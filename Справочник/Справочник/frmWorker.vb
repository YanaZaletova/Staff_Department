Public Class frmWorker
    Dim objFL1 As Сотрудник

    Private Sub frmWorker_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        With Me

            Select Case strFormMode
                Case "ADD"
                    objFL1 = New Сотрудник(98754834)
                    .Text = "Новый сотрудник"
                    .Icon = My.Resources.add

                Case "EDIT"
                    objFL1 = New Сотрудник(intIDFL)
                    .Text = "Редактирование сведений о сотруднике"
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
        FL.Text = "Физлицо"
        Rank.Text = "Должность"
        Discharge.Text = "Разряд"
        Rating.Text = "Рейтинг"
        DatePr.Text = "Дата приёма"
        DateUvol.Text = "Дата увольнения"
        Comment.Text = "Примечания"

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
            textFL.Text = .Физлицо
            textRank.Text = .Должность
            textDischarge.Text = .Разряд
            textRating.Text = .Рейтинг
            textDatePr.Text = .Дата_приёма
            textDateUvol.Text = .Дата_увольнения
            textComment.Text = .Примечания
        End With
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        With objFL1
            textFL.Text = .Физлицо
            textRank.Text = .Должность
            textDischarge.Text = .Разряд
            textRating.Text = .Рейтинг
            textDatePr.Text = .Дата_приёма
            textDateUvol.Text = .Дата_увольнения
            textComment.Text = .Примечания
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

        Call frmListWorker.CreateWorkerList()
        Me.Close()

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub txtTel_TextChanged(sender As Object, e As EventArgs) Handles textDateUvol.Validating
        Dim datePriem As Date = textDatePr.Text
        Dim dateUvol As Date = textDateUvol.Text
        If textDateUvol.Text <> "(не указана)" And dateUvol < datePriem Then
            ErrorProvider1.SetError(textDateUvol, "Дата увольнения не может быть раньше даты приёма")
        Else
            ErrorProvider1.SetError(textDateUvol, "")
        End If
    End Sub
End Class