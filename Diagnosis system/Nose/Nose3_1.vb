Public Class Nose3_1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        main_page.Show()
        Me.Hide()

    End Sub

    Private Sub yes_Click(sender As Object, e As EventArgs) Handles yes.Click
        If TextBox1.Text = "أمامي" Then
            Form4_1.Show()
            Me.Hide()

        End If

        If TextBox1.Text = "خلفي" Then
            Nose4_2.Show()
            Me.Hide()

        End If

    End Sub
End Class