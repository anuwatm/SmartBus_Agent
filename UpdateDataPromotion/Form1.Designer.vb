<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cmdLoadCSV = New System.Windows.Forms.Button()
        Me.lstvPromotion = New System.Windows.Forms.ListView()
        Me.colRouteID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCard = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTransDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTransTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colStationUp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colStationDown = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTransAmount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colFareBox = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBSS = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMatch = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dlgFile = New System.Windows.Forms.OpenFileDialog()
        Me.cmdMatchData = New System.Windows.Forms.Button()
        Me.cmdUpdateDB = New System.Windows.Forms.Button()
        Me.cmdClearList = New System.Windows.Forms.Button()
        Me.ssStatus = New System.Windows.Forms.StatusStrip()
        Me.slblMessage = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ssStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdLoadCSV
        '
        Me.cmdLoadCSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLoadCSV.Location = New System.Drawing.Point(7, 508)
        Me.cmdLoadCSV.Name = "cmdLoadCSV"
        Me.cmdLoadCSV.Size = New System.Drawing.Size(164, 44)
        Me.cmdLoadCSV.TabIndex = 2
        Me.cmdLoadCSV.Text = "Load Data CSV"
        Me.cmdLoadCSV.UseVisualStyleBackColor = True
        '
        'lstvPromotion
        '
        Me.lstvPromotion.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colRouteID, Me.colCard, Me.colTransDate, Me.colTransTime, Me.colStationUp, Me.colStationDown, Me.colTransAmount, Me.colFareBox, Me.colBSS, Me.colMatch})
        Me.lstvPromotion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvPromotion.FullRowSelect = True
        Me.lstvPromotion.GridLines = True
        Me.lstvPromotion.HideSelection = False
        Me.lstvPromotion.Location = New System.Drawing.Point(4, 4)
        Me.lstvPromotion.Name = "lstvPromotion"
        Me.lstvPromotion.Size = New System.Drawing.Size(933, 498)
        Me.lstvPromotion.TabIndex = 3
        Me.lstvPromotion.UseCompatibleStateImageBehavior = False
        Me.lstvPromotion.View = System.Windows.Forms.View.Details
        '
        'colRouteID
        '
        Me.colRouteID.Text = "Route"
        Me.colRouteID.Width = 58
        '
        'colCard
        '
        Me.colCard.Text = "Card ID"
        Me.colCard.Width = 119
        '
        'colTransDate
        '
        Me.colTransDate.Text = "Trans Date"
        Me.colTransDate.Width = 119
        '
        'colTransTime
        '
        Me.colTransTime.Text = "Trans Time"
        Me.colTransTime.Width = 127
        '
        'colStationUp
        '
        Me.colStationUp.Text = "Up"
        Me.colStationUp.Width = 53
        '
        'colStationDown
        '
        Me.colStationDown.Text = "Down"
        Me.colStationDown.Width = 59
        '
        'colTransAmount
        '
        Me.colTransAmount.Text = "Amount"
        Me.colTransAmount.Width = 87
        '
        'colFareBox
        '
        Me.colFareBox.Text = "Fare Amount"
        Me.colFareBox.Width = 119
        '
        'colBSS
        '
        Me.colBSS.Text = "BSS Payment"
        Me.colBSS.Width = 123
        '
        'colMatch
        '
        Me.colMatch.Text = "CheckData"
        '
        'dlgFile
        '
        Me.dlgFile.FileName = "Open File CSV File"
        Me.dlgFile.Filter = "File CSV|*.csv"
        '
        'cmdMatchData
        '
        Me.cmdMatchData.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMatchData.Location = New System.Drawing.Point(177, 508)
        Me.cmdMatchData.Name = "cmdMatchData"
        Me.cmdMatchData.Size = New System.Drawing.Size(205, 44)
        Me.cmdMatchData.TabIndex = 4
        Me.cmdMatchData.Text = "Check Matching"
        Me.cmdMatchData.UseVisualStyleBackColor = True
        '
        'cmdUpdateDB
        '
        Me.cmdUpdateDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdateDB.Location = New System.Drawing.Point(397, 508)
        Me.cmdUpdateDB.Name = "cmdUpdateDB"
        Me.cmdUpdateDB.Size = New System.Drawing.Size(200, 44)
        Me.cmdUpdateDB.TabIndex = 5
        Me.cmdUpdateDB.Text = "Update Database"
        Me.cmdUpdateDB.UseVisualStyleBackColor = True
        '
        'cmdClearList
        '
        Me.cmdClearList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearList.Location = New System.Drawing.Point(603, 508)
        Me.cmdClearList.Name = "cmdClearList"
        Me.cmdClearList.Size = New System.Drawing.Size(200, 44)
        Me.cmdClearList.TabIndex = 6
        Me.cmdClearList.Text = "Clear All List"
        Me.cmdClearList.UseVisualStyleBackColor = True
        '
        'ssStatus
        '
        Me.ssStatus.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ssStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblMessage})
        Me.ssStatus.Location = New System.Drawing.Point(0, 555)
        Me.ssStatus.Name = "ssStatus"
        Me.ssStatus.Size = New System.Drawing.Size(949, 24)
        Me.ssStatus.TabIndex = 7
        Me.ssStatus.Text = "StatusStrip1"
        '
        'slblMessage
        '
        Me.slblMessage.Name = "slblMessage"
        Me.slblMessage.Size = New System.Drawing.Size(0, 18)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 579)
        Me.Controls.Add(Me.ssStatus)
        Me.Controls.Add(Me.cmdClearList)
        Me.Controls.Add(Me.cmdUpdateDB)
        Me.Controls.Add(Me.cmdMatchData)
        Me.Controls.Add(Me.cmdLoadCSV)
        Me.Controls.Add(Me.lstvPromotion)
        Me.Name = "Form1"
        Me.Text = "Promotion Update"
        Me.ssStatus.ResumeLayout(False)
        Me.ssStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdLoadCSV As Button
    Friend WithEvents lstvPromotion As ListView
    Friend WithEvents colRouteID As ColumnHeader
    Friend WithEvents colCard As ColumnHeader
    Friend WithEvents colTransDate As ColumnHeader
    Friend WithEvents colTransTime As ColumnHeader
    Friend WithEvents colStationUp As ColumnHeader
    Friend WithEvents colStationDown As ColumnHeader
    Friend WithEvents colTransAmount As ColumnHeader
    Friend WithEvents colFareBox As ColumnHeader
    Friend WithEvents colBSS As ColumnHeader
    Friend WithEvents dlgFile As OpenFileDialog
    Friend WithEvents cmdMatchData As Button
    Friend WithEvents colMatch As ColumnHeader
    Friend WithEvents cmdUpdateDB As Button
    Friend WithEvents cmdClearList As Button
    Friend WithEvents ssStatus As StatusStrip
    Friend WithEvents slblMessage As ToolStripStatusLabel
End Class
