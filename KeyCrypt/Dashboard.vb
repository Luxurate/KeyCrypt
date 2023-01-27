Public Class Dashboard

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)



    End Sub

    Private Sub Guna2ControlBox3_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox3.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Panel1.Controls.Clear()
        AddRecord.TopLevel = False
        Panel1.Controls.Add(AddRecord)
        AddRecord.Show()
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Panel1.Controls.Clear()
        UpdateForm.TopLevel = False
        Panel1.Controls.Add(UpdateForm)
        UpdateForm.Show()

    End Sub



    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Panel1.Controls.Clear()
        DisplayBin.TopLevel = False
        Panel1.Controls.Add(DisplayBin)
        DisplayBin.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Panel1.Controls.Clear()
        RecoveryKey.TopLevel = False
        Panel1.Controls.Add(RecoveryKey)
        RecoveryKey.Show()
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click

    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        frmMain.Show()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Panel1.Controls.Clear()
        CreditCard.TopLevel = False
        Panel1.Controls.Add(CreditCard)
        CreditCard.Show()

    End Sub
End Class