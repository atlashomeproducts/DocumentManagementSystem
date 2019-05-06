
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Public Class FrmIndex
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click






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

                    ListBox1.Items.Add(filename)
                Next

            End If
        End With





    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click



        If ListBox1.Items.Count = 0 Then

            MessageBox.Show("Files not found!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)


        ElseIf batchIdTextBox.Text = "" Then

            MessageBox.Show("Please don't leave batch name empty..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else




            Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
            Dim cmd As New SqlCommand



            Try


                con.Open()

                For Each Item As String In ListBox1.Items

                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO [dbo].[DocsCatalogue] ([Batch], [SubBatch],[BatchDesc],[ScannedDate],[Filename],[Status]) 
                                        VALUES ('" & batchIdTextBox.Text & "', '" & TxtSubBatch.Text & "', '" & TxtBatchDesc.Text & "','" & scanDateTimePicker.Text & "' 
                                                , '" & batchIdTextBox.Text & "_" & My.Computer.FileSystem.GetFileInfo(Item).Name & "', '" & "Indexed" & "')"
                    cmd.ExecuteNonQuery()

                    File.Copy(Item, Path.Combine(My.Settings.ImgPath, batchIdTextBox.Text & "_" & TxtSubBatch.Text & "_" & My.Computer.FileSystem.GetFileInfo(Item).Name), True)

                Next


                Me.ListBox1.Items.Clear()
                AxAcroPDF1.LoadFile("NOTEXISTING.pdf")


                MessageBox.Show("Index Success!!", "Indexed", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                con.Close()
            End Try

        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim path = Me.ListBox1.SelectedItem

        AxAcroPDF1.src = path
    End Sub

    Private Sub Index_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  Me.TopMost = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Me.ListBox1.Items.Clear()
        ' AxAcroPDF1.LoadFile("NOTEXISTING.pdf")
        Try


            ListBox1.Items.Remove(ListBox1.SelectedItem)
        Me.ListBox1.SelectedIndex = Me.ListBox1.SelectedIndex + 1


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub




End Class