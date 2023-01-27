
Imports System.Data.SqlClient
Imports System.Text
Imports Microsoft.Data.SqlClient

Public Class CreatePassword
    Dim con As New Microsoft.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Save Flies VB\KeyCrypt\KeyCrypt\KeyCrypt\Database1.mdf;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim cmd1 As New SqlCommand
    Dim c As String
    Dim d As String




    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub deleet_Click(sender As Object, e As EventArgs) Handles SignUp.Click
        Dim CurChar As String
        Dim HasNum As Boolean
        Dim HasCaps As Boolean
        Dim HasLower As Boolean
        Dim HasChar As Boolean
        Dim x As Long
        Dim MinLength As Integer = 8
        Dim PW As String = TextBoxC.Text
        Dim chk As Boolean


        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select bkpstr,upassAS from Login"
        cmd.CommandType = CommandType.Text
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        sdr.Read()
        c = sdr("bkpstr").ToString()
        d = sdr("upassAS").ToString()
        con.Close()
        If TextBoxN.Text = "" Or TextBoxC.Text = "" Or TextBoxR.Text = "" Then
            MsgBox("Enter the Recovery Key and Password!", MsgBoxStyle.Exclamation, "Enter all fields")
            chk = True
        ElseIf c <> TextBoxR.Text Then
            MsgBox("That Recovery key did not match. Please try again!", MsgBoxStyle.Exclamation, "Check Recovery Key")
            chk = True
        ElseIf TextBoxN.Text <> TextBoxC.Text Then
            MsgBox("Those passwords did not match. Please try again!", MsgBoxStyle.Critical, "Password didn't match")
            chk = True
        ElseIf Len(PW) < MinLength Then
            MsgBox("Password should be atleast 8 charcters", MsgBoxStyle.Exclamation, "Warning!")
            chk = True

        ElseIf TextBoxN.Text = d Then
            MsgBox("New password cannot be same as existing password. Please re-enter new password, or click on back to continue same password.", MsgBoxStyle.Critical, "Password matches existing password")
            chk = True
        ElseIf TextBoxC.Text.Trim = "" Then
            MsgBox("Password cannot have just spaces. Please re-insert the Password!", MsgBoxStyle.Critical, "Check the Fields")
            chk = True

        Else
            For x = 1 To Len(PW)
                CurChar = Mid(PW, x, 1)
                Select Case Asc(CurChar)
                    Case 32 To 47       'Characters
                        HasChar = True

                    Case 48 To 57   'Numbers
                        HasNum = True

                    Case 58 To 64       'Characters
                        HasChar = True

                    Case 65 To 90   'Capital letters
                        HasCaps = True

                    Case 91 To 96       'Characters
                        HasChar = True

                    Case 97 To 122  'Lower case letters
                        HasLower = True

                    Case 123 To 127       'Characters
                        HasChar = True

                End Select
            Next x
            chk = False
        End If


        If Not chk Then
            If Not HasNum Then
                MsgBox("Enter a strong password with a Upper case, Lower case, number and a symbol", MsgBoxStyle.Critical, "Enter a strong password")

            ElseIf Not HasCaps Then
                MsgBox("Enter a strong password with a Upper case, Lower case, number and a symbol", MsgBoxStyle.Critical, "Enter a strong password")
            ElseIf Not HasLower Then
                MsgBox("Enter a strong password with a Upper case, Lower case, number and a symbol", MsgBoxStyle.Critical, "Enter a strong password")
            ElseIf Not HasChar Then
                MsgBox("Enter a strong password with a Upper case, Lower case, number and a symbol", MsgBoxStyle.Critical, "Enter a strong password")
            ElseIf TextBoxR.Text = c And TextBoxN.Text = TextBoxC.Text Then
                con.Open()
                cmd1.Connection = con
                cmd1.CommandText = "UPDATE Login SET upassAS=('" + TextBoxN.Text + "')"
                cmd1.ExecuteNonQuery()
                con.Close()
                MsgBox("Updated Successfully", MsgBoxStyle.Information, "Success")
                MsgBox("Please Head to Dashboard after Signing In and Press <Reset Recovery Key> Button to Change the Default Key to New", MsgBoxStyle.Information, "Success")

                Me.Close()
                Form1.Show()
            End If
        End If

    End Sub

    Private Sub Guna2ControlBox2_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox2.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub ShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassword.CheckedChanged
        If ShowPassword.Checked Then
            TextBoxN.PasswordChar = ""
            TextBoxC.PasswordChar = ""
        Else
            TextBoxN.PasswordChar = "●"
            TextBoxC.PasswordChar = "●"
        End If
    End Sub
End Class