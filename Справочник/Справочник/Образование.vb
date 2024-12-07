Public Class Образование

    Private intID As Integer
    Private strYearFinish As String
    Private intLvl As Integer
    Private intSpec As Integer
    Private intQual As Integer
    Private intInst As Integer
    Private intFL As Integer

    Public Property ИД() As Integer
        Get
            Return intID
        End Get
        Set(value As Integer)
            intID = value
        End Set
    End Property
    Public Property Год_окончания_обучения() As String
        Get
            Return strYearFinish
        End Get
        Set(value As String)
            strYearFinish = value
        End Set
    End Property

    Public Property Уровень_образования() As Integer
        Get
            Return intLvl
        End Get
        Set(value As Integer)
            intLvl = value
        End Set
    End Property

    Public Property Специальность() As Integer
        Get
            Return intSpec
        End Get
        Set(value As Integer)
            intSpec = value
        End Set
    End Property

    Public Property Квалификация() As Integer
        Get
            Return intQual
        End Get
        Set(value As Integer)
            intQual = value
        End Set
    End Property

    Public Property Учебное_заведение() As Integer
        Get
            Return intInst
        End Get
        Set(value As Integer)
            intInst = value
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
            Dim strQuery As String = "SELECT * FROM Образование WHERE ИД=" & intID
            Try
                Dim objConnection As New OleDb.OleDbConnection(strConnectionString)
                objConnection.Open()
                Dim objCommand As New OleDb.OleDbCommand(strQuery, objConnection)
                Dim objDataReader As OleDb.OleDbDataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)

                While objDataReader.Read() = True
                    With Me
                        .ИД = objDataReader.GetValue(0)
                        .Год_окончания_обучения = objDataReader.GetValue(1)
                        .Уровень_образования = objDataReader.GetValue(2)
                        .Специальность = objDataReader.GetValue(3)
                        .Квалификация = objDataReader.GetValue(4)
                        .Учебное_заведение = objDataReader.GetValue(5)
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
                .ИД = MaxID("Образование", "ИД") + 1
                .Год_окончания_обучения = "(не указан)"
                .Уровень_образования = 0
                .Специальность = 0
                .Квалификация = 0
                .Учебное_заведение = 0
                .Физлицо = 0

            End With

        End If
    End Sub


    Public Function ЕстьТакой(ByVal intID As Integer) As Boolean
        Dim strConnectionString As String = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
        Dim strQuery As String = "SELECT COUNT(*) FROM Образование WHERE ИД=" & intID
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


    Public Function Add(ByVal objFL As Образование) As Boolean
        Dim strConnectionString As String = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
        Dim strQuery As String = "INSERT INTO Образование(ИД,Год_окончания_обучения,Уровень_образования,Специальность,Квалификация,Учебное_заведение,Физлицо) VALUES (" & objFL.ИД & ",'" & objFL.Год_окончания_обучения & "','" & objFL.Уровень_образования & "','" & objFL.Специальность & "','" & objFL.Квалификация & "','" & objFL.Учебное_заведение & "','" & objFL.Физлицо & "')"
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

    Public Function Edit(ByVal objFL As Образование) As Boolean
        Dim strConnectionString As String = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
        Dim strQuery As String = "UPDATE Образование SET Год_окончания_обучения='" & objFL.Год_окончания_обучения & "', Уровень_образования='" & objFL.Уровень_образования & "', Специальность='" & objFL.Специальность & "', Квалификация='" & objFL.Квалификация & "', Учебное_заведение='" & objFL.Учебное_заведение & "',Физлицо='" & objFL.Физлицо & "' WHERE ИД=" & objFL.ИД
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
        Dim strQuery As String = "DELETE FROM Образование WHERE ИД = " & intID
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
