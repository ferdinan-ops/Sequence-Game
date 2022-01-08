Public Class Choose_Game

    Private Sub GunaButton7_Click(sender As Object, e As EventArgs) Handles GunaButton7.Click
        Color_Sequence.GunaElipsePanel3.Visible = True
        Color_Sequence.Label20.Text = 10
        Color_Sequence.Label20.ForeColor = Color.FromArgb(0, 192, 0)
        Color_Sequence.GunaCircleProgressBar1.ProgressMaxColor = Color.FromArgb(0, 192, 192)
        Color_Sequence.GunaCircleProgressBar1.ProgressMinColor = Color.FromArgb(0, 192, 0)
        Me.Hide()
        Color_Sequence.Show()
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Word_Sequence.GunaElipsePanel3.Visible = True
        Word_Sequence.Label20.Text = 10
        Word_Sequence.Label20.ForeColor = Color.FromArgb(0, 192, 0)
        Word_Sequence.GunaCircleProgressBar1.ProgressMaxColor = Color.FromArgb(0, 192, 192)
        Word_Sequence.GunaCircleProgressBar1.ProgressMinColor = Color.FromArgb(0, 192, 0)
        Me.Hide()
        Word_Sequence.Show()
    End Sub
End Class