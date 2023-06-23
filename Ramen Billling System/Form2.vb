Imports System.Data.SqlClient
Public Class Form2
    Const shi = 15
    Const mis = 12
    Const sho = 13
    Const ton = 14

    Dim con As New SqlConnection
    Dim item(9) As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        NumerShio.Value = 0
        NumerMiso.Value = 0
        NumerShoyu.Value = 0
        NumerTonkotsu.Value = 0

        lblshio.Text = "$0.00"
        lblmiso.Text = "$0.00"
        lblshoyu.Text = "$0.00"
        lblTonkistu.Text = "$0.00"
        lblTotal.Text = "$0.00"
        lblNumTotal.Text = "0"

        RadioButton1.Checked = False
        RadioButton2.Checked = False



        cardNo.Text = ""

        fname.Text = ""
        lname.Text = ""
        mobno.Text = ""

        orderno.Text = ""
        cvv.Text = ""
        name1.Text = ""


    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) Then
            e.Handled = True
        End If
    End Sub


    Private Sub NumerShio_ValueChanged(sender As Object, e As EventArgs) Handles NumerShio.ValueChanged
        lblshio.Text = FormatCurrency(NumerShio.Value * shi)
    End Sub

    Private Sub NumerMiso_ValueChanged(sender As Object, e As EventArgs) Handles NumerMiso.ValueChanged
        lblmiso.Text = FormatCurrency(NumerMiso.Value * mis)
    End Sub

    Private Sub NumerShoyu_ValueChanged(sender As Object, e As EventArgs) Handles NumerShoyu.ValueChanged
        lblshoyu.Text = FormatCurrency(NumerShoyu.Value * sho)
    End Sub

    Private Sub NumerTonkotsu_ValueChanged(sender As Object, e As EventArgs) Handles NumerTonkotsu.ValueChanged
        lblTonkistu.Text = FormatCurrency(NumerTonkotsu.Value * ton)
    End Sub



    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        auto()
        item(0) = NumerShio.Value * shi
        item(1) = NumerMiso.Value * mis
        item(2) = NumerShoyu.Value * sho
        item(3) = NumerTonkotsu.Value * ton

        item(4) = item(0) + item(1) + item(2) + item(3)
        lblTotal.Text = FormatCurrency(item(4))

        Dim q(9) As Integer
        q(0) = NumerShio.Value
        q(1) = NumerShoyu.Value
        q(2) = NumerMiso.Value
        q(3) = NumerTonkotsu.Value


        q(4) = q(0) + q(1) + q(2) + q(3)
        lblNumTotal.Text = q(4)



    End Sub

    Private Sub cardNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cardNo.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso Asc(ch) <> 8 Then
            e.Handled = True

        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Logout.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sonuyadav07\source\repos\Ramen Billling System\Ramen Billling System\Database1.mdf;Integrated Security=True"
        con.Open()
        Dim d1 As SqlDataReader
        Dim cmd As SqlCommand
        Dim Q As String


        Try
            Q = "select orderno from items where orderno='" & orderno.Text & "'"
            cmd = New SqlCommand(Q, con)
            d1 = cmd.ExecuteReader
            Dim c As Integer
            c = 0
            While d1.Read
                c = c + 1

            End While
            d1.Close()




            If c = 1 Then
                MessageBox.Show("Change the Order No.")



            ElseIf lblNumTotal.Text = 0 Then
                MessageBox.Show("Please Do Total first")

            ElseIf RadioButton1.Checked = False And RadioButton2.Checked = False Then
                MessageBox.Show("Select payment Method")



            ElseIf orderno.Text = "" Then
                MessageBox.Show("Enter Customer ID")




            ElseIf orderno.Text = "" And RadioButton2.Checked = True Then
                If cardNo.Text = "" Then
                    MessageBox.Show("Enter Custid and card number")
                End If



            ElseIf lblNumTotal.Text = "0" And lblTotal.Text = "$0" Then
                MessageBox.Show("Add some items first")

            ElseIf fname.Text = "" Then
                MessageBox.Show(" Enter Customer Details")


            ElseIf lname.Text = "" Then
                MessageBox.Show("Enter Last Name and Mobile No.")

            ElseIf mobno.Text = "" Then
                MessageBox.Show("Enter Mobile Number")

            ElseIf mobno.Text.Length <> 10 Then
                MsgBox("please enter a valid number")

            ElseIf cvv.Text.Length > 16 Then
                MessageBox.Show("Card Numbershould be of 16 digits")

            ElseIf cardNo.Text = "" Or name1.Text = "" Then
                MessageBox.Show("Please Enter your Card Details Properly ")

                ElseIf cvv.Text.Length <> 3 Then
                    MessageBox.Show("CVV Number cannot be more than 3 digits")






            ElseIf RadioButton1.Checked = True Or RadioButton2.Checked = True Then
                Q = "select mobno from customer where mobno='" & mobno.Text & "'
"
                cmd = New SqlCommand(Q, con)
                d1 = cmd.ExecuteReader

                Dim count As Integer
                count = 0
                While d1.Read
                    count = count + 1
                End While
                d1.Close()
                If count = 1 Then
                    Q = "insert into items (orderno,Noofitems,TotalCostofitem,shio,miso,shoyu,tonkostsu,date,mobno1) values ('" & orderno.Text & "','" & lblNumTotal.Text & "','" & lblTotal.Text & "',
                   '" & NumerShio.Value & "', '" & NumerMiso.Value & "', '" & NumerShoyu.Value & "','" & NumerTonkotsu.Value & "',
                   '" & Date1.Value & "','" & mobno.Text & "')"

                    cmd = New SqlCommand(Q, con)
                    d1 = cmd.ExecuteReader
                    d1.Close()

                    Q = "update customer set orderno1='" & orderno.Text & "' where mobno ='" & mobno.Text & "' "
                    cmd = New SqlCommand(Q, con)
                    d1 = cmd.ExecuteReader
                    d1.Close()
                    MessageBox.Show("Payment Successfully")
                    Button1.Visible = False
                    NumerShio.Value = 0
                    NumerMiso.Value = 0
                    NumerShoyu.Value = 0
                    NumerTonkotsu.Value = 0

                    lblshio.Text = "$0.00"
                    lblmiso.Text = "$0.00"
                    lblshoyu.Text = "$0.00"
                    lblTonkistu.Text = "$0.00"
                    lblTotal.Text = "$0.00"
                    lblNumTotal.Text = "0"

                    RadioButton1.Checked = False
                    RadioButton2.Checked = False



                    cardNo.Text = ""

                    fname.Text = ""
                    lname.Text = ""
                    mobno.Text = ""

                    orderno.Text = ""
                    cvv.Text = ""
                    name1.Text = ""

                ElseIf count = 0 Then
                    Q = "insert into items (orderno,Noofitems,TotalCostofitem,shio,miso,shoyu,tonkostsu,date,mobno1) values ('" & orderno.Text & "','" & lblNumTotal.Text & "','" & lblTotal.Text & "',
                   '" & NumerShio.Value & "', '" & NumerMiso.Value & "', '" & NumerShoyu.Value & "','" & NumerTonkotsu.Value & "',
                   '" & Date1.Value & "','" & mobno.Text & "')"

                    cmd = New SqlCommand(Q, con)
                    d1 = cmd.ExecuteReader
                    d1.Close()

                    Q = "insert into customer(mobno,fname,lname,orderno1,date1) values('" & mobno.Text & "','" & fname.Text & "','" & lname.Text & "'
                           ,'" & orderno.Text & "','" & Date1.Value & "')"

                    cmd = New SqlCommand(Q, con)
                    d1 = cmd.ExecuteReader
                    MessageBox.Show("Payment Successfully")
                    Button1.Visible = False
                    NumerShio.Value = 0
                    NumerMiso.Value = 0
                    NumerShoyu.Value = 0
                    NumerTonkotsu.Value = 0

                    lblshio.Text = "$0.00"
                    lblmiso.Text = "$0.00"
                    lblshoyu.Text = "$0.00"
                    lblTonkistu.Text = "$0.00"
                    lblTotal.Text = "$0.00"
                    lblNumTotal.Text = "0"

                    RadioButton1.Checked = False
                    RadioButton2.Checked = False



                    cardNo.Text = ""

                    fname.Text = ""
                    lname.Text = ""
                    mobno.Text = ""

                    orderno.Text = ""
                    cvv.Text = ""
                    name1.Text = ""
                End If





            End If


        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        Finally
            con.Close()
            con.Dispose()
        End Try


    End Sub




    Private Sub custid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles orderno.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso Asc(ch) <> 8 Then
            e.Handled = True
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sonuyadav07\source\repos\Ramen Billling System\Ramen Billling System\Database1.mdf;Integrated Security=True"
        con.Open()


        Dim q1 As String

        q1 = "select mobno from customer where mobno='" & mobno.Text & "'"
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
            Button1.Visible = True
            MessageBox.Show("Record exist")
            q1 = "select fname,lname from customer where mobno='" & mobno.Text & "'"
            cmd = New SqlCommand(q1, con)
            d1 = cmd.ExecuteReader
            While d1.Read
                fname.Text = d1("fname")
                lname.Text = d1("lname")
            End While

        ElseIf count = 0 Then
            Button1.Visible = True
            MessageBox.Show("Record doesn't exist")
        End If
        d1.Close()
        con.Close()

        con.Dispose()

    End Sub
    Public Sub auto()

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sonuyadav07\source\repos\Ramen Billling System\Ramen Billling System\Database1.mdf;Integrated Security=True"
        con.Open()
        Dim cmd As SqlCommand

        Dim Num As Integer

        cmd = New SqlCommand("select max(orderno) from items", con)
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
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Visible = False
        name1.Visible = False
        cvv.Visible = False
        cardNo.Visible = False
        lblcardbo.Visible = False
        lblcvv.Visible = False
        lblname1.Visible = False
    End Sub

    Private Sub mobno_TextChanged(sender As Object, e As EventArgs) Handles mobno.TextChanged
        If mobno.Text.Length > 10 Then
            MsgBox("please enter a valid number")
        End If

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

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles lblname1.Click

    End Sub

    Private Sub cardNo_TextChanged(sender As Object, e As EventArgs) Handles cardNo.TextChanged
        If cardNo.Text.Length > 16 Then
            MessageBox.Show("Card Number should be of 16 digits")

        End If
    End Sub

    Private Sub mobno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mobno.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso Asc(ch) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Date1_ValueChanged(sender As Object, e As EventArgs) Handles Date1.ValueChanged

    End Sub

    Private Sub cvv_TextChanged(sender As Object, e As EventArgs) Handles cvv.TextChanged
        If cvv.Text.Length > 3 Then
            MessageBox.Show("CVV could not be more than 3 digits, please check")

        End If
    End Sub

    Private Sub cvv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cvv.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso Asc(ch) <> 8 Then
            e.Handled = True

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

    Private Sub name1_TextChanged(sender As Object, e As EventArgs) Handles name1.TextChanged

    End Sub

    Private Sub name1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles name1.KeyPress
        Dim unacceptable As String = "0123456789+-/*.,';[]"

        If InStr(unacceptable, e.KeyChar) > 0 Then
            e.KeyChar = Nothing
        End If
    End Sub


End Class
