Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class OrderPage
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Sub Loadss(ByVal search As String)
        con = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\SONUYADAV07\SOURCE\REPOS\HOSTEL\HOSTEL\APP_DATA\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Dim query As String = "select itemid,itemname,price,discription,total_stock from items"
        cmd = New SqlCommand(query, con)
        Dim da = New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Private Sub OrderPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadss("")

    End Sub


    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        Me.lblid.Text = DataGridView1.Item(0, i).Value
        Me.itemname.Text = DataGridView1.Item(1, i).Value
        Me.price.Text = DataGridView1.Item(2, i).Value
        Me.discription.Text = DataGridView1.Item(3, i).Value
        Me.total_stock.Text = DataGridView1.Item(4, i).Value
        con = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\SONUYADAV07\SOURCE\REPOS\HOSTEL\HOSTEL\APP_DATA\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        con.Open()

        Dim q As String
        Dim da As SqlDataAdapter
        Dim data As New DataTable
        da = New SqlDataAdapter("select image from items where itemid='" + lblid.Text + "'", con)
        Dim comdbuild As New SqlCommandBuilder
        da.Fill(data)
        Dim picbyte() As Byte = data.Rows(0).Item("image")
        Dim pic As New System.IO.MemoryStream(picbyte)
        PictureBox1.Image = Image.FromStream(pic)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        pic.Close()
        con.Close()
        con.Dispose()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Search.Click
        con = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\SONUYADAV07\SOURCE\REPOS\HOSTEL\HOSTEL\APP_DATA\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        con.Open()



        Dim q As String = "select itemid,itemname,discription,price,total_stock from items where itemid='" + lblid.Text + "' "
        Dim da As SqlDataReader
        cmd = New SqlCommand(q, con)
        da = cmd.ExecuteReader
        Dim count As Integer
        count = 0
        Dim available As Integer
        While da.Read
            count = count + 1
            available = da("total_stock")
        End While
        da.Close()
        If count = 1 And available >= 1 Then
            MessageBox.Show("Record exist")
            q = "select itemid,itemname,discription,price,total_stock from items where itemid='" + lblid.Text + "' "
            cmd = New SqlCommand(q, con)
            da = cmd.ExecuteReader
            While da.Read
                lblid.Text = da("itemid")
                itemname.Text = da("itemname")
                discription.Text = da("discription")
                price.Text = da("price")
                total_stock.Text = da("total_stock")
            End While
            da.Close()
            Dim sda As SqlDataAdapter
            Dim data As New DataTable
            sda = New SqlDataAdapter("select image from items where itemid='" + lblid.Text + "'", con)
            Dim comdbuild As New SqlCommandBuilder
            sda.Fill(data)
            Dim picbyte() As Byte = data.Rows(0).Item("image")
            Dim pic As New System.IO.MemoryStream(picbyte)
            PictureBox1.Image = Image.FromStream(pic)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            pic.Close()
            con.Close()
            con.Dispose()
        ElseIf count = 1 And available >= 0 Then

            MessageBox.Show("Out of Stock")


        ElseIf count = 0 Then

            MessageBox.Show("Record doesn't exist")

        End If
    End Sub

    Private Sub Payment_Click(sender As Object, e As EventArgs) Handles Payment.Click
        If lblid.Text = "" Then
            MessageBox.Show("Select or Search a Phone")
        ElseIf itemname.Text = "" Then
            MessageBox.Show("Select a Phone")
        ElseIf Convert.ToInt32(total_stock.Text) = 0 Then
            MessageBox.Show("Out of Stock")
        Else


            Payment1.Show()

            Me.Hide()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class