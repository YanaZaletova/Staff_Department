<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDoc
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
        textNumber = New TextBox()
        cmdExit = New Button()
        cmdSave = New Button()
        textSeria = New TextBox()
        textType = New TextBox()
        textDocWho = New TextBox()
        Number = New Label()
        Seria = New Label()
        Type = New Label()
        DocWho = New Label()
        ID = New Label()
        textDateDoc = New TextBox()
        DateDoc = New Label()
        textFL = New TextBox()
        FL = New Label()
        SuspendLayout()
        ' 
        ' textNumber
        ' 
        textNumber.Location = New Point(158, 149)
        textNumber.Margin = New Padding(3, 2, 3, 2)
        textNumber.Name = "textNumber"
        textNumber.Size = New Size(110, 23)
        textNumber.TabIndex = 30
        ' 
        ' cmdExit
        ' 
        cmdExit.Location = New Point(543, 302)
        cmdExit.Margin = New Padding(3, 2, 3, 2)
        cmdExit.Name = "cmdExit"
        cmdExit.Size = New Size(82, 22)
        cmdExit.TabIndex = 29
        cmdExit.Text = "Закрыть"
        cmdExit.UseVisualStyleBackColor = True
        ' 
        ' cmdSave
        ' 
        cmdSave.Location = New Point(398, 302)
        cmdSave.Margin = New Padding(3, 2, 3, 2)
        cmdSave.Name = "cmdSave"
        cmdSave.Size = New Size(82, 22)
        cmdSave.TabIndex = 28
        cmdSave.Text = "Сохранить"
        cmdSave.UseVisualStyleBackColor = True
        ' 
        ' textSeria
        ' 
        textSeria.Location = New Point(158, 104)
        textSeria.Margin = New Padding(3, 2, 3, 2)
        textSeria.Name = "textSeria"
        textSeria.Size = New Size(110, 23)
        textSeria.TabIndex = 25
        ' 
        ' textType
        ' 
        textType.Location = New Point(158, 62)
        textType.Margin = New Padding(3, 2, 3, 2)
        textType.Name = "textType"
        textType.Size = New Size(110, 23)
        textType.TabIndex = 24
        ' 
        ' textDocWho
        ' 
        textDocWho.Location = New Point(158, 16)
        textDocWho.Margin = New Padding(3, 2, 3, 2)
        textDocWho.Name = "textDocWho"
        textDocWho.Size = New Size(110, 23)
        textDocWho.TabIndex = 23
        ' 
        ' Number
        ' 
        Number.AutoSize = True
        Number.Location = New Point(36, 152)
        Number.Name = "Number"
        Number.Size = New Size(41, 15)
        Number.TabIndex = 20
        Number.Text = "Label5"
        ' 
        ' Seria
        ' 
        Seria.AutoSize = True
        Seria.Location = New Point(36, 106)
        Seria.Name = "Seria"
        Seria.Size = New Size(41, 15)
        Seria.TabIndex = 19
        Seria.Text = "Label4"
        ' 
        ' Type
        ' 
        Type.AutoSize = True
        Type.Location = New Point(36, 62)
        Type.Name = "Type"
        Type.Size = New Size(41, 15)
        Type.TabIndex = 18
        Type.Text = "Label3"
        ' 
        ' DocWho
        ' 
        DocWho.AutoSize = True
        DocWho.Location = New Point(36, 19)
        DocWho.Name = "DocWho"
        DocWho.Size = New Size(41, 15)
        DocWho.TabIndex = 17
        DocWho.Text = "Label2"
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
        ' textDateDoc
        ' 
        textDateDoc.Location = New Point(158, 197)
        textDateDoc.Margin = New Padding(3, 2, 3, 2)
        textDateDoc.Name = "textDateDoc"
        textDateDoc.Size = New Size(110, 23)
        textDateDoc.TabIndex = 32
        ' 
        ' DateDoc
        ' 
        DateDoc.AutoSize = True
        DateDoc.Location = New Point(36, 200)
        DateDoc.Name = "DateDoc"
        DateDoc.Size = New Size(41, 15)
        DateDoc.TabIndex = 31
        DateDoc.Text = "Label5"
        ' 
        ' textFL
        ' 
        textFL.Location = New Point(158, 243)
        textFL.Margin = New Padding(3, 2, 3, 2)
        textFL.Name = "textFL"
        textFL.Size = New Size(110, 23)
        textFL.TabIndex = 34
        ' 
        ' FL
        ' 
        FL.AutoSize = True
        FL.Location = New Point(36, 251)
        FL.Name = "FL"
        FL.Size = New Size(41, 15)
        FL.TabIndex = 33
        FL.Text = "Label5"
        ' 
        ' frmDoc
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 335)
        Controls.Add(textFL)
        Controls.Add(FL)
        Controls.Add(textDateDoc)
        Controls.Add(DateDoc)
        Controls.Add(textNumber)
        Controls.Add(cmdExit)
        Controls.Add(cmdSave)
        Controls.Add(textSeria)
        Controls.Add(textType)
        Controls.Add(textDocWho)
        Controls.Add(Number)
        Controls.Add(Seria)
        Controls.Add(Type)
        Controls.Add(DocWho)
        Controls.Add(ID)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmDoc"
        StartPosition = FormStartPosition.CenterParent
        Text = "frmDoc"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents textNumber As TextBox
    Friend WithEvents cmdExit As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents textSeria As TextBox
    Friend WithEvents textType As TextBox
    Friend WithEvents textDocWho As TextBox
    Friend WithEvents Number As Label
    Friend WithEvents Seria As Label
    Friend WithEvents Type As Label
    Friend WithEvents DocWho As Label
    Friend WithEvents ID As Label
    Friend WithEvents textDateDoc As TextBox
    Friend WithEvents DateDoc As Label
    Friend WithEvents textFL As TextBox
    Friend WithEvents FL As Label
End Class
