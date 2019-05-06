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

    Friend WithEvents DocumentTypeLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmQuery))
        Me.DocumentTypeLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.C1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.CHKBatch = New System.Windows.Forms.CheckBox()
        Me.TxtBatch = New System.Windows.Forms.TextBox()
        Me.CHKScanDate = New System.Windows.Forms.CheckBox()
        Me.DTScanDateTo = New System.Windows.Forms.DateTimePicker()
        Me.DTScanDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.CHKDocType = New System.Windows.Forms.CheckBox()
        Me.CHKDocDate = New System.Windows.Forms.CheckBox()
        Me.CHKBook = New System.Windows.Forms.CheckBox()
        Me.CHKBox = New System.Windows.Forms.CheckBox()
        Me.CHKRack = New System.Windows.Forms.CheckBox()
        Me.TxtBook = New System.Windows.Forms.TextBox()
        Me.TxtBox = New System.Windows.Forms.TextBox()
        Me.TxtRack = New System.Windows.Forms.TextBox()
        Me.DTDocDateTo = New System.Windows.Forms.DateTimePicker()
        Me.DTDocDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.AcroPDF = New AxAcroPDFLib.AxAcroPDF()
        Me.DocumentTypeComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcroPDF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DocumentTypeLabel
        '
        Me.DocumentTypeLabel.AutoSize = True
        Me.DocumentTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentTypeLabel.Location = New System.Drawing.Point(65, 344)
        Me.DocumentTypeLabel.Name = "DocumentTypeLabel"
        Me.DocumentTypeLabel.Size = New System.Drawing.Size(125, 20)
        Me.DocumentTypeLabel.TabIndex = 27
        Me.DocumentTypeLabel.Text = "Document Type:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Rack No.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Box No.:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Booklet No.:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(65, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 20)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Document Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(312, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 20)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "To:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 20)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Search by:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(110, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 20)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "From:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(110, 297)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 20)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "From:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(312, 297)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 20)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "To:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(65, 270)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 20)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Scanned Date:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(65, 149)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 20)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Batch No.:"
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.CHKBatch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TxtBatch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CHKScanDate)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DTScanDateTo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DTScanDateFrom)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CHKDocType)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CHKDocDate)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CHKBook)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CHKBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CHKRack)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TxtBook)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TxtBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TxtRack)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DTDocDateTo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DTDocDateFrom)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.AcroPDF)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DocumentTypeComboBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DocumentTypeLabel)
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
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(1240, 253)
        Me.C1TrueDBGrid1.TabIndex = 0
        Me.C1TrueDBGrid1.UseCompatibleTextRendering = False
        Me.C1TrueDBGrid1.PropBag = resources.GetString("C1TrueDBGrid1.PropBag")
        '
        'CHKBatch
        '
        Me.CHKBatch.AutoSize = True
        Me.CHKBatch.Location = New System.Drawing.Point(44, 153)
        Me.CHKBatch.Name = "CHKBatch"
        Me.CHKBatch.Size = New System.Drawing.Size(15, 14)
        Me.CHKBatch.TabIndex = 58
        Me.CHKBatch.UseVisualStyleBackColor = True
        '
        'TxtBatch
        '
        Me.TxtBatch.Location = New System.Drawing.Point(192, 146)
        Me.TxtBatch.Name = "TxtBatch"
        Me.TxtBatch.Size = New System.Drawing.Size(157, 26)
        Me.TxtBatch.TabIndex = 56
        '
        'CHKScanDate
        '
        Me.CHKScanDate.AutoSize = True
        Me.CHKScanDate.Location = New System.Drawing.Point(44, 274)
        Me.CHKScanDate.Name = "CHKScanDate"
        Me.CHKScanDate.Size = New System.Drawing.Size(15, 14)
        Me.CHKScanDate.TabIndex = 55
        Me.CHKScanDate.UseVisualStyleBackColor = True
        '
        'DTScanDateTo
        '
        Me.DTScanDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTScanDateTo.Location = New System.Drawing.Point(347, 294)
        Me.DTScanDateTo.Name = "DTScanDateTo"
        Me.DTScanDateTo.Size = New System.Drawing.Size(129, 26)
        Me.DTScanDateTo.TabIndex = 51
        '
        'DTScanDateFrom
        '
        Me.DTScanDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTScanDateFrom.Location = New System.Drawing.Point(166, 294)
        Me.DTScanDateFrom.Name = "DTScanDateFrom"
        Me.DTScanDateFrom.Size = New System.Drawing.Size(129, 26)
        Me.DTScanDateFrom.TabIndex = 50
        '
        'CHKDocType
        '
        Me.CHKDocType.AutoSize = True
        Me.CHKDocType.Location = New System.Drawing.Point(44, 348)
        Me.CHKDocType.Name = "CHKDocType"
        Me.CHKDocType.Size = New System.Drawing.Size(15, 14)
        Me.CHKDocType.TabIndex = 49
        Me.CHKDocType.UseVisualStyleBackColor = True
        '
        'CHKDocDate
        '
        Me.CHKDocDate.AutoSize = True
        Me.CHKDocDate.Location = New System.Drawing.Point(44, 210)
        Me.CHKDocDate.Name = "CHKDocDate"
        Me.CHKDocDate.Size = New System.Drawing.Size(15, 14)
        Me.CHKDocDate.TabIndex = 48
        Me.CHKDocDate.UseVisualStyleBackColor = True
        '
        'CHKBook
        '
        Me.CHKBook.AutoSize = True
        Me.CHKBook.Location = New System.Drawing.Point(44, 126)
        Me.CHKBook.Name = "CHKBook"
        Me.CHKBook.Size = New System.Drawing.Size(15, 14)
        Me.CHKBook.TabIndex = 47
        Me.CHKBook.UseVisualStyleBackColor = True
        '
        'CHKBox
        '
        Me.CHKBox.AutoSize = True
        Me.CHKBox.Location = New System.Drawing.Point(44, 100)
        Me.CHKBox.Name = "CHKBox"
        Me.CHKBox.Size = New System.Drawing.Size(15, 14)
        Me.CHKBox.TabIndex = 46
        Me.CHKBox.UseVisualStyleBackColor = True
        '
        'CHKRack
        '
        Me.CHKRack.AutoSize = True
        Me.CHKRack.Location = New System.Drawing.Point(44, 74)
        Me.CHKRack.Name = "CHKRack"
        Me.CHKRack.Size = New System.Drawing.Size(15, 14)
        Me.CHKRack.TabIndex = 45
        Me.CHKRack.UseVisualStyleBackColor = True
        '
        'TxtBook
        '
        Me.TxtBook.Location = New System.Drawing.Point(192, 119)
        Me.TxtBook.Name = "TxtBook"
        Me.TxtBook.Size = New System.Drawing.Size(157, 26)
        Me.TxtBook.TabIndex = 37
        '
        'TxtBox
        '
        Me.TxtBox.Location = New System.Drawing.Point(192, 93)
        Me.TxtBox.Name = "TxtBox"
        Me.TxtBox.Size = New System.Drawing.Size(157, 26)
        Me.TxtBox.TabIndex = 36
        '
        'TxtRack
        '
        Me.TxtRack.Location = New System.Drawing.Point(192, 67)
        Me.TxtRack.Name = "TxtRack"
        Me.TxtRack.Size = New System.Drawing.Size(157, 26)
        Me.TxtRack.TabIndex = 35
        '
        'DTDocDateTo
        '
        Me.DTDocDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTDocDateTo.Location = New System.Drawing.Point(347, 230)
        Me.DTDocDateTo.Name = "DTDocDateTo"
        Me.DTDocDateTo.Size = New System.Drawing.Size(129, 26)
        Me.DTDocDateTo.TabIndex = 34
        '
        'DTDocDateFrom
        '
        Me.DTDocDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTDocDateFrom.Location = New System.Drawing.Point(166, 230)
        Me.DTDocDateFrom.Name = "DTDocDateFrom"
        Me.DTDocDateFrom.Size = New System.Drawing.Size(129, 26)
        Me.DTDocDateFrom.TabIndex = 33
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(420, 400)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(160, 38)
        Me.BtnSearch.TabIndex = 32
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
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
        'DocumentTypeComboBox
        '
        Me.DocumentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DocumentTypeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentTypeComboBox.FormattingEnabled = True
        Me.DocumentTypeComboBox.Location = New System.Drawing.Point(196, 341)
        Me.DocumentTypeComboBox.Name = "DocumentTypeComboBox"
        Me.DocumentTypeComboBox.Size = New System.Drawing.Size(384, 28)
        Me.DocumentTypeComboBox.TabIndex = 28
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
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcroPDF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents DocumentTypeComboBox As ComboBox
    Friend WithEvents C1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents AcroPDF As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TxtBook As TextBox
    Friend WithEvents TxtBox As TextBox
    Friend WithEvents TxtRack As TextBox
    Friend WithEvents DTDocDateTo As DateTimePicker
    Friend WithEvents DTDocDateFrom As DateTimePicker
    Friend WithEvents CHKDocType As CheckBox
    Friend WithEvents CHKDocDate As CheckBox
    Friend WithEvents CHKBook As CheckBox
    Friend WithEvents CHKBox As CheckBox
    Friend WithEvents CHKRack As CheckBox
    Friend WithEvents CHKScanDate As CheckBox
    Friend WithEvents DTScanDateTo As DateTimePicker
    Friend WithEvents DTScanDateFrom As DateTimePicker
    Friend WithEvents CHKBatch As CheckBox
    Friend WithEvents TxtBatch As TextBox

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

    End Sub
End Class
