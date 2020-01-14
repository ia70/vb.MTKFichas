Public Class DataBase_Empresa

    ''' <summary>
    ''' Carga información de la Empresa
    ''' </summary>
    ''' <returns>DataTable</returns>
    Public Function Cargar() As String()
        Dim DB As New DataBase
        Dim Respuesta() As String = Nothing

        Try
            Respuesta = DB.Query("SELECT * FROM empresa WHERE Id=1")
            'Id(0); nombre(1); logo(2); 
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "DataBase_Empresa -> Cargar")
            End If
        End Try
        Return Respuesta
    End Function

    ''' <summary>
    ''' Actualiza información de Empresa
    ''' </summary>
    ''' <param name="nombre_"></param>
    ''' <param name="logo_"></param>
    ''' <returns>Boolean</returns>
    Public Function Editar(ByVal nombre_ As String, Optional ByVal logo_ As String = "") As Boolean
        Dim DB As New DataBase
        Dim Respuesta() As String

        Try
            Respuesta = DB.Query("UPDATE empresa SET nombre='" & nombre_ & "', logo='" & logo_ & "' WHERE Id=1")
            If Respuesta(0) = "" Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "DataBase_Empresa -> Editar")
            End If
            Return False
        End Try
    End Function
End Class
