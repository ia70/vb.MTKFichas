Public Class DataBase_Mikrotik

    ''' <summary>
    ''' Carga información del disposito Mikrotik
    ''' </summary>
    ''' <returns>Cadena()</returns>
    Public Function Cargar() As String()
        Dim DB As New DataBase
        Dim Respuesta() As String

        Try
            Respuesta = DB.Query("SELECT * FROM mikrotik WHERE dispositivo=1")
            'dispositivo(0); ip(1); usuario(2); password(3); puerto(4); dominio(5)

        Catch ex As Exception
            Respuesta = Nothing
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "DataBase_Mikrotik -> Cargar")
            End If
        End Try
        Return Respuesta
    End Function

    ''' <summary>
    ''' Edita Configuración de dispositivo
    ''' </summary>
    ''' <param name="ip_">IP del dispositivo Mikrotik</param>
    ''' <param name="usuario_">Nombre de usuario</param>
    ''' <param name="pass_">Contraseña</param>
    ''' <param name="puerto_">Puerto</param>
    ''' <returns></returns>
    Public Function Editar(ByVal ip_ As String, ByVal usuario_ As String, ByVal pass_ As String, Optional ByVal dominio_ As String = "", Optional ByVal puerto_ As Integer = 8728) As Boolean
        Dim DB As New DataBase
        Dim Respuesta() As String

        If puerto_ = 0 Then
            puerto_ = 8728
        End If

        Try
            Respuesta = DB.Query("UPDATE mikrotik SET ip='" & ip_ & "', usuario='" & usuario_ & "', pass='" & pass_ & "', puerto=" & puerto_ & ", dominio_login='" & dominio_ & "' WHERE dispositivo=1")
            If Respuesta(0) = "" Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception

            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "DataBase_Mikrotik -> Editar")
            End If
            Return False
        End Try
    End Function
End Class
