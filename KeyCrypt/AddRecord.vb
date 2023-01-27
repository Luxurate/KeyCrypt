Imports System.Data.SqlClient
Imports System.Text
Imports Microsoft.Data.SqlClient
Public Class AddRecord
    Dim con As New Microsoft.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Save Flies VB\KeyCrypt\KeyCrypt\KeyCrypt\Database1.mdf;Integrated Security=True")
    Dim cmd As New SqlCommand

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

    Private Sub LinkLabel1_Click(sender As Object, e As EventArgs) Handles LinkLabel1.Click
        TextBoxpass.Text = RandomString(8, 25)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBoxsite.Text = "" Or TextBoxuname.Text = "" Or TextBoxpass.Text = "" Or TextBoxlink.Text = "" Then
            MsgBox("Fill in all the fields to proceed.", MsgBoxStyle.Information, "Enter Details!")
        ElseIf TextBoxuname.Text.Trim = "" Then
            MsgBox("Username cannot have just spaces. Please re-insert the Name!", MsgBoxStyle.Critical, "Check the Fields")
        ElseIf TextBoxpass.Text.Trim = "" Then
            MsgBox("Password cannot have just spaces. Please re-insert the Password!", MsgBoxStyle.Critical, "Check the Fields")
        ElseIf TextBoxsite.Text.Trim = "" Then
            MsgBox("Site cannot have just spaces. Please re-insert the Site!", MsgBoxStyle.Critical, "Check the Fields")
        ElseIf TextBoxlink.Text.Trim = "" Then
            MsgBox("Link cannot have just spaces. Please re-insert the Link!", MsgBoxStyle.Critical, "Check the Fields")
        ElseIf TextBoxsite.Text.Contains(" ") Then
            MsgBox("Site cannot have spaces. Please Re-insert the Site name", MsgBoxStyle.Information, "Check site name")
        ElseIf TextBoxlink.Text.Contains(" ") Then
            MsgBox("Link cannot have spaces. Please Re-insert correct Link", MsgBoxStyle.Information, "Check Website link")
        Else

            con.Open()
            Dim cmd4 As New SqlCommand
            Dim cmd2 As New SqlCommand, cmd3 As New SqlCommand
            Dim n As Integer = -1



            cmd3.Connection = con
            cmd3.CommandText = "Select count ([lsite]) from [Main] where lsite like ('%" + TextBoxsite.Text + "%')"
            n = Convert.ToInt32(cmd3.ExecuteScalar())
            con.Close()

            If n > 0 Then
                con.Open()
                Dim cmd6 As New SqlCommand
                cmd6.Connection = con
                cmd6.CommandText = "Select count ([lpass]) from [Main] where lname like ('%" + TextBoxuname.Text + "%') and lpass like ('%" + TextBoxpass.Text + "%')"
                Dim countpass As Integer = -1
                countpass = Convert.ToInt32(cmd6.ExecuteScalar())
                con.Close()


                If countpass > 0 Then
                    MsgBox("Username and password cannot be the same", MsgBoxStyle.Critical, "Re-enter username and password")
                Else
                    n += 1
                    Dim x As String = TextBoxsite.Text + " (" + n.ToString + ")"

                    con.Open()
                    cmd2.Connection = con
                    cmd2.CommandText = "insert into Main(lurl,lpass,lname,lsite) values('" + TextBoxlink.Text + "','" + TextBoxpass.Text + "','" + TextBoxuname.Text + "','" + x + "' )"

                    cmd2.ExecuteNonQuery()
                    con.Close()
                    MsgBox("Account successfully created", MsgBoxStyle.Information, "Success!")
                    Dashboard.Refresh()
                    Dashboard.ResetText()

                    Dashboard.Show()

                    Me.Close()
                End If
            Else

                con.Open()
                cmd4.Connection = con
                cmd4.CommandText = "insert into Main(lurl,lpass,lname,lsite) values('" + TextBoxlink.Text + "','" + TextBoxpass.Text + "','" + TextBoxuname.Text + "','" + TextBoxsite.Text + "' )"
                cmd4.ExecuteNonQuery()
                con.Close()
                MsgBox("Account successfully created", MsgBoxStyle.Information, "Success!")
                TextBoxsite.Text = ""
                TextBoxuname.Text = ""
                TextBoxpass.Text = ""
                TextBoxlink.Text = ""
                Me.Refresh()
                Me.ResetText()
                Me.Show()



            End If
        End If
    End Sub

    Private Sub Showpass_CheckedChanged(sender As Object, e As EventArgs) Handles Showpass.CheckedChanged
        If Showpass.Checked Then
            TextBoxpass.PasswordChar = ""



        ElseIf TextBoxpass.PasswordChar = "●" Then

        End If
    End Sub

    Private Sub TextBoxpass_TextChanged(sender As Object, e As EventArgs) Handles TextBoxpass.TextChanged

    End Sub

    Private Sub TextBoxsite_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxsite.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
            TextBoxuname.Focus()
        End If

    End Sub

    Private Sub TextBoxuname_TextChanged(sender As Object, e As EventArgs) Handles TextBoxuname.TextChanged

    End Sub

    Private Sub TextBoxuname_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxuname.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TextBoxsite_TextChanged(sender As Object, e As EventArgs) Handles TextBoxsite.TextChanged

    End Sub

    Private Sub TextBoxpass_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxpass.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class