Imports System.Data.Odbc
Public Class TambahStok

    Public namaBarang As String
    Public jam As String

    Private Sub TambahStok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loadTambahStok()
    End Sub

    Sub loadTambahStok()
        Call kodeOtomatis()
        kodebarang.Text = ""
        kodebarang.Focus()
        oldstock.Text = 0
        newstock.Text = 0
        keterangan.Text = ""
        BunifuCustomDataGrid2.Rows.Clear()
        petugas.Text = MainForm.btnLogin.Text
        newstock.Text = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tanggal.Text = DateTime.Now.ToString("yyyy-MM-dd")
        jam = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Sub kodeOtomatis()
       
    End Sub

    Sub inputBarang()
        
    End Sub

    Sub tambahStok()
        
    End Sub

    Sub simpanStok()
        
    End Sub

    Private Sub newstock_KeyDown(sender As Object, e As KeyEventArgs) Handles newstock.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call tambahStok()
        End If
    End Sub


    Private Sub newstock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles newstock.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Or e.KeyChar = "-") Then e.Handled = True
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        KoreksiBarang.Show()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Call tambahStok()
    End Sub

    Private Sub kodebarang_KeyDown(sender As Object, e As KeyEventArgs) Handles kodebarang.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call inputBarang()
        End If
    End Sub

    Private Sub kodebarang_TextChanged(sender As Object, e As EventArgs) Handles kodebarang.TextChanged

    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        
    End Sub

    Private Sub newstock_MouseLeave(sender As Object, e As EventArgs) Handles newstock.MouseLeave
        
    End Sub

    Private Sub newstock_TextChanged(sender As Object, e As EventArgs) Handles newstock.TextChanged

    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        MainForm.switchPanel(KoreksiStok)
    End Sub
End Class