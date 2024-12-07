<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQual
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
        textQual = New TextBox()
        Qual = New Label()
        ID = New Label()
        SuspendLayout()
        ' 
        ' cmdExit
        ' 
        cmdExit.Location = New Point(527, 113)
        cmdExit.Margin = New Padding(3, 2, 3, 2)
        cmdExit.Name = "cmdExit"
        cmdExit.Size = New Size(82, 22)
        cmdExit.TabIndex = 34
        cmdExit.Text = "Закрыть"
        cmdExit.UseVisualStyleBackColor = True
        ' 
        ' cmdSave
        ' 
        cmdSave.Location = New Point(419, 113)
        cmdSave.Margin = New Padding(3, 2, 3, 2)
        cmdSave.Name = "cmdSave"
        cmdSave.Size = New Size(82, 22)
        cmdSave.TabIndex = 33
        cmdSave.Text = "Сохранить"
        cmdSave.UseVisualStyleBackColor = True
        ' 
        ' textQual
        ' 
        textQual.Location = New Point(150, 73)
        textQual.Margin = New Padding(3, 2, 3, 2)
        textQual.Name = "textQual"
        textQual.Size = New Size(256, 23)
        textQual.TabIndex = 32
        ' 
        ' Qual
        ' 
        Qual.AutoSize = True
        Qual.Location = New Point(27, 78)
        Qual.Name = "Qual"
        Qual.Size = New Size(41, 15)
        Qual.TabIndex = 31
        Qual.Text = "Label2"
        ' 
        ' ID
        ' 
        ID.AutoSize = True
        ID.Location = New Point(606, 22)
        ID.Name = "ID"
        ID.Size = New Size(41, 15)
        ID.TabIndex = 30
        ID.Text = "Label1"
        ' 
        ' frmQual
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 152)
        Controls.Add(cmdExit)
        Controls.Add(cmdSave)
        Controls.Add(textQual)
        Controls.Add(Qual)
        Controls.Add(ID)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmQual"
        StartPosition = FormStartPosition.CenterParent
        Text = "frmQual"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmdExit As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents textQual As TextBox
    Friend WithEvents Qual As Label
    Friend WithEvents ID As Label
End Class
