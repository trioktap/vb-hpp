Imports MySql.Data.MySqlClient

Public Class bahanbaku
    Dim Connection As New MySqlConnection("server=localhost;user id=root;database=hpp")
    Dim dt As New DataTable()
    Dim adapter As MySqlDataAdapter

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Dim command As New MySqlCommand("INSERT INTO `bahan_baku`(`id_bb`, `nama_bb`, `stok`, `satuan`, `harga_satuan`) VALUES (@idbb,@namabb,@stokbb,@satuanbb,@hargabb)", Connection)

        command.Parameters.Add("@idbb", MySqlDbType.VarChar).Value = idbb.Text
        command.Parameters.Add("@namabb", MySqlDbType.VarChar).Value = namabb.Text
        command.Parameters.Add("@stokbb", MySqlDbType.Int16).Value = stokbb.Text
        command.Parameters.Add("@satuanbb", MySqlDbType.VarChar).Value = satuanbb.Text
        command.Parameters.Add("@hargabb", MySqlDbType.Int32).Value = hargabb.Text

        Connection.Open()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Data Berhasil Disimpan!")
        Else
            MessageBox.Show("Data Tidak Dapat Disimpan!")
        End If

        Connection.Close()
        Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        DataGridView1.Columns(0).Name = "ID Bahan Baku"
        DataGridView1.Columns(1).Name = "Nama Bahan Baku"
        DataGridView1.Columns(2).Name = "Stok Bahan Baku"
        DataGridView1.Columns(3).Name = "Satuan Bahan Baku"
        DataGridView1.Columns(4).Name = "Harga Bahan Baku"

        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Function AllCellsSelected(dataGridView1 As DataGridView) As Boolean
        Throw New NotImplementedException()
    End Function

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click

        Dim command As New MySqlCommand("DELETE FROM `bahan_baku` WHERE nama_bb='" + namabb.Text + "'")

        Try
            Connection.Open()

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Data Berhasil Dihapus!")
            Else
                MessageBox.Show("Data Gagal Dihapus!")
            End If

            Connection.Close()

            Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub simpan_produk_Click(sender As Object, e As EventArgs) Handles simpan_produk.Click
        Dim command As New MySqlCommand("INSERT INTO `produk`(`id_produk`, `nama_produk`) VALUES (@idproduk,@namaproduk)", Connection)
        command.Parameters.Add("@idproduk", MySqlDbType.VarChar).Value = idproduk.Text
        command.Parameters.Add("@namaproduk", MySqlDbType.VarChar).Value = namaproduk.Text

        Connection.Open()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Data Berhasil Disimpan!")
        Else
            MessageBox.Show("Data Tidak Dapat Disimpan!")
        End If

        Connection.Close()
        Show()
    End Sub

    Private Sub simpanoverhead_Click(sender As Object, e As EventArgs) Handles simpanoverhead.Click
        Dim command As New MySqlCommand("INSERT INTO `overhead`(`id_overhead`, `nama_overhead`, `satuan`, `biaya_satuan`) VALUES (@idoverhead,@namaoverhead,@satuanoverhead,@hargaoverhead)", Connection)

        command.Parameters.Add("@idoverhead", MySqlDbType.VarChar).Value = idoverhead.Text
        command.Parameters.Add("@namaoverhead", MySqlDbType.VarChar).Value = namaoverhead.Text
        command.Parameters.Add("@satuanoverhead", MySqlDbType.VarChar).Value = satuanoverhead.Text
        command.Parameters.Add("@hargaoverhead", MySqlDbType.Int32).Value = hargaoverhead.Text

        Connection.Open()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Data Berhasil Disimpan!")
        Else
            MessageBox.Show("Data Tidak Dapat Disimpan!")
        End If

        Connection.Close()
        Show()
    End Sub

    Private Sub simpanpekerjaan_Click(sender As Object, e As EventArgs) Handles simpanpekerjaan.Click
        Dim command As New MySqlCommand("INSERT INTO `tenaga_kerja`(`id_pekerjaan`, `nama_pekerjaan`, `satuan`, `biaya`) VALUES (@idpekerjaan,@namapekerjaan,@satuanpekerjaan,@hargapekerjaan)", Connection)

        command.Parameters.Add("@idpekerjaan", MySqlDbType.VarChar).Value = idpekerjaan.Text
        command.Parameters.Add("@namapekerjaan", MySqlDbType.VarChar).Value = namapekerjaan.Text
        command.Parameters.Add("@satuanpekerjaan", MySqlDbType.VarChar).Value = satuanpekerjaan.Text
        command.Parameters.Add("@hargapekerjaan", MySqlDbType.Int32).Value = hargapekerjaan.Text

        Connection.Open()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Data Berhasil Disimpan!")
        Else
            MessageBox.Show("Data Tidak Dapat Disimpan!")
        End If

        Connection.Close()
        Show()
    End Sub

    Private Sub Populate(v As Object, idbb As String, namabb As String, satuanbb As String)
        Dim row As String() = New String() {idbb, namabb, satuanbb}

        DataGridView1.Rows.Add(row)

    End Sub

    Private Sub loadbb_Click(sender As Object, e As EventArgs) Handles loadbb.Click

        ' Dim sql As String = "SELECT * FROM bahan_baku"
        'Dim cmd As New MySqlCommand(sql, Connection)

        'Try
        ' Connection.Open()
        'adapter = New MySqlDataAdapter(cmd)
        'adapter.Fill(dt)

        'For Each row In dt.Rows
        ' Populate(row(0), row(1), row(2), row(3), row(4))

        'Next

        'Connection.Close()

        '  Catch ex As Exception

        ' End Try
    End Sub

    Private Sub Populate(v1 As Object, v2 As Object, v3 As Object, v4 As Object, v5 As Object)
        Throw New NotImplementedException()
    End Sub
End Class