Public Class Form23

    Private Sub Form23_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SHCSystemDataSet1.DataTable2' table. You can move, or remove it, as needed.
        Me.DataTable2TableAdapter.Fill(Me.SHCSystemDataSet1.DataTable2)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DataTable2BindingSource.Filter = "DateOfApplication >= '" & datefrom.Value.ToShortDateString & "'and DateOfApplication <='" & dateto.Value.ToShortDateString & "'"
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.DataTable2BindingSource.Filter = String.Empty
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DataEntry.Show()
        Me.Hide()
    End Sub
End Class