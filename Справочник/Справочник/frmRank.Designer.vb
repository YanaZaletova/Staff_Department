<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRank
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
        textWage = New TextBox()
        textRank = New TextBox()
        Wage = New Label()
        Rank = New Label()
        ID = New Label()
        SuspendLayout()
        ' 
        ' cmdExit
        ' 
        cmdExit.Location = New Point(583, 307)
        cmdExit.Margin = New Padding(3, 2, 3, 2)
        cmdExit.Name = "cmdExit"
        cmdExit.Size = New Size(82, 22)
        cmdExit.TabIndex = 29
        cmdExit.Text = "Закрыть"
        cmdExit.UseVisualStyleBackColor = True
        ' 
        ' cmdSave
        ' 
        cmdSave.Location = New Point(457, 307)
        cmdSave.Margin = New Padding(3, 2, 3, 2)
        cmdSave.Name = "cmdSave"
        cmdSave.Size = New Size(82, 22)
        cmdSave.TabIndex = 28
        cmdSave.Text = "Сохранить"
        cmdSave.UseVisualStyleBackColor = True
        ' 
        ' textWage
        ' 
        textWage.Location = New Point(158, 120)
        textWage.Margin = New Padding(3, 2, 3, 2)
        textWage.Name = "textWage"
        textWage.Size = New Size(110, 23)
        textWage.TabIndex = 24
        ' 
        ' textRank
        ' 
        textRank.Location = New Point(158, 52)
        textRank.Margin = New Padding(3, 2, 3, 2)
        textRank.Name = "textRank"
        textRank.Size = New Size(110, 23)
        textRank.TabIndex = 23
        ' 
        ' Wage
        ' 
        Wage.AutoSize = True
        Wage.Location = New Point(36, 122)
        Wage.Name = "Wage"
        Wage.Size = New Size(41, 15)
        Wage.TabIndex = 18
        Wage.Text = "Label3"
        ' 
        ' Rank
        ' 
        Rank.AutoSize = True
        Rank.Location = New Point(36, 58)
        Rank.Name = "Rank"
        Rank.Size = New Size(41, 15)
        Rank.TabIndex = 17
        Rank.Text = "Label2"
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
        ' frmRank
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 338)
        Controls.Add(cmdExit)
        Controls.Add(cmdSave)
        Controls.Add(textWage)
        Controls.Add(textRank)
        Controls.Add(Wage)
        Controls.Add(Rank)
        Controls.Add(ID)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmRank"
        StartPosition = FormStartPosition.CenterParent
        Text = "frmRank"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents cmdExit As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents textWage As TextBox
    Friend WithEvents textRank As TextBox
    Friend WithEvents Wage As Label
    Friend WithEvents Rank As Label
    Friend WithEvents ID As Label
End Class
