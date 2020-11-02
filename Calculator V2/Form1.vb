Public Class Form1

    Dim operation As Integer = 0
    Dim firstnumber As Double
    Dim firstEntered As Boolean = False
    Dim memory As Double = 0

    Private Sub btnZero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZero.Click
        If lblanswer.Text.Length < 10 Then
            lblanswer.Text = lblanswer.Text + sender.text

        End If
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        If lblanswer.Text.Length < 10 Then
            lblanswer.Text = lblanswer.Text + sender.text

        End If
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        If lblanswer.Text.Length < 10 Then
            lblanswer.Text = lblanswer.Text + sender.text
        End If
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        If lblanswer.Text.Length < 10 Then
            lblanswer.Text = lblanswer.Text + sender.text
        End If
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        If lblanswer.Text.Length < 10 Then
            lblanswer.Text = lblanswer.Text + sender.text
        End If
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        If lblanswer.Text.Length < 10 Then
            lblanswer.Text = lblanswer.Text + sender.text
        End If
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        If lblanswer.Text.Length < 10 Then
            lblanswer.Text = lblanswer.Text + sender.text
        End If
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        If lblanswer.Text.Length < 10 Then
            lblanswer.Text = lblanswer.Text + sender.text
        End If
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        If lblanswer.Text.Length < 10 Then
            lblanswer.Text = lblanswer.Text + sender.text
        End If
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        If lblanswer.Text.Length < 10 Then
            lblanswer.Text = lblanswer.Text + sender.text
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If lblanswer.Text <> vbNullString Then
            firstnumber = lblanswer.Text
            firstEntered = True
            operation = 1
            lblanswer.Text = ""
        End If
    End Sub

    Private Sub btnMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinus.Click
        If lblanswer.Text <> vbNullString Then
            firstnumber = lblanswer.Text
            firstEntered = True
            operation = 2
            lblanswer.Text = ""
        End If
    End Sub

    Private Sub btnTimes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimes.Click
        If lblanswer.Text <> vbNullString Then
            firstnumber = lblanswer.Text
            firstEntered = True
            operation = 3
            lblanswer.Text = ""
        End If
    End Sub

    Private Sub btnDivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDivide.Click
        If lblanswer.Text <> vbNullString Then
            firstnumber = lblanswer.Text
            firstEntered = True
            operation = 4
            lblanswer.Text = ""
        End If
    End Sub

    Private Sub btnEqual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEqual.Click
        If firstEntered Then

            If lblanswer.Text <> vbNullString Then

                Dim secondNumber As Double = lblanswer.Text
                Dim answer As Double

                Select Case operation
                    Case 1
                        answer = firstnumber + secondNumber

                    Case 2
                        answer = firstnumber - secondNumber

                    Case 3
                        answer = firstnumber * secondNumber

                    Case 4
                        answer = firstnumber / secondNumber
                End Select

                If operation >= 1 And operation <= 4 Then
                    lblanswer.Text = answer
                    firstnumber = answer
                End If

                If firstnumber >= 999999999999 And secondNumber <= 10000000000 Then
                    secondNumber = 0
                    lblanswer.Text = "error"

                End If

            End If

        End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        firstEntered = False
        lblanswer.Text = ""
        lblanswer.Focus()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If MsgBox("Do you want to close this window", vbYesNo + vbQuestion, "Close") = vbYes Then
            Me.Close()
        Else
            Me.Focus()
        End If
    End Sub
End Class

