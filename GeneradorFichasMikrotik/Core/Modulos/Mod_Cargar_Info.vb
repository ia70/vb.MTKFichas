Module Mod_Cargar_Info

    'Carga toda la información del programa
    Public Sub Informacion_Cargar()
        Try
            Mikrotik_Cargar()
            Verificar_Mikrotik()

            Empresa_Cargar()
            Fichas_Cargar()
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "Mod_Cargar_Info -> Informacion_Cargar")
            End If
        End Try
    End Sub

    'Cargar Empresa
    Public Sub Empresa_Cargar()
        Try
            Dim DB As New DataBase_Empresa
            Dim Datos(10) As String

            If Config_BaseDeDatos_Connect Then
                Datos = DB.Cargar

                If Not Datos(0) = "" And Not Datos(1) = "" Then
                    Empresa_Nombre = Datos(1)
                    Empresa_Logo = Image.FromFile(Datos(2))
                End If
            End If
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "Mod_Cargar_Info -> Empresa_Cargar")
            End If
        End Try
    End Sub

    'Cargar Mikrotik
    Public Sub Mikrotik_Cargar()
        Try
            Dim DB As New DataBase_Mikrotik
            Dim Datos(10) As String
            If Config_BaseDeDatos_Connect Then
                Datos = DB.Cargar

                If Not Datos(0) = "" Then
                    Mikrotik_IP = Datos(1)
                    Mikrotik_Usuario = Datos(2)
                    Mikrotik_Password = Datos(3)
                    Mikrotik_Puerto = Datos(4)
                    Mikrotik_Dominio = Datos(5)
                End If

            End If

            'If Config_Mikrotik_Connect Then
            Mikrotik_Cargar_Perfiles()
            'End If
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "Mod_Cargar_Info -> Mikrotik_Cargar")
            End If
        End Try
    End Sub

    'Carga los perfiles existentes del Mikrotik
    Private Sub Mikrotik_Cargar_Perfiles()

        Dim MK As New MikrotikAPI
        Dim Estado As Boolean
        Dim Respuesta As New List(Of String)

        On Error Resume Next
        Estado = MK.Open(Mikrotik_IP, Mikrotik_Usuario, Mikrotik_Password, Mikrotik_Puerto)


        If Estado Then

            MK.Send("/ip/hotspot/user/profile/print", False)
            MK.Send("=.proplist=name", True)
            Respuesta = MK.Read()

            'MSG_("Respuesta 1:" & Respuesta.ToString, 1)
            'MSG_("Respuesta 2:" & Respuesta.ToString, 1)
            On Error Resume Next
            Mikrotik_Perfiles.Clear()

            For Each Row As String In Respuesta
                On Error Resume Next
                Mikrotik_Perfiles.Add(Row.Substring(9, Row.Length - 9))
            Next

            If Mikrotik_Perfiles.Count > 0 Then
                Config_Mikrotik_Connect = True
                On Error Resume Next
                GUI_Cargar_Mikrotik()
            Else
                Config_Mikrotik_Connect = False
            End If
        Else
            'If Config_MostrarError Then
            MSG_("No se pueden cargar los perfiles!", 2)
                'End If
            End If
    End Sub

    'Cargar Ficha
    Public Sub Fichas_Cargar()
        Try
            Dim DB As New DataBase_Ficha

            If Config_BaseDeDatos_Connect Then
                Ficha_URL_Fondo = DB.Fondo
            End If
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "Mod_Cargar_Info -> Fichas_Cargar")
            End If
        End Try
    End Sub

    'Cargar Activación
    Public Sub Activacion_Cargar()
        Try
            Dim DB As New DataBase_Activacion

            Verificar_DB()

            If Config_BaseDeDatos_Connect Then
                Activacion.DB_LicenciaEncode = DB.Serial
            End If
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "Mod_Cargar_Info -> Activacion_Cargar")
            End If
        End Try
    End Sub

    ' Mensaje de Información, Alerta y Error
    ''' <summary>
    ''' Muestra mensaje en pantalla
    ''' </summary>
    ''' <param name="Mensaje">Texto del mensaje</param>
    ''' <param name="Icono">0Info; 1Alert; 2Error; 3Quuestion</param>
    Public Sub MSG_(ByVal Mensaje As String, Optional ByVal Icono As Integer = 0, Optional ByVal Titulo As String = "")
        Dim Ico As Integer = 0

        Select Case Icono
            Case 0
                Ico = vbInformation
            Case 1
                Ico = vbExclamation
            Case 2
                Ico = vbCritical
            Case Else
                Ico = vbQuestion
        End Select
        If Titulo = "" Then
            MsgBox(Mensaje, vbOKOnly + Ico, Empresa_Nombre)
        Else
            MsgBox(Mensaje, vbOKOnly + Ico, Titulo)
        End If
    End Sub

    ''' <summary>
    ''' Verifica si existe conexion a la base de datos
    ''' </summary>
    ''' <returns></returns>
    Public Function Verificar_DB() As Boolean

        Try
            Dim DB As New DataBase
            Config_BaseDeDatos_Connect = DB.Test
            Return Config_BaseDeDatos_Connect
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "Mod_Cargar_Info -> Verificar_DB")
            End If
            Config_BaseDeDatos_Connect = False
            Return Config_BaseDeDatos_Connect
        End Try
    End Function

    ''' <summary>
    ''' Verifica si existe conexion a lal Mikrotik
    ''' </summary>
    ''' <returns></returns>
    Public Function Verificar_Mikrotik() As Boolean
        Try
            Dim MK As New MikrotikAPI

            If Config_BaseDeDatos_Connect Then
                Config_Mikrotik_Connect = MK.Open(Mikrotik_IP, Mikrotik_Usuario, Mikrotik_Password, Mikrotik_Puerto)
            Else
                Config_Mikrotik_Connect = False
            End If

            Return Config_Mikrotik_Connect
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "Mod_Cargar_Info -> Verificar_Mikrotik")
            End If
            Config_Mikrotik_Connect = False
            Return Config_Mikrotik_Connect
        End Try
    End Function

    Public Function VerificaRequerimientos() As Boolean
        Try
            Dim Respuesta As Boolean = True
            If Empresa_Nombre = "" Then
                Empresa_Nombre = "Generador de Fichas"
            End If

            If Not Verifica_Access() Then
                MSG_("Se requiere Microsoft Access 2003 o superior para funcionar!", 2)
                Respuesta = False
            End If

            If Not Verifica_AdobeReader() Then
                MSG_("Se requiere Adobe Reader para funcionar!", 2)
                Respuesta = False
            End If

            If Not Verifica_NetFramework() Then
                MSG_("Se requiere NetFramework 6.1 o superior!", 2)
                Respuesta = False
            End If

            If Not Verificar_DB() Then
                MSG_("No existe coneccion a la DB!", 2)
                Respuesta = False
            End If

            If Not Verificar_Mikrotik() Then
                MSG_("No existe conexión al dispositivo Mikrotik!", 2)
                Respuesta = False
            End If

            Return Respuesta
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "Mod_Cargar_Info -> VerificaRequerimientos")
            End If
            Return False
        End Try
    End Function

    Private Function Verifica_NetFramework() As Boolean
        Dim Version As Integer
        Try
            Version = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full", "Release", 0)

            If Version >= 394254 Then
                Return True
            End If

            Return False
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "Mod_Cargar_Info -> Verifica_NetFramework")
            End If
            Return False
        End Try
    End Function

    Private Function Verifica_Access() As Boolean
        Try
            Dim Objeto As Object
            ' -- Crear una referencia al objeto  
            Objeto = CreateObject("Access.Application")
            Objeto = Nothing
            Return True
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "Mod_Cargar_Info -> Verifica_Access")
            End If
            Return False
        End Try

    End Function

    Private Function Verifica_AdobeReader() As Boolean
        Try
            Dim PDF As New AxAcroPDFLib.AxAcroPDF
            Return True
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "Mod_Cargar_Info -> Verifica_AdobeReader")
            End If
            Return False
        End Try
    End Function

End Module
