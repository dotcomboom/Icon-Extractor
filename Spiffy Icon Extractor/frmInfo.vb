Public Class frmInfo

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkGithub.LinkClicked
        Process.Start("https://github.com/dotcomboom/spiffy-icon-extractor")
    End Sub

    Private Sub frmInfo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblVersion.Text = My.Application.Info.Version.Major
        If My.Application.Info.Version.MajorRevision > 0 Then
            lblVersion.Text &= "." & My.Application.Info.Version.MajorRevision
        End If
        If My.Application.Info.Version.Minor > 0 Then
            lblVersion.Text &= "." & My.Application.Info.Version.Minor
        End If
        If My.Application.Info.Version.MinorRevision > 0 Then
            lblVersion.Text &= "." & My.Application.Info.Version.MinorRevision
        End If
        If My.Application.Info.Version.Build > 0 Then
            lblVersion.Text &= "." & My.Application.Info.Version.Build
        End If
        chkSamples.Checked = My.Settings.samples
    End Sub

    Private Sub lnkWebsite_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkWebsite.LinkClicked
        Process.Start("http://dotcomboom.somnolescent.net")
    End Sub

    Private Sub chkSamples_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkSamples.CheckedChanged
        My.Settings.samples = chkSamples.Checked
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class