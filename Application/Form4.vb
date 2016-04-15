Public Class Form4

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SHCSystemDataSet1.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.SHCSystemDataSet1.DataTable1)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DataTable1BindingSource.Filter = "DateOfConsultation >= '" & datefrom.Value.ToShortDateString & "'and DateOfConsultation <='" & dateto.Value.ToShortDateString & "'"
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.DataTable1BindingSource.Filter = String.Empty
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DataEntry.Show()
        Me.Hide()
    End Sub
End Class