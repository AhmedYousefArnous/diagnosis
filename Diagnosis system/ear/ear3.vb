Public Class ear3


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "نعم" Then
            ear3_1.Show()
            Me.Hide()
        End If
        If TextBox1.Text = "لا" Then
            ear4.Show()
            Me.Hide()
        End If

    End Sub

   
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        main_page.Show()
        Me.Hide()
    End Sub
End Class