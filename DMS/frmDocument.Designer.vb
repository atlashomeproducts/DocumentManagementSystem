<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocument
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocument))
        Dim Style11 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style12 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style13 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style14 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style15 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style16 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style17 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style18 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style19 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style20 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.DocumentTypesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.DocumentTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DMSDataSet = New DMS.DMSDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DocumentTypesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DocumentTypesC1TrueDBGrid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.DocumentTypesTableAdapter = New DMS.DMSDataSetTableAdapters.DocumentTypesTableAdapter()
        Me.TableAdapterManager = New DMS.DMSDataSetTableAdapters.TableAdapterManager()
        Me.C1TrueDBDropdown1 = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.DocumentGroupsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DocumentGroupsTableAdapter = New DMS.DMSDataSetTableAdapters.DocumentGroupsTableAdapter()
        CType(Me.DocumentTypesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentTypesBindingNavigator.SuspendLayout()
        CType(Me.DocumentTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentTypesC1TrueDBGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TrueDBDropdown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentGroupsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DocumentTypesBindingNavigator
        '
        Me.DocumentTypesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DocumentTypesBindingNavigator.BindingSource = Me.DocumentTypesBindingSource
        Me.DocumentTypesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DocumentTypesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DocumentTypesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DocumentTypesBindingNavigatorSaveItem})
        Me.DocumentTypesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DocumentTypesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DocumentTypesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DocumentTypesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DocumentTypesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DocumentTypesBindingNavigator.Name = "DocumentTypesBindingNavigator"
        Me.DocumentTypesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DocumentTypesBindingNavigator.Size = New System.Drawing.Size(532, 25)
        Me.DocumentTypesBindingNavigator.TabIndex = 0
        Me.DocumentTypesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'DocumentTypesBindingSource
        '
        Me.DocumentTypesBindingSource.DataMember = "DocumentTypes"
        Me.DocumentTypesBindingSource.DataSource = Me.DMSDataSet
        '
        'DMSDataSet
        '
        Me.DMSDataSet.DataSetName = "DMSDataSet"
        Me.DMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'DocumentTypesBindingNavigatorSaveItem
        '
        Me.DocumentTypesBindingNavigatorSaveItem.Image = CType(resources.GetObject("DocumentTypesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DocumentTypesBindingNavigatorSaveItem.Name = "DocumentTypesBindingNavigatorSaveItem"
        Me.DocumentTypesBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.DocumentTypesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DocumentTypesC1TrueDBGrid
        '
        Me.DocumentTypesC1TrueDBGrid.AllowAddNew = True
        Me.DocumentTypesC1TrueDBGrid.AllowDelete = True
        Me.DocumentTypesC1TrueDBGrid.DataSource = Me.DocumentTypesBindingSource
        Me.DocumentTypesC1TrueDBGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DocumentTypesC1TrueDBGrid.ExtendRightColumn = True
        Me.DocumentTypesC1TrueDBGrid.FilterBar = True
        Me.DocumentTypesC1TrueDBGrid.GroupByCaption = "Drag a column header here to group by that column"
        Me.DocumentTypesC1TrueDBGrid.Images.Add(CType(resources.GetObject("DocumentTypesC1TrueDBGrid.Images"), System.Drawing.Image))
        Me.DocumentTypesC1TrueDBGrid.Location = New System.Drawing.Point(0, 25)
        Me.DocumentTypesC1TrueDBGrid.Name = "DocumentTypesC1TrueDBGrid"
        Me.DocumentTypesC1TrueDBGrid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DocumentTypesC1TrueDBGrid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DocumentTypesC1TrueDBGrid.PreviewInfo.ZoomFactor = 75.0R
        Me.DocumentTypesC1TrueDBGrid.PrintInfo.PageSettings = CType(resources.GetObject("DocumentTypesC1TrueDBGrid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DocumentTypesC1TrueDBGrid.Size = New System.Drawing.Size(532, 406)
        Me.DocumentTypesC1TrueDBGrid.TabIndex = 1
        Me.DocumentTypesC1TrueDBGrid.UseCompatibleTextRendering = False
        Me.DocumentTypesC1TrueDBGrid.PropBag = resources.GetString("DocumentTypesC1TrueDBGrid.PropBag")
        '
        'DocumentTypesTableAdapter
        '
        Me.DocumentTypesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DocsCatalogueTableAdapter = Nothing
        Me.TableAdapterManager.DocumentGroupsTableAdapter = Nothing
        Me.TableAdapterManager.DocumentTypesTableAdapter = Me.DocumentTypesTableAdapter
        Me.TableAdapterManager.UpdateOrder = DMS.DMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'C1TrueDBDropdown1
        '
        Me.C1TrueDBDropdown1.AllowColMove = True
        Me.C1TrueDBDropdown1.AllowColSelect = True
        Me.C1TrueDBDropdown1.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.C1TrueDBDropdown1.AlternatingRows = False
        Me.C1TrueDBDropdown1.CaptionStyle = Style11
        Me.C1TrueDBDropdown1.ColumnCaptionHeight = 17
        Me.C1TrueDBDropdown1.ColumnFooterHeight = 17
        Me.C1TrueDBDropdown1.ColumnSelectorStyle = Style12
        Me.C1TrueDBDropdown1.DataSource = Me.DocumentGroupsBindingSource
        Me.C1TrueDBDropdown1.DisplayMember = "DocumentGroup"
        Me.C1TrueDBDropdown1.EvenRowStyle = Style13
        Me.C1TrueDBDropdown1.FetchRowStyles = False
        Me.C1TrueDBDropdown1.FooterStyle = Style14
        Me.C1TrueDBDropdown1.HeadingStyle = Style15
        Me.C1TrueDBDropdown1.HighLightRowStyle = Style16
        Me.C1TrueDBDropdown1.Images.Add(CType(resources.GetObject("C1TrueDBDropdown1.Images"), System.Drawing.Image))
        Me.C1TrueDBDropdown1.Location = New System.Drawing.Point(198, 135)
        Me.C1TrueDBDropdown1.Name = "C1TrueDBDropdown1"
        Me.C1TrueDBDropdown1.OddRowStyle = Style17
        Me.C1TrueDBDropdown1.RecordSelectorStyle = Style18
        Me.C1TrueDBDropdown1.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1TrueDBDropdown1.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.C1TrueDBDropdown1.RowSelectorStyle = Style19
        Me.C1TrueDBDropdown1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1TrueDBDropdown1.ScrollTips = False
        Me.C1TrueDBDropdown1.Size = New System.Drawing.Size(310, 225)
        Me.C1TrueDBDropdown1.Style = Style20
        Me.C1TrueDBDropdown1.TabIndex = 2
        Me.C1TrueDBDropdown1.TabStop = False
        Me.C1TrueDBDropdown1.UseCompatibleTextRendering = False
        Me.C1TrueDBDropdown1.Visible = False
        Me.C1TrueDBDropdown1.PropBag = resources.GetString("C1TrueDBDropdown1.PropBag")
        '
        'DocumentGroupsBindingSource
        '
        Me.DocumentGroupsBindingSource.DataMember = "DocumentGroups"
        Me.DocumentGroupsBindingSource.DataSource = Me.DMSDataSet
        '
        'DocumentGroupsTableAdapter
        '
        Me.DocumentGroupsTableAdapter.ClearBeforeFill = True
        '
        'frmDocument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 431)
        Me.Controls.Add(Me.C1TrueDBDropdown1)
        Me.Controls.Add(Me.DocumentTypesC1TrueDBGrid)
        Me.Controls.Add(Me.DocumentTypesBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDocument"
        Me.Text = "Document Types"
        CType(Me.DocumentTypesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentTypesBindingNavigator.ResumeLayout(False)
        Me.DocumentTypesBindingNavigator.PerformLayout()
        CType(Me.DocumentTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentTypesC1TrueDBGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TrueDBDropdown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentGroupsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DMSDataSet As DMSDataSet
    Friend WithEvents DocumentTypesBindingSource As BindingSource
    Friend WithEvents DocumentTypesTableAdapter As DMSDataSetTableAdapters.DocumentTypesTableAdapter
    Friend WithEvents TableAdapterManager As DMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DocumentTypesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents DocumentTypesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DocumentTypesC1TrueDBGrid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1TrueDBDropdown1 As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents DocumentGroupsBindingSource As BindingSource
    Friend WithEvents DocumentGroupsTableAdapter As DMSDataSetTableAdapters.DocumentGroupsTableAdapter
End Class
