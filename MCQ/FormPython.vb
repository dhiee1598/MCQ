Public Class FormPython

    Dim allQuestion() As String = {
                                    "What is the maximum possible length of an identifier?",
                                    "Who developed the Python language?",
                                    "In which year was the Python language developed?",
                                    "In which language is Python written?",
                                    "In which year was the Python 3.0 version developed?",
                                    "What do we use to define a block of code in Python language?",
                                    "Which character is used in Python to make a single line comment?",
                                    "What is the method inside the class in python language?",
                                    "Which of the following declarations is incorrect?",
                                    "Which of the following is not a keyword in Python language?"
                                    }

    Dim choices(,) As String = {
                                {"16", "32", "64", "None of these above"},
                                {"Zim Den", "Guido van Rossum", "Niene Stom", "Wick van Rossum"},
                                {"1995", "1972", "1981", "1989"},
                                {"English", "PHP", "C", "All of the above"},
                                {"2008", "2000", "2010", "2005"},
                                {"Key", "Brackets", "Indentation", "None of these"},
                                {"/", "//", "#", "!"},
                                {"Object", "Function", "Attribute", "Argument"},
                                {"_x = 2", "__x = 3", "__xyz__ = 5", "None of these"},
                                {"val", "raise", "try", "with"}
                                }

    Dim allAnswers() As String = {"D", "B", "D", "C", "A", "C", "C", "B", "D", "A"}

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
        FormHome.ButtonJava.Enabled = True
        FormHome.ButtonMath.Enabled = True
    End Sub
End Class