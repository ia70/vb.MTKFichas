Module Mod_GUI_Conexion
    Public Sub GUI_Cargar_Todo()
        Try
            Informacion_Cargar()

            GUI_Cargar_Empresa()
            GUI_Cargar_Ficha()
            'GUI_Cargar_Mikrotik()
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "Mod_GUI_Conexion -> GUI_Cargar_Todo")
            End If
        End Try
    End Sub
    Public Sub GUI_Cargar_Empresa()
        On Error Resume Next
        Inicio.picLogo.Image = Empresa_Logo
    End Sub
    Public Sub GUI_Cargar_Ficha(Optional ByVal Ima As Boolean = False)
        Try
            Fichas_Cargar()

            Dim Ficha_ As Ficha

            If (Ima) Then
                Ficha_ = New Ficha(Empresa_Nombre, Mikrotik_Dominio, "img\fondo.jpg")
            Else
                Ficha_ = New Ficha(Empresa_Nombre, Mikrotik_Dominio, Ficha_URL_Fondo)
            End If

            Inicio.picPreVisualizacion.Image = Ficha_.Generar("12345")
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "Mod_GUI_Conexion -> Cargar_Ficha")
            End If
        End Try

    End Sub
    Public Sub GUI_Cargar_Mikrotik()
        'Mikrotik_Cargar()
        'On Error Resume Next
        'MSG_(Mikrotik_Perfiles.ToArray.ToString)

        If Mikrotik_Perfiles.Count > 0 Then

            On Error Resume Next
            Inicio.txtPerfil.Items.Clear()

            For Each row As String In Mikrotik_Perfiles
                On Error Resume Next
                Inicio.txtPerfil.Items.Add(row)
            Next

            Inicio.btnGenerarFichas.Enabled = True
            Inicio.txtTipoFicha.Enabled = True
            Inicio.txtPerfil.Enabled = True
            Inicio.txtNumeroDeFichas.Enabled = True

            On Error Resume Next
            Inicio.txtPerfil.SelectedIndex = 0
        Else
            Inicio.btnGenerarFichas.Enabled = False
            Inicio.txtTipoFicha.Enabled = False
            Inicio.txtPerfil.Enabled = False
            Inicio.txtNumeroDeFichas.Enabled = False
        End If
    End Sub

End Module
