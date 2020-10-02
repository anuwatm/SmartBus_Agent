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
        Me.ssStatus = New System.Windows.Forms.StatusStrip()
        Me.lblMessage = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lstvPlan = New System.Windows.Forms.ListView()
        Me.colDateLog = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colRoute = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTerminal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colHour = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAmount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdLoadPlan = New System.Windows.Forms.Button()
        Me.txtDatePlan = New System.Windows.Forms.TextBox()
        Me.txtWD = New System.Windows.Forms.TextBox()
        Me.tmDelay = New System.Windows.Forms.Timer(Me.components)
        Me.btnAuto = New System.Windows.Forms.Button()
        Me.ssStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'ssStatus
        '
        Me.ssStatus.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ssStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblMessage})
        Me.ssStatus.Location = New System.Drawing.Point(0, 433)
        Me.ssStatus.Name = "ssStatus"
        Me.ssStatus.Padding = New System.Windows.Forms.Padding(2, 0, 17, 0)
        Me.ssStatus.Size = New System.Drawing.Size(769, 22)
        Me.ssStatus.TabIndex = 1
        Me.ssStatus.Text = "StatusStrip1"
        '
        'lblMessage
        '
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 16)
        '
        'lstvPlan
        '
        Me.lstvPlan.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colDateLog, Me.colRoute, Me.colTerminal, Me.colHour, Me.colAmount})
        Me.lstvPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvPlan.FullRowSelect = True
        Me.lstvPlan.GridLines = True
        Me.lstvPlan.HideSelection = False
        Me.lstvPlan.Location = New System.Drawing.Point(2, 1)
        Me.lstvPlan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstvPlan.Name = "lstvPlan"
        Me.lstvPlan.Size = New System.Drawing.Size(556, 428)
        Me.lstvPlan.TabIndex = 2
        Me.lstvPlan.UseCompatibleStateImageBehavior = False
        Me.lstvPlan.View = System.Windows.Forms.View.Details
        '
        'colDateLog
        '
        Me.colDateLog.Text = "Date"
        Me.colDateLog.Width = 107
        '
        'colRoute
        '
        Me.colRoute.Text = "Route"
        Me.colRoute.Width = 89
        '
        'colTerminal
        '
        Me.colTerminal.Text = "Terminal"
        Me.colTerminal.Width = 88
        '
        'colHour
        '
        Me.colHour.Text = "Hour"
        Me.colHour.Width = 77
        '
        'colAmount
        '
        Me.colAmount.Text = "Amount"
        Me.colAmount.Width = 112
        '
        'cmdLoadPlan
        '
        Me.cmdLoadPlan.Location = New System.Drawing.Point(564, 91)
        Me.cmdLoadPlan.Name = "cmdLoadPlan"
        Me.cmdLoadPlan.Size = New System.Drawing.Size(188, 49)
        Me.cmdLoadPlan.TabIndex = 3
        Me.cmdLoadPlan.Text = "Load Plan"
        Me.cmdLoadPlan.UseVisualStyleBackColor = True
        '
        'txtDatePlan
        '
        Me.txtDatePlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatePlan.Location = New System.Drawing.Point(564, 51)
        Me.txtDatePlan.Name = "txtDatePlan"
        Me.txtDatePlan.Size = New System.Drawing.Size(188, 34)
        Me.txtDatePlan.TabIndex = 6
        Me.txtDatePlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtWD
        '
        Me.txtWD.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWD.Location = New System.Drawing.Point(564, 12)
        Me.txtWD.Name = "txtWD"
        Me.txtWD.Size = New System.Drawing.Size(188, 34)
        Me.txtWD.TabIndex = 7
        Me.txtWD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tmDelay
        '
        Me.tmDelay.Interval = 1000
        '
        'btnAuto
        '
        Me.btnAuto.Location = New System.Drawing.Point(569, 146)
        Me.btnAuto.Name = "btnAuto"
        Me.btnAuto.Size = New System.Drawing.Size(188, 49)
        Me.btnAuto.TabIndex = 8
        Me.btnAuto.Text = "Stop Auto"
        Me.btnAuto.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 455)
        Me.Controls.Add(Me.btnAuto)
        Me.Controls.Add(Me.txtWD)
        Me.Controls.Add(Me.txtDatePlan)
        Me.Controls.Add(Me.cmdLoadPlan)
        Me.Controls.Add(Me.lstvPlan)
        Me.Controls.Add(Me.ssStatus)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Generate Plan"
        Me.ssStatus.ResumeLayout(False)
        Me.ssStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ssStatus As StatusStrip
    Friend WithEvents lstvPlan As ListView
    Friend WithEvents colDateLog As ColumnHeader
    Friend WithEvents colRoute As ColumnHeader
    Friend WithEvents colTerminal As ColumnHeader
    Friend WithEvents colHour As ColumnHeader
    Friend WithEvents colAmount As ColumnHeader
    Friend WithEvents cmdLoadPlan As Button
    Friend WithEvents txtDatePlan As TextBox
    Friend WithEvents lblMessage As ToolStripStatusLabel
    Friend WithEvents txtWD As TextBox
    Friend WithEvents tmDelay As Timer
    Friend WithEvents btnAuto As Button
End Class
