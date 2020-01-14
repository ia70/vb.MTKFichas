
Public Class Pruebas
    Private Estado As Boolean = False
    Private MK As MikrotikAPI

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Dim Respuesta As Boolean

        Respuesta = Abrir()

        If Respuesta Then
            MsgBox("Conexión estableciada correctamente!", vbInformation)
        Else
            MsgBox("Error de conexión!", vbExclamation)
        End If

    End Sub

    Private Function Abrir() As Boolean
        Dim Respuesta As Boolean

        If Not Estado Then
            MK = New MikrotikAPI
            Respuesta = MK.Open(txtIP.Text, txtUsuario.Text, txtPassword.Text, Val(txtPuerto.Text))
            If Respuesta Then
                Estado = True
            Else
                Estado = False
            End If
        End If

        Return Estado
    End Function

    Private Sub btnCargarPerfiles_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        If Estado Then
            MK.Send(txtComando.Text, False)
            txtComando.Text = "=.proplist=name"
            txtComando.Select()
        Else
            MSG_("Coneción cerrada!", 2)
            End If
    End Sub

    Private Sub btnFin_Click(sender As Object, e As EventArgs) Handles btnFin.Click
        Dim Respuesta As New List(Of String)

        If Estado Then
            On Error Resume Next
            MK.Send(txtComando.Text, True)
            txtComando.Text = "/ip/hotspot/user/profile/print"
            txtComando.Select()

            Lista.Text = ""

            On Error Resume Next
            Respuesta = MK.Read()

            For Each Row As String In Respuesta
                On Error Resume Next
                Lista.Text = Lista.Text + Row.Substring(9, Row.Length - 9) + vbCrLf
            Next

            On Error Resume Next
        Else
            MsgBox("Error de conexión!", vbExclamation)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'VerificaRequerimientos()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error Resume Next
        MK.Close()
        Estado = False

        MSG_("Conexión cerrada!")
    End Sub

    Private Sub txtIP_TextChanged(sender As Object, e As EventArgs) Handles txtIP.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Lista.Text = ""
    End Sub
End Class