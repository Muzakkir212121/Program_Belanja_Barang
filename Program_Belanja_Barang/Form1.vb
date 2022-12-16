Public Class Form1
    Dim count As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbJenis.Items.Add("Makanan")
        CmbJenis.Items.Add("Minuman")
        CmbJenis.Items.Add("DLL")
    End Sub

    Private Sub CmbJenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbJenis.SelectedIndexChanged
        If CmbJenis.Text = "Makanan" Then
            CmbNama.Items.Clear()
            CmbNama.Text = ""
            CmbNama.Items.Add("Roti")
            CmbNama.Items.Add("Banana Cake")
            CmbNama.Items.Add("Bolu")
            CmbNama.Items.Add("Tar")
        ElseIf CmbJenis.Text = "Minuman" Then
            CmbNama.Items.Clear()
            CmbNama.Text = ""
            CmbNama.Items.Add("Susu")
            CmbNama.Items.Add("Soda")
            CmbNama.Items.Add("Jus")
            CmbNama.Items.Add("Air Mineral")
        ElseIf CmbJenis.Text = "DLL" Then
            CmbNama.Items.Clear()
            CmbNama.Text = ""
            CmbNama.Items.Add("Coklat")
            CmbNama.Items.Add("Selai")
            CmbNama.Items.Add("Mayones")
            CmbNama.Items.Add("Topping")
        End If
    End Sub

    Private Sub CmbNama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbNama.SelectedIndexChanged
        If CmbNama.Text = "Roti" Then
            TxtHarga.Text = 27000
        ElseIf CmbNama.Text = "Banana Cake" Then
            TxtHarga.Text = 19000
        ElseIf CmbNama.Text = "Bolu" Then
            TxtHarga.Text = 25000
        ElseIf CmbNama.Text = "Tar" Then
            TxtHarga.Text = 119000
        ElseIf CmbNama.Text = "Susu" Then
            TxtHarga.Text = 9000
        ElseIf CmbNama.Text = "Soda" Then
            TxtHarga.Text = 7000
        ElseIf CmbNama.Text = "Air Mineral" Then
            TxtHarga.Text = 5000
        ElseIf CmbNama.Text = "Coklat" Then
            TxtHarga.Text = 12000
        ElseIf CmbNama.Text = "Selai" Then
            TxtHarga.Text = 7000
        ElseIf CmbNama.Text = "Mayones" Then
            TxtHarga.Text = 8000
        ElseIf CmbNama.Text = "Topping" Then
            TxtHarga.Text = 5000
        End If
    End Sub

    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        TxtTotalBelanja.Text = Val(TxtHarga.Text) * Val(TxtJumlah.Text)
        If TxtTotalBelanja.Text >= 1000000 Then
            TxtPotongan.Text = 50000
        Else
            TxtPotongan.Text = 0
        End If
        TxtTotalBayar.Text = Val(TxtTotalBelanja.Text) - Val(TxtPotongan.Text)
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        End
    End Sub

    Private Sub TxtJumlah_TextChanged(sender As Object, e As EventArgs) Handles TxtJumlah.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        count += 1
        LabelNo.Text = count
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnPP.Click
        Dim form As New Form2
        form.NomorAntrian = LabelNo.Text
        form.Show()
    End Sub
End Class
