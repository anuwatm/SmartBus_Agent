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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstvFile = New System.Windows.Forms.ListView()
        Me.colFilename = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdTestDB = New System.Windows.Forms.Button()
        Me.cmdScanFolder = New System.Windows.Forms.Button()
        Me.dlgFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.tmInterval = New System.Windows.Forms.Timer(Me.components)
        Me.lblCount = New System.Windows.Forms.Label()
        Me.tabData = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lstvPlan = New System.Windows.Forms.ListView()
        Me.colPlanDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPlanBusNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPlanBusID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPlanEmpID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPlanStart = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lstvWorkLog = New System.Windows.Forms.ListView()
        Me.colDateLog = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBusNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBusID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colEmpID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTravelCount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lstvMaintenance = New System.Windows.Forms.ListView()
        Me.coMainDay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.coMainBusID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.coMainRemark = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lstvTimeActen = New System.Windows.Forms.ListView()
        Me.colTimeDay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTimeEmpID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTimeTImeIn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTimeOut = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.lstvTicketLog = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.lstvGas = New System.Windows.Forms.ListView()
        Me.colGasRoute = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colGasBusID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colGasBusNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colGasDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colGasKG = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colGasAmount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.labelStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.chkSummary = New System.Windows.Forms.CheckBox()
        Me.tabData.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(603, 0)
        Me.cmdBrowse.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(111, 26)
        Me.cmdBrowse.TabIndex = 8
        Me.cmdBrowse.Text = "Browse..."
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(111, 0)
        Me.txtPath.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(484, 26)
        Me.txtPath.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-2, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Path Monitor"
        '
        'lstvFile
        '
        Me.lstvFile.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colFilename, Me.colSize, Me.colStatus})
        Me.lstvFile.FullRowSelect = True
        Me.lstvFile.GridLines = True
        Me.lstvFile.HideSelection = False
        Me.lstvFile.Location = New System.Drawing.Point(2, 34)
        Me.lstvFile.Margin = New System.Windows.Forms.Padding(4)
        Me.lstvFile.Name = "lstvFile"
        Me.lstvFile.Size = New System.Drawing.Size(264, 326)
        Me.lstvFile.TabIndex = 5
        Me.lstvFile.UseCompatibleStateImageBehavior = False
        Me.lstvFile.View = System.Windows.Forms.View.Details
        '
        'colFilename
        '
        Me.colFilename.Text = "Filename"
        Me.colFilename.Width = 131
        '
        'colSize
        '
        Me.colSize.Text = "Size"
        Me.colSize.Width = 57
        '
        'colStatus
        '
        Me.colStatus.Text = "Status"
        '
        'cmdTestDB
        '
        Me.cmdTestDB.Location = New System.Drawing.Point(763, 318)
        Me.cmdTestDB.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdTestDB.Name = "cmdTestDB"
        Me.cmdTestDB.Size = New System.Drawing.Size(150, 46)
        Me.cmdTestDB.TabIndex = 10
        Me.cmdTestDB.Text = "Test Connect DB"
        Me.cmdTestDB.UseVisualStyleBackColor = True
        '
        'cmdScanFolder
        '
        Me.cmdScanFolder.Location = New System.Drawing.Point(763, 97)
        Me.cmdScanFolder.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdScanFolder.Name = "cmdScanFolder"
        Me.cmdScanFolder.Size = New System.Drawing.Size(150, 46)
        Me.cmdScanFolder.TabIndex = 9
        Me.cmdScanFolder.Text = "Scan Folder"
        Me.cmdScanFolder.UseVisualStyleBackColor = True
        '
        'tmInterval
        '
        Me.tmInterval.Interval = 1000
        '
        'lblCount
        '
        Me.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(765, 34)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(148, 59)
        Me.lblCount.TabIndex = 12
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabData
        '
        Me.tabData.Controls.Add(Me.TabPage1)
        Me.tabData.Controls.Add(Me.TabPage2)
        Me.tabData.Controls.Add(Me.TabPage3)
        Me.tabData.Controls.Add(Me.TabPage4)
        Me.tabData.Controls.Add(Me.TabPage5)
        Me.tabData.Controls.Add(Me.TabPage6)
        Me.tabData.Location = New System.Drawing.Point(273, 33)
        Me.tabData.Name = "tabData"
        Me.tabData.SelectedIndex = 0
        Me.tabData.Size = New System.Drawing.Size(486, 334)
        Me.tabData.TabIndex = 13
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lstvPlan)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(478, 301)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Plan"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lstvPlan
        '
        Me.lstvPlan.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colPlanDate, Me.colPlanBusNumber, Me.colPlanBusID, Me.colPlanEmpID, Me.colPlanStart})
        Me.lstvPlan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstvPlan.FullRowSelect = True
        Me.lstvPlan.GridLines = True
        Me.lstvPlan.HideSelection = False
        Me.lstvPlan.Location = New System.Drawing.Point(3, 3)
        Me.lstvPlan.Margin = New System.Windows.Forms.Padding(4)
        Me.lstvPlan.Name = "lstvPlan"
        Me.lstvPlan.Size = New System.Drawing.Size(472, 295)
        Me.lstvPlan.TabIndex = 14
        Me.lstvPlan.UseCompatibleStateImageBehavior = False
        Me.lstvPlan.View = System.Windows.Forms.View.Details
        '
        'colPlanDate
        '
        Me.colPlanDate.Text = "Date"
        '
        'colPlanBusNumber
        '
        Me.colPlanBusNumber.Text = "Bus Number"
        Me.colPlanBusNumber.Width = 110
        '
        'colPlanBusID
        '
        Me.colPlanBusID.Text = "Bus ID"
        Me.colPlanBusID.Width = 70
        '
        'colPlanEmpID
        '
        Me.colPlanEmpID.Text = "emp ID"
        Me.colPlanEmpID.Width = 91
        '
        'colPlanStart
        '
        Me.colPlanStart.Text = "Time Start"
        Me.colPlanStart.Width = 84
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lstvWorkLog)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(478, 301)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "WorkLog"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lstvWorkLog
        '
        Me.lstvWorkLog.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colDateLog, Me.colBusNumber, Me.colBusID, Me.colEmpID, Me.colTravelCount})
        Me.lstvWorkLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstvWorkLog.FullRowSelect = True
        Me.lstvWorkLog.GridLines = True
        Me.lstvWorkLog.HideSelection = False
        Me.lstvWorkLog.Location = New System.Drawing.Point(3, 3)
        Me.lstvWorkLog.Margin = New System.Windows.Forms.Padding(4)
        Me.lstvWorkLog.Name = "lstvWorkLog"
        Me.lstvWorkLog.Size = New System.Drawing.Size(472, 295)
        Me.lstvWorkLog.TabIndex = 13
        Me.lstvWorkLog.UseCompatibleStateImageBehavior = False
        Me.lstvWorkLog.View = System.Windows.Forms.View.Details
        '
        'colDateLog
        '
        Me.colDateLog.Text = "Date"
        Me.colDateLog.Width = 72
        '
        'colBusNumber
        '
        Me.colBusNumber.Text = "Bus"
        Me.colBusNumber.Width = 68
        '
        'colBusID
        '
        Me.colBusID.Text = "BusID"
        '
        'colEmpID
        '
        Me.colEmpID.Text = "empID"
        Me.colEmpID.Width = 78
        '
        'colTravelCount
        '
        Me.colTravelCount.Text = "Count"
        Me.colTravelCount.Width = 72
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lstvMaintenance)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(478, 301)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Maintenance"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lstvMaintenance
        '
        Me.lstvMaintenance.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.coMainDay, Me.coMainBusID, Me.coMainRemark})
        Me.lstvMaintenance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstvMaintenance.FullRowSelect = True
        Me.lstvMaintenance.GridLines = True
        Me.lstvMaintenance.HideSelection = False
        Me.lstvMaintenance.Location = New System.Drawing.Point(0, 0)
        Me.lstvMaintenance.Margin = New System.Windows.Forms.Padding(4)
        Me.lstvMaintenance.Name = "lstvMaintenance"
        Me.lstvMaintenance.Size = New System.Drawing.Size(478, 301)
        Me.lstvMaintenance.TabIndex = 14
        Me.lstvMaintenance.UseCompatibleStateImageBehavior = False
        Me.lstvMaintenance.View = System.Windows.Forms.View.Details
        '
        'coMainDay
        '
        Me.coMainDay.Text = "Date"
        Me.coMainDay.Width = 94
        '
        'coMainBusID
        '
        Me.coMainBusID.Text = "BusID"
        '
        'coMainRemark
        '
        Me.coMainRemark.Text = "Remark"
        Me.coMainRemark.Width = 73
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.lstvTimeActen)
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(478, 301)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Time Acten"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'lstvTimeActen
        '
        Me.lstvTimeActen.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colTimeDay, Me.colTimeEmpID, Me.colTimeTImeIn, Me.colTimeOut})
        Me.lstvTimeActen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstvTimeActen.FullRowSelect = True
        Me.lstvTimeActen.GridLines = True
        Me.lstvTimeActen.HideSelection = False
        Me.lstvTimeActen.Location = New System.Drawing.Point(0, 0)
        Me.lstvTimeActen.Margin = New System.Windows.Forms.Padding(4)
        Me.lstvTimeActen.Name = "lstvTimeActen"
        Me.lstvTimeActen.Size = New System.Drawing.Size(478, 301)
        Me.lstvTimeActen.TabIndex = 15
        Me.lstvTimeActen.UseCompatibleStateImageBehavior = False
        Me.lstvTimeActen.View = System.Windows.Forms.View.Details
        '
        'colTimeDay
        '
        Me.colTimeDay.Text = "Date"
        Me.colTimeDay.Width = 78
        '
        'colTimeEmpID
        '
        Me.colTimeEmpID.Text = "EmpID"
        Me.colTimeEmpID.Width = 85
        '
        'colTimeTImeIn
        '
        Me.colTimeTImeIn.Text = "IN"
        Me.colTimeTImeIn.Width = 75
        '
        'colTimeOut
        '
        Me.colTimeOut.Text = "OUT"
        Me.colTimeOut.Width = 74
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.lstvTicketLog)
        Me.TabPage5.Location = New System.Drawing.Point(4, 29)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(478, 301)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Ticket"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'lstvTicketLog
        '
        Me.lstvTicketLog.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader9})
        Me.lstvTicketLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstvTicketLog.FullRowSelect = True
        Me.lstvTicketLog.GridLines = True
        Me.lstvTicketLog.HideSelection = False
        Me.lstvTicketLog.Location = New System.Drawing.Point(3, 3)
        Me.lstvTicketLog.Margin = New System.Windows.Forms.Padding(4)
        Me.lstvTicketLog.Name = "lstvTicketLog"
        Me.lstvTicketLog.Size = New System.Drawing.Size(472, 295)
        Me.lstvTicketLog.TabIndex = 14
        Me.lstvTicketLog.UseCompatibleStateImageBehavior = False
        Me.lstvTicketLog.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "dateLog"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "route"
        Me.ColumnHeader7.Width = 34
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "bus"
        Me.ColumnHeader8.Width = 46
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "BusID"
        Me.ColumnHeader1.Width = 55
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "EmpID"
        Me.ColumnHeader2.Width = 77
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "roundCount"
        Me.ColumnHeader3.Width = 37
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ticketPrice"
        Me.ColumnHeader4.Width = 47
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "countTicket"
        Me.ColumnHeader5.Width = 48
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Amount"
        Me.ColumnHeader9.Width = 64
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.lstvGas)
        Me.TabPage6.Location = New System.Drawing.Point(4, 29)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(478, 301)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Gas"
        '
        'lstvGas
        '
        Me.lstvGas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colGasRoute, Me.colGasBusID, Me.colGasBusNumber, Me.colGasDate, Me.colGasKG, Me.colGasAmount})
        Me.lstvGas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstvGas.FullRowSelect = True
        Me.lstvGas.GridLines = True
        Me.lstvGas.HideSelection = False
        Me.lstvGas.Location = New System.Drawing.Point(3, 3)
        Me.lstvGas.Margin = New System.Windows.Forms.Padding(4)
        Me.lstvGas.Name = "lstvGas"
        Me.lstvGas.Size = New System.Drawing.Size(472, 295)
        Me.lstvGas.TabIndex = 15
        Me.lstvGas.UseCompatibleStateImageBehavior = False
        Me.lstvGas.View = System.Windows.Forms.View.Details
        '
        'colGasRoute
        '
        Me.colGasRoute.Text = "Route"
        '
        'colGasBusID
        '
        Me.colGasBusID.Text = "BusID"
        Me.colGasBusID.Width = 65
        '
        'colGasBusNumber
        '
        Me.colGasBusNumber.Text = "Bus Number"
        Me.colGasBusNumber.Width = 62
        '
        'colGasDate
        '
        Me.colGasDate.Text = "Date"
        Me.colGasDate.Width = 92
        '
        'colGasKG
        '
        Me.colGasKG.Text = "KG"
        Me.colGasKG.Width = 79
        '
        'colGasAmount
        '
        Me.colGasAmount.Text = "Amount"
        Me.colGasAmount.Width = 83
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 368)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(920, 22)
        Me.StatusStrip1.TabIndex = 14
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'labelStatus
        '
        Me.labelStatus.Name = "labelStatus"
        Me.labelStatus.Size = New System.Drawing.Size(0, 16)
        '
        'chkSummary
        '
        Me.chkSummary.AutoSize = True
        Me.chkSummary.Location = New System.Drawing.Point(761, 150)
        Me.chkSummary.Name = "chkSummary"
        Me.chkSummary.Size = New System.Drawing.Size(148, 24)
        Me.chkSummary.TabIndex = 15
        Me.chkSummary.Text = "Summary Mode"
        Me.chkSummary.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 390)
        Me.Controls.Add(Me.chkSummary)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.tabData)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.cmdTestDB)
        Me.Controls.Add(Me.cmdScanFolder)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstvFile)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Update WorkLog"
        Me.tabData.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdBrowse As Button
    Friend WithEvents txtPath As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lstvFile As ListView
    Friend WithEvents colFilename As ColumnHeader
    Friend WithEvents colSize As ColumnHeader
    Friend WithEvents colStatus As ColumnHeader
    Friend WithEvents cmdTestDB As Button
    Friend WithEvents cmdScanFolder As Button
    Friend WithEvents dlgFolder As FolderBrowserDialog
    Friend WithEvents tmInterval As Timer
    Friend WithEvents lblCount As Label
    Friend WithEvents tabData As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lstvWorkLog As ListView
    Friend WithEvents colDateLog As ColumnHeader
    Friend WithEvents colBusNumber As ColumnHeader
    Friend WithEvents colBusID As ColumnHeader
    Friend WithEvents colEmpID As ColumnHeader
    Friend WithEvents colTravelCount As ColumnHeader
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents lstvMaintenance As ListView
    Friend WithEvents coMainDay As ColumnHeader
    Friend WithEvents coMainBusID As ColumnHeader
    Friend WithEvents coMainRemark As ColumnHeader
    Friend WithEvents lstvTimeActen As ListView
    Friend WithEvents colTimeDay As ColumnHeader
    Friend WithEvents colTimeEmpID As ColumnHeader
    Friend WithEvents colTimeTImeIn As ColumnHeader
    Friend WithEvents colTimeOut As ColumnHeader
    Friend WithEvents lstvPlan As ListView
    Friend WithEvents colPlanDate As ColumnHeader
    Friend WithEvents colPlanBusNumber As ColumnHeader
    Friend WithEvents colPlanBusID As ColumnHeader
    Friend WithEvents colPlanEmpID As ColumnHeader
    Friend WithEvents colPlanStart As ColumnHeader
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents lstvTicketLog As ListView
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents labelStatus As ToolStripStatusLabel
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents lstvGas As ListView
    Friend WithEvents colGasRoute As ColumnHeader
    Friend WithEvents colGasBusID As ColumnHeader
    Friend WithEvents colGasBusNumber As ColumnHeader
    Friend WithEvents colGasDate As ColumnHeader
    Friend WithEvents colGasKG As ColumnHeader
    Friend WithEvents colGasAmount As ColumnHeader
    Friend WithEvents chkSummary As CheckBox
End Class
