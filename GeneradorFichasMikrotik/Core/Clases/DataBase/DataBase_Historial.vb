Public Class DataBase_Historial

    ''' <summary>
    ''' Inserta registro al historial en la Base de Datos
    ''' </summary>
    ''' <param name="usuario_">Nombre de usuario</param>
    ''' <param name="password_">Contraseña</param>
    ''' <param name="plan_">Número de plan</param>
    ''' <returns></returns>
    Public Function Insertar(ByVal usuario_ As String, ByVal password_ As String, ByVal plan_ As String) As Boolean
        Dim DB As New DataBase()
        Dim fecha As String = Format(Date.Today, "yyyyMMdd")
        Dim Respuesta() As String
        Try
            Respuesta = DB.Query("INSERT INTO historial VALUES(" & Indice() & ", '" & usuario_ & "', '" & password_ & "', '" & plan_ & "', " & fecha & ")")
            If Respuesta(0) = "" Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "DataBase_Historial -> Insertar")
            End If
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Verifica si existe un ususrio
    ''' </summary>
    ''' <param name="usuario_">Nombre de usuario a verificar</param>
    ''' <returns>
    ''' True - Si existe
    ''' False - Si no existe
    ''' </returns>
    Public Function VerificarUsuario(ByVal usuario_ As String) As Boolean
        Dim DB As New DataBase
        Dim Respuesta() As String

        Try
            Respuesta = DB.Query("SELECT * FROM historial WHERE usuario ='" & usuario_ & "'")

            If Respuesta(0) = "" Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "DataBase_Historial -> VerificarUsuario")
            End If
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Elimina los registros de mas de un determinado tiempo de antiguedad
    ''' </summary>
    ''' <param name="Meses">Antiguedad de registros</param>
    ''' <returns>
    ''' True - Si elimino algun registro
    ''' False - Si no eliminó ningun registro
    ''' </returns>
    Public Function EliminarAntiguos(Optional ByVal Meses As Integer = 3) As Boolean
        Dim DB As New DataBase
        Dim Auxiliar As Integer = Meses
        Dim Respuesta() As String

        Dim Ano As Integer = Today.Date.Year
        Dim Mes As Integer = Today.Date.Month
        Dim Dia As Integer = Today.Date.Day
        Dim fecha As Date

        If Mes = Meses Then
            Ano -= 1
            Mes = 12
        ElseIf Mes < Meses Then
            Ano -= 1
            Auxiliar -= Mes
            Mes = 12 - Auxiliar
        Else
            Mes -= Meses
        End If

        fecha = New Date(Ano, Mes, Dia)
        Try
            Respuesta = DB.Query("DELETE FROM historial WHERE fecha <= " & fecha.ToString("yyyyMMdd") & " ;")
            If Respuesta(0) = "" Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "DataBase_Historial -> EliminarAntiguos")
            End If
            Return False
        End Try
    End Function

    'Obtiene el indice mas alto de la tabla y le suma 1 para insertar el nuevo registro
    Private Function Indice() As Integer
        Dim DB As New DataBase
        Dim Respuesta() As String
        Dim Numero As Integer

        Try
            Respuesta = DB.Query("SELECT MAX(Id) FROM historial")
            Numero = Val(Respuesta(0))
            Return Numero + 1
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "DataBase_Historial -> Indice")
            End If
            Return 0
        End Try
    End Function
End Class
