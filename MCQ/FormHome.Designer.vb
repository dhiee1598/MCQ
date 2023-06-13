<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHome
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ButtonJava = New System.Windows.Forms.Button()
        Me.ButtonMath = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ButtonExit)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.ButtonJava)
        Me.Panel1.Controls.Add(Me.ButtonMath)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.Color.Lime
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 505)
        Me.Panel1.TabIndex = 0
        '
        'ButtonExit
        '
        Me.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExit.ForeColor = System.Drawing.Color.Aqua
        Me.ButtonExit.Location = New System.Drawing.Point(19, 438)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(171, 43)
        Me.ButtonExit.TabIndex = 4
        Me.ButtonExit.Text = "Exit Quiz"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(19, 266)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(171, 43)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Python Quiz"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ButtonJava
        '
        Me.ButtonJava.BackColor = System.Drawing.Color.MediumAquamarine
        Me.ButtonJava.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonJava.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonJava.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonJava.ForeColor = System.Drawing.Color.Black
        Me.ButtonJava.Location = New System.Drawing.Point(19, 194)
        Me.ButtonJava.Name = "ButtonJava"
        Me.ButtonJava.Size = New System.Drawing.Size(171, 43)
        Me.ButtonJava.TabIndex = 2
        Me.ButtonJava.Text = "Java Quiz"
        Me.ButtonJava.UseVisualStyleBackColor = False
        '
        'ButtonMath
        '
        Me.ButtonMath.BackColor = System.Drawing.Color.MediumAquamarine
        Me.ButtonMath.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonMath.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonMath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonMath.Location = New System.Drawing.Point(19, 126)
        Me.ButtonMath.Name = "ButtonMath"
        Me.ButtonMath.Size = New System.Drawing.Size(171, 43)
        Me.ButtonMath.TabIndex = 1
        Me.ButtonMath.Text = "Math Quiz"
        Me.ButtonMath.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome Users"
        '
        'FormHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(905, 505)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Poppins Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(6, 9, 6, 9)
        Me.Name = "FormHome"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormHome"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ButtonJava As System.Windows.Forms.Button
    Friend WithEvents ButtonMath As System.Windows.Forms.Button
End Class
