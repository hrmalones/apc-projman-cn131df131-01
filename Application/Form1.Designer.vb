<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.PersonalInformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.eSHCDataSet1 = New eSHC.eSHCDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.datefrom = New System.Windows.Forms.DateTimePicker()
        Me.dateto = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.HealthCertificateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HealthCertificateTableAdapter = New eSHC.eSHCDataSet1TableAdapters.HealthCertificateTableAdapter()
        Me.STIConsultationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STIConsultationTableAdapter = New eSHC.eSHCDataSet1TableAdapters.STIConsultationTableAdapter()
        Me.HIVVCTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HIVVCTTableAdapter = New eSHC.eSHCDataSet1TableAdapters.HIVVCTTableAdapter()
        Me.PersonalInformationTableAdapter = New eSHC.eSHCDataSet1TableAdapters.PersonalInformationTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.PersonalInformationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eSHCDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HealthCertificateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STIConsultationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HIVVCTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PersonalInformationBindingSource
        '
        Me.PersonalInformationBindingSource.DataMember = "PersonalInformation"
        Me.PersonalInformationBindingSource.DataSource = Me.eSHCDataSet1
        '
        'eSHCDataSet1
        '
        Me.eSHCDataSet1.DataSetName = "SHCSystemDataSet1"
        Me.eSHCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.PersonalInformationBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "eSHC.Report5.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(34, 126)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(668, 210)
        Me.ReportViewer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date To"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Name Filter"
        '
        'datefrom
        '
        Me.datefrom.Location = New System.Drawing.Point(105, 24)
        Me.datefrom.Name = "datefrom"
        Me.datefrom.Size = New System.Drawing.Size(200, 20)
        Me.datefrom.TabIndex = 4
        '
        'dateto
        '
        Me.dateto.Location = New System.Drawing.Point(105, 57)
        Me.dateto.Name = "dateto"
        Me.dateto.Size = New System.Drawing.Size(200, 20)
        Me.dateto.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(105, 94)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 20)
        Me.TextBox1.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(348, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "FILTER"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(348, 53)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "RESET"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'HealthCertificateBindingSource
        '
        Me.HealthCertificateBindingSource.DataMember = "HealthCertificate"
        Me.HealthCertificateBindingSource.DataSource = Me.eSHCDataSet1
        '
        'HealthCertificateTableAdapter
        '
        Me.HealthCertificateTableAdapter.ClearBeforeFill = True
        '
        'STIConsultationBindingSource
        '
        Me.STIConsultationBindingSource.DataMember = "STIConsultation"
        Me.STIConsultationBindingSource.DataSource = Me.eSHCDataSet1
        '
        'STIConsultationTableAdapter
        '
        Me.STIConsultationTableAdapter.ClearBeforeFill = True
        '
        'HIVVCTBindingSource
        '
        Me.HIVVCTBindingSource.DataMember = "HIVVCT"
        Me.HIVVCTBindingSource.DataSource = Me.eSHCDataSet1
        '
        'HIVVCTTableAdapter
        '
        Me.HIVVCTTableAdapter.ClearBeforeFill = True
        '
        'PersonalInformationTableAdapter
        '
        Me.PersonalInformationTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(627, 27)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "HOME"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 442)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dateto)
        Me.Controls.Add(Me.datefrom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PersonalInformationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SHCSystemDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HealthCertificateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STIConsultationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HIVVCTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HealthCertificateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents eSHCDataSet1 As eSHC.eSHCDataSet1
    Friend WithEvents HealthCertificateTableAdapter As eSHC.eSHCDataSet1TableAdapters.HealthCertificateTableAdapter
    Friend WithEvents STIConsultationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents STIConsultationTableAdapter As eSHC.eSHCDataSet1TableAdapters.STIConsultationTableAdapter
    Friend WithEvents HIVVCTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HIVVCTTableAdapter As eSHC.eSHCDataSet1TableAdapters.HIVVCTTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PersonalInformationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PersonalInformationTableAdapter As eSHC.eSHCDataSet1TableAdapters.PersonalInformationTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents datefrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateto As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
