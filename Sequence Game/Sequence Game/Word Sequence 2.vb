Public Class Word_Sequence_2
    Dim nilai As Integer
    Dim jumlah As Integer = 0
    Dim rnd As New Random

    Private Sub GunaCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles GunaCheckBox1.CheckedChanged
        nilai = +50
        jumlah = jumlah + (nilai)
    End Sub

    Private Sub checkbox2a_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox2a.CheckedChanged
        nilai = +50
        jumlah = jumlah + (nilai)
    End Sub

    Private Sub GunaCheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles GunaCheckBox3.CheckedChanged
        nilai = +50
        jumlah = jumlah + (nilai)
    End Sub

    Private Sub GunaCheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles GunaCheckBox4.CheckedChanged
        nilai = +50
        jumlah = jumlah + (nilai)
    End Sub

    Private Sub checkbox6a_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox6a.CheckedChanged
        nilai = +50
        jumlah = jumlah + (nilai)
    End Sub

    Private Sub GunaCheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles GunaCheckBox5.CheckedChanged
        nilai = +50
        jumlah = jumlah + (nilai)
    End Sub

    Private Sub checkbox1a_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox1a.CheckedChanged
        nilai = -20
        jumlah = jumlah + (nilai)
    End Sub

    Private Sub GunaCheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles GunaCheckBox2.CheckedChanged
        nilai = -20
        jumlah = jumlah + (nilai)
    End Sub

    Private Sub checkbox3a_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox3a.CheckedChanged
        nilai = -20
        jumlah = jumlah + (nilai)
    End Sub

    Private Sub checkbox4a_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox4a.CheckedChanged
        nilai = -20
        jumlah = jumlah + (nilai)
    End Sub

    Private Sub checkbox5a_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox5a.CheckedChanged
        nilai = -20
        jumlah = jumlah + (nilai)
    End Sub

    Private Sub checkbox7a_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox7a.CheckedChanged
        nilai = -20
        jumlah = jumlah + (nilai)
    End Sub
    Private Sub Word_Sequence_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        jumlah = jumlah + (nilai)

        random1.ForeColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
        random2.ForeColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
        random3.ForeColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
        random4.ForeColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
        random5.ForeColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
        random6.ForeColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
        random7.ForeColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
    End Sub

    Private Sub GunaButton7_Click(sender As Object, e As EventArgs) Handles GunaButton7.Click
        Score.Label3.Text = jumlah
        Me.Hide()
        Score.Show()
    End Sub
End Class