<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUI_Empresa
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_Empresa))
        Me.Panel_Body = New System.Windows.Forms.Panel()
        Me.txtEmpresa_Nombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDialogo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGuardarCambios = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.Panel_Header = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dialogo_Abrir = New System.Windows.Forms.OpenFileDialog()
        Me.Panel_Body.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Header.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Body
        '
        Me.Panel_Body.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel_Body.Controls.Add(Me.txtEmpresa_Nombre)
        Me.Panel_Body.Controls.Add(Me.Label5)
        Me.Panel_Body.Controls.Add(Me.Label3)
        Me.Panel_Body.Controls.Add(Me.btnDialogo)
        Me.Panel_Body.Controls.Add(Me.Label2)
        Me.Panel_Body.Controls.Add(Me.btnGuardarCambios)
        Me.Panel_Body.Controls.Add(Me.picLogo)
        Me.Panel_Body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Body.Location = New System.Drawing.Point(0, 61)
        Me.Panel_Body.Name = "Panel_Body"
        Me.Panel_Body.Size = New System.Drawing.Size(527, 300)
        Me.Panel_Body.TabIndex = 3
        '
        'txtEmpresa_Nombre
        '
        Me.txtEmpresa_Nombre.Location = New System.Drawing.Point(25, 136)
        Me.txtEmpresa_Nombre.MaxLength = 50
        Me.txtEmpresa_Nombre.Name = "txtEmpresa_Nombre"
        Me.txtEmpresa_Nombre.Size = New System.Drawing.Size(175, 29)
        Me.txtEmpresa_Nombre.TabIndex = 8
        Me.txtEmpresa_Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(25, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 30)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Nombre Empresa"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.GhostWhite
        Me.Label3.Location = New System.Drawing.Point(25, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 40)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Logo: "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDialogo
        '
        Me.btnDialogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDialogo.BackgroundImage = Global.GeneradorFichasMikrotik.My.Resources.Resources.lupa
        Me.btnDialogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDialogo.Location = New System.Drawing.Point(160, 43)
        Me.btnDialogo.Name = "btnDialogo"
        Me.btnDialogo.Size = New System.Drawing.Size(40, 40)
        Me.btnDialogo.TabIndex = 3
        Me.btnDialogo.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(223, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(279, 39)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pre visualización (164x118px)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGuardarCambios
        '
        Me.btnGuardarCambios.BackColor = System.Drawing.Color.LightGreen
        Me.btnGuardarCambios.Location = New System.Drawing.Point(25, 237)
        Me.btnGuardarCambios.Name = "btnGuardarCambios"
        Me.btnGuardarCambios.Size = New System.Drawing.Size(175, 45)
        Me.btnGuardarCambios.TabIndex = 1
        Me.btnGuardarCambios.Text = "Guardar cambios"
        Me.btnGuardarCambios.UseVisualStyleBackColor = False
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.White
        Me.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLogo.Location = New System.Drawing.Point(224, 82)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(278, 200)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'Panel_Header
        '
        Me.Panel_Header.BackgroundImage = Global.GeneradorFichasMikrotik.My.Resources.Resources.Textura
        Me.Panel_Header.Controls.Add(Me.Label1)
        Me.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Header.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Header.Name = "Panel_Header"
        Me.Panel_Header.Size = New System.Drawing.Size(527, 61)
        Me.Panel_Header.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(527, 61)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Configuración de Empresa"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Dialogo_Abrir
        '
        Me.Dialogo_Abrir.Filter = "Imágenes: |*.jpg;*.bmp;*.png"
        Me.Dialogo_Abrir.Title = "Buscar Imágen"
        '
        'GUI_Empresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 361)
        Me.Controls.Add(Me.Panel_Body)
        Me.Controls.Add(Me.Panel_Header)
        Me.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MaximizeBox = False
        Me.Name = "GUI_Empresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurar Empresa"
        Me.Panel_Body.ResumeLayout(False)
        Me.Panel_Body.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Header.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Body As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDialogo As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGuardarCambios As Button
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents Panel_Header As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Dialogo_Abrir As OpenFileDialog
    Friend WithEvents txtEmpresa_Nombre As TextBox
    Friend WithEvents Label5 As Label
End Class
