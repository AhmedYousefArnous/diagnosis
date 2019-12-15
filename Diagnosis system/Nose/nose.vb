Public Class nose


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles yes.Click

        If TextBox1.Text = "نعم" Then
            Nose2.show()
            Me.Hide()

        End If

        If TextBox1.Text = "لا" Then
            NoseII.Show()
            Me.Hide()

        End If


    End Sub
End Class