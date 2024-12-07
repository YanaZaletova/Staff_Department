Public Class Тип_документа

    Private intID As Integer
    Private strType As String

    Public Property ИД() As Integer
        Get
            Return intID
        End Get
        Set(value As Integer)
            intID = value
        End Set
    End Property

    Public Property Тип_документа() As String
        Get
            Return strType
        End Get
        Set(value As String)
            strType = value
        End Set
    End Property

    Public Sub New(ByVal intID As Integer)
        If ЕстьТакой(intID) = True Then
            Dim strConnectionString As String = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
            Dim strQuery As String = "SELECT * FROM Тип_документа WHERE ИД=" & intID
            Try
                Dim objConnection As New OleDb.OleDbConnection(strConnectionString)
                objConnection.Open()
                Dim objCommand As New OleDb.OleDbCommand(strQuery, objConnection)
                Dim objDataReader As OleDb.OleDbDataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)

                While objDataReader.Read() = True
                    With Me
                        .ИД = objDataReader.GetValue(0)
                        .Тип_документа = objDataReader.GetValue(1)

                    End With
                End While
                objDataReader.Close()
                objConnection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            With Me
                .ИД = MaxID("Тип_документа", "ИД") + 1
                .Тип_документа = "(не указан)"

            End With

        End If
    End Sub


    Public Function ЕстьТакой(ByVal intID As Integer) As Boolean
        Dim strConnectionString As String = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
        Dim strQuery As String = "SELECT COUNT(*) FROM Тип_документа WHERE ИД=" & intID
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


    Public Function Add(ByVal objFL As Тип_документа) As Boolean
        Dim strConnectionString As String = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
        Dim strQuery As String = "INSERT INTO Тип_документа(ИД,Тип_документа) VALUES (" & objFL.ИД & ",'" & objFL.Тип_документа & "')"
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

    Public Function Edit(ByVal objFL As Тип_документа) As Boolean
        Dim strConnectionString As String = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
        Dim strQuery As String = "UPDATE Тип_документа SET Type='" & objFL.Тип_документа & "' WHERE ИД=" & objFL.ИД
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
        Dim strQuery As String = "DELETE FROM Тип_документа WHERE ИД = " & intID
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
