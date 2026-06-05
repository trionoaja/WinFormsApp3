Public Class Form3
    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub FormBukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormBukuToolStripMenuItem.Click
        Dim f As New Form1()

        f.MdiParent = Me

        f.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel1.Text = "tanggal : " &
            DateTime.Now.ToString("dd/MM/yyyy")

        ToolStripStatusLabel2.Text = "Jam : " &
            DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub FormLaporanBukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormLaporanBukuToolStripMenuItem.Click
        Dim f As New Form4()

        f.MdiParent = Me

        f.Show()
    End Sub
End Class