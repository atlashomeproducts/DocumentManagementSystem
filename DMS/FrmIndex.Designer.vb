<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmIndex
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIndex))
        Dim DocumentTypeLabel As System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Splitter2 = New System.Windows.Forms.Splitter()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RackNoTextbox = New System.Windows.Forms.TextBox()
        Me.BoxNoTextbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SubBatchTextbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.scanDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.batchIdTextBox = New System.Windows.Forms.TextBox()
        Me.BtnIndex = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DocumentTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtPurpose = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        DocumentTypeLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Splitter1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SplitContainer1.Size = New System.Drawing.Size(873, 580)
        Me.SplitContainer1.SplitterDistance = 419
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.ListBox1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Splitter2)
        Me.SplitContainer2.Panel2.Controls.Add(Me.BtnRemove)
        Me.SplitContainer2.Panel2.Controls.Add(Me.BtnBrowse)
        Me.SplitContainer2.Size = New System.Drawing.Size(419, 580)
        Me.SplitContainer2.SplitterDistance = 519
        Me.SplitContainer2.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(0, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(419, 519)
        Me.ListBox1.TabIndex = 1
        '
        'Splitter2
        '
        Me.Splitter2.Location = New System.Drawing.Point(0, 0)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(3, 57)
        Me.Splitter2.TabIndex = 3
        Me.Splitter2.TabStop = False
        '
        'BtnRemove
        '
        Me.BtnRemove.AutoSize = True
        Me.BtnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemove.Location = New System.Drawing.Point(224, 12)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(191, 39)
        Me.BtnRemove.TabIndex = 2
        Me.BtnRemove.Text = "REMOVE"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'BtnBrowse
        '
        Me.BtnBrowse.AutoSize = True
        Me.BtnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBrowse.Location = New System.Drawing.Point(9, 12)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(191, 39)
        Me.BtnBrowse.TabIndex = 0
        Me.BtnBrowse.Text = "BROWSE"
        Me.BtnBrowse.UseVisualStyleBackColor = True
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 580)
        Me.Splitter1.TabIndex = 5
        Me.Splitter1.TabStop = False
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
        Me.SplitContainer3.Panel1.Controls.Add(Me.AxAcroPDF1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label9)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer3.Panel2.Controls.Add(Me.txtPurpose)
        Me.SplitContainer3.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer3.Panel2.Controls.Add(Me.txtCompany)
        Me.SplitContainer3.Panel2.Controls.Add(Me.DocumentTypeComboBox)
        Me.SplitContainer3.Panel2.Controls.Add(DocumentTypeLabel)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer3.Panel2.Controls.Add(Me.RackNoTextbox)
        Me.SplitContainer3.Panel2.Controls.Add(Me.BoxNoTextbox)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer3.Panel2.Controls.Add(Me.SubBatchTextbox)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer3.Panel2.Controls.Add(Me.scanDateTimePicker)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer3.Panel2.Controls.Add(Me.batchIdTextBox)
        Me.SplitContainer3.Panel2.Controls.Add(Me.BtnIndex)
        Me.SplitContainer3.Size = New System.Drawing.Size(450, 580)
        Me.SplitContainer3.SplitterDistance = 332
        Me.SplitContainer3.TabIndex = 16
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(0, 0)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(450, 332)
        Me.AxAcroPDF1.TabIndex = 8
        Me.AxAcroPDF1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, -388)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Preview"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 16)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Rack No.:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 16)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Box No.:"
        '
        'RackNoTextbox
        '
        Me.RackNoTextbox.Location = New System.Drawing.Point(126, 211)
        Me.RackNoTextbox.Name = "RackNoTextbox"
        Me.RackNoTextbox.Size = New System.Drawing.Size(106, 22)
        Me.RackNoTextbox.TabIndex = 23
        '
        'BoxNoTextbox
        '
        Me.BoxNoTextbox.Location = New System.Drawing.Point(126, 187)
        Me.BoxNoTextbox.Name = "BoxNoTextbox"
        Me.BoxNoTextbox.Size = New System.Drawing.Size(106, 22)
        Me.BoxNoTextbox.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Location = New System.Drawing.Point(4, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 19)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Sub Batch Name:*"
        '
        'SubBatchTextbox
        '
        Me.SubBatchTextbox.Location = New System.Drawing.Point(126, 141)
        Me.SubBatchTextbox.Name = "SubBatchTextbox"
        Me.SubBatchTextbox.Size = New System.Drawing.Size(315, 22)
        Me.SubBatchTextbox.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Scanned Date:*"
        '
        'scanDateTimePicker
        '
        Me.scanDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.scanDateTimePicker.Location = New System.Drawing.Point(126, 164)
        Me.scanDateTimePicker.Name = "scanDateTimePicker"
        Me.scanDateTimePicker.Size = New System.Drawing.Size(185, 22)
        Me.scanDateTimePicker.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Batch Name:*"
        '
        'batchIdTextBox
        '
        Me.batchIdTextBox.Location = New System.Drawing.Point(126, 99)
        Me.batchIdTextBox.Multiline = True
        Me.batchIdTextBox.Name = "batchIdTextBox"
        Me.batchIdTextBox.Size = New System.Drawing.Size(315, 42)
        Me.batchIdTextBox.TabIndex = 17
        '
        'BtnIndex
        '
        Me.BtnIndex.Location = New System.Drawing.Point(292, 199)
        Me.BtnIndex.Name = "BtnIndex"
        Me.BtnIndex.Size = New System.Drawing.Size(149, 38)
        Me.BtnIndex.TabIndex = 26
        Me.BtnIndex.Text = "INDEX FILES"
        Me.BtnIndex.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DocumentTypeComboBox
        '
        Me.DocumentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DocumentTypeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentTypeComboBox.FormattingEnabled = True
        Me.DocumentTypeComboBox.Location = New System.Drawing.Point(126, 5)
        Me.DocumentTypeComboBox.Name = "DocumentTypeComboBox"
        Me.DocumentTypeComboBox.Size = New System.Drawing.Size(315, 24)
        Me.DocumentTypeComboBox.TabIndex = 31
        '
        'DocumentTypeLabel
        '
        DocumentTypeLabel.AutoSize = True
        DocumentTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DocumentTypeLabel.Location = New System.Drawing.Point(4, 8)
        DocumentTypeLabel.Name = "DocumentTypeLabel"
        DocumentTypeLabel.Size = New System.Drawing.Size(112, 16)
        DocumentTypeLabel.TabIndex = 30
        DocumentTypeLabel.Text = "Document Type:*"
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(126, 31)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(315, 22)
        Me.txtCompany.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 16)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Company Name:*"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyyMMMdd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(126, 54)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(185, 22)
        Me.DateTimePicker1.TabIndex = 34
        '
        'txtPurpose
        '
        Me.txtPurpose.Location = New System.Drawing.Point(126, 77)
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Size = New System.Drawing.Size(315, 22)
        Me.txtPurpose.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 16)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Date:*"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 16)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Purpose:*"
        '
        'FrmIndex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(873, 580)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmIndex"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INDEX"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.PerformLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents BtnBrowse As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents BtnRemove As Button
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents RackNoTextbox As TextBox
    Friend WithEvents BoxNoTextbox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SubBatchTextbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents scanDateTimePicker As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents batchIdTextBox As TextBox
    Friend WithEvents Splitter2 As Splitter
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents BtnIndex As Button
    Friend WithEvents DocumentTypeComboBox As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPurpose As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCompany As TextBox
End Class
