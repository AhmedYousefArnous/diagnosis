Public Class Nose5_1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        main_page.Show()
        Me.Hide()

    End Sub

    Private Sub yes_Click(sender As Object, e As EventArgs) Handles yes.Click
        If TextBox1.Text = "متقطع" Then
            Nose6.Show()
            Me.Hide()

        End If

        If TextBox1.Text = "مستمر" Then
            Nose6_2.Show()
            Me.Hide()

        End If

    End Sub
End Class