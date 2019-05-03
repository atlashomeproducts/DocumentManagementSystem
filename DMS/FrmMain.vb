
Public Class FrmMain
    Private Sub DocumentManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentManagementToolStripMenuItem.Click


        FrmEditor.Show(Me)

    End Sub

    Private Sub TerminateProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TerminateProgramToolStripMenuItem.Click
        End
    End Sub

    Private Sub IndexToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IndexToolStripMenuItem1.Click
        FrmIndex.Show(Me)
    End Sub



    Private Sub DocumentTypesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentTypesToolStripMenuItem.Click

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
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
            Return myCp
        End Get
    End Property

    Private Sub QueryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QueryToolStripMenuItem.Click
        frmQuery.Show()
    End Sub

    Private Sub IndexToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndexToolStripMenuItem.Click

    End Sub
End Class
