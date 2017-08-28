Imports System.IO

Public Class frmMain
    Private _nrFound As Integer
    Private _colFiles As Dictionary(Of String, Integer)

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

    Private Sub btnCerca_Click(sender As Object, e As EventArgs) Handles btnCerca.Click
        CercaFavoriti(txtSource.Text, txtDest.Text)
    End Sub

    Private Sub btnEsporta_Click(sender As Object, e As EventArgs) Handles btnEsporta.Click
        If Not _colFiles Is Nothing AndAlso _colFiles.Count > 0 Then
            'copia file....
            'File.Move(fileName, Path.Combine(sourcePath, newName))
        Else
            MessageBox.Show("Nessun file da esportare", "Attenzione")
        End If
    End Sub

    Private Function LeggiFavoriti() As Dictionary(Of String, Integer)
        Dim pathIni As String = Path.Combine(Application.StartupPath, "Favorites.ini")
        Dim iniFile As StreamReader = New StreamReader(pathIni)
        Dim line As String
        Dim startScan As Boolean = False
        Dim res As New Dictionary(Of String, Integer)

        Do
            line = iniFile.ReadLine()
            If Not line Is Nothing Then
                If startScan Then
                    If Not line.StartsWith("[") AndAlso (line <> "") Then
                        res.Add(line, 0)
                    Else
                        Exit Do
                    End If
                Else
                    startScan = line = "[ROOT_FOLDER]"
                End If
            End If
        Loop Until line Is Nothing
        iniFile.Close()

        Return res
    End Function

    Private Sub CercaFavoriti(sourcePath As String, destPath As String)
        Dim searchPattern As String = "*.zip|*.7z"
        Dim name, ext As String
        Dim i As Integer = 0

        _colFiles = Nothing
        _colFiles = LeggiFavoriti()
        _nrFound = 0
        listMissed.Items.Clear()

        For Each fileName As String In Directory.GetFiles(sourcePath, "*.*", SearchOption.TopDirectoryOnly)
            name = Path.GetFileNameWithoutExtension(fileName)
            ext = Path.GetExtension(fileName)

            If ext = ".zip" Or ext = ".7z" Then
                If _colFiles.ContainsKey(name) Then
                    _colFiles(name) = 1
                    _nrFound = _nrFound + 1
                End If
            End If
        Next

        txtTotFiles.Text = _colFiles.Count
        txtExpFiles.Text = _nrFound

        If _nrFound < _colFiles.Count Then
            For Each kvp As KeyValuePair(Of String, Integer) In _colFiles
                Dim romName As String = kvp.Key
                Dim val As Integer = kvp.Value

                If val = 0 Then
                    listMissed.Items.Add(romName)
                End If
            Next
        End If
    End Sub
End Class
