<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdu
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
        textQual = New TextBox()
        cmdExit = New Button()
        cmdSave = New Button()
        textSpec = New TextBox()
        textLvl = New TextBox()
        textYearFinish = New TextBox()
        Qual = New Label()
        Spec = New Label()
        Lvl = New Label()
        YearFinish = New Label()
        ID = New Label()
        textFL = New TextBox()
        textInst = New TextBox()
        FL = New Label()
        Inst = New Label()
        SuspendLayout()
        ' 
        ' textQual
        ' 
        textQual.Location = New Point(219, 149)
        textQual.Margin = New Padding(3, 2, 3, 2)
        textQual.Name = "textQual"
        textQual.Size = New Size(110, 23)
        textQual.TabIndex = 30
        ' 
        ' cmdExit
        ' 
        cmdExit.Location = New Point(543, 294)
        cmdExit.Margin = New Padding(3, 2, 3, 2)
        cmdExit.Name = "cmdExit"
        cmdExit.Size = New Size(82, 22)
        cmdExit.TabIndex = 29
        cmdExit.Text = "Закрыть"
        cmdExit.UseVisualStyleBackColor = True
        ' 
        ' cmdSave
        ' 
        cmdSave.Location = New Point(409, 294)
        cmdSave.Margin = New Padding(3, 2, 3, 2)
        cmdSave.Name = "cmdSave"
        cmdSave.Size = New Size(82, 22)
        cmdSave.TabIndex = 28
        cmdSave.Text = "Сохранить"
        cmdSave.UseVisualStyleBackColor = True
        ' 
        ' textSpec
        ' 
        textSpec.Location = New Point(219, 104)
        textSpec.Margin = New Padding(3, 2, 3, 2)
        textSpec.Name = "textSpec"
        textSpec.Size = New Size(110, 23)
        textSpec.TabIndex = 25
        ' 
        ' textLvl
        ' 
        textLvl.Location = New Point(219, 62)
        textLvl.Margin = New Padding(3, 2, 3, 2)
        textLvl.Name = "textLvl"
        textLvl.Size = New Size(110, 23)
        textLvl.TabIndex = 24
        ' 
        ' textYearFinish
        ' 
        textYearFinish.Location = New Point(219, 16)
        textYearFinish.Margin = New Padding(3, 2, 3, 2)
        textYearFinish.Name = "textYearFinish"
        textYearFinish.Size = New Size(110, 23)
        textYearFinish.TabIndex = 23
        ' 
        ' Qual
        ' 
        Qual.AutoSize = True
        Qual.Location = New Point(36, 152)
        Qual.Name = "Qual"
        Qual.Size = New Size(41, 15)
        Qual.TabIndex = 20
        Qual.Text = "Label5"
        ' 
        ' Spec
        ' 
        Spec.AutoSize = True
        Spec.Location = New Point(36, 106)
        Spec.Name = "Spec"
        Spec.Size = New Size(41, 15)
        Spec.TabIndex = 19
        Spec.Text = "Label4"
        ' 
        ' Lvl
        ' 
        Lvl.AutoSize = True
        Lvl.Location = New Point(36, 62)
        Lvl.Name = "Lvl"
        Lvl.Size = New Size(41, 15)
        Lvl.TabIndex = 18
        Lvl.Text = "Label3"
        ' 
        ' YearFinish
        ' 
        YearFinish.AutoSize = True
        YearFinish.Location = New Point(36, 19)
        YearFinish.Name = "YearFinish"
        YearFinish.Size = New Size(41, 15)
        YearFinish.TabIndex = 17
        YearFinish.Text = "Label2"
        ' 
        ' ID
        ' 
        ID.AutoSize = True
        ID.Location = New Point(610, 9)
        ID.Name = "ID"
        ID.Size = New Size(41, 15)
        ID.TabIndex = 16
        ID.Text = "Label1"
        ' 
        ' textFL
        ' 
        textFL.Location = New Point(219, 241)
        textFL.Margin = New Padding(3, 2, 3, 2)
        textFL.Name = "textFL"
        textFL.Size = New Size(110, 23)
        textFL.TabIndex = 34
        ' 
        ' textInst
        ' 
        textInst.Location = New Point(219, 196)
        textInst.Margin = New Padding(3, 2, 3, 2)
        textInst.Name = "textInst"
        textInst.Size = New Size(110, 23)
        textInst.TabIndex = 33
        ' 
        ' FL
        ' 
        FL.AutoSize = True
        FL.Location = New Point(36, 244)
        FL.Name = "FL"
        FL.Size = New Size(41, 15)
        FL.TabIndex = 32
        FL.Text = "Label5"
        ' 
        ' Inst
        ' 
        Inst.AutoSize = True
        Inst.Location = New Point(36, 198)
        Inst.Name = "Inst"
        Inst.Size = New Size(41, 15)
        Inst.TabIndex = 31
        Inst.Text = "Label4"
        ' 
        ' frmEdu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 327)
        Controls.Add(textFL)
        Controls.Add(textInst)
        Controls.Add(FL)
        Controls.Add(Inst)
        Controls.Add(textQual)
        Controls.Add(cmdExit)
        Controls.Add(cmdSave)
        Controls.Add(textSpec)
        Controls.Add(textLvl)
        Controls.Add(textYearFinish)
        Controls.Add(Qual)
        Controls.Add(Spec)
        Controls.Add(Lvl)
        Controls.Add(YearFinish)
        Controls.Add(ID)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmEdu"
        StartPosition = FormStartPosition.CenterParent
        Text = "frmEdu"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents textQual As TextBox
    Friend WithEvents cmdExit As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents textSpec As TextBox
    Friend WithEvents textLvl As TextBox
    Friend WithEvents textYearFinish As TextBox
    Friend WithEvents Qual As Label
    Friend WithEvents Spec As Label
    Friend WithEvents Lvl As Label
    Friend WithEvents YearFinish As Label
    Friend WithEvents ID As Label
    Friend WithEvents textFL As TextBox
    Friend WithEvents textInst As TextBox
    Friend WithEvents FL As Label
    Friend WithEvents Inst As Label
End Class
