Imports System.Windows.Forms.LinkLabel
Imports System.Data
Imports System.Text
Imports System.Configuration
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class DisplayBin
    Dim ans As Integer
    Dim con As New Microsoft.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Save Flies VB\KeyCrypt\KeyCrypt\KeyCrypt\Database1.mdf;Integrated Security=True")




    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim st As String = ComboBox1.Text

        con.Open()
        Dim cmd4 As New SqlCommand
        cmd4.Connection = con
        cmd4.CommandText = "Select rsite,rurl,rpass,rname from Bin where ('" + st + "')=rsite"
        cmd4.CommandType = CommandType.Text
        Dim sdr As SqlDataReader = cmd4.ExecuteReader()
        sdr.Read()
        If st = sdr("rsite").ToString() Then
            tbname.Text = sdr("rname").ToString()
            tbpass.Text = sdr("rpass").ToString()
            tblink.Text = sdr("rurl").ToString()
            tbsite.Text = sdr("rsite").ToString()
        End If
        con.Close()
    End Sub

    Private Sub BtnRestore_Click(sender As Object, e As EventArgs) Handles BtnRestore.Click
        Dim a As String
        a = ComboBox1.Text
        Dim ans As Integer
        If ComboBox1.Text = "" Then
            MsgBox("Select an item to be Restored!", MsgBoxStyle.Critical, "Select an item")

        Else
            ans = MsgBox("Are you sure you want to Restore " + tbsite.Text + "?", MsgBoxStyle.YesNo, "Restore " + tbsite.Text + "?")
            If ans = vbYes Then
                con.Open()
                Dim cmd4 As New SqlCommand
                Dim cmd2 As New SqlCommand, cmd3 As New SqlCommand
                Dim n As Integer = -1



                cmd3.Connection = con
                cmd3.CommandText = "Select count ([lsite]) from [Main] where lsite like ('%" + tbsite.Text + "%')"
                n = Convert.ToInt32(cmd3.ExecuteScalar())
                con.Close()

                If n > 0 Then
                    n += 1
                    Dim x As String = tbsite.Text + " (" + n.ToString + ")"

                    con.Open()
                    cmd2.Connection = con
                    cmd2.CommandText = "insert into Main(lurl,lpass,lname,lsite) values('" + tblink.Text + "','" + tbpass.Text + "','" + tbname.Text + "','" + x + "' )"

                    cmd2.ExecuteNonQuery()
                    con.Close()
                Else
                    con.Open()
                    cmd4.Connection = con
                    cmd4.CommandText = "insert into Main(lurl,lpass,lname,lsite) values('" + tblink.Text + "','" + tbpass.Text + "','" + tbname.Text + "','" + tbsite.Text + "' )"
                    cmd4.ExecuteNonQuery()
                    con.Close()
                End If





                MsgBox("Restored Successfully!", MsgBoxStyle.Information, "Restore")
                tbname.Text = ""
                tbpass.Text = ""
                tblink.Text = ""
                tbsite.Text = ""
                ComboBox1.Items.Clear()
                con.Close()


                Dim cmd5 As New SqlCommand
                cmd5.Connection = con
                con.Open()
                cmd5.CommandText = "Delete from Bin where ('" + a + "')=rsite "
                cmd5.ExecuteNonQuery()
                con.Close()
                'Reloading the data from DB:
                ComboBox1.Items.Clear()
                Try
                    con.Open()
                    Dim da As New SqlDataAdapter("select rsite from bin", con)
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

        End If
    End Sub

    Private Sub deleet_Click(sender As Object, e As EventArgs) Handles deleet.Click
        Dim ans
        If ComboBox1.Text = "" Then
            MsgBox("Select an item to be Deleted!", MsgBoxStyle.Critical, "Select an item")
        Else
            ans = MsgBox("Are you sure you want to delete " + tbsite.Text + "?", MsgBoxStyle.YesNo, "Delete " + tbsite.Text + "?")
            If ans = vbYes Then
                Dim str As String = ComboBox1.Text
                con.Open()
                Dim cmd2 As New SqlCommand
                cmd2.Connection = con
                cmd2.CommandText = "Delete from bin where ('" + str + "')=rsite "

                cmd2.ExecuteNonQuery()

                MsgBox("Deleted Successfully", MsgBoxStyle.Information, "Notice")
                tbname.Text = ""
                tbpass.Text = ""
                tblink.Text = ""
                tbsite.Text = ""
                con.Close()
                'Reloading the data from DB:
                ComboBox1.Items.Clear()
                Try
                    con.Open()
                    Dim da As New SqlDataAdapter("select rsite from Bin", con)
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

        End If
    End Sub

    Private Sub BtnDelA_Click(sender As Object, e As EventArgs) Handles BtnDelA.Click
        Dim ans As Integer
        Dim cmd As New SqlCommand
        Dim count As Integer = -1
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "Select count(rsite) from bin"
        cmd.ExecuteNonQuery()
        count = Convert.ToInt32(cmd.ExecuteScalar)
        con.Close()

        If count < 1 Then
            MsgBox("Bin is already empty.", MsgBoxStyle.Information, "Bin is empty")
        Else
            ans = MsgBox("Are you sure you want to delete all passwords?", MsgBoxStyle.YesNo, "Delete all?")
            If ans = vbYes Then


                con.Open()
                Dim cmd2 As New SqlCommand
                cmd2.Connection = con
                cmd2.CommandText = "Delete from bin "

                cmd2.ExecuteNonQuery()

                MsgBox("Deleted Successfully!", MsgBoxStyle.Information, "Successfully Deleted!")
                con.Close()
                tbname.Text = ""
                tbpass.Text = ""
                tblink.Text = ""
                tbsite.Text = ""
                ComboBox1.Items.Clear()

                'Reloading the data from DB:
                ComboBox1.Items.Clear()
                ComboBox1.Text = ""
                Try
                    con.Open()
                    Dim da As New SqlDataAdapter("select rsite from bin", con)
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
        End If
    End Sub

    Private Sub DisplayBin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        Try
            con.Open()
            Dim da As New SqlDataAdapter("select rsite from bin", con)
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
    End Sub

    Private Sub tbsite_TextChanged(sender As Object, e As EventArgs) Handles tbsite.TextChanged

    End Sub

    Private Sub tbsite_KeyDown(sender As Object, e As KeyEventArgs) Handles tbsite.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
            tbname.Focus()

        End If
    End Sub

    Private Sub tbname_KeyDown(sender As Object, e As KeyEventArgs) Handles tbname.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub tbpass_KeyDown(sender As Object, e As KeyEventArgs) Handles tbpass.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub cpypass_Click(sender As Object, e As EventArgs) Handles cpypass.Click

    End Sub
End Class