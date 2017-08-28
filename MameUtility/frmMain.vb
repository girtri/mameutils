Public Class frmMain
    Private Sub selSource_Click(sender As Object, e As EventArgs) Handles selSource.Click
        Dim res As DialogResult = sourceDialog.ShowDialog
        If res = DialogResult.OK Then
            txtSource.Text = sourceDialog.SelectedPath
        Else
            txtSource.Text = ""
        End If
    End Sub

    Private Sub selDest_Click(sender As Object, e As EventArgs) Handles selDest.Click
        Dim res As DialogResult = destDialog.ShowDialog
        If res = DialogResult.OK Then
            txtDest.Text = destDialog.SelectedPath
        Else
            txtDest.Text = ""
        End If
    End Sub

    Private Sub btnAnnulla_Click(sender As Object, e As EventArgs) Handles btnAnnulla.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        '..
    End Sub
End Class
