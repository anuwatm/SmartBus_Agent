Imports MySql.Data
Imports AMS.Profile.Ini
Imports TAJet
Imports System.IO

Public Class Form1
    Dim intTimer As Integer
    Structure fileDesc
        Dim filename As String
        Dim size As String
        Dim realSize As Long
        Dim fullPath As String
        Dim dateStamp As String
        Dim Extension As String
    End Structure
    Sub moveFile2Backup(fullFilename As String)
        Dim oMaster As New mMaster
        Dim oFile As New fileDesc
        Dim oFileinfo As New FileInfo(fullFilename)
        Dim backupFile As String = ""
        If oFileinfo.Exists Then
            If chkSummary.Checked Then
                backupFile = oMaster.getINIValue("monitor", "backupSummary") & "\" & oFileinfo.Name.Replace(".csv", "") & "_" & Now().Hour & Now().Minute & Now().Second & Now.Millisecond & oFileinfo.Extension
            Else
                backupFile = oMaster.getINIValue("monitor", "backupPath") & "\" & oFileinfo.Name.Replace(".csv", "") & "_" & Now().Hour & Now().Minute & Now().Second & Now.Millisecond & oFileinfo.Extension
            End If
        Else
            If chkSummary.Checked Then
                backupFile = oMaster.getINIValue("monitor", "backupSummary") & "\" & oFileinfo.Name
            Else
                backupFile = oMaster.getINIValue("monitor", "backupPath") & "\" & oFileinfo.Name
            End If


        End If

        My.Computer.FileSystem.MoveFile(fullFilename, backupFile)
    End Sub
    Function getFileDesc(fullPath As String) As fileDesc
        Dim oFileDesc As fileDesc = New fileDesc

        If (fullPath & "") <> "" Then
            Dim oFile As FileInfo = New FileInfo(fullPath)
            If oFile.Exists Then
                With oFileDesc
                    .filename = oFile.Name
                    .fullPath = oFile.FullName
                    Select Case oFile.Length.ToString.Length
                        Case Is <= 4
                            .size = Format((oFile.Length / 1000000), "#,##0.00") & "KB"
                        Case 5 To 7
                            .size = Format((oFile.Length / 1000000), "#,##0.00") & "MB"
                        Case Is > 10
                            .size = Format((oFile.Length / 1000000000), "#,##0.00") & "GB"
                    End Select
                    .realSize = oFile.Length
                    .dateStamp = oFile.LastWriteTime
                    .dateStamp = oFile.LastWriteTime
                    .dateStamp = oFile.LastWriteTime
                    .dateStamp = oFile.LastWriteTime
                    .dateStamp = oFile.LastWriteTime
                    .Extension = oFile.Extension
                End With
            End If
        End If

        Return oFileDesc
    End Function
    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        dlgFolder.ShowDialog()
        If dlgFolder.SelectedPath <> "" Then
            txtPath.Text = dlgFolder.SelectedPath
        End If
    End Sub
    Sub getDataWorklog(fullfilename As String)
        Dim oReader As StreamReader = New System.IO.StreamReader(fullfilename, System.Text.Encoding.GetEncoding(874))
        Dim strDate As String = ""
        While oReader.Peek <> -1
            Dim strText() As String = oReader.ReadLine.Split(",")
            With lstvWorkLog
                If IsNumeric(strText(6)) Then
                    If strText(0).Split("-")(0) > 2500 Then
                        strDate = strText(0).Split("-")(0) - 543 & "-" & strText(0).Split("-")(1) & "-" & strText(0).Split("-")(2)
                    Else
                        strDate = strText(0)
                    End If
                    .Items.Add(strDate) 'Datelog
                    .Items(.Items.Count - 1).SubItems.Add(strText(1)) 'Bus Number
                    .Items(.Items.Count - 1).SubItems.Add(strText(2)) 'Bus ID
                    .Items(.Items.Count - 1).SubItems.Add(strText(3)) 'emp ID
                    .Items(.Items.Count - 1).SubItems.Add(strText(6)) 'TravelCount
                    .Items(.Items.Count - 1).ForeColor = Color.Black
                End If
            End With
        End While
        oReader.Close()
        moveFile2Backup(fullfilename.ToString)
        labelStatus.Text = "work log " & lstvWorkLog.Items.Count & " rec."
        StatusStrip1.Refresh()
        lstvFile.Items.Remove(lstvFile.Items(0))
    End Sub
    Sub updateDataWorkLog()
        tabData.SelectTab(1)
        Dim oMaster As New mMaster
        Dim sql As String = ""
        For int1 As Integer = 0 To lstvWorkLog.Items.Count - 1
            labelStatus.Text = "Update " & int1 + 1 & "/" & lstvWorkLog.Items.Count & " rec."
            StatusStrip1.Refresh()
            With lstvWorkLog
                sql = "insert into buslog (dayLog,BusNumber,BusID,empID,travelCount) values "
                sql = sql & " ('" & .Items(int1).Text & "','" & .Items(int1).SubItems(1).Text & "','" & .Items(int1).SubItems(2).Text & "',"
                sql = sql & "'" & .Items(int1).SubItems(3).Text & "'," & .Items(int1).SubItems(4).Text & ")"

                Try
                    If oMaster.executeSQL(sql) Then
                        .Items(int1).ForeColor = Color.Green
                        sql = "select * from hr_deduct where (dayLog='" & .Items(int1).Text & "' and empID='" & .Items(int1).SubItems(3).Text & "')"
                        Dim DT As DataTable = oMaster.getData(sql)
                        If IsNothing(DT) Then
                            sql = "insert into hr_deduct (dayLog,empID,busID,work) values ('" & .Items(int1).Text & "','" & .Items(int1).SubItems(3).Text & "',"
                            sql = sql & "'" & .Items(int1).SubItems(2).Text & "',1)"
                        Else
                            sql = "update hr_deduct set work=1  where (dayLog='" & .Items(int1).Text & "' and empID='" & .Items(int1).SubItems(3).Text & "')"
                            Debug.Print("Work Log. Update")
                        End If
                        oMaster.executeSQL(sql)
                    Else
                        .Items(int1).ForeColor = Color.Red
                    End If
                Catch ex As Exception
                    .Items(int1).ForeColor = Color.Red
                End Try
            End With
        Next
    End Sub
    Sub getDataPlanDay(fullfilename As String)
        Dim oReader As StreamReader = New System.IO.StreamReader(fullfilename, System.Text.Encoding.GetEncoding(874))
        Dim strDate As String = ""
        While oReader.Peek <> -1
            Dim strText() As String = oReader.ReadLine.Split(",")
            With lstvPlan
                If IsNumeric(strText(3).Trim) Then
                    'If strText(0).Split("-")(0) > 2500 Then
                    '    strDate = strText(0).Split("-")(0) - 543 & "-" & strText(0).Split("-")(1) & "-" & strText(0).Split("-")(2)
                    'Else
                    '    strDate = strText(0)
                    'End If
                    strDate = strText(0).Split("/")(2) & "-" & strText(0).Split("/")(1) & "-" & strText(0).Split("/")(0)
                    .Items.Add(strDate) 'Datelog
                    .Items(.Items.Count - 1).SubItems.Add(strText(1)) 'Bus Number
                    .Items(.Items.Count - 1).SubItems.Add(strText(2)) 'Bus ID
                    .Items(.Items.Count - 1).SubItems.Add(strText(3)) 'emp ID
                    .Items(.Items.Count - 1).SubItems.Add(strText(5)) 'TravelCount
                    '.Items(.Items.Count - 1).ForeColor = Color.Black
                End If
            End With
        End While
        oReader.Close()
        moveFile2Backup(fullfilename.ToString)
        labelStatus.Text = "Plan log " & lstvWorkLog.Items.Count & " rec."
        'lblCount.Refresh()
        lstvFile.Items.Remove(lstvFile.Items(0))
    End Sub
    Sub updateDataPlanDay()
        tabData.SelectTab(0)
        Dim oMaster As New mMaster
        For int1 As Integer = 0 To lstvPlan.Items.Count - 1
            labelStatus.Text = "Update " & int1 + 1 & "/" & lstvPlan.Items.Count & " rec."
            StatusStrip1.Refresh()
            With lstvPlan
                Dim sql As String = "insert into busplan (dayLog,BusNumber,BusID,empID,timeStart) values ('" & .Items(int1).Text & "','" & .Items(int1).SubItems(1).Text & "','" & .Items(int1).SubItems(2).Text
                sql = sql & "','" & .Items(int1).SubItems(3).Text & "','" & .Items(int1).SubItems(4).Text & "')"

                Try
                    If oMaster.executeSQL(sql) Then
                        .Items(int1).ForeColor = Color.Green
                        sql = "select * from hr_deduct where (dayLog='" & .Items(int1).Text & "' and empID='" & .Items(int1).SubItems(3).Text & "')"
                        Dim DT As DataTable = oMaster.getData(sql)
                        If IsNothing(DT) Then
                            sql = "insert into hr_deduct (dayLog,empID,BusID,plan) values ('" & .Items(int1).Text & "','" & .Items(int1).SubItems(3).Text & "','" & .Items(int1).SubItems(2).Text & "',1)"
                        Else
                            sql = "update hr_deduct set plan=1  where (dayLog='" & .Items(int1).Text & "' and empID='" & .Items(int1).SubItems(3).Text & "')"
                            Debug.Print("Plan. Update")
                        End If
                        oMaster.executeSQL(sql)
                    Else
                        .Items(int1).ForeColor = Color.Red
                    End If
                Catch ex As Exception
                    .Items(int1).ForeColor = Color.Red
                End Try
            End With
        Next
    End Sub
    Sub getDataMaintenance(fullfilename As String)
        Dim oReader As StreamReader = New System.IO.StreamReader(fullfilename, System.Text.Encoding.GetEncoding(874))
        Dim strDate As String = ""
        While oReader.Peek <> -1
            Dim strText() As String = oReader.ReadLine.Split(",")
            With lstvMaintenance
                'Datelog
                For int1 As Integer = 1 To strText.Count - 1
                    If strText(int1).Trim <> "" Then
                        If strText(0).Split("-")(0) > 2500 Then
                            strDate = strText(0).Split("-")(0) - 543 & "-" & strText(0).Split("-")(1) & "-" & strText(0).Split("-")(2)
                        Else
                            strDate = strText(0)
                        End If
                        .Items.Add(strDate)
                        .Items(.Items.Count - 1).SubItems.Add(strText(int1))
                    End If
                Next
            End With
        End While
        oReader.Close()
        moveFile2Backup(fullfilename.ToString)
        labelStatus.Text = "Maintenance log " & lstvWorkLog.Items.Count & " rec."
        StatusStrip1.Refresh()
        lstvFile.Items.Remove(lstvFile.Items(0))
    End Sub
    Sub updateDataMaintenance()
        tabData.SelectTab(2)
        Dim oMaster As New mMaster
        Dim sql As String = ""
        For int1 As Integer = 0 To lstvMaintenance.Items.Count - 1
            labelStatus.Text = "Update " & int1 + 1 & "/" & lstvMaintenance.Items.Count & " rec."
            StatusStrip1.Refresh()
            With lstvMaintenance
                sql = "insert into busmaintenance (dayLog,BusID) values ('" & .Items(int1).Text & "','" & .Items(int1).SubItems(1).Text & "')"

                Try
                    If oMaster.executeSQL(sql) Then
                        .Items(int1).ForeColor = Color.Green
                        sql = "select * from hr_deduct where (dayLog='" & .Items(int1).Text & "' and BusID='" & .Items(int1).SubItems(1).Text & "')"
                        Dim DT As DataTable = oMaster.getData(sql)
                        If IsNothing(DT) Then
                            'sql = "insert into hr_deduct (dayLog,busID,busMainten) values ('" & .Items(int1).Text & "','" & .Items(int1).SubItems(1).Text & "',1)"
                        Else
                            sql = "update hr_deduct set busMainten=1  where (dayLog='" & .Items(int1).Text & "' and busID='" & .Items(int1).SubItems(1).Text & "')"

                            Debug.Print("Maintenance Update")
                        End If
                        If sql <> "" Then oMaster.executeSQL(sql)
                    Else
                        .Items(int1).ForeColor = Color.Red
                    End If
                Catch ex As Exception
                    .Items(int1).ForeColor = Color.Red
                End Try
            End With
        Next
    End Sub
    Sub getdataTimeAct(fullfilename As String)
        Dim oReader As StreamReader = New System.IO.StreamReader(fullfilename, System.Text.Encoding.GetEncoding(874))
        Dim strDate As String = ""

        tabData.SelectTab(3)
        While oReader.Peek <> -1
            Dim strText() As String = oReader.ReadLine.Split(",")
            With lstvTimeActen
                If strText.Length > 1 Then
                    If strText(2).Trim <> "" Then
                        If strText(0).Split("-")(0) > 2500 Then
                            strDate = strText(0).Split("-")(0) - 543 & "-" & strText(0).Split("-")(1) & "-" & strText(0).Split("-")(2)
                        Else
                            strDate = strText(0)
                        End If
                        .Items.Add(strDate) 'Datelog
                        .Items(.Items.Count - 1).SubItems.Add(strText(1)) 'EmpID
                        .Items(.Items.Count - 1).SubItems.Add(strText(2)) 'Time IN
                    End If
                End If

            End With
        End While
        oReader.Close()
        moveFile2Backup(fullfilename.ToString)
        labelStatus.Text = "Time Act. " & lstvWorkLog.Items.Count & " rec."
        StatusStrip1.Refresh()
        lstvFile.Items.Remove(lstvFile.Items(0))
    End Sub
    Sub updateDataTimeAct()
        Dim oMaster As New mMaster
        Dim sql As String = ""

        tabData.SelectTab(3)
        For int1 As Integer = 0 To lstvTimeActen.Items.Count - 1
            labelStatus.Text = "Update " & int1 + 1 & "/" & lstvTimeActen.Items.Count & " rec."
            StatusStrip1.Refresh()
            With lstvTimeActen
                sql = "insert into worktime (dayLog,empID,timeIn) values ('" & .Items(int1).Text & "','" & .Items(int1).SubItems(1).Text & "',"
                sql = sql & "'" & .Items(int1).Text & "')"


                Try
                    If oMaster.executeSQL(sql) Then
                        .Items(int1).ForeColor = Color.Green
                        sql = "select * from hr_deduct where (dayLog='" & .Items(int1).Text & "' and empID='" & .Items(int1).SubItems(1).Text & "')"
                        Dim DT As DataTable = oMaster.getData(sql)
                        If IsNothing(DT) Then
                            sql = "insert into hr_deduct (dayLog,empID,timeAct) values ('" & .Items(int1).Text & "','" & .Items(int1).SubItems(1).Text & "',1)"
                        Else
                            sql = "update hr_deduct set timeAct=1  where (dayLog='" & .Items(int1).Text & "' and empID='" & .Items(int1).SubItems(1).Text & "')"
                            Debug.Print("Time Act. Update")
                        End If
                        oMaster.executeSQL(sql)
                    Else
                        .Items(int1).ForeColor = Color.Red
                    End If
                Catch ex As Exception
                    .Items(int1).ForeColor = Color.Red
                End Try
            End With
        Next
    End Sub

    Sub getdataTicketLog(fullfilename As String)
        Dim oReader As StreamReader = New System.IO.StreamReader(fullfilename, System.Text.Encoding.GetEncoding(874))
        Dim strDate As String = ""

        tabData.SelectTab(4)
        With lstvTicketLog
            While oReader.Peek <> -1
                Dim strText() As String = oReader.ReadLine.Split(",")
                If IsNumeric(strText(1)) Then
                    If strText(3).Split("-")(0) > 2500 Then
                        strDate = strText(3).Split("-")(0) - 543 & "-" & strText(3).Split("-")(1) & "-" & strText(3).Split("-")(2)
                    Else
                        strDate = strText(3)
                    End If
                    .Items.Add(strDate)
                    .Items(.Items.Count - 1).SubItems.Add(strText(0))
                    .Items(.Items.Count - 1).SubItems.Add(strText(2))
                    .Items(.Items.Count - 1).SubItems.Add(strText(0) & "-" & strText(1))
                    .Items(.Items.Count - 1).SubItems.Add(strText(6))
                    .Items(.Items.Count - 1).SubItems.Add(strText(8))
                    .Items(.Items.Count - 1).SubItems.Add(strText(9))
                    .Items(.Items.Count - 1).SubItems.Add(strText(12))
                    If InStr(strText(13), """") > 0 Then
                        .Items(.Items.Count - 1).SubItems.Add(strText(13).Replace("""", "") & strText(14).Replace("""", ""))
                    Else
                        .Items(.Items.Count - 1).SubItems.Add(strText(13))
                    End If

                    lblCount.Text = "Ticket Log " & .Items.Count & " rec."
                    lblCount.Refresh()
                End If
            End While
            .Refresh()
            oReader.Close()
            moveFile2Backup(fullfilename.ToString)
            labelStatus.Text = "Ticket Log " & .Items.Count & " rec."
            StatusStrip1.Refresh()
            lstvFile.Items.Remove(lstvFile.Items(0))
        End With
    End Sub

    Sub getdataGas(fullFilename As String)
        Dim oReader As StreamReader = New System.IO.StreamReader(fullFilename, System.Text.Encoding.GetEncoding(874))
        Dim strDate As String = ""

        tabData.SelectTab(5)
        With lstvGas
            While oReader.Peek <> -1
                Dim strText() As String = oReader.ReadLine.Split(",")
                If IsNumeric(strText(1).Trim) Then
                    If strText(3).Split("-")(0) > 2500 Then
                        strDate = strText(3).Split("-")(0) - 543 & "-" & strText(3).Split("-")(1) & "-" & strText(3).Split("-")(2)
                    Else
                        strDate = strText(3)
                    End If
                    .Items.Add(strText(0))
                    .Items(.Items.Count - 1).SubItems.Add(strText(0) & "-" & strText(1))
                    .Items(.Items.Count - 1).SubItems.Add(strText(2))
                    .Items(.Items.Count - 1).SubItems.Add(strText(3))
                    .Items(.Items.Count - 1).SubItems.Add(strText(4))
                    .Items(.Items.Count - 1).SubItems.Add(strText(5))
                    lblCount.Text = "GAS Log " & .Items.Count & " rec."
                    lblCount.Refresh()
                End If
            End While
            .Refresh()
            oReader.Close()
            moveFile2Backup(fullFilename.ToString)
            lstvFile.Items.Remove(lstvFile.Items(0))
        End With
    End Sub
    Sub updateDataGasLog()
        Dim oMaster As New mMaster
        Dim sql As String = ""

        tabData.SelectTab(5)
        With lstvGas
            For int1 As Integer = 0 To .Items.Count - 1
                sql = "select * from gas where (route='" & .Items(int1).Text & "' and busID='" & .Items(int1).SubItems(1).Text & "' and dateLog='" & .Items(int1).SubItems(3).Text & "')"
                Dim DT As DataTable = oMaster.getData(sql)
                If IsNothing(DT) Then
                    sql = "insert into gas (route,busID,busNumber,dateLog,gasKG,gasAmount) values ('" & .Items(int1).Text & "','" & .Items(int1).SubItems(1).Text & "','" & .Items(int1).SubItems(2).Text
                    sql = sql & "','" & .Items(int1).SubItems(3).Text & "'," & .Items(int1).SubItems(4).Text & "," & .Items(int1).SubItems(5).Text & ")"
                Else
                    sql = "update gas set gasKG=" & .Items(int1).SubItems(4).Text & ",gasAmount=" & .Items(int1).SubItems(5).Text & " where  (route='" & .Items(int1).Text & "' and busID='" &
                        sql = sql & .Items(int1).SubItems(1).Text & "' and dateLog='" & .Items(int1).SubItems(3).Text & "')"
                End If
                lblCount.Text = "update " & int1 + 1 & "/" & .Items.Count & " rec."
                StatusStrip1.Refresh()
                Try
                    oMaster.executeSQL(sql)
                    .Items(int1).ForeColor = Color.Green
                Catch ex As Exception
                    .Items(int1).ForeColor = Color.Red

                End Try
            Next
        End With
    End Sub
    Sub updateDataTicketLog()
        Dim oMaster As New mMaster
        Dim sql As String = ""

        tabData.SelectTab(4)
        With lstvTicketLog
            For int1 As Integer = 0 To .Items.Count - 1
                labelStatus.Text = "update " & int1 + 1 & "/" & .Items.Count & " rec."
                StatusStrip1.Refresh()

                sql = "select * from busticketincome where (dateLog='" & .Items(int1).Text & "' and route='" & .Items(int1).SubItems(1).Text & "' and busID='" & .Items(int1).SubItems(3).Text & "' and empID='" & .Items(int1).SubItems(4).Text & "' and ticketPrice=" & .Items(int1).SubItems(6).Text & ") "
                Dim DT As DataTable = oMaster.getData(sql)
                If IsNothing(DT) Then
                    sql = "insert into busticketincome (dateLog,route,busNo,busID,empID,round,ticketPrice,ticketCount,Amount) values ('" & .Items(int1).Text & "','" & .Items(int1).SubItems(1).Text & "','" & .Items(int1).SubItems(2).Text & "','" & .Items(int1).SubItems(3).Text & "',"
                    sql = sql & "'" & .Items(int1).SubItems(4).Text & "'," & .Items(int1).SubItems(5).Text & "," & .Items(int1).SubItems(6).Text & "," & .Items(int1).SubItems(7).Text & "," & CInt(.Items(int1).SubItems(8).Text) & ")"
                Else
                    Dim intTicketCount As Integer = CInt(DT.Rows(0).Item("ticketcount").ToString) + CInt(.Items(int1).SubItems(7).Text)
                    Dim intAmount As Integer = CInt(DT.Rows(0).Item("amount").ToString) + CInt(.Items(int1).SubItems(8).Text)
                    'sql = "update busticketincome set ticketCount=ticketCount+" & CInt(.Items(int1).SubItems(7).Text) & ",Amount=Amount+" & CInt(.Items(int1).SubItems(8).Text) & " where dateLog='" & .Items(int1).Text & "' and route='" & .Items(int1).SubItems(1).Text & "' and busID='" & .Items(int1).SubItems(3).Text & "' and empID='" & .Items(int1).SubItems(4).Text & "'"
                    If chkSummary.Checked = False Then
                        sql = "update busticketincome set ticketCount=ticketCount+" & CInt(.Items(int1).SubItems(7).Text) & ",Amount=Amount+" & CInt(.Items(int1).SubItems(8).Text) & " where dateLog='" & .Items(int1).Text & "' and route='" & .Items(int1).SubItems(1).Text & "' and busID='" & .Items(int1).SubItems(3).Text & "' and empID='" & .Items(int1).SubItems(4).Text & "'"
                    Else
                        sql = "update busticketincome set ticketCount=" & CInt(.Items(int1).SubItems(7).Text) & ",Amount=" & CInt(.Items(int1).SubItems(8).Text) & " where dateLog='" & .Items(int1).Text & "' and route='" & .Items(int1).SubItems(1).Text & "' and busID='" & .Items(int1).SubItems(3).Text & "' and empID='" & .Items(int1).SubItems(4).Text & "'"
                    End If
                    sql = sql & " and ticketPrice=" & .Items(int1).SubItems(6).Text
                End If
                Try
                    oMaster.executeSQL(sql)
                    .Items(int1).ForeColor = Color.Green
                Catch ex As Exception
                    .Items(int1).ForeColor = Color.Red
                End Try

            Next
        End With

    End Sub
    Private Sub cmdScanFolder_Click(sender As Object, e As EventArgs) Handles cmdScanFolder.Click
        Dim oMaster As New mMaster
        'Dim oDir As DirectoryInfo = New DirectoryInfo(oMaster.getINIValue("monitor", "pathBus"))
        Dim oDir As DirectoryInfo = New DirectoryInfo(txtPath.Text)

        tmInterval.Enabled = False
        lstvFile.Items.Clear()
        lstvPlan.Items.Clear()
        lstvWorkLog.Items.Clear()
        lstvMaintenance.Items.Clear()
        lstvTimeActen.Items.Clear()
        lstvTicketLog.Items.Clear()
        lstvGas.Items.Clear()

        For Each ofile In oDir.GetFiles()
            If ofile.Extension.ToLower = ".csv" Then
                Dim oDesc As fileDesc = getFileDesc(ofile.FullName)
                With lstvFile
                    .Items.Add(oDesc.filename)
                    .Items(.Items.Count - 1).Tag = oDesc.fullPath
                    .Items(.Items.Count - 1).SubItems.Add(oDesc.realSize)
                    .Items(.Items.Count - 1).SubItems(1).Tag = oDesc.realSize
                    .Items(.Items.Count - 1).SubItems.Add("Found")
                    .Refresh()
                End With
            End If

        Next
        labelStatus.Text = "Found " & lstvFile.Items.Count & " files"
        StatusStrip1.Refresh()
        lstvFile.Refresh()

        While lstvFile.Items.Count > 0
            Select Case oMaster.leftString(lstvFile.Items(0).Text.ToString, 4).ToLower
                Case "plan"
                    tabData.SelectTab(0)
                    getDataPlanDay(lstvFile.Items(0).Tag)
                Case "trip"
                    tabData.SelectTab(1)
                    getDataWorklog(lstvFile.Items(0).Tag)
                Case "main"
                    tabData.SelectTab(2)
                    getDataMaintenance(lstvFile.Items(0).Tag)
                Case "time"
                    tabData.SelectTab(3)
                    getdataTimeAct(lstvFile.Items(0).Tag)
                Case "tick"
                    tabData.SelectTab(4)
                    getdataTicketLog(lstvFile.Items(0).Tag)
                Case "gasn"
                    tabData.SelectTab(5)
                    getdataGas(lstvFile.Items(0).Tag)
            End Select
        End While

        updateDataPlanDay()
        updateDataWorkLog()
        updateDataMaintenance()
        updateDataTimeAct()
        updateDataTicketLog()
        updateDataGasLog()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oMaster As New mMaster
        txtPath.Text = oMaster.getINIValue("monitor", "pathBus")
        tmInterval.Enabled = True
        chkSummary.Checked = False
        Dim args As String() = Environment.GetCommandLineArgs()
        If args.Count > 0 Then
            For int1 As Integer = 0 To args.Count - 1
                If args(int1) = "sum" Then
                    chkSummary.Checked = True
                    txtPath.Text = oMaster.getINIValue("monitor", "summary")
                End If
            Next
        End If
    End Sub

    Private Sub tmInterval_Tick(sender As Object, e As EventArgs) Handles tmInterval.Tick
        labelStatus.Text = "Scan Folder in " & 120 - intTimer & " sec."
        StatusStrip1.Refresh()
        intTimer = intTimer + 1
        If intTimer >= 120 Then
            tmInterval.Enabled = False
            cmdScanFolder_Click(cmdScanFolder, e)
            tmInterval.Enabled = True
            intTimer = 0
        End If
    End Sub

    Private Sub cmdTestDB_Click(sender As Object, e As EventArgs) Handles cmdTestDB.Click
        Dim oMaster As New mMaster
        Dim oDB As New MySql.Data.MySqlClient.MySqlConnection(oMaster.getINIValue("db", "Connection"))

        oDB.Open()
        MessageBox.Show(oDB.ConnectionString & vbCrLf & "Connect Stat : " & oDB.State.ToString)
    End Sub
End Class
