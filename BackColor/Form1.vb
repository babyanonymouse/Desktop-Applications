Public Class Form1
    Private Sub btnN_Click(sender As Object, e As EventArgs) Handles btnN.Click
        Dim i As Integer
        For i = 300 To 50 Step -1
            If i Mod 2 = 1 Then
                lstN.Items.Add(i)
            End If
        Next i
    End Sub
End Class
