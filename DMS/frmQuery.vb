
Imports C1.Win.C1TrueDBGrid

Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports System.ComponentModel

Public Class FrmQuery
    Private Sub FrmQuery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DMSDataSet.DocsCatalogueChanges' table. You can move, or remove it, as needed.



        PopulateCombobox()



        'Format
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

        TabControl3.Appearance = TabAppearance.FlatButtons
        TabControl3.ItemSize = New Size(0, 1)
        TabControl3.SizeMode = TabSizeMode.Fixed
        For Each TabPage In TabControl2.TabPages

            TabPage.Text = ""

        Next


        TabControl4.Appearance = TabAppearance.FlatButtons
        TabControl4.ItemSize = New Size(0, 1)
        TabControl4.SizeMode = TabSizeMode.Fixed
        For Each TabPage In TabControl4.TabPages

            TabPage.Text = ""

        Next


        Me.PaymentFormComboBox.Items.Add("Bank Deposit")
        Me.PaymentFormComboBox.Items.Add("Cash")
        Me.PaymentFormComboBox.Items.Add("Check")
        Me.PaymentFormComboBox.Items.Add("Others")


        Me.BtnSaveChanges1.Enabled = False




        Try
            Me.C1TrueDBGrid1.LoadLayout("default.layout")
        Catch ex As Exception
            Me.C1TrueDBGrid1.SaveLayout("default.layout")
        End Try




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

        If Me.C1TrueDBGrid1.Columns("Document Type").Text = "Sales Invoice" Then
            TabControl2.SelectTab(ReceiptInvoice)
        ElseIf Me.C1TrueDBGrid1.Columns("Document Type").Text = "Official Receipt" Then
            TabControl2.SelectTab(ReceiptInvoice)
        ElseIf Me.C1TrueDBGrid1.Columns("Document Type").Text = "Delivery Receipt" Then
            TabControl2.SelectTab(ReceiptInvoice)
        ElseIf Me.C1TrueDBGrid1.Columns("Document Type").Text = "Acknowledgement Receipt" Then
            TabControl2.SelectTab(ReceiptInvoice)
        ElseIf Me.C1TrueDBGrid1.Columns("Document Type").Text = "Collection Receipt" Then
            TabControl2.SelectTab(ReceiptInvoice)
        ElseIf Me.C1TrueDBGrid1.Columns("Document Type").Text = "Provisional Receipt" Then
            TabControl2.SelectTab(ReceiptInvoice)

        ElseIf Me.C1TrueDBGrid1.Columns("Document Type").Text = "Daily Time Record" Then
            TabControl2.SelectTab(Timesheet)


        ElseIf Me.C1TrueDBGrid1.Columns("Document Type").Text = "Warranty Card" Then
            TabControl2.SelectTab(Warranty)


        ElseIf Me.C1TrueDBGrid1.Columns("Document Type").Text = "Payment Voucher" Then
            TabControl2.SelectTab(Voucher)



        ElseIf Me.C1TrueDBGrid1.Columns("Document Type").Text = "Secretary's Certificate" Then
            TabControl2.SelectTab(CorpDocu)
            TabControl4.SelectTab(TabMeeting)
        ElseIf Me.C1TrueDBGrid1.Columns("Document Type").Text = "Minutes of Board Meeting" Then
            TabControl2.SelectTab(CorpDocu)
            TabControl4.SelectTab(TabMeeting)
        ElseIf Me.C1TrueDBGrid1.Columns("Document Type").Text = "Articles of Incorporation" Then
            TabControl2.SelectTab(CorpDocu)
            TabControl4.SelectTab(TabMeeting2)
        ElseIf Me.C1TrueDBGrid1.Columns("Document Type").Text = "SEC Certificate of Registration" Then
            TabControl2.SelectTab(CorpDocu)
            TabControl4.SelectTab(TabMeeting2)
        ElseIf Me.C1TrueDBGrid1.Columns("Document Type").Text = "DTI Permit" Then
            TabControl2.SelectTab(CorpDocu)
            TabControl4.SelectTab(TabPromo)
        ElseIf Me.C1TrueDBGrid1.Columns("Document Type").Text = "Financial Statement" Then
            TabControl2.SelectTab(CorpDocu)
            TabControl4.SelectTab(TabMeeting2)
        ElseIf Me.C1TrueDBGrid1.Columns("Document Type").Text = "General Information Sheet" Then
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
    Private Sub C1TrueDBGrid1_DoubleClick(sender As Object, e As EventArgs) Handles C1TrueDBGrid1.DoubleClick
        Try

            AcroPDF.src = (My.Settings.ImgPath & "\" & Me.C1TrueDBGrid1.Columns("File Name").Text)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Search()
        Try


            'Create a variable to hold your parameter value
            Dim id As Integer = 0
            'Create your query as you already have done
            Dim strsql As String = "SELECT 
                [Id]
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
            C1TrueDBGrid1.DataSource = objbindingsource

            Me.C1TrueDBGrid1.Splits(0).DisplayColumns("Id").Visible = False
            Me.C1TrueDBGrid1.Splits(0).ExtendRightColumn = True



        Catch ex As Exception
            MessageBox.Show("Searching Failed! " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnSearch.Click

        Search()

    End Sub

    Private Sub C1TrueDBGrid1_Click(sender As Object, e As EventArgs) Handles C1TrueDBGrid1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnEditRecord.Click
        Try
            ComboSelect()

            Me.DocsCatalogueTableAdapter.Fill(Me.DMSDataSet.DocsCatalogue, "Finished")
            Me.DocsCatalogueBindingSource.Filter = "[Id] = '" & Me.C1TrueDBGrid1.Columns("Id").Text & "' "
            AcroPDF.src = (My.Settings.ImgPath & "\" & Me.C1TrueDBGrid1.Columns("File Name").Text)

            TabControl1.SelectTab(TabChanges)
            Me.C1TrueDBGrid1.Enabled = False
            Me.BtnEditRecord.Enabled = False
            Me.BtnSearch.Enabled = False
            Me.BtnSaveChanges1.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    Public Sub SaveChanges()
        Me.Validate()
        Me.DocsCatalogueBindingSource.EndEdit()
        Me.DocsCatalogueTableAdapter.Update(Me.DMSDataSet.DocsCatalogue)

        Me.BtnEditRecord.Enabled = True
        Me.C1TrueDBGrid1.Enabled = True
        Me.BtnSearch.Enabled = True
        Me.BtnSaveChanges1.Enabled = False
        MessageBox.Show("Successfully Saved!!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.TabControl1.SelectTab(TabQuery)
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
        Me.C1TrueDBGrid1.SaveLayout("default.layout")
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
        Dim DateFormat As Date

        If Date.TryParseExact(MeetingDateTextBox.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.MeetingDateTextBox.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.MeetingDateTextBox.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.MeetingDateTextBox.Clear()
        End If
    End Sub



    Private Sub PromoFromTextBox_LostFocus(sender As Object, e As EventArgs) Handles PromoFromTextBox.LostFocus
        Dim DateFormat As Date

        If Date.TryParseExact(PromoFromTextBox.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.PromoFromTextBox.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.PromoFromTextBox.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.PromoFromTextBox.Clear()
        End If
    End Sub



    Private Sub PromoToTextBox_LostFocus(sender As Object, e As EventArgs) Handles PromoToTextBox.LostFocus
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
        Dim DateFormat As Date

        If Date.TryParseExact(FromPeriodTextBox.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.FromPeriodTextBox.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.FromPeriodTextBox.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.FromPeriodTextBox.Clear()
        End If
    End Sub



    Private Sub ToPeriodTextBox_LostFocus(sender As Object, e As EventArgs) Handles ToPeriodTextBox.LostFocus
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
End Class