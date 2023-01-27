Imports System.Data.SqlClient
Imports System.Text
Imports Microsoft.Data.SqlClient

Public Class RecoveryKey
    Dim con As New Microsoft.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Save Flies VB\KeyCrypt\KeyCrypt\KeyCrypt\Database1.mdf;Integrated Security=True")

    Function RandomString(minCharacters As Integer, maxCharacters As Integer)

        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()+-{}[]~<>"
        Static r As New Random
        Dim chactersInString As Integer = r.Next(minCharacters, maxCharacters)
        Dim sb As New StringBuilder
        For i As Integer = 1 To chactersInString
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function



    Private Sub deleet_Click(sender As Object, e As EventArgs) Handles BtnChgbkpstr.Click
        Textboxbkpstr.Text = RandomString(10, 10)
    End Sub

    Private Sub BtnRestore_Click(sender As Object, e As EventArgs) Handles BtnSavebkpstr.Click
        Dim ans1 As Integer = MsgBox("Are you sure you want to Overwrite?", vbOKCancel, "Recovery Key")
        If ans1 = vbOK Then
            con.Open()

            Dim cmd4 As New SqlCommand
            cmd4.Connection = con
            cmd4.CommandText = "UPDATE Login SET bkpstr=('" + Textboxbkpstr.Text + "')"
            cmd4.ExecuteNonQuery()
            MsgBox("Items saved successfully!", MsgBoxStyle.Information, "Recovery Key")
            MsgBox("Please Save this Key As you will need this for Recovery Purposes!", MsgBoxStyle.Information, "Recovery Key")
            con.Close()
        End If
    End Sub
End Class