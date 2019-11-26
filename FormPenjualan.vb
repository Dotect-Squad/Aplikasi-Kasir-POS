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
        
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        jam.Text = DateTime.Now.ToString("hh:mm:ss")
        tanggal.Text = DateTime.Now.ToString("yyyy-MM-dd")
    End Sub

    Sub penguranganStok()
        
    End Sub

    Sub inputBarang()
        
    End Sub


    Private Sub qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles qty.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Sub hitungSubTotal()
       
    End Sub

    Sub hitungKembalian()
        
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