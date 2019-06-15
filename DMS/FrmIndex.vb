
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Public Class FrmIndex


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



        If ListBox1.Items.Count = 0 Then

            MessageBox.Show("Files not found!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf batchIdTextBox.Text = "" Then

            MessageBox.Show("Please don't leave batch name empty..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
            Dim cmd As New SqlCommand

            Try


                con.Open()

                For Each Item As String In ListBox1.SelectedItems

                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO [dbo].[DocsCatalogue] ([Batch], [SubBatch],[BatchDesc],[ScannedDate],[Filename],[Status], [RackNo], [BoxNo]) 
                                        VALUES ('" & batchIdTextBox.Text & "', '" & SubBatchTextbox.Text & "', '" & TxtBatchDesc.Text & "','" & scanDateTimePicker.Text & "' 
                                                , '" & batchIdTextBox.Text & "_" & My.Computer.FileSystem.GetFileInfo(Item).Name & "', '" & "Indexed" & "', '" & RackNoTextbox.Text & "', '" & BoxNoTextbox.Text & "')"
                    cmd.ExecuteNonQuery()

                    File.Copy(Item, Path.Combine(My.Settings.ImgPath, Me.batchIdTextBox.Text & "_" & My.Computer.FileSystem.GetFileInfo(Item).Name), True)

                Next

                Dim lst As New List(Of Object)
                For Each a As Object In ListBox1.SelectedItems
                    lst.Add(a)
                Next
                For Each a As Object In lst
                    ListBox1.Items.Remove(a)
                Next

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click

        Try

            Dim MsgDelete = MessageBox.Show("Remove Items?", "Remove?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If MsgDelete = vbYes Then

                Me.ListBox1.Items.Clear()
                AxAcroPDF1.LoadFile("NOTEXISTING.pdf")

            ElseIf MsgDelete = vbNo Then

            End If



            '    ListBox1.Items.Remove(ListBox1.SelectedItem)
            'Me.ListBox1.SelectedIndex = Me.ListBox1.SelectedIndex + 1


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub SplitContainer3_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer3.Panel2.Paint

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)


    End Sub



    'Private Sub ListBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseDown
    '    Try

    '        Dim sAllString As String = "ALL"

    '        If Me.ListBox1.SelectedItems.Count = 0 Then

    '            Me.ListBox1.ClearSelected()
    '            Me.ListBox1.SelectedItems.Add(sAllString)

    '        Else
    '            Dim pt As Point = New Point(e.X, e.Y)

    '            Dim index As Integer

    '            index = CType(sender, ListBox).IndexFromPoint(pt)

    '            If index = Me.ListBox1.Items.IndexOf(sAllString) Then

    '                Me.ListBox1.ClearSelected()

    '                Me.ListBox1.SelectedItems.Add(sAllString)

    '            Else

    '                If Me.ListBox1.SelectedItems.Count > 1 AndAlso Me.ListBox1.SelectedItems.Contains(sAllString) Then

    '                    Me.ListBox1.SelectedItems.Remove(Me.ListBox1.Items.Item(Me.ListBox1.Items.IndexOf(sAllString)))
    '                    Dim path = Me.ListBox1.SelectedItem

    '                    AxAcroPDF1.src = path

    '                End If

    '            End If

    '        End If


    '    Catch ex As Exception

    '        Throw ex

    '    End Try
    'End Sub


End Class