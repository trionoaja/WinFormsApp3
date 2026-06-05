Imports MySql.Data.MySqlClient
Imports FastReport
Imports FastReport.Export.PdfSimple

Public Class FormLaporanBuku

    Dim db As New Koneksi()

    Private Sub btncetak_Click(
        sender As Object,
        e As EventArgs
    ) Handles btncetak.Click

        Try

            db.buka()

            Dim sql As String =
                "SELECT * FROM buku"

            Dim da As New MySqlDataAdapter(
                sql,
                db.conn)

            Dim dt As New DataTable()

            da.Fill(dt)

            Dim rpt As New Report()

            rpt.RegisterData(dt, "buku")

            rpt.GetDataSource(
                "buku").Enabled = True

            rpt.Load(
                "Report/LaporanBuku.frx")

            'rpt.Show()

            Dim pdf As New PDFSimpleExport()

            rpt.Prepare()

            rpt.Export(
                pdf,
                "laporan_buku.pdf")

        Catch ex As Exception

            MessageBox.Show(
                "Error : " & ex.Message)

        End Try

    End Sub

End Class