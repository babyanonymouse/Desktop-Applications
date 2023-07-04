Public Class Form2
    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        Dim k As Single, l As Single, m As Single, t As Single, avg As Double
        k = Val(txtN1.Text)
        m = Val(txtN2.Text)
        l = Val(txtN3.Text)
        t = k + m + l
        avg = t / 3
    End Sub
End Class