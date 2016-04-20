Public Class Form21

    Private Sub Form21_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SHCSystemDataSet1.PersonalInformation' table. You can move, or remove it, as needed.
        Me.PersonalInformationTableAdapter.Fill(Me.SHCSystemDataSet1.PersonalInformation)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.PersonalInformationBindingSource.Filter = "DateOfRegistration >= '" & datefrom.Value.ToShortDateString & "'and DateOfRegistration <='" & dateto.Value.ToShortDateString & "'"
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.PersonalInformationBindingSource.Filter = String.Empty
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub PersonalInformationBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PersonalInformationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SHCSystemDataSet1)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DataEntry.Show()
        Me.Hide()
    End Sub
End Class