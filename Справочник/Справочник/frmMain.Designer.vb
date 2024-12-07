<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        lblCount = New Label()
        MenuStrip1 = New MenuStrip()
        СправочникиToolStripMenuItem = New ToolStripMenuItem()
        ФизЛицаToolStripMenuItem = New ToolStripMenuItem()
        СотрудникиToolStripMenuItem = New ToolStripMenuItem()
        СотрудникиToolStripMenuItem1 = New ToolStripMenuItem()
        ДолжностиToolStripMenuItem = New ToolStripMenuItem()
        ДокументыToolStripMenuItem = New ToolStripMenuItem()
        ДокументыToolStripMenuItem1 = New ToolStripMenuItem()
        ТипыДокументовToolStripMenuItem = New ToolStripMenuItem()
        ОрганизацииToolStripMenuItem = New ToolStripMenuItem()
        ОбразованиеToolStripMenuItem = New ToolStripMenuItem()
        ОбразованиеToolStripMenuItem1 = New ToolStripMenuItem()
        УровеньОбразованияToolStripMenuItem = New ToolStripMenuItem()
        ОбразовательныеУчрежденияToolStripMenuItem = New ToolStripMenuItem()
        СпециальностиToolStripMenuItem = New ToolStripMenuItem()
        КвалификацииToolStripMenuItem = New ToolStripMenuItem()
        БанковскиеРеквизитыToolStripMenuItem = New ToolStripMenuItem()
        БанковскиеКартыToolStripMenuItem = New ToolStripMenuItem()
        БанкиToolStripMenuItem = New ToolStripMenuItem()
        СправкаToolStripMenuItem = New ToolStripMenuItem()
        bHelp = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        ОбАвторахToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblCount
        ' 
        lblCount.AutoSize = True
        lblCount.Location = New Point(447, 388)
        lblCount.Name = "lblCount"
        lblCount.Size = New Size(0, 20)
        lblCount.TabIndex = 13
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {СправочникиToolStripMenuItem, СправкаToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(886, 28)
        MenuStrip1.TabIndex = 15
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' СправочникиToolStripMenuItem
        ' 
        СправочникиToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ФизЛицаToolStripMenuItem, СотрудникиToolStripMenuItem, ДокументыToolStripMenuItem, ОбразованиеToolStripMenuItem, БанковскиеРеквизитыToolStripMenuItem})
        СправочникиToolStripMenuItem.Image = CType(resources.GetObject("СправочникиToolStripMenuItem.Image"), Image)
        СправочникиToolStripMenuItem.Name = "СправочникиToolStripMenuItem"
        СправочникиToolStripMenuItem.Size = New Size(137, 24)
        СправочникиToolStripMenuItem.Text = "Справочники"
        ' 
        ' ФизЛицаToolStripMenuItem
        ' 
        ФизЛицаToolStripMenuItem.Image = My.Resources.Resources.employee__icon_icons_com_76984
        ФизЛицаToolStripMenuItem.Name = "ФизЛицаToolStripMenuItem"
        ФизЛицаToolStripMenuItem.Size = New Size(251, 26)
        ФизЛицаToolStripMenuItem.Text = "Физ.Лица"
        ' 
        ' СотрудникиToolStripMenuItem
        ' 
        СотрудникиToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {СотрудникиToolStripMenuItem1, ДолжностиToolStripMenuItem})
        СотрудникиToolStripMenuItem.Image = My.Resources.Resources._4043241_builder_helmet_worker_113249
        СотрудникиToolStripMenuItem.Name = "СотрудникиToolStripMenuItem"
        СотрудникиToolStripMenuItem.Size = New Size(251, 26)
        СотрудникиToolStripMenuItem.Text = "Сотрудники"
        ' 
        ' СотрудникиToolStripMenuItem1
        ' 
        СотрудникиToolStripMenuItem1.Image = My.Resources.Resources._4043241_builder_helmet_worker_113249
        СотрудникиToolStripMenuItem1.Name = "СотрудникиToolStripMenuItem1"
        СотрудникиToolStripMenuItem1.Size = New Size(174, 26)
        СотрудникиToolStripMenuItem1.Text = "Сотрудники"
        ' 
        ' ДолжностиToolStripMenuItem
        ' 
        ДолжностиToolStripMenuItem.Image = My.Resources.Resources.office_suitcase_profession_work_job_briefcase_business_icon_232665
        ДолжностиToolStripMenuItem.Name = "ДолжностиToolStripMenuItem"
        ДолжностиToolStripMenuItem.Size = New Size(174, 26)
        ДолжностиToolStripMenuItem.Text = "Должности"
        ' 
        ' ДокументыToolStripMenuItem
        ' 
        ДокументыToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ДокументыToolStripMenuItem1, ТипыДокументовToolStripMenuItem, ОрганизацииToolStripMenuItem})
        ДокументыToolStripMenuItem.Image = CType(resources.GetObject("ДокументыToolStripMenuItem.Image"), Image)
        ДокументыToolStripMenuItem.Name = "ДокументыToolStripMenuItem"
        ДокументыToolStripMenuItem.Size = New Size(251, 26)
        ДокументыToolStripMenuItem.Text = "Документы"
        ' 
        ' ДокументыToolStripMenuItem1
        ' 
        ДокументыToolStripMenuItem1.Image = CType(resources.GetObject("ДокументыToolStripMenuItem1.Image"), Image)
        ДокументыToolStripMenuItem1.Name = "ДокументыToolStripMenuItem1"
        ДокументыToolStripMenuItem1.Size = New Size(215, 26)
        ДокументыToolStripMenuItem1.Text = "Документы"
        ' 
        ' ТипыДокументовToolStripMenuItem
        ' 
        ТипыДокументовToolStripMenuItem.Image = CType(resources.GetObject("ТипыДокументовToolStripMenuItem.Image"), Image)
        ТипыДокументовToolStripMenuItem.Name = "ТипыДокументовToolStripMenuItem"
        ТипыДокументовToolStripMenuItem.Size = New Size(215, 26)
        ТипыДокументовToolStripMenuItem.Text = "Типы документов"
        ' 
        ' ОрганизацииToolStripMenuItem
        ' 
        ОрганизацииToolStripMenuItem.Image = CType(resources.GetObject("ОрганизацииToolStripMenuItem.Image"), Image)
        ОрганизацииToolStripMenuItem.Name = "ОрганизацииToolStripMenuItem"
        ОрганизацииToolStripMenuItem.Size = New Size(215, 26)
        ОрганизацииToolStripMenuItem.Text = "Организации"
        ' 
        ' ОбразованиеToolStripMenuItem
        ' 
        ОбразованиеToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ОбразованиеToolStripMenuItem1, УровеньОбразованияToolStripMenuItem, ОбразовательныеУчрежденияToolStripMenuItem, СпециальностиToolStripMenuItem, КвалификацииToolStripMenuItem})
        ОбразованиеToolStripMenuItem.Image = CType(resources.GetObject("ОбразованиеToolStripMenuItem.Image"), Image)
        ОбразованиеToolStripMenuItem.Name = "ОбразованиеToolStripMenuItem"
        ОбразованиеToolStripMenuItem.Size = New Size(251, 26)
        ОбразованиеToolStripMenuItem.Text = "Образование"
        ' 
        ' ОбразованиеToolStripMenuItem1
        ' 
        ОбразованиеToolStripMenuItem1.Image = CType(resources.GetObject("ОбразованиеToolStripMenuItem1.Image"), Image)
        ОбразованиеToolStripMenuItem1.Name = "ОбразованиеToolStripMenuItem1"
        ОбразованиеToolStripMenuItem1.Size = New Size(308, 26)
        ОбразованиеToolStripMenuItem1.Text = "Образование"
        ' 
        ' УровеньОбразованияToolStripMenuItem
        ' 
        УровеньОбразованияToolStripMenuItem.Image = CType(resources.GetObject("УровеньОбразованияToolStripMenuItem.Image"), Image)
        УровеньОбразованияToolStripMenuItem.Name = "УровеньОбразованияToolStripMenuItem"
        УровеньОбразованияToolStripMenuItem.Size = New Size(308, 26)
        УровеньОбразованияToolStripMenuItem.Text = "Уровни образования"
        ' 
        ' ОбразовательныеУчрежденияToolStripMenuItem
        ' 
        ОбразовательныеУчрежденияToolStripMenuItem.Image = CType(resources.GetObject("ОбразовательныеУчрежденияToolStripMenuItem.Image"), Image)
        ОбразовательныеУчрежденияToolStripMenuItem.Name = "ОбразовательныеУчрежденияToolStripMenuItem"
        ОбразовательныеУчрежденияToolStripMenuItem.Size = New Size(308, 26)
        ОбразовательныеУчрежденияToolStripMenuItem.Text = "Образовательные учреждения"
        ' 
        ' СпециальностиToolStripMenuItem
        ' 
        СпециальностиToolStripMenuItem.Image = CType(resources.GetObject("СпециальностиToolStripMenuItem.Image"), Image)
        СпециальностиToolStripMenuItem.Name = "СпециальностиToolStripMenuItem"
        СпециальностиToolStripMenuItem.Size = New Size(308, 26)
        СпециальностиToolStripMenuItem.Text = "Специальности"
        ' 
        ' КвалификацииToolStripMenuItem
        ' 
        КвалификацииToolStripMenuItem.Image = CType(resources.GetObject("КвалификацииToolStripMenuItem.Image"), Image)
        КвалификацииToolStripMenuItem.Name = "КвалификацииToolStripMenuItem"
        КвалификацииToolStripMenuItem.Size = New Size(308, 26)
        КвалификацииToolStripMenuItem.Text = "Квалификации"
        ' 
        ' БанковскиеРеквизитыToolStripMenuItem
        ' 
        БанковскиеРеквизитыToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {БанковскиеКартыToolStripMenuItem, БанкиToolStripMenuItem})
        БанковскиеРеквизитыToolStripMenuItem.Image = CType(resources.GetObject("БанковскиеРеквизитыToolStripMenuItem.Image"), Image)
        БанковскиеРеквизитыToolStripMenuItem.Name = "БанковскиеРеквизитыToolStripMenuItem"
        БанковскиеРеквизитыToolStripMenuItem.Size = New Size(251, 26)
        БанковскиеРеквизитыToolStripMenuItem.Text = "Банковские реквизиты"
        ' 
        ' БанковскиеКартыToolStripMenuItem
        ' 
        БанковскиеКартыToolStripMenuItem.Image = CType(resources.GetObject("БанковскиеКартыToolStripMenuItem.Image"), Image)
        БанковскиеКартыToolStripMenuItem.Name = "БанковскиеКартыToolStripMenuItem"
        БанковскиеКартыToolStripMenuItem.Size = New Size(218, 26)
        БанковскиеКартыToolStripMenuItem.Text = "Банковские карты"
        ' 
        ' БанкиToolStripMenuItem
        ' 
        БанкиToolStripMenuItem.Image = CType(resources.GetObject("БанкиToolStripMenuItem.Image"), Image)
        БанкиToolStripMenuItem.Name = "БанкиToolStripMenuItem"
        БанкиToolStripMenuItem.Size = New Size(218, 26)
        БанкиToolStripMenuItem.Text = "Банки"
        ' 
        ' СправкаToolStripMenuItem
        ' 
        СправкаToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {bHelp, ОбАвторахToolStripMenuItem})
        СправкаToolStripMenuItem.Image = CType(resources.GetObject("СправкаToolStripMenuItem.Image"), Image)
        СправкаToolStripMenuItem.Name = "СправкаToolStripMenuItem"
        СправкаToolStripMenuItem.Size = New Size(103, 24)
        СправкаToolStripMenuItem.Text = "Помощь"
        ' 
        ' bHelp
        ' 
        bHelp.Image = CType(resources.GetObject("bHelp.Image"), Image)
        bHelp.Name = "bHelp"
        bHelp.Size = New Size(224, 26)
        bHelp.Text = "Справка"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Location = New Point(0, 635)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(886, 22)
        StatusStrip1.TabIndex = 17
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ОбАвторахToolStripMenuItem
        ' 
        ОбАвторахToolStripMenuItem.Name = "ОбАвторахToolStripMenuItem"
        ОбАвторахToolStripMenuItem.Size = New Size(224, 26)
        ОбАвторахToolStripMenuItem.Text = "Об авторах..."
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(886, 657)
        Controls.Add(StatusStrip1)
        Controls.Add(lblCount)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        Name = "frmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmMain"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblCount As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents СправочникиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ФизЛицаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СотрудникиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ДокументыToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СотрудникиToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ДолжностиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ДокументыToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ТипыДокументовToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОрганизацииToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОбразованиеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОбразованиеToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents УровеньОбразованияToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОбразовательныеУчрежденияToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СпециальностиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents КвалификацииToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents БанковскиеРеквизитыToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents БанковскиеКартыToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents БанкиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СправкаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents bHelp As ToolStripMenuItem
    Friend WithEvents ОбАвторахToolStripMenuItem As ToolStripMenuItem

End Class
