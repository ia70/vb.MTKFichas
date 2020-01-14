Public Class GUI_Activacion_Activar
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtRespuesta.Text = ""

        txtRespuesta.Select()
    End Sub

    Private Sub btnActivar_Click(sender As Object, e As EventArgs) Handles btnActivar.Click
        Dim Activacion_ As Boolean = False

        Try
            Activacion_ = Activacion.Activar_Prodcuto(txtRespuesta.Text)
            Dim DB As New DataBase_Activacion

            If Activacion_ Then
                DB.Serial = txtRespuesta.Text
                MSG_("Se ha activado el producto correctamente!")
                txtRespuesta.Text = ""
                GUI_Cargar_Todo()
                Inicio.Show()
                Close()
            Else
                MSG_("Lincencia incorrecta!", 1)
                txtRespuesta.Text = ""
                txtRespuesta.Select()
            End If
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "GUI_Activacion_Activar")
            End If
            If Activacion_ Then
                Inicio.Show()
                Close()
            End If
        End Try
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        GUI_Activacion.Show()
        Close()
    End Sub
End Class