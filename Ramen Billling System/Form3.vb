Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Form3

    Dim con As New SqlConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Dim d1 As SqlDataReader

        Dim regex As Regex = New Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
            Dim isValid As Boolean = regex.IsMatch(username.Text.Trim)
        con.ConnectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\SONUYADAV07\SOURCE\REPOS\HOSTEL\HOSTEL\APP_DATA\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        con.Open()
        Try
            If fname.Text = "" Then
                MessageBox.Show("Enter First Name")


            ElseIf Not isValid Then
                MessageBox.Show("Invalid Email.")



            ElseIf lname.Text = "" Then

                MessageBox.Show("Enter Last Name")

            ElseIf password1.Text = "" Then

                MessageBox.Show("Enter Password")

            ElseIf confirmpassword.Text = "" Then
                MessageBox.Show("Enter Confirm Password")


            ElseIf password1.Text <> confirmpassword.Text Then
                MessageBox.Show("Confirm Password and Password Doesn't Match")


            ElseIf username.Text = "" Then
                MessageBox.Show(" Enter Username")

            Else




                Dim q1 As String

                q1 = "select username from employee where username='" & username.Text & "'"

                Dim cmd As New SqlCommand(q1, con)


                d1 = cmd.ExecuteReader

                Dim count As Integer
                count = 0
                While d1.Read
                    count = count + 1
                End While
                d1.Close()
                If count = 1 Then
                    MessageBox.Show("Username Exist, Try different Username")

                ElseIf count = 0 Then
                    q1 = "insert into employee (empid,fname,lname,username,password) values ('" & lblempid.Text & "','" & fname.Text & "','" & lname.Text & "','" & username.Text & "',
                     '" & password1.Text & "')"
                    cmd = New SqlCommand(q1, con)
                    d1 = cmd.ExecuteReader
                    d1.Close()

                    MessageBox.Show("Sucessfull, for Username '" & username.Text & "'")
                    lblempid.Text = ""
                    fname.Text = ""
                    lname.Text = ""
                    username.Text = ""
                    password1.Text = ""
                    confirmpassword.Text = ""
                    auto1()


                End If

            End If


        Finally
            con.Close()
            con.Dispose()
            auto1()


        End Try



    End Sub




    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles fname.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()


    End Sub

    Private Sub empid_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        auto1()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lblempid.Text = ""
        fname.Text = ""
        lname.Text = ""
        username.Text = ""
        password1.Text = ""
        confirmpassword.Text = ""
        auto1()
    End Sub

    Public Sub auto1()

        con.Close()
        con.ConnectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\SONUYADAV07\SOURCE\REPOS\HOSTEL\HOSTEL\APP_DATA\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        con.Open()
            Dim cmd As SqlCommand

            Dim Num As Integer
        Try
            cmd = New SqlCommand("select max(empid) from employee", con)
            cmd.ExecuteNonQuery()

            If IsDBNull(cmd.ExecuteScalar) Then
                Num = 1
                lblempid.Text = Num
            Else
                Num = cmd.ExecuteScalar + 1
                lblempid.Text = Num

            End If

        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
            con.Dispose()
        End Try
    End Sub

    Private Sub fname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fname.KeyPress
        Dim unacceptable As String = "0123456789+-/*.,';[]"

        If InStr(unacceptable, e.KeyChar) > 0 Then
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub lname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lname.KeyPress
        Dim unacceptable As String = "0123456789+-/*.,';[]"

        If InStr(unacceptable, e.KeyChar) > 0 Then
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub password1_TextChanged(sender As Object, e As EventArgs) Handles password1.TextChanged

    End Sub

    Private Sub lblempid_Click(sender As Object, e As EventArgs) Handles lblempid.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

        con.ConnectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        con.Open()
        Dim cmd As SqlCommand

        Dim Num As Integer

        cmd = New SqlCommand("select max(empid) from employee", con)
        cmd.ExecuteNonQuery()

        If IsDBNull(cmd.ExecuteScalar) Then
            Num = 1
            lblempid.Text = Num
        Else
            Num = cmd.ExecuteScalar + 1
            lblempid.Text = Num

        End If

        con.Close()
        con.Dispose()
    End Sub

    Private Sub username_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged

    End Sub
End Class