Public Class Специальность

    Private intID As Integer
    Private strSpec As String

    Public Property ИД() As Integer
        Get
            Return intID
        End Get
        Set(value As Integer)
            intID = value
        End Set
    End Property

    Public Property Специальность() As String
        Get
            Return strSpec
        End Get
        Set(value As String)
            strSpec = value
        End Set
    End Property

    Public Sub New(ByVal intID As Integer)
        If ЕстьТакой(intID) = True Then
            Dim strConnectionString As String = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
            Dim strQuery As String = "SELECT * FROM Специальность WHERE ИД=" & intID
            Try
                Dim objConnection As New OleDb.OleDbConnection(strConnectionString)
                objConnection.Open()
                Dim objCommand As New OleDb.OleDbCommand(strQuery, objConnection)
                Dim objDataReader As OleDb.OleDbDataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)

                While objDataReader.Read() = True
                    With Me
                        .ИД = objDataReader.GetValue(0)
                        .Специальность = objDataReader.GetValue(1)

                    End With
                End While
                objDataReader.Close()
                objConnection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            With Me
                .ИД = MaxID("Специальность", "ИД") + 1
                .Специальность = "(не указана)"

            End With

        End If
    End Sub

    Public Function ЕстьТакой(ByVal intID As Integer) As Boolean
        Dim strConnectionString As String = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
        Dim strQuery As String = "SELECT COUNT(*) FROM Специальность WHERE ИД=" & intID
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


    Public Function Add(ByVal objFL As Специальность) As Boolean
        Dim strConnectionString As String = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
        Dim strQuery As String = "INSERT INTO Специальность(ИД,Специальность) VALUES (" & objFL.ИД & ",'" & objFL.Специальность & "')"
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

    Public Function Edit(ByVal objFL As Специальность) As Boolean
        Dim strConnectionString As String = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
        Dim strQuery As String = "UPDATE Специальность SET Специальность='" & objFL.Специальность & "' WHERE ИД=" & objFL.ИД
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
        Dim strQuery As String = "DELETE FROM Специальность WHERE ИД = " & intID
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
