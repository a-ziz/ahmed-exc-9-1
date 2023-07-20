Public Class Form1

    Private Sub btnCalculateDueDays_Click(sender As Object, e As EventArgs) Handles btnCalculateDueDays.Click

        ' Check if date is valid

        If Not IsDate(txtFutureDate.Text) Then
            MessageBox.Show(txtFutureDate.Text & " is not a valid date." & vbNewLine &
                            "Please enter a date in MM/DD/YYYY format.", "Date Error")
            Exit Sub
        End If

        If CDate(txtFutureDate.Text) < DateTime.Today Then
            MessageBox.Show(txtFutureDate.Text & " is in the past." & vbNewLine &
                            "Please enter a future date in MM/DD/YYYY format.", "Date Error")
            Exit Sub
        End If

        ' Calculate due date

        Dim dueTime As TimeSpan = DateTime.Parse(txtFutureDate.Text) - DateTime.Today
        Dim dueInDays As Integer = dueTime.Days

        MessageBox.Show("Current date: " & DateTime.Today & vbNewLine &
                        "Future date: " & txtFutureDate.Text & vbNewLine & vbNewLine &
                        "Days until due : " & dueInDays, "Due Days Calculation")

    End Sub

    Private Sub btnCalculateAge_Click(sender As Object, e As EventArgs) Handles btnCalculateAge.Click

        ' Check if date is valid

        If Not IsDate(txtBirthDate.Text) Then
            MessageBox.Show(txtBirthDate.Text & " is not a valid date." & vbNewLine &
                            "Please enter a date in MM/DD/YYYY format.", "Date Error")
            Exit Sub
        End If

        If CDate(txtBirthDate.Text) > DateTime.Today Then
            MessageBox.Show(txtBirthDate.Text & " is in the future" & vbNewLine &
                            "Please enter a date in MM/DD/YYYY format.", "Date Error")
            Exit Sub
        End If

        ' Calculate age

        Dim age As TimeSpan = DateTime.Today - DateTime.Parse(txtBirthDate.Text)
        Dim ageInDays As Integer = age.Days
        Dim ageInYears As Integer = CInt(Math.Floor(ageInDays / 365.25))

        MessageBox.Show("Current date: " & DateTime.Today & vbNewLine &
                        "Birth date: " & txtBirthDate.Text & vbNewLine & vbNewLine &
                        "Age: " & ageInYears.ToString, "Age Calculation")

    End Sub

    Private Sub btnExit_Click(sender As Object,
        e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
