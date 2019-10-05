
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



        TabControl5.Appearance = TabAppearance.Normal
        TabControl5.ItemSize = New Size(0, 1)
        TabControl5.SizeMode = TabSizeMode.Fixed


        For Each TabPage In TabControl5.TabPages

            TabPage.Text = ""
            TabPage.BackColor = Color.Azure

        Next



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



        TBColors()




    End Sub

    Private Sub TBColors()
        For Each tb As TextBox In GrpAccre.Controls.OfType(Of TextBox)()
            AddHandler tb.Enter, Sub() tb.BackColor = Color.LightYellow
            AddHandler tb.Leave, Sub() tb.BackColor = Color.White
        Next

        For Each tb As TextBox In GrpAttorney.Controls.OfType(Of TextBox)()
            AddHandler tb.Enter, Sub() tb.BackColor = Color.LightYellow
            AddHandler tb.Leave, Sub() tb.BackColor = Color.White
        Next

        For Each tb As TextBox In GrpBIR.Controls.OfType(Of TextBox)()
            AddHandler tb.Enter, Sub() tb.BackColor = Color.LightYellow
            AddHandler tb.Leave, Sub() tb.BackColor = Color.White
        Next

        For Each tb As TextBox In GrpClear.Controls.OfType(Of TextBox)()
            AddHandler tb.Enter, Sub() tb.BackColor = Color.LightYellow
            AddHandler tb.Leave, Sub() tb.BackColor = Color.White
        Next

        For Each tb As TextBox In GrpContract.Controls.OfType(Of TextBox)()
            AddHandler tb.Enter, Sub() tb.BackColor = Color.LightYellow
            AddHandler tb.Leave, Sub() tb.BackColor = Color.White
        Next

        For Each tb As TextBox In GrpCopy.Controls.OfType(Of TextBox)()
            AddHandler tb.Enter, Sub() tb.BackColor = Color.LightYellow
            AddHandler tb.Leave, Sub() tb.BackColor = Color.White
        Next

        For Each tb As TextBox In GrpCorp.Controls.OfType(Of TextBox)()
            AddHandler tb.Enter, Sub() tb.BackColor = Color.LightYellow
            AddHandler tb.Leave, Sub() tb.BackColor = Color.White
        Next

        For Each tb As TextBox In GrpHRDoc.Controls.OfType(Of TextBox)()
            AddHandler tb.Enter, Sub() tb.BackColor = Color.LightYellow
            AddHandler tb.Leave, Sub() tb.BackColor = Color.White
        Next

        For Each tb As TextBox In GrpImportation.Controls.OfType(Of TextBox)()
            AddHandler tb.Enter, Sub() tb.BackColor = Color.LightYellow
            AddHandler tb.Leave, Sub() tb.BackColor = Color.White
        Next

        For Each tb As TextBox In GrpMemo.Controls.OfType(Of TextBox)()
            AddHandler tb.Enter, Sub() tb.BackColor = Color.LightYellow
            AddHandler tb.Leave, Sub() tb.BackColor = Color.White
        Next

        For Each tb As TextBox In GrpOther.Controls.OfType(Of TextBox)()
            AddHandler tb.Enter, Sub() tb.BackColor = Color.LightYellow
            AddHandler tb.Leave, Sub() tb.BackColor = Color.White
        Next

        For Each tb As TextBox In GrpPatent.Controls.OfType(Of TextBox)()
            AddHandler tb.Enter, Sub() tb.BackColor = Color.LightYellow
            AddHandler tb.Leave, Sub() tb.BackColor = Color.White
        Next

        For Each tb As TextBox In GrpReceipt.Controls.OfType(Of TextBox)()
            AddHandler tb.Enter, Sub() tb.BackColor = Color.LightYellow
            AddHandler tb.Leave, Sub() tb.BackColor = Color.White
        Next

        For Each tb As TextBox In GrpSubs.Controls.OfType(Of TextBox)()
            AddHandler tb.Enter, Sub() tb.BackColor = Color.LightYellow
            AddHandler tb.Leave, Sub() tb.BackColor = Color.White
        Next

        For Each tb As TextBox In GrpTimeSheet.Controls.OfType(Of TextBox)()
            AddHandler tb.Enter, Sub() tb.BackColor = Color.LightYellow
            AddHandler tb.Leave, Sub() tb.BackColor = Color.White
        Next

        For Each tb As TextBox In GrpTrade.Controls.OfType(Of TextBox)()
            AddHandler tb.Enter, Sub() tb.BackColor = Color.LightYellow
            AddHandler tb.Leave, Sub() tb.BackColor = Color.White
        Next

        For Each tb As TextBox In GrpVoucher.Controls.OfType(Of TextBox)()
            AddHandler tb.Enter, Sub() tb.BackColor = Color.LightYellow
            AddHandler tb.Leave, Sub() tb.BackColor = Color.White
        Next

        For Each tb As TextBox In GrpWarranty.Controls.OfType(Of TextBox)()
            AddHandler tb.Enter, Sub() tb.BackColor = Color.LightYellow
            AddHandler tb.Leave, Sub() tb.BackColor = Color.White
        Next

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


        Me.PaymentFormComboBox.Items.Add("Bank Deposit")
        Me.PaymentFormComboBox.Items.Add("Cash")
        Me.PaymentFormComboBox.Items.Add("Check")
        Me.PaymentFormComboBox.Items.Add("Others")



        Me.PaymentFormImport.Items.Add("Letter of Credit")
        Me.PaymentFormImport.Items.Add("DP")
        Me.PaymentFormImport.Items.Add("Others")



        Me.ShipBatchImport.Items.Add("Batch 1")
        Me.ShipBatchImport.Items.Add("Batch 2")
        Me.ShipBatchImport.Items.Add("Batch 3")
        Me.ShipBatchImport.Items.Add("Batch 4")
        Me.ShipBatchImport.Items.Add("Batch 5")
        Me.ShipBatchImport.Items.Add("Batch 6")
        Me.ShipBatchImport.Items.Add("Batch 7")
        Me.ShipBatchImport.Items.Add("Batch 8")
        Me.ShipBatchImport.Items.Add("Batch 9")
        Me.ShipBatchImport.Items.Add("Batch 10")




    End Sub
    Private Sub ComboSelect4()


        If Me.PaymentFormImport.Text = "Letter of Credit" Then
            TabControl5.Visible = True
            TabControl5.SelectTab(LCNo)
        ElseIf Me.PaymentFormImport.Text = "DP" Then
            TabControl5.Visible = True
            TabControl5.SelectTab(DPNo)
        ElseIf Me.PaymentFormImport.Text = "Others" Then
            TabControl5.Visible = True
            TabControl5.SelectTab(OthersImport)

        ElseIf Me.PaymentFormImport.Text = "" Then
            TabControl5.Visible = False
        ElseIf Me.PaymentFormImport.SelectedIndex = -1 Then
            TabControl5.Visible = False
        End If





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
        ElseIf Me.C1TrueDBGrid2.Columns("Document Type").Text = "Importation Documents" Then
            TabControl2.SelectTab(Importation)
        ElseIf Me.C1TrueDBGrid2.Columns("Document Type").Text = "BIR Form" Then
            TabControl2.SelectTab(BIR)
        ElseIf Me.C1TrueDBGrid2.Columns("Document Type").Text = "HR Document" Then
            TabControl2.SelectTab(HRDoc)
        ElseIf Me.C1TrueDBGrid2.Columns("Document Type").Text = "Board Resolution" Then
            TabControl2.SelectTab(CorpDocu)
            TabControl4.SelectTab(TabMeeting2)
        ElseIf Me.C1TrueDBGrid2.Columns("Document Type").Text = "Copyright" Then
            TabControl2.SelectTab(Copyright)
        ElseIf Me.C1TrueDBGrid2.Columns("Document Type").Text = "Trademark" Then
            TabControl2.SelectTab(Trademark)
        ElseIf Me.C1TrueDBGrid2.Columns("Document Type").Text = "Trademark" Then
            TabControl2.SelectTab(Trademark)
        ElseIf Me.C1TrueDBGrid2.Columns("Document Type").Text = "Patent" Then
            TabControl2.SelectTab(Patent)
        ElseIf Me.C1TrueDBGrid2.Columns("Document Type").Text = "BIR Importer Clearance Certificate (BIR-ICC)" Then
            TabControl2.SelectTab(BIRClear)
        ElseIf Me.C1TrueDBGrid2.Columns("Document Type").Text = "Certificate of Accreditation" Then
            TabControl2.SelectTab(Accredit)
        ElseIf Me.C1TrueDBGrid2.Columns("Document Type").Text = "GS1 Membership Subscription" Then
            TabControl2.SelectTab(Subs)
        ElseIf Me.C1TrueDBGrid2.Columns("Document Type").Text = "Contract" Then
            TabControl2.SelectTab(Contract)
        ElseIf Me.C1TrueDBGrid2.Columns("Document Type").Text = "Special Power of Attorney" Then
            TabControl2.SelectTab(Attorney)
        ElseIf Me.C1TrueDBGrid2.Columns("Document Type").Text = "Other Documents" Then
            TabControl2.SelectTab(OtherDoc)
        ElseIf Me.C1TrueDBGrid2.Columns("Document Type").Text = "Memorandum" Then
            TabControl2.SelectTab(Memo)

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
        ElseIf Me.DocumentTypeCombobox2.Text = "Importation Documents" Then
            TabControl2.SelectTab(Importation)
        ElseIf Me.DocumentTypeCombobox2.Text = "BIR Form" Then
            TabControl2.SelectTab(BIR)
        ElseIf Me.DocumentTypeCombobox2.Text = "HR Document" Then
            TabControl2.SelectTab(HRDoc)
        ElseIf Me.DocumentTypeCombobox2.Text = "Board Resolution" Then
            TabControl2.SelectTab(CorpDocu)
            TabControl4.SelectTab(TabMeeting2)
        ElseIf Me.DocumentTypeCombobox2.Text = "Copyright" Then
            TabControl2.SelectTab(Copyright)
        ElseIf Me.DocumentTypeCombobox2.Text = "Trademark" Then
            TabControl2.SelectTab(Trademark)
        ElseIf Me.DocumentTypeCombobox2.Text = "Trademark" Then
            TabControl2.SelectTab(Trademark)
        ElseIf Me.DocumentTypeCombobox2.Text = "Patent" Then
            TabControl2.SelectTab(Patent)
        ElseIf Me.DocumentTypeCombobox2.Text = "BIR Importer Clearance Certificate (BIR-ICC)" Then
            TabControl2.SelectTab(BIRClear)
        ElseIf Me.DocumentTypeCombobox2.Text = "Certificate of Accreditation" Then
            TabControl2.SelectTab(Accredit)
        ElseIf Me.DocumentTypeCombobox2.Text = "GS1 Membership Subscription" Then
            TabControl2.SelectTab(Subs)
        ElseIf Me.DocumentTypeCombobox2.Text = "Contract" Then
            TabControl2.SelectTab(Contract)
        ElseIf Me.DocumentTypeCombobox2.Text = "Special Power of Attorney" Then
            TabControl2.SelectTab(Attorney)
        ElseIf Me.DocumentTypeCombobox2.Text = "Other Documents" Then
            TabControl2.SelectTab(OtherDoc)
        ElseIf Me.DocumentTypeCombobox2.Text = "Memorandum" Then
            TabControl2.SelectTab(Memo)





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
            OR  [AddressC] LIKE '%' + @Wild + '%'
    OR  [Remarks]  LIKE '%' + @Wild + '%'
    OR  [FromPeriod]  LIKE '%' + @Wild + '%'
    OR  [ToPeriod]  LIKE '%' + @Wild + '%'
    OR  [DatePurchased]  LIKE '%' + @Wild + '%'
    OR  [MeetingDate]  LIKE '%' + @Wild + '%'
    OR  [DateReceived]  LIKE '%' + @Wild + '%' 
    OR  [BatchDesc]  LIKE '%' + @Wild + '%'
    OR  [PromoFrom]  LIKE '%' + @Wild + '%'
    OR  [PromoTo]  LIKE '%' + @Wild + '%'
    OR  [DocSize]  LIKE '%' + @Wild + '%'
    OR  [Pages]  LIKE '%' + @Wild + '%'
    OR  [ImportMonth]  LIKE '%' + @Wild + '%'
    OR  [Country]  LIKE '%' + @Wild + '%'
    OR  [ISRNo]  LIKE '%' + @Wild + '%'
    OR  [PRONo]  LIKE '%' + @Wild + '%'
    OR  [ShipBatch]   LIKE '%' + @Wild + '%'
    OR  [CargoDesc]  LIKE '%' + @Wild + '%'
    OR  [ShipLine]  LIKE '%' + @Wild + '%'
    OR  [BillNo]  LIKE '%' + @Wild + '%'
    OR  [ContQtyx40]  LIKE '%' + @Wild + '%'
    OR  [ContQtyx20]  LIKE '%' + @Wild + '%'
    OR  [VesselArrived]  LIKE '%' + @Wild + '%'
    OR  [LetterCredit]  LIKE '%' + @Wild + '%'
    OR  [DPNo]  LIKE '%' + @Wild + '%'
    OR  [BrokeCompany]  LIKE '%' + @Wild + '%'
    OR  [CustomsNo]  LIKE '%' + @Wild + '%'
    OR  [RegNo]  LIKE '%' + @Wild + '%'
    OR  [InsuranceCompany]  LIKE '%' + @Wild + '%'
    OR  [PolicyNo]  LIKE '%' + @Wild + '%'
    OR  [YearReport]  LIKE '%' + @Wild + '%'
    OR  [Sex]  LIKE '%' + @Wild + '%'
    OR  [Title]  LIKE '%' + @Wild + '%'
    OR  [Author]  LIKE '%' + @Wild + '%'
    OR  [Class]  LIKE '%' + @Wild + '%'
    OR  [CreationDate]  LIKE '%' + @Wild + '%'
    OR  [PeriodProtect]  LIKE '%' + @Wild + '%'
    OR  [RegDate]  LIKE '%' + @Wild + '%'
    OR  [Term]  LIKE '%' + @Wild + '%'
    OR  [FilingDate]  LIKE '%' + @Wild + '%'
    OR  [Registrant]  LIKE '%' + @Wild + '%'
    OR  [RegMark]  LIKE '%' + @Wild + '%'
    OR  [IssueDate]  LIKE '%' + @Wild + '%'
    OR  [BIRICCNo]  LIKE '%' + @Wild + '%'
    OR  [AccreditNo]  LIKE '%' + @Wild + '%'
    OR  [CompanyPrefix]  LIKE '%' + @Wild + '%'
    OR  [GLN]  LIKE '%' + @Wild + '%'
    OR  [SubsDate]  LIKE '%' + @Wild + '%'
    OR  [ContractType]  LIKE '%' + @Wild + '%'
    OR  [SignDate]  LIKE '%' + @Wild + '%'
    OR  [ContractPlace]  LIKE '%' + @Wild + '%'
    OR  [P1Company]  LIKE '%' + @Wild + '%'
    OR  [P1FirstName]  LIKE '%' + @Wild + '%'
    OR  [P1MiddleName]  LIKE '%' + @Wild + '%'
    OR  [P1LastName]  LIKE '%' + @Wild + '%'
    OR  [P1Position]  LIKE '%' + @Wild + '%'
    OR  [P2Company]  LIKE '%' + @Wild + '%'
    OR  [P2FirstName]  LIKE '%' + @Wild + '%'
    OR  [P2MiddleName]  LIKE '%' + @Wild + '%'
    OR  [P2LastName]  LIKE '%' + @Wild + '%'
    OR  [P2Position]  LIKE '%' + @Wild + '%'
    OR  [IssuePlace]  LIKE '%' + @Wild + '%'
    OR  [MemoType]  LIKE '%' + @Wild + '%'
    OR  [MemoSubj]  LIKE '%' + @Wild + '%'


)
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

        If BtnEditRecord.Text = "Edit Record" Then




            Try
                ComboSelect()


                Dim Confistatus As String
                Confistatus = IIf(FrmMain.type = "System Admin" Or FrmMain.type = "Admin", "", "Unchecked")
                Me.DocsCatalogueTableAdapter.Fill(Me.DMSDataSet.DocsCatalogue, "Finished", Confistatus)

                'Me.DocsCatalogueTableAdapter.Fill(Me.DMSDataSet.DocsCatalogue, "Finished", IIf(FrmMain.type = "System Admin" Or FrmMain.type = "Admin", "", "Unchecked"))

                ' Me.DocsCatalogueBindingSource.Filter = "[Id] = '" & Me.C1TrueDBGrid2.Columns("Document No").Text & "' "

                Me.DocsCatalogueBindingSource.Position = Me.DocsCatalogueBindingSource.Find("Id", Me.C1TrueDBGrid2.Columns("Document No").Text)
                Dim pdffile As String = (My.Settings.ImgPath & "\" & Me.C1TrueDBGrid2.Columns("File Name").Text)
                WebBrowser1.Navigate(pdffile)

                ' AxAcroPDF1.src = (My.Settings.ImgPath & "\" & Me.C1TrueDBGrid2.Columns("File Name").Text)

                TabControl1.SelectTab(TabChanges)

                Me.C1TrueDBGrid2.Enabled = False
                Me.BtnSearch.Enabled = False
                Me.BtnSaveChanges1.Enabled = True
                Me.BtnRemoval.Enabled = False
                Me.BtnDownload.Enabled = False

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



                BtnEditRecord.Text = "Cancel Edit"

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try






        ElseIf BtnEditRecord.Text = "Cancel Edit" Then

            Try


                Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
                Dim cmdlogs As New SqlCommand(" INSERT INTO DMSLogs(Username, Action, ActionDate) VALUES (@Username, @Action, @ActionDate)", con)
                ' Dim dRemoteDate As Date
                '  dRemoteDate = GetNetRemoteTOD(My.Settings.remoteTOD)

                con.Open()
                cmdlogs.Connection = con
                cmdlogs.Parameters.AddWithValue("@Username", FrmMain.User)
                cmdlogs.Parameters.AddWithValue("@Action", FrmMain.User & " " & "Canceled Editing Record ID:" & Me.C1TrueDBGrid2.Columns("Document No").Text)
                cmdlogs.Parameters.AddWithValue("@ActionDate", DateTime.Now)
                cmdlogs.ExecuteNonQuery()
                con.Close()




                Me.C1TrueDBGrid2.Enabled = True
                Me.BtnSearch.Enabled = True
                Me.BtnSaveChanges1.Enabled = False
                Me.BtnRemoval.Enabled = True
                Me.BtnDownload.Enabled = True

                Me.TabControl1.SelectTab(TabQuery)



                Search()


                BtnEditRecord.Text = "Edit Record"


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try


        End If

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


            SaveChanges()
            Search()
            BtnEditRecord.Text = "Edit Record"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
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


        Dim DateFormat As Date

        If Date.TryParseExact(DocumentDateCorp.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.DocumentDateCorp.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.DocumentDateCorp.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.DocumentDateCorp.Clear()
        End If
    End Sub
    Private Sub MeetingDateTextBox_LostFocus(sender As Object, e As EventArgs) Handles MeetingDateTextBox.LostFocus
        MeetingDateTextBox.BackColor = Color.LightYellow

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


        Dim DateFormat As Date

        If Date.TryParseExact(DocumentDateVoucher.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.DocumentDateVoucher.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.DocumentDateVoucher.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.DocumentDateVoucher.Clear()
        End If
    End Sub
    Private Sub DatePurchasedTextBox_LostFocus(sender As Object, e As EventArgs) Handles DatePurchasedTextBox.LostFocus


        Dim DateFormat As Date
        If Date.TryParseExact(DatePurchasedTextBox.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.DatePurchasedTextBox.Text = "" Then
        Else
            MessageBox.Show("Incorrect Date Format " & Me.DatePurchasedTextBox.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.DatePurchasedTextBox.Clear()
        End If
    End Sub

    Private Sub DocumentDateRI_LostFocus(sender As Object, e As EventArgs) Handles DocumentDateRI.LostFocus

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


    Private Sub DocumentDateTS_LostFocus(sender As Object, e As EventArgs) Handles DocumentDateTS.LostFocus



        Dim DateFormat As Date

        If Date.TryParseExact(DocumentDateTS.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.DocumentDateTS.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.DocumentDateTS.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.DocumentDateTS.Clear()
        End If
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
        Me.DocsCatalogueBindingSource.Filter = "[Id] = '" & IdTextBox.Text & "' "
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



    Private Sub DTIssueDateMemo_ValueChanged_1(sender As Object, e As EventArgs) Handles DTIssueDateMemo.ValueChanged
        Me.IssueDateMemo.Text = Me.DTIssueDateMemo.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub IssueDateMemo_TextChanged(sender As Object, e As EventArgs) Handles IssueDateMemo.TextChanged

    End Sub

    Private Sub IssueDateMemo_LostFocus(sender As Object, e As EventArgs) Handles IssueDateMemo.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(IssueDateMemo.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.IssueDateMemo.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.IssueDateMemo.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.IssueDateMemo.Clear()
        End If
    End Sub

    Private Sub DTIssueDateOther_ValueChanged(sender As Object, e As EventArgs) Handles DTIssueDateOther.ValueChanged
        Me.IssueDateOther.Text = Me.DTIssueDateOther.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTIssuePlaceOther_ValueChanged_1(sender As Object, e As EventArgs) Handles DTIssuePlaceOther.ValueChanged
        Me.IssuePlaceOther.Text = Me.DTIssuePlaceOther.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub IssueDateOther_TextChanged(sender As Object, e As EventArgs) Handles IssueDateOther.TextChanged

    End Sub

    Private Sub IssueDateOther_LostFocus(sender As Object, e As EventArgs) Handles IssueDateOther.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(IssueDateOther.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.IssueDateOther.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.IssueDateOther.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.IssueDateOther.Clear()
        End If
    End Sub

    Private Sub IssuePlaceOther_TextChanged(sender As Object, e As EventArgs) Handles IssuePlaceOther.TextChanged

    End Sub

    Private Sub IssuePlaceOther_LostFocus(sender As Object, e As EventArgs) Handles IssuePlaceOther.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(IssuePlaceOther.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.IssuePlaceOther.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.IssuePlaceOther.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.IssuePlaceOther.Clear()
        End If
    End Sub

    Private Sub DTIssueDateAttorney_ValueChanged(sender As Object, e As EventArgs) Handles DTIssueDateAttorney.ValueChanged
        Me.IssueDateAttorney.Text = Me.DTIssueDateAttorney.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTIssuePlaceAttorney_ValueChanged_1(sender As Object, e As EventArgs) Handles DTIssuePlaceAttorney.ValueChanged
        Me.IssuePlaceAttorney.Text = Me.DTIssuePlaceAttorney.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub IssueDateAttorney_TextChanged(sender As Object, e As EventArgs) Handles IssueDateAttorney.TextChanged

    End Sub

    Private Sub IssueDateAttorney_LostFocus(sender As Object, e As EventArgs) Handles IssueDateAttorney.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(IssueDateAttorney.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.IssueDateAttorney.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.IssueDateAttorney.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.IssueDateAttorney.Clear()
        End If
    End Sub

    Private Sub IssuePlaceAttorney_TextChanged(sender As Object, e As EventArgs) Handles IssuePlaceAttorney.TextChanged

    End Sub

    Private Sub IssuePlaceAttorney_LostFocus(sender As Object, e As EventArgs) Handles IssuePlaceAttorney.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(IssuePlaceAttorney.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.IssuePlaceAttorney.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.IssuePlaceAttorney.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.IssuePlaceAttorney.Clear()
        End If
    End Sub

    Private Sub DTFromAttorney_ValueChanged_1(sender As Object, e As EventArgs) Handles DTFromAttorney.ValueChanged
        Me.FromPeriodAttorney.Text = Me.DTFromAttorney.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTToAttorney_ValueChanged_1(sender As Object, e As EventArgs) Handles DTToAttorney.ValueChanged
        Me.ToPeriodAttorney.Text = Me.DTToAttorney.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub FromPeriodAttorney_TextChanged(sender As Object, e As EventArgs) Handles FromPeriodAttorney.TextChanged

    End Sub

    Private Sub FromPeriodAttorney_LostFocus(sender As Object, e As EventArgs) Handles FromPeriodAttorney.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(FromPeriodAttorney.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.FromPeriodAttorney.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.FromPeriodAttorney.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.FromPeriodAttorney.Clear()
        End If
    End Sub

    Private Sub ToPeriodAttorney_TextChanged(sender As Object, e As EventArgs) Handles ToPeriodAttorney.TextChanged

    End Sub

    Private Sub ToPeriodAttorney_LostFocus(sender As Object, e As EventArgs) Handles ToPeriodAttorney.LostFocus

        Dim DateFormat As Date

        If Date.TryParseExact(ToPeriodAttorney.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.ToPeriodAttorney.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.ToPeriodAttorney.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.ToPeriodAttorney.Clear()
        End If
    End Sub

    Private Sub DTFromContract_ValueChanged_1(sender As Object, e As EventArgs) Handles DTFromContract.ValueChanged
        Me.FromPeriodContract.Text = Me.DTFromContract.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub FromPeriodContract_TextChanged(sender As Object, e As EventArgs) Handles FromPeriodContract.TextChanged

    End Sub

    Private Sub FromPeriodContract_LostFocus(sender As Object, e As EventArgs) Handles FromPeriodContract.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(FromPeriodContract.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.FromPeriodContract.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.FromPeriodContract.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.FromPeriodContract.Clear()
        End If
    End Sub

    Private Sub DTToContract_ValueChanged_1(sender As Object, e As EventArgs) Handles DTToContract.ValueChanged
        Me.ToPeriodContract.Text = Me.DTToContract.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub ToPeriodContract_TextChanged(sender As Object, e As EventArgs) Handles ToPeriodContract.TextChanged

    End Sub

    Private Sub ToPeriodContract_LostFocus(sender As Object, e As EventArgs) Handles ToPeriodContract.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(ToPeriodContract.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.ToPeriodContract.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.ToPeriodContract.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.ToPeriodContract.Clear()
        End If
    End Sub

    Private Sub DTDateSignContract_ValueChanged_1(sender As Object, e As EventArgs) Handles DTDateSignContract.ValueChanged
        Me.SignDateContract.Text = Me.DTDateSignContract.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub SignDateContract_TextChanged(sender As Object, e As EventArgs) Handles SignDateContract.TextChanged

    End Sub

    Private Sub SignDateContract_LostFocus(sender As Object, e As EventArgs) Handles SignDateContract.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(SignDateContract.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.SignDateContract.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.SignDateContract.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.SignDateContract.Clear()
        End If
    End Sub

    Private Sub DTSubsDateSubs_ValueChanged(sender As Object, e As EventArgs) Handles DTSubsDateSubs.ValueChanged
        Me.SubsDateSubs.Text = Me.DTSubsDateSubs.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTFromSubs_ValueChanged_1(sender As Object, e As EventArgs) Handles DTFromSubs.ValueChanged
        Me.FromPeriodSubs.Text = Me.DTFromSubs.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTToSubs_ValueChanged_1(sender As Object, e As EventArgs) Handles DTToSubs.ValueChanged
        Me.ToPeriodSubs.Text = Me.DTToSubs.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub ToPeriodSubs_TextChanged(sender As Object, e As EventArgs) Handles ToPeriodSubs.TextChanged

    End Sub

    Private Sub ToPeriodSubs_LostFocus(sender As Object, e As EventArgs) Handles ToPeriodSubs.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(ToPeriodSubs.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.ToPeriodSubs.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.ToPeriodSubs.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.ToPeriodSubs.Clear()
        End If
    End Sub

    Private Sub FromPeriodSubs_TextChanged(sender As Object, e As EventArgs) Handles FromPeriodSubs.TextChanged

    End Sub

    Private Sub FromPeriodSubs_LostFocus(sender As Object, e As EventArgs) Handles FromPeriodSubs.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(FromPeriodSubs.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.FromPeriodSubs.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.FromPeriodSubs.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.FromPeriodSubs.Clear()
        End If
    End Sub

    Private Sub SubsDateSubs_TextChanged(sender As Object, e As EventArgs) Handles SubsDateSubs.TextChanged

    End Sub

    Private Sub SubsDateSubs_LostFocus(sender As Object, e As EventArgs) Handles SubsDateSubs.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(SubsDateSubs.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.SubsDateSubs.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.SubsDateSubs.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.SubsDateSubs.Clear()
        End If
    End Sub

    Private Sub DTIssueDateAccre_ValueChanged(sender As Object, e As EventArgs) Handles DTIssueDateAccre.ValueChanged
        Me.IssueDateAccre.Text = Me.DTIssueDateAccre.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTFromAccre_ValueChanged(sender As Object, e As EventArgs) Handles DTFromAccre.ValueChanged
        Me.FromPeriodAccre.Text = Me.DTFromAccre.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTToAccre_ValueChanged(sender As Object, e As EventArgs) Handles DTToAccre.ValueChanged
        Me.ToPeriodAccre.Text = Me.DTToAccre.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub IssueDateAccre_TextChanged(sender As Object, e As EventArgs) Handles IssueDateAccre.TextChanged

    End Sub

    Private Sub IssueDateAccre_LostFocus(sender As Object, e As EventArgs) Handles IssueDateAccre.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(IssueDateAccre.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.IssueDateAccre.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.IssueDateAccre.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.IssueDateAccre.Clear()
        End If
    End Sub

    Private Sub FromPeriodAccre_TextChanged(sender As Object, e As EventArgs) Handles FromPeriodAccre.TextChanged

    End Sub

    Private Sub FromPeriodAccre_LostFocus(sender As Object, e As EventArgs) Handles FromPeriodAccre.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(FromPeriodAccre.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.FromPeriodAccre.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.FromPeriodAccre.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.FromPeriodAccre.Clear()
        End If
    End Sub

    Private Sub ToPeriodAccre_TextChanged(sender As Object, e As EventArgs) Handles ToPeriodAccre.TextChanged

    End Sub

    Private Sub ToPeriodAccre_LostFocus(sender As Object, e As EventArgs) Handles ToPeriodAccre.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(ToPeriodAccre.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.ToPeriodAccre.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.ToPeriodAccre.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.ToPeriodAccre.Clear()
        End If
    End Sub

    Private Sub DTIssueDateClear_ValueChanged(sender As Object, e As EventArgs) Handles DTIssueDateClear.ValueChanged
        Me.IssueDateClear.Text = Me.DTIssueDateClear.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTFromClear_ValueChanged_1(sender As Object, e As EventArgs) Handles DTFromClear.ValueChanged
        Me.FromPeriodClear.Text = Me.DTFromClear.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTToClear_ValueChanged_1(sender As Object, e As EventArgs) Handles DTToClear.ValueChanged
        Me.ToPeriodClear.Text = Me.DTToClear.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub IssueDateClear_TextChanged(sender As Object, e As EventArgs) Handles IssueDateClear.TextChanged

    End Sub

    Private Sub IssueDateClear_LostFocus(sender As Object, e As EventArgs) Handles IssueDateClear.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(IssueDateClear.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.IssueDateClear.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.IssueDateClear.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.IssueDateClear.Clear()
        End If
    End Sub

    Private Sub FromPeriodClear_TextChanged(sender As Object, e As EventArgs) Handles FromPeriodClear.TextChanged

    End Sub

    Private Sub FromPeriodClear_LostFocus(sender As Object, e As EventArgs) Handles FromPeriodClear.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(FromPeriodClear.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.FromPeriodClear.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.FromPeriodClear.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.FromPeriodClear.Clear()
        End If
    End Sub

    Private Sub ToPeriodClear_TextChanged(sender As Object, e As EventArgs) Handles ToPeriodClear.TextChanged

    End Sub

    Private Sub ToPeriodClear_LostFocus(sender As Object, e As EventArgs) Handles ToPeriodClear.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(ToPeriodClear.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.ToPeriodClear.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.ToPeriodClear.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.ToPeriodClear.Clear()
        End If
    End Sub

    Private Sub DocumentDateTS_TextChanged(sender As Object, e As EventArgs) Handles DocumentDateTS.TextChanged

    End Sub

    Private Sub DTFromPeriod_ValueChanged(sender As Object, e As EventArgs) Handles DTFromPeriod.ValueChanged
        Me.FromPeriodTextBox.Text = Me.DTFromPeriod.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTToPeriod_ValueChanged(sender As Object, e As EventArgs) Handles DTToPeriod.ValueChanged
        Me.ToPeriodTextBox.Text = Me.DTToPeriod.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub





    Private Sub DTDateReceived_ValueChanged(sender As Object, e As EventArgs) Handles DTDateReceived.ValueChanged
        Me.DateReceivedTextBox.Text = Me.DTDateReceived.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DateReceivedTextBox_TextChanged(sender As Object, e As EventArgs) Handles DateReceivedTextBox.TextChanged

    End Sub

    Private Sub DateReceivedTextBox_LostFocus(sender As Object, e As EventArgs) Handles DateReceivedTextBox.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(DateReceivedTextBox.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.DateReceivedTextBox.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.DateReceivedTextBox.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.DateReceivedTextBox.Clear()
        End If
    End Sub



    Private Sub DateTimePicker1_ValueChanged_5(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Me.ImpMonthImport.Text = Me.DateTimePicker1.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub ImpMonthImport_TextChanged(sender As Object, e As EventArgs) Handles ImpMonthImport.TextChanged

    End Sub

    Private Sub ImpMonthImport_LostFocus(sender As Object, e As EventArgs) Handles ImpMonthImport.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(ImpMonthImport.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.ImpMonthImport.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.ImpMonthImport.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.ImpMonthImport.Clear()
        End If
    End Sub

    Private Sub DTVesselImport_ValueChanged(sender As Object, e As EventArgs) Handles DTVesselImport.ValueChanged
        Me.VesselArrivedImport.Text = Me.DTVesselImport.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub VesselArrivedImport_TextChanged(sender As Object, e As EventArgs) Handles VesselArrivedImport.TextChanged

    End Sub

    Private Sub VesselArrivedImport_LostFocus(sender As Object, e As EventArgs) Handles VesselArrivedImport.LostFocus



        Dim DateFormat As Date

        If Date.TryParseExact(VesselArrivedImport.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.VesselArrivedImport.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.VesselArrivedImport.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.VesselArrivedImport.Clear()
        End If
    End Sub

    Private Sub DTDocuBIR_ValueChanged_1(sender As Object, e As EventArgs) Handles DTDocuBIR.ValueChanged

        Me.DocumentDateBIR.Text = Me.DTDocuBIR.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DocumentDateBIR_TextChanged(sender As Object, e As EventArgs) Handles DocumentDateBIR.TextChanged

    End Sub

    Private Sub DocumentDateBIR_LostFocus(sender As Object, e As EventArgs) Handles DocumentDateBIR.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(DocumentDateBIR.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.DocumentDateBIR.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.DocumentDateBIR.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.DocumentDateBIR.Clear()
        End If
    End Sub

    Private Sub DTDocuHRDoc_ValueChanged_1(sender As Object, e As EventArgs) Handles DTDocuHRDoc.ValueChanged
        Me.DocumentDateHRDoc.Text = Me.DTDocuHRDoc.Value.ToString("MM/dd/yyyy")
    End Sub



    Private Sub DocumentDateHRDoc_LostFocus(sender As Object, e As EventArgs) Handles DocumentDateHRDoc.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(DocumentDateHRDoc.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.DocumentDateHRDoc.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.DocumentDateHRDoc.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.DocumentDateHRDoc.Clear()
        End If
    End Sub

    Private Sub DTCreateDate_ValueChanged(sender As Object, e As EventArgs) Handles DTCreateDate.ValueChanged
        Me.CreationDateCopy.Text = Me.DTCreateDate.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub CreationDateCopy_TextChanged(sender As Object, e As EventArgs) Handles CreationDateCopy.TextChanged


        Dim DateFormat As Date

        If Date.TryParseExact(CreationDateCopy.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.CreationDateCopy.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.CreationDateCopy.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.CreationDateCopy.Clear()
        End If
    End Sub

    Private Sub DTRegDateTrade_ValueChanged_1(sender As Object, e As EventArgs) Handles DTRegDateTrade.ValueChanged
        Me.RegDateTrade.Text = Me.DTRegDateTrade.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub RegDateTrade_TextChanged(sender As Object, e As EventArgs) Handles RegDateTrade.TextChanged

    End Sub

    Private Sub RegDateTrade_LostFocus(sender As Object, e As EventArgs) Handles RegDateTrade.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(RegDateTrade.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.RegDateTrade.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.RegDateTrade.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.RegDateTrade.Clear()
        End If
    End Sub

    Private Sub DTFromTrade_ValueChanged_1(sender As Object, e As EventArgs) Handles DTFromTrade.ValueChanged
        Me.FromPeriodTrade.Text = Me.DTFromTrade.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTToTrade_ValueChanged_1(sender As Object, e As EventArgs) Handles DTToTrade.ValueChanged
        Me.ToPeriodTrade.Text = Me.DTToTrade.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTFilingTrade_ValueChanged_1(sender As Object, e As EventArgs) Handles DTFilingTrade.ValueChanged
        Me.FilingDateTrade.Text = Me.DTFilingTrade.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub FromPeriodTrade_TextChanged(sender As Object, e As EventArgs) Handles FromPeriodTrade.TextChanged

    End Sub

    Private Sub FromPeriodTrade_LostFocus(sender As Object, e As EventArgs) Handles FromPeriodTrade.LostFocus



        Dim DateFormat As Date

        If Date.TryParseExact(FromPeriodTrade.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.FromPeriodTrade.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.FromPeriodTrade.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.FromPeriodTrade.Clear()
        End If
    End Sub

    Private Sub ToPeriodTrade_TextChanged(sender As Object, e As EventArgs) Handles ToPeriodTrade.TextChanged

    End Sub

    Private Sub ToPeriodTrade_LostFocus(sender As Object, e As EventArgs) Handles ToPeriodTrade.LostFocus



        Dim DateFormat As Date

        If Date.TryParseExact(ToPeriodTrade.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.ToPeriodTrade.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.ToPeriodTrade.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.ToPeriodTrade.Clear()
        End If
    End Sub

    Private Sub FilingDateTrade_TextChanged(sender As Object, e As EventArgs) Handles FilingDateTrade.TextChanged

    End Sub

    Private Sub FilingDateTrade_LostFocus(sender As Object, e As EventArgs) Handles FilingDateTrade.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(FilingDateTrade.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.FilingDateTrade.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.FilingDateTrade.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.FilingDateTrade.Clear()
        End If
    End Sub

    Private Sub DTRegDatePatent_ValueChanged(sender As Object, e As EventArgs) Handles DTRegDatePatent.ValueChanged
        Me.RegDatePatent.Text = Me.DTRegDatePatent.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTFromPatent_ValueChanged_1(sender As Object, e As EventArgs) Handles DTFromPatent.ValueChanged
        Me.FromPeriodPatent.Text = Me.DTFromPatent.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTToPatent_ValueChanged_1(sender As Object, e As EventArgs) Handles DTToPatent.ValueChanged
        Me.ToPeriodPatent.Text = Me.DTToPatent.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTFilingPatent_ValueChanged_1(sender As Object, e As EventArgs) Handles DTFilingPatent.ValueChanged
        Me.FilingDatePatent.Text = Me.DTFilingPatent.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub RegDatePatent_TextChanged(sender As Object, e As EventArgs) Handles RegDatePatent.TextChanged

    End Sub

    Private Sub RegDatePatent_LostFocus(sender As Object, e As EventArgs) Handles RegDatePatent.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(RegDatePatent.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.RegDatePatent.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.RegDatePatent.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.RegDatePatent.Clear()
        End If
    End Sub

    Private Sub FromPeriodPatent_TextChanged(sender As Object, e As EventArgs) Handles FromPeriodPatent.TextChanged

    End Sub

    Private Sub FromPeriodPatent_LostFocus(sender As Object, e As EventArgs) Handles FromPeriodPatent.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(FromPeriodPatent.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.FromPeriodPatent.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.FromPeriodPatent.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.FromPeriodPatent.Clear()
        End If
    End Sub

    Private Sub ToPeriodPatent_TextChanged(sender As Object, e As EventArgs) Handles ToPeriodPatent.TextChanged

    End Sub

    Private Sub ToPeriodPatent_LostFocus(sender As Object, e As EventArgs) Handles ToPeriodPatent.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(ToPeriodPatent.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.ToPeriodPatent.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.ToPeriodPatent.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.ToPeriodPatent.Clear()
        End If
    End Sub

    Private Sub FilingDatePatent_TextChanged(sender As Object, e As EventArgs) Handles FilingDatePatent.TextChanged

    End Sub

    Private Sub FilingDatePatent_LostFocus(sender As Object, e As EventArgs) Handles FilingDatePatent.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(FilingDatePatent.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.FilingDatePatent.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.FilingDatePatent.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.FilingDatePatent.Clear()
        End If
    End Sub

    Private Sub DTDocuTimeSheet_GotFocus(sender As Object, e As EventArgs) Handles DTDocuTimeSheet.GotFocus
        DocumentDateTS.BackColor = Color.LightYellow
    End Sub

    Private Sub DTDocuTimeSheet_LostFocus(sender As Object, e As EventArgs) Handles DTDocuTimeSheet.LostFocus
        DocumentDateTS.BackColor = Color.White
    End Sub

    Private Sub BatchTextBox_TextChanged(sender As Object, e As EventArgs) Handles BatchTextBox.TextChanged

    End Sub

    Private Sub BatchTextBox_GotFocus(sender As Object, e As EventArgs) Handles BatchTextBox.GotFocus
        BatchTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub BatchTextBox_LostFocus(sender As Object, e As EventArgs) Handles BatchTextBox.LostFocus
        BatchTextBox.BackColor = Color.White
    End Sub

    Private Sub SubBatchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SubBatchTextBox.TextChanged

    End Sub

    Private Sub SubBatchTextBox_GotFocus(sender As Object, e As EventArgs) Handles SubBatchTextBox.GotFocus
        SubBatchTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub SubBatchTextBox_LostFocus(sender As Object, e As EventArgs) Handles SubBatchTextBox.LostFocus
        SubBatchTextBox.BackColor = Color.White
    End Sub

    Private Sub IdTextBox_GotFocus(sender As Object, e As EventArgs) Handles IdTextBox.GotFocus
        IdTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub IdTextBox_LostFocus(sender As Object, e As EventArgs) Handles IdTextBox.LostFocus
        IdTextBox.BackColor = Color.White
    End Sub

    Private Sub txtPages_TextChanged(sender As Object, e As EventArgs) Handles txtPages.TextChanged

    End Sub

    Private Sub txtPages_GotFocus(sender As Object, e As EventArgs) Handles txtPages.GotFocus
        txtPages.BackColor = Color.LightYellow
    End Sub

    Private Sub txtPages_LostFocus(sender As Object, e As EventArgs) Handles txtPages.LostFocus
        txtPages.BackColor = Color.White
    End Sub

    Private Sub DTFromPeriod_GotFocus(sender As Object, e As EventArgs) Handles DTFromPeriod.GotFocus
        FromPeriodTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub DTFromPeriod_LostFocus(sender As Object, e As EventArgs) Handles DTFromPeriod.LostFocus
        FromPeriodTextBox.BackColor = Color.White
    End Sub

    Private Sub DTToPeriod_GotFocus(sender As Object, e As EventArgs) Handles DTToPeriod.GotFocus
        ToPeriodTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub DTToPeriod_LostFocus(sender As Object, e As EventArgs) Handles DTToPeriod.LostFocus
        ToPeriodTextBox.BackColor = Color.White
    End Sub

    Private Sub FromPeriodTextBox_TextChanged(sender As Object, e As EventArgs) Handles FromPeriodTextBox.TextChanged

    End Sub

    Private Sub FromPeriodTextBox_GotFocus(sender As Object, e As EventArgs) Handles FromPeriodTextBox.GotFocus
        FromPeriodTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub ToPeriodTextBox_TextChanged(sender As Object, e As EventArgs) Handles ToPeriodTextBox.TextChanged

    End Sub

    Private Sub ToPeriodTextBox_GotFocus(sender As Object, e As EventArgs) Handles ToPeriodTextBox.GotFocus
        ToPeriodTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub DTDocuRI_GotFocus(sender As Object, e As EventArgs) Handles DTDocuRI.GotFocus
        DocumentDateRI.BackColor = Color.LightYellow
    End Sub

    Private Sub DTDocuRI_LostFocus(sender As Object, e As EventArgs) Handles DTDocuRI.LostFocus
        DocumentDateRI.BackColor = Color.White
    End Sub

    Private Sub DTDatePurchased_GotFocus(sender As Object, e As EventArgs) Handles DTDatePurchased.GotFocus
        DatePurchasedTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub DTDatePurchased_LostFocus(sender As Object, e As EventArgs) Handles DTDatePurchased.LostFocus
        DatePurchasedTextBox.BackColor = Color.White
    End Sub

    Private Sub DTDocuVoucher_GotFocus(sender As Object, e As EventArgs) Handles DTDocuVoucher.GotFocus
        DocumentDateVoucher.BackColor = Color.LightYellow
    End Sub

    Private Sub DTDocuVoucher_LostFocus(sender As Object, e As EventArgs) Handles DTDocuVoucher.LostFocus
        DocumentDateVoucher.BackColor = Color.White
    End Sub

    Private Sub DTDateReceived_GotFocus(sender As Object, e As EventArgs) Handles DTDateReceived.GotFocus
        DateReceivedTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub DTDateReceived_LostFocus(sender As Object, e As EventArgs) Handles DTDateReceived.LostFocus
        DateReceivedTextBox.BackColor = Color.White
    End Sub

    Private Sub BankNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles BankNameTextBox.TextChanged

    End Sub

    Private Sub BankNameTextBox_GotFocus(sender As Object, e As EventArgs) Handles BankNameTextBox.GotFocus
        BankNameTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub BankNameTextBox_LostFocus(sender As Object, e As EventArgs) Handles BankNameTextBox.LostFocus
        BankNameTextBox.BackColor = Color.White
    End Sub

    Private Sub BankBranchTextBox_TextChanged(sender As Object, e As EventArgs) Handles BankBranchTextBox.TextChanged

    End Sub

    Private Sub BankBranchTextBox_GotFocus(sender As Object, e As EventArgs) Handles BankBranchTextBox.GotFocus
        BankBranchTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub BankBranchTextBox_LostFocus(sender As Object, e As EventArgs) Handles BankBranchTextBox.LostFocus
        BankBranchTextBox.BackColor = Color.White
    End Sub

    Private Sub BankAddressTextBox_TextChanged(sender As Object, e As EventArgs) Handles BankAddressTextBox.TextChanged

    End Sub

    Private Sub BankAddressTextBox_GotFocus(sender As Object, e As EventArgs) Handles BankAddressTextBox.GotFocus
        BankAddressTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub BankAddressTextBox_LostFocus(sender As Object, e As EventArgs) Handles BankAddressTextBox.LostFocus
        BankAddressTextBox.BackColor = Color.White
    End Sub

    Private Sub PaymentOthersTextBox_TextChanged(sender As Object, e As EventArgs) Handles PaymentOthersTextBox.TextChanged

    End Sub

    Private Sub PaymentOthersTextBox_GotFocus(sender As Object, e As EventArgs) Handles PaymentOthersTextBox.GotFocus
        PaymentOthersTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub PaymentOthersTextBox_LostFocus(sender As Object, e As EventArgs) Handles PaymentOthersTextBox.LostFocus
        PaymentOthersTextBox.BackColor = Color.White
    End Sub

    Private Sub CheckNoTextBox_TextChanged(sender As Object, e As EventArgs) Handles CheckNoTextBox.TextChanged

    End Sub

    Private Sub CheckNoTextBox_GotFocus(sender As Object, e As EventArgs) Handles CheckNoTextBox.GotFocus
        CheckNoTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub CheckNoTextBox_LostFocus(sender As Object, e As EventArgs) Handles CheckNoTextBox.LostFocus
        CheckNoTextBox.BackColor = Color.White
    End Sub

    Private Sub DTDocuCorp_GotFocus(sender As Object, e As EventArgs) Handles DTDocuCorp.GotFocus
        DocumentDateCorp.BackColor = Color.LightYellow
    End Sub

    Private Sub DTDocuCorp_LostFocus(sender As Object, e As EventArgs) Handles DTDocuCorp.LostFocus
        DocumentDateCorp.BackColor = Color.White
    End Sub

    Private Sub DTMeetingDate_GotFocus(sender As Object, e As EventArgs) Handles DTMeetingDate.GotFocus
        MeetingDateTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub DTMeetingDate_LostFocus(sender As Object, e As EventArgs) Handles DTMeetingDate.LostFocus
        MeetingDateTextBox.BackColor = Color.White
    End Sub

    Private Sub MeetingDateTextBox_TextChanged(sender As Object, e As EventArgs) Handles MeetingDateTextBox.TextChanged

    End Sub

    Private Sub MeetingDateTextBox_GotFocus(sender As Object, e As EventArgs) Handles MeetingDateTextBox.GotFocus
        MeetingDateTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub CompanyTextBox_TextChanged(sender As Object, e As EventArgs) Handles CompanyTextBox.TextChanged

    End Sub

    Private Sub CompanyTextBox_GotFocus(sender As Object, e As EventArgs) Handles CompanyTextBox.GotFocus
        CompanyTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub CompanyTextBox_LostFocus(sender As Object, e As EventArgs) Handles CompanyTextBox.LostFocus
        CompanyTextBox.BackColor = Color.White
    End Sub

    Private Sub SecretaryTextBox_TextChanged(sender As Object, e As EventArgs) Handles SecretaryTextBox.TextChanged

    End Sub

    Private Sub SecretaryTextBox_GotFocus(sender As Object, e As EventArgs) Handles SecretaryTextBox.GotFocus
        SecretaryTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub SecretaryTextBox_LostFocus(sender As Object, e As EventArgs) Handles SecretaryTextBox.LostFocus
        SecretaryTextBox.BackColor = Color.White
    End Sub

    Private Sub PromoTitleTextBox_TextChanged(sender As Object, e As EventArgs) Handles PromoTitleTextBox.TextChanged

    End Sub

    Private Sub PromoTitleTextBox_GotFocus(sender As Object, e As EventArgs) Handles PromoTitleTextBox.GotFocus
        PromoTitleTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub PromoTitleTextBox_LostFocus(sender As Object, e As EventArgs) Handles PromoTitleTextBox.LostFocus
        PromoTitleTextBox.BackColor = Color.White
    End Sub

    Private Sub PromoFromTextBox_HandleCreated(sender As Object, e As EventArgs) Handles PromoFromTextBox.HandleCreated

    End Sub

    Private Sub PromoFromTextBox_GotFocus(sender As Object, e As EventArgs) Handles PromoFromTextBox.GotFocus
        PromoFromTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub DTPromoFrom_GotFocus(sender As Object, e As EventArgs) Handles DTPromoFrom.GotFocus
        PromoFromTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub DTPromoFrom_LostFocus(sender As Object, e As EventArgs) Handles DTPromoFrom.LostFocus
        PromoFromTextBox.BackColor = Color.White
    End Sub

    Private Sub PromoToTextBox_TextChanged(sender As Object, e As EventArgs) Handles PromoToTextBox.TextChanged

    End Sub

    Private Sub PromoToTextBox_GotFocus(sender As Object, e As EventArgs) Handles PromoToTextBox.GotFocus
        PromoToTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub DTPromoTo_GotFocus(sender As Object, e As EventArgs) Handles DTPromoTo.GotFocus
        PromoToTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub DTPromoTo_LostFocus(sender As Object, e As EventArgs) Handles DTPromoTo.LostFocus
        PromoToTextBox.BackColor = Color.White
    End Sub

    Private Sub DTIPermitNoTextBox_TextChanged(sender As Object, e As EventArgs) Handles DTIPermitNoTextBox.TextChanged

    End Sub

    Private Sub DTIPermitNoTextBox_GotFocus(sender As Object, e As EventArgs) Handles DTIPermitNoTextBox.GotFocus
        DTIPermitNoTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub DTIPermitNoTextBox_LostFocus(sender As Object, e As EventArgs) Handles DTIPermitNoTextBox.LostFocus
        DTIPermitNoTextBox.BackColor = Color.White
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        TextBox1.BackColor = Color.LightYellow
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        TextBox1.BackColor = Color.White
    End Sub

    Private Sub DateTimePicker1_GotFocus(sender As Object, e As EventArgs) Handles DateTimePicker1.GotFocus
        ImpMonthImport.BackColor = Color.LightYellow
    End Sub

    Private Sub DateTimePicker1_LostFocus(sender As Object, e As EventArgs) Handles DateTimePicker1.LostFocus
        ImpMonthImport.BackColor = Color.White
    End Sub

    Private Sub LetterCreditImport_TextChanged(sender As Object, e As EventArgs) Handles LetterCreditImport.TextChanged

    End Sub

    Private Sub LetterCreditImport_GotFocus(sender As Object, e As EventArgs) Handles LetterCreditImport.GotFocus
        LetterCreditImport.BackColor = Color.LightYellow
    End Sub

    Private Sub LetterCreditImport_LostFocus(sender As Object, e As EventArgs) Handles LetterCreditImport.LostFocus
        LetterCreditImport.BackColor = Color.White
    End Sub

    Private Sub DPNoImport_TextChanged(sender As Object, e As EventArgs) Handles DPNoImport.TextChanged

    End Sub

    Private Sub DPNoImport_GotFocus(sender As Object, e As EventArgs) Handles DPNoImport.GotFocus
        DPNoImport.BackColor = Color.LightYellow
    End Sub

    Private Sub DPNoImport_LostFocus(sender As Object, e As EventArgs) Handles DPNoImport.LostFocus
        DPNoImport.BackColor = Color.White
    End Sub

    Private Sub PaymentOthersImport_TextChanged(sender As Object, e As EventArgs) Handles PaymentOthersImport.TextChanged

    End Sub

    Private Sub PaymentOthersImport_GotFocus(sender As Object, e As EventArgs) Handles PaymentOthersImport.GotFocus
        PaymentOthersImport.BackColor = Color.LightYellow
    End Sub

    Private Sub PaymentOthersImport_LostFocus(sender As Object, e As EventArgs) Handles PaymentOthersImport.LostFocus
        PaymentOthersImport.BackColor = Color.White
    End Sub

    Private Sub DTVesselImport_GotFocus(sender As Object, e As EventArgs) Handles DTVesselImport.GotFocus
        VesselArrivedImport.BackColor = Color.LightYellow
    End Sub

    Private Sub DTVesselImport_LostFocus(sender As Object, e As EventArgs) Handles DTVesselImport.LostFocus
        VesselArrivedImport.BackColor = Color.White
    End Sub

    Private Sub DTDocuBIR_GotFocus(sender As Object, e As EventArgs) Handles DTDocuBIR.GotFocus
        DocumentDateBIR.BackColor = Color.LightYellow
    End Sub

    Private Sub DTDocuBIR_LostFocus(sender As Object, e As EventArgs) Handles DTDocuBIR.LostFocus
        DocumentDateBIR.BackColor = Color.White
    End Sub

    Private Sub DTDocuHRDoc_GotFocus(sender As Object, e As EventArgs) Handles DTDocuHRDoc.GotFocus
        DocumentDateHRDoc.BackColor = Color.LightYellow
    End Sub

    Private Sub DTDocuHRDoc_LostFocus(sender As Object, e As EventArgs) Handles DTDocuHRDoc.LostFocus
        DocumentDateHRDoc.BackColor = Color.White
    End Sub

    Private Sub DTCreateDate_GotFocus(sender As Object, e As EventArgs) Handles DTCreateDate.GotFocus
        CreationDateCopy.BackColor = Color.LightYellow
    End Sub

    Private Sub DTCreateDate_LostFocus(sender As Object, e As EventArgs) Handles DTCreateDate.LostFocus
        CreationDateCopy.BackColor = Color.White
    End Sub

    Private Sub DTRegDateTrade_GotFocus(sender As Object, e As EventArgs) Handles DTRegDateTrade.GotFocus
        RegDateTrade.BackColor = Color.LightYellow
    End Sub

    Private Sub DTRegDateTrade_LostFocus(sender As Object, e As EventArgs) Handles DTRegDateTrade.LostFocus
        RegDateTrade.BackColor = Color.White
    End Sub

    Private Sub DTFromTrade_GotFocus(sender As Object, e As EventArgs) Handles DTFromTrade.GotFocus
        FromPeriodTrade.BackColor = Color.LightYellow
    End Sub

    Private Sub DTFromTrade_LostFocus(sender As Object, e As EventArgs) Handles DTFromTrade.LostFocus
        FromPeriodTrade.BackColor = Color.White
    End Sub

    Private Sub DTToTrade_GotFocus(sender As Object, e As EventArgs) Handles DTToTrade.GotFocus
        ToPeriodTrade.BackColor = Color.LightYellow
    End Sub

    Private Sub DTToTrade_LostFocus(sender As Object, e As EventArgs) Handles DTToTrade.LostFocus
        ToPeriodTrade.BackColor = Color.White
    End Sub

    Private Sub DTFilingTrade_GotFocus(sender As Object, e As EventArgs) Handles DTFilingTrade.GotFocus
        FilingDateTrade.BackColor = Color.LightYellow
    End Sub

    Private Sub DTFilingTrade_LostFocus(sender As Object, e As EventArgs) Handles DTFilingTrade.LostFocus
        FilingDateTrade.BackColor = Color.White
    End Sub

    Private Sub DTIssueDateClear_GotFocus(sender As Object, e As EventArgs) Handles DTIssueDateClear.GotFocus
        IssueDateClear.BackColor = Color.LightYellow
    End Sub

    Private Sub DTIssueDateClear_LostFocus(sender As Object, e As EventArgs) Handles DTIssueDateClear.LostFocus
        IssueDateClear.BackColor = Color.White
    End Sub

    Private Sub DTFromClear_GotFocus(sender As Object, e As EventArgs) Handles DTFromClear.GotFocus
        FromPeriodClear.BackColor = Color.LightYellow
    End Sub

    Private Sub DTFromClear_LostFocus(sender As Object, e As EventArgs) Handles DTFromClear.LostFocus
        FromPeriodClear.BackColor = Color.White
    End Sub

    Private Sub DTToClear_GotFocus(sender As Object, e As EventArgs) Handles DTToClear.GotFocus
        ToPeriodClear.BackColor = Color.LightYellow
    End Sub

    Private Sub DTToClear_LostFocus(sender As Object, e As EventArgs) Handles DTToClear.LostFocus
        ToPeriodClear.BackColor = Color.White
    End Sub

    Private Sub DTIssueDateAccre_GotFocus(sender As Object, e As EventArgs) Handles DTIssueDateAccre.GotFocus
        IssueDateAccre.BackColor = Color.LightYellow
    End Sub

    Private Sub DTIssueDateAccre_LostFocus(sender As Object, e As EventArgs) Handles DTIssueDateAccre.LostFocus
        IssueDateAccre.BackColor = Color.White
    End Sub

    Private Sub DTFromAccre_GotFocus(sender As Object, e As EventArgs) Handles DTFromAccre.GotFocus
        FromPeriodAccre.BackColor = Color.LightYellow
    End Sub

    Private Sub DTFromAccre_LostFocus(sender As Object, e As EventArgs) Handles DTFromAccre.LostFocus
        FromPeriodAccre.BackColor = Color.White
    End Sub

    Private Sub DTToAccre_GotFocus(sender As Object, e As EventArgs) Handles DTToAccre.GotFocus
        ToPeriodAccre.BackColor = Color.LightYellow
    End Sub

    Private Sub DTToAccre_LostFocus(sender As Object, e As EventArgs) Handles DTToAccre.LostFocus
        ToPeriodAccre.BackColor = Color.White
    End Sub

    Private Sub DTSubsDateSubs_GotFocus(sender As Object, e As EventArgs) Handles DTSubsDateSubs.GotFocus
        SubsDateSubs.BackColor = Color.LightYellow
    End Sub

    Private Sub DTSubsDateSubs_LostFocus(sender As Object, e As EventArgs) Handles DTSubsDateSubs.LostFocus
        SubsDateSubs.BackColor = Color.White
    End Sub

    Private Sub DTFromSubs_GotFocus(sender As Object, e As EventArgs) Handles DTFromSubs.GotFocus
        FromPeriodSubs.BackColor = Color.LightYellow
    End Sub

    Private Sub DTFromSubs_LostFocus(sender As Object, e As EventArgs) Handles DTFromSubs.LostFocus
        FromPeriodSubs.BackColor = Color.White
    End Sub

    Private Sub DTToSubs_GotFocus(sender As Object, e As EventArgs) Handles DTToSubs.GotFocus
        ToPeriodSubs.BackColor = Color.LightYellow
    End Sub

    Private Sub DTToSubs_LostFocus(sender As Object, e As EventArgs) Handles DTToSubs.LostFocus
        ToPeriodSubs.BackColor = Color.White
    End Sub

    Private Sub DTFromContract_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs) Handles DTFromContract.GiveFeedback

    End Sub

    Private Sub DTFromContract_GotFocus(sender As Object, e As EventArgs) Handles DTFromContract.GotFocus
        FromPeriodContract.BackColor = Color.LightYellow
    End Sub

    Private Sub DTFromContract_LostFocus(sender As Object, e As EventArgs) Handles DTFromContract.LostFocus
        FromPeriodContract.BackColor = Color.White
    End Sub

    Private Sub DTToContract_GotFocus(sender As Object, e As EventArgs) Handles DTToContract.GotFocus
        ToPeriodContract.BackColor = Color.LightYellow
    End Sub

    Private Sub DTToContract_LostFocus(sender As Object, e As EventArgs) Handles DTToContract.LostFocus
        ToPeriodContract.BackColor = Color.White
    End Sub

    Private Sub DTDateSignContract_GotFocus(sender As Object, e As EventArgs) Handles DTDateSignContract.GotFocus
        SignDateContract.BackColor = Color.LightYellow
    End Sub

    Private Sub DTDateSignContract_LostFocus(sender As Object, e As EventArgs) Handles DTDateSignContract.LostFocus
        SignDateContract.BackColor = Color.White
    End Sub

    Private Sub DTIssueDateAttorney_GotFocus(sender As Object, e As EventArgs) Handles DTIssueDateAttorney.GotFocus
        IssueDateAttorney.BackColor = Color.LightYellow
    End Sub

    Private Sub DTIssueDateAttorney_LostFocus(sender As Object, e As EventArgs) Handles DTIssueDateAttorney.LostFocus
        IssueDateAttorney.BackColor = Color.White
    End Sub

    Private Sub DTIssuePlaceAttorney_GotFocus(sender As Object, e As EventArgs) Handles DTIssuePlaceAttorney.GotFocus
        IssuePlaceAttorney.BackColor = Color.LightYellow
    End Sub

    Private Sub DTIssuePlaceAttorney_LostFocus(sender As Object, e As EventArgs) Handles DTIssuePlaceAttorney.LostFocus
        IssuePlaceAttorney.BackColor = Color.White
    End Sub

    Private Sub DTFromAttorney_GotFocus(sender As Object, e As EventArgs) Handles DTFromAttorney.GotFocus
        FromPeriodAttorney.BackColor = Color.LightYellow
    End Sub

    Private Sub DTFromAttorney_LostFocus(sender As Object, e As EventArgs) Handles DTFromAttorney.LostFocus
        FromPeriodAttorney.BackColor = Color.White
    End Sub

    Private Sub DTToAttorney_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs) Handles DTToAttorney.GiveFeedback

    End Sub

    Private Sub DTToAttorney_GotFocus(sender As Object, e As EventArgs) Handles DTToAttorney.GotFocus
        ToPeriodAttorney.BackColor = Color.LightYellow
    End Sub

    Private Sub DTToAttorney_LostFocus(sender As Object, e As EventArgs) Handles DTToAttorney.LostFocus
        ToPeriodAttorney.BackColor = Color.White
    End Sub

    Private Sub DTIssueDateOther_GotFocus(sender As Object, e As EventArgs) Handles DTIssueDateOther.GotFocus
        IssueDateOther.BackColor = Color.LightYellow
    End Sub

    Private Sub DTIssueDateOther_LostFocus(sender As Object, e As EventArgs) Handles DTIssueDateOther.LostFocus
        IssueDateOther.BackColor = Color.White
    End Sub

    Private Sub DTIssuePlaceOther_GotFocus(sender As Object, e As EventArgs) Handles DTIssuePlaceOther.GotFocus
        IssuePlaceOther.BackColor = Color.LightYellow
    End Sub

    Private Sub DTIssuePlaceOther_LostFocus(sender As Object, e As EventArgs) Handles DTIssuePlaceOther.LostFocus
        IssuePlaceOther.BackColor = Color.LightYellow
    End Sub

    Private Sub DTIssueDateMemo_GotFocus(sender As Object, e As EventArgs) Handles DTIssueDateMemo.GotFocus
        IssueDateMemo.BackColor = Color.LightYellow
    End Sub

    Private Sub DTIssueDateMemo_LostFocus(sender As Object, e As EventArgs) Handles DTIssueDateMemo.LostFocus
        IssueDateMemo.BackColor = Color.White
    End Sub

    Private Sub PaymentFormImport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PaymentFormImport.SelectedIndexChanged

    End Sub

    Private Sub PaymentFormImport_ValueMemberChanged(sender As Object, e As EventArgs) Handles PaymentFormImport.ValueMemberChanged

    End Sub

    Private Sub PaymentFormImport_SystemColorsChanged(sender As Object, e As EventArgs) Handles PaymentFormImport.SystemColorsChanged
        ComboSelect4()
    End Sub
End Class