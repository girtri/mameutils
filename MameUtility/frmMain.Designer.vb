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
        Me.lblSource = New System.Windows.Forms.Label()
        Me.lblDest = New System.Windows.Forms.Label()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.txtDest = New System.Windows.Forms.TextBox()
        Me.btnCerca = New System.Windows.Forms.Button()
        Me.btnAnnulla = New System.Windows.Forms.Button()
        Me.sourceDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.destDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.selSource = New System.Windows.Forms.Button()
        Me.selDest = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotFiles = New System.Windows.Forms.TextBox()
        Me.txtExpFiles = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEsporta = New System.Windows.Forms.Button()
        Me.lblTotNotFound = New System.Windows.Forms.Label()
        Me.lsvMissed = New System.Windows.Forms.ListView()
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAlt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chkAlt = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblSource
        '
        Me.lblSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSource.Location = New System.Drawing.Point(12, 18)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(160, 21)
        Me.lblSource.TabIndex = 0
        Me.lblSource.Text = "Roms source dir"
        '
        'lblDest
        '
        Me.lblDest.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDest.Location = New System.Drawing.Point(12, 78)
        Me.lblDest.Name = "lblDest"
        Me.lblDest.Size = New System.Drawing.Size(160, 21)
        Me.lblDest.TabIndex = 1
        Me.lblDest.Text = "Roms destination dir"
        '
        'txtSource
        '
        Me.txtSource.Location = New System.Drawing.Point(15, 42)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(473, 20)
        Me.txtSource.TabIndex = 2
        Me.txtSource.Text = "F:\Mame0149\MameRoms"
        '
        'txtDest
        '
        Me.txtDest.Location = New System.Drawing.Point(15, 102)
        Me.txtDest.Name = "txtDest"
        Me.txtDest.Size = New System.Drawing.Size(473, 20)
        Me.txtDest.TabIndex = 3
        Me.txtDest.Text = "F:\Mame0149\ExportRoms"
        '
        'btnCerca
        '
        Me.btnCerca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerca.Location = New System.Drawing.Point(26, 287)
        Me.btnCerca.Name = "btnCerca"
        Me.btnCerca.Size = New System.Drawing.Size(105, 29)
        Me.btnCerca.TabIndex = 4
        Me.btnCerca.Text = "Cerca roms"
        Me.btnCerca.UseVisualStyleBackColor = True
        '
        'btnAnnulla
        '
        Me.btnAnnulla.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnulla.Location = New System.Drawing.Point(26, 372)
        Me.btnAnnulla.Name = "btnAnnulla"
        Me.btnAnnulla.Size = New System.Drawing.Size(105, 29)
        Me.btnAnnulla.TabIndex = 5
        Me.btnAnnulla.Text = "Chiudi"
        Me.btnAnnulla.UseVisualStyleBackColor = True
        '
        'selSource
        '
        Me.selSource.Location = New System.Drawing.Point(490, 42)
        Me.selSource.Name = "selSource"
        Me.selSource.Size = New System.Drawing.Size(22, 20)
        Me.selSource.TabIndex = 6
        Me.selSource.Text = "..."
        Me.selSource.UseVisualStyleBackColor = True
        '
        'selDest
        '
        Me.selDest.Location = New System.Drawing.Point(490, 102)
        Me.selDest.Name = "selDest"
        Me.selDest.Size = New System.Drawing.Size(22, 20)
        Me.selDest.TabIndex = 7
        Me.selDest.Text = "..."
        Me.selDest.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 21)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Files da esportare:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 21)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Files trovati:"
        '
        'txtTotFiles
        '
        Me.txtTotFiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotFiles.Location = New System.Drawing.Point(159, 174)
        Me.txtTotFiles.Name = "txtTotFiles"
        Me.txtTotFiles.ReadOnly = True
        Me.txtTotFiles.Size = New System.Drawing.Size(45, 20)
        Me.txtTotFiles.TabIndex = 10
        Me.txtTotFiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtExpFiles
        '
        Me.txtExpFiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpFiles.Location = New System.Drawing.Point(159, 205)
        Me.txtExpFiles.Name = "txtExpFiles"
        Me.txtExpFiles.ReadOnly = True
        Me.txtExpFiles.Size = New System.Drawing.Size(45, 20)
        Me.txtExpFiles.TabIndex = 11
        Me.txtExpFiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(256, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 21)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "non trovati:"
        '
        'btnEsporta
        '
        Me.btnEsporta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEsporta.Location = New System.Drawing.Point(26, 327)
        Me.btnEsporta.Name = "btnEsporta"
        Me.btnEsporta.Size = New System.Drawing.Size(105, 29)
        Me.btnEsporta.TabIndex = 14
        Me.btnEsporta.Text = "Esporta roms"
        Me.btnEsporta.UseVisualStyleBackColor = True
        '
        'lblTotNotFound
        '
        Me.lblTotNotFound.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotNotFound.Location = New System.Drawing.Point(333, 144)
        Me.lblTotNotFound.Name = "lblTotNotFound"
        Me.lblTotNotFound.Size = New System.Drawing.Size(95, 21)
        Me.lblTotNotFound.TabIndex = 15
        Me.lblTotNotFound.Text = "(tot: x)"
        '
        'lsvMissed
        '
        Me.lsvMissed.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colName, Me.colAlt})
        Me.lsvMissed.FullRowSelect = True
        Me.lsvMissed.Location = New System.Drawing.Point(259, 167)
        Me.lsvMissed.Name = "lsvMissed"
        Me.lsvMissed.Size = New System.Drawing.Size(285, 258)
        Me.lsvMissed.TabIndex = 16
        Me.lsvMissed.UseCompatibleStateImageBehavior = False
        Me.lsvMissed.View = System.Windows.Forms.View.Details
        '
        'colName
        '
        Me.colName.Text = "Rom"
        Me.colName.Width = 140
        '
        'colAlt
        '
        Me.colAlt.Text = "Alt"
        Me.colAlt.Width = 140
        '
        'chkAlt
        '
        Me.chkAlt.AutoSize = True
        Me.chkAlt.Location = New System.Drawing.Point(434, 144)
        Me.chkAlt.Name = "chkAlt"
        Me.chkAlt.Size = New System.Drawing.Size(110, 17)
        Me.chkAlt.TabIndex = 17
        Me.chkAlt.Text = "Esporta alternativi"
        Me.chkAlt.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 437)
        Me.Controls.Add(Me.chkAlt)
        Me.Controls.Add(Me.lsvMissed)
        Me.Controls.Add(Me.lblTotNotFound)
        Me.Controls.Add(Me.btnEsporta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtExpFiles)
        Me.Controls.Add(Me.txtTotFiles)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.selDest)
        Me.Controls.Add(Me.selSource)
        Me.Controls.Add(Me.btnAnnulla)
        Me.Controls.Add(Me.btnCerca)
        Me.Controls.Add(Me.txtDest)
        Me.Controls.Add(Me.txtSource)
        Me.Controls.Add(Me.lblDest)
        Me.Controls.Add(Me.lblSource)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMain"
        Me.Text = "Mame Utility"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSource As Label
    Friend WithEvents lblDest As Label
    Friend WithEvents txtSource As TextBox
    Friend WithEvents txtDest As TextBox
    Friend WithEvents btnCerca As Button
    Friend WithEvents btnAnnulla As Button
    Friend WithEvents sourceDialog As FolderBrowserDialog
    Friend WithEvents destDialog As FolderBrowserDialog
    Friend WithEvents selSource As Button
    Friend WithEvents selDest As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTotFiles As TextBox
    Friend WithEvents txtExpFiles As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEsporta As Button
    Friend WithEvents lblTotNotFound As Label
    Friend WithEvents lsvMissed As ListView
    Friend WithEvents colName As ColumnHeader
    Friend WithEvents colAlt As ColumnHeader
    Friend WithEvents chkAlt As CheckBox
End Class
