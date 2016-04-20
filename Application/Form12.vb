﻿Public Class Form12

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.HIVVCTBindingSource.Filter = "DateOfHIVTesting >= '" & datefrom.Value.ToShortDateString & "'and DateOfHIVTesting <='" & dateto.Value.ToShortDateString & "'"
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.HIVVCTBindingSource.Filter = String.Empty
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Form12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'eSHCDataSet1.HIVVCT' table. You can move, or remove it, as needed.
        Me.HIVVCTTableAdapter.Fill(Me.eSHCDataSet1.HIVVCT)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub HIVVCTBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.HIVVCTBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.eSHCDataSet1)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DataEntry.Show()
        Me.Hide()
    End Sub
End Class