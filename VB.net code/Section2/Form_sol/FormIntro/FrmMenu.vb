Public Class FrmMenu

    Private Sub FrmMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel2.Text = DateTime.Now
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = DateTime.Now
    End Sub

    Private Sub FrmMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("แน่ใจว่าต้องการออกจากโปรแกรม?", "ข้อความจากระบบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
End Class