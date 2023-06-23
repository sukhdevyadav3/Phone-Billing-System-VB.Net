Public Class Report
    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.sales' table. You can move, or remove it, as needed.
        Me.salesTableAdapter.Fill(Me.DataSet1.sales)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dash.Show()
        Me.Hide()

    End Sub
End Class