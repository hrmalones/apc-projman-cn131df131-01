﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form13
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.HIVVCTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.eSHCDataSet1 = New eSHC.eSHCDataSet1()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dateto = New System.Windows.Forms.DateTimePicker()
        Me.datefrom = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.HIVVCTTableAdapter = New eSHC.eSHCDataSet1TableAdapters.HIVVCTTableAdapter()
        Me.TableAdapterManager = New eSHC.eSHCDataSet1TableAdapters.TableAdapterManager()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.HIVVCTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eSHCDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HIVVCTBindingSource
        '
        Me.HIVVCTBindingSource.DataMember = "HIVVCT"
        Me.HIVVCTBindingSource.DataSource = Me.eSHCDataSet1
        '
        'eSHCDataSet1
        '
        Me.eSHCDataSet1.DataSetName = "eSHCDataSet1"
        Me.eSHCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(431, 48)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 53
        Me.Button2.Text = "RESET"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(431, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "FILTER"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dateto
        '
        Me.dateto.Location = New System.Drawing.Point(162, 40)
        Me.dateto.Name = "dateto"
        Me.dateto.Size = New System.Drawing.Size(200, 20)
        Me.dateto.TabIndex = 51
        '
        'datefrom
        '
        Me.datefrom.Location = New System.Drawing.Point(162, 12)
        Me.datefrom.Name = "datefrom"
        Me.datefrom.Size = New System.Drawing.Size(200, 20)
        Me.datefrom.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Date To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Date From"
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.HIVVCTBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "eSHC.Report24.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(44, 77)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(666, 585)
        Me.ReportViewer1.TabIndex = 54
        '
        'HIVVCTTableAdapter
        '
        Me.HIVVCTTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.HealthCertificateTableAdapter = Nothing
        Me.TableAdapterManager.HIVVCTTableAdapter = Me.HIVVCTTableAdapter
        Me.TableAdapterManager.PersonalInformationTableAdapter = Nothing
        Me.TableAdapterManager.STIConsultationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = eSHC.eSHCDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(569, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 55
        Me.Button3.Text = "HOME"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 741)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dateto)
        Me.Controls.Add(Me.datefrom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form13"
        Me.Text = "HIV TEST RESULT BY TYPE OF CLIENT"
        CType(Me.HIVVCTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eSHCataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dateto As System.Windows.Forms.DateTimePicker
    Friend WithEvents datefrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents eSHCDataSet1 As eSHC.eSHCDataSet1
    Friend WithEvents HIVVCTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HIVVCTTableAdapter As eSHCSystem.eSHCDataSet1TableAdapters.HIVVCTTableAdapter
    Friend WithEvents TableAdapterManager As eSHC.eSHCDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
