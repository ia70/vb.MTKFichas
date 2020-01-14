
Imports System.IO

Public Class Ficha
#Region "Declaraciones - Componentes"
    Private Contenedor As New Panel             'Contener principal
    Private QR As New PictureBox                'PictureBox con código QR
    Private Label_Empresa As New Label          'Nombre de la empresa
    Private Label_Usuario As New Label          'Etiqueta Usuario
    Private Label_txtUsuario As New Label       'Usuario de Mikrotik
    Private Label_Password As New Label         'Etiqueta Password
    Private Label_txtPassword As New Label      'Password de Mikrotik
    Private Label_PIN As New Label              'Pin de Mikrotik
    Private Label_txtPIN As New Label           'Password de Mikrotik
#End Region
#Region "Declaraciones - Atributos"
    Private _NombreEmpresa As String = ""       'Npmbre de Empresa
    Private _Fondo As Bitmap = Nothing          'Imagen de fondo
    Private _URLImagenDeFondo As String = ""    'URL de imagen de fondo
    Private _Dominio As String              'Dirección IP ó Dominio del dispositivo
#End Region
#Region "Propiedades"
    Public Property Empresa() As String
        Get
            Return _NombreEmpresa
        End Get
        Set(ByVal Value As String)
            _NombreEmpresa = Value
        End Set
    End Property

    Public Property ImagenDeFondo() As Bitmap
        Get
            Return _Fondo
        End Get
        Set(ByVal value As Bitmap)
            _Fondo = value
        End Set
    End Property

    Public Property URLImagenFondo() As String
        Get
            Return _URLImagenDeFondo
        End Get
        Set(ByVal value As String)
            If File.Exists(value) Then
                _URLImagenDeFondo = value
            End If
        End Set
    End Property

    Public Property Dominio() As String
        Get
            Return _Dominio
        End Get
        Set(ByVal value As String)
            _Dominio = value
        End Set
    End Property
#End Region
#Region "Constructores de Clase"
    Public Sub New()
        IniciarComponentes()
    End Sub

    Public Sub New(ByVal NombreEmpresa_ As String)
        _NombreEmpresa = NombreEmpresa_
        IniciarComponentes()
    End Sub

    Public Sub New(ByVal NombreEmpresa_ As String, ByVal URLMikrotik__ As String)
        _NombreEmpresa = NombreEmpresa_
        _Dominio = URLMikrotik__
        IniciarComponentes()
    End Sub

    Public Sub New(ByVal NombreEmpresa_ As String, ByVal URLMikrotik__ As String, ByVal Fondo_ As Bitmap)
        _NombreEmpresa = NombreEmpresa_
        _Dominio = URLMikrotik__
        _Fondo = Fondo_
        IniciarComponentes()
    End Sub

    Public Sub New(ByVal NombreEmpresa_ As String, ByVal URLMikrotik__ As String, ByVal Fondo_ As String)
        _NombreEmpresa = NombreEmpresa_
        _Dominio = URLMikrotik__
        If File.Exists(Fondo_) Then
            _URLImagenDeFondo = Fondo_
        End If
        IniciarComponentes()
    End Sub

    Private Sub IniciarComponentes()
        'Creación de diseño de ficha -----------------------------------------------------------------------------------
        Try
            'Contenedor principal --------------------------------------
            With Contenedor
                .Size = New Size(255, 200)
                .BorderStyle = BorderStyle.Fixed3D
                .BackColor = Color.Beige
                .BackgroundImageLayout = ImageLayout.Stretch
            End With

            'PictureBox QR ---------------------------------------------
            With QR
                .Size = New Size(80, 80)
                .BackColor = Color.White
                .SizeMode = PictureBoxSizeMode.StretchImage
            End With

            'Label_Empresa ---------------------------------------------
            With Label_Empresa
                .AutoSize = False
                .Size = New Size(234, 39)
                .BackColor = Color.Transparent
                .Font = New Font(New FontFamily("Arial"), 14, FontStyle.Bold, GraphicsUnit.Point)
                .TextAlign = ContentAlignment.MiddleCenter
                .ForeColor = Color.Black
                .BorderStyle = BorderStyle.Fixed3D
                .Text = "Nombre Empresa"
            End With

            'Label_Usuario ---------------------------------------------
            With Label_Usuario
                .AutoSize = False
                .Size = New Size(101, 27)
                .BackColor = Color.Transparent
                .Font = New Font(New FontFamily("Arial"), 12, FontStyle.Bold, GraphicsUnit.Point)
                .TextAlign = ContentAlignment.MiddleCenter
                .ForeColor = Color.Black
                .Text = "Usuario:"
                .Visible = False
            End With

            'Label_txtUsuario ------------------------------------------
            With Label_txtUsuario
                .AutoSize = False
                .Size = New Size(101, 29)
                .BackColor = Color.Transparent
                .Font = New Font(New FontFamily("Arial"), 14, FontStyle.Bold, GraphicsUnit.Point)
                .TextAlign = ContentAlignment.MiddleCenter
                .ForeColor = Color.Blue
                .BorderStyle = BorderStyle.FixedSingle
                .Visible = False
            End With

            'Label_Password --------------------------------------------
            With Label_Password
                .AutoSize = False
                .Size = New Size(101, 27)
                .BackColor = Color.Transparent
                .Font = New Font(New FontFamily("Arial"), 12, FontStyle.Bold, GraphicsUnit.Point)
                .TextAlign = ContentAlignment.MiddleCenter
                .ForeColor = Color.Black
                .Text = "Password:"
                .Visible = False
            End With

            'Label_txtPassword -----------------------------------------
            With Label_txtPassword
                .AutoSize = False
                .Size = New Size(101, 29)
                .BackColor = Color.Transparent
                .Font = New Font(New FontFamily("Arial"), 14, FontStyle.Bold, GraphicsUnit.Point)
                .TextAlign = ContentAlignment.MiddleCenter
                .ForeColor = Color.Blue
                .BorderStyle = BorderStyle.FixedSingle
                .Visible = False
            End With

            'Label_PIN -------------------------------------------------
            With Label_PIN
                .AutoSize = False
                .Size = New Size(101, 20)
                .BackColor = Color.Transparent
                .Font = New Font(New FontFamily("Arial"), 12, FontStyle.Bold, GraphicsUnit.Point)
                .TextAlign = ContentAlignment.MiddleCenter
                .ForeColor = Color.Black
                .Text = "PIN:"
                .Visible = False
            End With

            'Label_txtPIN ----------------------------------------------
            With Label_txtPIN
                .AutoSize = False
                .Size = New Size(101, 22)
                .BackColor = Color.Transparent
                .Font = New Font(New FontFamily("Arial"), 14, FontStyle.Bold, GraphicsUnit.Point)
                .TextAlign = ContentAlignment.MiddleCenter
                .ForeColor = Color.Blue
                .BorderStyle = BorderStyle.FixedSingle
                .Visible = False
            End With

            'Uniendo todos los componentes -------------------------------------------------------------------------------
            With Contenedor.Controls
                .Add(QR)
                .Add(Label_Empresa)
                .Add(Label_Usuario)
                .Add(Label_txtUsuario)
                .Add(Label_Password)
                .Add(Label_txtPassword)
                .Add(Label_PIN)
                .Add(Label_txtPIN)
            End With

            'Ordenando Componentes ---------------------------------------------------------------------------------------
            Label_Empresa.Location = New Point(9, 6)
            Label_Usuario.Location = New Point(142, 50)
            Label_txtUsuario.Location = New Point(142, 77)
            Label_Password.Location = New Point(142, 119)
            Label_txtPassword.Location = New Point(142, 146)
            Label_PIN.Location = New Point(142, 82)
            Label_txtPIN.Location = New Point(142, 109)
            QR.Location = New Point(11, 72)
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "Ficha -> IniciarComponentes")
            End If
        End Try
    End Sub
#End Region
    Public Function Generar(ByVal PIN_ As String) As Bitmap
        Try
            Dim ima = New Bitmap(Contenedor.Width, Contenedor.Height)
            Dim _QR As New QRcode()

            If _NombreEmpresa = "" Then
                _NombreEmpresa = "www.xcoru.com"
            End If

            If _Dominio = "" Then
                _Dominio = "www.xcoru.com"
            End If

            If Not _URLImagenDeFondo = "" Then
                Contenedor.BackgroundImage = Image.FromFile(_URLImagenDeFondo)
            End If

            If _Fondo IsNot Nothing Then
                Contenedor.BackgroundImage = _Fondo
            End If

            'Habilitando componentes ----------------------------------------
            Label_PIN.Visible = True
            Label_txtPIN.Visible = True

            'Llenado información de ficha -----------------------------------
            QR.Image = _QR.GenerarQR(_Dominio & "/acceso.html?usr=" & PIN_ & "&pwd=")
            Label_Empresa.Text = _NombreEmpresa
            Label_txtPIN.Text = PIN_

            'Generando BitMap ------------------------------------------------
            Contenedor.DrawToBitmap(ima, New Rectangle(0, 0, Contenedor.Width, Contenedor.Height))
            Return ima
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "Ficha -> Generar-01")
            End If
            Return Nothing
        End Try
    End Function

    Public Function Generar(ByVal Usuario_ As String, ByVal Password_ As String) As Bitmap
        Try
            Dim ima = New Bitmap(Contenedor.Width, Contenedor.Height)
            Dim _QR As New QRcode()

            If _NombreEmpresa = "" Then
                _NombreEmpresa = "www.xcoru.com"
            End If

            If _Dominio = "" Then
                _Dominio = "www.xcoru.com"
            End If

            If Not _URLImagenDeFondo = "" Then
                Contenedor.BackgroundImage = Image.FromFile(_URLImagenDeFondo)
            End If

            If _Fondo IsNot Nothing Then
                Contenedor.BackgroundImage = _Fondo
            End If

            'Habilitando componentes ----------------------------------------
            Label_Usuario.Visible = True
            Label_txtUsuario.Visible = True
            Label_Password.Visible = True
            Label_txtPassword.Visible = True

            'Llenado información de ficha -----------------------------------
            QR.Image = _QR.GenerarQR(_Dominio & "/acceso.html?usr=" & Usuario_ & "&pwd=" & Password_)
            Label_Empresa.Text = _NombreEmpresa
            Label_txtUsuario.Text = Usuario_
            Label_txtPassword.Text = Password_

            'Generando BitMap ------------------------------------------------
            Contenedor.DrawToBitmap(ima, New Rectangle(0, 0, Contenedor.Width, Contenedor.Height))
            Return ima
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "Ficha -> Generar-02")
            End If
            Return Nothing
        End Try
    End Function
End Class
