Public Class FrmChanges
    Private Sub FrmChanges_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Format
        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.SizeMode = TabSizeMode.Fixed
        For Each TabPage In TabControl1.TabPages

            TabPage.Text = ""

        Next



        TabControl2.Appearance = TabAppearance.FlatButtons
        TabControl2.ItemSize = New Size(0, 1)
        TabControl2.SizeMode = TabSizeMode.Fixed
        For Each TabPage In TabControl2.TabPages

            TabPage.Text = ""

        Next
    End Sub
End Class