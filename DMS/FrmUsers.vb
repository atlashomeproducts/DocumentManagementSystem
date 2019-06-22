Imports C1.Win.C1TrueDBGrid

Public Class FrmUsers
    Private Sub DMSUserBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub FrmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DMSDataSet.DMSUser' table. You can move, or remove it, as needed.
        Me.DMSUserTableAdapter.Fill(Me.DMSDataSet.DMSUser)


        Me.DMSUserC1TrueDBGrid.Splits(0).DisplayColumns("Password").Visible = False


        Me.DMSUserC1TrueDBGrid.Splits(0).DisplayColumns("Username").Locked = True





    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        If txtUsername.Text = "" Or txtName.Text = "" Or txtPassword.Text = "" Or txtRetype.Text = "" Or txtUsertype.Text = "" Then


            MessageBox.Show("Please complete all the required fields.", "Incomplete Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else


            Try

                If txtPassword.Text = txtRetype.Text Then

                    Me.DMSUserBindingSource.AddNew()


                    Me.DMSUserC1TrueDBGrid.Columns("Username").Text = Me.txtUsername.Text
                    Me.DMSUserC1TrueDBGrid.Columns("Name").Text = Me.txtName.Text
                    Me.DMSUserC1TrueDBGrid.Columns("Password").Text = Me.txtPassword.Text
                    Me.DMSUserC1TrueDBGrid.Columns("Usertype").Text = Me.txtUsertype.Text

                    Me.Validate()
                    Me.DMSUserBindingSource.EndEdit()
                    Me.DMSUserTableAdapter.Update(Me.DMSDataSet.DMSUser)

                    '   MessageBox.Show("Successfully Saved!!", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information)


                Else

                    MessageBox.Show("""Password"" and ""Retype Password"" does not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)


                End If



            Catch ex As Exception
                MessageBox.Show("Error inserting records.." & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try

        End If


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim MsgDelete = MessageBox.Show("Delete User?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgDelete = vbYes Then

            Me.DMSUserBindingSource.RemoveCurrent()
            Me.Validate()
            Me.DMSUserBindingSource.EndEdit()
            Me.DMSUserTableAdapter.Update(Me.DMSDataSet.DMSUser)


        ElseIf MsgDelete = vbNo Then

        End If


    End Sub

    Private Sub DMSUserC1TrueDBGrid_Click(sender As Object, e As EventArgs) Handles DMSUserC1TrueDBGrid.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked = True Then
            Me.DMSUserC1TrueDBGrid.Splits(0).DisplayColumns("Password").Visible = True
        Else
            Me.DMSUserC1TrueDBGrid.Splits(0).DisplayColumns("Password").Visible = False
        End If

    End Sub

    Private Sub DMSUserC1TrueDBGrid_AfterColEdit(sender As Object, e As ColEventArgs) Handles DMSUserC1TrueDBGrid.AfterColEdit
        Try


            Me.Validate()
            Me.DMSUserBindingSource.EndEdit()
            Me.DMSUserTableAdapter.Update(Me.DMSDataSet.DMSUser)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class