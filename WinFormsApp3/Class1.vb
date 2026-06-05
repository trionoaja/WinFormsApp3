Imports MySql.Data.MySqlClient

Public Class Koneksi
    Public conn As MySqlConnection

    Public Sub buka()
        Dim str As String = "server=localhost;user id=root;password=;database=perpustakaan;"
        conn = New MySqlConnection(str)
        conn.Open()
    End Sub
End Class