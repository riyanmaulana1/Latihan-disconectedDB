<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        Label2 = New Label()
        no = New TextBox()
        satuan = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F)
        Label1.Location = New Point(37, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(33, 23)
        Label1.TabIndex = 0
        Label1.Text = "No"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.Location = New Point(414, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 23)
        Label2.TabIndex = 0
        Label2.Text = "Satuan"
        ' 
        ' no
        ' 
        no.Font = New Font("Segoe UI", 10F)
        no.Location = New Point(76, 34)
        no.Name = "no"
        no.Size = New Size(239, 30)
        no.TabIndex = 1
        ' 
        ' satuan
        ' 
        satuan.Font = New Font("Segoe UI", 10F)
        satuan.Location = New Point(493, 34)
        satuan.Name = "satuan"
        satuan.Size = New Size(239, 30)
        satuan.TabIndex = 1
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Font = New Font("Segoe UI", 10F)
        btnSimpan.Location = New Point(395, 83)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 29)
        btnSimpan.TabIndex = 2
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Font = New Font("Segoe UI", 10F)
        btnUbah.Location = New Point(495, 83)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(94, 29)
        btnUbah.TabIndex = 2
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Font = New Font("Segoe UI", 10F)
        btnHapus.Location = New Point(595, 83)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 2
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10F)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.Location = New Point(37, 118)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(720, 320)
        DataGridView1.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(satuan)
        Controls.Add(no)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents no As TextBox
    Friend WithEvents satuan As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents DataGridView1 As DataGridView

End Class
