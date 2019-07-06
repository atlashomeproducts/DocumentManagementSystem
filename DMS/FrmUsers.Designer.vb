<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsers))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtUsertype = New System.Windows.Forms.ComboBox()
        Me.TxtRetype = New System.Windows.Forms.TextBox()
        Me.BtnConfirm = New System.Windows.Forms.Button()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.DMSUserC1TrueDBGrid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.DMSUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DMSDataSet = New DMS.DMSDataSet()
        Me.TableAdapterManager = New DMS.DMSDataSetTableAdapters.TableAdapterManager()
        Me.DMSUserTableAdapter = New DMS.DMSDataSetTableAdapters.DMSUserTableAdapter()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DMSUserC1TrueDBGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DMSUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnDelete)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtUsertype)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtRetype)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnConfirm)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtPassword)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtUsername)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.DMSUserC1TrueDBGrid)
        Me.SplitContainer1.Size = New System.Drawing.Size(386, 466)
        Me.SplitContainer1.SplitterDistance = 155
        Me.SplitContainer1.TabIndex = 0
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 131)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(107, 17)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "Show Passwords"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(280, 122)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(83, 26)
        Me.BtnDelete.TabIndex = 14
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Name:*"
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(109, 34)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(254, 20)
        Me.TxtName.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "User Type:*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Retype Password:*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Password:*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Username:*"
        '
        'TxtUsertype
        '
        Me.TxtUsertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtUsertype.FormattingEnabled = True
        Me.TxtUsertype.Items.AddRange(New Object() {"Administrator", "User"})
        Me.TxtUsertype.Location = New System.Drawing.Point(109, 97)
        Me.TxtUsertype.Name = "TxtUsertype"
        Me.TxtUsertype.Size = New System.Drawing.Size(254, 21)
        Me.TxtUsertype.TabIndex = 4
        '
        'TxtRetype
        '
        Me.TxtRetype.Location = New System.Drawing.Point(109, 76)
        Me.TxtRetype.Name = "TxtRetype"
        Me.TxtRetype.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtRetype.Size = New System.Drawing.Size(254, 20)
        Me.TxtRetype.TabIndex = 3
        '
        'BtnConfirm
        '
        Me.BtnConfirm.Location = New System.Drawing.Point(191, 122)
        Me.BtnConfirm.Name = "BtnConfirm"
        Me.BtnConfirm.Size = New System.Drawing.Size(83, 26)
        Me.BtnConfirm.TabIndex = 5
        Me.BtnConfirm.Text = "Confirm"
        Me.BtnConfirm.UseVisualStyleBackColor = True
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(109, 55)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(254, 20)
        Me.TxtPassword.TabIndex = 2
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(109, 13)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(254, 20)
        Me.TxtUsername.TabIndex = 0
        '
        'DMSUserC1TrueDBGrid
        '
        Me.DMSUserC1TrueDBGrid.AllowDelete = True
        Me.DMSUserC1TrueDBGrid.DataSource = Me.DMSUserBindingSource
        Me.DMSUserC1TrueDBGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DMSUserC1TrueDBGrid.ExtendRightColumn = True
        Me.DMSUserC1TrueDBGrid.FilterBar = True
        Me.DMSUserC1TrueDBGrid.GroupByCaption = "Drag a column header here to group by that column"
        Me.DMSUserC1TrueDBGrid.Images.Add(CType(resources.GetObject("DMSUserC1TrueDBGrid.Images"), System.Drawing.Image))
        Me.DMSUserC1TrueDBGrid.Location = New System.Drawing.Point(0, 0)
        Me.DMSUserC1TrueDBGrid.Name = "DMSUserC1TrueDBGrid"
        Me.DMSUserC1TrueDBGrid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DMSUserC1TrueDBGrid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DMSUserC1TrueDBGrid.PreviewInfo.ZoomFactor = 75.0R
        Me.DMSUserC1TrueDBGrid.PrintInfo.PageSettings = CType(resources.GetObject("DMSUserC1TrueDBGrid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DMSUserC1TrueDBGrid.RowHeight = 22
        Me.DMSUserC1TrueDBGrid.Size = New System.Drawing.Size(386, 307)
        Me.DMSUserC1TrueDBGrid.TabIndex = 0
        Me.DMSUserC1TrueDBGrid.UseCompatibleTextRendering = False
        Me.DMSUserC1TrueDBGrid.PropBag = resources.GetString("DMSUserC1TrueDBGrid.PropBag")
        '
        'DMSUserBindingSource
        '
        Me.DMSUserBindingSource.DataMember = "DMSUser"
        Me.DMSUserBindingSource.DataSource = Me.DMSDataSet
        '
        'DMSDataSet
        '
        Me.DMSDataSet.DataSetName = "DMSDataSet"
        Me.DMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.DMSLogsTableAdapter = Nothing
        Me.TableAdapterManager.DMSUserTableAdapter = Nothing
        Me.TableAdapterManager.DocsCatalogueTableAdapter = Nothing
        Me.TableAdapterManager.DocumentGroupsTableAdapter = Nothing
        Me.TableAdapterManager.DocumentTypesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DMS.DMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DMSUserTableAdapter
        '
        Me.DMSUserTableAdapter.ClearBeforeFill = True
        '
        'FrmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(386, 466)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmUsers"
        Me.Text = "Users"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DMSUserC1TrueDBGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DMSUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents DMSDataSet As DMSDataSet
    Friend WithEvents DMSUserBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As DMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents DMSUserC1TrueDBGrid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents BtnConfirm As Button
    Friend WithEvents TxtUsertype As ComboBox
    Friend WithEvents TxtRetype As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents BtnDelete As Button
    Friend WithEvents DMSUserTableAdapter As DMSDataSetTableAdapters.DMSUserTableAdapter
    Friend WithEvents CheckBox1 As CheckBox
End Class
