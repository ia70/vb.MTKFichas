Public Class DataBase_Activacion

    ''' <summary>
    ''' Obtiene o establece Número de Serie
    ''' </summary>
    ''' <returns>Serial</returns>
    Public Property Serial() As String
        Get
            Return Cargar()
        End Get
        Set(value As String)
            Editar(value)
        End Set
    End Property

    ''' <summary>
    ''' Carga Numero de serie del programa
    ''' </summary>
    ''' <returns>String</returns>
    Private Function Cargar() As String
        Dim DB As New DataBase
        Dim Respuesta() As String

        Try
            Respuesta = DB.Query("SELECT * FROM activacion WHERE Id=1")
            If Respuesta(0) = "" Then
                Return ""
            Else
                Return Respuesta(1)
            End If
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "DataBase_Activacion -> Cargar")
            End If
            Return ""
        End Try
    End Function

    ''' <summary>
    ''' Editar Serie del programa
    ''' </summary>
    ''' <param name="Serie_">No. De Serie</param>
    ''' <returns>Boolean</returns>
    Private Function Editar(ByVal Serie_ As String) As Boolean
        Dim DB As New DataBase
        Dim Respuesta() As String

        Try
            Respuesta = DB.Query("UPDATE activacion SET serial='" & Serie_ & "' WHERE Id=1")
            If Respuesta(0) = "" Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "DataBase_Activacion -> Editar")
            End If
            Return False
        End Try
    End Function
End Class
