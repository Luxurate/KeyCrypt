Imports Microsoft.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.SqlClient
Imports System.Text


Public Class CardDisplay
    Dim con As New Microsoft.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Save Flies VB\KeyCrypt\KeyCrypt\KeyCrypt\Database1.mdf;Integrated Security=True")
    Dim cmd As New SqlCommand
    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim ct As String = ComboBox2.Text

        con.Open()
        Dim cmd4 As New SqlCommand
        cmd4.Connection = con
        cmd4.CommandText = "Select credit1,credit2,credit3,credit4,creditname,creditmonth,credityear from CREDIT where ('" + ct + "')=credit4"
        cmd4.CommandType = CommandType.Text
        Dim sdr As SqlDataReader = cmd4.ExecuteReader()
        sdr.Read()
        If ct = sdr("credit4").ToString() Then
            creditd1.Text = sdr("credit1").ToString()
            creditd2.Text = sdr("credit2").ToString()
            creditd3.Text = sdr("credit3").ToString()
            creditd4.Text = sdr("credit4").ToString()
            creditdname.Text = sdr("creditname").ToString()
            creditdmonth.Text = sdr("creditmonth").ToString()
            creditdyear.Text = sdr("credityear").ToString()

        End If
        con.Close()
    End Sub

    Private Sub CardDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox2.Items.Clear()
        Try
            con.Open()
            Dim da As New SqlDataAdapter("select credit4 from CREDIT", con)
            Dim ds As New DataSet
            da.Fill(ds, "1")


            For i As Integer = 0 To ds.Tables("1").Rows.Count - 1
                Me.ComboBox2.Items.Add(ds.Tables("1").Rows(i)(0))
            Next

        Catch ex As Exception
            MsgBox("Error : " + ex.Message)
        Finally
            con.Close()
        End Try

        creditd1.Text = ""
        creditd2.Text = ""
        creditd3.Text = ""
        creditd4.Text = ""
        creditdname.Text = ""
        creditdmonth.Text = ""
        creditdyear.Text = ""

        ComboBox2.Text = "Select an Item"
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim a As String
        a = ComboBox2.Text
        Dim ans As Integer
        If creditd4.Text = "" Then
            MsgBox("Select a card to be deleted.", MsgBoxStyle.Exclamation, "Invalid item")
        Else

            ans = MsgBox("Are you sure you want to Delete?", MsgBoxStyle.YesNo, "Delete the entry?")
            If ans = vbYes Then
                con.Open()
                Dim cmd3 As New SqlCommand
                cmd3.Connection = con
                cmd3.CommandText = "insert into BINCR(credit11,credit22,credit33,credit44,creditnamee,creditmonthh,credityearr) values('" + creditd1.Text + "','" + creditd2.Text + "','" + creditd3.Text + "','" + creditd4.Text + "','" + creditdname.Text + "','" + creditdmonth.Text + "','" + creditdyear.Text + "')"
                cmd3.ExecuteNonQuery()
                con.Close()

                creditd1.Clear()
                creditd2.Clear()
                creditd3.Clear()
                creditd4.Clear()
                creditdname.Clear()
                creditdmonth.Clear()
                creditdyear.Clear()
                ComboBox2.Text = ""

                con.Open()
                Dim cmd4 As New SqlCommand
                cmd4.Connection = con
                cmd4.CommandText = "Delete from CREDIT where ('" + a + "')=credit4 "
                cmd4.ExecuteNonQuery()
                con.Close()
                MsgBox("Items moved to bin successfully!", MsgBoxStyle.Information, "Deleted!")



            End If
            ComboBox2.Items.Clear()
            Try
                con.Open()
                Dim da As New SqlDataAdapter("select credit4 from CREDIT", con)
                Dim ds As New DataSet
                da.Fill(ds, "1")


                For i As Integer = 0 To ds.Tables("1").Rows.Count - 1
                    Me.ComboBox2.Items.Add(ds.Tables("1").Rows(i)(0))
                Next

            Catch ex As Exception
                MsgBox("Error : " + ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub
End Class