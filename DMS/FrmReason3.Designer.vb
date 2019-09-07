<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReason3
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblID = New System.Windows.Forms.Label()
        Me.TxtOthers = New System.Windows.Forms.TextBox()
        Me.ChkOthers = New System.Windows.Forms.CheckBox()
        Me.ChkNotArchiving = New System.Windows.Forms.CheckBox()
        Me.ChkOlder = New System.Windows.Forms.CheckBox()
        Me.ChkDuplicate = New System.Windows.Forms.CheckBox()
        Me.TxtDupID = New System.Windows.Forms.TextBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnConfirm = New System.Windows.Forms.Button()
        Me.DMSDataSet = New DMS.DMSDataSet()
        Me.DocsRemovalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New DMS.DMSDataSetTableAdapters.TableAdapterManager()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocsRemovalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Azure
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtOthers)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ChkOthers)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ChkNotArchiving)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ChkOlder)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ChkDuplicate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtDupID)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.Azure
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnCancel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnConfirm)
        Me.SplitContainer1.Size = New System.Drawing.Size(552, 215)
        Me.SplitContainer1.SplitterDistance = 172
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LblID)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 40)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(370, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Check Reason/s for Removal of Selected Document."
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblID.Location = New System.Drawing.Point(488, 14)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(0, 16)
        Me.LblID.TabIndex = 1
        '
        'TxtOthers
        '
        Me.TxtOthers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOthers.Location = New System.Drawing.Point(46, 145)
        Me.TxtOthers.Name = "TxtOthers"
        Me.TxtOthers.Size = New System.Drawing.Size(494, 22)
        Me.TxtOthers.TabIndex = 6
        '
        'ChkOthers
        '
        Me.ChkOthers.AutoSize = True
        Me.ChkOthers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkOthers.Location = New System.Drawing.Point(25, 125)
        Me.ChkOthers.Name = "ChkOthers"
        Me.ChkOthers.Size = New System.Drawing.Size(288, 20)
        Me.ChkOthers.TabIndex = 5
        Me.ChkOthers.Text = "Others (Specify reason, up to 70 characters.)"
        Me.ChkOthers.UseVisualStyleBackColor = True
        '
        'ChkNotArchiving
        '
        Me.ChkNotArchiving.AutoSize = True
        Me.ChkNotArchiving.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkNotArchiving.Location = New System.Drawing.Point(25, 99)
        Me.ChkNotArchiving.Name = "ChkNotArchiving"
        Me.ChkNotArchiving.Size = New System.Drawing.Size(200, 20)
        Me.ChkNotArchiving.TabIndex = 4
        Me.ChkNotArchiving.Text = "Document is not for archiving."
        Me.ChkNotArchiving.UseVisualStyleBackColor = True
        '
        'ChkOlder
        '
        Me.ChkOlder.AutoSize = True
        Me.ChkOlder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkOlder.Location = New System.Drawing.Point(25, 75)
        Me.ChkOlder.Name = "ChkOlder"
        Me.ChkOlder.Size = New System.Drawing.Size(130, 20)
        Me.ChkOlder.TabIndex = 3
        Me.ChkOlder.Text = "10 years or older."
        Me.ChkOlder.UseVisualStyleBackColor = True
        '
        'ChkDuplicate
        '
        Me.ChkDuplicate.AutoSize = True
        Me.ChkDuplicate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkDuplicate.Location = New System.Drawing.Point(25, 51)
        Me.ChkDuplicate.Name = "ChkDuplicate"
        Me.ChkDuplicate.Size = New System.Drawing.Size(225, 20)
        Me.ChkDuplicate.TabIndex = 2
        Me.ChkDuplicate.Text = "Duplicate copy of Document No. :"
        Me.ChkDuplicate.UseVisualStyleBackColor = True
        '
        'TxtDupID
        '
        Me.TxtDupID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDupID.Location = New System.Drawing.Point(256, 49)
        Me.TxtDupID.Name = "TxtDupID"
        Me.TxtDupID.Size = New System.Drawing.Size(281, 22)
        Me.TxtDupID.TabIndex = 0
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Location = New System.Drawing.Point(458, 4)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(87, 30)
        Me.BtnCancel.TabIndex = 1
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnConfirm
        '
        Me.BtnConfirm.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnConfirm.Location = New System.Drawing.Point(363, 4)
        Me.BtnConfirm.Name = "BtnConfirm"
        Me.BtnConfirm.Size = New System.Drawing.Size(87, 30)
        Me.BtnConfirm.TabIndex = 0
        Me.BtnConfirm.Text = "Confirm"
        Me.BtnConfirm.UseVisualStyleBackColor = False
        '
        'DMSDataSet
        '
        Me.DMSDataSet.DataSetName = "DMSDataSet"
        Me.DMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DocsRemovalBindingSource
        '
        Me.DocsRemovalBindingSource.DataMember = "DocsRemoval"
        Me.DocsRemovalBindingSource.DataSource = Me.DMSDataSet
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
        'FrmReason3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 215)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmReason3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Removal Reason"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocsRemovalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnConfirm As Button
    Friend WithEvents DMSDataSet As DMSDataSet
    Friend WithEvents DocsRemovalBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As DMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TxtOthers As TextBox
    Friend WithEvents ChkOthers As CheckBox
    Friend WithEvents ChkNotArchiving As CheckBox
    Friend WithEvents ChkOlder As CheckBox
    Friend WithEvents ChkDuplicate As CheckBox
    Friend WithEvents LblID As Label
    Friend WithEvents TxtDupID As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
End Class
