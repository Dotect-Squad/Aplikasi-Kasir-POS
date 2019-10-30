Imports System.Data.Odbc
Public Class FormSetupToko

    Sub tampilData()
        
    End Sub

    Private Sub FormSetupToko_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            Call updateData()
        End If
    End Sub

    Private Sub FormSetupToko_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilData()
    End Sub

    Private Sub telepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles telepon.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Call updateData()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        namaToko.Text = ""
        alamatToko.Text = ""
        telepon.Text = ""
    End Sub

    Private Sub namaToko_KeyPress(sender As Object, e As KeyPressEventArgs) Handles namaToko.KeyPress
        If namaToko.Text.Length >= 16 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub alamatToko_KeyPress(sender As Object, e As KeyPressEventArgs) Handles alamatToko.KeyPress
        If alamatToko.Text.Length >= 35 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub telepon1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles telepon.KeyPress
        If telepon.Text.Length >= 13 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Sub updateData()
        
    End Sub
End Class