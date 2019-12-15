Public Class larynx1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        main_page.Show()
        Me.Hide()

    End Sub

    Private Sub yes_Click(sender As Object, e As EventArgs) Handles yes.Click
        If TextBox1.Text = "مزمن" Then
            larynx1_1.Show()
            Me.Hide()

        End If

        If TextBox1.Text = "حاد" Then
            larynx1_2.Show()
            Me.Hide()

        End If

    End Sub

End Class