Public Class frmMain

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
        frmBank.MdiParent = Me
        frmCard.MdiParent = Me
        frmDoc.MdiParent = Me
        frmEducation.MdiParent = Me
        frmEO.MdiParent = Me
        frmEduLevel.MdiParent = Me
        frmFL.MdiParent = Me
        frmListBank.MdiParent = Me
        frmListCard.MdiParent = Me
        frmListDocument.MdiParent = Me
        frmListEducation.MdiParent = Me
        frmListEduLevel.MdiParent = Me
        frmListEO.MdiParent = Me
        frmListFL.MdiParent = Me
        frmListOrg.MdiParent = Me
        frmListQual.MdiParent = Me
        frmListRank.MdiParent = Me
        frmListSpec.MdiParent = Me
        frmListTypeDoc.MdiParent = Me
        frmListWorker.MdiParent = Me
        frmOrg.MdiParent = Me
        frmQual.MdiParent = Me
        frmRank.MdiParent = Me
        frmSpec.MdiParent = Me
        frmTypeDoc.MdiParent = Me
        frmWorker.MdiParent = Me

        ToolStripStatusLabel1.Text = Now.ToLongDateString + Now.ToLongTimeString
        ToolStripStatusLabel2.Text = My.User.Name
        Timer1.Start()

        Me.Text = "Работнички"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel1.Text = Now.ToLongDateString + Now.ToLongTimeString
    End Sub

    Private Sub ФизЛицаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ФизЛицаToolStripMenuItem.Click
        frmListFL.Show()
    End Sub

    Private Sub СотрудникиToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles СотрудникиToolStripMenuItem1.Click
        frmListWorker.Show()
    End Sub

    Private Sub ДолжностиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДолжностиToolStripMenuItem.Click
        frmListRank.Show()
    End Sub

    Private Sub ДокументыToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ДокументыToolStripMenuItem1.Click
        frmListDocument.Show()
    End Sub

    Private Sub ТипыДокументовToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ТипыДокументовToolStripMenuItem.Click
        frmListTypeDoc.Show()
    End Sub

    Private Sub ОрганизацииToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОрганизацииToolStripMenuItem.Click
        frmListOrg.Show()
    End Sub

    Private Sub ОбразованиеToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ОбразованиеToolStripMenuItem1.Click
        frmListEducation.Show()
    End Sub

    Private Sub УровеньОбразованияToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles УровеньОбразованияToolStripMenuItem.Click
        frmListEduLevel.Show()
    End Sub

    Private Sub ОбразовательныеУчрежденияToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОбразовательныеУчрежденияToolStripMenuItem.Click
        frmListEO.Show()
    End Sub

    Private Sub СпециальностиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СпециальностиToolStripMenuItem.Click
        frmListSpec.Show()
    End Sub

    Private Sub БанковскиеКартыToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles БанковскиеКартыToolStripMenuItem.Click
        frmListCard.Show()
    End Sub

    Private Sub БанкиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles БанкиToolStripMenuItem.Click
        frmListBank.Show()
    End Sub

    Private Sub Help_Click(sender As Object, e As EventArgs) Handles bHelp.Click
        Help.ShowHelp(Me, helpFileName, HelpNavigator.Topic, "about_program.html")
    End Sub

    Private Sub ОбАвторахToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОбАвторахToolStripMenuItem.Click
        frmAuthors.Show()
    End Sub

    Private Sub СотрудникиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СотрудникиToolStripMenuItem.Click

    End Sub

    Private Sub КвалификацииToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles КвалификацииToolStripMenuItem.Click
        frmListQual.Show()
    End Sub
End Class