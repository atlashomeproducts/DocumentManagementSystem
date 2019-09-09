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






    End Sub

    Private Sub DocMan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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




    Private Sub IdTextBox_TextChanged(sender As Object, e As EventArgs) Handles IdTextBox.TextChanged
        Try

            Dim pdffile As String = IIf(IdTextBox.Text = "", (""), (My.Settings.ImgPath & "\" & Me.DocsCatalogueC1TrueDBGrid.Columns("FileName").Text))
            WebBrowser1.Navigate(pdffile)


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

        DocumentDateRI.BackColor = Color.White

        Dim DateFormat As Date

        If Date.TryParseExact(DocumentDateRI.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.DocumentDateRI.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.DocumentDateRI.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.DocumentDateRI.Clear()
        End If
    End Sub

    Private Sub DocumentDateTS_LostFocus(sender As Object, e As EventArgs) Handles DocumentDateTS.LostFocus
        DocumentDateTS.BackColor = Color.White

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
        DocumentDateVoucher.BackColor = Color.White

        Dim DateFormat As Date

        If Date.TryParseExact(DocumentDateVoucher.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.DocumentDateVoucher.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.DocumentDateVoucher.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.DocumentDateVoucher.Clear()
        End If
    End Sub

    Private Sub DatePurchasedTextBox_LostFocus(sender As Object, e As EventArgs) Handles DatePurchasedTextBox.LostFocus
        DatePurchasedTextBox.BackColor = Color.White


        Dim DateFormat As Date

        If Date.TryParseExact(DatePurchasedTextBox.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.DatePurchasedTextBox.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.DatePurchasedTextBox.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.DatePurchasedTextBox.Clear()
        End If
    End Sub

    Private Sub DateReceivedTextBox_LostFocus(sender As Object, e As EventArgs) Handles DateReceivedTextBox.LostFocus
        DateReceivedTextBox.BackColor = Color.White

        Dim DateFormat As Date

        If Date.TryParseExact(DateReceivedTextBox.Text.ToString(), "mm/dd/yyyy", System.Globalization.CultureInfo.CurrentCulture, Globalization.DateTimeStyles.None, DateFormat) Or Me.DateReceivedTextBox.Text = "" Then
        Else

            MessageBox.Show("Incorrect Date Format " & Me.DateReceivedTextBox.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.DateReceivedTextBox.Clear()
        End If
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

    Private Sub MeetingDateLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnDownload_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub RackNoTS_GotFocus(sender As Object, e As EventArgs) Handles RackNoTS.GotFocus
        RackNoTS.BackColor = Color.LightYellow
    End Sub

    Private Sub RackNoTS_LostFocus(sender As Object, e As EventArgs) Handles RackNoTS.LostFocus
        RackNoTS.BackColor = Color.White
    End Sub

    Private Sub BoxNoTS_TextChanged(sender As Object, e As EventArgs) Handles BoxNoTS.TextChanged

    End Sub

    Private Sub BoxNoTS_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs) Handles BoxNoTS.GiveFeedback

    End Sub

    Private Sub BoxNoTS_GotFocus(sender As Object, e As EventArgs) Handles BoxNoTS.GotFocus
        BoxNoTS.BackColor = Color.LightYellow
    End Sub

    Private Sub BoxNoTS_LostFocus(sender As Object, e As EventArgs) Handles BoxNoTS.LostFocus
        BoxNoTS.BackColor = Color.White
    End Sub

    Private Sub DocumentDateTS_TextChanged(sender As Object, e As EventArgs) Handles DocumentDateTS.TextChanged

    End Sub

    Private Sub DocumentDateTS_GotFocus(sender As Object, e As EventArgs) Handles DocumentDateTS.GotFocus
        DocumentDateTS.BackColor = Color.LightYellow
    End Sub

    Private Sub LastNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles LastNameTextBox.TextChanged

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

    Private Sub MiddleNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles MiddleNameTextBox.TextChanged

    End Sub

    Private Sub MiddleNameTextBox_GotFocus(sender As Object, e As EventArgs) Handles MiddleNameTextBox.GotFocus
        MiddleNameTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub MiddleNameTextBox_LostFocus(sender As Object, e As EventArgs) Handles MiddleNameTextBox.LostFocus
        MiddleNameTextBox.BackColor = Color.White
    End Sub

    Private Sub FromPeriodTextBox_TextChanged(sender As Object, e As EventArgs) Handles FromPeriodTextBox.TextChanged

    End Sub

    Private Sub FromPeriodTextBox_GotFocus(sender As Object, e As EventArgs) Handles FromPeriodTextBox.GotFocus
        FromPeriodTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub ToPeriodTextBox_TextChanged(sender As Object, e As EventArgs) Handles ToPeriodTextBox.TextChanged

    End Sub

    Private Sub ToPeriodTextBox_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs) Handles ToPeriodTextBox.GiveFeedback
        ToPeriodTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub RackNoRI_TextChanged(sender As Object, e As EventArgs) Handles RackNoRI.TextChanged

    End Sub

    Private Sub RackNoRI_GotFocus(sender As Object, e As EventArgs) Handles RackNoRI.GotFocus
        RackNoRI.BackColor = Color.LightYellow
    End Sub

    Private Sub RackNoRI_LostFocus(sender As Object, e As EventArgs) Handles RackNoRI.LostFocus
        RackNoRI.BackColor = Color.White
    End Sub

    Private Sub BoxNoRI_TextChanged(sender As Object, e As EventArgs) Handles BoxNoRI.TextChanged

    End Sub

    Private Sub BoxNoRI_GotFocus(sender As Object, e As EventArgs) Handles BoxNoRI.GotFocus
        BoxNoRI.BackColor = Color.LightYellow
    End Sub

    Private Sub BoxNoRI_LostFocus(sender As Object, e As EventArgs) Handles BoxNoRI.LostFocus
        BoxNoRI.BackColor = Color.White
    End Sub

    Private Sub DocumentDateRI_TextChanged(sender As Object, e As EventArgs) Handles DocumentDateRI.TextChanged

    End Sub

    Private Sub DocumentDateRI_GotFocus(sender As Object, e As EventArgs) Handles DocumentDateRI.GotFocus
        DocumentDateRI.BackColor = Color.LightYellow
    End Sub

    Private Sub BookletNoTextBox_TextChanged(sender As Object, e As EventArgs) Handles BookletNoTextBox.TextChanged

    End Sub

    Private Sub BookletNoTextBox_GotFocus(sender As Object, e As EventArgs) Handles BookletNoTextBox.GotFocus
        BookletNoTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub BookletNoTextBox_LostFocus(sender As Object, e As EventArgs) Handles BookletNoTextBox.LostFocus
        BookletNoTextBox.BackColor = Color.White
    End Sub

    Private Sub ReferenceNoRI_TextChanged(sender As Object, e As EventArgs) Handles ReferenceNoRI.TextChanged

    End Sub

    Private Sub ReferenceNoRI_GotFocus(sender As Object, e As EventArgs) Handles ReferenceNoRI.GotFocus
        ReferenceNoRI.BackColor = Color.LightYellow
    End Sub

    Private Sub ReferenceNoRI_LostFocus(sender As Object, e As EventArgs) Handles ReferenceNoRI.LostFocus
        ReferenceNoRI.BackColor = Color.White
    End Sub

    Private Sub VendorTextBox_TextChanged(sender As Object, e As EventArgs) Handles VendorTextBox.TextChanged

    End Sub

    Private Sub VendorTextBox_GotFocus(sender As Object, e As EventArgs) Handles VendorTextBox.GotFocus
        VendorTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub VendorTextBox_LostFocus(sender As Object, e As EventArgs) Handles VendorTextBox.LostFocus
        VendorTextBox.BackColor = Color.White
    End Sub

    Private Sub CustomerTextBox_TextChanged(sender As Object, e As EventArgs) Handles CustomerTextBox.TextChanged

    End Sub

    Private Sub CustomerTextBox_GotFocus(sender As Object, e As EventArgs) Handles CustomerTextBox.GotFocus
        CustomerTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub CustomerTextBox_LostFocus(sender As Object, e As EventArgs) Handles CustomerTextBox.LostFocus
        CustomerTextBox.BackColor = Color.White
    End Sub

    Private Sub AddressCTextBox_TextChanged(sender As Object, e As EventArgs) Handles AddressCTextBox.TextChanged

    End Sub

    Private Sub AddressCTextBox_GotFocus(sender As Object, e As EventArgs) Handles AddressCTextBox.GotFocus
        AddressCTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub AddressCTextBox_LostFocus(sender As Object, e As EventArgs) Handles AddressCTextBox.LostFocus
        AddressCTextBox.BackColor = Color.White
    End Sub

    Private Sub TinVendorTextBox_TextChanged(sender As Object, e As EventArgs) Handles TinVendorTextBox.TextChanged

    End Sub

    Private Sub TinVendorTextBox_GotFocus(sender As Object, e As EventArgs) Handles TinVendorTextBox.GotFocus
        TinVendorTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub TinVendorTextBox_LostFocus(sender As Object, e As EventArgs) Handles TinVendorTextBox.LostFocus
        TinVendorTextBox.BackColor = Color.White
    End Sub

    Private Sub TinCustomerTextBox_TextChanged(sender As Object, e As EventArgs) Handles TinCustomerTextBox.TextChanged

    End Sub

    Private Sub TinCustomerTextBox_GotFocus(sender As Object, e As EventArgs) Handles TinCustomerTextBox.GotFocus
        TinCustomerTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub TinCustomerTextBox_LostFocus(sender As Object, e As EventArgs) Handles TinCustomerTextBox.LostFocus
        TinCustomerTextBox.BackColor = Color.White
    End Sub

    Private Sub ItemPurchasedTextBox_TextChanged(sender As Object, e As EventArgs) Handles ItemPurchasedTextBox.TextChanged

    End Sub

    Private Sub ItemPurchasedTextBox_GotFocus(sender As Object, e As EventArgs) Handles ItemPurchasedTextBox.GotFocus
        ItemPurchasedTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub ItemPurchasedTextBox_LostFocus(sender As Object, e As EventArgs) Handles ItemPurchasedTextBox.LostFocus
        ItemPurchasedTextBox.BackColor = Color.White
    End Sub

    Private Sub RackNoWarranty_TextChanged(sender As Object, e As EventArgs) Handles RackNoWarranty.TextChanged

    End Sub

    Private Sub RackNoWarranty_GotFocus(sender As Object, e As EventArgs) Handles RackNoWarranty.GotFocus
        RackNoWarranty.BackColor = Color.LightYellow
    End Sub

    Private Sub RackNoWarranty_LostFocus(sender As Object, e As EventArgs) Handles RackNoWarranty.LostFocus
        RackNoWarranty.BackColor = Color.White
    End Sub

    Private Sub BoxNoWarranty_TextChanged(sender As Object, e As EventArgs) Handles BoxNoWarranty.TextChanged

    End Sub

    Private Sub BoxNoWarranty_GotFocus(sender As Object, e As EventArgs) Handles BoxNoWarranty.GotFocus
        BoxNoWarranty.BackColor = Color.LightYellow
    End Sub

    Private Sub BoxNoWarranty_LostFocus(sender As Object, e As EventArgs) Handles BoxNoWarranty.LostFocus
        BoxNoWarranty.BackColor = Color.White
    End Sub

    Private Sub ProductBrandTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProductBrandTextBox.TextChanged

    End Sub

    Private Sub ProductBrandTextBox_GotFocus(sender As Object, e As EventArgs) Handles ProductBrandTextBox.GotFocus
        ProductBrandTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub ProductBrandTextBox_LostFocus(sender As Object, e As EventArgs) Handles ProductBrandTextBox.LostFocus
        ProductBrandTextBox.BackColor = Color.White
    End Sub

    Private Sub ProductTypeTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProductTypeTextBox.TextChanged

    End Sub

    Private Sub ProductTypeTextBox_GotFocus(sender As Object, e As EventArgs) Handles ProductTypeTextBox.GotFocus
        ProductTypeTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub ProductTypeTextBox_LostFocus(sender As Object, e As EventArgs) Handles ProductTypeTextBox.LostFocus
        ProductTypeTextBox.BackColor = Color.White
    End Sub

    Private Sub SerialTextBox_TextChanged(sender As Object, e As EventArgs) Handles SerialTextBox.TextChanged

    End Sub

    Private Sub SerialTextBox_GotFocus(sender As Object, e As EventArgs) Handles SerialTextBox.GotFocus
        SerialTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub SerialTextBox_LostFocus(sender As Object, e As EventArgs) Handles SerialTextBox.LostFocus
        SerialTextBox.BackColor = Color.White
    End Sub

    Private Sub DatePurchasedTextBox_TextChanged(sender As Object, e As EventArgs) Handles DatePurchasedTextBox.TextChanged

    End Sub

    Private Sub DatePurchasedTextBox_GotFocus(sender As Object, e As EventArgs) Handles DatePurchasedTextBox.GotFocus
        DatePurchasedTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub ReferenceNoTextBox1_TextChanged(sender As Object, e As EventArgs) Handles ReferenceNoTextBox1.TextChanged

    End Sub

    Private Sub ReferenceNoTextBox1_GotFocus(sender As Object, e As EventArgs) Handles ReferenceNoTextBox1.GotFocus
        ReferenceNoTextBox1.BackColor = Color.LightYellow
    End Sub

    Private Sub ReferenceNoTextBox1_LostFocus(sender As Object, e As EventArgs) Handles ReferenceNoTextBox1.LostFocus
        ReferenceNoTextBox1.BackColor = Color.White
    End Sub

    Private Sub WarrantyNoTextBox_TextChanged(sender As Object, e As EventArgs) Handles WarrantyNoTextBox.TextChanged

    End Sub

    Private Sub WarrantyNoTextBox_GotFocus(sender As Object, e As EventArgs) Handles WarrantyNoTextBox.GotFocus
        WarrantyNoTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub WarrantyNoTextBox_LostFocus(sender As Object, e As EventArgs) Handles WarrantyNoTextBox.LostFocus
        WarrantyNoTextBox.BackColor = Color.White
    End Sub

    Private Sub WarrantyPeriodTextBox_TextChanged(sender As Object, e As EventArgs) Handles WarrantyPeriodTextBox.TextChanged

    End Sub

    Private Sub WarrantyPeriodTextBox_GotFocus(sender As Object, e As EventArgs) Handles WarrantyPeriodTextBox.GotFocus
        WarrantyPeriodTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub WarrantyPeriodTextBox_LostFocus(sender As Object, e As EventArgs) Handles WarrantyPeriodTextBox.LostFocus
        WarrantyPeriodTextBox.BackColor = Color.White
    End Sub

    Private Sub ServiceCenterTextBox_TextChanged(sender As Object, e As EventArgs) Handles ServiceCenterTextBox.TextChanged

    End Sub

    Private Sub ServiceCenterTextBox_GotFocus(sender As Object, e As EventArgs) Handles ServiceCenterTextBox.GotFocus
        ServiceCenterTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub ServiceCenterTextBox_LostFocus(sender As Object, e As EventArgs) Handles ServiceCenterTextBox.LostFocus
        ServiceCenterTextBox.BackColor = Color.White
    End Sub

    Private Sub AddressTextBox_TextChanged(sender As Object, e As EventArgs) Handles AddressTextBox.TextChanged

    End Sub

    Private Sub AddressTextBox_GotFocus(sender As Object, e As EventArgs) Handles AddressTextBox.GotFocus
        AddressTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub AddressTextBox_LostFocus(sender As Object, e As EventArgs) Handles AddressTextBox.LostFocus
        AddressTextBox.BackColor = Color.White
    End Sub

    Private Sub ContactNoTextBox_TextChanged(sender As Object, e As EventArgs) Handles ContactNoTextBox.TextChanged

    End Sub

    Private Sub ContactNoTextBox_GotFocus(sender As Object, e As EventArgs) Handles ContactNoTextBox.GotFocus
        ContactNoTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub ContactNoTextBox_LostFocus(sender As Object, e As EventArgs) Handles ContactNoTextBox.LostFocus
        ContactNoTextBox.BackColor = Color.White
    End Sub

    Private Sub EmailTextBox_TextChanged(sender As Object, e As EventArgs) Handles EmailTextBox.TextChanged

    End Sub

    Private Sub EmailTextBox_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs) Handles EmailTextBox.GiveFeedback

    End Sub

    Private Sub EmailTextBox_GotFocus(sender As Object, e As EventArgs) Handles EmailTextBox.GotFocus
        EmailTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub EmailTextBox_LostFocus(sender As Object, e As EventArgs) Handles EmailTextBox.LostFocus
        EmailTextBox.BackColor = Color.White
    End Sub

    Private Sub TotalValueWarranty_TextChanged(sender As Object, e As EventArgs) Handles TotalValueWarranty.TextChanged

    End Sub

    Private Sub TotalValueWarranty_GotFocus(sender As Object, e As EventArgs) Handles TotalValueWarranty.GotFocus
        TotalValueWarranty.BackColor = Color.LightYellow
    End Sub

    Private Sub TotalValueWarranty_LostFocus(sender As Object, e As EventArgs) Handles TotalValueWarranty.LostFocus
        TotalValueWarranty.BackColor = Color.White
    End Sub

    Private Sub RackNoVoucher_TextChanged(sender As Object, e As EventArgs) Handles RackNoVoucher.TextChanged

    End Sub

    Private Sub RackNoVoucher_GotFocus(sender As Object, e As EventArgs) Handles RackNoVoucher.GotFocus
        RackNoVoucher.BackColor = Color.LightYellow
    End Sub

    Private Sub RackNoVoucher_LostFocus(sender As Object, e As EventArgs) Handles RackNoVoucher.LostFocus
        RackNoVoucher.BackColor = Color.White
    End Sub

    Private Sub BoxNoVoucher_TextChanged(sender As Object, e As EventArgs) Handles BoxNoVoucher.TextChanged

    End Sub

    Private Sub BoxNoVoucher_GotFocus(sender As Object, e As EventArgs) Handles BoxNoVoucher.GotFocus
        BoxNoVoucher.BackColor = Color.LightYellow
    End Sub

    Private Sub BoxNoVoucher_LostFocus(sender As Object, e As EventArgs) Handles BoxNoVoucher.LostFocus
        BoxNoVoucher.BackColor = Color.White
    End Sub

    Private Sub DocumentDateVoucher_TextChanged(sender As Object, e As EventArgs) Handles DocumentDateVoucher.TextChanged

    End Sub

    Private Sub DocumentDateVoucher_GotFocus(sender As Object, e As EventArgs) Handles DocumentDateVoucher.GotFocus
        DocumentDateVoucher.BackColor = Color.LightYellow
    End Sub

    Private Sub PayeeTextBox_TextChanged(sender As Object, e As EventArgs) Handles PayeeTextBox.TextChanged

    End Sub

    Private Sub PayeeTextBox_GotFocus(sender As Object, e As EventArgs) Handles PayeeTextBox.GotFocus
        PayeeTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub PayeeTextBox_LostFocus(sender As Object, e As EventArgs) Handles PayeeTextBox.LostFocus
        PayeeTextBox.BackColor = Color.White
    End Sub

    Private Sub PayorTextBox_TextChanged(sender As Object, e As EventArgs) Handles PayorTextBox.TextChanged

    End Sub

    Private Sub PayorTextBox_GotFocus(sender As Object, e As EventArgs) Handles PayorTextBox.GotFocus
        PayorTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub PayorTextBox_LostFocus(sender As Object, e As EventArgs) Handles PayorTextBox.LostFocus
        PayorTextBox.BackColor = Color.White
    End Sub

    Private Sub VoucherNoTextBox_TextChanged(sender As Object, e As EventArgs) Handles VoucherNoTextBox.TextChanged

    End Sub

    Private Sub VoucherNoTextBox_GotFocus(sender As Object, e As EventArgs) Handles VoucherNoTextBox.GotFocus
        VoucherNoTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub VoucherNoTextBox_LostFocus(sender As Object, e As EventArgs) Handles VoucherNoTextBox.LostFocus
        VoucherNoTextBox.BackColor = Color.White
    End Sub

    Private Sub BankNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles BankNameTextBox.TextChanged

    End Sub

    Private Sub BankNameTextBox_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs) Handles BankNameTextBox.GiveFeedback

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

    Private Sub TotalValueVoucher_TextChanged(sender As Object, e As EventArgs) Handles TotalValueVoucher.TextChanged

    End Sub

    Private Sub TotalValueVoucher_GotFocus(sender As Object, e As EventArgs) Handles TotalValueVoucher.GotFocus
        TotalValueVoucher.BackColor = Color.LightYellow
    End Sub

    Private Sub TotalValueVoucher_LostFocus(sender As Object, e As EventArgs) Handles TotalValueVoucher.LostFocus
        TotalValueVoucher.BackColor = Color.White
    End Sub

    Private Sub PreparedbyTextBox_TextChanged(sender As Object, e As EventArgs) Handles PreparedbyTextBox.TextChanged

    End Sub

    Private Sub PreparedbyTextBox_GotFocus(sender As Object, e As EventArgs) Handles PreparedbyTextBox.GotFocus
        PreparedbyTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub PreparedbyTextBox_LostFocus(sender As Object, e As EventArgs) Handles PreparedbyTextBox.LostFocus
        PreparedbyTextBox.BackColor = Color.White
    End Sub

    Private Sub ApprovedbyTextBox_TextChanged(sender As Object, e As EventArgs) Handles ApprovedbyTextBox.TextChanged

    End Sub

    Private Sub ApprovedbyTextBox_GotFocus(sender As Object, e As EventArgs) Handles ApprovedbyTextBox.GotFocus
        ApprovedbyTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub ApprovedbyTextBox_LostFocus(sender As Object, e As EventArgs) Handles ApprovedbyTextBox.LostFocus
        ApprovedbyTextBox.BackColor = Color.White
    End Sub

    Private Sub RecordedbyTextBox_TextChanged(sender As Object, e As EventArgs) Handles RecordedbyTextBox.TextChanged

    End Sub

    Private Sub RecordedbyTextBox_GotFocus(sender As Object, e As EventArgs) Handles RecordedbyTextBox.GotFocus
        RecordedbyTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub RecordedbyTextBox_LostFocus(sender As Object, e As EventArgs) Handles RecordedbyTextBox.LostFocus
        RecordedbyTextBox.BackColor = Color.White
    End Sub

    Private Sub ReceivedbyTextBox_TextChanged(sender As Object, e As EventArgs) Handles ReceivedbyTextBox.TextChanged

    End Sub

    Private Sub ReceivedbyTextBox_GotFocus(sender As Object, e As EventArgs) Handles ReceivedbyTextBox.GotFocus
        ReceivedbyTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub ReceivedbyTextBox_LostFocus(sender As Object, e As EventArgs) Handles ReceivedbyTextBox.LostFocus
        ReceivedbyTextBox.BackColor = Color.White
    End Sub

    Private Sub DateReceivedTextBox_TextChanged(sender As Object, e As EventArgs) Handles DateReceivedTextBox.TextChanged

    End Sub

    Private Sub DateReceivedTextBox_GotFocus(sender As Object, e As EventArgs) Handles DateReceivedTextBox.GotFocus
        DateReceivedTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub RackNoCorpDocu_TextChanged(sender As Object, e As EventArgs) Handles RackNoCorpDocu.TextChanged

    End Sub

    Private Sub RackNoCorpDocu_GotFocus(sender As Object, e As EventArgs) Handles RackNoCorpDocu.GotFocus
        RackNoCorpDocu.BackColor = Color.LightYellow
    End Sub

    Private Sub RackNoCorpDocu_LostFocus(sender As Object, e As EventArgs) Handles RackNoCorpDocu.LostFocus
        RackNoCorpDocu.BackColor = Color.White
    End Sub

    Private Sub BoxNoCorpDocu_TextChanged(sender As Object, e As EventArgs) Handles BoxNoCorpDocu.TextChanged

    End Sub

    Private Sub BoxNoCorpDocu_GotFocus(sender As Object, e As EventArgs) Handles BoxNoCorpDocu.GotFocus
        BoxNoCorpDocu.BackColor = Color.LightYellow
    End Sub

    Private Sub BoxNoCorpDocu_LostFocus(sender As Object, e As EventArgs) Handles BoxNoCorpDocu.LostFocus
        BoxNoCorpDocu.BackColor = Color.White
    End Sub

    Private Sub DocumentDateCorp_TextChanged(sender As Object, e As EventArgs) Handles DocumentDateCorp.TextChanged

    End Sub

    Private Sub DocumentDateCorp_GotFocus(sender As Object, e As EventArgs) Handles DocumentDateCorp.GotFocus
        DocumentDateCorp.BackColor = Color.LightYellow
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

    Private Sub PurposeTextBox_TextChanged(sender As Object, e As EventArgs) Handles PurposeTextBox.TextChanged

    End Sub

    Private Sub PurposeTextBox_GotFocus(sender As Object, e As EventArgs) Handles PurposeTextBox.GotFocus
        PurposeTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub PurposeTextBox_LostFocus(sender As Object, e As EventArgs) Handles PurposeTextBox.LostFocus
        PurposeTextBox.BackColor = Color.White
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

    Private Sub DTIPermitNoTextBox_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs) Handles DTIPermitNoTextBox.GiveFeedback

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

    Private Sub TotalValueRI_GotFocus(sender As Object, e As EventArgs) Handles TotalValueRI.GotFocus
        TotalValueRI.BackColor = Color.LightYellow
    End Sub

    Private Sub TotalValueRI_LostFocus(sender As Object, e As EventArgs) Handles TotalValueRI.LostFocus
        TotalValueRI.BackColor = Color.White
    End Sub

    Private Sub ToPeriodTextBox_HandleCreated(sender As Object, e As EventArgs) Handles ToPeriodTextBox.HandleCreated

    End Sub

    Private Sub ToPeriodTextBox_GotFocus(sender As Object, e As EventArgs) Handles ToPeriodTextBox.GotFocus
        ToPeriodTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub PaymentOthersTextBox_TextChanged(sender As Object, e As EventArgs) Handles PaymentOthersTextBox.TextChanged

    End Sub

    Private Sub PaymentOthersTextBox_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs) Handles PaymentOthersTextBox.GiveFeedback

    End Sub

    Private Sub PaymentOthersTextBox_GotFocus(sender As Object, e As EventArgs) Handles PaymentOthersTextBox.GotFocus
        PaymentOthersTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub PaymentOthersTextBox_LostFocus(sender As Object, e As EventArgs) Handles PaymentOthersTextBox.LostFocus
        PaymentOthersTextBox.BackColor = Color.White
    End Sub

    Private Sub CheckNoTextBox_TextChanged(sender As Object, e As EventArgs) Handles CheckNoTextBox.TextChanged

    End Sub

    Private Sub CheckNoTextBox_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs) Handles CheckNoTextBox.GiveFeedback

    End Sub

    Private Sub CheckNoTextBox_GotFocus(sender As Object, e As EventArgs) Handles CheckNoTextBox.GotFocus
        CheckNoTextBox.BackColor = Color.LightYellow
    End Sub

    Private Sub CheckNoTextBox_LostFocus(sender As Object, e As EventArgs) Handles CheckNoTextBox.LostFocus
        CheckNoTextBox.BackColor = Color.White
    End Sub

    Private Sub DocsCatalogueC1TrueDBGrid_Click_1(sender As Object, e As EventArgs) Handles DocsCatalogueC1TrueDBGrid.Click

    End Sub

    Private Sub DocsCatalogueC1TrueDBGrid_DoubleClick(sender As Object, e As EventArgs) Handles DocsCatalogueC1TrueDBGrid.DoubleClick

    End Sub

    Private Sub SplitContainer2_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer2.Panel2.Paint

    End Sub

    Private Sub IdTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class