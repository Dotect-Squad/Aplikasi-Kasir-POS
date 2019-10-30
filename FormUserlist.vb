Imports System.Data.Odbc

Public Class FormUserlist

    Private Sub FormUserlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()

    End Sub

    Sub kondisiAwal()
        
    End Sub

    Sub isiData()
        
    End Sub

    Sub updateValidation()
        
    End Sub

    Sub kodeOtomatis()
        
    End Sub

    Private Sub BunifuCustomDataGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellClick
        
    End Sub

    Private Sub search_OnTextChange(sender As Object, e As EventArgs) Handles search.OnTextChange
        
    End Sub

    Private Sub password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles password.KeyPress
        If password.Text.Length >= 10 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub password_OnValueChanged(sender As Object, e As EventArgs) Handles password.OnValueChanged
        password.isPassword = True
    End Sub

    Private Sub kodeAdmin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles kodeAdmin.KeyPress
        If kodeAdmin.Text.Length >= 6 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub kodeAdmin_OnValueChanged(sender As Object, e As EventArgs) Handles kodeAdmin.OnValueChanged

    End Sub

    Private Sub username_KeyPress(sender As Object, e As KeyPressEventArgs) Handles username.KeyPress
        If username.Text.Length >= 10 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub username_OnValueChanged(sender As Object, e As EventArgs) Handles username.OnValueChanged

    End Sub

    Private Sub input_Click(sender As Object, e As EventArgs) Handles input.Click
        Call inputData()
    End Sub

    Sub inputData()
        
    End Sub


    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Call updateData()
    End Sub

    Sub updateData()
        
    End Sub


    Private Sub batal_Click(sender As Object, e As EventArgs) Handles batal.Click
        Call kondisiAwal()
    End Sub

    Private Sub simpan_Click_1(sender As Object, e As EventArgs) Handles simpan.Click

    End Sub

    Private Sub levelAdmin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles levelAdmin.KeyPress
        If e.KeyChar = Chr(13) Then
            If input.Enabled = True Then
                Call inputData()
            Else
                Call updateData()
            End If
        End If
    End Sub

End Class