Public Class GUI_Activacion_Generar_Solicitud
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim Serie As String
        Try
            Serie = Activacion.GetRequestCode

            If Serie.Length < 8 Then
                txtSolicitud.Text = ""
                MSG_("No se puede generar código de solicitud!", 1)
            Else
                MSG_("Solicitud generada exitosamente!")
                txtSolicitud.Text = Serie
                txtSolicitud.Enabled = True
            End If
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "GUI_Activacion_Generar_Solicitud")
            End If
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtSolicitud.Text = ""
        txtSolicitud.Enabled = False
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        GUI_Activacion.Show()
        Close()
    End Sub
End Class