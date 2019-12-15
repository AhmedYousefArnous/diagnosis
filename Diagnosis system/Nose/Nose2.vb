Public Class Nose2

    Private Sub yes_Click(sender As Object, e As EventArgs) Handles yes.Click
        If TextBox1.Text = "دم" Then
            Nose3_1.Show()
            Me.Hide()

        End If

        If TextBox1.Text = "سائل" Then
            Nose2_2.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        main_page.Show()
        Me.Hide()
    End Sub
End Class