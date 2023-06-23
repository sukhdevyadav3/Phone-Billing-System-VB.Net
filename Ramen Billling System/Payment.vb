Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class Payment1
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim exist As Integer = 0
    Dim total, ts, ta As Integer


    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblid.Text = OrderPage.lblid.Text
        Me.itemname.Text = OrderPage.itemname.Text
        Me.totalamount.Text = OrderPage.price.Text
        Me.total_stock.Text = OrderPage.total_stock.Text
        Int32.TryParse(totalamount.Text, total)
        ts = OrderPage.total_stock.Text
        ta = OrderPage.price.Text
        NumericUpDown1.Maximum = ts
        NumericUpDown1.Minimum = 1

        Date1.Value = DateTime.Now.Date

        Panel6.Visible = False
        auto()
        name1.Visible = False
        cvv.Visible = False
        cardNo.Visible = False
        lblcardbo.Visible = False
        lblcvv.Visible = False
        lblname1.Visible = False
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        OrderPage.Show()
        Me.Close()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            If mobno.Text = "" Then
                MessageBox.Show("Enter Mobile Number ")
            Else
                con = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\SONUYADAV07\SOURCE\REPOS\HOSTEL\HOSTEL\APP_DATA\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
                con.Open()
                Dim q1 As String = "select * from customer where mobno='" + mobno.Text + "'"
                cmd = New SqlCommand(q1, con)
                Dim d1 As SqlDataReader
                d1 = cmd.ExecuteReader
                Dim c As Integer
                c = 0
                While d1.Read
                    c = c + 1
                End While
                d1.Close()
                If c = 0 Then
                    MessageBox.Show("New Customer")
                Paymentbtn.Visible = True
                Panel6.Visible = True
                exist = 0
            Else
                MessageBox.Show("Customer Exist")
                exist = 1
                Dim total As Integer
                Paymentbtn.Visible = True
                    q1 = "select * from customer where mobno='" + mobno.Text + "'"
                    cmd = New SqlCommand(q1, con)
                    d1 = cmd.ExecuteReader
                    While d1.Read
                        fname.Text = d1("fname")
                    lname.Text = d1("lname")
                    total = totalamount.Text.Trim()
                    Dim discount As Integer
                    discount = total * 15 / 100
                    total = total - discount
                    totalamount.Text = total
                    lblcongo.Visible = True
                    lbldiscount.Text = discount
                    lbldiscount.Visible = True
                    Panel6.Visible = True
                End While

            End If
            End If

        End Sub

    Private Sub lblid_TextChanged(sender As Object, e As EventArgs) Handles lblid.TextChanged
        OrderPage.lblid.Text = Me.lblid.Text
    End Sub
    Public Sub auto()
        con = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\SONUYADAV07\SOURCE\REPOS\HOSTEL\HOSTEL\APP_DATA\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        con.Open()
        Dim cmd As SqlCommand

        Dim Num As Integer

        cmd = New SqlCommand("select max(orderno1) from customer", con)
        cmd.ExecuteNonQuery()

        If IsDBNull(cmd.ExecuteScalar) Then
            Num = 1
            orderno.Text = Num
        Else
            Num = cmd.ExecuteScalar + 1
            orderno.Text = Num

        End If
        con.Dispose()
        con.Close()
    End Sub


    Private Sub Paymentbtn_Click(sender As Object, e As EventArgs) Handles Paymentbtn.Click
        Try
            con = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\SONUYADAV07\SOURCE\REPOS\HOSTEL\HOSTEL\APP_DATA\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
            con.Open()
            Dim sqd As SqlDataReader
            If mobno.Text = "" Then
                MessageBox.Show("Enter Mobile No.")

            ElseIf fname.Text = "" Then
                MessageBox.Show("Enter Customer Details properly")

            ElseIf lname.Text = "" Then
                MessageBox.Show("Enter  Customer Details properly")
            ElseIf lblid.Text = "" Then
                MessageBox.Show("Enter  Customer Details properly")

            ElseIf RadioButton1.Checked = False And RadioButton2.Checked = False Then
                MessageBox.Show("Select Payment Method")




            ElseIf RadioButton1.Checked = True Then
                Dim ts As Integer = 0
                Dim ns As Integer = 0
                Dim total_stock1 As String = ""

                Dim cmd As SqlCommand
                Dim q As String
                q = "select * from sales where orderno='" + orderno.Text + "'"
                cmd = New SqlCommand(q, con)
                sqd = cmd.ExecuteReader
                Dim c As Integer


                While sqd.Read
                    c = c + 1
                End While
                If c = 1 Then
                    MessageBox.Show("Change orderno")
                Else
                    If exist = 0 Then


                        q = "insert into customer (orderno1,fname,lname,mobno,date1) values ('" & orderno.Text & "','" & fname.Text & "','" & lname.Text & "','" & mobno.Text & "','" & Date1.Value & "')"
                        cmd = New SqlCommand(q, con)
                        sqd.Close()
                        sqd = cmd.ExecuteReader
                        sqd.Close()
                        q = "select * from items where itemid='" + lblid.Text + "'"
                        cmd = New SqlCommand(q, con)
                        sqd = cmd.ExecuteReader
                        While sqd.Read

                            ts = sqd("total_stock")


                        End While
                        sqd.Close()

                        ts = ts - NumericUpDown1.Value
                        total_stock.Text = ts
                        q = "update items set total_stock='" & total_stock.Text & "' where itemid ='" & lblid.Text & "' "
                        cmd = New SqlCommand(q, con)
                        sqd = cmd.ExecuteReader
                        sqd.Close()
                        q = "insert into sales (orderno,itemid,itemname,price,date,qty) values ('" & orderno.Text & "','" & lblid.Text & "','" & itemname.Text & "','" & totalamount.Text & "','" & Date1.Value & "','" & NumericUpDown1.Value & "')"
                        cmd = New SqlCommand(q, con)
                        sqd = cmd.ExecuteReader
                        sqd.Close()
                        MessageBox.Show("Payment Successful")
                        clear()
                    ElseIf exist = 1 Then
                        q = "update customer set orderno1='" & orderno.Text & "' where mobno ='" & mobno.Text & "' "
                        cmd = New SqlCommand(q, con)
                        sqd.Close()
                        sqd = cmd.ExecuteReader
                        sqd.Close()


                        q = "select * from items where itemid='" + lblid.Text + "'"
                        cmd = New SqlCommand(q, con)
                        sqd = cmd.ExecuteReader
                        While sqd.Read

                            ts = sqd("total_stock")


                        End While
                        sqd.Close()

                        ts = ts - NumericUpDown1.Value
                        total_stock.Text = ts
                        q = "update items set total_stock='" & total_stock.Text & "' where itemid ='" & lblid.Text & "' "
                        cmd = New SqlCommand(q, con)
                        sqd = cmd.ExecuteReader
                        sqd.Close()

                        q = "insert into sales (orderno,itemid,itemname,price,date,qty) values ('" & orderno.Text & "','" & lblid.Text & "','" & itemname.Text & "','" & totalamount.Text & "','" & Date1.Value & "','" & NumericUpDown1.Value & "')"
                        cmd = New SqlCommand(q, con)
                        sqd = cmd.ExecuteReader
                        sqd.Close()
                        MessageBox.Show("Payment Successful")

                        clear()




                    End If

                End If
            ElseIf RadioButton2.Checked = True Then
                If name1.Text = "" Then
                    MessageBox.Show("Enter name card deatils properly")
                ElseIf cardNo.Text = "" Then
                    MessageBox.Show("Enter card no. deatils properly")
                ElseIf cvv.Text = "" Then
                    MessageBox.Show("Enter cvv no. deatils properly")
                ElseIf cvv.Text.Length > 16 Then
                    MessageBox.Show("Card Numbershould be of 16 digits")

                ElseIf cvv.Text.Length <> 3 Then
                    MessageBox.Show("CVV Number cannot be more than 3 digits")
                Else
                    Dim ts As Integer = 0
                Dim ns As Integer = 0
                Dim total_stock1 As String = ""

                Dim cmd As SqlCommand
                Dim q As String
                q = "select * from sales where orderno='" + orderno.Text + "'"
                cmd = New SqlCommand(q, con)
                sqd = cmd.ExecuteReader
                Dim c As Integer


                While sqd.Read
                    c = c + 1
                End While
                If c = 1 Then
                    MessageBox.Show("Change orderno")
                Else
                        If exist = 0 Then


                            q = "insert into customer (orderno1,fname,lname,mobno,date1) values ('" & orderno.Text & "','" & fname.Text & "','" & lname.Text & "','" & mobno.Text & "','" & Date1.Value & "')"
                            cmd = New SqlCommand(q, con)
                            sqd.Close()
                            sqd = cmd.ExecuteReader
                            sqd.Close()
                            q = "select * from items where itemid='" + lblid.Text + "'"
                            cmd = New SqlCommand(q, con)
                            sqd = cmd.ExecuteReader
                            While sqd.Read

                                ts = sqd("total_stock")


                            End While
                            sqd.Close()

                            ts = ts - NumericUpDown1.Value
                            total_stock.Text = ts
                            q = "update items set total_stock='" & total_stock.Text & "' where itemid ='" & lblid.Text & "' "
                            cmd = New SqlCommand(q, con)
                            sqd = cmd.ExecuteReader
                            sqd.Close()
                            q = "insert into sales (orderno,itemid,itemname,price,date,qty) values ('" & orderno.Text & "','" & lblid.Text & "','" & itemname.Text & "','" & totalamount.Text & "','" & Date1.Value & "','" & NumericUpDown1.Value & "')"
                            cmd = New SqlCommand(q, con)
                            sqd = cmd.ExecuteReader
                            sqd.Close()
                            MessageBox.Show("Payment Successful")
                            clear()
                        ElseIf exist = 1 Then
                            q = "update customer set orderno1='" & orderno.Text & "' where mobno ='" & mobno.Text & "' "
                            cmd = New SqlCommand(q, con)
                            sqd.Close()
                            sqd = cmd.ExecuteReader
                            sqd.Close()


                            q = "select * from items where itemid='" + lblid.Text + "'"
                            cmd = New SqlCommand(q, con)
                            sqd = cmd.ExecuteReader
                            While sqd.Read

                                ts = sqd("total_stock")


                            End While
                            sqd.Close()

                            ts = ts - NumericUpDown1.Value
                            total_stock.Text = ts
                            q = "update items set total_stock='" & total_stock.Text & "' where itemid ='" & lblid.Text & "' "
                            cmd = New SqlCommand(q, con)
                            sqd = cmd.ExecuteReader
                            sqd.Close()

                            q = "insert into sales (orderno,itemid,itemname,price,date,qty) values ('" & orderno.Text & "','" & lblid.Text & "','" & itemname.Text & "','" & totalamount.Text & "','" & Date1.Value & "','" & NumericUpDown1.Value & "')"
                            cmd = New SqlCommand(q, con)
                            sqd = cmd.ExecuteReader
                            sqd.Close()
                            MessageBox.Show("Payment Successful")

                            clear()



                        End If
                    End If

                End If
            End If

        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        Finally
            con.Close()
            con.Dispose()
        End Try




    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = False Then
            name1.Visible = False
            cvv.Visible = False
            cardNo.Visible = False
            lblcardbo.Visible = False
            lblcvv.Visible = False
            lblname1.Visible = False
        ElseIf RadioButton2.Checked = True Then
            name1.Visible = True
            cvv.Visible = True
            cardNo.Visible = True
            lblcardbo.Visible = True
            lblcvv.Visible = True
            lblname1.Visible = True

        End If
    End Sub
    Public Sub clear()
        fname.Text = ""
        lname.Text = ""
        mobno.Text = ""
        cardNo.Text = ""
        cvv.Text = ""
        name1.Text = ""
        fname.Text = ""
        lname.Text = ""
        total_stock.Text = ""
        totalamount.Text = ""
        name1.Text = ""
        lblid.Text = ""
        itemname.Text = ""
        NumericUpDown1.Value = NumericUpDown1.Minimum
        lbldiscount.Text = ""
        auto()
    End Sub

    Private Sub cardNo_TextChanged(sender As Object, e As EventArgs) Handles cardNo.TextChanged
        If cardNo.Text.Length > 16 Then
            MessageBox.Show("Card Number should be of 16 digits")

        End If
    End Sub

    Private Sub cvv_TextChanged(sender As Object, e As EventArgs) Handles cvv.TextChanged
        If cvv.Text.Length > 3 Then
            MessageBox.Show("CVV could not be more than 3 digits, please check")

        End If
    End Sub



    Private Sub name1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles name1.KeyPress
        Dim unacceptable As String = "0123456789+-/*.,';[]"

        If InStr(unacceptable, e.KeyChar) > 0 Then
            e.KeyChar = Nothing
        End If
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

    Private Sub mobno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mobno.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso Asc(ch) <> 8 Then
            e.Handled = True

        End If
    End Sub

    Private Sub cardNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cardNo.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso Asc(ch) <> 8 Then
            e.Handled = True

        End If
    End Sub

    Private Sub cvv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cvv.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso Asc(ch) <> 8 Then
            e.Handled = True

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        clear()
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub total_stock_TextChanged(sender As Object, e As EventArgs) Handles total_stock.TextChanged



    End Sub

    Private Sub NumericUpDown1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NumericUpDown1.KeyPress
        Dim i As Integer
        i = Convert.ToInt32(total_stock.Text)
        If i <= 0 Then
            MessageBox.Show("Out of Stock")
        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub



    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso Asc(ch) <> 8 Then
            e.Handled = True

        End If
    End Sub



    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        totalamount.Text = NumericUpDown1.Value * ta


        total_stock.Text = ts - NumericUpDown1.Value
        If NumericUpDown1.Value = NumericUpDown1.Maximum Then
            MessageBox.Show("Out of Stock")
        End If


    End Sub



End Class