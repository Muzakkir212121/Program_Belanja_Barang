Public Class Form2
    Public NomorAntrian As String = ""
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labelNo2.Text = NomorAntrian
    End Sub

    Private Sub BtnPilih_Click(sender As Object, e As EventArgs) Handles BtnPilih.Click
        Form1.Label13.Text = TxtNP.Text
        Me.Close()
    End Sub
End Class