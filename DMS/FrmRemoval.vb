Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO
Imports C1.Win.C1TrueDBGrid

Public Class FrmRemoval
    Private Sub FrmRemoval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DMSDataSet.vwRemoval' table. You can move, or remove it, as needed.
        Me.VwRemovalTableAdapter.Fill(Me.DMSDataSet.vwRemoval)

        Me.VwRemovalC1TrueDBGrid.Columns("Select").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox



        For i = 0 To VwRemovalBindingSource.Count
            Me.VwRemovalC1TrueDBGrid.Columns("Select").Value = False
            VwRemovalBindingSource.MoveNext()
        Next


        Me.VwRemovalC1TrueDBGrid.Splits(0).DisplayColumns("Filename").Locked = True
        Me.VwRemovalC1TrueDBGrid.Splits(0).DisplayColumns("DocumentType").Locked = True


    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub VwRemovalC1TrueDBGrid_Click(sender As Object, e As EventArgs) Handles VwRemovalC1TrueDBGrid.Click
        Try
            Me.SpForRemovalTableAdapter.Fill(Me.DMSDataSet.spForRemoval, Me.VwRemovalC1TrueDBGrid.Columns("ID").Text)
            AcroReader1.src = (My.Settings.ImgPath & "\" & Me.VwRemovalC1TrueDBGrid.Columns("FileName").Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub VwRemovalC1TrueDBGrid_SelChange(sender As Object, e As CancelEventArgs) Handles VwRemovalC1TrueDBGrid.SelChange
        Try
            Me.SpForRemovalTableAdapter.Fill(Me.DMSDataSet.spForRemoval, Me.VwRemovalC1TrueDBGrid.Columns("ID").Text)
            AcroReader1.src = (My.Settings.ImgPath & "\" & Me.VwRemovalC1TrueDBGrid.Columns("FileName").Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnSelectAll.Click
        For i = 0 To VwRemovalBindingSource.Count
            VwRemovalBindingSource.MoveFirst()
            Me.VwRemovalC1TrueDBGrid.Columns("Select").Value = True
            VwRemovalBindingSource.MoveNext()
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnDeselectAll.Click
        For i = 0 To VwRemovalBindingSource.Count
            VwRemovalBindingSource.MoveFirst()
            Me.VwRemovalC1TrueDBGrid.Columns("Select").Value = False
            VwRemovalBindingSource.MoveNext()
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim MsgDelete = MessageBox.Show("Are you sure to remove selected documents", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgDelete = vbYes Then

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

                VwRemovalBindingSource.Position = 0
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

                MessageBox.Show("Files Deleted.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.VwRemovalTableAdapter.Fill(Me.DMSDataSet.vwRemoval)
                Me.SpForRemovalTableAdapter.Fill(Me.DMSDataSet.spForRemoval, 0)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try



        ElseIf MsgDelete = vbNo Then



        End If


    End Sub
End Class