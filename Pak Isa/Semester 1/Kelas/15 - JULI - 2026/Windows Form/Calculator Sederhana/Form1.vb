Public Class Form1

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim angka1 As Integer = Convert.ToInt32(txtAngka1.Text)
        Dim angka2 As Integer = Convert.ToInt32(txtAngka2.Text)

        Dim hasil As Integer = angka1 + angka2

        lblHasil.Text = "Hasil : " & hasil
    End Sub

    Private Sub btnKurang_Click(sender As Object, e As EventArgs) Handles btnKurang.Click
        Dim angka1 As Integer = Convert.ToInt32(txtAngka1.Text)
        Dim angka2 As Integer = Convert.ToInt32(txtAngka2.Text)

        Dim hasil As Integer = angka1 - angka2

        lblHasil.Text = "Hasil : " & hasil
    End Sub

    Private Sub btnKali_Click(sender As Object, e As EventArgs) Handles btnKali.Click
        Dim angka1 As Integer = Convert.ToInt32(txtAngka1.Text)
        Dim angka2 As Integer = Convert.ToInt32(txtAngka2.Text)

        Dim hasil As Integer = angka1 * angka2

        lblHasil.Text = "Hasil : " & hasil
    End Sub

    Private Sub btnBagi_Click(sender As Object, e As EventArgs) Handles btnBagi.Click
        Dim angka1 As Double = Convert.ToDouble(txtAngka1.Text)
        Dim angka2 As Double = Convert.ToDouble(txtAngka2.Text)

        If angka2 = 0 Then
            MessageBox.Show("Tidak bisa membagi dengan nol!")
            Exit Sub
        End If

        Dim hasil As Double = angka1 / angka2

        lblHasil.Text = "Hasil : " & hasil
    End Sub

End Class