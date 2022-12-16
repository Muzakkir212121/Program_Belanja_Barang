<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CmbJenis = New System.Windows.Forms.ComboBox()
        Me.CmbNama = New System.Windows.Forms.ComboBox()
        Me.TxtHarga = New System.Windows.Forms.TextBox()
        Me.TxtJumlah = New System.Windows.Forms.TextBox()
        Me.TxtTotalBelanja = New System.Windows.Forms.TextBox()
        Me.TxtPotongan = New System.Windows.Forms.TextBox()
        Me.TxtTotalBayar = New System.Windows.Forms.TextBox()
        Me.BtnHitung = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnPP = New System.Windows.Forms.Button()
        Me.LabelNo = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Subheading", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(247, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PROGRAM BELANJA BARANG"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(417, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jenis Barang :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(410, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Barang :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(460, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Harga :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(452, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jumlah :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(397, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total Belanja :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(429, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 24)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Potongan :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(411, 309)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 24)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Total Bayar :"
        '
        'CmbJenis
        '
        Me.CmbJenis.FormattingEnabled = True
        Me.CmbJenis.Location = New System.Drawing.Point(527, 75)
        Me.CmbJenis.Name = "CmbJenis"
        Me.CmbJenis.Size = New System.Drawing.Size(175, 23)
        Me.CmbJenis.TabIndex = 8
        '
        'CmbNama
        '
        Me.CmbNama.FormattingEnabled = True
        Me.CmbNama.Location = New System.Drawing.Point(527, 110)
        Me.CmbNama.Name = "CmbNama"
        Me.CmbNama.Size = New System.Drawing.Size(175, 23)
        Me.CmbNama.TabIndex = 9
        '
        'TxtHarga
        '
        Me.TxtHarga.Location = New System.Drawing.Point(528, 141)
        Me.TxtHarga.Name = "TxtHarga"
        Me.TxtHarga.Size = New System.Drawing.Size(130, 23)
        Me.TxtHarga.TabIndex = 10
        '
        'TxtJumlah
        '
        Me.TxtJumlah.Location = New System.Drawing.Point(527, 171)
        Me.TxtJumlah.Name = "TxtJumlah"
        Me.TxtJumlah.Size = New System.Drawing.Size(130, 23)
        Me.TxtJumlah.TabIndex = 11
        '
        'TxtTotalBelanja
        '
        Me.TxtTotalBelanja.Location = New System.Drawing.Point(529, 252)
        Me.TxtTotalBelanja.Name = "TxtTotalBelanja"
        Me.TxtTotalBelanja.Size = New System.Drawing.Size(173, 23)
        Me.TxtTotalBelanja.TabIndex = 12
        '
        'TxtPotongan
        '
        Me.TxtPotongan.Location = New System.Drawing.Point(529, 284)
        Me.TxtPotongan.Name = "TxtPotongan"
        Me.TxtPotongan.Size = New System.Drawing.Size(173, 23)
        Me.TxtPotongan.TabIndex = 13
        '
        'TxtTotalBayar
        '
        Me.TxtTotalBayar.Location = New System.Drawing.Point(529, 314)
        Me.TxtTotalBayar.Name = "TxtTotalBayar"
        Me.TxtTotalBayar.Size = New System.Drawing.Size(173, 23)
        Me.TxtTotalBayar.TabIndex = 14
        '
        'BtnHitung
        '
        Me.BtnHitung.Location = New System.Drawing.Point(96, 304)
        Me.BtnHitung.Name = "BtnHitung"
        Me.BtnHitung.Size = New System.Drawing.Size(82, 32)
        Me.BtnHitung.TabIndex = 15
        Me.BtnHitung.Text = "Hitung"
        Me.BtnHitung.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Location = New System.Drawing.Point(247, 304)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(82, 33)
        Me.BtnBatal.TabIndex = 16
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 425)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(332, 15)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "*Potongan Harga 50.000 untuk setiap pembelanjaan 1.000.000"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(96, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 15)
        Me.Label10.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(169, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 15)
        Me.Label11.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(71, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 23)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Nama Pelanggan :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(218, 76)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 23)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "-"
        '
        'BtnPP
        '
        Me.BtnPP.Location = New System.Drawing.Point(74, 102)
        Me.BtnPP.Name = "BtnPP"
        Me.BtnPP.Size = New System.Drawing.Size(126, 23)
        Me.BtnPP.TabIndex = 22
        Me.BtnPP.Text = "Pilih Pelanggan"
        Me.BtnPP.UseVisualStyleBackColor = True
        '
        'LabelNo
        '
        Me.LabelNo.AutoSize = True
        Me.LabelNo.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelNo.Location = New System.Drawing.Point(212, 148)
        Me.LabelNo.Name = "LabelNo"
        Me.LabelNo.Size = New System.Drawing.Size(23, 23)
        Me.LabelNo.TabIndex = 24
        Me.LabelNo.Text = " 0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label15.Location = New System.Drawing.Point(89, 149)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(114, 23)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "No Pelanggan :"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(73, 178)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 23)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Tambah"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LabelNo)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.BtnPP)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnHitung)
        Me.Controls.Add(Me.TxtTotalBayar)
        Me.Controls.Add(Me.TxtPotongan)
        Me.Controls.Add(Me.TxtTotalBelanja)
        Me.Controls.Add(Me.TxtJumlah)
        Me.Controls.Add(Me.TxtHarga)
        Me.Controls.Add(Me.CmbNama)
        Me.Controls.Add(Me.CmbJenis)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CmbJenis As ComboBox
    Friend WithEvents CmbNama As ComboBox
    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents TxtJumlah As TextBox
    Friend WithEvents TxtTotalBelanja As TextBox
    Friend WithEvents TxtPotongan As TextBox
    Friend WithEvents TxtTotalBayar As TextBox
    Friend WithEvents BtnHitung As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents BtnPP As Button
    Friend WithEvents LabelNo As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Button2 As Button
End Class
