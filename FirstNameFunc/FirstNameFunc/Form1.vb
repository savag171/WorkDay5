Option Strict On

Public Class Form1

    Private Sub btnDetermine_Click(sender As System.Object, e As System.EventArgs) Handles btnDetermine.Click
        Dim name As String
        name = txtFullName.Text

        Dim result As String
        result = FirstName(name)

        txtFirstName.Text = result
    End Sub

    Function FirstName(ByVal name As String) As String

        Dim IDX As Integer
        IDX = name.IndexOf(" ")

        Dim fName As String
        fName = name.Substring(0, IDX)

        Return fName

    End Function

End Class
