Imports System.Configuration
Imports System.Data.SqlClient

Public Class FrmReason
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub DocsRemovalBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DocsRemovalBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DMSDataSet)

    End Sub

    Private Sub FrmReason_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DMSDataSet.DocsRemoval' table. You can move, or remove it, as needed.
        Me.LblID.Text = FrmEditor.IdTextBox.Text

        TxtDupID.Enabled = False
        TxtOthers.Enabled = False




    End Sub

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
        Dim cmd As New SqlCommand
        Dim cmdlogs As New SqlCommand(" INSERT INTO DMSLogs(Username, Action, ActionDate) VALUES (@Username, @Action, @ActionDate)", con)


        If ChkDuplicate.Checked = True And TxtDupID.Text = "" Then

            MessageBox.Show("Please indicate the Document No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)


        Else
            Try

                con.Open()
                cmd.Connection = con
                cmd.CommandText = "spRemovalInsert"
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@ID", LblID.Text)
                cmd.Parameters.AddWithValue("@Duplicate", IIf(ChkDuplicate.Checked = True, "True", "False"))
                cmd.Parameters.AddWithValue("@DuplicateID", TxtDupID.Text)
                cmd.Parameters.AddWithValue("@Old", IIf(ChkOlder.Checked = True, "True", "False"))
                cmd.Parameters.AddWithValue("@NotArchiving", IIf(ChkNotArchiving.Checked = True, "True", "False"))
                cmd.Parameters.AddWithValue("@Others", IIf(ChkOthers.Checked = True, "True", "False"))
                cmd.Parameters.AddWithValue("@OthersReason", TxtOthers.Text)

                cmd.ExecuteNonQuery()


                cmdlogs.Connection = con
                cmdlogs.Parameters.AddWithValue("@Username", FrmMain.User)
                cmdlogs.Parameters.AddWithValue("@Action", FrmMain.User & " " & "Added document no. " + LblID.Text + " for Removal.")
                cmdlogs.Parameters.AddWithValue("@ActionDate", DateTime.Now)
                cmdlogs.ExecuteNonQuery()


                Me.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
            End Try

        End If




    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ChkDuplicate_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDuplicate.CheckedChanged
        If Me.ChkDuplicate.Checked = True Then
            Me.TxtDupID.Enabled = True
        Else
            Me.TxtDupID.Enabled = False
        End If
    End Sub

    Private Sub ChkOthers_CheckedChanged(sender As Object, e As EventArgs) Handles ChkOthers.CheckedChanged
        If Me.ChkDuplicate.Checked = True Then
            Me.TxtOthers.Enabled = True
        Else
            Me.TxtOthers.Enabled = False
        End If
    End Sub
End Class