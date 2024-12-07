Public Class Документ

    Private intID As Integer
    Private intDocWho As Integer
    Private intType As Integer
    Private strSeria As String
    Private strNumber As String
    Private strDateDoc As String
    Private intFL As Integer

    Public Property ИД() As Integer
        Get
            Return intID
        End Get
        Set(value As Integer)
            intID = value
        End Set
    End Property
    Public Property Организация() As Integer
        Get
            Return intDocWho
        End Get
        Set(value As Integer)
            intDocWho = value
        End Set
    End Property

    Public Property Тип_документа() As Integer
        Get
            Return intType
        End Get
        Set(value As Integer)
            intType = value
        End Set
    End Property

    Public Property Серия() As String
        Get
            Return strSeria
        End Get
        Set(value As String)
            strSeria = value
        End Set
    End Property

    Public Property Номер() As String
        Get
            Return strNumber
        End Get
        Set(value As String)
            strNumber = value
        End Set
    End Property

    Public Property Дата_выдачи() As String
        Get
            Return strDateDoc
        End Get
        Set(value As String)
            strDateDoc = value
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

    Public Sub New(ByVal intID As Integer)
        If ЕстьТакой(intID) = True Then
            Dim strConnectionString As String = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
            Dim strQuery As String = "SELECT * FROM Документ WHERE ИД=" & intID
            Try
                Dim objConnection As New OleDb.OleDbConnection(strConnectionString)
                objConnection.Open()
                Dim objCommand As New OleDb.OleDbCommand(strQuery, objConnection)
                Dim objDataReader As OleDb.OleDbDataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)

                While objDataReader.Read() = True
                    With Me
                        .ИД = objDataReader.GetValue(0)
                        .Организация = objDataReader.GetValue(1)
                        .Тип_документа = objDataReader.GetValue(2)
                        .Серия = objDataReader.GetValue(3)
                        .Номер = objDataReader.GetValue(4)
                        .Дата_выдачи = objDataReader.GetValue(5)
                        .Физлицо = objDataReader.GetValue(6)

                    End With
                End While
                objDataReader.Close()
                objConnection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            With Me
                .ИД = MaxID("Документ", "ИД") + 1
                .Организация = 0
                .Тип_документа = 0
                .Серия = "(не указана)"
                .Номер = "(не указан)"
                .Дата_выдачи = "(не указана)"
                .Физлицо = 0

            End With

        End If
    End Sub


    Public Function ЕстьТакой(ByVal intID As Integer) As Boolean
        Dim strConnectionString As String = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
        Dim strQuery As String = "SELECT COUNT(*) FROM Документ WHERE ИД=" & intID
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


    Public Function Add(ByVal objFL As Документ) As Boolean
        Dim strConnectionString As String = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
        Dim strQuery As String = "INSERT INTO Документ(ИД,Организация,Тип_документа,Серия,Номер,Дата_выдачи,Физлицо) VALUES (" & objFL.ИД & ",'" & objFL.Организация & "','" & objFL.Тип_документа & "','" & objFL.Серия & "','" & objFL.Номер & "','" & objFL.Дата_выдачи & "','" & objFL.Физлицо & "')"
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

    Public Function Edit(ByVal objFL As Документ) As Boolean
        Dim strConnectionString As String = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
        Dim strQuery As String = "UPDATE Документ SET ИД='" & objFL.ИД & "', Организация='" & objFL.Организация & "', Тип_документа='" & objFL.Тип_документа & "', Серия='" & objFL.Серия & "', Номер='" & objFL.Номер & "',Дата_выдачи='" & objFL.Дата_выдачи & "' WHERE Физлицо=" & objFL.Физлицо
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
        Dim strQuery As String = "DELETE FROM Документ WHERE ИД = " & intID
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
