﻿Public Class Form26

    Private Sub Form26_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SHCSystemDataSet1.HIVVCT' table. You can move, or remove it, as needed.
        Me.HIVVCTTableAdapter.Fill(Me.SHCSystemDataSet1.HIVVCT)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub HIVVCTBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HIVVCTBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.HIVVCTBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SHCSystemDataSet1)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.HIVVCTBindingSource.Filter = "DateOfHIVTesting >= '" & datefrom.Value.ToShortDateString & "'and DateOfHIVTesting <='" & dateto.Value.ToShortDateString & "'"
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.HIVVCTBindingSource.Filter = String.Empty
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DataEntry.Show()
        Me.Hide()
    End Sub
End Class