Imports MySql.Data.MySqlClient

Public Class hpp
    Dim Connection As New MySqlConnection("server=localhost;user id=root;database=hpp")
    Dim a, b As Integer
    Dim bbhitung As Integer
    Dim hitung As Integer
    Dim jml, totalbahanbaku, totalpekerja, totaloverhead, hpp As Integer
    Private Sub addproduksi_Click(sender As Object, e As EventArgs) Handles addproduksi.Click
        Dim command As New MySqlCommand("INSERT INTO `produksi`(`id_produksi`, `tgl_produksi`) VALUES (@idproduksi,@tglproduksi)",
                                        Connection)

        command.Parameters.Add("@idproduksi", MySqlDbType.VarChar).Value = idproduksi.Text
        command.Parameters.Add("@tglproduksi", MySqlDbType.VarChar).Value = tglproduksi.Text

        Connection.Open()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Data Berhasil Disimpan!")
        Else
            MessageBox.Show("Data Tidak Dapat Disimpan!")
        End If
    End Sub

    Private Sub combobb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobb.SelectedIndexChanged
        Dim READER As MySqlDataReader
        Try
            Connection.Open()
            Dim Query As String
            Query = "Select * from bahan_baku where nama_bb = '" & combobb.Text & "'"
            Dim Command As New MySqlCommand(Query, Connection)
            READER = Command.ExecuteReader
            While READER.Read

                idbb.Text = READER.GetString("id_bb")
                combobb.Text = READER.GetString("nama_bb")
                satuanbb.Text = READER.GetString("satuan")
                hargabb.Text = READER.GetInt64("harga_satuan")

            End While

            Connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Connection.Dispose()
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        Dim READER As MySqlDataReader
        Try
            Connection.Open()
            Dim Query As String
            Query = "Select * from bahan_baku"
            Dim Command As New MySqlCommand(Query, Connection)
            READER = Command.ExecuteReader
            While READER.Read

                Dim sName = READER.GetString("nama_bb")
                combobb.Items.Add(sName)

            End While

            Connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Connection.Dispose()
        End Try
    End Sub

    Private Sub combopekerjaan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combopekerjaan.SelectedIndexChanged
        Dim READER As MySqlDataReader
        Try
            Connection.Open()
            Dim Query As String
            Query = "Select * from tenaga_kerja where nama_pekerjaan = '" & combopekerjaan.Text & "'"
            Dim Command As New MySqlCommand(Query, Connection)
            READER = Command.ExecuteReader
            While READER.Read

                idpekerjaan.Text = READER.GetString("id_pekerjaan")
                combopekerjaan.Text = READER.GetString("nama_pekerjaan")
                satuanpekerjaan.Text = READER.GetString("satuan")
                hargapekerjaan.Text = READER.GetInt64("biaya")

            End While

            Connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Connection.Dispose()
        End Try
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter
        Dim READER As MySqlDataReader
        Try
            Connection.Open()
            Dim Query As String
            Query = "Select * from tenaga_kerja"
            Dim Command As New MySqlCommand(Query, Connection)
            READER = Command.ExecuteReader
            While READER.Read

                Dim sName = READER.GetString("nama_pekerjaan")
                combopekerjaan.Items.Add(sName)

            End While

            Connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Connection.Dispose()
        End Try
    End Sub

    Private Sub jmlpekerjaan_TextChanged(sender As Object, e As EventArgs) Handles jmlpekerjaan.TextChanged
        If jmlpekerjaan.Text = "" Then
            jmlpekerjaan.Focus()
            jmlpekerjaan.SelectAll()

        Else
            a = jmlpekerjaan.Text
            b = hargapekerjaan.Text
            totalpekerjaan.Text = Val(a) * Val(b)
        End If
    End Sub

    Private Sub combooverhead_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combooverhead.SelectedIndexChanged
        Dim READER As MySqlDataReader
        Try
            Connection.Open()
            Dim Query As String
            Query = "Select * from overhead where nama_overhead = '" & combooverhead.Text & "'"
            Dim Command As New MySqlCommand(Query, Connection)
            READER = Command.ExecuteReader
            While READER.Read

                hppidoverhead.Text = READER.GetString("id_overhead")
                combooverhead.Text = READER.GetString("nama_overhead")
                hppsatuanoverhead.Text = READER.GetString("satuan")
                hpphargaoverhead.Text = READER.GetInt64("biaya_satuan")

            End While

            Connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Connection.Dispose()
        End Try
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter
        Dim READER As MySqlDataReader
        Try
            Connection.Open()
            Dim Query As String
            Query = "Select * from overhead"
            Dim Command As New MySqlCommand(Query, Connection)
            READER = Command.ExecuteReader
            While READER.Read

                Dim sName = READER.GetString("nama_overhead")
                combooverhead.Items.Add(sName)

            End While

            Connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Connection.Dispose()
        End Try
    End Sub

    Private Sub jmloverhead_TextChanged(sender As Object, e As EventArgs) Handles jmloverhead.TextChanged
        If jmloverhead.Text = "" Then
            jmloverhead.Focus()
            jmloverhead.SelectAll()

        Else
            a = jmloverhead.Text
            b = hpphargaoverhead.Text
            hpptotaloverhead.Text = Val(a) * Val(b)
        End If
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter
        Dim READER As MySqlDataReader
        Try
            Connection.Open()
            Dim Query As String
            Query = "Select * from produk"
            Dim Command As New MySqlCommand(Query, Connection)
            READER = Command.ExecuteReader
            While READER.Read

                Dim sName = READER.GetString("nama_produk")
                ComboBox1.Items.Add(sName)

            End While

            Connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Connection.Dispose()
        End Try
    End Sub

    Private Sub addbb_Click(sender As Object, e As EventArgs) Handles addbb.Click
        idbb.Text = ""
        jmlbb.Text = ""
        hargabb.Text = ""
        combobb.Text = ""
        satuanbb.Text = ""
        bbhitung = Val(totalbb.Text)
        hitung = hitung + bbhitung
        totalbbhpp.Text = hitung
        totalbb.Text = ""
    End Sub

    Private Sub totalpekerjaan_TextChanged(sender As Object, e As EventArgs) Handles totalpekerjaan.TextChanged
        'If totalpekerjaan.Text = "" Then
        'totalpekerjaan.Focus()
        'totalpekerjaan.SelectAll()

        'Else

        'totalpekerjahpp.Text = Val(totalpekerjaan.Text) + Val(totalpekerjahpp.Text)
        'End If
    End Sub

    Private Sub hpptotaloverhead_TextChanged(sender As Object, e As EventArgs) Handles hpptotaloverhead.TextChanged
        'If hpptotaloverhead.Text = "" Then
        'hpptotaloverhead.Focus()
        'hpptotaloverhead.SelectAll()

        'Else

        'totaloverhpp.Text = Val(hpptotaloverhead.Text) + Val(totaloverhpp.Text)
        'End If
    End Sub

    Private Sub totalbbhpp_TextChanged(sender As Object, e As EventArgs) Handles totalbbhpp.TextChanged

    End Sub

    Private Sub hitunghpp_Click(sender As Object, e As EventArgs) Handles hitunghpp.Click
        jml = jmlhpp.Text
        totalbahanbaku = totalbbhpp.Text
        totalpekerja = totalpekerjahpp.Text
        totaloverhead = totaloverhpp.Text
        totalhpp.Text = (Val(totalbahanbaku) + Val(totalpekerja) + Val(totaloverhead)) / Val(jml)

    End Sub

    Private Sub totalbb_TextChanged(sender As Object, e As EventArgs) Handles totalbb.TextChanged
        'If totalbb.Text = "" Then
        'totalbb.Focus()
        'totalbb.SelectAll()

        'Else

        'totalbbhpp.Text = Val(totalbb.Text) + Val(totalbbhpp.Text)
        'End If*/
    End Sub

    Private Sub addpekerja_Click(sender As Object, e As EventArgs) Handles addpekerja.Click
        idpekerjaan.Text = ""
        jmlpekerjaan.Text = ""
        hargapekerjaan.Text = ""
        combopekerjaan.Text = ""
        satuanpekerjaan.Text = ""
        bbhitung = Val(totalpekerjaan.Text)
        hitung = hitung + bbhitung
        totalpekerjahpp.Text = hitung
        totalpekerjaan.Text = ""
    End Sub

    Private Sub addoverhead_Click(sender As Object, e As EventArgs) Handles addoverhead.Click
        hppidoverhead.Text = ""
        jmloverhead.Text = ""
        hppsatuanoverhead.Text = ""
        combooverhead.Text = ""
        hpphargaoverhead.Text = ""
        bbhitung = Val(hpptotaloverhead.Text)
        hitung = hitung + bbhitung
        totaloverhpp.Text = hitung
        hpptotaloverhead.Text = ""
    End Sub

    Private Sub jmlbb_TextChanged(sender As Object, e As EventArgs) Handles jmlbb.TextChanged
        If jmlbb.Text = "" Then
            jmlbb.Focus()
            jmlbb.SelectAll()

        Else
            a = jmlbb.Text
            b = hargabb.Text
            totalbb.Text = Val(a) * Val(b)
        End If

    End Sub


End Class