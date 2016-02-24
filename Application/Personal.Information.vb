Public Class Personal_Information

    Private Sub Personal_InformationBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Personal_InformationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TryshcDataSet1)

    End Sub

    Private Sub Personal_Information_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TryshcDataSet1.HIV_Voluntary_Counseling_and_Testing' table. You can move, or remove it, as needed.
        Me.HIV_Voluntary_Counseling_and_TestingTableAdapter.Fill(Me.TryshcDataSet1.HIV_Voluntary_Counseling_and_Testing)
        'TODO: This line of code loads data into the 'TryshcDataSet1.Health_Certificate_Application_and_Renewal' table. You can move, or remove it, as needed.
        Me.Health_Certificate_Application_and_RenewalTableAdapter.Fill(Me.TryshcDataSet1.Health_Certificate_Application_and_Renewal)
        'TODO: This line of code loads data into the 'TryshcDataSet1.Health_Certificate_Application_and_Renewal' table. You can move, or remove it, as needed.
        Me.Health_Certificate_Application_and_RenewalTableAdapter.Fill(Me.TryshcDataSet1.Health_Certificate_Application_and_Renewal)
        'TODO: This line of code loads data into the 'TryshcDataSet1.Health_Certificate_Application_and_Renewal' table. You can move, or remove it, as needed.
        Me.Health_Certificate_Application_and_RenewalTableAdapter.Fill(Me.TryshcDataSet1.Health_Certificate_Application_and_Renewal)
        'TODO: This line of code loads data into the 'TryshcDataSet1.Health_Certificate_Application_and_Renewal' table. You can move, or remove it, as needed.
        Me.Health_Certificate_Application_and_RenewalTableAdapter.Fill(Me.TryshcDataSet1.Health_Certificate_Application_and_Renewal)
        'TODO: This line of code loads data into the 'TryshcDataSet1.STI_CONSULTATION' table. You can move, or remove it, as needed.
        Me.STI_CONSULTATIONTableAdapter.Fill(Me.TryshcDataSet1.STI_CONSULTATION)
        'TODO: This line of code loads data into the 'TryshcDataSet1.Personal_Information' table. You can move, or remove it, as needed.
        Me.Personal_InformationTableAdapter.Fill(Me.TryshcDataSet1.Personal_Information)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Personalgrpbx.Enter

    End Sub

    Private Sub Telephone_NumberLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CityLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Patient_IDTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Patient_IDTextBox.TextChanged

    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Initial_ImpressionLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Heart_rateTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Heart_rateTextBox.TextChanged

    End Sub

    Private Sub PrescriptionLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Laboratory_requestLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Laboratory_requestTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Laboratory_requestTextBox.TextChanged

    End Sub

    Private Sub Referral_Label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Referral_TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Referral_TextBox.TextChanged

    End Sub

    Private Sub Date_of_Follow_upLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PrescriptionTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrescriptionTextBox.TextChanged

    End Sub

    Private Sub Date_of_Follow_upDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Date_of_Follow_upDateTimePicker.ValueChanged

    End Sub


    Private Sub Patient_IDTextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Patient_IDTextBox2.TextChanged

    End Sub
    Private Sub Patient_IDLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox6_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox6.Enter

    End Sub

    Private Sub TabPage4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub GroupBox11_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox11.Enter

    End Sub
End Class