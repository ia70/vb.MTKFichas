<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Contenedor = New System.Windows.Forms.Panel()
        Me.VisorPDF = New AxAcroPDFLib.AxAcroPDF()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MarcadeAgua = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnGenerarFichas = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.picPreVisualizacion = New System.Windows.Forms.PictureBox()
        Me.txtNumeroDeFichas = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPerfil = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTipoFicha = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TInicio = New System.Windows.Forms.Timer(Me.components)
        Me.ToolInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.btnFicha = New System.Windows.Forms.Button()
        Me.btnMikrotik = New System.Windows.Forms.Button()
        Me.btnEmpresa = New System.Windows.Forms.Button()
        Me.Encabezado = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Contenedor.SuspendLayout()
        CType(Me.VisorPDF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MarcadeAgua.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.picPreVisualizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroDeFichas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Encabezado.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp"
        Me.OpenFileDialog1.Title = "Imágen"
        '
        'Contenedor
        '
        Me.Contenedor.Controls.Add(Me.VisorPDF)
        Me.Contenedor.Controls.Add(Me.Panel1)
        Me.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Contenedor.Location = New System.Drawing.Point(0, 133)
        Me.Contenedor.Name = "Contenedor"
        Me.Contenedor.Size = New System.Drawing.Size(1069, 670)
        Me.Contenedor.TabIndex = 10
        '
        'VisorPDF
        '
        Me.VisorPDF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VisorPDF.Enabled = True
        Me.VisorPDF.Location = New System.Drawing.Point(254, 0)
        Me.VisorPDF.Name = "VisorPDF"
        Me.VisorPDF.OcxState = CType(resources.GetObject("VisorPDF.OcxState"), System.Windows.Forms.AxHost.State)
        Me.VisorPDF.Size = New System.Drawing.Size(815, 670)
        Me.VisorPDF.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.GeneradorFichasMikrotik.My.Resources.Resources.Textura
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.MarcadeAgua)
        Me.Panel1.Controls.Add(Me.btnGenerarFichas)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.txtNumeroDeFichas)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtPerfil)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtTipoFicha)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(254, 670)
        Me.Panel1.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(112, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 25)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'MarcadeAgua
        '
        Me.MarcadeAgua.BackColor = System.Drawing.Color.Transparent
        Me.MarcadeAgua.Controls.Add(Me.PictureBox2)
        Me.MarcadeAgua.Controls.Add(Me.Label6)
        Me.MarcadeAgua.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MarcadeAgua.Location = New System.Drawing.Point(0, 620)
        Me.MarcadeAgua.Name = "MarcadeAgua"
        Me.MarcadeAgua.Size = New System.Drawing.Size(250, 46)
        Me.MarcadeAgua.TabIndex = 15
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.GeneradorFichasMikrotik.My.Resources.Resources.xcoru
        Me.PictureBox2.Location = New System.Drawing.Point(5, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(1, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "xcoru"
        '
        'btnGenerarFichas
        '
        Me.btnGenerarFichas.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnGenerarFichas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGenerarFichas.Enabled = False
        Me.btnGenerarFichas.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarFichas.ForeColor = System.Drawing.Color.Transparent
        Me.btnGenerarFichas.Location = New System.Drawing.Point(12, 9)
        Me.btnGenerarFichas.Name = "btnGenerarFichas"
        Me.btnGenerarFichas.Size = New System.Drawing.Size(217, 52)
        Me.btnGenerarFichas.TabIndex = 8
        Me.btnGenerarFichas.Text = "Generar fichas"
        Me.btnGenerarFichas.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.picPreVisualizacion)
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(12, 335)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(213, 216)
        Me.Panel2.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(18, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 22)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Pre visualización:"
        '
        'picPreVisualizacion
        '
        Me.picPreVisualizacion.BackgroundImage = Global.GeneradorFichasMikrotik.My.Resources.Resources.Textura
        Me.picPreVisualizacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPreVisualizacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPreVisualizacion.Location = New System.Drawing.Point(5, 50)
        Me.picPreVisualizacion.Name = "picPreVisualizacion"
        Me.picPreVisualizacion.Size = New System.Drawing.Size(203, 159)
        Me.picPreVisualizacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPreVisualizacion.TabIndex = 0
        Me.picPreVisualizacion.TabStop = False
        '
        'txtNumeroDeFichas
        '
        Me.txtNumeroDeFichas.Enabled = False
        Me.txtNumeroDeFichas.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroDeFichas.Location = New System.Drawing.Point(12, 281)
        Me.txtNumeroDeFichas.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.txtNumeroDeFichas.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtNumeroDeFichas.Name = "txtNumeroDeFichas"
        Me.txtNumeroDeFichas.Size = New System.Drawing.Size(213, 32)
        Me.txtNumeroDeFichas.TabIndex = 5
        Me.txtNumeroDeFichas.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.AliceBlue
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(12, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(213, 31)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Numero de Fichas:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPerfil
        '
        Me.txtPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtPerfil.Enabled = False
        Me.txtPerfil.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPerfil.FormattingEnabled = True
        Me.txtPerfil.Location = New System.Drawing.Point(12, 195)
        Me.txtPerfil.Name = "txtPerfil"
        Me.txtPerfil.Size = New System.Drawing.Size(213, 32)
        Me.txtPerfil.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.AliceBlue
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(13, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Perfil Mikrotik:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTipoFicha
        '
        Me.txtTipoFicha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtTipoFicha.Enabled = False
        Me.txtTipoFicha.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoFicha.FormattingEnabled = True
        Me.txtTipoFicha.Items.AddRange(New Object() {"PIN", "Normal"})
        Me.txtTipoFicha.Location = New System.Drawing.Point(12, 106)
        Me.txtTipoFicha.Name = "txtTipoFicha"
        Me.txtTipoFicha.Size = New System.Drawing.Size(213, 32)
        Me.txtTipoFicha.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.AliceBlue
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(13, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tipo de ficha:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TInicio
        '
        Me.TInicio.Enabled = True
        Me.TInicio.Interval = 2000
        '
        'ToolInfo
        '
        Me.ToolInfo.AutoPopDelay = 5000
        Me.ToolInfo.InitialDelay = 500
        Me.ToolInfo.ReshowDelay = 100
        Me.ToolInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolInfo.ToolTipTitle = "Información"
        '
        'btnVerificar
        '
        Me.btnVerificar.BackgroundImage = Global.GeneradorFichasMikrotik.My.Resources.Resources.checklist
        Me.btnVerificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVerificar.Location = New System.Drawing.Point(64, 70)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(55, 55)
        Me.btnVerificar.TabIndex = 3
        Me.btnVerificar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolInfo.SetToolTip(Me.btnVerificar, "Verificar Requerimientos del Programa")
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'btnFicha
        '
        Me.btnFicha.BackgroundImage = Global.GeneradorFichasMikrotik.My.Resources.Resources.tarjeta
        Me.btnFicha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFicha.Location = New System.Drawing.Point(3, 70)
        Me.btnFicha.Name = "btnFicha"
        Me.btnFicha.Size = New System.Drawing.Size(55, 55)
        Me.btnFicha.TabIndex = 2
        Me.ToolInfo.SetToolTip(Me.btnFicha, "Configurar Ficha")
        Me.btnFicha.UseVisualStyleBackColor = True
        '
        'btnMikrotik
        '
        Me.btnMikrotik.BackgroundImage = Global.GeneradorFichasMikrotik.My.Resources.Resources.dispositivo
        Me.btnMikrotik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMikrotik.Location = New System.Drawing.Point(64, 11)
        Me.btnMikrotik.Name = "btnMikrotik"
        Me.btnMikrotik.Size = New System.Drawing.Size(55, 55)
        Me.btnMikrotik.TabIndex = 1
        Me.ToolInfo.SetToolTip(Me.btnMikrotik, "Configurar Mikrotik")
        Me.btnMikrotik.UseVisualStyleBackColor = True
        '
        'btnEmpresa
        '
        Me.btnEmpresa.BackgroundImage = Global.GeneradorFichasMikrotik.My.Resources.Resources.empresa
        Me.btnEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEmpresa.Location = New System.Drawing.Point(3, 12)
        Me.btnEmpresa.Name = "btnEmpresa"
        Me.btnEmpresa.Size = New System.Drawing.Size(55, 55)
        Me.btnEmpresa.TabIndex = 0
        Me.ToolInfo.SetToolTip(Me.btnEmpresa, "Configurar empresa")
        Me.btnEmpresa.UseVisualStyleBackColor = True
        '
        'Encabezado
        '
        Me.Encabezado.BackgroundImage = Global.GeneradorFichasMikrotik.My.Resources.Resources.Textura
        Me.Encabezado.Controls.Add(Me.Panel3)
        Me.Encabezado.Controls.Add(Me.picLogo)
        Me.Encabezado.Controls.Add(Me.Label1)
        Me.Encabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.Encabezado.Location = New System.Drawing.Point(0, 0)
        Me.Encabezado.Name = "Encabezado"
        Me.Encabezado.Size = New System.Drawing.Size(1069, 133)
        Me.Encabezado.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel3.Controls.Add(Me.btnVerificar)
        Me.Panel3.Controls.Add(Me.btnFicha)
        Me.Panel3.Controls.Add(Me.btnMikrotik)
        Me.Panel3.Controls.Add(Me.btnEmpresa)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(942, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(127, 133)
        Me.Panel3.TabIndex = 4
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.BackgroundImage = Global.GeneradorFichasMikrotik.My.Resources.Resources.Textura
        Me.picLogo.Location = New System.Drawing.Point(14, 7)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(164, 118)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 3
        Me.picLogo.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1069, 133)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Generador de Fichas Mikrotik"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 803)
        Me.Controls.Add(Me.Contenedor)
        Me.Controls.Add(Me.Encabezado)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(855, 586)
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generador de Fichas Mikrotik v2.5"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Contenedor.ResumeLayout(False)
        CType(Me.VisorPDF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.MarcadeAgua.ResumeLayout(False)
        Me.MarcadeAgua.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picPreVisualizacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroDeFichas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Encabezado.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Encabezado As Panel
    Friend WithEvents Contenedor As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnGenerarFichas As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents picPreVisualizacion As PictureBox
    Friend WithEvents txtNumeroDeFichas As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPerfil As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTipoFicha As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TInicio As Timer
    Friend WithEvents MarcadeAgua As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents VisorPDF As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnFicha As Button
    Friend WithEvents btnMikrotik As Button
    Friend WithEvents btnEmpresa As Button
    Friend WithEvents ToolInfo As ToolTip
    Friend WithEvents Button1 As Button
    Friend WithEvents btnVerificar As Button
End Class
