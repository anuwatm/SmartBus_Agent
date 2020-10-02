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
        Me.cmdTestDB = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdSettleWP = New System.Windows.Forms.Button()
        Me.cmdExportReport = New System.Windows.Forms.Button()
        Me.tabReview = New System.Windows.Forms.TabControl()
        Me.tSettlement = New System.Windows.Forms.TabPage()
        Me.lstvSettlement = New System.Windows.Forms.ListView()
        Me.colCheckSum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colRoute = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colReader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCardID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTrans = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSale = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAmount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tSumTrans = New System.Windows.Forms.TabPage()
        Me.lstvSumTrans = New System.Windows.Forms.ListView()
        Me.colsumDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colsumRoute = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSumBus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDirection = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colsumAddVal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colsumDeduct = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colsumRebate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colsumNewCard = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTotalDeduct = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTotalAdd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTotalNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tPassengerLog = New System.Windows.Forms.TabPage()
        Me.lstvPassengerLog = New System.Windows.Forms.ListView()
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tIncomeByBus = New System.Windows.Forms.TabPage()
        Me.lstvIncomeBus = New System.Windows.Forms.ListView()
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader26 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader27 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader28 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tPassengerCount = New System.Windows.Forms.TabPage()
        Me.lstvPassengerUpDown = New System.Windows.Forms.ListView()
        Me.colPassDateLog = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPassenRoute = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPassenBus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPassenStation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPassenAmount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPassStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tCashflow = New System.Windows.Forms.TabPage()
        Me.lstvCashflow = New System.Windows.Forms.ListView()
        Me.colCashDay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCashMonth = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCashYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCashHour = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCashTransID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCashSPID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCashcardType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCashRoute = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCashBus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCashStation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCashTotalTrans = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCashSale = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCashTotalAmount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCashdSettlement = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tPassengerFlow = New System.Windows.Forms.TabPage()
        Me.lstvPassenger = New System.Windows.Forms.ListView()
        Me.colPassDay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPassMonth = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPassYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPassHour = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPassTrans = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPassSPID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPassRoute = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPassBus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPassStation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPassCount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdTranferOK = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblCounter = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmdReCalc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdReCalSelect = New System.Windows.Forms.Button()
        Me.mtxtSelectDate = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.tabReview.SuspendLayout()
        Me.tSettlement.SuspendLayout()
        Me.tSumTrans.SuspendLayout()
        Me.tPassengerLog.SuspendLayout()
        Me.tIncomeByBus.SuspendLayout()
        Me.tPassengerCount.SuspendLayout()
        Me.tCashflow.SuspendLayout()
        Me.tPassengerFlow.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdTestDB
        '
        Me.cmdTestDB.Location = New System.Drawing.Point(761, 12)
        Me.cmdTestDB.Name = "cmdTestDB"
        Me.cmdTestDB.Size = New System.Drawing.Size(164, 44)
        Me.cmdTestDB.TabIndex = 1
        Me.cmdTestDB.Text = "Test Connect DB"
        Me.cmdTestDB.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmdSettleWP)
        Me.GroupBox1.Location = New System.Drawing.Point(761, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 130)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Settlement"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 44)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "CCH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdSettleWP
        '
        Me.cmdSettleWP.Location = New System.Drawing.Point(6, 26)
        Me.cmdSettleWP.Name = "cmdSettleWP"
        Me.cmdSettleWP.Size = New System.Drawing.Size(152, 44)
        Me.cmdSettleWP.TabIndex = 3
        Me.cmdSettleWP.Text = "Web Portal"
        Me.cmdSettleWP.UseVisualStyleBackColor = True
        '
        'cmdExportReport
        '
        Me.cmdExportReport.Location = New System.Drawing.Point(761, 198)
        Me.cmdExportReport.Name = "cmdExportReport"
        Me.cmdExportReport.Size = New System.Drawing.Size(164, 44)
        Me.cmdExportReport.TabIndex = 4
        Me.cmdExportReport.Text = "Calc Report"
        Me.cmdExportReport.UseVisualStyleBackColor = True
        '
        'tabReview
        '
        Me.tabReview.Controls.Add(Me.tSettlement)
        Me.tabReview.Controls.Add(Me.tSumTrans)
        Me.tabReview.Controls.Add(Me.tPassengerLog)
        Me.tabReview.Controls.Add(Me.tIncomeByBus)
        Me.tabReview.Controls.Add(Me.tPassengerCount)
        Me.tabReview.Controls.Add(Me.tCashflow)
        Me.tabReview.Controls.Add(Me.tPassengerFlow)
        Me.tabReview.Location = New System.Drawing.Point(12, 12)
        Me.tabReview.Name = "tabReview"
        Me.tabReview.SelectedIndex = 0
        Me.tabReview.Size = New System.Drawing.Size(749, 506)
        Me.tabReview.TabIndex = 5
        '
        'tSettlement
        '
        Me.tSettlement.Controls.Add(Me.lstvSettlement)
        Me.tSettlement.Location = New System.Drawing.Point(4, 29)
        Me.tSettlement.Name = "tSettlement"
        Me.tSettlement.Padding = New System.Windows.Forms.Padding(3)
        Me.tSettlement.Size = New System.Drawing.Size(741, 473)
        Me.tSettlement.TabIndex = 0
        Me.tSettlement.Text = "Settlement"
        Me.tSettlement.UseVisualStyleBackColor = True
        '
        'lstvSettlement
        '
        Me.lstvSettlement.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colCheckSum, Me.colRoute, Me.colBus, Me.colReader, Me.colCardID, Me.colTrans, Me.colSale, Me.colAmount})
        Me.lstvSettlement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstvSettlement.FullRowSelect = True
        Me.lstvSettlement.GridLines = True
        Me.lstvSettlement.HideSelection = False
        Me.lstvSettlement.Location = New System.Drawing.Point(3, 3)
        Me.lstvSettlement.Name = "lstvSettlement"
        Me.lstvSettlement.Size = New System.Drawing.Size(735, 467)
        Me.lstvSettlement.TabIndex = 1
        Me.lstvSettlement.UseCompatibleStateImageBehavior = False
        Me.lstvSettlement.View = System.Windows.Forms.View.Details
        '
        'colCheckSum
        '
        Me.colCheckSum.Text = "HashKey"
        Me.colCheckSum.Width = 181
        '
        'colRoute
        '
        Me.colRoute.Text = "Route"
        '
        'colBus
        '
        Me.colBus.Text = "Bus"
        Me.colBus.Width = 50
        '
        'colReader
        '
        Me.colReader.Text = "Reader"
        Me.colReader.Width = 99
        '
        'colCardID
        '
        Me.colCardID.Text = "Card ID"
        Me.colCardID.Width = 98
        '
        'colTrans
        '
        Me.colTrans.Text = "Trans"
        Me.colTrans.Width = 59
        '
        'colSale
        '
        Me.colSale.Text = "Sale"
        '
        'colAmount
        '
        Me.colAmount.Text = "Amount"
        Me.colAmount.Width = 90
        '
        'tSumTrans
        '
        Me.tSumTrans.Controls.Add(Me.lstvSumTrans)
        Me.tSumTrans.Location = New System.Drawing.Point(4, 29)
        Me.tSumTrans.Name = "tSumTrans"
        Me.tSumTrans.Padding = New System.Windows.Forms.Padding(3)
        Me.tSumTrans.Size = New System.Drawing.Size(741, 441)
        Me.tSumTrans.TabIndex = 6
        Me.tSumTrans.Text = "Sum Trans"
        Me.tSumTrans.UseVisualStyleBackColor = True
        '
        'lstvSumTrans
        '
        Me.lstvSumTrans.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colsumDate, Me.colsumRoute, Me.colSumBus, Me.colDirection, Me.colsumAddVal, Me.colsumDeduct, Me.colsumRebate, Me.colsumNewCard, Me.colTotalDeduct, Me.colTotalAdd, Me.colTotalNew})
        Me.lstvSumTrans.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstvSumTrans.FullRowSelect = True
        Me.lstvSumTrans.GridLines = True
        Me.lstvSumTrans.HideSelection = False
        Me.lstvSumTrans.Location = New System.Drawing.Point(3, 3)
        Me.lstvSumTrans.Name = "lstvSumTrans"
        Me.lstvSumTrans.Size = New System.Drawing.Size(735, 435)
        Me.lstvSumTrans.TabIndex = 2
        Me.lstvSumTrans.UseCompatibleStateImageBehavior = False
        Me.lstvSumTrans.View = System.Windows.Forms.View.Details
        '
        'colsumDate
        '
        Me.colsumDate.Text = "dateLog"
        '
        'colsumRoute
        '
        Me.colsumRoute.Text = "Route"
        '
        'colSumBus
        '
        Me.colSumBus.Text = "BusID"
        Me.colSumBus.Width = 58
        '
        'colDirection
        '
        Me.colDirection.Text = "Direction"
        Me.colDirection.Width = 50
        '
        'colsumAddVal
        '
        Me.colsumAddVal.Text = "Add Val"
        Me.colsumAddVal.Width = 70
        '
        'colsumDeduct
        '
        Me.colsumDeduct.Text = "Deduct"
        Me.colsumDeduct.Width = 66
        '
        'colsumRebate
        '
        Me.colsumRebate.Text = "Rebate"
        Me.colsumRebate.Width = 68
        '
        'colsumNewCard
        '
        Me.colsumNewCard.Text = "new Card"
        Me.colsumNewCard.Width = 75
        '
        'colTotalDeduct
        '
        Me.colTotalDeduct.Text = "TotalDeduct"
        Me.colTotalDeduct.Width = 70
        '
        'colTotalAdd
        '
        Me.colTotalAdd.Text = "Total AddVal"
        Me.colTotalAdd.Width = 68
        '
        'colTotalNew
        '
        Me.colTotalNew.Text = "Total New"
        Me.colTotalNew.Width = 69
        '
        'tPassengerLog
        '
        Me.tPassengerLog.Controls.Add(Me.lstvPassengerLog)
        Me.tPassengerLog.Location = New System.Drawing.Point(4, 29)
        Me.tPassengerLog.Name = "tPassengerLog"
        Me.tPassengerLog.Padding = New System.Windows.Forms.Padding(3)
        Me.tPassengerLog.Size = New System.Drawing.Size(741, 441)
        Me.tPassengerLog.TabIndex = 3
        Me.tPassengerLog.Text = "Passenger Log"
        Me.tPassengerLog.UseVisualStyleBackColor = True
        '
        'lstvPassengerLog
        '
        Me.lstvPassengerLog.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader1})
        Me.lstvPassengerLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstvPassengerLog.FullRowSelect = True
        Me.lstvPassengerLog.GridLines = True
        Me.lstvPassengerLog.HideSelection = False
        Me.lstvPassengerLog.Location = New System.Drawing.Point(3, 3)
        Me.lstvPassengerLog.Name = "lstvPassengerLog"
        Me.lstvPassengerLog.Size = New System.Drawing.Size(735, 435)
        Me.lstvPassengerLog.TabIndex = 2
        Me.lstvPassengerLog.UseCompatibleStateImageBehavior = False
        Me.lstvPassengerLog.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Date"
        Me.ColumnHeader12.Width = 88
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "CardID"
        Me.ColumnHeader13.Width = 113
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Route"
        Me.ColumnHeader15.Width = 52
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Bus"
        Me.ColumnHeader16.Width = 61
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Up St."
        Me.ColumnHeader17.Width = 61
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "up Time"
        Me.ColumnHeader18.Width = 74
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "down St."
        Me.ColumnHeader19.Width = 63
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "down Time"
        Me.ColumnHeader20.Width = 88
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Amount"
        Me.ColumnHeader21.Width = 79
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "direction"
        '
        'tIncomeByBus
        '
        Me.tIncomeByBus.Controls.Add(Me.lstvIncomeBus)
        Me.tIncomeByBus.Location = New System.Drawing.Point(4, 29)
        Me.tIncomeByBus.Name = "tIncomeByBus"
        Me.tIncomeByBus.Padding = New System.Windows.Forms.Padding(3)
        Me.tIncomeByBus.Size = New System.Drawing.Size(741, 441)
        Me.tIncomeByBus.TabIndex = 4
        Me.tIncomeByBus.Text = "Income By Bus"
        Me.tIncomeByBus.UseVisualStyleBackColor = True
        '
        'lstvIncomeBus
        '
        Me.lstvIncomeBus.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24, Me.ColumnHeader25, Me.ColumnHeader26, Me.ColumnHeader27, Me.ColumnHeader28, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lstvIncomeBus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstvIncomeBus.FullRowSelect = True
        Me.lstvIncomeBus.GridLines = True
        Me.lstvIncomeBus.HideSelection = False
        Me.lstvIncomeBus.Location = New System.Drawing.Point(3, 3)
        Me.lstvIncomeBus.Name = "lstvIncomeBus"
        Me.lstvIncomeBus.Size = New System.Drawing.Size(735, 435)
        Me.lstvIncomeBus.TabIndex = 3
        Me.lstvIncomeBus.UseCompatibleStateImageBehavior = False
        Me.lstvIncomeBus.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "date"
        Me.ColumnHeader22.Width = 97
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "route"
        Me.ColumnHeader23.Width = 77
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "bus"
        Me.ColumnHeader24.Width = 75
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "direction"
        Me.ColumnHeader25.Width = 85
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "ticket"
        Me.ColumnHeader26.Width = 76
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "onBus"
        Me.ColumnHeader27.Width = 71
        '
        'ColumnHeader28
        '
        Me.ColumnHeader28.Text = "a920"
        Me.ColumnHeader28.Width = 63
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Topup+Sale"
        Me.ColumnHeader2.Width = 103
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "up"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "down"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "topup"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "saletopup"
        '
        'tPassengerCount
        '
        Me.tPassengerCount.Controls.Add(Me.lstvPassengerUpDown)
        Me.tPassengerCount.Location = New System.Drawing.Point(4, 29)
        Me.tPassengerCount.Name = "tPassengerCount"
        Me.tPassengerCount.Padding = New System.Windows.Forms.Padding(3)
        Me.tPassengerCount.Size = New System.Drawing.Size(741, 441)
        Me.tPassengerCount.TabIndex = 5
        Me.tPassengerCount.Text = "Passenger Count"
        Me.tPassengerCount.UseVisualStyleBackColor = True
        '
        'lstvPassengerUpDown
        '
        Me.lstvPassengerUpDown.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colPassDateLog, Me.colPassenRoute, Me.colPassenBus, Me.colPassenStation, Me.colPassenAmount, Me.colPassStatus})
        Me.lstvPassengerUpDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstvPassengerUpDown.FullRowSelect = True
        Me.lstvPassengerUpDown.GridLines = True
        Me.lstvPassengerUpDown.HideSelection = False
        Me.lstvPassengerUpDown.Location = New System.Drawing.Point(3, 3)
        Me.lstvPassengerUpDown.Name = "lstvPassengerUpDown"
        Me.lstvPassengerUpDown.Size = New System.Drawing.Size(735, 435)
        Me.lstvPassengerUpDown.TabIndex = 2
        Me.lstvPassengerUpDown.UseCompatibleStateImageBehavior = False
        Me.lstvPassengerUpDown.View = System.Windows.Forms.View.Details
        '
        'colPassDateLog
        '
        Me.colPassDateLog.Text = "dateLog"
        Me.colPassDateLog.Width = 108
        '
        'colPassenRoute
        '
        Me.colPassenRoute.Text = "route"
        Me.colPassenRoute.Width = 68
        '
        'colPassenBus
        '
        Me.colPassenBus.Text = "Bus"
        Me.colPassenBus.Width = 71
        '
        'colPassenStation
        '
        Me.colPassenStation.Text = "station"
        Me.colPassenStation.Width = 80
        '
        'colPassenAmount
        '
        Me.colPassenAmount.Text = "amount"
        Me.colPassenAmount.Width = 79
        '
        'colPassStatus
        '
        Me.colPassStatus.Text = "U/D"
        '
        'tCashflow
        '
        Me.tCashflow.Controls.Add(Me.lstvCashflow)
        Me.tCashflow.Location = New System.Drawing.Point(4, 29)
        Me.tCashflow.Name = "tCashflow"
        Me.tCashflow.Padding = New System.Windows.Forms.Padding(3)
        Me.tCashflow.Size = New System.Drawing.Size(741, 441)
        Me.tCashflow.TabIndex = 1
        Me.tCashflow.Text = "Cash Flow"
        Me.tCashflow.UseVisualStyleBackColor = True
        '
        'lstvCashflow
        '
        Me.lstvCashflow.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colCashDay, Me.colCashMonth, Me.colCashYear, Me.colCashHour, Me.colCashTransID, Me.colCashSPID, Me.colCashcardType, Me.colCashRoute, Me.colCashBus, Me.colCashStation, Me.colCashTotalTrans, Me.colCashSale, Me.colCashTotalAmount, Me.colCashdSettlement})
        Me.lstvCashflow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstvCashflow.FullRowSelect = True
        Me.lstvCashflow.GridLines = True
        Me.lstvCashflow.HideSelection = False
        Me.lstvCashflow.Location = New System.Drawing.Point(3, 3)
        Me.lstvCashflow.Name = "lstvCashflow"
        Me.lstvCashflow.Size = New System.Drawing.Size(735, 435)
        Me.lstvCashflow.TabIndex = 0
        Me.lstvCashflow.UseCompatibleStateImageBehavior = False
        Me.lstvCashflow.View = System.Windows.Forms.View.Details
        '
        'colCashDay
        '
        Me.colCashDay.Text = "D."
        Me.colCashDay.Width = 34
        '
        'colCashMonth
        '
        Me.colCashMonth.Text = "M."
        Me.colCashMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colCashMonth.Width = 32
        '
        'colCashYear
        '
        Me.colCashYear.Text = "Y."
        Me.colCashYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colCashYear.Width = 55
        '
        'colCashHour
        '
        Me.colCashHour.Text = "H."
        Me.colCashHour.Width = 28
        '
        'colCashTransID
        '
        Me.colCashTransID.Text = "trans"
        '
        'colCashSPID
        '
        Me.colCashSPID.Text = "SPID"
        '
        'colCashcardType
        '
        Me.colCashcardType.Text = "cType"
        Me.colCashcardType.Width = 57
        '
        'colCashRoute
        '
        Me.colCashRoute.Text = "Route"
        '
        'colCashBus
        '
        Me.colCashBus.Text = "Bus"
        Me.colCashBus.Width = 44
        '
        'colCashStation
        '
        Me.colCashStation.Text = "St."
        Me.colCashStation.Width = 42
        '
        'colCashTotalTrans
        '
        Me.colCashTotalTrans.Text = "Trans"
        '
        'colCashSale
        '
        Me.colCashSale.Text = "Sale"
        Me.colCashSale.Width = 55
        '
        'colCashTotalAmount
        '
        Me.colCashTotalAmount.Text = "Amount"
        '
        'colCashdSettlement
        '
        Me.colCashdSettlement.Text = "Date Settle"
        '
        'tPassengerFlow
        '
        Me.tPassengerFlow.Controls.Add(Me.lstvPassenger)
        Me.tPassengerFlow.Location = New System.Drawing.Point(4, 29)
        Me.tPassengerFlow.Name = "tPassengerFlow"
        Me.tPassengerFlow.Padding = New System.Windows.Forms.Padding(3)
        Me.tPassengerFlow.Size = New System.Drawing.Size(741, 441)
        Me.tPassengerFlow.TabIndex = 2
        Me.tPassengerFlow.Text = "Passenger Flow"
        Me.tPassengerFlow.UseVisualStyleBackColor = True
        '
        'lstvPassenger
        '
        Me.lstvPassenger.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colPassDay, Me.colPassMonth, Me.colPassYear, Me.colPassHour, Me.colPassTrans, Me.colPassSPID, Me.colPassRoute, Me.colPassBus, Me.colPassStation, Me.colPassCount, Me.ColumnHeader14})
        Me.lstvPassenger.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstvPassenger.FullRowSelect = True
        Me.lstvPassenger.GridLines = True
        Me.lstvPassenger.HideSelection = False
        Me.lstvPassenger.Location = New System.Drawing.Point(3, 3)
        Me.lstvPassenger.Name = "lstvPassenger"
        Me.lstvPassenger.Size = New System.Drawing.Size(735, 435)
        Me.lstvPassenger.TabIndex = 1
        Me.lstvPassenger.UseCompatibleStateImageBehavior = False
        Me.lstvPassenger.View = System.Windows.Forms.View.Details
        '
        'colPassDay
        '
        Me.colPassDay.Text = "D."
        Me.colPassDay.Width = 30
        '
        'colPassMonth
        '
        Me.colPassMonth.Text = "M."
        Me.colPassMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colPassMonth.Width = 32
        '
        'colPassYear
        '
        Me.colPassYear.Text = "Y."
        Me.colPassYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colPassYear.Width = 55
        '
        'colPassHour
        '
        Me.colPassHour.Text = "H."
        Me.colPassHour.Width = 41
        '
        'colPassTrans
        '
        Me.colPassTrans.Text = "trans"
        Me.colPassTrans.Width = 66
        '
        'colPassSPID
        '
        Me.colPassSPID.Text = "SPID"
        Me.colPassSPID.Width = 72
        '
        'colPassRoute
        '
        Me.colPassRoute.Text = "Route"
        Me.colPassRoute.Width = 70
        '
        'colPassBus
        '
        Me.colPassBus.Text = "Bus"
        Me.colPassBus.Width = 44
        '
        'colPassStation
        '
        Me.colPassStation.Text = "St."
        Me.colPassStation.Width = 56
        '
        'colPassCount
        '
        Me.colPassCount.Text = "count"
        Me.colPassCount.Width = 87
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Date Settle"
        Me.ColumnHeader14.Width = 121
        '
        'cmdTranferOK
        '
        Me.cmdTranferOK.Location = New System.Drawing.Point(763, 470)
        Me.cmdTranferOK.Name = "cmdTranferOK"
        Me.cmdTranferOK.Size = New System.Drawing.Size(164, 44)
        Me.cmdTranferOK.TabIndex = 7
        Me.cmdTranferOK.Text = "Tranfer OK Table"
        Me.cmdTranferOK.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblCounter})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 521)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(937, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblCounter
        '
        Me.lblCounter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(0, 16)
        '
        'cmdReCalc
        '
        Me.cmdReCalc.Location = New System.Drawing.Point(758, 248)
        Me.cmdReCalc.Name = "cmdReCalc"
        Me.cmdReCalc.Size = New System.Drawing.Size(167, 42)
        Me.cmdReCalc.TabIndex = 9
        Me.cmdReCalc.Text = "Re Calc Report All"
        Me.cmdReCalc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(763, 312)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Start Date"
        '
        'cmdReCalSelect
        '
        Me.cmdReCalSelect.Location = New System.Drawing.Point(763, 371)
        Me.cmdReCalSelect.Name = "cmdReCalSelect"
        Me.cmdReCalSelect.Size = New System.Drawing.Size(167, 42)
        Me.cmdReCalSelect.TabIndex = 14
        Me.cmdReCalSelect.Text = "Re Calc Report"
        Me.cmdReCalSelect.UseVisualStyleBackColor = True
        '
        'mtxtSelectDate
        '
        Me.mtxtSelectDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtSelectDate.Location = New System.Drawing.Point(763, 335)
        Me.mtxtSelectDate.Mask = "####-##-##"
        Me.mtxtSelectDate.Name = "mtxtSelectDate"
        Me.mtxtSelectDate.Size = New System.Drawing.Size(167, 30)
        Me.mtxtSelectDate.TabIndex = 15
        Me.mtxtSelectDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(937, 543)
        Me.Controls.Add(Me.mtxtSelectDate)
        Me.Controls.Add(Me.cmdReCalSelect)
        Me.Controls.Add(Me.cmdReCalc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.cmdTranferOK)
        Me.Controls.Add(Me.tabReview)
        Me.Controls.Add(Me.cmdExportReport)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdTestDB)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settlement Manage"
        Me.GroupBox1.ResumeLayout(False)
        Me.tabReview.ResumeLayout(False)
        Me.tSettlement.ResumeLayout(False)
        Me.tSumTrans.ResumeLayout(False)
        Me.tPassengerLog.ResumeLayout(False)
        Me.tIncomeByBus.ResumeLayout(False)
        Me.tPassengerCount.ResumeLayout(False)
        Me.tCashflow.ResumeLayout(False)
        Me.tPassengerFlow.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdTestDB As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cmdSettleWP As Button
    Friend WithEvents cmdExportReport As Button
    Friend WithEvents tabReview As TabControl
    Friend WithEvents tSettlement As TabPage
    Friend WithEvents lstvSettlement As ListView
    Friend WithEvents colCheckSum As ColumnHeader
    Friend WithEvents colRoute As ColumnHeader
    Friend WithEvents colBus As ColumnHeader
    Friend WithEvents colReader As ColumnHeader
    Friend WithEvents colCardID As ColumnHeader
    Friend WithEvents colTrans As ColumnHeader
    Friend WithEvents colSale As ColumnHeader
    Friend WithEvents colAmount As ColumnHeader
    Friend WithEvents tCashflow As TabPage
    Friend WithEvents lstvCashflow As ListView
    Friend WithEvents colCashDay As ColumnHeader
    Friend WithEvents colCashMonth As ColumnHeader
    Friend WithEvents colCashYear As ColumnHeader
    Friend WithEvents colCashHour As ColumnHeader
    Friend WithEvents colCashTransID As ColumnHeader
    Friend WithEvents colCashSPID As ColumnHeader
    Friend WithEvents colCashcardType As ColumnHeader
    Friend WithEvents colCashRoute As ColumnHeader
    Friend WithEvents colCashBus As ColumnHeader
    Friend WithEvents colCashStation As ColumnHeader
    Friend WithEvents colCashTotalTrans As ColumnHeader
    Friend WithEvents colCashSale As ColumnHeader
    Friend WithEvents colCashTotalAmount As ColumnHeader
    Friend WithEvents colCashdSettlement As ColumnHeader
    Friend WithEvents tPassengerFlow As TabPage
    Friend WithEvents lstvPassenger As ListView
    Friend WithEvents colPassDay As ColumnHeader
    Friend WithEvents colPassMonth As ColumnHeader
    Friend WithEvents colPassYear As ColumnHeader
    Friend WithEvents colPassHour As ColumnHeader
    Friend WithEvents colPassTrans As ColumnHeader
    Friend WithEvents colPassSPID As ColumnHeader
    Friend WithEvents colPassRoute As ColumnHeader
    Friend WithEvents colPassBus As ColumnHeader
    Friend WithEvents colPassStation As ColumnHeader
    Friend WithEvents colPassCount As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents cmdTranferOK As Button
    Friend WithEvents tPassengerLog As TabPage
    Friend WithEvents lstvPassengerLog As ListView
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents ColumnHeader17 As ColumnHeader
    Friend WithEvents ColumnHeader18 As ColumnHeader
    Friend WithEvents ColumnHeader19 As ColumnHeader
    Friend WithEvents ColumnHeader20 As ColumnHeader
    Friend WithEvents ColumnHeader21 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Timer1 As Timer
    Friend WithEvents tIncomeByBus As TabPage
    Friend WithEvents lstvIncomeBus As ListView
    Friend WithEvents ColumnHeader22 As ColumnHeader
    Friend WithEvents ColumnHeader23 As ColumnHeader
    Friend WithEvents ColumnHeader24 As ColumnHeader
    Friend WithEvents ColumnHeader25 As ColumnHeader
    Friend WithEvents ColumnHeader26 As ColumnHeader
    Friend WithEvents ColumnHeader27 As ColumnHeader
    Friend WithEvents ColumnHeader28 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblCounter As ToolStripStatusLabel
    Friend WithEvents cmdReCalc As Button
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents tPassengerCount As TabPage
    Friend WithEvents lstvPassengerUpDown As ListView
    Friend WithEvents colPassDateLog As ColumnHeader
    Friend WithEvents colPassenRoute As ColumnHeader
    Friend WithEvents colPassenBus As ColumnHeader
    Friend WithEvents colPassenStation As ColumnHeader
    Friend WithEvents colPassenAmount As ColumnHeader
    Friend WithEvents colPassStatus As ColumnHeader
    Friend WithEvents tSumTrans As TabPage
    Friend WithEvents lstvSumTrans As ListView
    Friend WithEvents colsumDate As ColumnHeader
    Friend WithEvents colsumRoute As ColumnHeader
    Friend WithEvents colSumBus As ColumnHeader
    Friend WithEvents colDirection As ColumnHeader
    Friend WithEvents colsumAddVal As ColumnHeader
    Friend WithEvents colsumDeduct As ColumnHeader
    Friend WithEvents colsumRebate As ColumnHeader
    Friend WithEvents colsumNewCard As ColumnHeader
    Friend WithEvents colTotalDeduct As ColumnHeader
    Friend WithEvents colTotalAdd As ColumnHeader
    Friend WithEvents colTotalNew As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdReCalSelect As Button
    Friend WithEvents mtxtSelectDate As MaskedTextBox
End Class
