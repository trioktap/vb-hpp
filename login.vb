Imports MySql.Data.MySqlClient

Public Class login
    Private Const V As String = "server=localhost;user id=root;database=hpp"

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim MyConn As New MySqlConnection
        Dim COMMAND As MySqlCommand
        Dim READER As MySqlDataReader
        MyConn.ConnectionString = V

        Try
            MyConn.Open()
            Dim Query As String
            Query = "select * from hpp.login where username = '" & username.Text & "' 
            and password = '" & password.Text & "' "

            COMMAND = New MySqlCommand(Query, MyConn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
            End While

            If count = 1 Then
                MessageBox.Show("Anda Berhasil Masuk!")
                awal.Show()
            ElseIf count > 1 Then
                MessageBox.Show("Duplikasi data!")
            Else
                MessageBox.Show("Data yang Anda Masukkan Salah!")
            End If
            MyConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class