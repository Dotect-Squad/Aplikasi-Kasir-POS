Imports System.Data.Odbc
Public Class DetailBarang

    Sub tampilBarang()
        
    End Sub

    Private Sub DetailBarang_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub DetailBarang_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call tampilBarang()
    End Sub

    Private Sub search_OnTextChange(sender As Object, e As EventArgs) Handles search.OnTextChange
        
    End Sub

    Private Sub BunifuCustomDataGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellClick

    End Sub

    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellContentClick
        
    End Sub

    Private Sub BunifuCustomDataGrid1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellDoubleClick
        
    End Sub

End Class