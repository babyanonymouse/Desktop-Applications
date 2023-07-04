Public Class Form1
    Private Sub btnN_Click(sender As Object, e As EventArgs) Handles btnN.Click
        Dim i As Integer
        For i = 300 To 50 Step -1
            If i Mod 2 = 1 Then
                lstN.Items.Add(i)
            End If
        Next i
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim age As Integer
        age = Val(InputBox("please enter your age"))
        If age >= 18 Then
            MessageBox.Show("Legible to vote")
        Else
            MessageBox.Show("too young to vote")

        End If
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        Dim k As Single, eng As Single, m As Single, t As Single, avg As Double
        k = Val(txtK.Text)
        m = Val(txtM.Text)
        eng = Val(txtE.Text)
        t = k + m + eng
        avg = t / 3

        lblT.Text = t.ToString
        lblA.Text = avg.ToString("0.00")
        If avg >= 70 And avg <= 100 Then
            lblG.Text = "A"
            lblR.Text = "Pass"
        ElseIf avg >= 60 And avg <= 69 Then
            lblG.Text = "A"
            lblR.Text = "Above Average"
        ElseIf avg >= 50 And avg <= 59 Then
            lblG.Text = "C"
            lblR.Text = "Average"
        ElseIf avg >= 40 And avg <= 49 Then
            lblG.Text = "D"
            lblR.Text = "Below Average"
        Else
            lblG.Text = "FAIL"
        End If
    End Sub
End Class
