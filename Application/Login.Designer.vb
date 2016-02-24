<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SHCLogin
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
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Me.TryshcDataSet1 = New TRYSHC.tryshcDataSet1()
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginTableAdapter = New TRYSHC.tryshcDataSet1TableAdapters.LoginTableAdapter()
        Me.TableAdapterManager = New TRYSHC.tryshcDataSet1TableAdapters.TableAdapterManager()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        CType(Me.TryshcDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsernameLabel.Location = New System.Drawing.Point(157, 109)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(78, 18)
        UsernameLabel.TabIndex = 1
        UsernameLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel.Location = New System.Drawing.Point(157, 135)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(72, 18)
        PasswordLabel.TabIndex = 3
        PasswordLabel.Text = "Password:"
        '
        'TryshcDataSet1
        '
        Me.TryshcDataSet1.DataSetName = "tryshcDataSet1"
        Me.TryshcDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoginBindingSource
        '
        Me.LoginBindingSource.DataMember = "Login"
        Me.LoginBindingSource.DataSource = Me.TryshcDataSet1
        '
        'LoginTableAdapter
        '
        Me.LoginTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Health_Certificate_Application_and_RenewalTableAdapter = Nothing
        Me.TableAdapterManager.HIV_Voluntary_Counseling_and_TestingTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Me.LoginTableAdapter
        Me.TableAdapterManager.Personal_InformationTableAdapter = Nothing
        Me.TableAdapterManager.STI_CONSULTATIONTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TRYSHC.tryshcDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "Username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(241, 107)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(181, 20)
        Me.UsernameTextBox.TabIndex = 2
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(241, 133)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(181, 20)
        Me.PasswordTextBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Baskerville Old Face", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(524, 22)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "SOCIAL HYGIENE CLINIC AND WELLNESS CENTER "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Baskerville Old Face", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(146, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(276, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Please login in using your account."
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.MidnightBlue
        Me.LinkLabel1.Location = New System.Drawing.Point(26, 224)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(122, 18)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Create an account"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(218, 175)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(317, 175)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SHCLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(604, 250)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Name = "SHCLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Social Hygiene Clinic and Wellness Center Login In"
        CType(Me.TryshcDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TryshcDataSet1 As TRYSHC.tryshcDataSet1
    Friend WithEvents LoginBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LoginTableAdapter As TRYSHC.tryshcDataSet1TableAdapters.LoginTableAdapter
    Friend WithEvents TableAdapterManager As TRYSHC.tryshcDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
