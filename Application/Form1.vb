Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SHCSystemDataSet1.PersonalInformation' table. You can move, or remove it, as needed.
        Me.PersonalInformationTableAdapter.Fill(Me.SHCSystemDataSet1.PersonalInformation)
        'TODO: This line of code loads data into the 'SHCSystemDataSet1.HIVVCT' table. You can move, or remove it, as needed.
        Me.HIVVCTTableAdapter.Fill(Me.SHCSystemDataSet1.HIVVCT)
        'TODO: This line of code loads data into the 'SHCSystemDataSet1.STIConsultation' table. You can move, or remove it, as needed.
        Me.STIConsultationTableAdapter.Fill(Me.SHCSystemDataSet1.STIConsultation)
        'TODO: This line of code loads data into the 'SHCSystemDataSet1.HealthCertificate' table. You can move, or remove it, as needed.
        Me.HealthCertificateTableAdapter.Fill(Me.SHCSystemDataSet1.HealthCertificate)

        Me.ReportViewer1.RefreshReport()
       
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DataEntry.Show()
        Me.Hide()

    End Sub
End Class