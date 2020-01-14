Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class PDF_API
    'Componentes PDF ----------------------------------------------------------------------
    'Private Documento As New Document(PageSize.LETTER, 72, 72, 72, 72)
    'Private PDF_Writer As PdfWriter
    'Private PDF_Imagen As Image

    'Atributos PDF ------------------------------------------------------------------------
    Private AnchoHoja As Integer            'Ancho de hoja PDF
    Private AltoHoja As Integer             'Alto de hoja PDF
    Private EspacioHorizontal As Integer    'Espacion entre fichas Horizontalmente
    Private EspacioVertical As Integer      'Espacion entre fichas Verticalmente
    Private Imagen_Ancho As Integer         'Ancho de la imagen recibida
    Private Imagen_Alto As Integer          'Alto de la imagen recibida
    Private NombreArchivo As String         'Nombre del archivo temporal que se generará

    'Atributos de ejecución ---------------------------------------------------------------
    Private X As Integer                    'Posición actual en X
    Private Y As Integer                    'Posición actual en Y
    Private X_Inicio As Integer             'Posición de inicio de X, Espaciado lateral izquierdo
    Private NewPage As Boolean              'Indica si se debe crear una nueva pagina

    Public Sub New()
        Iniciar()
    End Sub

    'Inicializa los valores de Inicio de ejecución
    Private Sub Iniciar()
        NombreArchivo = "temp\Fichas.dll"
        AnchoHoja = 600
        AltoHoja = 630
        EspacioHorizontal = 5
        EspacioVertical = 5
        X_Inicio = 10
        X = X_Inicio
        Y = AltoHoja
        NewPage = False
    End Sub

    Public Function Generar(ByVal NoFichas As Integer, ByVal Perfil As String, Optional ByVal Pin_ As Boolean = True) As String
        Try
            'Componentes de documento PDF
            Dim Documento As New Document(PageSize.LETTER, 0, 0, 0, 0)
            Dim PDF_Writer As PdfWriter = Nothing


            Dim PDF_Imagen As Image
            Dim FichaBmp As Bitmap

            If Perfil = "" Or Perfil = Nothing Then
                Return ""
            End If

            Dim DB As New DataBase_Historial
            Dim MK As New Mikrotik(Mikrotik_IP, Mikrotik_Usuario, Mikrotik_Password, Mikrotik_Puerto)


            Dim Ficha_ As New Ficha(Empresa_Nombre, Mikrotik_Dominio, Ficha_URL_Fondo)
            Dim Datos(1) As String
            Dim i As Integer

            PDF_Writer = PdfWriter.GetInstance(Documento, New FileStream(NombreArchivo, FileMode.Create, FileAccess.Write, FileShare.None))


            Documento.Open()
            Documento.NewPage()

            'Tamaño de imagen en documento PDF segun escala adsoluta
            Imagen_Ancho = 190
            Imagen_Alto = 150


            For i = 1 To NoFichas

                If Pin_ Then
                    Datos(0) = GenerarPIN(5)
                Else
                    Datos = GenerarUsuario(5)
                End If


                If Pin_ Then
                    DB.Insertar(Datos(0), "-", Perfil)
                    MK.Insertar(Datos(0), "", "", Perfil)
                    FichaBmp = Ficha_.Generar(Datos(0))
                Else
                    DB.Insertar(Datos(0), "-", Perfil)
                    MK.Insertar(Datos(0), Datos(1), "", Perfil)
                    FichaBmp = Ficha_.Generar(Datos(0), Datos(1))
                End If

                'Base de datos y Mikrotik


                If NewPage Then
                    Documento.NewPage()
                    NewPage = False
                End If

                PDF_Imagen = Image.GetInstance(FichaBmp, Imaging.ImageFormat.Bmp)
                'PDF_Imagen.ScalePercent(Escala)
                PDF_Imagen.ScaleAbsolute(Imagen_Ancho, Imagen_Alto)


                PDF_Imagen.SetAbsolutePosition(X, Y)
                GenerarPosicion()

                Documento.Add(PDF_Imagen)
            Next

            PDF_Writer.Flush()
            Documento.Close()

            PDF_Writer = Nothing
            Documento = Nothing

            Return NombreArchivo
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "PDF_API -> Generar")
            End If
            NombreArchivo = Nothing
            Return NombreArchivo
        End Try
    End Function

    Private Function GenerarUsuario(ByVal Longitud_ As Integer) As String()
        Try
            Dim DB As New DataBase_Historial
            Dim Random As New Random()
            Dim Datos(1) As String

            Do
                Datos(0) = Random.Next(10000, 99999)
            Loop While DB.VerificarUsuario(Datos(0))

            Datos(1) = Random.Next(10000, 99999)

            Return Datos
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "PDF_API -> GenerarUsuario")
            End If
            Return Nothing
        End Try
    End Function

    Private Function GenerarPIN(ByVal Longitud_ As Integer) As String
        Try
            Dim DB As New DataBase_Historial
            Dim Random As New Random()
            Dim Datos As String

            Do
                Datos = Random.Next(10000, 99999)
            Loop While DB.VerificarUsuario(Datos)

            Return Datos
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "PDF_API -> GenerarPIN")
            End If
            Return ""
        End Try
    End Function

    'Genera la siguiente posicion de X y Y
    Private Sub GenerarPosicion()
        Try
            X += Imagen_Ancho + EspacioHorizontal
            If (X + Imagen_Ancho) > AnchoHoja Then
                X = X_Inicio
                Y -= (Imagen_Alto + EspacioVertical)

                If Y < 10 Then
                    Y = AltoHoja
                    NewPage = True
                End If
            End If
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "PDF_API -> GenerarPsicion")
            End If
        End Try
    End Sub

    'Termina edición de documento.
    Public Function EndDoc() As String
        Return NombreArchivo
    End Function

End Class
