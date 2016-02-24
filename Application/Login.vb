Public Class SHCLogin

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TryshcDataSet1.Login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.TryshcDataSet1.Login)

    End Sub

    Private Sub LoginBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.LoginBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TryshcDataSet1)

    End Sub

    Private Sub LoginBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class
