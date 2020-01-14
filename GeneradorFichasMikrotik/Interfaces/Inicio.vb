Public Class Inicio


    Private Sub btnGenerarFichas_Click(sender As Object, e As EventArgs) Handles btnGenerarFichas.Click
        Dim PDF As New PDF_API
        Try
            If txtTipoFicha.SelectedIndex = 0 Then
                VisorPDF.LoadFile(PDF.Generar(txtNumeroDeFichas.Value, txtPerfil.SelectedItem))
            Else
                VisorPDF.LoadFile(PDF.Generar(txtNumeroDeFichas.Value, txtPerfil.SelectedItem, False))
            End If
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "GUI_Inicio")
            End If

        End Try
        'MsgBox(txtPerfil.SelectedItem)
    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles Me.Load
        On Error Resume Next
        txtTipoFicha.SelectedIndex = 0
        On Error Resume Next
        txtPerfil.SelectedIndex = 0

    End Sub

    Private Sub TInicio_Tick(sender As Object, e As EventArgs) Handles TInicio.Tick
        Try
            VisorPDF.LoadFile("config\adojkll.dll")
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "GUI_Inicio")
            End If

        End Try
        TInicio.Enabled = False
    End Sub

    Private Sub txtTipoFicha_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtTipoFicha.SelectedIndexChanged
        Dim Ficha_ As Ficha
        Try
            Ficha_ = New Ficha(Empresa_Nombre, Mikrotik_Dominio, Ficha_URL_Fondo)

            If txtTipoFicha.SelectedIndex = 0 Then
                picPreVisualizacion.Image = Ficha_.Generar("12345")
            Else
                picPreVisualizacion.Image = Ficha_.Generar("12345", "11111")
            End If
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "GUI_Inicio")
            End If

        End Try

    End Sub

    Private Sub btnEmpresa_Click(sender As Object, e As EventArgs) Handles btnEmpresa.Click
        GUI_Empresa.Show()
    End Sub

    Private Sub btnMikrotik_Click(sender As Object, e As EventArgs) Handles btnMikrotik.Click
        GUI_Mikrotik.Show()
    End Sub

    Private Sub btnFicha_Click(sender As Object, e As EventArgs) Handles btnFicha.Click
        GUI_Ficha.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim PDF As New PDF_API

        On Error Resume Next
        VisorPDF.LoadFile(PDF.Generar(4, "1_Hora", False))

    End Sub

    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        MsgBox("Se precederá a analizar si el programa cuenta con todos los requerimientos necesarios para su funcionamiento!", vbInformation + vbOKOnly, "Verificar Requerimientos del Programa")
        VerificaRequerimientos()
    End Sub
End Class
