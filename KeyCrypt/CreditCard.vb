Imports System.Data.SqlClient
Imports System.Text
Imports Microsoft.Data.SqlClient



Public Class CreditCard
    Dim ans As Integer
    Dim con As New Microsoft.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Save Flies VB\KeyCrypt\KeyCrypt\KeyCrypt\Database1.mdf;Integrated Security=True")
    Dim cmd As New SqlCommand
    Private Sub credit1_TextChanged(sender As Object, e As EventArgs) Handles credit1.TextChanged
        credit1.MaxLength = 4

        If credit1.TextLength = 4 Then
            credit2.Focus()
        End If



    End Sub

    Private Sub credit2_TextChanged(sender As Object, e As EventArgs) Handles credit2.TextChanged
        credit2.MaxLength = 4

        If credit2.TextLength = 4 Then
            credit3.Focus()
        End If
    End Sub

    Private Sub credit3_TextChanged(sender As Object, e As EventArgs) Handles credit4.TextChanged
        credit4.MaxLength = 4

        If credit4.TextLength = 4 Then
            creditname.Focus()
        End If
    End Sub

    Private Sub credit4_TextChanged(sender As Object, e As EventArgs) Handles creditname.TextChanged

    End Sub

    Private Sub credit3_TextChanged_1(sender As Object, e As EventArgs) Handles credit3.TextChanged
        credit3.MaxLength = 4

        If credit3.TextLength = 4 Then
            credit4.Focus()
        End If
    End Sub

    Private Sub creditadd_Click(sender As Object, e As EventArgs) Handles creditadd.Click

        If credit1.Text = "" Or credit2.Text = "" Or credit3.Text = "" Or credit4.Text = "" Or creditname.Text = "" Or creditmonth.Text = "" Or credityear.Text = "" Then
            MsgBox("Fill in all the fields to proceed.", MsgBoxStyle.Information, "Enter Details!")
        ElseIf credit1.Text.Trim = "" Then
            MsgBox("Please Enter the First Box, Four Digits!", MsgBoxStyle.Critical, "Check the Fields")
        ElseIf credit2.Text.Trim = "" Then
            MsgBox("Please Enter the Second Box, Four Digits!", MsgBoxStyle.Critical, "Check the Fields")
        ElseIf credit3.Text.Contains(" ") Then
            MsgBox("Please Enter the Third Box, Four Digits!", MsgBoxStyle.Information, "Check site name")
        ElseIf credit4.Text.Contains(" ") Then
            MsgBox("Please Enter the Fourth Box, Four Digits!", MsgBoxStyle.Information, "Check Website link")
        ElseIf creditname.Text.Trim = "" Then
            MsgBox("Card Name cannot have just spaces. Please re-insert the Name!", MsgBoxStyle.Critical, "Check the Fields")
        ElseIf creditmonth.Text.Trim = "" Or credityear.Text.Trim = "" Then
            MsgBox("Expiration cannot have just spaces. Please re-insert the Expiration Details!", MsgBoxStyle.Critical, "Check the Fields")

        Else

            con.Open()
            Dim cmd4 As New SqlCommand
            Dim cmd2 As New SqlCommand, cmd3 As New SqlCommand

            cmd4.Connection = con
                cmd4.CommandText = "insert into CREDIT(credit1,credit2,credit3,credit4,creditname,creditmonth,credityear) values('" + credit1.Text + "','" + credit2.Text + "','" + credit3.Text + "','" + credit4.Text + "','" + creditname.Text + "','" + creditmonth.Text + "','" + credityear.Text + "' )"
                cmd4.ExecuteNonQuery()
                con.Close()
                MsgBox("Card successfully created", MsgBoxStyle.Information, "Success!")
                credit1.Text = ""
                credit2.Text = ""
                credit3.Text = ""
                credit4.Text = ""
                creditname.Text = ""
                creditmonth.Text = ""
                credityear.Text = ""
                Me.Refresh()
                Me.ResetText()
                Me.Show()




            End If






    End Sub

    Private Sub credit1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles credit1.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter Numbers!!", MsgBoxStyle.Critical, "Please Check!")
            e.Handled = True
        End If
    End Sub

    Private Sub credit2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles credit2.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter Numbers!!", MsgBoxStyle.Critical, "Please Check!")
            e.Handled = True
        End If
    End Sub

    Private Sub credit3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles credit3.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter Numbers!!", MsgBoxStyle.Critical, "Please Check!")
            e.Handled = True
        End If
    End Sub

    Private Sub credit4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles credit4.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter Numbers!!", MsgBoxStyle.Critical, "Please Check!")
            e.Handled = True
        End If
    End Sub

    Private Sub creditmonth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles creditmonth.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter Numbers!!", MsgBoxStyle.Critical, "Please Check!")
            e.Handled = True
        End If
    End Sub

    Private Sub credityear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles credityear.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter Numbers!!", MsgBoxStyle.Critical, "Please Check!")
            e.Handled = True
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        CardDisplay.Show()

    End Sub
End Class