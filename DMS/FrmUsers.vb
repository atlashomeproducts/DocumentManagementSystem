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

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click

        If TxtUsername.Text = "" Or TxtName.Text = "" Or TxtPassword.Text = "" Or TxtRetype.Text = "" Or TxtUsertype.Text = "" Then


            MessageBox.Show("Please complete all the required fields.", "Incomplete Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else


            Try

                If TxtPassword.Text = TxtRetype.Text Then

                    Me.DMSUserBindingSource.AddNew()


                    Me.DMSUserC1TrueDBGrid.Columns("Username").Text = Me.TxtUsername.Text
                    Me.DMSUserC1TrueDBGrid.Columns("Name").Text = Me.TxtName.Text
                    Me.DMSUserC1TrueDBGrid.Columns("Password").Text = Me.TxtPassword.Text
                    Me.DMSUserC1TrueDBGrid.Columns("Usertype").Text = Me.TxtUsertype.Text

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

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
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

    Private Sub TxtUsername_TextChanged(sender As Object, e As EventArgs) Handles TxtUsername.TextChanged

    End Sub

    Private Sub TxtUsername_GotFocus(sender As Object, e As EventArgs) Handles TxtUsername.GotFocus
        TxtUsername.BackColor = Color.LightYellow
    End Sub

    Private Sub TxtUsername_LostFocus(sender As Object, e As EventArgs) Handles TxtUsername.LostFocus
        TxtUsername.BackColor = Color.White
    End Sub

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles TxtName.TextChanged

    End Sub

    Private Sub TxtName_GotFocus(sender As Object, e As EventArgs) Handles TxtName.GotFocus
        TxtUsername.BackColor = Color.LightYellow

    End Sub

    Private Sub TxtName_LostFocus(sender As Object, e As EventArgs) Handles TxtName.LostFocus
        TxtUsername.BackColor = Color.White
    End Sub

    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged

    End Sub

    Private Sub TxtPassword_GotFocus(sender As Object, e As EventArgs) Handles TxtPassword.GotFocus
        TxtPassword.BackColor = Color.LightYellow
    End Sub

    Private Sub TxtPassword_LostFocus(sender As Object, e As EventArgs) Handles TxtPassword.LostFocus
        TxtPassword.BackColor = Color.White
    End Sub

    Private Sub TxtRetype_TextChanged(sender As Object, e As EventArgs) Handles TxtRetype.TextChanged

    End Sub

    Private Sub TxtRetype_GotFocus(sender As Object, e As EventArgs) Handles TxtRetype.GotFocus
        TxtRetype.BackColor = Color.LightYellow
    End Sub

    Private Sub TxtRetype_LostFocus(sender As Object, e As EventArgs) Handles TxtRetype.LostFocus
        TxtRetype.BackColor = Color.White
    End Sub
End Class