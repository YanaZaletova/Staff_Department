<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBank
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
        textBank = New TextBox()
        Bank = New Label()
        ID = New Label()
        SuspendLayout()
        ' 
        ' cmdExit
        ' 
        cmdExit.Location = New Point(447, 165)
        cmdExit.Margin = New Padding(3, 2, 3, 2)
        cmdExit.Name = "cmdExit"
        cmdExit.Size = New Size(82, 22)
        cmdExit.TabIndex = 29
        cmdExit.Text = "Закрыть"
        cmdExit.UseVisualStyleBackColor = True
        ' 
        ' cmdSave
        ' 
        cmdSave.Location = New Point(299, 165)
        cmdSave.Margin = New Padding(3, 2, 3, 2)
        cmdSave.Name = "cmdSave"
        cmdSave.Size = New Size(82, 22)
        cmdSave.TabIndex = 28
        cmdSave.Text = "Сохранить"
        cmdSave.UseVisualStyleBackColor = True
        ' 
        ' textBank
        ' 
        textBank.Location = New Point(129, 49)
        textBank.Margin = New Padding(3, 2, 3, 2)
        textBank.Name = "textBank"
        textBank.Size = New Size(110, 23)
        textBank.TabIndex = 23
        ' 
        ' Bank
        ' 
        Bank.AutoSize = True
        Bank.Location = New Point(31, 49)
        Bank.Name = "Bank"
        Bank.Size = New Size(41, 15)
        Bank.TabIndex = 17
        Bank.Text = "Label2"
        ' 
        ' ID
        ' 
        ID.AutoSize = True
        ID.Location = New Point(522, 7)
        ID.Name = "ID"
        ID.Size = New Size(41, 15)
        ID.TabIndex = 16
        ID.Text = "Label1"
        ' 
        ' frmBank
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(578, 196)
        Controls.Add(cmdExit)
        Controls.Add(cmdSave)
        Controls.Add(textBank)
        Controls.Add(Bank)
        Controls.Add(ID)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmBank"
        StartPosition = FormStartPosition.CenterParent
        Text = "frmBank"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents cmdExit As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents textBank As TextBox
    Friend WithEvents Bank As Label
    Friend WithEvents ID As Label
End Class
