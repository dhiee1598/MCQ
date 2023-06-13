<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMath
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
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.LabelQuestion = New System.Windows.Forms.Label()
        Me.LabelCount = New System.Windows.Forms.Label()
        Me.LabelChoiceD = New System.Windows.Forms.Label()
        Me.LabelChoiceC = New System.Windows.Forms.Label()
        Me.LabelChoiceB = New System.Windows.Forms.Label()
        Me.LabelChoiceA = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonD = New System.Windows.Forms.Button()
        Me.ButtonC = New System.Windows.Forms.Button()
        Me.ButtonB = New System.Windows.Forms.Button()
        Me.ButtonA = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonNext
        '
        Me.ButtonNext.Location = New System.Drawing.Point(345, 448)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(124, 42)
        Me.ButtonNext.TabIndex = 39
        Me.ButtonNext.Text = "Next"
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'ButtonStart
        '
        Me.ButtonStart.Location = New System.Drawing.Point(475, 448)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(124, 42)
        Me.ButtonStart.TabIndex = 38
        Me.ButtonStart.Text = "Start"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'LabelQuestion
        '
        Me.LabelQuestion.AutoSize = True
        Me.LabelQuestion.Font = New System.Drawing.Font("Poppins", 13.0!)
        Me.LabelQuestion.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LabelQuestion.Location = New System.Drawing.Point(12, 15)
        Me.LabelQuestion.Name = "LabelQuestion"
        Me.LabelQuestion.Size = New System.Drawing.Size(148, 31)
        Me.LabelQuestion.TabIndex = 0
        Me.LabelQuestion.Text = "Question 1 Test"
        '
        'LabelCount
        '
        Me.LabelCount.AutoSize = True
        Me.LabelCount.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.LabelCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelCount.Font = New System.Drawing.Font("Poppins", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCount.ForeColor = System.Drawing.Color.Red
        Me.LabelCount.Location = New System.Drawing.Point(623, 433)
        Me.LabelCount.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelCount.Name = "LabelCount"
        Me.LabelCount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelCount.Size = New System.Drawing.Size(52, 65)
        Me.LabelCount.TabIndex = 37
        Me.LabelCount.Text = "0"
        '
        'LabelChoiceD
        '
        Me.LabelChoiceD.AutoSize = True
        Me.LabelChoiceD.Font = New System.Drawing.Font("Poppins", 13.0!)
        Me.LabelChoiceD.Location = New System.Drawing.Point(105, 340)
        Me.LabelChoiceD.Name = "LabelChoiceD"
        Me.LabelChoiceD.Size = New System.Drawing.Size(161, 31)
        Me.LabelChoiceD.TabIndex = 36
        Me.LabelChoiceD.Text = "Choices Sample"
        '
        'LabelChoiceC
        '
        Me.LabelChoiceC.AutoSize = True
        Me.LabelChoiceC.Font = New System.Drawing.Font("Poppins", 13.0!)
        Me.LabelChoiceC.Location = New System.Drawing.Point(105, 274)
        Me.LabelChoiceC.Name = "LabelChoiceC"
        Me.LabelChoiceC.Size = New System.Drawing.Size(161, 31)
        Me.LabelChoiceC.TabIndex = 35
        Me.LabelChoiceC.Text = "Choices Sample"
        '
        'LabelChoiceB
        '
        Me.LabelChoiceB.AutoSize = True
        Me.LabelChoiceB.Font = New System.Drawing.Font("Poppins", 13.0!)
        Me.LabelChoiceB.Location = New System.Drawing.Point(105, 208)
        Me.LabelChoiceB.Name = "LabelChoiceB"
        Me.LabelChoiceB.Size = New System.Drawing.Size(161, 31)
        Me.LabelChoiceB.TabIndex = 34
        Me.LabelChoiceB.Text = "Choices Sample"
        '
        'LabelChoiceA
        '
        Me.LabelChoiceA.AutoSize = True
        Me.LabelChoiceA.Font = New System.Drawing.Font("Poppins", 13.0!)
        Me.LabelChoiceA.Location = New System.Drawing.Point(105, 142)
        Me.LabelChoiceA.Name = "LabelChoiceA"
        Me.LabelChoiceA.Size = New System.Drawing.Size(161, 31)
        Me.LabelChoiceA.TabIndex = 33
        Me.LabelChoiceA.Text = "Choices Sample"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'ButtonD
        '
        Me.ButtonD.Location = New System.Drawing.Point(19, 328)
        Me.ButtonD.Name = "ButtonD"
        Me.ButtonD.Size = New System.Drawing.Size(65, 60)
        Me.ButtonD.TabIndex = 32
        Me.ButtonD.Text = "D"
        Me.ButtonD.UseVisualStyleBackColor = True
        '
        'ButtonC
        '
        Me.ButtonC.Location = New System.Drawing.Point(19, 262)
        Me.ButtonC.Name = "ButtonC"
        Me.ButtonC.Size = New System.Drawing.Size(65, 60)
        Me.ButtonC.TabIndex = 31
        Me.ButtonC.Text = "C"
        Me.ButtonC.UseVisualStyleBackColor = True
        '
        'ButtonB
        '
        Me.ButtonB.Location = New System.Drawing.Point(19, 196)
        Me.ButtonB.Name = "ButtonB"
        Me.ButtonB.Size = New System.Drawing.Size(65, 60)
        Me.ButtonB.TabIndex = 30
        Me.ButtonB.Text = "B"
        Me.ButtonB.UseVisualStyleBackColor = True
        '
        'ButtonA
        '
        Me.ButtonA.Location = New System.Drawing.Point(19, 130)
        Me.ButtonA.Name = "ButtonA"
        Me.ButtonA.Size = New System.Drawing.Size(65, 60)
        Me.ButtonA.TabIndex = 29
        Me.ButtonA.Text = "A"
        Me.ButtonA.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Panel2.Controls.Add(Me.LabelQuestion)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(700, 68)
        Me.Panel2.TabIndex = 28
        '
        'ButtonExit
        '
        Me.ButtonExit.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonExit.FlatAppearance.BorderSize = 0
        Me.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExit.Font = New System.Drawing.Font("Poppins", 16.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonExit.ForeColor = System.Drawing.Color.Red
        Me.ButtonExit.Location = New System.Drawing.Point(650, 6)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(43, 42)
        Me.ButtonExit.TabIndex = 14
        Me.ButtonExit.Text = "X"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelTitle.Font = New System.Drawing.Font("Poppins SemiBold", 23.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTitle.ForeColor = System.Drawing.Color.LimeGreen
        Me.LabelTitle.Location = New System.Drawing.Point(0, -2)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(179, 54)
        Me.LabelTitle.TabIndex = 0
        Me.LabelTitle.Text = "Math Quiz"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Panel1.Controls.Add(Me.ButtonExit)
        Me.Panel1.Controls.Add(Me.LabelTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(700, 52)
        Me.Panel1.TabIndex = 27
        '
        'FormMath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(700, 500)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.LabelCount)
        Me.Controls.Add(Me.LabelChoiceD)
        Me.Controls.Add(Me.LabelChoiceC)
        Me.Controls.Add(Me.LabelChoiceB)
        Me.Controls.Add(Me.LabelChoiceA)
        Me.Controls.Add(Me.ButtonD)
        Me.Controls.Add(Me.ButtonC)
        Me.Controls.Add(Me.ButtonB)
        Me.Controls.Add(Me.ButtonA)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(7, 9, 7, 9)
        Me.Name = "FormMath"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormWelcome"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonNext As System.Windows.Forms.Button
    Friend WithEvents ButtonStart As System.Windows.Forms.Button
    Friend WithEvents LabelQuestion As System.Windows.Forms.Label
    Friend WithEvents LabelCount As System.Windows.Forms.Label
    Friend WithEvents LabelChoiceD As System.Windows.Forms.Label
    Friend WithEvents LabelChoiceC As System.Windows.Forms.Label
    Friend WithEvents LabelChoiceB As System.Windows.Forms.Label
    Friend WithEvents LabelChoiceA As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ButtonD As System.Windows.Forms.Button
    Friend WithEvents ButtonC As System.Windows.Forms.Button
    Friend WithEvents ButtonB As System.Windows.Forms.Button
    Friend WithEvents ButtonA As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
    Friend WithEvents LabelTitle As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
