Public Class frmMain

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Отдел кадров"
    End Sub

    Private Sub ФизЛицаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ФизЛицаToolStripMenuItem.Click
        frmListFL.ShowDialog()
    End Sub

    Private Sub СотрудникиToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles СотрудникиToolStripMenuItem1.Click
        frmListWorker.ShowDialog()
    End Sub

    Private Sub ДолжностиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДолжностиToolStripMenuItem.Click
        frmListRank.ShowDialog()
    End Sub

    Private Sub ДокументыToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ДокументыToolStripMenuItem1.Click
        frmListDocument.ShowDialog()
    End Sub

    Private Sub ТипыДокументовToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ТипыДокументовToolStripMenuItem.Click
        frmListTypeDoc.ShowDialog()
    End Sub

    Private Sub ОрганизацииToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОрганизацииToolStripMenuItem.Click
        frmListOrg.ShowDialog()
    End Sub

    Private Sub ОбразованиеToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ОбразованиеToolStripMenuItem1.Click
        frmListEducation.ShowDialog()
    End Sub

    Private Sub УровеньОбразованияToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles УровеньОбразованияToolStripMenuItem.Click
        frmListEduLevel.ShowDialog()
    End Sub

    Private Sub ОбразовательныеУчрежденияToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОбразовательныеУчрежденияToolStripMenuItem.Click
        frmListEO.ShowDialog()
    End Sub

    Private Sub СпециальностиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СпециальностиToolStripMenuItem.Click
        frmListSpec.ShowDialog()
    End Sub

    Private Sub КвалификацииToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles КвалификацииToolStripMenuItem.Click
        frmListQual.ShowDialog()
    End Sub

    Private Sub БанковскиеКартыToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles БанковскиеКартыToolStripMenuItem.Click
        frmListCard.ShowDialog()
    End Sub

    Private Sub БанкиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles БанкиToolStripMenuItem.Click
        frmListBank.ShowDialog()
    End Sub

    Private Sub bHelp_Click(sender As Object, e As EventArgs) Handles bHelp.Click
        Help.ShowHelp(Me, helpFileName)
    End Sub

    Private Sub ОбАвторахToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОбАвторахToolStripMenuItem.Click
        frmAuthors.ShowDialog()
    End Sub
End Class