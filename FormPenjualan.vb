Imports System.Data.Odbc
Public Class FormPenjualan

    Private Sub FormPenjualan_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            DetailBarang.Show()
        End If

    End Sub

    Private Sub FormPenjualan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub FormPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
        Call loadDetail()
        If Not BunifuCustomDataGrid1.Rows.Count = 0 Then
            Call totalQty()
            Call hitungSubTotal()
        End If
    End Sub

    Sub kondisiAwal()
        Call kodeOtomatis()
        txtIdAdmin.Text = MainForm.lblIdAdmin.Text
        namaKasir.Text = MainForm.btnLogin.Text
        kodeBarang.Text = ""
        qty.Text = "1"
        kembali.Text = ""
        bayar.Text = ""
        Total.Text = "0"
        Diskon.Text = "0"
    End Sub

    Sub kodeOtomatis()
        Call koneksi()
        Cmd = New OdbcCommand("select * from penjualan where id_penjualan in (select max(id_penjualan) from penjualan)", Conn)
        Dim urutan As String
        Dim hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            urutan = "T" + Format(Now, "yyyyMMdd") + "001"
        Else
            If Microsoft.VisualBasic.Left(Rd.Item("id_penjualan"), 9) <> "T" + Format(Now, "yyyyMMdd") Then
                urutan = "T" + Format(Now, "yyyyMMdd") + "001"
            Else
                hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 9) + 1
                urutan = "T" + Format(Now, "yyyyMMdd") + Microsoft.VisualBasic.Right("000" & hitung, 3)
            End If
        End If
        noTransaksi.Text = urutan
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        jam.Text = DateTime.Now.ToString("hh:mm:ss")
        tanggal.Text = DateTime.Now.ToString("yyyy-MM-dd")
    End Sub

    Sub penguranganStok()
        Call koneksi()
        Cmd = New OdbcCommand("SELECT * FROM barang WHERE id_barang='" & kodeBarang.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.Item("stok") = 0 Then
            MsgBox("Stok tidak tersedia !", vbInformation)
        Else
            Cmd = New OdbcCommand("UPDATE barang SET stok = stok - '" & qty.Text & "' WHERE id_barang = '" & kodeBarang.Text & "'", Conn)
            Cmd.ExecuteNonQuery()
        End If
    End Sub

    Sub inputBarang()
        Dim harga_pokok As Integer
        Call koneksi()
        Cmd = New OdbcCommand("SELECT * FROM barang WHERE id_barang='" & kodeBarang.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            MsgBox("Kode Barang tidak tersedia !", vbInformation)
        ElseIf Rd.Item("stok") < 0 Or Rd.Item("stok") < qty.Text Then
            MsgBox("Stok tidak tersedia !", vbInformation)
        Else
            Cmd = New OdbcCommand("UPDATE barang SET stok = stok - '" & qty.Text & "' WHERE id_barang = '" & kodeBarang.Text & "'", Conn)
            Cmd.ExecuteNonQuery()
            namaBarang.Text = Rd.Item("nama_barang")
            hargaSatuan.Text = Rd.Item("harga_jual")
            harga_pokok = Rd.Item("harga_beli")
            Cmd = New OdbcCommand("INSERT INTO detail_penjualan (id_penjualan,id_barang,nama_barang,harga_pokok,harga_satuan,qty,subtotal,diskon,netto,total_pokok) VALUES ('" & noTransaksi.Text & "', '" & kodeBarang.Text & "','" & namaBarang.Text & "','" & harga_pokok & "','" & hargaSatuan.Text & "','" & qty.Text & "','" & Val(hargaSatuan.Text) * Val(qty.Text) & "','" & Diskon.Text & "','" & (Val(hargaSatuan.Text) * Val(qty.Text)) - Diskon.Text & "','" & Val(harga_pokok) * Val(qty.Text) & "')", Conn)
            Cmd.ExecuteNonQuery()
            Call loadDetail()
            Call hitungSubTotal()
            Call totalQty()
            kodeBarang.Text = ""
        End If
    End Sub


    Private Sub qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles qty.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Sub hitungSubTotal()
        Dim count As Integer = 0
        Call koneksi()
        Cmd = New OdbcCommand("SELECT SUM(netto) FROM detail_penjualan WHERE id_penjualan='" & noTransaksi.Text & "'", Conn)
        count = Cmd.ExecuteScalar
        Total.Text = count
    End Sub

    Sub hitungKembalian()
        Dim kembalian As Integer
        If bayar.Text = "" Then
            kembali.Text = "0"
        Else
            kembalian = Val(bayar.Text) - Val(Total.Text)
            kembali.Text = kembalian
        End If
    End Sub

    Private Sub bayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles bayar.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        If (Total.Text = "0") Then
            e.Handled = True
        End If
    End Sub

    Private Sub bayar_TextChanged(sender As Object, e As EventArgs) Handles bayar.TextChanged
        Call hitungKembalian()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        DetailBarang.ShowDialog()
    End Sub

    Sub totalQty()
        
    End Sub

    Sub loadDetail()
        Call koneksi()
        Da = New OdbcDataAdapter("SELECT id_barang, nama_barang,harga_pokok,harga_satuan,SUM(qty) AS qty,SUM(subtotal) AS SubTotal,SUM(diskon) as diskon,SUM(netto) AS netto,SUM(total_pokok) AS total_pokok FROM detail_penjualan WHERE id_penjualan='" & noTransaksi.Text & "' GROUP BY id_barang", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "detail")
        BunifuCustomDataGrid1.DataSource = Ds.Tables("detail")
        BunifuCustomDataGrid1.ReadOnly = True
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click

    End Sub

    Sub saveData()
        
    End Sub

    Private Sub kodeBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles kodeBarang.KeyPress
        If e.KeyChar = Chr(13) Then
            Call inputBarang()
        End If
    End Sub

    Private Sub bayar_KeyDown(sender As Object, e As KeyEventArgs) Handles bayar.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call saveData()
        End If
    End Sub

    Private Sub Diskon_TextChanged(sender As Object, e As EventArgs) Handles Diskon.TextChanged

    End Sub

    Private Sub Diskon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Diskon.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub Diskon_Leave(sender As Object, e As EventArgs) Handles Diskon.Leave
        If Diskon.Text = "" Then
            Diskon.Text = "0"
        End If
    End Sub

    Private Sub Diskon_KeyDown(sender As Object, e As KeyEventArgs) Handles Diskon.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call inputBarang()
        End If
    End Sub

    Private Sub qty_Leave(sender As Object, e As EventArgs) Handles qty.Leave
        If qty.Text = "" Then
            qty.Text = "1"
        End If
    End Sub

    Private Sub qty_KeyDown(sender As Object, e As KeyEventArgs) Handles qty.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call inputBarang()
        End If
    End Sub

    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellContentClick

    End Sub

    Private Sub BunifuCustomDataGrid1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellDoubleClick
        
    End Sub

    Private Sub namaKasir_TextChanged(sender As Object, e As EventArgs) Handles namaKasir.TextChanged

    End Sub

    Private Sub kodeBarang_TextChanged(sender As Object, e As EventArgs) Handles kodeBarang.TextChanged

    End Sub
End Class