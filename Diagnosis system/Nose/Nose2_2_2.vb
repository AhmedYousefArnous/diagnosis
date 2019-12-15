Public Class Nose2_2_2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        main_page.Show()
        Me.Hide()

    End Sub

    Private Sub yes_Click(sender As Object, e As EventArgs) Handles yes.Click
        If TextBox1.Text = "نعم" Then
            Nose2_2_2_1.Show()
            Me.Hide()

        End If

        If TextBox1.Text = "لا" Then
            Nose2_2_2_2.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub Nose2_2_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class