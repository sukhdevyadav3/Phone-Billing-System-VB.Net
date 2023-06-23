Imports System.Data
Imports System.Data.SqlClient


Public Class CustomerDetials

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Sub Loadss(ByVal search As String)
        con = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\SONUYADAV07\SOURCE\REPOS\HOSTEL\HOSTEL\APP_DATA\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Dim query As String = "select * from customer"
        cmd = New SqlCommand(query, con)
        Dim da = New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        CustomerGridView1.DataSource = dt
    End Sub
    Private Sub CustomerDetials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadss("")
    End Sub



    Private Sub CustomerGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerGridView1.CellContentClick

    End Sub

    Private Sub CustomerGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles CustomerGridView1.MouseClick
        Dim i As Integer
        i = CustomerGridView1.CurrentRow.Index
        Me.mobno2.Text = CustomerGridView1.Item(0, i).Value
        Me.fname.Text = CustomerGridView1.Item(1, i).Value
        Me.lname.Text = CustomerGridView1.Item(2, i).Value
        Me.orderno.Text = CustomerGridView1.Item(3, i).Value
        Me.Date3.Value = CustomerGridView1.Item(4, i).Value


    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        con.ConnectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\SONUYADAV07\SOURCE\REPOS\HOSTEL\HOSTEL\APP_DATA\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        Try
            con.Open()
            Dim q As String
            q = "select * from customer where mobno='" + mobno2.Text + "'"
            cmd = New SqlCommand(q, con)
            Dim sqd As SqlDataReader
            sqd = cmd.ExecuteReader
            Dim c As Integer
            While sqd.Read
                c = c + 1
            End While
            sqd.Close()
            If c = 1 Then


                Dim query As String = "update customer set fname ='" & fname.Text & "',
              lname='" & lname.Text & "',date1='" & Date3.Value & "'
              where mobno= '" & mobno2.Text & "'"
                cmd = New SqlCommand(query, con)
                Dim d1 As SqlDataReader

                d1 = cmd.ExecuteReader

                MessageBox.Show("User Data Updated")
                d1.Close()

                Loadss("")
            Else
                MessageBox.Show("record doesn't exist")
            End If
        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
            con.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        con.ConnectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\SONUYADAV07\SOURCE\REPOS\HOSTEL\HOSTEL\APP_DATA\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

        Try
            If mobno2.Text = "" Then
                MessageBox.Show("Enter Mobile Number to find customer details")
            Else
                con.Open()


                Dim q1 As String

                q1 = "select mobno from customer where mobno='" & mobno2.Text & "'"
                Dim cmd As New SqlCommand(q1, con)

                Dim d1 As SqlDataReader

                d1 = cmd.ExecuteReader

                Dim count As Integer
                count = 0
                While d1.Read
                    count = count + 1
                End While
                d1.Close()
                If count = 1 Then

                    MessageBox.Show("Record exist")
                    q1 = "select fname,lname,orderno1,date1 from customer where mobno='" & mobno2.Text & "'"
                    cmd = New SqlCommand(q1, con)
                    d1 = cmd.ExecuteReader
                    While d1.Read
                        fname.Text = d1("fname")
                        lname.Text = d1("lname")
                        orderno.Text = d1("orderno1")
                        Date3.Text = d1("date1")
                    End While
                    d1.Close()
                ElseIf count = 0 Then

                    MessageBox.Show("Record doesn't exist")
                End If
            End If
        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
            con.Dispose()

        End Try

    End Sub

    Private Sub orderno_TextChanged(sender As Object, e As EventArgs)
        If Len(orderno.Text) > 0 Then
            orderno.ReadOnly = True
        End If

    End Sub

    Private Sub BillingSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BillingSystemToolStripMenuItem.Click
        dash.Show()
        Me.Close()

    End Sub

    Private Sub SaleToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Sale.Show()
        Me.Close()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        orderno.Text = ""
        mobno2.Text = ""
        fname.Text = ""
        lname.Text = ""
        Dim iexit As DialogResult
        iexit = MessageBox.Show("Confirm if you want to Exit", " Icharaku Ramen", MessageBoxButtons.YesNo)
        If iexit = DialogResult.Yes Then
            Application.Exit()
        End If


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim iexit As DialogResult
        iexit = MessageBox.Show("Confirm if you want to Exit", " Icharaku Ramen", MessageBoxButtons.YesNo)
        If iexit = DialogResult.Yes Then

            Application.Exit()
        End If
    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        Report.Show()
        Me.Hide()


    End Sub

    Private Sub mobno2_TextChanged(sender As Object, e As EventArgs) Handles mobno2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dash.Show()
        Me.Hide()
    End Sub
End Class