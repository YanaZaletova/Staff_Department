<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListEducation
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListEducation))
        lblCount = New Label()
        dgdList = New DataGridView()
        cmdExit = New Button()
        lblTotalField = New Label()
        tspMain = New ToolStrip()
        tsbAdd = New ToolStripButton()
        tsbRemove = New ToolStripButton()
        tsbEdit = New ToolStripButton()
        tsbExit = New ToolStripButton()
        ilsIcons = New ImageList(components)
        ttpPopUp = New ToolTip(components)
        CType(dgdList, ComponentModel.ISupportInitialize).BeginInit()
        tspMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblCount
        ' 
        lblCount.AutoSize = True
        lblCount.Location = New Point(447, 397)
        lblCount.Name = "lblCount"
        lblCount.Size = New Size(53, 20)
        lblCount.TabIndex = 23
        lblCount.Text = "Label1"
        ' 
        ' dgdList
        ' 
        dgdList.AllowUserToAddRows = False
        dgdList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgdList.Location = New Point(12, 42)
        dgdList.Name = "dgdList"
        dgdList.ReadOnly = True
        dgdList.RowHeadersWidth = 51
        dgdList.Size = New Size(776, 342)
        dgdList.TabIndex = 22
        ' 
        ' cmdExit
        ' 
        cmdExit.Location = New Point(683, 418)
        cmdExit.Name = "cmdExit"
        cmdExit.Size = New Size(94, 29)
        cmdExit.TabIndex = 21
        cmdExit.Text = "Button1"
        cmdExit.UseVisualStyleBackColor = True
        ' 
        ' lblTotalField
        ' 
        lblTotalField.AutoSize = True
        lblTotalField.Location = New Point(624, 397)
        lblTotalField.Name = "lblTotalField"
        lblTotalField.Size = New Size(53, 20)
        lblTotalField.TabIndex = 20
        lblTotalField.Text = "Label1"
        ' 
        ' tspMain
        ' 
        tspMain.ImageScalingSize = New Size(20, 20)
        tspMain.Items.AddRange(New ToolStripItem() {tsbAdd, tsbRemove, tsbEdit, tsbExit})
        tspMain.Location = New Point(0, 0)
        tspMain.Name = "tspMain"
        tspMain.Size = New Size(800, 27)
        tspMain.TabIndex = 19
        tspMain.Text = "ToolStrip1"
        ' 
        ' tsbAdd
        ' 
        tsbAdd.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbAdd.Image = CType(resources.GetObject("tsbAdd.Image"), Image)
        tsbAdd.ImageTransparentColor = Color.Magenta
        tsbAdd.Name = "tsbAdd"
        tsbAdd.Size = New Size(29, 24)
        tsbAdd.Text = "Добавить"
        ' 
        ' tsbRemove
        ' 
        tsbRemove.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbRemove.Image = CType(resources.GetObject("tsbRemove.Image"), Image)
        tsbRemove.ImageTransparentColor = Color.Magenta
        tsbRemove.Name = "tsbRemove"
        tsbRemove.Size = New Size(29, 24)
        tsbRemove.Text = "Удалить"
        ' 
        ' tsbEdit
        ' 
        tsbEdit.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbEdit.Image = CType(resources.GetObject("tsbEdit.Image"), Image)
        tsbEdit.ImageTransparentColor = Color.Magenta
        tsbEdit.Name = "tsbEdit"
        tsbEdit.Size = New Size(29, 24)
        tsbEdit.Text = "Изменить"
        ' 
        ' tsbExit
        ' 
        tsbExit.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbExit.Image = CType(resources.GetObject("tsbExit.Image"), Image)
        tsbExit.ImageTransparentColor = Color.Magenta
        tsbExit.Name = "tsbExit"
        tsbExit.Size = New Size(29, 24)
        tsbExit.Text = "Закрыть"
        ' 
        ' ilsIcons
        ' 
        ilsIcons.ColorDepth = ColorDepth.Depth32Bit
        ilsIcons.ImageStream = CType(resources.GetObject("ilsIcons.ImageStream"), ImageListStreamer)
        ilsIcons.TransparentColor = Color.Transparent
        ilsIcons.Images.SetKeyName(0, "add_icon-icons.com_52393.png")
        ilsIcons.Images.SetKeyName(1, "delete_icon-icons.com_52378.png")
        ilsIcons.Images.SetKeyName(2, "edit_icon-icons.com_52382.ico")
        ilsIcons.Images.SetKeyName(3, "log_logout_door_1563.png")
        ilsIcons.Images.SetKeyName(4, "Save_37110.ico")
        ' 
        ' frmListEducation
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblCount)
        Controls.Add(dgdList)
        Controls.Add(cmdExit)
        Controls.Add(lblTotalField)
        Controls.Add(tspMain)
        Name = "frmListEducation"
        StartPosition = FormStartPosition.CenterParent
        Text = "frmListEducation"
        CType(dgdList, ComponentModel.ISupportInitialize).EndInit()
        tspMain.ResumeLayout(False)
        tspMain.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCount As Label
    Friend WithEvents dgdList As DataGridView
    Friend WithEvents cmdExit As Button
    Friend WithEvents lblTotalField As Label
    Friend WithEvents tspMain As ToolStrip
    Friend WithEvents tsbAdd As ToolStripButton
    Friend WithEvents tsbRemove As ToolStripButton
    Friend WithEvents tsbEdit As ToolStripButton
    Friend WithEvents tsbExit As ToolStripButton
    Friend WithEvents ilsIcons As ImageList
    Friend WithEvents ttpPopUp As ToolTip
End Class
