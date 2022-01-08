Public Class Word_Sequence

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        Timer1.Interval = 1000
        If Label20.Text = 4 Then
            Label20.ForeColor = Color.Red
            Label20.Text = Val(Label20.Text) - 1
            GunaCircleProgressBar1.ProgressMaxColor = Color.Red
            GunaCircleProgressBar1.ProgressMinColor = Color.MistyRose
        ElseIf Label20.Text = 0 Then
            Timer1.Enabled = False
            GunaCircleProgressBar1.Animated = False
            Me.Hide()
            Word_Sequence_2.Show()
        Else
            Label20.Text = Val(Label20.Text) - 1
        End If
    End Sub
    Private Sub GunaButton7_Click(sender As Object, e As EventArgs) Handles GunaButton7.Click
        GunaElipsePanel3.Visible = False
        GunaCircleProgressBar1.Animated = True
        If Timer1.Enabled = True Then
            Timer1.Start()
        Else
            Label20.Text = 10
            Timer1.Start()
        End If
    End Sub
End Class