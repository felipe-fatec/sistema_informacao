<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.btn_cad_usuarios = New System.Windows.Forms.Button()
        Me.btn_historico = New System.Windows.Forms.Button()
        Me.btn_sair_admin = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_cad_usuarios
        '
        Me.btn_cad_usuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_cad_usuarios.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cad_usuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_cad_usuarios.Location = New System.Drawing.Point(69, 277)
        Me.btn_cad_usuarios.Name = "btn_cad_usuarios"
        Me.btn_cad_usuarios.Size = New System.Drawing.Size(276, 52)
        Me.btn_cad_usuarios.TabIndex = 0
        Me.btn_cad_usuarios.Text = "CADASTRAR USUÁRIOS"
        Me.btn_cad_usuarios.UseVisualStyleBackColor = False
        '
        'btn_historico
        '
        Me.btn_historico.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_historico.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_historico.Location = New System.Drawing.Point(69, 347)
        Me.btn_historico.Name = "btn_historico"
        Me.btn_historico.Size = New System.Drawing.Size(276, 52)
        Me.btn_historico.TabIndex = 1
        Me.btn_historico.Text = "VISUALIZAR HISTÓRICO"
        Me.btn_historico.UseVisualStyleBackColor = False
        '
        'btn_sair_admin
        '
        Me.btn_sair_admin.BackColor = System.Drawing.Color.OrangeRed
        Me.btn_sair_admin.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair_admin.Location = New System.Drawing.Point(480, 613)
        Me.btn_sair_admin.Name = "btn_sair_admin"
        Me.btn_sair_admin.Size = New System.Drawing.Size(137, 47)
        Me.btn_sair_admin.TabIndex = 2
        Me.btn_sair_admin.Text = "SAIR"
        Me.btn_sair_admin.UseVisualStyleBackColor = False
        '
        'btn_sair
        '
        Me.btn_sair.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_sair.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair.Location = New System.Drawing.Point(119, 422)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(149, 59)
        Me.btn_sair.TabIndex = 3
        Me.btn_sair.Text = "SAIR"
        Me.btn_sair.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(416, 493)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.btn_sair_admin)
        Me.Controls.Add(Me.btn_historico)
        Me.Controls.Add(Me.btn_cad_usuarios)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administração do Sistema"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_cad_usuarios As Button
    Friend WithEvents btn_historico As Button
    Friend WithEvents btn_sair_admin As Button
    Friend WithEvents btn_sair As Button
End Class
