<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEduLevel
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
        cmdExit = New Button()
        cmdSave = New Button()
        textLvl = New TextBox()
        Lvl = New Label()
        ID = New Label()
        SuspendLayout()
        ' 
        ' cmdExit
        ' 
        cmdExit.Location = New Point(474, 111)
        cmdExit.Margin = New Padding(3, 2, 3, 2)
        cmdExit.Name = "cmdExit"
        cmdExit.Size = New Size(82, 22)
        cmdExit.TabIndex = 29
        cmdExit.Text = "Закрыть"
        cmdExit.UseVisualStyleBackColor = True
        ' 
        ' cmdSave
        ' 
        cmdSave.Location = New Point(325, 111)
        cmdSave.Margin = New Padding(3, 2, 3, 2)
        cmdSave.Name = "cmdSave"
        cmdSave.Size = New Size(82, 22)
        cmdSave.TabIndex = 28
        cmdSave.Text = "Сохранить"
        cmdSave.UseVisualStyleBackColor = True
        ' 
        ' textLvl
        ' 
        textLvl.Location = New Point(183, 62)
        textLvl.Margin = New Padding(3, 2, 3, 2)
        textLvl.Name = "textLvl"
        textLvl.Size = New Size(110, 23)
        textLvl.TabIndex = 23
        ' 
        ' Lvl
        ' 
        Lvl.AutoSize = True
        Lvl.Location = New Point(35, 65)
        Lvl.Name = "Lvl"
        Lvl.Size = New Size(41, 15)
        Lvl.TabIndex = 17
        Lvl.Text = "Label2"
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
        ' frmEduLevel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 160)
        Controls.Add(cmdExit)
        Controls.Add(cmdSave)
        Controls.Add(textLvl)
        Controls.Add(Lvl)
        Controls.Add(ID)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmEduLevel"
        StartPosition = FormStartPosition.CenterParent
        Text = "frmEduLevel"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents cmdExit As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents textLvl As TextBox
    Friend WithEvents Lvl As Label
    Friend WithEvents ID As Label
End Class
