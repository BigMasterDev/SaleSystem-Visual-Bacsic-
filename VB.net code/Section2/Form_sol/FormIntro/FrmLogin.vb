Public Class FrmLogin

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()

    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
        TextBox1.Text = "admin"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmMenu.Show()
        Me.Hide()

    End Sub
End Class
