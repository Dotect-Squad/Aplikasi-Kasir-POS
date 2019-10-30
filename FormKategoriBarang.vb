Imports System.Data.Odbc
Public Class FormKategoriBarang
    Private Sub FormKategoriBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
        Call tampilData()
        Call kondisiAwal()
    End Sub

    Sub tampilData()
        
    End Sub

    Sub kondisiAwal()
        namaKategori.Text = ""
        namaKategori.Focus()
        Call tampilData()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Call inputData()
    End Sub

    Sub inputData()
        
    End Sub

    Private Sub FormKategoriBarang_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call inputData()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub namaKategori_OnValueChanged(sender As Object, e As EventArgs) Handles namaKategori.OnValueChanged

    End Sub

    Private Sub namaKategori_KeyPress(sender As Object, e As KeyPressEventArgs) Handles namaKategori.KeyPress
        If namaKategori.Text.Length >= 13 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellContentClick

    End Sub

    Private Sub BunifuCustomDataGrid1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellDoubleClick
        
    End Sub
End Class