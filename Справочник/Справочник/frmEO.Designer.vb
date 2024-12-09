<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEO
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
        textInst = New TextBox()
        Inst = New Label()
        ID = New Label()
        SuspendLayout()
        ' 
        ' cmdExit
        ' 
        cmdExit.Location = New Point(574, 143)
        cmdExit.Margin = New Padding(3, 2, 3, 2)
        cmdExit.Name = "cmdExit"
        cmdExit.Size = New Size(82, 22)
        cmdExit.TabIndex = 29
        cmdExit.Text = "Закрыть"
        cmdExit.UseVisualStyleBackColor = True
        ' 
        ' cmdSave
        ' 
        cmdSave.Location = New Point(435, 143)
        cmdSave.Margin = New Padding(3, 2, 3, 2)
        cmdSave.Name = "cmdSave"
        cmdSave.Size = New Size(82, 22)
        cmdSave.TabIndex = 28
        cmdSave.Text = "Сохранить"
        cmdSave.UseVisualStyleBackColor = True
        ' 
        ' textInst
        ' 
        textInst.Location = New Point(150, 75)
        textInst.Margin = New Padding(3, 2, 3, 2)
        textInst.Name = "textInst"
        textInst.Size = New Size(145, 23)
        textInst.TabIndex = 23
        ' 
        ' Inst
        ' 
        Inst.AutoSize = True
        Inst.Location = New Point(33, 80)
        Inst.Name = "Inst"
        Inst.Size = New Size(41, 15)
        Inst.TabIndex = 17
        Inst.Text = "Label2"
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
        ' frmEducInst
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 196)
        Controls.Add(cmdExit)
        Controls.Add(cmdSave)
        Controls.Add(textInst)
        Controls.Add(Inst)
        Controls.Add(ID)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmEducInst"
        StartPosition = FormStartPosition.CenterParent
        Text = "frmEO"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmdExit As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents textInst As TextBox
    Friend WithEvents Inst As Label
    Friend WithEvents ID As Label
End Class
