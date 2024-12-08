
Public Class frmAuthors
    Private Sub frmAuthors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAuthors.Text = "Разработчики:" & vbCrLf & "Ялалова Юлиана — разработчик и тестировщик" & vbCrLf & "Залётова Яна - разработчик и тестировщик"
        cmdClose.Text = "Закрыть"
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmAuthors_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.HelpButtonClicked
        Help.ShowHelp(Me, helpFileName, HelpNavigator.Topic, "about_authors.html")
    End Sub
End Class