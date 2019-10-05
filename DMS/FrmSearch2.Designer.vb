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
        Dim Label38 As System.Windows.Forms.Label
        Dim PolicyNoLabel As System.Windows.Forms.Label
        Dim InsuranceCompanyLabel As System.Windows.Forms.Label
        Dim RegNoLabel As System.Windows.Forms.Label
        Dim CustomsNoLabel As System.Windows.Forms.Label
        Dim BrokeCompanyLabel As System.Windows.Forms.Label
        Dim PaymentFormLabel1 As System.Windows.Forms.Label
        Dim LetterCreditLabel As System.Windows.Forms.Label
        Dim DPNoLabel As System.Windows.Forms.Label
        Dim PaymentOthersLabel1 As System.Windows.Forms.Label
        Dim BankBranchLabel1 As System.Windows.Forms.Label
        Dim BankNameLabel1 As System.Windows.Forms.Label
        Dim VesselArrivedLabel As System.Windows.Forms.Label
        Dim ContQtyx20Label As System.Windows.Forms.Label
        Dim ContQtyx40Label As System.Windows.Forms.Label
        Dim BillNoLabel As System.Windows.Forms.Label
        Dim ShipLineLabel As System.Windows.Forms.Label
        Dim CargoDescLabel As System.Windows.Forms.Label
        Dim ShipBatchLabel As System.Windows.Forms.Label
        Dim PRONoLabel As System.Windows.Forms.Label
        Dim ISRNoLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim CompanyLabel1 As System.Windows.Forms.Label
        Dim ImportMonthLabel As System.Windows.Forms.Label
        Dim Label39 As System.Windows.Forms.Label
        Dim Label40 As System.Windows.Forms.Label
        Dim AddressCLabel1 As System.Windows.Forms.Label
        Dim YearReportLabel As System.Windows.Forms.Label
        Dim TinVendorLabel1 As System.Windows.Forms.Label
        Dim TinCustomerLabel1 As System.Windows.Forms.Label
        Dim AddressLabel1 As System.Windows.Forms.Label
        Dim CompanyLabel2 As System.Windows.Forms.Label
        Dim Label41 As System.Windows.Forms.Label
        Dim Label42 As System.Windows.Forms.Label
        Dim Label43 As System.Windows.Forms.Label
        Dim Label44 As System.Windows.Forms.Label
        Dim SexLabel As System.Windows.Forms.Label
        Dim LastNameLabel1 As System.Windows.Forms.Label
        Dim MiddleNameLabel1 As System.Windows.Forms.Label
        Dim FirstNameLabel1 As System.Windows.Forms.Label
        Dim CompanyLabel3 As System.Windows.Forms.Label
        Dim Label45 As System.Windows.Forms.Label
        Dim Label46 As System.Windows.Forms.Label
        Dim Label47 As System.Windows.Forms.Label
        Dim Label48 As System.Windows.Forms.Label
        Dim Label49 As System.Windows.Forms.Label
        Dim PeriodProtectLabel As System.Windows.Forms.Label
        Dim CreationDateLabel As System.Windows.Forms.Label
        Dim ClassLabel As System.Windows.Forms.Label
        Dim AuthorLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim RegNoLabel1 As System.Windows.Forms.Label
        Dim Label51 As System.Windows.Forms.Label
        Dim Label52 As System.Windows.Forms.Label
        Dim Label50 As System.Windows.Forms.Label
        Dim Label53 As System.Windows.Forms.Label
        Dim Label54 As System.Windows.Forms.Label
        Dim Label55 As System.Windows.Forms.Label
        Dim RegMarkLabel As System.Windows.Forms.Label
        Dim RegistrantLabel As System.Windows.Forms.Label
        Dim FilingDateLabel As System.Windows.Forms.Label
        Dim ToPeriodLabel1 As System.Windows.Forms.Label
        Dim FromPeriodLabel1 As System.Windows.Forms.Label
        Dim TermLabel As System.Windows.Forms.Label
        Dim RegDateLabel As System.Windows.Forms.Label
        Dim RegNoLabel2 As System.Windows.Forms.Label
        Dim Label56 As System.Windows.Forms.Label
        Dim Label57 As System.Windows.Forms.Label
        Dim Label58 As System.Windows.Forms.Label
        Dim Label59 As System.Windows.Forms.Label
        Dim Label60 As System.Windows.Forms.Label
        Dim Label61 As System.Windows.Forms.Label
        Dim FilingDateLabel1 As System.Windows.Forms.Label
        Dim TitleLabel1 As System.Windows.Forms.Label
        Dim RegistrantLabel1 As System.Windows.Forms.Label
        Dim ToPeriodLabel2 As System.Windows.Forms.Label
        Dim FromPeriodLabel2 As System.Windows.Forms.Label
        Dim TermLabel1 As System.Windows.Forms.Label
        Dim RegDateLabel1 As System.Windows.Forms.Label
        Dim RegNoLabel3 As System.Windows.Forms.Label
        Dim Label62 As System.Windows.Forms.Label
        Dim Label63 As System.Windows.Forms.Label
        Dim Label69 As System.Windows.Forms.Label
        Dim Label64 As System.Windows.Forms.Label
        Dim Label65 As System.Windows.Forms.Label
        Dim ToPeriodLabel3 As System.Windows.Forms.Label
        Dim FromPeriodLabel3 As System.Windows.Forms.Label
        Dim TermLabel2 As System.Windows.Forms.Label
        Dim AccreditNoLabel As System.Windows.Forms.Label
        Dim IssueDateLabel As System.Windows.Forms.Label
        Dim TinCustomerLabel2 As System.Windows.Forms.Label
        Dim CompanyLabel4 As System.Windows.Forms.Label
        Dim Label66 As System.Windows.Forms.Label
        Dim Label67 As System.Windows.Forms.Label
        Dim Label73 As System.Windows.Forms.Label
        Dim Label72 As System.Windows.Forms.Label
        Dim Label71 As System.Windows.Forms.Label
        Dim ToPeriodLabel4 As System.Windows.Forms.Label
        Dim FromPeriodLabel4 As System.Windows.Forms.Label
        Dim TermLabel3 As System.Windows.Forms.Label
        Dim AccreditNoLabel1 As System.Windows.Forms.Label
        Dim IssueDateLabel1 As System.Windows.Forms.Label
        Dim CompanyLabel5 As System.Windows.Forms.Label
        Dim Label68 As System.Windows.Forms.Label
        Dim Label70 As System.Windows.Forms.Label
        Dim Label75 As System.Windows.Forms.Label
        Dim Label74 As System.Windows.Forms.Label
        Dim Label76 As System.Windows.Forms.Label
        Dim ToPeriodLabel5 As System.Windows.Forms.Label
        Dim FromPeriodLabel5 As System.Windows.Forms.Label
        Dim TermLabel4 As System.Windows.Forms.Label
        Dim SubsDateLabel As System.Windows.Forms.Label
        Dim GLNLabel As System.Windows.Forms.Label
        Dim CompanyPrefixLabel As System.Windows.Forms.Label
        Dim CompanyLabel6 As System.Windows.Forms.Label
        Dim Label77 As System.Windows.Forms.Label
        Dim Label78 As System.Windows.Forms.Label
        Dim Label82 As System.Windows.Forms.Label
        Dim Label81 As System.Windows.Forms.Label
        Dim Label80 As System.Windows.Forms.Label
        Dim Label79 As System.Windows.Forms.Label
        Dim Label83 As System.Windows.Forms.Label
        Dim Label84 As System.Windows.Forms.Label
        Dim Label85 As System.Windows.Forms.Label
        Dim P2PositionLabel As System.Windows.Forms.Label
        Dim P2LastNameLabel As System.Windows.Forms.Label
        Dim P2MiddleNameLabel As System.Windows.Forms.Label
        Dim P2FirstNameLabel As System.Windows.Forms.Label
        Dim P2CompanyLabel As System.Windows.Forms.Label
        Dim P1PositionLabel As System.Windows.Forms.Label
        Dim P1LastNameLabel As System.Windows.Forms.Label
        Dim P1MiddleNameLabel As System.Windows.Forms.Label
        Dim P1FirstNameLabel As System.Windows.Forms.Label
        Dim P1CompanyLabel As System.Windows.Forms.Label
        Dim ContractPlaceLabel As System.Windows.Forms.Label
        Dim SignDateLabel As System.Windows.Forms.Label
        Dim ToPeriodLabel6 As System.Windows.Forms.Label
        Dim FromPeriodLabel6 As System.Windows.Forms.Label
        Dim PurposeLabel1 As System.Windows.Forms.Label
        Dim ContractTypeLabel As System.Windows.Forms.Label
        Dim Label86 As System.Windows.Forms.Label
        Dim Label87 As System.Windows.Forms.Label
        Dim Label89 As System.Windows.Forms.Label
        Dim Label88 As System.Windows.Forms.Label
        Dim Label90 As System.Windows.Forms.Label
        Dim Label91 As System.Windows.Forms.Label
        Dim Label92 As System.Windows.Forms.Label
        Dim Label93 As System.Windows.Forms.Label
        Dim Label94 As System.Windows.Forms.Label
        Dim ToPeriodLabel7 As System.Windows.Forms.Label
        Dim FromPeriodLabel7 As System.Windows.Forms.Label
        Dim P2LastNameLabel1 As System.Windows.Forms.Label
        Dim P2MiddleNameLabel1 As System.Windows.Forms.Label
        Dim P2FirstNameLabel1 As System.Windows.Forms.Label
        Dim P2CompanyLabel1 As System.Windows.Forms.Label
        Dim P1LastNameLabel1 As System.Windows.Forms.Label
        Dim P1MiddleNameLabel1 As System.Windows.Forms.Label
        Dim P1FirstNameLabel1 As System.Windows.Forms.Label
        Dim P1CompanyLabel1 As System.Windows.Forms.Label
        Dim IssuePlaceLabel As System.Windows.Forms.Label
        Dim IssueDateLabel2 As System.Windows.Forms.Label
        Dim Label95 As System.Windows.Forms.Label
        Dim Label96 As System.Windows.Forms.Label
        Dim Label97 As System.Windows.Forms.Label
        Dim Label98 As System.Windows.Forms.Label
        Dim Label99 As System.Windows.Forms.Label
        Dim LastNameLabel2 As System.Windows.Forms.Label
        Dim MiddleNameLabel2 As System.Windows.Forms.Label
        Dim FirstNameLabel2 As System.Windows.Forms.Label
        Dim CompanyLabel7 As System.Windows.Forms.Label
        Dim IssuePlaceLabel1 As System.Windows.Forms.Label
        Dim IssueDateLabel3 As System.Windows.Forms.Label
        Dim Label100 As System.Windows.Forms.Label
        Dim Label101 As System.Windows.Forms.Label
        Dim Label102 As System.Windows.Forms.Label
        Dim Label103 As System.Windows.Forms.Label
        Dim Label104 As System.Windows.Forms.Label
        Dim Label105 As System.Windows.Forms.Label
        Dim P2LastNameLabel2 As System.Windows.Forms.Label
        Dim P2MiddleNameLabel2 As System.Windows.Forms.Label
        Dim P2FirstNameLabel2 As System.Windows.Forms.Label
        Dim P2CompanyLabel2 As System.Windows.Forms.Label
        Dim P1LastNameLabel2 As System.Windows.Forms.Label
        Dim P1MiddleNameLabel2 As System.Windows.Forms.Label
        Dim P1FirstNameLabel2 As System.Windows.Forms.Label
        Dim P1CompanyLabel2 As System.Windows.Forms.Label
        Dim IssueDateLabel4 As System.Windows.Forms.Label
        Dim MemoSubjLabel As System.Windows.Forms.Label
        Dim MemoTypeLabel As System.Windows.Forms.Label
        Dim CompanyLabel8 As System.Windows.Forms.Label
        Dim Label106 As System.Windows.Forms.Label
        Dim Label107 As System.Windows.Forms.Label
        Dim Label108 As System.Windows.Forms.Label
        Dim Label109 As System.Windows.Forms.Label
        Dim Label110 As System.Windows.Forms.Label
        Dim Label111 As System.Windows.Forms.Label
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
        Me.C1TrueDBGrid2 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.BtnRemoval = New System.Windows.Forms.Button()
        Me.BtnDownload = New System.Windows.Forms.Button()
        Me.BtnSaveChanges1 = New System.Windows.Forms.Button()
        Me.BtnEditRecord = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabQuery = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtWild = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.TabChanges = New System.Windows.Forms.TabPage()
        Me.txtPages = New System.Windows.Forms.TextBox()
        Me.DocsCatalogueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DMSDataSet = New DMS.DMSDataSet()
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
        Me.Importation = New System.Windows.Forms.TabPage()
        Me.GrpImportation = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DTVesselImport = New System.Windows.Forms.DateTimePicker()
        Me.PolicyNoImport = New System.Windows.Forms.TextBox()
        Me.InsuranceCompanyImport = New System.Windows.Forms.TextBox()
        Me.RegNoImport = New System.Windows.Forms.TextBox()
        Me.CustomsNoImport = New System.Windows.Forms.TextBox()
        Me.BrokeCompanyImport = New System.Windows.Forms.TextBox()
        Me.PaymentFormImport = New System.Windows.Forms.ComboBox()
        Me.TabControl5 = New System.Windows.Forms.TabControl()
        Me.LCNo = New System.Windows.Forms.TabPage()
        Me.LetterCreditImport = New System.Windows.Forms.TextBox()
        Me.DPNo = New System.Windows.Forms.TabPage()
        Me.DPNoImport = New System.Windows.Forms.TextBox()
        Me.OthersImport = New System.Windows.Forms.TabPage()
        Me.PaymentOthersImport = New System.Windows.Forms.TextBox()
        Me.BankBranchImport = New System.Windows.Forms.TextBox()
        Me.BankNameImport = New System.Windows.Forms.TextBox()
        Me.VesselArrivedImport = New System.Windows.Forms.TextBox()
        Me.ContQtyx20Import = New System.Windows.Forms.TextBox()
        Me.ContQtyx40Import = New System.Windows.Forms.TextBox()
        Me.BillNoImport = New System.Windows.Forms.TextBox()
        Me.ShipLineImport = New System.Windows.Forms.TextBox()
        Me.CargoDescImport = New System.Windows.Forms.TextBox()
        Me.ShipBatchImport = New System.Windows.Forms.ComboBox()
        Me.PRONoImport = New System.Windows.Forms.TextBox()
        Me.ISRNoImport = New System.Windows.Forms.TextBox()
        Me.CountryImport = New System.Windows.Forms.TextBox()
        Me.CompanyImport = New System.Windows.Forms.TextBox()
        Me.ImpMonthImport = New System.Windows.Forms.TextBox()
        Me.BoxNoImport = New System.Windows.Forms.TextBox()
        Me.RackNoImport = New System.Windows.Forms.TextBox()
        Me.BIR = New System.Windows.Forms.TabPage()
        Me.GrpBIR = New System.Windows.Forms.GroupBox()
        Me.AddressCBIR = New System.Windows.Forms.TextBox()
        Me.YearReportBIR = New System.Windows.Forms.TextBox()
        Me.TinVendorBIR = New System.Windows.Forms.TextBox()
        Me.TinCustomerBIR = New System.Windows.Forms.TextBox()
        Me.AddressBIR = New System.Windows.Forms.TextBox()
        Me.CompanyBIR = New System.Windows.Forms.TextBox()
        Me.BoxNoBIR = New System.Windows.Forms.TextBox()
        Me.RackNoBIR = New System.Windows.Forms.TextBox()
        Me.DTDocuBIR = New System.Windows.Forms.DateTimePicker()
        Me.DocumentDateBIR = New System.Windows.Forms.TextBox()
        Me.HRDoc = New System.Windows.Forms.TabPage()
        Me.GrpHRDoc = New System.Windows.Forms.GroupBox()
        Me.SexHRDoc = New System.Windows.Forms.TextBox()
        Me.LastNameHRDoc = New System.Windows.Forms.TextBox()
        Me.MiddleNameHRDoc = New System.Windows.Forms.TextBox()
        Me.FirstNameHRDoc = New System.Windows.Forms.TextBox()
        Me.CompanyHRDoc = New System.Windows.Forms.TextBox()
        Me.BoxNoHRDoc = New System.Windows.Forms.TextBox()
        Me.RackNoHRDoc = New System.Windows.Forms.TextBox()
        Me.DTDocuHRDoc = New System.Windows.Forms.DateTimePicker()
        Me.DocumentDateHRDoc = New System.Windows.Forms.TextBox()
        Me.Copyright = New System.Windows.Forms.TabPage()
        Me.GrpCopy = New System.Windows.Forms.GroupBox()
        Me.DTCreateDate = New System.Windows.Forms.DateTimePicker()
        Me.PeriodProtectCopy = New System.Windows.Forms.TextBox()
        Me.CreationDateCopy = New System.Windows.Forms.TextBox()
        Me.ClassCopy = New System.Windows.Forms.TextBox()
        Me.AuthorCopy = New System.Windows.Forms.TextBox()
        Me.TitleCopy = New System.Windows.Forms.TextBox()
        Me.RegNoCopy = New System.Windows.Forms.TextBox()
        Me.BoxNoCopy = New System.Windows.Forms.TextBox()
        Me.RackNoCopy = New System.Windows.Forms.TextBox()
        Me.Trademark = New System.Windows.Forms.TabPage()
        Me.GrpTrade = New System.Windows.Forms.GroupBox()
        Me.DTFilingTrade = New System.Windows.Forms.DateTimePicker()
        Me.DTToTrade = New System.Windows.Forms.DateTimePicker()
        Me.DTFromTrade = New System.Windows.Forms.DateTimePicker()
        Me.DTRegDateTrade = New System.Windows.Forms.DateTimePicker()
        Me.RegMarkTrade = New System.Windows.Forms.TextBox()
        Me.RegistrantTrade = New System.Windows.Forms.TextBox()
        Me.FilingDateTrade = New System.Windows.Forms.TextBox()
        Me.ToPeriodTrade = New System.Windows.Forms.TextBox()
        Me.FromPeriodTrade = New System.Windows.Forms.TextBox()
        Me.TermTrade = New System.Windows.Forms.TextBox()
        Me.RegDateTrade = New System.Windows.Forms.TextBox()
        Me.RegNoTrade = New System.Windows.Forms.TextBox()
        Me.BoxNoTrade = New System.Windows.Forms.TextBox()
        Me.RackNoTrade = New System.Windows.Forms.TextBox()
        Me.Patent = New System.Windows.Forms.TabPage()
        Me.GrpPatent = New System.Windows.Forms.GroupBox()
        Me.DTFilingPatent = New System.Windows.Forms.DateTimePicker()
        Me.DTToPatent = New System.Windows.Forms.DateTimePicker()
        Me.DTFromPatent = New System.Windows.Forms.DateTimePicker()
        Me.DTRegDatePatent = New System.Windows.Forms.DateTimePicker()
        Me.FilingDatePatent = New System.Windows.Forms.TextBox()
        Me.TitlePatent = New System.Windows.Forms.TextBox()
        Me.RegistrantPatent = New System.Windows.Forms.TextBox()
        Me.ToPeriodPatent = New System.Windows.Forms.TextBox()
        Me.FromPeriodPatent = New System.Windows.Forms.TextBox()
        Me.TermPatent = New System.Windows.Forms.TextBox()
        Me.RegDatePatent = New System.Windows.Forms.TextBox()
        Me.RegNoPatent = New System.Windows.Forms.TextBox()
        Me.BoxNoPatent = New System.Windows.Forms.TextBox()
        Me.RackNoPatent = New System.Windows.Forms.TextBox()
        Me.BIRClear = New System.Windows.Forms.TabPage()
        Me.GrpClear = New System.Windows.Forms.GroupBox()
        Me.DTToClear = New System.Windows.Forms.DateTimePicker()
        Me.DTFromClear = New System.Windows.Forms.DateTimePicker()
        Me.DTIssueDateClear = New System.Windows.Forms.DateTimePicker()
        Me.ToPeriodClear = New System.Windows.Forms.TextBox()
        Me.FromPeriodClear = New System.Windows.Forms.TextBox()
        Me.TermClear = New System.Windows.Forms.TextBox()
        Me.AccreditNoClear = New System.Windows.Forms.TextBox()
        Me.IssueDateClear = New System.Windows.Forms.TextBox()
        Me.TinCustomerClear = New System.Windows.Forms.TextBox()
        Me.CompanyClear = New System.Windows.Forms.TextBox()
        Me.BoxNoClear = New System.Windows.Forms.TextBox()
        Me.RackNoClear = New System.Windows.Forms.TextBox()
        Me.Accredit = New System.Windows.Forms.TabPage()
        Me.GrpAccre = New System.Windows.Forms.GroupBox()
        Me.DTToAccre = New System.Windows.Forms.DateTimePicker()
        Me.DTFromAccre = New System.Windows.Forms.DateTimePicker()
        Me.DTIssueDateAccre = New System.Windows.Forms.DateTimePicker()
        Me.ToPeriodAccre = New System.Windows.Forms.TextBox()
        Me.FromPeriodAccre = New System.Windows.Forms.TextBox()
        Me.TermAccre = New System.Windows.Forms.TextBox()
        Me.AccreditNoAccre = New System.Windows.Forms.TextBox()
        Me.IssueDateAccre = New System.Windows.Forms.TextBox()
        Me.CompanyAccre = New System.Windows.Forms.TextBox()
        Me.BoxNoAccre = New System.Windows.Forms.TextBox()
        Me.RackNoAccre = New System.Windows.Forms.TextBox()
        Me.Subs = New System.Windows.Forms.TabPage()
        Me.GrpSubs = New System.Windows.Forms.GroupBox()
        Me.DTToSubs = New System.Windows.Forms.DateTimePicker()
        Me.DTFromSubs = New System.Windows.Forms.DateTimePicker()
        Me.DTSubsDateSubs = New System.Windows.Forms.DateTimePicker()
        Me.ToPeriodSubs = New System.Windows.Forms.TextBox()
        Me.FromPeriodSubs = New System.Windows.Forms.TextBox()
        Me.TermSubs = New System.Windows.Forms.TextBox()
        Me.SubsDateSubs = New System.Windows.Forms.TextBox()
        Me.GLNSubs = New System.Windows.Forms.TextBox()
        Me.CompanyPrefixSubs = New System.Windows.Forms.TextBox()
        Me.CompanySubs = New System.Windows.Forms.TextBox()
        Me.BoxNoSubs = New System.Windows.Forms.TextBox()
        Me.RackNoSubs = New System.Windows.Forms.TextBox()
        Me.Contract = New System.Windows.Forms.TabPage()
        Me.GrpContract = New System.Windows.Forms.GroupBox()
        Me.DTDateSignContract = New System.Windows.Forms.DateTimePicker()
        Me.DTToContract = New System.Windows.Forms.DateTimePicker()
        Me.DTFromContract = New System.Windows.Forms.DateTimePicker()
        Me.P2PositionContract = New System.Windows.Forms.TextBox()
        Me.P2LastNameContract = New System.Windows.Forms.TextBox()
        Me.P2MiddleNameContract = New System.Windows.Forms.TextBox()
        Me.P2FirstNameContract = New System.Windows.Forms.TextBox()
        Me.P2CompanyContract = New System.Windows.Forms.TextBox()
        Me.P1PositionContract = New System.Windows.Forms.TextBox()
        Me.P1LastNameContract = New System.Windows.Forms.TextBox()
        Me.P1MiddleNameContract = New System.Windows.Forms.TextBox()
        Me.P1FirstNameContract = New System.Windows.Forms.TextBox()
        Me.P1CompanyContract = New System.Windows.Forms.TextBox()
        Me.ContractPlaceContract = New System.Windows.Forms.TextBox()
        Me.SignDateContract = New System.Windows.Forms.TextBox()
        Me.ToPeriodContract = New System.Windows.Forms.TextBox()
        Me.FromPeriodContract = New System.Windows.Forms.TextBox()
        Me.PurposeContract = New System.Windows.Forms.TextBox()
        Me.ContractTypeContract = New System.Windows.Forms.TextBox()
        Me.BoxNoContract = New System.Windows.Forms.TextBox()
        Me.RackNoContract = New System.Windows.Forms.TextBox()
        Me.Attorney = New System.Windows.Forms.TabPage()
        Me.GrpAttorney = New System.Windows.Forms.GroupBox()
        Me.DTToAttorney = New System.Windows.Forms.DateTimePicker()
        Me.DTFromAttorney = New System.Windows.Forms.DateTimePicker()
        Me.DTIssuePlaceAttorney = New System.Windows.Forms.DateTimePicker()
        Me.DTIssueDateAttorney = New System.Windows.Forms.DateTimePicker()
        Me.ToPeriodAttorney = New System.Windows.Forms.TextBox()
        Me.FromPeriodAttorney = New System.Windows.Forms.TextBox()
        Me.P2LastNameAttorney = New System.Windows.Forms.TextBox()
        Me.P2MiddleNameAttorney = New System.Windows.Forms.TextBox()
        Me.P2FirstNameAttorney = New System.Windows.Forms.TextBox()
        Me.P2CompanyAttorney = New System.Windows.Forms.TextBox()
        Me.P1LastNameAttorney = New System.Windows.Forms.TextBox()
        Me.P1MiddleNameAttorney = New System.Windows.Forms.TextBox()
        Me.P1FirstNameAttorney = New System.Windows.Forms.TextBox()
        Me.P1CompanyAttorney = New System.Windows.Forms.TextBox()
        Me.IssuePlaceAttorney = New System.Windows.Forms.TextBox()
        Me.IssueDateAttorney = New System.Windows.Forms.TextBox()
        Me.BoxNoAttorney = New System.Windows.Forms.TextBox()
        Me.RackNoAttorney = New System.Windows.Forms.TextBox()
        Me.PurposeAttorney = New System.Windows.Forms.TextBox()
        Me.OtherDoc = New System.Windows.Forms.TabPage()
        Me.GrpOther = New System.Windows.Forms.GroupBox()
        Me.DTIssuePlaceOther = New System.Windows.Forms.DateTimePicker()
        Me.DTIssueDateOther = New System.Windows.Forms.DateTimePicker()
        Me.LastNameOther = New System.Windows.Forms.TextBox()
        Me.MiddleNameOther = New System.Windows.Forms.TextBox()
        Me.FirstNameOther = New System.Windows.Forms.TextBox()
        Me.CompanyOther = New System.Windows.Forms.TextBox()
        Me.IssuePlaceOther = New System.Windows.Forms.TextBox()
        Me.IssueDateOther = New System.Windows.Forms.TextBox()
        Me.BoxNoOther = New System.Windows.Forms.TextBox()
        Me.RackNoOther = New System.Windows.Forms.TextBox()
        Me.PurposeOther = New System.Windows.Forms.TextBox()
        Me.Memo = New System.Windows.Forms.TabPage()
        Me.GrpMemo = New System.Windows.Forms.GroupBox()
        Me.DTIssueDateMemo = New System.Windows.Forms.DateTimePicker()
        Me.P2LastNameMemo = New System.Windows.Forms.TextBox()
        Me.P2MiddleNameMemo = New System.Windows.Forms.TextBox()
        Me.P2FirstNameMemo = New System.Windows.Forms.TextBox()
        Me.P2CompanyMemo = New System.Windows.Forms.TextBox()
        Me.P1LastNameMemo = New System.Windows.Forms.TextBox()
        Me.P1MiddleNameMemo = New System.Windows.Forms.TextBox()
        Me.P1FirstNameMemo = New System.Windows.Forms.TextBox()
        Me.P1CompanyMemo = New System.Windows.Forms.TextBox()
        Me.IssueDateMemo = New System.Windows.Forms.TextBox()
        Me.MemoSubjMemo = New System.Windows.Forms.TextBox()
        Me.MemoTypeMemo = New System.Windows.Forms.TextBox()
        Me.CompanyMemo = New System.Windows.Forms.TextBox()
        Me.BoxNoMemo = New System.Windows.Forms.TextBox()
        Me.RackNoMemo = New System.Windows.Forms.TextBox()
        Me.PurposeMemo = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CHKFileName = New System.Windows.Forms.CheckBox()
        Me.sdasd = New System.Windows.Forms.Label()
        Me.TxtFileName = New System.Windows.Forms.TextBox()
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTDocDateTo = New System.Windows.Forms.DateTimePicker()
        Me.DTDocDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.DocumentTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.DocumentTypeLabel = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TableAdapterManager = New DMS.DMSDataSetTableAdapters.TableAdapterManager()
        Me.DocsCatalogueTableAdapter = New DMS.DMSDataSetTableAdapters.DocsCatalogueTableAdapter()
        IdLabel = New System.Windows.Forms.Label()
        DocSizeLabel = New System.Windows.Forms.Label()
        SubBatchLabel = New System.Windows.Forms.Label()
        BatchLabel = New System.Windows.Forms.Label()
        PagesLabel = New System.Windows.Forms.Label()
        Label38 = New System.Windows.Forms.Label()
        PolicyNoLabel = New System.Windows.Forms.Label()
        InsuranceCompanyLabel = New System.Windows.Forms.Label()
        RegNoLabel = New System.Windows.Forms.Label()
        CustomsNoLabel = New System.Windows.Forms.Label()
        BrokeCompanyLabel = New System.Windows.Forms.Label()
        PaymentFormLabel1 = New System.Windows.Forms.Label()
        LetterCreditLabel = New System.Windows.Forms.Label()
        DPNoLabel = New System.Windows.Forms.Label()
        PaymentOthersLabel1 = New System.Windows.Forms.Label()
        BankBranchLabel1 = New System.Windows.Forms.Label()
        BankNameLabel1 = New System.Windows.Forms.Label()
        VesselArrivedLabel = New System.Windows.Forms.Label()
        ContQtyx20Label = New System.Windows.Forms.Label()
        ContQtyx40Label = New System.Windows.Forms.Label()
        BillNoLabel = New System.Windows.Forms.Label()
        ShipLineLabel = New System.Windows.Forms.Label()
        CargoDescLabel = New System.Windows.Forms.Label()
        ShipBatchLabel = New System.Windows.Forms.Label()
        PRONoLabel = New System.Windows.Forms.Label()
        ISRNoLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        CompanyLabel1 = New System.Windows.Forms.Label()
        ImportMonthLabel = New System.Windows.Forms.Label()
        Label39 = New System.Windows.Forms.Label()
        Label40 = New System.Windows.Forms.Label()
        AddressCLabel1 = New System.Windows.Forms.Label()
        YearReportLabel = New System.Windows.Forms.Label()
        TinVendorLabel1 = New System.Windows.Forms.Label()
        TinCustomerLabel1 = New System.Windows.Forms.Label()
        AddressLabel1 = New System.Windows.Forms.Label()
        CompanyLabel2 = New System.Windows.Forms.Label()
        Label41 = New System.Windows.Forms.Label()
        Label42 = New System.Windows.Forms.Label()
        Label43 = New System.Windows.Forms.Label()
        Label44 = New System.Windows.Forms.Label()
        SexLabel = New System.Windows.Forms.Label()
        LastNameLabel1 = New System.Windows.Forms.Label()
        MiddleNameLabel1 = New System.Windows.Forms.Label()
        FirstNameLabel1 = New System.Windows.Forms.Label()
        CompanyLabel3 = New System.Windows.Forms.Label()
        Label45 = New System.Windows.Forms.Label()
        Label46 = New System.Windows.Forms.Label()
        Label47 = New System.Windows.Forms.Label()
        Label48 = New System.Windows.Forms.Label()
        Label49 = New System.Windows.Forms.Label()
        PeriodProtectLabel = New System.Windows.Forms.Label()
        CreationDateLabel = New System.Windows.Forms.Label()
        ClassLabel = New System.Windows.Forms.Label()
        AuthorLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        RegNoLabel1 = New System.Windows.Forms.Label()
        Label51 = New System.Windows.Forms.Label()
        Label52 = New System.Windows.Forms.Label()
        Label50 = New System.Windows.Forms.Label()
        Label53 = New System.Windows.Forms.Label()
        Label54 = New System.Windows.Forms.Label()
        Label55 = New System.Windows.Forms.Label()
        RegMarkLabel = New System.Windows.Forms.Label()
        RegistrantLabel = New System.Windows.Forms.Label()
        FilingDateLabel = New System.Windows.Forms.Label()
        ToPeriodLabel1 = New System.Windows.Forms.Label()
        FromPeriodLabel1 = New System.Windows.Forms.Label()
        TermLabel = New System.Windows.Forms.Label()
        RegDateLabel = New System.Windows.Forms.Label()
        RegNoLabel2 = New System.Windows.Forms.Label()
        Label56 = New System.Windows.Forms.Label()
        Label57 = New System.Windows.Forms.Label()
        Label58 = New System.Windows.Forms.Label()
        Label59 = New System.Windows.Forms.Label()
        Label60 = New System.Windows.Forms.Label()
        Label61 = New System.Windows.Forms.Label()
        FilingDateLabel1 = New System.Windows.Forms.Label()
        TitleLabel1 = New System.Windows.Forms.Label()
        RegistrantLabel1 = New System.Windows.Forms.Label()
        ToPeriodLabel2 = New System.Windows.Forms.Label()
        FromPeriodLabel2 = New System.Windows.Forms.Label()
        TermLabel1 = New System.Windows.Forms.Label()
        RegDateLabel1 = New System.Windows.Forms.Label()
        RegNoLabel3 = New System.Windows.Forms.Label()
        Label62 = New System.Windows.Forms.Label()
        Label63 = New System.Windows.Forms.Label()
        Label69 = New System.Windows.Forms.Label()
        Label64 = New System.Windows.Forms.Label()
        Label65 = New System.Windows.Forms.Label()
        ToPeriodLabel3 = New System.Windows.Forms.Label()
        FromPeriodLabel3 = New System.Windows.Forms.Label()
        TermLabel2 = New System.Windows.Forms.Label()
        AccreditNoLabel = New System.Windows.Forms.Label()
        IssueDateLabel = New System.Windows.Forms.Label()
        TinCustomerLabel2 = New System.Windows.Forms.Label()
        CompanyLabel4 = New System.Windows.Forms.Label()
        Label66 = New System.Windows.Forms.Label()
        Label67 = New System.Windows.Forms.Label()
        Label73 = New System.Windows.Forms.Label()
        Label72 = New System.Windows.Forms.Label()
        Label71 = New System.Windows.Forms.Label()
        ToPeriodLabel4 = New System.Windows.Forms.Label()
        FromPeriodLabel4 = New System.Windows.Forms.Label()
        TermLabel3 = New System.Windows.Forms.Label()
        AccreditNoLabel1 = New System.Windows.Forms.Label()
        IssueDateLabel1 = New System.Windows.Forms.Label()
        CompanyLabel5 = New System.Windows.Forms.Label()
        Label68 = New System.Windows.Forms.Label()
        Label70 = New System.Windows.Forms.Label()
        Label75 = New System.Windows.Forms.Label()
        Label74 = New System.Windows.Forms.Label()
        Label76 = New System.Windows.Forms.Label()
        ToPeriodLabel5 = New System.Windows.Forms.Label()
        FromPeriodLabel5 = New System.Windows.Forms.Label()
        TermLabel4 = New System.Windows.Forms.Label()
        SubsDateLabel = New System.Windows.Forms.Label()
        GLNLabel = New System.Windows.Forms.Label()
        CompanyPrefixLabel = New System.Windows.Forms.Label()
        CompanyLabel6 = New System.Windows.Forms.Label()
        Label77 = New System.Windows.Forms.Label()
        Label78 = New System.Windows.Forms.Label()
        Label82 = New System.Windows.Forms.Label()
        Label81 = New System.Windows.Forms.Label()
        Label80 = New System.Windows.Forms.Label()
        Label79 = New System.Windows.Forms.Label()
        Label83 = New System.Windows.Forms.Label()
        Label84 = New System.Windows.Forms.Label()
        Label85 = New System.Windows.Forms.Label()
        P2PositionLabel = New System.Windows.Forms.Label()
        P2LastNameLabel = New System.Windows.Forms.Label()
        P2MiddleNameLabel = New System.Windows.Forms.Label()
        P2FirstNameLabel = New System.Windows.Forms.Label()
        P2CompanyLabel = New System.Windows.Forms.Label()
        P1PositionLabel = New System.Windows.Forms.Label()
        P1LastNameLabel = New System.Windows.Forms.Label()
        P1MiddleNameLabel = New System.Windows.Forms.Label()
        P1FirstNameLabel = New System.Windows.Forms.Label()
        P1CompanyLabel = New System.Windows.Forms.Label()
        ContractPlaceLabel = New System.Windows.Forms.Label()
        SignDateLabel = New System.Windows.Forms.Label()
        ToPeriodLabel6 = New System.Windows.Forms.Label()
        FromPeriodLabel6 = New System.Windows.Forms.Label()
        PurposeLabel1 = New System.Windows.Forms.Label()
        ContractTypeLabel = New System.Windows.Forms.Label()
        Label86 = New System.Windows.Forms.Label()
        Label87 = New System.Windows.Forms.Label()
        Label89 = New System.Windows.Forms.Label()
        Label88 = New System.Windows.Forms.Label()
        Label90 = New System.Windows.Forms.Label()
        Label91 = New System.Windows.Forms.Label()
        Label92 = New System.Windows.Forms.Label()
        Label93 = New System.Windows.Forms.Label()
        Label94 = New System.Windows.Forms.Label()
        ToPeriodLabel7 = New System.Windows.Forms.Label()
        FromPeriodLabel7 = New System.Windows.Forms.Label()
        P2LastNameLabel1 = New System.Windows.Forms.Label()
        P2MiddleNameLabel1 = New System.Windows.Forms.Label()
        P2FirstNameLabel1 = New System.Windows.Forms.Label()
        P2CompanyLabel1 = New System.Windows.Forms.Label()
        P1LastNameLabel1 = New System.Windows.Forms.Label()
        P1MiddleNameLabel1 = New System.Windows.Forms.Label()
        P1FirstNameLabel1 = New System.Windows.Forms.Label()
        P1CompanyLabel1 = New System.Windows.Forms.Label()
        IssuePlaceLabel = New System.Windows.Forms.Label()
        IssueDateLabel2 = New System.Windows.Forms.Label()
        Label95 = New System.Windows.Forms.Label()
        Label96 = New System.Windows.Forms.Label()
        Label97 = New System.Windows.Forms.Label()
        Label98 = New System.Windows.Forms.Label()
        Label99 = New System.Windows.Forms.Label()
        LastNameLabel2 = New System.Windows.Forms.Label()
        MiddleNameLabel2 = New System.Windows.Forms.Label()
        FirstNameLabel2 = New System.Windows.Forms.Label()
        CompanyLabel7 = New System.Windows.Forms.Label()
        IssuePlaceLabel1 = New System.Windows.Forms.Label()
        IssueDateLabel3 = New System.Windows.Forms.Label()
        Label100 = New System.Windows.Forms.Label()
        Label101 = New System.Windows.Forms.Label()
        Label102 = New System.Windows.Forms.Label()
        Label103 = New System.Windows.Forms.Label()
        Label104 = New System.Windows.Forms.Label()
        Label105 = New System.Windows.Forms.Label()
        P2LastNameLabel2 = New System.Windows.Forms.Label()
        P2MiddleNameLabel2 = New System.Windows.Forms.Label()
        P2FirstNameLabel2 = New System.Windows.Forms.Label()
        P2CompanyLabel2 = New System.Windows.Forms.Label()
        P1LastNameLabel2 = New System.Windows.Forms.Label()
        P1MiddleNameLabel2 = New System.Windows.Forms.Label()
        P1FirstNameLabel2 = New System.Windows.Forms.Label()
        P1CompanyLabel2 = New System.Windows.Forms.Label()
        IssueDateLabel4 = New System.Windows.Forms.Label()
        MemoSubjLabel = New System.Windows.Forms.Label()
        MemoTypeLabel = New System.Windows.Forms.Label()
        CompanyLabel8 = New System.Windows.Forms.Label()
        Label106 = New System.Windows.Forms.Label()
        Label107 = New System.Windows.Forms.Label()
        Label108 = New System.Windows.Forms.Label()
        Label109 = New System.Windows.Forms.Label()
        Label110 = New System.Windows.Forms.Label()
        Label111 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.C1TrueDBGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabQuery.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabChanges.SuspendLayout()
        CType(Me.DocsCatalogueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Importation.SuspendLayout()
        Me.GrpImportation.SuspendLayout()
        Me.TabControl5.SuspendLayout()
        Me.LCNo.SuspendLayout()
        Me.DPNo.SuspendLayout()
        Me.OthersImport.SuspendLayout()
        Me.BIR.SuspendLayout()
        Me.GrpBIR.SuspendLayout()
        Me.HRDoc.SuspendLayout()
        Me.GrpHRDoc.SuspendLayout()
        Me.Copyright.SuspendLayout()
        Me.GrpCopy.SuspendLayout()
        Me.Trademark.SuspendLayout()
        Me.GrpTrade.SuspendLayout()
        Me.Patent.SuspendLayout()
        Me.GrpPatent.SuspendLayout()
        Me.BIRClear.SuspendLayout()
        Me.GrpClear.SuspendLayout()
        Me.Accredit.SuspendLayout()
        Me.GrpAccre.SuspendLayout()
        Me.Subs.SuspendLayout()
        Me.GrpSubs.SuspendLayout()
        Me.Contract.SuspendLayout()
        Me.GrpContract.SuspendLayout()
        Me.Attorney.SuspendLayout()
        Me.GrpAttorney.SuspendLayout()
        Me.OtherDoc.SuspendLayout()
        Me.GrpOther.SuspendLayout()
        Me.Memo.SuspendLayout()
        Me.GrpMemo.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        'Label38
        '
        Label38.AutoSize = True
        Label38.Location = New System.Drawing.Point(293, 329)
        Label38.Name = "Label38"
        Label38.Size = New System.Drawing.Size(82, 16)
        Label38.TabIndex = 56
        Label38.Text = "mm/dd/yyyy"
        '
        'PolicyNoLabel
        '
        PolicyNoLabel.AutoSize = True
        PolicyNoLabel.Location = New System.Drawing.Point(8, 564)
        PolicyNoLabel.Name = "PolicyNoLabel"
        PolicyNoLabel.Size = New System.Drawing.Size(72, 16)
        PolicyNoLabel.TabIndex = 53
        PolicyNoLabel.Text = "Policy No.:"
        '
        'InsuranceCompanyLabel
        '
        InsuranceCompanyLabel.AutoSize = True
        InsuranceCompanyLabel.Location = New System.Drawing.Point(7, 540)
        InsuranceCompanyLabel.Name = "InsuranceCompanyLabel"
        InsuranceCompanyLabel.Size = New System.Drawing.Size(130, 16)
        InsuranceCompanyLabel.TabIndex = 52
        InsuranceCompanyLabel.Text = "Insurance Company:"
        '
        'RegNoLabel
        '
        RegNoLabel.AutoSize = True
        RegNoLabel.Location = New System.Drawing.Point(8, 517)
        RegNoLabel.Name = "RegNoLabel"
        RegNoLabel.Size = New System.Drawing.Size(85, 16)
        RegNoLabel.TabIndex = 51
        RegNoLabel.Text = "Registry No.:"
        '
        'CustomsNoLabel
        '
        CustomsNoLabel.AutoSize = True
        CustomsNoLabel.Location = New System.Drawing.Point(8, 493)
        CustomsNoLabel.Name = "CustomsNoLabel"
        CustomsNoLabel.Size = New System.Drawing.Size(153, 16)
        CustomsNoLabel.TabIndex = 50
        CustomsNoLabel.Text = "Customs Reference No.:"
        '
        'BrokeCompanyLabel
        '
        BrokeCompanyLabel.AutoSize = True
        BrokeCompanyLabel.Location = New System.Drawing.Point(8, 471)
        BrokeCompanyLabel.Name = "BrokeCompanyLabel"
        BrokeCompanyLabel.Size = New System.Drawing.Size(136, 16)
        BrokeCompanyLabel.TabIndex = 49
        BrokeCompanyLabel.Text = "Brokerage Company:"
        '
        'PaymentFormLabel1
        '
        PaymentFormLabel1.AutoSize = True
        PaymentFormLabel1.Location = New System.Drawing.Point(8, 400)
        PaymentFormLabel1.Name = "PaymentFormLabel1"
        PaymentFormLabel1.Size = New System.Drawing.Size(112, 16)
        PaymentFormLabel1.TabIndex = 48
        PaymentFormLabel1.Text = "Payment Method:"
        '
        'LetterCreditLabel
        '
        LetterCreditLabel.AutoSize = True
        LetterCreditLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        LetterCreditLabel.Location = New System.Drawing.Point(-2, 3)
        LetterCreditLabel.Name = "LetterCreditLabel"
        LetterCreditLabel.Size = New System.Drawing.Size(82, 16)
        LetterCreditLabel.TabIndex = 0
        LetterCreditLabel.Text = "Letter Credit:"
        '
        'DPNoLabel
        '
        DPNoLabel.AutoSize = True
        DPNoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        DPNoLabel.Location = New System.Drawing.Point(-2, 4)
        DPNoLabel.Name = "DPNoLabel"
        DPNoLabel.Size = New System.Drawing.Size(48, 16)
        DPNoLabel.TabIndex = 50
        DPNoLabel.Text = "DPNo:"
        '
        'PaymentOthersLabel1
        '
        PaymentOthersLabel1.AutoSize = True
        PaymentOthersLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        PaymentOthersLabel1.Location = New System.Drawing.Point(-2, 5)
        PaymentOthersLabel1.Name = "PaymentOthersLabel1"
        PaymentOthersLabel1.Size = New System.Drawing.Size(50, 16)
        PaymentOthersLabel1.TabIndex = 0
        PaymentOthersLabel1.Text = "Others:"
        '
        'BankBranchLabel1
        '
        BankBranchLabel1.AutoSize = True
        BankBranchLabel1.Location = New System.Drawing.Point(8, 376)
        BankBranchLabel1.Name = "BankBranchLabel1"
        BankBranchLabel1.Size = New System.Drawing.Size(87, 16)
        BankBranchLabel1.TabIndex = 46
        BankBranchLabel1.Text = "Bank Branch:"
        '
        'BankNameLabel1
        '
        BankNameLabel1.AutoSize = True
        BankNameLabel1.Location = New System.Drawing.Point(8, 353)
        BankNameLabel1.Name = "BankNameLabel1"
        BankNameLabel1.Size = New System.Drawing.Size(82, 16)
        BankNameLabel1.TabIndex = 45
        BankNameLabel1.Text = "Bank Name:"
        '
        'VesselArrivedLabel
        '
        VesselArrivedLabel.AutoSize = True
        VesselArrivedLabel.Location = New System.Drawing.Point(8, 330)
        VesselArrivedLabel.Name = "VesselArrivedLabel"
        VesselArrivedLabel.Size = New System.Drawing.Size(131, 16)
        VesselArrivedLabel.TabIndex = 44
        VesselArrivedLabel.Text = "Date Vessel Arrived:"
        '
        'ContQtyx20Label
        '
        ContQtyx20Label.AutoSize = True
        ContQtyx20Label.Location = New System.Drawing.Point(8, 307)
        ContQtyx20Label.Name = "ContQtyx20Label"
        ContQtyx20Label.Size = New System.Drawing.Size(140, 16)
        ContQtyx20Label.TabIndex = 43
        ContQtyx20Label.Text = "Qty of Containers(x20):"
        '
        'ContQtyx40Label
        '
        ContQtyx40Label.AutoSize = True
        ContQtyx40Label.Location = New System.Drawing.Point(8, 284)
        ContQtyx40Label.Name = "ContQtyx40Label"
        ContQtyx40Label.Size = New System.Drawing.Size(140, 16)
        ContQtyx40Label.TabIndex = 42
        ContQtyx40Label.Text = "Qty of Containers(x40):"
        '
        'BillNoLabel
        '
        BillNoLabel.AutoSize = True
        BillNoLabel.Location = New System.Drawing.Point(8, 261)
        BillNoLabel.Name = "BillNoLabel"
        BillNoLabel.Size = New System.Drawing.Size(203, 16)
        BillNoLabel.TabIndex = 41
        BillNoLabel.Text = "Bill of Lading No./ Airway Bill No.:"
        '
        'ShipLineLabel
        '
        ShipLineLabel.AutoSize = True
        ShipLineLabel.Location = New System.Drawing.Point(8, 238)
        ShipLineLabel.Name = "ShipLineLabel"
        ShipLineLabel.Size = New System.Drawing.Size(92, 16)
        ShipLineLabel.TabIndex = 40
        ShipLineLabel.Text = "Shipping Line:"
        '
        'CargoDescLabel
        '
        CargoDescLabel.AutoSize = True
        CargoDescLabel.Location = New System.Drawing.Point(8, 215)
        CargoDescLabel.Name = "CargoDescLabel"
        CargoDescLabel.Size = New System.Drawing.Size(119, 16)
        CargoDescLabel.TabIndex = 39
        CargoDescLabel.Text = "Cargo Description:"
        '
        'ShipBatchLabel
        '
        ShipBatchLabel.AutoSize = True
        ShipBatchLabel.Location = New System.Drawing.Point(8, 190)
        ShipBatchLabel.Name = "ShipBatchLabel"
        ShipBatchLabel.Size = New System.Drawing.Size(104, 16)
        ShipBatchLabel.TabIndex = 38
        ShipBatchLabel.Text = "Shipment Batch:"
        '
        'PRONoLabel
        '
        PRONoLabel.AutoSize = True
        PRONoLabel.Location = New System.Drawing.Point(8, 167)
        PRONoLabel.Name = "PRONoLabel"
        PRONoLabel.Size = New System.Drawing.Size(104, 16)
        PRONoLabel.TabIndex = 37
        PRONoLabel.Text = "PRO No./ IS No."
        '
        'ISRNoLabel
        '
        ISRNoLabel.AutoSize = True
        ISRNoLabel.Location = New System.Drawing.Point(8, 144)
        ISRNoLabel.Name = "ISRNoLabel"
        ISRNoLabel.Size = New System.Drawing.Size(85, 16)
        ISRNoLabel.TabIndex = 36
        ISRNoLabel.Text = "AHP ISR No."
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CountryLabel.Location = New System.Drawing.Point(8, 121)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(108, 16)
        CountryLabel.TabIndex = 35
        CountryLabel.Text = "Country of Origin:"
        '
        'CompanyLabel1
        '
        CompanyLabel1.AutoSize = True
        CompanyLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CompanyLabel1.Location = New System.Drawing.Point(8, 98)
        CompanyLabel1.Name = "CompanyLabel1"
        CompanyLabel1.Size = New System.Drawing.Size(158, 15)
        CompanyLabel1.TabIndex = 34
        CompanyLabel1.Text = "Supplier's Complete Name:"
        '
        'ImportMonthLabel
        '
        ImportMonthLabel.AutoSize = True
        ImportMonthLabel.Location = New System.Drawing.Point(8, 75)
        ImportMonthLabel.Name = "ImportMonthLabel"
        ImportMonthLabel.Size = New System.Drawing.Size(116, 16)
        ImportMonthLabel.TabIndex = 33
        ImportMonthLabel.Text = "Importation Month:"
        '
        'Label39
        '
        Label39.AutoSize = True
        Label39.Location = New System.Drawing.Point(8, 53)
        Label39.Name = "Label39"
        Label39.Size = New System.Drawing.Size(122, 16)
        Label39.TabIndex = 33
        Label39.Text = "Document Box No.:"
        '
        'Label40
        '
        Label40.AutoSize = True
        Label40.Location = New System.Drawing.Point(8, 30)
        Label40.Name = "Label40"
        Label40.Size = New System.Drawing.Size(131, 16)
        Label40.TabIndex = 32
        Label40.Text = "Document Rack No.:"
        '
        'AddressCLabel1
        '
        AddressCLabel1.AutoSize = True
        AddressCLabel1.Location = New System.Drawing.Point(8, 130)
        AddressCLabel1.Name = "AddressCLabel1"
        AddressCLabel1.Size = New System.Drawing.Size(133, 16)
        AddressCLabel1.TabIndex = 41
        AddressCLabel1.Text = "Company's Address:"
        '
        'YearReportLabel
        '
        YearReportLabel.AutoSize = True
        YearReportLabel.Location = New System.Drawing.Point(8, 242)
        YearReportLabel.Name = "YearReportLabel"
        YearReportLabel.Size = New System.Drawing.Size(98, 16)
        YearReportLabel.TabIndex = 40
        YearReportLabel.Text = "Year of Report:"
        '
        'TinVendorLabel1
        '
        TinVendorLabel1.AutoSize = True
        TinVendorLabel1.Location = New System.Drawing.Point(8, 214)
        TinVendorLabel1.Name = "TinVendorLabel1"
        TinVendorLabel1.Size = New System.Drawing.Size(90, 16)
        TinVendorLabel1.TabIndex = 39
        TinVendorLabel1.Text = "Vendor's TIN:"
        '
        'TinCustomerLabel1
        '
        TinCustomerLabel1.AutoSize = True
        TinCustomerLabel1.Location = New System.Drawing.Point(8, 153)
        TinCustomerLabel1.Name = "TinCustomerLabel1"
        TinCustomerLabel1.Size = New System.Drawing.Size(104, 16)
        TinCustomerLabel1.TabIndex = 38
        TinCustomerLabel1.Text = "Company's TIN:"
        '
        'AddressLabel1
        '
        AddressLabel1.AutoSize = True
        AddressLabel1.Location = New System.Drawing.Point(8, 191)
        AddressLabel1.Name = "AddressLabel1"
        AddressLabel1.Size = New System.Drawing.Size(119, 16)
        AddressLabel1.TabIndex = 37
        AddressLabel1.Text = "Vendor's Address:"
        '
        'CompanyLabel2
        '
        CompanyLabel2.AutoSize = True
        CompanyLabel2.Location = New System.Drawing.Point(8, 107)
        CompanyLabel2.Name = "CompanyLabel2"
        CompanyLabel2.Size = New System.Drawing.Size(109, 16)
        CompanyLabel2.TabIndex = 36
        CompanyLabel2.Text = "Company Name:"
        '
        'Label41
        '
        Label41.AutoSize = True
        Label41.Location = New System.Drawing.Point(281, 75)
        Label41.Name = "Label41"
        Label41.Size = New System.Drawing.Size(82, 16)
        Label41.TabIndex = 36
        Label41.Text = "mm/dd/yyyy"
        '
        'Label42
        '
        Label42.AutoSize = True
        Label42.Location = New System.Drawing.Point(8, 53)
        Label42.Name = "Label42"
        Label42.Size = New System.Drawing.Size(122, 16)
        Label42.TabIndex = 33
        Label42.Text = "Document Box No.:"
        '
        'Label43
        '
        Label43.AutoSize = True
        Label43.Location = New System.Drawing.Point(8, 30)
        Label43.Name = "Label43"
        Label43.Size = New System.Drawing.Size(131, 16)
        Label43.TabIndex = 32
        Label43.Text = "Document Rack No.:"
        '
        'Label44
        '
        Label44.AutoSize = True
        Label44.ForeColor = System.Drawing.Color.Black
        Label44.Location = New System.Drawing.Point(8, 76)
        Label44.Name = "Label44"
        Label44.Size = New System.Drawing.Size(104, 16)
        Label44.TabIndex = 0
        Label44.Text = "Document Date:"
        '
        'SexLabel
        '
        SexLabel.AutoSize = True
        SexLabel.Location = New System.Drawing.Point(8, 207)
        SexLabel.Name = "SexLabel"
        SexLabel.Size = New System.Drawing.Size(34, 16)
        SexLabel.TabIndex = 40
        SexLabel.Text = "Sex:"
        '
        'LastNameLabel1
        '
        LastNameLabel1.AutoSize = True
        LastNameLabel1.Location = New System.Drawing.Point(8, 184)
        LastNameLabel1.Name = "LastNameLabel1"
        LastNameLabel1.Size = New System.Drawing.Size(76, 16)
        LastNameLabel1.TabIndex = 39
        LastNameLabel1.Text = "Last Name:"
        '
        'MiddleNameLabel1
        '
        MiddleNameLabel1.AutoSize = True
        MiddleNameLabel1.Location = New System.Drawing.Point(8, 161)
        MiddleNameLabel1.Name = "MiddleNameLabel1"
        MiddleNameLabel1.Size = New System.Drawing.Size(92, 16)
        MiddleNameLabel1.TabIndex = 38
        MiddleNameLabel1.Text = "Middle Name:"
        '
        'FirstNameLabel1
        '
        FirstNameLabel1.AutoSize = True
        FirstNameLabel1.Location = New System.Drawing.Point(8, 138)
        FirstNameLabel1.Name = "FirstNameLabel1"
        FirstNameLabel1.Size = New System.Drawing.Size(76, 16)
        FirstNameLabel1.TabIndex = 37
        FirstNameLabel1.Text = "First Name:"
        '
        'CompanyLabel3
        '
        CompanyLabel3.AutoSize = True
        CompanyLabel3.Location = New System.Drawing.Point(8, 114)
        CompanyLabel3.Name = "CompanyLabel3"
        CompanyLabel3.Size = New System.Drawing.Size(69, 16)
        CompanyLabel3.TabIndex = 36
        CompanyLabel3.Text = "Company:"
        '
        'Label45
        '
        Label45.AutoSize = True
        Label45.Location = New System.Drawing.Point(281, 75)
        Label45.Name = "Label45"
        Label45.Size = New System.Drawing.Size(82, 16)
        Label45.TabIndex = 36
        Label45.Text = "mm/dd/yyyy"
        '
        'Label46
        '
        Label46.AutoSize = True
        Label46.Location = New System.Drawing.Point(8, 53)
        Label46.Name = "Label46"
        Label46.Size = New System.Drawing.Size(122, 16)
        Label46.TabIndex = 33
        Label46.Text = "Document Box No.:"
        '
        'Label47
        '
        Label47.AutoSize = True
        Label47.Location = New System.Drawing.Point(8, 30)
        Label47.Name = "Label47"
        Label47.Size = New System.Drawing.Size(131, 16)
        Label47.TabIndex = 32
        Label47.Text = "Document Rack No.:"
        '
        'Label48
        '
        Label48.AutoSize = True
        Label48.ForeColor = System.Drawing.Color.Black
        Label48.Location = New System.Drawing.Point(8, 76)
        Label48.Name = "Label48"
        Label48.Size = New System.Drawing.Size(104, 16)
        Label48.TabIndex = 0
        Label48.Text = "Document Date:"
        '
        'Label49
        '
        Label49.AutoSize = True
        Label49.Location = New System.Drawing.Point(279, 175)
        Label49.Name = "Label49"
        Label49.Size = New System.Drawing.Size(82, 16)
        Label49.TabIndex = 41
        Label49.Text = "mm/dd/yyyy"
        '
        'PeriodProtectLabel
        '
        PeriodProtectLabel.AutoSize = True
        PeriodProtectLabel.Location = New System.Drawing.Point(8, 199)
        PeriodProtectLabel.Name = "PeriodProtectLabel"
        PeriodProtectLabel.Size = New System.Drawing.Size(128, 16)
        PeriodProtectLabel.TabIndex = 38
        PeriodProtectLabel.Text = "Period of Protection:"
        '
        'CreationDateLabel
        '
        CreationDateLabel.AutoSize = True
        CreationDateLabel.Location = New System.Drawing.Point(8, 176)
        CreationDateLabel.Name = "CreationDateLabel"
        CreationDateLabel.Size = New System.Drawing.Size(93, 16)
        CreationDateLabel.TabIndex = 37
        CreationDateLabel.Text = "Creation Date:"
        '
        'ClassLabel
        '
        ClassLabel.AutoSize = True
        ClassLabel.Location = New System.Drawing.Point(8, 152)
        ClassLabel.Name = "ClassLabel"
        ClassLabel.Size = New System.Drawing.Size(45, 16)
        ClassLabel.TabIndex = 36
        ClassLabel.Text = "Class:"
        '
        'AuthorLabel
        '
        AuthorLabel.AutoSize = True
        AuthorLabel.Location = New System.Drawing.Point(8, 129)
        AuthorLabel.Name = "AuthorLabel"
        AuthorLabel.Size = New System.Drawing.Size(64, 16)
        AuthorLabel.TabIndex = 35
        AuthorLabel.Text = "Author(s):"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(8, 106)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(37, 16)
        TitleLabel.TabIndex = 34
        TitleLabel.Text = "Title:"
        '
        'RegNoLabel1
        '
        RegNoLabel1.AutoSize = True
        RegNoLabel1.Location = New System.Drawing.Point(8, 83)
        RegNoLabel1.Name = "RegNoLabel1"
        RegNoLabel1.Size = New System.Drawing.Size(107, 16)
        RegNoLabel1.TabIndex = 33
        RegNoLabel1.Text = "Registration No.:"
        '
        'Label51
        '
        Label51.AutoSize = True
        Label51.Location = New System.Drawing.Point(8, 53)
        Label51.Name = "Label51"
        Label51.Size = New System.Drawing.Size(122, 16)
        Label51.TabIndex = 33
        Label51.Text = "Document Box No.:"
        '
        'Label52
        '
        Label52.AutoSize = True
        Label52.Location = New System.Drawing.Point(8, 30)
        Label52.Name = "Label52"
        Label52.Size = New System.Drawing.Size(131, 16)
        Label52.TabIndex = 32
        Label52.Text = "Document Rack No.:"
        '
        'Label50
        '
        Label50.AutoSize = True
        Label50.Location = New System.Drawing.Point(281, 205)
        Label50.Name = "Label50"
        Label50.Size = New System.Drawing.Size(82, 16)
        Label50.TabIndex = 49
        Label50.Text = "mm/dd/yyyy"
        '
        'Label53
        '
        Label53.AutoSize = True
        Label53.Location = New System.Drawing.Point(281, 177)
        Label53.Name = "Label53"
        Label53.Size = New System.Drawing.Size(82, 16)
        Label53.TabIndex = 47
        Label53.Text = "mm/dd/yyyy"
        '
        'Label54
        '
        Label54.AutoSize = True
        Label54.Location = New System.Drawing.Point(281, 154)
        Label54.Name = "Label54"
        Label54.Size = New System.Drawing.Size(82, 16)
        Label54.TabIndex = 45
        Label54.Text = "mm/dd/yyyy"
        '
        'Label55
        '
        Label55.AutoSize = True
        Label55.Location = New System.Drawing.Point(281, 103)
        Label55.Name = "Label55"
        Label55.Size = New System.Drawing.Size(82, 16)
        Label55.TabIndex = 43
        Label55.Text = "mm/dd/yyyy"
        '
        'RegMarkLabel
        '
        RegMarkLabel.AutoSize = True
        RegMarkLabel.Location = New System.Drawing.Point(8, 252)
        RegMarkLabel.Name = "RegMarkLabel"
        RegMarkLabel.Size = New System.Drawing.Size(111, 16)
        RegMarkLabel.TabIndex = 40
        RegMarkLabel.Text = "Registered Mark:"
        '
        'RegistrantLabel
        '
        RegistrantLabel.AutoSize = True
        RegistrantLabel.Location = New System.Drawing.Point(8, 229)
        RegistrantLabel.Name = "RegistrantLabel"
        RegistrantLabel.Size = New System.Drawing.Size(72, 16)
        RegistrantLabel.TabIndex = 39
        RegistrantLabel.Text = "Registrant:"
        '
        'FilingDateLabel
        '
        FilingDateLabel.AutoSize = True
        FilingDateLabel.Location = New System.Drawing.Point(8, 206)
        FilingDateLabel.Name = "FilingDateLabel"
        FilingDateLabel.Size = New System.Drawing.Size(75, 16)
        FilingDateLabel.TabIndex = 38
        FilingDateLabel.Text = "Filing Date:"
        '
        'ToPeriodLabel1
        '
        ToPeriodLabel1.AutoSize = True
        ToPeriodLabel1.Location = New System.Drawing.Point(8, 178)
        ToPeriodLabel1.Name = "ToPeriodLabel1"
        ToPeriodLabel1.Size = New System.Drawing.Size(71, 16)
        ToPeriodLabel1.TabIndex = 37
        ToPeriodLabel1.Text = "Valid Until:"
        '
        'FromPeriodLabel1
        '
        FromPeriodLabel1.AutoSize = True
        FromPeriodLabel1.Location = New System.Drawing.Point(8, 155)
        FromPeriodLabel1.Name = "FromPeriodLabel1"
        FromPeriodLabel1.Size = New System.Drawing.Size(76, 16)
        FromPeriodLabel1.TabIndex = 36
        FromPeriodLabel1.Text = "Valid From:"
        '
        'TermLabel
        '
        TermLabel.AutoSize = True
        TermLabel.Location = New System.Drawing.Point(8, 127)
        TermLabel.Name = "TermLabel"
        TermLabel.Size = New System.Drawing.Size(123, 16)
        TermLabel.TabIndex = 35
        TermLabel.Text = "Term (no. of years):"
        '
        'RegDateLabel
        '
        RegDateLabel.AutoSize = True
        RegDateLabel.Location = New System.Drawing.Point(8, 104)
        RegDateLabel.Name = "RegDateLabel"
        RegDateLabel.Size = New System.Drawing.Size(115, 16)
        RegDateLabel.TabIndex = 34
        RegDateLabel.Text = "Registration Date:"
        '
        'RegNoLabel2
        '
        RegNoLabel2.AutoSize = True
        RegNoLabel2.Location = New System.Drawing.Point(8, 81)
        RegNoLabel2.Name = "RegNoLabel2"
        RegNoLabel2.Size = New System.Drawing.Size(104, 16)
        RegNoLabel2.TabIndex = 33
        RegNoLabel2.Text = "Registration No:"
        '
        'Label56
        '
        Label56.AutoSize = True
        Label56.Location = New System.Drawing.Point(8, 53)
        Label56.Name = "Label56"
        Label56.Size = New System.Drawing.Size(122, 16)
        Label56.TabIndex = 33
        Label56.Text = "Document Box No.:"
        '
        'Label57
        '
        Label57.AutoSize = True
        Label57.Location = New System.Drawing.Point(8, 30)
        Label57.Name = "Label57"
        Label57.Size = New System.Drawing.Size(131, 16)
        Label57.TabIndex = 32
        Label57.Text = "Document Rack No.:"
        '
        'Label58
        '
        Label58.AutoSize = True
        Label58.Location = New System.Drawing.Point(281, 205)
        Label58.Name = "Label58"
        Label58.Size = New System.Drawing.Size(82, 16)
        Label58.TabIndex = 51
        Label58.Text = "mm/dd/yyyy"
        '
        'Label59
        '
        Label59.AutoSize = True
        Label59.Location = New System.Drawing.Point(281, 177)
        Label59.Name = "Label59"
        Label59.Size = New System.Drawing.Size(82, 16)
        Label59.TabIndex = 49
        Label59.Text = "mm/dd/yyyy"
        '
        'Label60
        '
        Label60.AutoSize = True
        Label60.Location = New System.Drawing.Point(281, 154)
        Label60.Name = "Label60"
        Label60.Size = New System.Drawing.Size(82, 16)
        Label60.TabIndex = 47
        Label60.Text = "mm/dd/yyyy"
        '
        'Label61
        '
        Label61.AutoSize = True
        Label61.Location = New System.Drawing.Point(281, 103)
        Label61.Name = "Label61"
        Label61.Size = New System.Drawing.Size(82, 16)
        Label61.TabIndex = 45
        Label61.Text = "mm/dd/yyyy"
        '
        'FilingDateLabel1
        '
        FilingDateLabel1.AutoSize = True
        FilingDateLabel1.Location = New System.Drawing.Point(8, 206)
        FilingDateLabel1.Name = "FilingDateLabel1"
        FilingDateLabel1.Size = New System.Drawing.Size(75, 16)
        FilingDateLabel1.TabIndex = 40
        FilingDateLabel1.Text = "Filing Date:"
        '
        'TitleLabel1
        '
        TitleLabel1.AutoSize = True
        TitleLabel1.Location = New System.Drawing.Point(8, 252)
        TitleLabel1.Name = "TitleLabel1"
        TitleLabel1.Size = New System.Drawing.Size(37, 16)
        TitleLabel1.TabIndex = 39
        TitleLabel1.Text = "Title:"
        '
        'RegistrantLabel1
        '
        RegistrantLabel1.AutoSize = True
        RegistrantLabel1.Location = New System.Drawing.Point(8, 229)
        RegistrantLabel1.Name = "RegistrantLabel1"
        RegistrantLabel1.Size = New System.Drawing.Size(72, 16)
        RegistrantLabel1.TabIndex = 38
        RegistrantLabel1.Text = "Registrant:"
        '
        'ToPeriodLabel2
        '
        ToPeriodLabel2.AutoSize = True
        ToPeriodLabel2.Location = New System.Drawing.Point(8, 178)
        ToPeriodLabel2.Name = "ToPeriodLabel2"
        ToPeriodLabel2.Size = New System.Drawing.Size(71, 16)
        ToPeriodLabel2.TabIndex = 37
        ToPeriodLabel2.Text = "Valid Until:"
        '
        'FromPeriodLabel2
        '
        FromPeriodLabel2.AutoSize = True
        FromPeriodLabel2.Location = New System.Drawing.Point(8, 155)
        FromPeriodLabel2.Name = "FromPeriodLabel2"
        FromPeriodLabel2.Size = New System.Drawing.Size(76, 16)
        FromPeriodLabel2.TabIndex = 36
        FromPeriodLabel2.Text = "Valid From:"
        '
        'TermLabel1
        '
        TermLabel1.AutoSize = True
        TermLabel1.Location = New System.Drawing.Point(8, 127)
        TermLabel1.Name = "TermLabel1"
        TermLabel1.Size = New System.Drawing.Size(123, 16)
        TermLabel1.TabIndex = 35
        TermLabel1.Text = "Term (no. of years):"
        '
        'RegDateLabel1
        '
        RegDateLabel1.AutoSize = True
        RegDateLabel1.Location = New System.Drawing.Point(8, 104)
        RegDateLabel1.Name = "RegDateLabel1"
        RegDateLabel1.Size = New System.Drawing.Size(115, 16)
        RegDateLabel1.TabIndex = 34
        RegDateLabel1.Text = "Registration Date:"
        '
        'RegNoLabel3
        '
        RegNoLabel3.AutoSize = True
        RegNoLabel3.Location = New System.Drawing.Point(8, 81)
        RegNoLabel3.Name = "RegNoLabel3"
        RegNoLabel3.Size = New System.Drawing.Size(104, 16)
        RegNoLabel3.TabIndex = 33
        RegNoLabel3.Text = "Registration No:"
        '
        'Label62
        '
        Label62.AutoSize = True
        Label62.Location = New System.Drawing.Point(8, 53)
        Label62.Name = "Label62"
        Label62.Size = New System.Drawing.Size(122, 16)
        Label62.TabIndex = 33
        Label62.Text = "Document Box No.:"
        '
        'Label63
        '
        Label63.AutoSize = True
        Label63.Location = New System.Drawing.Point(8, 30)
        Label63.Name = "Label63"
        Label63.Size = New System.Drawing.Size(131, 16)
        Label63.TabIndex = 32
        Label63.Text = "Document Rack No.:"
        '
        'Label69
        '
        Label69.AutoSize = True
        Label69.Location = New System.Drawing.Point(281, 223)
        Label69.Name = "Label69"
        Label69.Size = New System.Drawing.Size(82, 16)
        Label69.TabIndex = 51
        Label69.Text = "mm/dd/yyyy"
        '
        'Label64
        '
        Label64.AutoSize = True
        Label64.Location = New System.Drawing.Point(281, 200)
        Label64.Name = "Label64"
        Label64.Size = New System.Drawing.Size(82, 16)
        Label64.TabIndex = 49
        Label64.Text = "mm/dd/yyyy"
        '
        'Label65
        '
        Label65.AutoSize = True
        Label65.Location = New System.Drawing.Point(281, 131)
        Label65.Name = "Label65"
        Label65.Size = New System.Drawing.Size(82, 16)
        Label65.TabIndex = 47
        Label65.Text = "mm/dd/yyyy"
        '
        'ToPeriodLabel3
        '
        ToPeriodLabel3.AutoSize = True
        ToPeriodLabel3.Location = New System.Drawing.Point(8, 224)
        ToPeriodLabel3.Name = "ToPeriodLabel3"
        ToPeriodLabel3.Size = New System.Drawing.Size(71, 16)
        ToPeriodLabel3.TabIndex = 39
        ToPeriodLabel3.Text = "To Period:"
        '
        'FromPeriodLabel3
        '
        FromPeriodLabel3.AutoSize = True
        FromPeriodLabel3.Location = New System.Drawing.Point(8, 201)
        FromPeriodLabel3.Name = "FromPeriodLabel3"
        FromPeriodLabel3.Size = New System.Drawing.Size(85, 16)
        FromPeriodLabel3.TabIndex = 38
        FromPeriodLabel3.Text = "From Period:"
        '
        'TermLabel2
        '
        TermLabel2.AutoSize = True
        TermLabel2.Location = New System.Drawing.Point(8, 178)
        TermLabel2.Name = "TermLabel2"
        TermLabel2.Size = New System.Drawing.Size(43, 16)
        TermLabel2.TabIndex = 37
        TermLabel2.Text = "Term:"
        '
        'AccreditNoLabel
        '
        AccreditNoLabel.AutoSize = True
        AccreditNoLabel.Location = New System.Drawing.Point(8, 155)
        AccreditNoLabel.Name = "AccreditNoLabel"
        AccreditNoLabel.Size = New System.Drawing.Size(81, 16)
        AccreditNoLabel.TabIndex = 36
        AccreditNoLabel.Text = "Accredit No:"
        '
        'IssueDateLabel
        '
        IssueDateLabel.AutoSize = True
        IssueDateLabel.Location = New System.Drawing.Point(8, 132)
        IssueDateLabel.Name = "IssueDateLabel"
        IssueDateLabel.Size = New System.Drawing.Size(75, 16)
        IssueDateLabel.TabIndex = 35
        IssueDateLabel.Text = "Issue Date:"
        '
        'TinCustomerLabel2
        '
        TinCustomerLabel2.AutoSize = True
        TinCustomerLabel2.Location = New System.Drawing.Point(8, 104)
        TinCustomerLabel2.Name = "TinCustomerLabel2"
        TinCustomerLabel2.Size = New System.Drawing.Size(90, 16)
        TinCustomerLabel2.TabIndex = 34
        TinCustomerLabel2.Text = "Tin Customer:"
        '
        'CompanyLabel4
        '
        CompanyLabel4.AutoSize = True
        CompanyLabel4.Location = New System.Drawing.Point(8, 81)
        CompanyLabel4.Name = "CompanyLabel4"
        CompanyLabel4.Size = New System.Drawing.Size(69, 16)
        CompanyLabel4.TabIndex = 33
        CompanyLabel4.Text = "Company:"
        '
        'Label66
        '
        Label66.AutoSize = True
        Label66.Location = New System.Drawing.Point(8, 53)
        Label66.Name = "Label66"
        Label66.Size = New System.Drawing.Size(122, 16)
        Label66.TabIndex = 33
        Label66.Text = "Document Box No.:"
        '
        'Label67
        '
        Label67.AutoSize = True
        Label67.Location = New System.Drawing.Point(8, 30)
        Label67.Name = "Label67"
        Label67.Size = New System.Drawing.Size(131, 16)
        Label67.TabIndex = 32
        Label67.Text = "Document Rack No.:"
        '
        'Label73
        '
        Label73.AutoSize = True
        Label73.Location = New System.Drawing.Point(281, 195)
        Label73.Name = "Label73"
        Label73.Size = New System.Drawing.Size(82, 16)
        Label73.TabIndex = 53
        Label73.Text = "mm/dd/yyyy"
        '
        'Label72
        '
        Label72.AutoSize = True
        Label72.Location = New System.Drawing.Point(281, 172)
        Label72.Name = "Label72"
        Label72.Size = New System.Drawing.Size(82, 16)
        Label72.TabIndex = 51
        Label72.Text = "mm/dd/yyyy"
        '
        'Label71
        '
        Label71.AutoSize = True
        Label71.Location = New System.Drawing.Point(281, 103)
        Label71.Name = "Label71"
        Label71.Size = New System.Drawing.Size(82, 16)
        Label71.TabIndex = 49
        Label71.Text = "mm/dd/yyyy"
        '
        'ToPeriodLabel4
        '
        ToPeriodLabel4.AutoSize = True
        ToPeriodLabel4.Location = New System.Drawing.Point(8, 196)
        ToPeriodLabel4.Name = "ToPeriodLabel4"
        ToPeriodLabel4.Size = New System.Drawing.Size(71, 16)
        ToPeriodLabel4.TabIndex = 38
        ToPeriodLabel4.Text = "To Period:"
        '
        'FromPeriodLabel4
        '
        FromPeriodLabel4.AutoSize = True
        FromPeriodLabel4.Location = New System.Drawing.Point(8, 173)
        FromPeriodLabel4.Name = "FromPeriodLabel4"
        FromPeriodLabel4.Size = New System.Drawing.Size(85, 16)
        FromPeriodLabel4.TabIndex = 37
        FromPeriodLabel4.Text = "From Period:"
        '
        'TermLabel3
        '
        TermLabel3.AutoSize = True
        TermLabel3.Location = New System.Drawing.Point(8, 150)
        TermLabel3.Name = "TermLabel3"
        TermLabel3.Size = New System.Drawing.Size(43, 16)
        TermLabel3.TabIndex = 36
        TermLabel3.Text = "Term:"
        '
        'AccreditNoLabel1
        '
        AccreditNoLabel1.AutoSize = True
        AccreditNoLabel1.Location = New System.Drawing.Point(8, 127)
        AccreditNoLabel1.Name = "AccreditNoLabel1"
        AccreditNoLabel1.Size = New System.Drawing.Size(81, 16)
        AccreditNoLabel1.TabIndex = 35
        AccreditNoLabel1.Text = "Accredit No:"
        '
        'IssueDateLabel1
        '
        IssueDateLabel1.AutoSize = True
        IssueDateLabel1.Location = New System.Drawing.Point(8, 104)
        IssueDateLabel1.Name = "IssueDateLabel1"
        IssueDateLabel1.Size = New System.Drawing.Size(75, 16)
        IssueDateLabel1.TabIndex = 34
        IssueDateLabel1.Text = "Issue Date:"
        '
        'CompanyLabel5
        '
        CompanyLabel5.AutoSize = True
        CompanyLabel5.Location = New System.Drawing.Point(8, 81)
        CompanyLabel5.Name = "CompanyLabel5"
        CompanyLabel5.Size = New System.Drawing.Size(69, 16)
        CompanyLabel5.TabIndex = 33
        CompanyLabel5.Text = "Company:"
        '
        'Label68
        '
        Label68.AutoSize = True
        Label68.Location = New System.Drawing.Point(8, 53)
        Label68.Name = "Label68"
        Label68.Size = New System.Drawing.Size(122, 16)
        Label68.TabIndex = 33
        Label68.Text = "Document Box No.:"
        '
        'Label70
        '
        Label70.AutoSize = True
        Label70.Location = New System.Drawing.Point(8, 30)
        Label70.Name = "Label70"
        Label70.Size = New System.Drawing.Size(131, 16)
        Label70.TabIndex = 32
        Label70.Text = "Document Rack No.:"
        '
        'Label75
        '
        Label75.AutoSize = True
        Label75.Location = New System.Drawing.Point(281, 228)
        Label75.Name = "Label75"
        Label75.Size = New System.Drawing.Size(82, 16)
        Label75.TabIndex = 55
        Label75.Text = "mm/dd/yyyy"
        '
        'Label74
        '
        Label74.AutoSize = True
        Label74.Location = New System.Drawing.Point(281, 205)
        Label74.Name = "Label74"
        Label74.Size = New System.Drawing.Size(82, 16)
        Label74.TabIndex = 53
        Label74.Text = "mm/dd/yyyy"
        '
        'Label76
        '
        Label76.AutoSize = True
        Label76.Location = New System.Drawing.Point(281, 154)
        Label76.Name = "Label76"
        Label76.Size = New System.Drawing.Size(82, 16)
        Label76.TabIndex = 51
        Label76.Text = "mm/dd/yyyy"
        '
        'ToPeriodLabel5
        '
        ToPeriodLabel5.AutoSize = True
        ToPeriodLabel5.Location = New System.Drawing.Point(8, 229)
        ToPeriodLabel5.Name = "ToPeriodLabel5"
        ToPeriodLabel5.Size = New System.Drawing.Size(71, 16)
        ToPeriodLabel5.TabIndex = 39
        ToPeriodLabel5.Text = "Valid Until:"
        '
        'FromPeriodLabel5
        '
        FromPeriodLabel5.AutoSize = True
        FromPeriodLabel5.Location = New System.Drawing.Point(8, 206)
        FromPeriodLabel5.Name = "FromPeriodLabel5"
        FromPeriodLabel5.Size = New System.Drawing.Size(76, 16)
        FromPeriodLabel5.TabIndex = 38
        FromPeriodLabel5.Text = "Valid From:"
        '
        'TermLabel4
        '
        TermLabel4.AutoSize = True
        TermLabel4.Location = New System.Drawing.Point(8, 178)
        TermLabel4.Name = "TermLabel4"
        TermLabel4.Size = New System.Drawing.Size(43, 16)
        TermLabel4.TabIndex = 37
        TermLabel4.Text = "Term:"
        '
        'SubsDateLabel
        '
        SubsDateLabel.AutoSize = True
        SubsDateLabel.Location = New System.Drawing.Point(8, 155)
        SubsDateLabel.Name = "SubsDateLabel"
        SubsDateLabel.Size = New System.Drawing.Size(117, 16)
        SubsDateLabel.TabIndex = 36
        SubsDateLabel.Text = "Subscription Date:"
        '
        'GLNLabel
        '
        GLNLabel.AutoSize = True
        GLNLabel.Location = New System.Drawing.Point(8, 127)
        GLNLabel.Name = "GLNLabel"
        GLNLabel.Size = New System.Drawing.Size(38, 16)
        GLNLabel.TabIndex = 35
        GLNLabel.Text = "GLN:"
        '
        'CompanyPrefixLabel
        '
        CompanyPrefixLabel.AutoSize = True
        CompanyPrefixLabel.Location = New System.Drawing.Point(8, 104)
        CompanyPrefixLabel.Name = "CompanyPrefixLabel"
        CompanyPrefixLabel.Size = New System.Drawing.Size(105, 16)
        CompanyPrefixLabel.TabIndex = 34
        CompanyPrefixLabel.Text = "Company Prefix:"
        '
        'CompanyLabel6
        '
        CompanyLabel6.AutoSize = True
        CompanyLabel6.Location = New System.Drawing.Point(8, 81)
        CompanyLabel6.Name = "CompanyLabel6"
        CompanyLabel6.Size = New System.Drawing.Size(69, 16)
        CompanyLabel6.TabIndex = 33
        CompanyLabel6.Text = "Company:"
        '
        'Label77
        '
        Label77.AutoSize = True
        Label77.Location = New System.Drawing.Point(8, 53)
        Label77.Name = "Label77"
        Label77.Size = New System.Drawing.Size(122, 16)
        Label77.TabIndex = 33
        Label77.Text = "Document Box No.:"
        '
        'Label78
        '
        Label78.AutoSize = True
        Label78.Location = New System.Drawing.Point(8, 30)
        Label78.Name = "Label78"
        Label78.Size = New System.Drawing.Size(131, 16)
        Label78.TabIndex = 32
        Label78.Text = "Document Rack No.:"
        '
        'Label82
        '
        Label82.AutoSize = True
        Label82.Location = New System.Drawing.Point(281, 234)
        Label82.Name = "Label82"
        Label82.Size = New System.Drawing.Size(82, 16)
        Label82.TabIndex = 59
        Label82.Text = "mm/dd/yyyy"
        '
        'Label81
        '
        Label81.AutoSize = True
        Label81.Location = New System.Drawing.Point(281, 181)
        Label81.Name = "Label81"
        Label81.Size = New System.Drawing.Size(82, 16)
        Label81.TabIndex = 57
        Label81.Text = "mm/dd/yyyy"
        '
        'Label80
        '
        Label80.AutoSize = True
        Label80.Location = New System.Drawing.Point(281, 158)
        Label80.Name = "Label80"
        Label80.Size = New System.Drawing.Size(82, 16)
        Label80.TabIndex = 55
        Label80.Text = "mm/dd/yyyy"
        '
        'Label79
        '
        Label79.AutoSize = True
        Label79.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label79.Location = New System.Drawing.Point(20, 137)
        Label79.Name = "Label79"
        Label79.Size = New System.Drawing.Size(115, 16)
        Label79.TabIndex = 53
        Label79.Text = "Contract Period"
        '
        'Label83
        '
        Label83.AutoSize = True
        Label83.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label83.Location = New System.Drawing.Point(20, 431)
        Label83.Name = "Label83"
        Label83.Size = New System.Drawing.Size(60, 16)
        Label83.TabIndex = 52
        Label83.Text = "Party 2:"
        '
        'Label84
        '
        Label84.AutoSize = True
        Label84.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label84.Location = New System.Drawing.Point(20, 288)
        Label84.Name = "Label84"
        Label84.Size = New System.Drawing.Size(60, 16)
        Label84.TabIndex = 51
        Label84.Text = "Party 1:"
        '
        'Label85
        '
        Label85.AutoSize = True
        Label85.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label85.Location = New System.Drawing.Point(20, 213)
        Label85.Name = "Label85"
        Label85.Size = New System.Drawing.Size(159, 16)
        Label85.TabIndex = 50
        Label85.Text = "Other Contract Details"
        '
        'P2PositionLabel
        '
        P2PositionLabel.AutoSize = True
        P2PositionLabel.Location = New System.Drawing.Point(8, 548)
        P2PositionLabel.Name = "P2PositionLabel"
        P2PositionLabel.Size = New System.Drawing.Size(59, 16)
        P2PositionLabel.TabIndex = 48
        P2PositionLabel.Text = "Position:"
        '
        'P2LastNameLabel
        '
        P2LastNameLabel.AutoSize = True
        P2LastNameLabel.Location = New System.Drawing.Point(8, 525)
        P2LastNameLabel.Name = "P2LastNameLabel"
        P2LastNameLabel.Size = New System.Drawing.Size(76, 16)
        P2LastNameLabel.TabIndex = 47
        P2LastNameLabel.Text = "Last Name:"
        '
        'P2MiddleNameLabel
        '
        P2MiddleNameLabel.AutoSize = True
        P2MiddleNameLabel.Location = New System.Drawing.Point(8, 502)
        P2MiddleNameLabel.Name = "P2MiddleNameLabel"
        P2MiddleNameLabel.Size = New System.Drawing.Size(92, 16)
        P2MiddleNameLabel.TabIndex = 46
        P2MiddleNameLabel.Text = "Middle Name:"
        '
        'P2FirstNameLabel
        '
        P2FirstNameLabel.AutoSize = True
        P2FirstNameLabel.Location = New System.Drawing.Point(8, 479)
        P2FirstNameLabel.Name = "P2FirstNameLabel"
        P2FirstNameLabel.Size = New System.Drawing.Size(76, 16)
        P2FirstNameLabel.TabIndex = 45
        P2FirstNameLabel.Text = "First Name:"
        '
        'P2CompanyLabel
        '
        P2CompanyLabel.AutoSize = True
        P2CompanyLabel.Location = New System.Drawing.Point(8, 456)
        P2CompanyLabel.Name = "P2CompanyLabel"
        P2CompanyLabel.Size = New System.Drawing.Size(109, 16)
        P2CompanyLabel.TabIndex = 44
        P2CompanyLabel.Text = "Company Name:"
        '
        'P1PositionLabel
        '
        P1PositionLabel.AutoSize = True
        P1PositionLabel.Location = New System.Drawing.Point(8, 402)
        P1PositionLabel.Name = "P1PositionLabel"
        P1PositionLabel.Size = New System.Drawing.Size(59, 16)
        P1PositionLabel.TabIndex = 43
        P1PositionLabel.Text = "Position:"
        '
        'P1LastNameLabel
        '
        P1LastNameLabel.AutoSize = True
        P1LastNameLabel.Location = New System.Drawing.Point(8, 379)
        P1LastNameLabel.Name = "P1LastNameLabel"
        P1LastNameLabel.Size = New System.Drawing.Size(76, 16)
        P1LastNameLabel.TabIndex = 42
        P1LastNameLabel.Text = "Last Name:"
        '
        'P1MiddleNameLabel
        '
        P1MiddleNameLabel.AutoSize = True
        P1MiddleNameLabel.Location = New System.Drawing.Point(8, 356)
        P1MiddleNameLabel.Name = "P1MiddleNameLabel"
        P1MiddleNameLabel.Size = New System.Drawing.Size(92, 16)
        P1MiddleNameLabel.TabIndex = 41
        P1MiddleNameLabel.Text = "Middle Name:"
        '
        'P1FirstNameLabel
        '
        P1FirstNameLabel.AutoSize = True
        P1FirstNameLabel.Location = New System.Drawing.Point(8, 333)
        P1FirstNameLabel.Name = "P1FirstNameLabel"
        P1FirstNameLabel.Size = New System.Drawing.Size(76, 16)
        P1FirstNameLabel.TabIndex = 40
        P1FirstNameLabel.Text = "First Name:"
        '
        'P1CompanyLabel
        '
        P1CompanyLabel.AutoSize = True
        P1CompanyLabel.Location = New System.Drawing.Point(8, 310)
        P1CompanyLabel.Name = "P1CompanyLabel"
        P1CompanyLabel.Size = New System.Drawing.Size(109, 16)
        P1CompanyLabel.TabIndex = 39
        P1CompanyLabel.Text = "Company Name:"
        '
        'ContractPlaceLabel
        '
        ContractPlaceLabel.AutoSize = True
        ContractPlaceLabel.Location = New System.Drawing.Point(8, 258)
        ContractPlaceLabel.Name = "ContractPlaceLabel"
        ContractPlaceLabel.Size = New System.Drawing.Size(145, 16)
        ContractPlaceLabel.TabIndex = 38
        ContractPlaceLabel.Text = "Place of Contract (City):"
        '
        'SignDateLabel
        '
        SignDateLabel.AutoSize = True
        SignDateLabel.Location = New System.Drawing.Point(8, 235)
        SignDateLabel.Name = "SignDateLabel"
        SignDateLabel.Size = New System.Drawing.Size(86, 16)
        SignDateLabel.TabIndex = 37
        SignDateLabel.Text = "Date Signed:"
        '
        'ToPeriodLabel6
        '
        ToPeriodLabel6.AutoSize = True
        ToPeriodLabel6.Location = New System.Drawing.Point(8, 182)
        ToPeriodLabel6.Name = "ToPeriodLabel6"
        ToPeriodLabel6.Size = New System.Drawing.Size(67, 16)
        ToPeriodLabel6.TabIndex = 36
        ToPeriodLabel6.Text = "Date End:"
        '
        'FromPeriodLabel6
        '
        FromPeriodLabel6.AutoSize = True
        FromPeriodLabel6.Location = New System.Drawing.Point(8, 159)
        FromPeriodLabel6.Name = "FromPeriodLabel6"
        FromPeriodLabel6.Size = New System.Drawing.Size(70, 16)
        FromPeriodLabel6.TabIndex = 35
        FromPeriodLabel6.Text = "Date Start:"
        '
        'PurposeLabel1
        '
        PurposeLabel1.AutoSize = True
        PurposeLabel1.Location = New System.Drawing.Point(8, 104)
        PurposeLabel1.Name = "PurposeLabel1"
        PurposeLabel1.Size = New System.Drawing.Size(62, 16)
        PurposeLabel1.TabIndex = 34
        PurposeLabel1.Text = "Purpose:"
        '
        'ContractTypeLabel
        '
        ContractTypeLabel.AutoSize = True
        ContractTypeLabel.Location = New System.Drawing.Point(8, 81)
        ContractTypeLabel.Name = "ContractTypeLabel"
        ContractTypeLabel.Size = New System.Drawing.Size(95, 16)
        ContractTypeLabel.TabIndex = 33
        ContractTypeLabel.Text = "Contract Type:"
        '
        'Label86
        '
        Label86.AutoSize = True
        Label86.Location = New System.Drawing.Point(8, 53)
        Label86.Name = "Label86"
        Label86.Size = New System.Drawing.Size(122, 16)
        Label86.TabIndex = 33
        Label86.Text = "Document Box No.:"
        '
        'Label87
        '
        Label87.AutoSize = True
        Label87.Location = New System.Drawing.Point(8, 30)
        Label87.Name = "Label87"
        Label87.Size = New System.Drawing.Size(131, 16)
        Label87.TabIndex = 32
        Label87.Text = "Document Rack No.:"
        '
        'Label89
        '
        Label89.AutoSize = True
        Label89.Location = New System.Drawing.Point(281, 440)
        Label89.Name = "Label89"
        Label89.Size = New System.Drawing.Size(82, 16)
        Label89.TabIndex = 63
        Label89.Text = "mm/dd/yyyy"
        '
        'Label88
        '
        Label88.AutoSize = True
        Label88.Location = New System.Drawing.Point(281, 416)
        Label88.Name = "Label88"
        Label88.Size = New System.Drawing.Size(82, 16)
        Label88.TabIndex = 61
        Label88.Text = "mm/dd/yyyy"
        '
        'Label90
        '
        Label90.AutoSize = True
        Label90.Location = New System.Drawing.Point(281, 126)
        Label90.Name = "Label90"
        Label90.Size = New System.Drawing.Size(82, 16)
        Label90.TabIndex = 59
        Label90.Text = "mm/dd/yyyy"
        '
        'Label91
        '
        Label91.AutoSize = True
        Label91.Location = New System.Drawing.Point(281, 103)
        Label91.Name = "Label91"
        Label91.Size = New System.Drawing.Size(82, 16)
        Label91.TabIndex = 57
        Label91.Text = "mm/dd/yyyy"
        '
        'Label92
        '
        Label92.AutoSize = True
        Label92.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label92.Location = New System.Drawing.Point(20, 276)
        Label92.Name = "Label92"
        Label92.Size = New System.Drawing.Size(67, 16)
        Label92.TabIndex = 50
        Label92.Text = "Grantee:"
        '
        'Label93
        '
        Label93.AutoSize = True
        Label93.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label93.Location = New System.Drawing.Point(20, 154)
        Label93.Name = "Label93"
        Label93.Size = New System.Drawing.Size(63, 16)
        Label93.TabIndex = 49
        Label93.Text = "Grantor:"
        '
        'Label94
        '
        Label94.AutoSize = True
        Label94.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label94.Location = New System.Drawing.Point(20, 395)
        Label94.Name = "Label94"
        Label94.Size = New System.Drawing.Size(121, 16)
        Label94.TabIndex = 48
        Label94.Text = "Period Covered:"
        '
        'ToPeriodLabel7
        '
        ToPeriodLabel7.AutoSize = True
        ToPeriodLabel7.Location = New System.Drawing.Point(8, 441)
        ToPeriodLabel7.Name = "ToPeriodLabel7"
        ToPeriodLabel7.Size = New System.Drawing.Size(67, 16)
        ToPeriodLabel7.TabIndex = 44
        ToPeriodLabel7.Text = "Date End:"
        '
        'FromPeriodLabel7
        '
        FromPeriodLabel7.AutoSize = True
        FromPeriodLabel7.Location = New System.Drawing.Point(8, 417)
        FromPeriodLabel7.Name = "FromPeriodLabel7"
        FromPeriodLabel7.Size = New System.Drawing.Size(70, 16)
        FromPeriodLabel7.TabIndex = 43
        FromPeriodLabel7.Text = "Date Start:"
        '
        'P2LastNameLabel1
        '
        P2LastNameLabel1.AutoSize = True
        P2LastNameLabel1.Location = New System.Drawing.Point(8, 365)
        P2LastNameLabel1.Name = "P2LastNameLabel1"
        P2LastNameLabel1.Size = New System.Drawing.Size(76, 16)
        P2LastNameLabel1.TabIndex = 42
        P2LastNameLabel1.Text = "Last Name:"
        '
        'P2MiddleNameLabel1
        '
        P2MiddleNameLabel1.AutoSize = True
        P2MiddleNameLabel1.Location = New System.Drawing.Point(8, 342)
        P2MiddleNameLabel1.Name = "P2MiddleNameLabel1"
        P2MiddleNameLabel1.Size = New System.Drawing.Size(92, 16)
        P2MiddleNameLabel1.TabIndex = 41
        P2MiddleNameLabel1.Text = "Middle Name:"
        '
        'P2FirstNameLabel1
        '
        P2FirstNameLabel1.AutoSize = True
        P2FirstNameLabel1.Location = New System.Drawing.Point(8, 319)
        P2FirstNameLabel1.Name = "P2FirstNameLabel1"
        P2FirstNameLabel1.Size = New System.Drawing.Size(76, 16)
        P2FirstNameLabel1.TabIndex = 40
        P2FirstNameLabel1.Text = "First Name:"
        '
        'P2CompanyLabel1
        '
        P2CompanyLabel1.AutoSize = True
        P2CompanyLabel1.Location = New System.Drawing.Point(8, 296)
        P2CompanyLabel1.Name = "P2CompanyLabel1"
        P2CompanyLabel1.Size = New System.Drawing.Size(109, 16)
        P2CompanyLabel1.TabIndex = 39
        P2CompanyLabel1.Text = "Company Name:"
        '
        'P1LastNameLabel1
        '
        P1LastNameLabel1.AutoSize = True
        P1LastNameLabel1.Location = New System.Drawing.Point(8, 246)
        P1LastNameLabel1.Name = "P1LastNameLabel1"
        P1LastNameLabel1.Size = New System.Drawing.Size(76, 16)
        P1LastNameLabel1.TabIndex = 38
        P1LastNameLabel1.Text = "Last Name:"
        '
        'P1MiddleNameLabel1
        '
        P1MiddleNameLabel1.AutoSize = True
        P1MiddleNameLabel1.Location = New System.Drawing.Point(8, 223)
        P1MiddleNameLabel1.Name = "P1MiddleNameLabel1"
        P1MiddleNameLabel1.Size = New System.Drawing.Size(92, 16)
        P1MiddleNameLabel1.TabIndex = 37
        P1MiddleNameLabel1.Text = "Middle Name:"
        '
        'P1FirstNameLabel1
        '
        P1FirstNameLabel1.AutoSize = True
        P1FirstNameLabel1.Location = New System.Drawing.Point(8, 199)
        P1FirstNameLabel1.Name = "P1FirstNameLabel1"
        P1FirstNameLabel1.Size = New System.Drawing.Size(76, 16)
        P1FirstNameLabel1.TabIndex = 36
        P1FirstNameLabel1.Text = "First Name:"
        '
        'P1CompanyLabel1
        '
        P1CompanyLabel1.AutoSize = True
        P1CompanyLabel1.Location = New System.Drawing.Point(8, 176)
        P1CompanyLabel1.Name = "P1CompanyLabel1"
        P1CompanyLabel1.Size = New System.Drawing.Size(69, 16)
        P1CompanyLabel1.TabIndex = 35
        P1CompanyLabel1.Text = "Company:"
        '
        'IssuePlaceLabel
        '
        IssuePlaceLabel.AutoSize = True
        IssuePlaceLabel.Location = New System.Drawing.Point(8, 127)
        IssuePlaceLabel.Name = "IssuePlaceLabel"
        IssuePlaceLabel.Size = New System.Drawing.Size(86, 16)
        IssuePlaceLabel.TabIndex = 34
        IssuePlaceLabel.Text = "Place Issued"
        '
        'IssueDateLabel2
        '
        IssueDateLabel2.AutoSize = True
        IssueDateLabel2.Location = New System.Drawing.Point(8, 104)
        IssueDateLabel2.Name = "IssueDateLabel2"
        IssueDateLabel2.Size = New System.Drawing.Size(80, 16)
        IssueDateLabel2.TabIndex = 33
        IssueDateLabel2.Text = "Date Issued"
        '
        'Label95
        '
        Label95.AutoSize = True
        Label95.Location = New System.Drawing.Point(8, 53)
        Label95.Name = "Label95"
        Label95.Size = New System.Drawing.Size(122, 16)
        Label95.TabIndex = 33
        Label95.Text = "Document Box No.:"
        '
        'Label96
        '
        Label96.AutoSize = True
        Label96.Location = New System.Drawing.Point(8, 30)
        Label96.Name = "Label96"
        Label96.Size = New System.Drawing.Size(131, 16)
        Label96.TabIndex = 32
        Label96.Text = "Document Rack No.:"
        '
        'Label97
        '
        Label97.AutoSize = True
        Label97.Location = New System.Drawing.Point(8, 81)
        Label97.Name = "Label97"
        Label97.Size = New System.Drawing.Size(62, 16)
        Label97.TabIndex = 4
        Label97.Text = "Purpose:"
        '
        'Label98
        '
        Label98.AutoSize = True
        Label98.Location = New System.Drawing.Point(281, 121)
        Label98.Name = "Label98"
        Label98.Size = New System.Drawing.Size(82, 16)
        Label98.TabIndex = 61
        Label98.Text = "mm/dd/yyyy"
        '
        'Label99
        '
        Label99.AutoSize = True
        Label99.Location = New System.Drawing.Point(281, 98)
        Label99.Name = "Label99"
        Label99.Size = New System.Drawing.Size(82, 16)
        Label99.TabIndex = 59
        Label99.Text = "mm/dd/yyyy"
        '
        'LastNameLabel2
        '
        LastNameLabel2.AutoSize = True
        LastNameLabel2.Location = New System.Drawing.Point(8, 248)
        LastNameLabel2.Name = "LastNameLabel2"
        LastNameLabel2.Size = New System.Drawing.Size(76, 16)
        LastNameLabel2.TabIndex = 38
        LastNameLabel2.Text = "Last Name:"
        '
        'MiddleNameLabel2
        '
        MiddleNameLabel2.AutoSize = True
        MiddleNameLabel2.Location = New System.Drawing.Point(8, 225)
        MiddleNameLabel2.Name = "MiddleNameLabel2"
        MiddleNameLabel2.Size = New System.Drawing.Size(92, 16)
        MiddleNameLabel2.TabIndex = 37
        MiddleNameLabel2.Text = "Middle Name:"
        '
        'FirstNameLabel2
        '
        FirstNameLabel2.AutoSize = True
        FirstNameLabel2.Location = New System.Drawing.Point(8, 202)
        FirstNameLabel2.Name = "FirstNameLabel2"
        FirstNameLabel2.Size = New System.Drawing.Size(76, 16)
        FirstNameLabel2.TabIndex = 36
        FirstNameLabel2.Text = "First Name:"
        '
        'CompanyLabel7
        '
        CompanyLabel7.AutoSize = True
        CompanyLabel7.Location = New System.Drawing.Point(8, 179)
        CompanyLabel7.Name = "CompanyLabel7"
        CompanyLabel7.Size = New System.Drawing.Size(109, 16)
        CompanyLabel7.TabIndex = 35
        CompanyLabel7.Text = "Company Name:"
        '
        'IssuePlaceLabel1
        '
        IssuePlaceLabel1.AutoSize = True
        IssuePlaceLabel1.Location = New System.Drawing.Point(8, 122)
        IssuePlaceLabel1.Name = "IssuePlaceLabel1"
        IssuePlaceLabel1.Size = New System.Drawing.Size(81, 16)
        IssuePlaceLabel1.TabIndex = 34
        IssuePlaceLabel1.Text = "Issue Place:"
        '
        'IssueDateLabel3
        '
        IssueDateLabel3.AutoSize = True
        IssueDateLabel3.Location = New System.Drawing.Point(8, 99)
        IssueDateLabel3.Name = "IssueDateLabel3"
        IssueDateLabel3.Size = New System.Drawing.Size(75, 16)
        IssueDateLabel3.TabIndex = 33
        IssueDateLabel3.Text = "Issue Date:"
        '
        'Label100
        '
        Label100.AutoSize = True
        Label100.Location = New System.Drawing.Point(8, 53)
        Label100.Name = "Label100"
        Label100.Size = New System.Drawing.Size(122, 16)
        Label100.TabIndex = 33
        Label100.Text = "Document Box No.:"
        '
        'Label101
        '
        Label101.AutoSize = True
        Label101.Location = New System.Drawing.Point(8, 30)
        Label101.Name = "Label101"
        Label101.Size = New System.Drawing.Size(131, 16)
        Label101.TabIndex = 32
        Label101.Text = "Document Rack No.:"
        '
        'Label102
        '
        Label102.AutoSize = True
        Label102.Location = New System.Drawing.Point(8, 76)
        Label102.Name = "Label102"
        Label102.Size = New System.Drawing.Size(62, 16)
        Label102.TabIndex = 4
        Label102.Text = "Purpose:"
        '
        'Label103
        '
        Label103.AutoSize = True
        Label103.Location = New System.Drawing.Point(281, 167)
        Label103.Name = "Label103"
        Label103.Size = New System.Drawing.Size(82, 16)
        Label103.TabIndex = 61
        Label103.Text = "mm/dd/yyyy"
        '
        'Label104
        '
        Label104.AutoSize = True
        Label104.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label104.Location = New System.Drawing.Point(22, 200)
        Label104.Name = "Label104"
        Label104.Size = New System.Drawing.Size(79, 16)
        Label104.TabIndex = 47
        Label104.Text = "Issued by:"
        '
        'Label105
        '
        Label105.AutoSize = True
        Label105.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label105.Location = New System.Drawing.Point(22, 329)
        Label105.Name = "Label105"
        Label105.Size = New System.Drawing.Size(75, 16)
        Label105.TabIndex = 46
        Label105.Text = "Issued to:"
        '
        'P2LastNameLabel2
        '
        P2LastNameLabel2.AutoSize = True
        P2LastNameLabel2.Location = New System.Drawing.Point(8, 419)
        P2LastNameLabel2.Name = "P2LastNameLabel2"
        P2LastNameLabel2.Size = New System.Drawing.Size(76, 16)
        P2LastNameLabel2.TabIndex = 44
        P2LastNameLabel2.Text = "Last Name:"
        '
        'P2MiddleNameLabel2
        '
        P2MiddleNameLabel2.AutoSize = True
        P2MiddleNameLabel2.Location = New System.Drawing.Point(8, 396)
        P2MiddleNameLabel2.Name = "P2MiddleNameLabel2"
        P2MiddleNameLabel2.Size = New System.Drawing.Size(92, 16)
        P2MiddleNameLabel2.TabIndex = 43
        P2MiddleNameLabel2.Text = "Middle Name:"
        '
        'P2FirstNameLabel2
        '
        P2FirstNameLabel2.AutoSize = True
        P2FirstNameLabel2.Location = New System.Drawing.Point(8, 373)
        P2FirstNameLabel2.Name = "P2FirstNameLabel2"
        P2FirstNameLabel2.Size = New System.Drawing.Size(76, 16)
        P2FirstNameLabel2.TabIndex = 42
        P2FirstNameLabel2.Text = "First Name:"
        '
        'P2CompanyLabel2
        '
        P2CompanyLabel2.AutoSize = True
        P2CompanyLabel2.Location = New System.Drawing.Point(8, 350)
        P2CompanyLabel2.Name = "P2CompanyLabel2"
        P2CompanyLabel2.Size = New System.Drawing.Size(81, 16)
        P2CompanyLabel2.TabIndex = 41
        P2CompanyLabel2.Text = "Department:"
        '
        'P1LastNameLabel2
        '
        P1LastNameLabel2.AutoSize = True
        P1LastNameLabel2.Location = New System.Drawing.Point(8, 293)
        P1LastNameLabel2.Name = "P1LastNameLabel2"
        P1LastNameLabel2.Size = New System.Drawing.Size(76, 16)
        P1LastNameLabel2.TabIndex = 40
        P1LastNameLabel2.Text = "Last Name:"
        '
        'P1MiddleNameLabel2
        '
        P1MiddleNameLabel2.AutoSize = True
        P1MiddleNameLabel2.Location = New System.Drawing.Point(8, 270)
        P1MiddleNameLabel2.Name = "P1MiddleNameLabel2"
        P1MiddleNameLabel2.Size = New System.Drawing.Size(92, 16)
        P1MiddleNameLabel2.TabIndex = 39
        P1MiddleNameLabel2.Text = "Middle Name:"
        '
        'P1FirstNameLabel2
        '
        P1FirstNameLabel2.AutoSize = True
        P1FirstNameLabel2.Location = New System.Drawing.Point(8, 247)
        P1FirstNameLabel2.Name = "P1FirstNameLabel2"
        P1FirstNameLabel2.Size = New System.Drawing.Size(76, 16)
        P1FirstNameLabel2.TabIndex = 38
        P1FirstNameLabel2.Text = "First Name:"
        '
        'P1CompanyLabel2
        '
        P1CompanyLabel2.AutoSize = True
        P1CompanyLabel2.Location = New System.Drawing.Point(8, 224)
        P1CompanyLabel2.Name = "P1CompanyLabel2"
        P1CompanyLabel2.Size = New System.Drawing.Size(81, 16)
        P1CompanyLabel2.TabIndex = 37
        P1CompanyLabel2.Text = "Department:"
        '
        'IssueDateLabel4
        '
        IssueDateLabel4.AutoSize = True
        IssueDateLabel4.Location = New System.Drawing.Point(8, 168)
        IssueDateLabel4.Name = "IssueDateLabel4"
        IssueDateLabel4.Size = New System.Drawing.Size(83, 16)
        IssueDateLabel4.TabIndex = 36
        IssueDateLabel4.Text = "Date Issued:"
        '
        'MemoSubjLabel
        '
        MemoSubjLabel.AutoSize = True
        MemoSubjLabel.Location = New System.Drawing.Point(8, 122)
        MemoSubjLabel.Name = "MemoSubjLabel"
        MemoSubjLabel.Size = New System.Drawing.Size(97, 16)
        MemoSubjLabel.TabIndex = 35
        MemoSubjLabel.Text = "Memo Subject:"
        '
        'MemoTypeLabel
        '
        MemoTypeLabel.AutoSize = True
        MemoTypeLabel.Location = New System.Drawing.Point(8, 99)
        MemoTypeLabel.Name = "MemoTypeLabel"
        MemoTypeLabel.Size = New System.Drawing.Size(84, 16)
        MemoTypeLabel.TabIndex = 34
        MemoTypeLabel.Text = "Memo Type:"
        '
        'CompanyLabel8
        '
        CompanyLabel8.AutoSize = True
        CompanyLabel8.Location = New System.Drawing.Point(8, 76)
        CompanyLabel8.Name = "CompanyLabel8"
        CompanyLabel8.Size = New System.Drawing.Size(109, 16)
        CompanyLabel8.TabIndex = 33
        CompanyLabel8.Text = "Company Name:"
        '
        'Label106
        '
        Label106.AutoSize = True
        Label106.Location = New System.Drawing.Point(8, 53)
        Label106.Name = "Label106"
        Label106.Size = New System.Drawing.Size(122, 16)
        Label106.TabIndex = 33
        Label106.Text = "Document Box No.:"
        '
        'Label107
        '
        Label107.AutoSize = True
        Label107.Location = New System.Drawing.Point(8, 30)
        Label107.Name = "Label107"
        Label107.Size = New System.Drawing.Size(131, 16)
        Label107.TabIndex = 32
        Label107.Text = "Document Rack No.:"
        '
        'Label108
        '
        Label108.AutoSize = True
        Label108.Location = New System.Drawing.Point(8, 145)
        Label108.Name = "Label108"
        Label108.Size = New System.Drawing.Size(62, 16)
        Label108.TabIndex = 4
        Label108.Text = "Purpose:"
        '
        'Label109
        '
        Label109.AutoSize = True
        Label109.Location = New System.Drawing.Point(261, 178)
        Label109.Name = "Label109"
        Label109.Size = New System.Drawing.Size(85, 16)
        Label109.TabIndex = 52
        Label109.Text = "(no. of years)"
        '
        'Label110
        '
        Label110.AutoSize = True
        Label110.Location = New System.Drawing.Point(260, 150)
        Label110.Name = "Label110"
        Label110.Size = New System.Drawing.Size(85, 16)
        Label110.TabIndex = 54
        Label110.Text = "(no. of years)"
        '
        'Label111
        '
        Label111.AutoSize = True
        Label111.Location = New System.Drawing.Point(261, 178)
        Label111.Name = "Label111"
        Label111.Size = New System.Drawing.Size(85, 16)
        Label111.TabIndex = 56
        Label111.Text = "(no. of years)"
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.BtnEditRecord)
        Me.SplitContainer2.Panel1.Controls.Add(Me.TabControl1)
        Me.SplitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer2.Panel2.Controls.Add(Me.WebBrowser1)
        Me.SplitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer2.Size = New System.Drawing.Size(1240, 518)
        Me.SplitContainer2.SplitterDistance = 658
        Me.SplitContainer2.TabIndex = 0
        Me.SplitContainer2.TabStop = False
        '
        'BtnRemoval
        '
        Me.BtnRemoval.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnRemoval.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRemoval.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemoval.Location = New System.Drawing.Point(294, 7)
        Me.BtnRemoval.Name = "BtnRemoval"
        Me.BtnRemoval.Size = New System.Drawing.Size(106, 28)
        Me.BtnRemoval.TabIndex = 2
        Me.BtnRemoval.Text = "For Removal"
        Me.BtnRemoval.UseVisualStyleBackColor = False
        '
        'BtnDownload
        '
        Me.BtnDownload.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDownload.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDownload.Location = New System.Drawing.Point(4, 7)
        Me.BtnDownload.Name = "BtnDownload"
        Me.BtnDownload.Size = New System.Drawing.Size(106, 28)
        Me.BtnDownload.TabIndex = 1
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
        Me.TabControl1.Size = New System.Drawing.Size(658, 477)
        Me.TabControl1.TabIndex = 91
        Me.TabControl1.TabStop = False
        '
        'TabQuery
        '
        Me.TabQuery.BackColor = System.Drawing.Color.Azure
        Me.TabQuery.Controls.Add(Me.GroupBox3)
        Me.TabQuery.Controls.Add(Me.Label36)
        Me.TabQuery.Location = New System.Drawing.Point(4, 32)
        Me.TabQuery.Name = "TabQuery"
        Me.TabQuery.Padding = New System.Windows.Forms.Padding(3)
        Me.TabQuery.Size = New System.Drawing.Size(650, 441)
        Me.TabQuery.TabIndex = 0
        Me.TabQuery.Text = "TabQuery"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtWild)
        Me.GroupBox3.Controls.Add(Me.Label37)
        Me.GroupBox3.Controls.Add(Me.BtnSearch)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(597, 64)
        Me.GroupBox3.TabIndex = 92
        Me.GroupBox3.TabStop = False
        '
        'txtWild
        '
        Me.txtWild.Location = New System.Drawing.Point(78, 22)
        Me.txtWild.Name = "txtWild"
        Me.txtWild.Size = New System.Drawing.Size(393, 26)
        Me.txtWild.TabIndex = 92
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(3, 25)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(71, 20)
        Me.Label37.TabIndex = 93
        Me.Label37.Text = "Search:"
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.Location = New System.Drawing.Point(477, 20)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(110, 28)
        Me.BtnSearch.TabIndex = 1
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(454, 3)
        Me.Label36.Name = "Label36"
        Me.Label36.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label36.Size = New System.Drawing.Size(158, 15)
        Me.Label36.TabIndex = 88
        Me.Label36.Text = "Double Click to view the file."
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
        Me.TabChanges.Size = New System.Drawing.Size(650, 441)
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
        Me.txtPages.TabIndex = 11
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
        'cbDocSize
        '
        Me.cbDocSize.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "DocSize", True))
        Me.cbDocSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDocSize.FormattingEnabled = True
        Me.cbDocSize.Items.AddRange(New Object() {"8.5 x 11 (Letter Size)", "8.5 x 13 (Long Bond)", "8.5 x 14 (Legal Size)", "A4 Size", "A5 Size"})
        Me.cbDocSize.Location = New System.Drawing.Point(138, 103)
        Me.cbDocSize.Name = "cbDocSize"
        Me.cbDocSize.Size = New System.Drawing.Size(217, 24)
        Me.cbDocSize.TabIndex = 9
        '
        'chkConfidential
        '
        Me.chkConfidential.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DocsCatalogueBindingSource, "Confidential", True))
        Me.chkConfidential.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkConfidential.Location = New System.Drawing.Point(495, 80)
        Me.chkConfidential.Name = "chkConfidential"
        Me.chkConfidential.Size = New System.Drawing.Size(104, 24)
        Me.chkConfidential.TabIndex = 10
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
        Me.SubBatchTextBox.TabIndex = 7
        '
        'BatchTextBox
        '
        Me.BatchTextBox.BackColor = System.Drawing.Color.White
        Me.BatchTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Batch", True))
        Me.BatchTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BatchTextBox.Location = New System.Drawing.Point(138, 34)
        Me.BatchTextBox.Name = "BatchTextBox"
        Me.BatchTextBox.Size = New System.Drawing.Size(461, 22)
        Me.BatchTextBox.TabIndex = 6
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Id", True))
        Me.IdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox.Location = New System.Drawing.Point(138, 80)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(82, 22)
        Me.IdTextBox.TabIndex = 8
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
        Me.DocumentTypeCombobox2.Size = New System.Drawing.Size(461, 28)
        Me.DocumentTypeCombobox2.TabIndex = 5
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
        Me.TabControl2.Controls.Add(Me.Importation)
        Me.TabControl2.Controls.Add(Me.BIR)
        Me.TabControl2.Controls.Add(Me.HRDoc)
        Me.TabControl2.Controls.Add(Me.Copyright)
        Me.TabControl2.Controls.Add(Me.Trademark)
        Me.TabControl2.Controls.Add(Me.Patent)
        Me.TabControl2.Controls.Add(Me.BIRClear)
        Me.TabControl2.Controls.Add(Me.Accredit)
        Me.TabControl2.Controls.Add(Me.Subs)
        Me.TabControl2.Controls.Add(Me.Contract)
        Me.TabControl2.Controls.Add(Me.Attorney)
        Me.TabControl2.Controls.Add(Me.OtherDoc)
        Me.TabControl2.Controls.Add(Me.Memo)
        Me.TabControl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(-1, 125)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(658, 310)
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
        Me.Timesheet.Location = New System.Drawing.Point(4, 22)
        Me.Timesheet.Name = "Timesheet"
        Me.Timesheet.Padding = New System.Windows.Forms.Padding(3)
        Me.Timesheet.Size = New System.Drawing.Size(650, 284)
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
        Me.GrpTimeSheet.Size = New System.Drawing.Size(627, 294)
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
        Me.BoxNoTS.TabIndex = 13
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
        Me.RackNoTS.TabIndex = 12
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
        Me.DTToPeriod.TabIndex = 22
        '
        'FromPeriodTextBox
        '
        Me.FromPeriodTextBox.BackColor = System.Drawing.Color.White
        Me.FromPeriodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "FromPeriod", True))
        Me.FromPeriodTextBox.Location = New System.Drawing.Point(181, 21)
        Me.FromPeriodTextBox.Name = "FromPeriodTextBox"
        Me.FromPeriodTextBox.Size = New System.Drawing.Size(104, 22)
        Me.FromPeriodTextBox.TabIndex = 19
        Me.FromPeriodTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DTFromPeriod
        '
        Me.DTFromPeriod.Location = New System.Drawing.Point(286, 21)
        Me.DTFromPeriod.Name = "DTFromPeriod"
        Me.DTFromPeriod.Size = New System.Drawing.Size(18, 22)
        Me.DTFromPeriod.TabIndex = 20
        '
        'ToPeriodTextBox
        '
        Me.ToPeriodTextBox.BackColor = System.Drawing.Color.White
        Me.ToPeriodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ToPeriod", True))
        Me.ToPeriodTextBox.Location = New System.Drawing.Point(181, 47)
        Me.ToPeriodTextBox.Name = "ToPeriodTextBox"
        Me.ToPeriodTextBox.Size = New System.Drawing.Size(103, 22)
        Me.ToPeriodTextBox.TabIndex = 21
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
        Me.MiddleNameTextBox.TabIndex = 18
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
        Me.FirstNameTextBox.TabIndex = 17
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
        Me.LastNameTextBox.TabIndex = 16
        '
        'DocumentDateTS
        '
        Me.DocumentDateTS.BackColor = System.Drawing.Color.White
        Me.DocumentDateTS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "DocumentDate", True))
        Me.DocumentDateTS.Location = New System.Drawing.Point(158, 73)
        Me.DocumentDateTS.Name = "DocumentDateTS"
        Me.DocumentDateTS.Size = New System.Drawing.Size(104, 22)
        Me.DocumentDateTS.TabIndex = 14
        Me.DocumentDateTS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DTDocuTimeSheet
        '
        Me.DTDocuTimeSheet.Location = New System.Drawing.Point(263, 73)
        Me.DTDocuTimeSheet.Name = "DTDocuTimeSheet"
        Me.DTDocuTimeSheet.Size = New System.Drawing.Size(18, 22)
        Me.DTDocuTimeSheet.TabIndex = 15
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
        Me.ReceiptInvoice.Location = New System.Drawing.Point(4, 22)
        Me.ReceiptInvoice.Name = "ReceiptInvoice"
        Me.ReceiptInvoice.Padding = New System.Windows.Forms.Padding(3)
        Me.ReceiptInvoice.Size = New System.Drawing.Size(650, 284)
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
        Me.GrpReceipt.Size = New System.Drawing.Size(627, 394)
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
        Me.AddressCTextBox.TabIndex = 22
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
        Me.TinCustomerTextBox.TabIndex = 24
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
        Me.TinVendorTextBox.TabIndex = 23
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
        Me.BoxNoRI.TabIndex = 13
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
        Me.RackNoRI.TabIndex = 12
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
        Me.DocumentDateRI.TabIndex = 14
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
        Me.TotalValueRI.TabIndex = 20
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
        Me.ItemPurchasedTextBox.TabIndex = 25
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
        Me.CustomerTextBox.TabIndex = 21
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
        Me.VendorTextBox.TabIndex = 20
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
        Me.BookletNoTextBox.TabIndex = 16
        '
        'DTDocuRI
        '
        Me.DTDocuRI.Location = New System.Drawing.Point(263, 73)
        Me.DTDocuRI.Name = "DTDocuRI"
        Me.DTDocuRI.Size = New System.Drawing.Size(18, 22)
        Me.DTDocuRI.TabIndex = 15
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
        Me.ReferenceNoRI.TabIndex = 17
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
        Me.Warranty.Location = New System.Drawing.Point(4, 22)
        Me.Warranty.Name = "Warranty"
        Me.Warranty.Padding = New System.Windows.Forms.Padding(3)
        Me.Warranty.Size = New System.Drawing.Size(650, 284)
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
        Me.GrpWarranty.Size = New System.Drawing.Size(627, 414)
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
        Me.BoxNoWarranty.TabIndex = 13
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
        Me.RackNoWarranty.TabIndex = 12
        '
        'DTDatePurchased
        '
        Me.DTDatePurchased.Location = New System.Drawing.Point(255, 149)
        Me.DTDatePurchased.Name = "DTDatePurchased"
        Me.DTDatePurchased.Size = New System.Drawing.Size(18, 22)
        Me.DTDatePurchased.TabIndex = 18
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
        Me.EmailTextBox.TabIndex = 25
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
        Me.ContactNoTextBox.TabIndex = 24
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
        Me.AddressTextBox.TabIndex = 23
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
        Me.ServiceCenterTextBox.TabIndex = 22
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
        Me.WarrantyPeriodTextBox.TabIndex = 21
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
        Me.SerialTextBox.TabIndex = 16
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
        Me.TotalValueWarranty.TabIndex = 26
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
        Me.ReferenceNoTextBox1.TabIndex = 19
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
        Me.DatePurchasedTextBox.TabIndex = 17
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
        Me.ProductTypeTextBox.TabIndex = 15
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
        Me.ProductBrandTextBox.TabIndex = 14
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
        Me.WarrantyNoTextBox.TabIndex = 20
        '
        'Voucher
        '
        Me.Voucher.AutoScroll = True
        Me.Voucher.AutoScrollMinSize = New System.Drawing.Size(0, 500)
        Me.Voucher.BackColor = System.Drawing.SystemColors.Control
        Me.Voucher.Controls.Add(Me.GrpVoucher)
        Me.Voucher.Location = New System.Drawing.Point(4, 22)
        Me.Voucher.Name = "Voucher"
        Me.Voucher.Size = New System.Drawing.Size(650, 284)
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
        Me.GrpVoucher.Size = New System.Drawing.Size(633, 500)
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
        Me.DTDateReceived.TabIndex = 29
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
        Me.BoxNoVoucher.TabIndex = 13
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
        Me.RackNoVoucher.TabIndex = 12
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
        Me.DateReceivedTextBox.TabIndex = 28
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
        Me.PaymentFormComboBox.TabIndex = 19
        '
        'DTDocuVoucher
        '
        Me.DTDocuVoucher.Location = New System.Drawing.Point(259, 73)
        Me.DTDocuVoucher.Name = "DTDocuVoucher"
        Me.DTDocuVoucher.Size = New System.Drawing.Size(18, 22)
        Me.DTDocuVoucher.TabIndex = 15
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
        Me.ReceivedbyTextBox.TabIndex = 27
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
        Me.RecordedbyTextBox.TabIndex = 26
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
        Me.ApprovedbyTextBox.TabIndex = 25
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
        Me.PreparedbyTextBox.TabIndex = 24
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
        Me.PayorTextBox.TabIndex = 17
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
        Me.PayeeTextBox.TabIndex = 16
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
        Me.TotalValueVoucher.TabIndex = 23
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
        Me.VoucherNoTextBox.TabIndex = 18
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
        Me.DocumentDateVoucher.TabIndex = 14
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
        Me.TabControl3.TabIndex = 20
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
        Me.BankAddressTextBox.TabIndex = 22
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
        Me.BankBranchTextBox.TabIndex = 21
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
        Me.BankNameTextBox.TabIndex = 20
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
        Me.PaymentOthersTextBox.TabIndex = 20
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
        Me.CorpDocu.Location = New System.Drawing.Point(4, 22)
        Me.CorpDocu.Name = "CorpDocu"
        Me.CorpDocu.Size = New System.Drawing.Size(650, 284)
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
        Me.GrpCorp.Size = New System.Drawing.Size(633, 350)
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
        Me.TabControl4.Size = New System.Drawing.Size(633, 129)
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
        Me.TabMeeting.Size = New System.Drawing.Size(625, 100)
        Me.TabMeeting.TabIndex = 0
        Me.TabMeeting.Text = "Meeting"
        '
        'DTMeetingDate
        '
        Me.DTMeetingDate.Location = New System.Drawing.Point(255, 5)
        Me.DTMeetingDate.Name = "DTMeetingDate"
        Me.DTMeetingDate.Size = New System.Drawing.Size(18, 22)
        Me.DTMeetingDate.TabIndex = 17
        '
        'MeetingDateTextBox
        '
        Me.MeetingDateTextBox.BackColor = System.Drawing.Color.White
        Me.MeetingDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "MeetingDate", True))
        Me.MeetingDateTextBox.Location = New System.Drawing.Point(154, 5)
        Me.MeetingDateTextBox.Name = "MeetingDateTextBox"
        Me.MeetingDateTextBox.Size = New System.Drawing.Size(100, 22)
        Me.MeetingDateTextBox.TabIndex = 16
        Me.MeetingDateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SecretaryTextBox
        '
        Me.SecretaryTextBox.BackColor = System.Drawing.Color.White
        Me.SecretaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Secretary", True))
        Me.SecretaryTextBox.Location = New System.Drawing.Point(154, 51)
        Me.SecretaryTextBox.Name = "SecretaryTextBox"
        Me.SecretaryTextBox.Size = New System.Drawing.Size(229, 22)
        Me.SecretaryTextBox.TabIndex = 19
        '
        'CompanyTextBox
        '
        Me.CompanyTextBox.BackColor = System.Drawing.Color.White
        Me.CompanyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Company", True))
        Me.CompanyTextBox.Location = New System.Drawing.Point(154, 28)
        Me.CompanyTextBox.Name = "CompanyTextBox"
        Me.CompanyTextBox.Size = New System.Drawing.Size(374, 22)
        Me.CompanyTextBox.TabIndex = 18
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
        Me.TabPromo.Size = New System.Drawing.Size(625, 100)
        Me.TabPromo.TabIndex = 1
        Me.TabPromo.Text = "Promo"
        '
        'DTPromoTo
        '
        Me.DTPromoTo.Location = New System.Drawing.Point(255, 50)
        Me.DTPromoTo.Name = "DTPromoTo"
        Me.DTPromoTo.Size = New System.Drawing.Size(18, 22)
        Me.DTPromoTo.TabIndex = 20
        '
        'DTPromoFrom
        '
        Me.DTPromoFrom.Location = New System.Drawing.Point(255, 28)
        Me.DTPromoFrom.Name = "DTPromoFrom"
        Me.DTPromoFrom.Size = New System.Drawing.Size(18, 22)
        Me.DTPromoFrom.TabIndex = 18
        '
        'DTIPermitNoTextBox
        '
        Me.DTIPermitNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "DTIPermitNo", True))
        Me.DTIPermitNoTextBox.Location = New System.Drawing.Point(154, 73)
        Me.DTIPermitNoTextBox.Name = "DTIPermitNoTextBox"
        Me.DTIPermitNoTextBox.Size = New System.Drawing.Size(229, 22)
        Me.DTIPermitNoTextBox.TabIndex = 21
        '
        'PromoToTextBox
        '
        Me.PromoToTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "PromoTo", True))
        Me.PromoToTextBox.Location = New System.Drawing.Point(154, 50)
        Me.PromoToTextBox.Name = "PromoToTextBox"
        Me.PromoToTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PromoToTextBox.TabIndex = 19
        '
        'PromoFromTextBox
        '
        Me.PromoFromTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "PromoFrom", True))
        Me.PromoFromTextBox.Location = New System.Drawing.Point(154, 27)
        Me.PromoFromTextBox.Name = "PromoFromTextBox"
        Me.PromoFromTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PromoFromTextBox.TabIndex = 17
        '
        'PromoTitleTextBox
        '
        Me.PromoTitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "PromoTitle", True))
        Me.PromoTitleTextBox.Location = New System.Drawing.Point(154, 4)
        Me.PromoTitleTextBox.Name = "PromoTitleTextBox"
        Me.PromoTitleTextBox.Size = New System.Drawing.Size(344, 22)
        Me.PromoTitleTextBox.TabIndex = 16
        '
        'TabMeeting2
        '
        Me.TabMeeting2.BackColor = System.Drawing.Color.Azure
        Me.TabMeeting2.Controls.Add(Me.Label35)
        Me.TabMeeting2.Controls.Add(Me.TextBox1)
        Me.TabMeeting2.Location = New System.Drawing.Point(4, 25)
        Me.TabMeeting2.Name = "TabMeeting2"
        Me.TabMeeting2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMeeting2.Size = New System.Drawing.Size(625, 100)
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
        Me.TextBox1.TabIndex = 16
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
        Me.BoxNoCorpDocu.TabIndex = 13
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
        Me.RackNoCorpDocu.TabIndex = 12
        '
        'DTDocuCorp
        '
        Me.DTDocuCorp.Location = New System.Drawing.Point(259, 73)
        Me.DTDocuCorp.Name = "DTDocuCorp"
        Me.DTDocuCorp.Size = New System.Drawing.Size(18, 22)
        Me.DTDocuCorp.TabIndex = 15
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
        Me.PurposeTextBox.TabIndex = 22
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
        Me.DocumentDateCorp.TabIndex = 14
        Me.DocumentDateCorp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Importation
        '
        Me.Importation.AutoScroll = True
        Me.Importation.AutoScrollMinSize = New System.Drawing.Size(0, 600)
        Me.Importation.BackColor = System.Drawing.Color.Azure
        Me.Importation.Controls.Add(Me.GrpImportation)
        Me.Importation.Location = New System.Drawing.Point(4, 22)
        Me.Importation.Name = "Importation"
        Me.Importation.Size = New System.Drawing.Size(650, 284)
        Me.Importation.TabIndex = 5
        Me.Importation.Text = "Importation"
        '
        'GrpImportation
        '
        Me.GrpImportation.BackColor = System.Drawing.Color.Azure
        Me.GrpImportation.Controls.Add(Me.DateTimePicker1)
        Me.GrpImportation.Controls.Add(Label38)
        Me.GrpImportation.Controls.Add(Me.DTVesselImport)
        Me.GrpImportation.Controls.Add(PolicyNoLabel)
        Me.GrpImportation.Controls.Add(Me.PolicyNoImport)
        Me.GrpImportation.Controls.Add(InsuranceCompanyLabel)
        Me.GrpImportation.Controls.Add(Me.InsuranceCompanyImport)
        Me.GrpImportation.Controls.Add(RegNoLabel)
        Me.GrpImportation.Controls.Add(Me.RegNoImport)
        Me.GrpImportation.Controls.Add(CustomsNoLabel)
        Me.GrpImportation.Controls.Add(Me.CustomsNoImport)
        Me.GrpImportation.Controls.Add(BrokeCompanyLabel)
        Me.GrpImportation.Controls.Add(Me.BrokeCompanyImport)
        Me.GrpImportation.Controls.Add(PaymentFormLabel1)
        Me.GrpImportation.Controls.Add(Me.PaymentFormImport)
        Me.GrpImportation.Controls.Add(Me.TabControl5)
        Me.GrpImportation.Controls.Add(BankBranchLabel1)
        Me.GrpImportation.Controls.Add(Me.BankBranchImport)
        Me.GrpImportation.Controls.Add(BankNameLabel1)
        Me.GrpImportation.Controls.Add(Me.BankNameImport)
        Me.GrpImportation.Controls.Add(VesselArrivedLabel)
        Me.GrpImportation.Controls.Add(Me.VesselArrivedImport)
        Me.GrpImportation.Controls.Add(ContQtyx20Label)
        Me.GrpImportation.Controls.Add(Me.ContQtyx20Import)
        Me.GrpImportation.Controls.Add(ContQtyx40Label)
        Me.GrpImportation.Controls.Add(Me.ContQtyx40Import)
        Me.GrpImportation.Controls.Add(BillNoLabel)
        Me.GrpImportation.Controls.Add(Me.BillNoImport)
        Me.GrpImportation.Controls.Add(ShipLineLabel)
        Me.GrpImportation.Controls.Add(Me.ShipLineImport)
        Me.GrpImportation.Controls.Add(CargoDescLabel)
        Me.GrpImportation.Controls.Add(Me.CargoDescImport)
        Me.GrpImportation.Controls.Add(ShipBatchLabel)
        Me.GrpImportation.Controls.Add(Me.ShipBatchImport)
        Me.GrpImportation.Controls.Add(PRONoLabel)
        Me.GrpImportation.Controls.Add(Me.PRONoImport)
        Me.GrpImportation.Controls.Add(ISRNoLabel)
        Me.GrpImportation.Controls.Add(Me.ISRNoImport)
        Me.GrpImportation.Controls.Add(CountryLabel)
        Me.GrpImportation.Controls.Add(Me.CountryImport)
        Me.GrpImportation.Controls.Add(CompanyLabel1)
        Me.GrpImportation.Controls.Add(Me.CompanyImport)
        Me.GrpImportation.Controls.Add(ImportMonthLabel)
        Me.GrpImportation.Controls.Add(Me.ImpMonthImport)
        Me.GrpImportation.Controls.Add(Label39)
        Me.GrpImportation.Controls.Add(Me.BoxNoImport)
        Me.GrpImportation.Controls.Add(Label40)
        Me.GrpImportation.Controls.Add(Me.RackNoImport)
        Me.GrpImportation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpImportation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpImportation.ForeColor = System.Drawing.Color.Black
        Me.GrpImportation.Location = New System.Drawing.Point(0, 0)
        Me.GrpImportation.Name = "GrpImportation"
        Me.GrpImportation.Size = New System.Drawing.Size(633, 600)
        Me.GrpImportation.TabIndex = 3
        Me.GrpImportation.TabStop = False
        Me.GrpImportation.Text = "Keywords"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MMMM yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(275, 72)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(18, 22)
        Me.DateTimePicker1.TabIndex = 15
        '
        'DTVesselImport
        '
        Me.DTVesselImport.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTVesselImport.Location = New System.Drawing.Point(271, 327)
        Me.DTVesselImport.Name = "DTVesselImport"
        Me.DTVesselImport.Size = New System.Drawing.Size(18, 22)
        Me.DTVesselImport.TabIndex = 27
        '
        'PolicyNoImport
        '
        Me.PolicyNoImport.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "PolicyNo", True))
        Me.PolicyNoImport.Location = New System.Drawing.Point(170, 561)
        Me.PolicyNoImport.Name = "PolicyNoImport"
        Me.PolicyNoImport.Size = New System.Drawing.Size(217, 22)
        Me.PolicyNoImport.TabIndex = 38
        '
        'InsuranceCompanyImport
        '
        Me.InsuranceCompanyImport.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "InsuranceCompany", True))
        Me.InsuranceCompanyImport.Location = New System.Drawing.Point(170, 537)
        Me.InsuranceCompanyImport.Name = "InsuranceCompanyImport"
        Me.InsuranceCompanyImport.Size = New System.Drawing.Size(449, 22)
        Me.InsuranceCompanyImport.TabIndex = 37
        '
        'RegNoImport
        '
        Me.RegNoImport.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "RegNo", True))
        Me.RegNoImport.Location = New System.Drawing.Point(170, 514)
        Me.RegNoImport.Name = "RegNoImport"
        Me.RegNoImport.Size = New System.Drawing.Size(217, 22)
        Me.RegNoImport.TabIndex = 36
        '
        'CustomsNoImport
        '
        Me.CustomsNoImport.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "CustomsNo", True))
        Me.CustomsNoImport.Location = New System.Drawing.Point(170, 491)
        Me.CustomsNoImport.Name = "CustomsNoImport"
        Me.CustomsNoImport.Size = New System.Drawing.Size(217, 22)
        Me.CustomsNoImport.TabIndex = 35
        '
        'BrokeCompanyImport
        '
        Me.BrokeCompanyImport.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BrokeCompany", True))
        Me.BrokeCompanyImport.Location = New System.Drawing.Point(170, 467)
        Me.BrokeCompanyImport.Name = "BrokeCompanyImport"
        Me.BrokeCompanyImport.Size = New System.Drawing.Size(449, 22)
        Me.BrokeCompanyImport.TabIndex = 34
        '
        'PaymentFormImport
        '
        Me.PaymentFormImport.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "PaymentForm", True))
        Me.PaymentFormImport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PaymentFormImport.FormattingEnabled = True
        Me.PaymentFormImport.Location = New System.Drawing.Point(170, 397)
        Me.PaymentFormImport.Name = "PaymentFormImport"
        Me.PaymentFormImport.Size = New System.Drawing.Size(217, 24)
        Me.PaymentFormImport.TabIndex = 30
        '
        'TabControl5
        '
        Me.TabControl5.Controls.Add(Me.LCNo)
        Me.TabControl5.Controls.Add(Me.DPNo)
        Me.TabControl5.Controls.Add(Me.OthersImport)
        Me.TabControl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl5.Location = New System.Drawing.Point(6, 417)
        Me.TabControl5.Name = "TabControl5"
        Me.TabControl5.SelectedIndex = 0
        Me.TabControl5.Size = New System.Drawing.Size(613, 51)
        Me.TabControl5.TabIndex = 48
        '
        'LCNo
        '
        Me.LCNo.AutoScroll = True
        Me.LCNo.BackColor = System.Drawing.Color.Azure
        Me.LCNo.Controls.Add(LetterCreditLabel)
        Me.LCNo.Controls.Add(Me.LetterCreditImport)
        Me.LCNo.Location = New System.Drawing.Point(4, 22)
        Me.LCNo.Name = "LCNo"
        Me.LCNo.Padding = New System.Windows.Forms.Padding(3)
        Me.LCNo.Size = New System.Drawing.Size(605, 25)
        Me.LCNo.TabIndex = 0
        Me.LCNo.Text = "LCNo"
        '
        'LetterCreditImport
        '
        Me.LetterCreditImport.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "LetterCredit", True))
        Me.LetterCreditImport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.LetterCreditImport.Location = New System.Drawing.Point(160, 0)
        Me.LetterCreditImport.Name = "LetterCreditImport"
        Me.LetterCreditImport.Size = New System.Drawing.Size(217, 22)
        Me.LetterCreditImport.TabIndex = 31
        '
        'DPNo
        '
        Me.DPNo.AutoScroll = True
        Me.DPNo.BackColor = System.Drawing.Color.Azure
        Me.DPNo.Controls.Add(DPNoLabel)
        Me.DPNo.Controls.Add(Me.DPNoImport)
        Me.DPNo.Location = New System.Drawing.Point(4, 22)
        Me.DPNo.Name = "DPNo"
        Me.DPNo.Padding = New System.Windows.Forms.Padding(3)
        Me.DPNo.Size = New System.Drawing.Size(605, 25)
        Me.DPNo.TabIndex = 1
        Me.DPNo.Text = "DPNo"
        '
        'DPNoImport
        '
        Me.DPNoImport.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "DPNo", True))
        Me.DPNoImport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.DPNoImport.Location = New System.Drawing.Point(160, 1)
        Me.DPNoImport.Name = "DPNoImport"
        Me.DPNoImport.Size = New System.Drawing.Size(217, 22)
        Me.DPNoImport.TabIndex = 32
        '
        'OthersImport
        '
        Me.OthersImport.BackColor = System.Drawing.Color.Azure
        Me.OthersImport.Controls.Add(PaymentOthersLabel1)
        Me.OthersImport.Controls.Add(Me.PaymentOthersImport)
        Me.OthersImport.Location = New System.Drawing.Point(4, 22)
        Me.OthersImport.Name = "OthersImport"
        Me.OthersImport.Padding = New System.Windows.Forms.Padding(3)
        Me.OthersImport.Size = New System.Drawing.Size(605, 25)
        Me.OthersImport.TabIndex = 2
        Me.OthersImport.Text = "OthersImport"
        '
        'PaymentOthersImport
        '
        Me.PaymentOthersImport.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "PaymentOthers", True))
        Me.PaymentOthersImport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.PaymentOthersImport.Location = New System.Drawing.Point(160, 2)
        Me.PaymentOthersImport.Name = "PaymentOthersImport"
        Me.PaymentOthersImport.Size = New System.Drawing.Size(217, 22)
        Me.PaymentOthersImport.TabIndex = 33
        '
        'BankBranchImport
        '
        Me.BankBranchImport.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BankBranch", True))
        Me.BankBranchImport.Location = New System.Drawing.Point(170, 373)
        Me.BankBranchImport.Name = "BankBranchImport"
        Me.BankBranchImport.Size = New System.Drawing.Size(449, 22)
        Me.BankBranchImport.TabIndex = 29
        '
        'BankNameImport
        '
        Me.BankNameImport.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BankName", True))
        Me.BankNameImport.Location = New System.Drawing.Point(170, 350)
        Me.BankNameImport.Name = "BankNameImport"
        Me.BankNameImport.Size = New System.Drawing.Size(449, 22)
        Me.BankNameImport.TabIndex = 28
        '
        'VesselArrivedImport
        '
        Me.VesselArrivedImport.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "VesselArrived", True))
        Me.VesselArrivedImport.Location = New System.Drawing.Point(170, 327)
        Me.VesselArrivedImport.Name = "VesselArrivedImport"
        Me.VesselArrivedImport.Size = New System.Drawing.Size(100, 22)
        Me.VesselArrivedImport.TabIndex = 26
        '
        'ContQtyx20Import
        '
        Me.ContQtyx20Import.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ContQtyx20", True))
        Me.ContQtyx20Import.Location = New System.Drawing.Point(170, 304)
        Me.ContQtyx20Import.Name = "ContQtyx20Import"
        Me.ContQtyx20Import.Size = New System.Drawing.Size(123, 22)
        Me.ContQtyx20Import.TabIndex = 25
        '
        'ContQtyx40Import
        '
        Me.ContQtyx40Import.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ContQtyx40", True))
        Me.ContQtyx40Import.Location = New System.Drawing.Point(170, 281)
        Me.ContQtyx40Import.Name = "ContQtyx40Import"
        Me.ContQtyx40Import.Size = New System.Drawing.Size(123, 22)
        Me.ContQtyx40Import.TabIndex = 24
        '
        'BillNoImport
        '
        Me.BillNoImport.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BillNo", True))
        Me.BillNoImport.Location = New System.Drawing.Point(213, 258)
        Me.BillNoImport.Name = "BillNoImport"
        Me.BillNoImport.Size = New System.Drawing.Size(123, 22)
        Me.BillNoImport.TabIndex = 23
        '
        'ShipLineImport
        '
        Me.ShipLineImport.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ShipLine", True))
        Me.ShipLineImport.Location = New System.Drawing.Point(170, 235)
        Me.ShipLineImport.Name = "ShipLineImport"
        Me.ShipLineImport.Size = New System.Drawing.Size(449, 22)
        Me.ShipLineImport.TabIndex = 22
        '
        'CargoDescImport
        '
        Me.CargoDescImport.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "CargoDesc", True))
        Me.CargoDescImport.Location = New System.Drawing.Point(170, 212)
        Me.CargoDescImport.Name = "CargoDescImport"
        Me.CargoDescImport.Size = New System.Drawing.Size(449, 22)
        Me.CargoDescImport.TabIndex = 21
        '
        'ShipBatchImport
        '
        Me.ShipBatchImport.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ShipBatch", True))
        Me.ShipBatchImport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ShipBatchImport.FormattingEnabled = True
        Me.ShipBatchImport.Location = New System.Drawing.Point(170, 187)
        Me.ShipBatchImport.Name = "ShipBatchImport"
        Me.ShipBatchImport.Size = New System.Drawing.Size(166, 24)
        Me.ShipBatchImport.TabIndex = 20
        '
        'PRONoImport
        '
        Me.PRONoImport.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "PRONo", True))
        Me.PRONoImport.Location = New System.Drawing.Point(170, 164)
        Me.PRONoImport.Name = "PRONoImport"
        Me.PRONoImport.Size = New System.Drawing.Size(166, 22)
        Me.PRONoImport.TabIndex = 19
        '
        'ISRNoImport
        '
        Me.ISRNoImport.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ISRNo", True))
        Me.ISRNoImport.Location = New System.Drawing.Point(170, 141)
        Me.ISRNoImport.Name = "ISRNoImport"
        Me.ISRNoImport.Size = New System.Drawing.Size(166, 22)
        Me.ISRNoImport.TabIndex = 18
        '
        'CountryImport
        '
        Me.CountryImport.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Country", True))
        Me.CountryImport.Location = New System.Drawing.Point(170, 118)
        Me.CountryImport.Name = "CountryImport"
        Me.CountryImport.Size = New System.Drawing.Size(246, 22)
        Me.CountryImport.TabIndex = 17
        '
        'CompanyImport
        '
        Me.CompanyImport.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Company", True))
        Me.CompanyImport.Location = New System.Drawing.Point(170, 95)
        Me.CompanyImport.Name = "CompanyImport"
        Me.CompanyImport.Size = New System.Drawing.Size(449, 22)
        Me.CompanyImport.TabIndex = 16
        '
        'ImpMonthImport
        '
        Me.ImpMonthImport.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ImportMonth", True))
        Me.ImpMonthImport.Location = New System.Drawing.Point(170, 72)
        Me.ImpMonthImport.Name = "ImpMonthImport"
        Me.ImpMonthImport.Size = New System.Drawing.Size(104, 22)
        Me.ImpMonthImport.TabIndex = 14
        '
        'BoxNoImport
        '
        Me.BoxNoImport.BackColor = System.Drawing.Color.White
        Me.BoxNoImport.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BoxNo", True))
        Me.BoxNoImport.Location = New System.Drawing.Point(170, 50)
        Me.BoxNoImport.Name = "BoxNoImport"
        Me.BoxNoImport.Size = New System.Drawing.Size(123, 22)
        Me.BoxNoImport.TabIndex = 13
        '
        'RackNoImport
        '
        Me.RackNoImport.BackColor = System.Drawing.Color.White
        Me.RackNoImport.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "RackNo", True))
        Me.RackNoImport.Location = New System.Drawing.Point(170, 27)
        Me.RackNoImport.Name = "RackNoImport"
        Me.RackNoImport.Size = New System.Drawing.Size(123, 22)
        Me.RackNoImport.TabIndex = 12
        '
        'BIR
        '
        Me.BIR.BackColor = System.Drawing.Color.Azure
        Me.BIR.Controls.Add(Me.GrpBIR)
        Me.BIR.Location = New System.Drawing.Point(4, 22)
        Me.BIR.Name = "BIR"
        Me.BIR.Size = New System.Drawing.Size(650, 284)
        Me.BIR.TabIndex = 6
        Me.BIR.Text = "BIR"
        '
        'GrpBIR
        '
        Me.GrpBIR.BackColor = System.Drawing.Color.Azure
        Me.GrpBIR.Controls.Add(AddressCLabel1)
        Me.GrpBIR.Controls.Add(Me.AddressCBIR)
        Me.GrpBIR.Controls.Add(YearReportLabel)
        Me.GrpBIR.Controls.Add(Me.YearReportBIR)
        Me.GrpBIR.Controls.Add(TinVendorLabel1)
        Me.GrpBIR.Controls.Add(Me.TinVendorBIR)
        Me.GrpBIR.Controls.Add(TinCustomerLabel1)
        Me.GrpBIR.Controls.Add(Me.TinCustomerBIR)
        Me.GrpBIR.Controls.Add(AddressLabel1)
        Me.GrpBIR.Controls.Add(Me.AddressBIR)
        Me.GrpBIR.Controls.Add(CompanyLabel2)
        Me.GrpBIR.Controls.Add(Me.CompanyBIR)
        Me.GrpBIR.Controls.Add(Label41)
        Me.GrpBIR.Controls.Add(Label42)
        Me.GrpBIR.Controls.Add(Me.BoxNoBIR)
        Me.GrpBIR.Controls.Add(Label43)
        Me.GrpBIR.Controls.Add(Me.RackNoBIR)
        Me.GrpBIR.Controls.Add(Me.DTDocuBIR)
        Me.GrpBIR.Controls.Add(Label44)
        Me.GrpBIR.Controls.Add(Me.DocumentDateBIR)
        Me.GrpBIR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpBIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBIR.ForeColor = System.Drawing.Color.Black
        Me.GrpBIR.Location = New System.Drawing.Point(0, 0)
        Me.GrpBIR.Name = "GrpBIR"
        Me.GrpBIR.Size = New System.Drawing.Size(650, 284)
        Me.GrpBIR.TabIndex = 3
        Me.GrpBIR.TabStop = False
        Me.GrpBIR.Text = "Keywords"
        '
        'AddressCBIR
        '
        Me.AddressCBIR.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "AddressC", True))
        Me.AddressCBIR.Location = New System.Drawing.Point(158, 127)
        Me.AddressCBIR.Name = "AddressCBIR"
        Me.AddressCBIR.Size = New System.Drawing.Size(464, 22)
        Me.AddressCBIR.TabIndex = 17
        '
        'YearReportBIR
        '
        Me.YearReportBIR.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "YearReport", True))
        Me.YearReportBIR.Location = New System.Drawing.Point(158, 239)
        Me.YearReportBIR.Name = "YearReportBIR"
        Me.YearReportBIR.Size = New System.Drawing.Size(122, 22)
        Me.YearReportBIR.TabIndex = 21
        '
        'TinVendorBIR
        '
        Me.TinVendorBIR.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "TinVendor", True))
        Me.TinVendorBIR.Location = New System.Drawing.Point(158, 211)
        Me.TinVendorBIR.Name = "TinVendorBIR"
        Me.TinVendorBIR.Size = New System.Drawing.Size(220, 22)
        Me.TinVendorBIR.TabIndex = 20
        '
        'TinCustomerBIR
        '
        Me.TinCustomerBIR.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "TinCustomer", True))
        Me.TinCustomerBIR.Location = New System.Drawing.Point(158, 150)
        Me.TinCustomerBIR.Name = "TinCustomerBIR"
        Me.TinCustomerBIR.Size = New System.Drawing.Size(220, 22)
        Me.TinCustomerBIR.TabIndex = 18
        '
        'AddressBIR
        '
        Me.AddressBIR.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Address", True))
        Me.AddressBIR.Location = New System.Drawing.Point(158, 188)
        Me.AddressBIR.Name = "AddressBIR"
        Me.AddressBIR.Size = New System.Drawing.Size(464, 22)
        Me.AddressBIR.TabIndex = 19
        '
        'CompanyBIR
        '
        Me.CompanyBIR.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Company", True))
        Me.CompanyBIR.Location = New System.Drawing.Point(158, 104)
        Me.CompanyBIR.Name = "CompanyBIR"
        Me.CompanyBIR.Size = New System.Drawing.Size(464, 22)
        Me.CompanyBIR.TabIndex = 16
        '
        'BoxNoBIR
        '
        Me.BoxNoBIR.BackColor = System.Drawing.Color.White
        Me.BoxNoBIR.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BoxNo", True))
        Me.BoxNoBIR.Location = New System.Drawing.Point(158, 50)
        Me.BoxNoBIR.Name = "BoxNoBIR"
        Me.BoxNoBIR.Size = New System.Drawing.Size(123, 22)
        Me.BoxNoBIR.TabIndex = 13
        '
        'RackNoBIR
        '
        Me.RackNoBIR.BackColor = System.Drawing.Color.White
        Me.RackNoBIR.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "RackNo", True))
        Me.RackNoBIR.Location = New System.Drawing.Point(158, 27)
        Me.RackNoBIR.Name = "RackNoBIR"
        Me.RackNoBIR.Size = New System.Drawing.Size(123, 22)
        Me.RackNoBIR.TabIndex = 12
        '
        'DTDocuBIR
        '
        Me.DTDocuBIR.Location = New System.Drawing.Point(259, 73)
        Me.DTDocuBIR.Name = "DTDocuBIR"
        Me.DTDocuBIR.Size = New System.Drawing.Size(18, 22)
        Me.DTDocuBIR.TabIndex = 15
        '
        'DocumentDateBIR
        '
        Me.DocumentDateBIR.BackColor = System.Drawing.Color.White
        Me.DocumentDateBIR.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "DocumentDate", True))
        Me.DocumentDateBIR.Location = New System.Drawing.Point(158, 73)
        Me.DocumentDateBIR.Name = "DocumentDateBIR"
        Me.DocumentDateBIR.Size = New System.Drawing.Size(100, 22)
        Me.DocumentDateBIR.TabIndex = 14
        Me.DocumentDateBIR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HRDoc
        '
        Me.HRDoc.BackColor = System.Drawing.Color.Azure
        Me.HRDoc.Controls.Add(Me.GrpHRDoc)
        Me.HRDoc.Location = New System.Drawing.Point(4, 22)
        Me.HRDoc.Name = "HRDoc"
        Me.HRDoc.Size = New System.Drawing.Size(650, 284)
        Me.HRDoc.TabIndex = 7
        Me.HRDoc.Text = "HRDoc"
        '
        'GrpHRDoc
        '
        Me.GrpHRDoc.BackColor = System.Drawing.Color.Azure
        Me.GrpHRDoc.Controls.Add(SexLabel)
        Me.GrpHRDoc.Controls.Add(Me.SexHRDoc)
        Me.GrpHRDoc.Controls.Add(LastNameLabel1)
        Me.GrpHRDoc.Controls.Add(Me.LastNameHRDoc)
        Me.GrpHRDoc.Controls.Add(MiddleNameLabel1)
        Me.GrpHRDoc.Controls.Add(Me.MiddleNameHRDoc)
        Me.GrpHRDoc.Controls.Add(FirstNameLabel1)
        Me.GrpHRDoc.Controls.Add(Me.FirstNameHRDoc)
        Me.GrpHRDoc.Controls.Add(CompanyLabel3)
        Me.GrpHRDoc.Controls.Add(Me.CompanyHRDoc)
        Me.GrpHRDoc.Controls.Add(Label45)
        Me.GrpHRDoc.Controls.Add(Label46)
        Me.GrpHRDoc.Controls.Add(Me.BoxNoHRDoc)
        Me.GrpHRDoc.Controls.Add(Label47)
        Me.GrpHRDoc.Controls.Add(Me.RackNoHRDoc)
        Me.GrpHRDoc.Controls.Add(Me.DTDocuHRDoc)
        Me.GrpHRDoc.Controls.Add(Label48)
        Me.GrpHRDoc.Controls.Add(Me.DocumentDateHRDoc)
        Me.GrpHRDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpHRDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpHRDoc.ForeColor = System.Drawing.Color.Black
        Me.GrpHRDoc.Location = New System.Drawing.Point(0, 0)
        Me.GrpHRDoc.Name = "GrpHRDoc"
        Me.GrpHRDoc.Size = New System.Drawing.Size(650, 284)
        Me.GrpHRDoc.TabIndex = 3
        Me.GrpHRDoc.TabStop = False
        Me.GrpHRDoc.Text = "Keywords"
        '
        'SexHRDoc
        '
        Me.SexHRDoc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Sex", True))
        Me.SexHRDoc.Location = New System.Drawing.Point(158, 204)
        Me.SexHRDoc.Name = "SexHRDoc"
        Me.SexHRDoc.Size = New System.Drawing.Size(100, 22)
        Me.SexHRDoc.TabIndex = 20
        '
        'LastNameHRDoc
        '
        Me.LastNameHRDoc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "LastName", True))
        Me.LastNameHRDoc.Location = New System.Drawing.Point(158, 181)
        Me.LastNameHRDoc.Name = "LastNameHRDoc"
        Me.LastNameHRDoc.Size = New System.Drawing.Size(464, 22)
        Me.LastNameHRDoc.TabIndex = 19
        '
        'MiddleNameHRDoc
        '
        Me.MiddleNameHRDoc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "MiddleName", True))
        Me.MiddleNameHRDoc.Location = New System.Drawing.Point(158, 158)
        Me.MiddleNameHRDoc.Name = "MiddleNameHRDoc"
        Me.MiddleNameHRDoc.Size = New System.Drawing.Size(464, 22)
        Me.MiddleNameHRDoc.TabIndex = 18
        '
        'FirstNameHRDoc
        '
        Me.FirstNameHRDoc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "FirstName", True))
        Me.FirstNameHRDoc.Location = New System.Drawing.Point(158, 135)
        Me.FirstNameHRDoc.Name = "FirstNameHRDoc"
        Me.FirstNameHRDoc.Size = New System.Drawing.Size(464, 22)
        Me.FirstNameHRDoc.TabIndex = 17
        '
        'CompanyHRDoc
        '
        Me.CompanyHRDoc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Company", True))
        Me.CompanyHRDoc.Location = New System.Drawing.Point(158, 111)
        Me.CompanyHRDoc.Name = "CompanyHRDoc"
        Me.CompanyHRDoc.Size = New System.Drawing.Size(464, 22)
        Me.CompanyHRDoc.TabIndex = 16
        '
        'BoxNoHRDoc
        '
        Me.BoxNoHRDoc.BackColor = System.Drawing.Color.White
        Me.BoxNoHRDoc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BoxNo", True))
        Me.BoxNoHRDoc.Location = New System.Drawing.Point(158, 50)
        Me.BoxNoHRDoc.Name = "BoxNoHRDoc"
        Me.BoxNoHRDoc.Size = New System.Drawing.Size(123, 22)
        Me.BoxNoHRDoc.TabIndex = 13
        '
        'RackNoHRDoc
        '
        Me.RackNoHRDoc.BackColor = System.Drawing.Color.White
        Me.RackNoHRDoc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "RackNo", True))
        Me.RackNoHRDoc.Location = New System.Drawing.Point(158, 27)
        Me.RackNoHRDoc.Name = "RackNoHRDoc"
        Me.RackNoHRDoc.Size = New System.Drawing.Size(123, 22)
        Me.RackNoHRDoc.TabIndex = 12
        '
        'DTDocuHRDoc
        '
        Me.DTDocuHRDoc.Location = New System.Drawing.Point(259, 73)
        Me.DTDocuHRDoc.Name = "DTDocuHRDoc"
        Me.DTDocuHRDoc.Size = New System.Drawing.Size(18, 22)
        Me.DTDocuHRDoc.TabIndex = 15
        '
        'DocumentDateHRDoc
        '
        Me.DocumentDateHRDoc.BackColor = System.Drawing.Color.White
        Me.DocumentDateHRDoc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "DocumentDate", True))
        Me.DocumentDateHRDoc.Location = New System.Drawing.Point(158, 73)
        Me.DocumentDateHRDoc.Name = "DocumentDateHRDoc"
        Me.DocumentDateHRDoc.Size = New System.Drawing.Size(100, 22)
        Me.DocumentDateHRDoc.TabIndex = 14
        Me.DocumentDateHRDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Copyright
        '
        Me.Copyright.BackColor = System.Drawing.Color.Azure
        Me.Copyright.Controls.Add(Me.GrpCopy)
        Me.Copyright.Location = New System.Drawing.Point(4, 22)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(650, 284)
        Me.Copyright.TabIndex = 8
        Me.Copyright.Text = "Copyright"
        '
        'GrpCopy
        '
        Me.GrpCopy.BackColor = System.Drawing.Color.Azure
        Me.GrpCopy.Controls.Add(Label49)
        Me.GrpCopy.Controls.Add(Me.DTCreateDate)
        Me.GrpCopy.Controls.Add(PeriodProtectLabel)
        Me.GrpCopy.Controls.Add(Me.PeriodProtectCopy)
        Me.GrpCopy.Controls.Add(CreationDateLabel)
        Me.GrpCopy.Controls.Add(Me.CreationDateCopy)
        Me.GrpCopy.Controls.Add(ClassLabel)
        Me.GrpCopy.Controls.Add(Me.ClassCopy)
        Me.GrpCopy.Controls.Add(AuthorLabel)
        Me.GrpCopy.Controls.Add(Me.AuthorCopy)
        Me.GrpCopy.Controls.Add(TitleLabel)
        Me.GrpCopy.Controls.Add(Me.TitleCopy)
        Me.GrpCopy.Controls.Add(RegNoLabel1)
        Me.GrpCopy.Controls.Add(Me.RegNoCopy)
        Me.GrpCopy.Controls.Add(Label51)
        Me.GrpCopy.Controls.Add(Me.BoxNoCopy)
        Me.GrpCopy.Controls.Add(Label52)
        Me.GrpCopy.Controls.Add(Me.RackNoCopy)
        Me.GrpCopy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpCopy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpCopy.ForeColor = System.Drawing.Color.Black
        Me.GrpCopy.Location = New System.Drawing.Point(0, 0)
        Me.GrpCopy.Name = "GrpCopy"
        Me.GrpCopy.Size = New System.Drawing.Size(650, 284)
        Me.GrpCopy.TabIndex = 3
        Me.GrpCopy.TabStop = False
        Me.GrpCopy.Text = "Keywords"
        '
        'DTCreateDate
        '
        Me.DTCreateDate.Location = New System.Drawing.Point(257, 173)
        Me.DTCreateDate.Name = "DTCreateDate"
        Me.DTCreateDate.Size = New System.Drawing.Size(18, 22)
        Me.DTCreateDate.TabIndex = 19
        '
        'PeriodProtectCopy
        '
        Me.PeriodProtectCopy.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "PeriodProtect", True))
        Me.PeriodProtectCopy.Location = New System.Drawing.Point(156, 196)
        Me.PeriodProtectCopy.Name = "PeriodProtectCopy"
        Me.PeriodProtectCopy.Size = New System.Drawing.Size(243, 22)
        Me.PeriodProtectCopy.TabIndex = 20
        '
        'CreationDateCopy
        '
        Me.CreationDateCopy.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "CreationDate", True))
        Me.CreationDateCopy.Location = New System.Drawing.Point(156, 173)
        Me.CreationDateCopy.Name = "CreationDateCopy"
        Me.CreationDateCopy.Size = New System.Drawing.Size(100, 22)
        Me.CreationDateCopy.TabIndex = 18
        '
        'ClassCopy
        '
        Me.ClassCopy.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Class", True))
        Me.ClassCopy.Location = New System.Drawing.Point(156, 149)
        Me.ClassCopy.Name = "ClassCopy"
        Me.ClassCopy.Size = New System.Drawing.Size(243, 22)
        Me.ClassCopy.TabIndex = 17
        '
        'AuthorCopy
        '
        Me.AuthorCopy.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Author", True))
        Me.AuthorCopy.Location = New System.Drawing.Point(156, 126)
        Me.AuthorCopy.Name = "AuthorCopy"
        Me.AuthorCopy.Size = New System.Drawing.Size(466, 22)
        Me.AuthorCopy.TabIndex = 16
        '
        'TitleCopy
        '
        Me.TitleCopy.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Title", True))
        Me.TitleCopy.Location = New System.Drawing.Point(156, 103)
        Me.TitleCopy.Name = "TitleCopy"
        Me.TitleCopy.Size = New System.Drawing.Size(466, 22)
        Me.TitleCopy.TabIndex = 15
        '
        'RegNoCopy
        '
        Me.RegNoCopy.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "RegNo", True))
        Me.RegNoCopy.Location = New System.Drawing.Point(157, 80)
        Me.RegNoCopy.Name = "RegNoCopy"
        Me.RegNoCopy.Size = New System.Drawing.Size(124, 22)
        Me.RegNoCopy.TabIndex = 14
        '
        'BoxNoCopy
        '
        Me.BoxNoCopy.BackColor = System.Drawing.Color.White
        Me.BoxNoCopy.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BoxNo", True))
        Me.BoxNoCopy.Location = New System.Drawing.Point(158, 50)
        Me.BoxNoCopy.Name = "BoxNoCopy"
        Me.BoxNoCopy.Size = New System.Drawing.Size(123, 22)
        Me.BoxNoCopy.TabIndex = 13
        '
        'RackNoCopy
        '
        Me.RackNoCopy.BackColor = System.Drawing.Color.White
        Me.RackNoCopy.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "RackNo", True))
        Me.RackNoCopy.Location = New System.Drawing.Point(158, 27)
        Me.RackNoCopy.Name = "RackNoCopy"
        Me.RackNoCopy.Size = New System.Drawing.Size(123, 22)
        Me.RackNoCopy.TabIndex = 12
        '
        'Trademark
        '
        Me.Trademark.BackColor = System.Drawing.Color.Azure
        Me.Trademark.Controls.Add(Me.GrpTrade)
        Me.Trademark.Location = New System.Drawing.Point(4, 22)
        Me.Trademark.Name = "Trademark"
        Me.Trademark.Size = New System.Drawing.Size(650, 284)
        Me.Trademark.TabIndex = 9
        Me.Trademark.Text = "Trademark"
        '
        'GrpTrade
        '
        Me.GrpTrade.BackColor = System.Drawing.Color.Azure
        Me.GrpTrade.Controls.Add(Label50)
        Me.GrpTrade.Controls.Add(Me.DTFilingTrade)
        Me.GrpTrade.Controls.Add(Label53)
        Me.GrpTrade.Controls.Add(Me.DTToTrade)
        Me.GrpTrade.Controls.Add(Label54)
        Me.GrpTrade.Controls.Add(Me.DTFromTrade)
        Me.GrpTrade.Controls.Add(Label55)
        Me.GrpTrade.Controls.Add(Me.DTRegDateTrade)
        Me.GrpTrade.Controls.Add(RegMarkLabel)
        Me.GrpTrade.Controls.Add(Me.RegMarkTrade)
        Me.GrpTrade.Controls.Add(RegistrantLabel)
        Me.GrpTrade.Controls.Add(Me.RegistrantTrade)
        Me.GrpTrade.Controls.Add(FilingDateLabel)
        Me.GrpTrade.Controls.Add(Me.FilingDateTrade)
        Me.GrpTrade.Controls.Add(ToPeriodLabel1)
        Me.GrpTrade.Controls.Add(Me.ToPeriodTrade)
        Me.GrpTrade.Controls.Add(FromPeriodLabel1)
        Me.GrpTrade.Controls.Add(Me.FromPeriodTrade)
        Me.GrpTrade.Controls.Add(TermLabel)
        Me.GrpTrade.Controls.Add(Me.TermTrade)
        Me.GrpTrade.Controls.Add(RegDateLabel)
        Me.GrpTrade.Controls.Add(Me.RegDateTrade)
        Me.GrpTrade.Controls.Add(RegNoLabel2)
        Me.GrpTrade.Controls.Add(Me.RegNoTrade)
        Me.GrpTrade.Controls.Add(Label56)
        Me.GrpTrade.Controls.Add(Me.BoxNoTrade)
        Me.GrpTrade.Controls.Add(Label57)
        Me.GrpTrade.Controls.Add(Me.RackNoTrade)
        Me.GrpTrade.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpTrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpTrade.ForeColor = System.Drawing.Color.Black
        Me.GrpTrade.Location = New System.Drawing.Point(0, 0)
        Me.GrpTrade.Name = "GrpTrade"
        Me.GrpTrade.Size = New System.Drawing.Size(650, 284)
        Me.GrpTrade.TabIndex = 3
        Me.GrpTrade.TabStop = False
        Me.GrpTrade.Text = "Keywords"
        '
        'DTFilingTrade
        '
        Me.DTFilingTrade.Location = New System.Drawing.Point(259, 203)
        Me.DTFilingTrade.Name = "DTFilingTrade"
        Me.DTFilingTrade.Size = New System.Drawing.Size(18, 22)
        Me.DTFilingTrade.TabIndex = 23
        '
        'DTToTrade
        '
        Me.DTToTrade.Location = New System.Drawing.Point(259, 175)
        Me.DTToTrade.Name = "DTToTrade"
        Me.DTToTrade.Size = New System.Drawing.Size(18, 22)
        Me.DTToTrade.TabIndex = 21
        '
        'DTFromTrade
        '
        Me.DTFromTrade.Location = New System.Drawing.Point(259, 152)
        Me.DTFromTrade.Name = "DTFromTrade"
        Me.DTFromTrade.Size = New System.Drawing.Size(18, 22)
        Me.DTFromTrade.TabIndex = 19
        '
        'DTRegDateTrade
        '
        Me.DTRegDateTrade.Location = New System.Drawing.Point(259, 101)
        Me.DTRegDateTrade.Name = "DTRegDateTrade"
        Me.DTRegDateTrade.Size = New System.Drawing.Size(18, 22)
        Me.DTRegDateTrade.TabIndex = 16
        '
        'RegMarkTrade
        '
        Me.RegMarkTrade.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "RegMark", True))
        Me.RegMarkTrade.Location = New System.Drawing.Point(158, 249)
        Me.RegMarkTrade.Name = "RegMarkTrade"
        Me.RegMarkTrade.Size = New System.Drawing.Size(464, 22)
        Me.RegMarkTrade.TabIndex = 25
        '
        'RegistrantTrade
        '
        Me.RegistrantTrade.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Registrant", True))
        Me.RegistrantTrade.Location = New System.Drawing.Point(158, 226)
        Me.RegistrantTrade.Name = "RegistrantTrade"
        Me.RegistrantTrade.Size = New System.Drawing.Size(464, 22)
        Me.RegistrantTrade.TabIndex = 24
        '
        'FilingDateTrade
        '
        Me.FilingDateTrade.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "FilingDate", True))
        Me.FilingDateTrade.Location = New System.Drawing.Point(158, 203)
        Me.FilingDateTrade.Name = "FilingDateTrade"
        Me.FilingDateTrade.Size = New System.Drawing.Size(100, 22)
        Me.FilingDateTrade.TabIndex = 22
        '
        'ToPeriodTrade
        '
        Me.ToPeriodTrade.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ToPeriod", True))
        Me.ToPeriodTrade.Location = New System.Drawing.Point(158, 175)
        Me.ToPeriodTrade.Name = "ToPeriodTrade"
        Me.ToPeriodTrade.Size = New System.Drawing.Size(100, 22)
        Me.ToPeriodTrade.TabIndex = 20
        '
        'FromPeriodTrade
        '
        Me.FromPeriodTrade.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "FromPeriod", True))
        Me.FromPeriodTrade.Location = New System.Drawing.Point(158, 152)
        Me.FromPeriodTrade.Name = "FromPeriodTrade"
        Me.FromPeriodTrade.Size = New System.Drawing.Size(100, 22)
        Me.FromPeriodTrade.TabIndex = 18
        '
        'TermTrade
        '
        Me.TermTrade.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Term", True))
        Me.TermTrade.Location = New System.Drawing.Point(158, 124)
        Me.TermTrade.Name = "TermTrade"
        Me.TermTrade.Size = New System.Drawing.Size(100, 22)
        Me.TermTrade.TabIndex = 17
        '
        'RegDateTrade
        '
        Me.RegDateTrade.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "RegDate", True))
        Me.RegDateTrade.Location = New System.Drawing.Point(158, 101)
        Me.RegDateTrade.Name = "RegDateTrade"
        Me.RegDateTrade.Size = New System.Drawing.Size(100, 22)
        Me.RegDateTrade.TabIndex = 15
        '
        'RegNoTrade
        '
        Me.RegNoTrade.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "RegNo", True))
        Me.RegNoTrade.Location = New System.Drawing.Point(158, 78)
        Me.RegNoTrade.Name = "RegNoTrade"
        Me.RegNoTrade.Size = New System.Drawing.Size(123, 22)
        Me.RegNoTrade.TabIndex = 14
        '
        'BoxNoTrade
        '
        Me.BoxNoTrade.BackColor = System.Drawing.Color.White
        Me.BoxNoTrade.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BoxNo", True))
        Me.BoxNoTrade.Location = New System.Drawing.Point(158, 50)
        Me.BoxNoTrade.Name = "BoxNoTrade"
        Me.BoxNoTrade.Size = New System.Drawing.Size(123, 22)
        Me.BoxNoTrade.TabIndex = 13
        '
        'RackNoTrade
        '
        Me.RackNoTrade.BackColor = System.Drawing.Color.White
        Me.RackNoTrade.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "RackNo", True))
        Me.RackNoTrade.Location = New System.Drawing.Point(158, 27)
        Me.RackNoTrade.Name = "RackNoTrade"
        Me.RackNoTrade.Size = New System.Drawing.Size(123, 22)
        Me.RackNoTrade.TabIndex = 12
        '
        'Patent
        '
        Me.Patent.BackColor = System.Drawing.Color.Azure
        Me.Patent.Controls.Add(Me.GrpPatent)
        Me.Patent.Location = New System.Drawing.Point(4, 22)
        Me.Patent.Name = "Patent"
        Me.Patent.Size = New System.Drawing.Size(650, 284)
        Me.Patent.TabIndex = 10
        Me.Patent.Text = "Patent"
        '
        'GrpPatent
        '
        Me.GrpPatent.BackColor = System.Drawing.Color.Azure
        Me.GrpPatent.Controls.Add(Label58)
        Me.GrpPatent.Controls.Add(Me.DTFilingPatent)
        Me.GrpPatent.Controls.Add(Label59)
        Me.GrpPatent.Controls.Add(Me.DTToPatent)
        Me.GrpPatent.Controls.Add(Label60)
        Me.GrpPatent.Controls.Add(Me.DTFromPatent)
        Me.GrpPatent.Controls.Add(Label61)
        Me.GrpPatent.Controls.Add(Me.DTRegDatePatent)
        Me.GrpPatent.Controls.Add(FilingDateLabel1)
        Me.GrpPatent.Controls.Add(Me.FilingDatePatent)
        Me.GrpPatent.Controls.Add(TitleLabel1)
        Me.GrpPatent.Controls.Add(Me.TitlePatent)
        Me.GrpPatent.Controls.Add(RegistrantLabel1)
        Me.GrpPatent.Controls.Add(Me.RegistrantPatent)
        Me.GrpPatent.Controls.Add(ToPeriodLabel2)
        Me.GrpPatent.Controls.Add(Me.ToPeriodPatent)
        Me.GrpPatent.Controls.Add(FromPeriodLabel2)
        Me.GrpPatent.Controls.Add(Me.FromPeriodPatent)
        Me.GrpPatent.Controls.Add(TermLabel1)
        Me.GrpPatent.Controls.Add(Me.TermPatent)
        Me.GrpPatent.Controls.Add(RegDateLabel1)
        Me.GrpPatent.Controls.Add(Me.RegDatePatent)
        Me.GrpPatent.Controls.Add(RegNoLabel3)
        Me.GrpPatent.Controls.Add(Me.RegNoPatent)
        Me.GrpPatent.Controls.Add(Label62)
        Me.GrpPatent.Controls.Add(Me.BoxNoPatent)
        Me.GrpPatent.Controls.Add(Label63)
        Me.GrpPatent.Controls.Add(Me.RackNoPatent)
        Me.GrpPatent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpPatent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpPatent.ForeColor = System.Drawing.Color.Black
        Me.GrpPatent.Location = New System.Drawing.Point(0, 0)
        Me.GrpPatent.Name = "GrpPatent"
        Me.GrpPatent.Size = New System.Drawing.Size(650, 284)
        Me.GrpPatent.TabIndex = 3
        Me.GrpPatent.TabStop = False
        Me.GrpPatent.Text = "Keywords"
        '
        'DTFilingPatent
        '
        Me.DTFilingPatent.Location = New System.Drawing.Point(259, 203)
        Me.DTFilingPatent.Name = "DTFilingPatent"
        Me.DTFilingPatent.Size = New System.Drawing.Size(18, 22)
        Me.DTFilingPatent.TabIndex = 23
        '
        'DTToPatent
        '
        Me.DTToPatent.Location = New System.Drawing.Point(259, 175)
        Me.DTToPatent.Name = "DTToPatent"
        Me.DTToPatent.Size = New System.Drawing.Size(18, 22)
        Me.DTToPatent.TabIndex = 21
        '
        'DTFromPatent
        '
        Me.DTFromPatent.Location = New System.Drawing.Point(259, 152)
        Me.DTFromPatent.Name = "DTFromPatent"
        Me.DTFromPatent.Size = New System.Drawing.Size(18, 22)
        Me.DTFromPatent.TabIndex = 19
        '
        'DTRegDatePatent
        '
        Me.DTRegDatePatent.Location = New System.Drawing.Point(259, 101)
        Me.DTRegDatePatent.Name = "DTRegDatePatent"
        Me.DTRegDatePatent.Size = New System.Drawing.Size(18, 22)
        Me.DTRegDatePatent.TabIndex = 16
        '
        'FilingDatePatent
        '
        Me.FilingDatePatent.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "FilingDate", True))
        Me.FilingDatePatent.Location = New System.Drawing.Point(158, 203)
        Me.FilingDatePatent.Name = "FilingDatePatent"
        Me.FilingDatePatent.Size = New System.Drawing.Size(100, 22)
        Me.FilingDatePatent.TabIndex = 22
        '
        'TitlePatent
        '
        Me.TitlePatent.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Title", True))
        Me.TitlePatent.Location = New System.Drawing.Point(158, 249)
        Me.TitlePatent.Name = "TitlePatent"
        Me.TitlePatent.Size = New System.Drawing.Size(464, 22)
        Me.TitlePatent.TabIndex = 25
        '
        'RegistrantPatent
        '
        Me.RegistrantPatent.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Registrant", True))
        Me.RegistrantPatent.Location = New System.Drawing.Point(158, 226)
        Me.RegistrantPatent.Name = "RegistrantPatent"
        Me.RegistrantPatent.Size = New System.Drawing.Size(464, 22)
        Me.RegistrantPatent.TabIndex = 24
        '
        'ToPeriodPatent
        '
        Me.ToPeriodPatent.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ToPeriod", True))
        Me.ToPeriodPatent.Location = New System.Drawing.Point(158, 175)
        Me.ToPeriodPatent.Name = "ToPeriodPatent"
        Me.ToPeriodPatent.Size = New System.Drawing.Size(100, 22)
        Me.ToPeriodPatent.TabIndex = 20
        '
        'FromPeriodPatent
        '
        Me.FromPeriodPatent.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "FromPeriod", True))
        Me.FromPeriodPatent.Location = New System.Drawing.Point(158, 152)
        Me.FromPeriodPatent.Name = "FromPeriodPatent"
        Me.FromPeriodPatent.Size = New System.Drawing.Size(100, 22)
        Me.FromPeriodPatent.TabIndex = 18
        '
        'TermPatent
        '
        Me.TermPatent.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Term", True))
        Me.TermPatent.Location = New System.Drawing.Point(158, 124)
        Me.TermPatent.Name = "TermPatent"
        Me.TermPatent.Size = New System.Drawing.Size(100, 22)
        Me.TermPatent.TabIndex = 17
        '
        'RegDatePatent
        '
        Me.RegDatePatent.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "RegDate", True))
        Me.RegDatePatent.Location = New System.Drawing.Point(158, 101)
        Me.RegDatePatent.Name = "RegDatePatent"
        Me.RegDatePatent.Size = New System.Drawing.Size(100, 22)
        Me.RegDatePatent.TabIndex = 15
        '
        'RegNoPatent
        '
        Me.RegNoPatent.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "RegNo", True))
        Me.RegNoPatent.Location = New System.Drawing.Point(158, 78)
        Me.RegNoPatent.Name = "RegNoPatent"
        Me.RegNoPatent.Size = New System.Drawing.Size(122, 22)
        Me.RegNoPatent.TabIndex = 14
        '
        'BoxNoPatent
        '
        Me.BoxNoPatent.BackColor = System.Drawing.Color.White
        Me.BoxNoPatent.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BoxNo", True))
        Me.BoxNoPatent.Location = New System.Drawing.Point(158, 50)
        Me.BoxNoPatent.Name = "BoxNoPatent"
        Me.BoxNoPatent.Size = New System.Drawing.Size(123, 22)
        Me.BoxNoPatent.TabIndex = 13
        '
        'RackNoPatent
        '
        Me.RackNoPatent.BackColor = System.Drawing.Color.White
        Me.RackNoPatent.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "RackNo", True))
        Me.RackNoPatent.Location = New System.Drawing.Point(158, 27)
        Me.RackNoPatent.Name = "RackNoPatent"
        Me.RackNoPatent.Size = New System.Drawing.Size(123, 22)
        Me.RackNoPatent.TabIndex = 12
        '
        'BIRClear
        '
        Me.BIRClear.BackColor = System.Drawing.Color.Azure
        Me.BIRClear.Controls.Add(Me.GrpClear)
        Me.BIRClear.Location = New System.Drawing.Point(4, 22)
        Me.BIRClear.Name = "BIRClear"
        Me.BIRClear.Size = New System.Drawing.Size(650, 284)
        Me.BIRClear.TabIndex = 11
        Me.BIRClear.Text = "BIRClear"
        '
        'GrpClear
        '
        Me.GrpClear.BackColor = System.Drawing.Color.Azure
        Me.GrpClear.Controls.Add(Label109)
        Me.GrpClear.Controls.Add(Label69)
        Me.GrpClear.Controls.Add(Me.DTToClear)
        Me.GrpClear.Controls.Add(Label64)
        Me.GrpClear.Controls.Add(Me.DTFromClear)
        Me.GrpClear.Controls.Add(Label65)
        Me.GrpClear.Controls.Add(Me.DTIssueDateClear)
        Me.GrpClear.Controls.Add(ToPeriodLabel3)
        Me.GrpClear.Controls.Add(Me.ToPeriodClear)
        Me.GrpClear.Controls.Add(FromPeriodLabel3)
        Me.GrpClear.Controls.Add(Me.FromPeriodClear)
        Me.GrpClear.Controls.Add(TermLabel2)
        Me.GrpClear.Controls.Add(Me.TermClear)
        Me.GrpClear.Controls.Add(AccreditNoLabel)
        Me.GrpClear.Controls.Add(Me.AccreditNoClear)
        Me.GrpClear.Controls.Add(IssueDateLabel)
        Me.GrpClear.Controls.Add(Me.IssueDateClear)
        Me.GrpClear.Controls.Add(TinCustomerLabel2)
        Me.GrpClear.Controls.Add(Me.TinCustomerClear)
        Me.GrpClear.Controls.Add(CompanyLabel4)
        Me.GrpClear.Controls.Add(Me.CompanyClear)
        Me.GrpClear.Controls.Add(Label66)
        Me.GrpClear.Controls.Add(Me.BoxNoClear)
        Me.GrpClear.Controls.Add(Label67)
        Me.GrpClear.Controls.Add(Me.RackNoClear)
        Me.GrpClear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpClear.ForeColor = System.Drawing.Color.Black
        Me.GrpClear.Location = New System.Drawing.Point(0, 0)
        Me.GrpClear.Name = "GrpClear"
        Me.GrpClear.Size = New System.Drawing.Size(650, 284)
        Me.GrpClear.TabIndex = 3
        Me.GrpClear.TabStop = False
        Me.GrpClear.Text = "Keywords"
        '
        'DTToClear
        '
        Me.DTToClear.Location = New System.Drawing.Point(259, 221)
        Me.DTToClear.Name = "DTToClear"
        Me.DTToClear.Size = New System.Drawing.Size(18, 22)
        Me.DTToClear.TabIndex = 23
        '
        'DTFromClear
        '
        Me.DTFromClear.Location = New System.Drawing.Point(259, 198)
        Me.DTFromClear.Name = "DTFromClear"
        Me.DTFromClear.Size = New System.Drawing.Size(18, 22)
        Me.DTFromClear.TabIndex = 21
        '
        'DTIssueDateClear
        '
        Me.DTIssueDateClear.Location = New System.Drawing.Point(259, 129)
        Me.DTIssueDateClear.Name = "DTIssueDateClear"
        Me.DTIssueDateClear.Size = New System.Drawing.Size(18, 22)
        Me.DTIssueDateClear.TabIndex = 17
        '
        'ToPeriodClear
        '
        Me.ToPeriodClear.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ToPeriod", True))
        Me.ToPeriodClear.Location = New System.Drawing.Point(158, 221)
        Me.ToPeriodClear.Name = "ToPeriodClear"
        Me.ToPeriodClear.Size = New System.Drawing.Size(100, 22)
        Me.ToPeriodClear.TabIndex = 22
        '
        'FromPeriodClear
        '
        Me.FromPeriodClear.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "FromPeriod", True))
        Me.FromPeriodClear.Location = New System.Drawing.Point(158, 198)
        Me.FromPeriodClear.Name = "FromPeriodClear"
        Me.FromPeriodClear.Size = New System.Drawing.Size(100, 22)
        Me.FromPeriodClear.TabIndex = 20
        '
        'TermClear
        '
        Me.TermClear.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Term", True))
        Me.TermClear.Location = New System.Drawing.Point(158, 175)
        Me.TermClear.Name = "TermClear"
        Me.TermClear.Size = New System.Drawing.Size(100, 22)
        Me.TermClear.TabIndex = 19
        '
        'AccreditNoClear
        '
        Me.AccreditNoClear.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "AccreditNo", True))
        Me.AccreditNoClear.Location = New System.Drawing.Point(158, 152)
        Me.AccreditNoClear.Name = "AccreditNoClear"
        Me.AccreditNoClear.Size = New System.Drawing.Size(122, 22)
        Me.AccreditNoClear.TabIndex = 18
        '
        'IssueDateClear
        '
        Me.IssueDateClear.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "IssueDate", True))
        Me.IssueDateClear.Location = New System.Drawing.Point(158, 129)
        Me.IssueDateClear.Name = "IssueDateClear"
        Me.IssueDateClear.Size = New System.Drawing.Size(100, 22)
        Me.IssueDateClear.TabIndex = 16
        '
        'TinCustomerClear
        '
        Me.TinCustomerClear.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "TinCustomer", True))
        Me.TinCustomerClear.Location = New System.Drawing.Point(158, 101)
        Me.TinCustomerClear.Name = "TinCustomerClear"
        Me.TinCustomerClear.Size = New System.Drawing.Size(187, 22)
        Me.TinCustomerClear.TabIndex = 15
        '
        'CompanyClear
        '
        Me.CompanyClear.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Company", True))
        Me.CompanyClear.Location = New System.Drawing.Point(158, 78)
        Me.CompanyClear.Name = "CompanyClear"
        Me.CompanyClear.Size = New System.Drawing.Size(464, 22)
        Me.CompanyClear.TabIndex = 14
        '
        'BoxNoClear
        '
        Me.BoxNoClear.BackColor = System.Drawing.Color.White
        Me.BoxNoClear.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BoxNo", True))
        Me.BoxNoClear.Location = New System.Drawing.Point(158, 50)
        Me.BoxNoClear.Name = "BoxNoClear"
        Me.BoxNoClear.Size = New System.Drawing.Size(123, 22)
        Me.BoxNoClear.TabIndex = 13
        '
        'RackNoClear
        '
        Me.RackNoClear.BackColor = System.Drawing.Color.White
        Me.RackNoClear.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "RackNo", True))
        Me.RackNoClear.Location = New System.Drawing.Point(158, 27)
        Me.RackNoClear.Name = "RackNoClear"
        Me.RackNoClear.Size = New System.Drawing.Size(123, 22)
        Me.RackNoClear.TabIndex = 12
        '
        'Accredit
        '
        Me.Accredit.BackColor = System.Drawing.Color.Azure
        Me.Accredit.Controls.Add(Me.GrpAccre)
        Me.Accredit.Location = New System.Drawing.Point(4, 22)
        Me.Accredit.Name = "Accredit"
        Me.Accredit.Size = New System.Drawing.Size(650, 284)
        Me.Accredit.TabIndex = 12
        Me.Accredit.Text = "Accredit"
        '
        'GrpAccre
        '
        Me.GrpAccre.BackColor = System.Drawing.Color.Azure
        Me.GrpAccre.Controls.Add(Label110)
        Me.GrpAccre.Controls.Add(Label73)
        Me.GrpAccre.Controls.Add(Me.DTToAccre)
        Me.GrpAccre.Controls.Add(Label72)
        Me.GrpAccre.Controls.Add(Me.DTFromAccre)
        Me.GrpAccre.Controls.Add(Label71)
        Me.GrpAccre.Controls.Add(Me.DTIssueDateAccre)
        Me.GrpAccre.Controls.Add(ToPeriodLabel4)
        Me.GrpAccre.Controls.Add(Me.ToPeriodAccre)
        Me.GrpAccre.Controls.Add(FromPeriodLabel4)
        Me.GrpAccre.Controls.Add(Me.FromPeriodAccre)
        Me.GrpAccre.Controls.Add(TermLabel3)
        Me.GrpAccre.Controls.Add(Me.TermAccre)
        Me.GrpAccre.Controls.Add(AccreditNoLabel1)
        Me.GrpAccre.Controls.Add(Me.AccreditNoAccre)
        Me.GrpAccre.Controls.Add(IssueDateLabel1)
        Me.GrpAccre.Controls.Add(Me.IssueDateAccre)
        Me.GrpAccre.Controls.Add(CompanyLabel5)
        Me.GrpAccre.Controls.Add(Me.CompanyAccre)
        Me.GrpAccre.Controls.Add(Label68)
        Me.GrpAccre.Controls.Add(Me.BoxNoAccre)
        Me.GrpAccre.Controls.Add(Label70)
        Me.GrpAccre.Controls.Add(Me.RackNoAccre)
        Me.GrpAccre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpAccre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpAccre.ForeColor = System.Drawing.Color.Black
        Me.GrpAccre.Location = New System.Drawing.Point(0, 0)
        Me.GrpAccre.Name = "GrpAccre"
        Me.GrpAccre.Size = New System.Drawing.Size(650, 284)
        Me.GrpAccre.TabIndex = 3
        Me.GrpAccre.TabStop = False
        Me.GrpAccre.Text = "Keywords"
        '
        'DTToAccre
        '
        Me.DTToAccre.Location = New System.Drawing.Point(259, 193)
        Me.DTToAccre.Name = "DTToAccre"
        Me.DTToAccre.Size = New System.Drawing.Size(18, 22)
        Me.DTToAccre.TabIndex = 22
        '
        'DTFromAccre
        '
        Me.DTFromAccre.Location = New System.Drawing.Point(259, 170)
        Me.DTFromAccre.Name = "DTFromAccre"
        Me.DTFromAccre.Size = New System.Drawing.Size(18, 22)
        Me.DTFromAccre.TabIndex = 20
        '
        'DTIssueDateAccre
        '
        Me.DTIssueDateAccre.Location = New System.Drawing.Point(259, 101)
        Me.DTIssueDateAccre.Name = "DTIssueDateAccre"
        Me.DTIssueDateAccre.Size = New System.Drawing.Size(18, 22)
        Me.DTIssueDateAccre.TabIndex = 16
        '
        'ToPeriodAccre
        '
        Me.ToPeriodAccre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ToPeriod", True))
        Me.ToPeriodAccre.Location = New System.Drawing.Point(158, 193)
        Me.ToPeriodAccre.Name = "ToPeriodAccre"
        Me.ToPeriodAccre.Size = New System.Drawing.Size(100, 22)
        Me.ToPeriodAccre.TabIndex = 21
        '
        'FromPeriodAccre
        '
        Me.FromPeriodAccre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "FromPeriod", True))
        Me.FromPeriodAccre.Location = New System.Drawing.Point(158, 170)
        Me.FromPeriodAccre.Name = "FromPeriodAccre"
        Me.FromPeriodAccre.Size = New System.Drawing.Size(100, 22)
        Me.FromPeriodAccre.TabIndex = 19
        '
        'TermAccre
        '
        Me.TermAccre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Term", True))
        Me.TermAccre.Location = New System.Drawing.Point(158, 147)
        Me.TermAccre.Name = "TermAccre"
        Me.TermAccre.Size = New System.Drawing.Size(100, 22)
        Me.TermAccre.TabIndex = 18
        '
        'AccreditNoAccre
        '
        Me.AccreditNoAccre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "AccreditNo", True))
        Me.AccreditNoAccre.Location = New System.Drawing.Point(158, 124)
        Me.AccreditNoAccre.Name = "AccreditNoAccre"
        Me.AccreditNoAccre.Size = New System.Drawing.Size(122, 22)
        Me.AccreditNoAccre.TabIndex = 17
        '
        'IssueDateAccre
        '
        Me.IssueDateAccre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "IssueDate", True))
        Me.IssueDateAccre.Location = New System.Drawing.Point(158, 101)
        Me.IssueDateAccre.Name = "IssueDateAccre"
        Me.IssueDateAccre.Size = New System.Drawing.Size(100, 22)
        Me.IssueDateAccre.TabIndex = 15
        '
        'CompanyAccre
        '
        Me.CompanyAccre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Company", True))
        Me.CompanyAccre.Location = New System.Drawing.Point(158, 78)
        Me.CompanyAccre.Name = "CompanyAccre"
        Me.CompanyAccre.Size = New System.Drawing.Size(464, 22)
        Me.CompanyAccre.TabIndex = 14
        '
        'BoxNoAccre
        '
        Me.BoxNoAccre.BackColor = System.Drawing.Color.White
        Me.BoxNoAccre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BoxNo", True))
        Me.BoxNoAccre.Location = New System.Drawing.Point(158, 50)
        Me.BoxNoAccre.Name = "BoxNoAccre"
        Me.BoxNoAccre.Size = New System.Drawing.Size(123, 22)
        Me.BoxNoAccre.TabIndex = 13
        '
        'RackNoAccre
        '
        Me.RackNoAccre.BackColor = System.Drawing.Color.White
        Me.RackNoAccre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "RackNo", True))
        Me.RackNoAccre.Location = New System.Drawing.Point(158, 27)
        Me.RackNoAccre.Name = "RackNoAccre"
        Me.RackNoAccre.Size = New System.Drawing.Size(123, 22)
        Me.RackNoAccre.TabIndex = 12
        '
        'Subs
        '
        Me.Subs.BackColor = System.Drawing.Color.Azure
        Me.Subs.Controls.Add(Me.GrpSubs)
        Me.Subs.Location = New System.Drawing.Point(4, 22)
        Me.Subs.Name = "Subs"
        Me.Subs.Size = New System.Drawing.Size(650, 284)
        Me.Subs.TabIndex = 13
        Me.Subs.Text = "Subs"
        '
        'GrpSubs
        '
        Me.GrpSubs.BackColor = System.Drawing.Color.Azure
        Me.GrpSubs.Controls.Add(Label111)
        Me.GrpSubs.Controls.Add(Label75)
        Me.GrpSubs.Controls.Add(Me.DTToSubs)
        Me.GrpSubs.Controls.Add(Label74)
        Me.GrpSubs.Controls.Add(Me.DTFromSubs)
        Me.GrpSubs.Controls.Add(Label76)
        Me.GrpSubs.Controls.Add(Me.DTSubsDateSubs)
        Me.GrpSubs.Controls.Add(ToPeriodLabel5)
        Me.GrpSubs.Controls.Add(Me.ToPeriodSubs)
        Me.GrpSubs.Controls.Add(FromPeriodLabel5)
        Me.GrpSubs.Controls.Add(Me.FromPeriodSubs)
        Me.GrpSubs.Controls.Add(TermLabel4)
        Me.GrpSubs.Controls.Add(Me.TermSubs)
        Me.GrpSubs.Controls.Add(SubsDateLabel)
        Me.GrpSubs.Controls.Add(Me.SubsDateSubs)
        Me.GrpSubs.Controls.Add(GLNLabel)
        Me.GrpSubs.Controls.Add(Me.GLNSubs)
        Me.GrpSubs.Controls.Add(CompanyPrefixLabel)
        Me.GrpSubs.Controls.Add(Me.CompanyPrefixSubs)
        Me.GrpSubs.Controls.Add(CompanyLabel6)
        Me.GrpSubs.Controls.Add(Me.CompanySubs)
        Me.GrpSubs.Controls.Add(Label77)
        Me.GrpSubs.Controls.Add(Me.BoxNoSubs)
        Me.GrpSubs.Controls.Add(Label78)
        Me.GrpSubs.Controls.Add(Me.RackNoSubs)
        Me.GrpSubs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpSubs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpSubs.ForeColor = System.Drawing.Color.Black
        Me.GrpSubs.Location = New System.Drawing.Point(0, 0)
        Me.GrpSubs.Name = "GrpSubs"
        Me.GrpSubs.Size = New System.Drawing.Size(650, 284)
        Me.GrpSubs.TabIndex = 3
        Me.GrpSubs.TabStop = False
        Me.GrpSubs.Text = "Keywords"
        '
        'DTToSubs
        '
        Me.DTToSubs.Location = New System.Drawing.Point(259, 226)
        Me.DTToSubs.Name = "DTToSubs"
        Me.DTToSubs.Size = New System.Drawing.Size(18, 22)
        Me.DTToSubs.TabIndex = 23
        '
        'DTFromSubs
        '
        Me.DTFromSubs.Location = New System.Drawing.Point(259, 203)
        Me.DTFromSubs.Name = "DTFromSubs"
        Me.DTFromSubs.Size = New System.Drawing.Size(18, 22)
        Me.DTFromSubs.TabIndex = 21
        '
        'DTSubsDateSubs
        '
        Me.DTSubsDateSubs.Location = New System.Drawing.Point(259, 152)
        Me.DTSubsDateSubs.Name = "DTSubsDateSubs"
        Me.DTSubsDateSubs.Size = New System.Drawing.Size(18, 22)
        Me.DTSubsDateSubs.TabIndex = 18
        '
        'ToPeriodSubs
        '
        Me.ToPeriodSubs.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ToPeriod", True))
        Me.ToPeriodSubs.Location = New System.Drawing.Point(158, 226)
        Me.ToPeriodSubs.Name = "ToPeriodSubs"
        Me.ToPeriodSubs.Size = New System.Drawing.Size(100, 22)
        Me.ToPeriodSubs.TabIndex = 22
        '
        'FromPeriodSubs
        '
        Me.FromPeriodSubs.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "FromPeriod", True))
        Me.FromPeriodSubs.Location = New System.Drawing.Point(158, 203)
        Me.FromPeriodSubs.Name = "FromPeriodSubs"
        Me.FromPeriodSubs.Size = New System.Drawing.Size(100, 22)
        Me.FromPeriodSubs.TabIndex = 20
        '
        'TermSubs
        '
        Me.TermSubs.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Term", True))
        Me.TermSubs.Location = New System.Drawing.Point(158, 175)
        Me.TermSubs.Name = "TermSubs"
        Me.TermSubs.Size = New System.Drawing.Size(100, 22)
        Me.TermSubs.TabIndex = 19
        '
        'SubsDateSubs
        '
        Me.SubsDateSubs.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "SubsDate", True))
        Me.SubsDateSubs.Location = New System.Drawing.Point(158, 152)
        Me.SubsDateSubs.Name = "SubsDateSubs"
        Me.SubsDateSubs.Size = New System.Drawing.Size(100, 22)
        Me.SubsDateSubs.TabIndex = 17
        '
        'GLNSubs
        '
        Me.GLNSubs.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "GLN", True))
        Me.GLNSubs.Location = New System.Drawing.Point(158, 124)
        Me.GLNSubs.Name = "GLNSubs"
        Me.GLNSubs.Size = New System.Drawing.Size(220, 22)
        Me.GLNSubs.TabIndex = 16
        '
        'CompanyPrefixSubs
        '
        Me.CompanyPrefixSubs.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "CompanyPrefix", True))
        Me.CompanyPrefixSubs.Location = New System.Drawing.Point(158, 101)
        Me.CompanyPrefixSubs.Name = "CompanyPrefixSubs"
        Me.CompanyPrefixSubs.Size = New System.Drawing.Size(220, 22)
        Me.CompanyPrefixSubs.TabIndex = 15
        '
        'CompanySubs
        '
        Me.CompanySubs.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Company", True))
        Me.CompanySubs.Location = New System.Drawing.Point(158, 78)
        Me.CompanySubs.Name = "CompanySubs"
        Me.CompanySubs.Size = New System.Drawing.Size(464, 22)
        Me.CompanySubs.TabIndex = 14
        '
        'BoxNoSubs
        '
        Me.BoxNoSubs.BackColor = System.Drawing.Color.White
        Me.BoxNoSubs.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BoxNo", True))
        Me.BoxNoSubs.Location = New System.Drawing.Point(158, 50)
        Me.BoxNoSubs.Name = "BoxNoSubs"
        Me.BoxNoSubs.Size = New System.Drawing.Size(123, 22)
        Me.BoxNoSubs.TabIndex = 13
        '
        'RackNoSubs
        '
        Me.RackNoSubs.BackColor = System.Drawing.Color.White
        Me.RackNoSubs.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "RackNo", True))
        Me.RackNoSubs.Location = New System.Drawing.Point(158, 27)
        Me.RackNoSubs.Name = "RackNoSubs"
        Me.RackNoSubs.Size = New System.Drawing.Size(123, 22)
        Me.RackNoSubs.TabIndex = 12
        '
        'Contract
        '
        Me.Contract.AutoScroll = True
        Me.Contract.AutoScrollMinSize = New System.Drawing.Size(0, 600)
        Me.Contract.BackColor = System.Drawing.Color.Azure
        Me.Contract.Controls.Add(Me.GrpContract)
        Me.Contract.Location = New System.Drawing.Point(4, 22)
        Me.Contract.Name = "Contract"
        Me.Contract.Size = New System.Drawing.Size(650, 284)
        Me.Contract.TabIndex = 14
        Me.Contract.Text = "Contract"
        '
        'GrpContract
        '
        Me.GrpContract.BackColor = System.Drawing.Color.Azure
        Me.GrpContract.Controls.Add(Label82)
        Me.GrpContract.Controls.Add(Me.DTDateSignContract)
        Me.GrpContract.Controls.Add(Label81)
        Me.GrpContract.Controls.Add(Me.DTToContract)
        Me.GrpContract.Controls.Add(Label80)
        Me.GrpContract.Controls.Add(Me.DTFromContract)
        Me.GrpContract.Controls.Add(Label79)
        Me.GrpContract.Controls.Add(Label83)
        Me.GrpContract.Controls.Add(Label84)
        Me.GrpContract.Controls.Add(Label85)
        Me.GrpContract.Controls.Add(P2PositionLabel)
        Me.GrpContract.Controls.Add(Me.P2PositionContract)
        Me.GrpContract.Controls.Add(P2LastNameLabel)
        Me.GrpContract.Controls.Add(Me.P2LastNameContract)
        Me.GrpContract.Controls.Add(P2MiddleNameLabel)
        Me.GrpContract.Controls.Add(Me.P2MiddleNameContract)
        Me.GrpContract.Controls.Add(P2FirstNameLabel)
        Me.GrpContract.Controls.Add(Me.P2FirstNameContract)
        Me.GrpContract.Controls.Add(P2CompanyLabel)
        Me.GrpContract.Controls.Add(Me.P2CompanyContract)
        Me.GrpContract.Controls.Add(P1PositionLabel)
        Me.GrpContract.Controls.Add(Me.P1PositionContract)
        Me.GrpContract.Controls.Add(P1LastNameLabel)
        Me.GrpContract.Controls.Add(Me.P1LastNameContract)
        Me.GrpContract.Controls.Add(P1MiddleNameLabel)
        Me.GrpContract.Controls.Add(Me.P1MiddleNameContract)
        Me.GrpContract.Controls.Add(P1FirstNameLabel)
        Me.GrpContract.Controls.Add(Me.P1FirstNameContract)
        Me.GrpContract.Controls.Add(P1CompanyLabel)
        Me.GrpContract.Controls.Add(Me.P1CompanyContract)
        Me.GrpContract.Controls.Add(ContractPlaceLabel)
        Me.GrpContract.Controls.Add(Me.ContractPlaceContract)
        Me.GrpContract.Controls.Add(SignDateLabel)
        Me.GrpContract.Controls.Add(Me.SignDateContract)
        Me.GrpContract.Controls.Add(ToPeriodLabel6)
        Me.GrpContract.Controls.Add(Me.ToPeriodContract)
        Me.GrpContract.Controls.Add(FromPeriodLabel6)
        Me.GrpContract.Controls.Add(Me.FromPeriodContract)
        Me.GrpContract.Controls.Add(PurposeLabel1)
        Me.GrpContract.Controls.Add(Me.PurposeContract)
        Me.GrpContract.Controls.Add(ContractTypeLabel)
        Me.GrpContract.Controls.Add(Me.ContractTypeContract)
        Me.GrpContract.Controls.Add(Label86)
        Me.GrpContract.Controls.Add(Me.BoxNoContract)
        Me.GrpContract.Controls.Add(Label87)
        Me.GrpContract.Controls.Add(Me.RackNoContract)
        Me.GrpContract.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpContract.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpContract.ForeColor = System.Drawing.Color.Black
        Me.GrpContract.Location = New System.Drawing.Point(0, 0)
        Me.GrpContract.Name = "GrpContract"
        Me.GrpContract.Size = New System.Drawing.Size(633, 600)
        Me.GrpContract.TabIndex = 3
        Me.GrpContract.TabStop = False
        Me.GrpContract.Text = "Keywords"
        '
        'DTDateSignContract
        '
        Me.DTDateSignContract.Location = New System.Drawing.Point(259, 232)
        Me.DTDateSignContract.Name = "DTDateSignContract"
        Me.DTDateSignContract.Size = New System.Drawing.Size(18, 22)
        Me.DTDateSignContract.TabIndex = 21
        '
        'DTToContract
        '
        Me.DTToContract.Location = New System.Drawing.Point(259, 179)
        Me.DTToContract.Name = "DTToContract"
        Me.DTToContract.Size = New System.Drawing.Size(18, 22)
        Me.DTToContract.TabIndex = 19
        '
        'DTFromContract
        '
        Me.DTFromContract.Location = New System.Drawing.Point(259, 156)
        Me.DTFromContract.Name = "DTFromContract"
        Me.DTFromContract.Size = New System.Drawing.Size(18, 22)
        Me.DTFromContract.TabIndex = 17
        '
        'P2PositionContract
        '
        Me.P2PositionContract.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "P2Position", True))
        Me.P2PositionContract.Location = New System.Drawing.Point(158, 545)
        Me.P2PositionContract.Name = "P2PositionContract"
        Me.P2PositionContract.Size = New System.Drawing.Size(464, 22)
        Me.P2PositionContract.TabIndex = 32
        '
        'P2LastNameContract
        '
        Me.P2LastNameContract.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "P2LastName", True))
        Me.P2LastNameContract.Location = New System.Drawing.Point(158, 522)
        Me.P2LastNameContract.Name = "P2LastNameContract"
        Me.P2LastNameContract.Size = New System.Drawing.Size(464, 22)
        Me.P2LastNameContract.TabIndex = 31
        '
        'P2MiddleNameContract
        '
        Me.P2MiddleNameContract.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "P2MiddleName", True))
        Me.P2MiddleNameContract.Location = New System.Drawing.Point(158, 499)
        Me.P2MiddleNameContract.Name = "P2MiddleNameContract"
        Me.P2MiddleNameContract.Size = New System.Drawing.Size(464, 22)
        Me.P2MiddleNameContract.TabIndex = 30
        '
        'P2FirstNameContract
        '
        Me.P2FirstNameContract.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "P2FirstName", True))
        Me.P2FirstNameContract.Location = New System.Drawing.Point(158, 476)
        Me.P2FirstNameContract.Name = "P2FirstNameContract"
        Me.P2FirstNameContract.Size = New System.Drawing.Size(464, 22)
        Me.P2FirstNameContract.TabIndex = 29
        '
        'P2CompanyContract
        '
        Me.P2CompanyContract.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "P2Company", True))
        Me.P2CompanyContract.Location = New System.Drawing.Point(158, 453)
        Me.P2CompanyContract.Name = "P2CompanyContract"
        Me.P2CompanyContract.Size = New System.Drawing.Size(464, 22)
        Me.P2CompanyContract.TabIndex = 28
        '
        'P1PositionContract
        '
        Me.P1PositionContract.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "P1Position", True))
        Me.P1PositionContract.Location = New System.Drawing.Point(158, 399)
        Me.P1PositionContract.Name = "P1PositionContract"
        Me.P1PositionContract.Size = New System.Drawing.Size(464, 22)
        Me.P1PositionContract.TabIndex = 27
        '
        'P1LastNameContract
        '
        Me.P1LastNameContract.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "P1LastName", True))
        Me.P1LastNameContract.Location = New System.Drawing.Point(158, 376)
        Me.P1LastNameContract.Name = "P1LastNameContract"
        Me.P1LastNameContract.Size = New System.Drawing.Size(464, 22)
        Me.P1LastNameContract.TabIndex = 26
        '
        'P1MiddleNameContract
        '
        Me.P1MiddleNameContract.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "P1MiddleName", True))
        Me.P1MiddleNameContract.Location = New System.Drawing.Point(158, 353)
        Me.P1MiddleNameContract.Name = "P1MiddleNameContract"
        Me.P1MiddleNameContract.Size = New System.Drawing.Size(464, 22)
        Me.P1MiddleNameContract.TabIndex = 25
        '
        'P1FirstNameContract
        '
        Me.P1FirstNameContract.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "P1FirstName", True))
        Me.P1FirstNameContract.Location = New System.Drawing.Point(158, 330)
        Me.P1FirstNameContract.Name = "P1FirstNameContract"
        Me.P1FirstNameContract.Size = New System.Drawing.Size(464, 22)
        Me.P1FirstNameContract.TabIndex = 24
        '
        'P1CompanyContract
        '
        Me.P1CompanyContract.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "P1Company", True))
        Me.P1CompanyContract.Location = New System.Drawing.Point(158, 307)
        Me.P1CompanyContract.Name = "P1CompanyContract"
        Me.P1CompanyContract.Size = New System.Drawing.Size(464, 22)
        Me.P1CompanyContract.TabIndex = 23
        '
        'ContractPlaceContract
        '
        Me.ContractPlaceContract.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ContractPlace", True))
        Me.ContractPlaceContract.Location = New System.Drawing.Point(158, 255)
        Me.ContractPlaceContract.Name = "ContractPlaceContract"
        Me.ContractPlaceContract.Size = New System.Drawing.Size(288, 22)
        Me.ContractPlaceContract.TabIndex = 22
        '
        'SignDateContract
        '
        Me.SignDateContract.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "SignDate", True))
        Me.SignDateContract.Location = New System.Drawing.Point(158, 232)
        Me.SignDateContract.Name = "SignDateContract"
        Me.SignDateContract.Size = New System.Drawing.Size(100, 22)
        Me.SignDateContract.TabIndex = 20
        '
        'ToPeriodContract
        '
        Me.ToPeriodContract.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ToPeriod", True))
        Me.ToPeriodContract.Location = New System.Drawing.Point(158, 179)
        Me.ToPeriodContract.Name = "ToPeriodContract"
        Me.ToPeriodContract.Size = New System.Drawing.Size(100, 22)
        Me.ToPeriodContract.TabIndex = 18
        '
        'FromPeriodContract
        '
        Me.FromPeriodContract.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "FromPeriod", True))
        Me.FromPeriodContract.Location = New System.Drawing.Point(158, 156)
        Me.FromPeriodContract.Name = "FromPeriodContract"
        Me.FromPeriodContract.Size = New System.Drawing.Size(100, 22)
        Me.FromPeriodContract.TabIndex = 16
        '
        'PurposeContract
        '
        Me.PurposeContract.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Purpose", True))
        Me.PurposeContract.Location = New System.Drawing.Point(158, 101)
        Me.PurposeContract.Name = "PurposeContract"
        Me.PurposeContract.Size = New System.Drawing.Size(464, 22)
        Me.PurposeContract.TabIndex = 15
        '
        'ContractTypeContract
        '
        Me.ContractTypeContract.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ContractType", True))
        Me.ContractTypeContract.Location = New System.Drawing.Point(158, 78)
        Me.ContractTypeContract.Name = "ContractTypeContract"
        Me.ContractTypeContract.Size = New System.Drawing.Size(288, 22)
        Me.ContractTypeContract.TabIndex = 14
        '
        'BoxNoContract
        '
        Me.BoxNoContract.BackColor = System.Drawing.Color.White
        Me.BoxNoContract.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BoxNo", True))
        Me.BoxNoContract.Location = New System.Drawing.Point(158, 50)
        Me.BoxNoContract.Name = "BoxNoContract"
        Me.BoxNoContract.Size = New System.Drawing.Size(123, 22)
        Me.BoxNoContract.TabIndex = 13
        '
        'RackNoContract
        '
        Me.RackNoContract.BackColor = System.Drawing.Color.White
        Me.RackNoContract.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "RackNo", True))
        Me.RackNoContract.Location = New System.Drawing.Point(158, 27)
        Me.RackNoContract.Name = "RackNoContract"
        Me.RackNoContract.Size = New System.Drawing.Size(123, 22)
        Me.RackNoContract.TabIndex = 12
        '
        'Attorney
        '
        Me.Attorney.AutoScroll = True
        Me.Attorney.AutoScrollMinSize = New System.Drawing.Size(0, 500)
        Me.Attorney.BackColor = System.Drawing.Color.Azure
        Me.Attorney.Controls.Add(Me.GrpAttorney)
        Me.Attorney.Location = New System.Drawing.Point(4, 22)
        Me.Attorney.Name = "Attorney"
        Me.Attorney.Size = New System.Drawing.Size(650, 284)
        Me.Attorney.TabIndex = 15
        Me.Attorney.Text = "Attorney"
        '
        'GrpAttorney
        '
        Me.GrpAttorney.BackColor = System.Drawing.Color.Azure
        Me.GrpAttorney.Controls.Add(Label89)
        Me.GrpAttorney.Controls.Add(Me.DTToAttorney)
        Me.GrpAttorney.Controls.Add(Label88)
        Me.GrpAttorney.Controls.Add(Me.DTFromAttorney)
        Me.GrpAttorney.Controls.Add(Label90)
        Me.GrpAttorney.Controls.Add(Me.DTIssuePlaceAttorney)
        Me.GrpAttorney.Controls.Add(Label91)
        Me.GrpAttorney.Controls.Add(Me.DTIssueDateAttorney)
        Me.GrpAttorney.Controls.Add(Label92)
        Me.GrpAttorney.Controls.Add(Label93)
        Me.GrpAttorney.Controls.Add(Label94)
        Me.GrpAttorney.Controls.Add(ToPeriodLabel7)
        Me.GrpAttorney.Controls.Add(Me.ToPeriodAttorney)
        Me.GrpAttorney.Controls.Add(FromPeriodLabel7)
        Me.GrpAttorney.Controls.Add(Me.FromPeriodAttorney)
        Me.GrpAttorney.Controls.Add(P2LastNameLabel1)
        Me.GrpAttorney.Controls.Add(Me.P2LastNameAttorney)
        Me.GrpAttorney.Controls.Add(P2MiddleNameLabel1)
        Me.GrpAttorney.Controls.Add(Me.P2MiddleNameAttorney)
        Me.GrpAttorney.Controls.Add(P2FirstNameLabel1)
        Me.GrpAttorney.Controls.Add(Me.P2FirstNameAttorney)
        Me.GrpAttorney.Controls.Add(P2CompanyLabel1)
        Me.GrpAttorney.Controls.Add(Me.P2CompanyAttorney)
        Me.GrpAttorney.Controls.Add(P1LastNameLabel1)
        Me.GrpAttorney.Controls.Add(Me.P1LastNameAttorney)
        Me.GrpAttorney.Controls.Add(P1MiddleNameLabel1)
        Me.GrpAttorney.Controls.Add(Me.P1MiddleNameAttorney)
        Me.GrpAttorney.Controls.Add(P1FirstNameLabel1)
        Me.GrpAttorney.Controls.Add(Me.P1FirstNameAttorney)
        Me.GrpAttorney.Controls.Add(P1CompanyLabel1)
        Me.GrpAttorney.Controls.Add(Me.P1CompanyAttorney)
        Me.GrpAttorney.Controls.Add(IssuePlaceLabel)
        Me.GrpAttorney.Controls.Add(Me.IssuePlaceAttorney)
        Me.GrpAttorney.Controls.Add(IssueDateLabel2)
        Me.GrpAttorney.Controls.Add(Me.IssueDateAttorney)
        Me.GrpAttorney.Controls.Add(Label95)
        Me.GrpAttorney.Controls.Add(Me.BoxNoAttorney)
        Me.GrpAttorney.Controls.Add(Label96)
        Me.GrpAttorney.Controls.Add(Me.RackNoAttorney)
        Me.GrpAttorney.Controls.Add(Label97)
        Me.GrpAttorney.Controls.Add(Me.PurposeAttorney)
        Me.GrpAttorney.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpAttorney.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpAttorney.ForeColor = System.Drawing.Color.Black
        Me.GrpAttorney.Location = New System.Drawing.Point(0, 0)
        Me.GrpAttorney.Name = "GrpAttorney"
        Me.GrpAttorney.Size = New System.Drawing.Size(633, 500)
        Me.GrpAttorney.TabIndex = 3
        Me.GrpAttorney.TabStop = False
        Me.GrpAttorney.Text = "Keywords"
        '
        'DTToAttorney
        '
        Me.DTToAttorney.Location = New System.Drawing.Point(259, 438)
        Me.DTToAttorney.Name = "DTToAttorney"
        Me.DTToAttorney.Size = New System.Drawing.Size(18, 22)
        Me.DTToAttorney.TabIndex = 30
        '
        'DTFromAttorney
        '
        Me.DTFromAttorney.Location = New System.Drawing.Point(259, 414)
        Me.DTFromAttorney.Name = "DTFromAttorney"
        Me.DTFromAttorney.Size = New System.Drawing.Size(18, 22)
        Me.DTFromAttorney.TabIndex = 28
        '
        'DTIssuePlaceAttorney
        '
        Me.DTIssuePlaceAttorney.Location = New System.Drawing.Point(259, 124)
        Me.DTIssuePlaceAttorney.Name = "DTIssuePlaceAttorney"
        Me.DTIssuePlaceAttorney.Size = New System.Drawing.Size(18, 22)
        Me.DTIssuePlaceAttorney.TabIndex = 18
        '
        'DTIssueDateAttorney
        '
        Me.DTIssueDateAttorney.Location = New System.Drawing.Point(259, 101)
        Me.DTIssueDateAttorney.Name = "DTIssueDateAttorney"
        Me.DTIssueDateAttorney.Size = New System.Drawing.Size(18, 22)
        Me.DTIssueDateAttorney.TabIndex = 16
        '
        'ToPeriodAttorney
        '
        Me.ToPeriodAttorney.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "ToPeriod", True))
        Me.ToPeriodAttorney.Location = New System.Drawing.Point(158, 438)
        Me.ToPeriodAttorney.Name = "ToPeriodAttorney"
        Me.ToPeriodAttorney.Size = New System.Drawing.Size(100, 22)
        Me.ToPeriodAttorney.TabIndex = 29
        '
        'FromPeriodAttorney
        '
        Me.FromPeriodAttorney.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "FromPeriod", True))
        Me.FromPeriodAttorney.Location = New System.Drawing.Point(158, 414)
        Me.FromPeriodAttorney.Name = "FromPeriodAttorney"
        Me.FromPeriodAttorney.Size = New System.Drawing.Size(100, 22)
        Me.FromPeriodAttorney.TabIndex = 27
        '
        'P2LastNameAttorney
        '
        Me.P2LastNameAttorney.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "P2LastName", True))
        Me.P2LastNameAttorney.Location = New System.Drawing.Point(158, 362)
        Me.P2LastNameAttorney.Name = "P2LastNameAttorney"
        Me.P2LastNameAttorney.Size = New System.Drawing.Size(464, 22)
        Me.P2LastNameAttorney.TabIndex = 26
        '
        'P2MiddleNameAttorney
        '
        Me.P2MiddleNameAttorney.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "P2MiddleName", True))
        Me.P2MiddleNameAttorney.Location = New System.Drawing.Point(158, 339)
        Me.P2MiddleNameAttorney.Name = "P2MiddleNameAttorney"
        Me.P2MiddleNameAttorney.Size = New System.Drawing.Size(464, 22)
        Me.P2MiddleNameAttorney.TabIndex = 25
        '
        'P2FirstNameAttorney
        '
        Me.P2FirstNameAttorney.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "P2FirstName", True))
        Me.P2FirstNameAttorney.Location = New System.Drawing.Point(158, 316)
        Me.P2FirstNameAttorney.Name = "P2FirstNameAttorney"
        Me.P2FirstNameAttorney.Size = New System.Drawing.Size(464, 22)
        Me.P2FirstNameAttorney.TabIndex = 24
        '
        'P2CompanyAttorney
        '
        Me.P2CompanyAttorney.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "P2Company", True))
        Me.P2CompanyAttorney.Location = New System.Drawing.Point(158, 293)
        Me.P2CompanyAttorney.Name = "P2CompanyAttorney"
        Me.P2CompanyAttorney.Size = New System.Drawing.Size(464, 22)
        Me.P2CompanyAttorney.TabIndex = 23
        '
        'P1LastNameAttorney
        '
        Me.P1LastNameAttorney.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "P1LastName", True))
        Me.P1LastNameAttorney.Location = New System.Drawing.Point(158, 243)
        Me.P1LastNameAttorney.Name = "P1LastNameAttorney"
        Me.P1LastNameAttorney.Size = New System.Drawing.Size(464, 22)
        Me.P1LastNameAttorney.TabIndex = 22
        '
        'P1MiddleNameAttorney
        '
        Me.P1MiddleNameAttorney.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "P1MiddleName", True))
        Me.P1MiddleNameAttorney.Location = New System.Drawing.Point(158, 220)
        Me.P1MiddleNameAttorney.Name = "P1MiddleNameAttorney"
        Me.P1MiddleNameAttorney.Size = New System.Drawing.Size(464, 22)
        Me.P1MiddleNameAttorney.TabIndex = 21
        '
        'P1FirstNameAttorney
        '
        Me.P1FirstNameAttorney.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "P1FirstName", True))
        Me.P1FirstNameAttorney.Location = New System.Drawing.Point(158, 196)
        Me.P1FirstNameAttorney.Name = "P1FirstNameAttorney"
        Me.P1FirstNameAttorney.Size = New System.Drawing.Size(464, 22)
        Me.P1FirstNameAttorney.TabIndex = 20
        '
        'P1CompanyAttorney
        '
        Me.P1CompanyAttorney.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "P1Company", True))
        Me.P1CompanyAttorney.Location = New System.Drawing.Point(158, 173)
        Me.P1CompanyAttorney.Name = "P1CompanyAttorney"
        Me.P1CompanyAttorney.Size = New System.Drawing.Size(464, 22)
        Me.P1CompanyAttorney.TabIndex = 19
        '
        'IssuePlaceAttorney
        '
        Me.IssuePlaceAttorney.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "IssuePlace", True))
        Me.IssuePlaceAttorney.Location = New System.Drawing.Point(158, 124)
        Me.IssuePlaceAttorney.Name = "IssuePlaceAttorney"
        Me.IssuePlaceAttorney.Size = New System.Drawing.Size(100, 22)
        Me.IssuePlaceAttorney.TabIndex = 17
        '
        'IssueDateAttorney
        '
        Me.IssueDateAttorney.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "IssueDate", True))
        Me.IssueDateAttorney.Location = New System.Drawing.Point(158, 101)
        Me.IssueDateAttorney.Name = "IssueDateAttorney"
        Me.IssueDateAttorney.Size = New System.Drawing.Size(100, 22)
        Me.IssueDateAttorney.TabIndex = 15
        '
        'BoxNoAttorney
        '
        Me.BoxNoAttorney.BackColor = System.Drawing.Color.White
        Me.BoxNoAttorney.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BoxNo", True))
        Me.BoxNoAttorney.Location = New System.Drawing.Point(158, 50)
        Me.BoxNoAttorney.Name = "BoxNoAttorney"
        Me.BoxNoAttorney.Size = New System.Drawing.Size(123, 22)
        Me.BoxNoAttorney.TabIndex = 13
        '
        'RackNoAttorney
        '
        Me.RackNoAttorney.BackColor = System.Drawing.Color.White
        Me.RackNoAttorney.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "RackNo", True))
        Me.RackNoAttorney.Location = New System.Drawing.Point(158, 27)
        Me.RackNoAttorney.Name = "RackNoAttorney"
        Me.RackNoAttorney.Size = New System.Drawing.Size(123, 22)
        Me.RackNoAttorney.TabIndex = 12
        '
        'PurposeAttorney
        '
        Me.PurposeAttorney.BackColor = System.Drawing.Color.White
        Me.PurposeAttorney.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Purpose", True))
        Me.PurposeAttorney.Location = New System.Drawing.Point(158, 78)
        Me.PurposeAttorney.Name = "PurposeAttorney"
        Me.PurposeAttorney.Size = New System.Drawing.Size(464, 22)
        Me.PurposeAttorney.TabIndex = 14
        '
        'OtherDoc
        '
        Me.OtherDoc.BackColor = System.Drawing.Color.Azure
        Me.OtherDoc.Controls.Add(Me.GrpOther)
        Me.OtherDoc.Location = New System.Drawing.Point(4, 22)
        Me.OtherDoc.Name = "OtherDoc"
        Me.OtherDoc.Size = New System.Drawing.Size(650, 284)
        Me.OtherDoc.TabIndex = 16
        Me.OtherDoc.Text = "OtherDoc"
        '
        'GrpOther
        '
        Me.GrpOther.BackColor = System.Drawing.Color.Azure
        Me.GrpOther.Controls.Add(Label98)
        Me.GrpOther.Controls.Add(Me.DTIssuePlaceOther)
        Me.GrpOther.Controls.Add(Label99)
        Me.GrpOther.Controls.Add(Me.DTIssueDateOther)
        Me.GrpOther.Controls.Add(LastNameLabel2)
        Me.GrpOther.Controls.Add(Me.LastNameOther)
        Me.GrpOther.Controls.Add(MiddleNameLabel2)
        Me.GrpOther.Controls.Add(Me.MiddleNameOther)
        Me.GrpOther.Controls.Add(FirstNameLabel2)
        Me.GrpOther.Controls.Add(Me.FirstNameOther)
        Me.GrpOther.Controls.Add(CompanyLabel7)
        Me.GrpOther.Controls.Add(Me.CompanyOther)
        Me.GrpOther.Controls.Add(IssuePlaceLabel1)
        Me.GrpOther.Controls.Add(Me.IssuePlaceOther)
        Me.GrpOther.Controls.Add(IssueDateLabel3)
        Me.GrpOther.Controls.Add(Me.IssueDateOther)
        Me.GrpOther.Controls.Add(Label100)
        Me.GrpOther.Controls.Add(Me.BoxNoOther)
        Me.GrpOther.Controls.Add(Label101)
        Me.GrpOther.Controls.Add(Me.RackNoOther)
        Me.GrpOther.Controls.Add(Label102)
        Me.GrpOther.Controls.Add(Me.PurposeOther)
        Me.GrpOther.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpOther.ForeColor = System.Drawing.Color.Black
        Me.GrpOther.Location = New System.Drawing.Point(0, 0)
        Me.GrpOther.Name = "GrpOther"
        Me.GrpOther.Size = New System.Drawing.Size(650, 284)
        Me.GrpOther.TabIndex = 3
        Me.GrpOther.TabStop = False
        Me.GrpOther.Text = "Keywords"
        '
        'DTIssuePlaceOther
        '
        Me.DTIssuePlaceOther.Location = New System.Drawing.Point(259, 119)
        Me.DTIssuePlaceOther.Name = "DTIssuePlaceOther"
        Me.DTIssuePlaceOther.Size = New System.Drawing.Size(18, 22)
        Me.DTIssuePlaceOther.TabIndex = 18
        '
        'DTIssueDateOther
        '
        Me.DTIssueDateOther.Location = New System.Drawing.Point(259, 96)
        Me.DTIssueDateOther.Name = "DTIssueDateOther"
        Me.DTIssueDateOther.Size = New System.Drawing.Size(18, 22)
        Me.DTIssueDateOther.TabIndex = 16
        '
        'LastNameOther
        '
        Me.LastNameOther.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "LastName", True))
        Me.LastNameOther.Location = New System.Drawing.Point(158, 245)
        Me.LastNameOther.Name = "LastNameOther"
        Me.LastNameOther.Size = New System.Drawing.Size(464, 22)
        Me.LastNameOther.TabIndex = 22
        '
        'MiddleNameOther
        '
        Me.MiddleNameOther.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "MiddleName", True))
        Me.MiddleNameOther.Location = New System.Drawing.Point(158, 222)
        Me.MiddleNameOther.Name = "MiddleNameOther"
        Me.MiddleNameOther.Size = New System.Drawing.Size(464, 22)
        Me.MiddleNameOther.TabIndex = 21
        '
        'FirstNameOther
        '
        Me.FirstNameOther.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "FirstName", True))
        Me.FirstNameOther.Location = New System.Drawing.Point(158, 199)
        Me.FirstNameOther.Name = "FirstNameOther"
        Me.FirstNameOther.Size = New System.Drawing.Size(464, 22)
        Me.FirstNameOther.TabIndex = 20
        '
        'CompanyOther
        '
        Me.CompanyOther.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Company", True))
        Me.CompanyOther.Location = New System.Drawing.Point(158, 176)
        Me.CompanyOther.Name = "CompanyOther"
        Me.CompanyOther.Size = New System.Drawing.Size(464, 22)
        Me.CompanyOther.TabIndex = 19
        '
        'IssuePlaceOther
        '
        Me.IssuePlaceOther.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "IssuePlace", True))
        Me.IssuePlaceOther.Location = New System.Drawing.Point(158, 119)
        Me.IssuePlaceOther.Name = "IssuePlaceOther"
        Me.IssuePlaceOther.Size = New System.Drawing.Size(100, 22)
        Me.IssuePlaceOther.TabIndex = 17
        '
        'IssueDateOther
        '
        Me.IssueDateOther.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "IssueDate", True))
        Me.IssueDateOther.Location = New System.Drawing.Point(158, 96)
        Me.IssueDateOther.Name = "IssueDateOther"
        Me.IssueDateOther.Size = New System.Drawing.Size(100, 22)
        Me.IssueDateOther.TabIndex = 15
        '
        'BoxNoOther
        '
        Me.BoxNoOther.BackColor = System.Drawing.Color.White
        Me.BoxNoOther.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BoxNo", True))
        Me.BoxNoOther.Location = New System.Drawing.Point(158, 50)
        Me.BoxNoOther.Name = "BoxNoOther"
        Me.BoxNoOther.Size = New System.Drawing.Size(123, 22)
        Me.BoxNoOther.TabIndex = 13
        '
        'RackNoOther
        '
        Me.RackNoOther.BackColor = System.Drawing.Color.White
        Me.RackNoOther.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "RackNo", True))
        Me.RackNoOther.Location = New System.Drawing.Point(158, 27)
        Me.RackNoOther.Name = "RackNoOther"
        Me.RackNoOther.Size = New System.Drawing.Size(123, 22)
        Me.RackNoOther.TabIndex = 12
        '
        'PurposeOther
        '
        Me.PurposeOther.BackColor = System.Drawing.Color.White
        Me.PurposeOther.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Purpose", True))
        Me.PurposeOther.Location = New System.Drawing.Point(158, 73)
        Me.PurposeOther.Name = "PurposeOther"
        Me.PurposeOther.Size = New System.Drawing.Size(464, 22)
        Me.PurposeOther.TabIndex = 14
        '
        'Memo
        '
        Me.Memo.AutoScroll = True
        Me.Memo.AutoScrollMinSize = New System.Drawing.Size(0, 500)
        Me.Memo.BackColor = System.Drawing.Color.Azure
        Me.Memo.Controls.Add(Me.GrpMemo)
        Me.Memo.Location = New System.Drawing.Point(4, 22)
        Me.Memo.Name = "Memo"
        Me.Memo.Size = New System.Drawing.Size(650, 284)
        Me.Memo.TabIndex = 17
        Me.Memo.Text = "Memo"
        '
        'GrpMemo
        '
        Me.GrpMemo.BackColor = System.Drawing.Color.Azure
        Me.GrpMemo.Controls.Add(Label103)
        Me.GrpMemo.Controls.Add(Me.DTIssueDateMemo)
        Me.GrpMemo.Controls.Add(Label104)
        Me.GrpMemo.Controls.Add(Label105)
        Me.GrpMemo.Controls.Add(P2LastNameLabel2)
        Me.GrpMemo.Controls.Add(Me.P2LastNameMemo)
        Me.GrpMemo.Controls.Add(P2MiddleNameLabel2)
        Me.GrpMemo.Controls.Add(Me.P2MiddleNameMemo)
        Me.GrpMemo.Controls.Add(P2FirstNameLabel2)
        Me.GrpMemo.Controls.Add(Me.P2FirstNameMemo)
        Me.GrpMemo.Controls.Add(P2CompanyLabel2)
        Me.GrpMemo.Controls.Add(Me.P2CompanyMemo)
        Me.GrpMemo.Controls.Add(P1LastNameLabel2)
        Me.GrpMemo.Controls.Add(Me.P1LastNameMemo)
        Me.GrpMemo.Controls.Add(P1MiddleNameLabel2)
        Me.GrpMemo.Controls.Add(Me.P1MiddleNameMemo)
        Me.GrpMemo.Controls.Add(P1FirstNameLabel2)
        Me.GrpMemo.Controls.Add(Me.P1FirstNameMemo)
        Me.GrpMemo.Controls.Add(P1CompanyLabel2)
        Me.GrpMemo.Controls.Add(Me.P1CompanyMemo)
        Me.GrpMemo.Controls.Add(IssueDateLabel4)
        Me.GrpMemo.Controls.Add(Me.IssueDateMemo)
        Me.GrpMemo.Controls.Add(MemoSubjLabel)
        Me.GrpMemo.Controls.Add(Me.MemoSubjMemo)
        Me.GrpMemo.Controls.Add(MemoTypeLabel)
        Me.GrpMemo.Controls.Add(Me.MemoTypeMemo)
        Me.GrpMemo.Controls.Add(CompanyLabel8)
        Me.GrpMemo.Controls.Add(Me.CompanyMemo)
        Me.GrpMemo.Controls.Add(Label106)
        Me.GrpMemo.Controls.Add(Me.BoxNoMemo)
        Me.GrpMemo.Controls.Add(Label107)
        Me.GrpMemo.Controls.Add(Me.RackNoMemo)
        Me.GrpMemo.Controls.Add(Label108)
        Me.GrpMemo.Controls.Add(Me.PurposeMemo)
        Me.GrpMemo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpMemo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpMemo.ForeColor = System.Drawing.Color.Black
        Me.GrpMemo.Location = New System.Drawing.Point(0, 0)
        Me.GrpMemo.Name = "GrpMemo"
        Me.GrpMemo.Size = New System.Drawing.Size(633, 500)
        Me.GrpMemo.TabIndex = 3
        Me.GrpMemo.TabStop = False
        Me.GrpMemo.Text = "Keywords"
        '
        'DTIssueDateMemo
        '
        Me.DTIssueDateMemo.Location = New System.Drawing.Point(259, 165)
        Me.DTIssueDateMemo.Name = "DTIssueDateMemo"
        Me.DTIssueDateMemo.Size = New System.Drawing.Size(18, 22)
        Me.DTIssueDateMemo.TabIndex = 19
        '
        'P2LastNameMemo
        '
        Me.P2LastNameMemo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "P2LastName", True))
        Me.P2LastNameMemo.Location = New System.Drawing.Point(158, 416)
        Me.P2LastNameMemo.Name = "P2LastNameMemo"
        Me.P2LastNameMemo.Size = New System.Drawing.Size(464, 22)
        Me.P2LastNameMemo.TabIndex = 27
        '
        'P2MiddleNameMemo
        '
        Me.P2MiddleNameMemo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "P2MiddleName", True))
        Me.P2MiddleNameMemo.Location = New System.Drawing.Point(158, 393)
        Me.P2MiddleNameMemo.Name = "P2MiddleNameMemo"
        Me.P2MiddleNameMemo.Size = New System.Drawing.Size(464, 22)
        Me.P2MiddleNameMemo.TabIndex = 26
        '
        'P2FirstNameMemo
        '
        Me.P2FirstNameMemo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "P2FirstName", True))
        Me.P2FirstNameMemo.Location = New System.Drawing.Point(158, 370)
        Me.P2FirstNameMemo.Name = "P2FirstNameMemo"
        Me.P2FirstNameMemo.Size = New System.Drawing.Size(464, 22)
        Me.P2FirstNameMemo.TabIndex = 25
        '
        'P2CompanyMemo
        '
        Me.P2CompanyMemo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "P2Company", True))
        Me.P2CompanyMemo.Location = New System.Drawing.Point(158, 347)
        Me.P2CompanyMemo.Name = "P2CompanyMemo"
        Me.P2CompanyMemo.Size = New System.Drawing.Size(464, 22)
        Me.P2CompanyMemo.TabIndex = 24
        '
        'P1LastNameMemo
        '
        Me.P1LastNameMemo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "P1LastName", True))
        Me.P1LastNameMemo.Location = New System.Drawing.Point(158, 290)
        Me.P1LastNameMemo.Name = "P1LastNameMemo"
        Me.P1LastNameMemo.Size = New System.Drawing.Size(464, 22)
        Me.P1LastNameMemo.TabIndex = 23
        '
        'P1MiddleNameMemo
        '
        Me.P1MiddleNameMemo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "P1MiddleName", True))
        Me.P1MiddleNameMemo.Location = New System.Drawing.Point(158, 267)
        Me.P1MiddleNameMemo.Name = "P1MiddleNameMemo"
        Me.P1MiddleNameMemo.Size = New System.Drawing.Size(464, 22)
        Me.P1MiddleNameMemo.TabIndex = 22
        '
        'P1FirstNameMemo
        '
        Me.P1FirstNameMemo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "P1FirstName", True))
        Me.P1FirstNameMemo.Location = New System.Drawing.Point(158, 244)
        Me.P1FirstNameMemo.Name = "P1FirstNameMemo"
        Me.P1FirstNameMemo.Size = New System.Drawing.Size(464, 22)
        Me.P1FirstNameMemo.TabIndex = 21
        '
        'P1CompanyMemo
        '
        Me.P1CompanyMemo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "P1Company", True))
        Me.P1CompanyMemo.Location = New System.Drawing.Point(158, 221)
        Me.P1CompanyMemo.Name = "P1CompanyMemo"
        Me.P1CompanyMemo.Size = New System.Drawing.Size(464, 22)
        Me.P1CompanyMemo.TabIndex = 20
        '
        'IssueDateMemo
        '
        Me.IssueDateMemo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "IssueDate", True))
        Me.IssueDateMemo.Location = New System.Drawing.Point(158, 165)
        Me.IssueDateMemo.Name = "IssueDateMemo"
        Me.IssueDateMemo.Size = New System.Drawing.Size(100, 22)
        Me.IssueDateMemo.TabIndex = 18
        '
        'MemoSubjMemo
        '
        Me.MemoSubjMemo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "MemoSubj", True))
        Me.MemoSubjMemo.Location = New System.Drawing.Point(158, 119)
        Me.MemoSubjMemo.Name = "MemoSubjMemo"
        Me.MemoSubjMemo.Size = New System.Drawing.Size(464, 22)
        Me.MemoSubjMemo.TabIndex = 16
        '
        'MemoTypeMemo
        '
        Me.MemoTypeMemo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "MemoType", True))
        Me.MemoTypeMemo.Location = New System.Drawing.Point(158, 96)
        Me.MemoTypeMemo.Name = "MemoTypeMemo"
        Me.MemoTypeMemo.Size = New System.Drawing.Size(464, 22)
        Me.MemoTypeMemo.TabIndex = 15
        '
        'CompanyMemo
        '
        Me.CompanyMemo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Company", True))
        Me.CompanyMemo.Location = New System.Drawing.Point(158, 73)
        Me.CompanyMemo.Name = "CompanyMemo"
        Me.CompanyMemo.Size = New System.Drawing.Size(464, 22)
        Me.CompanyMemo.TabIndex = 14
        '
        'BoxNoMemo
        '
        Me.BoxNoMemo.BackColor = System.Drawing.Color.White
        Me.BoxNoMemo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "BoxNo", True))
        Me.BoxNoMemo.Location = New System.Drawing.Point(158, 50)
        Me.BoxNoMemo.Name = "BoxNoMemo"
        Me.BoxNoMemo.Size = New System.Drawing.Size(123, 22)
        Me.BoxNoMemo.TabIndex = 13
        '
        'RackNoMemo
        '
        Me.RackNoMemo.BackColor = System.Drawing.Color.White
        Me.RackNoMemo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "RackNo", True))
        Me.RackNoMemo.Location = New System.Drawing.Point(158, 27)
        Me.RackNoMemo.Name = "RackNoMemo"
        Me.RackNoMemo.Size = New System.Drawing.Size(123, 22)
        Me.RackNoMemo.TabIndex = 12
        '
        'PurposeMemo
        '
        Me.PurposeMemo.BackColor = System.Drawing.Color.White
        Me.PurposeMemo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocsCatalogueBindingSource, "Purpose", True))
        Me.PurposeMemo.Location = New System.Drawing.Point(158, 142)
        Me.PurposeMemo.Name = "PurposeMemo"
        Me.PurposeMemo.Size = New System.Drawing.Size(464, 22)
        Me.PurposeMemo.TabIndex = 17
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CHKFileName)
        Me.GroupBox2.Controls.Add(Me.sdasd)
        Me.GroupBox2.Controls.Add(Me.TxtFileName)
        Me.GroupBox2.Controls.Add(Me.CHKBatch)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TxtBatch)
        Me.GroupBox2.Controls.Add(Me.TxtBook)
        Me.GroupBox2.Controls.Add(Me.TxtBox)
        Me.GroupBox2.Controls.Add(Me.TxtRack)
        Me.GroupBox2.Controls.Add(Me.CHKScanDate)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.DTScanDateTo)
        Me.GroupBox2.Controls.Add(Me.DTScanDateFrom)
        Me.GroupBox2.Controls.Add(Me.CHKDocType)
        Me.GroupBox2.Controls.Add(Me.CHKDocDate)
        Me.GroupBox2.Controls.Add(Me.CHKBook)
        Me.GroupBox2.Controls.Add(Me.CHKBox)
        Me.GroupBox2.Controls.Add(Me.CHKRack)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.DTDocDateTo)
        Me.GroupBox2.Controls.Add(Me.DTDocDateFrom)
        Me.GroupBox2.Controls.Add(Me.DocumentTypeComboBox)
        Me.GroupBox2.Controls.Add(Me.DocumentTypeLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(561, 338)
        Me.GroupBox2.TabIndex = 91
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
        '
        'CHKFileName
        '
        Me.CHKFileName.AutoSize = True
        Me.CHKFileName.Location = New System.Drawing.Point(15, 34)
        Me.CHKFileName.Name = "CHKFileName"
        Me.CHKFileName.Size = New System.Drawing.Size(15, 14)
        Me.CHKFileName.TabIndex = 5
        Me.CHKFileName.UseVisualStyleBackColor = True
        '
        'sdasd
        '
        Me.sdasd.AutoSize = True
        Me.sdasd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sdasd.Location = New System.Drawing.Point(36, 30)
        Me.sdasd.Name = "sdasd"
        Me.sdasd.Size = New System.Drawing.Size(84, 20)
        Me.sdasd.TabIndex = 90
        Me.sdasd.Text = "File Name:"
        '
        'TxtFileName
        '
        Me.TxtFileName.Location = New System.Drawing.Point(163, 27)
        Me.TxtFileName.Name = "TxtFileName"
        Me.TxtFileName.Size = New System.Drawing.Size(157, 26)
        Me.TxtFileName.TabIndex = 6
        '
        'CHKBatch
        '
        Me.CHKBatch.AutoSize = True
        Me.CHKBatch.Location = New System.Drawing.Point(15, 142)
        Me.CHKBatch.Name = "CHKBatch"
        Me.CHKBatch.Size = New System.Drawing.Size(15, 14)
        Me.CHKBatch.TabIndex = 13
        Me.CHKBatch.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(36, 138)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 20)
        Me.Label11.TabIndex = 86
        Me.Label11.Text = "Batch No.:"
        '
        'TxtBatch
        '
        Me.TxtBatch.Location = New System.Drawing.Point(163, 135)
        Me.TxtBatch.Name = "TxtBatch"
        Me.TxtBatch.Size = New System.Drawing.Size(157, 26)
        Me.TxtBatch.TabIndex = 14
        '
        'TxtBook
        '
        Me.TxtBook.Location = New System.Drawing.Point(163, 108)
        Me.TxtBook.Name = "TxtBook"
        Me.TxtBook.Size = New System.Drawing.Size(157, 26)
        Me.TxtBook.TabIndex = 12
        '
        'TxtBox
        '
        Me.TxtBox.Location = New System.Drawing.Point(163, 81)
        Me.TxtBox.Name = "TxtBox"
        Me.TxtBox.Size = New System.Drawing.Size(157, 26)
        Me.TxtBox.TabIndex = 10
        '
        'TxtRack
        '
        Me.TxtRack.Location = New System.Drawing.Point(163, 54)
        Me.TxtRack.Name = "TxtRack"
        Me.TxtRack.Size = New System.Drawing.Size(157, 26)
        Me.TxtRack.TabIndex = 8
        '
        'CHKScanDate
        '
        Me.CHKScanDate.AutoSize = True
        Me.CHKScanDate.Location = New System.Drawing.Point(15, 230)
        Me.CHKScanDate.Name = "CHKScanDate"
        Me.CHKScanDate.Size = New System.Drawing.Size(15, 14)
        Me.CHKScanDate.TabIndex = 18
        Me.CHKScanDate.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(81, 253)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 20)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "From:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(283, 253)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 20)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "To:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(36, 226)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 20)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "Scanned Date:"
        '
        'DTScanDateTo
        '
        Me.DTScanDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTScanDateTo.Location = New System.Drawing.Point(318, 250)
        Me.DTScanDateTo.Name = "DTScanDateTo"
        Me.DTScanDateTo.Size = New System.Drawing.Size(129, 26)
        Me.DTScanDateTo.TabIndex = 20
        '
        'DTScanDateFrom
        '
        Me.DTScanDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTScanDateFrom.Location = New System.Drawing.Point(137, 250)
        Me.DTScanDateFrom.Name = "DTScanDateFrom"
        Me.DTScanDateFrom.Size = New System.Drawing.Size(129, 26)
        Me.DTScanDateFrom.TabIndex = 19
        '
        'CHKDocType
        '
        Me.CHKDocType.AutoSize = True
        Me.CHKDocType.Location = New System.Drawing.Point(15, 304)
        Me.CHKDocType.Name = "CHKDocType"
        Me.CHKDocType.Size = New System.Drawing.Size(15, 14)
        Me.CHKDocType.TabIndex = 21
        Me.CHKDocType.UseVisualStyleBackColor = True
        '
        'CHKDocDate
        '
        Me.CHKDocDate.AutoSize = True
        Me.CHKDocDate.Location = New System.Drawing.Point(15, 166)
        Me.CHKDocDate.Name = "CHKDocDate"
        Me.CHKDocDate.Size = New System.Drawing.Size(15, 14)
        Me.CHKDocDate.TabIndex = 15
        Me.CHKDocDate.UseVisualStyleBackColor = True
        '
        'CHKBook
        '
        Me.CHKBook.AutoSize = True
        Me.CHKBook.Location = New System.Drawing.Point(15, 115)
        Me.CHKBook.Name = "CHKBook"
        Me.CHKBook.Size = New System.Drawing.Size(15, 14)
        Me.CHKBook.TabIndex = 11
        Me.CHKBook.UseVisualStyleBackColor = True
        '
        'CHKBox
        '
        Me.CHKBox.AutoSize = True
        Me.CHKBox.Location = New System.Drawing.Point(15, 88)
        Me.CHKBox.Name = "CHKBox"
        Me.CHKBox.Size = New System.Drawing.Size(15, 14)
        Me.CHKBox.TabIndex = 9
        Me.CHKBox.UseVisualStyleBackColor = True
        '
        'CHKRack
        '
        Me.CHKRack.AutoSize = True
        Me.CHKRack.Location = New System.Drawing.Point(15, 61)
        Me.CHKRack.Name = "CHKRack"
        Me.CHKRack.Size = New System.Drawing.Size(15, 14)
        Me.CHKRack.TabIndex = 7
        Me.CHKRack.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(81, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 20)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "From:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(283, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 20)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "To:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 20)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Document Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Booklet No.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Box No.:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Rack No.:"
        '
        'DTDocDateTo
        '
        Me.DTDocDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTDocDateTo.Location = New System.Drawing.Point(318, 186)
        Me.DTDocDateTo.Name = "DTDocDateTo"
        Me.DTDocDateTo.Size = New System.Drawing.Size(129, 26)
        Me.DTDocDateTo.TabIndex = 17
        '
        'DTDocDateFrom
        '
        Me.DTDocDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTDocDateFrom.Location = New System.Drawing.Point(137, 186)
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
        Me.DocumentTypeComboBox.Location = New System.Drawing.Point(167, 297)
        Me.DocumentTypeComboBox.Name = "DocumentTypeComboBox"
        Me.DocumentTypeComboBox.Size = New System.Drawing.Size(384, 28)
        Me.DocumentTypeComboBox.TabIndex = 22
        '
        'DocumentTypeLabel
        '
        Me.DocumentTypeLabel.AutoSize = True
        Me.DocumentTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentTypeLabel.Location = New System.Drawing.Point(36, 300)
        Me.DocumentTypeLabel.Name = "DocumentTypeLabel"
        Me.DocumentTypeLabel.Size = New System.Drawing.Size(125, 20)
        Me.DocumentTypeLabel.TabIndex = 59
        Me.DocumentTypeLabel.Text = "Document Type:"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(578, 518)
        Me.WebBrowser1.TabIndex = 92
        Me.WebBrowser1.Url = New System.Uri("", System.UriKind.Relative)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
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
        CType(Me.C1TrueDBGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabQuery.ResumeLayout(False)
        Me.TabQuery.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabChanges.ResumeLayout(False)
        Me.TabChanges.PerformLayout()
        CType(Me.DocsCatalogueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.Importation.ResumeLayout(False)
        Me.GrpImportation.ResumeLayout(False)
        Me.GrpImportation.PerformLayout()
        Me.TabControl5.ResumeLayout(False)
        Me.LCNo.ResumeLayout(False)
        Me.LCNo.PerformLayout()
        Me.DPNo.ResumeLayout(False)
        Me.DPNo.PerformLayout()
        Me.OthersImport.ResumeLayout(False)
        Me.OthersImport.PerformLayout()
        Me.BIR.ResumeLayout(False)
        Me.GrpBIR.ResumeLayout(False)
        Me.GrpBIR.PerformLayout()
        Me.HRDoc.ResumeLayout(False)
        Me.GrpHRDoc.ResumeLayout(False)
        Me.GrpHRDoc.PerformLayout()
        Me.Copyright.ResumeLayout(False)
        Me.GrpCopy.ResumeLayout(False)
        Me.GrpCopy.PerformLayout()
        Me.Trademark.ResumeLayout(False)
        Me.GrpTrade.ResumeLayout(False)
        Me.GrpTrade.PerformLayout()
        Me.Patent.ResumeLayout(False)
        Me.GrpPatent.ResumeLayout(False)
        Me.GrpPatent.PerformLayout()
        Me.BIRClear.ResumeLayout(False)
        Me.GrpClear.ResumeLayout(False)
        Me.GrpClear.PerformLayout()
        Me.Accredit.ResumeLayout(False)
        Me.GrpAccre.ResumeLayout(False)
        Me.GrpAccre.PerformLayout()
        Me.Subs.ResumeLayout(False)
        Me.GrpSubs.ResumeLayout(False)
        Me.GrpSubs.PerformLayout()
        Me.Contract.ResumeLayout(False)
        Me.GrpContract.ResumeLayout(False)
        Me.GrpContract.PerformLayout()
        Me.Attorney.ResumeLayout(False)
        Me.GrpAttorney.ResumeLayout(False)
        Me.GrpAttorney.PerformLayout()
        Me.OtherDoc.ResumeLayout(False)
        Me.GrpOther.ResumeLayout(False)
        Me.GrpOther.PerformLayout()
        Me.Memo.ResumeLayout(False)
        Me.GrpMemo.ResumeLayout(False)
        Me.GrpMemo.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtWild As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents Importation As TabPage
    Friend WithEvents BIR As TabPage
    Friend WithEvents HRDoc As TabPage
    Friend WithEvents Copyright As TabPage
    Friend WithEvents Trademark As TabPage
    Friend WithEvents Patent As TabPage
    Friend WithEvents BIRClear As TabPage
    Friend WithEvents Accredit As TabPage
    Friend WithEvents Subs As TabPage
    Friend WithEvents Contract As TabPage
    Friend WithEvents Attorney As TabPage
    Friend WithEvents OtherDoc As TabPage
    Friend WithEvents Memo As TabPage
    Friend WithEvents GrpImportation As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DTVesselImport As DateTimePicker
    Friend WithEvents PolicyNoImport As TextBox
    Friend WithEvents InsuranceCompanyImport As TextBox
    Friend WithEvents RegNoImport As TextBox
    Friend WithEvents CustomsNoImport As TextBox
    Friend WithEvents BrokeCompanyImport As TextBox
    Friend WithEvents PaymentFormImport As ComboBox
    Friend WithEvents TabControl5 As TabControl
    Friend WithEvents LCNo As TabPage
    Friend WithEvents LetterCreditImport As TextBox
    Friend WithEvents DPNo As TabPage
    Friend WithEvents DPNoImport As TextBox
    Friend WithEvents OthersImport As TabPage
    Friend WithEvents PaymentOthersImport As TextBox
    Friend WithEvents BankBranchImport As TextBox
    Friend WithEvents BankNameImport As TextBox
    Friend WithEvents VesselArrivedImport As TextBox
    Friend WithEvents ContQtyx20Import As TextBox
    Friend WithEvents ContQtyx40Import As TextBox
    Friend WithEvents BillNoImport As TextBox
    Friend WithEvents ShipLineImport As TextBox
    Friend WithEvents CargoDescImport As TextBox
    Friend WithEvents ShipBatchImport As ComboBox
    Friend WithEvents PRONoImport As TextBox
    Friend WithEvents ISRNoImport As TextBox
    Friend WithEvents CountryImport As TextBox
    Friend WithEvents CompanyImport As TextBox
    Friend WithEvents ImpMonthImport As TextBox
    Friend WithEvents BoxNoImport As TextBox
    Friend WithEvents RackNoImport As TextBox
    Friend WithEvents GrpBIR As GroupBox
    Friend WithEvents AddressCBIR As TextBox
    Friend WithEvents YearReportBIR As TextBox
    Friend WithEvents TinVendorBIR As TextBox
    Friend WithEvents TinCustomerBIR As TextBox
    Friend WithEvents AddressBIR As TextBox
    Friend WithEvents CompanyBIR As TextBox
    Friend WithEvents BoxNoBIR As TextBox
    Friend WithEvents RackNoBIR As TextBox
    Friend WithEvents DTDocuBIR As DateTimePicker
    Friend WithEvents DocumentDateBIR As TextBox
    Friend WithEvents GrpHRDoc As GroupBox
    Friend WithEvents SexHRDoc As TextBox
    Friend WithEvents LastNameHRDoc As TextBox
    Friend WithEvents MiddleNameHRDoc As TextBox
    Friend WithEvents FirstNameHRDoc As TextBox
    Friend WithEvents CompanyHRDoc As TextBox
    Friend WithEvents BoxNoHRDoc As TextBox
    Friend WithEvents RackNoHRDoc As TextBox
    Friend WithEvents DTDocuHRDoc As DateTimePicker
    Friend WithEvents DocumentDateHRDoc As TextBox
    Friend WithEvents GrpCopy As GroupBox
    Friend WithEvents DTCreateDate As DateTimePicker
    Friend WithEvents PeriodProtectCopy As TextBox
    Friend WithEvents CreationDateCopy As TextBox
    Friend WithEvents ClassCopy As TextBox
    Friend WithEvents AuthorCopy As TextBox
    Friend WithEvents TitleCopy As TextBox
    Friend WithEvents RegNoCopy As TextBox
    Friend WithEvents BoxNoCopy As TextBox
    Friend WithEvents RackNoCopy As TextBox
    Friend WithEvents GrpTrade As GroupBox
    Friend WithEvents DTFilingTrade As DateTimePicker
    Friend WithEvents DTToTrade As DateTimePicker
    Friend WithEvents DTFromTrade As DateTimePicker
    Friend WithEvents DTRegDateTrade As DateTimePicker
    Friend WithEvents RegMarkTrade As TextBox
    Friend WithEvents RegistrantTrade As TextBox
    Friend WithEvents FilingDateTrade As TextBox
    Friend WithEvents ToPeriodTrade As TextBox
    Friend WithEvents FromPeriodTrade As TextBox
    Friend WithEvents TermTrade As TextBox
    Friend WithEvents RegDateTrade As TextBox
    Friend WithEvents RegNoTrade As TextBox
    Friend WithEvents BoxNoTrade As TextBox
    Friend WithEvents RackNoTrade As TextBox
    Friend WithEvents GrpPatent As GroupBox
    Friend WithEvents DTFilingPatent As DateTimePicker
    Friend WithEvents DTToPatent As DateTimePicker
    Friend WithEvents DTFromPatent As DateTimePicker
    Friend WithEvents DTRegDatePatent As DateTimePicker
    Friend WithEvents FilingDatePatent As TextBox
    Friend WithEvents TitlePatent As TextBox
    Friend WithEvents RegistrantPatent As TextBox
    Friend WithEvents ToPeriodPatent As TextBox
    Friend WithEvents FromPeriodPatent As TextBox
    Friend WithEvents TermPatent As TextBox
    Friend WithEvents RegDatePatent As TextBox
    Friend WithEvents RegNoPatent As TextBox
    Friend WithEvents BoxNoPatent As TextBox
    Friend WithEvents RackNoPatent As TextBox
    Friend WithEvents GrpClear As GroupBox
    Friend WithEvents DTToClear As DateTimePicker
    Friend WithEvents DTFromClear As DateTimePicker
    Friend WithEvents DTIssueDateClear As DateTimePicker
    Friend WithEvents ToPeriodClear As TextBox
    Friend WithEvents FromPeriodClear As TextBox
    Friend WithEvents TermClear As TextBox
    Friend WithEvents AccreditNoClear As TextBox
    Friend WithEvents IssueDateClear As TextBox
    Friend WithEvents TinCustomerClear As TextBox
    Friend WithEvents CompanyClear As TextBox
    Friend WithEvents BoxNoClear As TextBox
    Friend WithEvents RackNoClear As TextBox
    Friend WithEvents GrpAccre As GroupBox
    Friend WithEvents DTToAccre As DateTimePicker
    Friend WithEvents DTFromAccre As DateTimePicker
    Friend WithEvents DTIssueDateAccre As DateTimePicker
    Friend WithEvents ToPeriodAccre As TextBox
    Friend WithEvents FromPeriodAccre As TextBox
    Friend WithEvents TermAccre As TextBox
    Friend WithEvents AccreditNoAccre As TextBox
    Friend WithEvents IssueDateAccre As TextBox
    Friend WithEvents CompanyAccre As TextBox
    Friend WithEvents BoxNoAccre As TextBox
    Friend WithEvents RackNoAccre As TextBox
    Friend WithEvents GrpSubs As GroupBox
    Friend WithEvents DTToSubs As DateTimePicker
    Friend WithEvents DTFromSubs As DateTimePicker
    Friend WithEvents DTSubsDateSubs As DateTimePicker
    Friend WithEvents ToPeriodSubs As TextBox
    Friend WithEvents FromPeriodSubs As TextBox
    Friend WithEvents TermSubs As TextBox
    Friend WithEvents SubsDateSubs As TextBox
    Friend WithEvents GLNSubs As TextBox
    Friend WithEvents CompanyPrefixSubs As TextBox
    Friend WithEvents CompanySubs As TextBox
    Friend WithEvents BoxNoSubs As TextBox
    Friend WithEvents RackNoSubs As TextBox
    Friend WithEvents GrpContract As GroupBox
    Friend WithEvents DTDateSignContract As DateTimePicker
    Friend WithEvents DTToContract As DateTimePicker
    Friend WithEvents DTFromContract As DateTimePicker
    Friend WithEvents P2PositionContract As TextBox
    Friend WithEvents P2LastNameContract As TextBox
    Friend WithEvents P2MiddleNameContract As TextBox
    Friend WithEvents P2FirstNameContract As TextBox
    Friend WithEvents P2CompanyContract As TextBox
    Friend WithEvents P1PositionContract As TextBox
    Friend WithEvents P1LastNameContract As TextBox
    Friend WithEvents P1MiddleNameContract As TextBox
    Friend WithEvents P1FirstNameContract As TextBox
    Friend WithEvents P1CompanyContract As TextBox
    Friend WithEvents ContractPlaceContract As TextBox
    Friend WithEvents SignDateContract As TextBox
    Friend WithEvents ToPeriodContract As TextBox
    Friend WithEvents FromPeriodContract As TextBox
    Friend WithEvents PurposeContract As TextBox
    Friend WithEvents ContractTypeContract As TextBox
    Friend WithEvents BoxNoContract As TextBox
    Friend WithEvents RackNoContract As TextBox
    Friend WithEvents GrpAttorney As GroupBox
    Friend WithEvents DTToAttorney As DateTimePicker
    Friend WithEvents DTFromAttorney As DateTimePicker
    Friend WithEvents DTIssuePlaceAttorney As DateTimePicker
    Friend WithEvents DTIssueDateAttorney As DateTimePicker
    Friend WithEvents ToPeriodAttorney As TextBox
    Friend WithEvents FromPeriodAttorney As TextBox
    Friend WithEvents P2LastNameAttorney As TextBox
    Friend WithEvents P2MiddleNameAttorney As TextBox
    Friend WithEvents P2FirstNameAttorney As TextBox
    Friend WithEvents P2CompanyAttorney As TextBox
    Friend WithEvents P1LastNameAttorney As TextBox
    Friend WithEvents P1MiddleNameAttorney As TextBox
    Friend WithEvents P1FirstNameAttorney As TextBox
    Friend WithEvents P1CompanyAttorney As TextBox
    Friend WithEvents IssuePlaceAttorney As TextBox
    Friend WithEvents IssueDateAttorney As TextBox
    Friend WithEvents BoxNoAttorney As TextBox
    Friend WithEvents RackNoAttorney As TextBox
    Friend WithEvents PurposeAttorney As TextBox
    Friend WithEvents GrpOther As GroupBox
    Friend WithEvents DTIssuePlaceOther As DateTimePicker
    Friend WithEvents DTIssueDateOther As DateTimePicker
    Friend WithEvents LastNameOther As TextBox
    Friend WithEvents MiddleNameOther As TextBox
    Friend WithEvents FirstNameOther As TextBox
    Friend WithEvents CompanyOther As TextBox
    Friend WithEvents IssuePlaceOther As TextBox
    Friend WithEvents IssueDateOther As TextBox
    Friend WithEvents BoxNoOther As TextBox
    Friend WithEvents RackNoOther As TextBox
    Friend WithEvents PurposeOther As TextBox
    Friend WithEvents GrpMemo As GroupBox
    Friend WithEvents DTIssueDateMemo As DateTimePicker
    Friend WithEvents P2LastNameMemo As TextBox
    Friend WithEvents P2MiddleNameMemo As TextBox
    Friend WithEvents P2FirstNameMemo As TextBox
    Friend WithEvents P2CompanyMemo As TextBox
    Friend WithEvents P1LastNameMemo As TextBox
    Friend WithEvents P1MiddleNameMemo As TextBox
    Friend WithEvents P1FirstNameMemo As TextBox
    Friend WithEvents P1CompanyMemo As TextBox
    Friend WithEvents IssueDateMemo As TextBox
    Friend WithEvents MemoSubjMemo As TextBox
    Friend WithEvents MemoTypeMemo As TextBox
    Friend WithEvents CompanyMemo As TextBox
    Friend WithEvents BoxNoMemo As TextBox
    Friend WithEvents RackNoMemo As TextBox
    Friend WithEvents PurposeMemo As TextBox
End Class


