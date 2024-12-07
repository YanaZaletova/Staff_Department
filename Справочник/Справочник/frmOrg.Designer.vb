<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrg
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
        textDocWho = New TextBox()
        DocWho = New Label()
        ID = New Label()
        SuspendLayout()
        ' 
        ' cmdExit
        ' 
        cmdExit.Location = New Point(572, 148)
        cmdExit.Margin = New Padding(3, 2, 3, 2)
        cmdExit.Name = "cmdExit"
        cmdExit.Size = New Size(82, 22)
        cmdExit.TabIndex = 34
        cmdExit.Text = "Закрыть"
        cmdExit.UseVisualStyleBackColor = True
        ' 
        ' cmdSave
        ' 
        cmdSave.Location = New Point(433, 148)
        cmdSave.Margin = New Padding(3, 2, 3, 2)
        cmdSave.Name = "cmdSave"
        cmdSave.Size = New Size(82, 22)
        cmdSave.TabIndex = 33
        cmdSave.Text = "Сохранить"
        cmdSave.UseVisualStyleBackColor = True
        ' 
        ' textDocWho
        ' 
        textDocWho.Location = New Point(149, 80)
        textDocWho.Margin = New Padding(3, 2, 3, 2)
        textDocWho.Name = "textDocWho"
        textDocWho.Size = New Size(340, 23)
        textDocWho.TabIndex = 32
        ' 
        ' DocWho
        ' 
        DocWho.AutoSize = True
        DocWho.Location = New Point(32, 86)
        DocWho.Name = "DocWho"
        DocWho.Size = New Size(41, 15)
        DocWho.TabIndex = 31
        DocWho.Text = "Label2"
        ' 
        ' ID
        ' 
        ID.AutoSize = True
        ID.Location = New Point(608, 14)
        ID.Name = "ID"
        ID.Size = New Size(41, 15)
        ID.TabIndex = 30
        ID.Text = "Label1"
        ' 
        ' frmOrg
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 190)
        Controls.Add(cmdExit)
        Controls.Add(cmdSave)
        Controls.Add(textDocWho)
        Controls.Add(DocWho)
        Controls.Add(ID)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmOrg"
        StartPosition = FormStartPosition.CenterParent
        Text = "frmOrg"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmdExit As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents textDocWho As TextBox
    Friend WithEvents DocWho As Label
    Friend WithEvents ID As Label
End Class
