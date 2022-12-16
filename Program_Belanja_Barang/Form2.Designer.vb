<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelNo2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNP = New System.Windows.Forms.TextBox()
        Me.BtnPilih = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(156, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.UseWaitCursor = True
        '
        'labelNo2
        '
        Me.labelNo2.AutoSize = True
        Me.labelNo2.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelNo2.Location = New System.Drawing.Point(300, 88)
        Me.labelNo2.Name = "labelNo2"
        Me.labelNo2.Size = New System.Drawing.Size(16, 23)
        Me.labelNo2.TabIndex = 23
        Me.labelNo2.Text = "-"
        Me.labelNo2.UseWaitCursor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(153, 89)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(143, 23)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Nomor Pelanggan :"
        Me.Label12.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(160, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 23)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nama Pelanggan :"
        Me.Label2.UseWaitCursor = True
        '
        'TxtNP
        '
        Me.TxtNP.Location = New System.Drawing.Point(301, 149)
        Me.TxtNP.Name = "TxtNP"
        Me.TxtNP.Size = New System.Drawing.Size(166, 23)
        Me.TxtNP.TabIndex = 25
        Me.TxtNP.UseWaitCursor = True
        '
        'BtnPilih
        '
        Me.BtnPilih.Location = New System.Drawing.Point(299, 204)
        Me.BtnPilih.Name = "BtnPilih"
        Me.BtnPilih.Size = New System.Drawing.Size(168, 23)
        Me.BtnPilih.TabIndex = 26
        Me.BtnPilih.Text = "Pilih"
        Me.BtnPilih.UseVisualStyleBackColor = True
        Me.BtnPilih.UseWaitCursor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 327)
        Me.Controls.Add(Me.BtnPilih)
        Me.Controls.Add(Me.TxtNP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.labelNo2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form2"
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents labelNo2 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNP As TextBox
    Friend WithEvents BtnPilih As Button
End Class
