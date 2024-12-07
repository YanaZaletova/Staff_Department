Imports System.Data.OleDb
Public Class Физлицо

    Private intID As Integer
    Private strFam As String
    Private strImya As String
    Private strOtch As String
    Private strDateBirth As String
    Private strAddress As String
    Private strPhone As String
    Private strInn As String
    Private strSnils As String


    Public Property ИД() As Integer
        Get
            Return intID
        End Get
        Set(value As Integer)
            intID = value
        End Set
    End Property

    Public Property Фамилия() As String
        Get
            Return strFam
        End Get
        Set(value As String)
            strFam = value
        End Set
    End Property

    Public Property Имя() As String
        Get
            Return strImya
        End Get
        Set(value As String)
            strImya = value
        End Set
    End Property

    Public Property Отчество() As String
        Get
            Return strOtch
        End Get
        Set(value As String)
            strOtch = value
        End Set
    End Property

    Public Property Дата_рождения() As String
        Get
            Return strDateBirth
        End Get
        Set(value As String)
            strDateBirth = value
        End Set
    End Property

    Public Property Адрес() As String
        Get
            Return strAddress
        End Get
        Set(value As String)
            strAddress = value
        End Set
    End Property

    Public Property Телефон() As String
        Get
            Return strPhone
        End Get
        Set(value As String)
            strPhone = value
        End Set
    End Property

    Public Property ИНН() As String
        Get
            Return strInn
        End Get
        Set(value As String)
            strInn = value
        End Set
    End Property

    Public Property СНИЛС() As String
        Get
            Return strSnils
        End Get
        Set(value As String)
            strSnils = value
        End Set
    End Property


    Public Sub New(ByVal intID As Integer)
        If ЕстьТакой(intID) = True Then
            Dim strConnectionString As String = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
            Dim strQuery As String = "SELECT * FROM Физлицо WHERE ИД=" & intID
            Try
                Dim objConnection As New OleDb.OleDbConnection(strConnectionString)
                objConnection.Open()
                Dim objCommand As New OleDb.OleDbCommand(strQuery, objConnection)
                Dim objDataReader As OleDb.OleDbDataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)

                While objDataReader.Read() = True
                    With Me
                        .ИД = objDataReader.GetValue(0)
                        .Фамилия = objDataReader.GetValue(1)
                        .Имя = objDataReader.GetValue(2)
                        .Отчество = objDataReader.GetValue(3)
                        .Дата_рождения = objDataReader.GetValue(4)
                        .Адрес = objDataReader.GetValue(5)
                        .Телефон = objDataReader.GetValue(6)
                        .ИНН = objDataReader.GetValue(7)
                        .СНИЛС = objDataReader.GetValue(8)
                    End With
                End While
                objDataReader.Close()
                objConnection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            With Me
                .ИД = MaxID("Физлицо", "ИД") + 1
                .Фамилия = "(не указана)"
                .Имя = "(не указано)"
                .Отчество = "(не указано)"
                .Дата_рождения = "(не указана)"
                .Адрес = "(не указан)"
                .Телефон = "(не указан)"
                .ИНН = "(не указан)"
                .СНИЛС = "(не указан)"
            End With

        End If
    End Sub

    Public Function ЕстьТакой(ByVal intID As Integer) As Boolean
        Dim strConnectionString As String = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
        Dim strQuery As String = "SELECT COUNT(*) FROM Физлицо WHERE ИД=" & intID
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


    Public Function Add(ByVal objFL As Физлицо) As Boolean
        Dim strConnectionString As String = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
        Dim strQuery As String = "INSERT INTO Физлицо(ИД,Фамилия,Имя,Отчество,Дата_рождения,Адрес,Телефон,ИНН,СНИЛС) VALUES (" & objFL.ИД & ",'" & objFL.Фамилия & "','" & objFL.Имя & "','" & objFL.Отчество & "','" & objFL.Дата_рождения & "','" & objFL.Адрес & "','" & objFL.Телефон & "','" & objFL.ИНН & "','" & objFL.СНИЛС & "')"
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

    Public Function Edit(ByVal objFL As Физлицо) As Boolean
        Dim strConnectionString As String = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
        Dim strQuery As String = "UPDATE Физлицо SET Фамилия='" & objFL.Фамилия & "', Имя='" & objFL.Имя & "', Отчество='" & objFL.Отчество & "', Дата_рождения='" & objFL.Дата_рождения & "', Адрес='" & objFL.Адрес & "',Телефон='" & objFL.Телефон & "' ,ИНН='" & objFL.ИНН & "' ,СНИЛС='" & objFL.СНИЛС & "' WHERE ИД=" & objFL.ИД
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
        Dim strQuery As String = "DELETE FROM Физлицо WHERE ИД = " & intID
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

