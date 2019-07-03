Public Class frmDocument
    Private Sub DocumentTypesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DocumentTypesBindingNavigatorSaveItem.Click

        Try


            Me.Validate()
            Me.DocumentTypesBindingSource.EndEdit()
            Me.DocumentTypesTableAdapter.Update(Me.DMSDataSet.DocumentTypes)

            MessageBox.Show("Successfuly 
!!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub FrmDocument_Load(sender As Object, e As EventArgs) Handles MyBase.Load





        Me.DocumentTypesTableAdapter.Fill(Me.DMSDataSet.DocumentTypes)





    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub C1TrueDBDropdown1_Click(sender As Object, e As EventArgs)

    End Sub
End Class