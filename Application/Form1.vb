Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'eSHCDataSet1.PersonalInformation' table. You can move, or remove it, as needed.
        Me.PersonalInformationTableAdapter.Fill(Me.eSHCDataSet1.PersonalInformation)
        'TODO: This line of code loads data into the 'eSHCDataSet1.HIVVCT' table. You can move, or remove it, as needed.
        Me.HIVVCTTableAdapter.Fill(Me.eSHCDataSet1.HIVVCT)
        'TODO: This line of code loads data into the 'eSHCDataSet1.STIConsultation' table. You can move, or remove it, as needed.
        Me.STIConsultationTableAdapter.Fill(Me.eSHCDataSet1.STIConsultation)
        'TODO: This line of code loads data into the 'eSHCDataSet1.HealthCertificate' table. You can move, or remove it, as needed.
        Me.HealthCertificateTableAdapter.Fill(Me.eSHCDataSet1.HealthCertificate)

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
