<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUI_Mikrotik
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_Mikrotik))
        Me.Panel_Body = New System.Windows.Forms.Panel()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtDominio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPuerto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel_Header = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPruebas = New System.Windows.Forms.Button()
        Me.Panel_Body.SuspendLayout()
        Me.Panel_Header.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Body
        '
        Me.Panel_Body.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel_Body.Controls.Add(Me.btnPruebas)
        Me.Panel_Body.Controls.Add(Me.btnTest)
        Me.Panel_Body.Controls.Add(Me.btnLimpiar)
        Me.Panel_Body.Controls.Add(Me.btnGuardar)
        Me.Panel_Body.Controls.Add(Me.txtDominio)
        Me.Panel_Body.Controls.Add(Me.Label6)
        Me.Panel_Body.Controls.Add(Me.txtPuerto)
        Me.Panel_Body.Controls.Add(Me.Label5)
        Me.Panel_Body.Controls.Add(Me.txtPassword)
        Me.Panel_Body.Controls.Add(Me.Label4)
        Me.Panel_Body.Controls.Add(Me.txtUsuario)
        Me.Panel_Body.Controls.Add(Me.Label3)
        Me.Panel_Body.Controls.Add(Me.txtIP)
        Me.Panel_Body.Controls.Add(Me.Label2)
        Me.Panel_Body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Body.Location = New System.Drawing.Point(0, 61)
        Me.Panel_Body.Name = "Panel_Body"
        Me.Panel_Body.Size = New System.Drawing.Size(604, 300)
        Me.Panel_Body.TabIndex = 3
        '
        'btnTest
        '
        Me.btnTest.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnTest.Location = New System.Drawing.Point(257, 238)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(114, 45)
        Me.btnTest.TabIndex = 15
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.LightCoral
        Me.btnLimpiar.Location = New System.Drawing.Point(137, 238)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(114, 45)
        Me.btnLimpiar.TabIndex = 14
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.LightGreen
        Me.btnGuardar.Location = New System.Drawing.Point(377, 238)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(114, 45)
        Me.btnGuardar.TabIndex = 13
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'txtDominio
        '
        Me.txtDominio.Location = New System.Drawing.Point(315, 155)
        Me.txtDominio.MaxLength = 30
        Me.txtDominio.Name = "txtDominio"
        Me.txtDominio.Size = New System.Drawing.Size(175, 29)
        Me.txtDominio.TabIndex = 12
        Me.txtDominio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(315, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 30)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Dominio Hotspot"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPuerto
        '
        Me.txtPuerto.Location = New System.Drawing.Point(122, 155)
        Me.txtPuerto.MaxLength = 5
        Me.txtPuerto.Name = "txtPuerto"
        Me.txtPuerto.Size = New System.Drawing.Size(175, 29)
        Me.txtPuerto.TabIndex = 10
        Me.txtPuerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(122, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 30)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Puerto"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(405, 69)
        Me.txtPassword.MaxLength = 20
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(175, 29)
        Me.txtPassword.TabIndex = 8
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(405, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 30)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Password"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(214, 69)
        Me.txtUsuario.MaxLength = 20
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(175, 29)
        Me.txtUsuario.TabIndex = 6
        Me.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(214, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 30)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Usuario"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(23, 69)
        Me.txtIP.MaxLength = 15
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(175, 29)
        Me.txtIP.TabIndex = 4
        Me.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(23, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "IP"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_Header
        '
        Me.Panel_Header.BackgroundImage = Global.GeneradorFichasMikrotik.My.Resources.Resources.Textura
        Me.Panel_Header.Controls.Add(Me.Label1)
        Me.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Header.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Header.Name = "Panel_Header"
        Me.Panel_Header.Size = New System.Drawing.Size(604, 61)
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
        Me.Label1.Size = New System.Drawing.Size(604, 61)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Configuración del Mikrotik"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPruebas
        '
        Me.btnPruebas.BackColor = System.Drawing.Color.AliceBlue
        Me.btnPruebas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPruebas.Location = New System.Drawing.Point(3, 276)
        Me.btnPruebas.Name = "btnPruebas"
        Me.btnPruebas.Size = New System.Drawing.Size(21, 21)
        Me.btnPruebas.TabIndex = 16
        Me.btnPruebas.UseVisualStyleBackColor = False
        '
        'GUI_Mikrotik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 361)
        Me.Controls.Add(Me.Panel_Body)
        Me.Controls.Add(Me.Panel_Header)
        Me.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MaximizeBox = False
        Me.Name = "GUI_Mikrotik"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurar Mikrotik"
        Me.Panel_Body.ResumeLayout(False)
        Me.Panel_Body.PerformLayout()
        Me.Panel_Header.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Body As Panel
    Friend WithEvents Panel_Header As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDominio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPuerto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnTest As Button
    Friend WithEvents btnPruebas As Button
End Class
