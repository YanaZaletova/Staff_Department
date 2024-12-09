Public Class frmListEducation
    Public Sub CreateEduList()

        Dim strConnectionString As String = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
        Dim strQuery As String = "SELECT Образование.ИД, Год_окончания_обучения, Уровень_образования.Уровень_образования, Специальность.Специальность, Квалификация.Квалификация, Учебное_заведение.Учебное_заведение, Фамилия, Имя, Отчество FROM Образование, Уровень_образования, Специальность, Квалификация, Учебное_заведение, Физлицо WHERE Образование.Уровень_образования = Уровень_образования.ИД AND Образование.Специальность = Специальность.ИД AND Образование.Квалификация = Квалификация.ИД AND Образование.Учебное_заведение = Учебное_заведение.ИД AND Образование.Физлицо = Физлицо.ИД ORDER BY Год_окончания_обучения, Фамилия"
        Dim intCount As Integer = 0
        Dim intIDRow As Integer = 0
        Dim dtDataTable As New DataTable

        Try
            Dim objConnection As New OleDb.OleDbConnection(strConnectionString)
            objConnection.Open()
            Dim objCommand As New OleDb.OleDbCommand(strQuery, objConnection)
            Dim objDataReader As OleDb.OleDbDataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)

            With dtDataTable.Columns
                .Add("ID")
                .Add("№ пп")
                .Add("Год окончания обучения")
                .Add("Уровень образования")
                .Add("Специальность")
                .Add("Квалификация")
                .Add("Учебное_заведение")
                .Add("Фамилия")
                .Add("Имя")
                .Add("Отчество")
            End With

            While objDataReader.Read() = True
                If objDataReader.GetValue(0) <> 0 Then
                    intCount += 1
                    dtDataTable.Rows.Add(New String() {objDataReader.GetValue(0), intCount, objDataReader.GetValue(1), objDataReader.GetValue(2), objDataReader.GetValue(3), objDataReader.GetValue(4), objDataReader.GetValue(5), objDataReader.GetValue(6), objDataReader.GetValue(7), objDataReader.GetValue(8)})
                End If
            End While
            objDataReader.Close()
            objConnection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        With dgdList
            .DataSource = dtDataTable
            .ReadOnly = True
            .AllowUserToAddRows = False
            .Columns(0).Visible = False
            .Columns(1).Width = 40
            .Columns(3).Width = 250
            .Columns(4).Width = 300
        End With

        lblCount.Text = "Всего образований: "
        lblTotalField.Text = intCount
        cmdExit.Text = "Закрыть"

        If intCount >= 1 Then
            With dgdList
                .Rows(0).Selected = True
            End With
        End If

    End Sub

    Private Sub frmListEducation_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        With Me
            .Text = "Образование"
            .Icon = My.Resources.education
            .WindowState = FormWindowState.Normal
            .MaximizeBox = False
            .MinimizeBox = False
        End With

        tsbAdd.Image = ilsIcons.Images(0)
        tsbEdit.Image = ilsIcons.Images(2)
        tsbRemove.Image = ilsIcons.Images(1)
        tsbExit.Image = ilsIcons.Images(3)

        With cmdExit
            .Image = ilsIcons.Images(3)
            .ImageAlign = ContentAlignment.MiddleLeft
            .TextAlign = ContentAlignment.MiddleLeft
            .TextImageRelation = TextImageRelation.ImageBeforeText
        End With

        Call CreateEduList()

    End Sub

    Private Sub dgdList_Click(sender As Object, e As System.EventArgs) Handles dgdList.Click
        intIDFL = dgdList.Item(0, dgdList.CurrentRow.Index).Value
    End Sub

    Private Sub tsbAdd_Click(sender As System.Object, e As System.EventArgs) Handles tsbAdd.Click

        'Dim objFL1 As Физлицо = New Физлицо(98754834)

        strFormMode = "ADD"
        frmEducation.Show()

    End Sub

    Private Sub tsbEdit_Click(sender As System.Object, e As System.EventArgs) Handles tsbEdit.Click

        Dim objFL1 As Образование = New Образование(intIDFL)

        strFormMode = "EDIT"

        frmEducation.Show()

    End Sub

    Private Sub tsbRemove_Click(sender As System.Object, e As System.EventArgs) Handles tsbRemove.Click

        Dim objFL1 As Образование = New Образование(intIDFL)

        If intIDFL > 0 Then
            If MessageBox.Show("Вы действительно хотите удалить элемент с идентификатором " & intIDFL & " из 
справочника?", "Удаление элемента из справочника", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If objFL1.Delete(intIDFL) = True Then
                    MessageBox.Show("Элемент и идентификатором  " & intIDFL & " успешно удален из справочника",
"Удаление элемента из справочника", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                Exit Sub
            End If
        Else
            MessageBox.Show("Требуется указать элемент справочника, который Вы хотите удалить", "Удаление 
элемента из справочника", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        Call CreateEduList()

    End Sub

    Private Sub tsbExit_Click(sender As System.Object, e As System.EventArgs) Handles tsbExit.Click, cmdExit.Click

        Me.Close()

    End Sub
End Class