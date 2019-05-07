<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmQuery
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmQuery))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.C1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.AcroPDF = New AxAcroPDFLib.AxAcroPDF()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CHKBatch = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtBatch = New System.Windows.Forms.TextBox()
        Me.CHKScanDate = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DTScanDateTo = New System.Windows.Forms.DateTimePicker()
        Me.DTScanDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.CHKDocType = New System.Windows.Forms.CheckBox()
        Me.CHKDocDate = New System.Windows.Forms.CheckBox()
        Me.CHKBook = New System.Windows.Forms.CheckBox()
        Me.CHKBox = New System.Windows.Forms.CheckBox()
        Me.CHKRack = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBook = New System.Windows.Forms.TextBox()
        Me.TxtBox = New System.Windows.Forms.TextBox()
        Me.TxtRack = New System.Windows.Forms.TextBox()
        Me.DTDocDateTo = New System.Windows.Forms.DateTimePicker()
        Me.DTDocDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.DocumentTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.DocumentTypeLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcroPDF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.C1TrueDBGrid1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.AcroPDF)
        Me.SplitContainer1.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SplitContainer1.Size = New System.Drawing.Size(1240, 741)
        Me.SplitContainer1.SplitterDistance = 253
        Me.SplitContainer1.TabIndex = 0
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.AllowUpdate = False
        Me.C1TrueDBGrid1.AlternatingRows = True
        Me.C1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1TrueDBGrid1.FilterBar = True
        Me.C1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("C1TrueDBGrid1.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75.0R
        Me.C1TrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(1240, 253)
        Me.C1TrueDBGrid1.TabIndex = 0
        Me.C1TrueDBGrid1.UseCompatibleTextRendering = False
        Me.C1TrueDBGrid1.PropBag = resources.GetString("C1TrueDBGrid1.PropBag")
        '
        'AcroPDF
        '
        Me.AcroPDF.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AcroPDF.Enabled = True
        Me.AcroPDF.Location = New System.Drawing.Point(599, 2)
        Me.AcroPDF.Name = "AcroPDF"
        Me.AcroPDF.OcxState = CType(resources.GetObject("AcroPDF.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AcroPDF.Size = New System.Drawing.Size(629, 482)
        Me.AcroPDF.TabIndex = 30
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(599, 479)
        Me.TabControl1.TabIndex = 31
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CHKBatch)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.TxtBatch)
        Me.TabPage1.Controls.Add(Me.CHKScanDate)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.DTScanDateTo)
        Me.TabPage1.Controls.Add(Me.DTScanDateFrom)
        Me.TabPage1.Controls.Add(Me.CHKDocType)
        Me.TabPage1.Controls.Add(Me.CHKDocDate)
        Me.TabPage1.Controls.Add(Me.CHKBook)
        Me.TabPage1.Controls.Add(Me.CHKBox)
        Me.TabPage1.Controls.Add(Me.CHKRack)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TxtBook)
        Me.TabPage1.Controls.Add(Me.TxtBox)
        Me.TabPage1.Controls.Add(Me.TxtRack)
        Me.TabPage1.Controls.Add(Me.DTDocDateTo)
        Me.TabPage1.Controls.Add(Me.DTDocDateFrom)
        Me.TabPage1.Controls.Add(Me.BtnSearch)
        Me.TabPage1.Controls.Add(Me.DocumentTypeComboBox)
        Me.TabPage1.Controls.Add(Me.DocumentTypeLabel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(591, 446)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(591, 446)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CHKBatch
        '
        Me.CHKBatch.AutoSize = True
        Me.CHKBatch.Location = New System.Drawing.Point(43, 149)
        Me.CHKBatch.Name = "CHKBatch"
        Me.CHKBatch.Size = New System.Drawing.Size(15, 14)
        Me.CHKBatch.TabIndex = 87
        Me.CHKBatch.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(64, 145)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 20)
        Me.Label11.TabIndex = 86
        Me.Label11.Text = "Batch No.:"
        '
        'TxtBatch
        '
        Me.TxtBatch.Location = New System.Drawing.Point(191, 142)
        Me.TxtBatch.Name = "TxtBatch"
        Me.TxtBatch.Size = New System.Drawing.Size(157, 26)
        Me.TxtBatch.TabIndex = 85
        '
        'CHKScanDate
        '
        Me.CHKScanDate.AutoSize = True
        Me.CHKScanDate.Location = New System.Drawing.Point(43, 270)
        Me.CHKScanDate.Name = "CHKScanDate"
        Me.CHKScanDate.Size = New System.Drawing.Size(15, 14)
        Me.CHKScanDate.TabIndex = 84
        Me.CHKScanDate.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(109, 293)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 20)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "From:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(311, 293)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 20)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "To:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(64, 266)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 20)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "Scanned Date:"
        '
        'DTScanDateTo
        '
        Me.DTScanDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTScanDateTo.Location = New System.Drawing.Point(346, 290)
        Me.DTScanDateTo.Name = "DTScanDateTo"
        Me.DTScanDateTo.Size = New System.Drawing.Size(129, 26)
        Me.DTScanDateTo.TabIndex = 80
        '
        'DTScanDateFrom
        '
        Me.DTScanDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTScanDateFrom.Location = New System.Drawing.Point(165, 290)
        Me.DTScanDateFrom.Name = "DTScanDateFrom"
        Me.DTScanDateFrom.Size = New System.Drawing.Size(129, 26)
        Me.DTScanDateFrom.TabIndex = 79
        '
        'CHKDocType
        '
        Me.CHKDocType.AutoSize = True
        Me.CHKDocType.Location = New System.Drawing.Point(43, 344)
        Me.CHKDocType.Name = "CHKDocType"
        Me.CHKDocType.Size = New System.Drawing.Size(15, 14)
        Me.CHKDocType.TabIndex = 78
        Me.CHKDocType.UseVisualStyleBackColor = True
        '
        'CHKDocDate
        '
        Me.CHKDocDate.AutoSize = True
        Me.CHKDocDate.Location = New System.Drawing.Point(43, 206)
        Me.CHKDocDate.Name = "CHKDocDate"
        Me.CHKDocDate.Size = New System.Drawing.Size(15, 14)
        Me.CHKDocDate.TabIndex = 77
        Me.CHKDocDate.UseVisualStyleBackColor = True
        '
        'CHKBook
        '
        Me.CHKBook.AutoSize = True
        Me.CHKBook.Location = New System.Drawing.Point(43, 122)
        Me.CHKBook.Name = "CHKBook"
        Me.CHKBook.Size = New System.Drawing.Size(15, 14)
        Me.CHKBook.TabIndex = 76
        Me.CHKBook.UseVisualStyleBackColor = True
        '
        'CHKBox
        '
        Me.CHKBox.AutoSize = True
        Me.CHKBox.Location = New System.Drawing.Point(43, 96)
        Me.CHKBox.Name = "CHKBox"
        Me.CHKBox.Size = New System.Drawing.Size(15, 14)
        Me.CHKBox.TabIndex = 75
        Me.CHKBox.UseVisualStyleBackColor = True
        '
        'CHKRack
        '
        Me.CHKRack.AutoSize = True
        Me.CHKRack.Location = New System.Drawing.Point(43, 70)
        Me.CHKRack.Name = "CHKRack"
        Me.CHKRack.Size = New System.Drawing.Size(15, 14)
        Me.CHKRack.TabIndex = 74
        Me.CHKRack.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(109, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 20)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "From:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 20)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Search by:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(311, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 20)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "To:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(64, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 20)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Document Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Booklet No.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Box No.:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Rack No.:"
        '
        'TxtBook
        '
        Me.TxtBook.Location = New System.Drawing.Point(191, 115)
        Me.TxtBook.Name = "TxtBook"
        Me.TxtBook.Size = New System.Drawing.Size(157, 26)
        Me.TxtBook.TabIndex = 66
        '
        'TxtBox
        '
        Me.TxtBox.Location = New System.Drawing.Point(191, 89)
        Me.TxtBox.Name = "TxtBox"
        Me.TxtBox.Size = New System.Drawing.Size(157, 26)
        Me.TxtBox.TabIndex = 65
        '
        'TxtRack
        '
        Me.TxtRack.Location = New System.Drawing.Point(191, 63)
        Me.TxtRack.Name = "TxtRack"
        Me.TxtRack.Size = New System.Drawing.Size(157, 26)
        Me.TxtRack.TabIndex = 64
        '
        'DTDocDateTo
        '
        Me.DTDocDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTDocDateTo.Location = New System.Drawing.Point(346, 226)
        Me.DTDocDateTo.Name = "DTDocDateTo"
        Me.DTDocDateTo.Size = New System.Drawing.Size(129, 26)
        Me.DTDocDateTo.TabIndex = 63
        '
        'DTDocDateFrom
        '
        Me.DTDocDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTDocDateFrom.Location = New System.Drawing.Point(165, 226)
        Me.DTDocDateFrom.Name = "DTDocDateFrom"
        Me.DTDocDateFrom.Size = New System.Drawing.Size(129, 26)
        Me.DTDocDateFrom.TabIndex = 62
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(419, 396)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(160, 38)
        Me.BtnSearch.TabIndex = 61
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'DocumentTypeComboBox
        '
        Me.DocumentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DocumentTypeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentTypeComboBox.FormattingEnabled = True
        Me.DocumentTypeComboBox.Location = New System.Drawing.Point(195, 337)
        Me.DocumentTypeComboBox.Name = "DocumentTypeComboBox"
        Me.DocumentTypeComboBox.Size = New System.Drawing.Size(384, 28)
        Me.DocumentTypeComboBox.TabIndex = 60
        '
        'DocumentTypeLabel
        '
        Me.DocumentTypeLabel.AutoSize = True
        Me.DocumentTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentTypeLabel.Location = New System.Drawing.Point(64, 340)
        Me.DocumentTypeLabel.Name = "DocumentTypeLabel"
        Me.DocumentTypeLabel.Size = New System.Drawing.Size(125, 20)
        Me.DocumentTypeLabel.TabIndex = 59
        Me.DocumentTypeLabel.Text = "Document Type:"
        '
        'FrmQuery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1240, 741)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmQuery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmQuery"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcroPDF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents C1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents AcroPDF As AxAcroPDFLib.AxAcroPDF

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents CHKBatch As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtBatch As TextBox
    Friend WithEvents CHKScanDate As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DTScanDateTo As DateTimePicker
    Friend WithEvents DTScanDateFrom As DateTimePicker
    Friend WithEvents CHKDocType As CheckBox
    Friend WithEvents CHKDocDate As CheckBox
    Friend WithEvents CHKBook As CheckBox
    Friend WithEvents CHKBox As CheckBox
    Friend WithEvents CHKRack As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBook As TextBox
    Friend WithEvents TxtBox As TextBox
    Friend WithEvents TxtRack As TextBox
    Friend WithEvents DTDocDateTo As DateTimePicker
    Friend WithEvents DTDocDateFrom As DateTimePicker
    Friend WithEvents BtnSearch As Button
    Friend WithEvents DocumentTypeComboBox As ComboBox
    Friend WithEvents DocumentTypeLabel As Label
    Friend WithEvents TabPage2 As TabPage
End Class
