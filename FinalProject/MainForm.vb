Option Strict On
Imports System.IO




Public Class frmMain
    Private tbTextInput As Object

    Private Sub mnuFile_Click(sender As Object, e As EventArgs) Handles mnuFile.Click

    End Sub

    Private Sub mnuNew_Click(sender As Object, e As EventArgs) Handles mnuNew.Click

        Dim TextEditorForm As New frmTextEditor
        TextEditorForm.MdiParent = Me
        TextEditorForm.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        TextEditorForm.Show()

    End Sub

    Private Sub mnuOpen_Click(sender As Object, e As EventArgs) Handles mnuOpen.Click


        Dim TextEditorForm As New frmTextEditor
        TextEditorForm.MdiParent = Me

        Dim openDialog As New OpenFileDialog
        Dim file As String
        openDialog.ShowDialog()
        file = openDialog.FileName

        Dim streamRead As New System.IO.StreamReader(file)
        'Dim tbTextInput As Object = Nothing
        'tbTextInput.MdiParent = Me
        TextEditorForm.tbTextInput.Text = streamRead.ReadToEnd()

        streamRead.Close()
        TextEditorForm.Show()

    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click

        Dim TextEditorForm As New frmTextEditor
        TextEditorForm.MdiParent = Me

        Dim saveDialog As New SaveFileDialog
        Dim saveFile As String
        saveFile = ""
        'saveFile(TextEditorForm.tbTextInput)
        saveDialog.ShowDialog()
        'saveDialog.ShowDialog()
        Dim streamWrite As New System.IO.StreamWriter(saveFile)
        streamWrite.Write(TextEditorForm.tbTextInput.Text)

        streamWrite.Close()

    End Sub

    Private Sub mnuSaveAs_Click(sender As Object, e As EventArgs) Handles mnuSaveAs.Click

    End Sub

    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click

        Dim activeForm As Form = Me.ActiveMdiChild
        If activeForm IsNot Nothing Then
            activeForm.Close()
        End If

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click

        Application.Exit()

    End Sub

    Private Sub mnuEdit_Click(sender As Object, e As EventArgs) Handles mnuEdit.Click

    End Sub

    Private Sub mnuCut_Click(sender As Object, e As EventArgs) Handles mnuCut.Click

        'Dim TextEditorForm As New frmTextEditor
        'TextEditorForm.MdiParent = Me

        'My.Computer.Clipboard.SetText(TextEditorForm.tbTextInput.SelectedText)
        'TextEditorForm.tbTextInput.SelectedText = ""

        'My.Computer.Clipboard.SetDataObject(CType(tbTextInput, SelectedText))
        'TextEditorForm.tbTextInput.SelectedText = ""

        'Clipboard.SetDataObject(tbTextInput.SelectedText)

        Dim TextEditorForm As frmTextEditor = CType(Me.ActiveMdiChild, frmTextEditor)

        Clipboard.SetDataObject(TextEditorForm.tbTextInput.SelectedText)
        TextEditorForm.tbTextInput.SelectedText = ""

    End Sub

    Private Sub mnuCopy_Click(sender As Object, e As EventArgs) Handles mnuCopy.Click

        Dim TextEditorForm As frmTextEditor = CType(Me.ActiveMdiChild, frmTextEditor)

        Clipboard.SetDataObject(TextEditorForm.tbTextInput.SelectedText)



    End Sub

    Private Sub mnuPaste_Click(sender As Object, e As EventArgs) Handles mnuPaste.Click

    End Sub

    Private Sub mnuWindows_Click(sender As Object, e As EventArgs) Handles mnuWindows.Click

    End Sub

    Private Sub mnuCascade_Click(sender As Object, e As EventArgs) Handles mnuCascade.Click

        Me.LayoutMdi(MdiLayout.Cascade)

    End Sub

    Private Sub mnuTileVertical_Click(sender As Object, e As EventArgs) Handles mnuTileVertical.Click

        Me.LayoutMdi(MdiLayout.TileVertical)

    End Sub

    Private Sub mnuTileHorizontal_Click(sender As Object, e As EventArgs) Handles mnuTileHorizontal.Click

        Me.LayoutMdi(MdiLayout.TileHorizontal)

    End Sub

    Private Sub mnuAverageUnits_Click(sender As Object, e As EventArgs) Handles mnuAverageUnits.Click

        Dim UnitForm As New frmUnit
        UnitForm.MdiParent = Me

        UnitForm.Show()

    End Sub

    Private Sub mnuHelp_Click(sender As Object, e As EventArgs) Handles mnuHelp.Click

    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click

        MessageBox.Show("NETD-2202" & vbCrLf & "Final Project" & vbCrLf & "J. Lopez", "About", MessageBoxButtons.OK)

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        Dim TextEditorForm As New frmTextEditor
        TextEditorForm.MdiParent = Me
        TextEditorForm.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
        TextEditorForm.Show()


    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click

        Dim TextEditorFrom As New frmTextEditor
        TextEditorFrom.MdiParent = Me

        Dim openDialog As New OpenFileDialog
        Dim file As String
        openDialog.ShowDialog()
        file = openDialog.FileName

        Dim streamRead As New System.IO.StreamReader(file)
        'Dim tbTextInput As Object = Nothing
        'tbTextInput.MdiParent = Me
        TextEditorFrom.tbTextInput.Text = streamRead.ReadToEnd()

        streamRead.Close()
        TextEditorFrom.Show()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub
End Class
