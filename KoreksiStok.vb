Imports System.Data.Odbc
Public Class KoreksiStok

    Dim kodeStok As String

    Private Sub BunifuCustomDataGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellClick
        
    End Sub

    Private Sub KoreksiStok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilData()
    End Sub

    Sub tampilData()
        Call koneksi()
        Da = New OdbcDataAdapter("SELECT id,tanggal,jam,keterangan,admin FROM koreksi_stok GROUP BY id ORDER BY tanggal DESC", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "kr")
        BunifuCustomDataGrid1.DataSource = Ds.Tables("kr")
        BunifuCustomDataGrid1.ReadOnly = True
        BunifuCustomDataGrid1.Enabled = True
    End Sub

    Sub searchDataByID()
        
    End Sub

    Sub searchDataByTanggal()
        
    End Sub

    Sub searchDataByKeterangan()
        
    End Sub

    Private Sub search_OnTextChange(sender As Object, e As EventArgs) Handles searchItem.OnTextChange
        
    End Sub

    Sub hapusData()
        
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Call hapusData()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        MainForm.switchPanel(TambahStok)
    End Sub

    Private Sub BunifuCustomDataGrid1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellDoubleClick

    End Sub
End Class