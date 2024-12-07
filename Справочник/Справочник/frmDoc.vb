Public Class frmDoc
    Dim objFL1 As Документ

    Private Sub frmDoc_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        With Me

            Select Case strFormMode
                Case "ADD"
                    objFL1 = New Документ(98754834)
                    .Text = "Новый документ"
                    .Icon = My.Resources.add

                Case "EDIT"
                    objFL1 = New Документ(intIDFL)
                    .Text = "Редактирование сведений о документе"
                    .Icon = My.Resources.edit
                Case Else
                    MessageBox.Show("Неизвестный режим отображения формы", "Ошибка", MessageBoxButtons.OK,
MessageBoxIcon.Error)
                    Exit Sub
            End Select

            .WindowState = FormWindowState.Normal
            .MaximizeBox = False
            .MinimizeBox = False

        End With

        ID.Visible = False
        DocWho.Text = "Организация"
        Type.Text = "Тип документа"
        Seria.Text = "Серия"
        Number.Text = "Номер"
        DateDoc.Text = "Дата выдачи"
        FL.Text = "Физлицо"

        With cmdExit
            .Text = "Закрыть"
            .Image = frmListFL.ilsIcons.Images(3)
            .ImageAlign = ContentAlignment.MiddleLeft
            .TextAlign = ContentAlignment.MiddleLeft
            .TextImageRelation = TextImageRelation.ImageBeforeText
        End With

        With cmdSave
            .Text = "Сохранить"
            .Image = frmListFL.ilsIcons.Images(4)
            .ImageAlign = ContentAlignment.MiddleLeft
            .TextAlign = ContentAlignment.MiddleLeft
            .TextImageRelation = TextImageRelation.ImageBeforeText
        End With


        With objFL1
            ID.Text = .ИД
            textDocWho.Text = .Организация
            textType.Text = .Тип_документа
            textSeria.Text = .Серия
            textNumber.Text = .Номер
            textDateDoc.Text = .Дата_выдачи
            textFL.Text = .Физлицо
        End With
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        With objFL1
            textDocWho.Text = .Организация
            textType.Text = .Тип_документа
            textSeria.Text = .Серия
            textNumber.Text = .Номер
            textDateDoc.Text = .Дата_выдачи
            textFL.Text = .Физлицо
        End With

        Select Case strFormMode
            Case "ADD"
                If objFL1.Add(objFL1) = True Then
                    MessageBox.Show("Новый элемент успешно добавлен в справочник", "Добавление элемента в 
справочник", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Case "EDIT"
                If objFL1.Edit(objFL1) = True Then
                    MessageBox.Show("Изменения в элемент справочника успешно внесены", "Редактирование 
элемента в справочнике", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case Else
                MessageBox.Show("Неизвестный режим отображения формы", "Ошибка", MessageBoxButtons.OK,
MessageBoxIcon.Error)
                Exit Sub
        End Select

        Call frmListDocument.CreateDocList()
        Me.Close()

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class