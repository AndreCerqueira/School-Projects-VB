<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu
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
        Me.lb_area = New System.Windows.Forms.Label()
        Me.lb_titulo = New System.Windows.Forms.Label()
        Me.lb_vol = New System.Windows.Forms.Label()
        Me.bt_quad = New System.Windows.Forms.Button()
        Me.bt_ret = New System.Windows.Forms.Button()
        Me.bt_tri = New System.Windows.Forms.Button()
        Me.bt_circ = New System.Windows.Forms.Button()
        Me.bt_cilindro = New System.Windows.Forms.Button()
        Me.bt_prisma = New System.Windows.Forms.Button()
        Me.bt_paral = New System.Windows.Forms.Button()
        Me.bt_cubo = New System.Windows.Forms.Button()
        Me.bt_voltar = New System.Windows.Forms.Button()
        Me.bt_sair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lb_area
        '
        Me.lb_area.AutoSize = True
        Me.lb_area.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lb_area.Location = New System.Drawing.Point(86, 56)
        Me.lb_area.Name = "lb_area"
        Me.lb_area.Size = New System.Drawing.Size(57, 22)
        Me.lb_area.TabIndex = 1
        Me.lb_area.Text = "Áreas"
        '
        'lb_titulo
        '
        Me.lb_titulo.AutoSize = True
        Me.lb_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lb_titulo.Location = New System.Drawing.Point(64, 9)
        Me.lb_titulo.Name = "lb_titulo"
        Me.lb_titulo.Size = New System.Drawing.Size(297, 26)
        Me.lb_titulo.TabIndex = 2
        Me.lb_titulo.Text = "Quinta do Forte da Casa, Lda"
        '
        'lb_vol
        '
        Me.lb_vol.AutoSize = True
        Me.lb_vol.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lb_vol.Location = New System.Drawing.Point(259, 56)
        Me.lb_vol.Name = "lb_vol"
        Me.lb_vol.Size = New System.Drawing.Size(79, 22)
        Me.lb_vol.TabIndex = 3
        Me.lb_vol.Text = "Volumes"
        '
        'bt_quad
        '
        Me.bt_quad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.bt_quad.Location = New System.Drawing.Point(56, 90)
        Me.bt_quad.Name = "bt_quad"
        Me.bt_quad.Size = New System.Drawing.Size(115, 42)
        Me.bt_quad.TabIndex = 4
        Me.bt_quad.Text = "Quadrado"
        Me.bt_quad.UseVisualStyleBackColor = True
        '
        'bt_ret
        '
        Me.bt_ret.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.bt_ret.Location = New System.Drawing.Point(56, 138)
        Me.bt_ret.Name = "bt_ret"
        Me.bt_ret.Size = New System.Drawing.Size(115, 42)
        Me.bt_ret.TabIndex = 5
        Me.bt_ret.Text = "Rêtangulo"
        Me.bt_ret.UseVisualStyleBackColor = True
        '
        'bt_tri
        '
        Me.bt_tri.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.bt_tri.Location = New System.Drawing.Point(56, 186)
        Me.bt_tri.Name = "bt_tri"
        Me.bt_tri.Size = New System.Drawing.Size(115, 42)
        Me.bt_tri.TabIndex = 6
        Me.bt_tri.Text = "Triângulo"
        Me.bt_tri.UseVisualStyleBackColor = True
        '
        'bt_circ
        '
        Me.bt_circ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.bt_circ.Location = New System.Drawing.Point(56, 234)
        Me.bt_circ.Name = "bt_circ"
        Me.bt_circ.Size = New System.Drawing.Size(115, 42)
        Me.bt_circ.TabIndex = 7
        Me.bt_circ.Text = "Círculo"
        Me.bt_circ.UseVisualStyleBackColor = True
        '
        'bt_cilindro
        '
        Me.bt_cilindro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.bt_cilindro.Location = New System.Drawing.Point(246, 234)
        Me.bt_cilindro.Name = "bt_cilindro"
        Me.bt_cilindro.Size = New System.Drawing.Size(115, 42)
        Me.bt_cilindro.TabIndex = 11
        Me.bt_cilindro.Text = "Cilindro"
        Me.bt_cilindro.UseVisualStyleBackColor = True
        '
        'bt_prisma
        '
        Me.bt_prisma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.bt_prisma.Location = New System.Drawing.Point(246, 186)
        Me.bt_prisma.Name = "bt_prisma"
        Me.bt_prisma.Size = New System.Drawing.Size(115, 42)
        Me.bt_prisma.TabIndex = 10
        Me.bt_prisma.Text = "Prisma Triângular"
        Me.bt_prisma.UseVisualStyleBackColor = True
        '
        'bt_paral
        '
        Me.bt_paral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.bt_paral.Location = New System.Drawing.Point(246, 138)
        Me.bt_paral.Name = "bt_paral"
        Me.bt_paral.Size = New System.Drawing.Size(115, 42)
        Me.bt_paral.TabIndex = 9
        Me.bt_paral.Text = "Paralelepípedo"
        Me.bt_paral.UseVisualStyleBackColor = True
        '
        'bt_cubo
        '
        Me.bt_cubo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.bt_cubo.Location = New System.Drawing.Point(246, 90)
        Me.bt_cubo.Name = "bt_cubo"
        Me.bt_cubo.Size = New System.Drawing.Size(115, 42)
        Me.bt_cubo.TabIndex = 8
        Me.bt_cubo.Text = "Cubo"
        Me.bt_cubo.UseVisualStyleBackColor = True
        '
        'bt_voltar
        '
        Me.bt_voltar.BackColor = System.Drawing.Color.Silver
        Me.bt_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.bt_voltar.Location = New System.Drawing.Point(225, 296)
        Me.bt_voltar.Name = "bt_voltar"
        Me.bt_voltar.Size = New System.Drawing.Size(200, 28)
        Me.bt_voltar.TabIndex = 13
        Me.bt_voltar.Text = "Voltar"
        Me.bt_voltar.UseVisualStyleBackColor = False
        '
        'bt_sair
        '
        Me.bt_sair.BackColor = System.Drawing.Color.Silver
        Me.bt_sair.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.bt_sair.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.bt_sair.Location = New System.Drawing.Point(12, 296)
        Me.bt_sair.Name = "bt_sair"
        Me.bt_sair.Size = New System.Drawing.Size(200, 28)
        Me.bt_sair.TabIndex = 12
        Me.bt_sair.Text = "Sair"
        Me.bt_sair.UseVisualStyleBackColor = False
        '
        'menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(437, 334)
        Me.Controls.Add(Me.bt_voltar)
        Me.Controls.Add(Me.bt_sair)
        Me.Controls.Add(Me.bt_cilindro)
        Me.Controls.Add(Me.bt_prisma)
        Me.Controls.Add(Me.bt_paral)
        Me.Controls.Add(Me.bt_cubo)
        Me.Controls.Add(Me.bt_circ)
        Me.Controls.Add(Me.bt_tri)
        Me.Controls.Add(Me.bt_ret)
        Me.Controls.Add(Me.bt_quad)
        Me.Controls.Add(Me.lb_vol)
        Me.Controls.Add(Me.lb_titulo)
        Me.Controls.Add(Me.lb_area)
        Me.Name = "menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_area As System.Windows.Forms.Label
    Friend WithEvents lb_titulo As System.Windows.Forms.Label
    Friend WithEvents lb_vol As System.Windows.Forms.Label
    Friend WithEvents bt_quad As System.Windows.Forms.Button
    Friend WithEvents bt_ret As System.Windows.Forms.Button
    Friend WithEvents bt_tri As System.Windows.Forms.Button
    Friend WithEvents bt_circ As System.Windows.Forms.Button
    Friend WithEvents bt_cilindro As System.Windows.Forms.Button
    Friend WithEvents bt_prisma As System.Windows.Forms.Button
    Friend WithEvents bt_paral As System.Windows.Forms.Button
    Friend WithEvents bt_cubo As System.Windows.Forms.Button
    Friend WithEvents bt_voltar As System.Windows.Forms.Button
    Friend WithEvents bt_sair As System.Windows.Forms.Button

End Class
