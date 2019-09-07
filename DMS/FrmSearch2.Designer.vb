Imports System.Data.SqlClient

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSearch2
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim DocSizeLabel As System.Windows.Forms.Label
        Dim SubBatchLabel As System.Windows.Forms.Label
        Dim BatchLabel As System.Windows.Forms.Label
        Dim PagesLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSearch2))
        Me.Label25 = New System.Windows.Forms.Label()
        Me.MeetingDateLabel = New System.Windows.Forms.Label()
        Me.SecretaryLabel = New System.Windows.Forms.Label()
        Me.CompanyLabel = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.DTIPermitNoLabel = New System.Windows.Forms.Label()
        Me.PromoToLabel = New System.Windows.Forms.Label()
        Me.PromoFromLabel = New System.Windows.Forms.Label()
        Me.PromoTitleLabel = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.BtnDownload = New System.Windows.Forms.Button()
        Me.BtnSaveChanges1 = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnEditRecord = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabQuery = New System.Windows.Forms.TabPage()
        Me.CHKFileName = New System.Windows.Forms.CheckBox()
        Me.sdasd = New System.Windows.Forms.Label()
        Me.TxtFileName = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.CHKBatch = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtBatch = New System.Windows.Forms.TextBox()
        Me.TxtBook = New System.Windows.Forms.TextBox()
        Me.TxtBox = New System.Windows.Forms.TextBox()
        Me.TxtRack = New System.Windows.Forms.TextBox()
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
        Me.DTDocDateTo = New System.Windows.Forms.DateTimePicker()
        Me.DTDocDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.DocumentTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.DocumentTypeLabel = New System.Windows.Forms.Label()
        Me.TabChanges = New System.Windows.Forms.TabPage()
        Me.txtPages = New System.Windows.Forms.TextBox()
        Me.cbDocSize = New System.Windows.Forms.ComboBox()
        Me.chkConfidential = New System.Windows.Forms.CheckBox()
        Me.SubBatchTextBox = New System.Windows.Forms.TextBox()
        Me.BatchTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.DocumentTypeCombobox2 = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.Timesheet = New System.Windows.Forms.TabPage()
        Me.GrpTimeSheet = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BoxNoTS = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.RackNoTS = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.FromPeriodLabel = New System.Windows.Forms.Label()
        Me.DTToPeriod = New System.Windows.Forms.DateTimePicker()
        Me.FromPeriodTextBox = New System.Windows.Forms.TextBox()
        Me.DTFromPeriod = New System.Windows.Forms.DateTimePicker()
        Me.ToPeriodTextBox = New System.Windows.Forms.TextBox()
        Me.ToPeriodLabel = New System.Windows.Forms.Label()
        Me.MiddleNameLabel = New System.Windows.Forms.Label()
        Me.MiddleNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.DocumentDateTS = New System.Windows.Forms.TextBox()
        Me.DTDocuTimeSheet = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ReceiptInvoice = New System.Windows.Forms.TabPage()
        Me.GrpReceipt = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.NONVATregCheckBox = New System.Windows.Forms.CheckBox()
        Me.VATregCheckBox = New System.Windows.Forms.CheckBox()
        Me.AddressCLabel = New System.Windows.Forms.Label()
        Me.AddressCTextBox = New System.Windows.Forms.TextBox()
        Me.TinCustomerLabel = New System.Windows.Forms.Label()
        Me.TinCustomerTextBox = New System.Windows.Forms.TextBox()
        Me.TinVendorLabel = New System.Windows.Forms.Label()
        Me.TinVendorTextBox = New System.Windows.Forms.TextBox()
        Me.BoxNoLabel = New System.Windows.Forms.Label()
        Me.BoxNoRI = New System.Windows.Forms.TextBox()
        Me.RackNoLabel = New System.Windows.Forms.Label()
        Me.RackNoRI = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DocumentDateRI = New System.Windows.Forms.TextBox()
        Me.TotalValueLabel = New System.Windows.Forms.Label()
        Me.TotalValueRI = New System.Windows.Forms.TextBox()
        Me.ItemPurchasedLabel = New System.Windows.Forms.Label()
        Me.ItemPurchasedTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerLabel = New System.Windows.Forms.Label()
        Me.CustomerTextBox = New System.Windows.Forms.TextBox()
        Me.VendorLabel = New System.Windows.Forms.Label()
        Me.VendorTextBox = New System.Windows.Forms.TextBox()
        Me.BookletNoLabel = New System.Windows.Forms.Label()
        Me.BookletNoTextBox = New System.Windows.Forms.TextBox()
        Me.DTDocuRI = New System.Windows.Forms.DateTimePicker()
        Me.ReferenceNoLabel = New System.Windows.Forms.Label()
        Me.ReferenceNoRI = New System.Windows.Forms.TextBox()
        Me.DocumentDateLabel = New System.Windows.Forms.Label()
        Me.Warranty = New System.Windows.Forms.TabPage()
        Me.GrpWarranty = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.BoxNoWarranty = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.RackNoWarranty = New System.Windows.Forms.TextBox()
        Me.DTDatePurchased = New System.Windows.Forms.DateTimePicker()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.ContactNoLabel = New System.Windows.Forms.Label()
        Me.ContactNoTextBox = New System.Windows.Forms.TextBox()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.ServiceCenterLabel = New System.Windows.Forms.Label()
        Me.ServiceCenterTextBox = New System.Windows.Forms.TextBox()
        Me.WarrantyPeriodLabel = New System.Windows.Forms.Label()
        Me.WarrantyPeriodTextBox = New System.Windows.Forms.TextBox()
        Me.SerialLabel = New System.Windows.Forms.Label()
        Me.SerialTextBox = New System.Windows.Forms.TextBox()
        Me.TotalValueLabel1 = New System.Windows.Forms.Label()
        Me.TotalValueWarranty = New System.Windows.Forms.TextBox()
        Me.ReferenceNoLabel1 = New System.Windows.Forms.Label()
        Me.ReferenceNoTextBox1 = New System.Windows.Forms.TextBox()
        Me.DatePurchasedLabel = New System.Windows.Forms.Label()
        Me.DatePurchasedTextBox = New System.Windows.Forms.TextBox()
        Me.ProductTypeLabel = New System.Windows.Forms.Label()
        Me.ProductTypeTextBox = New System.Windows.Forms.TextBox()
        Me.ProductBrandLabel = New System.Windows.Forms.Label()
        Me.ProductBrandTextBox = New System.Windows.Forms.TextBox()
        Me.WarrantyNoLabel = New System.Windows.Forms.Label()
        Me.WarrantyNoTextBox = New System.Windows.Forms.TextBox()
        Me.Voucher = New System.Windows.Forms.TabPage()
        Me.GrpVoucher = New System.Windows.Forms.GroupBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.DTDateReceived = New System.Windows.Forms.DateTimePicker()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.BoxNoVoucher = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.RackNoVoucher = New System.Windows.Forms.TextBox()
        Me.DateReceivedLabel = New System.Windows.Forms.Label()
        Me.DateReceivedTextBox = New System.Windows.Forms.TextBox()
        Me.PaymentFormComboBox = New System.Windows.Forms.ComboBox()
        Me.DTDocuVoucher = New System.Windows.Forms.DateTimePicker()
        Me.ReceivedbyLabel = New System.Windows.Forms.Label()
        Me.ReceivedbyTextBox = New System.Windows.Forms.TextBox()
        Me.RecordedbyLabel = New System.Windows.Forms.Label()
        Me.RecordedbyTextBox = New System.Windows.Forms.TextBox()
        Me.ApprovedbyLabel = New System.Windows.Forms.Label()
        Me.ApprovedbyTextBox = New System.Windows.Forms.TextBox()
        Me.PreparedbyLabel = New System.Windows.Forms.Label()
        Me.PreparedbyTextBox = New System.Windows.Forms.TextBox()
        Me.PayorLabel = New System.Windows.Forms.Label()
        Me.PayorTextBox = New System.Windows.Forms.TextBox()
        Me.PayeeLabel = New System.Windows.Forms.Label()
        Me.PayeeTextBox = New System.Windows.Forms.TextBox()
        Me.TotalValueLabel2 = New System.Windows.Forms.Label()
        Me.TotalValueVoucher = New System.Windows.Forms.TextBox()
        Me.PaymentFormLabel = New System.Windows.Forms.Label()
        Me.VoucherNoLabel = New System.Windows.Forms.Label()
        Me.VoucherNoTextBox = New System.Windows.Forms.TextBox()
        Me.DocumentDateLabel1 = New System.Windows.Forms.Label()
        Me.DocumentDateVoucher = New System.Windows.Forms.TextBox()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.BankDepo = New System.Windows.Forms.TabPage()
        Me.BankAddressLabel = New System.Windows.Forms.Label()
        Me.BankAddressTextBox = New System.Windows.Forms.TextBox()
        Me.BankBranchLabel = New System.Windows.Forms.Label()
        Me.BankBranchTextBox = New System.Windows.Forms.TextBox()
        Me.BankNameLabel = New System.Windows.Forms.Label()
        Me.BankNameTextBox = New System.Windows.Forms.TextBox()
        Me.Others = New System.Windows.Forms.TabPage()
        Me.PaymentOthersLabel = New System.Windows.Forms.Label()
        Me.PaymentOthersTextBox = New System.Windows.Forms.TextBox()
        Me.Check = New System.Windows.Forms.TabPage()
        Me.CheckNoTextBox = New System.Windows.Forms.TextBox()
        Me.CheckNoLabel = New System.Windows.Forms.Label()
        Me.CorpDocu = New System.Windows.Forms.TabPage()
        Me.GrpCorp = New System.Windows.Forms.GroupBox()
        Me.TabControl4 = New System.Windows.Forms.TabControl()
        Me.TabMeeting = New System.Windows.Forms.TabPage()
        Me.DTMeetingDate = New System.Windows.Forms.DateTimePicker()
        Me.MeetingDateTextBox = New System.Windows.Forms.TextBox()
        Me.SecretaryTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyTextBox = New System.Windows.Forms.TextBox()
        Me.TabPromo = New System.Windows.Forms.TabPage()
        Me.DTPromoTo = New System.Windows.Forms.DateTimePicker()
        Me.DTPromoFrom = New System.Windows.Forms.DateTimePicker()
        Me.DTIPermitNoTextBox = New System.Windows.Forms.TextBox()
        Me.PromoToTextBox = New System.Windows.Forms.TextBox()
        Me.PromoFromTextBox = New System.Windows.Forms.TextBox()
        Me.PromoTitleTextBox = New System.Windows.Forms.TextBox()
        Me.TabMeeting2 = New System.Windows.Forms.TabPage()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.BoxNoCorpDocu = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.RackNoCorpDocu = New System.Windows.Forms.TextBox()
        Me.DTDocuCorp = New System.Windows.Forms.DateTimePicker()
        Me.PurposeLabel = New System.Windows.Forms.Label()
        Me.PurposeTextBox = New System.Windows.Forms.TextBox()
        Me.DocumentDateLabel2 = New System.Windows.Forms.Label()
        Me.DocumentDateCorp = New System.Windows.Forms.TextBox()
        Me.AcroPDF = New AxAcroPDFLib.AxAcroPDF()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.BtnRemoval = New System.Windows.Forms.Button()
        Me.C1TrueDBGrid2 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.DocsCatalogueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DMSDataSet = New DMS.DMSDataSet()
        Me.TableAdapterManager = New DMS.DMSDataSetTableAdapters.TableAdapterManager()
        Me.DocsCatalogueTableAdapter = New DMS.DMSDataSetTableAdapters.DocsCatalogueTableAdapter()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        IdLabel = New System.Windows.Forms.Label()
        DocSizeLabel = New System.Windows.Forms.Label()
        SubBatchLabel = New System.Windows.Forms.Label()
        BatchLabel = New System.Windows.Forms.Label()
        PagesLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabQuery.SuspendLayout()
        Me.TabChanges.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.Timesheet.SuspendLayout()
        Me.GrpTimeSheet.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ReceiptInvoice.SuspendLayout()
        Me.GrpReceipt.SuspendLayout()
        Me.Warranty.SuspendLayout()
        Me.GrpWarranty.SuspendLayout()
        Me.Voucher.SuspendLayout()
        Me.GrpVoucher.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.BankDepo.SuspendLayout()
        Me.Others.SuspendLayout()
        Me.Check.SuspendLayout()
        Me.CorpDocu.SuspendLayout()
        Me.GrpCorp.SuspendLayout()
        Me.TabControl4.SuspendLayout()
        Me.TabMeeting.SuspendLayout()
        Me.TabPromo.SuspendLayout()
        Me.TabMeeting2.SuspendLayout()
        CType(Me.AcroPDF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TrueDBGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocsCatalogueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.Location = New System.Drawing.Point(23, 83)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(93, 16)
        IdLabel.TabIndex = 42
        IdLabel.Text = "Document No:"
        '
        'DocSizeLabel
        '
        DocSizeLabel.AutoSize = True
        DocSizeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DocSizeLabel.Location = New System.Drawing.Point(15, 106)
        DocSizeLabel.Name = "DocSizeLabel"
        DocSizeLabel.Size = New System.Drawing.Size(101, 16)
        DocSizeLabel.TabIndex = 40
        DocSizeLabel.Text = "Document Size:"
        '
        'SubBatchLabel
        '
        SubBatchLabel.AutoSize = True
        SubBatchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SubBatchLabel.Location = New System.Drawing.Point(44, 60)
        SubBatchLabel.Name = "SubBatchLabel"
        SubBatchLabel.Size = New System.Drawing.Size(72, 16)
        SubBatchLabel.TabIndex = 37
        SubBatchLabel.Text = "Sub Batch:"
        '
        'BatchLabel
        '
        BatchLabel.AutoSize = True
        BatchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BatchLabel.Location = New System.Drawing.Point(31, 37)
        BatchLabel.Name = "BatchLabel"
        BatchLabel.Size = New System.Drawing.Size(85, 16)
        BatchLabel.TabIndex = 36
        BatchLabel.Text = "Batch Name:"
        '
        'PagesLabel
        '
        PagesLabel.AutoSize = True
        PagesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PagesLabel.Location = New System.Drawing.Point(441, 106)
        PagesLabel.Name = "PagesLabel"
        PagesLabel.Size = New System.Drawing.Size(89, 16)
        PagesLabel.TabIndex = 45
        PagesLabel.Text = "No. of Pages:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(277, 8)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(82, 16)
        Me.Label25.TabIndex = 44
        Me.Label25.Text = "mm/dd/yyyy"
        '
        'MeetingDateLabel
        '
        Me.MeetingDateLabel.AutoSize = True
        Me.MeetingDateLabel.Location = New System.Drawing.Point(4, 8)
        Me.MeetingDateLabel.Name = "MeetingDateLabel"
        Me.MeetingDateLabel.Size = New System.Drawing.Size(91, 16)
        Me.MeetingDateLabel.TabIndex = 39
        Me.MeetingDateLabel.Text = "Meeting Date:"
        '
        'SecretaryLabel
        '
        Me.SecretaryLabel.AutoSize = True
        Me.SecretaryLabel.Location = New System.Drawing.Point(4, 54)
        Me.SecretaryLabel.Name = "SecretaryLabel"
        Me.SecretaryLabel.Size = New System.Drawing.Size(69, 16)
        Me.SecretaryLabel.TabIndex = 38
        Me.SecretaryLabel.Text = "Secretary:"
        '
        'CompanyLabel
        '
        Me.CompanyLabel.AutoSize = True
        Me.CompanyLabel.Location = New System.Drawing.Point(4, 31)
        Me.CompanyLabel.Name = "CompanyLabel"
        Me.CompanyLabel.Size = New System.Drawing.Size(69, 16)
        Me.CompanyLabel.TabIndex = 37
        Me.CompanyLabel.Text = "Company:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(277, 53)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(82, 16)
        Me.Label33.TabIndex = 56
        Me.Label33.Text = "mm/dd/yyyy"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(277, 30)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(82, 16)
        Me.Label34.TabIndex = 55
        Me.Label34.Text = "mm/dd/yyyy"
        '
        'DTIPermitNoLabel
        '
        Me.DTIPermitNoLabel.AutoSize = True
        Me.DTIPermitNoLabel.Location = New System.Drawing.Point(5, 76)
        Me.DTIPermitNoLabel.Name = "DTIPermitNoLabel"
        Me.DTIPermitNoLabel.Size = New System.Drawing.Size(92, 16)
        Me.DTIPermitNoLabel.TabIndex = 50
        Me.DTIPermitNoLabel.Text = "DTIPermit No:"
        '
        'PromoToLabel
        '
        Me.PromoToLabel.AutoSize = True
        Me.PromoToLabel.Location = New System.Drawing.Point(4, 53)
        Me.PromoToLabel.Name = "PromoToLabel"
        Me.PromoToLabel.Size = New System.Drawing.Size(28, 16)
        Me.PromoToLabel.TabIndex = 48
        Me.PromoToLabel.Text = "To:"
        '
        'PromoFromLabel
        '
        Me.PromoFromLabel.AutoSize = True
        Me.PromoFromLabel.Location = New System.Drawing.Point(5, 30)
        Me.PromoFromLabel.Name = "PromoFromLabel"
        Me.PromoFromLabel.Size = New System.Drawing.Size(42, 16)
        Me.PromoFromLabel.TabIndex = 46
        Me.PromoFromLabel.Text = "From:"
        '
        'PromoTitleLabel
        '
        Me.PromoTitleLabel.AutoSize = True
        Me.PromoTitleLabel.Location = New System.Drawing.Point(4, 7)
        Me.PromoTitleLabel.Name = "PromoTitleLabel"
        Me.PromoTitleLabel.Size = New System.Drawing.Size(80, 16)
        Me.PromoTitleLabel.TabIndex = 45
        Me.PromoTitleLabel.Text = "Promo Title:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Azure
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Azure
        Me.SplitContainer1.Panel1.Controls.Add(Me.C1TrueDBGrid2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.Azure
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SplitContainer1.Size = New System.Drawing.Size(1240, 757)
        Me.SplitContainer1.SplitterDistance = 235
        Me.SplitContainer1.TabIndex = 0
        Me.SplitContainer1.TabStop = False
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.Controls.Add(Me.BtnRemoval)
        Me.SplitContainer2.Panel1.Controls.Add(Me.BtnDownload)
        Me.SplitContainer2.Panel1.Controls.Add(Me.BtnSaveChanges1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.BtnSearch)
        Me.SplitContainer2.Panel1.Controls.Add(Me.BtnEditRecord)
        Me.SplitContainer2.Panel1.Controls.Add(Me.TabControl1)
        Me.SplitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.AcroPDF)
        Me.SplitContainer2.Panel2.Controls.Add(Me.WebBrowser1)
        Me.SplitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer2.Size = New System.Drawing.Size(1240, 518)
        Me.SplitContainer2.SplitterDistance = 626
        Me.SplitContainer2.TabIndex = 0
        Me.SplitContainer2.TabStop = False
        '
        'BtnDownload
        '
        Me.BtnDownload.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDownload.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDownload.Location = New System.Drawing.Point(294, 7)
        Me.BtnDownload.Name = "BtnDownload"
        Me.BtnDownload.Size = New System.Drawing.Size(106, 28)
        Me.BtnDownload.TabIndex = 2
        Me.BtnDownload.Text = "Download"
        Me.BtnDownload.UseVisualStyleBackColor = False
        '
        'BtnSaveChanges1
        '
        Me.BtnSaveChanges1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnSaveChanges1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSaveChanges1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveChanges1.Location = New System.Drawing.Point(512, 7)
        Me.BtnSaveChanges1.Name = "BtnSaveChanges1"
        Me.BtnSaveChanges1.Size = New System.Drawing.Size(106, 28)
        Me.BtnSaveChanges1.TabIndex = 4
        Me.BtnSaveChanges1.Text = "Save Changes"
        Me.BtnSaveChanges1.UseVisualStyleBackColor = False
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.Location = New System.Drawing.Point(6, 7)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(110, 28)
        Me.BtnSearch.TabIndex = 1
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'BtnEditRecord
        '
        Me.BtnEditRecord.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnEditRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEditRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditRecord.Location = New System.Drawing.Point(403, 7)
        Me.BtnEditRecord.Name = "BtnEditRecord"
        Me.BtnEditRecord.Size = New System.Drawing.Size(106, 28)
        Me.BtnEditRecord.TabIndex = 3
        Me.BtnEditRecord.Text = "Edit Record"
        Me.BtnEditRecord.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabQuery)
        Me.TabControl1.Controls.Add(Me.TabChanges)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl1.ItemSize = New System.Drawing.Size(81, 28)
        Me.TabControl1.Location = New System.Drawing.Point(0, 41)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(626, 477)
        Me.TabControl1.TabIndex = 91
        Me.TabControl1.TabStop = False
        '
        'TabQuery
        '
        Me.TabQuery.BackColor = System.Drawing.Color.Azure
        Me.TabQuery.Controls.Add(Me.CHKFileName)
        Me.TabQuery.Controls.Add(Me.sdasd)
        Me.TabQuery.Controls.Add(Me.TxtFileName)
        Me.TabQuery.Controls.Add(Me.Label36)
        Me.TabQuery.Controls.Add(Me.CHKBatch)
        Me.TabQuery.Controls.Add(Me.Label11)
        Me.TabQuery.Controls.Add(Me.TxtBatch)
        Me.TabQuery.Controls.Add(Me.TxtBook)
        Me.TabQuery.Controls.Add(Me.TxtBox)
        Me.TabQuery.Controls.Add(Me.TxtRack)
        Me.TabQuery.Controls.Add(Me.CHKScanDate)
        Me.TabQuery.Controls.Add(Me.Label8)
        Me.TabQuery.Controls.Add(Me.Label9)
        Me.TabQuery.Controls.Add(Me.Label10)
        Me.TabQuery.Controls.Add(Me.DTScanDateTo)
        Me.TabQuery.Controls.Add(Me.DTScanDateFrom)
        Me.TabQuery.Controls.Add(Me.CHKDocType)
        Me.TabQuery.Controls.Add(Me.CHKDocDate)
        Me.TabQuery.Controls.Add(Me.CHKBook)
        Me.TabQuery.Controls.Add(Me.CHKBox)
        Me.TabQuery.Controls.Add(Me.CHKRack)
        Me.TabQuery.Controls.Add(Me.Label7)
        Me.TabQuery.Controls.Add(Me.Label6)
        Me.TabQuery.Controls.Add(Me.Label5)
        Me.TabQuery.Controls.Add(Me.Label4)
        Me.TabQuery.Controls.Add(Me.Label3)
        Me.TabQuery.Controls.Add(Me.Label2)
        Me.TabQuery.Controls.Add(Me.Label1)
        Me.TabQuery.Controls.Add(Me.DTDocDateTo)
        Me.TabQuery.Controls.Add(Me.DTDocDateFrom)
        Me.TabQuery.Controls.Add(Me.DocumentTypeComboBox)
        Me.TabQuery.Controls.Add(Me.DocumentTypeLabel)
        Me.TabQuery.Location = New System.Drawing.Point(4, 32)
        Me.TabQuery.Name = "TabQuery"
        Me.TabQuery.Padding = New System.Windows.Forms.Padding(3)
        Me.TabQuery.Size = New System.Drawing.Size(618, 441)
        Me.TabQuery.TabIndex = 0
        Me.TabQuery.Text = "TabQuery"
        '
        'CHKFileName
        '
        Me.CHKFileName.AutoSize = True
        Me.CHKFileName.Location = New System.Drawing.Point(43, 74)
        Me.CHKFileName.Name = "CHKFileName"
        Me.CHKFileName.Size = New System.Drawing.Size(15, 14)
        Me.CHKFileName.TabIndex = 5
        Me.CHKFileName.UseVisualStyleBackColor = True
        '
        'sdasd
        '
        Me.sdasd.AutoSize = True
        Me.sdasd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sdasd.Location = New System.Drawing.Point(64, 70)
        Me.sdasd.Name = "sdasd"
        Me.sdasd.Size = New System.Drawing.Size(84, 20)
        Me.sdasd.TabIndex = 90
        Me.sdasd.Text = "File Name:"
        '
        'TxtFileName
        '
        Me.TxtFileName.Location = New System.Drawing.Point(191, 67)
        Me.TxtFileName.Name = "TxtFileName"
        Me.TxtFileName.Size = New System.Drawing.Size(157, 26)
        Me.TxtFileName.TabIndex = 6
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(326, 12)
        Me.Label36.Name = "Label36"
        Me.Label36.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label36.Size = New System.Drawing.Size(267, 30)
        Me.Label36.TabIndex = 88
        Me.Label36.Text = "Check the box if you want to search by that field. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If there is no selected it w" &
    "ill seach all records." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'CHKBatch
        '
        Me.CHKBatch.AutoSize = True
        Me.CHKBatch.Location = New System.Drawing.Point(43, 182)
        Me.CHKBatch.Name = "CHKBatch"
        Me.CHKBatch.Size = New System.Drawing.Size(15, 14)
        Me.CHKBatch.TabIndex = 13
        Me.CHKBatch.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(64, 178)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 20)
        Me.Label11.TabIndex = 86
        Me.Label11.Text = "Batch No.:"
        '
        'TxtBatch
        '
        Me.TxtBatch.Location = New System.Drawing.Point(191, 175)
        Me.TxtBatch.Name = "TxtBatch"
        Me.TxtBatch.Size = New System.Drawing.Size(157, 26)
        Me.TxtBatch.TabIndex = 14
        '
        'TxtBook
        '
        Me.TxtBook.Location = New System.Drawing.Point(191, 148)
        Me.TxtBook.Name = "TxtBook"
        Me.TxtBook.Size = New System.Drawing.Size(157, 26)
        Me.TxtBook.TabIndex = 12
        '
        'TxtBox
        '
        Me.TxtBox.Location = New System.Drawing.Point(191, 121)
        Me.TxtBox.Name = "TxtBox"
        Me.TxtBox.Size = New System.Drawing.Size(157, 26)
        Me.TxtBox.TabIndex = 10
        '
        'TxtRack
        '
        Me.TxtRack.Location = New System.Drawing.Point(191, 94)
        Me.TxtRack.Name = "TxtRack"
        Me.TxtRack.Size = New System.Drawing.Size(157, 26)
        Me.TxtRack.TabIndex = 8
        '
        'CHKScanDate
        '
        Me.CHKScanDate.AutoSize = True
        Me.CHKScanDate.Location = New System.Drawing.Point(43, 270)
        Me.CHKScanDate.Name = "CHKScanDate"
        Me.CHKScanDate.Size = New System.Drawing.Size(15, 14)
        Me.CHKScanDate.TabIndex = 18
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
        Me.DTScanDateTo.TabIndex = 20
        '
        'DTScanDateFrom
        '
        Me.DTScanDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTScanDateFrom.Location = New System.Drawing.Point(165, 290)
        Me.DTScanDateFrom.Name = "DTScanDateFrom"
        Me.DTScanDateFrom.Size = New System.Drawing.Size(129, 26)
        Me.DTScanDateFrom.TabIndex = 19
        '
        'CHKDocType
        '
        Me.CHKDocType.AutoSize = True
        Me.CHKDocType.Location = New System.Drawing.Point(43, 344)
        Me.CHKDocType.Name = "CHKDocType"
        Me.CHKDocType.Size = New System.Drawing.Size(15, 14)
        Me.CHKDocType.TabIndex = 21
        Me.CHKDocType.UseVisualStyleBackColor = True
        '
        'CHKDocDate
        '
        Me.CHKDocDate.AutoSize = True
        Me.CHKDocDate.Location = New System.Drawing.Point(43, 206)
        Me.CHKDocDate.Name = "CHKDocDate"
        Me.CHKDocDate.Size = New System.Drawing.Size(15, 14)
        Me.CHKDocDate.TabIndex = 15
        Me.CHKDocDate.UseVisualStyleBackColor = True
        '
        'CHKBook
        '
        Me.CHKBook.AutoSize = True
        Me.CHKBook.Location = New System.Drawing.Point(43, 155)
        Me.CHKBook.Name = "CHKBook"
        Me.CHKBook.Size = New System.Drawing.Size(15, 14)
        Me.CHKBook.TabIndex = 11
        Me.CHKBook.UseVisualStyleBackColor = True
        '
        'CHKBox
        '
        Me.CHKBox.AutoSize = True
        Me.CHKBox.Location = New System.Drawing.Point(43, 128)
        Me.CHKBox.Name = "CHKBox"
        Me.CHKBox.Size = New System.Drawing.Size(15, 14)
        Me.CHKBox.TabIndex = 9
        Me.CHKBox.UseVisualStyleBackColor = True
        '
        'CHKRack
        '
        Me.CHKRack.AutoSize = True
        Me.CHKRack.Location = New System.Drawing.Point(43, 101)
        Me.CHKRack.Name = "CHKRack"
        Me.CHKRack.Size = New System.Drawing.Size(15, 14)
        Me.CHKRack.TabIndex = 7
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
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
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
        Me.Label3.Location = New System.Drawing.Point(64, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Booklet No.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Box No.:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Rack No.:"
        '
        'DTDocDateTo
        '
        Me.DTDocDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTDocDateTo.Location = New System.Drawing.Point(346, 226)
        Me.DTDocDateTo.Name = "DTDocDateTo"
        Me.DTDocDateTo.Size = New System.Drawing.Size(129, 26)
        Me.DTDocDateTo.TabIndex = 17
        '
        'DTDocDateFrom
        '
        Me.DTDocDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTDocDateFrom.Location = New System.Drawing.Point(165, 226)
        Me.DTDocDateFrom.Name = "DTDocDateFrom"
        Me.DTDocDateFrom.Size = New System.Drawing.Size(129, 26)
        Me.DTDocDateFrom.TabIndex = 16
        '
        'DocumentTypeComboBox
        '
        Me.DocumentTypeComboBox.BackColor = System.Drawing.SystemColors.Window
        Me.DocumentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DocumentTypeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentTypeComboBox.FormattingEnabled = True
        Me.DocumentTypeComboBox.Location = New System.Drawing.Point(195, 337)
        Me.DocumentTypeComboBox.Name = "DocumentTypeComboBox"
        Me.DocumentTypeComboBox.Size = New System.Drawing.Size(384, 28)
        Me.DocumentTypeComboBox.TabIndex = 22
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
        'TabChanges
        '
        Me.TabChanges.BackColor = System.Drawing.Color.Azure
        Me.TabChanges.Controls.Add(PagesLabel)
        Me.TabChanges.Controls.Add(Me.txtPages)
        Me.TabChanges.Controls.Add(IdLabel)
        Me.TabChanges.Controls.Add(DocSizeLabel)
        Me.TabChanges.Controls.Add(Me.cbDocSize)
        Me.TabChanges.Controls.Add(Me.chkConfidential)
        Me.TabChanges.Controls.Add(SubBatchLabel)
        Me.TabChanges.Controls.Add(Me.SubBatchTextBox)
        Me.TabChanges.Controls.Add(BatchLabel)
        Me.TabChanges.Controls.Add(Me.BatchTextBox)
        Me.TabChanges.Controls.Add(Me.IdTextBox)
        Me.TabChanges.Controls.Add(Me.DocumentTypeCombobox2)
        Me.TabChanges.Controls.Add(Me.Label32)
        Me.TabChanges.Controls.Add(Me.TabControl2)
        Me.TabChanges.Location = New System.Drawing.Point(4, 32)
        Me.TabChanges.Name = "TabChanges"
        Me.TabChanges.Padding = New System.Windows.Forms.Padding(3)
        Me.TabChanges.Size = New System.Drawing.Size(618, 441)
        Me.TabChanges.TabIndex = 1
        Me.TabChanges.Text = "TabChanges"
        '
        'txtPages
        '
        Me.txtPages.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Pages", True))
        Me.txtPages.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPages.Location = New System.Drawing.Point(535, 103)
        Me.txtPages.Name = "txtPages"
        Me.txtPages.Size = New System.Drawing.Size(64, 22)
        Me.txtPages.TabIndex = 44
        '
        'cbDocSize
        '
        Me.cbDocSize.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "DocSize", True))
        Me.cbDocSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDocSize.FormattingEnabled = True
        Me.cbDocSize.Items.AddRange(New Object() {"8.5 x 11 (Letter Size)", "8.5 x 13 (Long Bond)", "8.5 x 14 (Legal Size)", "A4 Size", "A5 Size"})
        Me.cbDocSize.Location = New System.Drawing.Point(138, 103)
        Me.cbDocSize.Name = "cbDocSize"
        Me.cbDocSize.Size = New System.Drawing.Size(217, 24)
        Me.cbDocSize.TabIndex = 43
        '
        'chkConfidential
        '
        Me.chkConfidential.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DocsCatalogueBindingSource, "Confidential", True))
        Me.chkConfidential.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkConfidential.Location = New System.Drawing.Point(495, 80)
        Me.chkConfidential.Name = "chkConfidential"
        Me.chkConfidential.Size = New System.Drawing.Size(104, 24)
        Me.chkConfidential.TabIndex = 41
        Me.chkConfidential.Text = "Confidential"
        Me.chkConfidential.UseVisualStyleBackColor = True
        '
        'SubBatchTextBox
        '
        Me.SubBatchTextBox.BackColor = System.Drawing.Color.White
        Me.SubBatchTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "SubBatch", True))
        Me.SubBatchTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubBatchTextBox.Location = New System.Drawing.Point(138, 57)
        Me.SubBatchTextBox.Name = "SubBatchTextBox"
        Me.SubBatchTextBox.Size = New System.Drawing.Size(461, 22)
        Me.SubBatchTextBox.TabIndex = 39
        '
        'BatchTextBox
        '
        Me.BatchTextBox.BackColor = System.Drawing.Color.White
        Me.BatchTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Batch", True))
        Me.BatchTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BatchTextBox.Location = New System.Drawing.Point(138, 34)
        Me.BatchTextBox.Name = "BatchTextBox"
        Me.BatchTextBox.Size = New System.Drawing.Size(461, 22)
        Me.BatchTextBox.TabIndex = 38
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Id", True))
        Me.IdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox.Location = New System.Drawing.Point(138, 80)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(82, 22)
        Me.IdTextBox.TabIndex = 35
        Me.IdTextBox.TabStop = False
        '
        'DocumentTypeCombobox2
        '
        Me.DocumentTypeCombobox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.DocumentTypeCombobox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "DocumentType", True))
        Me.DocumentTypeCombobox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DocumentTypeCombobox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentTypeCombobox2.FormattingEnabled = True
        Me.DocumentTypeCombobox2.Location = New System.Drawing.Point(138, 2)
        Me.DocumentTypeCombobox2.Name = "DocumentTypeCombobox2"
        Me.DocumentTypeCombobox2.Size = New System.Drawing.Size(396, 28)
        Me.DocumentTypeCombobox2.TabIndex = 23
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(9, 5)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(125, 20)
        Me.Label32.TabIndex = 28
        Me.Label32.Text = "Document Type:"
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.Timesheet)
        Me.TabControl2.Controls.Add(Me.ReceiptInvoice)
        Me.TabControl2.Controls.Add(Me.Warranty)
        Me.TabControl2.Controls.Add(Me.Voucher)
        Me.TabControl2.Controls.Add(Me.CorpDocu)
        Me.TabControl2.Location = New System.Drawing.Point(-1, 125)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(626, 310)
        Me.TabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl2.TabIndex = 27
        Me.TabControl2.TabStop = False
        '
        'Timesheet
        '
        Me.Timesheet.AutoScroll = True
        Me.Timesheet.AutoScrollMinSize = New System.Drawing.Size(0, 300)
        Me.Timesheet.BackColor = System.Drawing.SystemColors.Control
        Me.Timesheet.Controls.Add(Me.GrpTimeSheet)
        Me.Timesheet.Location = New System.Drawing.Point(4, 29)
        Me.Timesheet.Name = "Timesheet"
        Me.Timesheet.Padding = New System.Windows.Forms.Padding(3)
        Me.Timesheet.Size = New System.Drawing.Size(618, 277)
        Me.Timesheet.TabIndex = 0
        Me.Timesheet.Text = "Timesheet"
        '
        'GrpTimeSheet
        '
        Me.GrpTimeSheet.BackColor = System.Drawing.Color.Azure
        Me.GrpTimeSheet.Controls.Add(Me.Label12)
        Me.GrpTimeSheet.Controls.Add(Me.Label13)
        Me.GrpTimeSheet.Controls.Add(Me.BoxNoTS)
        Me.GrpTimeSheet.Controls.Add(Me.Label14)
        Me.GrpTimeSheet.Controls.Add(Me.RackNoTS)
        Me.GrpTimeSheet.Controls.Add(Me.GroupBox1)
        Me.GrpTimeSheet.Controls.Add(Me.MiddleNameLabel)
        Me.GrpTimeSheet.Controls.Add(Me.MiddleNameTextBox)
        Me.GrpTimeSheet.Controls.Add(Me.FirstNameLabel)
        Me.GrpTimeSheet.Controls.Add(Me.FirstNameTextBox)
        Me.GrpTimeSheet.Controls.Add(Me.LastNameLabel)
        Me.GrpTimeSheet.Controls.Add(Me.LastNameTextBox)
        Me.GrpTimeSheet.Controls.Add(Me.DocumentDateTS)
        Me.GrpTimeSheet.Controls.Add(Me.DTDocuTimeSheet)
        Me.GrpTimeSheet.Controls.Add(Me.Label15)
        Me.GrpTimeSheet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpTimeSheet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpTimeSheet.ForeColor = System.Drawing.Color.Black
        Me.GrpTimeSheet.Location = New System.Drawing.Point(3, 3)
        Me.GrpTimeSheet.Name = "GrpTimeSheet"
        Me.GrpTimeSheet.Size = New System.Drawing.Size(595, 297)
        Me.GrpTimeSheet.TabIndex = 25
        Me.GrpTimeSheet.TabStop = False
        Me.GrpTimeSheet.Text = "Keywords"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(284, 76)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 16)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "mm/dd/yyyy"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(122, 16)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Document Box No.:"
        '
        'BoxNoTS
        '
        Me.BoxNoTS.BackColor = System.Drawing.Color.White
        Me.BoxNoTS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BoxNo", True))
        Me.BoxNoTS.Location = New System.Drawing.Point(158, 50)
        Me.BoxNoTS.Name = "BoxNoTS"
        Me.BoxNoTS.Size = New System.Drawing.Size(123, 22)
        Me.BoxNoTS.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(131, 16)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Document Rack No.:"
        '
        'RackNoTS
        '
        Me.RackNoTS.BackColor = System.Drawing.Color.White
        Me.RackNoTS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "RackNo", True))
        Me.RackNoTS.Location = New System.Drawing.Point(158, 27)
        Me.RackNoTS.Name = "RackNoTS"
        Me.RackNoTS.Size = New System.Drawing.Size(123, 22)
        Me.RackNoTS.TabIndex = 24
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.FromPeriodLabel)
        Me.GroupBox1.Controls.Add(Me.DTToPeriod)
        Me.GroupBox1.Controls.Add(Me.FromPeriodTextBox)
        Me.GroupBox1.Controls.Add(Me.DTFromPeriod)
        Me.GroupBox1.Controls.Add(Me.ToPeriodTextBox)
        Me.GroupBox1.Controls.Add(Me.ToPeriodLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 185)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(583, 84)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Coverage"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(307, 50)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(82, 16)
        Me.Label30.TabIndex = 37
        Me.Label30.Text = "mm/dd/yyyy"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(307, 24)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(82, 16)
        Me.Label29.TabIndex = 36
        Me.Label29.Text = "mm/dd/yyyy"
        '
        'FromPeriodLabel
        '
        Me.FromPeriodLabel.AutoSize = True
        Me.FromPeriodLabel.Location = New System.Drawing.Point(132, 24)
        Me.FromPeriodLabel.Name = "FromPeriodLabel"
        Me.FromPeriodLabel.Size = New System.Drawing.Size(42, 16)
        Me.FromPeriodLabel.TabIndex = 27
        Me.FromPeriodLabel.Text = "From:"
        '
        'DTToPeriod
        '
        Me.DTToPeriod.Location = New System.Drawing.Point(285, 47)
        Me.DTToPeriod.Name = "DTToPeriod"
        Me.DTToPeriod.Size = New System.Drawing.Size(18, 22)
        Me.DTToPeriod.TabIndex = 34
        '
        'FromPeriodTextBox
        '
        Me.FromPeriodTextBox.BackColor = System.Drawing.Color.White
        Me.FromPeriodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "FromPeriod", True))
        Me.FromPeriodTextBox.Location = New System.Drawing.Point(181, 21)
        Me.FromPeriodTextBox.Name = "FromPeriodTextBox"
        Me.FromPeriodTextBox.Size = New System.Drawing.Size(104, 22)
        Me.FromPeriodTextBox.TabIndex = 31
        Me.FromPeriodTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DTFromPeriod
        '
        Me.DTFromPeriod.Location = New System.Drawing.Point(286, 21)
        Me.DTFromPeriod.Name = "DTFromPeriod"
        Me.DTFromPeriod.Size = New System.Drawing.Size(18, 22)
        Me.DTFromPeriod.TabIndex = 32
        '
        'ToPeriodTextBox
        '
        Me.ToPeriodTextBox.BackColor = System.Drawing.Color.White
        Me.ToPeriodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ToPeriod", True))
        Me.ToPeriodTextBox.Location = New System.Drawing.Point(181, 47)
        Me.ToPeriodTextBox.Name = "ToPeriodTextBox"
        Me.ToPeriodTextBox.Size = New System.Drawing.Size(103, 22)
        Me.ToPeriodTextBox.TabIndex = 33
        Me.ToPeriodTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToPeriodLabel
        '
        Me.ToPeriodLabel.AutoSize = True
        Me.ToPeriodLabel.Location = New System.Drawing.Point(151, 50)
        Me.ToPeriodLabel.Name = "ToPeriodLabel"
        Me.ToPeriodLabel.Size = New System.Drawing.Size(28, 16)
        Me.ToPeriodLabel.TabIndex = 28
        Me.ToPeriodLabel.Text = "To:"
        '
        'MiddleNameLabel
        '
        Me.MiddleNameLabel.AutoSize = True
        Me.MiddleNameLabel.Location = New System.Drawing.Point(8, 154)
        Me.MiddleNameLabel.Name = "MiddleNameLabel"
        Me.MiddleNameLabel.Size = New System.Drawing.Size(92, 16)
        Me.MiddleNameLabel.TabIndex = 26
        Me.MiddleNameLabel.Text = "Middle Name:"
        '
        'MiddleNameTextBox
        '
        Me.MiddleNameTextBox.BackColor = System.Drawing.Color.White
        Me.MiddleNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "MiddleName", True))
        Me.MiddleNameTextBox.Location = New System.Drawing.Point(158, 151)
        Me.MiddleNameTextBox.Name = "MiddleNameTextBox"
        Me.MiddleNameTextBox.Size = New System.Drawing.Size(367, 22)
        Me.MiddleNameTextBox.TabIndex = 30
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(8, 131)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(76, 16)
        Me.FirstNameLabel.TabIndex = 25
        Me.FirstNameLabel.Text = "First Name:"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.BackColor = System.Drawing.Color.White
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(158, 128)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(367, 22)
        Me.FirstNameTextBox.TabIndex = 29
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(8, 108)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(76, 16)
        Me.LastNameLabel.TabIndex = 24
        Me.LastNameLabel.Text = "Last Name:"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.BackColor = System.Drawing.Color.White
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(158, 105)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(367, 22)
        Me.LastNameTextBox.TabIndex = 28
        '
        'DocumentDateTS
        '
        Me.DocumentDateTS.BackColor = System.Drawing.Color.White
        Me.DocumentDateTS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "DocumentDate", True))
        Me.DocumentDateTS.Location = New System.Drawing.Point(158, 73)
        Me.DocumentDateTS.Name = "DocumentDateTS"
        Me.DocumentDateTS.Size = New System.Drawing.Size(104, 22)
        Me.DocumentDateTS.TabIndex = 26
        Me.DocumentDateTS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DTDocuTimeSheet
        '
        Me.DTDocuTimeSheet.Location = New System.Drawing.Point(263, 73)
        Me.DTDocuTimeSheet.Name = "DTDocuTimeSheet"
        Me.DTDocuTimeSheet.Size = New System.Drawing.Size(18, 22)
        Me.DTDocuTimeSheet.TabIndex = 27
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 76)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 16)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Document Date:"
        '
        'ReceiptInvoice
        '
        Me.ReceiptInvoice.AutoScroll = True
        Me.ReceiptInvoice.AutoScrollMinSize = New System.Drawing.Size(0, 400)
        Me.ReceiptInvoice.BackColor = System.Drawing.SystemColors.Control
        Me.ReceiptInvoice.Controls.Add(Me.GrpReceipt)
        Me.ReceiptInvoice.Location = New System.Drawing.Point(4, 29)
        Me.ReceiptInvoice.Name = "ReceiptInvoice"
        Me.ReceiptInvoice.Padding = New System.Windows.Forms.Padding(3)
        Me.ReceiptInvoice.Size = New System.Drawing.Size(618, 277)
        Me.ReceiptInvoice.TabIndex = 1
        Me.ReceiptInvoice.Text = "Receipt/Invoice"
        '
        'GrpReceipt
        '
        Me.GrpReceipt.BackColor = System.Drawing.Color.Azure
        Me.GrpReceipt.Controls.Add(Me.Label16)
        Me.GrpReceipt.Controls.Add(Me.NONVATregCheckBox)
        Me.GrpReceipt.Controls.Add(Me.VATregCheckBox)
        Me.GrpReceipt.Controls.Add(Me.AddressCLabel)
        Me.GrpReceipt.Controls.Add(Me.AddressCTextBox)
        Me.GrpReceipt.Controls.Add(Me.TinCustomerLabel)
        Me.GrpReceipt.Controls.Add(Me.TinCustomerTextBox)
        Me.GrpReceipt.Controls.Add(Me.TinVendorLabel)
        Me.GrpReceipt.Controls.Add(Me.TinVendorTextBox)
        Me.GrpReceipt.Controls.Add(Me.BoxNoLabel)
        Me.GrpReceipt.Controls.Add(Me.BoxNoRI)
        Me.GrpReceipt.Controls.Add(Me.RackNoLabel)
        Me.GrpReceipt.Controls.Add(Me.RackNoRI)
        Me.GrpReceipt.Controls.Add(Me.Label17)
        Me.GrpReceipt.Controls.Add(Me.DocumentDateRI)
        Me.GrpReceipt.Controls.Add(Me.TotalValueLabel)
        Me.GrpReceipt.Controls.Add(Me.TotalValueRI)
        Me.GrpReceipt.Controls.Add(Me.ItemPurchasedLabel)
        Me.GrpReceipt.Controls.Add(Me.ItemPurchasedTextBox)
        Me.GrpReceipt.Controls.Add(Me.CustomerLabel)
        Me.GrpReceipt.Controls.Add(Me.CustomerTextBox)
        Me.GrpReceipt.Controls.Add(Me.VendorLabel)
        Me.GrpReceipt.Controls.Add(Me.VendorTextBox)
        Me.GrpReceipt.Controls.Add(Me.BookletNoLabel)
        Me.GrpReceipt.Controls.Add(Me.BookletNoTextBox)
        Me.GrpReceipt.Controls.Add(Me.DTDocuRI)
        Me.GrpReceipt.Controls.Add(Me.ReferenceNoLabel)
        Me.GrpReceipt.Controls.Add(Me.ReferenceNoRI)
        Me.GrpReceipt.Controls.Add(Me.DocumentDateLabel)
        Me.GrpReceipt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpReceipt.ForeColor = System.Drawing.Color.Black
        Me.GrpReceipt.Location = New System.Drawing.Point(3, 3)
        Me.GrpReceipt.Name = "GrpReceipt"
        Me.GrpReceipt.Size = New System.Drawing.Size(595, 397)
        Me.GrpReceipt.TabIndex = 0
        Me.GrpReceipt.TabStop = False
        Me.GrpReceipt.Text = "Keywords"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(285, 76)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 16)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "mm/dd/yyyy"
        '
        'NONVATregCheckBox
        '
        Me.NONVATregCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DocsCatalogueBindingSource, "NONVATreg", True))
        Me.NONVATregCheckBox.Location = New System.Drawing.Point(413, 49)
        Me.NONVATregCheckBox.Name = "NONVATregCheckBox"
        Me.NONVATregCheckBox.Size = New System.Drawing.Size(160, 24)
        Me.NONVATregCheckBox.TabIndex = 31
        Me.NONVATregCheckBox.Text = "NON-VAT Registered"
        Me.NONVATregCheckBox.UseVisualStyleBackColor = True
        '
        'VATregCheckBox
        '
        Me.VATregCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DocsCatalogueBindingSource, "VATreg", True))
        Me.VATregCheckBox.Location = New System.Drawing.Point(413, 27)
        Me.VATregCheckBox.Name = "VATregCheckBox"
        Me.VATregCheckBox.Size = New System.Drawing.Size(127, 24)
        Me.VATregCheckBox.TabIndex = 30
        Me.VATregCheckBox.Text = "VAT Registered"
        Me.VATregCheckBox.UseVisualStyleBackColor = True
        '
        'AddressCLabel
        '
        Me.AddressCLabel.AutoSize = True
        Me.AddressCLabel.Location = New System.Drawing.Point(8, 203)
        Me.AddressCLabel.Name = "AddressCLabel"
        Me.AddressCLabel.Size = New System.Drawing.Size(122, 16)
        Me.AddressCLabel.TabIndex = 29
        Me.AddressCLabel.Text = "Customer Address:"
        '
        'AddressCTextBox
        '
        Me.AddressCTextBox.BackColor = System.Drawing.Color.White
        Me.AddressCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "AddressC", True))
        Me.AddressCTextBox.Location = New System.Drawing.Point(158, 200)
        Me.AddressCTextBox.Name = "AddressCTextBox"
        Me.AddressCTextBox.Size = New System.Drawing.Size(416, 22)
        Me.AddressCTextBox.TabIndex = 35
        '
        'TinCustomerLabel
        '
        Me.TinCustomerLabel.AutoSize = True
        Me.TinCustomerLabel.Location = New System.Drawing.Point(8, 255)
        Me.TinCustomerLabel.Name = "TinCustomerLabel"
        Me.TinCustomerLabel.Size = New System.Drawing.Size(107, 16)
        Me.TinCustomerLabel.TabIndex = 28
        Me.TinCustomerLabel.Text = "TIN of Customer:"
        '
        'TinCustomerTextBox
        '
        Me.TinCustomerTextBox.BackColor = System.Drawing.Color.White
        Me.TinCustomerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "TinCustomer", True))
        Me.TinCustomerTextBox.Location = New System.Drawing.Point(158, 252)
        Me.TinCustomerTextBox.Name = "TinCustomerTextBox"
        Me.TinCustomerTextBox.Size = New System.Drawing.Size(182, 22)
        Me.TinCustomerTextBox.TabIndex = 37
        '
        'TinVendorLabel
        '
        Me.TinVendorLabel.AutoSize = True
        Me.TinVendorLabel.Location = New System.Drawing.Point(8, 232)
        Me.TinVendorLabel.Name = "TinVendorLabel"
        Me.TinVendorLabel.Size = New System.Drawing.Size(94, 16)
        Me.TinVendorLabel.TabIndex = 27
        Me.TinVendorLabel.Text = "TIN of Vendor:"
        '
        'TinVendorTextBox
        '
        Me.TinVendorTextBox.BackColor = System.Drawing.Color.White
        Me.TinVendorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "TinVendor", True))
        Me.TinVendorTextBox.Location = New System.Drawing.Point(158, 229)
        Me.TinVendorTextBox.Name = "TinVendorTextBox"
        Me.TinVendorTextBox.Size = New System.Drawing.Size(182, 22)
        Me.TinVendorTextBox.TabIndex = 36
        '
        'BoxNoLabel
        '
        Me.BoxNoLabel.AutoSize = True
        Me.BoxNoLabel.Location = New System.Drawing.Point(8, 53)
        Me.BoxNoLabel.Name = "BoxNoLabel"
        Me.BoxNoLabel.Size = New System.Drawing.Size(122, 16)
        Me.BoxNoLabel.TabIndex = 26
        Me.BoxNoLabel.Text = "Document Box No.:"
        '
        'BoxNoRI
        '
        Me.BoxNoRI.BackColor = System.Drawing.Color.White
        Me.BoxNoRI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BoxNo", True))
        Me.BoxNoRI.Location = New System.Drawing.Point(158, 50)
        Me.BoxNoRI.Name = "BoxNoRI"
        Me.BoxNoRI.Size = New System.Drawing.Size(123, 22)
        Me.BoxNoRI.TabIndex = 25
        '
        'RackNoLabel
        '
        Me.RackNoLabel.AutoSize = True
        Me.RackNoLabel.Location = New System.Drawing.Point(8, 30)
        Me.RackNoLabel.Name = "RackNoLabel"
        Me.RackNoLabel.Size = New System.Drawing.Size(131, 16)
        Me.RackNoLabel.TabIndex = 25
        Me.RackNoLabel.Text = "Document Rack No.:"
        '
        'RackNoRI
        '
        Me.RackNoRI.BackColor = System.Drawing.Color.White
        Me.RackNoRI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "RackNo", True))
        Me.RackNoRI.Location = New System.Drawing.Point(158, 27)
        Me.RackNoRI.Name = "RackNoRI"
        Me.RackNoRI.Size = New System.Drawing.Size(123, 22)
        Me.RackNoRI.TabIndex = 24
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(359, 123)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 13)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "(VAT INC)"
        '
        'DocumentDateRI
        '
        Me.DocumentDateRI.BackColor = System.Drawing.Color.White
        Me.DocumentDateRI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "DocumentDate", True))
        Me.DocumentDateRI.Location = New System.Drawing.Point(158, 73)
        Me.DocumentDateRI.Name = "DocumentDateRI"
        Me.DocumentDateRI.Size = New System.Drawing.Size(104, 22)
        Me.DocumentDateRI.TabIndex = 26
        Me.DocumentDateRI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TotalValueLabel
        '
        Me.TotalValueLabel.AutoSize = True
        Me.TotalValueLabel.Location = New System.Drawing.Point(348, 105)
        Me.TotalValueLabel.Name = "TotalValueLabel"
        Me.TotalValueLabel.Size = New System.Drawing.Size(80, 16)
        Me.TotalValueLabel.TabIndex = 22
        Me.TotalValueLabel.Text = "Total Value:"
        '
        'TotalValueRI
        '
        Me.TotalValueRI.BackColor = System.Drawing.Color.White
        Me.TotalValueRI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "TotalValue", True))
        Me.TotalValueRI.Location = New System.Drawing.Point(434, 102)
        Me.TotalValueRI.Name = "TotalValueRI"
        Me.TotalValueRI.Size = New System.Drawing.Size(140, 22)
        Me.TotalValueRI.TabIndex = 32
        '
        'ItemPurchasedLabel
        '
        Me.ItemPurchasedLabel.AutoSize = True
        Me.ItemPurchasedLabel.Location = New System.Drawing.Point(8, 287)
        Me.ItemPurchasedLabel.Name = "ItemPurchasedLabel"
        Me.ItemPurchasedLabel.Size = New System.Drawing.Size(104, 16)
        Me.ItemPurchasedLabel.TabIndex = 21
        Me.ItemPurchasedLabel.Text = "Item Purchased:"
        '
        'ItemPurchasedTextBox
        '
        Me.ItemPurchasedTextBox.BackColor = System.Drawing.Color.White
        Me.ItemPurchasedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ItemPurchased", True))
        Me.ItemPurchasedTextBox.Location = New System.Drawing.Point(158, 284)
        Me.ItemPurchasedTextBox.Multiline = True
        Me.ItemPurchasedTextBox.Name = "ItemPurchasedTextBox"
        Me.ItemPurchasedTextBox.Size = New System.Drawing.Size(416, 83)
        Me.ItemPurchasedTextBox.TabIndex = 38
        '
        'CustomerLabel
        '
        Me.CustomerLabel.AutoSize = True
        Me.CustomerLabel.Location = New System.Drawing.Point(8, 180)
        Me.CustomerLabel.Name = "CustomerLabel"
        Me.CustomerLabel.Size = New System.Drawing.Size(68, 16)
        Me.CustomerLabel.TabIndex = 20
        Me.CustomerLabel.Text = "Customer:"
        '
        'CustomerTextBox
        '
        Me.CustomerTextBox.BackColor = System.Drawing.Color.White
        Me.CustomerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Customer", True))
        Me.CustomerTextBox.Location = New System.Drawing.Point(158, 177)
        Me.CustomerTextBox.Name = "CustomerTextBox"
        Me.CustomerTextBox.Size = New System.Drawing.Size(416, 22)
        Me.CustomerTextBox.TabIndex = 34
        '
        'VendorLabel
        '
        Me.VendorLabel.AutoSize = True
        Me.VendorLabel.Location = New System.Drawing.Point(8, 157)
        Me.VendorLabel.Name = "VendorLabel"
        Me.VendorLabel.Size = New System.Drawing.Size(55, 16)
        Me.VendorLabel.TabIndex = 19
        Me.VendorLabel.Text = "Vendor:"
        '
        'VendorTextBox
        '
        Me.VendorTextBox.BackColor = System.Drawing.Color.White
        Me.VendorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Vendor", True))
        Me.VendorTextBox.Location = New System.Drawing.Point(158, 154)
        Me.VendorTextBox.Name = "VendorTextBox"
        Me.VendorTextBox.Size = New System.Drawing.Size(416, 22)
        Me.VendorTextBox.TabIndex = 33
        '
        'BookletNoLabel
        '
        Me.BookletNoLabel.AutoSize = True
        Me.BookletNoLabel.Location = New System.Drawing.Point(8, 105)
        Me.BookletNoLabel.Name = "BookletNoLabel"
        Me.BookletNoLabel.Size = New System.Drawing.Size(78, 16)
        Me.BookletNoLabel.TabIndex = 18
        Me.BookletNoLabel.Text = "Booklet No:"
        '
        'BookletNoTextBox
        '
        Me.BookletNoTextBox.BackColor = System.Drawing.Color.White
        Me.BookletNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BookletNo", True))
        Me.BookletNoTextBox.Location = New System.Drawing.Point(158, 102)
        Me.BookletNoTextBox.Name = "BookletNoTextBox"
        Me.BookletNoTextBox.Size = New System.Drawing.Size(123, 22)
        Me.BookletNoTextBox.TabIndex = 28
        '
        'DTDocuRI
        '
        Me.DTDocuRI.Location = New System.Drawing.Point(263, 73)
        Me.DTDocuRI.Name = "DTDocuRI"
        Me.DTDocuRI.Size = New System.Drawing.Size(18, 22)
        Me.DTDocuRI.TabIndex = 27
        '
        'ReferenceNoLabel
        '
        Me.ReferenceNoLabel.AutoSize = True
        Me.ReferenceNoLabel.Location = New System.Drawing.Point(8, 128)
        Me.ReferenceNoLabel.Name = "ReferenceNoLabel"
        Me.ReferenceNoLabel.Size = New System.Drawing.Size(126, 16)
        Me.ReferenceNoLabel.TabIndex = 5
        Me.ReferenceNoLabel.Text = "Receipt/Invoice No:"
        '
        'ReferenceNoRI
        '
        Me.ReferenceNoRI.BackColor = System.Drawing.Color.White
        Me.ReferenceNoRI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ReferenceNo", True))
        Me.ReferenceNoRI.Location = New System.Drawing.Point(158, 125)
        Me.ReferenceNoRI.Name = "ReferenceNoRI"
        Me.ReferenceNoRI.Size = New System.Drawing.Size(123, 22)
        Me.ReferenceNoRI.TabIndex = 29
        '
        'DocumentDateLabel
        '
        Me.DocumentDateLabel.AutoSize = True
        Me.DocumentDateLabel.Location = New System.Drawing.Point(8, 76)
        Me.DocumentDateLabel.Name = "DocumentDateLabel"
        Me.DocumentDateLabel.Size = New System.Drawing.Size(104, 16)
        Me.DocumentDateLabel.TabIndex = 2
        Me.DocumentDateLabel.Text = "Document Date:"
        '
        'Warranty
        '
        Me.Warranty.AutoScroll = True
        Me.Warranty.AutoScrollMinSize = New System.Drawing.Size(0, 420)
        Me.Warranty.BackColor = System.Drawing.SystemColors.Control
        Me.Warranty.Controls.Add(Me.GrpWarranty)
        Me.Warranty.Location = New System.Drawing.Point(4, 29)
        Me.Warranty.Name = "Warranty"
        Me.Warranty.Padding = New System.Windows.Forms.Padding(3)
        Me.Warranty.Size = New System.Drawing.Size(618, 277)
        Me.Warranty.TabIndex = 2
        Me.Warranty.Text = "Warranty"
        '
        'GrpWarranty
        '
        Me.GrpWarranty.BackColor = System.Drawing.Color.Azure
        Me.GrpWarranty.Controls.Add(Me.Label18)
        Me.GrpWarranty.Controls.Add(Me.Label19)
        Me.GrpWarranty.Controls.Add(Me.Label20)
        Me.GrpWarranty.Controls.Add(Me.BoxNoWarranty)
        Me.GrpWarranty.Controls.Add(Me.Label21)
        Me.GrpWarranty.Controls.Add(Me.RackNoWarranty)
        Me.GrpWarranty.Controls.Add(Me.DTDatePurchased)
        Me.GrpWarranty.Controls.Add(Me.EmailLabel)
        Me.GrpWarranty.Controls.Add(Me.EmailTextBox)
        Me.GrpWarranty.Controls.Add(Me.ContactNoLabel)
        Me.GrpWarranty.Controls.Add(Me.ContactNoTextBox)
        Me.GrpWarranty.Controls.Add(Me.AddressLabel)
        Me.GrpWarranty.Controls.Add(Me.AddressTextBox)
        Me.GrpWarranty.Controls.Add(Me.ServiceCenterLabel)
        Me.GrpWarranty.Controls.Add(Me.ServiceCenterTextBox)
        Me.GrpWarranty.Controls.Add(Me.WarrantyPeriodLabel)
        Me.GrpWarranty.Controls.Add(Me.WarrantyPeriodTextBox)
        Me.GrpWarranty.Controls.Add(Me.SerialLabel)
        Me.GrpWarranty.Controls.Add(Me.SerialTextBox)
        Me.GrpWarranty.Controls.Add(Me.TotalValueLabel1)
        Me.GrpWarranty.Controls.Add(Me.TotalValueWarranty)
        Me.GrpWarranty.Controls.Add(Me.ReferenceNoLabel1)
        Me.GrpWarranty.Controls.Add(Me.ReferenceNoTextBox1)
        Me.GrpWarranty.Controls.Add(Me.DatePurchasedLabel)
        Me.GrpWarranty.Controls.Add(Me.DatePurchasedTextBox)
        Me.GrpWarranty.Controls.Add(Me.ProductTypeLabel)
        Me.GrpWarranty.Controls.Add(Me.ProductTypeTextBox)
        Me.GrpWarranty.Controls.Add(Me.ProductBrandLabel)
        Me.GrpWarranty.Controls.Add(Me.ProductBrandTextBox)
        Me.GrpWarranty.Controls.Add(Me.WarrantyNoLabel)
        Me.GrpWarranty.Controls.Add(Me.WarrantyNoTextBox)
        Me.GrpWarranty.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpWarranty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpWarranty.ForeColor = System.Drawing.Color.Black
        Me.GrpWarranty.Location = New System.Drawing.Point(3, 3)
        Me.GrpWarranty.Name = "GrpWarranty"
        Me.GrpWarranty.Size = New System.Drawing.Size(595, 417)
        Me.GrpWarranty.TabIndex = 0
        Me.GrpWarranty.TabStop = False
        Me.GrpWarranty.Text = "Keywords"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(277, 153)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 16)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "mm/dd/yyyy"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(298, 230)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(106, 16)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "(6 mos, 1 yr, etc.)"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(8, 53)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(122, 16)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = "Document Box No.:"
        '
        'BoxNoWarranty
        '
        Me.BoxNoWarranty.BackColor = System.Drawing.Color.White
        Me.BoxNoWarranty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BoxNo", True))
        Me.BoxNoWarranty.Location = New System.Drawing.Point(158, 50)
        Me.BoxNoWarranty.Name = "BoxNoWarranty"
        Me.BoxNoWarranty.Size = New System.Drawing.Size(123, 22)
        Me.BoxNoWarranty.TabIndex = 25
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(8, 30)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(131, 16)
        Me.Label21.TabIndex = 28
        Me.Label21.Text = "Document Rack No.:"
        '
        'RackNoWarranty
        '
        Me.RackNoWarranty.BackColor = System.Drawing.Color.White
        Me.RackNoWarranty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "RackNo", True))
        Me.RackNoWarranty.Location = New System.Drawing.Point(158, 27)
        Me.RackNoWarranty.Name = "RackNoWarranty"
        Me.RackNoWarranty.Size = New System.Drawing.Size(123, 22)
        Me.RackNoWarranty.TabIndex = 24
        '
        'DTDatePurchased
        '
        Me.DTDatePurchased.Location = New System.Drawing.Point(255, 149)
        Me.DTDatePurchased.Name = "DTDatePurchased"
        Me.DTDatePurchased.Size = New System.Drawing.Size(18, 22)
        Me.DTDatePurchased.TabIndex = 30
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(9, 362)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(45, 16)
        Me.EmailLabel.TabIndex = 22
        Me.EmailLabel.Text = "Email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.BackColor = System.Drawing.Color.White
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(158, 359)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(191, 22)
        Me.EmailTextBox.TabIndex = 18
        '
        'ContactNoLabel
        '
        Me.ContactNoLabel.AutoSize = True
        Me.ContactNoLabel.Location = New System.Drawing.Point(9, 339)
        Me.ContactNoLabel.Name = "ContactNoLabel"
        Me.ContactNoLabel.Size = New System.Drawing.Size(77, 16)
        Me.ContactNoLabel.TabIndex = 20
        Me.ContactNoLabel.Text = "Contact No:"
        '
        'ContactNoTextBox
        '
        Me.ContactNoTextBox.BackColor = System.Drawing.Color.White
        Me.ContactNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ContactNo", True))
        Me.ContactNoTextBox.Location = New System.Drawing.Point(158, 336)
        Me.ContactNoTextBox.Name = "ContactNoTextBox"
        Me.ContactNoTextBox.Size = New System.Drawing.Size(191, 22)
        Me.ContactNoTextBox.TabIndex = 36
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(9, 284)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(153, 16)
        Me.AddressLabel.TabIndex = 18
        Me.AddressLabel.Text = "Service Center Address:"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.BackColor = System.Drawing.Color.White
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(158, 281)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(414, 47)
        Me.AddressTextBox.TabIndex = 35
        '
        'ServiceCenterLabel
        '
        Me.ServiceCenterLabel.AutoSize = True
        Me.ServiceCenterLabel.Location = New System.Drawing.Point(9, 261)
        Me.ServiceCenterLabel.Name = "ServiceCenterLabel"
        Me.ServiceCenterLabel.Size = New System.Drawing.Size(99, 16)
        Me.ServiceCenterLabel.TabIndex = 16
        Me.ServiceCenterLabel.Text = "Service Center:"
        '
        'ServiceCenterTextBox
        '
        Me.ServiceCenterTextBox.BackColor = System.Drawing.Color.White
        Me.ServiceCenterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ServiceCenter", True))
        Me.ServiceCenterTextBox.Location = New System.Drawing.Point(158, 258)
        Me.ServiceCenterTextBox.Name = "ServiceCenterTextBox"
        Me.ServiceCenterTextBox.Size = New System.Drawing.Size(414, 22)
        Me.ServiceCenterTextBox.TabIndex = 34
        '
        'WarrantyPeriodLabel
        '
        Me.WarrantyPeriodLabel.AutoSize = True
        Me.WarrantyPeriodLabel.Location = New System.Drawing.Point(9, 230)
        Me.WarrantyPeriodLabel.Name = "WarrantyPeriodLabel"
        Me.WarrantyPeriodLabel.Size = New System.Drawing.Size(108, 16)
        Me.WarrantyPeriodLabel.TabIndex = 14
        Me.WarrantyPeriodLabel.Text = "Warranty Period:"
        '
        'WarrantyPeriodTextBox
        '
        Me.WarrantyPeriodTextBox.BackColor = System.Drawing.Color.White
        Me.WarrantyPeriodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "WarrantyPeriod", True))
        Me.WarrantyPeriodTextBox.Location = New System.Drawing.Point(158, 227)
        Me.WarrantyPeriodTextBox.Name = "WarrantyPeriodTextBox"
        Me.WarrantyPeriodTextBox.Size = New System.Drawing.Size(140, 22)
        Me.WarrantyPeriodTextBox.TabIndex = 33
        '
        'SerialLabel
        '
        Me.SerialLabel.AutoSize = True
        Me.SerialLabel.Location = New System.Drawing.Point(9, 129)
        Me.SerialLabel.Name = "SerialLabel"
        Me.SerialLabel.Size = New System.Drawing.Size(46, 16)
        Me.SerialLabel.TabIndex = 12
        Me.SerialLabel.Text = "Serial:"
        '
        'SerialTextBox
        '
        Me.SerialTextBox.BackColor = System.Drawing.Color.White
        Me.SerialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Serial", True))
        Me.SerialTextBox.Location = New System.Drawing.Point(158, 126)
        Me.SerialTextBox.Name = "SerialTextBox"
        Me.SerialTextBox.Size = New System.Drawing.Size(303, 22)
        Me.SerialTextBox.TabIndex = 28
        '
        'TotalValueLabel1
        '
        Me.TotalValueLabel1.AutoSize = True
        Me.TotalValueLabel1.Location = New System.Drawing.Point(9, 385)
        Me.TotalValueLabel1.Name = "TotalValueLabel1"
        Me.TotalValueLabel1.Size = New System.Drawing.Size(56, 16)
        Me.TotalValueLabel1.TabIndex = 10
        Me.TotalValueLabel1.Text = "Amount:"
        '
        'TotalValueWarranty
        '
        Me.TotalValueWarranty.BackColor = System.Drawing.Color.White
        Me.TotalValueWarranty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "TotalValue", True))
        Me.TotalValueWarranty.Location = New System.Drawing.Point(158, 382)
        Me.TotalValueWarranty.Name = "TotalValueWarranty"
        Me.TotalValueWarranty.Size = New System.Drawing.Size(191, 22)
        Me.TotalValueWarranty.TabIndex = 19
        '
        'ReferenceNoLabel1
        '
        Me.ReferenceNoLabel1.AutoSize = True
        Me.ReferenceNoLabel1.Location = New System.Drawing.Point(9, 184)
        Me.ReferenceNoLabel1.Name = "ReferenceNoLabel1"
        Me.ReferenceNoLabel1.Size = New System.Drawing.Size(75, 16)
        Me.ReferenceNoLabel1.TabIndex = 8
        Me.ReferenceNoLabel1.Text = "Invoice No:"
        '
        'ReferenceNoTextBox1
        '
        Me.ReferenceNoTextBox1.BackColor = System.Drawing.Color.White
        Me.ReferenceNoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ReferenceNo", True))
        Me.ReferenceNoTextBox1.Location = New System.Drawing.Point(158, 181)
        Me.ReferenceNoTextBox1.Name = "ReferenceNoTextBox1"
        Me.ReferenceNoTextBox1.Size = New System.Drawing.Size(140, 22)
        Me.ReferenceNoTextBox1.TabIndex = 31
        '
        'DatePurchasedLabel
        '
        Me.DatePurchasedLabel.AutoSize = True
        Me.DatePurchasedLabel.Location = New System.Drawing.Point(9, 152)
        Me.DatePurchasedLabel.Name = "DatePurchasedLabel"
        Me.DatePurchasedLabel.Size = New System.Drawing.Size(108, 16)
        Me.DatePurchasedLabel.TabIndex = 6
        Me.DatePurchasedLabel.Text = "Date Purchased:"
        '
        'DatePurchasedTextBox
        '
        Me.DatePurchasedTextBox.BackColor = System.Drawing.Color.White
        Me.DatePurchasedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "DatePurchased", True))
        Me.DatePurchasedTextBox.Location = New System.Drawing.Point(158, 149)
        Me.DatePurchasedTextBox.Name = "DatePurchasedTextBox"
        Me.DatePurchasedTextBox.Size = New System.Drawing.Size(95, 22)
        Me.DatePurchasedTextBox.TabIndex = 29
        Me.DatePurchasedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProductTypeLabel
        '
        Me.ProductTypeLabel.AutoSize = True
        Me.ProductTypeLabel.Location = New System.Drawing.Point(9, 106)
        Me.ProductTypeLabel.Name = "ProductTypeLabel"
        Me.ProductTypeLabel.Size = New System.Drawing.Size(92, 16)
        Me.ProductTypeLabel.TabIndex = 4
        Me.ProductTypeLabel.Text = "Product Type:"
        '
        'ProductTypeTextBox
        '
        Me.ProductTypeTextBox.BackColor = System.Drawing.Color.White
        Me.ProductTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ProductType", True))
        Me.ProductTypeTextBox.Location = New System.Drawing.Point(158, 103)
        Me.ProductTypeTextBox.Name = "ProductTypeTextBox"
        Me.ProductTypeTextBox.Size = New System.Drawing.Size(303, 22)
        Me.ProductTypeTextBox.TabIndex = 27
        '
        'ProductBrandLabel
        '
        Me.ProductBrandLabel.AutoSize = True
        Me.ProductBrandLabel.Location = New System.Drawing.Point(9, 83)
        Me.ProductBrandLabel.Name = "ProductBrandLabel"
        Me.ProductBrandLabel.Size = New System.Drawing.Size(96, 16)
        Me.ProductBrandLabel.TabIndex = 2
        Me.ProductBrandLabel.Text = "Product Brand:"
        '
        'ProductBrandTextBox
        '
        Me.ProductBrandTextBox.BackColor = System.Drawing.Color.White
        Me.ProductBrandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ProductBrand", True))
        Me.ProductBrandTextBox.Location = New System.Drawing.Point(158, 80)
        Me.ProductBrandTextBox.Name = "ProductBrandTextBox"
        Me.ProductBrandTextBox.Size = New System.Drawing.Size(303, 22)
        Me.ProductBrandTextBox.TabIndex = 26
        '
        'WarrantyNoLabel
        '
        Me.WarrantyNoLabel.AutoSize = True
        Me.WarrantyNoLabel.Location = New System.Drawing.Point(9, 207)
        Me.WarrantyNoLabel.Name = "WarrantyNoLabel"
        Me.WarrantyNoLabel.Size = New System.Drawing.Size(86, 16)
        Me.WarrantyNoLabel.TabIndex = 0
        Me.WarrantyNoLabel.Text = "Warranty No:"
        '
        'WarrantyNoTextBox
        '
        Me.WarrantyNoTextBox.BackColor = System.Drawing.Color.White
        Me.WarrantyNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "WarrantyNo", True))
        Me.WarrantyNoTextBox.Location = New System.Drawing.Point(158, 204)
        Me.WarrantyNoTextBox.Name = "WarrantyNoTextBox"
        Me.WarrantyNoTextBox.Size = New System.Drawing.Size(140, 22)
        Me.WarrantyNoTextBox.TabIndex = 32
        '
        'Voucher
        '
        Me.Voucher.AutoScroll = True
        Me.Voucher.AutoScrollMinSize = New System.Drawing.Size(0, 500)
        Me.Voucher.BackColor = System.Drawing.SystemColors.Control
        Me.Voucher.Controls.Add(Me.GrpVoucher)
        Me.Voucher.Location = New System.Drawing.Point(4, 29)
        Me.Voucher.Name = "Voucher"
        Me.Voucher.Size = New System.Drawing.Size(618, 277)
        Me.Voucher.TabIndex = 3
        Me.Voucher.Text = "Voucher"
        '
        'GrpVoucher
        '
        Me.GrpVoucher.BackColor = System.Drawing.Color.Azure
        Me.GrpVoucher.Controls.Add(Me.Label31)
        Me.GrpVoucher.Controls.Add(Me.Label22)
        Me.GrpVoucher.Controls.Add(Me.DTDateReceived)
        Me.GrpVoucher.Controls.Add(Me.Label23)
        Me.GrpVoucher.Controls.Add(Me.BoxNoVoucher)
        Me.GrpVoucher.Controls.Add(Me.Label24)
        Me.GrpVoucher.Controls.Add(Me.RackNoVoucher)
        Me.GrpVoucher.Controls.Add(Me.DateReceivedLabel)
        Me.GrpVoucher.Controls.Add(Me.DateReceivedTextBox)
        Me.GrpVoucher.Controls.Add(Me.PaymentFormComboBox)
        Me.GrpVoucher.Controls.Add(Me.DTDocuVoucher)
        Me.GrpVoucher.Controls.Add(Me.ReceivedbyLabel)
        Me.GrpVoucher.Controls.Add(Me.ReceivedbyTextBox)
        Me.GrpVoucher.Controls.Add(Me.RecordedbyLabel)
        Me.GrpVoucher.Controls.Add(Me.RecordedbyTextBox)
        Me.GrpVoucher.Controls.Add(Me.ApprovedbyLabel)
        Me.GrpVoucher.Controls.Add(Me.ApprovedbyTextBox)
        Me.GrpVoucher.Controls.Add(Me.PreparedbyLabel)
        Me.GrpVoucher.Controls.Add(Me.PreparedbyTextBox)
        Me.GrpVoucher.Controls.Add(Me.PayorLabel)
        Me.GrpVoucher.Controls.Add(Me.PayorTextBox)
        Me.GrpVoucher.Controls.Add(Me.PayeeLabel)
        Me.GrpVoucher.Controls.Add(Me.PayeeTextBox)
        Me.GrpVoucher.Controls.Add(Me.TotalValueLabel2)
        Me.GrpVoucher.Controls.Add(Me.TotalValueVoucher)
        Me.GrpVoucher.Controls.Add(Me.PaymentFormLabel)
        Me.GrpVoucher.Controls.Add(Me.VoucherNoLabel)
        Me.GrpVoucher.Controls.Add(Me.VoucherNoTextBox)
        Me.GrpVoucher.Controls.Add(Me.DocumentDateLabel1)
        Me.GrpVoucher.Controls.Add(Me.DocumentDateVoucher)
        Me.GrpVoucher.Controls.Add(Me.TabControl3)
        Me.GrpVoucher.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpVoucher.ForeColor = System.Drawing.Color.Black
        Me.GrpVoucher.Location = New System.Drawing.Point(0, 0)
        Me.GrpVoucher.Name = "GrpVoucher"
        Me.GrpVoucher.Size = New System.Drawing.Size(601, 500)
        Me.GrpVoucher.TabIndex = 1
        Me.GrpVoucher.TabStop = False
        Me.GrpVoucher.Text = "Keywords"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(280, 76)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(82, 16)
        Me.Label31.TabIndex = 37
        Me.Label31.Text = "mm/dd/yyyy"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(280, 444)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(82, 16)
        Me.Label22.TabIndex = 36
        Me.Label22.Text = "mm/dd/yyyy"
        '
        'DTDateReceived
        '
        Me.DTDateReceived.Location = New System.Drawing.Point(259, 441)
        Me.DTDateReceived.Name = "DTDateReceived"
        Me.DTDateReceived.Size = New System.Drawing.Size(18, 22)
        Me.DTDateReceived.TabIndex = 21
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(8, 53)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(122, 16)
        Me.Label23.TabIndex = 29
        Me.Label23.Text = "Document Box No.:"
        '
        'BoxNoVoucher
        '
        Me.BoxNoVoucher.BackColor = System.Drawing.Color.White
        Me.BoxNoVoucher.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BoxNo", True))
        Me.BoxNoVoucher.Location = New System.Drawing.Point(158, 50)
        Me.BoxNoVoucher.Name = "BoxNoVoucher"
        Me.BoxNoVoucher.Size = New System.Drawing.Size(123, 22)
        Me.BoxNoVoucher.TabIndex = 25
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(8, 30)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(131, 16)
        Me.Label24.TabIndex = 28
        Me.Label24.Text = "Document Rack No.:"
        '
        'RackNoVoucher
        '
        Me.RackNoVoucher.BackColor = System.Drawing.Color.White
        Me.RackNoVoucher.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "RackNo", True))
        Me.RackNoVoucher.Location = New System.Drawing.Point(158, 27)
        Me.RackNoVoucher.Name = "RackNoVoucher"
        Me.RackNoVoucher.Size = New System.Drawing.Size(123, 22)
        Me.RackNoVoucher.TabIndex = 24
        '
        'DateReceivedLabel
        '
        Me.DateReceivedLabel.AutoSize = True
        Me.DateReceivedLabel.Location = New System.Drawing.Point(8, 444)
        Me.DateReceivedLabel.Name = "DateReceivedLabel"
        Me.DateReceivedLabel.Size = New System.Drawing.Size(102, 16)
        Me.DateReceivedLabel.TabIndex = 26
        Me.DateReceivedLabel.Text = "Date Received:"
        '
        'DateReceivedTextBox
        '
        Me.DateReceivedTextBox.BackColor = System.Drawing.Color.White
        Me.DateReceivedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "DateReceived", True))
        Me.DateReceivedTextBox.Location = New System.Drawing.Point(158, 441)
        Me.DateReceivedTextBox.Name = "DateReceivedTextBox"
        Me.DateReceivedTextBox.Size = New System.Drawing.Size(100, 22)
        Me.DateReceivedTextBox.TabIndex = 27
        Me.DateReceivedTextBox.TabStop = False
        '
        'PaymentFormComboBox
        '
        Me.PaymentFormComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "PaymentForm", True))
        Me.PaymentFormComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PaymentFormComboBox.FormattingEnabled = True
        Me.PaymentFormComboBox.ItemHeight = 16
        Me.PaymentFormComboBox.Location = New System.Drawing.Point(158, 180)
        Me.PaymentFormComboBox.Name = "PaymentFormComboBox"
        Me.PaymentFormComboBox.Size = New System.Drawing.Size(183, 24)
        Me.PaymentFormComboBox.TabIndex = 31
        '
        'DTDocuVoucher
        '
        Me.DTDocuVoucher.Location = New System.Drawing.Point(259, 73)
        Me.DTDocuVoucher.Name = "DTDocuVoucher"
        Me.DTDocuVoucher.Size = New System.Drawing.Size(18, 22)
        Me.DTDocuVoucher.TabIndex = 27
        '
        'ReceivedbyLabel
        '
        Me.ReceivedbyLabel.AutoSize = True
        Me.ReceivedbyLabel.ForeColor = System.Drawing.Color.Black
        Me.ReceivedbyLabel.Location = New System.Drawing.Point(8, 421)
        Me.ReceivedbyLabel.Name = "ReceivedbyLabel"
        Me.ReceivedbyLabel.Size = New System.Drawing.Size(89, 16)
        Me.ReceivedbyLabel.TabIndex = 20
        Me.ReceivedbyLabel.Text = "Received By:"
        '
        'ReceivedbyTextBox
        '
        Me.ReceivedbyTextBox.BackColor = System.Drawing.Color.White
        Me.ReceivedbyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Receivedby", True))
        Me.ReceivedbyTextBox.Location = New System.Drawing.Point(158, 418)
        Me.ReceivedbyTextBox.Name = "ReceivedbyTextBox"
        Me.ReceivedbyTextBox.Size = New System.Drawing.Size(326, 22)
        Me.ReceivedbyTextBox.TabIndex = 20
        '
        'RecordedbyLabel
        '
        Me.RecordedbyLabel.AutoSize = True
        Me.RecordedbyLabel.ForeColor = System.Drawing.Color.Black
        Me.RecordedbyLabel.Location = New System.Drawing.Point(8, 398)
        Me.RecordedbyLabel.Name = "RecordedbyLabel"
        Me.RecordedbyLabel.Size = New System.Drawing.Size(91, 16)
        Me.RecordedbyLabel.TabIndex = 18
        Me.RecordedbyLabel.Text = "Recorded By:"
        '
        'RecordedbyTextBox
        '
        Me.RecordedbyTextBox.BackColor = System.Drawing.Color.White
        Me.RecordedbyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Recordedby", True))
        Me.RecordedbyTextBox.Location = New System.Drawing.Point(158, 395)
        Me.RecordedbyTextBox.Name = "RecordedbyTextBox"
        Me.RecordedbyTextBox.Size = New System.Drawing.Size(326, 22)
        Me.RecordedbyTextBox.TabIndex = 19
        '
        'ApprovedbyLabel
        '
        Me.ApprovedbyLabel.AutoSize = True
        Me.ApprovedbyLabel.ForeColor = System.Drawing.Color.Black
        Me.ApprovedbyLabel.Location = New System.Drawing.Point(8, 375)
        Me.ApprovedbyLabel.Name = "ApprovedbyLabel"
        Me.ApprovedbyLabel.Size = New System.Drawing.Size(90, 16)
        Me.ApprovedbyLabel.TabIndex = 16
        Me.ApprovedbyLabel.Text = "Approved By:"
        '
        'ApprovedbyTextBox
        '
        Me.ApprovedbyTextBox.BackColor = System.Drawing.Color.White
        Me.ApprovedbyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Approvedby", True))
        Me.ApprovedbyTextBox.Location = New System.Drawing.Point(158, 372)
        Me.ApprovedbyTextBox.Name = "ApprovedbyTextBox"
        Me.ApprovedbyTextBox.Size = New System.Drawing.Size(326, 22)
        Me.ApprovedbyTextBox.TabIndex = 18
        '
        'PreparedbyLabel
        '
        Me.PreparedbyLabel.AutoSize = True
        Me.PreparedbyLabel.ForeColor = System.Drawing.Color.Black
        Me.PreparedbyLabel.Location = New System.Drawing.Point(8, 352)
        Me.PreparedbyLabel.Name = "PreparedbyLabel"
        Me.PreparedbyLabel.Size = New System.Drawing.Size(87, 16)
        Me.PreparedbyLabel.TabIndex = 14
        Me.PreparedbyLabel.Text = "Prepared By:"
        '
        'PreparedbyTextBox
        '
        Me.PreparedbyTextBox.BackColor = System.Drawing.Color.White
        Me.PreparedbyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Preparedby", True))
        Me.PreparedbyTextBox.Location = New System.Drawing.Point(158, 349)
        Me.PreparedbyTextBox.Name = "PreparedbyTextBox"
        Me.PreparedbyTextBox.Size = New System.Drawing.Size(326, 22)
        Me.PreparedbyTextBox.TabIndex = 17
        '
        'PayorLabel
        '
        Me.PayorLabel.AutoSize = True
        Me.PayorLabel.ForeColor = System.Drawing.Color.Black
        Me.PayorLabel.Location = New System.Drawing.Point(8, 129)
        Me.PayorLabel.Name = "PayorLabel"
        Me.PayorLabel.Size = New System.Drawing.Size(47, 16)
        Me.PayorLabel.TabIndex = 12
        Me.PayorLabel.Text = "Payor:"
        '
        'PayorTextBox
        '
        Me.PayorTextBox.BackColor = System.Drawing.Color.White
        Me.PayorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Payor", True))
        Me.PayorTextBox.Location = New System.Drawing.Point(158, 126)
        Me.PayorTextBox.Name = "PayorTextBox"
        Me.PayorTextBox.Size = New System.Drawing.Size(406, 22)
        Me.PayorTextBox.TabIndex = 29
        '
        'PayeeLabel
        '
        Me.PayeeLabel.AutoSize = True
        Me.PayeeLabel.ForeColor = System.Drawing.Color.Black
        Me.PayeeLabel.Location = New System.Drawing.Point(8, 106)
        Me.PayeeLabel.Name = "PayeeLabel"
        Me.PayeeLabel.Size = New System.Drawing.Size(51, 16)
        Me.PayeeLabel.TabIndex = 10
        Me.PayeeLabel.Text = "Payee:"
        '
        'PayeeTextBox
        '
        Me.PayeeTextBox.BackColor = System.Drawing.Color.White
        Me.PayeeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Payee", True))
        Me.PayeeTextBox.Location = New System.Drawing.Point(158, 103)
        Me.PayeeTextBox.Name = "PayeeTextBox"
        Me.PayeeTextBox.Size = New System.Drawing.Size(406, 22)
        Me.PayeeTextBox.TabIndex = 28
        '
        'TotalValueLabel2
        '
        Me.TotalValueLabel2.AutoSize = True
        Me.TotalValueLabel2.ForeColor = System.Drawing.Color.Black
        Me.TotalValueLabel2.Location = New System.Drawing.Point(8, 329)
        Me.TotalValueLabel2.Name = "TotalValueLabel2"
        Me.TotalValueLabel2.Size = New System.Drawing.Size(56, 16)
        Me.TotalValueLabel2.TabIndex = 8
        Me.TotalValueLabel2.Text = "Amount:"
        '
        'TotalValueVoucher
        '
        Me.TotalValueVoucher.BackColor = System.Drawing.Color.White
        Me.TotalValueVoucher.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "TotalValue", True))
        Me.TotalValueVoucher.Location = New System.Drawing.Point(158, 326)
        Me.TotalValueVoucher.Name = "TotalValueVoucher"
        Me.TotalValueVoucher.Size = New System.Drawing.Size(183, 22)
        Me.TotalValueVoucher.TabIndex = 35
        '
        'PaymentFormLabel
        '
        Me.PaymentFormLabel.AutoSize = True
        Me.PaymentFormLabel.ForeColor = System.Drawing.Color.Black
        Me.PaymentFormLabel.Location = New System.Drawing.Point(8, 183)
        Me.PaymentFormLabel.Name = "PaymentFormLabel"
        Me.PaymentFormLabel.Size = New System.Drawing.Size(112, 16)
        Me.PaymentFormLabel.TabIndex = 4
        Me.PaymentFormLabel.Text = "Form of Payment:"
        '
        'VoucherNoLabel
        '
        Me.VoucherNoLabel.AutoSize = True
        Me.VoucherNoLabel.ForeColor = System.Drawing.Color.Black
        Me.VoucherNoLabel.Location = New System.Drawing.Point(8, 152)
        Me.VoucherNoLabel.Name = "VoucherNoLabel"
        Me.VoucherNoLabel.Size = New System.Drawing.Size(82, 16)
        Me.VoucherNoLabel.TabIndex = 2
        Me.VoucherNoLabel.Text = "Voucher No:"
        '
        'VoucherNoTextBox
        '
        Me.VoucherNoTextBox.BackColor = System.Drawing.Color.White
        Me.VoucherNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "VoucherNo", True))
        Me.VoucherNoTextBox.Location = New System.Drawing.Point(158, 149)
        Me.VoucherNoTextBox.Name = "VoucherNoTextBox"
        Me.VoucherNoTextBox.Size = New System.Drawing.Size(183, 22)
        Me.VoucherNoTextBox.TabIndex = 30
        '
        'DocumentDateLabel1
        '
        Me.DocumentDateLabel1.AutoSize = True
        Me.DocumentDateLabel1.ForeColor = System.Drawing.Color.Black
        Me.DocumentDateLabel1.Location = New System.Drawing.Point(8, 76)
        Me.DocumentDateLabel1.Name = "DocumentDateLabel1"
        Me.DocumentDateLabel1.Size = New System.Drawing.Size(104, 16)
        Me.DocumentDateLabel1.TabIndex = 0
        Me.DocumentDateLabel1.Text = "Document Date:"
        '
        'DocumentDateVoucher
        '
        Me.DocumentDateVoucher.AcceptsReturn = True
        Me.DocumentDateVoucher.BackColor = System.Drawing.Color.White
        Me.DocumentDateVoucher.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "DocumentDate", True))
        Me.DocumentDateVoucher.Location = New System.Drawing.Point(158, 73)
        Me.DocumentDateVoucher.Name = "DocumentDateVoucher"
        Me.DocumentDateVoucher.Size = New System.Drawing.Size(100, 22)
        Me.DocumentDateVoucher.TabIndex = 26
        Me.DocumentDateVoucher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabControl3
        '
        Me.TabControl3.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl3.Controls.Add(Me.BankDepo)
        Me.TabControl3.Controls.Add(Me.Others)
        Me.TabControl3.Controls.Add(Me.Check)
        Me.TabControl3.Location = New System.Drawing.Point(0, 202)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(601, 129)
        Me.TabControl3.TabIndex = 21
        Me.TabControl3.TabStop = False
        '
        'BankDepo
        '
        Me.BankDepo.AutoScroll = True
        Me.BankDepo.BackColor = System.Drawing.Color.Azure
        Me.BankDepo.Controls.Add(Me.BankAddressLabel)
        Me.BankDepo.Controls.Add(Me.BankAddressTextBox)
        Me.BankDepo.Controls.Add(Me.BankBranchLabel)
        Me.BankDepo.Controls.Add(Me.BankBranchTextBox)
        Me.BankDepo.Controls.Add(Me.BankNameLabel)
        Me.BankDepo.Controls.Add(Me.BankNameTextBox)
        Me.BankDepo.Location = New System.Drawing.Point(4, 28)
        Me.BankDepo.Name = "BankDepo"
        Me.BankDepo.Padding = New System.Windows.Forms.Padding(3)
        Me.BankDepo.Size = New System.Drawing.Size(593, 97)
        Me.BankDepo.TabIndex = 0
        Me.BankDepo.Text = "BankDepo"
        '
        'BankAddressLabel
        '
        Me.BankAddressLabel.AutoSize = True
        Me.BankAddressLabel.Location = New System.Drawing.Point(4, 51)
        Me.BankAddressLabel.Name = "BankAddressLabel"
        Me.BankAddressLabel.Size = New System.Drawing.Size(96, 16)
        Me.BankAddressLabel.TabIndex = 4
        Me.BankAddressLabel.Text = "Bank Address:"
        '
        'BankAddressTextBox
        '
        Me.BankAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BankAddress", True))
        Me.BankAddressTextBox.Location = New System.Drawing.Point(154, 48)
        Me.BankAddressTextBox.Multiline = True
        Me.BankAddressTextBox.Name = "BankAddressTextBox"
        Me.BankAddressTextBox.Size = New System.Drawing.Size(367, 46)
        Me.BankAddressTextBox.TabIndex = 34
        '
        'BankBranchLabel
        '
        Me.BankBranchLabel.AutoSize = True
        Me.BankBranchLabel.Location = New System.Drawing.Point(4, 28)
        Me.BankBranchLabel.Name = "BankBranchLabel"
        Me.BankBranchLabel.Size = New System.Drawing.Size(87, 16)
        Me.BankBranchLabel.TabIndex = 2
        Me.BankBranchLabel.Text = "Bank Branch:"
        '
        'BankBranchTextBox
        '
        Me.BankBranchTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BankBranch", True))
        Me.BankBranchTextBox.Location = New System.Drawing.Point(154, 25)
        Me.BankBranchTextBox.Name = "BankBranchTextBox"
        Me.BankBranchTextBox.Size = New System.Drawing.Size(367, 22)
        Me.BankBranchTextBox.TabIndex = 33
        '
        'BankNameLabel
        '
        Me.BankNameLabel.AutoSize = True
        Me.BankNameLabel.Location = New System.Drawing.Point(4, 5)
        Me.BankNameLabel.Name = "BankNameLabel"
        Me.BankNameLabel.Size = New System.Drawing.Size(82, 16)
        Me.BankNameLabel.TabIndex = 0
        Me.BankNameLabel.Text = "Bank Name:"
        '
        'BankNameTextBox
        '
        Me.BankNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BankName", True))
        Me.BankNameTextBox.Location = New System.Drawing.Point(154, 2)
        Me.BankNameTextBox.Name = "BankNameTextBox"
        Me.BankNameTextBox.Size = New System.Drawing.Size(367, 22)
        Me.BankNameTextBox.TabIndex = 32
        '
        'Others
        '
        Me.Others.AutoScroll = True
        Me.Others.BackColor = System.Drawing.Color.Azure
        Me.Others.Controls.Add(Me.PaymentOthersLabel)
        Me.Others.Controls.Add(Me.PaymentOthersTextBox)
        Me.Others.Location = New System.Drawing.Point(4, 28)
        Me.Others.Name = "Others"
        Me.Others.Padding = New System.Windows.Forms.Padding(3)
        Me.Others.Size = New System.Drawing.Size(593, 97)
        Me.Others.TabIndex = 1
        Me.Others.Text = "Others"
        '
        'PaymentOthersLabel
        '
        Me.PaymentOthersLabel.AutoSize = True
        Me.PaymentOthersLabel.Location = New System.Drawing.Point(7, 7)
        Me.PaymentOthersLabel.Name = "PaymentOthersLabel"
        Me.PaymentOthersLabel.Size = New System.Drawing.Size(102, 16)
        Me.PaymentOthersLabel.TabIndex = 0
        Me.PaymentOthersLabel.Text = "Please Specify:"
        '
        'PaymentOthersTextBox
        '
        Me.PaymentOthersTextBox.BackColor = System.Drawing.Color.White
        Me.PaymentOthersTextBox.Location = New System.Drawing.Point(154, 4)
        Me.PaymentOthersTextBox.Name = "PaymentOthersTextBox"
        Me.PaymentOthersTextBox.Size = New System.Drawing.Size(367, 22)
        Me.PaymentOthersTextBox.TabIndex = 32
        '
        'Check
        '
        Me.Check.BackColor = System.Drawing.Color.Azure
        Me.Check.Controls.Add(Me.CheckNoTextBox)
        Me.Check.Controls.Add(Me.CheckNoLabel)
        Me.Check.Location = New System.Drawing.Point(4, 28)
        Me.Check.Name = "Check"
        Me.Check.Size = New System.Drawing.Size(593, 97)
        Me.Check.TabIndex = 2
        Me.Check.Text = "Check"
        '
        'CheckNoTextBox
        '
        Me.CheckNoTextBox.BackColor = System.Drawing.Color.White
        Me.CheckNoTextBox.Location = New System.Drawing.Point(154, 4)
        Me.CheckNoTextBox.Name = "CheckNoTextBox"
        Me.CheckNoTextBox.Size = New System.Drawing.Size(367, 22)
        Me.CheckNoTextBox.TabIndex = 32
        '
        'CheckNoLabel
        '
        Me.CheckNoLabel.AutoSize = True
        Me.CheckNoLabel.ForeColor = System.Drawing.Color.Black
        Me.CheckNoLabel.Location = New System.Drawing.Point(7, 7)
        Me.CheckNoLabel.Name = "CheckNoLabel"
        Me.CheckNoLabel.Size = New System.Drawing.Size(70, 16)
        Me.CheckNoLabel.TabIndex = 6
        Me.CheckNoLabel.Text = "Check No:"
        '
        'CorpDocu
        '
        Me.CorpDocu.AutoScroll = True
        Me.CorpDocu.AutoScrollMinSize = New System.Drawing.Size(0, 350)
        Me.CorpDocu.BackColor = System.Drawing.SystemColors.Control
        Me.CorpDocu.Controls.Add(Me.GrpCorp)
        Me.CorpDocu.Location = New System.Drawing.Point(4, 29)
        Me.CorpDocu.Name = "CorpDocu"
        Me.CorpDocu.Size = New System.Drawing.Size(618, 277)
        Me.CorpDocu.TabIndex = 4
        Me.CorpDocu.Text = "CorpDocu"
        '
        'GrpCorp
        '
        Me.GrpCorp.BackColor = System.Drawing.Color.Azure
        Me.GrpCorp.Controls.Add(Me.TabControl4)
        Me.GrpCorp.Controls.Add(Me.Label26)
        Me.GrpCorp.Controls.Add(Me.Label27)
        Me.GrpCorp.Controls.Add(Me.BoxNoCorpDocu)
        Me.GrpCorp.Controls.Add(Me.Label28)
        Me.GrpCorp.Controls.Add(Me.RackNoCorpDocu)
        Me.GrpCorp.Controls.Add(Me.DTDocuCorp)
        Me.GrpCorp.Controls.Add(Me.PurposeLabel)
        Me.GrpCorp.Controls.Add(Me.PurposeTextBox)
        Me.GrpCorp.Controls.Add(Me.DocumentDateLabel2)
        Me.GrpCorp.Controls.Add(Me.DocumentDateCorp)
        Me.GrpCorp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpCorp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpCorp.ForeColor = System.Drawing.Color.Black
        Me.GrpCorp.Location = New System.Drawing.Point(0, 0)
        Me.GrpCorp.Name = "GrpCorp"
        Me.GrpCorp.Size = New System.Drawing.Size(601, 350)
        Me.GrpCorp.TabIndex = 1
        Me.GrpCorp.TabStop = False
        Me.GrpCorp.Text = "Keywords"
        '
        'TabControl4
        '
        Me.TabControl4.Controls.Add(Me.TabMeeting)
        Me.TabControl4.Controls.Add(Me.TabPromo)
        Me.TabControl4.Controls.Add(Me.TabMeeting2)
        Me.TabControl4.Location = New System.Drawing.Point(0, 95)
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.SelectedIndex = 0
        Me.TabControl4.Size = New System.Drawing.Size(601, 129)
        Me.TabControl4.TabIndex = 46
        Me.TabControl4.TabStop = False
        '
        'TabMeeting
        '
        Me.TabMeeting.BackColor = System.Drawing.Color.Azure
        Me.TabMeeting.Controls.Add(Me.Label25)
        Me.TabMeeting.Controls.Add(Me.DTMeetingDate)
        Me.TabMeeting.Controls.Add(Me.MeetingDateLabel)
        Me.TabMeeting.Controls.Add(Me.MeetingDateTextBox)
        Me.TabMeeting.Controls.Add(Me.SecretaryLabel)
        Me.TabMeeting.Controls.Add(Me.SecretaryTextBox)
        Me.TabMeeting.Controls.Add(Me.CompanyLabel)
        Me.TabMeeting.Controls.Add(Me.CompanyTextBox)
        Me.TabMeeting.Location = New System.Drawing.Point(4, 25)
        Me.TabMeeting.Name = "TabMeeting"
        Me.TabMeeting.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMeeting.Size = New System.Drawing.Size(593, 100)
        Me.TabMeeting.TabIndex = 0
        Me.TabMeeting.Text = "Meeting"
        '
        'DTMeetingDate
        '
        Me.DTMeetingDate.Location = New System.Drawing.Point(255, 5)
        Me.DTMeetingDate.Name = "DTMeetingDate"
        Me.DTMeetingDate.Size = New System.Drawing.Size(18, 22)
        Me.DTMeetingDate.TabIndex = 29
        '
        'MeetingDateTextBox
        '
        Me.MeetingDateTextBox.BackColor = System.Drawing.Color.White
        Me.MeetingDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "MeetingDate", True))
        Me.MeetingDateTextBox.Location = New System.Drawing.Point(154, 5)
        Me.MeetingDateTextBox.Name = "MeetingDateTextBox"
        Me.MeetingDateTextBox.Size = New System.Drawing.Size(100, 22)
        Me.MeetingDateTextBox.TabIndex = 28
        Me.MeetingDateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SecretaryTextBox
        '
        Me.SecretaryTextBox.BackColor = System.Drawing.Color.White
        Me.SecretaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Secretary", True))
        Me.SecretaryTextBox.Location = New System.Drawing.Point(154, 51)
        Me.SecretaryTextBox.Name = "SecretaryTextBox"
        Me.SecretaryTextBox.Size = New System.Drawing.Size(229, 22)
        Me.SecretaryTextBox.TabIndex = 31
        '
        'CompanyTextBox
        '
        Me.CompanyTextBox.BackColor = System.Drawing.Color.White
        Me.CompanyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Company", True))
        Me.CompanyTextBox.Location = New System.Drawing.Point(154, 28)
        Me.CompanyTextBox.Name = "CompanyTextBox"
        Me.CompanyTextBox.Size = New System.Drawing.Size(374, 22)
        Me.CompanyTextBox.TabIndex = 30
        '
        'TabPromo
        '
        Me.TabPromo.BackColor = System.Drawing.Color.Azure
        Me.TabPromo.Controls.Add(Me.Label33)
        Me.TabPromo.Controls.Add(Me.Label34)
        Me.TabPromo.Controls.Add(Me.DTPromoTo)
        Me.TabPromo.Controls.Add(Me.DTPromoFrom)
        Me.TabPromo.Controls.Add(Me.DTIPermitNoLabel)
        Me.TabPromo.Controls.Add(Me.DTIPermitNoTextBox)
        Me.TabPromo.Controls.Add(Me.PromoToLabel)
        Me.TabPromo.Controls.Add(Me.PromoToTextBox)
        Me.TabPromo.Controls.Add(Me.PromoFromLabel)
        Me.TabPromo.Controls.Add(Me.PromoFromTextBox)
        Me.TabPromo.Controls.Add(Me.PromoTitleLabel)
        Me.TabPromo.Controls.Add(Me.PromoTitleTextBox)
        Me.TabPromo.Location = New System.Drawing.Point(4, 25)
        Me.TabPromo.Name = "TabPromo"
        Me.TabPromo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPromo.Size = New System.Drawing.Size(593, 100)
        Me.TabPromo.TabIndex = 1
        Me.TabPromo.Text = "Promo"
        '
        'DTPromoTo
        '
        Me.DTPromoTo.Location = New System.Drawing.Point(255, 50)
        Me.DTPromoTo.Name = "DTPromoTo"
        Me.DTPromoTo.Size = New System.Drawing.Size(18, 22)
        Me.DTPromoTo.TabIndex = 32
        '
        'DTPromoFrom
        '
        Me.DTPromoFrom.Location = New System.Drawing.Point(255, 28)
        Me.DTPromoFrom.Name = "DTPromoFrom"
        Me.DTPromoFrom.Size = New System.Drawing.Size(18, 22)
        Me.DTPromoFrom.TabIndex = 30
        '
        'DTIPermitNoTextBox
        '
        Me.DTIPermitNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "DTIPermitNo", True))
        Me.DTIPermitNoTextBox.Location = New System.Drawing.Point(154, 73)
        Me.DTIPermitNoTextBox.Name = "DTIPermitNoTextBox"
        Me.DTIPermitNoTextBox.Size = New System.Drawing.Size(229, 22)
        Me.DTIPermitNoTextBox.TabIndex = 33
        '
        'PromoToTextBox
        '
        Me.PromoToTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "PromoTo", True))
        Me.PromoToTextBox.Location = New System.Drawing.Point(154, 50)
        Me.PromoToTextBox.Name = "PromoToTextBox"
        Me.PromoToTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PromoToTextBox.TabIndex = 31
        '
        'PromoFromTextBox
        '
        Me.PromoFromTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "PromoFrom", True))
        Me.PromoFromTextBox.Location = New System.Drawing.Point(154, 27)
        Me.PromoFromTextBox.Name = "PromoFromTextBox"
        Me.PromoFromTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PromoFromTextBox.TabIndex = 29
        '
        'PromoTitleTextBox
        '
        Me.PromoTitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "PromoTitle", True))
        Me.PromoTitleTextBox.Location = New System.Drawing.Point(154, 4)
        Me.PromoTitleTextBox.Name = "PromoTitleTextBox"
        Me.PromoTitleTextBox.Size = New System.Drawing.Size(344, 22)
        Me.PromoTitleTextBox.TabIndex = 28
        '
        'TabMeeting2
        '
        Me.TabMeeting2.BackColor = System.Drawing.Color.Azure
        Me.TabMeeting2.Controls.Add(Me.Label35)
        Me.TabMeeting2.Controls.Add(Me.TextBox1)
        Me.TabMeeting2.Location = New System.Drawing.Point(4, 25)
        Me.TabMeeting2.Name = "TabMeeting2"
        Me.TabMeeting2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMeeting2.Size = New System.Drawing.Size(593, 100)
        Me.TabMeeting2.TabIndex = 2
        Me.TabMeeting2.Text = "TabMeeting2"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(4, 7)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(69, 16)
        Me.Label35.TabIndex = 43
        Me.Label35.Text = "Company:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Company", True))
        Me.TextBox1.Location = New System.Drawing.Point(154, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(374, 22)
        Me.TextBox1.TabIndex = 28
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(281, 75)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(82, 16)
        Me.Label26.TabIndex = 36
        Me.Label26.Text = "mm/dd/yyyy"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(8, 53)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(122, 16)
        Me.Label27.TabIndex = 33
        Me.Label27.Text = "Document Box No.:"
        '
        'BoxNoCorpDocu
        '
        Me.BoxNoCorpDocu.BackColor = System.Drawing.Color.White
        Me.BoxNoCorpDocu.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BoxNo", True))
        Me.BoxNoCorpDocu.Location = New System.Drawing.Point(158, 50)
        Me.BoxNoCorpDocu.Name = "BoxNoCorpDocu"
        Me.BoxNoCorpDocu.Size = New System.Drawing.Size(123, 22)
        Me.BoxNoCorpDocu.TabIndex = 25
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(8, 30)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(131, 16)
        Me.Label28.TabIndex = 32
        Me.Label28.Text = "Document Rack No.:"
        '
        'RackNoCorpDocu
        '
        Me.RackNoCorpDocu.BackColor = System.Drawing.Color.White
        Me.RackNoCorpDocu.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "RackNo", True))
        Me.RackNoCorpDocu.Location = New System.Drawing.Point(158, 27)
        Me.RackNoCorpDocu.Name = "RackNoCorpDocu"
        Me.RackNoCorpDocu.Size = New System.Drawing.Size(123, 22)
        Me.RackNoCorpDocu.TabIndex = 24
        '
        'DTDocuCorp
        '
        Me.DTDocuCorp.Location = New System.Drawing.Point(259, 73)
        Me.DTDocuCorp.Name = "DTDocuCorp"
        Me.DTDocuCorp.Size = New System.Drawing.Size(18, 22)
        Me.DTDocuCorp.TabIndex = 27
        '
        'PurposeLabel
        '
        Me.PurposeLabel.AutoSize = True
        Me.PurposeLabel.Location = New System.Drawing.Point(8, 228)
        Me.PurposeLabel.Name = "PurposeLabel"
        Me.PurposeLabel.Size = New System.Drawing.Size(62, 16)
        Me.PurposeLabel.TabIndex = 4
        Me.PurposeLabel.Text = "Purpose:"
        '
        'PurposeTextBox
        '
        Me.PurposeTextBox.BackColor = System.Drawing.Color.White
        Me.PurposeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Purpose", True))
        Me.PurposeTextBox.Location = New System.Drawing.Point(158, 225)
        Me.PurposeTextBox.Name = "PurposeTextBox"
        Me.PurposeTextBox.Size = New System.Drawing.Size(416, 22)
        Me.PurposeTextBox.TabIndex = 34
        '
        'DocumentDateLabel2
        '
        Me.DocumentDateLabel2.AutoSize = True
        Me.DocumentDateLabel2.ForeColor = System.Drawing.Color.Black
        Me.DocumentDateLabel2.Location = New System.Drawing.Point(8, 76)
        Me.DocumentDateLabel2.Name = "DocumentDateLabel2"
        Me.DocumentDateLabel2.Size = New System.Drawing.Size(104, 16)
        Me.DocumentDateLabel2.TabIndex = 0
        Me.DocumentDateLabel2.Text = "Document Date:"
        '
        'DocumentDateCorp
        '
        Me.DocumentDateCorp.BackColor = System.Drawing.Color.White
        Me.DocumentDateCorp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "DocumentDate", True))
        Me.DocumentDateCorp.Location = New System.Drawing.Point(158, 73)
        Me.DocumentDateCorp.Name = "DocumentDateCorp"
        Me.DocumentDateCorp.Size = New System.Drawing.Size(100, 22)
        Me.DocumentDateCorp.TabIndex = 26
        Me.DocumentDateCorp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AcroPDF
        '
        Me.AcroPDF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AcroPDF.Enabled = True
        Me.AcroPDF.Location = New System.Drawing.Point(0, 0)
        Me.AcroPDF.Name = "AcroPDF"
        Me.AcroPDF.OcxState = CType(resources.GetObject("AcroPDF.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AcroPDF.Size = New System.Drawing.Size(610, 518)
        Me.AcroPDF.TabIndex = 91
        Me.AcroPDF.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnRemoval
        '
        Me.BtnRemoval.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnRemoval.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRemoval.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemoval.Location = New System.Drawing.Point(185, 7)
        Me.BtnRemoval.Name = "BtnRemoval"
        Me.BtnRemoval.Size = New System.Drawing.Size(106, 28)
        Me.BtnRemoval.TabIndex = 3
        Me.BtnRemoval.Text = "For Removal"
        Me.BtnRemoval.UseVisualStyleBackColor = False
        '
        'C1TrueDBGrid2
        '
        Me.C1TrueDBGrid2.AlternatingRows = True
        Me.C1TrueDBGrid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1TrueDBGrid2.FilterBar = True
        Me.C1TrueDBGrid2.FlatStyle = C1.Win.C1TrueDBGrid.FlatModeEnum.Flat
        Me.C1TrueDBGrid2.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1TrueDBGrid2.Images.Add(CType(resources.GetObject("C1TrueDBGrid2.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid2.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid2.Name = "C1TrueDBGrid2"
        Me.C1TrueDBGrid2.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid2.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid2.PreviewInfo.ZoomFactor = 75.0R
        Me.C1TrueDBGrid2.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid2.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid2.Size = New System.Drawing.Size(1240, 235)
        Me.C1TrueDBGrid2.TabIndex = 0
        Me.C1TrueDBGrid2.UseCompatibleTextRendering = False
        Me.C1TrueDBGrid2.PropBag = resources.GetString("C1TrueDBGrid2.PropBag")
        '
        'DocsCatalogueBindingSource
        '
        Me.DocsCatalogueBindingSource.DataMember = "DocsCatalogue"
        Me.DocsCatalogueBindingSource.DataSource = Me.DMSDataSet
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
        Me.TableAdapterManager.DocsRemovalTableAdapter = Nothing
        Me.TableAdapterManager.DocumentGroupsTableAdapter = Nothing
        Me.TableAdapterManager.DocumentTypesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DMS.DMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DocsCatalogueTableAdapter
        '
        Me.DocsCatalogueTableAdapter.ClearBeforeFill = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(610, 518)
        Me.WebBrowser1.TabIndex = 92
        '
        'FrmSearch2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1240, 757)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSearch2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabQuery.ResumeLayout(False)
        Me.TabQuery.PerformLayout()
        Me.TabChanges.ResumeLayout(False)
        Me.TabChanges.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.Timesheet.ResumeLayout(False)
        Me.GrpTimeSheet.ResumeLayout(False)
        Me.GrpTimeSheet.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ReceiptInvoice.ResumeLayout(False)
        Me.GrpReceipt.ResumeLayout(False)
        Me.GrpReceipt.PerformLayout()
        Me.Warranty.ResumeLayout(False)
        Me.GrpWarranty.ResumeLayout(False)
        Me.GrpWarranty.PerformLayout()
        Me.Voucher.ResumeLayout(False)
        Me.GrpVoucher.ResumeLayout(False)
        Me.GrpVoucher.PerformLayout()
        Me.TabControl3.ResumeLayout(False)
        Me.BankDepo.ResumeLayout(False)
        Me.BankDepo.PerformLayout()
        Me.Others.ResumeLayout(False)
        Me.Others.PerformLayout()
        Me.Check.ResumeLayout(False)
        Me.Check.PerformLayout()
        Me.CorpDocu.ResumeLayout(False)
        Me.GrpCorp.ResumeLayout(False)
        Me.GrpCorp.PerformLayout()
        Me.TabControl4.ResumeLayout(False)
        Me.TabMeeting.ResumeLayout(False)
        Me.TabMeeting.PerformLayout()
        Me.TabPromo.ResumeLayout(False)
        Me.TabPromo.PerformLayout()
        Me.TabMeeting2.ResumeLayout(False)
        Me.TabMeeting2.PerformLayout()
        CType(Me.AcroPDF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TrueDBGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocsCatalogueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents DMSDataSet As DMSDataSet
    Friend WithEvents TableAdapterManager As DMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DocsCatalogueBindingSource As BindingSource
    Friend WithEvents DocsCatalogueTableAdapter As DMSDataSetTableAdapters.DocsCatalogueTableAdapter

    Private Sub BtnSaveChanges_Click(sender As Object, e As EventArgs)

    End Sub
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents BtnSaveChanges1 As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnEditRecord As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabQuery As TabPage
    Friend WithEvents CHKBatch As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtBatch As TextBox
    Friend WithEvents TxtBook As TextBox
    Friend WithEvents TxtBox As TextBox
    Friend WithEvents TxtRack As TextBox
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
    Friend WithEvents DTDocDateTo As DateTimePicker
    Friend WithEvents DTDocDateFrom As DateTimePicker
    Friend WithEvents DocumentTypeComboBox As ComboBox
    Friend WithEvents DocumentTypeLabel As Label
    Friend WithEvents TabChanges As TabPage
    Friend WithEvents DocumentTypeCombobox2 As ComboBox
    Friend WithEvents Label32 As Label
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents Timesheet As TabPage
    Friend WithEvents GrpTimeSheet As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents BoxNoTS As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents RackNoTS As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents FromPeriodLabel As Label
    Friend WithEvents DTToPeriod As DateTimePicker
    Friend WithEvents FromPeriodTextBox As TextBox
    Friend WithEvents DTFromPeriod As DateTimePicker
    Friend WithEvents ToPeriodTextBox As TextBox
    Friend WithEvents ToPeriodLabel As Label
    Friend WithEvents MiddleNameLabel As Label
    Friend WithEvents MiddleNameTextBox As TextBox
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents DocumentDateTS As TextBox
    Friend WithEvents DTDocuTimeSheet As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents ReceiptInvoice As TabPage
    Friend WithEvents GrpReceipt As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents NONVATregCheckBox As CheckBox
    Friend WithEvents VATregCheckBox As CheckBox
    Friend WithEvents AddressCLabel As Label
    Friend WithEvents AddressCTextBox As TextBox
    Friend WithEvents TinCustomerLabel As Label
    Friend WithEvents TinCustomerTextBox As TextBox
    Friend WithEvents TinVendorLabel As Label
    Friend WithEvents TinVendorTextBox As TextBox
    Friend WithEvents BoxNoLabel As Label
    Friend WithEvents BoxNoRI As TextBox
    Friend WithEvents RackNoLabel As Label
    Friend WithEvents RackNoRI As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents DocumentDateRI As TextBox
    Friend WithEvents TotalValueLabel As Label
    Friend WithEvents TotalValueRI As TextBox
    Friend WithEvents ItemPurchasedLabel As Label
    Friend WithEvents ItemPurchasedTextBox As TextBox
    Friend WithEvents CustomerLabel As Label
    Friend WithEvents CustomerTextBox As TextBox
    Friend WithEvents VendorLabel As Label
    Friend WithEvents VendorTextBox As TextBox
    Friend WithEvents BookletNoLabel As Label
    Friend WithEvents BookletNoTextBox As TextBox
    Friend WithEvents DTDocuRI As DateTimePicker
    Friend WithEvents ReferenceNoLabel As Label
    Friend WithEvents ReferenceNoRI As TextBox
    Friend WithEvents DocumentDateLabel As Label
    Friend WithEvents Warranty As TabPage
    Friend WithEvents GrpWarranty As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents BoxNoWarranty As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents RackNoWarranty As TextBox
    Friend WithEvents DTDatePurchased As DateTimePicker
    Friend WithEvents EmailLabel As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents ContactNoLabel As Label
    Friend WithEvents ContactNoTextBox As TextBox
    Friend WithEvents AddressLabel As Label
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents ServiceCenterLabel As Label
    Friend WithEvents ServiceCenterTextBox As TextBox
    Friend WithEvents WarrantyPeriodLabel As Label
    Friend WithEvents WarrantyPeriodTextBox As TextBox
    Friend WithEvents SerialLabel As Label
    Friend WithEvents SerialTextBox As TextBox
    Friend WithEvents TotalValueLabel1 As Label
    Friend WithEvents TotalValueWarranty As TextBox
    Friend WithEvents ReferenceNoLabel1 As Label
    Friend WithEvents ReferenceNoTextBox1 As TextBox
    Friend WithEvents DatePurchasedLabel As Label
    Friend WithEvents DatePurchasedTextBox As TextBox
    Friend WithEvents ProductTypeLabel As Label
    Friend WithEvents ProductTypeTextBox As TextBox
    Friend WithEvents ProductBrandLabel As Label
    Friend WithEvents ProductBrandTextBox As TextBox
    Friend WithEvents WarrantyNoLabel As Label
    Friend WithEvents WarrantyNoTextBox As TextBox
    Friend WithEvents Voucher As TabPage
    Friend WithEvents GrpVoucher As GroupBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents DTDateReceived As DateTimePicker
    Friend WithEvents Label23 As Label
    Friend WithEvents BoxNoVoucher As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents RackNoVoucher As TextBox
    Friend WithEvents DateReceivedLabel As Label
    Friend WithEvents DateReceivedTextBox As TextBox
    Friend WithEvents PaymentFormComboBox As ComboBox
    Friend WithEvents DTDocuVoucher As DateTimePicker
    Friend WithEvents ReceivedbyLabel As Label
    Friend WithEvents ReceivedbyTextBox As TextBox
    Friend WithEvents RecordedbyLabel As Label
    Friend WithEvents RecordedbyTextBox As TextBox
    Friend WithEvents ApprovedbyLabel As Label
    Friend WithEvents ApprovedbyTextBox As TextBox
    Friend WithEvents PreparedbyLabel As Label
    Friend WithEvents PreparedbyTextBox As TextBox
    Friend WithEvents PayorLabel As Label
    Friend WithEvents PayorTextBox As TextBox
    Friend WithEvents PayeeLabel As Label
    Friend WithEvents PayeeTextBox As TextBox
    Friend WithEvents TotalValueLabel2 As Label
    Friend WithEvents TotalValueVoucher As TextBox
    Friend WithEvents PaymentFormLabel As Label
    Friend WithEvents VoucherNoLabel As Label
    Friend WithEvents VoucherNoTextBox As TextBox
    Friend WithEvents DocumentDateLabel1 As Label
    Friend WithEvents DocumentDateVoucher As TextBox
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents BankDepo As TabPage
    Friend WithEvents BankAddressLabel As Label
    Friend WithEvents BankAddressTextBox As TextBox
    Friend WithEvents BankBranchLabel As Label
    Friend WithEvents BankBranchTextBox As TextBox
    Friend WithEvents BankNameLabel As Label
    Friend WithEvents BankNameTextBox As TextBox
    Friend WithEvents Others As TabPage
    Friend WithEvents PaymentOthersLabel As Label
    Friend WithEvents PaymentOthersTextBox As TextBox
    Friend WithEvents Check As TabPage
    Friend WithEvents CheckNoTextBox As TextBox
    Friend WithEvents CheckNoLabel As Label
    Friend WithEvents CorpDocu As TabPage
    Friend WithEvents GrpCorp As GroupBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents BoxNoCorpDocu As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents RackNoCorpDocu As TextBox
    Friend WithEvents DTDocuCorp As DateTimePicker
    Friend WithEvents PurposeLabel As Label
    Friend WithEvents PurposeTextBox As TextBox
    Friend WithEvents DocumentDateLabel2 As Label
    Friend WithEvents DocumentDateCorp As TextBox
    Friend WithEvents AcroPDF As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents TabControl4 As TabControl
    Friend WithEvents TabMeeting As TabPage
    Friend WithEvents DTMeetingDate As DateTimePicker
    Friend WithEvents MeetingDateTextBox As TextBox
    Friend WithEvents SecretaryTextBox As TextBox
    Friend WithEvents CompanyTextBox As TextBox
    Friend WithEvents TabPromo As TabPage
    Friend WithEvents DTPromoTo As DateTimePicker
    Friend WithEvents DTPromoFrom As DateTimePicker
    Friend WithEvents DTIPermitNoTextBox As TextBox
    Friend WithEvents PromoToTextBox As TextBox
    Friend WithEvents PromoFromTextBox As TextBox
    Friend WithEvents PromoTitleTextBox As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents MeetingDateLabel As Label
    Friend WithEvents SecretaryLabel As Label
    Friend WithEvents CompanyLabel As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents DTIPermitNoLabel As Label
    Friend WithEvents PromoToLabel As Label
    Friend WithEvents PromoFromLabel As Label
    Friend WithEvents PromoTitleLabel As Label
    Friend WithEvents TabMeeting2 As TabPage
    Friend WithEvents Label35 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnDownload As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents C1TrueDBGrid2 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label36 As Label
    Friend WithEvents CHKFileName As CheckBox
    Friend WithEvents sdasd As Label
    Friend WithEvents TxtFileName As TextBox
    Friend WithEvents txtPages As TextBox
    Friend WithEvents cbDocSize As ComboBox
    Friend WithEvents chkConfidential As CheckBox
    Friend WithEvents SubBatchTextBox As TextBox
    Friend WithEvents BatchTextBox As TextBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents BtnRemoval As Button
    Friend WithEvents WebBrowser1 As WebBrowser
End Class


