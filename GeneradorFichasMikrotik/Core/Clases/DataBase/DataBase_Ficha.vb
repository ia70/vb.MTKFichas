Public Class DataBase_Ficha

    ''' <summary>
    ''' Obtiene / Actualiza la URL del fondo de la ficha
    ''' </summary>
    ''' <returns>URL del fondo</returns>
    Public Property Fondo As String
        Get
            Return Cargar()
        End Get
        Set(value As String)
            Editar(value)
        End Set
    End Property

    ''' <summary>
    ''' Carga URL de imagen de fondo
    ''' </summary>
    ''' <returns>String</returns>
    Private Function Cargar() As String
        Dim DB As New DataBase
        Dim Respuesta(10) As String

        Try
            Respuesta = DB.Query("SELECT * FROM ficha WHERE Id=1")
            If Respuesta(0) = "" Then
                Return ""
            Else
                Return Respuesta(1)
            End If
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "DataBase_Ficha -> Cargar")
            End If
            Return ""
        End Try
    End Function

    ''' <summary>
    ''' Editar URL  de imagen de fondo de la ficha en la base de datos
    ''' </summary>
    ''' <param name="fondo_">No. De Serie</param>
    ''' <returns>Boolean</returns>
    Private Function Editar(ByVal fondo_ As String) As Boolean
        Dim DB As New DataBase
        Dim Respuesta() As String

        Try
            Respuesta = DB.Query("UPDATE ficha SET fondo='" & fondo_ & "' WHERE Id=1")
            If Respuesta(0) = "" Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "DataBase_Ficha -> Editar")
            End If
            Return False
        End Try
    End Function
End Class
