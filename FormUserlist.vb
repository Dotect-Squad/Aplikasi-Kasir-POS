Imports System.Data.Odbc

Public Class FormUserlist

    Private Sub FormUserlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()

    End Sub

    Sub kondisiAwal()
        kodeAdmin.Text = ""
        username.Text = ""
        password.Text = ""
        levelAdmin.Text = ""
        input.Text = "Tambah"

        kodeAdmin.Enabled = False
        username.Enabled = False
        password.Enabled = False
        levelAdmin.Enabled = False
        simpan.Enabled = False
        input.Enabled = True

        simpan.Enabled = False
        batal.Enabled = False

        Call koneksi()
        Da = New OdbcDataAdapter("SELECT * FROM admin", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "admin")
        BunifuCustomDataGrid1.DataSource = Ds.Tables("admin")
        BunifuCustomDataGrid1.ReadOnly = True
        BunifuCustomDataGrid1.Enabled = True
    End Sub

    Sub isiData()
        kodeAdmin.Enabled = False
        username.Enabled = True
        password.Enabled = True
        levelAdmin.Enabled = True
        levelAdmin.Text = ""
        simpan.Enabled = False
        batal.Enabled = True
        BunifuCustomDataGrid1.Enabled = False
    End Sub

    Sub updateValidation()
        kodeAdmin.Enabled = False
        username.Enabled = True
        password.Enabled = True
        levelAdmin.Enabled = True
        levelAdmin.Text = ""
        input.Enabled = False
        simpan.Enabled = True
        batal.Enabled = True
        BunifuCustomDataGrid1.Enabled = True
    End Sub

    Sub kodeOtomatis()
        Cmd = New OdbcCommand("select * from admin where id_admin in (select max(id_admin) from admin)", Conn)
        Dim urutan As String
        Dim hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            urutan = "ADM" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            urutan = "ADM" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        kodeAdmin.Text = urutan
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
        If input.Text = "Tambah" Then
            input.Text = "Simpan"
            'Button3.Text = "Batal"
            Call isiData()
            Call kodeOtomatis()
        Else
            If kodeAdmin.Text = "" Or username.Text = "" Or password.Text = "" Or levelAdmin.Text = "" Then
                MsgBox("Silahkan isi data dengan lengkap !", vbInformation)
            Else
                Call koneksi()
                Dim inputData As String = "INSERT INTO admin (id_admin,nama_admin,password_admin,level_admin) values ('" & kodeAdmin.Text & "', '" & username.Text & "', '" & password.Text & "', '" & levelAdmin.Text & "')"
                Cmd = New OdbcCommand(inputData, Conn)
                Cmd.ExecuteNonQuery()
                'MsgBox("Data berhasil diinputkan")
                Call kondisiAwal()
            End If
        End If

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