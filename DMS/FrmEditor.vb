﻿Imports C1.Win.C1TrueDBGrid

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
        Me.DocsCatalogueTableAdapter.Fill(Me.DMSDataSet.DocsCatalogue, "Indexed")



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
        For Each TabPage In TabControl3.TabPages

            TabPage.Text = ""

        Next



        'Permanently Disabled
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Visible = False


        'Temp Disabled
        Me.DocumentTypeComboBox.Enabled = False
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


        If FrmMain.type = "User" Or FrmMain.type = "" Then
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



                Me.DocsCatalogueTableAdapter.Fill(Me.DMSDataSet.DocsCatalogue, "Indexed")
                Me.DocsCatalogueC1TrueDBGrid.Enabled = True



                'Temp Disabled
                Me.DocumentTypeComboBox.Enabled = False
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


        'UpdateStatusLocked()

        Me.DocumentTypeComboBox.Enabled = True
        GrpTimeSheet.Enabled = True
        GrpReceipt.Enabled = True
        GrpCorp.Enabled = True
        GrpVoucher.Enabled = True
        GrpWarranty.Enabled = True

        Me.DocsCatalogueC1TrueDBGrid.Enabled = False
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



    End Sub



    Private Sub DateTimePicker1_ValueChanged_1(sender As Object, e As EventArgs) Handles DTDocuRI.ValueChanged

        Me.DocumentDateRI.Text = Me.DTDocuRI.Value.ToString("MM/dd/yyyy")

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Me.DocsCatalogueTableAdapter.Fill(Me.DMSDataSet.DocsCatalogue, "Indexed")





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

            AcroReader1.src = (My.Settings.ImgPath & "\" & Me.DocsCatalogueC1TrueDBGrid.Columns("FileName").Text)


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

        Try
            Dim MsgDelete = MessageBox.Show("Delete Record?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If MsgDelete = vbYes Then




                Me.DocsCatalogueBindingSource.RemoveCurrent()
                Me.Validate()
                Me.DocsCatalogueBindingSource.EndEdit()
                Me.DocsCatalogueTableAdapter.Update(Me.DMSDataSet.DocsCatalogue)

                File.Delete(My.Settings.ImgPath & "\" & Me.DocsCatalogueC1TrueDBGrid.Columns("FileName").Text)
                ' MessageBox.Show("Record Deleted!!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.LblStat.Text = "Record Deleted."




                Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
                Dim cmdlogs As New SqlCommand(" INSERT INTO DMSLogs(Username, Action, ActionDate) VALUES (@Username, @Action, @ActionDate)", con)



                con.Open()
                cmdlogs.Connection = con
                cmdlogs.Parameters.AddWithValue("@Username", FrmMain.User)
                cmdlogs.Parameters.AddWithValue("@Action", FrmMain.User & " " & "Deleted a record with ID:" & Me.IdTextBox.Text)
                cmdlogs.Parameters.AddWithValue("@ActionDate", DateTime.Now)
                cmdlogs.ExecuteNonQuery()
                con.Close()




            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub



    Private Sub BtnCancel1_Click(sender As Object, e As EventArgs) Handles BtnCancel1.Click
        'Temp Disabled
        Me.DocumentTypeComboBox.Enabled = False
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

    Private Sub MeetingDateLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnDownload_Click(sender As Object, e As EventArgs) 

    End Sub
End Class