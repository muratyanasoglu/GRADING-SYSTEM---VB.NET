Imports System.Linq
Imports System.Text.RegularExpressions

Public Class Form1

    Private Class Student
        Public Property StNumber As String
        Public Property StName As String
        Public Property MidScore As Double
        Public Property FinScore As Double
        Public ReadOnly Property FinalMark As Double
            Get
                Return MidScore * 0.4 + FinScore * 0.6
            End Get
        End Property

        Public ReadOnly Property PassOrFail As String
            Get
                If FinalMark >= 50 Then
                    Return "Pass"
                Else
                    Return "Fail"
                End If
            End Get
        End Property
    End Class

    Private students As New List(Of Student)()

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        Dim errors = ValidateInputs()

        If errors.Count > 0 Then
            MessageBox.Show(String.Join(Environment.NewLine, errors), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim st As New Student With {
            .StNumber = txtStNumber.Text,
            .StName = txtStName.Text,
            .MidScore = Double.Parse(txtMidScore.Text),
            .FinScore = Double.Parse(txtFinScore.Text)
        }
        students.Add(st)

        If students.Count > 10 Then
            lblError.Text = "A maximum of 10 students are allowed!"
            students.RemoveAt(10)
            Return
        End If

        txtFinalMark.Text = st.FinalMark.ToString("0.00")
        txtStNumber.Clear()
        txtStName.Clear()
        txtMidScore.Clear()
        txtFinScore.Clear()
    End Sub

    Private Function ValidateInputs() As List(Of String)
        Dim errors As New List(Of String)

        If String.IsNullOrWhiteSpace(txtStNumber.Text) Or Not Integer.TryParse(txtStNumber.Text, Nothing) Then
            errors.Add("The student number cannot be left blank or written, it must be a valid number!(Digits of student number only can be 10 or less than 10")
        End If

        If String.IsNullOrWhiteSpace(txtStName.Text) Or txtStName.Text.Any(Function(c) Char.IsDigit(c)) Then
            If String.IsNullOrWhiteSpace(txtStName.Text) Then
                errors.Add("Student name section cannot be left blank!")
            Else
                errors.Add("Please don't use numbers in the name!")
            End If
        End If

        If String.IsNullOrWhiteSpace(txtMidScore.Text) Or Not Double.TryParse(txtMidScore.Text, Nothing) OrElse Double.Parse(txtMidScore.Text) < 0 OrElse Double.Parse(txtMidScore.Text) > 100 Then
            errors.Add("The midterm grade section cannot be left blank - it cannot be written string and must be a value between 0 and 100!")
        End If

        If String.IsNullOrWhiteSpace(txtFinScore.Text) Or Not Double.TryParse(txtFinScore.Text, Nothing) OrElse Double.Parse(txtFinScore.Text) < 0 OrElse Double.Parse(txtFinScore.Text) > 100 Then
            errors.Add("The final grade part cannot be left blank - it cannot be written string and it must be a value between 0 and 100!")
        End If

        If errors.Count = 0 Then
            Return errors
        End If


        If errors.Any(Function(e) e.Contains("Cannot be left blank.")) Then
            errors.Insert(0, "Please fill in the information as requested. Cannot be left blank.")
        End If

        Return errors
    End Function

    Private Sub UpdateReport()
        lstboxReport.Items.Clear()

        If rbListStudents.Checked Then
            For Each st In students
                lstboxReport.Items.Add($"{st.StNumber}, {st.StName}")
            Next
        ElseIf rbDetailedList.Checked Then
            For Each st In students
                lstboxReport.Items.Add($"{st.StNumber}, {st.StName}, {st.MidScore}, {st.FinScore}, {st.FinalMark}")
            Next
        ElseIf rbPassOrFail.Checked Then
            For Each st In students
                lstboxReport.Items.Add($"{st.StName}, {st.PassOrFail}")
            Next
        ElseIf rbNumPassed.Checked Then
            Dim passedCount = (From s In students Where s.FinalMark >= 50).Count()
            lstboxReport.Items.Add($"Number of students who passed: {passedCount}")
        ElseIf rbNumFailed.Checked Then
            Dim failedCount = (From s In students Where s.FinalMark < 50).Count()
            lstboxReport.Items.Add($"Number of students who failed: {failedCount}")
        End If
    End Sub

    Private Sub RadioButtons_CheckedChanged(sender As Object, e As EventArgs) Handles rbListStudents.CheckedChanged, rbDetailedList.CheckedChanged, rbPassOrFail.CheckedChanged, rbNumPassed.CheckedChanged, rbNumFailed.CheckedChanged
        UpdateReport()
    End Sub

    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        lstboxReport.Items.Clear()

        For Each st In students
            lstboxReport.Items.Add($"{st.StNumber}, {st.StName}, {st.MidScore}, {st.FinScore}, {st.FinalMark}, {st.PassOrFail}")
        Next
    End Sub

End Class
