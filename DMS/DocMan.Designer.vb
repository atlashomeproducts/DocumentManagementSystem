<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DocMan
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
        Dim RemarksLabel As System.Windows.Forms.Label
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DocMan))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.DocsCatalogueC1TrueDBGrid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.DocsCatalogueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DMSDataSet = New DMS.DMSDataSet()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Timesheet = New System.Windows.Forms.TabPage()
        Me.GrpTimeSheet = New System.Windows.Forms.GroupBox()
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
        Me.DocumentDateRI = New System.Windows.Forms.TextBox()
        Me.TotalValueRI = New System.Windows.Forms.TextBox()
        Me.ItemPurchasedTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerTextBox = New System.Windows.Forms.TextBox()
        Me.VendorTextBox = New System.Windows.Forms.TextBox()
        Me.BookletNoTextBox = New System.Windows.Forms.TextBox()
        Me.DTDocuRI = New System.Windows.Forms.DateTimePicker()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.ReferenceNoRI = New System.Windows.Forms.TextBox()
        Me.Warranty = New System.Windows.Forms.TabPage()
        Me.GrpWarranty = New System.Windows.Forms.GroupBox()
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
        Me.BtnRefresh = New AxAcroPDFLib.AxAcroPDF()
        Me.DocsCatalogueTableAdapter = New DMS.DMSDataSetTableAdapters.DocsCatalogueTableAdapter()
        Me.TableAdapterManager = New DMS.DMSDataSetTableAdapters.TableAdapterManager()
        DocumentTypeLabel = New System.Windows.Forms.Label()
        DocumentDateLabel = New System.Windows.Forms.Label()
        ReferenceNoLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
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
        CType(Me.BtnRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
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
        DocumentDateLabel.Location = New System.Drawing.Point(21, 29)
        DocumentDateLabel.Name = "DocumentDateLabel"
        DocumentDateLabel.Size = New System.Drawing.Size(116, 18)
        DocumentDateLabel.TabIndex = 2
        DocumentDateLabel.Text = "Document Date:"
        '
        'ReferenceNoLabel
        '
        ReferenceNoLabel.AutoSize = True
        ReferenceNoLabel.Location = New System.Drawing.Point(1, 79)
        ReferenceNoLabel.Name = "ReferenceNoLabel"
        ReferenceNoLabel.Size = New System.Drawing.Size(136, 18)
        ReferenceNoLabel.TabIndex = 5
        ReferenceNoLabel.Text = "Reciept/Invoice No:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(64, 202)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(73, 18)
        RemarksLabel.TabIndex = 13
        RemarksLabel.Text = "Remarks:"
        '
        'BookletNoLabel
        '
        BookletNoLabel.AutoSize = True
        BookletNoLabel.Location = New System.Drawing.Point(50, 54)
        BookletNoLabel.Name = "BookletNoLabel"
        BookletNoLabel.Size = New System.Drawing.Size(87, 18)
        BookletNoLabel.TabIndex = 18
        BookletNoLabel.Text = "Booklet No:"
        '
        'VendorLabel
        '
        VendorLabel.AutoSize = True
        VendorLabel.Location = New System.Drawing.Point(78, 104)
        VendorLabel.Name = "VendorLabel"
        VendorLabel.Size = New System.Drawing.Size(59, 18)
        VendorLabel.TabIndex = 19
        VendorLabel.Text = "Vendor:"
        '
        'CustomerLabel
        '
        CustomerLabel.AutoSize = True
        CustomerLabel.Location = New System.Drawing.Point(59, 129)
        CustomerLabel.Name = "CustomerLabel"
        CustomerLabel.Size = New System.Drawing.Size(78, 18)
        CustomerLabel.TabIndex = 20
        CustomerLabel.Text = "Customer:"
        '
        'ItemPurchasedLabel
        '
        ItemPurchasedLabel.AutoSize = True
        ItemPurchasedLabel.Location = New System.Drawing.Point(22, 155)
        ItemPurchasedLabel.Name = "ItemPurchasedLabel"
        ItemPurchasedLabel.Size = New System.Drawing.Size(115, 18)
        ItemPurchasedLabel.TabIndex = 21
        ItemPurchasedLabel.Text = "Item Purchased:"
        '
        'TotalValueLabel
        '
        TotalValueLabel.AutoSize = True
        TotalValueLabel.Location = New System.Drawing.Point(334, 54)
        TotalValueLabel.Name = "TotalValueLabel"
        TotalValueLabel.Size = New System.Drawing.Size(85, 18)
        TotalValueLabel.TabIndex = 22
        TotalValueLabel.Text = "Total Value:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(21, 29)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(116, 18)
        Label8.TabIndex = 2
        Label8.Text = "Document Date:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(50, 61)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(84, 18)
        LastNameLabel.TabIndex = 24
        LastNameLabel.Text = "Last Name:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(49, 87)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(85, 18)
        FirstNameLabel.TabIndex = 25
        FirstNameLabel.Text = "First Name:"
        '
        'MiddleNameLabel
        '
        MiddleNameLabel.AutoSize = True
        MiddleNameLabel.Location = New System.Drawing.Point(35, 113)
        MiddleNameLabel.Name = "MiddleNameLabel"
        MiddleNameLabel.Size = New System.Drawing.Size(99, 18)
        MiddleNameLabel.TabIndex = 26
        MiddleNameLabel.Text = "Middle Name:"
        '
        'FromPeriodLabel
        '
        FromPeriodLabel.AutoSize = True
        FromPeriodLabel.Location = New System.Drawing.Point(52, 24)
        FromPeriodLabel.Name = "FromPeriodLabel"
        FromPeriodLabel.Size = New System.Drawing.Size(48, 18)
        FromPeriodLabel.TabIndex = 27
        FromPeriodLabel.Text = "From:"
        '
        'ToPeriodLabel
        '
        ToPeriodLabel.AutoSize = True
        ToPeriodLabel.Location = New System.Drawing.Point(71, 50)
        ToPeriodLabel.Name = "ToPeriodLabel"
        ToPeriodLabel.Size = New System.Drawing.Size(30, 18)
        ToPeriodLabel.TabIndex = 28
        ToPeriodLabel.Text = "To:"
        '
        'WarrantyNoLabel
        '
        WarrantyNoLabel.AutoSize = True
        WarrantyNoLabel.Location = New System.Drawing.Point(42, 137)
        WarrantyNoLabel.Name = "WarrantyNoLabel"
        WarrantyNoLabel.Size = New System.Drawing.Size(96, 18)
        WarrantyNoLabel.TabIndex = 0
        WarrantyNoLabel.Text = "Warranty No:"
        '
        'ProductBrandLabel
        '
        ProductBrandLabel.AutoSize = True
        ProductBrandLabel.Location = New System.Drawing.Point(31, 29)
        ProductBrandLabel.Name = "ProductBrandLabel"
        ProductBrandLabel.Size = New System.Drawing.Size(107, 18)
        ProductBrandLabel.TabIndex = 2
        ProductBrandLabel.Text = "Product Brand:"
        '
        'ProductTypeLabel
        '
        ProductTypeLabel.AutoSize = True
        ProductTypeLabel.Location = New System.Drawing.Point(38, 54)
        ProductTypeLabel.Name = "ProductTypeLabel"
        ProductTypeLabel.Size = New System.Drawing.Size(100, 18)
        ProductTypeLabel.TabIndex = 4
        ProductTypeLabel.Text = "Product Type:"
        '
        'DatePurchasedLabel
        '
        DatePurchasedLabel.AutoSize = True
        DatePurchasedLabel.Location = New System.Drawing.Point(377, 29)
        DatePurchasedLabel.Name = "DatePurchasedLabel"
        DatePurchasedLabel.Size = New System.Drawing.Size(118, 18)
        DatePurchasedLabel.TabIndex = 6
        DatePurchasedLabel.Text = "Date Purchased:"
        '
        'ReferenceNoLabel1
        '
        ReferenceNoLabel1.AutoSize = True
        ReferenceNoLabel1.Location = New System.Drawing.Point(56, 111)
        ReferenceNoLabel1.Name = "ReferenceNoLabel1"
        ReferenceNoLabel1.Size = New System.Drawing.Size(82, 18)
        ReferenceNoLabel1.TabIndex = 8
        ReferenceNoLabel1.Text = "Invoice No:"
        '
        'TotalValueLabel1
        '
        TotalValueLabel1.AutoSize = True
        TotalValueLabel1.Location = New System.Drawing.Point(332, 159)
        TotalValueLabel1.Name = "TotalValueLabel1"
        TotalValueLabel1.Size = New System.Drawing.Size(63, 18)
        TotalValueLabel1.TabIndex = 10
        TotalValueLabel1.Text = "Amount:"
        '
        'SerialLabel
        '
        SerialLabel.AutoSize = True
        SerialLabel.Location = New System.Drawing.Point(89, 79)
        SerialLabel.Name = "SerialLabel"
        SerialLabel.Size = New System.Drawing.Size(49, 18)
        SerialLabel.TabIndex = 12
        SerialLabel.Text = "Serial:"
        '
        'WarrantyPeriodLabel
        '
        WarrantyPeriodLabel.AutoSize = True
        WarrantyPeriodLabel.Location = New System.Drawing.Point(19, 161)
        WarrantyPeriodLabel.Name = "WarrantyPeriodLabel"
        WarrantyPeriodLabel.Size = New System.Drawing.Size(119, 18)
        WarrantyPeriodLabel.TabIndex = 14
        WarrantyPeriodLabel.Text = "Warranty Period:"
        '
        'ServiceCenterLabel
        '
        ServiceCenterLabel.AutoSize = True
        ServiceCenterLabel.Location = New System.Drawing.Point(29, 186)
        ServiceCenterLabel.Name = "ServiceCenterLabel"
        ServiceCenterLabel.Size = New System.Drawing.Size(109, 18)
        ServiceCenterLabel.TabIndex = 16
        ServiceCenterLabel.Text = "Service Center:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(68, 211)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(66, 18)
        AddressLabel.TabIndex = 18
        AddressLabel.Text = "Address:"
        '
        'ContactNoLabel
        '
        ContactNoLabel.AutoSize = True
        ContactNoLabel.Location = New System.Drawing.Point(307, 110)
        ContactNoLabel.Name = "ContactNoLabel"
        ContactNoLabel.Size = New System.Drawing.Size(88, 18)
        ContactNoLabel.TabIndex = 20
        ContactNoLabel.Text = "Contact No:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(342, 136)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(49, 18)
        EmailLabel.TabIndex = 22
        EmailLabel.Text = "Email:"
        '
        'DocumentDateLabel1
        '
        DocumentDateLabel1.AutoSize = True
        DocumentDateLabel1.ForeColor = System.Drawing.Color.Black
        DocumentDateLabel1.Location = New System.Drawing.Point(22, 29)
        DocumentDateLabel1.Name = "DocumentDateLabel1"
        DocumentDateLabel1.Size = New System.Drawing.Size(116, 18)
        DocumentDateLabel1.TabIndex = 0
        DocumentDateLabel1.Text = "Document Date:"
        AddHandler DocumentDateLabel1.Click, AddressOf Me.DocumentDateLabel1_Click
        '
        'VoucherNoLabel
        '
        VoucherNoLabel.AutoSize = True
        VoucherNoLabel.ForeColor = System.Drawing.Color.Black
        VoucherNoLabel.Location = New System.Drawing.Point(47, 108)
        VoucherNoLabel.Name = "VoucherNoLabel"
        VoucherNoLabel.Size = New System.Drawing.Size(91, 18)
        VoucherNoLabel.TabIndex = 2
        VoucherNoLabel.Text = "Voucher No:"
        '
        'PaymentFormLabel
        '
        PaymentFormLabel.AutoSize = True
        PaymentFormLabel.ForeColor = System.Drawing.Color.Black
        PaymentFormLabel.Location = New System.Drawing.Point(11, 135)
        PaymentFormLabel.Name = "PaymentFormLabel"
        PaymentFormLabel.Size = New System.Drawing.Size(127, 18)
        PaymentFormLabel.TabIndex = 4
        PaymentFormLabel.Text = "Form of Payment:"
        '
        'CheckNoLabel
        '
        CheckNoLabel.AutoSize = True
        CheckNoLabel.ForeColor = System.Drawing.Color.Black
        CheckNoLabel.Location = New System.Drawing.Point(41, 7)
        CheckNoLabel.Name = "CheckNoLabel"
        CheckNoLabel.Size = New System.Drawing.Size(79, 18)
        CheckNoLabel.TabIndex = 6
        CheckNoLabel.Text = "Check No:"
        '
        'TotalValueLabel2
        '
        TotalValueLabel2.AutoSize = True
        TotalValueLabel2.ForeColor = System.Drawing.Color.Black
        TotalValueLabel2.Location = New System.Drawing.Point(334, 108)
        TotalValueLabel2.Name = "TotalValueLabel2"
        TotalValueLabel2.Size = New System.Drawing.Size(63, 18)
        TotalValueLabel2.TabIndex = 8
        TotalValueLabel2.Text = "Amount:"
        '
        'PayeeLabel
        '
        PayeeLabel.AutoSize = True
        PayeeLabel.ForeColor = System.Drawing.Color.Black
        PayeeLabel.Location = New System.Drawing.Point(85, 59)
        PayeeLabel.Name = "PayeeLabel"
        PayeeLabel.Size = New System.Drawing.Size(53, 18)
        PayeeLabel.TabIndex = 10
        PayeeLabel.Text = "Payee:"
        '
        'PayorLabel
        '
        PayorLabel.AutoSize = True
        PayorLabel.ForeColor = System.Drawing.Color.Black
        PayorLabel.Location = New System.Drawing.Point(87, 84)
        PayorLabel.Name = "PayorLabel"
        PayorLabel.Size = New System.Drawing.Size(51, 18)
        PayorLabel.TabIndex = 12
        PayorLabel.Text = "Payor:"
        '
        'PreparedbyLabel
        '
        PreparedbyLabel.AutoSize = True
        PreparedbyLabel.ForeColor = System.Drawing.Color.Black
        PreparedbyLabel.Location = New System.Drawing.Point(347, 145)
        PreparedbyLabel.Name = "PreparedbyLabel"
        PreparedbyLabel.Size = New System.Drawing.Size(93, 18)
        PreparedbyLabel.TabIndex = 14
        PreparedbyLabel.Text = "Prepared By:"
        '
        'ApprovedbyLabel
        '
        ApprovedbyLabel.AutoSize = True
        ApprovedbyLabel.ForeColor = System.Drawing.Color.Black
        ApprovedbyLabel.Location = New System.Drawing.Point(344, 170)
        ApprovedbyLabel.Name = "ApprovedbyLabel"
        ApprovedbyLabel.Size = New System.Drawing.Size(95, 18)
        ApprovedbyLabel.TabIndex = 16
        ApprovedbyLabel.Text = "Approved By:"
        '
        'RecordedbyLabel
        '
        RecordedbyLabel.AutoSize = True
        RecordedbyLabel.ForeColor = System.Drawing.Color.Black
        RecordedbyLabel.Location = New System.Drawing.Point(341, 195)
        RecordedbyLabel.Name = "RecordedbyLabel"
        RecordedbyLabel.Size = New System.Drawing.Size(98, 18)
        RecordedbyLabel.TabIndex = 18
        RecordedbyLabel.Text = "Recorded By:"
        '
        'ReceivedbyLabel
        '
        ReceivedbyLabel.AutoSize = True
        ReceivedbyLabel.ForeColor = System.Drawing.Color.Black
        ReceivedbyLabel.Location = New System.Drawing.Point(345, 220)
        ReceivedbyLabel.Name = "ReceivedbyLabel"
        ReceivedbyLabel.Size = New System.Drawing.Size(94, 18)
        ReceivedbyLabel.TabIndex = 20
        ReceivedbyLabel.Text = "Received By:"
        '
        'DocumentDateLabel2
        '
        DocumentDateLabel2.AutoSize = True
        DocumentDateLabel2.ForeColor = System.Drawing.Color.Black
        DocumentDateLabel2.Location = New System.Drawing.Point(21, 28)
        DocumentDateLabel2.Name = "DocumentDateLabel2"
        DocumentDateLabel2.Size = New System.Drawing.Size(116, 18)
        DocumentDateLabel2.TabIndex = 0
        DocumentDateLabel2.Text = "Document Date:"
        '
        'CompanyLabel
        '
        CompanyLabel.AutoSize = True
        CompanyLabel.Location = New System.Drawing.Point(61, 92)
        CompanyLabel.Name = "CompanyLabel"
        CompanyLabel.Size = New System.Drawing.Size(76, 18)
        CompanyLabel.TabIndex = 2
        CompanyLabel.Text = "Company:"
        '
        'PurposeLabel
        '
        PurposeLabel.AutoSize = True
        PurposeLabel.Location = New System.Drawing.Point(69, 157)
        PurposeLabel.Name = "PurposeLabel"
        PurposeLabel.Size = New System.Drawing.Size(68, 18)
        PurposeLabel.TabIndex = 4
        PurposeLabel.Text = "Purpose:"
        '
        'SecretaryLabel
        '
        SecretaryLabel.AutoSize = True
        SecretaryLabel.Location = New System.Drawing.Point(62, 117)
        SecretaryLabel.Name = "SecretaryLabel"
        SecretaryLabel.Size = New System.Drawing.Size(75, 18)
        SecretaryLabel.TabIndex = 6
        SecretaryLabel.Text = "Secretary:"
        '
        'MeetingDateLabel
        '
        MeetingDateLabel.AutoSize = True
        MeetingDateLabel.Location = New System.Drawing.Point(38, 54)
        MeetingDateLabel.Name = "MeetingDateLabel"
        MeetingDateLabel.Size = New System.Drawing.Size(99, 18)
        MeetingDateLabel.TabIndex = 8
        MeetingDateLabel.Text = "Meeting Date:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(345, 72)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(55, 13)
        Label1.TabIndex = 25
        Label1.Text = "(VAT INC)"
        '
        'PaymentOthersLabel
        '
        PaymentOthersLabel.AutoSize = True
        PaymentOthersLabel.Location = New System.Drawing.Point(11, 7)
        PaymentOthersLabel.Name = "PaymentOthersLabel"
        PaymentOthersLabel.Size = New System.Drawing.Size(109, 18)
        PaymentOthersLabel.TabIndex = 0
        PaymentOthersLabel.Text = "Please Specify:"
        '
        'BankNameLabel
        '
        BankNameLabel.AutoSize = True
        BankNameLabel.Location = New System.Drawing.Point(26, 7)
        BankNameLabel.Name = "BankNameLabel"
        BankNameLabel.Size = New System.Drawing.Size(90, 18)
        BankNameLabel.TabIndex = 0
        BankNameLabel.Text = "Bank Name:"
        '
        'BankBranchLabel
        '
        BankBranchLabel.AutoSize = True
        BankBranchLabel.Location = New System.Drawing.Point(19, 31)
        BankBranchLabel.Name = "BankBranchLabel"
        BankBranchLabel.Size = New System.Drawing.Size(97, 18)
        BankBranchLabel.TabIndex = 2
        BankBranchLabel.Text = "Bank Branch:"
        '
        'BankAddressLabel
        '
        BankAddressLabel.AutoSize = True
        BankAddressLabel.Location = New System.Drawing.Point(12, 56)
        BankAddressLabel.Name = "BankAddressLabel"
        BankAddressLabel.Size = New System.Drawing.Size(104, 18)
        BankAddressLabel.TabIndex = 4
        BankAddressLabel.Text = "Bank Address:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnRefresh)
        Me.SplitContainer1.Size = New System.Drawing.Size(1197, 684)
        Me.SplitContainer1.SplitterDistance = 641
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.DocsCatalogueC1TrueDBGrid)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.IdTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.StatusStrip1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.BtnClear)
        Me.SplitContainer2.Panel2.Controls.Add(Me.BtnSave)
        Me.SplitContainer2.Panel2.Controls.Add(Me.BtnEdit)
        Me.SplitContainer2.Panel2.Controls.Add(Me.DocumentTypeComboBox)
        Me.SplitContainer2.Panel2.Controls.Add(DocumentTypeLabel)
        Me.SplitContainer2.Size = New System.Drawing.Size(641, 684)
        Me.SplitContainer2.SplitterDistance = 274
        Me.SplitContainer2.TabIndex = 0
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
        Me.DocsCatalogueC1TrueDBGrid.FlatStyle = C1.Win.C1TrueDBGrid.FlatModeEnum.Standard
        Me.DocsCatalogueC1TrueDBGrid.GroupByCaption = "Drag a column header here to group by that column"
        Me.DocsCatalogueC1TrueDBGrid.Images.Add(CType(resources.GetObject("DocsCatalogueC1TrueDBGrid.Images"), System.Drawing.Image))
        Me.DocsCatalogueC1TrueDBGrid.Location = New System.Drawing.Point(0, 0)
        Me.DocsCatalogueC1TrueDBGrid.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
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
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(610, 46)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(14, 20)
        Me.IdTextBox.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(421, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 27)
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
        Me.TabControl1.Location = New System.Drawing.Point(7, 77)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(631, 304)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 26
        Me.TabControl1.TabStop = False
        '
        'Timesheet
        '
        Me.Timesheet.Controls.Add(Me.GrpTimeSheet)
        Me.Timesheet.Location = New System.Drawing.Point(4, 25)
        Me.Timesheet.Name = "Timesheet"
        Me.Timesheet.Padding = New System.Windows.Forms.Padding(3)
        Me.Timesheet.Size = New System.Drawing.Size(623, 275)
        Me.Timesheet.TabIndex = 0
        Me.Timesheet.Text = "Timesheet"
        Me.Timesheet.UseVisualStyleBackColor = True
        '
        'GrpTimeSheet
        '
        Me.GrpTimeSheet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpTimeSheet.BackColor = System.Drawing.Color.Transparent
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
        Me.GrpTimeSheet.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpTimeSheet.ForeColor = System.Drawing.Color.Black
        Me.GrpTimeSheet.Location = New System.Drawing.Point(0, 3)
        Me.GrpTimeSheet.Name = "GrpTimeSheet"
        Me.GrpTimeSheet.Size = New System.Drawing.Size(617, 261)
        Me.GrpTimeSheet.TabIndex = 25
        Me.GrpTimeSheet.TabStop = False
        Me.GrpTimeSheet.Text = "Keywords"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(FromPeriodLabel)
        Me.GroupBox1.Controls.Add(Me.DTToPeriod)
        Me.GroupBox1.Controls.Add(Me.FromPeriodTextBox)
        Me.GroupBox1.Controls.Add(Me.DTFromPeriod)
        Me.GroupBox1.Controls.Add(Me.ToPeriodTextBox)
        Me.GroupBox1.Controls.Add(ToPeriodLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 84)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Coverage"
        '
        'DTToPeriod
        '
        Me.DTToPeriod.Location = New System.Drawing.Point(205, 47)
        Me.DTToPeriod.Name = "DTToPeriod"
        Me.DTToPeriod.Size = New System.Drawing.Size(18, 24)
        Me.DTToPeriod.TabIndex = 11
        '
        'FromPeriodTextBox
        '
        Me.FromPeriodTextBox.BackColor = System.Drawing.Color.White
        Me.FromPeriodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "FromPeriod", True))
        Me.FromPeriodTextBox.Location = New System.Drawing.Point(101, 21)
        Me.FromPeriodTextBox.Name = "FromPeriodTextBox"
        Me.FromPeriodTextBox.Size = New System.Drawing.Size(104, 24)
        Me.FromPeriodTextBox.TabIndex = 28
        Me.FromPeriodTextBox.TabStop = False
        Me.FromPeriodTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DTFromPeriod
        '
        Me.DTFromPeriod.Location = New System.Drawing.Point(206, 21)
        Me.DTFromPeriod.Name = "DTFromPeriod"
        Me.DTFromPeriod.Size = New System.Drawing.Size(18, 24)
        Me.DTFromPeriod.TabIndex = 10
        '
        'ToPeriodTextBox
        '
        Me.ToPeriodTextBox.BackColor = System.Drawing.Color.White
        Me.ToPeriodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ToPeriod", True))
        Me.ToPeriodTextBox.Location = New System.Drawing.Point(101, 47)
        Me.ToPeriodTextBox.Name = "ToPeriodTextBox"
        Me.ToPeriodTextBox.Size = New System.Drawing.Size(103, 24)
        Me.ToPeriodTextBox.TabIndex = 29
        Me.ToPeriodTextBox.TabStop = False
        Me.ToPeriodTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MiddleNameTextBox
        '
        Me.MiddleNameTextBox.BackColor = System.Drawing.Color.White
        Me.MiddleNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "MiddleName", True))
        Me.MiddleNameTextBox.Location = New System.Drawing.Point(140, 110)
        Me.MiddleNameTextBox.Name = "MiddleNameTextBox"
        Me.MiddleNameTextBox.Size = New System.Drawing.Size(229, 24)
        Me.MiddleNameTextBox.TabIndex = 9
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.BackColor = System.Drawing.Color.White
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(140, 84)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(229, 24)
        Me.FirstNameTextBox.TabIndex = 8
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.BackColor = System.Drawing.Color.White
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(140, 58)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(229, 24)
        Me.LastNameTextBox.TabIndex = 7
        '
        'DocumentDateTS
        '
        Me.DocumentDateTS.BackColor = System.Drawing.Color.White
        Me.DocumentDateTS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "DocumentDate", True))
        Me.DocumentDateTS.Location = New System.Drawing.Point(140, 26)
        Me.DocumentDateTS.Name = "DocumentDateTS"
        Me.DocumentDateTS.Size = New System.Drawing.Size(104, 24)
        Me.DocumentDateTS.TabIndex = 24
        Me.DocumentDateTS.TabStop = False
        Me.DocumentDateTS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DTDocuTimeSheet
        '
        Me.DTDocuTimeSheet.Location = New System.Drawing.Point(245, 26)
        Me.DTDocuTimeSheet.Name = "DTDocuTimeSheet"
        Me.DTDocuTimeSheet.Size = New System.Drawing.Size(18, 24)
        Me.DTDocuTimeSheet.TabIndex = 6
        '
        'ReceiptInvoice
        '
        Me.ReceiptInvoice.Controls.Add(Me.GrpReceipt)
        Me.ReceiptInvoice.Location = New System.Drawing.Point(4, 25)
        Me.ReceiptInvoice.Name = "ReceiptInvoice"
        Me.ReceiptInvoice.Padding = New System.Windows.Forms.Padding(3)
        Me.ReceiptInvoice.Size = New System.Drawing.Size(623, 275)
        Me.ReceiptInvoice.TabIndex = 1
        Me.ReceiptInvoice.Text = "Receipt/Invoice"
        Me.ReceiptInvoice.UseVisualStyleBackColor = True
        '
        'GrpReceipt
        '
        Me.GrpReceipt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.GrpReceipt.Controls.Add(RemarksLabel)
        Me.GrpReceipt.Controls.Add(Me.RemarksTextBox)
        Me.GrpReceipt.Controls.Add(ReferenceNoLabel)
        Me.GrpReceipt.Controls.Add(Me.ReferenceNoRI)
        Me.GrpReceipt.Controls.Add(DocumentDateLabel)
        Me.GrpReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpReceipt.ForeColor = System.Drawing.Color.Black
        Me.GrpReceipt.Location = New System.Drawing.Point(0, 3)
        Me.GrpReceipt.Name = "GrpReceipt"
        Me.GrpReceipt.Size = New System.Drawing.Size(617, 261)
        Me.GrpReceipt.TabIndex = 0
        Me.GrpReceipt.TabStop = False
        Me.GrpReceipt.Text = "Keywords"
        '
        'DocumentDateRI
        '
        Me.DocumentDateRI.BackColor = System.Drawing.Color.White
        Me.DocumentDateRI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "DocumentDate", True))
        Me.DocumentDateRI.Location = New System.Drawing.Point(140, 26)
        Me.DocumentDateRI.Name = "DocumentDateRI"
        Me.DocumentDateRI.Size = New System.Drawing.Size(104, 24)
        Me.DocumentDateRI.TabIndex = 24
        Me.DocumentDateRI.TabStop = False
        Me.DocumentDateRI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TotalValueRI
        '
        Me.TotalValueRI.BackColor = System.Drawing.Color.White
        Me.TotalValueRI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "TotalValue", True))
        Me.TotalValueRI.Location = New System.Drawing.Point(422, 51)
        Me.TotalValueRI.Name = "TotalValueRI"
        Me.TotalValueRI.Size = New System.Drawing.Size(177, 24)
        Me.TotalValueRI.TabIndex = 13
        '
        'ItemPurchasedTextBox
        '
        Me.ItemPurchasedTextBox.BackColor = System.Drawing.Color.White
        Me.ItemPurchasedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ItemPurchased", True))
        Me.ItemPurchasedTextBox.Location = New System.Drawing.Point(140, 151)
        Me.ItemPurchasedTextBox.Multiline = True
        Me.ItemPurchasedTextBox.Name = "ItemPurchasedTextBox"
        Me.ItemPurchasedTextBox.Size = New System.Drawing.Size(459, 47)
        Me.ItemPurchasedTextBox.TabIndex = 11
        '
        'CustomerTextBox
        '
        Me.CustomerTextBox.BackColor = System.Drawing.Color.White
        Me.CustomerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Customer", True))
        Me.CustomerTextBox.Location = New System.Drawing.Point(140, 126)
        Me.CustomerTextBox.Name = "CustomerTextBox"
        Me.CustomerTextBox.Size = New System.Drawing.Size(307, 24)
        Me.CustomerTextBox.TabIndex = 10
        '
        'VendorTextBox
        '
        Me.VendorTextBox.BackColor = System.Drawing.Color.White
        Me.VendorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Vendor", True))
        Me.VendorTextBox.Location = New System.Drawing.Point(140, 101)
        Me.VendorTextBox.Name = "VendorTextBox"
        Me.VendorTextBox.Size = New System.Drawing.Size(307, 24)
        Me.VendorTextBox.TabIndex = 9
        '
        'BookletNoTextBox
        '
        Me.BookletNoTextBox.BackColor = System.Drawing.Color.White
        Me.BookletNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BookletNo", True))
        Me.BookletNoTextBox.Location = New System.Drawing.Point(140, 51)
        Me.BookletNoTextBox.Name = "BookletNoTextBox"
        Me.BookletNoTextBox.Size = New System.Drawing.Size(123, 24)
        Me.BookletNoTextBox.TabIndex = 7
        '
        'DTDocuRI
        '
        Me.DTDocuRI.Location = New System.Drawing.Point(245, 26)
        Me.DTDocuRI.Name = "DTDocuRI"
        Me.DTDocuRI.Size = New System.Drawing.Size(18, 24)
        Me.DTDocuRI.TabIndex = 6
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.BackColor = System.Drawing.Color.White
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Remarks", True))
        Me.RemarksTextBox.Location = New System.Drawing.Point(140, 199)
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(459, 24)
        Me.RemarksTextBox.TabIndex = 12
        '
        'ReferenceNoRI
        '
        Me.ReferenceNoRI.BackColor = System.Drawing.Color.White
        Me.ReferenceNoRI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ReferenceNo", True))
        Me.ReferenceNoRI.Location = New System.Drawing.Point(140, 76)
        Me.ReferenceNoRI.Name = "ReferenceNoRI"
        Me.ReferenceNoRI.Size = New System.Drawing.Size(123, 24)
        Me.ReferenceNoRI.TabIndex = 8
        '
        'Warranty
        '
        Me.Warranty.AutoScroll = True
        Me.Warranty.Controls.Add(Me.GrpWarranty)
        Me.Warranty.Location = New System.Drawing.Point(4, 25)
        Me.Warranty.Name = "Warranty"
        Me.Warranty.Padding = New System.Windows.Forms.Padding(3)
        Me.Warranty.Size = New System.Drawing.Size(623, 275)
        Me.Warranty.TabIndex = 2
        Me.Warranty.Text = "Warranty"
        Me.Warranty.UseVisualStyleBackColor = True
        '
        'GrpWarranty
        '
        Me.GrpWarranty.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.GrpWarranty.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.GrpWarranty.ForeColor = System.Drawing.Color.Black
        Me.GrpWarranty.Location = New System.Drawing.Point(0, 3)
        Me.GrpWarranty.Name = "GrpWarranty"
        Me.GrpWarranty.Size = New System.Drawing.Size(617, 261)
        Me.GrpWarranty.TabIndex = 0
        Me.GrpWarranty.TabStop = False
        Me.GrpWarranty.Text = "Keywords"
        '
        'DTDatePurchased
        '
        Me.DTDatePurchased.Location = New System.Drawing.Point(592, 26)
        Me.DTDatePurchased.Name = "DTDatePurchased"
        Me.DTDatePurchased.Size = New System.Drawing.Size(18, 24)
        Me.DTDatePurchased.TabIndex = 14
        '
        'EmailTextBox
        '
        Me.EmailTextBox.BackColor = System.Drawing.Color.White
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(397, 133)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(202, 24)
        Me.EmailTextBox.TabIndex = 16
        '
        'ContactNoTextBox
        '
        Me.ContactNoTextBox.BackColor = System.Drawing.Color.White
        Me.ContactNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ContactNo", True))
        Me.ContactNoTextBox.Location = New System.Drawing.Point(397, 108)
        Me.ContactNoTextBox.Name = "ContactNoTextBox"
        Me.ContactNoTextBox.Size = New System.Drawing.Size(202, 24)
        Me.ContactNoTextBox.TabIndex = 15
        '
        'AddressTextBox
        '
        Me.AddressTextBox.BackColor = System.Drawing.Color.White
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(140, 208)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(459, 47)
        Me.AddressTextBox.TabIndex = 13
        '
        'ServiceCenterTextBox
        '
        Me.ServiceCenterTextBox.BackColor = System.Drawing.Color.White
        Me.ServiceCenterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ServiceCenter", True))
        Me.ServiceCenterTextBox.Location = New System.Drawing.Point(140, 183)
        Me.ServiceCenterTextBox.Name = "ServiceCenterTextBox"
        Me.ServiceCenterTextBox.Size = New System.Drawing.Size(459, 24)
        Me.ServiceCenterTextBox.TabIndex = 12
        '
        'WarrantyPeriodTextBox
        '
        Me.WarrantyPeriodTextBox.BackColor = System.Drawing.Color.White
        Me.WarrantyPeriodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "WarrantyPeriod", True))
        Me.WarrantyPeriodTextBox.Location = New System.Drawing.Point(140, 158)
        Me.WarrantyPeriodTextBox.Name = "WarrantyPeriodTextBox"
        Me.WarrantyPeriodTextBox.Size = New System.Drawing.Size(140, 24)
        Me.WarrantyPeriodTextBox.TabIndex = 11
        '
        'SerialTextBox
        '
        Me.SerialTextBox.BackColor = System.Drawing.Color.White
        Me.SerialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Serial", True))
        Me.SerialTextBox.Location = New System.Drawing.Point(140, 76)
        Me.SerialTextBox.Name = "SerialTextBox"
        Me.SerialTextBox.Size = New System.Drawing.Size(232, 24)
        Me.SerialTextBox.TabIndex = 8
        '
        'TotalValueWarranty
        '
        Me.TotalValueWarranty.BackColor = System.Drawing.Color.White
        Me.TotalValueWarranty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "TotalValue", True))
        Me.TotalValueWarranty.Location = New System.Drawing.Point(397, 158)
        Me.TotalValueWarranty.Name = "TotalValueWarranty"
        Me.TotalValueWarranty.Size = New System.Drawing.Size(202, 24)
        Me.TotalValueWarranty.TabIndex = 17
        '
        'ReferenceNoTextBox1
        '
        Me.ReferenceNoTextBox1.BackColor = System.Drawing.Color.White
        Me.ReferenceNoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ReferenceNo", True))
        Me.ReferenceNoTextBox1.Location = New System.Drawing.Point(140, 109)
        Me.ReferenceNoTextBox1.Name = "ReferenceNoTextBox1"
        Me.ReferenceNoTextBox1.Size = New System.Drawing.Size(140, 24)
        Me.ReferenceNoTextBox1.TabIndex = 9
        '
        'DatePurchasedTextBox
        '
        Me.DatePurchasedTextBox.BackColor = System.Drawing.Color.White
        Me.DatePurchasedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "DatePurchased", True))
        Me.DatePurchasedTextBox.Location = New System.Drawing.Point(497, 26)
        Me.DatePurchasedTextBox.Name = "DatePurchasedTextBox"
        Me.DatePurchasedTextBox.Size = New System.Drawing.Size(95, 24)
        Me.DatePurchasedTextBox.TabIndex = 7
        Me.DatePurchasedTextBox.TabStop = False
        Me.DatePurchasedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProductTypeTextBox
        '
        Me.ProductTypeTextBox.BackColor = System.Drawing.Color.White
        Me.ProductTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ProductType", True))
        Me.ProductTypeTextBox.Location = New System.Drawing.Point(140, 51)
        Me.ProductTypeTextBox.Name = "ProductTypeTextBox"
        Me.ProductTypeTextBox.Size = New System.Drawing.Size(232, 24)
        Me.ProductTypeTextBox.TabIndex = 7
        '
        'ProductBrandTextBox
        '
        Me.ProductBrandTextBox.BackColor = System.Drawing.Color.White
        Me.ProductBrandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ProductBrand", True))
        Me.ProductBrandTextBox.Location = New System.Drawing.Point(140, 26)
        Me.ProductBrandTextBox.Name = "ProductBrandTextBox"
        Me.ProductBrandTextBox.Size = New System.Drawing.Size(232, 24)
        Me.ProductBrandTextBox.TabIndex = 6
        '
        'WarrantyNoTextBox
        '
        Me.WarrantyNoTextBox.BackColor = System.Drawing.Color.White
        Me.WarrantyNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "WarrantyNo", True))
        Me.WarrantyNoTextBox.Location = New System.Drawing.Point(140, 133)
        Me.WarrantyNoTextBox.Name = "WarrantyNoTextBox"
        Me.WarrantyNoTextBox.Size = New System.Drawing.Size(140, 24)
        Me.WarrantyNoTextBox.TabIndex = 10
        '
        'Voucher
        '
        Me.Voucher.AutoScroll = True
        Me.Voucher.Controls.Add(Me.GrpVoucher)
        Me.Voucher.Location = New System.Drawing.Point(4, 25)
        Me.Voucher.Name = "Voucher"
        Me.Voucher.Size = New System.Drawing.Size(623, 275)
        Me.Voucher.TabIndex = 3
        Me.Voucher.Text = "Voucher"
        Me.Voucher.UseVisualStyleBackColor = True
        '
        'GrpVoucher
        '
        Me.GrpVoucher.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.GrpVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.GrpVoucher.ForeColor = System.Drawing.Color.Black
        Me.GrpVoucher.Location = New System.Drawing.Point(0, 3)
        Me.GrpVoucher.Name = "GrpVoucher"
        Me.GrpVoucher.Size = New System.Drawing.Size(623, 269)
        Me.GrpVoucher.TabIndex = 1
        Me.GrpVoucher.TabStop = False
        Me.GrpVoucher.Text = "Keywords"
        '
        'PaymentFormComboBox
        '
        Me.PaymentFormComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "PaymentForm", True))
        Me.PaymentFormComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PaymentFormComboBox.FormattingEnabled = True
        Me.PaymentFormComboBox.Location = New System.Drawing.Point(140, 130)
        Me.PaymentFormComboBox.Name = "PaymentFormComboBox"
        Me.PaymentFormComboBox.Size = New System.Drawing.Size(183, 26)
        Me.PaymentFormComboBox.TabIndex = 10
        '
        'DTDocuVoucher
        '
        Me.DTDocuVoucher.Location = New System.Drawing.Point(241, 26)
        Me.DTDocuVoucher.Name = "DTDocuVoucher"
        Me.DTDocuVoucher.Size = New System.Drawing.Size(18, 24)
        Me.DTDocuVoucher.TabIndex = 6
        '
        'ReceivedbyTextBox
        '
        Me.ReceivedbyTextBox.BackColor = System.Drawing.Color.White
        Me.ReceivedbyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Receivedby", True))
        Me.ReceivedbyTextBox.Location = New System.Drawing.Point(441, 217)
        Me.ReceivedbyTextBox.Name = "ReceivedbyTextBox"
        Me.ReceivedbyTextBox.Size = New System.Drawing.Size(141, 24)
        Me.ReceivedbyTextBox.TabIndex = 18
        '
        'RecordedbyTextBox
        '
        Me.RecordedbyTextBox.BackColor = System.Drawing.Color.White
        Me.RecordedbyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Recordedby", True))
        Me.RecordedbyTextBox.Location = New System.Drawing.Point(441, 192)
        Me.RecordedbyTextBox.Name = "RecordedbyTextBox"
        Me.RecordedbyTextBox.Size = New System.Drawing.Size(141, 24)
        Me.RecordedbyTextBox.TabIndex = 17
        '
        'ApprovedbyTextBox
        '
        Me.ApprovedbyTextBox.BackColor = System.Drawing.Color.White
        Me.ApprovedbyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Approvedby", True))
        Me.ApprovedbyTextBox.Location = New System.Drawing.Point(441, 167)
        Me.ApprovedbyTextBox.Name = "ApprovedbyTextBox"
        Me.ApprovedbyTextBox.Size = New System.Drawing.Size(141, 24)
        Me.ApprovedbyTextBox.TabIndex = 16
        '
        'PreparedbyTextBox
        '
        Me.PreparedbyTextBox.BackColor = System.Drawing.Color.White
        Me.PreparedbyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Preparedby", True))
        Me.PreparedbyTextBox.Location = New System.Drawing.Point(441, 142)
        Me.PreparedbyTextBox.Name = "PreparedbyTextBox"
        Me.PreparedbyTextBox.Size = New System.Drawing.Size(141, 24)
        Me.PreparedbyTextBox.TabIndex = 15
        '
        'PayorTextBox
        '
        Me.PayorTextBox.BackColor = System.Drawing.Color.White
        Me.PayorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Payor", True))
        Me.PayorTextBox.Location = New System.Drawing.Point(140, 81)
        Me.PayorTextBox.Name = "PayorTextBox"
        Me.PayorTextBox.Size = New System.Drawing.Size(442, 24)
        Me.PayorTextBox.TabIndex = 8
        '
        'PayeeTextBox
        '
        Me.PayeeTextBox.BackColor = System.Drawing.Color.White
        Me.PayeeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Payee", True))
        Me.PayeeTextBox.Location = New System.Drawing.Point(140, 56)
        Me.PayeeTextBox.Name = "PayeeTextBox"
        Me.PayeeTextBox.Size = New System.Drawing.Size(442, 24)
        Me.PayeeTextBox.TabIndex = 7
        '
        'TotalValueVoucher
        '
        Me.TotalValueVoucher.BackColor = System.Drawing.Color.White
        Me.TotalValueVoucher.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "TotalValue", True))
        Me.TotalValueVoucher.Location = New System.Drawing.Point(399, 105)
        Me.TotalValueVoucher.Name = "TotalValueVoucher"
        Me.TotalValueVoucher.Size = New System.Drawing.Size(183, 24)
        Me.TotalValueVoucher.TabIndex = 14
        '
        'VoucherNoTextBox
        '
        Me.VoucherNoTextBox.BackColor = System.Drawing.Color.White
        Me.VoucherNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "VoucherNo", True))
        Me.VoucherNoTextBox.Location = New System.Drawing.Point(140, 105)
        Me.VoucherNoTextBox.Name = "VoucherNoTextBox"
        Me.VoucherNoTextBox.Size = New System.Drawing.Size(183, 24)
        Me.VoucherNoTextBox.TabIndex = 9
        '
        'DocumentDateVoucher
        '
        Me.DocumentDateVoucher.BackColor = System.Drawing.Color.White
        Me.DocumentDateVoucher.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "DocumentDate", True))
        Me.DocumentDateVoucher.Location = New System.Drawing.Point(140, 26)
        Me.DocumentDateVoucher.Name = "DocumentDateVoucher"
        Me.DocumentDateVoucher.Size = New System.Drawing.Size(100, 24)
        Me.DocumentDateVoucher.TabIndex = 1
        Me.DocumentDateVoucher.TabStop = False
        Me.DocumentDateVoucher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabControl2
        '
        Me.TabControl2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl2.Controls.Add(Me.BankDepo)
        Me.TabControl2.Controls.Add(Me.Others)
        Me.TabControl2.Controls.Add(Me.Check)
        Me.TabControl2.Location = New System.Drawing.Point(14, 151)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(321, 131)
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
        Me.BankDepo.Location = New System.Drawing.Point(4, 30)
        Me.BankDepo.Name = "BankDepo"
        Me.BankDepo.Padding = New System.Windows.Forms.Padding(3)
        Me.BankDepo.Size = New System.Drawing.Size(313, 97)
        Me.BankDepo.TabIndex = 0
        Me.BankDepo.Text = "BankDepo"
        Me.BankDepo.UseVisualStyleBackColor = True
        '
        'BankAddressTextBox
        '
        Me.BankAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BankAddress", True))
        Me.BankAddressTextBox.Location = New System.Drawing.Point(122, 53)
        Me.BankAddressTextBox.Multiline = True
        Me.BankAddressTextBox.Name = "BankAddressTextBox"
        Me.BankAddressTextBox.Size = New System.Drawing.Size(183, 54)
        Me.BankAddressTextBox.TabIndex = 13
        '
        'BankBranchTextBox
        '
        Me.BankBranchTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BankBranch", True))
        Me.BankBranchTextBox.Location = New System.Drawing.Point(122, 28)
        Me.BankBranchTextBox.Name = "BankBranchTextBox"
        Me.BankBranchTextBox.Size = New System.Drawing.Size(183, 24)
        Me.BankBranchTextBox.TabIndex = 12
        '
        'BankNameTextBox
        '
        Me.BankNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BankName", True))
        Me.BankNameTextBox.Location = New System.Drawing.Point(122, 4)
        Me.BankNameTextBox.Name = "BankNameTextBox"
        Me.BankNameTextBox.Size = New System.Drawing.Size(183, 24)
        Me.BankNameTextBox.TabIndex = 11
        '
        'Others
        '
        Me.Others.AutoScroll = True
        Me.Others.BackColor = System.Drawing.SystemColors.Control
        Me.Others.Controls.Add(PaymentOthersLabel)
        Me.Others.Controls.Add(Me.PaymentOthersTextBox)
        Me.Others.Location = New System.Drawing.Point(4, 30)
        Me.Others.Name = "Others"
        Me.Others.Padding = New System.Windows.Forms.Padding(3)
        Me.Others.Size = New System.Drawing.Size(313, 97)
        Me.Others.TabIndex = 1
        Me.Others.Text = "Others"
        Me.Others.UseVisualStyleBackColor = True
        '
        'PaymentOthersTextBox
        '
        Me.PaymentOthersTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "PaymentOthers", True))
        Me.PaymentOthersTextBox.Location = New System.Drawing.Point(122, 4)
        Me.PaymentOthersTextBox.Name = "PaymentOthersTextBox"
        Me.PaymentOthersTextBox.Size = New System.Drawing.Size(183, 24)
        Me.PaymentOthersTextBox.TabIndex = 11
        '
        'Check
        '
        Me.Check.Controls.Add(Me.CheckNoTextBox)
        Me.Check.Controls.Add(CheckNoLabel)
        Me.Check.Location = New System.Drawing.Point(4, 30)
        Me.Check.Name = "Check"
        Me.Check.Size = New System.Drawing.Size(313, 97)
        Me.Check.TabIndex = 2
        Me.Check.Text = "Check"
        Me.Check.UseVisualStyleBackColor = True
        '
        'CheckNoTextBox
        '
        Me.CheckNoTextBox.BackColor = System.Drawing.Color.White
        Me.CheckNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "CheckNo", True))
        Me.CheckNoTextBox.Location = New System.Drawing.Point(122, 4)
        Me.CheckNoTextBox.Name = "CheckNoTextBox"
        Me.CheckNoTextBox.Size = New System.Drawing.Size(183, 24)
        Me.CheckNoTextBox.TabIndex = 11
        '
        'CorpDocu
        '
        Me.CorpDocu.Controls.Add(Me.GrpCorp)
        Me.CorpDocu.Location = New System.Drawing.Point(4, 25)
        Me.CorpDocu.Name = "CorpDocu"
        Me.CorpDocu.Size = New System.Drawing.Size(623, 275)
        Me.CorpDocu.TabIndex = 4
        Me.CorpDocu.Text = "CorpDocu"
        Me.CorpDocu.UseVisualStyleBackColor = True
        '
        'GrpCorp
        '
        Me.GrpCorp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.GrpCorp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.GrpCorp.ForeColor = System.Drawing.Color.Black
        Me.GrpCorp.Location = New System.Drawing.Point(0, 3)
        Me.GrpCorp.Name = "GrpCorp"
        Me.GrpCorp.Size = New System.Drawing.Size(617, 261)
        Me.GrpCorp.TabIndex = 1
        Me.GrpCorp.TabStop = False
        Me.GrpCorp.Text = "Keywords"
        '
        'DTMeetingDate
        '
        Me.DTMeetingDate.Location = New System.Drawing.Point(241, 51)
        Me.DTMeetingDate.Name = "DTMeetingDate"
        Me.DTMeetingDate.Size = New System.Drawing.Size(18, 24)
        Me.DTMeetingDate.TabIndex = 7
        '
        'DTDocuCorp
        '
        Me.DTDocuCorp.Location = New System.Drawing.Point(241, 26)
        Me.DTDocuCorp.Name = "DTDocuCorp"
        Me.DTDocuCorp.Size = New System.Drawing.Size(18, 24)
        Me.DTDocuCorp.TabIndex = 6
        '
        'MeetingDateTextBox
        '
        Me.MeetingDateTextBox.BackColor = System.Drawing.Color.White
        Me.MeetingDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "MeetingDate", True))
        Me.MeetingDateTextBox.Location = New System.Drawing.Point(140, 51)
        Me.MeetingDateTextBox.Name = "MeetingDateTextBox"
        Me.MeetingDateTextBox.Size = New System.Drawing.Size(100, 24)
        Me.MeetingDateTextBox.TabIndex = 9
        Me.MeetingDateTextBox.TabStop = False
        Me.MeetingDateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SecretaryTextBox
        '
        Me.SecretaryTextBox.BackColor = System.Drawing.Color.White
        Me.SecretaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Secretary", True))
        Me.SecretaryTextBox.Location = New System.Drawing.Point(140, 114)
        Me.SecretaryTextBox.Name = "SecretaryTextBox"
        Me.SecretaryTextBox.Size = New System.Drawing.Size(269, 24)
        Me.SecretaryTextBox.TabIndex = 9
        '
        'PurposeTextBox
        '
        Me.PurposeTextBox.BackColor = System.Drawing.Color.White
        Me.PurposeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Purpose", True))
        Me.PurposeTextBox.Location = New System.Drawing.Point(140, 154)
        Me.PurposeTextBox.Multiline = True
        Me.PurposeTextBox.Name = "PurposeTextBox"
        Me.PurposeTextBox.Size = New System.Drawing.Size(434, 101)
        Me.PurposeTextBox.TabIndex = 10
        '
        'CompanyTextBox
        '
        Me.CompanyTextBox.BackColor = System.Drawing.Color.White
        Me.CompanyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Company", True))
        Me.CompanyTextBox.Location = New System.Drawing.Point(140, 89)
        Me.CompanyTextBox.Name = "CompanyTextBox"
        Me.CompanyTextBox.Size = New System.Drawing.Size(434, 24)
        Me.CompanyTextBox.TabIndex = 8
        '
        'DocumentDateCorp
        '
        Me.DocumentDateCorp.BackColor = System.Drawing.Color.White
        Me.DocumentDateCorp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "DocumentDate", True))
        Me.DocumentDateCorp.Location = New System.Drawing.Point(140, 26)
        Me.DocumentDateCorp.Name = "DocumentDateCorp"
        Me.DocumentDateCorp.Size = New System.Drawing.Size(100, 24)
        Me.DocumentDateCorp.TabIndex = 1
        Me.DocumentDateCorp.TabStop = False
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
        Me.BtnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClear.Location = New System.Drawing.Point(528, 8)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(104, 27)
        Me.BtnClear.TabIndex = 4
        Me.BtnClear.Text = "Clear Keys"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(122, 8)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(104, 27)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(12, 8)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(104, 27)
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
        'BtnRefresh
        '
        Me.BtnRefresh.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRefresh.Enabled = True
        Me.BtnRefresh.Location = New System.Drawing.Point(2, 3)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.OcxState = CType(resources.GetObject("BtnRefresh.OcxState"), System.Windows.Forms.AxHost.State)
        Me.BtnRefresh.Size = New System.Drawing.Size(547, 678)
        Me.BtnRefresh.TabIndex = 0
        '
        'DocsCatalogueTableAdapter
        '
        Me.DocsCatalogueTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DocsCatalogueTableAdapter = Me.DocsCatalogueTableAdapter
        Me.TableAdapterManager.DocumentTypesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DMS.DMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DocMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 684)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DocMan"
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
        CType(Me.BtnRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents GrpReceipt As GroupBox
    Friend WithEvents DMSDataSet As DMSDataSet
    Friend WithEvents DocumentTypeComboBox As ComboBox
    Friend WithEvents DocsCatalogueC1TrueDBGrid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents BtnClear As Button
    Friend WithEvents RemarksTextBox As TextBox
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
    Friend WithEvents BtnRefresh As AxAcroPDFLib.AxAcroPDF
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
End Class
