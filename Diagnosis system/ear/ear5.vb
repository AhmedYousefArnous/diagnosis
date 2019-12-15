Public Class ear5

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ear1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "نعم" Then
            ear5_11.Show()
            Me.Hide()
        End If
        If TextBox1.Text = "لا" Then
            ear6.Show()
            Me.Hide()
        End If
    End Sub
End Class