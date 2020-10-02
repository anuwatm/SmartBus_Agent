<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSync
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSync))
        Me.lstvFile = New System.Windows.Forms.ListView()
        Me.colFilename = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdMonitor = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.dlgFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.tmInterval = New System.Windows.Forms.Timer(Me.components)
        Me.cmdScanFolder = New System.Windows.Forms.Button()
        Me.cmdTestDB = New System.Windows.Forms.Button()
        Me.tmStart = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lstvFile
        '
        Me.lstvFile.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colFilename, Me.colSize, Me.colStatus})
        Me.lstvFile.FullRowSelect = True
        Me.lstvFile.GridLines = True
        Me.lstvFile.HideSelection = False
        Me.lstvFile.Location = New System.Drawing.Point(13, 53)
        Me.lstvFile.Margin = New System.Windows.Forms.Padding(4)
        Me.lstvFile.Name = "lstvFile"
        Me.lstvFile.Size = New System.Drawing.Size(394, 258)
        Me.lstvFile.TabIndex = 0
        Me.lstvFile.UseCompatibleStateImageBehavior = False
        Me.lstvFile.View = System.Windows.Forms.View.Details
        '
        'colFilename
        '
        Me.colFilename.Text = "Filename"
        Me.colFilename.Width = 190
        '
        'colSize
        '
        Me.colSize.Text = "Size"
        Me.colSize.Width = 102
        '
        'colStatus
        '
        Me.colStatus.Text = "Status"
        '
        'cmdMonitor
        '
        Me.cmdMonitor.Location = New System.Drawing.Point(415, 53)
        Me.cmdMonitor.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdMonitor.Name = "cmdMonitor"
        Me.cmdMonitor.Size = New System.Drawing.Size(200, 46)
        Me.cmdMonitor.TabIndex = 1
        Me.cmdMonitor.Text = "Start Monitor"
        Me.cmdMonitor.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Path Monitor"
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(122, 19)
        Me.txtPath.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(374, 26)
        Me.txtPath.TabIndex = 3
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(504, 19)
        Me.cmdBrowse.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(111, 26)
        Me.cmdBrowse.TabIndex = 4
        Me.cmdBrowse.Text = "Browse..."
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'tmInterval
        '
        Me.tmInterval.Interval = 60000
        '
        'cmdScanFolder
        '
        Me.cmdScanFolder.Location = New System.Drawing.Point(415, 107)
        Me.cmdScanFolder.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdScanFolder.Name = "cmdScanFolder"
        Me.cmdScanFolder.Size = New System.Drawing.Size(200, 46)
        Me.cmdScanFolder.TabIndex = 5
        Me.cmdScanFolder.Text = "Scan Folder"
        Me.cmdScanFolder.UseVisualStyleBackColor = True
        '
        'cmdTestDB
        '
        Me.cmdTestDB.Location = New System.Drawing.Point(415, 265)
        Me.cmdTestDB.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdTestDB.Name = "cmdTestDB"
        Me.cmdTestDB.Size = New System.Drawing.Size(200, 46)
        Me.cmdTestDB.TabIndex = 6
        Me.cmdTestDB.Text = "Test Connect DB"
        Me.cmdTestDB.UseVisualStyleBackColor = True
        '
        'tmStart
        '
        Me.tmStart.Interval = 60000
        '
        'frmSync
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 320)
        Me.Controls.Add(Me.cmdTestDB)
        Me.Controls.Add(Me.cmdScanFolder)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdMonitor)
        Me.Controls.Add(Me.lstvFile)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmSync"
        Me.Text = "Sync Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstvFile As ListView
    Friend WithEvents colFilename As ColumnHeader
    Friend WithEvents colSize As ColumnHeader
    Friend WithEvents cmdMonitor As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents dlgFolder As FolderBrowserDialog
    Friend WithEvents tmInterval As Timer
    Friend WithEvents colStatus As ColumnHeader
    Friend WithEvents cmdScanFolder As Button
    Friend WithEvents cmdTestDB As Button
    Friend WithEvents tmStart As Timer
End Class
