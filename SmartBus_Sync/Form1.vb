Imports AMS.Profile
Imports TAJet
Imports System.IO
Imports MySql.Data
Imports System.Diagnostics
Imports Rebex.Net
Public Class frmSync
    Dim watchFolder As FileSystemWatcher
    Dim blnModify As Boolean = False
    Dim oItemActive As ListViewItem = Nothing
    Structure fileDesc
        Dim filename As String
        Dim size As String
        Dim realSize As Long
        Dim fullPath As String
        Dim dateStamp As String
        Dim Extension As String
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
        Dim upStation As String
        Dim downStation As String
        Dim prodUsage As String
        Dim productType As String
        Dim passType As String
        Dim transValue As String
        Dim direction As String
        Dim flag As String
        Dim saleAmount As String
        Dim empID As String
        Dim sumCheck As String
        Dim referTrans As String
        Dim entryDateTime As String
        Dim entryStation As String
        Dim dateSettlement As String
    End Structure
    Structure dateSplit
        Dim day As Integer
        Dim month As Integer
        Dim year As Integer
        Dim hour As Integer
        Dim minute As Integer
        Dim second As Integer
    End Structure



    Function splitAmount(source As String) As Long
        Dim oMaster As New mMaster
        If source.Length > 2 Then
            If source.ToLower = "null" Then
                Return 0
            Else
                Return CLng(Mid(source, 1, source.Length - 2) & "." & oMaster.trimRight(source, 2))
            End If

        Else
            Return CLng("0" & source)
        End If
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
                .day = 00
                .month = 00
                .year = 0000
            End If
            If sourceTime <> "" Then
                .hour = Mid(sourceTime, 1, 2)
                .minute = Mid(sourceTime, 3, 2)
                .second = oMaster.trimRight(sourceTime, 2)
            Else
                .hour = 00
                .minute = 00
                .second = 00
            End If

        End With
        Return dTarget
    End Function

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
                    .Extension = oFile.Extension
                End With
            End If
        End If

        Return oFileDesc
    End Function

    Function moveFile(source As String) As Boolean
        'Try
        Dim oFile As FileInfo = New FileInfo(source)
        Dim oMaster As New mMaster
        oFile.CopyTo(oMaster.getINIValue("monitor", "backupPath") & "\" & oFile.Name)
        oFile.Delete()
        'Catch ex As Exception
        Return True
        'End Try
    End Function


    Function readCSV(filename As String) As ArrayList
        Dim objReader As New StreamReader(filename)
        Dim sLine As String = ""
        Dim arrText As New ArrayList()

        Do
            sLine = objReader.ReadLine()
            If Not sLine Is Nothing Then
                arrText.Add(sLine)
            End If
        Loop Until sLine Is Nothing
        objReader.Close()
        Return arrText
    End Function
    Function splitRabbitWP(source As String, dateData As String) As RabbitData
        Dim item As New RabbitData
        Dim oTmp() As String = source.Split(",")

        If oTmp.Length > 15 Then
            With item
                .sourceType = oTmp(2)
                .transDate = oTmp(3)
                .transTime = oTmp(4)
                .splitDate = splitDateTime(.transDate, .transTime)
                .transID = oTmp(5)
                .SPid = oTmp(6)
                .reader = oTmp(7)
                .cardID = oTmp(8)
                .cardType = oTmp(9)
                .route = oTmp(11)
                .bus = oTmp(12)
                .station = oTmp(13)
                .entryDateTime = oTmp(16)
                .entryStation = oTmp(17)
                Select Case CInt(.transID)
                    Case 41
                        .upStation = .station
                    Case 92
                        .upStation = .entryStation
                        .downStation = .station
                End Select
                .prodUsage = oTmp(14)
                .transValue = splitAmount(oTmp(15))
                .direction = oTmp(19)
                .flag = oTmp(20)
                .saleAmount = splitAmount(oTmp(21))
                .empID = oTmp(22)
                .productType = oTmp(10)
                .dateSettlement = dateData
                If .productType.Trim = "7047" And .transID = 31 Then
                    .sumCheck = .cardID & .reader & .transDate & .transTime & .productType & .transID & .transValue & .saleAmount
                Else
                    .sumCheck = .cardID & .reader & .transDate & .transTime & .route & .bus & .transValue & .saleAmount
                End If
                '.sumCheck = .cardID & .reader & .transDate & .transTime & .route & .bus & .transValue & .saleAmount
                Dim referID As String = .cardID & "_" & .transDate
                Select Case .transID
                    Case 92
                        referID = referID & "_" & "41"
                    Case 91
                        referID = referID & "_" & "99"
                    Case Else
                        referID = referID & "_" & .transID
                End Select
                .referTrans = referID & "_" & .SPid & "_" & .entryStation
            End With
            Return item
        Else
            Return Nothing
        End If

    End Function

    Function splitRabbitCCH(source As String, dateData As String) As RabbitData
        Dim item As New RabbitData
        Dim oTmp() As String = source.Split(",")

        If oTmp.Length > 15 Then
            If oTmp(3).Trim <> "" Then
                With item
                    .sourceType = oTmp(2)
                    .transDate = oTmp(11)
                    .transTime = oTmp(12)
                    .splitDate = splitDateTime(.transDate, .transTime)
                    .transID = oTmp(4)
                    .SPid = oTmp(3)
                    .reader = oTmp(9)
                    .cardID = oTmp(15)
                    .cardType = oTmp(14)
                    .route = oTmp(6)
                    .bus = oTmp(7)
                    .station = oTmp(8)
                    .transValue = splitAmount(oTmp(19))
                    .direction = oTmp(5)
                    .flag = oTmp(17)
                    .saleAmount = splitAmount(oTmp(18))
                    '.entryDateTime = oTmp(16)
                    '.entryStation = oTmp(17)
                    .productType = oTmp(16)
                    .dateSettlement = dateData
                    If .productType.Trim = "7047" And .transID = 31 Then
                        .sumCheck = .cardID & .reader & .transDate & .transTime & .productType & .transID & .transValue & .saleAmount
                    Else
                        .sumCheck = .cardID & .reader & .transDate & .transTime & .route & .bus & .transValue & .saleAmount
                    End If
                    '.sumCheck = .cardID & .reader & .transDate & .transTime & .route & .bus & .transValue & .saleAmount
                    .referTrans = .cardID & "_" & .transDate & "_" & .transID & .SPid
                End With
            End If
            Return item
        Else
            Return Nothing
        End If
    End Function
    Function InsertTranscData(data As RabbitData, typeData As String) As Boolean
        Dim sqlSelect As String = ""
        Dim sqlInsert As String = ""
        Dim sqlUpdate As String = ""
        Dim sql As String = ""
        Select Case typeData.ToLower()
            Case "wp"
                sqlInsert = "insert into web_trans_temp "
                sqlUpdate = "Update web_trans_temp set  "
                sqlSelect = "select * from web_trans_temp where (sumCheck='" & data.sumCheck & "')"
            Case "cch"
                sqlInsert = "insert into cch_trans_temp "
                sqlUpdate = "Update cch_trans_temp set "
                sqlSelect = "select * from cch_trans_temp where (sumCheck='" & data.sumCheck & "')"
        End Select
        Dim oDB As New mMaster
        Try
            Dim DT As DataTable = oDB.getData(sqlSelect)
            If IsNothing(DT) Then
                sqlInsert = sqlInsert & "(sourceType,transDate,transTime,TransDay,TransMonth,TransYear,TransHour,TransMinute,TransSec,TransID,SPID,deviceID,cardID,cardType,route,bus,station,upStation,downStation,productType,transVal,passType,direction,flag,saleAmount,empID,sumCheck,referTrans,dateSettlement,statTrans) values ("
                With data
                    sqlInsert = sqlInsert & chkVal(.sourceType) & "," & chkVal(.transDate) & "," & chkVal(.transTime) & "," & chkVal(.splitDate.day, "n") & "," & chkVal(.splitDate.month, "n") & "," & chkVal(.splitDate.year, "n") & "," & chkVal(.splitDate.hour, "n") & "," & chkVal(.splitDate.minute, "n")
                    sqlInsert = sqlInsert & "," & chkVal(.splitDate.second, "n") & "," & chkVal(.transID, "n") & "," & chkVal(.SPid) & "," & chkVal(.reader) & "," & chkVal(.cardID) & "," & chkVal(.cardType, "n") & "," & chkVal(.route, "n") & "," & chkVal(.bus, "n") & "," & chkVal(.station, "n") & "," & chkVal(.upStation, "n") & "," & chkVal(.downStation, "n")
                    sqlInsert = sqlInsert & "," & chkVal(.productType, "n") & "," & chkVal(.transValue, "n") & "," & chkVal(.passType) & "," & chkVal(.direction, "n") & "," & chkVal(.flag, "n") & "," & chkVal(.saleAmount, "n") & "," & chkVal(.empID) & "," & chkVal(.sumCheck) & "," & chkVal(.referTrans) & "," & chkVal(.dateSettlement) & ",0)"
                End With
                sql = sqlInsert
            Else
                If DT.Rows.Count >= 0 Then
                    With data
                        sqlUpdate = sqlUpdate & "sourceType=" & chkVal(.sourceType) & ",transDate=" & chkVal(.transDate) & ",transTime=" & chkVal(.transTime) & ",TransDay=" & chkVal(.splitDate.day, "n") & ",TransMonth=" & chkVal(.splitDate.month, "n") & ",TransYear=" & chkVal(.splitDate.year, "n")
                        sqlUpdate = sqlUpdate & ",TransHour=" & chkVal(.splitDate.hour, "n") & ",TransMinute=" & chkVal(.splitDate.minute, "n") & ",TransSec=" & chkVal(.splitDate.second, "n") & ",TransID=" & chkVal(.transID, "n") & ",SPID=" & chkVal(.SPid)
                        sqlUpdate = sqlUpdate & ",deviceID=" & chkVal(.reader) & ",cardID=" & chkVal(.cardID) & ",cardType=" & chkVal(.cardType, "n") & ",route=" & chkVal(.route, "n") & ",bus=" & chkVal(.bus, "n") & ",station=" & chkVal(.station, "n") & ",upStation=" & chkVal(.upStation, "n") & ",downStation=" & chkVal(.downStation, "n")
                        sqlUpdate = sqlUpdate & ",transVal=" & chkVal(.transValue, "n") & ",productType=" & chkVal(.productType, "n") & ",passType=" & chkVal(.passType) & ",direction=" & chkVal(.direction, "n") & ",flag=" & chkVal(.flag, "n") & ",saleAmount=" & chkVal(.saleAmount, "n") & ",empID=" & chkVal(.empID) & ",dateSettlement=" & chkVal(.dateSettlement)
                        sqlUpdate = sqlUpdate & ",statTrans=0 where sumCheck=" & chkVal(.sumCheck)
                    End With
                    sql = sqlUpdate
                End If
            End If

            oDB.executeSQL(sql)
        Catch ex As Exception
            oDB.writeLog("Error SQL ->" & sql)
        End Try

        Return True
    End Function


    Private Sub frmSync_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oMaster As New mMaster
        txtPath.Text = oMaster.getINIValue("monitor", "path")
        'cmdScanFolder_Click(cmdScanFolder, e)
        If oMaster.getINIValue("monitor", "status") = 1 Then
            'cmdMonitor_Click(cmdMonitor, e)
            tmStart.Enabled = True
        End If
    End Sub
    Sub monitorFolder(source As Object, e As System.IO.FileSystemEventArgs)
        Dim oFile As fileDesc = getFileDesc(e.FullPath)
        Dim oMaster As New mMaster
        Select Case e.ChangeType
            Case WatcherChangeTypes.Changed
                If IsNothing(lstvFile.FindItemWithText(oFile.filename)) = False Then
                    'With lstvFileMonitor
                    '    .Items(.FindItemWithText(oFile.filename).Index).SubItems(3).Text = "Sending To FTP..."
                    '    ftpFile(oFile.filename, lstvFileMonitor.FindItemWithText(oFile.filename))
                    '    .Refresh()
                    'End With
                    'Dim oListItem As ListViewItem = lstvFileMonitor.FindItemWithText(oFile.filename)
                    'oListItem.SubItems(1).Text = oFile.size
                    'oListItem.SubItems(1).Tag = oFile.realSize
                    'If oListItem.SubItems(2).Text <> oFile.dateStamp Then
                    '    oListItem.SubItems(2).Text = oFile.dateStamp
                    '    oListItem.SubItems(3).Text = "Queue FTP"
                    'End If
                Else
                    With lstvFile
                        .Items.Add(oFile.filename)
                        .Items(.Items.Count - 1).Tag = oFile.fullPath
                        '.Items(.Items.Count - 1).SubItems.Add(oFile.size)
                        .Items(.Items.Count - 1).SubItems.Add(oFile.realSize)
                        .Items(.Items.Count - 1).SubItems(1).Tag = oFile.realSize
                        '.Items(.Items.Count - 1).SubItems.Add(oFile.dateStamp)
                        .Items(.Items.Count - 1).SubItems.Add("File Copying...")
                        .Refresh()
                        oMaster.writeLog("File Change Found :" & oFile.filename)
                        'showMessage("Found File : " & oFile.filename)
                    End With
                End If
            Case WatcherChangeTypes.Created
                With lstvFile
                    .Items.Add(oFile.filename)
                    .Items(.Items.Count - 1).Tag = oFile.fullPath
                    .Items(.Items.Count - 1).SubItems.Add(oFile.realSize)
                    .Items(.Items.Count - 1).SubItems(1).Tag = oFile.realSize
                    '.Items(.Items.Count - 1).SubItems.Add(oFile.dateStamp)
                    .Items(.Items.Count - 1).SubItems.Add("File Create...")
                    .Refresh()
                    oMaster.writeLog("File Create Found :" & oFile.filename)
                    'Dim arrItems As ArrayList = readCSV(oFile.filename)
                    'For Each arrItem In arrItems
                    '    Dim oRabbit As RabbitData = splitRabbitCCH(arrItem.replace("""", ""))
                    '    If Not IsNothing(oRabbit.cardID) Then
                    '        InsertTranscData(oRabbit, oFile.filename.Split("_")(0))
                    '    End If
                    '    'Dim oRabbit As RabbitData = splitRabbit(arrItem)
                    'Next
                    tmInterval_Tick(tmInterval, e)
                    'showMessage("Found File : " & oFile.filename)
                End With
        End Select
    End Sub
    Sub moveFile2Backup(fullFilename As String)
        Dim oMaster As New mMaster
        Dim oFile As New fileDesc
        Dim oFileinfo As New FileInfo(fullFilename)
        Dim backupFile As String = ""
        If oFileinfo.Exists Then
            backupFile = oMaster.getINIValue("monitor", "backupPath") & "\" & oFileinfo.Name.Replace(".csv", "") & "_" & Now().Hour & Now().Minute & Now().Second & Now.Millisecond & oFileinfo.Extension
        Else
            backupFile = oMaster.getINIValue("monitor", "backupPath") & "\" & oFileinfo.Name
        End If

        My.Computer.FileSystem.MoveFile(fullfilename, backupFile)
    End Sub
    Private Sub cmdMonitor_Click(sender As Object, e As EventArgs) Handles cmdMonitor.Click
        Dim oMaster As New mMaster
        If cmdMonitor.Text = "Start Monitor" Then
            lstvFile.CheckBoxes = False
            lstvFile.Refresh()
            watchFolder = New FileSystemWatcher
            With watchFolder
                .SynchronizingObject = Me
                .Path = txtPath.Text
                .NotifyFilter = NotifyFilters.DirectoryName
                .NotifyFilter = .NotifyFilter Or NotifyFilters.FileName
                .NotifyFilter = .NotifyFilter Or NotifyFilters.Attributes
                AddHandler watchFolder.Changed, AddressOf monitorFolder
                AddHandler watchFolder.Created, AddressOf monitorFolder
                .EnableRaisingEvents = True
            End With
            oMaster.writeLog("Start Monitor : " & txtPath.Text)
            tmInterval.Enabled = True
            cmdMonitor.Text = "Stop Monitor"
        Else
            lstvFile.CheckBoxes = True
            'lstvFileMonitor.Items.Clear()
            lstvFile.Refresh()
            watchFolder.EnableRaisingEvents = False
            cmdMonitor.Text = "Start Monitor"
            tmInterval.Enabled = False
            oMaster.writeLog("Stop Monitor : " & txtPath.Text)
        End If
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        dlgFolder.ShowDialog()
        If dlgFolder.SelectedPath <> "" Then
            txtPath.Text = dlgFolder.SelectedPath
        End If
    End Sub

    Private Sub cmdScanFolder_Click(sender As Object, e As EventArgs) Handles cmdScanFolder.Click
        Dim oMaster As New mMaster
        Dim oDir As DirectoryInfo = New DirectoryInfo(oMaster.getINIValue("monitor", "path"))

        For Each ofile In oDir.GetFiles()
            Dim oDesc As fileDesc = getFileDesc(ofile.FullName)
            With lstvFile
                .Items.Add(oDesc.filename)
                .Items(.Items.Count - 1).Tag = oDesc.fullPath
                .Items(.Items.Count - 1).SubItems.Add(oDesc.realSize)
                .Items(.Items.Count - 1).SubItems(1).Tag = oDesc.realSize
                '.Items(.Items.Count - 1).SubItems.Add(oFile.dateStamp)
                .Items(.Items.Count - 1).SubItems.Add("Found")
                .Refresh()
                'Dim arrItems As ArrayList = readCSV(oDesc.fullPath)
                'For Each arrItem In arrItems
                '    Dim oRabbit As RabbitData = splitRabbit(arrItem.replace("""", ""))
                '    If Not IsNothing(oRabbit.cardID) Then
                '        InsertTranscData(oRabbit)
                '    End If
                'Next
                'showMessage("Found File : " & oFile.filename)
            End With
        Next
        tmInterval_Tick(tmInterval, e)
        'Dim oFile As fileDesc = getFileDesc(fullFilename)
    End Sub

    Sub importCSV(fullfilename As String, typeData As String)
        Dim oMaster As New mMaster
        Dim oFile As fileDesc = getFileDesc(fullfilename)
        Dim dateData As String = ""
        oMaster.writeLog("File Extract Found :" & oFile.filename)
        Dim arrItems As ArrayList = readCSV(fullfilename)
        For Each arritem In arrItems
            Dim tmp As String = arritem.replace("""", "")
            Dim oRabbit As New RabbitData
            If tmp.Split(",")(0) = "H" Then
                dateData = tmp.Split(",")(1).ToString
            End If
            Dim strFile() As String = oFile.filename.Split("_")
            Select Case strFile(0).ToLower
                Case "wp"
                    oRabbit = splitRabbitWP(tmp, dateData)
                    'If strFile(3).Trim <> "" Then

                    'End If
                Case "cch"
                    oRabbit = splitRabbitCCH(tmp, dateData)
            End Select
            If Not IsNothing(oRabbit.cardID) Then
                InsertTranscData(oRabbit, typeData)
            End If
        Next
    End Sub

    Private Sub tmInterval_Tick(sender As Object, e As EventArgs) Handles tmInterval.Tick
        tmInterval.Enabled = False
        Dim dateData As String = ""
        For int1 As Integer = lstvFile.Items.Count - 1 To 0 Step -1
            With lstvFile
                Dim oFile As fileDesc = getFileDesc(lstvFile.Items(int1).Tag)
                If oFile.realSize <> .Items(int1).SubItems(1).Tag Then
                    .Items(int1).SubItems(1).Text = oFile.realSize
                    .Items(int1).SubItems(1).Tag = oFile.realSize
                Else
                    Dim strProcess() As String = lstvFile.Items(int1).Text.Split("_")
                    If strProcess.Length > 5 Then
                        importCSV(lstvFile.Items(int1).Tag, strProcess(0))
                        moveFile2Backup(lstvFile.Items(int1).Tag)
                        lstvFile.Items(int1).Remove()
                    Else
                    End If
                End If
            End With
        Next
        tmInterval.Enabled = True
    End Sub

    Private Sub cmdTestDB_Click(sender As Object, e As EventArgs) Handles cmdTestDB.Click
        Dim oMaster As New mMaster
        Dim oDB As New MySqlClient.MySqlConnection(oMaster.getINIValue("db", "Connection"))

        oDB.Open()
        MessageBox.Show(oDB.ConnectionString & vbCrLf & "Connect Stat : " & oDB.State.ToString)
    End Sub

    Private Sub tmStart_Tick(sender As Object, e As EventArgs) Handles tmStart.Tick
        tmStart.Enabled = False
        cmdScanFolder_Click(cmdScanFolder, e)
        cmdMonitor_Click(cmdMonitor, e)
    End Sub
End Class
