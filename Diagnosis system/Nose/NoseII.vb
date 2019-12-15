Public Class NoseII
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        main_page.Show()
        Me.Hide()

    End Sub

    Private Sub yes_Click(sender As Object, e As EventArgs) Handles yes.Click
        If TextBox1.Text = "نعم" Then
            NoseII_1.Show()
            Me.Hide()

        End If

        If TextBox1.Text = "لا" Then
            NoseII_2.Show()
            Me.Hide()

        End If

    End Sub

 
End Class