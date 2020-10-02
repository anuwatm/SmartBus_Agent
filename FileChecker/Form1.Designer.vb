<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDateSource = New System.Windows.Forms.TextBox()
        Me.lblBusCount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAnalyticTicket = New System.Windows.Forms.Button()
        Me.lstvTicketSubSum = New System.Windows.Forms.ListView()
        Me.colTicketSubBranch = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTicketSubRoute = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTicketSubBus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstvTicketGroupSum = New System.Windows.Forms.ListView()
        Me.colTicketBranch = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTicketRoute = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTicketBus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstFileTicket = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnUpdateBranch = New System.Windows.Forms.Button()
        Me.lblGenDisplay = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lstGenFile = New System.Windows.Forms.ListBox()
        Me.btnAnalyzeFile = New System.Windows.Forms.Button()
        Me.lstvBranchChacker = New System.Windows.Forms.ListView()
        Me.colGenDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colGenBranch = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colGenRoute = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colGenBus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstDateGen = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGenEnd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGenDate = New System.Windows.Forms.Button()
        Me.txtGenStart = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.chkAutoMoveShuttleBus = New System.Windows.Forms.CheckBox()
        Me.btnMoveData = New System.Windows.Forms.Button()
        Me.btnReorderRoute = New System.Windows.Forms.Button()
        Me.chkAutoAddRoute = New System.Windows.Forms.CheckBox()
        Me.lstNewRoute = New System.Windows.Forms.ListBox()
        Me.btnCheckNewRoute = New System.Windows.Forms.Button()
        Me.chkAlertNewRoute = New System.Windows.Forms.CheckBox()
        Me.chkUpdateBranch = New System.Windows.Forms.CheckBox()
        Me.lblFileCHeckDisplay = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkAutoCheck = New System.Windows.Forms.CheckBox()
        Me.chkSendToLine = New System.Windows.Forms.CheckBox()
        Me.btnCheckFile = New System.Windows.Forms.Button()
        Me.lstvCheckFile = New System.Windows.Forms.ListView()
        Me.colBranchName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTicket = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTrip = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colGas = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCheckDate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.dlgFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnBreakAuto = New System.Windows.Forms.Button()
        Me.chkShortALert = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(13, 62)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1047, 501)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtDateSource)
        Me.TabPage1.Controls.Add(Me.lblBusCount)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.btnAnalyticTicket)
        Me.TabPage1.Controls.Add(Me.lstvTicketSubSum)
        Me.TabPage1.Controls.Add(Me.lstvTicketGroupSum)
        Me.TabPage1.Controls.Add(Me.lstFileTicket)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(1039, 468)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ticket"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Source Date"
        '
        'txtDateSource
        '
        Me.txtDateSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateSource.Location = New System.Drawing.Point(7, 32)
        Me.txtDateSource.Name = "txtDateSource"
        Me.txtDateSource.Size = New System.Drawing.Size(220, 34)
        Me.txtDateSource.TabIndex = 6
        Me.txtDateSource.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBusCount
        '
        Me.lblBusCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusCount.Location = New System.Drawing.Point(7, 407)
        Me.lblBusCount.Name = "lblBusCount"
        Me.lblBusCount.Size = New System.Drawing.Size(220, 52)
        Me.lblBusCount.TabIndex = 5
        Me.lblBusCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 387)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "จำนวนรถที่วิ่ง"
        '
        'btnAnalyticTicket
        '
        Me.btnAnalyticTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnalyticTicket.Location = New System.Drawing.Point(814, 7)
        Me.btnAnalyticTicket.Name = "btnAnalyticTicket"
        Me.btnAnalyticTicket.Size = New System.Drawing.Size(218, 59)
        Me.btnAnalyticTicket.TabIndex = 3
        Me.btnAnalyticTicket.Text = "Analytic Ticket"
        Me.btnAnalyticTicket.UseVisualStyleBackColor = True
        '
        'lstvTicketSubSum
        '
        Me.lstvTicketSubSum.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colTicketSubBranch, Me.colTicketSubRoute, Me.colTicketSubBus})
        Me.lstvTicketSubSum.FullRowSelect = True
        Me.lstvTicketSubSum.GridLines = True
        Me.lstvTicketSubSum.HideSelection = False
        Me.lstvTicketSubSum.Location = New System.Drawing.Point(527, 7)
        Me.lstvTicketSubSum.Name = "lstvTicketSubSum"
        Me.lstvTicketSubSum.Size = New System.Drawing.Size(281, 452)
        Me.lstvTicketSubSum.TabIndex = 2
        Me.lstvTicketSubSum.UseCompatibleStateImageBehavior = False
        Me.lstvTicketSubSum.View = System.Windows.Forms.View.Details
        '
        'colTicketSubBranch
        '
        Me.colTicketSubBranch.Text = "Branch"
        Me.colTicketSubBranch.Width = 69
        '
        'colTicketSubRoute
        '
        Me.colTicketSubRoute.Text = "Route"
        Me.colTicketSubRoute.Width = 72
        '
        'colTicketSubBus
        '
        Me.colTicketSubBus.Text = "Bus ID"
        Me.colTicketSubBus.Width = 95
        '
        'lstvTicketGroupSum
        '
        Me.lstvTicketGroupSum.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colTicketBranch, Me.colTicketRoute, Me.colTicketBus})
        Me.lstvTicketGroupSum.FullRowSelect = True
        Me.lstvTicketGroupSum.GridLines = True
        Me.lstvTicketGroupSum.HideSelection = False
        Me.lstvTicketGroupSum.Location = New System.Drawing.Point(240, 7)
        Me.lstvTicketGroupSum.Name = "lstvTicketGroupSum"
        Me.lstvTicketGroupSum.Size = New System.Drawing.Size(281, 452)
        Me.lstvTicketGroupSum.TabIndex = 1
        Me.lstvTicketGroupSum.UseCompatibleStateImageBehavior = False
        Me.lstvTicketGroupSum.View = System.Windows.Forms.View.Details
        '
        'colTicketBranch
        '
        Me.colTicketBranch.Text = "Branch"
        Me.colTicketBranch.Width = 69
        '
        'colTicketRoute
        '
        Me.colTicketRoute.Text = "Route"
        Me.colTicketRoute.Width = 72
        '
        'colTicketBus
        '
        Me.colTicketBus.Text = "Total Bus"
        Me.colTicketBus.Width = 95
        '
        'lstFileTicket
        '
        Me.lstFileTicket.FormattingEnabled = True
        Me.lstFileTicket.ItemHeight = 20
        Me.lstFileTicket.Location = New System.Drawing.Point(3, 70)
        Me.lstFileTicket.Name = "lstFileTicket"
        Me.lstFileTicket.Size = New System.Drawing.Size(227, 304)
        Me.lstFileTicket.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnUpdateBranch)
        Me.TabPage2.Controls.Add(Me.lblGenDisplay)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.lstGenFile)
        Me.TabPage2.Controls.Add(Me.btnAnalyzeFile)
        Me.TabPage2.Controls.Add(Me.lstvBranchChacker)
        Me.TabPage2.Controls.Add(Me.lstDateGen)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txtGenEnd)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.btnGenDate)
        Me.TabPage2.Controls.Add(Me.txtGenStart)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1039, 468)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Branch Checker"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnUpdateBranch
        '
        Me.btnUpdateBranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateBranch.Location = New System.Drawing.Point(776, 73)
        Me.btnUpdateBranch.Name = "btnUpdateBranch"
        Me.btnUpdateBranch.Size = New System.Drawing.Size(256, 59)
        Me.btnUpdateBranch.TabIndex = 17
        Me.btnUpdateBranch.Text = "Update Branch"
        Me.btnUpdateBranch.UseVisualStyleBackColor = True
        '
        'lblGenDisplay
        '
        Me.lblGenDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenDisplay.Location = New System.Drawing.Point(776, 408)
        Me.lblGenDisplay.Name = "lblGenDisplay"
        Me.lblGenDisplay.Size = New System.Drawing.Size(256, 52)
        Me.lblGenDisplay.TabIndex = 16
        Me.lblGenDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(776, 388)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(260, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Date Checker"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstGenFile
        '
        Me.lstGenFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGenFile.FormattingEnabled = True
        Me.lstGenFile.ItemHeight = 29
        Me.lstGenFile.Location = New System.Drawing.Point(6, 281)
        Me.lstGenFile.Name = "lstGenFile"
        Me.lstGenFile.Size = New System.Drawing.Size(367, 178)
        Me.lstGenFile.TabIndex = 14
        '
        'btnAnalyzeFile
        '
        Me.btnAnalyzeFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnalyzeFile.Location = New System.Drawing.Point(776, 8)
        Me.btnAnalyzeFile.Name = "btnAnalyzeFile"
        Me.btnAnalyzeFile.Size = New System.Drawing.Size(256, 59)
        Me.btnAnalyzeFile.TabIndex = 13
        Me.btnAnalyzeFile.Text = "Analyze File"
        Me.btnAnalyzeFile.UseVisualStyleBackColor = True
        '
        'lstvBranchChacker
        '
        Me.lstvBranchChacker.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colGenDate, Me.colGenBranch, Me.colGenRoute, Me.colGenBus})
        Me.lstvBranchChacker.FullRowSelect = True
        Me.lstvBranchChacker.GridLines = True
        Me.lstvBranchChacker.HideSelection = False
        Me.lstvBranchChacker.Location = New System.Drawing.Point(379, 8)
        Me.lstvBranchChacker.Name = "lstvBranchChacker"
        Me.lstvBranchChacker.Size = New System.Drawing.Size(391, 452)
        Me.lstvBranchChacker.TabIndex = 12
        Me.lstvBranchChacker.UseCompatibleStateImageBehavior = False
        Me.lstvBranchChacker.View = System.Windows.Forms.View.Details
        '
        'colGenDate
        '
        Me.colGenDate.Text = "Date"
        Me.colGenDate.Width = 91
        '
        'colGenBranch
        '
        Me.colGenBranch.Text = "Branch"
        Me.colGenBranch.Width = 84
        '
        'colGenRoute
        '
        Me.colGenRoute.Text = "Route"
        Me.colGenRoute.Width = 82
        '
        'colGenBus
        '
        Me.colGenBus.Text = "BusID"
        Me.colGenBus.Width = 118
        '
        'lstDateGen
        '
        Me.lstDateGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDateGen.FormattingEnabled = True
        Me.lstDateGen.ItemHeight = 29
        Me.lstDateGen.Location = New System.Drawing.Point(6, 66)
        Me.lstDateGen.Name = "lstDateGen"
        Me.lstDateGen.Size = New System.Drawing.Size(264, 207)
        Me.lstDateGen.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(141, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "End"
        '
        'txtGenEnd
        '
        Me.txtGenEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGenEnd.Location = New System.Drawing.Point(141, 26)
        Me.txtGenEnd.Name = "txtGenEnd"
        Me.txtGenEnd.Size = New System.Drawing.Size(129, 34)
        Me.txtGenEnd.TabIndex = 9
        Me.txtGenEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Start"
        '
        'btnGenDate
        '
        Me.btnGenDate.Location = New System.Drawing.Point(276, 28)
        Me.btnGenDate.Name = "btnGenDate"
        Me.btnGenDate.Size = New System.Drawing.Size(98, 32)
        Me.btnGenDate.TabIndex = 7
        Me.btnGenDate.Text = "Generate"
        Me.btnGenDate.UseVisualStyleBackColor = True
        '
        'txtGenStart
        '
        Me.txtGenStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGenStart.Location = New System.Drawing.Point(6, 26)
        Me.txtGenStart.Name = "txtGenStart"
        Me.txtGenStart.Size = New System.Drawing.Size(129, 34)
        Me.txtGenStart.TabIndex = 6
        Me.txtGenStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.chkShortALert)
        Me.TabPage3.Controls.Add(Me.chkAutoMoveShuttleBus)
        Me.TabPage3.Controls.Add(Me.btnMoveData)
        Me.TabPage3.Controls.Add(Me.btnReorderRoute)
        Me.TabPage3.Controls.Add(Me.chkAutoAddRoute)
        Me.TabPage3.Controls.Add(Me.lstNewRoute)
        Me.TabPage3.Controls.Add(Me.btnCheckNewRoute)
        Me.TabPage3.Controls.Add(Me.chkAlertNewRoute)
        Me.TabPage3.Controls.Add(Me.chkUpdateBranch)
        Me.TabPage3.Controls.Add(Me.lblFileCHeckDisplay)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.chkAutoCheck)
        Me.TabPage3.Controls.Add(Me.chkSendToLine)
        Me.TabPage3.Controls.Add(Me.btnCheckFile)
        Me.TabPage3.Controls.Add(Me.lstvCheckFile)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.txtCheckDate)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1039, 468)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "File Checker"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'chkAutoMoveShuttleBus
        '
        Me.chkAutoMoveShuttleBus.AutoSize = True
        Me.chkAutoMoveShuttleBus.Location = New System.Drawing.Point(761, 177)
        Me.chkAutoMoveShuttleBus.Name = "chkAutoMoveShuttleBus"
        Me.chkAutoMoveShuttleBus.Size = New System.Drawing.Size(237, 24)
        Me.chkAutoMoveShuttleBus.TabIndex = 26
        Me.chkAutoMoveShuttleBus.Text = "Auto Move GAS ShuttleBus"
        Me.chkAutoMoveShuttleBus.UseVisualStyleBackColor = True
        '
        'btnMoveData
        '
        Me.btnMoveData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveData.Location = New System.Drawing.Point(723, 315)
        Me.btnMoveData.Name = "btnMoveData"
        Me.btnMoveData.Size = New System.Drawing.Size(274, 54)
        Me.btnMoveData.TabIndex = 25
        Me.btnMoveData.Text = "Manager GAS Data"
        Me.btnMoveData.UseVisualStyleBackColor = True
        '
        'btnReorderRoute
        '
        Me.btnReorderRoute.Location = New System.Drawing.Point(434, 47)
        Me.btnReorderRoute.Name = "btnReorderRoute"
        Me.btnReorderRoute.Size = New System.Drawing.Size(175, 32)
        Me.btnReorderRoute.TabIndex = 24
        Me.btnReorderRoute.Text = "Reorder Route"
        Me.btnReorderRoute.UseVisualStyleBackColor = True
        '
        'chkAutoAddRoute
        '
        Me.chkAutoAddRoute.AutoSize = True
        Me.chkAutoAddRoute.Location = New System.Drawing.Point(761, 147)
        Me.chkAutoAddRoute.Name = "chkAutoAddRoute"
        Me.chkAutoAddRoute.Size = New System.Drawing.Size(186, 24)
        Me.chkAutoAddRoute.TabIndex = 23
        Me.chkAutoAddRoute.Text = "Auto Add New Route"
        Me.chkAutoAddRoute.UseVisualStyleBackColor = True
        '
        'lstNewRoute
        '
        Me.lstNewRoute.FormattingEnabled = True
        Me.lstNewRoute.ItemHeight = 20
        Me.lstNewRoute.Location = New System.Drawing.Point(433, 95)
        Me.lstNewRoute.Name = "lstNewRoute"
        Me.lstNewRoute.Size = New System.Drawing.Size(175, 364)
        Me.lstNewRoute.TabIndex = 22
        '
        'btnCheckNewRoute
        '
        Me.btnCheckNewRoute.Location = New System.Drawing.Point(434, 8)
        Me.btnCheckNewRoute.Name = "btnCheckNewRoute"
        Me.btnCheckNewRoute.Size = New System.Drawing.Size(175, 32)
        Me.btnCheckNewRoute.TabIndex = 21
        Me.btnCheckNewRoute.Text = "Check New Route"
        Me.btnCheckNewRoute.UseVisualStyleBackColor = True
        '
        'chkAlertNewRoute
        '
        Me.chkAlertNewRoute.AutoSize = True
        Me.chkAlertNewRoute.Location = New System.Drawing.Point(761, 117)
        Me.chkAlertNewRoute.Name = "chkAlertNewRoute"
        Me.chkAlertNewRoute.Size = New System.Drawing.Size(180, 24)
        Me.chkAlertNewRoute.TabIndex = 20
        Me.chkAlertNewRoute.Text = "New Route Checker"
        Me.chkAlertNewRoute.UseVisualStyleBackColor = True
        '
        'chkUpdateBranch
        '
        Me.chkUpdateBranch.AutoSize = True
        Me.chkUpdateBranch.Location = New System.Drawing.Point(761, 87)
        Me.chkUpdateBranch.Name = "chkUpdateBranch"
        Me.chkUpdateBranch.Size = New System.Drawing.Size(182, 24)
        Me.chkUpdateBranch.TabIndex = 19
        Me.chkUpdateBranch.Text = "Auto Update Branch"
        Me.chkUpdateBranch.UseVisualStyleBackColor = True
        '
        'lblFileCHeckDisplay
        '
        Me.lblFileCHeckDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileCHeckDisplay.Location = New System.Drawing.Point(777, 407)
        Me.lblFileCHeckDisplay.Name = "lblFileCHeckDisplay"
        Me.lblFileCHeckDisplay.Size = New System.Drawing.Size(256, 52)
        Me.lblFileCHeckDisplay.TabIndex = 18
        Me.lblFileCHeckDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(777, 387)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(260, 20)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "File Date Checker"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkAutoCheck
        '
        Me.chkAutoCheck.AutoSize = True
        Me.chkAutoCheck.Location = New System.Drawing.Point(761, 27)
        Me.chkAutoCheck.Name = "chkAutoCheck"
        Me.chkAutoCheck.Size = New System.Drawing.Size(190, 24)
        Me.chkAutoCheck.TabIndex = 16
        Me.chkAutoCheck.Text = "Automatic Check File"
        Me.chkAutoCheck.UseVisualStyleBackColor = True
        '
        'chkSendToLine
        '
        Me.chkSendToLine.AutoSize = True
        Me.chkSendToLine.Location = New System.Drawing.Point(761, 57)
        Me.chkSendToLine.Name = "chkSendToLine"
        Me.chkSendToLine.Size = New System.Drawing.Size(188, 24)
        Me.chkSendToLine.TabIndex = 15
        Me.chkSendToLine.Text = "Send Result To LINE"
        Me.chkSendToLine.UseVisualStyleBackColor = True
        '
        'btnCheckFile
        '
        Me.btnCheckFile.Location = New System.Drawing.Point(323, 8)
        Me.btnCheckFile.Name = "btnCheckFile"
        Me.btnCheckFile.Size = New System.Drawing.Size(98, 32)
        Me.btnCheckFile.TabIndex = 14
        Me.btnCheckFile.Text = "Check FIle"
        Me.btnCheckFile.UseVisualStyleBackColor = True
        '
        'lstvCheckFile
        '
        Me.lstvCheckFile.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colBranchName, Me.colTicket, Me.colTrip, Me.colGas})
        Me.lstvCheckFile.FullRowSelect = True
        Me.lstvCheckFile.GridLines = True
        Me.lstvCheckFile.HideSelection = False
        Me.lstvCheckFile.Location = New System.Drawing.Point(8, 47)
        Me.lstvCheckFile.Name = "lstvCheckFile"
        Me.lstvCheckFile.Size = New System.Drawing.Size(419, 412)
        Me.lstvCheckFile.TabIndex = 13
        Me.lstvCheckFile.UseCompatibleStateImageBehavior = False
        Me.lstvCheckFile.View = System.Windows.Forms.View.Details
        '
        'colBranchName
        '
        Me.colBranchName.Text = "สาขา"
        Me.colBranchName.Width = 160
        '
        'colTicket
        '
        Me.colTicket.Text = "ตั๋ว"
        Me.colTicket.Width = 69
        '
        'colTrip
        '
        Me.colTrip.Text = "เที่ยว"
        Me.colTrip.Width = 72
        '
        'colGas
        '
        Me.colGas.Text = "ก๊าซ"
        Me.colGas.Width = 83
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Date Check"
        '
        'txtCheckDate
        '
        Me.txtCheckDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckDate.Location = New System.Drawing.Point(107, 6)
        Me.txtCheckDate.Name = "txtCheckDate"
        Me.txtCheckDate.Size = New System.Drawing.Size(180, 34)
        Me.txtCheckDate.TabIndex = 3
        Me.txtCheckDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Path File"
        '
        'txtPath
        '
        Me.txtPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPath.Location = New System.Drawing.Point(104, 10)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(469, 34)
        Me.txtPath.TabIndex = 3
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(589, 10)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(98, 32)
        Me.btnBrowse.TabIndex = 5
        Me.btnBrowse.Text = "Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'btnBreakAuto
        '
        Me.btnBreakAuto.Location = New System.Drawing.Point(850, 2)
        Me.btnBreakAuto.Name = "btnBreakAuto"
        Me.btnBreakAuto.Size = New System.Drawing.Size(206, 57)
        Me.btnBreakAuto.TabIndex = 21
        Me.btnBreakAuto.Text = "Break Mode OFF"
        Me.btnBreakAuto.UseVisualStyleBackColor = True
        '
        'chkShortALert
        '
        Me.chkShortALert.AutoSize = True
        Me.chkShortALert.Location = New System.Drawing.Point(760, 207)
        Me.chkShortALert.Name = "chkShortALert"
        Me.chkShortALert.Size = New System.Drawing.Size(224, 24)
        Me.chkShortALert.TabIndex = 27
        Me.chkShortALert.Text = "Send Message Error Only"
        Me.chkShortALert.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 562)
        Me.Controls.Add(Me.btnBreakAuto)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "File Analytic"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lstFileTicket As ListBox
    Friend WithEvents lstvTicketGroupSum As ListView
    Friend WithEvents colTicketBranch As ColumnHeader
    Friend WithEvents colTicketRoute As ColumnHeader
    Friend WithEvents colTicketBus As ColumnHeader
    Friend WithEvents btnAnalyticTicket As Button
    Friend WithEvents lstvTicketSubSum As ListView
    Friend WithEvents colTicketSubBranch As ColumnHeader
    Friend WithEvents colTicketSubRoute As ColumnHeader
    Friend WithEvents colTicketSubBus As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents dlgFolder As FolderBrowserDialog
    Friend WithEvents btnBrowse As Button
    Friend WithEvents lblBusCount As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents txtGenEnd As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnGenDate As Button
    Friend WithEvents txtGenStart As TextBox
    Friend WithEvents lstDateGen As ListBox
    Friend WithEvents lstvBranchChacker As ListView
    Friend WithEvents colGenDate As ColumnHeader
    Friend WithEvents colGenBranch As ColumnHeader
    Friend WithEvents colGenRoute As ColumnHeader
    Friend WithEvents colGenBus As ColumnHeader
    Friend WithEvents btnAnalyzeFile As Button
    Friend WithEvents lstGenFile As ListBox
    Friend WithEvents lblGenDisplay As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCheckDate As TextBox
    Friend WithEvents lstvCheckFile As ListView
    Friend WithEvents colBranchName As ColumnHeader
    Friend WithEvents colTicket As ColumnHeader
    Friend WithEvents colTrip As ColumnHeader
    Friend WithEvents colGas As ColumnHeader
    Friend WithEvents btnCheckFile As Button
    Friend WithEvents chkSendToLine As CheckBox
    Friend WithEvents chkAutoCheck As CheckBox
    Friend WithEvents btnUpdateBranch As Button
    Friend WithEvents lblFileCHeckDisplay As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents chkUpdateBranch As CheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDateSource As TextBox
    Friend WithEvents btnBreakAuto As Button
    Friend WithEvents chkAlertNewRoute As CheckBox
    Friend WithEvents btnCheckNewRoute As Button
    Friend WithEvents lstNewRoute As ListBox
    Friend WithEvents chkAutoAddRoute As CheckBox
    Friend WithEvents btnReorderRoute As Button
    Friend WithEvents btnMoveData As Button
    Friend WithEvents chkAutoMoveShuttleBus As CheckBox
    Friend WithEvents chkShortALert As CheckBox
End Class
