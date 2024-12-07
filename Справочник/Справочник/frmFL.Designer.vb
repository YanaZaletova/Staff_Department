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
        ID.Location = New Point(584, 9)
        ID.Name = "ID"
        ID.Size = New Size(41, 15)
        ID.TabIndex = 0
        ID.Text = "Label1"
        ' 
        ' Fam
        ' 
        Fam.AutoSize = True
        Fam.Location = New Point(10, 19)
        Fam.Name = "Fam"
        Fam.Size = New Size(41, 15)
        Fam.TabIndex = 1
        Fam.Text = "Label2"
        ' 
        ' Imya
        ' 
        Imya.AutoSize = True
        Imya.Location = New Point(10, 62)
        Imya.Name = "Imya"
        Imya.Size = New Size(41, 15)
        Imya.TabIndex = 2
        Imya.Text = "Label3"
        ' 
        ' Otch
        ' 
        Otch.AutoSize = True
        Otch.Location = New Point(10, 106)
        Otch.Name = "Otch"
        Otch.Size = New Size(41, 15)
        Otch.TabIndex = 3
        Otch.Text = "Label4"
        ' 
        ' DateBirth
        ' 
        DateBirth.AutoSize = True
        DateBirth.Location = New Point(10, 152)
        DateBirth.Name = "DateBirth"
        DateBirth.Size = New Size(41, 15)
        DateBirth.TabIndex = 4
        DateBirth.Text = "Label5"
        ' 
        ' Address
        ' 
        Address.AutoSize = True
        Address.Location = New Point(10, 206)
        Address.Name = "Address"
        Address.Size = New Size(41, 15)
        Address.TabIndex = 5
        Address.Text = "Label6"
        ' 
        ' Tel
        ' 
        Tel.AutoSize = True
        Tel.Location = New Point(10, 292)
        Tel.Name = "Tel"
        Tel.Size = New Size(41, 15)
        Tel.TabIndex = 6
        Tel.Text = "Label7"
        ' 
        ' textFam
        ' 
        textFam.Location = New Point(133, 16)
        textFam.Margin = New Padding(3, 2, 3, 2)
        textFam.Name = "textFam"
        textFam.Size = New Size(110, 23)
        textFam.TabIndex = 7
        ' 
        ' textImya
        ' 
        textImya.Location = New Point(133, 62)
        textImya.Margin = New Padding(3, 2, 3, 2)
        textImya.Name = "textImya"
        textImya.Size = New Size(110, 23)
        textImya.TabIndex = 8
        ' 
        ' textOtch
        ' 
        textOtch.Location = New Point(133, 104)
        textOtch.Margin = New Padding(3, 2, 3, 2)
        textOtch.Name = "textOtch"
        textOtch.Size = New Size(110, 23)
        textOtch.TabIndex = 9
        ' 
        ' textAddress
        ' 
        textAddress.Location = New Point(133, 204)
        textAddress.Margin = New Padding(3, 2, 3, 2)
        textAddress.Multiline = True
        textAddress.Name = "textAddress"
        textAddress.Size = New Size(196, 62)
        textAddress.TabIndex = 11
        ' 
        ' textTel
        ' 
        textTel.Location = New Point(133, 290)
        textTel.Margin = New Padding(3, 2, 3, 2)
        textTel.Name = "textTel"
        textTel.Size = New Size(110, 23)
        textTel.TabIndex = 12
        ' 
        ' cmdSave
        ' 
        cmdSave.Location = New Point(431, 307)
        cmdSave.Margin = New Padding(3, 2, 3, 2)
        cmdSave.Name = "cmdSave"
        cmdSave.Size = New Size(82, 22)
        cmdSave.TabIndex = 13
        cmdSave.Text = "Сохранить"
        cmdSave.UseVisualStyleBackColor = True
        ' 
        ' cmdExit
        ' 
        cmdExit.Location = New Point(557, 307)
        cmdExit.Margin = New Padding(3, 2, 3, 2)
        cmdExit.Name = "cmdExit"
        cmdExit.Size = New Size(82, 22)
        cmdExit.TabIndex = 14
        cmdExit.Text = "Закрыть"
        cmdExit.UseVisualStyleBackColor = True
        ' 
        ' textDateBirth
        ' 
        textDateBirth.Location = New Point(133, 149)
        textDateBirth.Margin = New Padding(3, 2, 3, 2)
        textDateBirth.Name = "textDateBirth"
        textDateBirth.Size = New Size(110, 23)
        textDateBirth.TabIndex = 15
        ' 
        ' frmFL
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 338)
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
        Margin = New Padding(3, 2, 3, 2)
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
