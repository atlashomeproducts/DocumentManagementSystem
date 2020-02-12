Imports C1.Win.C1TrueDBGrid

Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports System.ComponentModel
Imports System.Globalization


Public Class FrmEditor


    Private Sub PopulateComboItems()
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
    Private Sub DocMan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DMSDataSet.DocsRemoval' table. You can move, or remove it, as needed.
        ' Me.DocsRemovalTableAdapter.Fill(Me.DMSDataSet.DocsRemoval)
        'TODO: This line of code loads data into the 'DMSDataSet.DocumentGroups' table. You can move, or remove it, as needed.

        'Populate Data
        PopulateComboItems()
        Me.DocsCatalogueTableAdapter.Fill(Me.DMSDataSet.DocsCatalogue, "Indexed", IIf(FrmMain.type = "System Admin" Or FrmMain.type = "Admin", "", "Unchecked"))




        'Format
        TabControl1.Appearance = TabAppearance.Normal
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.SizeMode = TabSizeMode.Fixed
        For Each TabPage In TabControl1.TabPages

            TabPage.Text = ""

        Next



        TabControl2.Appearance = TabAppearance.Normal
        TabControl2.ItemSize = New Size(0, 1)
        TabControl2.SizeMode = TabSizeMode.Fixed
        For Each TabPage In TabControl2.TabPages

            TabPage.Text = ""

        Next


        TabControl3.Appearance = TabAppearance.Normal
        TabControl3.ItemSize = New Size(0, 1)
        TabControl3.SizeMode = TabSizeMode.Fixed
        For Each TabPage In TabControl3.TabPages

            TabPage.Text = ""

        Next


        TabControl4.Appearance = TabAppearance.Normal
        TabControl4.ItemSize = New Size(0, 1)
        TabControl4.SizeMode = TabSizeMode.Fixed
        For Each TabPage In TabControl4.TabPages

            TabPage.Text = ""

        Next




        'Permanently Disabled
        Me.IdTextBox.ReadOnly = True
        ' Me.IdTextBox.Visible = False


        'Temp Disabled
        Me.DocumentTypeComboBox.Enabled = False
        Me.BatchTextBox.ReadOnly = True
        Me.SubBatchTextBox.ReadOnly = True
        Me.cbDocSize.Enabled = False
        Me.txtPages.ReadOnly = True
        Me.chkConfidential.Enabled = False



        GrpTimeSheet.Enabled = False
        GrpReceipt.Enabled = False
        GrpCorp.Enabled = False
        GrpVoucher.Enabled = False
        GrpWarranty.Enabled = False

        'Changing

        Me.LblStat.Text = ""
        Me.BtnSave.Enabled = False
        Me.BtnClear.Enabled = False
        Me.BtnCancel1.Enabled = False


        If FrmMain.type = "System Admin" Then
            Me.BtnRemove.Visible = True
        Else
            Me.BtnRemove.Visible = False
        End If



    End Sub


    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click


        If Me.DocumentTypeComboBox.Text = "" Then

            MessageBox.Show("Please don't leave Document Type blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else


            Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
            Dim cmd As New SqlCommand
            Dim cmdlogs As New SqlCommand(" INSERT INTO DMSLogs(Username, Action, ActionDate) VALUES (@Username, @Action, @ActionDate)", con)


            Try

                My.Settings.Save_RackNoTS = RackNoTS.Text
                My.Settings.Save_BoxNoTS = BoxNoTS.Text
                My.Settings.Save_RackNoRI = RackNoRI.Text
                My.Settings.Save_BoxNoRI = BoxNoRI.Text
                My.Settings.Save_BookletNoRI = BookletNoTextBox.Text
                My.Settings.Save_RackNoWarranty = RackNoWarranty.Text
                My.Settings.Save_BoxNoWarranty = BoxNoWarranty.Text
                My.Settings.Save_RackNoVoucher = RackNoVoucher.Text
                My.Settings.Save_BoxNoVoucher = BoxNoVoucher.Text
                My.Settings.Save_RackNoCorpDocu = RackNoCorpDocu.Text
                My.Settings.Save_BoxNoCorpDocu = BoxNoCorpDocu.Text
                My.Settings.Save()



                Me.DocsCatalogueBindingSource.Current!UserID = FrmMain.User

                Me.Validate()
                Me.DocsCatalogueBindingSource.EndEdit()
                Me.DocsCatalogueTableAdapter.Update(Me.DMSDataSet.DocsCatalogue)


                con.Open()
                cmd.Connection = con
                cmd.CommandText = "UPDATE DocsCatalogue SET Status = 'Finished' WHERE Id = '" & Me.IdTextBox.Text & "' "
                cmd.ExecuteNonQuery()
                con.Close()



                con.Open()
                cmdlogs.Connection = con
                cmdlogs.Parameters.AddWithValue("@Username", FrmMain.User)
                cmdlogs.Parameters.AddWithValue("@Action", FrmMain.User & " " & "Saved changes on record with Id:" & Me.IdTextBox.Text)
                cmdlogs.Parameters.AddWithValue("@ActionDate", DateTime.Now)
                cmdlogs.ExecuteNonQuery()
                con.Close()



                Me.DocsCatalogueTableAdapter.Fill(Me.DMSDataSet.DocsCatalogue, "Indexed", IIf(FrmMain.type = "System Admin" Or FrmMain.type = "Admin", "", "Unchecked"))
                Me.DocsCatalogueC1TrueDBGrid.Enabled = True



                'Temp Disabled
                Me.DocumentTypeComboBox.Enabled = False
                Me.BatchTextBox.ReadOnly = True
                Me.SubBatchTextBox.ReadOnly = True
                Me.cbDocSize.Enabled = False
                Me.txtPages.ReadOnly = True
                Me.chkConfidential.Enabled = False

                GrpTimeSheet.Enabled = False
                GrpReceipt.Enabled = False
                GrpCorp.Enabled = False
                GrpVoucher.Enabled = False
                GrpWarranty.Enabled = False


                FrmMain.SpDMSTotalsTableAdapter.Fill(FrmMain.DMSDataSet.spDMSTotals)
                LblStat.Text = "Successfully Saved!"
                Me.BtnSave.Enabled = False
                Me.BtnClear.Enabled = False
                Me.BtnEdit.Enabled = True
                Me.BtnCancel1.Enabled = False

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        Dim MsgDelete = MessageBox.Show("Are you sure you want to clear all the values for this record?", "Clear?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)


        If MsgDelete = vbYes Then


            DocumentTypeComboBox.Text = ""
            DocumentDateRI.Clear()
            ReferenceNoRI.Clear()
            BookletNoTextBox.Clear()
            ReferenceNoRI.Clear()
            VendorTextBox.Clear()
            CustomerTextBox.Clear()
            ItemPurchasedTextBox.Clear()
            TotalValueRI.Clear()
            RackNoRI.Clear()
            BoxNoRI.Clear()
            VATregCheckBox.Checked = False
            NONVATregCheckBox.Checked = False
            AddressCTextBox.Clear()
            TinCustomerTextBox.Clear()
            TinVendorTextBox.Clear()
            Me.VATregCheckBox.Checked = False
            Me.NONVATregCheckBox.Checked = False



            DocumentDateTS.Clear()
            LastNameTextBox.Clear()
            FirstNameTextBox.Clear()
            MiddleNameTextBox.Clear()
            FromPeriodTextBox.Clear()
            ToPeriodTextBox.Clear()
            RackNoTS.Clear()
            BoxNoTS.Clear()


            ProductBrandTextBox.Clear()
            ProductTypeTextBox.Clear()
            SerialTextBox.Clear()
            ReferenceNoTextBox1.Clear()
            WarrantyNoTextBox.Clear()
            WarrantyPeriodTextBox.Clear()
            ServiceCenterTextBox.Clear()
            AddressTextBox.Clear()
            DatePurchasedTextBox.Clear()
            ContactNoTextBox.Clear()
            EmailTextBox.Clear()
            TotalValueWarranty.Clear()
            RackNoWarranty.Clear()
            BoxNoWarranty.Clear()


            DocumentDateVoucher.Clear()
            PayeeTextBox.Clear()
            PayorTextBox.Clear()
            VoucherNoTextBox.Clear()
            CheckNoTextBox.Clear()
            PaymentFormComboBox.SelectedIndex = -1
            TotalValueVoucher.Clear()
            PreparedbyTextBox.Clear()
            ApprovedbyTextBox.Clear()
            RecordedbyTextBox.Clear()
            ReceivedbyTextBox.Clear()
            BankAddressTextBox.Clear()
            BankBranchTextBox.Clear()
            BankNameTextBox.Clear()
            PaymentOthersTextBox.Clear()
            RackNoVoucher.Clear()
            BoxNoVoucher.Clear()
            DateReceivedTextBox.Clear()


            DocumentDateCorp.Clear()
            MeetingDateTextBox.Clear()
            CompanyTextBox.Clear()
            SecretaryTextBox.Clear()
            PurposeTextBox.Clear()
            RackNoCorpDocu.Clear()
            BoxNoCorpDocu.Clear()
            PromoFromTextBox.Clear()
            PromoToTextBox.Clear()
            DTIPermitNoTextBox.Clear()
            PromoTitleTextBox.Clear()




            Try


                Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
                Dim cmdlogs As New SqlCommand(" INSERT INTO DMSLogs(Username, Action, ActionDate) VALUES (@Username, @Action, @ActionDate)", con)

                con.Open()
                cmdlogs.Connection = con
                cmdlogs.Parameters.AddWithValue("@Username", FrmMain.User)
                cmdlogs.Parameters.AddWithValue("@Action", FrmMain.User & " " & "Cleared keys")
                cmdlogs.Parameters.AddWithValue("@ActionDate", DateTime.Now)
                cmdlogs.ExecuteNonQuery()
                con.Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try



        End If


    End Sub
    Private Sub UpdateStatusLocked()

        Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
        Dim cmd As New SqlCommand

        Try

            con.Open()
            cmd.Connection = con
            cmd.CommandText = " Update DocsCatalogue set Status = 'Locked' where Id = @id"
            cmd.Parameters.AddWithValue("@Id", Me.DocsCatalogueC1TrueDBGrid.Columns("Id").Text)

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub




    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click


        If Me.IdTextBox.Text = "" Then
            MessageBox.Show("No Records Found!!")


        Else

            'UpdateStatusLocked()

            Me.DocumentTypeComboBox.Enabled = True
            Me.BatchTextBox.ReadOnly = False
            Me.SubBatchTextBox.ReadOnly = False
            Me.cbDocSize.Enabled = True
            Me.txtPages.ReadOnly = False
            Me.chkConfidential.Enabled = True

            GrpTimeSheet.Enabled = True
            GrpReceipt.Enabled = True
            GrpCorp.Enabled = True
            GrpVoucher.Enabled = True
            GrpWarranty.Enabled = True

            Me.DocsCatalogueC1TrueDBGrid.Enabled = False

            Me.PurposeTextBox.ReadOnly = False
            Me.BtnSave.Enabled = True
            Me.BtnClear.Enabled = True
            Me.BtnEdit.Enabled = False
            Me.BtnCancel1.Enabled = True



            Try


                Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
                Dim cmdlogs As New SqlCommand(" INSERT INTO DMSLogs(Username, Action, ActionDate) VALUES (@Username, @Action, @ActionDate)", con)



                con.Open()
                cmdlogs.Connection = con
                cmdlogs.Parameters.AddWithValue("@Username", FrmMain.User)
                cmdlogs.Parameters.AddWithValue("@Action", FrmMain.User & " " & "Edited a record with ID:" & Me.IdTextBox.Text)
                cmdlogs.Parameters.AddWithValue("@ActionDate", DateTime.Now)
                cmdlogs.ExecuteNonQuery()
                con.Close()





            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try


        End If
    End Sub



    Private Sub DateTimePicker1_ValueChanged_1(sender As Object, e As EventArgs) Handles DTDocuRI.ValueChanged

        Me.DocumentDateRI.Text = Me.DTDocuRI.Value.ToString("MM/dd/yyyy")

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Me.DocsCatalogueTableAdapter.Fill(Me.DMSDataSet.DocsCatalogue, "Indexed", IIf(FrmMain.type = "System Admin" Or FrmMain.type = "Admin", "", "Unchecked"))





            Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
            Dim cmdlogs As New SqlCommand(" INSERT INTO DMSLogs(Username, Action, ActionDate) VALUES (@Username, @Action, @ActionDate)", con)



            con.Open()
            cmdlogs.Connection = con
            cmdlogs.Parameters.AddWithValue("@Username", FrmMain.User)
            cmdlogs.Parameters.AddWithValue("@Action", FrmMain.User & " " & "Refreshed record list")
            cmdlogs.Parameters.AddWithValue("@ActionDate", DateTime.Now)
            cmdlogs.ExecuteNonQuery()
            con.Close()





        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub ComboSelect()

        If Me.DocumentTypeComboBox.Text = "Sales Invoice" Then
            TabControl1.SelectTab(ReceiptInvoice)

            If RackNoRI.Text = "" Then
                RackNoRI.Text = My.Settings.Save_RackNoRI
            End If
            If BoxNoRI.Text = "" Then
                BoxNoRI.Text = My.Settings.Save_BoxNoRI
            End If
            If BookletNoTextBox.Text = "" Then
                BookletNoTextBox.Text = My.Settings.Save_BookletNoRI
            End If

        ElseIf Me.DocumentTypeComboBox.Text = "Official Receipt" Then
            TabControl1.SelectTab(ReceiptInvoice)
            If RackNoRI.Text = "" Then
                RackNoRI.Text = My.Settings.Save_RackNoRI
            End If
            If BoxNoRI.Text = "" Then
                BoxNoRI.Text = My.Settings.Save_BoxNoRI
            End If
            If BookletNoTextBox.Text = "" Then
                BookletNoTextBox.Text = My.Settings.Save_BookletNoRI
            End If
        ElseIf Me.DocumentTypeComboBox.Text = "Delivery Receipt" Then
            TabControl1.SelectTab(ReceiptInvoice)
            If RackNoRI.Text = "" Then
                RackNoRI.Text = My.Settings.Save_RackNoRI
            End If
            If BoxNoRI.Text = "" Then
                BoxNoRI.Text = My.Settings.Save_BoxNoRI
            End If
            If BookletNoTextBox.Text = "" Then
                BookletNoTextBox.Text = My.Settings.Save_BookletNoRI
            End If
        ElseIf Me.DocumentTypeComboBox.Text = "Acknowledgement Receipt" Then
            TabControl1.SelectTab(ReceiptInvoice)
            If RackNoRI.Text = "" Then
                RackNoRI.Text = My.Settings.Save_RackNoRI
            End If
            If BoxNoRI.Text = "" Then
                BoxNoRI.Text = My.Settings.Save_BoxNoRI
            End If
            If BookletNoTextBox.Text = "" Then
                BookletNoTextBox.Text = My.Settings.Save_BookletNoRI
            End If
        ElseIf Me.DocumentTypeComboBox.Text = "Collection Receipt" Then
            TabControl1.SelectTab(ReceiptInvoice)
            If RackNoRI.Text = "" Then
                RackNoRI.Text = My.Settings.Save_RackNoRI
            End If
            If BoxNoRI.Text = "" Then
                BoxNoRI.Text = My.Settings.Save_BoxNoRI
            End If
            If BookletNoTextBox.Text = "" Then
                BookletNoTextBox.Text = My.Settings.Save_BookletNoRI
            End If
        ElseIf Me.DocumentTypeComboBox.Text = "Provisional Receipt" Then
            TabControl1.SelectTab(ReceiptInvoice)
            If RackNoRI.Text = "" Then
                RackNoRI.Text = My.Settings.Save_RackNoRI
            End If
            If BoxNoRI.Text = "" Then
                BoxNoRI.Text = My.Settings.Save_BoxNoRI
            End If
            If BookletNoTextBox.Text = "" Then
                BookletNoTextBox.Text = My.Settings.Save_BookletNoRI
            End If



        ElseIf Me.DocumentTypeComboBox.Text = "Daily Time Record" Then
            TabControl1.SelectTab(Timesheet)
            If RackNoTS.Text = "" Then
                RackNoTS.Text = My.Settings.Save_RackNoTS
            End If
            If BoxNoTS.Text = "" Then
                BoxNoTS.Text = My.Settings.Save_BoxNoTS
            End If


        ElseIf Me.DocumentTypeComboBox.Text = "Warranty Card" Then
            TabControl1.SelectTab(Warranty)
            If RackNoWarranty.Text = "" Then
                RackNoWarranty.Text = My.Settings.Save_RackNoWarranty
            End If
            If BoxNoWarranty.Text = "" Then
                BoxNoWarranty.Text = My.Settings.Save_BoxNoWarranty
            End If

        ElseIf Me.DocumentTypeComboBox.Text = "Payment Voucher" Then
            TabControl1.SelectTab(Voucher)
            If RackNoVoucher.Text = "" Then
                RackNoVoucher.Text = My.Settings.Save_RackNoVoucher
            End If
            If BoxNoVoucher.Text = "" Then
                BoxNoVoucher.Text = My.Settings.Save_BoxNoVoucher
            End If

        ElseIf Me.DocumentTypeComboBox.Text = "Secretary's Certificate" Then
            TabControl1.SelectTab(CorpDocu)
            TabControl3.SelectTab(TabMeeting)
            If RackNoCorpDocu.Text = "" Then
                RackNoCorpDocu.Text = My.Settings.Save_RackNoCorpDocu
            End If
            If BoxNoCorpDocu.Text = "" Then
                BoxNoCorpDocu.Text = My.Settings.Save_BoxNoCorpDocu
            End If
        ElseIf Me.DocumentTypeComboBox.Text = "Minutes of Board Meeting" Then
            TabControl1.SelectTab(CorpDocu)
            TabControl3.SelectTab(TabMeeting)
            If RackNoCorpDocu.Text = "" Then
                RackNoCorpDocu.Text = My.Settings.Save_RackNoCorpDocu
            End If
            If BoxNoCorpDocu.Text = "" Then
                BoxNoCorpDocu.Text = My.Settings.Save_BoxNoCorpDocu
            End If
        ElseIf Me.DocumentTypeComboBox.Text = "Articles of Incorporation" Then
            TabControl1.SelectTab(CorpDocu)
            TabControl3.SelectTab(TabMeeting2)
            If RackNoCorpDocu.Text = "" Then
                RackNoCorpDocu.Text = My.Settings.Save_RackNoCorpDocu
            End If
            If BoxNoCorpDocu.Text = "" Then
                BoxNoCorpDocu.Text = My.Settings.Save_BoxNoCorpDocu
            End If
        ElseIf Me.DocumentTypeComboBox.Text = "SEC Certificate of Registration" Then
            TabControl1.SelectTab(CorpDocu)
            TabControl3.SelectTab(TabMeeting2)
            If RackNoCorpDocu.Text = "" Then
                RackNoCorpDocu.Text = My.Settings.Save_RackNoCorpDocu
            End If
            If BoxNoCorpDocu.Text = "" Then
                BoxNoCorpDocu.Text = My.Settings.Save_BoxNoCorpDocu
            End If
        ElseIf Me.DocumentTypeComboBox.Text = "DTI Permit" Then
            TabControl1.SelectTab(CorpDocu)
            TabControl3.SelectTab(TabPromo)
            If RackNoCorpDocu.Text = "" Then
                RackNoCorpDocu.Text = My.Settings.Save_RackNoCorpDocu
            End If
            If BoxNoCorpDocu.Text = "" Then
                BoxNoCorpDocu.Text = My.Settings.Save_BoxNoCorpDocu
            End If
        ElseIf Me.DocumentTypeComboBox.Text = "Financial Statement" Then
            TabControl1.SelectTab(CorpDocu)
            TabControl3.SelectTab(TabMeeting2)
            If RackNoCorpDocu.Text = "" Then
                RackNoCorpDocu.Text = My.Settings.Save_RackNoCorpDocu
            End If
            If BoxNoCorpDocu.Text = "" Then
                BoxNoCorpDocu.Text = My.Settings.Save_BoxNoCorpDocu
            End If

        ElseIf Me.DocumentTypeComboBox.Text = "General Information Sheet" Then
            TabControl1.SelectTab(CorpDocu)
            TabControl3.SelectTab(TabMeeting2)
            If RackNoCorpDocu.Text = "" Then
                RackNoCorpDocu.Text = My.Settings.Save_RackNoCorpDocu
            End If
            If BoxNoCorpDocu.Text = "" Then
                BoxNoCorpDocu.Text = My.Settings.Save_BoxNoCorpDocu
            End If



        ElseIf Me.DocumentTypeComboBox.Text = "Importation Documents" Then
            TabControl1.SelectTab(Importation)

            If RackNoImport.Text = "" Then
                RackNoImport.Text = My.Settings.Save_RackNoImport
            End If
            If BoxNoImport.Text = "" Then
                BoxNoCorpDocu.Text = My.Settings.Save_BoxNoImport
            End If

        ElseIf Me.DocumentTypeComboBox.Text = "BIR Form" Then
            TabControl1.SelectTab(BIR)

            If RackNoBIR.Text = "" Then
                RackNoBIR.Text = My.Settings.Save_RackNoImport
            End If
            If BoxNoBIR.Text = "" Then
                BoxNoBIR.Text = My.Settings.Save_BoxNoImport
            End If

        ElseIf Me.DocumentTypeComboBox.Text = "HR Document" Then
            TabControl1.SelectTab(HRDoc)

            If RackNoHRDoc.Text = "" Then
                RackNoHRDoc.Text = My.Settings.Save_RackNoHRDoc
            End If
            If BoxNoHRDoc.Text = "" Then
                BoxNoHRDoc.Text = My.Settings.Save_BoxNoHRDoc
            End If


        ElseIf Me.DocumentTypeComboBox.Text = "Board Resolution" Then
            TabControl1.SelectTab(CorpDocu)
            TabControl3.SelectTab(TabMeeting2)

            If RackNoCorpDocu.Text = "" Then
                RackNoCorpDocu.Text = My.Settings.Save_RackNoCorpDocu
            End If
            If BoxNoCorpDocu.Text = "" Then
                BoxNoCorpDocu.Text = My.Settings.Save_BoxNoCorpDocu
            End If


        ElseIf Me.DocumentTypeComboBox.Text = "Copyright" Then
            TabControl1.SelectTab(Copyright)

            If RackNoCopy.Text = "" Then
                RackNoCopy.Text = My.Settings.Save_RackNoCopy
            End If
            If BoxNoCopy.Text = "" Then
                BoxNoCopy.Text = My.Settings.Save_BoxNoCopy
            End If



        ElseIf Me.DocumentTypeComboBox.Text = "Trademark" Then
            TabControl1.SelectTab(Trademark)

            If RackNoTrade.Text = "" Then
                RackNoTrade.Text = My.Settings.Save_RackNoTrade
            End If
            If BoxNoTrade.Text = "" Then
                BoxNoTrade.Text = My.Settings.Save_BoxNoTrade
            End If


        ElseIf Me.DocumentTypeComboBox.Text = "Trademark" Then
            TabControl1.SelectTab(Trademark)

            If RackNoTrade.Text = "" Then
                RackNoTrade.Text = My.Settings.Save_RackNoTrade
            End If
            If BoxNoTrade.Text = "" Then
                BoxNoTrade.Text = My.Settings.Save_BoxNoTrade
            End If


        ElseIf Me.DocumentTypeComboBox.Text = "Patent" Then
            TabControl1.SelectTab(Patent)

            If RackNoPatent.Text = "" Then
                RackNoPatent.Text = My.Settings.Save_RackNoPatent
            End If
            If BoxNoPatent.Text = "" Then
                BoxNoPatent.Text = My.Settings.Save_BoxNoPatent
            End If



        ElseIf Me.DocumentTypeComboBox.Text = "BIR Importer Clearance Certificate (BIR-ICC)" Then
            TabControl1.SelectTab(BIRClear)

            If RackNoClear.Text = "" Then
                RackNoClear.Text = My.Settings.Save_RackNoClear
            End If
            If BoxNoClear.Text = "" Then
                BoxNoClear.Text = My.Settings.Save_BoxNoClear
            End If


        ElseIf Me.DocumentTypeComboBox.Text = "Certificate of Accreditation" Then
            TabControl1.SelectTab(Accredit)

            If RackNoAccre.Text = "" Then
                RackNoAccre.Text = My.Settings.Save_RackNoAccre
            End If
            If BoxNoAccre.Text = "" Then
                BoxNoAccre.Text = My.Settings.Save_BoxNoAccre
            End If


        ElseIf Me.DocumentTypeComboBox.Text = "GS1 Membership Subscription" Then
            TabControl1.SelectTab(Subs)

            If RackNoSubs.Text = "" Then
                RackNoSubs.Text = My.Settings.Save_RackNoSubs
            End If
            If BoxNoSubs.Text = "" Then
                BoxNoSubs.Text = My.Settings.Save_BoxNoSubs
            End If


        ElseIf Me.DocumentTypeComboBox.Text = "Contract" Then
            TabControl1.SelectTab(Contract)

            If RackNoContract.Text = "" Then
                RackNoContract.Text = My.Settings.Save_RackNoContract
            End If
            If BoxNoContract.Text = "" Then
                BoxNoContract.Text = My.Settings.Save_BoxNoContract
            End If


        ElseIf Me.DocumentTypeComboBox.Text = "Special Power of Attorney" Then
            TabControl1.SelectTab(Attorney)

            If RackNoAttorney.Text = "" Then
                RackNoAttorney.Text = My.Settings.Save_RackNoAttorney
            End If
            If BoxNoAttorney.Text = "" Then
                BoxNoAttorney.Text = My.Settings.Save_BoxNoAttorney
            End If


        ElseIf Me.DocumentTypeComboBox.Text = "Other Documents" Then
            TabControl1.SelectTab(OtherDoc)

            If RackNoOther.Text = "" Then
                RackNoOther.Text = My.Settings.Save_RackNoOther
            End If
            If BoxNoOther.Text = "" Then
                BoxNoOther.Text = My.Settings.Save_BoxNoOther
            End If

        ElseIf Me.DocumentTypeComboBox.Text = "Memorandum" Then
            TabControl1.SelectTab(Memo)

            If RackNoMemo.Text = "" Then
                RackNoMemo.Text = My.Settings.Save_RackNoMemo
            End If
            If BoxNoMemo.Text = "" Then
                BoxNoMemo.Text = My.Settings.Save_BoxNoMemo
            End If









        End If


    End Sub

    Private Sub ComboSelect2()


        If Me.PaymentFormComboBox.Text = "Bank Deposit" Then
            TabControl2.Visible = True
            TabControl2.SelectTab(BankDepo)



        ElseIf Me.PaymentFormComboBox.Text = "Check" Then
            TabControl2.Visible = True
            TabControl2.SelectTab(Check)

        ElseIf Me.PaymentFormComboBox.Text = "Others" Then
            TabControl2.Visible = True
            TabControl2.SelectTab(Others)

        ElseIf Me.PaymentFormComboBox.Text = "" Then
            TabControl2.Visible = False
        ElseIf Me.PaymentFormComboBox.Text = "Cash" Then
            TabControl2.Visible = False
        ElseIf Me.PaymentFormComboBox.SelectedIndex = -1 Then
            TabControl2.Visible = False
        End If





    End Sub

    Private Sub ComboSelect3()


        If Me.PaymentFormImport.Text = "Letter of Credit" Then
            TabControl4.Visible = True
            TabControl4.SelectTab(LCNo)
        ElseIf Me.PaymentFormImport.Text = "DP" Then
            TabControl4.Visible = True
            TabControl4.SelectTab(DPNo)
        ElseIf Me.PaymentFormImport.Text = "Others" Then
            TabControl4.Visible = True
            TabControl4.SelectTab(OthersImport)

        ElseIf Me.PaymentFormImport.Text = "" Then
            TabControl4.Visible = False
        ElseIf Me.PaymentFormImport.SelectedIndex = -1 Then
            TabControl4.Visible = False
        End If




    End Sub




    Private Sub IdTextBox_TextChanged(sender As Object, e As EventArgs) Handles IdTextBox.TextChanged
        Try

            Dim pdffile As String = IIf(IdTextBox.Text = "", (""), (My.Settings.ImgPath & "\" & Me.DocsCatalogueC1TrueDBGrid.Columns("FileName").Text))
            Browser.Navigate(pdffile)


            ' AcroReader1.src = (My.Settings.ImgPath & "\" & Me.DocsCatalogueC1TrueDBGrid.Columns("FileName").Text)


            If IsDBNull(DocsCatalogueBindingSource.Current!DocumentType) Then
                DocumentTypeComboBox.SelectedIndex = -1
            End If




            If IsDBNull(DocsCatalogueBindingSource.Current!PaymentForm) Then
                PaymentFormComboBox.SelectedIndex = -1
            End If





        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DTDocuTimeSheet.ValueChanged
        Me.DocumentDateTS.Text = Me.DTDocuTimeSheet.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DTFromPeriod.ValueChanged
        Me.FromPeriodTextBox.Text = Me.DTFromPeriod.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DateTimePicker4_ValueChanged(sender As Object, e As EventArgs) Handles DTToPeriod.ValueChanged
        Me.ToPeriodTextBox.Text = Me.DTToPeriod.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DocumentTypeComboBox_TextChanged(sender As Object, e As EventArgs) Handles DocumentTypeComboBox.TextChanged

        ComboSelect()

    End Sub



    Private Sub GrpVoucher_Enter(sender As Object, e As EventArgs) Handles GrpVoucher.Enter

    End Sub

    Private Sub GrpWarranty_Enter(sender As Object, e As EventArgs) Handles GrpWarranty.Enter

    End Sub

    Private Sub GrpReceipt_Enter(sender As Object, e As EventArgs) Handles GrpReceipt.Enter

    End Sub

    Private Sub DTDatePurchased_ValueChanged(sender As Object, e As EventArgs) Handles DTDatePurchased.ValueChanged
        Me.DatePurchasedTextBox.Text = Me.DTDatePurchased.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTDocuVoucher_ValueChanged(sender As Object, e As EventArgs) Handles DTDocuVoucher.ValueChanged
        Me.DocumentDateVoucher.Text = Me.DTDocuVoucher.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTDocuCorp_ValueChanged(sender As Object, e As EventArgs) Handles DTDocuCorp.ValueChanged
        Me.DocumentDateCorp.Text = Me.DTDocuCorp.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTMeetingDate_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TotalValueRI_TextChanged(sender As Object, e As EventArgs) Handles TotalValueRI.TextChanged
        'Dim num1 As Double = TotalValueRI.Text
        'TotalValueRI.Text = FormatNumber(num1, 2)





    End Sub

    Private Sub DocumentTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DocumentTypeComboBox.SelectedIndexChanged

    End Sub

    Private Sub DocsCatalogueC1TrueDBGrid_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PaymentFormComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PaymentFormComboBox.SelectedIndexChanged

    End Sub

    Private Sub PaymentFormComboBox_TextChanged(sender As Object, e As EventArgs) Handles PaymentFormComboBox.TextChanged
        ComboSelect2()

    End Sub

    Private Sub FirstNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles FirstNameTextBox.TextChanged

    End Sub

    Private Sub BankAddressLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DTDateReceived.ValueChanged
        Me.DateReceivedTextBox.Text = Me.DTDateReceived.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click

        'Try
        '    Dim MsgDelete = MessageBox.Show("Delete Record?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        '    If MsgDelete = vbYes Then




        '        Me.DocsCatalogueBindingSource.RemoveCurrent()
        '        Me.Validate()
        '        Me.DocsCatalogueBindingSource.EndEdit()
        '        Me.DocsCatalogueTableAdapter.Update(Me.DMSDataSet.DocsCatalogue)

        '        File.Delete(My.Settings.ImgPath & "\" & Me.DocsCatalogueC1TrueDBGrid.Columns("FileName").Text)
        '        ' MessageBox.Show("Record Deleted!!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        Me.LblStat.Text = "Record Deleted."




        '        Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
        '        Dim cmdlogs As New SqlCommand(" INSERT INTO DMSLogs(Username, Action, ActionDate) VALUES (@Username, @Action, @ActionDate)", con)



        '        con.Open()
        '        cmdlogs.Connection = con
        '        cmdlogs.Parameters.AddWithValue("@Username", FrmMain.User)
        '        cmdlogs.Parameters.AddWithValue("@Action", FrmMain.User & " " & "Deleted a record with ID:" & Me.IdTextBox.Text)
        '        cmdlogs.Parameters.AddWithValue("@ActionDate", DateTime.Now)
        '        cmdlogs.ExecuteNonQuery()
        '        con.Close()




        '    End If

        'Catch ex As Exception

        '    MessageBox.Show(ex.Message)

        'End Try




        FrmReason.ShowDialog()




    End Sub



    Private Sub BtnCancel1_Click(sender As Object, e As EventArgs) Handles BtnCancel1.Click
        'Temp Disabled
        Me.DocumentTypeComboBox.Enabled = False
        Me.BatchTextBox.ReadOnly = True
        Me.SubBatchTextBox.ReadOnly = True
        Me.cbDocSize.Enabled = False
        Me.txtPages.ReadOnly = True
        Me.chkConfidential.Enabled = False

        GrpTimeSheet.Enabled = False
        GrpReceipt.Enabled = False
        GrpCorp.Enabled = False
        GrpVoucher.Enabled = False
        GrpWarranty.Enabled = False


        Me.BtnSave.Enabled = False
        Me.BtnClear.Enabled = False
        Me.BtnEdit.Enabled = True
        Me.BtnCancel1.Enabled = False
        Me.DocsCatalogueC1TrueDBGrid.Enabled = True


        Try


            Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
            Dim cmdlogs As New SqlCommand(" INSERT INTO DMSLogs(Username, Action, ActionDate) VALUES (@Username, @Action, @ActionDate)", con)



            con.Open()
            cmdlogs.Connection = con
            cmdlogs.Parameters.AddWithValue("@Username", FrmMain.User)
            cmdlogs.Parameters.AddWithValue("@Action", FrmMain.User & " " & "Cancelled edit on record with ID:" & Me.IdTextBox.Text)
            cmdlogs.Parameters.AddWithValue("@ActionDate", DateTime.Now)
            cmdlogs.ExecuteNonQuery()
            con.Close()





        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub DocumentDateRI_LostFocus(sender As Object, e As EventArgs) Handles DocumentDateRI.LostFocus



        Dim DateFormat As Date

        If Date.TryParseExact(DocumentDateRI.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.DocumentDateRI.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.DocumentDateRI.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.DocumentDateRI.Clear()
        End If
    End Sub

    Private Sub DocumentDateTS_LostFocus(sender As Object, e As EventArgs) Handles DocumentDateTS.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(DocumentDateTS.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.DocumentDateTS.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.DocumentDateTS.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.DocumentDateTS.Clear()
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

    Private Sub DateReceivedTextBox_LostFocus(sender As Object, e As EventArgs) Handles DateReceivedTextBox.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(DateReceivedTextBox.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.DateReceivedTextBox.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.DateReceivedTextBox.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.DateReceivedTextBox.Clear()
        End If
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
        MeetingDateTextBox.BackColor = Color.White

        Dim DateFormat As Date

        If Date.TryParseExact(MeetingDateTextBox.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.MeetingDateTextBox.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.MeetingDateTextBox.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.MeetingDateTextBox.Clear()
        End If
    End Sub

    Private Sub RackNoTS_TextChanged(sender As Object, e As EventArgs) Handles RackNoTS.TextChanged

    End Sub

    Private Sub DTMeetingDate_ValueChanged_1(sender As Object, e As EventArgs) Handles DTMeetingDate.ValueChanged
        Me.MeetingDateTextBox.Text = Me.DTMeetingDate.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DateTimePicker1_ValueChanged_2(sender As Object, e As EventArgs) Handles DTPromoFrom.ValueChanged
        Me.PromoFromTextBox.Text = Me.DTPromoFrom.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTPromoTo_ValueChanged(sender As Object, e As EventArgs) Handles DTPromoTo.ValueChanged
        Me.PromoToTextBox.Text = Me.DTPromoTo.Value.ToString("MM/dd/yyyy")
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



    Private Sub VesselArrivedImport_LostFocus(sender As Object, e As EventArgs) Handles VesselArrivedImport.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(VesselArrivedImport.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.VesselArrivedImport.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.VesselArrivedImport.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.VesselArrivedImport.Clear()
        End If
    End Sub

    Private Sub DTDocuBIR_ValueChanged(sender As Object, e As EventArgs) Handles DTDocuBIR.ValueChanged
        Me.DocumentDateBIR.Text = Me.DTDocuBIR.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DateTimePicker1_ValueChanged_3(sender As Object, e As EventArgs) Handles DTVesselImport.ValueChanged
        Me.VesselArrivedImport.Text = Me.DTVesselImport.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DateTimePicker1_ValueChanged_4(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Me.ImpMonthImport.Text = Me.DTVesselImport.Value.ToString("MMMM yyyy")
    End Sub

    Private Sub PaymentFormImport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PaymentFormImport.SelectedIndexChanged

    End Sub

    Private Sub PaymentFormImport_TextChanged(sender As Object, e As EventArgs) Handles PaymentFormImport.TextChanged
        ComboSelect3()
    End Sub

    Private Sub ShipBatchImport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ShipBatchImport.SelectedIndexChanged

    End Sub

    Private Sub ShipBatchImport_TextChanged(sender As Object, e As EventArgs) Handles ShipBatchImport.TextChanged

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

    Private Sub DTDocuHRDoc_ValueChanged(sender As Object, e As EventArgs) Handles DTDocuHRDoc.ValueChanged
        Me.DocumentDateHRDoc.Text = Me.DTDocuHRDoc.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DocumentDateHRDoc_TextChanged(sender As Object, e As EventArgs) Handles DocumentDateHRDoc.TextChanged

    End Sub

    Private Sub DocumentDateHRDoc_LostFocus(sender As Object, e As EventArgs) Handles DocumentDateHRDoc.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(DocumentDateHRDoc.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.DocumentDateHRDoc.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.DocumentDateHRDoc.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.DocumentDateHRDoc.Clear()
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged_1(sender As Object, e As EventArgs) Handles DTCreateDate.ValueChanged
        Me.CreationDateCopy.Text = Me.DTCreateDate.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub CreationDateCopy_TextChanged(sender As Object, e As EventArgs) Handles CreationDateCopy.TextChanged

    End Sub

    Private Sub CreationDateCopy_LostFocus(sender As Object, e As EventArgs) Handles CreationDateCopy.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(CreationDateCopy.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.CreationDateCopy.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.CreationDateCopy.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.CreationDateCopy.Clear()
        End If
    End Sub

    Private Sub DTRegDateTrade_ValueChanged(sender As Object, e As EventArgs) Handles DTRegDateTrade.ValueChanged
        Me.RegDateTrade.Text = Me.DTRegDateTrade.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTFromTrade_ValueChanged(sender As Object, e As EventArgs) Handles DTFromTrade.ValueChanged
        Me.FromPeriodTrade.Text = Me.DTFromTrade.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTToTrade_ValueChanged(sender As Object, e As EventArgs) Handles DTToTrade.ValueChanged
        Me.ToPeriodTrade.Text = Me.DTToTrade.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTFilingTrade_ValueChanged(sender As Object, e As EventArgs) Handles DTFilingTrade.ValueChanged
        Me.FilingDateTrade.Text = Me.DTFilingTrade.Value.ToString("MM/dd/yyyy")
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

    Private Sub FromPeriodTrade_TextChanged(sender As Object, e As EventArgs) Handles FromPeriodTrade.TextChanged

    End Sub

    Private Sub ToPeriodTrade_TextChanged(sender As Object, e As EventArgs) Handles ToPeriodTrade.TextChanged

    End Sub

    Private Sub FromPeriodTrade_LostFocus(sender As Object, e As EventArgs) Handles FromPeriodTrade.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(FromPeriodTrade.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.FromPeriodTrade.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.FromPeriodTrade.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.FromPeriodTrade.Clear()
        End If
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

    Private Sub DateTimePicker2_ValueChanged_2(sender As Object, e As EventArgs) Handles DTRegDatePatent.ValueChanged
        Me.RegDatePatent.Text = Me.DTRegDatePatent.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTFromPatent_ValueChanged(sender As Object, e As EventArgs) Handles DTFromPatent.ValueChanged
        Me.FromPeriodPatent.Text = Me.DTFromPatent.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTToPatent_ValueChanged(sender As Object, e As EventArgs) Handles DTToPatent.ValueChanged
        Me.ToPeriodPatent.Text = Me.DTToPatent.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTFilingPatent_ValueChanged(sender As Object, e As EventArgs) Handles DTFilingPatent.ValueChanged
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

    Private Sub DateTimePicker2_ValueChanged_3(sender As Object, e As EventArgs) Handles DTIssueDateClear.ValueChanged
        Me.IssueDateClear.Text = Me.DTIssueDateClear.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTFromClear_ValueChanged(sender As Object, e As EventArgs) Handles DTFromClear.ValueChanged
        Me.FromPeriodClear.Text = Me.DTFromClear.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTToClear_ValueChanged(sender As Object, e As EventArgs) Handles DTToClear.ValueChanged
        Me.ToPeriodClear.Text = Me.DTToClear.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DateTimePicker2_ValueChanged_4(sender As Object, e As EventArgs) Handles DTSubsDateSubs.ValueChanged
        Me.SubsDateSubs.Text = Me.DTSubsDateSubs.Value.ToString("MM/dd/yyyy")
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

    Private Sub DTFromSubs_ValueChanged(sender As Object, e As EventArgs) Handles DTFromSubs.ValueChanged
        Me.FromPeriodSubs.Text = Me.DTFromSubs.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTToSubs_ValueChanged(sender As Object, e As EventArgs) Handles DTToSubs.ValueChanged
        Me.ToPeriodSubs.Text = Me.DTToSubs.Value.ToString("MM/dd/yyyy")
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

    Private Sub DTFromContract_ValueChanged(sender As Object, e As EventArgs) Handles DTFromContract.ValueChanged
        Me.FromPeriodContract.Text = Me.DTFromContract.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTToContract_ValueChanged(sender As Object, e As EventArgs) Handles DTToContract.ValueChanged
        Me.ToPeriodContract.Text = Me.DTToContract.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTDateSignContract_ValueChanged(sender As Object, e As EventArgs) Handles DTDateSignContract.ValueChanged
        Me.SignDateContract.Text = Me.DTDateSignContract.Value.ToString("MM/dd/yyyy")
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

    Private Sub ToPeriodContract_TextChanged(sender As Object, e As EventArgs) Handles ToPeriodContract.TextChanged


        Dim DateFormat As Date

        If Date.TryParseExact(ToPeriodContract.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.ToPeriodContract.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.ToPeriodContract.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.ToPeriodContract.Clear()
        End If
    End Sub

    Private Sub SignDateContract_TextChanged(sender As Object, e As EventArgs) Handles SignDateContract.TextChanged

    End Sub

    Private Sub DateTimePicker2_ValueChanged_5(sender As Object, e As EventArgs) Handles DTIssueDateAttorney.ValueChanged
        Me.IssueDateAttorney.Text = Me.DTIssueDateAttorney.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTIssuePlaceAttorney_ValueChanged(sender As Object, e As EventArgs) Handles DTIssuePlaceAttorney.ValueChanged
        Me.IssuePlaceAttorney.Text = Me.DTIssuePlaceAttorney.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTFromAttorney_ValueChanged(sender As Object, e As EventArgs) Handles DTFromAttorney.ValueChanged
        Me.FromPeriodAttorney.Text = Me.DTFromAttorney.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTToAttorney_ValueChanged(sender As Object, e As EventArgs) Handles DTToAttorney.ValueChanged
        Me.ToPeriodAttorney.Text = Me.DTToAttorney.Value.ToString("MM/dd/yyyy")
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

    Private Sub DateTimePicker2_ValueChanged_6(sender As Object, e As EventArgs) Handles DTIssueDateOther.ValueChanged
        Me.IssueDateOther.Text = Me.DTIssueDateOther.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTIssuePlaceOther_ValueChanged(sender As Object, e As EventArgs) Handles DTIssuePlaceOther.ValueChanged
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

    Private Sub DTIssueDateMemo_ValueChanged(sender As Object, e As EventArgs) Handles DTIssueDateMemo.ValueChanged
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

    Private Sub RackNoImport_TextChanged(sender As Object, e As EventArgs) Handles RackNoImport.TextChanged

    End Sub

    Private Sub RackNoImport_GotFocus(sender As Object, e As EventArgs) Handles RackNoImport.GotFocus

    End Sub

    Private Sub RackNoImport_LostFocus(sender As Object, e As EventArgs) Handles RackNoImport.LostFocus

    End Sub

    Private Sub SignDateContract_LostFocus(sender As Object, e As EventArgs) Handles SignDateContract.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(SignDateContract.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.SignDateContract.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.SignDateContract.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.SignDateContract.Clear()
        End If
    End Sub

    Private Sub DateTimePicker5_ValueChanged(sender As Object, e As EventArgs) Handles DTIssueDateAccre.ValueChanged
        Me.IssueDateAccre.Text = Me.DTIssueDateAccre.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub DTFromAccre_ValueChanged(sender As Object, e As EventArgs) Handles DTFromAccre.ValueChanged
        Me.FromPeriodAccre.Text = Me.DTFromAccre.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub FromPeriodTrade_LocationChanged(sender As Object, e As EventArgs) Handles FromPeriodTrade.LocationChanged

    End Sub



    Private Sub ImpMonthImport_LostFocus(sender As Object, e As EventArgs) Handles ImpMonthImport.LostFocus


        Dim DateFormat As Date

        If Date.TryParseExact(ImpMonthImport.Text.ToString(), "MMMM yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.ImpMonthImport.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.ImpMonthImport.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.ImpMonthImport.Clear()
        End If
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

    Private Sub PromoFromTextBox_TextChanged(sender As Object, e As EventArgs) Handles PromoFromTextBox.TextChanged

    End Sub

    Private Sub PromoFromTextBox_GotFocus(sender As Object, e As EventArgs) Handles PromoFromTextBox.GotFocus
        PromoFromTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub PromoToTextBox_TextChanged(sender As Object, e As EventArgs) Handles PromoToTextBox.TextChanged

    End Sub

    Private Sub PromoToTextBox_GotFocus(sender As Object, e As EventArgs) Handles PromoToTextBox.GotFocus
        PromoToTextBox.BackColor = Color.LightYellow
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

    Private Sub DocumentDateTS_TextChanged(sender As Object, e As EventArgs) Handles DocumentDateTS.TextChanged

    End Sub

    Private Sub DocumentDateTS_GotFocus(sender As Object, e As EventArgs) Handles DocumentDateTS.GotFocus

    End Sub

    Private Sub DTDocuTimeSheet_GotFocus(sender As Object, e As EventArgs) Handles DTDocuTimeSheet.GotFocus
        DocumentDateTS.BackColor = Color.LightYellow
    End Sub

    Private Sub DTDocuTimeSheet_LostFocus(sender As Object, e As EventArgs) Handles DTDocuTimeSheet.LostFocus
        DocumentDateTS.BackColor = Color.White
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

    Private Sub DTPromoFrom_GotFocus(sender As Object, e As EventArgs) Handles DTPromoFrom.GotFocus
        PromoFromTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub DTPromoFrom_LostFocus(sender As Object, e As EventArgs) Handles DTPromoFrom.LostFocus
        PromoFromTextBox.BackColor = Color.White
    End Sub

    Private Sub DTPromoTo_GotFocus(sender As Object, e As EventArgs) Handles DTPromoTo.GotFocus
        PromoToTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub DTPromoTo_LostFocus(sender As Object, e As EventArgs) Handles DTPromoTo.LostFocus
        PromoToTextBox.BackColor = Color.White
    End Sub

    Private Sub DateTimePicker1_GotFocus(sender As Object, e As EventArgs) Handles DateTimePicker1.GotFocus
        ImpMonthImport.BackColor = Color.LightYellow
    End Sub

    Private Sub DateTimePicker1_LostFocus(sender As Object, e As EventArgs) Handles DateTimePicker1.LostFocus
        ImpMonthImport.BackColor = Color.White
    End Sub

    Private Sub DTVesselImport_GotFocus(sender As Object, e As EventArgs) Handles DTVesselImport.GotFocus
        VesselArrivedImport.BackColor = Color.LightYellow
    End Sub

    Private Sub DTVesselImport_LostFocus(sender As Object, e As EventArgs) Handles DTVesselImport.LostFocus
        VesselArrivedImport.BackColor = Color.White
    End Sub

    Private Sub DTDocuBIR_HandleCreated(sender As Object, e As EventArgs) Handles DTDocuBIR.HandleCreated

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

    Private Sub DTCreateDate_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs) Handles DTCreateDate.GiveFeedback

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

    Private Sub DTRegDatePatent_GotFocus(sender As Object, e As EventArgs) Handles DTRegDatePatent.GotFocus
        RegDatePatent.BackColor = Color.LightYellow
    End Sub

    Private Sub DTRegDatePatent_LostFocus(sender As Object, e As EventArgs) Handles DTRegDatePatent.LostFocus
        RegDatePatent.BackColor = Color.White
    End Sub

    Private Sub DTFromPatent_GotFocus(sender As Object, e As EventArgs) Handles DTFromPatent.GotFocus
        FromPeriodPatent.BackColor = Color.LightYellow
    End Sub

    Private Sub DTFromPatent_LostFocus(sender As Object, e As EventArgs) Handles DTFromPatent.LostFocus
        FromPeriodPatent.BackColor = Color.White
    End Sub

    Private Sub DTToPatent_GotFocus(sender As Object, e As EventArgs) Handles DTToPatent.GotFocus
        ToPeriodPatent.BackColor = Color.LightYellow
    End Sub

    Private Sub DTToPatent_LostFocus(sender As Object, e As EventArgs) Handles DTToPatent.LostFocus
        ToPeriodPatent.BackColor = Color.White
    End Sub

    Private Sub DTFilingPatent_GotFocus(sender As Object, e As EventArgs) Handles DTFilingPatent.GotFocus
        FilingDatePatent.BackColor = Color.LightYellow
    End Sub

    Private Sub DTFilingPatent_LostFocus(sender As Object, e As EventArgs) Handles DTFilingPatent.LostFocus
        FilingDatePatent.BackColor = Color.White
    End Sub

    Private Sub DateTimePicker1_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs) Handles DateTimePicker1.GiveFeedback

    End Sub

    Private Sub DTToClear_GotFocus(sender As Object, e As EventArgs) Handles DTToClear.GotFocus
        ToPeriodClear.BackColor = Color.LightYellow
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

    Private Sub DTToAccre_ValueChanged(sender As Object, e As EventArgs) Handles DTToAccre.ValueChanged

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
        IssuePlaceOther.BackColor = Color.White
    End Sub

    Private Sub DTIssueDateMemo_GotFocus(sender As Object, e As EventArgs) Handles DTIssueDateMemo.GotFocus
        IssueDateMemo.BackColor = Color.LightYellow
    End Sub

    Private Sub DTIssueDateMemo_LostFocus(sender As Object, e As EventArgs) Handles DTIssueDateMemo.LostFocus
        IssueDateMemo.BackColor = Color.White
    End Sub
End Class