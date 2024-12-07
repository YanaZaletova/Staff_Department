Public Class frmListWorker

    Public Sub CreateWorkerList()

        Dim strConnectionString As String = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
        Dim strQuery As String = "SELECT Сотрудник.ИД, Фамилия, Имя, Отчество, Должность.Должность, Разряд, Рейтинг, Дата_приёма, Дата_увольнения, Примечания FROM Сотрудник, Физлицо, Должность WHERE Сотрудник.Физлицо = Физлицо.ИД AND Сотрудник.Должность = Должность.ИД ORDER BY Должность.Должность, Фамилия, Имя, Отчество"
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
                .Add("Фамилия")
                .Add("Имя")
                .Add("Отчество")
                .Add("Должность")
                .Add("Разряд")
                .Add("Рейтинг")
                .Add("Дата приёма")
                .Add("Дата увольнения")
                .Add("Примечания")
            End With

            While objDataReader.Read() = True
                If objDataReader.GetValue(0) <> 0 Then
                    intCount += 1
                    dtDataTable.Rows.Add(New String() {objDataReader.GetValue(0), intCount, objDataReader.GetValue(1), objDataReader.GetValue(2), objDataReader.GetValue(3), objDataReader.GetValue(4), objDataReader.GetValue(5), objDataReader.GetValue(6), objDataReader.GetValue(7), objDataReader.GetValue(8), objDataReader.GetValue(9)})
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
            .Columns(10).Width = 250
        End With

        lblTotalField.Text = intCount
        lblCount.Text = "Всего сотрудников: "
        cmdExit.Text = "Закрыть"

        If intCount >= 1 Then
            With dgdList
                .Rows(0).Selected = True
            End With
        End If

    End Sub

    Private Sub frmListWorker_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        With Me
            .Text = "Сотрудники"
            .Icon = My.Resources.wr
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

        Call CreateWorkerList()
    End Sub

    Private Sub dgdList_Click(sender As Object, e As System.EventArgs) Handles dgdList.Click
        intIDFL = dgdList.Item(0, dgdList.CurrentRow.Index).Value
    End Sub

    Private Sub tsbAdd_Click(sender As System.Object, e As System.EventArgs) Handles tsbAdd.Click

        'Dim objFL1 As Физлицо = New Физлицо(98754834)

        strFormMode = "ADD"
        frmWorker.Show()

    End Sub

    Private Sub tsbEdit_Click(sender As System.Object, e As System.EventArgs) Handles tsbEdit.Click

        Dim objFL1 As Сотрудник = New Сотрудник(intIDFL)

        strFormMode = "EDIT"

        frmWorker.Show()

    End Sub

    Private Sub tsbRemove_Click(sender As System.Object, e As System.EventArgs) Handles tsbRemove.Click

        Dim objFL1 As Сотрудник = New Сотрудник(intIDFL)

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

        Call CreateWorkerList()

    End Sub

    Private Sub tsbExit_Click(sender As System.Object, e As System.EventArgs) Handles tsbExit.Click, cmdExit.Click

        Me.Close()

    End Sub

End Class