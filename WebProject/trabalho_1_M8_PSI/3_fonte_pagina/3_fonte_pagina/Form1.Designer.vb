<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.atualizar = New System.Windows.Forms.Timer(Me.components)
        Me.bt_reset = New System.Windows.Forms.Button()
        Me.bip = New System.Windows.Forms.Timer(Me.components)
        Me.bt_sound_stop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(747, 70)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(215, 362)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 12)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(729, 420)
        Me.WebBrowser1.TabIndex = 5
        Me.WebBrowser1.Url = New System.Uri("", System.UriKind.Relative)
        '
        'atualizar
        '
        Me.atualizar.Interval = 2000
        '
        'bt_reset
        '
        Me.bt_reset.Location = New System.Drawing.Point(747, 41)
        Me.bt_reset.Name = "bt_reset"
        Me.bt_reset.Size = New System.Drawing.Size(215, 23)
        Me.bt_reset.TabIndex = 6
        Me.bt_reset.Text = "Reset"
        Me.bt_reset.UseVisualStyleBackColor = True
        '
        'bip
        '
        Me.bip.Interval = 1000
        '
        'bt_sound_stop
        '
        Me.bt_sound_stop.Location = New System.Drawing.Point(747, 12)
        Me.bt_sound_stop.Name = "bt_sound_stop"
        Me.bt_sound_stop.Size = New System.Drawing.Size(215, 23)
        Me.bt_sound_stop.TabIndex = 7
        Me.bt_sound_stop.Text = "Parar o som"
        Me.bt_sound_stop.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 444)
        Me.Controls.Add(Me.bt_sound_stop)
        Me.Controls.Add(Me.bt_reset)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents atualizar As System.Windows.Forms.Timer
    Friend WithEvents bt_reset As System.Windows.Forms.Button
    Friend WithEvents bip As System.Windows.Forms.Timer
    Friend WithEvents bt_sound_stop As System.Windows.Forms.Button

End Class
