<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInfo))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.richText = New System.Windows.Forms.RichTextBox()
        Me.imgIcon = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lnkGithub = New System.Windows.Forms.LinkLabel()
        Me.lnkWebsite = New System.Windows.Forms.LinkLabel()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.picBulb = New System.Windows.Forms.PictureBox()
        Me.chkSamples = New System.Windows.Forms.CheckBox()
        CType(Me.imgIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBulb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(496, 486)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(87, 27)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "OK"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'richText
        '
        Me.richText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.richText.BackColor = System.Drawing.SystemColors.Control
        Me.richText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.richText.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.richText.Location = New System.Drawing.Point(12, 68)
        Me.richText.Name = "richText"
        Me.richText.Size = New System.Drawing.Size(569, 401)
        Me.richText.TabIndex = 1
        Me.richText.Text = resources.GetString("richText.Text")
        '
        'imgIcon
        '
        Me.imgIcon.Image = CType(resources.GetObject("imgIcon.Image"), System.Drawing.Image)
        Me.imgIcon.Location = New System.Drawing.Point(14, 14)
        Me.imgIcon.Name = "imgIcon"
        Me.imgIcon.Size = New System.Drawing.Size(48, 48)
        Me.imgIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgIcon.TabIndex = 2
        Me.imgIcon.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(68, 23)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(199, 30)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Spiffy Icon Extractor"
        '
        'lnkGithub
        '
        Me.lnkGithub.AutoSize = True
        Me.lnkGithub.Location = New System.Drawing.Point(379, 35)
        Me.lnkGithub.Name = "lnkGithub"
        Me.lnkGithub.Size = New System.Drawing.Size(43, 15)
        Me.lnkGithub.TabIndex = 4
        Me.lnkGithub.TabStop = True
        Me.lnkGithub.Text = "Github"
        '
        'lnkWebsite
        '
        Me.lnkWebsite.AutoSize = True
        Me.lnkWebsite.Location = New System.Drawing.Point(428, 35)
        Me.lnkWebsite.Name = "lnkWebsite"
        Me.lnkWebsite.Size = New System.Drawing.Size(130, 15)
        Me.lnkWebsite.TabIndex = 5
        Me.lnkWebsite.TabStop = True
        Me.lnkWebsite.Text = "Made by dotcomboom"
        '
        'lblVersion
        '
        Me.lblVersion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblVersion.Location = New System.Drawing.Point(264, 23)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(90, 28)
        Me.lblVersion.TabIndex = 6
        Me.lblVersion.Text = "0.0.0.0"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'picBulb
        '
        Me.picBulb.AccessibleName = "Somnolescent"
        Me.picBulb.Image = CType(resources.GetObject("picBulb.Image"), System.Drawing.Image)
        Me.picBulb.Location = New System.Drawing.Point(564, 35)
        Me.picBulb.Name = "picBulb"
        Me.picBulb.Size = New System.Drawing.Size(16, 16)
        Me.picBulb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picBulb.TabIndex = 8
        Me.picBulb.TabStop = False
        '
        'chkSamples
        '
        Me.chkSamples.AutoSize = True
        Me.chkSamples.Location = New System.Drawing.Point(14, 486)
        Me.chkSamples.Name = "chkSamples"
        Me.chkSamples.Size = New System.Drawing.Size(297, 19)
        Me.chkSamples.TabIndex = 9
        Me.chkSamples.Text = "Start Spiffy Icon Extractor with sample system icons"
        Me.chkSamples.UseVisualStyleBackColor = True
        '
        'frmInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 527)
        Me.Controls.Add(Me.chkSamples)
        Me.Controls.Add(Me.picBulb)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lnkWebsite)
        Me.Controls.Add(Me.lnkGithub)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.imgIcon)
        Me.Controls.Add(Me.richText)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmInfo"
        Me.Text = "Info"
        CType(Me.imgIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBulb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents richText As System.Windows.Forms.RichTextBox
    Friend WithEvents imgIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lnkGithub As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkWebsite As System.Windows.Forms.LinkLabel
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents picBulb As System.Windows.Forms.PictureBox
    Friend WithEvents chkSamples As System.Windows.Forms.CheckBox
End Class
