<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(quad))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lb_area = New System.Windows.Forms.Label()
        Me.bt_calc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_lado = New System.Windows.Forms.TextBox()
        Me.bt_voltar = New System.Windows.Forms.Button()
        Me.bt_sair = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(24, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(209, 174)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lb_area
        '
        Me.lb_area.AutoSize = True
        Me.lb_area.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lb_area.Location = New System.Drawing.Point(264, 45)
        Me.lb_area.Name = "lb_area"
        Me.lb_area.Size = New System.Drawing.Size(154, 22)
        Me.lb_area.TabIndex = 2
        Me.lb_area.Text = "Área = lado * lado"
        '
        'bt_calc
        '
        Me.bt_calc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.bt_calc.Location = New System.Drawing.Point(291, 181)
        Me.bt_calc.Name = "bt_calc"
        Me.bt_calc.Size = New System.Drawing.Size(100, 28)
        Me.bt_calc.TabIndex = 5
        Me.bt_calc.Text = "Calcular"
        Me.bt_calc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label1.Location = New System.Drawing.Point(287, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 22)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Lado"
        '
        'tb_lado
        '
        Me.tb_lado.Location = New System.Drawing.Point(291, 133)
        Me.tb_lado.Name = "tb_lado"
        Me.tb_lado.Size = New System.Drawing.Size(100, 20)
        Me.tb_lado.TabIndex = 7
        '
        'bt_voltar
        '
        Me.bt_voltar.BackColor = System.Drawing.Color.Silver
        Me.bt_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.bt_voltar.Location = New System.Drawing.Point(225, 294)
        Me.bt_voltar.Name = "bt_voltar"
        Me.bt_voltar.Size = New System.Drawing.Size(200, 28)
        Me.bt_voltar.TabIndex = 15
        Me.bt_voltar.Text = "Voltar"
        Me.bt_voltar.UseVisualStyleBackColor = False
        '
        'bt_sair
        '
        Me.bt_sair.BackColor = System.Drawing.Color.Silver
        Me.bt_sair.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.bt_sair.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.bt_sair.Location = New System.Drawing.Point(12, 294)
        Me.bt_sair.Name = "bt_sair"
        Me.bt_sair.Size = New System.Drawing.Size(200, 28)
        Me.bt_sair.TabIndex = 14
        Me.bt_sair.Text = "Sair"
        Me.bt_sair.UseVisualStyleBackColor = False
        '
        'quad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(437, 334)
        Me.Controls.Add(Me.bt_voltar)
        Me.Controls.Add(Me.bt_sair)
        Me.Controls.Add(Me.tb_lado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_calc)
        Me.Controls.Add(Me.lb_area)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "quad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "quad"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lb_area As System.Windows.Forms.Label
    Friend WithEvents bt_calc As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_lado As System.Windows.Forms.TextBox
    Friend WithEvents bt_voltar As System.Windows.Forms.Button
    Friend WithEvents bt_sair As System.Windows.Forms.Button
End Class
