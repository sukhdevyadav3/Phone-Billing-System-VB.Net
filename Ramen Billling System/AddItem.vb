Imports System.Data.SqlClient
Imports System.IO


Public Class AddItem
    Dim con As New SqlConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.PNG;*GIF;*.JPG)|*.png;*.gif;*.jpg"
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            con = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\SONUYADAV07\SOURCE\REPOS\HOSTEL\HOSTEL\APP_DATA\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

            Dim cmd As New SqlCommand

            Dim ms As New MemoryStream


            If PictureBox1.Image Is Nothing Then
                    MessageBox.Show("Insert Image")

                Else
                cmd = New SqlCommand("insert into items (itemid,itemname,price,discription,image,total_stock) values(@itemid,@name,@price,@discription,@image,@total_stock)", con)

                Dim id As Integer
                id = lblid.Text
                Dim ts As Integer
                ts = total_stock.Text
                con.Open()
                PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = itemname.Text
                cmd.Parameters.Add("@itemid", SqlDbType.Int).Value = id
                cmd.Parameters.Add("@discription", SqlDbType.VarChar).Value = discription.Text.Trim
                cmd.Parameters.Add("@price", SqlDbType.Int).Value = price.Text.Trim
                cmd.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray()
                cmd.Parameters.Add("@total_stock", SqlDbType.Int).Value = ts

                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                If cmd.ExecuteNonQuery() = 1 Then

                    MessageBox.Show("Inserted")
                    auto1()
                    itemname.Text = ""
                    discription.Text = ""
                    total_stock.Text = ""
                    price.Text = ""
                    PictureBox1.Image.Dispose()

                Else
                    MessageBox.Show("Unsuccessful")
                End If
            End If
        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        Finally
            con.Close()
            con.Dispose()
        End Try
    End Sub

    Private Sub AddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        auto1()


    End Sub
    Public Sub auto1()


        con = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\SONUYADAV07\SOURCE\REPOS\HOSTEL\HOSTEL\APP_DATA\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

        con.Open()
        Dim cmd As SqlCommand

        Dim Num As Integer

        cmd = New SqlCommand("select max(itemid) from items", con)

        cmd.ExecuteNonQuery()

        If IsDBNull(cmd.ExecuteScalar) Then
            Num = 1
            lblid.Text = Num
        Else
            Num = cmd.ExecuteScalar + 1
            lblid.Text = Num

        End If

        con.Close()
        con.Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        dash.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try

            Dim sqd As SqlDataReader

            con = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\SONUYADAV07\SOURCE\REPOS\HOSTEL\HOSTEL\APP_DATA\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
            con.Open()




            Dim cmd As New SqlCommand




            If PictureBox1.Image Is Nothing Then
                MessageBox.Show("Insert Image")
            ElseIf lblid.Text = "" Then
                MessageBox.Show("Enter Product ID")
            ElseIf total_stock.Text = "" Then
                MessageBox.Show("Enter a number in the Stock TextBox")

            Else
                Dim q As String
                q = "update items set total_stock='" & total_stock.Text & "',itemname='" & itemname.Text & "',price='" & price.Text & "',discription='" & discription.Text & "' where itemid ='" & lblid.Text & "' "
                cmd = New SqlCommand(q, con)

                sqd = cmd.ExecuteReader
                sqd.Close()

                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                If cmd.ExecuteNonQuery() = 1 Then

                    MessageBox.Show("Stock Updated Successfully")
                    auto1()
                    itemname.Text = ""
                    discription.Text = ""
                    total_stock.Text = ""
                    price.Text = ""
                    PictureBox1.Image.Dispose()
                    Button4.Visible = False

                Else
                    MessageBox.Show("Unsuccessful")
                End If
            End If
        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        Finally
            con.Close()
            con.Dispose()
        End Try
    End Sub

    Private Sub lblid_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        con = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\SONUYADAV07\SOURCE\REPOS\HOSTEL\HOSTEL\APP_DATA\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        con.Open()


        Dim cmd As SqlCommand
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
        If count = 1 Then
            MessageBox.Show("Record exist")
            Button4.Visible = True
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



        ElseIf count = 0 Then

            MessageBox.Show("Record doesn't exist")

        End If
    End Sub
End Class