
Imports C1.Win.C1TrueDBGrid

Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports System.ComponentModel
Imports System.Runtime.InteropServices

Public Class FrmSearch2
    'Private Declare Unicode Function NetRemoteTOD Lib "netapi32" (<MarshalAs(UnmanagedType.LPWStr)> ByVal ServerName As String, ByRef BufferPtr As IntPtr) As Integer
    'Private Declare Function NetApiBufferFree Lib "netapi32" (ByVal Buffer As IntPtr) As Integer

    'Structure TIME_OF_DAY_INFO
    '    Dim tod_elapsedt As Integer
    '    Dim tod_msecs As Integer
    '    Dim tod_hours As Integer
    '    Dim tod_mins As Integer
    '    Dim tod_secs As Integer
    '    Dim tod_hunds As Integer
    '    Dim tod_timezone As Integer
    '    Dim tod_tinterval As Integer
    '    Dim tod_day As Integer
    '    Dim tod_month As Integer
    '    Dim tod_year As Integer
    '    Dim tod_weekday As Integer
    'End Structure


    'Function GetNetRemoteTOD(ByVal strServerName As String) As Date
    '    Try
    '        Dim iRet As Integer
    '        Dim ptodi As IntPtr
    '        Dim todi As TIME_OF_DAY_INFO
    '        Dim dDate As Date
    '        strServerName = strServerName & vbNullChar
    '        iRet = NetRemoteTOD(strServerName, ptodi)
    '        If iRet = 0 Then
    '            todi = CType(Marshal.PtrToStructure(ptodi, GetType(TIME_OF_DAY_INFO)), TIME_OF_DAY_INFO)
    '            NetApiBufferFree(ptodi)
    '            dDate = DateSerial(todi.tod_year, todi.tod_month, todi.tod_day) + " " + TimeSerial(todi.tod_hours, todi.tod_mins - todi.tod_timezone, todi.tod_secs)
    '            GetNetRemoteTOD = dDate

    '        Else
    '            MsgBox("Error retrieving time")
    '        End If
    '    Catch

    '        Try
    '            GetNetRemoteTOD = Date.Now.ToString("MM/dd/yyyy HH:mm:ss tt")
    '        Catch
    '            MsgBox("Error in GetNetRemoteTOD: " & Err.Description)
    '        End Try

    '    End Try

    '    Return GetNetRemoteTOD
    'End Function

    Public source As New BindingSource



    Private Sub FrmQuery_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.AcceptButton = BtnSearch

        PopulateCombobox()



        'Format
        TabControl1.Appearance = TabAppearance.Normal
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.SizeMode = TabSizeMode.Fixed
        For Each TabPage In TabControl1.TabPages

            TabPage.Text = ""
            TabPage.BackColor = Color.Azure

        Next


        TabControl2.Appearance = TabAppearance.Normal
        TabControl2.ItemSize = New Size(0, 1)
        TabControl2.SizeMode = TabSizeMode.Fixed

        For Each TabPage In TabControl2.TabPages

            TabPage.Text = ""
            TabPage.BackColor = Color.Azure

        Next

        TabControl3.Appearance = TabAppearance.Normal
        TabControl3.ItemSize = New Size(0, 1)
        TabControl3.SizeMode = TabSizeMode.Fixed
        For Each TabPage In TabControl2.TabPages

            TabPage.Text = ""
            TabPage.BackColor = Color.Azure

        Next


        TabControl4.Appearance = TabAppearance.Normal
        TabControl4.ItemSize = New Size(0, 1)
        TabControl4.SizeMode = TabSizeMode.Fixed


        For Each TabPage In TabControl4.TabPages

            TabPage.Text = ""
            TabPage.BackColor = Color.Azure

        Next

        Me.PaymentFormComboBox.Items.Add("Bank Deposit")
        Me.PaymentFormComboBox.Items.Add("Cash")
        Me.PaymentFormComboBox.Items.Add("Check")
        Me.PaymentFormComboBox.Items.Add("Others")

        Me.BtnSaveChanges1.Enabled = False
        Me.BtnDownload.Enabled = False


        If FrmMain.type = "System Admin" Or FrmMain.type = "Admin" Then
            Me.BtnDownload.Visible = True
            Me.BtnEditRecord.Visible = True
            Me.BtnSaveChanges1.Visible = True
            Me.BtnRemoval.Visible = True

        ElseIf FrmMain.type = "Editor" Then
            Me.BtnDownload.Visible = True
            Me.BtnEditRecord.Visible = False
            Me.BtnSaveChanges1.Visible = False
            Me.BtnRemoval.Visible = False


        ElseIf FrmMain.type = "User 1" Then
            Me.BtnDownload.Visible = True
            Me.BtnEditRecord.Visible = False
            Me.BtnSaveChanges1.Visible = False
            Me.BtnRemoval.Visible = False



        Else
            Me.BtnDownload.Visible = False
            Me.BtnEditRecord.Visible = False
            Me.BtnSaveChanges1.Visible = False
            Me.BtnRemoval.Visible = False
        End If


        Me.IdTextBox.ReadOnly = True



    End Sub
    Private Sub PopulateCombobox()

        Try


            Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("SELECT DocumentType FROM DocumentTypes ORDER BY DocumentType", con)

            Dim read As SqlDataReader = cmd.ExecuteReader()
            While read.Read()
                DocumentTypeComboBox.Items.Add(read.GetString(0))
                DocumentTypeCombobox2.Items.Add(read.GetString(0))
            End While
            con.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub



    Private Sub DocumentTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboSelect()

        If Me.C1TrueDBGrid2.Columns("Document Type").Text = "Sales Invoice" Then
            TabControl2.SelectTab(ReceiptInvoice)
        ElseIf Me.C1TrueDBGrid2.Columns("Document Type").Text = "Official Receipt" Then
            TabControl2.SelectTab(ReceiptInvoice)
        ElseIf Me.C1TrueDBGrid2.Columns("Document Type").Text = "Delivery Receipt" Then
            TabControl2.SelectTab(ReceiptInvoice)
        ElseIf Me.C1TrueDBGrid2.Columns("Document Type").Text = "Acknowledgement Receipt" Then
            TabControl2.SelectTab(ReceiptInvoice)
        ElseIf Me.C1TrueDBGrid2.Columns("Document Type").Text = "Collection Receipt" Then
            TabControl2.SelectTab(ReceiptInvoice)
        ElseIf Me.C1TrueDBGrid2.Columns("Document Type").Text = "Provisional Receipt" Then
            TabControl2.SelectTab(ReceiptInvoice)

        ElseIf Me.C1TrueDBGrid2.Columns("Document Type").Text = "Daily Time Record" Then
            TabControl2.SelectTab(Timesheet)

        ElseIf Me.C1TrueDBGrid2.Columns("Document Type").Text = "Warranty Card" Then
            TabControl2.SelectTab(Warranty)

        ElseIf Me.C1TrueDBGrid2.Columns("Document Type").Text = "Payment Voucher" Then
            TabControl2.SelectTab(Voucher)

        ElseIf Me.C1TrueDBGrid2.Columns("Document Type").Text = "Secretary's Certificate" Then
            TabControl2.SelectTab(CorpDocu)
            TabControl4.SelectTab(TabMeeting)
        ElseIf Me.C1TrueDBGrid2.Columns("Document Type").Text = "Minutes of Board Meeting" Then
            TabControl2.SelectTab(CorpDocu)
            TabControl4.SelectTab(TabMeeting)
        ElseIf Me.C1TrueDBGrid2.Columns("Document Type").Text = "Articles of Incorporation" Then
            TabControl2.SelectTab(CorpDocu)
            TabControl4.SelectTab(TabMeeting2)
        ElseIf Me.C1TrueDBGrid2.Columns("Document Type").Text = "SEC Certificate of Registration" Then
            TabControl2.SelectTab(CorpDocu)
            TabControl4.SelectTab(TabMeeting2)
        ElseIf Me.C1TrueDBGrid2.Columns("Document Type").Text = "DTI Permit" Then
            TabControl2.SelectTab(CorpDocu)
            TabControl4.SelectTab(TabPromo)
        ElseIf Me.C1TrueDBGrid2.Columns("Document Type").Text = "Financial Statement" Then
            TabControl2.SelectTab(CorpDocu)
            TabControl4.SelectTab(TabMeeting2)
        ElseIf Me.C1TrueDBGrid2.Columns("Document Type").Text = "General Information Sheet" Then
            TabControl2.SelectTab(CorpDocu)
            TabControl4.SelectTab(TabMeeting2)
        End If



    End Sub
    Private Sub ComboSelect3()

        If Me.DocumentTypeCombobox2.Text = "Sales Invoice" Then
            TabControl2.SelectTab(ReceiptInvoice)
        ElseIf Me.DocumentTypeCombobox2.Text = "Official Receipt" Then
            TabControl2.SelectTab(ReceiptInvoice)
        ElseIf Me.DocumentTypeCombobox2.Text = "Delivery Receipt" Then
            TabControl2.SelectTab(ReceiptInvoice)
        ElseIf Me.DocumentTypeCombobox2.Text = "Acknowledgement Receipt" Then
            TabControl2.SelectTab(ReceiptInvoice)
        ElseIf Me.DocumentTypeCombobox2.Text = "Collection Receipt" Then
            TabControl2.SelectTab(ReceiptInvoice)
        ElseIf Me.DocumentTypeCombobox2.Text = "Provisional Receipt" Then
            TabControl2.SelectTab(ReceiptInvoice)

        ElseIf Me.DocumentTypeCombobox2.Text = "Daily Time Record" Then
            TabControl2.SelectTab(Timesheet)
        ElseIf Me.DocumentTypeCombobox2.Text = "Warranty Card" Then
            TabControl2.SelectTab(Warranty)

        ElseIf Me.DocumentTypeCombobox2.Text = "Payment Voucher" Then
            TabControl2.SelectTab(Voucher)

        ElseIf Me.DocumentTypeCombobox2.Text = "Secretary's Certificate" Then
            TabControl2.SelectTab(CorpDocu)
            TabControl4.SelectTab(TabMeeting)
        ElseIf Me.DocumentTypeCombobox2.Text = "Minutes of Board Meeting" Then
            TabControl2.SelectTab(CorpDocu)
            TabControl4.SelectTab(TabMeeting)
        ElseIf Me.DocumentTypeCombobox2.Text = "Articles of Incorporation" Then
            TabControl2.SelectTab(CorpDocu)
            TabControl4.SelectTab(TabMeeting2)
        ElseIf Me.DocumentTypeCombobox2.Text = "SEC Certificate of Registration" Then
            TabControl2.SelectTab(CorpDocu)
            TabControl4.SelectTab(TabMeeting2)
        ElseIf Me.DocumentTypeCombobox2.Text = "DTI Permit" Then
            TabControl2.SelectTab(CorpDocu)
            TabControl4.SelectTab(TabPromo)
        ElseIf Me.DocumentTypeCombobox2.Text = "Financial Statement" Then
            TabControl2.SelectTab(CorpDocu)
            TabControl4.SelectTab(TabMeeting2)
        ElseIf Me.DocumentTypeCombobox2.Text = "General Information Sheet" Then
            TabControl2.SelectTab(CorpDocu)
            TabControl4.SelectTab(TabMeeting2)

        End If
    End Sub

    Private Sub Search()
        Try
            'Create a variable to hold your parameter value
            Dim id As Integer = 0
            'Create your query as you already have done
            Dim strsql As String = "SELECT 
                
               '' [Download]
                , [Id] [Document No]
              ,[DocumentType] [Document Type]
              ,[Batch]            
              ,[SubBatch]  [Sub Batch]               
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
              ,[Serial] [Serial Number] 
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
              , [PromoTitle] [Promo Title] 
              , [PromoFrom] 
              , [PromoTo]
              , [DTIPermitNo] [DTI Permit No]
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
              , [UserID]

                FROM DocsCatalogue 


          WHERE 
 ISNULL(Confidential, 'Unchecked') LIKE CASE WHEN '" + FrmMain.type + "' = 'System Admin' OR  '" + FrmMain.type + "' = 'Admin' THEN '%%' ELSE 'Unchecked' END
AND Status = 'Finished'
AND ISNULL(Removal, 'False') <> 'True'

AND ([DocumentType] LIKE '%' + @Wild + '%'
            OR  [Batch]   LIKE '%' + @Wild + '%'         
            OR  [SubBatch] LIKE '%' + @Wild + '%'
            OR  [RackNo] LIKE '%' + @Wild + '%'
            OR  [BoxNo] LIKE '%' + @Wild + '%' 
            OR  [ScannedDate] LIKE '%' + @Wild + '%'
            OR  [Filename] LIKE '%' + @Wild + '%'
            OR  [DocumentDate] LIKE '%' + @Wild + '%'
            OR  [ReferenceNo] LIKE '%' + @Wild + '%'
            OR  [BookletNo] LIKE '%' + @Wild + '%'
            OR  [Vendor] LIKE '%' + @Wild + '%'
            OR  [Customer] LIKE '%' + @Wild + '%'
            OR  [ItemPurchased] LIKE '%' + @Wild + '%'
            OR  [TotalValue] LIKE '%' + @Wild + '%'
            OR  [LastName] LIKE '%' + @Wild + '%'
            OR  [FirstName] LIKE '%' + @Wild + '%'
            OR  [MiddleName] LIKE '%' + @Wild + '%'
            OR  [WarrantyNo] LIKE '%' + @Wild + '%'
            OR  [ProductBrand] LIKE '%' + @Wild + '%'
            OR  [ProductType] LIKE '%' + @Wild + '%'            
            OR  [Serial] LIKE '%' + @Wild + '%' 
            OR  [WarrantyPeriod] LIKE '%' + @Wild + '%'
            OR  [ServiceCenter] LIKE '%' + @Wild + '%' 
            OR  [Address] LIKE '%' + @Wild + '%'
            OR  [ContactNo] LIKE '%' + @Wild + '%'
            OR  [Email] LIKE '%' + @Wild + '%'
            OR  [VoucherNo] LIKE '%' + @Wild + '%'
            OR  [PaymentForm] LIKE '%' + @Wild + '%'
            OR  [CheckNo] LIKE '%' + @Wild + '%'
            OR  [Payee] LIKE '%' + @Wild + '%'
            OR  [Payor] LIKE '%' + @Wild + '%'
            OR  [Preparedby] LIKE '%' + @Wild + '%'
            OR  [Approvedby] LIKE '%' + @Wild + '%'
            OR  [Recordedby] LIKE '%' + @Wild + '%'
            OR  [Receivedby] LIKE '%' + @Wild + '%'
            OR  [Company]   LIKE '%' + @Wild + '%'
            OR  [Purpose]   LIKE '%' + @Wild + '%'
            OR  [Secretary] LIKE '%' + @Wild + '%'            
            OR   [PromoTitle] LIKE '%' + @Wild + '%'
            OR   [DTIPermitNo] LIKE '%' + @Wild + '%'
            OR  [PaymentOthers] LIKE '%' + @Wild + '%'
            OR  [BankName] LIKE '%' + @Wild + '%'
            OR  [BankBranch] LIKE '%' + @Wild + '%'
            OR  [BankAddress] LIKE '%' + @Wild + '%'
            OR  [TinVendor] LIKE '%' + @Wild + '%'
            OR  [TinCustomer] LIKE '%' + @Wild + '%'
            OR  [VATreg] LIKE '%' + @Wild + '%'
            OR  [NONVATreg] LIKE '%' + @Wild + '%'      
            OR  [AddressC] LIKE '%' + @Wild + '%')
"








            '            WHERE
            '            ISNULL([DocumentDate], '') BETWEEN @DocDateFrom AND @DocDateTo
            'And ISNULL([RackNo], '') LIKE '%' + @RackNo + '%'
            'And ISNULL([BoxNo], '') LIKE '%' + @BoxNo + '%'
            'And ISNULL([BookletNo], '') LIKE '%' + @BookletNo + '%'
            'And ISNULL([Batch], '') LIKE '%' + @Batch + '%'
            'And ISNULL([DocumentType], '') LIKE '%' + @DocType + '%'
            'And ISNULL([ScannedDate], '') BETWEEN @ScanDateFrom AND @ScanDateTo 
            'And ISNULL([FileName], '') LIKE '%' + @FileName + '%'
            'And ISNULL(Confidential, 'Unchecked') LIKE CASE WHEN '" + FrmMain.type + "' = 'System Admin' OR  '" + FrmMain.type + "' = 'Admin' THEN '%%' ELSE 'Unchecked' END
            'And Status = 'Finished'
            'And ISNULL(Removal, 'False') <> 'True'




            'Get your connection string (You've done this right)
            Dim strconnectionstring As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
            'Create your SqlConnection (Done)
            'Create your SqlCommand (done)
            Dim objcommand As New SqlCommand()

            '**Set your command properties**
            With objcommand
                .CommandText = strsql
                .CommandType = CommandType.Text


                .Parameters.AddWithValue("@Wild", Me.txtWild.Text)


                'If Me.CHKDocDate.Checked = True Then
                '    .Parameters.AddWithValue("@DocDateFrom", Me.DTDocDateFrom.Value)
                '    .Parameters.AddWithValue("@DocDateTo", Me.DTDocDateTo.Value)
                'Else
                '    .Parameters.AddWithValue("@DocDateFrom", Me.DTDocDateFrom.MinDate)
                '    .Parameters.AddWithValue("@DocDateTo", Me.DTDocDateTo.MaxDate)
                'End If

                'If CHKRack.Checked = True Then
                '    .Parameters.AddWithValue("@RackNo", Me.TxtRack.Text)
                'Else
                '    .Parameters.AddWithValue("@RackNo", "")
                'End If

                'If Me.CHKBox.Checked = True Then
                '    .Parameters.AddWithValue("@BoxNo", Me.TxtBox.Text)
                'Else
                '    .Parameters.AddWithValue("@BoxNo", "")
                'End If

                'If Me.CHKBook.Checked = True Then
                '    .Parameters.AddWithValue("@BookletNo", Me.TxtBook.Text)
                'Else
                '    .Parameters.AddWithValue("@BookletNo", "")
                'End If

                'If Me.CHKBatch.Checked = True Then
                '    .Parameters.AddWithValue("@Batch", Me.TxtBatch.Text)
                'Else
                '    .Parameters.AddWithValue("@Batch", "")
                'End If

                'If Me.CHKDocType.Checked = True Then
                '    .Parameters.AddWithValue("@DocType", Me.DocumentTypeComboBox.Text)
                'Else
                '    .Parameters.AddWithValue("@DocType", "")
                'End If

                'If Me.CHKScanDate.Checked = True Then
                '    .Parameters.AddWithValue("@ScanDateFrom", Me.DTScanDateFrom.Value)
                '    .Parameters.AddWithValue("@ScanDateTo", Me.DTScanDateTo.Value)
                'Else
                '    .Parameters.AddWithValue("@ScanDateFrom", Me.DTScanDateFrom.MinDate)
                '    .Parameters.AddWithValue("@ScanDateTo", Me.DTScanDateTo.MaxDate)
                'End If

                'If Me.CHKFileName.Checked = True Then
                '    .Parameters.AddWithValue("@FileName", Me.TxtFileName.Text)
                'Else
                '    .Parameters.AddWithValue("@FileName", "")
                'End If
                .Connection = strconnectionstring
            End With




            'Create a new SqlDataAdapter
            'Set the SelectCommand property of our adapter
            Dim objdataAdapter As New SqlDataAdapter With {
                .SelectCommand = objcommand
            }
            'Create a new DataSet
            Dim objdataset As New DataSet
            'Fill the DataSet using the SqlDataAdapter
            objdataAdapter.Fill(objdataset, "DMS")

            Dim objbindingsource As New BindingSource With {
                .DataSource = objdataset.Tables("DMS")
            }
            C1TrueDBGrid2.DataSource = objbindingsource

            source = objbindingsource

            'Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Id").Visible = False
            Me.C1TrueDBGrid2.Splits(0).ExtendRightColumn = True

            Me.C1TrueDBGrid2.Columns("Download").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox

            For i = 0 To objbindingsource.Count
                Me.C1TrueDBGrid2.Columns("Download").Value = False
                objbindingsource.MoveNext()
            Next

            source.MoveFirst()



            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Document No").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Document Type").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Batch").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Sub Batch").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Rack No").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Box No").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Scanned Date").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("File Name").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Document Date").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Reference No").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Booklet No").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Vendor").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Customer").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Item Purchased").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Total Value").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Last Name").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("First Name").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Middle Name").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("From").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("To").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Warranty No").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Product Brand").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Product Type").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Date Purchased").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Serial Number").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Warranty Period").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Service Center").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Service Center Address").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Contact No").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("E-Mail").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Voucher No").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Form Of Payment").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Check No").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Payee").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Payor").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Prepared By").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Approved By").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Recorded By").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Received By").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Company").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Purpose").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Secretary").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Meeting Date").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Payment Others").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Bank Name").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Bank Branch").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Bank Address").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Tin of Vendor").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Tin of Customer").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("VAT-Registered").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("NONVAT-Registered").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Date Received").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Customer Address").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Promo Title").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("PromoFrom").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("UserID").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("PromoTo").Locked = True
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("DTI Permit No").Locked = True

            'Try
            '    Me.C1TrueDBGrid2.LoadLayout("default1.layout")
            'Catch ex As Exception
            '    Me.C1TrueDBGrid2.SaveLayout("default1.layout")
            'End Try


            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Download").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Download").Width = 54
            Me.C1TrueDBGrid2.Splits(0).ColumnCaptionHeight = 34

            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Document No").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Document No").Width = 54
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Document Type").Width = 200
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Batch").Width = 200
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Sub Batch").Width = 200

            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Rack No").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Box No").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Rack No").Width = 54
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Box No").Width = 54

            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Scanned Date").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("Scanned Date").Width = 70


            Me.C1TrueDBGrid2.Splits(0).DisplayColumns("File Name").Width = 200


            Me.BtnDownload.Enabled = True


            ''''''''''''''''''''''
        Catch ex As Exception
            MessageBox.Show("Searching Failed! " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Try

            Search()
            Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
            Dim cmdlogs As New SqlCommand(" INSERT INTO DMSLogs(Username, Action, ActionDate) VALUES (@Username, @Action, @ActionDate)", con)
            ' Dim dRemoteDate As Date
            ' dRemoteDate = GetNetRemoteTOD(My.Settings.remoteTOD)

            con.Open()
            cmdlogs.Connection = con
            cmdlogs.Parameters.AddWithValue("@Username", FrmMain.User)
            cmdlogs.Parameters.AddWithValue("@Action", FrmMain.User & " " & "Searched records")
            cmdlogs.Parameters.AddWithValue("@ActionDate", DateTime.Now)
            cmdlogs.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnEditRecord.Click
        Try
            ComboSelect()

            Me.DocsCatalogueTableAdapter.Fill(Me.DMSDataSet.DocsCatalogue, "Finished", IIf(FrmMain.type = "System Admin" Or FrmMain.type = "Admin", "", "Unchecked"))
            Me.DocsCatalogueBindingSource.Filter = "[Id] = '" & Me.C1TrueDBGrid2.Columns("Document No").Text & "' "


            Dim pdffile As String = (My.Settings.ImgPath & "\" & Me.C1TrueDBGrid2.Columns("File Name").Text)
            WebBrowser1.Navigate(pdffile)

            ' AxAcroPDF1.src = (My.Settings.ImgPath & "\" & Me.C1TrueDBGrid2.Columns("File Name").Text)

            TabControl1.SelectTab(TabChanges)
            Me.C1TrueDBGrid2.Enabled = False
            Me.BtnEditRecord.Enabled = False
            Me.BtnSearch.Enabled = False
            Me.BtnSaveChanges1.Enabled = True

            Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
            Dim cmdlogs As New SqlCommand(" INSERT INTO DMSLogs(Username, Action, ActionDate) VALUES (@Username, @Action, @ActionDate)", con)
            ' Dim dRemoteDate As Date
            '  dRemoteDate = GetNetRemoteTOD(My.Settings.remoteTOD)

            con.Open()
            cmdlogs.Connection = con
            cmdlogs.Parameters.AddWithValue("@Username", FrmMain.User)
            cmdlogs.Parameters.AddWithValue("@Action", FrmMain.User & " " & "Edited the searched record with ID:" & Me.C1TrueDBGrid2.Columns("Document No").Text)
            cmdlogs.Parameters.AddWithValue("@ActionDate", DateTime.Now)
            cmdlogs.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub SaveChanges()

        Me.Validate()
        Me.DocsCatalogueBindingSource.EndEdit()
        Me.DocsCatalogueTableAdapter.Update(Me.DMSDataSet.DocsCatalogue)

        Me.BtnEditRecord.Enabled = True
        Me.C1TrueDBGrid2.Enabled = True
        Me.BtnSearch.Enabled = True
        Me.BtnSaveChanges1.Enabled = False
        MessageBox.Show("Successfully Saved!!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.TabControl1.SelectTab(TabQuery)




        Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
        Dim cmdlogs As New SqlCommand(" INSERT INTO DMSLogs(Username, Action, ActionDate) VALUES (@Username, @Action, @ActionDate)", con)
        ' Dim dRemoteDate As Date
        '  dRemoteDate = GetNetRemoteTOD(My.Settings.remoteTOD)


        con.Open()
        cmdlogs.Connection = con
        cmdlogs.Parameters.AddWithValue("@Username", FrmMain.User)
        cmdlogs.Parameters.AddWithValue("@Action", FrmMain.User & " " & "Saved changes on searched record with ID:" & C1TrueDBGrid2.Columns("Document No").Text)
        cmdlogs.Parameters.AddWithValue("@ActionDate", DateTime.Now)
        cmdlogs.ExecuteNonQuery()
        con.Close()

    End Sub
    Private Sub BtnSaveChanges1_Click(sender As Object, e As EventArgs) Handles BtnSaveChanges1.Click

        Try



            Dim DateFormat As Date

            If Date.TryParseExact(DocumentDateTS.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.DocumentDateTS.Text = "" Then
                SaveChanges()
            ElseIf Date.TryParseExact(FromPeriodTextBox.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.FromPeriodTextBox.Text = "" Then
                SaveChanges()
            ElseIf Date.TryParseExact(ToPeriodTextBox.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.ToPeriodTextBox.Text = "" Then
                SaveChanges()
            ElseIf Date.TryParseExact(DocumentDateRI.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.DocumentDateRI.Text = "" Then
                SaveChanges()
            ElseIf Date.TryParseExact(DatePurchasedTextBox.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.DatePurchasedTextBox.Text = "" Then
                SaveChanges()
            ElseIf Date.TryParseExact(DocumentDateVoucher.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.DocumentDateVoucher.Text = "" Then
                SaveChanges()
            ElseIf Date.TryParseExact(DateReceivedTextBox.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.DateReceivedTextBox.Text = "" Then
                SaveChanges()
            ElseIf Date.TryParseExact(DocumentDateCorp.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.DocumentDateCorp.Text = "" Then
                SaveChanges()
            ElseIf Date.TryParseExact(MeetingDateTextBox.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.MeetingDateTextBox.Text = "" Then
                SaveChanges()
            ElseIf Date.TryParseExact(PromoFromTextBox.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.PromoFromTextBox.Text = "" Then
                SaveChanges()
            ElseIf Date.TryParseExact(PromoToTextBox.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.PromoToTextBox.Text = "" Then
                SaveChanges()
            Else

                MessageBox.Show("Incorrect Date Format")
                Me.DocumentDateTS.Clear()
                Me.FromPeriodTextBox.Clear()
                Me.ToPeriodTextBox.Clear()
                Me.DocumentDateRI.Clear()
                Me.DatePurchasedTextBox.Clear()
                Me.DocumentDateVoucher.Clear()
                Me.DateReceivedTextBox.Clear()
                Me.DocumentDateCorp.Clear()
                Me.MeetingDateTextBox.Clear()
                Me.PromoFromTextBox.Clear()
                Me.PromoToTextBox.Clear()

            End If

            Search()

        Catch ex As Exception
            MessageBox.Show("Error while updating records " & ex.Message)
        End Try
    End Sub


    Private Sub FrmQuery_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ' Me.C1TrueDBGrid2.SaveLayout("default1.layout")
    End Sub

    Private Sub DTMeetingDate_ValueChanged(sender As Object, e As EventArgs) Handles DTMeetingDate.ValueChanged
        Me.MeetingDateTextBox.Text = Me.DTMeetingDate.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTDocuCorp_ValueChanged(sender As Object, e As EventArgs) Handles DTDocuCorp.ValueChanged
        Me.DocumentDateCorp.Text = Me.DTDocuCorp.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTPromoFrom_ValueChanged(sender As Object, e As EventArgs) Handles DTPromoFrom.ValueChanged
        Me.PromoFromTextBox.Text = Me.DTPromoFrom.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTPromoTo_ValueChanged(sender As Object, e As EventArgs) Handles DTPromoTo.ValueChanged
        Me.PromoToTextBox.Text = Me.DTPromoTo.Value.ToString("MM/dd/yyyy")
    End Sub
    Private Sub DocumentDateCorp_LostFocus(sender As Object, e As EventArgs) Handles DocumentDateCorp.LostFocus
        DocumentDateCorp.BackColor = Color.White

        Dim DateFormat As Date

        If Date.TryParseExact(DocumentDateCorp.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.DocumentDateCorp.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.DocumentDateCorp.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.DocumentDateCorp.Clear()
        End If
    End Sub
    Private Sub MeetingDateTextBox_LostFocus(sender As Object, e As EventArgs) Handles MeetingDateTextBox.LostFocus
        MeetingDateTextBox.BackColor = Color.White

        Dim DateFormat As Date

        If Date.TryParseExact(MeetingDateTextBox.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.MeetingDateTextBox.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.MeetingDateTextBox.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.MeetingDateTextBox.Clear()
        End If
    End Sub
    Private Sub PromoFromTextBox_LostFocus(sender As Object, e As EventArgs) Handles PromoFromTextBox.LostFocus
        PromoFromTextBox.BackColor = Color.White

        Dim DateFormat As Date

        If Date.TryParseExact(PromoFromTextBox.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.PromoFromTextBox.Text = "" Then
        Else
            MessageBox.Show("Incorrect Date Format " & Me.PromoFromTextBox.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.PromoFromTextBox.Clear()
        End If
    End Sub
    Private Sub PromoToTextBox_LostFocus(sender As Object, e As EventArgs) Handles PromoToTextBox.LostFocus
        PromoToTextBox.BackColor = Color.White

        Dim DateFormat As Date

        If Date.TryParseExact(PromoToTextBox.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.PromoToTextBox.Text = "" Then
        Else
            MessageBox.Show("Incorrect Date Format " & Me.PromoToTextBox.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.PromoToTextBox.Clear()
        End If
    End Sub
    Private Sub DocumentDateVoucher_LostFocus(sender As Object, e As EventArgs) Handles DocumentDateVoucher.LostFocus

        DocumentDateVoucher.BackColor = Color.White
        Dim DateFormat As Date

        If Date.TryParseExact(DocumentDateVoucher.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.DocumentDateVoucher.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.DocumentDateVoucher.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.DocumentDateVoucher.Clear()
        End If
    End Sub
    Private Sub DatePurchasedTextBox_LostFocus(sender As Object, e As EventArgs) Handles DatePurchasedTextBox.LostFocus
        SerialTextBox.BackColor = Color.White

        Dim DateFormat As Date
        If Date.TryParseExact(DatePurchasedTextBox.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.DatePurchasedTextBox.Text = "" Then
        Else
            MessageBox.Show("Incorrect Date Format " & Me.DatePurchasedTextBox.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.DatePurchasedTextBox.Clear()
        End If
    End Sub



    Private Sub DocumentDateRI_LostFocus(sender As Object, e As EventArgs) Handles DocumentDateRI.LostFocus

        DocumentDateRI.BackColor = Color.White

        Dim DateFormat As Date

        If Date.TryParseExact(DocumentDateRI.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.DocumentDateRI.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.DocumentDateRI.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.DocumentDateRI.Clear()
        End If
    End Sub



    Private Sub FromPeriodTextBox_LostFocus(sender As Object, e As EventArgs) Handles FromPeriodTextBox.LostFocus
        FromPeriodTextBox.BackColor = Color.White

        Dim DateFormat As Date

        If Date.TryParseExact(FromPeriodTextBox.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.FromPeriodTextBox.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.FromPeriodTextBox.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.FromPeriodTextBox.Clear()
        End If
    End Sub



    Private Sub ToPeriodTextBox_LostFocus(sender As Object, e As EventArgs) Handles ToPeriodTextBox.LostFocus

        ToPeriodTextBox.BackColor = Color.White
        Dim DateFormat As Date

        If Date.TryParseExact(ToPeriodTextBox.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.ToPeriodTextBox.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.ToPeriodTextBox.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.ToPeriodTextBox.Clear()
        End If
    End Sub

    Private Sub DTDocuTimeSheet_ValueChanged(sender As Object, e As EventArgs) Handles DTDocuTimeSheet.ValueChanged
        Me.DocumentDateTS.Text = Me.DTDocuTimeSheet.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTDocuRI_ValueChanged(sender As Object, e As EventArgs) Handles DTDocuRI.ValueChanged
        Me.DocumentDateRI.Text = Me.DTDocuRI.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTDatePurchased_ValueChanged(sender As Object, e As EventArgs) Handles DTDatePurchased.ValueChanged
        Me.DatePurchasedTextBox.Text = Me.DTDatePurchased.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTDocuVoucher_ValueChanged(sender As Object, e As EventArgs) Handles DTDocuVoucher.ValueChanged
        Me.DocumentDateVoucher.Text = Me.DTDocuVoucher.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub PromoFromTextBox_TextChanged(sender As Object, e As EventArgs) Handles PromoFromTextBox.TextChanged

    End Sub

    Private Sub DocumentTypeCombobox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DocumentTypeCombobox2.SelectedIndexChanged
        ComboSelect3()
    End Sub

    Private Sub BtnDownload_Click(sender As Object, e As EventArgs) Handles BtnDownload.Click
        Try
            Dim FilePath As String
            If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then

                source.Position = 0
                For i = 0 To Me.source.Count - 1

                    If Me.C1TrueDBGrid2.Columns("Download").Value = True Then
                        FilePath = FolderBrowserDialog1.SelectedPath & "\" & Me.C1TrueDBGrid2.Columns("File Name").Text
                        My.Computer.Network.DownloadFile(Path.Combine(My.Settings.ImgPath, Me.C1TrueDBGrid2.Columns("File Name").Text), FilePath, "guest", "")
                    End If
                    source.MoveNext()
                Next


                Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
                Dim cmdlogs As New SqlCommand("INSERT INTO DMSLogs(Username, Action, ActionDate) VALUES (@Username, @Action, @ActionDate)", con)
                ' Dim dRemoteDate As Date
                '  dRemoteDate = GetNetRemoteTOD(My.Settings.remoteTOD)


                con.Open()
                cmdlogs.Connection = con
                cmdlogs.Parameters.AddWithValue("@Username", FrmMain.User)
                cmdlogs.Parameters.AddWithValue("@Action", FrmMain.User & " " & "Downloaded files.")
                cmdlogs.Parameters.AddWithValue("@ActionDate", DateTime.Now)
                cmdlogs.ExecuteNonQuery()
                con.Close()

                MessageBox.Show("Files Downloaded.", "Download", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    Private Sub C1TrueDBGrid1_DoubleClick(sender As Object, e As EventArgs)
        Try

            ' AcroPDF.src = (My.Settings.ImgPath & "\" & Me.C1TrueDBGrid2.Columns("File Name").Text)


            Dim pdffile As String = (My.Settings.ImgPath & "\" & Me.C1TrueDBGrid2.Columns("File Name").Text)
            WebBrowser1.Navigate(pdffile)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    Private Sub C1TrueDBGrid2_DoubleClick(sender As Object, e As EventArgs) Handles C1TrueDBGrid2.DoubleClick
        Try
            'AxAcroPDF1.src = (My.Settings.ImgPath & "\" & Me.C1TrueDBGrid2.Columns("File Name").Text)

            ' (My.Settings.ImgPath & "\" & Me.C1TrueDBGrid2.Columns("File Name").Text)


            Dim pdffile As String = IIf(Me.C1TrueDBGrid2.Columns("File Name").Text = "", "", (My.Settings.ImgPath & "\" & Me.C1TrueDBGrid2.Columns("File Name").Text))
            WebBrowser1.Navigate(pdffile)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ComboSelect2()


        If Me.PaymentFormComboBox.Text = "Bank Deposit" Then
            TabControl3.Visible = True
            TabControl3.SelectTab(BankDepo)
        ElseIf Me.PaymentFormComboBox.Text = "Check" Then
            TabControl3.Visible = True
            TabControl3.SelectTab(Check)
        ElseIf Me.PaymentFormComboBox.Text = "Others" Then
            TabControl3.Visible = True
            TabControl3.SelectTab(Others)
        ElseIf Me.PaymentFormComboBox.Text = "" Then
            TabControl3.Visible = False
        ElseIf Me.PaymentFormComboBox.Text = "Cash" Then
            TabControl3.Visible = False
        ElseIf Me.PaymentFormComboBox.SelectedIndex = -1 Then
            TabControl3.Visible = False
        End If
    End Sub

    Private Sub PaymentFormComboBox_TextChanged(sender As Object, e As EventArgs) Handles PaymentFormComboBox.TextChanged
        ComboSelect2()
    End Sub

    Private Sub TxtRack_GotFocus(sender As Object, e As EventArgs) Handles TxtRack.GotFocus
        TxtRack.BackColor = Color.LightYellow
    End Sub
    Private Sub TxtRack_LostFocus(sender As Object, e As EventArgs) Handles TxtRack.LostFocus
        TxtRack.BackColor = Color.White
    End Sub
    Private Sub TxtBox_GotFocus(sender As Object, e As EventArgs) Handles TxtBox.GotFocus
        TxtBox.BackColor = Color.LightYellow
    End Sub
    Private Sub TxtBox_LostFocus(sender As Object, e As EventArgs) Handles TxtBox.LostFocus
        TxtBox.BackColor = Color.White
    End Sub
    Private Sub TxtBook_GotFocus(sender As Object, e As EventArgs) Handles TxtBook.GotFocus
        TxtBook.BackColor = Color.LightYellow
    End Sub
    Private Sub TxtBook_LostFocus(sender As Object, e As EventArgs) Handles TxtBook.LostFocus
        TxtBook.BackColor = Color.White
    End Sub
    Private Sub TxtBatch_GotFocus(sender As Object, e As EventArgs) Handles TxtBatch.GotFocus
        TxtBatch.BackColor = Color.LightYellow
    End Sub
    Private Sub TxtBatch_LostFocus(sender As Object, e As EventArgs) Handles TxtBatch.LostFocus
        TxtBatch.BackColor = Color.White
    End Sub
    Private Sub TxtFileName_GotFocus(sender As Object, e As EventArgs) Handles TxtFileName.GotFocus
        TxtFileName.BackColor = Color.LightYellow
    End Sub
    Private Sub TxtFileName_LostFocus(sender As Object, e As EventArgs) Handles TxtFileName.LostFocus
        TxtFileName.BackColor = Color.White
    End Sub
    Private Sub RackNoTS_GotFocus(sender As Object, e As EventArgs) Handles RackNoTS.GotFocus
        RackNoTS.BackColor = Color.LightYellow
    End Sub
    Private Sub RackNoTS_LostFocus(sender As Object, e As EventArgs) Handles RackNoTS.LostFocus
        RackNoTS.BackColor = Color.White
    End Sub
    Private Sub BoxNoTS_GotFocus(sender As Object, e As EventArgs) Handles BoxNoTS.GotFocus
        BoxNoTS.BackColor = Color.LightYellow
    End Sub
    Private Sub BoxNoTS_LostFocus(sender As Object, e As EventArgs) Handles BoxNoTS.LostFocus
        BoxNoTS.BackColor = Color.White
    End Sub
    Private Sub DocumentDateTS_GotFocus(sender As Object, e As EventArgs) Handles DocumentDateTS.GotFocus
        DocumentDateTS.BackColor = Color.LightYellow
    End Sub
    Private Sub DocumentDateTS_LostFocus(sender As Object, e As EventArgs) Handles DocumentDateTS.LostFocus
        DocumentDateTS.BackColor = Color.White
    End Sub
    Private Sub LastNameTextBox_GotFocus(sender As Object, e As EventArgs) Handles LastNameTextBox.GotFocus
        LastNameTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub LastNameTextBox_LostFocus(sender As Object, e As EventArgs) Handles LastNameTextBox.LostFocus
        LastNameTextBox.BackColor = Color.White
    End Sub
    Private Sub FirstNameTextBox_GotFocus(sender As Object, e As EventArgs) Handles FirstNameTextBox.GotFocus
        FirstNameTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub FirstNameTextBox_LostFocus(sender As Object, e As EventArgs) Handles FirstNameTextBox.LostFocus
        FirstNameTextBox.BackColor = Color.White
    End Sub
    Private Sub MiddleNameTextBox_GotFocus(sender As Object, e As EventArgs) Handles MiddleNameTextBox.GotFocus
        MiddleNameTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub MiddleNameTextBox_LostFocus(sender As Object, e As EventArgs) Handles MiddleNameTextBox.LostFocus
        MiddleNameTextBox.BackColor = Color.White
    End Sub
    Private Sub FromPeriodTextBox_GotFocus(sender As Object, e As EventArgs) Handles FromPeriodTextBox.GotFocus
        FromPeriodTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub ToPeriodTextBox_GotFocus(sender As Object, e As EventArgs) Handles ToPeriodTextBox.GotFocus
        ToPeriodTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub RackNoRI_GotFocus(sender As Object, e As EventArgs) Handles RackNoRI.GotFocus
        RackNoRI.BackColor = Color.LightYellow
    End Sub
    Private Sub RackNoRI_LostFocus(sender As Object, e As EventArgs) Handles RackNoRI.LostFocus
        RackNoRI.BackColor = Color.White
    End Sub
    Private Sub BoxNoRI_GotFocus(sender As Object, e As EventArgs) Handles BoxNoRI.GotFocus
        BoxNoRI.BackColor = Color.LightYellow
    End Sub
    Private Sub BoxNoRI_LostFocus(sender As Object, e As EventArgs) Handles BoxNoRI.LostFocus
        BoxNoRI.BackColor = Color.White
    End Sub
    Private Sub DocumentDateRI_GotFocus(sender As Object, e As EventArgs) Handles DocumentDateRI.GotFocus
        DocumentDateRI.BackColor = Color.LightYellow
    End Sub
    Private Sub BookletNoTextBox_GotFocus(sender As Object, e As EventArgs) Handles BookletNoTextBox.GotFocus
        BookletNoTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub BookletNoTextBox_LostFocus(sender As Object, e As EventArgs) Handles BookletNoTextBox.LostFocus
        BookletNoTextBox.BackColor = Color.White
    End Sub
    Private Sub ReferenceNoRI_GotFocus(sender As Object, e As EventArgs) Handles ReferenceNoRI.GotFocus
        ReferenceNoRI.BackColor = Color.LightYellow
    End Sub
    Private Sub ReferenceNoRI_LostFocus(sender As Object, e As EventArgs) Handles ReferenceNoRI.LostFocus
        ReferenceNoRI.BackColor = Color.White
    End Sub
    Private Sub TotalValueRI_GotFocus(sender As Object, e As EventArgs) Handles TotalValueRI.GotFocus
        TotalValueRI.BackColor = Color.LightYellow
    End Sub
    Private Sub TotalValueRI_LostFocus(sender As Object, e As EventArgs) Handles TotalValueRI.LostFocus
        TotalValueRI.BackColor = Color.White
    End Sub
    Private Sub VendorTextBox_GotFocus(sender As Object, e As EventArgs) Handles VendorTextBox.GotFocus
        VendorTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub VendorTextBox_LostFocus(sender As Object, e As EventArgs) Handles VendorTextBox.LostFocus
        VendorTextBox.BackColor = Color.White
    End Sub
    Private Sub CustomerTextBox_GotFocus(sender As Object, e As EventArgs) Handles CustomerTextBox.GotFocus
        CustomerTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub CustomerTextBox_LostFocus(sender As Object, e As EventArgs) Handles CustomerTextBox.LostFocus
        CustomerTextBox.BackColor = Color.White
    End Sub
    Private Sub AddressCTextBox_GotFocus(sender As Object, e As EventArgs) Handles AddressCTextBox.GotFocus
        AddressCTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub AddressCTextBox_LostFocus(sender As Object, e As EventArgs) Handles AddressCTextBox.LostFocus
        AddressCTextBox.BackColor = Color.White
    End Sub
    Private Sub TinVendorTextBox_GotFocus(sender As Object, e As EventArgs) Handles TinVendorTextBox.GotFocus
        TinVendorTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub TinVendorTextBox_LostFocus(sender As Object, e As EventArgs) Handles TinVendorTextBox.LostFocus
        TinVendorTextBox.BackColor = Color.White
    End Sub
    Private Sub TinCustomerTextBox_GotFocus(sender As Object, e As EventArgs) Handles TinCustomerTextBox.GotFocus
        TinCustomerTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub TinCustomerTextBox_LostFocus(sender As Object, e As EventArgs) Handles TinCustomerTextBox.LostFocus
        TinCustomerTextBox.BackColor = Color.White
    End Sub
    Private Sub ItemPurchasedTextBox_GotFocus(sender As Object, e As EventArgs) Handles ItemPurchasedTextBox.GotFocus
        ItemPurchasedTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub ItemPurchasedTextBox_LostFocus(sender As Object, e As EventArgs) Handles ItemPurchasedTextBox.LostFocus
        ItemPurchasedTextBox.BackColor = Color.White
    End Sub
    Private Sub RackNoWarranty_GotFocus(sender As Object, e As EventArgs) Handles RackNoWarranty.GotFocus
        RackNoWarranty.BackColor = Color.LightYellow
    End Sub
    Private Sub RackNoWarranty_LostFocus(sender As Object, e As EventArgs) Handles RackNoWarranty.LostFocus
        RackNoWarranty.BackColor = Color.White
    End Sub
    Private Sub BoxNoWarranty_GotFocus(sender As Object, e As EventArgs) Handles BoxNoWarranty.GotFocus
        BoxNoWarranty.BackColor = Color.LightYellow
    End Sub
    Private Sub BoxNoWarranty_LostFocus(sender As Object, e As EventArgs) Handles BoxNoWarranty.LostFocus
        BoxNoWarranty.BackColor = Color.White
    End Sub
    Private Sub ProductBrandTextBox_GotFocus(sender As Object, e As EventArgs) Handles ProductBrandTextBox.GotFocus
        BoxNoWarranty.BackColor = Color.LightYellow
    End Sub
    Private Sub ProductBrandTextBox_LostFocus(sender As Object, e As EventArgs) Handles ProductBrandTextBox.LostFocus
        BoxNoWarranty.BackColor = Color.White
    End Sub
    Private Sub ProductTypeTextBox_GotFocus(sender As Object, e As EventArgs) Handles ProductTypeTextBox.GotFocus
        ProductTypeTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub ProductTypeTextBox_LostFocus(sender As Object, e As EventArgs) Handles ProductTypeTextBox.LostFocus
        ProductTypeTextBox.BackColor = Color.White
    End Sub
    Private Sub SerialTextBox_GotFocus(sender As Object, e As EventArgs) Handles SerialTextBox.GotFocus
        SerialTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub SerialTextBox_LostFocus(sender As Object, e As EventArgs) Handles SerialTextBox.LostFocus
        SerialTextBox.BackColor = Color.White
    End Sub
    Private Sub DatePurchasedTextBox_GotFocus(sender As Object, e As EventArgs) Handles DatePurchasedTextBox.GotFocus
        SerialTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub ReferenceNoTextBox1_GotFocus(sender As Object, e As EventArgs) Handles ReferenceNoTextBox1.GotFocus
        SerialTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub ReferenceNoTextBox1_LostFocus(sender As Object, e As EventArgs) Handles ReferenceNoTextBox1.LostFocus
        SerialTextBox.BackColor = Color.White
    End Sub
    Private Sub WarrantyNoTextBox_GotFocus(sender As Object, e As EventArgs) Handles WarrantyNoTextBox.GotFocus
        WarrantyNoTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub WarrantyNoTextBox_LostFocus(sender As Object, e As EventArgs) Handles WarrantyNoTextBox.LostFocus
        WarrantyNoTextBox.BackColor = Color.White
    End Sub
    Private Sub WarrantyPeriodTextBox_GotFocus(sender As Object, e As EventArgs) Handles WarrantyPeriodTextBox.GotFocus
        WarrantyPeriodTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub WarrantyPeriodTextBox_LostFocus(sender As Object, e As EventArgs) Handles WarrantyPeriodTextBox.LostFocus
        WarrantyPeriodTextBox.BackColor = Color.White
    End Sub
    Private Sub ServiceCenterTextBox_GotFocus(sender As Object, e As EventArgs) Handles ServiceCenterTextBox.GotFocus
        ServiceCenterTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub ServiceCenterTextBox_LostFocus(sender As Object, e As EventArgs) Handles ServiceCenterTextBox.LostFocus
        ServiceCenterTextBox.BackColor = Color.White
    End Sub
    Private Sub AddressTextBox_GotFocus(sender As Object, e As EventArgs) Handles AddressTextBox.GotFocus
        AddressTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub AddressTextBox_LostFocus(sender As Object, e As EventArgs) Handles AddressTextBox.LostFocus
        AddressTextBox.BackColor = Color.White
    End Sub
    Private Sub ContactNoTextBox_GotFocus(sender As Object, e As EventArgs) Handles ContactNoTextBox.GotFocus
        ContactNoTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub ContactNoTextBox_LostFocus(sender As Object, e As EventArgs) Handles ContactNoTextBox.LostFocus
        ContactNoTextBox.BackColor = Color.White
    End Sub
    Private Sub RackNoVoucher_GotFocus(sender As Object, e As EventArgs) Handles RackNoVoucher.GotFocus
        RackNoVoucher.BackColor = Color.LightYellow
    End Sub
    Private Sub RackNoVoucher_LostFocus(sender As Object, e As EventArgs) Handles RackNoVoucher.LostFocus
        RackNoVoucher.BackColor = Color.White
    End Sub
    Private Sub BoxNoVoucher_GotFocus(sender As Object, e As EventArgs) Handles BoxNoVoucher.GotFocus
        BoxNoVoucher.BackColor = Color.LightYellow
    End Sub
    Private Sub BoxNoVoucher_LostFocus(sender As Object, e As EventArgs) Handles BoxNoVoucher.LostFocus
        BoxNoVoucher.BackColor = Color.White
    End Sub
    Private Sub DocumentDateVoucher_GotFocus(sender As Object, e As EventArgs) Handles DocumentDateVoucher.GotFocus
        DocumentDateVoucher.BackColor = Color.LightYellow
    End Sub
    Private Sub PayeeTextBox_GotFocus(sender As Object, e As EventArgs) Handles PayeeTextBox.GotFocus
        PayeeTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub PayeeTextBox_LostFocus(sender As Object, e As EventArgs) Handles PayeeTextBox.LostFocus
        PayeeTextBox.BackColor = Color.White
    End Sub
    Private Sub PayorTextBox_GotFocus(sender As Object, e As EventArgs) Handles PayorTextBox.GotFocus
        PayorTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub PayorTextBox_LostFocus(sender As Object, e As EventArgs) Handles PayorTextBox.LostFocus
        PayorTextBox.BackColor = Color.White
    End Sub
    Private Sub VoucherNoTextBox_GotFocus(sender As Object, e As EventArgs) Handles VoucherNoTextBox.GotFocus
        VoucherNoTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub VoucherNoTextBox_LostFocus(sender As Object, e As EventArgs) Handles VoucherNoTextBox.LostFocus
        VoucherNoTextBox.BackColor = Color.White
    End Sub
    Private Sub BankNameTextBox_GotFocus(sender As Object, e As EventArgs) Handles BankNameTextBox.GotFocus
        BankNameTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub BankNameTextBox_LostFocus(sender As Object, e As EventArgs) Handles BankNameTextBox.LostFocus
        BankNameTextBox.BackColor = Color.White
    End Sub
    Private Sub BankBranchTextBox_GotFocus(sender As Object, e As EventArgs) Handles BankBranchTextBox.GotFocus
        BankBranchTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub BankBranchTextBox_LostFocus(sender As Object, e As EventArgs) Handles BankBranchTextBox.LostFocus
        BankBranchTextBox.BackColor = Color.White
    End Sub
    Private Sub BankAddressTextBox_GotFocus(sender As Object, e As EventArgs) Handles BankAddressTextBox.GotFocus
        BankAddressTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub BankAddressTextBox_LostFocus(sender As Object, e As EventArgs) Handles BankAddressTextBox.LostFocus
        BankAddressTextBox.BackColor = Color.White
    End Sub
    Private Sub TotalValueVoucher_GotFocus(sender As Object, e As EventArgs) Handles TotalValueVoucher.GotFocus
        TotalValueVoucher.BackColor = Color.LightYellow
    End Sub
    Private Sub TotalValueVoucher_LostFocus(sender As Object, e As EventArgs) Handles TotalValueVoucher.LostFocus
        TotalValueVoucher.BackColor = Color.White
    End Sub
    Private Sub PaymentOthersTextBox_GotFocus(sender As Object, e As EventArgs) Handles PaymentOthersTextBox.GotFocus
        PaymentOthersTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub PaymentOthersTextBox_LostFocus(sender As Object, e As EventArgs) Handles PaymentOthersTextBox.LostFocus
        PaymentOthersTextBox.BackColor = Color.White
    End Sub
    Private Sub CheckNoTextBox_GotFocus(sender As Object, e As EventArgs) Handles CheckNoTextBox.GotFocus
        CheckNoTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub CheckNoTextBox_LostFocus(sender As Object, e As EventArgs) Handles CheckNoTextBox.LostFocus
        CheckNoTextBox.BackColor = Color.White
    End Sub
    Private Sub RackNoCorpDocu_GotFocus(sender As Object, e As EventArgs) Handles RackNoCorpDocu.GotFocus
        RackNoCorpDocu.BackColor = Color.LightYellow
    End Sub
    Private Sub RackNoCorpDocu_LostFocus(sender As Object, e As EventArgs) Handles RackNoCorpDocu.LostFocus
        RackNoCorpDocu.BackColor = Color.White
    End Sub
    Private Sub BoxNoCorpDocu_GotFocus(sender As Object, e As EventArgs) Handles BoxNoCorpDocu.GotFocus
        BoxNoCorpDocu.BackColor = Color.LightYellow
    End Sub
    Private Sub BoxNoCorpDocu_LostFocus(sender As Object, e As EventArgs) Handles BoxNoCorpDocu.LostFocus
        BoxNoCorpDocu.BackColor = Color.White
    End Sub
    Private Sub DocumentDateCorp_GotFocus(sender As Object, e As EventArgs) Handles DocumentDateCorp.GotFocus
        DocumentDateCorp.BackColor = Color.LightYellow
    End Sub
    Private Sub MeetingDateTextBox_GotFocus(sender As Object, e As EventArgs) Handles MeetingDateTextBox.GotFocus
        MeetingDateTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub CompanyTextBox_GotFocus(sender As Object, e As EventArgs) Handles CompanyTextBox.GotFocus
        CompanyTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub CompanyTextBox_LostFocus(sender As Object, e As EventArgs) Handles CompanyTextBox.LostFocus
        CompanyTextBox.BackColor = Color.White
    End Sub
    Private Sub SecretaryTextBox_GotFocus(sender As Object, e As EventArgs) Handles SecretaryTextBox.GotFocus
        SecretaryTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub SecretaryTextBox_LostFocus(sender As Object, e As EventArgs) Handles SecretaryTextBox.LostFocus
        SecretaryTextBox.BackColor = Color.White
    End Sub
    Private Sub PurposeTextBox_GotFocus(sender As Object, e As EventArgs) Handles PurposeTextBox.GotFocus
        PurposeTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub PurposeTextBox_LostFocus(sender As Object, e As EventArgs) Handles PurposeTextBox.LostFocus
        PurposeTextBox.BackColor = Color.White
    End Sub
    Private Sub PromoTitleTextBox_GotFocus(sender As Object, e As EventArgs) Handles PromoTitleTextBox.GotFocus
        PromoTitleTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub PromoTitleTextBox_LostFocus(sender As Object, e As EventArgs) Handles PromoTitleTextBox.LostFocus
        PromoTitleTextBox.BackColor = Color.White
    End Sub
    Private Sub PromoFromTextBox_GotFocus(sender As Object, e As EventArgs) Handles PromoFromTextBox.GotFocus
        PromoFromTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub PromoToTextBox_GotFocus(sender As Object, e As EventArgs) Handles PromoToTextBox.GotFocus
        PromoToTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub DTIPermitNoTextBox_GotFocus(sender As Object, e As EventArgs) Handles DTIPermitNoTextBox.GotFocus
        DTIPermitNoTextBox.BackColor = Color.LightYellow
    End Sub
    Private Sub DTIPermitNoTextBox_LostFocus(sender As Object, e As EventArgs) Handles DTIPermitNoTextBox.LostFocus
        DTIPermitNoTextBox.BackColor = Color.White
    End Sub
    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        TextBox1.BackColor = Color.LightYellow
    End Sub
    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        TextBox1.BackColor = Color.White
    End Sub

    'Private Sub C1TrueDBGrid2_Click(sender As Object, e As EventArgs) Handles C1TrueDBGrid2.Click
    '    Try
    '        ' AcroPDF.src = (My.Settings.ImgPath & "\" & Me.C1TrueDBGrid2.Columns("File Name").Text)

    '        ' (My.Settings.ImgPath & "\" & Me.C1TrueDBGrid2.Columns("File Name").Text)


    '        Dim pdffile As String = IIf(Me.C1TrueDBGrid2.Columns("File Name").Text = "", "", (My.Settings.ImgPath & "\" & Me.C1TrueDBGrid2.Columns("File Name").Text))
    '        WebBrowser1.Navigate(pdffile)

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    Private Sub IdTextBox_TextChanged(sender As Object, e As EventArgs) Handles IdTextBox.TextChanged

    End Sub

    Private Sub BtnRemoval_Click(sender As Object, e As EventArgs) Handles BtnRemoval.Click
        FrmReason3.ShowDialog()
    End Sub

    Private Sub C1TrueDBGrid2_Click(sender As Object, e As EventArgs) Handles C1TrueDBGrid2.Click
        '    Try
        '        AxAcroPDF1.src = (My.Settings.ImgPath & "\" & Me.C1TrueDBGrid2.Columns("File Name").Text)

        '        ' (My.Settings.ImgPath & "\" & Me.C1TrueDBGrid2.Columns("File Name").Text)


        '        'Dim pdffile As String = IIf(Me.C1TrueDBGrid2.Columns("File Name").Text = "", "", (My.Settings.ImgPath & "\" & Me.C1TrueDBGrid2.Columns("File Name").Text))
        '        'WebBrowser1.Navigate(pdffile)

        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message)
        '    End Try
    End Sub

End Class