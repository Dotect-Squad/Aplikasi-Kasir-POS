Imports System.Data.Odbc
Public Class FormAddBarang

    Private Sub FormAddBarang_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            If id.Text = "" Then
                Call insertData()
            Else
                Call updateData()
            End If
        End If
    End Sub

    Private Sub FormAddBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call combobox()
        KeyPreview = True
    End Sub

    Sub combobox()
        
    End Sub

    Sub showCategoriById()
        
    End Sub

    Private Sub namaKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles namaKategori.SelectedIndexChanged, namaKategori.SelectedIndexChanged
        Call showCategoriById()
    End Sub

    Private Sub kodeBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles kodeBarang.KeyPress
        If kodeBarang.Text.Length >= 10 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub namaBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles namaBarang.KeyPress
        If namaBarang.Text.Length >= 35 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub stok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles stok.KeyPress
        If stok.Text.Length >= 4 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub stokMax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles stok.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
        If Not id.Text = "" Then
            e.Handled = True
        End If
    End Sub

    Private Sub beliMax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles beli.KeyPress
        If beli.Text.Length >= 9 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
        If Not id.Text = "" Then
            e.Handled = True
        End If
    End Sub

    Private Sub beli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles beli.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub jual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jual.KeyPress
        If jual.Text.Length >= 10 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
        If Not id.Text = "" Then
            e.Handled = True
        End If
    End Sub

    Private Sub jualMax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jual.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub satuan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles satuan.KeyPress
        If satuan.Text.Length >= 15 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub keterangan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles keterangan.KeyPress
        If keterangan.Text.Length >= 130 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub keteranganSubmit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles keterangan.KeyPress

    End Sub

    Sub switchPanel(ByVal panel As Form)
        MainForm.Panel2.Controls.Clear()
        panel.TopLevel = False
        MainForm.Panel2.Controls.Add(panel)
        panel.Show()
    End Sub

    Sub kondisiAwal()
        kodeBarang.Text = ""
        namaBarang.Text = ""
        satuan.Text = ""
        beli.Text = ""
        jual.Text = ""
        keterangan.Text = ""
        stok.Text = ""
        kategoriID.Text = ""
        id.Text = ""
    End Sub

    Sub insertData()
        
    End Sub

    Sub updateData()
        
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tanggalInput.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        tanggalUpdate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub

    Private Sub beli_OnValueChanged(sender As Object, e As EventArgs) Handles beli.OnValueChanged

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        If id.Text = "" Then
            Call insertData()
        Else
            Call updateData()
        End If
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        switchPanel(FormBarang)
        Call kondisiAwal()
        'Me.Close()
    End Sub

    Private Sub stok_OnValueChanged(sender As Object, e As EventArgs) Handles stok.OnValueChanged

    End Sub
End Class