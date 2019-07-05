
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports System.Runtime.InteropServices
Public Class FrmIndex
    Private Declare Unicode Function NetRemoteTOD Lib "netapi32" (<MarshalAs(UnmanagedType.LPWStr)> ByVal ServerName As String, ByRef BufferPtr As IntPtr) As Integer
    Private Declare Function NetApiBufferFree Lib "netapi32" (ByVal Buffer As IntPtr) As Integer

    Structure TIME_OF_DAY_INFO
        Dim tod_elapsedt As Integer
        Dim tod_msecs As Integer
        Dim tod_hours As Integer
        Dim tod_mins As Integer
        Dim tod_secs As Integer
        Dim tod_hunds As Integer
        Dim tod_timezone As Integer
        Dim tod_tinterval As Integer
        Dim tod_day As Integer
        Dim tod_month As Integer
        Dim tod_year As Integer
        Dim tod_weekday As Integer
    End Structure


    Function GetNetRemoteTOD(ByVal strServerName As String) As Date
        Try
            Dim iRet As Integer
            Dim ptodi As IntPtr
            Dim todi As TIME_OF_DAY_INFO
            Dim dDate As Date
            strServerName = strServerName & vbNullChar
            iRet = NetRemoteTOD(strServerName, ptodi)
            If iRet = 0 Then
                todi = CType(Marshal.PtrToStructure(ptodi, GetType(TIME_OF_DAY_INFO)), TIME_OF_DAY_INFO)
                NetApiBufferFree(ptodi)
                dDate = DateSerial(todi.tod_year, todi.tod_month, todi.tod_day) + " " + TimeSerial(todi.tod_hours, todi.tod_mins - todi.tod_timezone, todi.tod_secs)
                GetNetRemoteTOD = dDate

            Else
                MsgBox("Error retrieving time")
            End If
        Catch

            Try
                GetNetRemoteTOD = Date.Now.ToString("MM/dd/yyyy HH:mm:ss tt")
            Catch
                MsgBox("Error in GetNetRemoteTOD: " & Err.Description)
            End Try

        End Try

        Return GetNetRemoteTOD
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click

        With OpenFileDialog1
            .FileName = vbNullString           'Clear out previous filename
            .Filter = "PDF Files (*.pdf)|*.pdf| All Files (*.*)|*.*"
            .FilterIndex = 1             'Set index of filter
            .Multiselect = True     'Allow selecting of multiple files
            .CheckFileExists = True  'Only select existing files
            .ShowReadOnly = True   'Hide read only files
            .Title = "Import Files"  'Set caption of OFD



            If .ShowDialog() = System.Windows.Forms.DialogResult.OK Then


                For Each filename As String In .FileNames  'Loop through the file names
                    If Not (ListBox1.Items.Contains(filename)) Then
                        ListBox1.Items.Add(filename)
                    Else
                        MessageBox.Show(filename & " already exists", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Next

            End If
        End With





    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnIndex.Click
        If txtCompany.Text = "" Or txtPurpose.Text = "" Or DocumentTypeComboBox.Text = "" Or batchIdTextBox.Text = "" Or SubBatchTextbox.Text = "" Then


            MessageBox.Show("Please complete all the required fields.", "Incomplete Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else


            If ListBox1.Items.Count = 0 Then

                MessageBox.Show("Files not found!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf batchIdTextBox.Text = "" Then

                MessageBox.Show("Please don't leave batch name empty..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else

                Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
                Dim cmd As New SqlCommand
                Dim strsql As String = "INSERT INTO DocsCatalogue([DocumentType], [Batch], [SubBatch],[ScannedDate],[Filename],[Status], [Company], [Purpose], [RackNo], [BoxNo], [UserID])
                                                   VALUES (@DocumentType, @BatchID, @SubBatch, @ScanDate, @FileName, @Status, @Company, @Purpose, @RackNo, @BoxNo, @UserID)"
                Dim cmdlogs As New SqlCommand(" INSERT INTO DMSLogs(Username, Action, ActionDate) VALUES (@Username, @Action, @ActionDate)", con)
                Dim dRemoteDate As Date
                dRemoteDate = GetNetRemoteTOD(My.Settings.remoteTOD)


                With cmd
                    .CommandText = strsql
                    .CommandType = CommandType.Text


                    .Parameters.AddWithValue("@DocumentType", "")
                    .Parameters.AddWithValue("@BatchID", "")
                    .Parameters.AddWithValue("@SubBatch", "")
                    .Parameters.AddWithValue("@ScanDate", "")
                    .Parameters.AddWithValue("@FileName", "")
                    .Parameters.AddWithValue("@Status", "")
                    .Parameters.AddWithValue("@Company", "")
                    .Parameters.AddWithValue("@Purpose", "")
                    .Parameters.AddWithValue("@RackNo", "")
                    .Parameters.AddWithValue("@BoxNo", "")
                    .Parameters.AddWithValue("@UserID", "")



                    .Connection = con
                End With

                Try


                    con.Open()

                    For Each Item As String In ListBox1.SelectedItems


                        cmd.Parameters("@DocumentType").Value = DocumentTypeComboBox.Text
                        cmd.Parameters("@BatchID").Value = batchIdTextBox.Text
                        cmd.Parameters("@SubBatch").Value = SubBatchTextbox.Text
                        cmd.Parameters("@ScanDate").Value = scanDateTimePicker.Text
                        cmd.Parameters("@FileName").Value = txtPurpose.Text & "_" & My.Computer.FileSystem.GetFileInfo(Item).Name
                        cmd.Parameters("@Status").Value = "Indexed"
                        cmd.Parameters("@Company").Value = txtCompany.Text
                        cmd.Parameters("@Purpose").Value = txtPurpose.Text
                        cmd.Parameters("@RackNo").Value = RackNoTextbox.Text
                        cmd.Parameters("@BoxNo").Value = BoxNoTextbox.Text
                        cmd.Parameters("@UserID").Value = FrmMain.User

                        cmd.ExecuteNonQuery()



                        File.Copy(Item, Path.Combine(My.Settings.ImgPath, txtPurpose.Text & "_" & My.Computer.FileSystem.GetFileInfo(Item).Name), True)
                    Next


                    con.Close()

                    Dim lst As New List(Of Object)
                    For Each a As Object In ListBox1.SelectedItems
                        lst.Add(a)
                    Next
                    For Each a As Object In lst
                        ListBox1.Items.Remove(a)
                    Next

                    AxAcroPDF1.LoadFile("NOTEXISTING.pdf")
                    FrmMain.SpDMSTotalsTableAdapter.Fill(FrmMain.DMSDataSet.spDMSTotals)
                    MessageBox.Show("Index Success!!", "Indexed", MessageBoxButtons.OK, MessageBoxIcon.Information)




                    con.Open()
                        cmdlogs.Connection = con
                        cmdlogs.Parameters.AddWithValue("@Username", FrmMain.User)
                    cmdlogs.Parameters.AddWithValue("@Action", FrmMain.User & " Indexed documents with batch name: " & Me.batchIdTextBox.Text)
                    cmdlogs.Parameters.AddWithValue("@ActionDate", dRemoteDate)
                    cmdlogs.ExecuteNonQuery()
                        con.Close()



                    Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    con.Close()
                End Try

            End If

        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim path = Me.ListBox1.SelectedItem

        AxAcroPDF1.src = path
    End Sub

    Private Sub Index_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  Me.TopMost = True


        Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
        Dim cmd2 As New SqlCommand("SELECT Distinct Company FROM DocsCatalogue WHERE Status = 'Finished' ", con)
                    Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cmd2)
        da.Fill(ds, "list") ' list can be any name u want
        Dim col As New AutoCompleteStringCollection

        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("Company").ToString())  'columnname same as in query
        Next



        txtCompany.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtCompany.AutoCompleteCustomSource = col
        txtCompany.AutoCompleteMode = AutoCompleteMode.SuggestAppend


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("SELECT DocumentType FROM DocumentTypes ORDER BY DocumentType", con)
        Dim read As SqlDataReader = cmd.ExecuteReader()
        While read.Read()
            DocumentTypeComboBox.Items.Add(read.GetString(0))
        End While

        con.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click

        Try

            Dim MsgDelete = MessageBox.Show("Remove Items?", "Remove?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


            If MsgDelete = vbYes Then



                Do While (ListBox1.SelectedItems.Count > 0)
                    ListBox1.Items.Remove(ListBox1.SelectedItem)
                Loop

                AxAcroPDF1.LoadFile("NOTEXISTING.pdf")

            ElseIf MsgDelete = vbNo Then

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub SplitContainer3_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer3.Panel2.Paint

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub DocumentTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DocumentTypeComboBox.SelectedIndexChanged
        batchIdTextBox.Text = DocumentTypeComboBox.Text & "-" & txtCompany.Text & "-" & Me.DateTimePicker1.Value.ToString("yyyyMMMdd") & "-" & txtPurpose.Text
    End Sub

    Private Sub TxtPurpose_TextChanged(sender As Object, e As EventArgs) Handles txtPurpose.TextChanged


        batchIdTextBox.Text = DocumentTypeComboBox.Text & "-" & txtCompany.Text & "-" & Me.DateTimePicker1.Value.ToString("yyyyMMMdd") & "-" & txtPurpose.Text
    End Sub

    Private Sub TxtCompany_TextChanged(sender As Object, e As EventArgs) Handles txtCompany.TextChanged
        batchIdTextBox.Text = DocumentTypeComboBox.Text & "-" & txtCompany.Text & "-" & Me.DateTimePicker1.Value.ToString("yyyyMMMdd") & "-" & txtPurpose.Text
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        batchIdTextBox.Text = DocumentTypeComboBox.Text & "-" & txtCompany.Text & "-" & Me.DateTimePicker1.Value.ToString("yyyyMMMdd") & "-" & txtPurpose.Text
    End Sub





End Class