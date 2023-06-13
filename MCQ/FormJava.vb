Public Class Formjava

    Dim allQuestion() As String = {
                                    "Which of the following is not a Java features?",
                                    "The \u0021 article referred to as a",
                                    "_____ is used to find and fix bugs in the Java programs.",
                                    "Which of the following is a valid declaration of a char?",
                                    "What do you mean by nameless objects?",
                                    "Which of the following is a valid long literal?",
                                    "What does the expression float a = 35 / 0 return?",
                                    "Which of the following for loop declaration is not valid?",
                                    "An interface with no fields or methods is known as a ______.",
                                    "Which package contains the Random class?"
                                    }

    Dim choices(,) As String = {
                                {"Dynamic", "Architecture Neutral", "Use of pointers", "Object-oriented"},
                                {"Unicode escape sequence", "Octal escape", "Hexadecimal", "Line feed"},
                                {"JVM", "JRE", "JDK", "JDB"},
                                {"char ch = '\utea';", "char ca = 'tea';", "char cr = \u0223;", "char cc = '\itea';"},
                                {"An object created by using the new keyword.", "An object of a superclass created in the subclass.", "An object without having any name but having a reference.", "An object that has no reference."},
                                {"ABH8097", "L990023", "904423", "0xnf029L"},
                                {"0", "Not a Number", "Infinity", "Run time exception"},
                                {"for ( int i = 99; i >= 0; i / 9 )", "for ( int i = 7; i <= 77; i += 7 )", "for ( int i = 20; i >= 2; - -i )", "for ( int i = 2; i <= 20; i = 2* i )"},
                                {"Runnable Interface", "Marker Interface", "Abstract Interface", "CharSequence Interface"},
                                {"java.util package", "java.lang package", "java.awt package", "java.io package"}
                                }

    Dim allAnswers() As String = {"C", "A", "D", "A", "D", "D", "C", "A", "B", "A"}

    Dim index As Integer = 0
    Dim total_question = allQuestion.Length
    Dim score As Integer = 0
    Dim counter = 10

    Private labels As Label()
    Private buttons As Button()

    Private Sub FormWelcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FormHome

        labels = New Label() {LabelChoiceA, LabelChoiceB, LabelChoiceC, LabelChoiceD, LabelQuestion}
        buttons = New Button() {ButtonA, ButtonB, ButtonC, ButtonD, ButtonNext}

        For Each label In labels
            label.Text = String.Empty
        Next

        For Each button In buttons
            button.Enabled = False
        Next
        ButtonStart.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If counter = 0 Then
            counter = 10
            index = index + 1
            nextQuestion()
        End If
        LabelCount.Text = counter
        counter = counter - 1
    End Sub

    Private Sub ButtonStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStart.Click

        ButtonStart.Enabled = False
        ButtonStart.Text = "Start"
        ButtonExit.Enabled = False

        For Each button In buttons
            button.Enabled = True
        Next

        Timer1.Enabled = True
        nextQuestion()
    End Sub

    Private Sub nextQuestion()
        If index = total_question Then
            Timer1.Enabled = False
            result()
            ButtonStart.Enabled = True
            ButtonStart.Text = "Try Again"
            index = 0
            score = 0

        Else
            LabelQuestion.Text = "Question " + (index + 1).ToString + ".) " + allQuestion(index).ToString
            LabelChoiceA.Text = choices(index, 0).ToString
            LabelChoiceB.Text = choices(index, 1).ToString
            LabelChoiceC.Text = choices(index, 2).ToString
            LabelChoiceD.Text = choices(index, 3).ToString
            counter = 10
        End If
    End Sub

    Private Sub result()
        For Each button In buttons
            button.Enabled = False
        Next
        For Each label In labels
            label.Text = String.Empty
        Next
        LabelCount.Text = "10"
        ButtonExit.Enabled = True
        MessageBox.Show("Your score is " + score.ToString + "/" + total_question.ToString)
        If score >= (total_question / 2) Then
            MessageBox.Show("You PASSED!")
        Else
            MessageBox.Show("You FAILED!")
        End If
    End Sub

    Private Sub Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonA.Click, ButtonB.Click, ButtonC.Click, ButtonD.Click, ButtonNext.Click
        Dim clickedButton As Button = DirectCast(sender, Button)
        If clickedButton.Text = allAnswers(index) Then
            score = score + 1
        End If
        index = index + 1
        nextQuestion()
    End Sub

    Private Sub ButtonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        Me.Close()
        FormHome.ButtonMath.Enabled = True
        FormHome.Button3.Enabled = True
    End Sub

End Class