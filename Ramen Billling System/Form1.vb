Imports System.Data.SqlClient
Public Class Form1
    Dim con As New SqlConnection


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0
        Try
            con.ConnectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\SONUYADAV07\SOURCE\REPOS\HOSTEL\HOSTEL\APP_DATA\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"


            con.Open()
            Dim cmd As SqlCommand
            Dim da As SqlDataReader
            Dim Query As String
            If CheckBox1.Checked = False Then
                Query = "Select * from employee where username='" & TextBox1.Text & "'and  password='" & TextBox2.Text & "'"
                cmd = New SqlCommand(Query, con)



                da = cmd.ExecuteReader

                Dim count As Integer
                count = 0

                While da.Read
                    count = count + 1
                End While
                da.Close()
                If count = 1 Then
                    ProgressBar1.Value = 100
                    MessageBox.Show("Authorised access")
                    OrderPage.Show()
                    Me.Hide()
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    ProgressBar1.Value = 0
                Else

                    MessageBox.Show("Wrong Password or Username ,Try Agian")



                End If



            ElseIf CheckBox1.Checked = True Then
                Query = "select * from admin where username='" & TextBox1.Text & "'and password='" & TextBox2.Text & "'"
                cmd = New SqlCommand(Query, con)
                da = cmd.ExecuteReader
                Dim count As Integer
                count = 0
                While da.Read
                    count = count + 1

                End While
                da.Close()

                If count = 1 Then
                    dash.Show()
                    Me.Hide()



                Else
                    MessageBox.Show("Wrong Password or Username ,Try Agian")

                End If
            End If


        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
            con.Dispose()
        End Try

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim iexit As DialogResult
        iexit = MessageBox.Show("Confirm if you want to Exit", " Icharaku Ramen", MessageBoxButtons.YesNo)
        If iexit = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Visible = False
        RadioButton2.Visible = False
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        CheckBox1.Checked = False
        RadioButton1.Checked = False
        RadioButton2.Checked = False

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub
End Class
