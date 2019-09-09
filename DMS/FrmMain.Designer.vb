<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits C1.Win.C1Ribbon.C1RibbonForm

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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnDock = New System.Windows.Forms.Button()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.IndexFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SEARCHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemovalToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtQueue = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SpDMSTotalsC1TrueDBGrid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.SpDMSTotalsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DMSDataSet = New DMS.DMSDataSet()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.SpDMSLogsC1TrueDBGrid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.SpDMSLogsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SpDMSTotalsTableAdapter = New DMS.DMSDataSetTableAdapters.spDMSTotalsTableAdapter()
        Me.TableAdapterManager = New DMS.DMSDataSetTableAdapters.TableAdapterManager()
        Me.SpDMSLogsTableAdapter = New DMS.DMSDataSetTableAdapters.spDMSLogsTableAdapter()
        Me.SpDMSLogsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.HelpToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SpDMSTotalsC1TrueDBGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpDMSTotalsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.SpDMSLogsC1TrueDBGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpDMSLogsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpDMSLogsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Size = New System.Drawing.Size(1229, 687)
        Me.TabControl1.TabIndex = 1
        Me.TabControl1.TabStop = False
        '
        'TabLogin
        '
        Me.TabLogin.BackColor = System.Drawing.Color.Azure
        Me.TabLogin.Controls.Add(Me.GroupBox1)
        Me.TabLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabLogin.Location = New System.Drawing.Point(4, 22)
        Me.TabLogin.Margin = New System.Windows.Forms.Padding(0)
        Me.TabLogin.Name = "TabLogin"
        Me.TabLogin.Size = New System.Drawing.Size(1221, 661)
        Me.TabLogin.TabIndex = 0
        Me.TabLogin.Text = "Login"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ChkShow)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnCancel)
        Me.GroupBox1.Controls.Add(Me.BtnOK)
        Me.GroupBox1.Controls.Add(Me.TxtPassword)
        Me.GroupBox1.Controls.Add(Me.TxtUsername)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(348, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(524, 244)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'ChkShow
        '
        Me.ChkShow.AutoSize = True
        Me.ChkShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkShow.ForeColor = System.Drawing.Color.Black
        Me.ChkShow.Location = New System.Drawing.Point(165, 164)
        Me.ChkShow.Name = "ChkShow"
        Me.ChkShow.Size = New System.Drawing.Size(114, 19)
        Me.ChkShow.TabIndex = 2
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
        Me.Label2.ForeColor = System.Drawing.Color.Black
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
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(161, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 24)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Username:"
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancel.Location = New System.Drawing.Point(353, 191)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(131, 34)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "CANCEL"
        Me.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnOK
        '
        Me.BtnOK.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnOK.Image = CType(resources.GetObject("BtnOK.Image"), System.Drawing.Image)
        Me.BtnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOK.Location = New System.Drawing.Point(165, 191)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(131, 34)
        Me.BtnOK.TabIndex = 3
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = False
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(165, 129)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(319, 29)
        Me.TxtPassword.TabIndex = 1
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(165, 67)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(319, 29)
        Me.TxtUsername.TabIndex = 0
        '
        'TabMain
        '
        Me.TabMain.BackColor = System.Drawing.Color.DarkGray
        Me.TabMain.Controls.Add(Me.SplitContainer1)
        Me.TabMain.Location = New System.Drawing.Point(4, 22)
        Me.TabMain.Name = "TabMain"
        Me.TabMain.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMain.Size = New System.Drawing.Size(1221, 661)
        Me.TabMain.TabIndex = 1
        Me.TabMain.Text = "Main"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Azure
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnDock)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblUser)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MenuStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1215, 655)
        Me.SplitContainer1.SplitterDistance = 887
        Me.SplitContainer1.TabIndex = 6
        Me.SplitContainer1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(807, 611)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 27)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Log Off"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnDock
        '
        Me.btnDock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDock.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnDock.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDock.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDock.Location = New System.Drawing.Point(866, 33)
        Me.btnDock.Name = "btnDock"
        Me.btnDock.Size = New System.Drawing.Size(24, 98)
        Me.btnDock.TabIndex = 9
        Me.btnDock.Text = "Dock"
        Me.btnDock.UseVisualStyleBackColor = False
        '
        'LblUser
        '
        Me.LblUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblUser.AutoSize = True
        Me.LblUser.BackColor = System.Drawing.Color.Azure
        Me.LblUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LblUser.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUser.Location = New System.Drawing.Point(6, 615)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(52, 23)
        Me.LblUser.TabIndex = 8
        Me.LblUser.Text = "User"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Azure
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(887, 628)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IndexFilesToolStripMenuItem, Me.ToolStripMenuItem1, Me.EditorToolStripMenuItem, Me.ToolStripMenuItem2, Me.SEARCHToolStripMenuItem, Me.ToolStripMenuItem3, Me.RemovalToolStripMenuItem6, Me.ToolStripMenuItem7, Me.UserManagementToolStripMenuItem, Me.ToolStripMenuItem4, Me.HelpToolStripMenuItem6, Me.TxtQueue, Me.ToolStripMenuItem5})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(887, 27)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'IndexFilesToolStripMenuItem
        '
        Me.IndexFilesToolStripMenuItem.Image = CType(resources.GetObject("IndexFilesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IndexFilesToolStripMenuItem.Name = "IndexFilesToolStripMenuItem"
        Me.IndexFilesToolStripMenuItem.Size = New System.Drawing.Size(81, 27)
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
        Me.EditorToolStripMenuItem.Image = CType(resources.GetObject("EditorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditorToolStripMenuItem.Name = "EditorToolStripMenuItem"
        Me.EditorToolStripMenuItem.Size = New System.Drawing.Size(84, 27)
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
        Me.SEARCHToolStripMenuItem.Image = CType(resources.GetObject("SEARCHToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SEARCHToolStripMenuItem.Name = "SEARCHToolStripMenuItem"
        Me.SEARCHToolStripMenuItem.Size = New System.Drawing.Size(90, 27)
        Me.SEARCHToolStripMenuItem.Text = "Search"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Enabled = False
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(40, 27)
        Me.ToolStripMenuItem3.Text = "||"
        '
        'RemovalToolStripMenuItem6
        '
        Me.RemovalToolStripMenuItem6.Image = CType(resources.GetObject("RemovalToolStripMenuItem6.Image"), System.Drawing.Image)
        Me.RemovalToolStripMenuItem6.Name = "RemovalToolStripMenuItem6"
        Me.RemovalToolStripMenuItem6.Size = New System.Drawing.Size(104, 27)
        Me.RemovalToolStripMenuItem6.Text = "Removal"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Enabled = False
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(40, 27)
        Me.ToolStripMenuItem7.Text = "||"
        '
        'UserManagementToolStripMenuItem
        '
        Me.UserManagementToolStripMenuItem.Image = CType(resources.GetObject("UserManagementToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UserManagementToolStripMenuItem.Name = "UserManagementToolStripMenuItem"
        Me.UserManagementToolStripMenuItem.Size = New System.Drawing.Size(82, 27)
        Me.UserManagementToolStripMenuItem.Text = "Users"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Enabled = False
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(40, 27)
        Me.ToolStripMenuItem4.Text = "||"
        '
        'TxtQueue
        '
        Me.TxtQueue.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TxtQueue.Name = "TxtQueue"
        Me.TxtQueue.Size = New System.Drawing.Size(50, 27)
        Me.TxtQueue.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem5.ForeColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(81, 27)
        Me.ToolStripMenuItem5.Text = " QUEUE"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.SplitContainer2.Panel1.Controls.Add(Me.SpDMSTotalsC1TrueDBGrid)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(324, 655)
        Me.SplitContainer2.SplitterDistance = 341
        Me.SplitContainer2.TabIndex = 0
        Me.SplitContainer2.TabStop = False
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
        Me.SpDMSTotalsC1TrueDBGrid.BackColor = System.Drawing.Color.White
        Me.SpDMSTotalsC1TrueDBGrid.BorderColor = System.Drawing.Color.GhostWhite
        Me.SpDMSTotalsC1TrueDBGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SpDMSTotalsC1TrueDBGrid.CaptionHeight = 17
        Me.SpDMSTotalsC1TrueDBGrid.DataSource = Me.SpDMSTotalsBindingSource
        Me.SpDMSTotalsC1TrueDBGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpDMSTotalsC1TrueDBGrid.EditDropDown = False
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
        Me.SpDMSTotalsC1TrueDBGrid.RowDivider.Color = System.Drawing.Color.GhostWhite
        Me.SpDMSTotalsC1TrueDBGrid.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.SpDMSTotalsC1TrueDBGrid.RowHeight = 21
        Me.SpDMSTotalsC1TrueDBGrid.RowSubDividerColor = System.Drawing.Color.GhostWhite
        Me.SpDMSTotalsC1TrueDBGrid.Size = New System.Drawing.Size(324, 341)
        Me.SpDMSTotalsC1TrueDBGrid.SplitDividerSize = New System.Drawing.Size(0, 0)
        Me.SpDMSTotalsC1TrueDBGrid.TabIndex = 1
        Me.SpDMSTotalsC1TrueDBGrid.TabStop = False
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
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.AutoScroll = True
        Me.SplitContainer3.Panel1.Controls.Add(Me.SpDMSLogsC1TrueDBGrid)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.AutoScroll = True
        Me.SplitContainer3.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer3.Panel2.Controls.Add(Me.DateTimePicker2)
        Me.SplitContainer3.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.SplitContainer3.Size = New System.Drawing.Size(324, 310)
        Me.SplitContainer3.SplitterDistance = 269
        Me.SplitContainer3.TabIndex = 0
        Me.SplitContainer3.TabStop = False
        '
        'SpDMSLogsC1TrueDBGrid
        '
        Me.SpDMSLogsC1TrueDBGrid.AllowArrows = False
        Me.SpDMSLogsC1TrueDBGrid.AllowColSelect = False
        Me.SpDMSLogsC1TrueDBGrid.AllowFilter = False
        Me.SpDMSLogsC1TrueDBGrid.AllowRowSelect = False
        Me.SpDMSLogsC1TrueDBGrid.AllowSort = False
        Me.SpDMSLogsC1TrueDBGrid.AllowUpdate = False
        Me.SpDMSLogsC1TrueDBGrid.BackColor = System.Drawing.Color.White
        Me.SpDMSLogsC1TrueDBGrid.BorderColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.SpDMSLogsC1TrueDBGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SpDMSLogsC1TrueDBGrid.CaptionHeight = 17
        Me.SpDMSLogsC1TrueDBGrid.DataSource = Me.SpDMSLogsBindingSource
        Me.SpDMSLogsC1TrueDBGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpDMSLogsC1TrueDBGrid.EditDropDown = False
        Me.SpDMSLogsC1TrueDBGrid.ExtendRightColumn = True
        Me.SpDMSLogsC1TrueDBGrid.FlatStyle = C1.Win.C1TrueDBGrid.FlatModeEnum.Flat
        Me.SpDMSLogsC1TrueDBGrid.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpDMSLogsC1TrueDBGrid.GroupByCaption = "Drag a column header here to group by that column"
        Me.SpDMSLogsC1TrueDBGrid.Images.Add(CType(resources.GetObject("SpDMSLogsC1TrueDBGrid.Images"), System.Drawing.Image))
        Me.SpDMSLogsC1TrueDBGrid.Location = New System.Drawing.Point(0, 0)
        Me.SpDMSLogsC1TrueDBGrid.Name = "SpDMSLogsC1TrueDBGrid"
        Me.SpDMSLogsC1TrueDBGrid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.SpDMSLogsC1TrueDBGrid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.SpDMSLogsC1TrueDBGrid.PreviewInfo.ZoomFactor = 75.0R
        Me.SpDMSLogsC1TrueDBGrid.PrintInfo.PageSettings = CType(resources.GetObject("SpDMSLogsC1TrueDBGrid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.SpDMSLogsC1TrueDBGrid.RecordSelectors = False
        Me.SpDMSLogsC1TrueDBGrid.RowDivider.Color = System.Drawing.Color.GhostWhite
        Me.SpDMSLogsC1TrueDBGrid.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.SpDMSLogsC1TrueDBGrid.RowHeight = 28
        Me.SpDMSLogsC1TrueDBGrid.Size = New System.Drawing.Size(324, 269)
        Me.SpDMSLogsC1TrueDBGrid.SplitDividerSize = New System.Drawing.Size(0, 0)
        Me.SpDMSLogsC1TrueDBGrid.TabIndex = 0
        Me.SpDMSLogsC1TrueDBGrid.TabStop = False
        Me.SpDMSLogsC1TrueDBGrid.UseCompatibleTextRendering = False
        Me.SpDMSLogsC1TrueDBGrid.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.System
        Me.SpDMSLogsC1TrueDBGrid.PropBag = resources.GetString("SpDMSLogsC1TrueDBGrid.PropBag")
        '
        'SpDMSLogsBindingSource
        '
        Me.SpDMSLogsBindingSource.DataMember = "spDMSLogs"
        Me.SpDMSLogsBindingSource.DataSource = Me.DMSDataSet
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(174, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "End:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Start:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(210, 7)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(104, 20)
        Me.DateTimePicker2.TabIndex = 6
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(47, 7)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(104, 20)
        Me.DateTimePicker1.TabIndex = 5
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
        Me.TableAdapterManager.DMSLogsTableAdapter = Nothing
        Me.TableAdapterManager.DMSUserTableAdapter = Nothing
        Me.TableAdapterManager.DocsCatalogueTableAdapter = Nothing
        Me.TableAdapterManager.DocsRemovalTableAdapter = Nothing
        Me.TableAdapterManager.DocumentGroupsTableAdapter = Nothing
        Me.TableAdapterManager.DocumentTypesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DMS.DMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SpDMSLogsTableAdapter
        '
        Me.SpDMSLogsTableAdapter.ClearBeforeFill = True
        '
        'SpDMSLogsBindingSource1
        '
        Me.SpDMSLogsBindingSource1.DataMember = "spDMSLogs"
        Me.SpDMSLogsBindingSource1.DataSource = Me.DMSDataSet
        '
        'HelpToolStripMenuItem6
        '
        Me.HelpToolStripMenuItem6.Image = CType(resources.GetObject("HelpToolStripMenuItem6.Image"), System.Drawing.Image)
        Me.HelpToolStripMenuItem6.Name = "HelpToolStripMenuItem6"
        Me.HelpToolStripMenuItem6.Size = New System.Drawing.Size(73, 27)
        Me.HelpToolStripMenuItem6.Text = "Help"
        '
        'FrmMain
        '
        Me.BackgroundColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1229, 687)
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
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.SpDMSTotalsC1TrueDBGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpDMSTotalsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.PerformLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.SpDMSLogsC1TrueDBGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpDMSLogsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpDMSLogsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DMSDataSet As DMSDataSet
    Friend WithEvents SpDMSTotalsBindingSource As BindingSource
    Friend WithEvents SpDMSTotalsTableAdapter As DMSDataSetTableAdapters.spDMSTotalsTableAdapter
    Friend WithEvents TableAdapterManager As DMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabLogin As TabPage
    Friend WithEvents TabMain As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnOK As Button
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents ChkShow As CheckBox
    Friend WithEvents LblUser As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents SpDMSTotalsC1TrueDBGrid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents SpDMSLogsC1TrueDBGrid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents SpDMSLogsBindingSource As BindingSource
    Friend WithEvents SpDMSLogsTableAdapter As DMSDataSetTableAdapters.spDMSLogsTableAdapter
    Friend WithEvents SpDMSLogsBindingSource1 As BindingSource
    Friend WithEvents btnDock As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents IndexFilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents SEARCHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents UserManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents TxtQueue As ToolStripTextBox
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents RemovalToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents HelpToolStripMenuItem6 As ToolStripMenuItem
End Class
