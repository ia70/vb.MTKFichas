
Module VariablesGlobales
#Region "VARIABLES"

    '______________________________________________________________
#Region "Empresa" '------------------------------------------------
    Public Empresa_Nombre As String = ""
    Public Empresa_Logo As Bitmap
#End Region

    '______________________________________________________________
#Region "Mikrotik" '-----------------------------------------------
    Public Mikrotik_IP As String = ""
    Public Mikrotik_Usuario As String = ""
    Public Mikrotik_Password As String = ""
    Public Mikrotik_Puerto As Integer = 0
    Public Mikrotik_Dominio As String = "www.tuempresa.com"

    Public Mikrotik_Perfiles As New List(Of String)
#End Region

    '______________________________________________________________
#Region "Ficha" '-------------------------------------------------
    Public Ficha_Fondo As Bitmap
    Public Ficha_URL_Fondo As String = "img\fondo.jpg"
#End Region

    '______________________________________________________________
#Region "Data Base" '------------------------------------------
    Public DataBase_Nombre As String = "config\ApTdx.dll"
    Public DataBase_Password As String = "xcoru12345"
#End Region

    '______________________________________________________________
#Region "Configuración" '------------------------------------------
    Public Config_MostrarError As Boolean = False
    Public Config_BaseDeDatos_Connect As Boolean = True
    Public Config_Mikrotik_Connect As Boolean = False
#End Region

#End Region

End Module
