Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Data.SqlClient


Public Class Form1

    Dim con As New Microsoft.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Save Flies VB\KeyCrypt\KeyCrypt\KeyCrypt\Database1.mdf;Integrated Security=True")
    Dim cmd As New Microsoft.Data.SqlClient.SqlCommand
    Dim cmd1 As New Microsoft.Data.SqlClient.SqlCommand
    Dim a As String, b As String
    Dim count As Integer = -1
    Private Sub Loginpassword_TextChanged(sender As Object, e As EventArgs) Handles LoginPassword.TextChanged

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Timer1.Start()
    End Sub

    Private Sub checker_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassword.CheckedChanged
        If ShowPassword.Checked Then
            LoginPassword.PasswordChar = ""
        Else
            LoginPassword.PasswordChar = "●"
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        CreatePassword.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2ShadowPanel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2ShadowPanel2.Paint

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginPassword.Focus()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        prgbar.Increment(10)
        If prgbar.Value = 100 Then
            Timer1.Stop()


            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Select unameAS,upassAS from login"
            cmd.CommandType = CommandType.Text
            Dim sdr As Microsoft.Data.SqlClient.SqlDataReader = cmd.ExecuteReader()
            sdr.Read()
            a = sdr("unameAS").ToString()
            b = sdr("upassAS").ToString()
            If LoginUsername.Text = "" And LoginPassword.Text = "" Then

                checker.Text = "Please Fill the Fields!!"
                prgbar.Value = 0
            ElseIf LoginPassword.Text = "" Then
                checker.Text = "Please Fill the Password!!"
                prgbar.Value = 0
            ElseIf LoginUsername.Text = "" Then
                checker.Text = "Please Fill the Username!!"
                prgbar.Value = 0
            ElseIf a = LoginUsername.Text And b <> LoginPassword.Text Then

                checker.Text = "Please Check the Password!!"
                prgbar.Value = 0
            ElseIf a = LoginUsername.Text And b = LoginPassword.Text Then

                LoginPassword.Text = ""
                LoginUsername.Text = ""
                checker.Text = ""
                Dashboard.Show()
                Me.Hide()


            End If
            con.Close()
        End If
    End Sub
End Class