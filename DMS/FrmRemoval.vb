Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO
Imports C1.Win.C1TrueDBGrid

Public Class FrmRemoval
    Private Sub FrmRemoval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DMSDataSet.vwRemoval' table. You can move, or remove it, as needed.
        Me.VwRemovalTableAdapter.Fill(Me.DMSDataSet.vwRemoval)
        'TODO: This line of code loads data into the 'DMSDataSet.vwRemoval' table. You can move, or remove it, as needed.


        Me.VwRemovalC1TrueDBGrid.Columns("Select").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox

        For i = 0 To VwRemovalBindingSource.Count
            Me.VwRemovalC1TrueDBGrid.Columns("Select").Value = False
            VwRemovalBindingSource.MoveNext()
        Next


        VwRemovalBindingSource.MoveFirst()

        Me.VwRemovalC1TrueDBGrid.Splits(0).DisplayColumns("Filename").Locked = True
        Me.VwRemovalC1TrueDBGrid.Splits(0).DisplayColumns("DocumentType").Locked = True
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Visible = False


    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub VwRemovalC1TrueDBGrid_Click(sender As Object, e As EventArgs) Handles VwRemovalC1TrueDBGrid.Click
        'Dim pdffile As String = IIf(IdTextBox.Text = "", (""), (My.Settings.ImgPath & "\" & Me.VwRemovalC1TrueDBGrid.Columns("FileName").Text))
        'WebBrowser1.Navigate(pdffile)
    End Sub

    Private Sub VwRemovalC1TrueDBGrid_SelChange(sender As Object, e As CancelEventArgs) Handles VwRemovalC1TrueDBGrid.SelChange

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnSelectAll.Click
        RemoveHandler IdTextBox.TextChanged, AddressOf IdTextBox_TextChanged
        VwRemovalBindingSource.MoveFirst()
        For i = 0 To VwRemovalBindingSource.Count
            Me.VwRemovalC1TrueDBGrid.Columns("Select").Value = True
            VwRemovalBindingSource.MoveNext()
        Next

        AddHandler IdTextBox.TextChanged, AddressOf IdTextBox_TextChanged
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnDeselectAll.Click
        RemoveHandler IdTextBox.TextChanged, AddressOf IdTextBox_TextChanged
        VwRemovalBindingSource.MoveFirst()
        For i = 0 To VwRemovalBindingSource.Count
            Me.VwRemovalC1TrueDBGrid.Columns("Select").Value = False
            VwRemovalBindingSource.MoveNext()
        Next
        AddHandler IdTextBox.TextChanged, AddressOf IdTextBox_TextChanged
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click



        Dim MsgDelete = MessageBox.Show("Are you sure to remove selected documents", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgDelete = vbYes Then


            RemoveHandler IdTextBox.TextChanged, AddressOf IdTextBox_TextChanged
            ' do work


            Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
            Dim cmdlogs As New SqlCommand("INSERT INTO DMSLogs(Username, Action, ActionDate) VALUES (@Username, @Action, @ActionDate)", con)
            Dim cmd As New SqlCommand

            cmd.Parameters.AddWithValue("@ID", "")
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "spRemovalDelete"
            cmd.CommandType = CommandType.StoredProcedure



            Try
                ' Dim FilePath As String
                ' If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then

                VwRemovalBindingSource.MoveFirst()

                For i = 0 To Me.VwRemovalBindingSource.Count - 1

                    If Me.VwRemovalC1TrueDBGrid.Columns("Select").Value = True Then

                        cmd.Parameters("@ID").Value = Me.VwRemovalC1TrueDBGrid.Columns("ID").Text
                        cmd.ExecuteNonQuery()



                        My.Computer.FileSystem.DeleteFile(Path.Combine(My.Settings.ImgPath, Me.VwRemovalC1TrueDBGrid.Columns("FileName").Text))
                    End If
                    VwRemovalBindingSource.MoveNext()
                Next


                ' Dim dRemoteDate As Date
                '  dRemoteDate = GetNetRemoteTOD(My.Settings.remoteTOD)


                cmdlogs.Connection = con
                cmdlogs.Parameters.AddWithValue("@Username", FrmMain.User)
                cmdlogs.Parameters.AddWithValue("@Action", FrmMain.User & " " & "Deleted files.")
                cmdlogs.Parameters.AddWithValue("@ActionDate", DateTime.Now)
                cmdlogs.ExecuteNonQuery()
                con.Close()


                Me.VwRemovalTableAdapter.Fill(Me.DMSDataSet.vwRemoval)

                AxAcroPDF1.LoadFile("NOTEXISTING.pdf")
                MessageBox.Show("Files Deleted.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Catch ex As Exception
                MessageBox.Show(ex.Message)

            Finally

                AddHandler IdTextBox.TextChanged, AddressOf IdTextBox_TextChanged

            End Try

        End If


    End Sub

    Private Sub IdTextBox_TextChanged(sender As Object, e As EventArgs) Handles IdTextBox.TextChanged
        Try

            If IdTextBox.Text = "" Then

            Else
                'Me.SpForRemovalTableAdapter.Fill(Me.DMSDataSet.spForRemoval, Me.IdTextBox.Text)
                AxAcroPDF1.src = (My.Settings.ImgPath & "\" & Me.VwRemovalC1TrueDBGrid.Columns("FileName").Text)

                'Dim pdffile As String = IIf(IdTextBox.Text = "", (""), (My.Settings.ImgPath & "\" & Me.VwRemovalC1TrueDBGrid.Columns("FileName").Text))
                'WebBrowser1.Navigate(pdffile)

                Me.SpForRemovalTableAdapter.Fill(Me.DMSDataSet.spForRemoval, Me.VwRemovalC1TrueDBGrid.Columns("ID").Text)

            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SplitContainer3_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer3.Panel2.Paint

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnRestore.Click
        Dim MsgDelete = MessageBox.Show("Are you sure to restore selected documents", "Restore?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgDelete = vbYes Then

            Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
            Dim cmdlogs As New SqlCommand("INSERT INTO DMSLogs(Username, Action, ActionDate) VALUES (@Username, @Action, @ActionDate)", con)
            Dim cmd As New SqlCommand

            cmd.Parameters.AddWithValue("@ID", "")
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "spRestoreRemoval"
            cmd.CommandType = CommandType.StoredProcedure



            Try
                ' Dim FilePath As String
                ' If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then

                VwRemovalBindingSource.MoveFirst()

                For i = 0 To Me.VwRemovalBindingSource.Count - 1

                    If Me.VwRemovalC1TrueDBGrid.Columns("Select").Value = True Then

                        cmd.Parameters("@ID").Value = Me.VwRemovalC1TrueDBGrid.Columns("ID").Text
                        cmd.ExecuteNonQuery()
                        'My.Computer.FileSystem.DeleteFile(Path.Combine(My.Settings.ImgPath, Me.VwRemovalC1TrueDBGrid.Columns("FileName").Text))
                    End If
                    VwRemovalBindingSource.MoveNext()
                Next


                ' Dim dRemoteDate As Date
                '  dRemoteDate = GetNetRemoteTOD(My.Settings.remoteTOD)


                cmdlogs.Connection = con
                cmdlogs.Parameters.AddWithValue("@Username", FrmMain.User)
                cmdlogs.Parameters.AddWithValue("@Action", FrmMain.User & " " & "Restored files.")
                cmdlogs.Parameters.AddWithValue("@ActionDate", DateTime.Now)
                cmdlogs.ExecuteNonQuery()
                con.Close()


                Me.VwRemovalTableAdapter.Fill(Me.DMSDataSet.vwRemoval)
                MessageBox.Show("Files Restored.", "Restore", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub
End Class