Public Class Банковские_карты

    Private intID As Integer
    Private strNum As String
    Private intBank As Integer
    Private intFL As Integer

    Public Property ИД() As Integer
        Get
            Return intID
        End Get
        Set(value As Integer)
            intID = value
        End Set
    End Property

    Public Property Номер_карты() As String
        Get
            Return strNum
        End Get
        Set(value As String)
            strNum = value
        End Set
    End Property

    Public Property Банк() As Integer
        Get
            Return intBank
        End Get
        Set(value As Integer)
            intBank = value
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
            Dim strQuery As String = "SELECT * FROM Банковские_карты WHERE ИД=" & intID
            Try
                Dim objConnection As New OleDb.OleDbConnection(strConnectionString)
                objConnection.Open()
                Dim objCommand As New OleDb.OleDbCommand(strQuery, objConnection)
                Dim objDataReader As OleDb.OleDbDataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)

                While objDataReader.Read() = True
                    With Me
                        .ИД = objDataReader.GetValue(0)
                        .Номер_карты = objDataReader.GetValue(1)
                        .Банк = objDataReader.GetValue(2)
                        .Физлицо = objDataReader.GetValue(3)

                    End With
                End While
                objDataReader.Close()
                objConnection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            With Me
                .ИД = MaxID("Банковские_карты", "ИД") + 1
                .Номер_карты = "(не указан)"
                .Банк = 0
                .Физлицо = 0

            End With

        End If
    End Sub


    Public Function ЕстьТакой(ByVal intID As Integer) As Boolean
        Dim strConnectionString As String = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
        Dim strQuery As String = "SELECT COUNT(*) FROM Банковские_карты WHERE ИД=" & intID
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


    Public Function Add(ByVal objFL As Банковские_карты) As Boolean
        Dim strConnectionString As String = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
        Dim strQuery As String = "INSERT INTO Банковские_карты(ИД,Номер_карты,Банк,Физлицо) VALUES (" & objFL.ИД & ",'" & objFL.Номер_карты & "','" & objFL.Банк & "','" & objFL.Физлицо & "')"
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

    Public Function Edit(ByVal objFL As Банковские_карты) As Boolean
        Dim strConnectionString As String = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
        Dim strQuery As String = "UPDATE Банковские_карты SET Номер_карты='" & objFL.Номер_карты & "', Банк='" & objFL.Банк & "', Физлицо='" & objFL.Физлицо & "' WHERE ИД=" & objFL.ИД
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
        Dim strQuery As String = "DELETE FROM Банковские_карты WHERE ИД = " & intID
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
