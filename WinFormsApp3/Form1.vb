
'Imports System.Reflection.Metadata
Imports System.IO
Imports MySql.Data.MySqlClient
'Imports PdfSharp.Pdf
'Imports PdfSharp.Drawing
Imports QuestPDF.Fluent
Imports QuestPDF.Helpers
Imports QuestPDF.Infrastructure

Public Class Form1
    Dim db As New Koneksi()
    Dim id_buku As Integer
    Sub tampil()
        Dim da As New MySqlDataAdapter("select * from buku", db.conn)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        db.buka()
        tampil()
        QuestPDF.Settings.License =
    LicenseType.Community
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        Dim sql As String = "insert into buku (judul,pengarang,penerbit,tahun,Stock) " &
" Values (@judul, @pengarang, @penerbit, @tahun, @Stock)"
        Dim cmd As New MySqlCommand(sql, db.conn)

        cmd.Parameters.AddWithValue("@judul", txtjudul.Text)
        cmd.Parameters.AddWithValue("@pengarang", txtpengarang.Text)
        cmd.Parameters.AddWithValue("@penerbit", txtpenerbit.Text)
        cmd.Parameters.AddWithValue("@tahun", txttahun.Text)
        cmd.Parameters.AddWithValue("@Stock", txtstock.Text)

        cmd.ExecuteNonQuery()
        MessageBox.Show("Data Berhasil Disimpan")

        tampil()
    End Sub
    Sub resetForm()
        txtjudul.Clear()
        txtpengarang.Clear()
        txtpenerbit.Clear()
        txttahun.Clear()
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        resetForm()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        id_buku = DataGridView1.CurrentRow.Cells(0).Value
        txtjudul.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtpengarang.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtpenerbit.Text = DataGridView1.CurrentRow.Cells(3).Value
        txttahun.Text = DataGridView1.CurrentRow.Cells(4).Value
        txtstock.Text = DataGridView1.CurrentRow.Cells(5).Value
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim sql As String = "update buku set judul=@judul,pengarang=@pengarang,penerbit=@penerbit,tahun=@tahun,Stock=@Stock where id=@id"
        Dim cmd As New MySqlCommand(sql, db.conn)

        cmd.Parameters.AddWithValue("@judul", txtjudul.Text)
        cmd.Parameters.AddWithValue("@pengarang", txtpengarang.Text)
        cmd.Parameters.AddWithValue("@penerbit", txtpenerbit.Text)
        cmd.Parameters.AddWithValue("@tahun", txttahun.Text)
        cmd.Parameters.AddWithValue("@Stock", txtstock.Text)
        cmd.Parameters.AddWithValue("@id", id_buku)

        cmd.ExecuteNonQuery()
        MessageBox.Show("Data Berhasil di update")

        tampil()
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Dim sql As String = "DELETE FROM buku where id=@id"
        Dim cmd As New MySqlCommand(sql, db.conn)

        cmd.Parameters.AddWithValue("@id", id_buku)
        cmd.ExecuteNonQuery()

        MessageBox.Show("Data Berhasil Dihapus")
        tampil()
    End Sub

    Private Sub btnExportPDF_Click(sender As Object, e As EventArgs) Handles btnExportPDF.Click
        Try

            QuestPDF.Settings.License = LicenseType.Community

            Dim filepdf As String =
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "Laporan_Buku.pdf"
            )

            QuestPDF.Fluent.Document.Create(
        Sub(container)

            container.Page(
            Sub(page)

                page.Margin(20)

                'HEADER
                page.Header().Column(
                Sub(col)

                    col.Item().Text("LAPORAN DATA BUKU").
                        FontSize(18).
                        Bold()

                    col.Item().Text(
                        "Tanggal Cetak : " &
                        DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"))

                End Sub)

                'ISI
                page.Content().PaddingVertical(10).Table(
                Sub(table)

                    'LEBAR KOLOM
                    table.ColumnsDefinition(
                    Sub(columns)

                        columns.ConstantColumn(40)
                        columns.RelativeColumn(3)
                        columns.RelativeColumn(2)
                        columns.RelativeColumn(2)
                        columns.ConstantColumn(60)
                        columns.ConstantColumn(60)

                    End Sub)

                    'HEADER TABEL
                    table.Header(
                    Sub(header)

                        header.Cell().
                            Border(1).
                            Padding(5).
                            Text("ID").Bold()

                        header.Cell().
                            Border(1).
                            Padding(5).
                            Text("Judul").Bold()

                        header.Cell().
                            Border(1).
                            Padding(5).
                            Text("Pengarang").Bold()

                        header.Cell().
                            Border(1).
                            Padding(5).
                            Text("Penerbit").Bold()

                        header.Cell().
                            Border(1).
                            Padding(5).
                            Text("Tahun").Bold()

                        header.Cell().
                            Border(1).
                            Padding(5).
                            Text("Stock").Bold()

                    End Sub)

                    'DATA
                    For Each row As DataGridViewRow In DataGridView1.Rows

                        If Not row.IsNewRow Then

                            table.Cell().
                                Border(1).
                                Padding(3).
                                Text(row.Cells("id").Value.ToString())

                            table.Cell().
                                Border(1).
                                Padding(3).
                                Text(row.Cells("judul").Value.ToString())

                            table.Cell().
                                Border(1).
                                Padding(3).
                                Text(row.Cells("pengarang").Value.ToString())

                            table.Cell().
                                Border(1).
                                Padding(3).
                                Text(row.Cells("penerbit").Value.ToString())

                            table.Cell().
                                Border(1).
                                Padding(3).
                                Text(row.Cells("tahun").Value.ToString())

                            table.Cell().
                                Border(1).
                                Padding(3).
                                Text(row.Cells("stock").Value.ToString())

                        End If

                    Next

                End Sub)

                'FOOTER
                page.Footer().
                    AlignCenter().
                    Text(
                        Sub(txt)
                            txt.Span("Halaman ")
                            txt.CurrentPageNumber()
                            txt.Span(" dari ")
                            txt.TotalPages()
                        End Sub)

            End Sub)

        End Sub).GeneratePdf(filepdf)

            MessageBox.Show(
            "PDF berhasil dibuat !" &
            vbCrLf &
            filepdf)

            Process.Start(
            New ProcessStartInfo(filepdf) With {
                .UseShellExecute = True
            })

        Catch ex As Exception

            MessageBox.Show(
            ex.ToString(),
            "Error")

        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try

            QuestPDF.Settings.License = LicenseType.Community

            Dim filepdf =
                "D:\LaporanTest.pdf"

            Document.Create(
                Sub(container)

                    container.Page(
                        Sub(page)

                            page.Content.Text(
                                "TES PDF BERHASIL")

                        End Sub)

                End Sub).GeneratePdf(filepdf)

            MessageBox.Show("Sukses")

        Catch ex As Exception

            MessageBox.Show(ex.ToString)

        End Try
    End Sub
End Class
