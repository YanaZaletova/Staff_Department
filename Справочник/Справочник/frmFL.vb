Imports System.Reflection.Metadata

Public Class frmFL

    Private toolTip As New ToolTip()
    Dim objFL1 As Физлицо

    Private Sub frmFL_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        With Me

            Select Case strFormMode
                Case "ADD"
                    objFL1 = New Физлицо(98754834)
                    .Text = "Новое физическое лицо"
                    .Icon = My.Resources.add

                Case "EDIT"
                    objFL1 = New Физлицо(intIDFL)
                    .Text = "Редактирование сведений о физическом лице"
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
        Fam.Text = "Фамилия"
        Imya.Text = "Имя"
        Otch.Text = "Отчество"
        DateBirth.Text = "Дата рождения"
        Address.Text = "Адрес"
        Tel.Text = "Телефон"

        ToolTip1.ShowAlways = True

        ToolTip1.SetToolTip(textFam, "Введите фамилию физического лица.")
        ToolTip1.SetToolTip(textImya, "Введите имя физического лица.")
        ToolTip1.SetToolTip(textOtch, "Введите отчество физического лица.")
        ToolTip1.SetToolTip(textDateBirth, "Введите дату рождения физического лица.")
        ToolTip1.SetToolTip(textAddress, "Введите адрес физического лица.")
        ToolTip1.SetToolTip(textTel, "Введите телефон физического лица.")

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
            textFam.Text = .Фамилия
            textImya.Text = .Имя
            textOtch.Text = .Отчество
            textDateBirth.Text = .Дата_рождения
            textAddress.Text = .Адрес
            textTel.Text = .Телефон
        End With
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        With objFL1
            textFam.Text = .Фамилия
            textImya.Text = .Имя
            textOtch.Text = .Отчество
            textDateBirth.Text = .Дата_рождения
            textAddress.Text = .Адрес
            textTel.Text = .Телефон
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

        Call frmListFL.CreateFLList()
        Me.Close()

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class