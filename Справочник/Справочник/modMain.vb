Imports System.Data.OleDb
Module modMain

    Public strDBFileName As String = "DatabasePO.accdb"
    Public helpFileName As String = "help/help_work.chm"

    Public intIDFL As Integer = 0

    Public strFormMode As String = "EDIT"


    Public Function MaxID(ByVal strTableName As String, ByVal strFieldName As String) As Integer

        Dim strConnectionString As String = "Data Source=" & strDBFileName & ";User ID=Admin;Provider=Microsoft.ACE.OLEDB.12.0;OLE DB Services=-1"
        Dim strQuery As String = "SELECT MAX(" & strFieldName & ") FROM " & strTableName
        Dim intMaxID As Integer = 0

        Try
            Dim objConnection As New OleDb.OleDbConnection(strConnectionString)
            objConnection.Open()
            Dim objCommand As New OleDb.OleDbCommand(strQuery, objConnection)
            Dim objDataReader As OleDb.OleDbDataReader =
objCommand.ExecuteReader(CommandBehavior.CloseConnection)

            While objDataReader.Read() = True
                intMaxID = objDataReader.GetValue(0)
            End While
            objDataReader.Close()
            objConnection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return intMaxID

    End Function

End Module
