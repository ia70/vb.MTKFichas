Public Class GUI_Mikrotik
    Private IP, Usuario, Pass, Puerto, Dominio As String
    Private Estado As Boolean

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtIP.Text = ""
        txtUsuario.Text = ""
        txtPassword.Text = ""
        txtPuerto.Text = ""
        txtDominio.Text = ""
        txtIP.Select()
    End Sub

    Private Sub btnPruebas_Click(sender As Object, e As EventArgs) Handles btnPruebas.Click
        Pruebas.Show()
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Try
            Dim MK As New Mikrotik()

            LlenarDatos()

            If IP = "" Or Usuario = "" Or Pass = "" Then
                MSG_("Datos incompletos!", 1)
            Else
                Estado = MK.Open(IP, Usuario, Pass, Val(Puerto))
                If Estado Then
                    MK.Close()
                    Config_Mikrotik_Connect = True
                    MSG_("Conexión establecida correctamente!")
                Else
                    MSG_("Error de conexión!", 2)
                End If
            End If
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "GUI_Mikrotik")
            End If
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim DB As New DataBase_Mikrotik
        LlenarDatos()

        Estado = DB.Editar(IP, Usuario, Pass, Dominio, Val(Puerto))

        If Estado Then
            MSG_("Información guardada correctamente!")
        Else
            MSG_("Error al intentar guardar!", 2)
        End If

        On Error Resume Next
        Mikrotik_Cargar()
        'On Error Resume Next
        'Verificar_Mikrotik()
        On Error Resume Next
        GUI_Cargar_Mikrotik()

    End Sub

    Private Sub LlenarDatos()
        IP = txtIP.Text
        Usuario = txtUsuario.Text
        Pass = txtPassword.Text
        Puerto = txtPuerto.Text
        Dominio = txtDominio.Text
    End Sub

    Private Sub GUI_Mikrotik_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtIP.Text = Mikrotik_IP
        txtUsuario.Text = Mikrotik_Usuario
        txtPassword.Text = Mikrotik_Password
        txtPuerto.Text = Mikrotik_Puerto
        txtDominio.Text = Mikrotik_Dominio
    End Sub
End Class