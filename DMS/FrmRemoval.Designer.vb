<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRemoval
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRemoval))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.VwRemovalC1TrueDBGrid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.VwRemovalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DMSDataSet = New DMS.DMSDataSet()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.SpForRemovalC1TrueDBGrid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.SpForRemovalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnRestore = New System.Windows.Forms.Button()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.BtnDeselectAll = New System.Windows.Forms.Button()
        Me.BtnSelectAll = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New DMS.DMSDataSetTableAdapters.TableAdapterManager()
        Me.VwRemovalTableAdapter = New DMS.DMSDataSetTableAdapters.vwRemovalTableAdapter()
        Me.SpForRemovalTableAdapter = New DMS.DMSDataSetTableAdapters.spForRemovalTableAdapter()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.VwRemovalC1TrueDBGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwRemovalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.SpForRemovalC1TrueDBGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpForRemovalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Azure
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.AxAcroPDF1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1039, 577)
        Me.SplitContainer1.SplitterDistance = 547
        Me.SplitContainer1.TabIndex = 0
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.VwRemovalC1TrueDBGrid)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(547, 577)
        Me.SplitContainer2.SplitterDistance = 255
        Me.SplitContainer2.TabIndex = 0
        '
        'VwRemovalC1TrueDBGrid
        '
        Me.VwRemovalC1TrueDBGrid.DataSource = Me.VwRemovalBindingSource
        Me.VwRemovalC1TrueDBGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VwRemovalC1TrueDBGrid.ExtendRightColumn = True
        Me.VwRemovalC1TrueDBGrid.GroupByCaption = "Drag a column header here to group by that column"
        Me.VwRemovalC1TrueDBGrid.Images.Add(CType(resources.GetObject("VwRemovalC1TrueDBGrid.Images"), System.Drawing.Image))
        Me.VwRemovalC1TrueDBGrid.Location = New System.Drawing.Point(0, 0)
        Me.VwRemovalC1TrueDBGrid.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.VwRemovalC1TrueDBGrid.Name = "VwRemovalC1TrueDBGrid"
        Me.VwRemovalC1TrueDBGrid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.VwRemovalC1TrueDBGrid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.VwRemovalC1TrueDBGrid.PreviewInfo.ZoomFactor = 75.0R
        Me.VwRemovalC1TrueDBGrid.PrintInfo.PageSettings = CType(resources.GetObject("VwRemovalC1TrueDBGrid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.VwRemovalC1TrueDBGrid.RowHeight = 18
        Me.VwRemovalC1TrueDBGrid.Size = New System.Drawing.Size(547, 255)
        Me.VwRemovalC1TrueDBGrid.TabIndex = 0
        Me.VwRemovalC1TrueDBGrid.UseCompatibleTextRendering = False
        Me.VwRemovalC1TrueDBGrid.PropBag = resources.GetString("VwRemovalC1TrueDBGrid.PropBag")
        '
        'VwRemovalBindingSource
        '
        Me.VwRemovalBindingSource.DataMember = "vwRemoval"
        Me.VwRemovalBindingSource.DataSource = Me.DMSDataSet
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
        Me.SplitContainer3.Panel1.Controls.Add(Me.SpForRemovalC1TrueDBGrid)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.AutoScroll = True
        Me.SplitContainer3.Panel2.Controls.Add(Me.BtnRestore)
        Me.SplitContainer3.Panel2.Controls.Add(Me.IdTextBox)
        Me.SplitContainer3.Panel2.Controls.Add(Me.BtnDeselectAll)
        Me.SplitContainer3.Panel2.Controls.Add(Me.BtnSelectAll)
        Me.SplitContainer3.Panel2.Controls.Add(Me.BtnDelete)
        Me.SplitContainer3.Size = New System.Drawing.Size(547, 318)
        Me.SplitContainer3.SplitterDistance = 265
        Me.SplitContainer3.TabIndex = 0
        '
        'SpForRemovalC1TrueDBGrid
        '
        Me.SpForRemovalC1TrueDBGrid.AllowUpdate = False
        Me.SpForRemovalC1TrueDBGrid.DataSource = Me.SpForRemovalBindingSource
        Me.SpForRemovalC1TrueDBGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpForRemovalC1TrueDBGrid.ExtendRightColumn = True
        Me.SpForRemovalC1TrueDBGrid.GroupByCaption = "Drag a column header here to group by that column"
        Me.SpForRemovalC1TrueDBGrid.Images.Add(CType(resources.GetObject("SpForRemovalC1TrueDBGrid.Images"), System.Drawing.Image))
        Me.SpForRemovalC1TrueDBGrid.Location = New System.Drawing.Point(0, 0)
        Me.SpForRemovalC1TrueDBGrid.Name = "SpForRemovalC1TrueDBGrid"
        Me.SpForRemovalC1TrueDBGrid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.SpForRemovalC1TrueDBGrid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.SpForRemovalC1TrueDBGrid.PreviewInfo.ZoomFactor = 75.0R
        Me.SpForRemovalC1TrueDBGrid.PrintInfo.PageSettings = CType(resources.GetObject("SpForRemovalC1TrueDBGrid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.SpForRemovalC1TrueDBGrid.RowHeight = 17
        Me.SpForRemovalC1TrueDBGrid.Size = New System.Drawing.Size(547, 265)
        Me.SpForRemovalC1TrueDBGrid.TabIndex = 0
        Me.SpForRemovalC1TrueDBGrid.UseCompatibleTextRendering = False
        Me.SpForRemovalC1TrueDBGrid.PropBag = resources.GetString("SpForRemovalC1TrueDBGrid.PropBag")
        '
        'SpForRemovalBindingSource
        '
        Me.SpForRemovalBindingSource.DataMember = "spForRemoval"
        Me.SpForRemovalBindingSource.DataSource = Me.DMSDataSet
        '
        'BtnRestore
        '
        Me.BtnRestore.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRestore.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRestore.Location = New System.Drawing.Point(108, 8)
        Me.BtnRestore.Name = "BtnRestore"
        Me.BtnRestore.Size = New System.Drawing.Size(95, 32)
        Me.BtnRestore.TabIndex = 5
        Me.BtnRestore.Text = "Restore Selected"
        Me.BtnRestore.UseVisualStyleBackColor = False
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwRemovalBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(310, 15)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(32, 20)
        Me.IdTextBox.TabIndex = 4
        '
        'BtnDeselectAll
        '
        Me.BtnDeselectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDeselectAll.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnDeselectAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDeselectAll.Location = New System.Drawing.Point(449, 8)
        Me.BtnDeselectAll.Name = "BtnDeselectAll"
        Me.BtnDeselectAll.Size = New System.Drawing.Size(95, 32)
        Me.BtnDeselectAll.TabIndex = 2
        Me.BtnDeselectAll.Text = "Deselect All"
        Me.BtnDeselectAll.UseVisualStyleBackColor = False
        '
        'BtnSelectAll
        '
        Me.BtnSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSelectAll.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSelectAll.Location = New System.Drawing.Point(350, 8)
        Me.BtnSelectAll.Name = "BtnSelectAll"
        Me.BtnSelectAll.Size = New System.Drawing.Size(95, 32)
        Me.BtnSelectAll.TabIndex = 1
        Me.BtnSelectAll.Text = "Select All"
        Me.BtnSelectAll.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDelete.Location = New System.Drawing.Point(9, 8)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(95, 32)
        Me.BtnDelete.TabIndex = 0
        Me.BtnDelete.Text = "Delete Selected"
        Me.BtnDelete.UseVisualStyleBackColor = False
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
        'VwRemovalTableAdapter
        '
        Me.VwRemovalTableAdapter.ClearBeforeFill = True
        '
        'SpForRemovalTableAdapter
        '
        Me.SpForRemovalTableAdapter.ClearBeforeFill = True
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(0, 0)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(488, 577)
        Me.AxAcroPDF1.TabIndex = 0
        '
        'FrmRemoval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1039, 577)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRemoval"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Documents for Removal"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.VwRemovalC1TrueDBGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwRemovalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.PerformLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.SpForRemovalC1TrueDBGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpForRemovalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents DMSDataSet As DMSDataSet
    Friend WithEvents TableAdapterManager As DMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VwRemovalC1TrueDBGrid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents SpForRemovalC1TrueDBGrid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents BtnDeselectAll As Button
    Friend WithEvents BtnSelectAll As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents VwRemovalBindingSource As BindingSource
    Friend WithEvents VwRemovalTableAdapter As DMSDataSetTableAdapters.vwRemovalTableAdapter
    Friend WithEvents SpForRemovalBindingSource As BindingSource
    Friend WithEvents SpForRemovalTableAdapter As DMSDataSetTableAdapters.spForRemovalTableAdapter
    Friend WithEvents BtnRestore As Button
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
End Class
