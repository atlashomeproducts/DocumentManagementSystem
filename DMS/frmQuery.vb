
Imports C1.Win.C1TrueDBGrid

Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports System.ComponentModel

Public Class FrmQuery
    Private Sub FrmQuery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateCombobox()


        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.SizeMode = TabSizeMode.Fixed
        For Each TabPage In TabControl1.TabPages

            TabPage.Text = ""

        Next



        TabControl2.Appearance = TabAppearance.FlatButtons
        TabControl2.ItemSize = New Size(0, 1)
        TabControl2.SizeMode = TabSizeMode.Fixed
        For Each TabPage In TabControl2.TabPages

            TabPage.Text = ""

        Next

    End Sub
    Private Sub PopulateCombobox()

        Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("SELECT DocumentType FROM DocumentTypes ORDER BY DocumentType", con)

        Dim read As SqlDataReader = cmd.ExecuteReader()
        While read.Read()
            DocumentTypeComboBox.Items.Add(read.GetString(0))
        End While
        con.Close()



        Me.PaymentFormComboBox.Items.Add("Bank Deposit")
        Me.PaymentFormComboBox.Items.Add("Cash")
        Me.PaymentFormComboBox.Items.Add("Check")
        Me.PaymentFormComboBox.Items.Add("Others")

    End Sub

    Private Sub ComboSelect()

        If Me.DocumentTypeComboBox.Text = "Sales Invoice" Then
            TabControl1.SelectTab(ReceiptInvoice)
        ElseIf Me.DocumentTypeComboBox.Text = "Official Receipt" Then
            TabControl1.SelectTab(ReceiptInvoice)
        ElseIf Me.DocumentTypeComboBox.Text = "Delivery Receipt" Then
            TabControl1.SelectTab(ReceiptInvoice)
        ElseIf Me.DocumentTypeComboBox.Text = "Acknowledgement Receipt" Then
            TabControl1.SelectTab(ReceiptInvoice)
        ElseIf Me.DocumentTypeComboBox.Text = "Collection Receipt" Then
            TabControl1.SelectTab(ReceiptInvoice)
        ElseIf Me.DocumentTypeComboBox.Text = "Provisional Receipt" Then
            TabControl1.SelectTab(ReceiptInvoice)



        ElseIf Me.DocumentTypeComboBox.Text = "Daily Time Record" Then
            TabControl1.SelectTab(Timesheet)


        ElseIf Me.DocumentTypeComboBox.Text = "Warranty Card" Then
            TabControl1.SelectTab(Warranty)


        ElseIf Me.DocumentTypeComboBox.Text = "Payment Voucher" Then
            TabControl1.SelectTab(Voucher)


        ElseIf Me.DocumentTypeComboBox.Text = "Secretary's Certificate" Then
            TabControl1.SelectTab(CorpDocu)
        ElseIf Me.DocumentTypeComboBox.Text = "Minutes of Board Meeting" Then
            TabControl1.SelectTab(CorpDocu)
        ElseIf Me.DocumentTypeComboBox.Text = "Articles of Incorporation" Then
            TabControl1.SelectTab(CorpDocu)
        ElseIf Me.DocumentTypeComboBox.Text = "SEC Certificate of Registration" Then
            TabControl1.SelectTab(CorpDocu)
        ElseIf Me.DocumentTypeComboBox.Text = "DTI Registration" Then
            TabControl1.SelectTab(CorpDocu)
        ElseIf Me.DocumentTypeComboBox.Text = "Financial Statement" Then
            TabControl1.SelectTab(CorpDocu)







        End If

    End Sub

    Private Sub DocumentTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DocumentTypeComboBox.SelectedIndexChanged
        ComboSelect()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles TSSearch.Click


        If DocumentTypeComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Please Select Document Type", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            'Create a variable to hold your parameter value
            Dim id As Integer = 0
            'Create your query as you already have done
            Dim strsql As String = "SELECT 
Id

, RackNo as [Rack No]
, BoxNo as [Box No]
, DocumentDate as [Document Date]
, LastName as [Last Name]
, FirstName as [First Name] 
, MiddleName as [Middle Name]
, FromPeriod as [From]
, ToPeriod as [To]
, Filename as [File Name]

FROM DocsCatalogue 

WHERE ISNULL(FirstName, '') LIKE '%' + @FirstName + '%'
AND ISNULL(LastName, '') LIKE '%' + @LastName + '%'
AND ISNULL(MiddleName, '') LIKE '%' + @MiddleName + '%'
AND ISNULL(DocumentType, '') LIKE '%' + @DocType + '%'
AND ISNULL(FromPeriod, '') LIKE '%' + @FromPeriod + '%'
AND ISNULL(ToPeriod, '') LIKE '%' + @ToPeriod + '%'
AND ISNULL(Rackno, '') LIKE '%' + @RackNo + '%'
AND ISNULL(BoxNo, '') LIKE '%' + @BoxNo + '%'
AND ISNULL(DocumentDate, '') LIKE '%' + @DocDate + '%'
AND ISNULL(FromPeriod, '') LIKE  '%' + @From + '%'
AND ISNULL(ToPeriod, '') LIKE '%' + @To + '%'
AND Status = 'Finished'


"
            ' AND Status = "Finished"

            'Get your connection string (You've done this right)
            Dim strconnectionstring As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
            'Create your SqlConnection (Done)
            'Create your SqlCommand (done)
            Dim objcommand As New SqlCommand()

            '**Set your command properties**
            With objcommand
                .CommandText = strsql
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@Firstname", Me.FirstNameTextBox.Text)
                .Parameters.AddWithValue("@LastName", Me.LastNameTextBox.Text)
                .Parameters.AddWithValue("@Middlename", Me.MiddleNameTextBox.Text)
                .Parameters.AddWithValue("@DocType", Me.DocumentTypeComboBox.Text)
                .Parameters.AddWithValue("@FromPeriod", Me.FromPeriodTextBox.Text)
                .Parameters.AddWithValue("@ToPeriod", Me.ToPeriodTextBox.Text)
                .Parameters.AddWithValue("@RackNo", Me.RackNoTS.Text)
                .Parameters.AddWithValue("@BoxNo", Me.BoxNoTS.Text)
                .Parameters.AddWithValue("@DocDate", Me.DocumentDateTS.Text)
                .Parameters.AddWithValue("@From", Me.FromPeriodTextBox.Text)
                .Parameters.AddWithValue("@To", Me.ToPeriodTextBox.Text)



                .Connection = strconnectionstring
            End With
            'Create a new SqlDataAdapter
            Dim objdataAdapter As New SqlDataAdapter()
            'Set the SelectCommand property of our adapter
            objdataAdapter.SelectCommand = objcommand
            'Create a new DataSet
            Dim objdataset As New DataSet
            'Fill the DataSet using the SqlDataAdapter
            objdataAdapter.Fill(objdataset, "DMS")

            Dim objbindingsource As New BindingSource
            objbindingsource.DataSource = objdataset.Tables("DMS")
            C1TrueDBGrid1.DataSource = objbindingsource

            Me.C1TrueDBGrid1.Splits(0).DisplayColumns("Id").Visible = False

            Me.C1TrueDBGrid1.Splits(0).ExtendRightColumn = True



        End If
    End Sub

    Private Sub DTFromPeriod_ValueChanged(sender As Object, e As EventArgs) Handles DTFromPeriod.ValueChanged
        Me.FromPeriodTextBox.Text = Me.DTFromPeriod.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles RISearch.Click


        If DocumentTypeComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Please Select Document Type", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else


            'Create a variable to hold your parameter value
            Dim id As Integer = 0
            'Create your query as you already have done
            Dim strsql As String = "SELECT 
Id
, RackNo as [Rack No]
, BoxNo as [Box No]
, BookletNo [Booklet No]
, DocumentDate as [Document Date]
, ReferenceNo [Invoice/Receipt]
, Vendor [Vendor]
, Customer [Customer]
, AddressC [Customer Address]
, TinVendor [Tin of Vendor]
, TinCustomer [Tin of Customer]
, ItemPurchased [Item Purchased]
, TotalValue [Total Value]
, Filename as [File Name]

FROM DocsCatalogue 

WHERE ISNULL(DocumentDate, '') LIKE '%' + @DocumentDate + '%'
AND ISNULL(DocumentType, '') LIKE '%' + @DocumentType + '%'
AND ISNULL(Rackno, '') LIKE '%' + @RackNo + '%'
AND ISNULL(BoxNo, '') LIKE '%' + @BoxNo + '%'
AND ISNULL(ReferenceNo, '') LIKE '%' + @ReferenceNo + '%'
AND ISNULL(Vendor, '') LIKE '%' + @Vendor + '%'
AND ISNULL(Customer, '') LIKE '%' + @Customer + '%'
AND ISNULL(AddressC, '') LIKE '%' + @AddressC + '%'
AND ISNULL(TinVendor, '') LIKE '%' + @TinVendor + '%'
AND ISNULL(TinCustomer, '') LIKE '%' + @TinCustomer + '%'
AND ISNULL(ItemPurchased, '') LIKE '%' + @ItemPurchased + '%'
AND ISNULL(TotalValue, '') LIKE '%' + @TotalValue + '%'
AND Status = 'Finished'




"
            'AND Status = "Finished"

            'Get your connection string (You've done this right)
            Dim strconnectionstring As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
            'Create your SqlConnection (Done)
            'Create your SqlCommand (done)
            Dim objcommand As New SqlCommand()

            '**Set your command properties**
            With objcommand
                .CommandText = strsql
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@DocumentDate", Me.DocumentDateRI.Text)
                .Parameters.AddWithValue("@DocumentType", Me.DocumentTypeComboBox.Text)
                .Parameters.AddWithValue("@Rackno", Me.RackNoRI.Text)
                .Parameters.AddWithValue("@BoxNo", Me.BoxNoRI.Text)
                .Parameters.AddWithValue("@ReferenceNo", Me.ReferenceNoRI.Text)
                .Parameters.AddWithValue("@Vendor", Me.VendorTextBox.Text)
                .Parameters.AddWithValue("@Customer", Me.CustomerTextBox.Text)
                .Parameters.AddWithValue("@AddressC", Me.AddressCTextBox.Text)
                .Parameters.AddWithValue("@TinVendor", Me.TinVendorTextBox.Text)
                .Parameters.AddWithValue("@TinCustomer", Me.TinCustomerTextBox.Text)
                .Parameters.AddWithValue("@ItemPurchased", Me.ItemPurchasedTextBox.Text)
                .Parameters.AddWithValue("@TotalValue", Me.TotalValueRI.Text)




                .Connection = strconnectionstring
            End With
            'Create a new SqlDataAdapter
            Dim objdataAdapter As New SqlDataAdapter()
            'Set the SelectCommand property of our adapter
            objdataAdapter.SelectCommand = objcommand
            'Create a new DataSet
            Dim objdataset As New DataSet
            'Fill the DataSet using the SqlDataAdapter
            objdataAdapter.Fill(objdataset, "DMS")

            Dim objbindingsource As New BindingSource
            objbindingsource.DataSource = objdataset.Tables("DMS")
            C1TrueDBGrid1.DataSource = objbindingsource

            Me.C1TrueDBGrid1.Splits(0).DisplayColumns("Id").Visible = False
            Me.C1TrueDBGrid1.Splits(0).ExtendRightColumn = True

        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles WarrantySearch.Click

        If DocumentTypeComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Please Select Document Type", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else



            'Create a variable to hold your parameter value
            Dim id As Integer = 0
            'Create your query as you already have done
            Dim strsql As String = "SELECT 
Id

, RackNo as [Rack No]
, BoxNo as [Box No]
, ProductBrand [Product Brand]
, ProductType [Product Type]
, Serial [Serial]
, DatePurchased [Date Purchased]
, ReferenceNo [Invoice No]
, WarrantyNo [WarrantyNo]
, WarrantyPeriod [Warranty Period]
, ServiceCenter [Service Center]
, Address [Address]
, ContactNo [Contact No]
, Email [Email]
, TotalValue [Amount]
, Filename as [File Name]


FROM DocsCatalogue 

WHERE
ISNULL(DocumentType, '') LIKE '%' + @DocumentType + '%'
AND ISNULL(Rackno, '') LIKE '%' + @RackNo + '%'
AND ISNULL(BoxNo, '') LIKE '%' + @BoxNo + '%'
AND ISNULL(ProductBrand, '') LIKE '%' + @ProductBrand + '%'
AND ISNULL(ProductType, '') LIKE '%' + @ProductType + '%'
AND ISNULL(Serial, '') LIKE '%' + @Serial + '%'
AND ISNULL(DatePurchased, '') LIKE '%' + @DatePurchased + '%'
AND ISNULL(ReferenceNo, '') LIKE '%' + @ReferenceNo + '%'
AND ISNULL(WarrantyNo, '') LIKE '%' + @WarrantyNo + '%'
AND ISNULL(WarrantyPeriod, '') LIKE '%' + @WarrantyPeriod + '%'
AND ISNULL(ServiceCenter, '') LIKE '%' + @ServiceCenter + '%'
AND ISNULL(Address, '') LIKE '%' + @Address + '%'
AND ISNULL(ContactNo, '') LIKE '%' + @ContactNo + '%'
AND ISNULL(Email, '') LIKE '%' + @Email + '%'
AND ISNULL(TotalValue, '') LIKE '%' + @TotalValue + '%'
AND Status = 'Finished'




"
            'AND Status = "Finished"

            'Get your connection string (You've done this right)
            Dim strconnectionstring As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
            'Create your SqlConnection (Done)
            'Create your SqlCommand (done)
            Dim objcommand As New SqlCommand()

            '**Set your command properties**
            With objcommand
                .CommandText = strsql
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@DocumentType", Me.DocumentTypeComboBox.Text)
                .Parameters.AddWithValue("@Rackno", Me.RackNoWarranty.Text)
                .Parameters.AddWithValue("@BoxNo", Me.BoxNoWarranty.Text)
                .Parameters.AddWithValue("@ProductBrand", Me.ProductBrandTextBox.Text)
                .Parameters.AddWithValue("@ProductType", Me.ProductTypeTextBox.Text)
                .Parameters.AddWithValue("@Serial", Me.SerialTextBox.Text)
                .Parameters.AddWithValue("@DatePurchased", Me.DatePurchasedTextBox.Text)
                .Parameters.AddWithValue("@ReferenceNo", Me.ReferenceNoTextBox1.Text)
                .Parameters.AddWithValue("@WarrantyNo", Me.WarrantyNoTextBox.Text)
                .Parameters.AddWithValue("@WarrantyPeriod", Me.WarrantyPeriodTextBox.Text)
                .Parameters.AddWithValue("@ServiceCenter", Me.ServiceCenterTextBox.Text)
                .Parameters.AddWithValue("@Address", Me.AddressTextBox.Text)
                .Parameters.AddWithValue("@ContactNo", Me.ContactNoTextBox.Text)
                .Parameters.AddWithValue("@Email", Me.EmailTextBox.Text)
                .Parameters.AddWithValue("@TotalValue", Me.TotalValueWarranty.Text)


                .Connection = strconnectionstring
            End With
            'Create a new SqlDataAdapter
            Dim objdataAdapter As New SqlDataAdapter()
            'Set the SelectCommand property of our adapter
            objdataAdapter.SelectCommand = objcommand
            'Create a new DataSet
            Dim objdataset As New DataSet
            'Fill the DataSet using the SqlDataAdapter
            objdataAdapter.Fill(objdataset, "DMS")

            Dim objbindingsource As New BindingSource
            objbindingsource.DataSource = objdataset.Tables("DMS")
            C1TrueDBGrid1.DataSource = objbindingsource

            Me.C1TrueDBGrid1.Splits(0).DisplayColumns("Id").Visible = False
            Me.C1TrueDBGrid1.Splits(0).ExtendRightColumn = True

        End If

    End Sub

    Private Sub CorpDocuSearch_Click(sender As Object, e As EventArgs) Handles CorpDocuSearch.Click

        If DocumentTypeComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Please Select Document Type", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else


            'Create a variable to hold your parameter value
            Dim id As Integer = 0
            'Create your query as you already have done
            Dim strsql As String = "SELECT 
Id

, RackNo as [Rack No]
, BoxNo as [Box No]
, DocumentDate as [Document Date]
, MeetingDate [Meeting Date]
, Company [Company]
, Secretary [Secretary]
, Purpose [Purpose]
, Filename as [File Name]

FROM DocsCatalogue 

WHERE
ISNULL(DocumentDate, '') LIKE '%' + @DocumentDate + '%' 
AND ISNULL(DocumentType, '') LIKE '%' + @DocumentType + '%'
AND ISNULL(Rackno, '') LIKE '%' + @RackNo + '%'
AND ISNULL(BoxNo, '') LIKE '%' + @BoxNo + '%'
AND ISNULL(MeetingDate, '') LIKE '%' + @MeetingDate + '%'
AND ISNULL(Company, '') LIKE '%' + @Company + '%'
AND ISNULL(Secretary, '') LIKE '%' + @Secretary + '%'
AND ISNULL(Purpose, '') LIKE '%' + @Purpose + '%'
AND Status = 'Finished'




"
            'AND Status = 'Finished'

            'Get your connection string (You've done this right)
            Dim strconnectionstring As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
            'Create your SqlConnection (Done)
            'Create your SqlCommand (done)
            Dim objcommand As New SqlCommand()

            '**Set your command properties**
            With objcommand
                .CommandText = strsql
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@DocumentDate", Me.DocumentDateVoucher.Text)
                .Parameters.AddWithValue("@DocumentType", Me.DocumentTypeComboBox.Text)
                .Parameters.AddWithValue("@Rackno", Me.RackNoCorpDocu.Text)
                .Parameters.AddWithValue("@BoxNo", Me.BoxNoCorpDocu.Text)
                .Parameters.AddWithValue("@MeetingDate", Me.MeetingDateTextBox.Text)
                .Parameters.AddWithValue("@Company", Me.CompanyTextBox.Text)
                .Parameters.AddWithValue("@Secretary", Me.SecretaryTextBox.Text)
                .Parameters.AddWithValue("@Purpose", Me.PurposeTextBox.Text)



                .Connection = strconnectionstring
            End With
            'Create a new SqlDataAdapter
            Dim objdataAdapter As New SqlDataAdapter()
            'Set the SelectCommand property of our adapter
            objdataAdapter.SelectCommand = objcommand
            'Create a new DataSet
            Dim objdataset As New DataSet
            'Fill the DataSet using the SqlDataAdapter
            objdataAdapter.Fill(objdataset, "DMS")

            Dim objbindingsource As New BindingSource
            objbindingsource.DataSource = objdataset.Tables("DMS")
            C1TrueDBGrid1.DataSource = objbindingsource

            Me.C1TrueDBGrid1.Splits(0).DisplayColumns("Id").Visible = False
            Me.C1TrueDBGrid1.Splits(0).ExtendRightColumn = True



        End If

    End Sub

    Private Sub VoucherSearch_Click(sender As Object, e As EventArgs) Handles VoucherSearch.Click

        If DocumentTypeComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Please Select Document Type", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else


            'Create a variable to hold your parameter value
            Dim id As Integer = 0
            'Create your query as you already have done
            Dim strsql As String = "SELECT 
Id

, RackNo as [Rack No]
, BoxNo as [Box No]
, DocumentDate as [Document Date]
, Payee [Payee]
, Payor [Payor]
, VoucherNo [VoucherNo]
, PaymentForm [Form of Payment]
, BankName [Bank Name]
, BankBranch [Bank Branch]
, BankAddress [Bank Address]
, PaymentOthers [PaymentOthers]
, CheckNo [Check No]
, TotalValue [Total Value]
, Preparedby [Prepared By]
, Approvedby [Approved By]
, Recordedby [Recorded By]
, Receivedby [Received By]
, DateReceived [Date Received]
, Filename as [File Name]

FROM DocsCatalogue 

WHERE
ISNULL(DocumentDate, '') LIKE '%' + @DocumentDate + '%' 
AND ISNULL(DocumentType, '') LIKE '%' + @DocumentType + '%'
AND ISNULL(Rackno, '') LIKE '%' + @RackNo + '%'
AND ISNULL(BoxNo, '') LIKE '%' + @BoxNo + '%'
AND ISNULL(Payee, '') LIKE '%' + @Payee + '%'
AND ISNULL(Payor, '') LIKE '%' + @Payor + '%'
AND ISNULL(VoucherNo, '') LIKE '%' + @VoucherNo + '%'
AND ISNULL(PaymentForm, '') LIKE '%' + @PaymentForm + '%'
AND ISNULL(BankName, '') LIKE '%' + @BankName + '%'
AND ISNULL(BankBranch, '') LIKE '%' + @BankBranch + '%'
AND ISNULL(BankAddress, '') LIKE '%' + @BankAddress + '%'
AND ISNULL(PaymentOthers, '') LIKE '%' + @PaymentOthers + '%'
AND ISNULL(CheckNo, '') LIKE '%' + @CheckNo + '%'
AND ISNULL(TotalValue, '') LIKE '%' + @TotalValue + '%'
AND ISNULL(Preparedby, '') LIKE '%' + @Preparedby + '%'
AND ISNULL(Approvedby, '') LIKE '%' + @Approvedby + '%'
AND ISNULL(Recordedby, '') LIKE '%' + @Recordedby + '%'
AND ISNULL(Receivedby, '') LIKE '%' + @Receivedby + '%'
AND ISNULL(DateReceived, '') LIKE '%' + @DateReceived + '%'
AND Status = 'Finished'




"
            'AND Status = "Finished"

            'Get your connection string (You've done this right)
            Dim strconnectionstring As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
            'Create your SqlConnection (Done)
            'Create your SqlCommand (done)
            Dim objcommand As New SqlCommand()

            '**Set your command properties**
            With objcommand
                .CommandText = strsql
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@DocumentDate", Me.DocumentDateVoucher.Text)
                .Parameters.AddWithValue("@DocumentType", Me.DocumentTypeComboBox.Text)
                .Parameters.AddWithValue("@Rackno", Me.RackNoVoucher.Text)
                .Parameters.AddWithValue("@BoxNo", Me.BoxNoVoucher.Text)
                .Parameters.AddWithValue("@Payee", Me.PayeeTextBox.Text)
                .Parameters.AddWithValue("@Payor", Me.PayorTextBox.Text)
                .Parameters.AddWithValue("@VoucherNo", Me.VoucherNoTextBox.Text)
                .Parameters.AddWithValue("@PaymentForm", Me.PaymentFormComboBox.Text)
                .Parameters.AddWithValue("@BankName", Me.BankNameTextBox.Text)
                .Parameters.AddWithValue("@BankBranch", Me.BankBranchTextBox.Text)
                .Parameters.AddWithValue("@BankAddress", Me.BankAddressTextBox.Text)
                .Parameters.AddWithValue("@PaymentOthers", Me.PaymentOthersTextBox.Text)
                .Parameters.AddWithValue("@CheckNo", Me.CheckNoTextBox.Text)
                .Parameters.AddWithValue("@TotalValue", Me.TotalValueVoucher.Text)
                .Parameters.AddWithValue("@Preparedby", Me.PreparedbyTextBox.Text)
                .Parameters.AddWithValue("@Approvedby", Me.ApprovedbyTextBox.Text)
                .Parameters.AddWithValue("@Recordedby", Me.RecordedbyTextBox.Text)
                .Parameters.AddWithValue("@Receivedby", Me.ReceivedbyTextBox.Text)
                .Parameters.AddWithValue("@DateReceived", Me.DateReceivedTextBox.Text)


                .Connection = strconnectionstring
            End With
            'Create a new SqlDataAdapter
            Dim objdataAdapter As New SqlDataAdapter()
            'Set the SelectCommand property of our adapter
            objdataAdapter.SelectCommand = objcommand
            'Create a new DataSet
            Dim objdataset As New DataSet
            'Fill the DataSet using the SqlDataAdapter
            objdataAdapter.Fill(objdataset, "DMS")

            Dim objbindingsource As New BindingSource
            objbindingsource.DataSource = objdataset.Tables("DMS")
            C1TrueDBGrid1.DataSource = objbindingsource

            Me.C1TrueDBGrid1.Splits(0).DisplayColumns("Id").Visible = False
            Me.C1TrueDBGrid1.Splits(0).ExtendRightColumn = True


        End If
    End Sub

    Private Sub C1TrueDBGrid1_Click(sender As Object, e As EventArgs) Handles C1TrueDBGrid1.Click





    End Sub

    Private Sub C1TrueDBGrid1_DoubleClick(sender As Object, e As EventArgs) Handles C1TrueDBGrid1.DoubleClick
        Try

            AxAcroPDF1.src = (My.Settings.ImgPath & "\" & Me.C1TrueDBGrid1.Columns("File Name").Text)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class