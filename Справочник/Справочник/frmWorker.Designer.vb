<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorker
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
        textRating = New TextBox()
        cmdExit = New Button()
        cmdSave = New Button()
        textDateUvol = New TextBox()
        textDatePr = New TextBox()
        textDischarge = New TextBox()
        textRank = New TextBox()
        textFL = New TextBox()
        DateUvol = New Label()
        DatePr = New Label()
        Rating = New Label()
        Discharge = New Label()
        Rank = New Label()
        FL = New Label()
        ID = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        textComment = New TextBox()
        Comment = New Label()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' textRating
        ' 
        textRating.Location = New Point(158, 149)
        textRating.Margin = New Padding(3, 2, 3, 2)
        textRating.Name = "textRating"
        textRating.Size = New Size(110, 23)
        textRating.TabIndex = 30
        ' 
        ' cmdExit
        ' 
        cmdExit.Location = New Point(582, 409)
        cmdExit.Margin = New Padding(3, 2, 3, 2)
        cmdExit.Name = "cmdExit"
        cmdExit.Size = New Size(82, 22)
        cmdExit.TabIndex = 29
        cmdExit.Text = "Закрыть"
        cmdExit.UseVisualStyleBackColor = True
        ' 
        ' cmdSave
        ' 
        cmdSave.Location = New Point(456, 409)
        cmdSave.Margin = New Padding(3, 2, 3, 2)
        cmdSave.Name = "cmdSave"
        cmdSave.Size = New Size(82, 22)
        cmdSave.TabIndex = 28
        cmdSave.Text = "Сохранить"
        cmdSave.UseVisualStyleBackColor = True
        ' 
        ' textDateUvol
        ' 
        textDateUvol.Location = New Point(158, 237)
        textDateUvol.Margin = New Padding(3, 2, 3, 2)
        textDateUvol.Name = "textDateUvol"
        textDateUvol.Size = New Size(110, 23)
        textDateUvol.TabIndex = 27
        ' 
        ' textDatePr
        ' 
        textDatePr.Location = New Point(158, 194)
        textDatePr.Margin = New Padding(3, 2, 3, 2)
        textDatePr.Name = "textDatePr"
        textDatePr.Size = New Size(110, 23)
        textDatePr.TabIndex = 26
        ' 
        ' textDischarge
        ' 
        textDischarge.Location = New Point(158, 104)
        textDischarge.Margin = New Padding(3, 2, 3, 2)
        textDischarge.Name = "textDischarge"
        textDischarge.Size = New Size(110, 23)
        textDischarge.TabIndex = 25
        ' 
        ' textRank
        ' 
        textRank.Location = New Point(158, 62)
        textRank.Margin = New Padding(3, 2, 3, 2)
        textRank.Name = "textRank"
        textRank.Size = New Size(110, 23)
        textRank.TabIndex = 24
        ' 
        ' textFL
        ' 
        textFL.Location = New Point(158, 16)
        textFL.Margin = New Padding(3, 2, 3, 2)
        textFL.Name = "textFL"
        textFL.Size = New Size(110, 23)
        textFL.TabIndex = 23
        ' 
        ' DateUvol
        ' 
        DateUvol.AutoSize = True
        DateUvol.Location = New Point(36, 239)
        DateUvol.Name = "DateUvol"
        DateUvol.Size = New Size(41, 15)
        DateUvol.TabIndex = 22
        DateUvol.Text = "Label7"
        ' 
        ' DatePr
        ' 
        DatePr.AutoSize = True
        DatePr.Location = New Point(36, 196)
        DatePr.Name = "DatePr"
        DatePr.Size = New Size(41, 15)
        DatePr.TabIndex = 21
        DatePr.Text = "Label6"
        ' 
        ' Rating
        ' 
        Rating.AutoSize = True
        Rating.Location = New Point(36, 152)
        Rating.Name = "Rating"
        Rating.Size = New Size(41, 15)
        Rating.TabIndex = 20
        Rating.Text = "Label5"
        ' 
        ' Discharge
        ' 
        Discharge.AutoSize = True
        Discharge.Location = New Point(36, 106)
        Discharge.Name = "Discharge"
        Discharge.Size = New Size(41, 15)
        Discharge.TabIndex = 19
        Discharge.Text = "Label4"
        ' 
        ' Rank
        ' 
        Rank.AutoSize = True
        Rank.Location = New Point(36, 62)
        Rank.Name = "Rank"
        Rank.Size = New Size(41, 15)
        Rank.TabIndex = 18
        Rank.Text = "Label3"
        ' 
        ' FL
        ' 
        FL.AutoSize = True
        FL.Location = New Point(36, 19)
        FL.Name = "FL"
        FL.Size = New Size(41, 15)
        FL.TabIndex = 17
        FL.Text = "Label2"
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
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' textComment
        ' 
        textComment.Location = New Point(158, 284)
        textComment.Margin = New Padding(3, 2, 3, 2)
        textComment.Multiline = True
        textComment.Name = "textComment"
        textComment.Size = New Size(239, 100)
        textComment.TabIndex = 32
        ' 
        ' Comment
        ' 
        Comment.AutoSize = True
        Comment.Location = New Point(36, 286)
        Comment.Name = "Comment"
        Comment.Size = New Size(41, 15)
        Comment.TabIndex = 31
        Comment.Text = "Label7"
        ' 
        ' frmWorker
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 452)
        Controls.Add(textComment)
        Controls.Add(Comment)
        Controls.Add(textRating)
        Controls.Add(cmdExit)
        Controls.Add(cmdSave)
        Controls.Add(textDateUvol)
        Controls.Add(textDatePr)
        Controls.Add(textDischarge)
        Controls.Add(textRank)
        Controls.Add(textFL)
        Controls.Add(DateUvol)
        Controls.Add(DatePr)
        Controls.Add(Rating)
        Controls.Add(Discharge)
        Controls.Add(Rank)
        Controls.Add(FL)
        Controls.Add(ID)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmWorker"
        StartPosition = FormStartPosition.CenterParent
        Text = "frmWorker"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents textRating As TextBox
    Friend WithEvents cmdExit As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents textDateUvol As TextBox
    Friend WithEvents textDatePr As TextBox
    Friend WithEvents textDischarge As TextBox
    Friend WithEvents textRank As TextBox
    Friend WithEvents textFL As TextBox
    Friend WithEvents DateUvol As Label
    Friend WithEvents DatePr As Label
    Friend WithEvents Rating As Label
    Friend WithEvents Discharge As Label
    Friend WithEvents Rank As Label
    Friend WithEvents FL As Label
    Friend WithEvents ID As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents textComment As TextBox
    Friend WithEvents Comment As Label
End Class
