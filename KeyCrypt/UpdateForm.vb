Imports System.Data
Imports System.Text
Imports System.Configuration
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient



Public Class UpdateForm
    Dim ans As Integer
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














    Private Sub Guna2ToggleSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles Showpass.CheckedChanged

        If Showpass.Checked Then
            TextBoxpass.PasswordChar = ""



        ElseIf TextBoxpass.PasswordChar = "●" Then

        End If
    End Sub

    Private Sub TextBoxpass_TextChanged(sender As Object, e As EventArgs) Handles TextBoxpass.TextChanged
        TextBoxpass.PasswordChar = "●"
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles lnkgen.Click
        If ComboBox1.Text = "" Then
            MsgBox("Select an item to generate password.", MsgBoxStyle.Information, "Select an entry!")
        Else
            TextBoxpass.Text = RandomString(8, 25)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim st As String = ComboBox1.Text

        con.Open()
        Dim cmd4 As New SqlCommand
        cmd4.Connection = con
        cmd4.CommandText = "Select lsite,lurl,lpass,lname from Main where ('" + st + "')=lsite"
        cmd4.CommandType = CommandType.Text
        Dim sdr As SqlDataReader = cmd4.ExecuteReader()
        sdr.Read()
        If st = sdr("lsite").ToString() Then
            TextBoxuname.Text = sdr("lname").ToString()
            TextBoxpass.Text = sdr("lpass").ToString()
            TextBoxlink.Text = sdr("lurl").ToString()
            TextBoxsite.Text = sdr("lsite").ToString()
        End If
        con.Close()
    End Sub

    Private Sub UpdateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        Try
            con.Open()
            Dim da As New SqlDataAdapter("select lsite from Main", con)
            Dim ds As New DataSet
            da.Fill(ds, "1")


            For i As Integer = 0 To ds.Tables("1").Rows.Count - 1
                Me.ComboBox1.Items.Add(ds.Tables("1").Rows(i)(0))
            Next

        Catch ex As Exception
            MsgBox("Error : " + ex.Message)
        Finally
            con.Close()
        End Try



        TextBoxlink.Text = ""
        TextBoxpass.Text = ""
        TextBoxsite.Text = ""
        TextBoxuname.Text = ""
        ComboBox1.Text = "Select an Item"
    End Sub

    Private Sub BtnUpd_Click(sender As Object, e As EventArgs) Handles BtnUpd.Click
        Dim a As String
        Dim b As String
        Dim c As String
        Dim current As String = ComboBox1.Text
        ans = MsgBox("Are you sure you want to overwrite?", vbOKCancel, "Overwrite the details?")
        If ans = vbOK Then

            If ComboBox1.Text = "" Then
                MsgBox("Select an item to be overwritten", MsgBoxStyle.Critical, "Select password")
            ElseIf TextBoxuname.Text.Trim = "" Then
                MsgBox("Username cannot have just spaces. Please re-insert the Name!", MsgBoxStyle.Critical, "Re-enter Username")
            ElseIf TextBoxpass.Text.Trim = "" Then
                MsgBox("Password cannot have just spaces. Please re-insert the Password!", MsgBoxStyle.Critical, "Re-enter Password")
            ElseIf TextBoxlink.Text.Trim = "" Then
                MsgBox("Link cannot have just spaces. Please re-insert the Link!", MsgBoxStyle.Critical, "Re-enter Link")
            ElseIf TextBoxlink.Text.Contains(" ") Then
                MsgBox("Link cannot have spaces. Please Re-insert correct Link", MsgBoxStyle.Information, "Check Website link")
            Else
                con.Open()
                Dim cmd As New SqlCommand
                cmd.Connection = con
                cmd.CommandText = "Select lname, lpass, lurl from Main where lsite=('" + ComboBox1.Text + "')"
                cmd.CommandType = CommandType.Text
                Dim sdr As SqlDataReader = cmd.ExecuteReader()
                sdr.Read()
                a = sdr("lname").ToString()
                b = sdr("lpass").ToString()
                c = sdr("lurl").ToString()
                con.Close()


                Dim ans1 As Integer
                ans1 = MsgBox("Are you sure you want to Overwrite?", vbOKCancel, "Overwrite the entry?")

                If ans1 = vbOK And (a <> TextBoxuname.Text Or b <> TextBoxpass.Text Or c <> TextBoxlink.Text) Then

                    con.Open()

                    Dim cmd2 As New SqlCommand
                    cmd2.Connection = con
                    cmd2.CommandText = "UPDATE main SET lname=('" + TextBoxuname.Text + "'),lpass=('" + TextBoxpass.Text + "'),lurl=('" + TextBoxlink.Text + "') where lsite=('" + TextBoxsite.Text + "')"
                    cmd2.ExecuteNonQuery()
                    MsgBox("Items saved successfully!", MsgBoxStyle.Information, "Saved!")
                    con.Close()

                    TextBoxuname.Clear()
                    TextBoxpass.Clear()
                    TextBoxlink.Clear()
                    TextBoxsite.Clear()
                    ComboBox1.Text = ""

                    ComboBox1.Items.Clear()
                    Try
                        con.Open()
                        Dim da As New SqlDataAdapter("select lsite from Main", con)
                        Dim ds As New DataSet
                        da.Fill(ds, "1")


                        For i As Integer = 0 To ds.Tables("1").Rows.Count - 1
                            Me.ComboBox1.Items.Add(ds.Tables("1").Rows(i)(0))
                        Next

                    Catch ex As Exception
                        MsgBox("Error : " + ex.Message)
                    Finally
                        con.Close()
                    End Try
                Else
                    MsgBox("Cannot overwrite the same details. Please change the values.", MsgBoxStyle.Information, "Change the details to overwrite")
                End If
                ComboBox1.Text = current
            End If
        End If
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        Dim a As String
        a = ComboBox1.Text
        Dim ans As Integer
        If TextBoxsite.Text = "" Then
            MsgBox("Select an password to be deleted.", MsgBoxStyle.Exclamation, "Invalid item")
        Else

            ans = MsgBox("Are you sure you want to Delete?", MsgBoxStyle.YesNo, "Delete the entry?")
            If ans = vbYes Then
                con.Open()
                Dim cmd3 As New SqlCommand
                cmd3.Connection = con
                cmd3.CommandText = "insert into Bin(rname,rsite,rpass,rurl) values('" + TextBoxuname.Text + "','" + TextBoxsite.Text + "','" + TextBoxpass.Text + "','" + TextBoxlink.Text + "')"
                cmd3.ExecuteNonQuery()
                con.Close()

                TextBoxuname.Clear()
                TextBoxpass.Clear()
                TextBoxlink.Clear()
                TextBoxsite.Clear()
                ComboBox1.Text = ""

                con.Open()
                Dim cmd4 As New SqlCommand
                cmd4.Connection = con
                cmd4.CommandText = "Delete from main where ('" + a + "')=lsite "
                cmd4.ExecuteNonQuery()
                con.Close()
                MsgBox("Items moved to bin successfully!", MsgBoxStyle.Information, "Deleted!")



            End If
            ComboBox1.Items.Clear()
            Try
                con.Open()
                Dim da As New SqlDataAdapter("select lsite from Main", con)
                Dim ds As New DataSet
                da.Fill(ds, "1")


                For i As Integer = 0 To ds.Tables("1").Rows.Count - 1
                    Me.ComboBox1.Items.Add(ds.Tables("1").Rows(i)(0))
                Next

            Catch ex As Exception
                MsgBox("Error : " + ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub cpyu_Click(sender As Object, e As EventArgs) Handles cpyu.Click
        If TextBoxuname.Text = "" Then
            MsgBox("Cannot copy blank field! Select an item to copy.", MsgBoxStyle.Information, "Blank field cannot be copied")
        Else
            My.Computer.Clipboard.SetText(TextBoxuname.Text)
        End If
    End Sub

    Private Sub cpypass_Click(sender As Object, e As EventArgs) Handles cpypass.Click
        If TextBoxpass.Text = "" Then
            MsgBox("Cannot copy blank field! Select an item to copy.", MsgBoxStyle.Information, "Blank field cannot be copied")
        Else
            My.Computer.Clipboard.SetText(TextBoxpass.Text)
        End If
    End Sub

    Private Sub TextBoxsite_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxsite.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
            TextBoxuname.Focus()
        End If
    End Sub

    Private Sub TextBoxsite_TextChanged(sender As Object, e As EventArgs) Handles TextBoxsite.TextChanged

    End Sub

    Private Sub TextBoxuname_TextChanged(sender As Object, e As EventArgs) Handles TextBoxuname.TextChanged

    End Sub

    Private Sub TextBoxuname_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxuname.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TextBoxpass_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxpass.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub
End Class