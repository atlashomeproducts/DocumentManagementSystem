
Imports System.ComponentModel
Imports System.Configuration
Imports System.Data.SqlClient



Public Class FrmMain


    Public type As String
    Public User As String

    Private Sub DocumentManagementToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub TerminateProgramToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub IndexToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DocumentTypesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmDocument.Show(Me)
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.SelectTab(TabLogin)

        Me.AcceptButton = BtnOK
        Me.CancelButton = BtnCancel
        Me.TxtUsername.Focus()










        TabControl1.Appearance = TabAppearance.FlatButtons
            TabControl1.ItemSize = New Size(0, 1)
            TabControl1.SizeMode = TabSizeMode.Fixed

            For Each TabPage In TabControl1.TabPages

                TabPage.Text = ""

            Next









    End Sub

    Public Sub MinimizeAllChildren()
        Dim f As Form
        For Each f In Me.MdiChildren
            f.WindowState = FormWindowState.Minimized
        Next f
    End Sub

    Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    'Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
    '    Get
    '        Dim myCp As CreateParams = MyBase.CreateParams
    '        myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
    '        Return myCp
    '    End Get
    'End Property

    Private Sub QueryToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IndexToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub FrmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        My.Settings.Save_RackNoTS = ""
        My.Settings.Save_BoxNoTS = ""
        My.Settings.Save_RackNoRI = ""
        My.Settings.Save_BoxNoRI = ""
        My.Settings.Save_BookletNoRI = ""
        My.Settings.Save_RackNoWarranty = ""
        My.Settings.Save_BoxNoWarranty = ""
        My.Settings.Save_RackNoVoucher = ""
        My.Settings.Save_BoxNoVoucher = ""
        My.Settings.Save_RackNoCorpDocu = ""
        My.Settings.Save_BoxNoCorpDocu = ""


        My.Settings.Save()



        End
    End Sub



    Private Sub EditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditorToolStripMenuItem.Click
        FrmEditor.Show(Me)

    End Sub

    Private Sub SEARCHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SEARCHToolStripMenuItem.Click
        FrmSearch2.Show(Me)
    End Sub

    Private Sub IndexFilesToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles IndexFilesToolStripMenuItem.Click
        FrmIndex.Show(Me)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnOK.Click

        Try
            Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
            Dim cmd As New SqlCommand("SELECT UserName, Password, UserType FROM DMSUser WHERE (UserName = '" & Me.TxtUsername.Text & "') AND (Password = '" & Me.TxtPassword.Text & "')", con)
            con.Open()



            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            ' If the record can be queried, it means passing verification, then open another form.
            If (sdr.Read() = True) Then

                type = sdr!UserType
                User = StrConv(TxtUsername.Text, VbStrConv.ProperCase)
                'Dim usertxt As String = TxtUsername.Text
                'usertxt = StrConv(usertxt, VbStrConv.ProperCase)
                Me.LblUser.Text = "Logged in as:" & User

                If Type = "Administrator" Then
                    TabControl1.SelectTab(TabMain)



                ElseIf Type = "User" Then
                    TabControl1.SelectTab(TabMain)
                    UserManagementToolStripMenuItem.Visible = False
                    Me.ToolStripMenuItem4.Visible = False

                Else

                    TabControl1.SelectTab(TabMain)
                    UserManagementToolStripMenuItem.Visible = False
                    Me.ToolStripMenuItem4.Visible = False

                End If


            Else

                MessageBox.Show("Invalid Username or Password. Please try again.", "User Not Found!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)


                Me.TxtUsername.SelectAll()
                Me.TxtUsername.Focus()
                Me.TxtPassword.Clear()

            End If


            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try




        Dim con2 As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
        Dim cmd2 As New SqlCommand

        Try

            con2.Open()

            cmd2.Connection = con2
            cmd2.CommandText = " INSERT INTO DMSLogs(Username, Action, ActionDate) VALUES (@Username, @Action, @ActionDate)"
            cmd2.Parameters.AddWithValue("@Username", User)
            cmd2.Parameters.AddWithValue("@Action", User & " " & "logged in")
            cmd2.Parameters.AddWithValue("@ActionDate", DateTime.Now)

            cmd2.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con2.Close()
        End Try



        Me.SpDMSTotalsTableAdapter.Fill(Me.DMSDataSet.spDMSTotals)
        Me.SpDMSLogsTableAdapter.Fill(Me.DMSDataSet.spDMSLogs, Me.DateTimePicker1.Value, Me.DateTimePicker2.Value)

        Me.DateTimePicker1.Value = Date.Now.ToShortDateString
        Me.DateTimePicker2.Value = Date.Now.ToShortDateString
        Timer1.Enabled = True
        Timer1.Interval = 3000



    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        End
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ChkShow.CheckedChanged
        If Me.ChkShow.Checked = True Then
            TxtPassword.PasswordChar = ""

        Else
            TxtPassword.PasswordChar = "*"
        End If
    End Sub
    Private Sub UserManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserManagementToolStripMenuItem.Click
        FrmUsers.Show(Me)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.SpDMSTotalsTableAdapter.Fill(Me.DMSDataSet.spDMSTotals)
        Me.SpDMSLogsTableAdapter.Fill(Me.DMSDataSet.spDMSLogs, DateTimePicker1.Value, DateTimePicker2.Value)
    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Try


            Me.SpDMSTotalsTableAdapter.Fill(Me.DMSDataSet.spDMSTotals)
            Me.SpDMSLogsTableAdapter.Fill(Me.DMSDataSet.spDMSLogs, Me.DateTimePicker1.Value, Me.DateTimePicker2.Value)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Try


            Me.SpDMSTotalsTableAdapter.Fill(Me.DMSDataSet.spDMSTotals)
            Me.SpDMSLogsTableAdapter.Fill(Me.DMSDataSet.spDMSLogs, Me.DateTimePicker1.Value, Me.DateTimePicker2.Value)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TabLogin_Click(sender As Object, e As EventArgs) Handles TabLogin.Click

    End Sub
End Class
