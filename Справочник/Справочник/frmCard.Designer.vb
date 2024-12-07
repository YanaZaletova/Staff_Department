<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCard
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
        textFL = New TextBox()
        textBank = New TextBox()
        textNum = New TextBox()
        FL = New Label()
        Bank = New Label()
        Num = New Label()
        ID = New Label()
        SuspendLayout()
        ' 
        ' cmdExit
        ' 
        cmdExit.Location = New Point(501, 148)
        cmdExit.Margin = New Padding(3, 2, 3, 2)
        cmdExit.Name = "cmdExit"
        cmdExit.Size = New Size(82, 22)
        cmdExit.TabIndex = 29
        cmdExit.Text = "Закрыть"
        cmdExit.UseVisualStyleBackColor = True
        ' 
        ' cmdSave
        ' 
        cmdSave.Location = New Point(368, 148)
        cmdSave.Margin = New Padding(3, 2, 3, 2)
        cmdSave.Name = "cmdSave"
        cmdSave.Size = New Size(82, 22)
        cmdSave.TabIndex = 28
        cmdSave.Text = "Сохранить"
        cmdSave.UseVisualStyleBackColor = True
        ' 
        ' textFL
        ' 
        textFL.Location = New Point(158, 104)
        textFL.Margin = New Padding(3, 2, 3, 2)
        textFL.Name = "textFL"
        textFL.Size = New Size(110, 23)
        textFL.TabIndex = 25
        ' 
        ' textBank
        ' 
        textBank.Location = New Point(158, 62)
        textBank.Margin = New Padding(3, 2, 3, 2)
        textBank.Name = "textBank"
        textBank.Size = New Size(110, 23)
        textBank.TabIndex = 24
        ' 
        ' textNum
        ' 
        textNum.Location = New Point(158, 16)
        textNum.Margin = New Padding(3, 2, 3, 2)
        textNum.Name = "textNum"
        textNum.Size = New Size(110, 23)
        textNum.TabIndex = 23
        ' 
        ' FL
        ' 
        FL.AutoSize = True
        FL.Location = New Point(36, 106)
        FL.Name = "FL"
        FL.Size = New Size(41, 15)
        FL.TabIndex = 19
        FL.Text = "Label4"
        ' 
        ' Bank
        ' 
        Bank.AutoSize = True
        Bank.Location = New Point(36, 62)
        Bank.Name = "Bank"
        Bank.Size = New Size(41, 15)
        Bank.TabIndex = 18
        Bank.Text = "Label3"
        ' 
        ' Num
        ' 
        Num.AutoSize = True
        Num.Location = New Point(36, 19)
        Num.Name = "Num"
        Num.Size = New Size(41, 15)
        Num.TabIndex = 17
        Num.Text = "Label2"
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
        ' frmCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 183)
        Controls.Add(cmdExit)
        Controls.Add(cmdSave)
        Controls.Add(textFL)
        Controls.Add(textBank)
        Controls.Add(textNum)
        Controls.Add(FL)
        Controls.Add(Bank)
        Controls.Add(Num)
        Controls.Add(ID)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmCard"
        StartPosition = FormStartPosition.CenterParent
        Text = "frmCard"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents cmdExit As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents textFL As TextBox
    Friend WithEvents textBank As TextBox
    Friend WithEvents textNum As TextBox
    Friend WithEvents FL As Label
    Friend WithEvents Bank As Label
    Friend WithEvents Num As Label
    Friend WithEvents ID As Label
End Class
