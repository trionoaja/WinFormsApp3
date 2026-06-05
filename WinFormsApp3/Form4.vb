Imports MySql.Data.MySqlClient
Imports QuestPDF.Fluent
Imports QuestPDF.Infrastructure
Imports System.IO
Public Class Form4

    Dim db As New Koneksi()
    Public lblUser As Label
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db.buka()

        cbPenerbit.Items.Clear()

        Dim cmd As New MySqlCommand(
            "SELECT DISTINCT penerbit FROM buku",
            db.conn)

        Dim rd As MySqlDataReader =
            cmd.ExecuteReader()

        While rd.Read()

            cbPenerbit.Items.Add(
                rd("penerbit").ToString())

        End While

        rd.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String =
        "SELECT * FROM buku WHERE penerbit=@penerbit"

        Dim da As New MySqlDataAdapter(
        sql,
        db.conn)

        da.SelectCommand.Parameters.AddWithValue(
        "@penerbit",
        cbPenerbit.Text)

        Dim dt As New DataTable

        da.Fill(dt)

        DataGridView1.DataSource = dt

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            QuestPDF.Settings.License =
                LicenseType.Community

            Dim filepdf As String =
                Path.Combine(
                    Environment.GetFolderPath(
                    Environment.SpecialFolder.Desktop),
                    "Laporan_" &
                    cbPenerbit.Text &
                    ".pdf")

            QuestPDF.Fluent.Document.Create(
            Sub(container)

                container.Page(
                Sub(page)

                    page.Margin(20)

                    page.Header().Column(
                    Sub(col)

                        col.Item().Text(
                            "LAPORAN BUKU BERDASARKAN PENERBIT").FontSize(18).
                    Bold()

                        col.Item().Text(
                            "Penerbit : " &
                            cbPenerbit.Text)

                        col.Item().Text(
                            "Tanggal Cetak : " &
                            DateTime.Now.ToString(
                            "dd/MM/yyyy HH:mm"))

                    End Sub)

                    page.Content().Table(
                    Sub(table)

                        table.ColumnsDefinition(
                        Sub(columns)

                            columns.ConstantColumn(40)
                            columns.RelativeColumn(3)
                            columns.RelativeColumn(2)
                            columns.ConstantColumn(60)
                            columns.ConstantColumn(60)

                        End Sub)

                        table.Header(
                        Sub(header)

                            header.Cell().Border(1).Text("ID")
                            header.Cell().Border(1).Text("Judul")
                            header.Cell().Border(1).Text("Pengarang")
                            header.Cell().Border(1).Text("Tahun")
                            header.Cell().Border(1).Text("Stock")

                        End Sub)

                        For Each row As DataGridViewRow In DataGridView1.Rows

                            If Not row.IsNewRow Then

                                table.Cell().Border(1).
                                    Text(row.Cells("id").Value.ToString())

                                table.Cell().Border(1).
                                    Text(row.Cells("judul").Value.ToString())

                                table.Cell().Border(1).
                                    Text(row.Cells("pengarang").Value.ToString())

                                table.Cell().Border(1).
                                    Text(row.Cells("tahun").Value.ToString())

                                table.Cell().Border(1).
                                    Text(row.Cells("stock").Value.ToString())

                            End If

                        Next
                        page.Footer().AlignRight().Column(
    Sub(col)

        col.Item().Text(
            "Tangerang, " &
            DateTime.Now.ToString("dd MMMM yyyy"))

        col.Item().PaddingTop(40)

        col.Item().Text("Petugas")

        col.Item().PaddingTop(50)

        col.Item().Text("(__________________)")

        '   col.Item().Text(lblUser.Text)

    End Sub)
                    End Sub)

                End Sub)

            End Sub).GeneratePdf(filepdf)

            MessageBox.Show(
                "PDF berhasil dibuat")

            Process.Start(
                New ProcessStartInfo(filepdf) With {
                    .UseShellExecute = True
                })

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub
End Class