
Public Class FrmMain
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

    Private Sub IndexFilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndexFilesToolStripMenuItem.Click
        FrmIndex.Show(Me)
    End Sub

    Private Sub EditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditorToolStripMenuItem.Click
        FrmEditor.Show(Me)

    End Sub

    Private Sub SEARCHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SEARCHToolStripMenuItem.Click
        FrmQuery.Show(Me)
    End Sub
End Class
