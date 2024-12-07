Public Class Сотрудник

    Private intID As Integer
    Private intFL As Integer
    Private intRank As Integer
    Private intDischarge As Integer
    Private intRating As String
    Private strDatePr As String
    Private strDateUvol As String
    Private strComment As String


    Public Property ИД() As Integer
        Get
            Return intID
        End Get
        Set(value As Integer)
            intID = value
        End Set
    End Property

    Public Property Физлицо() As Integer
        Get
            Return intFL
        End Get
        Set(value As Integer)
            intFL = value
        End Set
    End Property

    Public Property Должность() As Integer
        Get
            Return intRank
        End Get
        Set(value As Integer)
            intRank = value
        End Set
    End Property

    Public Property Разряд() As Integer
        Get
            Return intDischarge
        End Get
        Set(value As Integer)
            intDischarge = value
        End Set
    End Property

    Public Property Рейтинг() As Integer
        Get
            Return intRating
        End Get
        Set(value As Integer)
            intRating = value
        End Set
    End Property

    Public Property Дата_приёма() As String
        Get
            Return strDatePr
        End Get
        Set(value As String)
            strDatePr = value
        End Set
    End Property

    Public Property Дата_увольнения() As String
        Get
            Return strDateUvol
        End Get
        Set(value As String)
            strDateUvol = value
        End Set
    End Property

    Public Property Примечания() As String
        Get
            Return strComment
        End Get
        Set(value As String)
            strComment = value
        End Set
    End Property


    Public Sub New(ByVal intID As Integer)
        If ЕстьТакой(intID) = True Then
            Dim strConnectionString As String = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
            Dim strQuery As String = "SELECT * FROM Сотрудник WHERE ИД=" & intID
            Try
                Dim objConnection As New OleDb.OleDbConnection(strConnectionString)
                objConnection.Open()
                Dim objCommand As New OleDb.OleDbCommand(strQuery, objConnection)
                Dim objDataReader As OleDb.OleDbDataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)

                While objDataReader.Read() = True
                    With Me
                        .ИД = objDataReader.GetValue(0)
                        .Физлицо = objDataReader.GetValue(1)
                        .Должность = objDataReader.GetValue(2)
                        .Разряд = objDataReader.GetValue(3)
                        .Рейтинг = objDataReader.GetValue(4)
                        .Дата_приёма = objDataReader.GetValue(5)
                        .Дата_увольнения = objDataReader.GetValue(6)
                        .Примечания = objDataReader.GetValue(7)

                    End With
                End While
                objDataReader.Close()
                objConnection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            With Me
                .ИД = MaxID("Сотрудник", "ИД") + 1
                .Физлицо = 0
                .Должность = 0
                .Разряд = 0
                .Рейтинг = 0
                .Дата_приёма = "(не указана)"
                .Дата_увольнения = "(не указана)"
                .Примечания = "(не указаны)"

            End With

        End If
    End Sub


    Public Function ЕстьТакой(ByVal intID As Integer) As Boolean
        Dim strConnectionString As String = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
        Dim strQuery As String = "SELECT COUNT(*) FROM Сотрудник WHERE ИД=" & intID
        Dim intCount As Integer = 0

        Try
            Dim objConnection As New OleDb.OleDbConnection(strConnectionString)
            objConnection.Open()
            Dim objCommand As New OleDb.OleDbCommand(strQuery, objConnection)
            Dim objDataReader As OleDb.OleDbDataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)

            While objDataReader.Read() = True
                intCount = objDataReader.GetValue(0)
            End While
            objDataReader.Close()
            objConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If intCount > 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Function Add(ByVal objFL As Сотрудник) As Boolean
        Dim strConnectionString As String = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
        Dim strQuery As String = "INSERT INTO Сотрудник(ИД,Физлицо,Должность,Разряд,Рейтинг,Дата_приёма,Дата_увольнения,Примечания) VALUES (" & objFL.ИД & ",'" & objFL.Физлицо & "','" & objFL.Должность & "','" & objFL.Разряд & "','" & objFL.Рейтинг & "','" & objFL.Дата_приёма & "','" & objFL.Дата_увольнения & "','" & objFL.Примечания & "')"
        Dim objConnection As New OleDb.OleDbConnection(strConnectionString)

        Try
            objConnection.Open()
            Dim objCommand As New OleDb.OleDbCommand(strQuery, objConnection)
            With objCommand
                .Connection = objConnection
                .ExecuteNonQuery()
            End With
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка добавления элемента в справочник", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            objConnection.Close()
        End Try
    End Function

    Public Function Edit(ByVal objFL As Сотрудник) As Boolean
        Dim strConnectionString As String = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
        Dim strQuery As String = "UPDATE Сотрудник SET Физлицо='" & objFL.Физлицо & "', Должность='" & objFL.Должность & "', Разряд='" & objFL.Разряд & "', Рейтинг='" & objFL.Рейтинг & "', Дата_приёма='" & objFL.Дата_приёма & "',Дата_увольнения='" & objFL.Дата_увольнения & "',Примечания='" & objFL.Примечания & "' WHERE ИД=" & objFL.ИД
        Dim objConnection As New OleDb.OleDbConnection(strConnectionString)

        Try
            objConnection.Open()
            Dim objCommand As New OleDb.OleDbCommand(strQuery, objConnection)
            With objCommand
                .Connection = objConnection
                .ExecuteNonQuery()
            End With
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка редактирования элемента справочника", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            objConnection.Close()
        End Try
    End Function

    Public Shared Function Delete(ByVal intID As Integer) As Boolean
        Dim strConnectionString As String = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
        Dim strQuery As String = "DELETE FROM Сотрудник WHERE ИД = " & intID
        Dim objConnection As New OleDb.OleDbConnection(strConnectionString)

        Try
            objConnection.Open()
            Dim objCommand As New OleDb.OleDbCommand(strQuery, objConnection)
            With objCommand
                .Connection = objConnection
                .ExecuteNonQuery()
            End With
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка при удалении элемента справочника", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            objConnection.Close()
        End Try
    End Function

End Class
