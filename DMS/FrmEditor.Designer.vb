<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEditor
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
        Dim DocumentTypeLabel As System.Windows.Forms.Label
        Dim DocumentDateLabel As System.Windows.Forms.Label
        Dim ReferenceNoLabel As System.Windows.Forms.Label
        Dim BookletNoLabel As System.Windows.Forms.Label
        Dim VendorLabel As System.Windows.Forms.Label
        Dim CustomerLabel As System.Windows.Forms.Label
        Dim ItemPurchasedLabel As System.Windows.Forms.Label
        Dim TotalValueLabel As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim MiddleNameLabel As System.Windows.Forms.Label
        Dim FromPeriodLabel As System.Windows.Forms.Label
        Dim ToPeriodLabel As System.Windows.Forms.Label
        Dim WarrantyNoLabel As System.Windows.Forms.Label
        Dim ProductBrandLabel As System.Windows.Forms.Label
        Dim ProductTypeLabel As System.Windows.Forms.Label
        Dim DatePurchasedLabel As System.Windows.Forms.Label
        Dim ReferenceNoLabel1 As System.Windows.Forms.Label
        Dim TotalValueLabel1 As System.Windows.Forms.Label
        Dim SerialLabel As System.Windows.Forms.Label
        Dim WarrantyPeriodLabel As System.Windows.Forms.Label
        Dim ServiceCenterLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim ContactNoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim DocumentDateLabel1 As System.Windows.Forms.Label
        Dim VoucherNoLabel As System.Windows.Forms.Label
        Dim PaymentFormLabel As System.Windows.Forms.Label
        Dim CheckNoLabel As System.Windows.Forms.Label
        Dim TotalValueLabel2 As System.Windows.Forms.Label
        Dim PayeeLabel As System.Windows.Forms.Label
        Dim PayorLabel As System.Windows.Forms.Label
        Dim PreparedbyLabel As System.Windows.Forms.Label
        Dim ApprovedbyLabel As System.Windows.Forms.Label
        Dim RecordedbyLabel As System.Windows.Forms.Label
        Dim ReceivedbyLabel As System.Windows.Forms.Label
        Dim DocumentDateLabel2 As System.Windows.Forms.Label
        Dim CompanyLabel As System.Windows.Forms.Label
        Dim PurposeLabel As System.Windows.Forms.Label
        Dim SecretaryLabel As System.Windows.Forms.Label
        Dim MeetingDateLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim PaymentOthersLabel As System.Windows.Forms.Label
        Dim BankNameLabel As System.Windows.Forms.Label
        Dim BankBranchLabel As System.Windows.Forms.Label
        Dim BankAddressLabel As System.Windows.Forms.Label
        Dim RackNoLabel As System.Windows.Forms.Label
        Dim BoxNoLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim TinVendorLabel As System.Windows.Forms.Label
        Dim TinCustomerLabel As System.Windows.Forms.Label
        Dim AddressCLabel As System.Windows.Forms.Label
        Dim DateReceivedLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim Label19 As System.Windows.Forms.Label
        Dim Label20 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditor))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.DocsCatalogueC1TrueDBGrid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.DocsCatalogueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DMSDataSet = New DMS.DMSDataSet()
        Me.BtnCancel1 = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Timesheet = New System.Windows.Forms.TabPage()
        Me.GrpTimeSheet = New System.Windows.Forms.GroupBox()
        Me.BoxNoTS = New System.Windows.Forms.TextBox()
        Me.RackNoTS = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DTToPeriod = New System.Windows.Forms.DateTimePicker()
        Me.FromPeriodTextBox = New System.Windows.Forms.TextBox()
        Me.DTFromPeriod = New System.Windows.Forms.DateTimePicker()
        Me.ToPeriodTextBox = New System.Windows.Forms.TextBox()
        Me.MiddleNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.DocumentDateTS = New System.Windows.Forms.TextBox()
        Me.DTDocuTimeSheet = New System.Windows.Forms.DateTimePicker()
        Me.ReceiptInvoice = New System.Windows.Forms.TabPage()
        Me.GrpReceipt = New System.Windows.Forms.GroupBox()
        Me.NONVATregCheckBox = New System.Windows.Forms.CheckBox()
        Me.VATregCheckBox = New System.Windows.Forms.CheckBox()
        Me.AddressCTextBox = New System.Windows.Forms.TextBox()
        Me.TinCustomerTextBox = New System.Windows.Forms.TextBox()
        Me.TinVendorTextBox = New System.Windows.Forms.TextBox()
        Me.BoxNoRI = New System.Windows.Forms.TextBox()
        Me.RackNoRI = New System.Windows.Forms.TextBox()
        Me.DocumentDateRI = New System.Windows.Forms.TextBox()
        Me.TotalValueRI = New System.Windows.Forms.TextBox()
        Me.ItemPurchasedTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerTextBox = New System.Windows.Forms.TextBox()
        Me.VendorTextBox = New System.Windows.Forms.TextBox()
        Me.BookletNoTextBox = New System.Windows.Forms.TextBox()
        Me.DTDocuRI = New System.Windows.Forms.DateTimePicker()
        Me.ReferenceNoRI = New System.Windows.Forms.TextBox()
        Me.Warranty = New System.Windows.Forms.TabPage()
        Me.GrpWarranty = New System.Windows.Forms.GroupBox()
        Me.BoxNoWarranty = New System.Windows.Forms.TextBox()
        Me.RackNoWarranty = New System.Windows.Forms.TextBox()
        Me.DTDatePurchased = New System.Windows.Forms.DateTimePicker()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.ContactNoTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.ServiceCenterTextBox = New System.Windows.Forms.TextBox()
        Me.WarrantyPeriodTextBox = New System.Windows.Forms.TextBox()
        Me.SerialTextBox = New System.Windows.Forms.TextBox()
        Me.TotalValueWarranty = New System.Windows.Forms.TextBox()
        Me.ReferenceNoTextBox1 = New System.Windows.Forms.TextBox()
        Me.DatePurchasedTextBox = New System.Windows.Forms.TextBox()
        Me.ProductTypeTextBox = New System.Windows.Forms.TextBox()
        Me.ProductBrandTextBox = New System.Windows.Forms.TextBox()
        Me.WarrantyNoTextBox = New System.Windows.Forms.TextBox()
        Me.Voucher = New System.Windows.Forms.TabPage()
        Me.GrpVoucher = New System.Windows.Forms.GroupBox()
        Me.DTDateReceived = New System.Windows.Forms.DateTimePicker()
        Me.BoxNoVoucher = New System.Windows.Forms.TextBox()
        Me.RackNoVoucher = New System.Windows.Forms.TextBox()
        Me.DateReceivedTextBox = New System.Windows.Forms.TextBox()
        Me.PaymentFormComboBox = New System.Windows.Forms.ComboBox()
        Me.DTDocuVoucher = New System.Windows.Forms.DateTimePicker()
        Me.ReceivedbyTextBox = New System.Windows.Forms.TextBox()
        Me.RecordedbyTextBox = New System.Windows.Forms.TextBox()
        Me.ApprovedbyTextBox = New System.Windows.Forms.TextBox()
        Me.PreparedbyTextBox = New System.Windows.Forms.TextBox()
        Me.PayorTextBox = New System.Windows.Forms.TextBox()
        Me.PayeeTextBox = New System.Windows.Forms.TextBox()
        Me.TotalValueVoucher = New System.Windows.Forms.TextBox()
        Me.VoucherNoTextBox = New System.Windows.Forms.TextBox()
        Me.DocumentDateVoucher = New System.Windows.Forms.TextBox()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.BankDepo = New System.Windows.Forms.TabPage()
        Me.BankAddressTextBox = New System.Windows.Forms.TextBox()
        Me.BankBranchTextBox = New System.Windows.Forms.TextBox()
        Me.BankNameTextBox = New System.Windows.Forms.TextBox()
        Me.Others = New System.Windows.Forms.TabPage()
        Me.PaymentOthersTextBox = New System.Windows.Forms.TextBox()
        Me.Check = New System.Windows.Forms.TabPage()
        Me.CheckNoTextBox = New System.Windows.Forms.TextBox()
        Me.CorpDocu = New System.Windows.Forms.TabPage()
        Me.GrpCorp = New System.Windows.Forms.GroupBox()
        Me.BoxNoCorpDocu = New System.Windows.Forms.TextBox()
        Me.RackNoCorpDocu = New System.Windows.Forms.TextBox()
        Me.DTMeetingDate = New System.Windows.Forms.DateTimePicker()
        Me.DTDocuCorp = New System.Windows.Forms.DateTimePicker()
        Me.MeetingDateTextBox = New System.Windows.Forms.TextBox()
        Me.SecretaryTextBox = New System.Windows.Forms.TextBox()
        Me.PurposeTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyTextBox = New System.Windows.Forms.TextBox()
        Me.DocumentDateCorp = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LblStat = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.DocumentTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.AcroReader1 = New AxAcroPDFLib.AxAcroPDF()
        Me.DocsCatalogueTableAdapter = New DMS.DMSDataSetTableAdapters.DocsCatalogueTableAdapter()
        Me.TableAdapterManager = New DMS.DMSDataSetTableAdapters.TableAdapterManager()
        DocumentTypeLabel = New System.Windows.Forms.Label()
        DocumentDateLabel = New System.Windows.Forms.Label()
        ReferenceNoLabel = New System.Windows.Forms.Label()
        BookletNoLabel = New System.Windows.Forms.Label()
        VendorLabel = New System.Windows.Forms.Label()
        CustomerLabel = New System.Windows.Forms.Label()
        ItemPurchasedLabel = New System.Windows.Forms.Label()
        TotalValueLabel = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        MiddleNameLabel = New System.Windows.Forms.Label()
        FromPeriodLabel = New System.Windows.Forms.Label()
        ToPeriodLabel = New System.Windows.Forms.Label()
        WarrantyNoLabel = New System.Windows.Forms.Label()
        ProductBrandLabel = New System.Windows.Forms.Label()
        ProductTypeLabel = New System.Windows.Forms.Label()
        DatePurchasedLabel = New System.Windows.Forms.Label()
        ReferenceNoLabel1 = New System.Windows.Forms.Label()
        TotalValueLabel1 = New System.Windows.Forms.Label()
        SerialLabel = New System.Windows.Forms.Label()
        WarrantyPeriodLabel = New System.Windows.Forms.Label()
        ServiceCenterLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        ContactNoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        DocumentDateLabel1 = New System.Windows.Forms.Label()
        VoucherNoLabel = New System.Windows.Forms.Label()
        PaymentFormLabel = New System.Windows.Forms.Label()
        CheckNoLabel = New System.Windows.Forms.Label()
        TotalValueLabel2 = New System.Windows.Forms.Label()
        PayeeLabel = New System.Windows.Forms.Label()
        PayorLabel = New System.Windows.Forms.Label()
        PreparedbyLabel = New System.Windows.Forms.Label()
        ApprovedbyLabel = New System.Windows.Forms.Label()
        RecordedbyLabel = New System.Windows.Forms.Label()
        ReceivedbyLabel = New System.Windows.Forms.Label()
        DocumentDateLabel2 = New System.Windows.Forms.Label()
        CompanyLabel = New System.Windows.Forms.Label()
        PurposeLabel = New System.Windows.Forms.Label()
        SecretaryLabel = New System.Windows.Forms.Label()
        MeetingDateLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        PaymentOthersLabel = New System.Windows.Forms.Label()
        BankNameLabel = New System.Windows.Forms.Label()
        BankBranchLabel = New System.Windows.Forms.Label()
        BankAddressLabel = New System.Windows.Forms.Label()
        RackNoLabel = New System.Windows.Forms.Label()
        BoxNoLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        TinVendorLabel = New System.Windows.Forms.Label()
        TinCustomerLabel = New System.Windows.Forms.Label()
        AddressCLabel = New System.Windows.Forms.Label()
        DateReceivedLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Label18 = New System.Windows.Forms.Label()
        Label19 = New System.Windows.Forms.Label()
        Label20 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.DocsCatalogueC1TrueDBGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocsCatalogueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.Timesheet.SuspendLayout()
        Me.GrpTimeSheet.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ReceiptInvoice.SuspendLayout()
        Me.GrpReceipt.SuspendLayout()
        Me.Warranty.SuspendLayout()
        Me.GrpWarranty.SuspendLayout()
        Me.Voucher.SuspendLayout()
        Me.GrpVoucher.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.BankDepo.SuspendLayout()
        Me.Others.SuspendLayout()
        Me.Check.SuspendLayout()
        Me.CorpDocu.SuspendLayout()
        Me.GrpCorp.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.AcroReader1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DocumentTypeLabel
        '
        DocumentTypeLabel.AutoSize = True
        DocumentTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DocumentTypeLabel.Location = New System.Drawing.Point(11, 49)
        DocumentTypeLabel.Name = "DocumentTypeLabel"
        DocumentTypeLabel.Size = New System.Drawing.Size(125, 20)
        DocumentTypeLabel.TabIndex = 0
        DocumentTypeLabel.Text = "Document Type:"
        '
        'DocumentDateLabel
        '
        DocumentDateLabel.AutoSize = True
        DocumentDateLabel.Location = New System.Drawing.Point(8, 76)
        DocumentDateLabel.Name = "DocumentDateLabel"
        DocumentDateLabel.Size = New System.Drawing.Size(104, 16)
        DocumentDateLabel.TabIndex = 2
        DocumentDateLabel.Text = "Document Date:"
        '
        'ReferenceNoLabel
        '
        ReferenceNoLabel.AutoSize = True
        ReferenceNoLabel.Location = New System.Drawing.Point(8, 128)
        ReferenceNoLabel.Name = "ReferenceNoLabel"
        ReferenceNoLabel.Size = New System.Drawing.Size(126, 16)
        ReferenceNoLabel.TabIndex = 5
        ReferenceNoLabel.Text = "Receipt/Invoice No:"
        '
        'BookletNoLabel
        '
        BookletNoLabel.AutoSize = True
        BookletNoLabel.Location = New System.Drawing.Point(8, 105)
        BookletNoLabel.Name = "BookletNoLabel"
        BookletNoLabel.Size = New System.Drawing.Size(78, 16)
        BookletNoLabel.TabIndex = 18
        BookletNoLabel.Text = "Booklet No:"
        '
        'VendorLabel
        '
        VendorLabel.AutoSize = True
        VendorLabel.Location = New System.Drawing.Point(8, 157)
        VendorLabel.Name = "VendorLabel"
        VendorLabel.Size = New System.Drawing.Size(55, 16)
        VendorLabel.TabIndex = 19
        VendorLabel.Text = "Vendor:"
        '
        'CustomerLabel
        '
        CustomerLabel.AutoSize = True
        CustomerLabel.Location = New System.Drawing.Point(8, 180)
        CustomerLabel.Name = "CustomerLabel"
        CustomerLabel.Size = New System.Drawing.Size(68, 16)
        CustomerLabel.TabIndex = 20
        CustomerLabel.Text = "Customer:"
        '
        'ItemPurchasedLabel
        '
        ItemPurchasedLabel.AutoSize = True
        ItemPurchasedLabel.Location = New System.Drawing.Point(8, 287)
        ItemPurchasedLabel.Name = "ItemPurchasedLabel"
        ItemPurchasedLabel.Size = New System.Drawing.Size(104, 16)
        ItemPurchasedLabel.TabIndex = 21
        ItemPurchasedLabel.Text = "Item Purchased:"
        '
        'TotalValueLabel
        '
        TotalValueLabel.AutoSize = True
        TotalValueLabel.Location = New System.Drawing.Point(348, 105)
        TotalValueLabel.Name = "TotalValueLabel"
        TotalValueLabel.Size = New System.Drawing.Size(80, 16)
        TotalValueLabel.TabIndex = 22
        TotalValueLabel.Text = "Total Value:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(8, 76)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(104, 16)
        Label8.TabIndex = 2
        Label8.Text = "Document Date:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(8, 108)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(76, 16)
        LastNameLabel.TabIndex = 24
        LastNameLabel.Text = "Last Name:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(8, 131)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(76, 16)
        FirstNameLabel.TabIndex = 25
        FirstNameLabel.Text = "First Name:"
        '
        'MiddleNameLabel
        '
        MiddleNameLabel.AutoSize = True
        MiddleNameLabel.Location = New System.Drawing.Point(8, 154)
        MiddleNameLabel.Name = "MiddleNameLabel"
        MiddleNameLabel.Size = New System.Drawing.Size(92, 16)
        MiddleNameLabel.TabIndex = 26
        MiddleNameLabel.Text = "Middle Name:"
        '
        'FromPeriodLabel
        '
        FromPeriodLabel.AutoSize = True
        FromPeriodLabel.Location = New System.Drawing.Point(132, 24)
        FromPeriodLabel.Name = "FromPeriodLabel"
        FromPeriodLabel.Size = New System.Drawing.Size(42, 16)
        FromPeriodLabel.TabIndex = 27
        FromPeriodLabel.Text = "From:"
        '
        'ToPeriodLabel
        '
        ToPeriodLabel.AutoSize = True
        ToPeriodLabel.Location = New System.Drawing.Point(151, 50)
        ToPeriodLabel.Name = "ToPeriodLabel"
        ToPeriodLabel.Size = New System.Drawing.Size(28, 16)
        ToPeriodLabel.TabIndex = 28
        ToPeriodLabel.Text = "To:"
        '
        'WarrantyNoLabel
        '
        WarrantyNoLabel.AutoSize = True
        WarrantyNoLabel.Location = New System.Drawing.Point(9, 207)
        WarrantyNoLabel.Name = "WarrantyNoLabel"
        WarrantyNoLabel.Size = New System.Drawing.Size(86, 16)
        WarrantyNoLabel.TabIndex = 0
        WarrantyNoLabel.Text = "Warranty No:"
        '
        'ProductBrandLabel
        '
        ProductBrandLabel.AutoSize = True
        ProductBrandLabel.Location = New System.Drawing.Point(9, 83)
        ProductBrandLabel.Name = "ProductBrandLabel"
        ProductBrandLabel.Size = New System.Drawing.Size(96, 16)
        ProductBrandLabel.TabIndex = 2
        ProductBrandLabel.Text = "Product Brand:"
        '
        'ProductTypeLabel
        '
        ProductTypeLabel.AutoSize = True
        ProductTypeLabel.Location = New System.Drawing.Point(9, 106)
        ProductTypeLabel.Name = "ProductTypeLabel"
        ProductTypeLabel.Size = New System.Drawing.Size(92, 16)
        ProductTypeLabel.TabIndex = 4
        ProductTypeLabel.Text = "Product Type:"
        '
        'DatePurchasedLabel
        '
        DatePurchasedLabel.AutoSize = True
        DatePurchasedLabel.Location = New System.Drawing.Point(9, 152)
        DatePurchasedLabel.Name = "DatePurchasedLabel"
        DatePurchasedLabel.Size = New System.Drawing.Size(108, 16)
        DatePurchasedLabel.TabIndex = 6
        DatePurchasedLabel.Text = "Date Purchased:"
        '
        'ReferenceNoLabel1
        '
        ReferenceNoLabel1.AutoSize = True
        ReferenceNoLabel1.Location = New System.Drawing.Point(9, 184)
        ReferenceNoLabel1.Name = "ReferenceNoLabel1"
        ReferenceNoLabel1.Size = New System.Drawing.Size(75, 16)
        ReferenceNoLabel1.TabIndex = 8
        ReferenceNoLabel1.Text = "Invoice No:"
        '
        'TotalValueLabel1
        '
        TotalValueLabel1.AutoSize = True
        TotalValueLabel1.Location = New System.Drawing.Point(9, 385)
        TotalValueLabel1.Name = "TotalValueLabel1"
        TotalValueLabel1.Size = New System.Drawing.Size(56, 16)
        TotalValueLabel1.TabIndex = 10
        TotalValueLabel1.Text = "Amount:"
        '
        'SerialLabel
        '
        SerialLabel.AutoSize = True
        SerialLabel.Location = New System.Drawing.Point(9, 129)
        SerialLabel.Name = "SerialLabel"
        SerialLabel.Size = New System.Drawing.Size(46, 16)
        SerialLabel.TabIndex = 12
        SerialLabel.Text = "Serial:"
        '
        'WarrantyPeriodLabel
        '
        WarrantyPeriodLabel.AutoSize = True
        WarrantyPeriodLabel.Location = New System.Drawing.Point(9, 230)
        WarrantyPeriodLabel.Name = "WarrantyPeriodLabel"
        WarrantyPeriodLabel.Size = New System.Drawing.Size(108, 16)
        WarrantyPeriodLabel.TabIndex = 14
        WarrantyPeriodLabel.Text = "Warranty Period:"
        '
        'ServiceCenterLabel
        '
        ServiceCenterLabel.AutoSize = True
        ServiceCenterLabel.Location = New System.Drawing.Point(9, 261)
        ServiceCenterLabel.Name = "ServiceCenterLabel"
        ServiceCenterLabel.Size = New System.Drawing.Size(99, 16)
        ServiceCenterLabel.TabIndex = 16
        ServiceCenterLabel.Text = "Service Center:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(9, 284)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(153, 16)
        AddressLabel.TabIndex = 18
        AddressLabel.Text = "Service Center Address:"
        '
        'ContactNoLabel
        '
        ContactNoLabel.AutoSize = True
        ContactNoLabel.Location = New System.Drawing.Point(9, 339)
        ContactNoLabel.Name = "ContactNoLabel"
        ContactNoLabel.Size = New System.Drawing.Size(77, 16)
        ContactNoLabel.TabIndex = 20
        ContactNoLabel.Text = "Contact No:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(9, 362)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(45, 16)
        EmailLabel.TabIndex = 22
        EmailLabel.Text = "Email:"
        '
        'DocumentDateLabel1
        '
        DocumentDateLabel1.AutoSize = True
        DocumentDateLabel1.ForeColor = System.Drawing.Color.Black
        DocumentDateLabel1.Location = New System.Drawing.Point(8, 76)
        DocumentDateLabel1.Name = "DocumentDateLabel1"
        DocumentDateLabel1.Size = New System.Drawing.Size(104, 16)
        DocumentDateLabel1.TabIndex = 0
        DocumentDateLabel1.Text = "Document Date:"
        AddHandler DocumentDateLabel1.Click, AddressOf Me.DocumentDateLabel1_Click
        '
        'VoucherNoLabel
        '
        VoucherNoLabel.AutoSize = True
        VoucherNoLabel.ForeColor = System.Drawing.Color.Black
        VoucherNoLabel.Location = New System.Drawing.Point(8, 152)
        VoucherNoLabel.Name = "VoucherNoLabel"
        VoucherNoLabel.Size = New System.Drawing.Size(82, 16)
        VoucherNoLabel.TabIndex = 2
        VoucherNoLabel.Text = "Voucher No:"
        '
        'PaymentFormLabel
        '
        PaymentFormLabel.AutoSize = True
        PaymentFormLabel.ForeColor = System.Drawing.Color.Black
        PaymentFormLabel.Location = New System.Drawing.Point(8, 183)
        PaymentFormLabel.Name = "PaymentFormLabel"
        PaymentFormLabel.Size = New System.Drawing.Size(112, 16)
        PaymentFormLabel.TabIndex = 4
        PaymentFormLabel.Text = "Form of Payment:"
        '
        'CheckNoLabel
        '
        CheckNoLabel.AutoSize = True
        CheckNoLabel.ForeColor = System.Drawing.Color.Black
        CheckNoLabel.Location = New System.Drawing.Point(7, 7)
        CheckNoLabel.Name = "CheckNoLabel"
        CheckNoLabel.Size = New System.Drawing.Size(70, 16)
        CheckNoLabel.TabIndex = 6
        CheckNoLabel.Text = "Check No:"
        '
        'TotalValueLabel2
        '
        TotalValueLabel2.AutoSize = True
        TotalValueLabel2.ForeColor = System.Drawing.Color.Black
        TotalValueLabel2.Location = New System.Drawing.Point(8, 329)
        TotalValueLabel2.Name = "TotalValueLabel2"
        TotalValueLabel2.Size = New System.Drawing.Size(56, 16)
        TotalValueLabel2.TabIndex = 8
        TotalValueLabel2.Text = "Amount:"
        '
        'PayeeLabel
        '
        PayeeLabel.AutoSize = True
        PayeeLabel.ForeColor = System.Drawing.Color.Black
        PayeeLabel.Location = New System.Drawing.Point(8, 106)
        PayeeLabel.Name = "PayeeLabel"
        PayeeLabel.Size = New System.Drawing.Size(51, 16)
        PayeeLabel.TabIndex = 10
        PayeeLabel.Text = "Payee:"
        '
        'PayorLabel
        '
        PayorLabel.AutoSize = True
        PayorLabel.ForeColor = System.Drawing.Color.Black
        PayorLabel.Location = New System.Drawing.Point(8, 129)
        PayorLabel.Name = "PayorLabel"
        PayorLabel.Size = New System.Drawing.Size(47, 16)
        PayorLabel.TabIndex = 12
        PayorLabel.Text = "Payor:"
        '
        'PreparedbyLabel
        '
        PreparedbyLabel.AutoSize = True
        PreparedbyLabel.ForeColor = System.Drawing.Color.Black
        PreparedbyLabel.Location = New System.Drawing.Point(8, 352)
        PreparedbyLabel.Name = "PreparedbyLabel"
        PreparedbyLabel.Size = New System.Drawing.Size(87, 16)
        PreparedbyLabel.TabIndex = 14
        PreparedbyLabel.Text = "Prepared By:"
        '
        'ApprovedbyLabel
        '
        ApprovedbyLabel.AutoSize = True
        ApprovedbyLabel.ForeColor = System.Drawing.Color.Black
        ApprovedbyLabel.Location = New System.Drawing.Point(8, 375)
        ApprovedbyLabel.Name = "ApprovedbyLabel"
        ApprovedbyLabel.Size = New System.Drawing.Size(90, 16)
        ApprovedbyLabel.TabIndex = 16
        ApprovedbyLabel.Text = "Approved By:"
        '
        'RecordedbyLabel
        '
        RecordedbyLabel.AutoSize = True
        RecordedbyLabel.ForeColor = System.Drawing.Color.Black
        RecordedbyLabel.Location = New System.Drawing.Point(8, 398)
        RecordedbyLabel.Name = "RecordedbyLabel"
        RecordedbyLabel.Size = New System.Drawing.Size(91, 16)
        RecordedbyLabel.TabIndex = 18
        RecordedbyLabel.Text = "Recorded By:"
        '
        'ReceivedbyLabel
        '
        ReceivedbyLabel.AutoSize = True
        ReceivedbyLabel.ForeColor = System.Drawing.Color.Black
        ReceivedbyLabel.Location = New System.Drawing.Point(8, 421)
        ReceivedbyLabel.Name = "ReceivedbyLabel"
        ReceivedbyLabel.Size = New System.Drawing.Size(89, 16)
        ReceivedbyLabel.TabIndex = 20
        ReceivedbyLabel.Text = "Received By:"
        '
        'DocumentDateLabel2
        '
        DocumentDateLabel2.AutoSize = True
        DocumentDateLabel2.ForeColor = System.Drawing.Color.Black
        DocumentDateLabel2.Location = New System.Drawing.Point(8, 76)
        DocumentDateLabel2.Name = "DocumentDateLabel2"
        DocumentDateLabel2.Size = New System.Drawing.Size(104, 16)
        DocumentDateLabel2.TabIndex = 0
        DocumentDateLabel2.Text = "Document Date:"
        '
        'CompanyLabel
        '
        CompanyLabel.AutoSize = True
        CompanyLabel.Location = New System.Drawing.Point(8, 129)
        CompanyLabel.Name = "CompanyLabel"
        CompanyLabel.Size = New System.Drawing.Size(69, 16)
        CompanyLabel.TabIndex = 2
        CompanyLabel.Text = "Company:"
        '
        'PurposeLabel
        '
        PurposeLabel.AutoSize = True
        PurposeLabel.Location = New System.Drawing.Point(8, 186)
        PurposeLabel.Name = "PurposeLabel"
        PurposeLabel.Size = New System.Drawing.Size(62, 16)
        PurposeLabel.TabIndex = 4
        PurposeLabel.Text = "Purpose:"
        '
        'SecretaryLabel
        '
        SecretaryLabel.AutoSize = True
        SecretaryLabel.Location = New System.Drawing.Point(8, 152)
        SecretaryLabel.Name = "SecretaryLabel"
        SecretaryLabel.Size = New System.Drawing.Size(69, 16)
        SecretaryLabel.TabIndex = 6
        SecretaryLabel.Text = "Secretary:"
        '
        'MeetingDateLabel
        '
        MeetingDateLabel.AutoSize = True
        MeetingDateLabel.Location = New System.Drawing.Point(8, 106)
        MeetingDateLabel.Name = "MeetingDateLabel"
        MeetingDateLabel.Size = New System.Drawing.Size(91, 16)
        MeetingDateLabel.TabIndex = 8
        MeetingDateLabel.Text = "Meeting Date:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(359, 123)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(55, 13)
        Label1.TabIndex = 25
        Label1.Text = "(VAT INC)"
        '
        'PaymentOthersLabel
        '
        PaymentOthersLabel.AutoSize = True
        PaymentOthersLabel.Location = New System.Drawing.Point(7, 7)
        PaymentOthersLabel.Name = "PaymentOthersLabel"
        PaymentOthersLabel.Size = New System.Drawing.Size(102, 16)
        PaymentOthersLabel.TabIndex = 0
        PaymentOthersLabel.Text = "Please Specify:"
        '
        'BankNameLabel
        '
        BankNameLabel.AutoSize = True
        BankNameLabel.Location = New System.Drawing.Point(4, 5)
        BankNameLabel.Name = "BankNameLabel"
        BankNameLabel.Size = New System.Drawing.Size(82, 16)
        BankNameLabel.TabIndex = 0
        BankNameLabel.Text = "Bank Name:"
        '
        'BankBranchLabel
        '
        BankBranchLabel.AutoSize = True
        BankBranchLabel.Location = New System.Drawing.Point(4, 28)
        BankBranchLabel.Name = "BankBranchLabel"
        BankBranchLabel.Size = New System.Drawing.Size(87, 16)
        BankBranchLabel.TabIndex = 2
        BankBranchLabel.Text = "Bank Branch:"
        '
        'BankAddressLabel
        '
        BankAddressLabel.AutoSize = True
        BankAddressLabel.Location = New System.Drawing.Point(4, 51)
        BankAddressLabel.Name = "BankAddressLabel"
        BankAddressLabel.Size = New System.Drawing.Size(96, 16)
        BankAddressLabel.TabIndex = 4
        BankAddressLabel.Text = "Bank Address:"
        AddHandler BankAddressLabel.Click, AddressOf Me.BankAddressLabel_Click
        '
        'RackNoLabel
        '
        RackNoLabel.AutoSize = True
        RackNoLabel.Location = New System.Drawing.Point(8, 30)
        RackNoLabel.Name = "RackNoLabel"
        RackNoLabel.Size = New System.Drawing.Size(131, 16)
        RackNoLabel.TabIndex = 25
        RackNoLabel.Text = "Document Rack No.:"
        '
        'BoxNoLabel
        '
        BoxNoLabel.AutoSize = True
        BoxNoLabel.Location = New System.Drawing.Point(8, 53)
        BoxNoLabel.Name = "BoxNoLabel"
        BoxNoLabel.Size = New System.Drawing.Size(122, 16)
        BoxNoLabel.TabIndex = 26
        BoxNoLabel.Text = "Document Box No.:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(8, 53)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(122, 16)
        Label2.TabIndex = 34
        Label2.Text = "Document Box No.:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(8, 30)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(131, 16)
        Label3.TabIndex = 33
        Label3.Text = "Document Rack No.:"
        '
        'TinVendorLabel
        '
        TinVendorLabel.AutoSize = True
        TinVendorLabel.Location = New System.Drawing.Point(8, 232)
        TinVendorLabel.Name = "TinVendorLabel"
        TinVendorLabel.Size = New System.Drawing.Size(94, 16)
        TinVendorLabel.TabIndex = 27
        TinVendorLabel.Text = "TIN of Vendor:"
        '
        'TinCustomerLabel
        '
        TinCustomerLabel.AutoSize = True
        TinCustomerLabel.Location = New System.Drawing.Point(8, 255)
        TinCustomerLabel.Name = "TinCustomerLabel"
        TinCustomerLabel.Size = New System.Drawing.Size(107, 16)
        TinCustomerLabel.TabIndex = 28
        TinCustomerLabel.Text = "TIN of Customer:"
        '
        'AddressCLabel
        '
        AddressCLabel.AutoSize = True
        AddressCLabel.Location = New System.Drawing.Point(8, 203)
        AddressCLabel.Name = "AddressCLabel"
        AddressCLabel.Size = New System.Drawing.Size(122, 16)
        AddressCLabel.TabIndex = 29
        AddressCLabel.Text = "Customer Address:"
        '
        'DateReceivedLabel
        '
        DateReceivedLabel.AutoSize = True
        DateReceivedLabel.Location = New System.Drawing.Point(8, 444)
        DateReceivedLabel.Name = "DateReceivedLabel"
        DateReceivedLabel.Size = New System.Drawing.Size(102, 16)
        DateReceivedLabel.TabIndex = 26
        DateReceivedLabel.Text = "Date Received:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(8, 53)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(122, 16)
        Label4.TabIndex = 29
        Label4.Text = "Document Box No.:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(8, 30)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(131, 16)
        Label5.TabIndex = 28
        Label5.Text = "Document Rack No.:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(298, 230)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(106, 16)
        Label6.TabIndex = 32
        Label6.Text = "(6 mos, 1 yr, etc.)"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(8, 53)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(122, 16)
        Label7.TabIndex = 29
        Label7.Text = "Document Box No.:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(8, 30)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(131, 16)
        Label9.TabIndex = 28
        Label9.Text = "Document Rack No.:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(8, 53)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(122, 16)
        Label10.TabIndex = 33
        Label10.Text = "Document Box No.:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(8, 30)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(131, 16)
        Label11.TabIndex = 32
        Label11.Text = "Document Rack No.:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(284, 76)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(82, 16)
        Label12.TabIndex = 35
        Label12.Text = "mm/dd/yyyy"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(285, 76)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(82, 16)
        Label13.TabIndex = 36
        Label13.Text = "MM/dd/yyyy"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Location = New System.Drawing.Point(277, 153)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(82, 16)
        Label14.TabIndex = 36
        Label14.Text = "mm/dd/yyyy"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Location = New System.Drawing.Point(280, 444)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(82, 16)
        Label15.TabIndex = 36
        Label15.Text = "mm/dd/yyyy"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Location = New System.Drawing.Point(281, 75)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(82, 16)
        Label16.TabIndex = 36
        Label16.Text = "mm/dd/yyyy"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Location = New System.Drawing.Point(281, 106)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(82, 16)
        Label17.TabIndex = 36
        Label17.Text = "mm/dd/yyyy"
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.Location = New System.Drawing.Point(306, 24)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(82, 16)
        Label18.TabIndex = 36
        Label18.Text = "mm/dd/yyyy"
        '
        'Label19
        '
        Label19.AutoSize = True
        Label19.Location = New System.Drawing.Point(306, 50)
        Label19.Name = "Label19"
        Label19.Size = New System.Drawing.Size(82, 16)
        Label19.TabIndex = 37
        Label19.Text = "mm/dd/yyyy"
        '
        'Label20
        '
        Label20.AutoSize = True
        Label20.Location = New System.Drawing.Point(280, 76)
        Label20.Name = "Label20"
        Label20.Size = New System.Drawing.Size(82, 16)
        Label20.TabIndex = 37
        Label20.Text = "mm/dd/yyyy"
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
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.AcroReader1)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer1.Size = New System.Drawing.Size(1197, 684)
        Me.SplitContainer1.SplitterDistance = 641
        Me.SplitContainer1.TabIndex = 0
        Me.SplitContainer1.TabStop = False
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.Controls.Add(Me.DocsCatalogueC1TrueDBGrid)
        Me.SplitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.BtnCancel1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.BtnRemove)
        Me.SplitContainer2.Panel2.Controls.Add(Me.IdTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.StatusStrip1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.BtnClear)
        Me.SplitContainer2.Panel2.Controls.Add(Me.BtnSave)
        Me.SplitContainer2.Panel2.Controls.Add(Me.BtnEdit)
        Me.SplitContainer2.Panel2.Controls.Add(Me.DocumentTypeComboBox)
        Me.SplitContainer2.Panel2.Controls.Add(DocumentTypeLabel)
        Me.SplitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer2.Size = New System.Drawing.Size(641, 684)
        Me.SplitContainer2.SplitterDistance = 274
        Me.SplitContainer2.TabIndex = 0
        Me.SplitContainer2.TabStop = False
        '
        'DocsCatalogueC1TrueDBGrid
        '
        Me.DocsCatalogueC1TrueDBGrid.AllowUpdate = False
        Me.DocsCatalogueC1TrueDBGrid.AlternatingRows = True
        Me.DocsCatalogueC1TrueDBGrid.DataSource = Me.DocsCatalogueBindingSource
        Me.DocsCatalogueC1TrueDBGrid.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy
        Me.DocsCatalogueC1TrueDBGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DocsCatalogueC1TrueDBGrid.ExtendRightColumn = True
        Me.DocsCatalogueC1TrueDBGrid.FilterBar = True
        Me.DocsCatalogueC1TrueDBGrid.FlatStyle = C1.Win.C1TrueDBGrid.FlatModeEnum.Flat
        Me.DocsCatalogueC1TrueDBGrid.GroupByCaption = "Drag a column header here to group by that column"
        Me.DocsCatalogueC1TrueDBGrid.Images.Add(CType(resources.GetObject("DocsCatalogueC1TrueDBGrid.Images"), System.Drawing.Image))
        Me.DocsCatalogueC1TrueDBGrid.LinesPerRow = 10
        Me.DocsCatalogueC1TrueDBGrid.Location = New System.Drawing.Point(0, 0)
        Me.DocsCatalogueC1TrueDBGrid.Name = "DocsCatalogueC1TrueDBGrid"
        Me.DocsCatalogueC1TrueDBGrid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DocsCatalogueC1TrueDBGrid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DocsCatalogueC1TrueDBGrid.PreviewInfo.ZoomFactor = 75.0R
        Me.DocsCatalogueC1TrueDBGrid.PrintInfo.PageSettings = CType(resources.GetObject("DocsCatalogueC1TrueDBGrid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DocsCatalogueC1TrueDBGrid.Size = New System.Drawing.Size(641, 274)
        Me.DocsCatalogueC1TrueDBGrid.TabIndex = 0
        Me.DocsCatalogueC1TrueDBGrid.UseCompatibleTextRendering = False
        Me.DocsCatalogueC1TrueDBGrid.PropBag = resources.GetString("DocsCatalogueC1TrueDBGrid.PropBag")
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
        'BtnCancel1
        '
        Me.BtnCancel1.Location = New System.Drawing.Point(97, 8)
        Me.BtnCancel1.Name = "BtnCancel1"
        Me.BtnCancel1.Size = New System.Drawing.Size(92, 27)
        Me.BtnCancel1.TabIndex = 28
        Me.BtnCancel1.Text = "Cancel"
        Me.BtnCancel1.UseVisualStyleBackColor = True
        '
        'BtnRemove
        '
        Me.BtnRemove.Location = New System.Drawing.Point(362, 8)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(92, 27)
        Me.BtnRemove.TabIndex = 27
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(620, 41)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(14, 20)
        Me.IdTextBox.TabIndex = 20
        Me.IdTextBox.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(453, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 27)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Refresh List"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.Timesheet)
        Me.TabControl1.Controls.Add(Me.ReceiptInvoice)
        Me.TabControl1.Controls.Add(Me.Warranty)
        Me.TabControl1.Controls.Add(Me.Voucher)
        Me.TabControl1.Controls.Add(Me.CorpDocu)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl1.Location = New System.Drawing.Point(0, 80)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(641, 304)
        Me.TabControl1.TabIndex = 26
        Me.TabControl1.TabStop = False
        '
        'Timesheet
        '
        Me.Timesheet.AutoScroll = True
        Me.Timesheet.AutoScrollMinSize = New System.Drawing.Size(0, 300)
        Me.Timesheet.Controls.Add(Me.GrpTimeSheet)
        Me.Timesheet.Location = New System.Drawing.Point(4, 25)
        Me.Timesheet.Name = "Timesheet"
        Me.Timesheet.Padding = New System.Windows.Forms.Padding(3)
        Me.Timesheet.Size = New System.Drawing.Size(633, 275)
        Me.Timesheet.TabIndex = 0
        Me.Timesheet.Text = "Timesheet"
        Me.Timesheet.UseVisualStyleBackColor = True
        '
        'GrpTimeSheet
        '
        Me.GrpTimeSheet.BackColor = System.Drawing.Color.Transparent
        Me.GrpTimeSheet.Controls.Add(Label12)
        Me.GrpTimeSheet.Controls.Add(Label2)
        Me.GrpTimeSheet.Controls.Add(Me.BoxNoTS)
        Me.GrpTimeSheet.Controls.Add(Label3)
        Me.GrpTimeSheet.Controls.Add(Me.RackNoTS)
        Me.GrpTimeSheet.Controls.Add(Me.GroupBox1)
        Me.GrpTimeSheet.Controls.Add(MiddleNameLabel)
        Me.GrpTimeSheet.Controls.Add(Me.MiddleNameTextBox)
        Me.GrpTimeSheet.Controls.Add(FirstNameLabel)
        Me.GrpTimeSheet.Controls.Add(Me.FirstNameTextBox)
        Me.GrpTimeSheet.Controls.Add(LastNameLabel)
        Me.GrpTimeSheet.Controls.Add(Me.LastNameTextBox)
        Me.GrpTimeSheet.Controls.Add(Me.DocumentDateTS)
        Me.GrpTimeSheet.Controls.Add(Me.DTDocuTimeSheet)
        Me.GrpTimeSheet.Controls.Add(Label8)
        Me.GrpTimeSheet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpTimeSheet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpTimeSheet.ForeColor = System.Drawing.Color.Black
        Me.GrpTimeSheet.Location = New System.Drawing.Point(3, 3)
        Me.GrpTimeSheet.Name = "GrpTimeSheet"
        Me.GrpTimeSheet.Size = New System.Drawing.Size(610, 294)
        Me.GrpTimeSheet.TabIndex = 25
        Me.GrpTimeSheet.TabStop = False
        Me.GrpTimeSheet.Text = "Keywords"
        '
        'BoxNoTS
        '
        Me.BoxNoTS.BackColor = System.Drawing.Color.White
        Me.BoxNoTS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BoxNo", True))
        Me.BoxNoTS.Location = New System.Drawing.Point(158, 50)
        Me.BoxNoTS.Name = "BoxNoTS"
        Me.BoxNoTS.Size = New System.Drawing.Size(123, 22)
        Me.BoxNoTS.TabIndex = 7
        '
        'RackNoTS
        '
        Me.RackNoTS.BackColor = System.Drawing.Color.White
        Me.RackNoTS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "RackNo", True))
        Me.RackNoTS.Location = New System.Drawing.Point(158, 27)
        Me.RackNoTS.Name = "RackNoTS"
        Me.RackNoTS.Size = New System.Drawing.Size(123, 22)
        Me.RackNoTS.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label19)
        Me.GroupBox1.Controls.Add(Label18)
        Me.GroupBox1.Controls.Add(FromPeriodLabel)
        Me.GroupBox1.Controls.Add(Me.DTToPeriod)
        Me.GroupBox1.Controls.Add(Me.FromPeriodTextBox)
        Me.GroupBox1.Controls.Add(Me.DTFromPeriod)
        Me.GroupBox1.Controls.Add(Me.ToPeriodTextBox)
        Me.GroupBox1.Controls.Add(ToPeriodLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 185)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(583, 84)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Coverage"
        '
        'DTToPeriod
        '
        Me.DTToPeriod.Location = New System.Drawing.Point(285, 47)
        Me.DTToPeriod.Name = "DTToPeriod"
        Me.DTToPeriod.Size = New System.Drawing.Size(18, 22)
        Me.DTToPeriod.TabIndex = 16
        '
        'FromPeriodTextBox
        '
        Me.FromPeriodTextBox.BackColor = System.Drawing.Color.White
        Me.FromPeriodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "FromPeriod", True))
        Me.FromPeriodTextBox.Location = New System.Drawing.Point(181, 21)
        Me.FromPeriodTextBox.Name = "FromPeriodTextBox"
        Me.FromPeriodTextBox.Size = New System.Drawing.Size(104, 22)
        Me.FromPeriodTextBox.TabIndex = 13
        Me.FromPeriodTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DTFromPeriod
        '
        Me.DTFromPeriod.Location = New System.Drawing.Point(286, 21)
        Me.DTFromPeriod.Name = "DTFromPeriod"
        Me.DTFromPeriod.Size = New System.Drawing.Size(18, 22)
        Me.DTFromPeriod.TabIndex = 14
        '
        'ToPeriodTextBox
        '
        Me.ToPeriodTextBox.BackColor = System.Drawing.Color.White
        Me.ToPeriodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ToPeriod", True))
        Me.ToPeriodTextBox.Location = New System.Drawing.Point(181, 47)
        Me.ToPeriodTextBox.Name = "ToPeriodTextBox"
        Me.ToPeriodTextBox.Size = New System.Drawing.Size(103, 22)
        Me.ToPeriodTextBox.TabIndex = 15
        Me.ToPeriodTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MiddleNameTextBox
        '
        Me.MiddleNameTextBox.BackColor = System.Drawing.Color.White
        Me.MiddleNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "MiddleName", True))
        Me.MiddleNameTextBox.Location = New System.Drawing.Point(158, 151)
        Me.MiddleNameTextBox.Name = "MiddleNameTextBox"
        Me.MiddleNameTextBox.Size = New System.Drawing.Size(367, 22)
        Me.MiddleNameTextBox.TabIndex = 12
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.BackColor = System.Drawing.Color.White
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(158, 128)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(367, 22)
        Me.FirstNameTextBox.TabIndex = 11
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.BackColor = System.Drawing.Color.White
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(158, 105)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(367, 22)
        Me.LastNameTextBox.TabIndex = 10
        '
        'DocumentDateTS
        '
        Me.DocumentDateTS.BackColor = System.Drawing.Color.White
        Me.DocumentDateTS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "DocumentDate", True))
        Me.DocumentDateTS.Location = New System.Drawing.Point(158, 73)
        Me.DocumentDateTS.Name = "DocumentDateTS"
        Me.DocumentDateTS.Size = New System.Drawing.Size(104, 22)
        Me.DocumentDateTS.TabIndex = 8
        Me.DocumentDateTS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DTDocuTimeSheet
        '
        Me.DTDocuTimeSheet.Location = New System.Drawing.Point(263, 73)
        Me.DTDocuTimeSheet.Name = "DTDocuTimeSheet"
        Me.DTDocuTimeSheet.Size = New System.Drawing.Size(18, 22)
        Me.DTDocuTimeSheet.TabIndex = 9
        '
        'ReceiptInvoice
        '
        Me.ReceiptInvoice.AutoScroll = True
        Me.ReceiptInvoice.AutoScrollMinSize = New System.Drawing.Size(0, 400)
        Me.ReceiptInvoice.Controls.Add(Me.GrpReceipt)
        Me.ReceiptInvoice.Location = New System.Drawing.Point(4, 25)
        Me.ReceiptInvoice.Name = "ReceiptInvoice"
        Me.ReceiptInvoice.Padding = New System.Windows.Forms.Padding(3)
        Me.ReceiptInvoice.Size = New System.Drawing.Size(633, 275)
        Me.ReceiptInvoice.TabIndex = 1
        Me.ReceiptInvoice.Text = "Receipt/Invoice"
        Me.ReceiptInvoice.UseVisualStyleBackColor = True
        '
        'GrpReceipt
        '
        Me.GrpReceipt.Controls.Add(Label13)
        Me.GrpReceipt.Controls.Add(Me.NONVATregCheckBox)
        Me.GrpReceipt.Controls.Add(Me.VATregCheckBox)
        Me.GrpReceipt.Controls.Add(AddressCLabel)
        Me.GrpReceipt.Controls.Add(Me.AddressCTextBox)
        Me.GrpReceipt.Controls.Add(TinCustomerLabel)
        Me.GrpReceipt.Controls.Add(Me.TinCustomerTextBox)
        Me.GrpReceipt.Controls.Add(TinVendorLabel)
        Me.GrpReceipt.Controls.Add(Me.TinVendorTextBox)
        Me.GrpReceipt.Controls.Add(BoxNoLabel)
        Me.GrpReceipt.Controls.Add(Me.BoxNoRI)
        Me.GrpReceipt.Controls.Add(RackNoLabel)
        Me.GrpReceipt.Controls.Add(Me.RackNoRI)
        Me.GrpReceipt.Controls.Add(Label1)
        Me.GrpReceipt.Controls.Add(Me.DocumentDateRI)
        Me.GrpReceipt.Controls.Add(TotalValueLabel)
        Me.GrpReceipt.Controls.Add(Me.TotalValueRI)
        Me.GrpReceipt.Controls.Add(ItemPurchasedLabel)
        Me.GrpReceipt.Controls.Add(Me.ItemPurchasedTextBox)
        Me.GrpReceipt.Controls.Add(CustomerLabel)
        Me.GrpReceipt.Controls.Add(Me.CustomerTextBox)
        Me.GrpReceipt.Controls.Add(VendorLabel)
        Me.GrpReceipt.Controls.Add(Me.VendorTextBox)
        Me.GrpReceipt.Controls.Add(BookletNoLabel)
        Me.GrpReceipt.Controls.Add(Me.BookletNoTextBox)
        Me.GrpReceipt.Controls.Add(Me.DTDocuRI)
        Me.GrpReceipt.Controls.Add(ReferenceNoLabel)
        Me.GrpReceipt.Controls.Add(Me.ReferenceNoRI)
        Me.GrpReceipt.Controls.Add(DocumentDateLabel)
        Me.GrpReceipt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpReceipt.ForeColor = System.Drawing.Color.Black
        Me.GrpReceipt.Location = New System.Drawing.Point(3, 3)
        Me.GrpReceipt.Name = "GrpReceipt"
        Me.GrpReceipt.Size = New System.Drawing.Size(610, 394)
        Me.GrpReceipt.TabIndex = 0
        Me.GrpReceipt.TabStop = False
        Me.GrpReceipt.Text = "Keywords"
        '
        'NONVATregCheckBox
        '
        Me.NONVATregCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DocsCatalogueBindingSource, "NONVATreg", True))
        Me.NONVATregCheckBox.Location = New System.Drawing.Point(413, 49)
        Me.NONVATregCheckBox.Name = "NONVATregCheckBox"
        Me.NONVATregCheckBox.Size = New System.Drawing.Size(160, 24)
        Me.NONVATregCheckBox.TabIndex = 19
        Me.NONVATregCheckBox.Text = "NON-VAT Registered"
        Me.NONVATregCheckBox.UseVisualStyleBackColor = True
        '
        'VATregCheckBox
        '
        Me.VATregCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DocsCatalogueBindingSource, "VATreg", True))
        Me.VATregCheckBox.Location = New System.Drawing.Point(413, 27)
        Me.VATregCheckBox.Name = "VATregCheckBox"
        Me.VATregCheckBox.Size = New System.Drawing.Size(127, 24)
        Me.VATregCheckBox.TabIndex = 18
        Me.VATregCheckBox.Text = "VAT Registered"
        Me.VATregCheckBox.UseVisualStyleBackColor = True
        '
        'AddressCTextBox
        '
        Me.AddressCTextBox.BackColor = System.Drawing.Color.White
        Me.AddressCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "AddressC", True))
        Me.AddressCTextBox.Location = New System.Drawing.Point(158, 200)
        Me.AddressCTextBox.Name = "AddressCTextBox"
        Me.AddressCTextBox.Size = New System.Drawing.Size(416, 22)
        Me.AddressCTextBox.TabIndex = 14
        '
        'TinCustomerTextBox
        '
        Me.TinCustomerTextBox.BackColor = System.Drawing.Color.White
        Me.TinCustomerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "TinCustomer", True))
        Me.TinCustomerTextBox.Location = New System.Drawing.Point(158, 252)
        Me.TinCustomerTextBox.Name = "TinCustomerTextBox"
        Me.TinCustomerTextBox.Size = New System.Drawing.Size(182, 22)
        Me.TinCustomerTextBox.TabIndex = 16
        '
        'TinVendorTextBox
        '
        Me.TinVendorTextBox.BackColor = System.Drawing.Color.White
        Me.TinVendorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "TinVendor", True))
        Me.TinVendorTextBox.Location = New System.Drawing.Point(158, 229)
        Me.TinVendorTextBox.Name = "TinVendorTextBox"
        Me.TinVendorTextBox.Size = New System.Drawing.Size(182, 22)
        Me.TinVendorTextBox.TabIndex = 15
        '
        'BoxNoRI
        '
        Me.BoxNoRI.BackColor = System.Drawing.Color.White
        Me.BoxNoRI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BoxNo", True))
        Me.BoxNoRI.Location = New System.Drawing.Point(158, 50)
        Me.BoxNoRI.Name = "BoxNoRI"
        Me.BoxNoRI.Size = New System.Drawing.Size(123, 22)
        Me.BoxNoRI.TabIndex = 7
        '
        'RackNoRI
        '
        Me.RackNoRI.BackColor = System.Drawing.Color.White
        Me.RackNoRI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "RackNo", True))
        Me.RackNoRI.Location = New System.Drawing.Point(158, 27)
        Me.RackNoRI.Name = "RackNoRI"
        Me.RackNoRI.Size = New System.Drawing.Size(123, 22)
        Me.RackNoRI.TabIndex = 6
        '
        'DocumentDateRI
        '
        Me.DocumentDateRI.BackColor = System.Drawing.Color.White
        Me.DocumentDateRI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "DocumentDate", True))
        Me.DocumentDateRI.Location = New System.Drawing.Point(158, 73)
        Me.DocumentDateRI.Name = "DocumentDateRI"
        Me.DocumentDateRI.Size = New System.Drawing.Size(104, 22)
        Me.DocumentDateRI.TabIndex = 8
        Me.DocumentDateRI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TotalValueRI
        '
        Me.TotalValueRI.BackColor = System.Drawing.Color.White
        Me.TotalValueRI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "TotalValue", True))
        Me.TotalValueRI.Location = New System.Drawing.Point(434, 102)
        Me.TotalValueRI.Name = "TotalValueRI"
        Me.TotalValueRI.Size = New System.Drawing.Size(140, 22)
        Me.TotalValueRI.TabIndex = 20
        '
        'ItemPurchasedTextBox
        '
        Me.ItemPurchasedTextBox.BackColor = System.Drawing.Color.White
        Me.ItemPurchasedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ItemPurchased", True))
        Me.ItemPurchasedTextBox.Location = New System.Drawing.Point(158, 284)
        Me.ItemPurchasedTextBox.Multiline = True
        Me.ItemPurchasedTextBox.Name = "ItemPurchasedTextBox"
        Me.ItemPurchasedTextBox.Size = New System.Drawing.Size(416, 83)
        Me.ItemPurchasedTextBox.TabIndex = 17
        '
        'CustomerTextBox
        '
        Me.CustomerTextBox.BackColor = System.Drawing.Color.White
        Me.CustomerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Customer", True))
        Me.CustomerTextBox.Location = New System.Drawing.Point(158, 177)
        Me.CustomerTextBox.Name = "CustomerTextBox"
        Me.CustomerTextBox.Size = New System.Drawing.Size(416, 22)
        Me.CustomerTextBox.TabIndex = 13
        '
        'VendorTextBox
        '
        Me.VendorTextBox.BackColor = System.Drawing.Color.White
        Me.VendorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Vendor", True))
        Me.VendorTextBox.Location = New System.Drawing.Point(158, 154)
        Me.VendorTextBox.Name = "VendorTextBox"
        Me.VendorTextBox.Size = New System.Drawing.Size(416, 22)
        Me.VendorTextBox.TabIndex = 12
        '
        'BookletNoTextBox
        '
        Me.BookletNoTextBox.BackColor = System.Drawing.Color.White
        Me.BookletNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BookletNo", True))
        Me.BookletNoTextBox.Location = New System.Drawing.Point(158, 102)
        Me.BookletNoTextBox.Name = "BookletNoTextBox"
        Me.BookletNoTextBox.Size = New System.Drawing.Size(123, 22)
        Me.BookletNoTextBox.TabIndex = 10
        '
        'DTDocuRI
        '
        Me.DTDocuRI.Location = New System.Drawing.Point(263, 73)
        Me.DTDocuRI.Name = "DTDocuRI"
        Me.DTDocuRI.Size = New System.Drawing.Size(18, 22)
        Me.DTDocuRI.TabIndex = 9
        '
        'ReferenceNoRI
        '
        Me.ReferenceNoRI.BackColor = System.Drawing.Color.White
        Me.ReferenceNoRI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ReferenceNo", True))
        Me.ReferenceNoRI.Location = New System.Drawing.Point(158, 125)
        Me.ReferenceNoRI.Name = "ReferenceNoRI"
        Me.ReferenceNoRI.Size = New System.Drawing.Size(123, 22)
        Me.ReferenceNoRI.TabIndex = 11
        '
        'Warranty
        '
        Me.Warranty.AutoScroll = True
        Me.Warranty.AutoScrollMinSize = New System.Drawing.Size(0, 420)
        Me.Warranty.Controls.Add(Me.GrpWarranty)
        Me.Warranty.Location = New System.Drawing.Point(4, 25)
        Me.Warranty.Name = "Warranty"
        Me.Warranty.Padding = New System.Windows.Forms.Padding(3)
        Me.Warranty.Size = New System.Drawing.Size(633, 275)
        Me.Warranty.TabIndex = 2
        Me.Warranty.Text = "Warranty"
        Me.Warranty.UseVisualStyleBackColor = True
        '
        'GrpWarranty
        '
        Me.GrpWarranty.Controls.Add(Label14)
        Me.GrpWarranty.Controls.Add(Label6)
        Me.GrpWarranty.Controls.Add(Label4)
        Me.GrpWarranty.Controls.Add(Me.BoxNoWarranty)
        Me.GrpWarranty.Controls.Add(Label5)
        Me.GrpWarranty.Controls.Add(Me.RackNoWarranty)
        Me.GrpWarranty.Controls.Add(Me.DTDatePurchased)
        Me.GrpWarranty.Controls.Add(EmailLabel)
        Me.GrpWarranty.Controls.Add(Me.EmailTextBox)
        Me.GrpWarranty.Controls.Add(ContactNoLabel)
        Me.GrpWarranty.Controls.Add(Me.ContactNoTextBox)
        Me.GrpWarranty.Controls.Add(AddressLabel)
        Me.GrpWarranty.Controls.Add(Me.AddressTextBox)
        Me.GrpWarranty.Controls.Add(ServiceCenterLabel)
        Me.GrpWarranty.Controls.Add(Me.ServiceCenterTextBox)
        Me.GrpWarranty.Controls.Add(WarrantyPeriodLabel)
        Me.GrpWarranty.Controls.Add(Me.WarrantyPeriodTextBox)
        Me.GrpWarranty.Controls.Add(SerialLabel)
        Me.GrpWarranty.Controls.Add(Me.SerialTextBox)
        Me.GrpWarranty.Controls.Add(TotalValueLabel1)
        Me.GrpWarranty.Controls.Add(Me.TotalValueWarranty)
        Me.GrpWarranty.Controls.Add(ReferenceNoLabel1)
        Me.GrpWarranty.Controls.Add(Me.ReferenceNoTextBox1)
        Me.GrpWarranty.Controls.Add(DatePurchasedLabel)
        Me.GrpWarranty.Controls.Add(Me.DatePurchasedTextBox)
        Me.GrpWarranty.Controls.Add(ProductTypeLabel)
        Me.GrpWarranty.Controls.Add(Me.ProductTypeTextBox)
        Me.GrpWarranty.Controls.Add(ProductBrandLabel)
        Me.GrpWarranty.Controls.Add(Me.ProductBrandTextBox)
        Me.GrpWarranty.Controls.Add(WarrantyNoLabel)
        Me.GrpWarranty.Controls.Add(Me.WarrantyNoTextBox)
        Me.GrpWarranty.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpWarranty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpWarranty.ForeColor = System.Drawing.Color.Black
        Me.GrpWarranty.Location = New System.Drawing.Point(3, 3)
        Me.GrpWarranty.Name = "GrpWarranty"
        Me.GrpWarranty.Size = New System.Drawing.Size(610, 414)
        Me.GrpWarranty.TabIndex = 0
        Me.GrpWarranty.TabStop = False
        Me.GrpWarranty.Text = "Keywords"
        '
        'BoxNoWarranty
        '
        Me.BoxNoWarranty.BackColor = System.Drawing.Color.White
        Me.BoxNoWarranty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BoxNo", True))
        Me.BoxNoWarranty.Location = New System.Drawing.Point(158, 50)
        Me.BoxNoWarranty.Name = "BoxNoWarranty"
        Me.BoxNoWarranty.Size = New System.Drawing.Size(123, 22)
        Me.BoxNoWarranty.TabIndex = 7
        '
        'RackNoWarranty
        '
        Me.RackNoWarranty.BackColor = System.Drawing.Color.White
        Me.RackNoWarranty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "RackNo", True))
        Me.RackNoWarranty.Location = New System.Drawing.Point(158, 27)
        Me.RackNoWarranty.Name = "RackNoWarranty"
        Me.RackNoWarranty.Size = New System.Drawing.Size(123, 22)
        Me.RackNoWarranty.TabIndex = 6
        '
        'DTDatePurchased
        '
        Me.DTDatePurchased.Location = New System.Drawing.Point(255, 149)
        Me.DTDatePurchased.Name = "DTDatePurchased"
        Me.DTDatePurchased.Size = New System.Drawing.Size(18, 22)
        Me.DTDatePurchased.TabIndex = 12
        '
        'EmailTextBox
        '
        Me.EmailTextBox.BackColor = System.Drawing.Color.White
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(158, 359)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(191, 22)
        Me.EmailTextBox.TabIndex = 19
        '
        'ContactNoTextBox
        '
        Me.ContactNoTextBox.BackColor = System.Drawing.Color.White
        Me.ContactNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ContactNo", True))
        Me.ContactNoTextBox.Location = New System.Drawing.Point(158, 336)
        Me.ContactNoTextBox.Name = "ContactNoTextBox"
        Me.ContactNoTextBox.Size = New System.Drawing.Size(191, 22)
        Me.ContactNoTextBox.TabIndex = 18
        '
        'AddressTextBox
        '
        Me.AddressTextBox.BackColor = System.Drawing.Color.White
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(158, 281)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(414, 47)
        Me.AddressTextBox.TabIndex = 17
        '
        'ServiceCenterTextBox
        '
        Me.ServiceCenterTextBox.BackColor = System.Drawing.Color.White
        Me.ServiceCenterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ServiceCenter", True))
        Me.ServiceCenterTextBox.Location = New System.Drawing.Point(158, 258)
        Me.ServiceCenterTextBox.Name = "ServiceCenterTextBox"
        Me.ServiceCenterTextBox.Size = New System.Drawing.Size(414, 22)
        Me.ServiceCenterTextBox.TabIndex = 16
        '
        'WarrantyPeriodTextBox
        '
        Me.WarrantyPeriodTextBox.BackColor = System.Drawing.Color.White
        Me.WarrantyPeriodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "WarrantyPeriod", True))
        Me.WarrantyPeriodTextBox.Location = New System.Drawing.Point(158, 227)
        Me.WarrantyPeriodTextBox.Name = "WarrantyPeriodTextBox"
        Me.WarrantyPeriodTextBox.Size = New System.Drawing.Size(140, 22)
        Me.WarrantyPeriodTextBox.TabIndex = 15
        '
        'SerialTextBox
        '
        Me.SerialTextBox.BackColor = System.Drawing.Color.White
        Me.SerialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Serial", True))
        Me.SerialTextBox.Location = New System.Drawing.Point(158, 126)
        Me.SerialTextBox.Name = "SerialTextBox"
        Me.SerialTextBox.Size = New System.Drawing.Size(303, 22)
        Me.SerialTextBox.TabIndex = 10
        '
        'TotalValueWarranty
        '
        Me.TotalValueWarranty.BackColor = System.Drawing.Color.White
        Me.TotalValueWarranty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "TotalValue", True))
        Me.TotalValueWarranty.Location = New System.Drawing.Point(158, 382)
        Me.TotalValueWarranty.Name = "TotalValueWarranty"
        Me.TotalValueWarranty.Size = New System.Drawing.Size(191, 22)
        Me.TotalValueWarranty.TabIndex = 20
        '
        'ReferenceNoTextBox1
        '
        Me.ReferenceNoTextBox1.BackColor = System.Drawing.Color.White
        Me.ReferenceNoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ReferenceNo", True))
        Me.ReferenceNoTextBox1.Location = New System.Drawing.Point(158, 181)
        Me.ReferenceNoTextBox1.Name = "ReferenceNoTextBox1"
        Me.ReferenceNoTextBox1.Size = New System.Drawing.Size(140, 22)
        Me.ReferenceNoTextBox1.TabIndex = 13
        '
        'DatePurchasedTextBox
        '
        Me.DatePurchasedTextBox.BackColor = System.Drawing.Color.White
        Me.DatePurchasedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "DatePurchased", True))
        Me.DatePurchasedTextBox.Location = New System.Drawing.Point(158, 149)
        Me.DatePurchasedTextBox.Name = "DatePurchasedTextBox"
        Me.DatePurchasedTextBox.Size = New System.Drawing.Size(95, 22)
        Me.DatePurchasedTextBox.TabIndex = 11
        Me.DatePurchasedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProductTypeTextBox
        '
        Me.ProductTypeTextBox.BackColor = System.Drawing.Color.White
        Me.ProductTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ProductType", True))
        Me.ProductTypeTextBox.Location = New System.Drawing.Point(158, 103)
        Me.ProductTypeTextBox.Name = "ProductTypeTextBox"
        Me.ProductTypeTextBox.Size = New System.Drawing.Size(303, 22)
        Me.ProductTypeTextBox.TabIndex = 9
        '
        'ProductBrandTextBox
        '
        Me.ProductBrandTextBox.BackColor = System.Drawing.Color.White
        Me.ProductBrandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ProductBrand", True))
        Me.ProductBrandTextBox.Location = New System.Drawing.Point(158, 80)
        Me.ProductBrandTextBox.Name = "ProductBrandTextBox"
        Me.ProductBrandTextBox.Size = New System.Drawing.Size(303, 22)
        Me.ProductBrandTextBox.TabIndex = 8
        '
        'WarrantyNoTextBox
        '
        Me.WarrantyNoTextBox.BackColor = System.Drawing.Color.White
        Me.WarrantyNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "WarrantyNo", True))
        Me.WarrantyNoTextBox.Location = New System.Drawing.Point(158, 204)
        Me.WarrantyNoTextBox.Name = "WarrantyNoTextBox"
        Me.WarrantyNoTextBox.Size = New System.Drawing.Size(140, 22)
        Me.WarrantyNoTextBox.TabIndex = 14
        '
        'Voucher
        '
        Me.Voucher.AutoScroll = True
        Me.Voucher.AutoScrollMinSize = New System.Drawing.Size(0, 500)
        Me.Voucher.Controls.Add(Me.GrpVoucher)
        Me.Voucher.Location = New System.Drawing.Point(4, 25)
        Me.Voucher.Name = "Voucher"
        Me.Voucher.Size = New System.Drawing.Size(633, 275)
        Me.Voucher.TabIndex = 3
        Me.Voucher.Text = "Voucher"
        Me.Voucher.UseVisualStyleBackColor = True
        '
        'GrpVoucher
        '
        Me.GrpVoucher.Controls.Add(Label20)
        Me.GrpVoucher.Controls.Add(Label15)
        Me.GrpVoucher.Controls.Add(Me.DTDateReceived)
        Me.GrpVoucher.Controls.Add(Label7)
        Me.GrpVoucher.Controls.Add(Me.BoxNoVoucher)
        Me.GrpVoucher.Controls.Add(Label9)
        Me.GrpVoucher.Controls.Add(Me.RackNoVoucher)
        Me.GrpVoucher.Controls.Add(DateReceivedLabel)
        Me.GrpVoucher.Controls.Add(Me.DateReceivedTextBox)
        Me.GrpVoucher.Controls.Add(Me.PaymentFormComboBox)
        Me.GrpVoucher.Controls.Add(Me.DTDocuVoucher)
        Me.GrpVoucher.Controls.Add(ReceivedbyLabel)
        Me.GrpVoucher.Controls.Add(Me.ReceivedbyTextBox)
        Me.GrpVoucher.Controls.Add(RecordedbyLabel)
        Me.GrpVoucher.Controls.Add(Me.RecordedbyTextBox)
        Me.GrpVoucher.Controls.Add(ApprovedbyLabel)
        Me.GrpVoucher.Controls.Add(Me.ApprovedbyTextBox)
        Me.GrpVoucher.Controls.Add(PreparedbyLabel)
        Me.GrpVoucher.Controls.Add(Me.PreparedbyTextBox)
        Me.GrpVoucher.Controls.Add(PayorLabel)
        Me.GrpVoucher.Controls.Add(Me.PayorTextBox)
        Me.GrpVoucher.Controls.Add(PayeeLabel)
        Me.GrpVoucher.Controls.Add(Me.PayeeTextBox)
        Me.GrpVoucher.Controls.Add(TotalValueLabel2)
        Me.GrpVoucher.Controls.Add(Me.TotalValueVoucher)
        Me.GrpVoucher.Controls.Add(PaymentFormLabel)
        Me.GrpVoucher.Controls.Add(VoucherNoLabel)
        Me.GrpVoucher.Controls.Add(Me.VoucherNoTextBox)
        Me.GrpVoucher.Controls.Add(DocumentDateLabel1)
        Me.GrpVoucher.Controls.Add(Me.DocumentDateVoucher)
        Me.GrpVoucher.Controls.Add(Me.TabControl2)
        Me.GrpVoucher.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpVoucher.ForeColor = System.Drawing.Color.Black
        Me.GrpVoucher.Location = New System.Drawing.Point(0, 0)
        Me.GrpVoucher.Name = "GrpVoucher"
        Me.GrpVoucher.Size = New System.Drawing.Size(616, 500)
        Me.GrpVoucher.TabIndex = 1
        Me.GrpVoucher.TabStop = False
        Me.GrpVoucher.Text = "Keywords"
        '
        'DTDateReceived
        '
        Me.DTDateReceived.Location = New System.Drawing.Point(259, 441)
        Me.DTDateReceived.Name = "DTDateReceived"
        Me.DTDateReceived.Size = New System.Drawing.Size(18, 22)
        Me.DTDateReceived.TabIndex = 23
        '
        'BoxNoVoucher
        '
        Me.BoxNoVoucher.BackColor = System.Drawing.Color.White
        Me.BoxNoVoucher.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BoxNo", True))
        Me.BoxNoVoucher.Location = New System.Drawing.Point(158, 50)
        Me.BoxNoVoucher.Name = "BoxNoVoucher"
        Me.BoxNoVoucher.Size = New System.Drawing.Size(123, 22)
        Me.BoxNoVoucher.TabIndex = 7
        '
        'RackNoVoucher
        '
        Me.RackNoVoucher.BackColor = System.Drawing.Color.White
        Me.RackNoVoucher.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "RackNo", True))
        Me.RackNoVoucher.Location = New System.Drawing.Point(158, 27)
        Me.RackNoVoucher.Name = "RackNoVoucher"
        Me.RackNoVoucher.Size = New System.Drawing.Size(123, 22)
        Me.RackNoVoucher.TabIndex = 6
        '
        'DateReceivedTextBox
        '
        Me.DateReceivedTextBox.BackColor = System.Drawing.Color.White
        Me.DateReceivedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "DateReceived", True))
        Me.DateReceivedTextBox.Location = New System.Drawing.Point(158, 441)
        Me.DateReceivedTextBox.Name = "DateReceivedTextBox"
        Me.DateReceivedTextBox.Size = New System.Drawing.Size(100, 22)
        Me.DateReceivedTextBox.TabIndex = 22
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
        Me.PaymentFormComboBox.TabIndex = 13
        '
        'DTDocuVoucher
        '
        Me.DTDocuVoucher.Location = New System.Drawing.Point(259, 73)
        Me.DTDocuVoucher.Name = "DTDocuVoucher"
        Me.DTDocuVoucher.Size = New System.Drawing.Size(18, 22)
        Me.DTDocuVoucher.TabIndex = 9
        '
        'ReceivedbyTextBox
        '
        Me.ReceivedbyTextBox.BackColor = System.Drawing.Color.White
        Me.ReceivedbyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Receivedby", True))
        Me.ReceivedbyTextBox.Location = New System.Drawing.Point(158, 418)
        Me.ReceivedbyTextBox.Name = "ReceivedbyTextBox"
        Me.ReceivedbyTextBox.Size = New System.Drawing.Size(326, 22)
        Me.ReceivedbyTextBox.TabIndex = 21
        '
        'RecordedbyTextBox
        '
        Me.RecordedbyTextBox.BackColor = System.Drawing.Color.White
        Me.RecordedbyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Recordedby", True))
        Me.RecordedbyTextBox.Location = New System.Drawing.Point(158, 395)
        Me.RecordedbyTextBox.Name = "RecordedbyTextBox"
        Me.RecordedbyTextBox.Size = New System.Drawing.Size(326, 22)
        Me.RecordedbyTextBox.TabIndex = 20
        '
        'ApprovedbyTextBox
        '
        Me.ApprovedbyTextBox.BackColor = System.Drawing.Color.White
        Me.ApprovedbyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Approvedby", True))
        Me.ApprovedbyTextBox.Location = New System.Drawing.Point(158, 372)
        Me.ApprovedbyTextBox.Name = "ApprovedbyTextBox"
        Me.ApprovedbyTextBox.Size = New System.Drawing.Size(326, 22)
        Me.ApprovedbyTextBox.TabIndex = 19
        '
        'PreparedbyTextBox
        '
        Me.PreparedbyTextBox.BackColor = System.Drawing.Color.White
        Me.PreparedbyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Preparedby", True))
        Me.PreparedbyTextBox.Location = New System.Drawing.Point(158, 349)
        Me.PreparedbyTextBox.Name = "PreparedbyTextBox"
        Me.PreparedbyTextBox.Size = New System.Drawing.Size(326, 22)
        Me.PreparedbyTextBox.TabIndex = 18
        '
        'PayorTextBox
        '
        Me.PayorTextBox.BackColor = System.Drawing.Color.White
        Me.PayorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Payor", True))
        Me.PayorTextBox.Location = New System.Drawing.Point(158, 126)
        Me.PayorTextBox.Name = "PayorTextBox"
        Me.PayorTextBox.Size = New System.Drawing.Size(406, 22)
        Me.PayorTextBox.TabIndex = 11
        '
        'PayeeTextBox
        '
        Me.PayeeTextBox.BackColor = System.Drawing.Color.White
        Me.PayeeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Payee", True))
        Me.PayeeTextBox.Location = New System.Drawing.Point(158, 103)
        Me.PayeeTextBox.Name = "PayeeTextBox"
        Me.PayeeTextBox.Size = New System.Drawing.Size(406, 22)
        Me.PayeeTextBox.TabIndex = 10
        '
        'TotalValueVoucher
        '
        Me.TotalValueVoucher.BackColor = System.Drawing.Color.White
        Me.TotalValueVoucher.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "TotalValue", True))
        Me.TotalValueVoucher.Location = New System.Drawing.Point(158, 326)
        Me.TotalValueVoucher.Name = "TotalValueVoucher"
        Me.TotalValueVoucher.Size = New System.Drawing.Size(183, 22)
        Me.TotalValueVoucher.TabIndex = 17
        '
        'VoucherNoTextBox
        '
        Me.VoucherNoTextBox.BackColor = System.Drawing.Color.White
        Me.VoucherNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "VoucherNo", True))
        Me.VoucherNoTextBox.Location = New System.Drawing.Point(158, 149)
        Me.VoucherNoTextBox.Name = "VoucherNoTextBox"
        Me.VoucherNoTextBox.Size = New System.Drawing.Size(183, 22)
        Me.VoucherNoTextBox.TabIndex = 12
        '
        'DocumentDateVoucher
        '
        Me.DocumentDateVoucher.BackColor = System.Drawing.Color.White
        Me.DocumentDateVoucher.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "DocumentDate", True))
        Me.DocumentDateVoucher.Location = New System.Drawing.Point(158, 73)
        Me.DocumentDateVoucher.Name = "DocumentDateVoucher"
        Me.DocumentDateVoucher.Size = New System.Drawing.Size(100, 22)
        Me.DocumentDateVoucher.TabIndex = 8
        Me.DocumentDateVoucher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabControl2
        '
        Me.TabControl2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl2.Controls.Add(Me.BankDepo)
        Me.TabControl2.Controls.Add(Me.Others)
        Me.TabControl2.Controls.Add(Me.Check)
        Me.TabControl2.Location = New System.Drawing.Point(0, 202)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(564, 129)
        Me.TabControl2.TabIndex = 21
        Me.TabControl2.TabStop = False
        '
        'BankDepo
        '
        Me.BankDepo.AutoScroll = True
        Me.BankDepo.BackColor = System.Drawing.SystemColors.Control
        Me.BankDepo.Controls.Add(BankAddressLabel)
        Me.BankDepo.Controls.Add(Me.BankAddressTextBox)
        Me.BankDepo.Controls.Add(BankBranchLabel)
        Me.BankDepo.Controls.Add(Me.BankBranchTextBox)
        Me.BankDepo.Controls.Add(BankNameLabel)
        Me.BankDepo.Controls.Add(Me.BankNameTextBox)
        Me.BankDepo.Location = New System.Drawing.Point(4, 28)
        Me.BankDepo.Name = "BankDepo"
        Me.BankDepo.Padding = New System.Windows.Forms.Padding(3)
        Me.BankDepo.Size = New System.Drawing.Size(556, 97)
        Me.BankDepo.TabIndex = 0
        Me.BankDepo.Text = "BankDepo"
        Me.BankDepo.UseVisualStyleBackColor = True
        '
        'BankAddressTextBox
        '
        Me.BankAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BankAddress", True))
        Me.BankAddressTextBox.Location = New System.Drawing.Point(154, 48)
        Me.BankAddressTextBox.Multiline = True
        Me.BankAddressTextBox.Name = "BankAddressTextBox"
        Me.BankAddressTextBox.Size = New System.Drawing.Size(367, 46)
        Me.BankAddressTextBox.TabIndex = 16
        '
        'BankBranchTextBox
        '
        Me.BankBranchTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BankBranch", True))
        Me.BankBranchTextBox.Location = New System.Drawing.Point(154, 25)
        Me.BankBranchTextBox.Name = "BankBranchTextBox"
        Me.BankBranchTextBox.Size = New System.Drawing.Size(367, 22)
        Me.BankBranchTextBox.TabIndex = 15
        '
        'BankNameTextBox
        '
        Me.BankNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BankName", True))
        Me.BankNameTextBox.Location = New System.Drawing.Point(154, 2)
        Me.BankNameTextBox.Name = "BankNameTextBox"
        Me.BankNameTextBox.Size = New System.Drawing.Size(367, 22)
        Me.BankNameTextBox.TabIndex = 14
        '
        'Others
        '
        Me.Others.AutoScroll = True
        Me.Others.BackColor = System.Drawing.SystemColors.Control
        Me.Others.Controls.Add(PaymentOthersLabel)
        Me.Others.Controls.Add(Me.PaymentOthersTextBox)
        Me.Others.Location = New System.Drawing.Point(4, 28)
        Me.Others.Name = "Others"
        Me.Others.Padding = New System.Windows.Forms.Padding(3)
        Me.Others.Size = New System.Drawing.Size(556, 97)
        Me.Others.TabIndex = 1
        Me.Others.Text = "Others"
        Me.Others.UseVisualStyleBackColor = True
        '
        'PaymentOthersTextBox
        '
        Me.PaymentOthersTextBox.BackColor = System.Drawing.Color.White
        Me.PaymentOthersTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "PaymentOthers", True))
        Me.PaymentOthersTextBox.Location = New System.Drawing.Point(154, 4)
        Me.PaymentOthersTextBox.Name = "PaymentOthersTextBox"
        Me.PaymentOthersTextBox.Size = New System.Drawing.Size(367, 22)
        Me.PaymentOthersTextBox.TabIndex = 14
        '
        'Check
        '
        Me.Check.Controls.Add(Me.CheckNoTextBox)
        Me.Check.Controls.Add(CheckNoLabel)
        Me.Check.Location = New System.Drawing.Point(4, 28)
        Me.Check.Name = "Check"
        Me.Check.Size = New System.Drawing.Size(556, 97)
        Me.Check.TabIndex = 2
        Me.Check.Text = "Check"
        Me.Check.UseVisualStyleBackColor = True
        '
        'CheckNoTextBox
        '
        Me.CheckNoTextBox.BackColor = System.Drawing.Color.White
        Me.CheckNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "CheckNo", True))
        Me.CheckNoTextBox.Location = New System.Drawing.Point(154, 4)
        Me.CheckNoTextBox.Name = "CheckNoTextBox"
        Me.CheckNoTextBox.Size = New System.Drawing.Size(367, 22)
        Me.CheckNoTextBox.TabIndex = 14
        '
        'CorpDocu
        '
        Me.CorpDocu.AutoScroll = True
        Me.CorpDocu.AutoScrollMinSize = New System.Drawing.Size(0, 350)
        Me.CorpDocu.Controls.Add(Me.GrpCorp)
        Me.CorpDocu.Location = New System.Drawing.Point(4, 25)
        Me.CorpDocu.Name = "CorpDocu"
        Me.CorpDocu.Size = New System.Drawing.Size(633, 275)
        Me.CorpDocu.TabIndex = 4
        Me.CorpDocu.Text = "CorpDocu"
        Me.CorpDocu.UseVisualStyleBackColor = True
        '
        'GrpCorp
        '
        Me.GrpCorp.Controls.Add(Label17)
        Me.GrpCorp.Controls.Add(Label16)
        Me.GrpCorp.Controls.Add(Label10)
        Me.GrpCorp.Controls.Add(Me.BoxNoCorpDocu)
        Me.GrpCorp.Controls.Add(Label11)
        Me.GrpCorp.Controls.Add(Me.RackNoCorpDocu)
        Me.GrpCorp.Controls.Add(Me.DTMeetingDate)
        Me.GrpCorp.Controls.Add(Me.DTDocuCorp)
        Me.GrpCorp.Controls.Add(MeetingDateLabel)
        Me.GrpCorp.Controls.Add(Me.MeetingDateTextBox)
        Me.GrpCorp.Controls.Add(SecretaryLabel)
        Me.GrpCorp.Controls.Add(Me.SecretaryTextBox)
        Me.GrpCorp.Controls.Add(PurposeLabel)
        Me.GrpCorp.Controls.Add(Me.PurposeTextBox)
        Me.GrpCorp.Controls.Add(CompanyLabel)
        Me.GrpCorp.Controls.Add(Me.CompanyTextBox)
        Me.GrpCorp.Controls.Add(DocumentDateLabel2)
        Me.GrpCorp.Controls.Add(Me.DocumentDateCorp)
        Me.GrpCorp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpCorp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpCorp.ForeColor = System.Drawing.Color.Black
        Me.GrpCorp.Location = New System.Drawing.Point(0, 0)
        Me.GrpCorp.Name = "GrpCorp"
        Me.GrpCorp.Size = New System.Drawing.Size(616, 350)
        Me.GrpCorp.TabIndex = 1
        Me.GrpCorp.TabStop = False
        Me.GrpCorp.Text = "Keywords"
        '
        'BoxNoCorpDocu
        '
        Me.BoxNoCorpDocu.BackColor = System.Drawing.Color.White
        Me.BoxNoCorpDocu.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BoxNo", True))
        Me.BoxNoCorpDocu.Location = New System.Drawing.Point(158, 50)
        Me.BoxNoCorpDocu.Name = "BoxNoCorpDocu"
        Me.BoxNoCorpDocu.Size = New System.Drawing.Size(123, 22)
        Me.BoxNoCorpDocu.TabIndex = 7
        '
        'RackNoCorpDocu
        '
        Me.RackNoCorpDocu.BackColor = System.Drawing.Color.White
        Me.RackNoCorpDocu.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "RackNo", True))
        Me.RackNoCorpDocu.Location = New System.Drawing.Point(158, 27)
        Me.RackNoCorpDocu.Name = "RackNoCorpDocu"
        Me.RackNoCorpDocu.Size = New System.Drawing.Size(123, 22)
        Me.RackNoCorpDocu.TabIndex = 6
        '
        'DTMeetingDate
        '
        Me.DTMeetingDate.Location = New System.Drawing.Point(259, 103)
        Me.DTMeetingDate.Name = "DTMeetingDate"
        Me.DTMeetingDate.Size = New System.Drawing.Size(18, 22)
        Me.DTMeetingDate.TabIndex = 11
        '
        'DTDocuCorp
        '
        Me.DTDocuCorp.Location = New System.Drawing.Point(259, 73)
        Me.DTDocuCorp.Name = "DTDocuCorp"
        Me.DTDocuCorp.Size = New System.Drawing.Size(18, 22)
        Me.DTDocuCorp.TabIndex = 9
        '
        'MeetingDateTextBox
        '
        Me.MeetingDateTextBox.BackColor = System.Drawing.Color.White
        Me.MeetingDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "MeetingDate", True))
        Me.MeetingDateTextBox.Location = New System.Drawing.Point(158, 103)
        Me.MeetingDateTextBox.Name = "MeetingDateTextBox"
        Me.MeetingDateTextBox.Size = New System.Drawing.Size(100, 22)
        Me.MeetingDateTextBox.TabIndex = 10
        Me.MeetingDateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SecretaryTextBox
        '
        Me.SecretaryTextBox.BackColor = System.Drawing.Color.White
        Me.SecretaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Secretary", True))
        Me.SecretaryTextBox.Location = New System.Drawing.Point(158, 149)
        Me.SecretaryTextBox.Name = "SecretaryTextBox"
        Me.SecretaryTextBox.Size = New System.Drawing.Size(416, 22)
        Me.SecretaryTextBox.TabIndex = 13
        '
        'PurposeTextBox
        '
        Me.PurposeTextBox.BackColor = System.Drawing.Color.White
        Me.PurposeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Purpose", True))
        Me.PurposeTextBox.Location = New System.Drawing.Point(158, 183)
        Me.PurposeTextBox.Multiline = True
        Me.PurposeTextBox.Name = "PurposeTextBox"
        Me.PurposeTextBox.Size = New System.Drawing.Size(416, 137)
        Me.PurposeTextBox.TabIndex = 14
        '
        'CompanyTextBox
        '
        Me.CompanyTextBox.BackColor = System.Drawing.Color.White
        Me.CompanyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Company", True))
        Me.CompanyTextBox.Location = New System.Drawing.Point(158, 126)
        Me.CompanyTextBox.Name = "CompanyTextBox"
        Me.CompanyTextBox.Size = New System.Drawing.Size(416, 22)
        Me.CompanyTextBox.TabIndex = 12
        '
        'DocumentDateCorp
        '
        Me.DocumentDateCorp.BackColor = System.Drawing.Color.White
        Me.DocumentDateCorp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "DocumentDate", True))
        Me.DocumentDateCorp.Location = New System.Drawing.Point(158, 73)
        Me.DocumentDateCorp.Name = "DocumentDateCorp"
        Me.DocumentDateCorp.Size = New System.Drawing.Size(100, 22)
        Me.DocumentDateCorp.TabIndex = 8
        Me.DocumentDateCorp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LblStat})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 384)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(641, 22)
        Me.StatusStrip1.TabIndex = 18
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LblStat
        '
        Me.LblStat.Name = "LblStat"
        Me.LblStat.Size = New System.Drawing.Size(121, 17)
        Me.LblStat.Text = "ToolStripStatusLabel1"
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(544, 8)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(92, 27)
        Me.BtnClear.TabIndex = 4
        Me.BtnClear.Text = "Clear Keys"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(188, 8)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(92, 27)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(6, 8)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(92, 27)
        Me.BtnEdit.TabIndex = 1
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'DocumentTypeComboBox
        '
        Me.DocumentTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "DocumentType", True))
        Me.DocumentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DocumentTypeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentTypeComboBox.FormattingEnabled = True
        Me.DocumentTypeComboBox.Location = New System.Drawing.Point(140, 46)
        Me.DocumentTypeComboBox.Name = "DocumentTypeComboBox"
        Me.DocumentTypeComboBox.Size = New System.Drawing.Size(396, 28)
        Me.DocumentTypeComboBox.TabIndex = 5
        '
        'AcroReader1
        '
        Me.AcroReader1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AcroReader1.Enabled = True
        Me.AcroReader1.Location = New System.Drawing.Point(0, 0)
        Me.AcroReader1.Name = "AcroReader1"
        Me.AcroReader1.OcxState = CType(resources.GetObject("AcroReader1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AcroReader1.Size = New System.Drawing.Size(552, 684)
        Me.AcroReader1.TabIndex = 0
        '
        'DocsCatalogueTableAdapter
        '
        Me.DocsCatalogueTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DocsCatalogueTableAdapter = Me.DocsCatalogueTableAdapter
        Me.TableAdapterManager.DocumentGroupsTableAdapter = Nothing
        Me.TableAdapterManager.DocumentTypesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DMS.DMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FrmEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1197, 684)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editor"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.DocsCatalogueC1TrueDBGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocsCatalogueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
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
        Me.TabControl2.ResumeLayout(False)
        Me.BankDepo.ResumeLayout(False)
        Me.BankDepo.PerformLayout()
        Me.Others.ResumeLayout(False)
        Me.Others.PerformLayout()
        Me.Check.ResumeLayout(False)
        Me.Check.PerformLayout()
        Me.CorpDocu.ResumeLayout(False)
        Me.GrpCorp.ResumeLayout(False)
        Me.GrpCorp.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.AcroReader1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents GrpReceipt As GroupBox
    Friend WithEvents DMSDataSet As DMSDataSet
    Friend WithEvents DocumentTypeComboBox As ComboBox
    Friend WithEvents BtnClear As Button
    Friend WithEvents ReferenceNoRI As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents LblStat As ToolStripStatusLabel
    Friend WithEvents DTDocuRI As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents DocsCatalogueBindingSource As BindingSource
    Friend WithEvents DocsCatalogueTableAdapter As DMSDataSetTableAdapters.DocsCatalogueTableAdapter
    Friend WithEvents TableAdapterManager As DMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TotalValueRI As TextBox
    Friend WithEvents ItemPurchasedTextBox As TextBox
    Friend WithEvents CustomerTextBox As TextBox
    Friend WithEvents VendorTextBox As TextBox
    Friend WithEvents BookletNoTextBox As TextBox
    Friend WithEvents AcroReader1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents DocumentDateRI As TextBox
    Friend WithEvents GrpTimeSheet As GroupBox
    Friend WithEvents MiddleNameTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents DocumentDateTS As TextBox
    Friend WithEvents DTToPeriod As DateTimePicker
    Friend WithEvents DTFromPeriod As DateTimePicker
    Friend WithEvents ToPeriodTextBox As TextBox
    Friend WithEvents FromPeriodTextBox As TextBox
    Friend WithEvents DTDocuTimeSheet As DateTimePicker
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ReceiptInvoice As TabPage
    Friend WithEvents Timesheet As TabPage
    Friend WithEvents Warranty As TabPage
    Friend WithEvents Voucher As TabPage
    Friend WithEvents CorpDocu As TabPage
    Friend WithEvents GrpWarranty As GroupBox
    Friend WithEvents GrpVoucher As GroupBox
    Friend WithEvents GrpCorp As GroupBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents ContactNoTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents ServiceCenterTextBox As TextBox
    Friend WithEvents WarrantyPeriodTextBox As TextBox
    Friend WithEvents SerialTextBox As TextBox
    Friend WithEvents TotalValueWarranty As TextBox
    Friend WithEvents ReferenceNoTextBox1 As TextBox
    Friend WithEvents DatePurchasedTextBox As TextBox
    Friend WithEvents ProductTypeTextBox As TextBox
    Friend WithEvents ProductBrandTextBox As TextBox
    Friend WithEvents WarrantyNoTextBox As TextBox
    Friend WithEvents RecordedbyTextBox As TextBox
    Friend WithEvents ApprovedbyTextBox As TextBox
    Friend WithEvents PreparedbyTextBox As TextBox
    Friend WithEvents PayorTextBox As TextBox
    Friend WithEvents PayeeTextBox As TextBox
    Friend WithEvents TotalValueVoucher As TextBox
    Friend WithEvents CheckNoTextBox As TextBox
    Friend WithEvents PaymentFormTextBox As TextBox
    Friend WithEvents VoucherNoTextBox As TextBox
    Friend WithEvents DocumentDateVoucher As TextBox
    Friend WithEvents ReceivedbyTextBox As TextBox
    Friend WithEvents MeetingDateTextBox As TextBox
    Friend WithEvents SecretaryTextBox As TextBox
    Friend WithEvents PurposeTextBox As TextBox
    Friend WithEvents CompanyTextBox As TextBox
    Friend WithEvents DocumentDateCorp As TextBox
    Friend WithEvents DTDatePurchased As DateTimePicker
    Friend WithEvents DTDocuVoucher As DateTimePicker
    Friend WithEvents DTMeetingDate As DateTimePicker
    Friend WithEvents DTDocuCorp As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PaymentFormComboBox As ComboBox
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents Others As TabPage
    Friend WithEvents BankDepo As TabPage
    Friend WithEvents Check As TabPage
    Friend WithEvents PaymentOthersTextBox As TextBox
    Friend WithEvents BankAddressTextBox As TextBox
    Friend WithEvents BankBranchTextBox As TextBox
    Friend WithEvents BankNameTextBox As TextBox
    Friend WithEvents BoxNoRI As TextBox
    Friend WithEvents RackNoRI As TextBox
    Friend WithEvents BoxNoTS As TextBox
    Friend WithEvents RackNoTS As TextBox
    Friend WithEvents NONVATregCheckBox As CheckBox
    Friend WithEvents VATregCheckBox As CheckBox
    Friend WithEvents AddressCTextBox As TextBox
    Friend WithEvents TinCustomerTextBox As TextBox
    Friend WithEvents TinVendorTextBox As TextBox
    Friend WithEvents DateReceivedTextBox As TextBox
    Friend WithEvents BoxNoWarranty As TextBox
    Friend WithEvents RackNoWarranty As TextBox
    Friend WithEvents BoxNoVoucher As TextBox
    Friend WithEvents RackNoVoucher As TextBox
    Friend WithEvents DTDateReceived As DateTimePicker
    Friend WithEvents BoxNoCorpDocu As TextBox
    Friend WithEvents RackNoCorpDocu As TextBox
    Friend WithEvents BtnRemove As Button
    Friend WithEvents BtnCancel1 As Button
    Friend WithEvents DocsCatalogueC1TrueDBGrid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
End Class
