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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        lblCount = New Label()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        ToolStripStatusLabel2 = New ToolStripStatusLabel()
        Timer1 = New Timer(components)
        СправочникиToolStripMenuItem = New ToolStripMenuItem()
        ФизЛицаToolStripMenuItem = New ToolStripMenuItem()
        СотрудникиToolStripMenuItem = New ToolStripMenuItem()
        СотрудникиToolStripMenuItem1 = New ToolStripMenuItem()
        ДолжностиToolStripMenuItem = New ToolStripMenuItem()
        КвалификацииToolStripMenuItem = New ToolStripMenuItem()
        ДокументыToolStripMenuItem = New ToolStripMenuItem()
        ТипыДокументовToolStripMenuItem = New ToolStripMenuItem()
        ОрганизацииToolStripMenuItem = New ToolStripMenuItem()
        ДокументыToolStripMenuItem1 = New ToolStripMenuItem()
        ОбразованиеToolStripMenuItem = New ToolStripMenuItem()
        ОбразованиеToolStripMenuItem1 = New ToolStripMenuItem()
        УровеньОбразованияToolStripMenuItem = New ToolStripMenuItem()
        ОбразовательныеУчрежденияToolStripMenuItem = New ToolStripMenuItem()
        СпециальностиToolStripMenuItem = New ToolStripMenuItem()
        БанковскиеРеквизитыToolStripMenuItem = New ToolStripMenuItem()
        БанковскиеКартыToolStripMenuItem = New ToolStripMenuItem()
        БанкиToolStripMenuItem = New ToolStripMenuItem()
        СправкаToolStripMenuItem = New ToolStripMenuItem()
        bHelp = New ToolStripMenuItem()
        ОбАвторахToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1 = New MenuStrip()
        ФайлToolStripMenuItem = New ToolStripMenuItem()
        ПравкаToolStripMenuItem = New ToolStripMenuItem()
        ВидToolStripMenuItem = New ToolStripMenuItem()
        ФорматToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblCount
        ' 
        lblCount.AutoSize = True
        lblCount.Location = New Point(391, 291)
        lblCount.Name = "lblCount"
        lblCount.Size = New Size(0, 15)
        lblCount.TabIndex = 13
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, ToolStripStatusLabel2})
        StatusStrip1.Location = New Point(0, 659)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Padding = New Padding(1, 0, 12, 0)
        StatusStrip1.Size = New Size(1386, 22)
        StatusStrip1.TabIndex = 17
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(119, 17)
        ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        ' 
        ' ToolStripStatusLabel2
        ' 
        ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        ToolStripStatusLabel2.Size = New Size(119, 17)
        ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        ' 
        ' Timer1
        ' 
        ' 
        ' СправочникиToolStripMenuItem
        ' 
        СправочникиToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ФизЛицаToolStripMenuItem, СотрудникиToolStripMenuItem, ДокументыToolStripMenuItem, ОбразованиеToolStripMenuItem, БанковскиеРеквизитыToolStripMenuItem})
        СправочникиToolStripMenuItem.Name = "СправочникиToolStripMenuItem"
        СправочникиToolStripMenuItem.Size = New Size(94, 20)
        СправочникиToolStripMenuItem.Text = "Справочники"
        ' 
        ' ФизЛицаToolStripMenuItem
        ' 
        ФизЛицаToolStripMenuItem.Name = "ФизЛицаToolStripMenuItem"
        ФизЛицаToolStripMenuItem.Size = New Size(199, 22)
        ФизЛицаToolStripMenuItem.Text = "Физлицо"
        ' 
        ' СотрудникиToolStripMenuItem
        ' 
        СотрудникиToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {СотрудникиToolStripMenuItem1, ДолжностиToolStripMenuItem, КвалификацииToolStripMenuItem})
        СотрудникиToolStripMenuItem.Name = "СотрудникиToolStripMenuItem"
        СотрудникиToolStripMenuItem.Size = New Size(199, 22)
        СотрудникиToolStripMenuItem.Text = "Сотрудники"
        ' 
        ' СотрудникиToolStripMenuItem1
        ' 
        СотрудникиToolStripMenuItem1.Name = "СотрудникиToolStripMenuItem1"
        СотрудникиToolStripMenuItem1.Size = New Size(156, 22)
        СотрудникиToolStripMenuItem1.Text = "Сотрудники"
        ' 
        ' ДолжностиToolStripMenuItem
        ' 
        ДолжностиToolStripMenuItem.Name = "ДолжностиToolStripMenuItem"
        ДолжностиToolStripMenuItem.Size = New Size(156, 22)
        ДолжностиToolStripMenuItem.Text = "Должности"
        ' 
        ' КвалификацииToolStripMenuItem
        ' 
        КвалификацииToolStripMenuItem.Name = "КвалификацииToolStripMenuItem"
        КвалификацииToolStripMenuItem.Size = New Size(156, 22)
        КвалификацииToolStripMenuItem.Text = "Квалификации"
        ' 
        ' ДокументыToolStripMenuItem
        ' 
        ДокументыToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ТипыДокументовToolStripMenuItem, ОрганизацииToolStripMenuItem, ДокументыToolStripMenuItem1})
        ДокументыToolStripMenuItem.Name = "ДокументыToolStripMenuItem"
        ДокументыToolStripMenuItem.Size = New Size(199, 22)
        ДокументыToolStripMenuItem.Text = "Документы"
        ' 
        ' ТипыДокументовToolStripMenuItem
        ' 
        ТипыДокументовToolStripMenuItem.Name = "ТипыДокументовToolStripMenuItem"
        ТипыДокументовToolStripMenuItem.Size = New Size(171, 22)
        ТипыДокументовToolStripMenuItem.Text = "Типы документов"
        ' 
        ' ОрганизацииToolStripMenuItem
        ' 
        ОрганизацииToolStripMenuItem.Name = "ОрганизацииToolStripMenuItem"
        ОрганизацииToolStripMenuItem.Size = New Size(171, 22)
        ОрганизацииToolStripMenuItem.Text = "Организации"
        ' 
        ' ДокументыToolStripMenuItem1
        ' 
        ДокументыToolStripMenuItem1.Name = "ДокументыToolStripMenuItem1"
        ДокументыToolStripMenuItem1.Size = New Size(171, 22)
        ДокументыToolStripMenuItem1.Text = "Документы"
        ' 
        ' ОбразованиеToolStripMenuItem
        ' 
        ОбразованиеToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ОбразованиеToolStripMenuItem1, УровеньОбразованияToolStripMenuItem, ОбразовательныеУчрежденияToolStripMenuItem, СпециальностиToolStripMenuItem})
        ОбразованиеToolStripMenuItem.Name = "ОбразованиеToolStripMenuItem"
        ОбразованиеToolStripMenuItem.Size = New Size(199, 22)
        ОбразованиеToolStripMenuItem.Text = "Образование"
        ' 
        ' ОбразованиеToolStripMenuItem1
        ' 
        ОбразованиеToolStripMenuItem1.Name = "ОбразованиеToolStripMenuItem1"
        ОбразованиеToolStripMenuItem1.Size = New Size(243, 22)
        ОбразованиеToolStripMenuItem1.Text = "Образование"
        ' 
        ' УровеньОбразованияToolStripMenuItem
        ' 
        УровеньОбразованияToolStripMenuItem.Name = "УровеньОбразованияToolStripMenuItem"
        УровеньОбразованияToolStripMenuItem.Size = New Size(243, 22)
        УровеньОбразованияToolStripMenuItem.Text = "Уровни образования"
        ' 
        ' ОбразовательныеУчрежденияToolStripMenuItem
        ' 
        ОбразовательныеУчрежденияToolStripMenuItem.Name = "ОбразовательныеУчрежденияToolStripMenuItem"
        ОбразовательныеУчрежденияToolStripMenuItem.Size = New Size(243, 22)
        ОбразовательныеУчрежденияToolStripMenuItem.Text = "Образовательные учреждения"
        ' 
        ' СпециальностиToolStripMenuItem
        ' 
        СпециальностиToolStripMenuItem.Name = "СпециальностиToolStripMenuItem"
        СпециальностиToolStripMenuItem.Size = New Size(243, 22)
        СпециальностиToolStripMenuItem.Text = "Специальности"
        ' 
        ' БанковскиеРеквизитыToolStripMenuItem
        ' 
        БанковскиеРеквизитыToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {БанковскиеКартыToolStripMenuItem, БанкиToolStripMenuItem})
        БанковскиеРеквизитыToolStripMenuItem.Name = "БанковскиеРеквизитыToolStripMenuItem"
        БанковскиеРеквизитыToolStripMenuItem.Size = New Size(199, 22)
        БанковскиеРеквизитыToolStripMenuItem.Text = "Банковские реквизиты"
        ' 
        ' БанковскиеКартыToolStripMenuItem
        ' 
        БанковскиеКартыToolStripMenuItem.Name = "БанковскиеКартыToolStripMenuItem"
        БанковскиеКартыToolStripMenuItem.Size = New Size(174, 22)
        БанковскиеКартыToolStripMenuItem.Text = "Банковские карты"
        ' 
        ' БанкиToolStripMenuItem
        ' 
        БанкиToolStripMenuItem.Name = "БанкиToolStripMenuItem"
        БанкиToolStripMenuItem.Size = New Size(174, 22)
        БанкиToolStripMenuItem.Text = "Банки"
        ' 
        ' СправкаToolStripMenuItem
        ' 
        СправкаToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {bHelp, ОбАвторахToolStripMenuItem})
        СправкаToolStripMenuItem.Name = "СправкаToolStripMenuItem"
        СправкаToolStripMenuItem.Size = New Size(65, 20)
        СправкаToolStripMenuItem.Text = "Справка"
        ' 
        ' bHelp
        ' 
        bHelp.Name = "bHelp"
        bHelp.Size = New Size(145, 22)
        bHelp.Text = "Справка"
        ' 
        ' ОбАвторахToolStripMenuItem
        ' 
        ОбАвторахToolStripMenuItem.Name = "ОбАвторахToolStripMenuItem"
        ОбАвторахToolStripMenuItem.Size = New Size(145, 22)
        ОбАвторахToolStripMenuItem.Text = "Об авторах..."
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ФайлToolStripMenuItem, ПравкаToolStripMenuItem, ВидToolStripMenuItem, ФорматToolStripMenuItem, СправочникиToolStripMenuItem, СправкаToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(5, 2, 0, 2)
        MenuStrip1.Size = New Size(1386, 24)
        MenuStrip1.TabIndex = 15
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ФайлToolStripMenuItem
        ' 
        ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem"
        ФайлToolStripMenuItem.Size = New Size(48, 20)
        ФайлToolStripMenuItem.Text = "Файл"
        ' 
        ' ПравкаToolStripMenuItem
        ' 
        ПравкаToolStripMenuItem.Name = "ПравкаToolStripMenuItem"
        ПравкаToolStripMenuItem.Size = New Size(59, 20)
        ПравкаToolStripMenuItem.Text = "Правка"
        ' 
        ' ВидToolStripMenuItem
        ' 
        ВидToolStripMenuItem.Name = "ВидToolStripMenuItem"
        ВидToolStripMenuItem.Size = New Size(39, 20)
        ВидToolStripMenuItem.Text = "Вид"
        ' 
        ' ФорматToolStripMenuItem
        ' 
        ФорматToolStripMenuItem.Name = "ФорматToolStripMenuItem"
        ФорматToolStripMenuItem.Size = New Size(62, 20)
        ФорматToolStripMenuItem.Text = "Формат"
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1386, 681)
        Controls.Add(StatusStrip1)
        Controls.Add(lblCount)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        IsMdiContainer = True
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmMain"
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblCount As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents СправочникиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ФизЛицаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СотрудникиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СотрудникиToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ДолжностиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ДокументыToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ДокументыToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ОрганизацииToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОбразованиеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОбразованиеToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents УровеньОбразованияToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОбразовательныеУчрежденияToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СпециальностиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents БанковскиеРеквизитыToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents БанковскиеКартыToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents БанкиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СправкаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents bHelp As ToolStripMenuItem
    Friend WithEvents ОбАвторахToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ФайлToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ПравкаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ВидToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ФорматToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ТипыДокументовToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents КвалификацииToolStripMenuItem As ToolStripMenuItem

End Class
