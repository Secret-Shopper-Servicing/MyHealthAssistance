Public Class Main

    Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
        If MsgBox("Are you Sure to close ????", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "MyQuestion") = MsgBoxResult.Yes Then
            MessageBox.Show("An error has occured.", "FU***K", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.PlannerNotes
        My.Computer.Audio.Play(My.Resources.MyHealthAssistanceGrooves, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        My.Settings.PlannerNotes = TextBox1.Text
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://secretshopperservicing.cf/")
    End Sub


    Private Sub Button1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.DoubleClick
        Application.Exit()
        End
    End Sub
End Class
