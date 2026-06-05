Imports System.Linq.Expressions
Imports MySql.Data.MySqlClient
Public Class Form2

    Dim db As New Koneksi

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Try
            db.buka()
            Dim sql As String = "SELECT * FROM users " &
            "WHERE username= @username and password= @password"
            Dim cmd As New MySqlCommand(sql, db.conn)

            cmd.Parameters.AddWithValue("@username", txtusername.Text)
            cmd.Parameters.AddWithValue("@password", txtpassword.Text)

            Dim rd As MySqlDataReader

            rd = cmd.ExecuteReader()

            If rd.HasRows Then
                MessageBox.Show("Login Berhasil")
                Form3.Show()
                Me.Hide()
            Else
                MessageBox.Show("Username dan Password salah")
            End If
            rd.Close()

        Catch ex As Exception

            MessageBox.Show(ex.message)

        End Try

    End Sub
End Class