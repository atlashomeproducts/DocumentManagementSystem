<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabLogin = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkShow = New System.Windows.Forms.CheckBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TabMain = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SpDMSTotalsC1TrueDBGrid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.SpDMSTotalsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DMSDataSet = New DMS.DMSDataSet()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.IndexFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SEARCHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SpDMSTotalsTableAdapter = New DMS.DMSDataSetTableAdapters.spDMSTotalsTableAdapter()
        Me.TableAdapterManager = New DMS.DMSDataSetTableAdapters.TableAdapterManager()
        Me.TabControl1.SuspendLayout()
        Me.TabLogin.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabMain.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpDMSTotalsC1TrueDBGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpDMSTotalsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabLogin)
        Me.TabControl1.Controls.Add(Me.TabMain)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(0, 0)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1085, 687)
        Me.TabControl1.TabIndex = 1
        '
        'TabLogin
        '
        Me.TabLogin.BackColor = System.Drawing.Color.DimGray
        Me.TabLogin.Controls.Add(Me.GroupBox1)
        Me.TabLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabLogin.Location = New System.Drawing.Point(4, 22)
        Me.TabLogin.Margin = New System.Windows.Forms.Padding(0)
        Me.TabLogin.Name = "TabLogin"
        Me.TabLogin.Size = New System.Drawing.Size(1077, 661)
        Me.TabLogin.TabIndex = 0
        Me.TabLogin.Text = "Login"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.ChkShow)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnCancel)
        Me.GroupBox1.Controls.Add(Me.BtnOK)
        Me.GroupBox1.Controls.Add(Me.TxtPassword)
        Me.GroupBox1.Controls.Add(Me.TxtUsername)
        Me.GroupBox1.Location = New System.Drawing.Point(276, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(524, 244)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LOGIN"
        '
        'ChkShow
        '
        Me.ChkShow.AutoSize = True
        Me.ChkShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkShow.Location = New System.Drawing.Point(165, 164)
        Me.ChkShow.Name = "ChkShow"
        Me.ChkShow.Size = New System.Drawing.Size(114, 19)
        Me.ChkShow.TabIndex = 14
        Me.ChkShow.Text = "Show Password"
        Me.ChkShow.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(35, 45)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(120, 119)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(161, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 24)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(161, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 24)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Username:"
        '
        'BtnCancel
        '
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancel.Location = New System.Drawing.Point(353, 191)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(131, 34)
        Me.BtnCancel.TabIndex = 10
        Me.BtnCancel.Text = "CANCEL"
        Me.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.Image = CType(resources.GetObject("BtnOK.Image"), System.Drawing.Image)
        Me.BtnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOK.Location = New System.Drawing.Point(165, 191)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(131, 34)
        Me.BtnOK.TabIndex = 9
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(165, 129)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(319, 29)
        Me.TxtPassword.TabIndex = 8
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(165, 67)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(319, 29)
        Me.TxtUsername.TabIndex = 7
        '
        'TabMain
        '
        Me.TabMain.Controls.Add(Me.SplitContainer1)
        Me.TabMain.Controls.Add(Me.MenuStrip1)
        Me.TabMain.Location = New System.Drawing.Point(4, 22)
        Me.TabMain.Name = "TabMain"
        Me.TabMain.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMain.Size = New System.Drawing.Size(1077, 661)
        Me.TabMain.TabIndex = 1
        Me.TabMain.Text = "Main"
        Me.TabMain.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.DarkGray
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 30)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblUser)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.SpDMSTotalsC1TrueDBGrid)
        Me.SplitContainer1.Size = New System.Drawing.Size(1071, 628)
        Me.SplitContainer1.SplitterDistance = 743
        Me.SplitContainer1.TabIndex = 6
        Me.SplitContainer1.TabStop = False
        '
        'LblUser
        '
        Me.LblUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblUser.AutoSize = True
        Me.LblUser.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.LblUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LblUser.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUser.Location = New System.Drawing.Point(4, 597)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(52, 23)
        Me.LblUser.TabIndex = 8
        Me.LblUser.Text = "User"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(743, 628)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'SpDMSTotalsC1TrueDBGrid
        '
        Me.SpDMSTotalsC1TrueDBGrid.AllowArrows = False
        Me.SpDMSTotalsC1TrueDBGrid.AllowColMove = False
        Me.SpDMSTotalsC1TrueDBGrid.AllowColSelect = False
        Me.SpDMSTotalsC1TrueDBGrid.AllowFilter = False
        Me.SpDMSTotalsC1TrueDBGrid.AllowRowSelect = False
        Me.SpDMSTotalsC1TrueDBGrid.AllowSort = False
        Me.SpDMSTotalsC1TrueDBGrid.AllowUpdate = False
        Me.SpDMSTotalsC1TrueDBGrid.BackColor = System.Drawing.Color.DarkGray
        Me.SpDMSTotalsC1TrueDBGrid.BorderColor = System.Drawing.Color.Transparent
        Me.SpDMSTotalsC1TrueDBGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SpDMSTotalsC1TrueDBGrid.CaptionHeight = 17
        Me.SpDMSTotalsC1TrueDBGrid.DataSource = Me.SpDMSTotalsBindingSource
        Me.SpDMSTotalsC1TrueDBGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpDMSTotalsC1TrueDBGrid.EditDropDown = False
        Me.SpDMSTotalsC1TrueDBGrid.Enabled = False
        Me.SpDMSTotalsC1TrueDBGrid.ExtendRightColumn = True
        Me.SpDMSTotalsC1TrueDBGrid.FlatStyle = C1.Win.C1TrueDBGrid.FlatModeEnum.Flat
        Me.SpDMSTotalsC1TrueDBGrid.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpDMSTotalsC1TrueDBGrid.GroupByCaption = "Drag a column header here to group by that column"
        Me.SpDMSTotalsC1TrueDBGrid.Images.Add(CType(resources.GetObject("SpDMSTotalsC1TrueDBGrid.Images"), System.Drawing.Image))
        Me.SpDMSTotalsC1TrueDBGrid.Location = New System.Drawing.Point(0, 0)
        Me.SpDMSTotalsC1TrueDBGrid.Name = "SpDMSTotalsC1TrueDBGrid"
        Me.SpDMSTotalsC1TrueDBGrid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.SpDMSTotalsC1TrueDBGrid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.SpDMSTotalsC1TrueDBGrid.PreviewInfo.ZoomFactor = 75.0R
        Me.SpDMSTotalsC1TrueDBGrid.PrintInfo.PageSettings = CType(resources.GetObject("SpDMSTotalsC1TrueDBGrid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.SpDMSTotalsC1TrueDBGrid.RecordSelectors = False
        Me.SpDMSTotalsC1TrueDBGrid.RowDivider.Color = System.Drawing.Color.DimGray
        Me.SpDMSTotalsC1TrueDBGrid.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Raised
        Me.SpDMSTotalsC1TrueDBGrid.RowHeight = 21
        Me.SpDMSTotalsC1TrueDBGrid.Size = New System.Drawing.Size(324, 628)
        Me.SpDMSTotalsC1TrueDBGrid.SplitDividerSize = New System.Drawing.Size(0, 0)
        Me.SpDMSTotalsC1TrueDBGrid.TabIndex = 0
        Me.SpDMSTotalsC1TrueDBGrid.UseCompatibleTextRendering = False
        Me.SpDMSTotalsC1TrueDBGrid.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.System
        Me.SpDMSTotalsC1TrueDBGrid.PropBag = resources.GetString("SpDMSTotalsC1TrueDBGrid.PropBag")
        '
        'SpDMSTotalsBindingSource
        '
        Me.SpDMSTotalsBindingSource.DataMember = "spDMSTotals"
        Me.SpDMSTotalsBindingSource.DataSource = Me.DMSDataSet
        '
        'DMSDataSet
        '
        Me.DMSDataSet.DataSetName = "DMSDataSet"
        Me.DMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IndexFilesToolStripMenuItem, Me.ToolStripMenuItem1, Me.EditorToolStripMenuItem, Me.ToolStripMenuItem2, Me.SEARCHToolStripMenuItem, Me.ToolStripMenuItem3, Me.UserManagementToolStripMenuItem, Me.ToolStripMenuItem4})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 3)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.MenuStrip1.Size = New System.Drawing.Size(1071, 27)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'IndexFilesToolStripMenuItem
        '
        Me.IndexFilesToolStripMenuItem.Name = "IndexFilesToolStripMenuItem"
        Me.IndexFilesToolStripMenuItem.Size = New System.Drawing.Size(65, 27)
        Me.IndexFilesToolStripMenuItem.Text = "Index"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Enabled = False
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(40, 27)
        Me.ToolStripMenuItem1.Text = "||"
        '
        'EditorToolStripMenuItem
        '
        Me.EditorToolStripMenuItem.Name = "EditorToolStripMenuItem"
        Me.EditorToolStripMenuItem.Size = New System.Drawing.Size(68, 27)
        Me.EditorToolStripMenuItem.Text = "Editor"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Enabled = False
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(40, 27)
        Me.ToolStripMenuItem2.Text = "||"
        '
        'SEARCHToolStripMenuItem
        '
        Me.SEARCHToolStripMenuItem.Name = "SEARCHToolStripMenuItem"
        Me.SEARCHToolStripMenuItem.Size = New System.Drawing.Size(74, 27)
        Me.SEARCHToolStripMenuItem.Text = "Search"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Enabled = False
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(40, 27)
        Me.ToolStripMenuItem3.Text = "||"
        '
        'UserManagementToolStripMenuItem
        '
        Me.UserManagementToolStripMenuItem.Name = "UserManagementToolStripMenuItem"
        Me.UserManagementToolStripMenuItem.Size = New System.Drawing.Size(66, 27)
        Me.UserManagementToolStripMenuItem.Text = "Users"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Enabled = False
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(40, 27)
        Me.ToolStripMenuItem4.Text = "||"
        '
        'Timer1
        '
        '
        'SpDMSTotalsTableAdapter
        '
        Me.SpDMSTotalsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.DMSUserTableAdapter = Nothing
        Me.TableAdapterManager.DocsCatalogueTableAdapter = Nothing
        Me.TableAdapterManager.DocumentGroupsTableAdapter = Nothing
        Me.TableAdapterManager.DocumentTypesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DMS.DMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FrmMain
        '
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1085, 687)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMain"
        Me.Text = "Document Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabLogin.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabMain.ResumeLayout(False)
        Me.TabMain.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpDMSTotalsC1TrueDBGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpDMSTotalsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DMSDataSet As DMSDataSet
    Friend WithEvents SpDMSTotalsBindingSource As BindingSource
    Friend WithEvents SpDMSTotalsTableAdapter As DMSDataSetTableAdapters.spDMSTotalsTableAdapter
    Friend WithEvents TableAdapterManager As DMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabLogin As TabPage
    Friend WithEvents TabMain As TabPage
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents IndexFilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents SEARCHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SpDMSTotalsC1TrueDBGrid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnOK As Button
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents ChkShow As CheckBox
    Friend WithEvents UserManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents LblUser As Label
    Friend WithEvents Timer1 As Timer
End Class
