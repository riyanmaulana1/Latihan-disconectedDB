Imports MySql.Data.MySqlClient
''' <summary>
''' #disconected Environment
'''     merupakan penggunaan database secaratidak langsung
'''     data dikumpulkan secara batch kedalam data set lokal,(tidak secara terus menerus terhubung dengan database )
'''     segala bentuk perubahan data tersimpan di data set (database lokal) yang kemudian dataset mentransfer datanya secara batch
'''     sql_adapter ->dataset->database
'''     
''' #perbedaann terkineksi dantidak terkoneksi
'''  - terkoneksi membutuhkan method open() dan close() agar koneksi tidak menumpuk
'''  - tidak terkoneksi tidak memerlukannya
'''  
''' </summary>
Public Class Form1
    Dim conn As New MySqlConnection 'connection  string
    Dim da As New MySqlDataAdapter  'dataAdapter
    Dim ds As New DataSet   'dataset
    Sub koneksi()
        conn = New MySqlConnection("server=localhost;user=root;password=;database=HR;port=3306;")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        da = New MySqlDataAdapter("select no,satuan from tblsatuan;", conn)
        ' ini sama dengan mysqlcommand di database terkonesi, namun ini tidak memerlukan open dan close 
        da.Fill(ds, "xxx")
        'memasukkan data dari database ke dataset dengan nama table di dataset menjadi XXX
        'ini sama dengan executeReader di database terkoneksi, sedngkan ini menggunakan fill untuk memasukkan data ke dataset
        DataGridView1.DataSource = ds.Tables("xxx").DefaultView
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        da = New MySqlDataAdapter("insert into tblsatuan values ('" & no.Text & "','" &
satuan.Text & "')", conn)
        da.Fill(ds, "xxx")
        MsgBox("data berhasil disimpan")
        ds.Clear()
        da = New MySqlDataAdapter("select no, satuan from tblsatuan", conn)
        da.Fill(ds, "xxx")
        DataGridView1.DataSource = ds.Tables("xxx").DefaultView
        no.Text = ""
        satuan.Text = ""
        da = New MySqlDataAdapter("SELECT IFNULL(MAX(CAST(no AS UNSIGNED)), 0) + 1 FROM tblsatuan", conn)
        da.Fill(ds, "xx1")
        no.Text = ds.Tables("xx1").Rows(0).Item(0).ToString
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        da = New MySqlDataAdapter("update tblsatuan set satuan='" & satuan.Text & "'
where no='" & no.Text & "'", conn)
        da.Fill(ds, "xxx")
        MsgBox("data berhasil diubah")
        ds.Clear()
        da = New MySqlDataAdapter("select no, satuan from tblsatuan", conn)
        da.Fill(ds, "xxx")
        DataGridView1.DataSource = ds.Tables("xxx").DefaultView
        no.Text = ""
        satuan.Text = ""
        da = New MySqlDataAdapter("SELECT IFNULL(MAX(CAST(no AS UNSIGNED)), 0) + 1 FROM tblsatuan", conn)
        da.Fill(ds, "xx1")
        no.Text = ds.Tables("xx1").Rows(0).Item(0).ToString
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        da = New MySqlDataAdapter("delete from tblsatuan where no='" & no.Text & "'", conn)
        da.Fill(ds, "xxx")
        MsgBox("data berhasil dihapus")
        ds.Clear()
        da = New MySqlDataAdapter("select no, satuan from tblsatuan", conn)
        da.Fill(ds, "xxx")
        DataGridView1.DataSource = ds.Tables("xxx").DefaultView
        no.Text = ""
        satuan.Text = ""
        da = New MySqlDataAdapter("SELECT IFNULL(MAX(CAST(no AS UNSIGNED)), 0) + 1 FROM tblsatuan", conn)
        da.Fill(ds, "xx1")
        no.Text = ds.Tables("xx1").Rows(0).Item(0).ToString
    End Sub
End Class
