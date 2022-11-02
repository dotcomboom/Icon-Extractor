Imports TsudaKageyu

Public Class frmMain

    Public filterBits As String = ""
    Public rootPath As String = ".\"
    Public theStruct As String = ""

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ProgressBar1.Maximum = lstPaths.Items.Count

        cmbStruct.Text = "%f icons\%wx%h__%i_%bbit.png"

        If My.Application.CommandLineArgs.Count > 0 Then
            ExtractIcons(My.Application.CommandLineArgs)
            Me.Close()
        End If

        testPath()

        txtParentPath.Text = Environment.CurrentDirectory & "\"

        If Not My.Settings.samples Then
            lstPaths.Items.Clear()
        End If

    End Sub

    Public Sub ExtractIcons(paths)
        Dim p = 1
        For Each path As String In paths
            Dim ext As String = My.Computer.FileSystem.GetFileInfo(path).Extension
            If ext(0) = "." Then
                ext.Remove(0, 1)
            End If
            Dim n As String = My.Computer.FileSystem.GetFileInfo(path).Name.Replace(ext, "")

            ExtractWorker.ReportProgress(p, n)
            p += 1

            'If Not My.Computer.FileSystem.DirectoryExists(n) Then
            '    My.Computer.FileSystem.CreateDirectory(n)
            'End If

            Try
                Dim iextract As New IconExtractor(path)

                Dim reallyCoolIcons = iextract.GetAllIcons()

                Dim index As Integer = 0
                For Each Ico As Icon In reallyCoolIcons
                    Dim s As Icon() = IconUtil.Split(Ico)
                    Dim index2 As Integer = 0
                    For Each i As Icon In s
                        Dim bitCount As String = IconUtil.GetBitCount(i)
                        'If Not My.Computer.FileSystem.DirectoryExists(n & i.Width & "x" & i.Height) Then
                        '    My.Computer.FileSystem.CreateDirectory(n & "\" & i.Width & "x" & i.Height)
                        'End If
                        'IconUtil.ToBitmap(i).Save(n & "\" & i.Width & "x" & i.Height & "\" & index & "_" & bitCount & "bit.png", Imaging.ImageFormat.Png)
                        Dim saveWorthy As Boolean = True
                        If chkFilterSize.Checked And Not (i.Width & "x" & i.Height = filterSize.Text) Then
                            saveWorthy = False
                        End If
                        If chkFilterBits.Checked And Not (bitCount = filterBits) Then
                            saveWorthy = False
                        End If
                        If saveWorthy Then
                            IconUtil.ToBitmap(i).Save(processPath(False, theStruct, n, ext, i.Width, i.Height, bitCount, index))
                        End If
                        index2 += 1
                    Next
                    index += 1
                Next
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Extraction error: " & n)
            End Try

        Next
    End Sub

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        btnStart.Text = "Ok.."
        btnStart.Enabled = False
        ProgressBar1.Maximum = lstPaths.Items.Count
        ExtractWorker.RunWorkerAsync()

    End Sub

    Private Sub ExtractWorker_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles ExtractWorker.DoWork
        ExtractIcons(lstPaths.Items)
    End Sub

    Private Sub ExtractWorker_ProgressChanged(sender As System.Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles ExtractWorker.ProgressChanged
        activeFile.Text = e.UserState
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub ExtractWorker_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles ExtractWorker.RunWorkerCompleted
        activeFile.Text = "Done"
        btnStart.Text = "Start"
        btnStart.Enabled = True
    End Sub

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        Dim itemsToRemove As New ArrayList
        For Each i In lstPaths.SelectedItems
            itemsToRemove.Add(i.ToString)
        Next
        For Each item As String In itemsToRemove
            lstPaths.Items.Remove(lstPaths.SelectedItem)
        Next
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim openfiles As New OpenFileDialog
        openfiles.Multiselect = True
        openfiles.FileName = ""
        openfiles.Filter = "Windows Application or Class Library (*.exe, *.dll)|*.exe;*.dll"
        If openfiles.ShowDialog = Windows.Forms.DialogResult.OK Then
            For Each f In openfiles.FileNames
                lstPaths.Items.Add(f)
            Next
        End If
    End Sub

    Private Function processPath(ByVal Preview As Boolean, ByVal format As String, ByVal filename As String, ByVal extension As String, ByVal width As Integer, ByVal height As Integer, ByVal bit As Integer, ByVal index As Integer)
        Dim a = format
        '%f: source filename
        '%e: extension
        '%w: width
        '%h: height (same most of the time)
        '%b: bit count (4, 8, 32 generally)
        '%i: index
        a = a.Replace("%f", filename)
        a = a.Replace("%e", extension)
        a = a.Replace("%w", width)
        a = a.Replace("%h", height)
        a = a.Replace("%b", bit)
        a = a.Replace("%i", index)
        If Not Preview Then
            'make sure folder exists
            If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.GetParentPath(a)) Then
                My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.GetParentPath(a))
            End If
        End If
        Return a
    End Function

    Private Sub testPath()
        ' Called when file structure textbox changes
        Label2.Text = processPath(True, theStruct, "shell32", "dll", 32, 32, 4, 0)
    End Sub

    Private Sub cmbStruct_TextChanged(sender As System.Object, e As System.EventArgs) Handles cmbStruct.TextChanged
        theStruct = cmbStruct.Text
        testPath()
    End Sub

    Private Sub btnRootFolder_Click(sender As System.Object, e As System.EventArgs) Handles btnRootFolder.Click
        Dim fb As New FolderBrowserDialog
        fb.ShowNewFolderButton = True
        If fb.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtParentPath.Text = fb.SelectedPath & "\"
        End If
    End Sub

    Private Sub cmbFilterBits_TextChanged(sender As System.Object, e As System.EventArgs) Handles cmbFilterBits.TextChanged
        filterBits = cmbFilterBits.Text
    End Sub

    Private Sub chkFilterSize_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkFilterSize.CheckedChanged
        filterSize.Enabled = chkFilterSize.Checked
    End Sub

    Private Sub chkFilterBits_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkFilterBits.CheckedChanged
        cmbFilterBits.Enabled = chkFilterBits.Checked
    End Sub

    Private Sub txtParentPath_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtParentPath.TextChanged
        rootPath = txtParentPath.Text
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frmInfo.Show()
    End Sub
End Class
