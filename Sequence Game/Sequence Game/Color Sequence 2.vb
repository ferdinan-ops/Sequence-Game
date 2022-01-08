Public Class Color_Sequence_2
    Dim nilai As Integer
    Dim jumlah As Integer = 0
    Dim rnd As New Random

    Private Sub GunaCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles GunaCheckBox1.CheckedChanged
        nilai = +50
        jumlah = jumlah + (nilai)
    End Sub

    Private Sub GunaCheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles GunaCheckBox2.CheckedChanged
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

    Private Sub GunaCheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles GunaCheckBox5.CheckedChanged
        nilai = +50
        jumlah = jumlah + (nilai)
    End Sub

    Private Sub checkbox7a_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox7a.CheckedChanged
        nilai = +50
        jumlah = jumlah + (nilai)
    End Sub

    Private Sub checkbox1a_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox1a.CheckedChanged
        nilai = -20
        jumlah = jumlah + (nilai)
    End Sub

    Private Sub checkbox2a_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox2a.CheckedChanged
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

    Private Sub checkbox6a_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox6a.CheckedChanged
        nilai = -20
        jumlah = jumlah + (nilai)
    End Sub
    Private Sub jawaban_sequence_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        random1a.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
        random1b.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
        random1c.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
        random2a.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
        random2b.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
        random2c.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
        random3a.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
        random3b.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
        random3c.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
        random4a.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
        random4b.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
        random4c.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
        random5a.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
        random5b.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
        random5c.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
        random6a.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
        random6b.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
        random6c.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))

        jumlah = jumlah + (nilai)

    End Sub

    Private Sub GunaButton7_Click(sender As Object, e As EventArgs) Handles GunaButton7.Click
        Score.Label3.Text = jumlah
        Label19.Text = jumlah
        Me.Hide()
        Score.Show()
    End Sub
End Class