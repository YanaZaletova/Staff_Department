<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTypeDoc
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
        textType = New TextBox()
        Type = New Label()
        ID = New Label()
        SuspendLayout()
        ' 
        ' cmdExit
        ' 
        cmdExit.Location = New Point(578, 154)
        cmdExit.Margin = New Padding(3, 2, 3, 2)
        cmdExit.Name = "cmdExit"
        cmdExit.Size = New Size(82, 22)
        cmdExit.TabIndex = 34
        cmdExit.Text = "Закрыть"
        cmdExit.UseVisualStyleBackColor = True
        ' 
        ' cmdSave
        ' 
        cmdSave.Location = New Point(439, 154)
        cmdSave.Margin = New Padding(3, 2, 3, 2)
        cmdSave.Name = "cmdSave"
        cmdSave.Size = New Size(82, 22)
        cmdSave.TabIndex = 33
        cmdSave.Text = "Сохранить"
        cmdSave.UseVisualStyleBackColor = True
        ' 
        ' textType
        ' 
        textType.Location = New Point(155, 86)
        textType.Margin = New Padding(3, 2, 3, 2)
        textType.Name = "textType"
        textType.Size = New Size(340, 23)
        textType.TabIndex = 32
        ' 
        ' Type
        ' 
        Type.AutoSize = True
        Type.Location = New Point(38, 91)
        Type.Name = "Type"
        Type.Size = New Size(41, 15)
        Type.TabIndex = 31
        Type.Text = "Label2"
        ' 
        ' ID
        ' 
        ID.AutoSize = True
        ID.Location = New Point(614, 20)
        ID.Name = "ID"
        ID.Size = New Size(41, 15)
        ID.TabIndex = 30
        ID.Text = "Label1"
        ' 
        ' frmTypeDoc
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 201)
        Controls.Add(cmdExit)
        Controls.Add(cmdSave)
        Controls.Add(textType)
        Controls.Add(Type)
        Controls.Add(ID)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmTypeDoc"
        StartPosition = FormStartPosition.CenterParent
        Text = "s"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmdExit As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents textType As TextBox
    Friend WithEvents Type As Label
    Friend WithEvents ID As Label
End Class
