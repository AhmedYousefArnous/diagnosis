Public Class ear5_11

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "نعم" Then
            ear5_111.Show()
            Me.Hide()
        End If
        If TextBox1.Text = "لا" Then
            ear5_112.Show()
            Me.Hide()
        End If
    End Sub

End Class