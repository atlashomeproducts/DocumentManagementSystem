﻿Imports C1.Win.C1TrueDBGrid

Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports System.ComponentModel

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




        'Dim adapter As New SqlDataAdapter(cmd)
        'Dim table As New DataTable()

        '    adapter.Fill(table)

        'DocumentTypeComboBox.DataSource = table

        'DocumentTypeComboBox.DisplayMember = "DocumentType"
        '' DocumentTypeComboBox.ValueMember = "Id"

    End Sub

    Private Sub DocMan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DMSDataSet.DocumentGroups' table. You can move, or remove it, as needed.



        'Populate Data
        PopulateComboItems()
        Me.DocsCatalogueTableAdapter.Fill(Me.DMSDataSet.DocsCatalogue)



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


        'Permanently Disabled
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Visible = False
        Me.DocumentDateCorp.ReadOnly = True
        Me.DocumentDateRI.ReadOnly = True
        Me.DocumentDateTS.ReadOnly = True
        Me.DocumentDateVoucher.ReadOnly = True

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

    End Sub


    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click


        Try

            Me.Validate()
            Me.DocsCatalogueBindingSource.EndEdit()
            Me.DocsCatalogueTableAdapter.Update(Me.DMSDataSet.DocsCatalogue)

            Me.DocsCatalogueC1TrueDBGrid.Enabled = True
            'Me.DocsCatalogueTableAdapter.Fill(Me.DMSDataSet.DocsCatalogue)

            'Temp Disabled
            Me.DocumentTypeComboBox.Enabled = False
            GrpTimeSheet.Enabled = False
            GrpReceipt.Enabled = False
            GrpCorp.Enabled = False
            GrpVoucher.Enabled = False
            GrpWarranty.Enabled = False

            LblStat.Text = "Successfully Saved!!"
            Me.BtnSave.Enabled = False
            Me.BtnClear.Enabled = False
            Me.BtnEdit.Enabled = True

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        Dim MsgDelete = MessageBox.Show("Are you sure you want to clear all the values for this record?", "Clear?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)


        If MsgDelete = vbYes Then


            DocumentTypeComboBox.Text = ""
            DocumentDateRI.Clear()
            ReferenceNoRI.Clear()
            RemarksTextBox.Clear()
            BookletNoTextBox.Clear()
            ReferenceNoRI.Clear()
            VendorTextBox.Clear()
            CustomerTextBox.Clear()
            ItemPurchasedTextBox.Clear()
            RemarksTextBox.Clear()
            TotalValueRI.Clear()

            DocumentDateTS.Clear()
            LastNameTextBox.Clear()
            FirstNameTextBox.Clear()
            MiddleNameTextBox.Clear()
            FromPeriodTextBox.Clear()
            ToPeriodTextBox.Clear()

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

            DocumentDateVoucher.Clear()
            PayeeTextBox.Clear()
            PayorTextBox.Clear()
            VoucherNoTextBox.Clear()
            CheckNoTextBox.Clear()
            PaymentFormTextBox.Clear()
            TotalValueVoucher.Clear()
            PreparedbyTextBox.Clear()
            ApprovedbyTextBox.Clear()
            RecordedbyTextBox.Clear()
            ReceivedbyTextBox.Clear()
            BankAddressTextBox.Clear()
            BankBranchTextBox.Clear()
            BankNameTextBox.Clear()
            PaymentOthersTextBox.Clear()



            DocumentDateCorp.Clear()
            MeetingDateTextBox.Clear()
            CompanyTextBox.Clear()
            SecretaryTextBox.Clear()
            PurposeTextBox.Clear()

        Else

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

    End Sub



    Private Sub DateTimePicker1_ValueChanged_1(sender As Object, e As EventArgs) Handles DTDocuRI.ValueChanged

        Me.DocumentDateRI.Text = Me.DTDocuRI.Value.ToString("MM/dd/yyyy")

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DocsCatalogueTableAdapter.Fill(Me.DMSDataSet.DocsCatalogue)


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

            BtnRefresh.src = (My.Settings.ImgPath & "\" & Me.DocsCatalogueC1TrueDBGrid.Columns("FileName").Text)


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

    Private Sub DocumentDateLabel1_Click(sender As Object, e As EventArgs)

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

    Private Sub DTMeetingDate_ValueChanged(sender As Object, e As EventArgs) Handles DTMeetingDate.ValueChanged
        Me.MeetingDateTextBox.Text = Me.DTMeetingDate.Value.ToString("MM/dd/yyyy")
    End Sub

    Private Sub TotalValueRI_TextChanged(sender As Object, e As EventArgs) Handles TotalValueRI.TextChanged
        'Dim num1 As Double = TotalValueRI.Text
        'TotalValueRI.Text = FormatNumber(num1, 2)
    End Sub

    Private Sub DocumentTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DocumentTypeComboBox.SelectedIndexChanged

    End Sub

    Private Sub DocsCatalogueC1TrueDBGrid_Click(sender As Object, e As EventArgs) Handles DocsCatalogueC1TrueDBGrid.Click

    End Sub

    Private Sub PaymentFormComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PaymentFormComboBox.SelectedIndexChanged

    End Sub

    Private Sub PaymentFormComboBox_TextChanged(sender As Object, e As EventArgs) Handles PaymentFormComboBox.TextChanged
        ComboSelect2()

    End Sub
End Class