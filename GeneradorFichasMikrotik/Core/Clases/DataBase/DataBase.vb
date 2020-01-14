Imports System.Data.OleDb

''' <summary>
''' Clase de conexión a a Base de Datos Access 2010 .mdb
''' </summary>
Public Class DataBase
    'Cadena de conexión a la Base de Datos
    Private Conexion As OleDbConnection

    Public Sub New()
        Try
            Conexion = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" _
            & DataBase_Nombre & ";Jet OLEDB:Database Password=" & DataBase_Password & ";")
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "DataBase -> New")
            End If
        End Try
    End Sub

    ''' <summary>
    ''' Realiza Test de conexion a la base de datos
    ''' </summary>
    ''' <returns></returns>
    Public Function Test() As Boolean
        Try
            Conexion.Open()
            Conexion.Close()
            Return True
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "DataBase -> Test")
            End If
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Verifica conexíon con la Base de Datos
    ''' </summary>
    ''' <returns>
    ''' True - Si conexión correcta
    ''' False - Si conexión incorrecta
    ''' </returns>
    Public Function Estado() As Boolean
        Try
            Conexion.Open()
            Conexion.Close()
            Return False
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "DataBase -> Estado")
            End If
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Ejecuta una sentencia SQL 
    ''' </summary>
    ''' <param name="SQL">Sentencia SQL a Ejecutar</param>
    ''' <returns>DataTable</returns>
    Public Function Query(ByVal SQL As String) As String()
        Dim Comando As OleDbCommand
        Dim Leer As OleDbDataReader
        Dim i As Integer
        Dim Tabla(10) As String

        Try
            Conexion.Open()
            Comando = New OleDbCommand(SQL, Conexion)

            If SQL.Contains("UPDATE") Then
                If Comando.ExecuteNonQuery > 0 Then
                    Tabla(0) = "True"
                Else
                    Tabla(0) = ""
                End If
                Return Tabla
            End If

            Leer = Comando.ExecuteReader

            If Leer.HasRows Then
                Leer.Read()
                If Leer.Item(0).ToString = "False" Then
                    Tabla(0) = ""
                Else
                    For i = 0 To Leer.FieldCount - 1
                        Tabla(i) = Leer.Item(i).ToString
                    Next
                End If
            Else
                Tabla(0) = ""
            End If

            Leer.Close()
            Conexion.Close()
        Catch ex As Exception
            Conexion.Close()

            Tabla(0) = ""
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "DataBase -> Query")
            End If
        End Try

        Return Tabla
    End Function
End Class
