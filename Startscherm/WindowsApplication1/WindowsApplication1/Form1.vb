Public Class Form1

    Private Sub RadioButton1_Click(sender As Object, e As System.EventArgs) Handles RadioButton1.Click
        PictureBox1.Image = My.Resources.afb1
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As System.EventArgs) Handles RadioButton2.Click
        PictureBox1.Image = My.Resources.afb2
    End Sub

    Private Sub RadioButton3_Click(sender As Object, e As System.EventArgs) Handles RadioButton3.Click
        PictureBox1.Image = My.Resources.afb3
    End Sub


    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged

    End Sub
End Class
