
Imports System.Data
Imports System.Data.SqlClient

Public Class Sale

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter

    Sub Loadss(ByVal seach As String)
        con = New SqlConnection("Data Source=(localdb) \ MSSQLLocalDB;Initial Catalog=C:\USERS\SONUYADAV07\SOURCE\REPOS\HOSTEL\HOSTEL\APP_DATA\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Dim query As String = "select * from sales"
        cmd = New SqlCommand(query, con)
        da = New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        SaleGridView1.DataSource = dt
    End Sub




    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadss("")
    End Sub

    Private Sub SaleGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SaleGridView1.CellContentClick



    End Sub

    Private Sub SaleGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles SaleGridView1.MouseClick

        Dim i As Integer
        i = SaleGridView1.CurrentRow.Index
        Me.itemid.Text = SaleGridView1.Item(0, i).Value
        Me.ordero.Text = SaleGridView1.Item(1, i).Value
        Me.itemname.Text = SaleGridView1.Item(2, i).Value
        Me.Date2.Value = SaleGridView1.Item(3, i).Value
        Me.total_amount.Text = SaleGridView1.Item(4, i).Value
        Me.qty.Text = SaleGridView1.Item(5, i).Value




    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Insert_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        con.ConnectionString = "Data Source=(localdb) \ MSSQLLocalDB;Initial Catalog=C:\USERS\SONUYADAV07\SOURCE\REPOS\HOSTEL\HOSTEL\APP_DATA\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

        Try
            If ordero.Text = "" Then
                MessageBox.Show("Enter Order No. to find Order No. details")
            Else
                con.Open()


                Dim q1 As String

                q1 = "select orderno from sales where orderno='" & ordero.Text & "'"
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
                    q1 = "select orderno,NoofItems,TotalCostofItem,shio,miso,shoyu,tonkostsu,date,mobno1 from sales where orderno='" & ordero.Text & "'"
                    cmd = New SqlCommand(q1, con)
                    d1 = cmd.ExecuteReader
                    While d1.Read
                        itemid.Text = d1("itemid")
                        ordero.Text = d1("orderno")
                        qty.Text = d1("qty")
                        total_amount.Text = d1("price")
                        itemname.Text = d1("itemname")
                        Date2.Text = d1("date")

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








    Private Sub CustomerDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerDetailsToolStripMenuItem.Click

        CustomerDetials.Show()
        Me.Close()
    End Sub

    Private Sub BillingSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BillingSystemToolStripMenuItem.Click


        Form2.Show()
        Me.Close()

    End Sub

    Private Sub SignOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignOutToolStripMenuItem.Click


        Form1.Show()
        Me.Close()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        Dim iexit As DialogResult

        iexit = MessageBox.Show("Confirm if you want to Exit", " Icharaku Ramen", MessageBoxButtons.YesNo)
        If iexit = DialogResult.Yes Then

            Application.Exit()
        End If

    End Sub

End Class