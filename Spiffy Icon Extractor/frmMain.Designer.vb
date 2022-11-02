<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lstPaths = New System.Windows.Forms.ListBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.activeFile = New System.Windows.Forms.Label()
        Me.ExtractWorker = New System.ComponentModel.BackgroundWorker()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkFilterSize = New System.Windows.Forms.CheckBox()
        Me.chkFilterBits = New System.Windows.Forms.CheckBox()
        Me.cmbFilterBits = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.filterSize = New System.Windows.Forms.MaskedTextBox()
        Me.txtParentPath = New System.Windows.Forms.TextBox()
        Me.btnRootFolder = New System.Windows.Forms.Button()
        Me.cmbStruct = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstPaths
        '
        Me.lstPaths.AllowDrop = True
        Me.lstPaths.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstPaths.FormattingEnabled = True
        Me.lstPaths.ItemHeight = 15
        Me.lstPaths.Items.AddRange(New Object() {"C:\Windows\system32\compstui.dll", "C:\Windows\system32\ddores.dll", "C:\Windows\system32\ieframe.dll", "C:\Windows\system32\imageres.dll", "C:\Windows\system32\mmcndmgr.dll", "C:\Windows\system32\moricons.dll", "C:\Windows\system32\netshell.dll", "C:\Windows\system32\pnidui.dll", "C:\Windows\system32\shell32.dll", "C:\Windows\system32\wmploc.dll", "C:\Windows\system32\pifmgr.dll", "C:\Windows\system32\wpdshext.dll", "C:\Windows\system32\comres.dll", "C:\Windows\system32\dmdskres.dll", "C:\Windows\system32\dsuiext.dll", "C:\Windows\system32\inetcpl.cpl", "C:\Windows\system32\setupapi.dll", "C:\Windows\system32\shdocvw.dll", "C:\Windows\system32\wiashext.dll", "C:\Windows\system32\mmres.dll", "C:\Windows\system32\urlmon.dll", "C:\Windows\explorer.exe"})
        Me.lstPaths.Location = New System.Drawing.Point(14, 14)
        Me.lstPaths.Name = "lstPaths"
        Me.lstPaths.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstPaths.Size = New System.Drawing.Size(336, 304)
        Me.lstPaths.TabIndex = 1
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStart.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Image = CType(resources.GetObject("btnStart.Image"), System.Drawing.Image)
        Me.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStart.Location = New System.Drawing.Point(517, 282)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(84, 39)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "Start"
        Me.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'activeFile
        '
        Me.activeFile.AutoSize = True
        Me.activeFile.Location = New System.Drawing.Point(357, 306)
        Me.activeFile.Name = "activeFile"
        Me.activeFile.Size = New System.Drawing.Size(0, 15)
        Me.activeFile.TabIndex = 4
        '
        'ExtractWorker
        '
        Me.ExtractWorker.WorkerReportsProgress = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(360, 328)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(242, 32)
        Me.ProgressBar1.TabIndex = 5
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Image)
        Me.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemove.Location = New System.Drawing.Point(92, 328)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(80, 32)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(14, 328)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(72, 32)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add..."
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(356, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 90)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "%f: file name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "%e: extension" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "%w: width" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "%h: height (same most of the time)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "%b: " & _
    "bit count (4, 8, 32 generally)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "%i: index"
        '
        'chkFilterSize
        '
        Me.chkFilterSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkFilterSize.AutoSize = True
        Me.chkFilterSize.Location = New System.Drawing.Point(437, 203)
        Me.chkFilterSize.Name = "chkFilterSize"
        Me.chkFilterSize.Size = New System.Drawing.Size(74, 19)
        Me.chkFilterSize.TabIndex = 10
        Me.chkFilterSize.Text = "Filter size"
        Me.chkFilterSize.UseVisualStyleBackColor = True
        '
        'chkFilterBits
        '
        Me.chkFilterBits.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkFilterBits.AutoSize = True
        Me.chkFilterBits.Location = New System.Drawing.Point(437, 229)
        Me.chkFilterBits.Name = "chkFilterBits"
        Me.chkFilterBits.Size = New System.Drawing.Size(103, 19)
        Me.chkFilterBits.TabIndex = 12
        Me.chkFilterBits.Text = "Filter bit count"
        Me.chkFilterBits.UseVisualStyleBackColor = True
        '
        'cmbFilterBits
        '
        Me.cmbFilterBits.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbFilterBits.Enabled = False
        Me.cmbFilterBits.FormattingEnabled = True
        Me.cmbFilterBits.Items.AddRange(New Object() {"1", "4", "8", "24", "32"})
        Me.cmbFilterBits.Location = New System.Drawing.Point(552, 227)
        Me.cmbFilterBits.Name = "cmbFilterBits"
        Me.cmbFilterBits.Size = New System.Drawing.Size(50, 23)
        Me.cmbFilterBits.TabIndex = 13
        Me.cmbFilterBits.Text = "32"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(357, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "placeholder"
        '
        'filterSize
        '
        Me.filterSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.filterSize.Enabled = False
        Me.filterSize.Location = New System.Drawing.Point(552, 201)
        Me.filterSize.Mask = "00x00"
        Me.filterSize.Name = "filterSize"
        Me.filterSize.Size = New System.Drawing.Size(50, 23)
        Me.filterSize.TabIndex = 16
        Me.filterSize.Text = "3232"
        '
        'txtParentPath
        '
        Me.txtParentPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtParentPath.Location = New System.Drawing.Point(360, 109)
        Me.txtParentPath.Name = "txtParentPath"
        Me.txtParentPath.ReadOnly = True
        Me.txtParentPath.Size = New System.Drawing.Size(202, 23)
        Me.txtParentPath.TabIndex = 17
        Me.txtParentPath.Text = ".\"
        '
        'btnRootFolder
        '
        Me.btnRootFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRootFolder.Location = New System.Drawing.Point(568, 109)
        Me.btnRootFolder.Name = "btnRootFolder"
        Me.btnRootFolder.Size = New System.Drawing.Size(34, 23)
        Me.btnRootFolder.TabIndex = 18
        Me.btnRootFolder.Text = "..."
        Me.btnRootFolder.UseVisualStyleBackColor = True
        '
        'cmbStruct
        '
        Me.cmbStruct.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbStruct.FormattingEnabled = True
        Me.cmbStruct.Items.AddRange(New Object() {"icons\%bbit_%wx%h__%f_%i.png", "%f icons\%i__%wx%h_%bbit.png", "%f icons\%wx%h__%i_%bbit.png", "%f icons\%wx%h\%i_%bbit.png", "%f icons\%i\%wx%h_%bbit.png", "%bbit\%f_%wx%h__%i.png", "%bbit\%wx%h\%f__%i.png", "%bbit\%f\%wx%h__%i.png", "%wx%h\%f__%i_%bbit.png", "%wx%h\%f\%i_%bbit.png"})
        Me.cmbStruct.Location = New System.Drawing.Point(360, 138)
        Me.cmbStruct.Name = "cmbStruct"
        Me.cmbStruct.Size = New System.Drawing.Size(242, 23)
        Me.cmbStruct.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(288, 328)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 32)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Info"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 372)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbStruct)
        Me.Controls.Add(Me.btnRootFolder)
        Me.Controls.Add(Me.txtParentPath)
        Me.Controls.Add(Me.filterSize)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbFilterBits)
        Me.Controls.Add(Me.chkFilterBits)
        Me.Controls.Add(Me.chkFilterSize)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.activeFile)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lstPaths)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Spiffy Icon Extractor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstPaths As System.Windows.Forms.ListBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents activeFile As System.Windows.Forms.Label
    Friend WithEvents ExtractWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkFilterSize As System.Windows.Forms.CheckBox
    Friend WithEvents chkFilterBits As System.Windows.Forms.CheckBox
    Friend WithEvents cmbFilterBits As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents filterSize As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtParentPath As System.Windows.Forms.TextBox
    Friend WithEvents btnRootFolder As System.Windows.Forms.Button
    Friend WithEvents cmbStruct As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
