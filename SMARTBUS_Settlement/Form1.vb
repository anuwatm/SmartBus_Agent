Imports System.IO
Imports MySql.Data

Public Class Form1

    Structure dateSplit
        Dim day As Integer
        Dim month As Integer
        Dim year As Integer
        Dim hour As Integer
        Dim minute As Integer
        Dim second As Integer
    End Structure
    Structure passengerData
        Dim transDate As String
        Dim day As String
        Dim month As String
        Dim year As String
        Dim hour As String
        Dim route As String
        Dim bus As String
        Dim station As String
        Dim transType As String
        Dim deviceType As String
        Dim cardType As String
        Dim countPassenger As Integer
        Dim dateSettlement As String
    End Structure
    Structure IncomeBus
        Dim dateLog As String
        Dim route As String
        Dim bus As String
        Dim direction As Integer
        Dim transType As Integer
        Dim upPerson As Integer
        Dim downPerson As Integer
        Dim topupPerson As Integer
        Dim saletopupPerson As Integer
        Dim ticket As Long
        Dim onBus As Long
        Dim A920 As Long
        Dim TopupSale As Long
    End Structure
    Structure RabbitData
        Dim sourceType As String
        Dim transID As String
        Dim transDate As String
        Dim transTime As String
        Dim splitDate As dateSplit
        Dim SPid As String
        Dim reader As String
        Dim cardID As String
        Dim cardType As String
        Dim route As String
        Dim bus As String
        Dim station As String
        Dim prodUsage As String
        Dim productType As String
        Dim passType As String
        Dim transValue As String
        Dim direction As String
        Dim flag As String
        Dim saleAmount As String
        Dim empID As String
        Dim sumCheck As String
        Dim entryDateTime As String
        Dim entryStation As String
        Dim totaAmount As String
        Dim dateSettlement As String
    End Structure
    Structure sumTransDesc
        Dim dateLog As String
        Dim route As String
        Dim busID As String
        Dim direction As Integer
        Dim addValCount As Long
        Dim addValAmount As Long
        Dim deductCount As Long
        Dim deductAmount As Long
        Dim rebateCount As Long
        Dim rebateAmount As Long
        Dim newCardCount As Long
        Dim newCardAmount As Long
    End Structure
    Function splitAmount(source As String) As Long
        Dim oMaster As New mMaster
        If source.Length > 2 Then
            If source = "null" Then
                Return 0
            Else
                Return CLng(Mid(source, 1, source.Length - 2) & "." & oMaster.trimRight(source, 2))
            End If

        Else
            Return source
        End If
    End Function
    Function matchRecord(sumCheck As String, dataMatch As String) As Boolean

        Try
            Dim oMaster As New mMaster
            Dim sql As String = "select * from " & dataMatch & "_trans_temp where (sumCheck='" & sumCheck & "')"
            Dim DT As DataTable = oMaster.getData(sql)
            If Not IsNothing(DT) Then
                If (DT.Rows.Count > 0) Then
                    sql = "update web_trans_temp set statTrans=1 where (sumCheck='" & sumCheck & "')"
                    oMaster.executeSQL(sql)
                    sql = "update cch_trans_temp set statTrans=1 where (sumCheck='" & sumCheck & "')"
                    oMaster.executeSQL(sql)
                End If
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Function chkVal(data As String, Optional typeData As String = "s") As String
        If data = "" Then
            Return "null"
        Else
            Select Case typeData
                Case "s"
                    Return "'" & data & "'"
                Case Else
                    Return data
            End Select
        End If
    End Function
    Function splitDateTime(sourceDate As String, sourceTime As String) As dateSplit
        Dim dTarget As New dateSplit
        Dim oMaster As New mMaster

        With dTarget
            If sourceDate <> "" Then
                .day = Mid(sourceDate, 1, 2)
                .month = Mid(sourceDate, 3, 2)
                .year = oMaster.trimRight(sourceDate, 4)
            Else
                .day = 0
                .month = 0
                .year = 0
            End If
            If sourceTime <> "" Then
                .hour = Mid(sourceTime, 1, 2)
                .minute = Mid(sourceTime, 3, 2)
                .second = oMaster.trimRight(sourceTime, 2)
            Else
                .hour = 0
                .minute = 0
                .second = 0
            End If

        End With
        Return dTarget
    End Function
    Function getWebPortalData(DR As DataRow) As RabbitData
        Dim oData As New RabbitData
        With oData
            .sumCheck = DR("sumCheck").ToString
            .sourceType = DR("sourceType").ToString
            .transDate = DR("transDate").ToString
            .transTime = DR("transTime").ToString
            .splitDate = splitDateTime(.transDate.ToString, .transTime.ToString)
            .transID = DR("transID").ToString
            .SPid = DR("SPid").ToString
            .reader = DR("deviceID").ToString
            .cardID = DR("cardID").ToString
            .cardType = DR("cardType").ToString
            .route = DR("route").ToString
            .bus = DR("bus").ToString
            .station = DR("station").ToString
            '.prodUsage = DR("prodUsage").ToString
            .transValue = DR("transVal").ToString
            .direction = DR("direction").ToString
            .flag = DR("flag").ToString
            .saleAmount = DR("saleAmount").ToString
            .empID = DR("empID").ToString
            .productType = DR("productType").ToString
            .dateSettlement = DR("dateSettlement").ToString
        End With
        Return oData
    End Function
    Function getIncomeBus(dr As DataRow) As IncomeBus
        Dim oTmp As New IncomeBus
        Dim tDate As New dateSplit
        With oTmp
            tDate = splitDateTime(dr.Item("transDate").ToString, "000000")
            .dateLog = tDate.year & "-" & tDate.month & "-" & tDate.day
            .route = dr.Item("route").ToString
            .bus = dr.Item("route").ToString & "-" & dr.Item("bus").ToString
            .direction = dr.Item("direction").ToString
            .ticket = 0
            .transType = dr.Item("TransID").ToString
            Select Case (dr.Item("TransID").ToString)
                Case 41
                    If dr.Item("SPID").ToString = 109 Then
                        .onBus = dr.Item("transVal").ToString
                    ElseIf dr.Item("SPID").ToString = 119 Then
                        .A920 = dr.Item("transVal").ToString
                    End If
                    .upPerson = dr.Item("countTrans").ToString
                Case 92
                    If dr.Item("SPID").ToString = 109 Then
                        .onBus = 0 - CInt(dr.Item("transVal").ToString)
                    ElseIf dr.Item("SPID").ToString = 119 Then
                        .A920 = 0 - CInt(dr.Item("transVal").ToString)
                    End If
                    .downPerson = dr.Item("countTrans").ToString
                Case 31, 99
                    .TopupSale = CInt(dr.Item("transVal").ToString) + CInt(dr.Item("saleAmount").ToString)
                    If dr.Item("TransID").ToString = 31 Then
                        .topupPerson = dr.Item("countTrans").ToString
                    ElseIf dr.Item("TransID").ToString = 99 Then
                        .saletopupPerson = dr.Item("countTrans").ToString
                    End If
            End Select
            Return oTmp
        End With
    End Function
    Function getPassengerData(DR As DataRow) As passengerData
        Dim oData As passengerData

        With oData
            .transDate = DR("transDate").ToString
            .day = DR("TransDay").ToString
            .month = DR("TransMonth").ToString
            .year = DR("TransYear").ToString
            .hour = DR("TransHour").ToString
            .route = DR("route").ToString
            .bus = DR("bus").ToString
            .station = DR("station").ToString
            .transType = DR("TransID").ToString
            .deviceType = DR("SPID").ToString
            .cardType = DR("cardType").ToString
            .countPassenger = DR("countPassenger").ToString
            .dateSettlement = DR("dateSettlement").ToString
        End With

        Return oData
    End Function
    Function getReportData(DR As DataRow) As RabbitData
        Dim oData As New RabbitData
        With oData
            '.sumCheck = DR("sumCheck").ToString
            '.sourceType = DR("sourceType").ToString
            .transDate = DR("transDate").ToString
            .transTime = DR("TransHour").ToString & DR("TransMinute").ToString & "00"
            .splitDate = splitDateTime(.transDate.ToString, .transTime.ToString)
            .transID = DR("transID").ToString
            .SPid = DR("SPid").ToString
            '.reader = DR("deviceID").ToString
            '.cardID = DR("cardID").ToString
            .cardType = DR("cardType").ToString
            .route = DR("route").ToString
            .bus = DR("bus").ToString
            .station = DR("station").ToString
            '.prodUsage = DR("prodUsage").ToString
            .transValue = DR("totalTrans").ToString
            '.direction = DR("direction").ToString
            '.flag = DR("flag").ToString
            .saleAmount = DR("totalSale").ToString
            '.empID = DR("empID").ToString
            .totaAmount = CLng(.transValue) + CLng(.saleAmount)
            '.productType = DR("productType").ToString
            .dateSettlement = DR("dateSettlement").ToString
        End With
        Return oData
    End Function
    Function getCCHPortalData(DR As DataRow) As RabbitData
        Dim oData As New RabbitData
        With oData
            .sumCheck = DR("sumCheck").ToString
            .sourceType = DR("sourceType").ToString
            .transDate = DR("transDate").ToString
            .transTime = DR("transTime").ToString
            .splitDate = splitDateTime(.transDate.ToString, .transTime.ToString)
            .transID = DR("transID").ToString
            .SPid = DR("SPid").ToString
            .reader = DR("deviceID").ToString
            .cardID = DR("cardID").ToString
            .cardType = DR("cardType").ToString
            .route = DR("route").ToString
            .bus = DR("bus").ToString
            .station = DR("station").ToString
            '.prodUsage = DR("prodUsage").ToString
            .transValue = DR("transVal").ToString
            .direction = DR("direction").ToString
            .flag = DR("flag").ToString
            .saleAmount = DR("saleAmount").ToString
            .empID = DR("empID").ToString
            .productType = DR("productType").ToString
            .dateSettlement = DR("dateSettlement").ToString
        End With
        Return oData
    End Function
    Function getCashType(transType As Integer) As String
        Dim oMaster As New mMaster
        Dim DT As DataTable

        DT = oMaster.getData("select * from transaction where transID=" & transType)
        If DT Is Nothing Then
            Return ""
        Else
            Select Case DT.Rows(0).Item("transType").ToString
                Case "1"
                    Return ""
                Case "2"
                    Return "-"
            End Select
        End If
    End Function
    Private Sub cmdTestDB_Click(sender As Object, e As EventArgs) Handles cmdTestDB.Click
        Dim oMaster As New mMaster
        Dim oDB As New MySql.Data.MySqlClient.MySqlConnection(oMaster.getINIValue("db", "Connection"))

        oDB.Open()
        MessageBox.Show(oDB.ConnectionString & vbCrLf & "Connect Stat : " & oDB.State.ToString)
    End Sub

    Private Sub cmdSettleWP_Click(sender As Object, e As EventArgs) Handles cmdSettleWP.Click
        Dim oMaster As New mMaster
        Dim DT As DataTable

        Dim sql As String = "select * from web_trans_temp where (statTrans=0) order by transDate,transTime"
        DT = oMaster.getData(sql)

        With lstvSettlement
            .Items.Clear()
            If Not IsNothing(DT) Then
                For int1 As Integer = 0 To DT.Rows.Count - 1
                    Dim dRabbit As RabbitData = getWebPortalData(DT.Rows(int1))
                    .Items.Add(dRabbit.sumCheck)
                    .Items(.Items.Count - 1).SubItems.Add(dRabbit.route)
                    .Items(.Items.Count - 1).SubItems.Add(dRabbit.bus)
                    .Items(.Items.Count - 1).SubItems.Add(dRabbit.reader)
                    .Items(.Items.Count - 1).SubItems.Add(dRabbit.cardID)
                    .Items(.Items.Count - 1).SubItems.Add(dRabbit.transID)
                    .Items(.Items.Count - 1).SubItems.Add(dRabbit.saleAmount)
                    .Items(.Items.Count - 1).SubItems.Add(dRabbit.transValue)
                Next
            End If

            lblCounter.Text = "WP " & .Items.Count & " rec."
            StatusStrip1.Refresh()
            'lblCounter.Refresh()
            .Refresh()
            For int1 As Integer = 0 To lstvSettlement.Items.Count - 1
                lblCounter.Text = int1 & "/" & .Items.Count & " rec."
                StatusStrip1.Refresh()
                'lblCounter.Refresh()
                If (matchRecord(.Items(int1).Text, "cch")) Then
                    .Items(int1).Font = New System.Drawing.Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Strikeout)
                    .Items(int1).ForeColor = Color.Red
                    .Refresh()
                End If
            Next
        End With
    End Sub

    Private Sub lstvSettlement_DoubleClick(sender As Object, e As EventArgs)
        Clipboard.SetText(lstvSettlement.SelectedItems(0).Text)
        MessageBox.Show("Copy sumCheck =>" & lstvSettlement.SelectedItems(0).Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oMaster As New mMaster
        Dim DT As DataTable

        Dim sql As String = "select * from CCH_trans_temp where (statTrans=0) order by transDate,transTime"
        DT = oMaster.getData(sql)

        With lstvSettlement
            .Items.Clear()
            If Not IsNothing(DT) Then
                For int1 As Integer = 0 To DT.Rows.Count - 1
                    Dim dRabbit As RabbitData = getCCHPortalData(DT.Rows(int1))
                    .Items.Add(dRabbit.sumCheck)
                    .Items(.Items.Count - 1).SubItems.Add(dRabbit.route)
                    .Items(.Items.Count - 1).SubItems.Add(dRabbit.bus)
                    .Items(.Items.Count - 1).SubItems.Add(dRabbit.reader)
                    .Items(.Items.Count - 1).SubItems.Add(dRabbit.cardID)
                    .Items(.Items.Count - 1).SubItems.Add(dRabbit.transID)
                    .Items(.Items.Count - 1).SubItems.Add(dRabbit.saleAmount)
                    .Items(.Items.Count - 1).SubItems.Add(dRabbit.transValue)
                Next
            End If
            lblCounter.Text = "CCH " & lstvSettlement.Items.Count & " rec."
            .Refresh()
            For int1 As Integer = 0 To lstvSettlement.Items.Count - 1
                lblCounter.Text = int1 & "/" & .Items.Count & " rec."
                StatusStrip1.Refresh()
                'lblCounter.Refresh()
                If (matchRecord(.Items(int1).Text, "web")) Then
                    .Items(int1).Font = New System.Drawing.Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Strikeout)
                    .Items(int1).ForeColor = Color.Red
                    .Refresh()
                End If
            Next
        End With
    End Sub
    Sub updateCashflow(Optional reCalc As Integer = 0)
        Dim oMaster As New mMaster
        Dim sql As String = ""
        Dim DT As DataTable

        If reCalc = 0 Then
            sql = "select * from vcalccashflow"
        Else
            sql = "select * from vcalccashflow_ok"
        End If
        'sql = "select * from vcalccashflow"

        'sql = "select transDate,TransDay,TransMonth,TransYear,TransHour,TransID,SPID,cardType,route,bus,station,sum(transVal) AS totalTrans,sum(saleAmount) AS totalSale,(sum(transVal) + sum(saleAmount)) AS totaAmount,dateSettlement "
        'sql = sql & " from web_trans_temp where (statTrans = 1) group by transDate,TransDay,TransMonth,TransYear,TransHour,TransMinute,TransID,SPID,cardType,route,bus,station"

        DT = oMaster.getData(sql)
        With lstvCashflow
            .Items.Clear()
            If Not IsNothing(DT) Then
                For int1 As Integer = 0 To DT.Rows.Count - 1
                    Dim oData As RabbitData = getReportData(DT.Rows(int1))
                    If oData.route <> "" And oData.bus <> "" Then
                        .Items.Add(DT.Rows(int1).Item("TransDay").ToString)
                        '.Items.Add(oData.splitDate.day)
                        .Items(.Items.Count - 1).Tag = DT.Rows(int1).Item("transDate").ToString
                        '.Items(.Items.Count - 1).Tag = oData.transDate
                        .Items(.Items.Count - 1).SubItems.Add(DT.Rows(int1).Item("TransMonth").ToString)
                        '.Items(.Items.Count - 1).SubItems.Add(oData.splitDate.month)
                        .Items(.Items.Count - 1).SubItems.Add(DT.Rows(int1).Item("TransYear").ToString)
                        '.Items(.Items.Count - 1).SubItems.Add(oData.splitDate.year)
                        .Items(.Items.Count - 1).SubItems.Add(DT.Rows(int1).Item("TransHour").ToString)
                        '.Items(.Items.Count - 1).SubItems.Add(oData.splitDate.hour)
                        '.Items(.Items.Count - 1).SubItems.Add(DT.Rows(int1).Item("TransMinute").ToString)
                        ''.Items(.Items.Count - 1).SubItems.Add(oData.splitDate.minute)
                        .Items(.Items.Count - 1).SubItems.Add(DT.Rows(int1).Item("TransID").ToString)
                        '.Items(.Items.Count - 1).SubItems.Add(oData.transID)
                        .Items(.Items.Count - 1).SubItems.Add(DT.Rows(int1).Item("SPID").ToString)
                        '.Items(.Items.Count - 1).SubItems.Add(oData.SPid)
                        .Items(.Items.Count - 1).SubItems.Add(DT.Rows(int1).Item("cardType").ToString)
                        '.Items(.Items.Count - 1).SubItems.Add(oData.cardType)
                        .Items(.Items.Count - 1).SubItems.Add(DT.Rows(int1).Item("route").ToString)
                        '.Items(.Items.Count - 1).SubItems.Add(oData.route)
                        .Items(.Items.Count - 1).SubItems.Add(DT.Rows(int1).Item("bus").ToString)
                        '.Items(.Items.Count - 1).SubItems.Add(oData.bus)
                        .Items(.Items.Count - 1).SubItems.Add(DT.Rows(int1).Item("station").ToString)
                        '.Items(.Items.Count - 1).SubItems.Add(oData.station)
                        .Items(.Items.Count - 1).SubItems.Add(DT.Rows(int1).Item("totalTrans").ToString)
                        '.Items(.Items.Count - 1).SubItems.Add(oData.transValue)
                        .Items(.Items.Count - 1).SubItems.Add(DT.Rows(int1).Item("totalSale").ToString)
                        '.Items(.Items.Count - 1).SubItems.Add(oData.saleAmount)
                        .Items(.Items.Count - 1).SubItems.Add(getCashType(DT.Rows(int1).Item("TransID").ToString) & DT.Rows(int1).Item("totaAmount").ToString)
                        '.Items(.Items.Count - 1).SubItems.Add(oData.transValue + oData.saleAmount)
                        .Items(.Items.Count - 1).SubItems.Add(DT.Rows(int1).Item("dateSettlement").ToString)
                        '.Items(.Items.Count - 1).SubItems.Add(oData.dateSettlement)

                        lblCounter.Text = "Cashflow " & int1 & "/" & DT.Rows.Count & " rec."
                        StatusStrip1.Refresh()
                        'lblCounter.Refresh()

                        Dim sqlCri As String = " where (transDate='" & oData.transDate & "' and transHour=" & oData.splitDate.hour & " and transMinute=" & oData.splitDate.minute
                        sqlCri = sqlCri & " and transType=" & oData.transID & " and SPid=" & oData.SPid & " and cardtype=" & oData.cardType
                        sqlCri = sqlCri & " and route=" & oData.route & " and bus=" & oData.bus & " and station=" & oData.station & " and dateSettlement='" & oData.dateSettlement & "')"
                        sql = "select * from cashflow  " & sqlCri
                        Dim DTtmp As DataTable = oMaster.getData(sql)
                        If DTtmp Is Nothing Then
                            sql = "insert into cashflow (transDate,transDay,transMonth,transYear,transHour,transMinute,transType,SPid,cardtype,route,bus,station,totalTrans,totalSale,totaAmount,dateSettlement) values ("
                            sql = sql & chkVal(oData.transDate) & "," & chkVal(oData.splitDate.day, "n") & "," & chkVal(oData.splitDate.month, "n") & "," & chkVal(oData.splitDate.year, "n") & "," & chkVal(oData.splitDate.hour, "n") & "," & chkVal(oData.splitDate.minute, "n")
                            sql = sql & "," & chkVal(oData.transID, "n") & "," & chkVal(oData.SPid) & "," & chkVal(oData.cardType, "n") & "," & chkVal(oData.route) & "," & chkVal(oData.bus, "n")
                            sql = sql & "," & chkVal(oData.station, "n") & "," & chkVal(getCashType(oData.transID) & oData.transValue, "n") & "," & chkVal(oData.saleAmount, "n") & "," & chkVal(oData.totaAmount, "n") & "," & chkVal(oData.dateSettlement) & ")"
                        Else
                            If (DTtmp.Rows.Count > 0) Then
                                sql = "update cashflow set transDay=" & chkVal(oData.splitDate.day, "n") & ",transMonth=" & chkVal(oData.splitDate.month, "n") & ",transYear=" & chkVal(oData.splitDate.year, "n") & ",transHour=" & chkVal(oData.splitDate.hour, "n")
                                sql = sql & ",transMinute=" & chkVal(oData.splitDate.minute, "n") & ",transType=" & chkVal(oData.transID, "n") & ",SPid=" & chkVal(oData.SPid) & ",cardtype=" & chkVal(oData.cardType, "n") & ",route=" & chkVal(oData.route) & ",bus=" & chkVal(oData.bus, "n")
                                sql = sql & ",station=" & chkVal(oData.station, "n") & ",totalTrans=" & chkVal(getCashType(oData.transID) & oData.transValue, "n") & ",totalSale=" & chkVal(oData.saleAmount, "n") & ",totaAmount=" & chkVal(oData.totaAmount, "n") & sqlCri
                            End If
                        End If
                        Try
                            If oMaster.executeSQL(sql) Then
                                .Items(int1).Font = New System.Drawing.Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Strikeout)
                                .Items(int1).ForeColor = Color.Green
                            Else
                                .Items(int1).ForeColor = Color.Red
                            End If
                        Catch ex As Exception
                            .Items(int1).ForeColor = Color.Red
                        End Try
                    End If
                Next
            End If

            .Refresh()
        End With
    End Sub
    Sub updatePassenger(Optional reCalc As Integer = 0)
        Dim oMaster As New mMaster
        Dim sql As String = ""
        Dim DT As DataTable

        If reCalc = 0 Then
            sql = "select * from vcalcpassenger"
        Else
            sql = "select * from vcalcpassenger_ok"
        End If

        DT = oMaster.getData(sql)
        With lstvPassenger

            If Not IsNothing(DT) Then
                .Items.Clear()
                Dim oData As New passengerData
                For int1 As Integer = 0 To DT.Rows.Count - 1
                    oData = getPassengerData(DT.Rows(int1))
                    If oData.route <> "" And oData.bus <> "" Then
                        .Items.Add(oData.day)
                        .Items(.Items.Count - 1).Tag = oData.transDate
                        .Items(.Items.Count - 1).SubItems.Add(oData.month)
                        .Items(.Items.Count - 1).SubItems.Add(oData.year)
                        .Items(.Items.Count - 1).SubItems.Add(oData.hour)
                        .Items(.Items.Count - 1).SubItems.Add(oData.transType)
                        .Items(.Items.Count - 1).SubItems.Add(oData.deviceType)
                        .Items(.Items.Count - 1).SubItems.Add(oData.route)
                        .Items(.Items.Count - 1).SubItems.Add(oData.bus)
                        .Items(.Items.Count - 1).SubItems.Add(oData.station)
                        .Items(.Items.Count - 1).SubItems.Add(oData.countPassenger)
                        .Items(.Items.Count - 1).SubItems.Add(oData.dateSettlement)

                        lblCounter.Text = "Passen. " & int1 & "/" & DT.Rows.Count & " rec."
                        StatusStrip1.Refresh()
                        'lblCounter.Refresh()

                        Dim sqlCri As String = ""
                        sqlCri = " where (passDate='" & oData.transDate & "' and passHour=" & oData.hour & " and transType=" & oData.transType & " and route='" & oData.route & "' and bus=" & oData.bus & " and station=" & oData.station
                        sqlCri = sqlCri & " and spid=" & oData.deviceType & " and cardType=" & oData.cardType & " and dateSettlement=" & chkVal(oData.dateSettlement) & ")"
                        sql = "select * from passengertracking " & sqlCri
                        Dim DTtmp As DataTable = oMaster.getData(sql)
                        If DTtmp Is Nothing Then
                            sql = "insert into passengertracking (passDate,passDay,passMonth,passYear,passHour,transType,spid,cardType,route,bus,station,countPassenger,dateSettlement) values ("
                            sql = sql & chkVal(oData.transDate) & "," & chkVal(oData.day, "n") & "," & chkVal(oData.month, "n") & "," & chkVal(oData.year, "n") & "," & chkVal(oData.hour, "n") & "," & chkVal(oData.transType, "n")
                            sql = sql & "," & chkVal(oData.deviceType, "n") & "," & chkVal(oData.cardType, "n") & "," & chkVal(oData.route) & "," & chkVal(oData.bus, "n") & "," & chkVal(oData.station, "n") & "," & chkVal(oData.countPassenger, "n") & "," & chkVal(oData.dateSettlement) & ")"
                        Else
                            sql = "update passengertracking set passHour=" & chkVal(oData.hour, "n") & ",transType=" & chkVal(oData.transType, "n") & ",spid=" & chkVal(oData.deviceType, "n") & ",route=" & chkVal(oData.route) & ",bus=" & chkVal(oData.bus, "n") & ",station=" & chkVal(oData.station, "n")
                            sql = sql & ",cardType=" & chkVal(oData.cardType, "n") & ",countPassenger=" & chkVal(oData.countPassenger, "n") & sqlCri
                        End If
                        Try
                            If oMaster.executeSQL(sql) Then
                                .Items(int1).Font = New System.Drawing.Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Strikeout)
                                .Items(int1).ForeColor = Color.Green
                            Else
                                .Items(int1).ForeColor = Color.Red
                            End If
                        Catch ex As Exception
                            .Items(int1).ForeColor = Color.Red
                        End Try
                    End If

                Next
            End If
        End With
    End Sub
    Sub updatePassengerLog(Optional reCalc As Integer = 0, Optional selectDate As String = "")
        Dim oMaster As New mMaster
        Dim sql As String = ""
        Dim DT As DataTable

        With lstvPassengerLog
            If reCalc = 0 Then
                DT = oMaster.getData("select * from web_trans_temp where (transID in(41,92) and statTrans = 1) order by transDate,referTrans,cardID,transTime,transID")
            Else
                If selectDate = "" Then
                    DT = oMaster.getData("select * from web_trans_ok where (transID in(41,92) and statTrans = 1) order by transDate,referTrans,cardID,transTime,transID")
                Else
                    DT = oMaster.getData("select * from web_trans_ok where (transID in(41,92) and statTrans = 1 and (transDate='" & selectDate & "')) order by transDate,referTrans,cardID,transTime,transID")
                End If
            End If

            .Items.Clear()
            Dim oData As New passengerData
            If Not IsNothing(DT) Then
                For int1 As Integer = 0 To DT.Rows.Count - 1
                    If .Items.Count < 1 Then
                        addRowPassenger(DT.Rows(int1))
                    Else
                        If DT.Rows(int1).Item("transDate").trim = .Items(.Items.Count - 1).Text And DT.Rows(int1).Item("referTrans").trim = .Items(.Items.Count - 1).Tag Then
                            If DT.Rows(int1).Item("transID") = 41 Then
                                addRowPassenger(DT.Rows(int1))
                            Else
                                updatePassenger(DT.Rows(int1))
                            End If
                            'updatePassenger(DT.Rows(int1))
                        Else
                            addRowPassenger(DT.Rows(int1))
                        End If
                    End If
                    lblCounter.Text = "Proc Passen.Log " & int1 & "/" & DT.Rows.Count & " rec."
                    StatusStrip1.Refresh()
                Next
            End If
            'Exit Sub
            lblCounter.Text = "found " & .Items.Count & " rec."
            StatusStrip1.Refresh()
            .Refresh()
            For int1 As Integer = 0 To .Items.Count - 1
                Dim Cir As String = ""
                Dim dTmp As New dateSplit
                dTmp = splitDateTime(.Items(int1).Text, "000000")
                Dim dDate As String = dTmp.year & "/" & dTmp.month & "/" & dTmp.day

                lblCounter.Text = "Passen.Log " & int1 & "/" & .Items.Count - 1 & " rec."
                StatusStrip1.Refresh()
                'lblCounter.Refresh()

                Cir = " where (transDate='" & dDate & "' and cardID='" & .Items(int1).SubItems(1).Text & "' and bus='" & .Items(int1).SubItems(3).Text & "' and "
                Cir = Cir & " upStation='" & .Items(int1).SubItems(4).Text & "' and downStation=" & chkVal(.Items(int1).SubItems(6).Text) & ")"
                sql = "select * from passengerlog " & Cir
                Dim DTtmp As DataTable = oMaster.getData(sql)
                If IsNothing(DTtmp) Then
                    sql = "insert into passengerlog (transDate,cardID,route,direction,bus,upStation,upTime,downStation,downTime,amount) values ("
                    sql = sql & chkVal(dDate) & "," & chkVal(.Items(int1).SubItems(1).Text) & "," & chkVal(.Items(int1).SubItems(2).Text) & "," & chkVal(.Items(int1).SubItems(9).Text) & ","
                    sql = sql & chkVal(.Items(int1).SubItems(3).Text) & "," & chkVal(.Items(int1).SubItems(4).Text, "n") & "," & chkVal(.Items(int1).SubItems(5).Text) & ","
                    sql = sql & chkVal(.Items(int1).SubItems(6).Text, "n") & "," & chkVal(.Items(int1).SubItems(7).Text) & "," & chkVal(.Items(int1).SubItems(8).Text, "n") & ")"
                End If
                If oMaster.executeSQL(sql) Then
                    .Items(int1).Font = New System.Drawing.Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Strikeout)
                    .Items(int1).ForeColor = Color.Green
                    '.Refresh()
                Else
                    .Items(int1).ForeColor = Color.Red
                End If
            Next
        End With
    End Sub
    Sub updatePassengerUpDown(Optional reCalc As Integer = 0, Optional dateSelect As String = "")
        Dim oMaster As New mMaster
        Dim sql As String = ""
        Dim DT As DataTable

        With lstvPassengerUpDown
            If reCalc = 0 Then
                DT = oMaster.getData("SELECT transDate,TransID,route,bus,station,Count(station) AS countPassenger FROM web_trans_temp  where (transID in(41,92) and statTrans = 1) GROUP BY transDate,TransID,route,bus,station")
            Else
                If dateSelect = "" Then
                    DT = oMaster.getData("SELECT transDate,TransID,route,bus,station,Count(station) AS countPassenger FROM web_trans_ok  where (transID in(41,92) ) GROUP BY transDate,TransID,route,bus,station")
                Else
                    DT = oMaster.getData("SELECT transDate,TransID,route,bus,station,Count(station) AS countPassenger FROM web_trans_ok  where (transID in(41,92) and transDate='" & dateSelect & "') GROUP BY transDate,TransID,route,bus,station")
                End If
            End If

            .Items.Clear()
            If IsNothing(DT) Then Exit Sub
            For int1 As Integer = 0 To DT.Rows.Count - 1
                Dim sDate As dateSplit = splitDateTime(DT.Rows(int1).Item("transDate").ToString, "000000")
                .Items.Add(sDate.year & "/" & sDate.month & "/" & sDate.day)
                .Items(.Items.Count - 1).SubItems.Add(DT.Rows(int1).Item("route").ToString)
                .Items(.Items.Count - 1).SubItems.Add(DT.Rows(int1).Item("route").ToString & "-" & DT.Rows(int1).Item("bus").ToString)
                .Items(.Items.Count - 1).SubItems.Add(DT.Rows(int1).Item("station").ToString)
                .Items(.Items.Count - 1).SubItems.Add(DT.Rows(int1).Item("countPassenger").ToString)
                Select Case DT.Rows(int1).Item("TransID").ToString
                    Case "41"
                        .Items(.Items.Count - 1).SubItems.Add("U")
                    Case "92"
                        .Items(.Items.Count - 1).SubItems.Add("D")
                End Select
                lblCounter.Text = "Passenger  " & int1 & "/" & DT.Rows.Count & " rec."
                StatusStrip1.Refresh()
            Next
            lblCounter.Text = "Total Passenger " & .Items.Count & " rec."

            For int1 As Integer = 0 To .Items.Count - 1
                Dim strTable As String = ""
                Select Case .Items(int1).SubItems(5).Text.ToUpper.Trim
                    Case "U"
                        strTable = "passengerup"
                    Case "D"
                        strTable = "passengerdown"
                End Select
                sql = "insert into " & strTable & " (dateLog,route,busID,station,amount) values ('" & .Items(int1).Text & "','" & .Items(int1).SubItems(1).Text & "','"
                sql = sql & .Items(int1).SubItems(2).Text & "'," & .Items(int1).SubItems(3).Text & "," & .Items(int1).SubItems(4).Text & ")"
                lblCounter.Text = "Update Passenger  " & int1 & "/" & DT.Rows.Count & " rec."
                StatusStrip1.Refresh()
                If oMaster.executeSQL(sql) Then
                    .Items(int1).Font = New System.Drawing.Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Strikeout)
                    .Items(int1).ForeColor = Color.Green
                    '.Refresh()
                Else
                    .Items(int1).ForeColor = Color.Red
                End If
            Next
        End With
    End Sub
    Function getSumTrans(DR As DataRow) As sumTransDesc
        Dim oTmp As New sumTransDesc
        Dim sDate As dateSplit = splitDateTime(DR.Item("transDate").ToString, "000000")
        With oTmp
            .dateLog = sDate.year & "/" & sDate.month & "/" & sDate.day
            .route = DR.Item("route").ToString
            .busID = DR.Item("route").ToString & "-" & DR.Item("bus").ToString
            .direction = DR.Item("direction").ToString
            Select Case DR.Item("TransID").ToString
                Case "31"
                    .addValAmount = DR.Item("sumVal").ToString
                    .addValCount = DR.Item("countCard").ToString
                Case "41"
                    .deductAmount = DR.Item("sumVal").ToString
                    .deductCount = DR.Item("countCard").ToString
                Case "92"
                    .rebateCount = DR.Item("countCard").ToString
                    .rebateAmount = DR.Item("sumVal").ToString
                Case "99"
                    .newCardAmount = DR.Item("sumSale").ToString
                    .newCardCount = DR.Item("countCard").ToString
            End Select
        End With
        Return oTmp
    End Function
    Sub updateSumTrans(Optional reCalc As Integer = 0, Optional dateSelect As String = "")
        Dim oMaster As New mMaster
        Dim sql As String = ""
        Dim DT As DataTable


        If reCalc = 0 Then
            sql = "SELECT transDate,route,bus,direction,TransID,Sum(transVal) AS sumVal,Sum(saleAmount) AS sumSale,Count(cardID) AS countCard FROM web_trans_temp  where statTrans=1 "
            sql = sql & "GROUP BY transDate,TransID,direction,route,bus order by transDate,route,bus,direction,TransID"
        Else
            If dateSelect = "" Then
                sql = "SELECT transDate,route,bus,direction,TransID,Sum(transVal) AS sumVal,Sum(saleAmount) AS sumSale,Count(cardID) AS countCard FROM web_trans_ok "
                sql = sql & "GROUP BY transDate,TransID,direction,route,bus order by transDate,route,bus,direction,TransID"
            Else
                sql = "SELECT transDate,route,bus,direction,TransID,Sum(transVal) AS sumVal,Sum(saleAmount) AS sumSale,Count(cardID) AS countCard FROM web_trans_ok "
                sql = sql & " where transDate='" & dateSelect & "' GROUP BY transDate,TransID,direction,route,bus order by transDate,route,bus,direction,TransID"
            End If
        End If

            DT = oMaster.getData(sql)
        With lstvSumTrans
            .Items.Clear()
            If Not IsNothing(DT) Then
                For int1 As Integer = 0 To DT.Rows.Count - 1
                    Dim dData As sumTransDesc = getSumTrans(DT.Rows(int1))
                    lblCounter.Text = "Gen Sum Trans " & int1 & "/" & DT.Rows.Count & " rec."
                    StatusStrip1.Refresh()
                    If .Items.Count < 1 Then
                        .Items.Add(dData.dateLog)
                        .Items(.Items.Count - 1).SubItems.Add(dData.route)          '1
                        .Items(.Items.Count - 1).SubItems.Add(dData.busID)          '2
                        .Items(.Items.Count - 1).SubItems.Add(dData.direction)      '3
                        .Items(.Items.Count - 1).SubItems.Add(dData.addValAmount)   '4
                        .Items(.Items.Count - 1).SubItems.Add(dData.deductAmount)   '5
                        .Items(.Items.Count - 1).SubItems.Add(dData.rebateAmount)   '6
                        .Items(.Items.Count - 1).SubItems.Add(dData.newCardAmount)  '7
                        .Items(.Items.Count - 1).SubItems.Add(dData.deductCount)    '8
                        .Items(.Items.Count - 1).SubItems.Add(dData.addValCount)    '9
                        .Items(.Items.Count - 1).SubItems.Add(dData.newCardCount)   '10
                    Else
                        If .Items(.Items.Count - 1).Text = dData.dateLog And .Items(.Items.Count - 1).SubItems(1).Text = dData.route And .Items(.Items.Count - 1).SubItems(2).Text = dData.busID _
                            And .Items(.Items.Count - 1).SubItems(3).Text = dData.direction Then
                            If dData.addValAmount > 0 Then
                                .Items(.Items.Count - 1).SubItems(4).Text = dData.addValAmount
                                .Items(.Items.Count - 1).SubItems(9).Text = dData.addValCount
                            End If
                            If dData.deductAmount > 0 Then
                                .Items(.Items.Count - 1).SubItems(5).Text = dData.deductAmount
                                .Items(.Items.Count - 1).SubItems(8).Text = dData.deductCount
                            End If
                            If dData.rebateCount > 0 Then
                                .Items(.Items.Count - 1).SubItems(6).Text = dData.rebateAmount
                            End If
                            If dData.newCardAmount > 0 Then
                                .Items(.Items.Count - 1).SubItems(7).Text = dData.newCardAmount
                                .Items(.Items.Count - 1).SubItems(10).Text = dData.newCardCount
                            End If
                        Else
                            .Items.Add(dData.dateLog)
                            .Items(.Items.Count - 1).SubItems.Add(dData.route)          '1
                            .Items(.Items.Count - 1).SubItems.Add(dData.busID)          '2
                            .Items(.Items.Count - 1).SubItems.Add(dData.direction)      '3
                            .Items(.Items.Count - 1).SubItems.Add(dData.addValAmount)   '4
                            .Items(.Items.Count - 1).SubItems.Add(dData.deductAmount)   '5
                            .Items(.Items.Count - 1).SubItems.Add(dData.rebateAmount)   '6
                            .Items(.Items.Count - 1).SubItems.Add(dData.newCardAmount)  '7
                            .Items(.Items.Count - 1).SubItems.Add(dData.deductCount)    '8
                            .Items(.Items.Count - 1).SubItems.Add(dData.addValCount)    '9
                            .Items(.Items.Count - 1).SubItems.Add(dData.newCardCount)   '10
                        End If
                    End If
                Next
                lblCounter.Text = "Start Update Data Summary Log"


                For int1 As Integer = 0 To lstvSumTrans.Items.Count - 1
                    Dim dData As sumTransDesc
                    dData.dateLog = .Items(int1).Text
                    dData.route = .Items(int1).SubItems(1).Text
                    dData.busID = .Items(int1).SubItems(2).Text
                    dData.direction = .Items(int1).SubItems(3).Text
                    dData.addValAmount = .Items(int1).SubItems(4).Text
                    dData.deductAmount = .Items(int1).SubItems(5).Text
                    dData.rebateAmount = .Items(int1).SubItems(6).Text
                    dData.newCardAmount = .Items(int1).SubItems(7).Text
                    dData.deductCount = .Items(int1).SubItems(8).Text
                    dData.addValCount = .Items(int1).SubItems(9).Text
                    dData.newCardCount = .Items(int1).SubItems(10).Text

                    sql = "insert into rabbitsummarylog (dateLog,route,busID,direction,addValAmount,deductAmount,rebateAmount,newcardAmount,deductCount,addValCount,newcardCount) values "
                    sql = sql & "('" & dData.dateLog & "','" & dData.route & "','" & dData.busID & "'," & dData.direction & "," & dData.addValAmount & "," & dData.deductAmount & ","
                    sql = sql & dData.rebateAmount & "," & dData.newCardAmount & "," & dData.deductCount & "," & dData.addValCount & "," & dData.newCardCount & ")"

                    lblCounter.Text = "Update Sum Trans => " & int1 & "/" & .Items.Count & " rec."
                    StatusStrip1.Refresh()
                    If oMaster.executeSQL(sql) Then
                        .Items(int1).Font = New System.Drawing.Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Strikeout)
                        .Items(int1).ForeColor = Color.Green
                        '.Refresh()
                    Else
                        .Items(int1).ForeColor = Color.Red
                    End If
                Next
            End If
        End With
    End Sub
    Sub UpdateIncomeByBus(Optional reCalc As Integer = 0, Optional dateSelect As String = "")
        Dim oMaster As New mMaster
        Dim sql As String = ""
        Dim DT As DataTable
        Dim dTmp As New dateSplit
        Dim dDate As String = ""
        Dim oData As New IncomeBus

        If reCalc = 0 Then
            sql = "Select transDate,TransID,route,bus,count(transVal) As countTrans,Sum(transVal) As transVal,direction,Sum(saleAmount) As saleAmount,SPID "
            sql = sql & "FROM cch_trans_temp WHERE statTrans = 1 GROUP BY transDate,TransID,spid,route,bus,direction "
            sql = sql & "ORDER BY transDate ASC,route ASC,bus ASC,direction ASC,TransID ASC"
        Else
            If dateSelect = "" Then
                sql = "Select transDate,TransID,route,bus,count(transVal) As countTrans,Sum(transVal) As transVal,direction,Sum(saleAmount) As saleAmount,SPID "
                sql = sql & "FROM cch_trans_ok WHERE statTrans = 1 GROUP BY transDate,TransID,spid,route,bus,direction "
                sql = sql & "ORDER BY transDate ASC,route ASC,bus ASC,direction ASC,TransID ASC"
            Else
                sql = "Select transDate,TransID,route,bus,count(transVal) As countTrans,Sum(transVal) As transVal,direction,Sum(saleAmount) As saleAmount,SPID "
                sql = sql & "FROM cch_trans_ok WHERE (statTrans = 1 and transDate='" & dateSelect & "') GROUP BY transDate,TransID,spid,route,bus,direction "
                sql = sql & "ORDER BY transDate ASC,route ASC,bus ASC,direction ASC,TransID ASC"
            End If

        End If

        DT = oMaster.getData(sql)
        With lstvIncomeBus
            .Items.Clear()
            If Not IsNothing(DT) Then
                oData = getIncomeBus(DT.Rows(0))
                For int1 = 1 To DT.Rows.Count - 1
                    Dim oNow As IncomeBus = getIncomeBus(DT.Rows(int1))
                    If oData.dateLog <> oNow.dateLog Or oData.bus <> oNow.bus Or oData.direction <> oNow.direction Then
                        .Items.Add(oData.dateLog)
                        .Items(.Items.Count - 1).SubItems.Add(oData.route)
                        .Items(.Items.Count - 1).SubItems.Add(oData.bus)
                        .Items(.Items.Count - 1).SubItems.Add(oData.direction)
                        .Items(.Items.Count - 1).SubItems.Add(oData.ticket)
                        .Items(.Items.Count - 1).SubItems.Add(oData.onBus)
                        .Items(.Items.Count - 1).SubItems.Add(oData.A920)
                        .Items(.Items.Count - 1).SubItems.Add(oData.TopupSale)
                        .Items(.Items.Count - 1).SubItems.Add(oData.upPerson)
                        .Items(.Items.Count - 1).SubItems.Add(oData.downPerson)
                        .Items(.Items.Count - 1).SubItems.Add(oData.topupPerson)
                        .Items(.Items.Count - 1).SubItems.Add(oData.saletopupPerson)
                        oData = oNow
                    Else
                        'Select Case oNow.transType
                        '    Case 41
                        '        oData.ticket = oData.ticket + oNow.ticket
                        '    Case 92
                        '        oData.ticket = oData.ticket - oNow.ticket
                        'End Select
                        oData.upPerson = oData.upPerson + oNow.upPerson
                        oData.downPerson = oData.downPerson + oNow.downPerson
                        oData.topupPerson = oData.topupPerson + oNow.topupPerson
                        oData.saletopupPerson = oData.saletopupPerson + oNow.saletopupPerson
                        oData.ticket = oData.ticket + oNow.ticket
                        oData.onBus = oData.onBus + oNow.onBus
                        oData.A920 = oData.A920 + oNow.A920
                        oData.TopupSale = oData.TopupSale + oNow.TopupSale
                    End If
                Next
                .Items.Add(oData.dateLog)
                .Items(.Items.Count - 1).SubItems.Add(oData.route)
                .Items(.Items.Count - 1).SubItems.Add(oData.bus)
                .Items(.Items.Count - 1).SubItems.Add(oData.direction)
                .Items(.Items.Count - 1).SubItems.Add(oData.ticket)
                .Items(.Items.Count - 1).SubItems.Add(oData.onBus)
                .Items(.Items.Count - 1).SubItems.Add(oData.A920)
                .Items(.Items.Count - 1).SubItems.Add(oData.TopupSale)
                .Items(.Items.Count - 1).SubItems.Add(oData.upPerson)
                .Items(.Items.Count - 1).SubItems.Add(oData.downPerson)
                .Items(.Items.Count - 1).SubItems.Add(oData.topupPerson)
                .Items(.Items.Count - 1).SubItems.Add(oData.saletopupPerson)
                'Exit Sub
            End If
            lblCounter.Text = "Imcome By Bus" & .Items.Count & " rec."
            StatusStrip1.Refresh()
            'Exit Sub
            For int1 As Integer = 0 To .Items.Count - 1
                sql = "Select * from incomebus where dateLog='" & .Items(int1).Text & "' and route='" & .Items(int1).SubItems(1).Text & "' and bus='" & .Items(int1).SubItems(2).Text & "' and direction=" & .Items(int1).SubItems(3).Text
                DT = oMaster.getData(sql)
                If IsNothing(DT) Then
                    sql = "insert into incomebus (dateLog,route,bus,direction,ticket,onBus,a920,topupSale,upPerson,downPerson,topUpPerson,saletopupPerson) values ("
                    sql = sql & "'" & .Items(int1).Text & "','" & .Items(int1).SubItems(1).Text & "','" & .Items(int1).SubItems(2).Text & "'," & .Items(int1).SubItems(3).Text & ","
                    sql = sql & "" & .Items(int1).SubItems(4).Text & "," & .Items(int1).SubItems(5).Text & "," & .Items(int1).SubItems(6).Text & "," & .Items(int1).SubItems(7).Text & "," & .Items(int1).SubItems(8).Text
                    sql = sql & "," & .Items(int1).SubItems(9).Text & "," & .Items(int1).SubItems(10).Text & "," & .Items(int1).SubItems(11).Text & ")"
                Else
                    sql = "update incomebus set onBus=" & .Items(int1).SubItems(5).Text & ",a920=" & .Items(int1).SubItems(6).Text & ",topupSale=" & .Items(int1).SubItems(7).Text & ",upPerson=" & .Items(int1).SubItems(8).Text
                    sql = sql & ",downPerson=" & .Items(int1).SubItems(9).Text & ",topUpPerson=" & .Items(int1).SubItems(10).Text & ",saletopupPerson=" & .Items(int1).SubItems(11).Text
                    sql = sql & " where dateLog='" & .Items(int1).Text & "' and route='" & .Items(int1).SubItems(1).Text & "' and bus='" & .Items(int1).SubItems(2).Text & "' and direction=" & .Items(int1).SubItems(3).Text
                End If
                If oMaster.executeSQL(sql) Then
                    .Items(int1).Font = New System.Drawing.Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Strikeout)
                    .Items(int1).ForeColor = Color.Green
                    .Refresh()
                Else
                    .Items(int1).ForeColor = Color.Red
                End If
                lblCounter.Text = "Update Income" & int1 & "/" & .Items.Count & " rec."
                StatusStrip1.Refresh()
            Next
        End With
    End Sub
    Private Sub cmdExportReport_Click(sender As Object, e As EventArgs) Handles cmdExportReport.Click
        'tabReview.SelectTab(1)
        'updateCashflow()

        'tabReview.SelectTab(2)
        'updatePassenger()

        tabReview.SelectTab("tPassengerLog")
        updatePassengerLog()

        tabReview.SelectTab("tIncomeByBus")
        UpdateIncomeByBus()

        tabReview.SelectTab("tPassengerCount")
        updatePassengerUpDown()

        tabReview.SelectTab("tSumTrans")
        updateSumTrans()

    End Sub
    Function updatePassenger(dr As DataRow)
        With lstvPassengerLog
            .Items(.Items.Count - 1).SubItems(6).Text = dr.Item("downStation").ToString
            .Items(.Items.Count - 1).SubItems(7).Text = dr.Item("transtime").ToString
            Dim intTicket As Integer = CInt(.Items(.Items.Count - 1).SubItems(8).Text)
            Select Case dr.Item("transID").ToString
                Case 41
                    intTicket = intTicket + CInt(dr.Item("transVal").ToString)
                Case 92
                    intTicket = intTicket - CInt(dr.Item("transVal").ToString)
            End Select
            'intTicket = intTicket - CInt(dr.Item("transVal").ToString)
            .Items(.Items.Count - 1).SubItems(8).Text = intTicket
        End With
    End Function
    Function addRowPassenger(dr As DataRow)
        With lstvPassengerLog

            .Items.Add(dr.Item("transDate").ToString)
            .Items(.Items.Count - 1).Tag = dr.Item("referTrans").ToString
            .Items(.Items.Count - 1).SubItems.Add(dr.Item("cardID").ToString)
            .Items(.Items.Count - 1).SubItems.Add(dr.Item("route").ToString)
            .Items(.Items.Count - 1).SubItems.Add(dr.Item("route").ToString & "-" & dr.Item("bus").ToString)
            .Items(.Items.Count - 1).SubItems.Add(dr.Item("upstation").ToString)
            .Items(.Items.Count - 1).SubItems.Add(dr.Item("transtime").ToString)
            .Items(.Items.Count - 1).SubItems.Add("")
            .Items(.Items.Count - 1).SubItems.Add("")
            .Items(.Items.Count - 1).SubItems.Add(CInt(dr.Item("transVal").ToString))
            .Items(.Items.Count - 1).SubItems.Add(CInt(dr.Item("direction").ToString))
        End With
    End Function
    Private Sub cmdTranferOK_Click(sender As Object, e As EventArgs) Handles cmdTranferOK.Click
        Dim oMaster As New mMaster
        'Clear Shift Work Card
        If (oMaster.executeSQL("insert into shiftwork select * from cch_trans_temp where transID=31 and station=4095 and productType=7047 and statTrans=1 ")) Then
            oMaster.executeSQL("delete from cch_trans_temp where transID=31 and station=4095 and productType=7047 and statTrans=1")
            oMaster.executeSQL("delete from web_trans_temp where transID=31 and station=4095 and productType=7047 and statTrans=1")
        End If
        'Clear Trans Data
        If (oMaster.executeSQL("insert into web_trans_ok select * from web_trans_temp where statTrans=1 ")) Then
            oMaster.executeSQL("delete from web_trans_temp where statTrans=1")
        End If
        If (oMaster.executeSQL("insert into cch_trans_ok select * from cch_trans_temp where statTrans=1 ")) Then
            oMaster.executeSQL("delete from cch_trans_temp where statTrans=1")
        End If
        lblCounter.Text = "Transfer Complete"
        StatusStrip1.Refresh()
        changeBusNumber()
        lblCounter.Text = "Update BUS Number Complete"
        StatusStrip1.Refresh()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oMaster As New mMaster
        If oMaster.getINIValue("monitor", "status") = 1 Then
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        cmdSettleWP_Click(cmdSettleWP, e)
        Button1_Click(Button1, e)
        cmdExportReport_Click(cmdExportReport, e)
        cmdTranferOK_Click(cmdTranferOK, e)
        End
    End Sub
    Sub execSQL(sql As String)
        Dim oMaster As New mMaster
        oMaster.executeSQL(sql)
    End Sub
    Sub changeBusNumber()
        execSQL("update passengerup set route='147L' where route='1471'")

        execSQL("Update passengerup set route='147R' where route='1472'")

        execSQL("update passengerdown set route='147L' where route='1471'")

        execSQL("update passengerdown set route='147R' where route='1472'")

        execSQL("update incomebus set route='147L' where route='1471'")

        execSQL("update incomebus set route='147R' where route='1472'")

        execSQL("update passengerlog set route='147L' where route='1471'")

        execSQL("update passengerlog set route='147R' where route='1472'")

        execSQL("update rabbitsummarylog set route='147L' where route='1471'")

        execSQL("update rabbitsummarylog set route='147R' where route='1472'")
    End Sub

    Private Sub cmdReCalc_Click(sender As Object, e As EventArgs) Handles cmdReCalc.Click
        Dim oMaster As New mMaster
        Dim DT As DataTable

        Timer1.Enabled = False
        If MessageBox.Show("System will clear all data Report and regenerate data." & vbCrLf & "Are You sure?", "Confirm Message", MessageBoxButtons.OKCancel) = vbOK Then
            lblCounter.Text = "Clear Report Data"
            StatusStrip1.Refresh()
            Dim sql As String = ""
            'sql = "delete from cashflow"
            'oMaster.executeSQL(sql)
            'sql = "delete from passengertracking"
            'oMaster.executeSQL(sql)
            sql = "delete from passengerlog"
            oMaster.executeSQL(sql)
            sql = "delete from incomebus"
            oMaster.executeSQL(sql)
            sql = "delete from passengerup"
            oMaster.executeSQL(sql)
            sql = "delete from passengerdown"
            oMaster.executeSQL(sql)
            sql = "delete from rabbitsummarylog"
            oMaster.executeSQL(sql)

            'lblCounter.Text = "reGenerate Data Report => cashflow"
            'StatusStrip1.Refresh()
            'tabReview.SelectTab(1)
            'updateCashflow(1)

            'lblCounter.Text = "reGenerate Data Report => passenger"
            'StatusStrip1.Refresh()
            'tabReview.SelectTab(2)
            'updatePassenger(1)

            lblCounter.Text = "reGenerate Data Report => passengerLog"
            StatusStrip1.Refresh()
            tabReview.SelectTab("tPassengerLog")
            updatePassengerLog(1)

            lblCounter.Text = "reGenerate Data Report => incomeBybus"
            StatusStrip1.Refresh()
            tabReview.SelectTab("tIncomeByBus")
            UpdateIncomeByBus(1)

            lblCounter.Text = "reGenerate Data Report => Passenger Up/Down"
            StatusStrip1.Refresh()
            tabReview.SelectTab("tPassengerCount")
            updatePassengerUpDown(1)

            lblCounter.Text = "reGenerate Data Report => Rabbit Summary By Trans"
            StatusStrip1.Refresh()
            tabReview.SelectTab("tSumTrans")
            updateSumTrans(1)

            changeBusNumber()
            lblCounter.Text = "Update BUS Number Complete"
            StatusStrip1.Refresh()
        End If
    End Sub

    Private Sub cmdReCalSelect_Click(sender As Object, e As EventArgs) Handles cmdReCalSelect.Click
        Dim oMaster As New mMaster
        Dim DT As DataTable
        Dim sql As String = ""

        Timer1.Enabled = False
        If MessageBox.Show("System will clear select date =>" & mtxtSelectDate.Text & vbCrLf & " Report and regenerate data." & vbCrLf & "Are You sure?", "Confirm Message", MessageBoxButtons.OKCancel) = vbOK Then
            lblCounter.Text = "Clear select Date => " & mtxtSelectDate.Text
            sql = "delete from passengerlog where (transdate = '" & mtxtSelectDate.Text & "')"
            oMaster.executeSQL(sql)
            sql = "delete from incomebus where (datelog = '" & mtxtSelectDate.Text & "')"
            oMaster.executeSQL(sql)
            sql = "delete from passengerup where (datelog = '" & mtxtSelectDate.Text & "')"
            oMaster.executeSQL(sql)
            sql = "delete from passengerdown where (datelog = '" & mtxtSelectDate.Text & "')"
            oMaster.executeSQL(sql)
            sql = "delete from rabbitsummarylog where (datelog = '" & mtxtSelectDate.Text & "')"
            oMaster.executeSQL(sql)

            Dim strDate As String = mtxtSelectDate.Text.Split("-")(2) & mtxtSelectDate.Text.Split("-")(1) & mtxtSelectDate.Text.Split("-")(0)
            lblCounter.Text = "reGenerate Data Report => passengerLog"
            StatusStrip1.Refresh()
            tabReview.SelectTab("tPassengerLog")
            updatePassengerLog(1, strDate)

            lblCounter.Text = "reGenerate Data Report => incomeBybus"
            StatusStrip1.Refresh()
            tabReview.SelectTab("tIncomeByBus")
            UpdateIncomeByBus(1, strDate)

            lblCounter.Text = "reGenerate Data Report => Passenger Up/Down"
            StatusStrip1.Refresh()
            tabReview.SelectTab("tPassengerCount")
            updatePassengerUpDown(1, strDate)

            lblCounter.Text = "reGenerate Data Report => Rabbit Summary By Trans"
            StatusStrip1.Refresh()
            tabReview.SelectTab("tSumTrans")
            updateSumTrans(1, strDate)
        End If
    End Sub

End Class
