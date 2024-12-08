<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAuthors
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
        lblAuthors = New Label()
        cmdClose = New Button()
        HelpProvider1 = New HelpProvider()
        SuspendLayout()
        ' 
        ' lblAuthors
        ' 
        lblAuthors.AutoSize = True
        HelpProvider1.SetHelpKeyword(lblAuthors, "Авторы")
        HelpProvider1.SetHelpNavigator(lblAuthors, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpString(lblAuthors, "Если у вас возникли вопросы или предложения, свяжитесь с нами: Email: supportpo@mail.ru, Телефон: +7 (909) 789-15-49 ")
        lblAuthors.Location = New Point(23, 56)
        lblAuthors.Name = "lblAuthors"
        HelpProvider1.SetShowHelp(lblAuthors, True)
        lblAuthors.Size = New Size(53, 20)
        lblAuthors.TabIndex = 0
        lblAuthors.Text = "Label1"
        ' 
        ' cmdClose
        ' 
        cmdClose.ImageAlign = ContentAlignment.TopLeft
        cmdClose.Location = New Point(309, 271)
        cmdClose.Name = "cmdClose"
        cmdClose.Size = New Size(132, 38)
        cmdClose.TabIndex = 1
        cmdClose.Text = "Button1"
        cmdClose.UseVisualStyleBackColor = True
        ' 
        ' HelpProvider1
        ' 
        HelpProvider1.HelpNamespace = "E:\ПО\Практические\5практич\Справочная система\Справочная система.chm"
        ' 
        ' frmAuthors
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(465, 321)
        Controls.Add(cmdClose)
        Controls.Add(lblAuthors)
        FormBorderStyle = FormBorderStyle.FixedSingle
        HelpButton = True
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmAuthors"
        StartPosition = FormStartPosition.CenterParent
        Text = "Об авторах"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblAuthors As Label
    Friend WithEvents cmdClose As Button
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
