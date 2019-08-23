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



    End Sub

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
        Dim cmd As New SqlCommand


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
End Class