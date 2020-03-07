﻿
Imports System.ComponentModel
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Threading

Public Class FrmMain


    Public type As String
    Public User As String
    Dim counter As Integer




    'Public con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
    'Public cmd As New SqlCommand("SELECT UserName, Password, UserType FROM DMSUser WHERE (UserName = '" & Me.TxtUsername.Text & "') AND (Password = '" & Me.TxtPassword.Text & "')", con)
    'Public cmdlogs As New SqlCommand(" INSERT INTO DMSLogs(Username, Action, ActionDate) VALUES (@Username, @Action, @ActionDate)", con)

    'Private Declare Unicode Function NetRemoteTOD Lib "netapi32" (<MarshalAs(UnmanagedType.LPWStr)> ByVal ServerName As String, ByRef BufferPtr As IntPtr) As Integer
    'Private Declare Function NetApiBufferFree Lib "netapi32" (ByVal Buffer As IntPtr) As Integer

    'Structure TIME_OF_DAY_INFO
    '    Dim tod_elapsedt As Integer
    '    Dim tod_msecs As Integer
    '    Dim tod_hours As Integer
    '    Dim tod_mins As Integer
    '    Dim tod_secs As Integer
    '    Dim tod_hunds As Integer
    '    Dim tod_timezone As Integer
    '    Dim tod_tinterval As Integer
    '    Dim tod_day As Integer
    '    Dim tod_month As Integer
    '    Dim tod_year As Integer
    '    Dim tod_weekday As Integer
    'End Structure


    'Function GetNetRemoteTOD(ByVal strServerName As String) As Date
    '    Try
    '        Dim iRet As Integer
    '        Dim ptodi As IntPtr
    '        Dim todi As TIME_OF_DAY_INFO
    '        Dim dDate As Date
    '        strServerName = strServerName & vbNullChar
    '        iRet = NetRemoteTOD(strServerName, ptodi)
    '        If iRet = 0 Then
    '            todi = CType(Marshal.PtrToStructure(ptodi, GetType(TIME_OF_DAY_INFO)), TIME_OF_DAY_INFO)
    '            NetApiBufferFree(ptodi)
    '            dDate = DateSerial(todi.tod_year, todi.tod_month, todi.tod_day) + " " + TimeSerial(todi.tod_hours, todi.tod_mins - todi.tod_timezone, todi.tod_secs)
    '            GetNetRemoteTOD = dDate
    '        Else
    '            MsgBox("Error retrieving time")
    '        End If
    '    Catch

    '        Try
    '            GetNetRemoteTOD = Date.Now.ToString("MM/dd/yyyy HH:mm:ss tt")
    '        Catch
    '            MsgBox("Error in GetNetRemoteTOD: " & Err.Description)
    '        End Try

    '    End Try

    '    Return GetNetRemoteTOD
    'End Function

    Private Sub IndexToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DocumentTypesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmDocument.Show(Me)
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TabControl1.SelectTab(TabLogin)
        Me.TxtUsername.Focus()
        Me.AcceptButton = BtnOK
        Me.CancelButton = BtnCancel



        TabControl1.Appearance = TabAppearance.Normal
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.SizeMode = TabSizeMode.Fixed

        For Each TabPage In TabControl1.TabPages

            TabPage.Text = ""
            TabPage.BackColor = Color.Azure

        Next

        TxtQueue.ReadOnly = True






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




        If User = "" Then
            Else


                Try


                    Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
                    Dim cmdlogs As New SqlCommand(" INSERT INTO DMSLogs(Username, Action, ActionDate) VALUES (@Username, @Action, @ActionDate)", con)
                    '   Dim dRemoteDate As Date
                    ' dRemoteDate = GetNetRemoteTOD(My.Settings.remoteTOD)


                    con.Open()
                    cmdlogs.Connection = con
                    cmdlogs.Parameters.AddWithValue("@Username", User)
                    cmdlogs.Parameters.AddWithValue("@Action", User & " " & "Logged Out")
                    cmdlogs.Parameters.AddWithValue("@ActionDate", DateTime.Now)
                    cmdlogs.ExecuteNonQuery()
                    con.Close()


                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try



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

            '  FrmSearch2.C1TrueDBGrid2.SaveLayout("default1.layout")
            End
        End If

    End Sub



    Private Sub EditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditorToolStripMenuItem.Click


        Try


            Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
            Dim cmdlogs As New SqlCommand(" INSERT INTO DMSLogs(Username, Action, ActionDate) VALUES (@Username, @Action, @ActionDate)", con)
            '   Dim dRemoteDate As Date
            ' dRemoteDate = GetNetRemoteTOD(My.Settings.remoteTOD)


            con.Open()
            cmdlogs.Connection = con
            cmdlogs.Parameters.AddWithValue("@Username", User)
            cmdlogs.Parameters.AddWithValue("@Action", User & " " & "Opened ""Editor"" form")
            cmdlogs.Parameters.AddWithValue("@ActionDate", DateTime.Now)
            cmdlogs.ExecuteNonQuery()
            con.Close()

            FrmEditor.Show(Me)

            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SEARCHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SEARCHToolStripMenuItem.Click

        Try


            Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
            Dim cmdlogs As New SqlCommand(" INSERT INTO DMSLogs(Username, Action, ActionDate) VALUES (@Username, @Action, @ActionDate)", con)
            '   Dim dRemoteDate As Date
            ' dRemoteDate = GetNetRemoteTOD(My.Settings.remoteTOD)


            con.Open()
            cmdlogs.Connection = con
            cmdlogs.Parameters.AddWithValue("@Username", User)
            cmdlogs.Parameters.AddWithValue("@Action", User & " " & "Opened ""Search"" form")
            cmdlogs.Parameters.AddWithValue("@ActionDate", DateTime.Now)
            cmdlogs.ExecuteNonQuery()
            con.Close()

            FrmSearch2.Show(Me)

            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub IndexFilesToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles IndexFilesToolStripMenuItem.Click

        Try


            Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
            Dim cmdlogs As New SqlCommand(" INSERT INTO DMSLogs(Username, Action, ActionDate) VALUES (@Username, @Action, @ActionDate)", con)
            '   Dim dRemoteDate As Date
            ' dRemoteDate = GetNetRemoteTOD(My.Settings.remoteTOD)


            con.Open()
            cmdlogs.Connection = con
            cmdlogs.Parameters.AddWithValue("@Username", User)
            cmdlogs.Parameters.AddWithValue("@Action", User & " " & "Opened ""Index"" form")
            cmdlogs.Parameters.AddWithValue("@ActionDate", DateTime.Now)
            cmdlogs.ExecuteNonQuery()
            con.Close()

            FrmIndex.Show(Me)

            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnOK.Click

        Try
            Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
            Dim cmd As New SqlCommand("SELECT UserName, Password, UserType FROM DMSUser WHERE (UserName = '" & Me.TxtUsername.Text & "') AND (Password = '" & Me.TxtPassword.Text & "')", con)
            Dim cmdlogs As New SqlCommand(" INSERT INTO DMSLogs(Username, Action, ActionDate) VALUES (@Username, @Action, @ActionDate)", con)
            '  Dim dRemoteDate As Date
            ' dRemoteDate = GetNetRemoteTOD(My.Settings.remoteTOD)

            con.Open()

            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            ' If the record can be queried, it means passing verification, then open another form.
            If (sdr.Read() = True) Then

                type = sdr!UserType
                User = StrConv(TxtUsername.Text, VbStrConv.ProperCase)

                Me.LblUser.Text = "Logged in as:" & User

                If type = "System Admin" Then
                    TabControl1.SelectTab(TabMain)

                ElseIf type = "Admin" Then
                    TabControl1.SelectTab(TabMain)
                    UserManagementToolStripMenuItem.Visible = False
                    Me.ToolStripMenuItem4.Visible = False

                ElseIf type = "Editor" Then
                    TabControl1.SelectTab(TabMain)
                    UserManagementToolStripMenuItem.Visible = False
                    RemovalToolStripMenuItem6.Visible = False
                    ToolStripMenuItem4.Visible = False
                    ToolStripMenuItem7.Visible = False

                ElseIf type = "User 1" Then
                    TabControl1.SelectTab(TabMain)
                    UserManagementToolStripMenuItem.Visible = False
                    EditorToolStripMenuItem.Visible = False
                    IndexFilesToolStripMenuItem.Visible = False
                    RemovalToolStripMenuItem6.Visible = False
                    Me.ToolStripMenuItem1.Visible = False
                    Me.ToolStripMenuItem2.Visible = False
                    Me.ToolStripMenuItem3.Visible = False
                    Me.ToolStripMenuItem4.Visible = False
                    Me.ToolStripMenuItem5.Visible = False
                ElseIf type = "User 2" Then
                    TabControl1.SelectTab(TabMain)
                    UserManagementToolStripMenuItem.Visible = False
                    EditorToolStripMenuItem.Visible = False
                    IndexFilesToolStripMenuItem.Visible = False
                    RemovalToolStripMenuItem6.Visible = False
                    Me.ToolStripMenuItem1.Visible = False
                    Me.ToolStripMenuItem2.Visible = False
                    Me.ToolStripMenuItem3.Visible = False
                    Me.ToolStripMenuItem4.Visible = False
                    Me.ToolStripMenuItem5.Visible = False
                Else
                    TabControl1.SelectTab(TabMain)
                    UserManagementToolStripMenuItem.Visible = False
                    EditorToolStripMenuItem.Visible = False
                    IndexFilesToolStripMenuItem.Visible = False
                    RemovalToolStripMenuItem6.Visible = False
                    Me.ToolStripMenuItem1.Visible = False
                    Me.ToolStripMenuItem2.Visible = False
                    Me.ToolStripMenuItem3.Visible = False
                    Me.ToolStripMenuItem4.Visible = False
                    Me.ToolStripMenuItem5.Visible = False
                End If

                con.Close()


                con.Open()
                cmdlogs.Connection = con
                cmdlogs.Parameters.AddWithValue("@Username", User)
                cmdlogs.Parameters.AddWithValue("@Action", User & " " & "Logged In")
                cmdlogs.Parameters.AddWithValue("@ActionDate", DateTime.Now)
                cmdlogs.ExecuteNonQuery()
                con.Close()

            Else

                MessageBox.Show("Invalid Username or Password. Please try again.", "User Not Found!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)


                Me.TxtUsername.SelectAll()
                Me.TxtUsername.Focus()
                Me.TxtPassword.Clear()

                con.Close()

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try




        'Dim con2 As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
        'Dim cmd2 As New SqlCommand

        'Try

        '    con2.Open()

        '    cmd2.Connection = con2
        '    cmd2.CommandText = " INSERT INTO DMSLogs(Username, Action, ActionDate) VALUES (@Username, @Action, @ActionDate)"
        '    cmd2.Parameters.AddWithValue("@Username", User)
        '    cmd2.Parameters.AddWithValue("@Action", User & " " & "logged in")
        '    cmd2.Parameters.AddWithValue("@ActionDate", DateTime.Now)

        '    cmd2.ExecuteNonQuery()


        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'Finally
        '    con2.Close()
        'End Try



        Me.SpDMSTotalsTableAdapter.Fill(Me.DMSDataSet.spDMSTotals)
        Me.SpDMSLogsTableAdapter.Fill(Me.DMSDataSet.spDMSLogs, Me.DateTimePicker1.Value, Me.DateTimePicker2.Value)

        Me.DateTimePicker1.Value = Date.Now.ToShortDateString
        Me.DateTimePicker2.Value = Date.Now.ToShortDateString
        Timer1.Enabled = True
        Timer1.Interval = 3000



        'Dim thread As New Thread(
        'Sub()
        '    counter = Directory.GetFiles(My.Settings.Queue, "*.pdf", SearchOption.AllDirectories).Length

        'End Sub
        '                            )
        'thread.Start()





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

        'Dim thread1 As New Thread(AddressOf TotalsThread)
        'thread1.IsBackground = True
        'thread1.Start()

        Me.SpDMSTotalsTableAdapter.Fill(Me.DMSDataSet.spDMSTotals)
        Me.SpDMSTotalsBindingSource.MoveLast()
        Me.SpDMSLogsTableAdapter.Fill(Me.DMSDataSet.spDMSLogs, DateTimePicker1.Value, DateTimePicker2.Value)
        Me.SpDMSLogsBindingSource.MoveLast()

        TxtQueue.Text = counter




    End Sub

    'Sub TotalsThread()
    '    Me.SpDMSTotalsTableAdapter.Fill(Me.DMSDataSet.spDMSTotals)
    '    Me.SpDMSTotalsBindingSource.MoveLast()
    '    Me.SpDMSLogsTableAdapter.Fill(Me.DMSDataSet.spDMSLogs, DateTimePicker1.Value, DateTimePicker2.Value)
    '    Me.SpDMSLogsBindingSource.MoveLast()
    'End Sub






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

    Private Sub FrmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.TxtUsername.Focus()
    End Sub

    Private Sub SIDEPANELToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If SplitContainer1.Panel2Collapsed = False Then

            SplitContainer1.Panel2Collapsed = True

        ElseIf SplitContainer1.Panel2Collapsed = True Then
            SplitContainer1.Panel2Collapsed = False

        End If

    End Sub

    Private Sub TxtUsername_TextChanged(sender As Object, e As EventArgs) Handles TxtUsername.TextChanged

    End Sub

    Private Sub btnDock_Click(sender As Object, e As EventArgs) Handles btnDock.Click
        If SplitContainer1.Panel2Collapsed = False Then

            SplitContainer1.Panel2Collapsed = True
            btnDock.Text = "Undock"

        ElseIf SplitContainer1.Panel2Collapsed = True Then
            SplitContainer1.Panel2Collapsed = False
            btnDock.Text = "Dock"

        End If
    End Sub

    Private Sub IndexFilesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EditorToolStripMenuItem_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub SEARCHToolStripMenuItem_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub UserManagementToolStripMenuItem_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtUsername_GotFocus(sender As Object, e As EventArgs) Handles TxtUsername.GotFocus
        TxtUsername.BackColor = Color.LightYellow
    End Sub

    Private Sub TxtUsername_LostFocus(sender As Object, e As EventArgs) Handles TxtUsername.LostFocus
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

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles TxtQueue.Click

    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs)
        Try

            Dim counter As Integer = Directory.GetFiles(My.Settings.Queue, "*.pdf", SearchOption.AllDirectories).Length
            TxtQueue.Text = counter

            Me.SpDMSTotalsTableAdapter.Fill(Me.DMSDataSet.spDMSTotals)
            Me.SpDMSLogsTableAdapter.Fill(Me.DMSDataSet.spDMSLogs, DateTimePicker1.Value, DateTimePicker2.Value)

            Me.SpDMSTotalsBindingSource.MoveLast()
            Me.SpDMSLogsBindingSource.MoveLast()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Try
            counter = Directory.GetFiles(My.Settings.Queue, "*.pdf", SearchOption.AllDirectories).Length
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripMenuItem6_Click_1(sender As Object, e As EventArgs) Handles RemovalToolStripMenuItem6.Click

        Try


            Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
            Dim cmdlogs As New SqlCommand(" INSERT INTO DMSLogs(Username, Action, ActionDate) VALUES (@Username, @Action, @ActionDate)", con)
            '   Dim dRemoteDate As Date
            ' dRemoteDate = GetNetRemoteTOD(My.Settings.remoteTOD)


            con.Open()
            cmdlogs.Connection = con
            cmdlogs.Parameters.AddWithValue("@Username", User)
            cmdlogs.Parameters.AddWithValue("@Action", User & " " & "Opened ""Removal"" form")
            cmdlogs.Parameters.AddWithValue("@ActionDate", DateTime.Now)
            cmdlogs.ExecuteNonQuery()
            con.Close()

            FrmRemoval.Show(Me)

            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try





    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click


        Dim MessageLogoff = MessageBox.Show("Are you sure you want to log off?", "Log off", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


        If MessageLogoff = vbYes Then


            Try


            Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("DMS.My.MySettings.DMSConnectionString").ConnectionString)
            Dim cmdlogs As New SqlCommand(" INSERT INTO DMSLogs(Username, Action, ActionDate) VALUES (@Username, @Action, @ActionDate)", con)
            '   Dim dRemoteDate As Date
            ' dRemoteDate = GetNetRemoteTOD(My.Settings.remoteTOD)


            con.Open()
            cmdlogs.Connection = con
            cmdlogs.Parameters.AddWithValue("@Username", User)
            cmdlogs.Parameters.AddWithValue("@Action", User & " " & "Logged Out")
            cmdlogs.Parameters.AddWithValue("@ActionDate", DateTime.Now)
            cmdlogs.ExecuteNonQuery()
            con.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



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



        frmDocument.Close()
        FrmEditor.Close()
        FrmIndex.Close()
        FrmReason.Close()
        FrmReason3.Close()
        FrmRemoval.Close()
        FrmSearch2.Close()
        FrmUsers.Close()










            TabControl1.SelectTab(TabLogin)
            'Close all windows and transfer to login tab



            UserManagementToolStripMenuItem.Visible = True
            EditorToolStripMenuItem.Visible = True
            IndexFilesToolStripMenuItem.Visible = True
            RemovalToolStripMenuItem6.Visible = True
            Me.ToolStripMenuItem1.Visible = True
            Me.ToolStripMenuItem2.Visible = True
            Me.ToolStripMenuItem3.Visible = True
            Me.ToolStripMenuItem4.Visible = True
            Me.ToolStripMenuItem5.Visible = True



        End If






    End Sub

    Private Sub ToolStripMenuItem6_Click_2(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem6.Click

    End Sub
End Class
