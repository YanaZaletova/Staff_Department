<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFL
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
        components = New ComponentModel.Container()
        ID = New Label()
        Fam = New Label()
        Imya = New Label()
        Otch = New Label()
        DateBirth = New Label()
        Address = New Label()
        Tel = New Label()
        textFam = New TextBox()
        textImya = New TextBox()
        textOtch = New TextBox()
        textAddress = New TextBox()
        textTel = New TextBox()
        cmdSave = New Button()
        cmdExit = New Button()
        textDateBirth = New TextBox()
        ToolTip1 = New ToolTip(components)
        SuspendLayout()
        ' 
        ' ID
        ' 
        ID.AutoSize = True
        ID.Location = New Point(667, 12)
        ID.Name = "ID"
        ID.Size = New Size(53, 20)
        ID.TabIndex = 0
        ID.Text = "Label1"
        ' 
        ' Fam
        ' 
        Fam.AutoSize = True
        Fam.Location = New Point(11, 25)
        Fam.Name = "Fam"
        Fam.Size = New Size(53, 20)
        Fam.TabIndex = 1
        Fam.Text = "Label2"
        ' 
        ' Imya
        ' 
        Imya.AutoSize = True
        Imya.Location = New Point(11, 83)
        Imya.Name = "Imya"
        Imya.Size = New Size(53, 20)
        Imya.TabIndex = 2
        Imya.Text = "Label3"
        ' 
        ' Otch
        ' 
        Otch.AutoSize = True
        Otch.Location = New Point(11, 141)
        Otch.Name = "Otch"
        Otch.Size = New Size(53, 20)
        Otch.TabIndex = 3
        Otch.Text = "Label4"
        ' 
        ' DateBirth
        ' 
        DateBirth.AutoSize = True
        DateBirth.Location = New Point(11, 203)
        DateBirth.Name = "DateBirth"
        DateBirth.Size = New Size(53, 20)
        DateBirth.TabIndex = 4
        DateBirth.Text = "Label5"
        ' 
        ' Address
        ' 
        Address.AutoSize = True
        Address.Location = New Point(11, 275)
        Address.Name = "Address"
        Address.Size = New Size(53, 20)
        Address.TabIndex = 5
        Address.Text = "Label6"
        ' 
        ' Tel
        ' 
        Tel.AutoSize = True
        Tel.Location = New Point(11, 389)
        Tel.Name = "Tel"
        Tel.Size = New Size(53, 20)
        Tel.TabIndex = 6
        Tel.Text = "Label7"
        ' 
        ' textFam
        ' 
        textFam.Location = New Point(152, 21)
        textFam.Name = "textFam"
        textFam.Size = New Size(341, 27)
        textFam.TabIndex = 7
        ' 
        ' textImya
        ' 
        textImya.Location = New Point(152, 83)
        textImya.Name = "textImya"
        textImya.Size = New Size(341, 27)
        textImya.TabIndex = 8
        ' 
        ' textOtch
        ' 
        textOtch.Location = New Point(152, 139)
        textOtch.Name = "textOtch"
        textOtch.Size = New Size(341, 27)
        textOtch.TabIndex = 9
        ' 
        ' textAddress
        ' 
        textAddress.Location = New Point(152, 272)
        textAddress.Multiline = True
        textAddress.Name = "textAddress"
        textAddress.Size = New Size(341, 81)
        textAddress.TabIndex = 11
        ' 
        ' textTel
        ' 
        textTel.Location = New Point(152, 387)
        textTel.Name = "textTel"
        textTel.Size = New Size(341, 27)
        textTel.TabIndex = 12
        ' 
        ' cmdSave
        ' 
        cmdSave.Location = New Point(557, 410)
        cmdSave.Name = "cmdSave"
        cmdSave.Size = New Size(94, 29)
        cmdSave.TabIndex = 13
        cmdSave.Text = "Сохранить"
        cmdSave.UseVisualStyleBackColor = True
        ' 
        ' cmdExit
        ' 
        cmdExit.Location = New Point(679, 409)
        cmdExit.Name = "cmdExit"
        cmdExit.Size = New Size(94, 29)
        cmdExit.TabIndex = 14
        cmdExit.Text = "Закрыть"
        cmdExit.UseVisualStyleBackColor = True
        ' 
        ' textDateBirth
        ' 
        textDateBirth.Location = New Point(152, 199)
        textDateBirth.Name = "textDateBirth"
        textDateBirth.Size = New Size(341, 27)
        textDateBirth.TabIndex = 15
        ' 
        ' frmFL
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 451)
        Controls.Add(textDateBirth)
        Controls.Add(cmdExit)
        Controls.Add(cmdSave)
        Controls.Add(textTel)
        Controls.Add(textAddress)
        Controls.Add(textOtch)
        Controls.Add(textImya)
        Controls.Add(textFam)
        Controls.Add(Tel)
        Controls.Add(Address)
        Controls.Add(DateBirth)
        Controls.Add(Otch)
        Controls.Add(Imya)
        Controls.Add(Fam)
        Controls.Add(ID)
        Name = "frmFL"
        StartPosition = FormStartPosition.CenterParent
        Text = "frmFL"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ID As Label
    Friend WithEvents Fam As Label
    Friend WithEvents Imya As Label
    Friend WithEvents Otch As Label
    Friend WithEvents DateBirth As Label
    Friend WithEvents Address As Label
    Friend WithEvents Tel As Label
    Friend WithEvents textFam As TextBox
    Friend WithEvents textImya As TextBox
    Friend WithEvents textOtch As TextBox
    Friend WithEvents textAddress As TextBox
    Friend WithEvents textTel As TextBox
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents textDateBirth As TextBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
