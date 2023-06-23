Public Class dash


    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        CustomerDetials.Show()
        Me.Hide()

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        CustomerDetials.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        CustomerDetials.Show()
        Me.Hide()
    End Sub



    Private Sub Panel6_Click(sender As Object, e As EventArgs) Handles Panel6.Click
        Report.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Report.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Report.Show()
        Me.Hide()
    End Sub






    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        AddItem.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        AddItem.Show()
        Me.Hide()
    End Sub

    Private Sub Panel10_Paint(sender As Object, e As PaintEventArgs)
        AddItem.Show()
        Me.Hide()
    End Sub



    Private Sub dash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class