
Imports C1.Win.C1TrueDBGrid

Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports System.ComponentModel

Public Class FrmQuery
    Private Sub FrmQuery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateCombobox()

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




    End Sub



    Private Sub DocumentTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) 

    End Sub


    Private Sub C1TrueDBGrid1_DoubleClick(sender As Object, e As EventArgs) Handles C1TrueDBGrid1.DoubleClick
        Try

            AcroPDF.src = (My.Settings.ImgPath & "\" & Me.C1TrueDBGrid1.Columns("File Name").Text)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) 



        'Create a variable to hold your parameter value
        Dim id As Integer = 0
        'Create your query as you already have done
        Dim strsql As String = "SELECT 
                [Id]
              ,[DocumentType] [Document Type]
              ,[Batch]
             
              ,[BatchDesc] [Batch Description]
              ,[RackNo] [Rack No]
              ,[BoxNo] [Box No]
              ,[ScannedDate] [Scanned Date]
              ,[Filename] [File Name]     
              ,[DocumentDate] [Document Date]
              ,[ReferenceNo] [Reference No]
              ,[BookletNo] [Booklet No]
              ,[Vendor]
              ,[Customer]
              ,[ItemPurchased] [Item Purchased]
              ,[TotalValue] [Total Value]
              ,[LastName] [Last Name]
              ,[FirstName] [First Name]
              ,[MiddleName] [Middle Name]
              ,[FromPeriod] [From]
              ,[ToPeriod] [To]
              ,[WarrantyNo] [Warranty No]
              ,[ProductBrand] [Product Brand]
              ,[ProductType] [Product Type]
              ,[DatePurchased] [Date Purchased]
              ,[Serial] 
              ,[WarrantyPeriod] [Warranty Period]
              ,[ServiceCenter] [Service Center]
              ,[Address] [Service Center Address]
              ,[ContactNo] [Contact No]
              ,[Email] [E-Mail]
              ,[VoucherNo] [Voucher No]
              ,[PaymentForm] [Form Of Payment]
              ,[CheckNo] [Check No]
              ,[Payee]
              ,[Payor]
              ,[Preparedby] [Prepared By]
              ,[Approvedby] [Approved By]
              ,[Recordedby] [Recorded By]
              ,[Receivedby] [Received By]
              ,[Company]   
              ,[Purpose]   
              ,[Secretary] 
              ,[MeetingDate] [Meeting Date]
              ,[PaymentOthers] [Payment Others]
              ,[BankName] [Bank Name]
              ,[BankBranch] [Bank Branch]
              ,[BankAddress] [Bank Address] 
              ,[TinVendor] [Tin of Vendor]
              ,[TinCustomer] [Tin of Customer]
              ,[VATreg] [VAT-Registered]
              ,[NONVATreg] [NONVAT-Registered]
              ,[DateReceived] [Date Received]
              ,[AddressC] [Customer Address]


                FROM DocsCatalogue 

WHERE
ISNULL(DocumentDate, '') BETWEEN @DocDateFrom AND @DocDateTo
AND ISNULL(RackNo, '') LIKE '%' + @RackNo + '%'
AND ISNULL(BoxNo, '') LIKE '%' + @BoxNo + '%'
AND ISNULL(BookletNo, '') LIKE '%' + @BookletNo + '%'
AND ISNULL(Batch, '') LIKE '%' + @Batch + '%'
AND ISNULL(DocumentType, '') LIKE '%' + @DocType + '%'
AND ISNULL(ScannedDate, '') BETWEEN @ScanDateFrom AND @ScanDateTo


AND Status = 'Finished'
"

        'Get your connection string (You've done this right)
        Dim strconnectionstring As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
        'Create your SqlConnection (Done)
        'Create your SqlCommand (done)
        Dim objcommand As New SqlCommand()

        '**Set your command properties**
        With objcommand
            .CommandText = strsql
            .CommandType = CommandType.Text

            If Me.CHKDocDate.Checked = True Then
                .Parameters.AddWithValue("@DocDateFrom", Me.DTDocDateFrom.Value)
                .Parameters.AddWithValue("@DocDateTo", Me.DTDocDateTo.Value)
            Else
                .Parameters.AddWithValue("@DocDateFrom", Me.DTDocDateFrom.MinDate)
                .Parameters.AddWithValue("@DocDateTo", Me.DTDocDateTo.MaxDate)
            End If


            If CHKRack.Checked = True Then
                .Parameters.AddWithValue("@RackNo", Me.TxtRack.Text)
            Else
                .Parameters.AddWithValue("@RackNo", "")
            End If

            If Me.CHKBox.Checked = True Then
                .Parameters.AddWithValue("@BoxNo", Me.TxtBox.Text)
            Else
                .Parameters.AddWithValue("@BoxNo", "")
            End If

            If Me.CHKBook.Checked = True Then
                .Parameters.AddWithValue("@BookletNo", Me.TxtBook.Text)
            Else
                .Parameters.AddWithValue("@BookletNo", "")
            End If

            If Me.CHKBatch.Checked = True Then
                .Parameters.AddWithValue("@Batch", Me.TxtBatch.Text)
            Else
                .Parameters.AddWithValue("@Batch", "")
            End If

            If Me.CHKDocType.Checked = True Then
                .Parameters.AddWithValue("@DocType", Me.DocumentTypeComboBox.Text)
            Else
                .Parameters.AddWithValue("@DocType", "")
            End If




            If Me.CHKScanDate.Checked = True Then
                .Parameters.AddWithValue("@ScanDateFrom", Me.DTScanDateFrom.Value)
                .Parameters.AddWithValue("@ScanDateTo", Me.DTScanDateTo.Value)
            Else
                .Parameters.AddWithValue("@ScanDateFrom", Me.DTScanDateFrom.MinDate)
                .Parameters.AddWithValue("@ScanDateTo", Me.DTScanDateTo.MaxDate)
            End If













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



    End Sub
End Class