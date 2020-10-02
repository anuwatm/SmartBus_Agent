Imports TAJet
Imports System.IO
Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    Private Sub btnAnalyticTicket_Click(sender As Object, e As EventArgs) Handles btnAnalyticTicket.Click
        Dim oDir As New DirectoryInfo(txtPath.Text)

        lstFileTicket.Items.Clear()
        For Each ofile In oDir.GetFiles("ticket*_" & txtDateSource.Text & "_*.csv")
            If ofile.Extension.ToLower = ".csv" Then
                lstFileTicket.Items.Add(ofile.Name)
            End If
        Next

        lstvTicketSubSum.Items.Clear()
        For int1 As Integer = 0 To lstFileTicket.Items.Count - 1
            Dim oReader As StreamReader = New System.IO.StreamReader(txtPath.Text & "\" & lstFileTicket.Items(int1).ToString, System.Text.Encoding.GetEncoding(874))
            While oReader.Peek <> -1
                Dim strText() As String = oReader.ReadLine.Split(",")
                With lstvTicketSubSum
                    If IsNumeric(strText(1)) Then
                        Dim strBusID As String = strText(0) & "-" & strText(1)
                        If IsNothing(lstvTicketSubSum.FindItemWithText(strBusID)) Then
                            Dim strFilename() As String = lstFileTicket.Items(int1).ToString.Split("_")
                            .Items.Add(Replace(strFilename(0), "TICKET", ""))
                            .Items(.Items.Count - 1).SubItems.Add(strText(0))
                            .Items(.Items.Count - 1).SubItems.Add(strBusID)
                        End If
                    End If
                End With
            End While
        Next

        lstvTicketGroupSum.Items.Clear()
        Dim strBranch As String = ""
        Dim strRoute As String = ""
        Dim intCountBus As String = 0
        For int1 As Integer = 0 To lstvTicketSubSum.Items.Count - 1
            If lstvTicketSubSum.Items(int1).Text <> strBranch Or lstvTicketSubSum.Items(int1).SubItems(1).Text <> strRoute Then
                strBranch = lstvTicketSubSum.Items(int1).Text
                strRoute = lstvTicketSubSum.Items(int1).SubItems(1).Text
                intCountBus = 1
                lstvTicketGroupSum.Items.Add(strBranch)
                lstvTicketGroupSum.Items(lstvTicketGroupSum.Items.Count - 1).SubItems.Add(strRoute)
                lstvTicketGroupSum.Items(lstvTicketGroupSum.Items.Count - 1).SubItems.Add(intCountBus)
            Else
                intCountBus = CInt(lstvTicketGroupSum.Items(lstvTicketGroupSum.Items.Count - 1).SubItems(2).Text) + 1
                lstvTicketGroupSum.Items(lstvTicketGroupSum.Items.Count - 1).SubItems(2).Text = intCountBus
            End If
        Next

        lblBusCount.Text = "0"
        intCountBus = 0
        For int1 As Integer = 0 To lstvTicketGroupSum.Items.Count - 1
            lblBusCount.Text = CInt(lblBusCount.Text) + CInt(lstvTicketGroupSum.Items(int1).SubItems(2).Text)
        Next
        lblBusCount.Text = lblBusCount.Text & " คัน"
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        dlgFolder.ShowDialog()
        If dlgFolder.SelectedPath <> "" Then
            txtPath.Text = dlgFolder.SelectedPath
            Dim oMaster As New mMaster
            oMaster.setINIValue("monitor", "monitorFolder", dlgFolder.SelectedPath)
        End If
    End Sub

    Function rightStr(source As String, lengthChar As Integer)
        Return Microsoft.VisualBasic.Right(source, lengthChar)
    End Function

    Private Sub btnGenDate_Click(sender As Object, e As EventArgs) Handles btnGenDate.Click
        Dim strStart As Date = Mid(txtGenStart.Text, 1, 4) - 543 & "/" & Mid(txtGenStart.Text, 5, 2) & "/" & Mid(txtGenStart.Text, 7, 2)
        Dim strEnd As Date = Mid(txtGenEnd.Text, 1, 4) - 543 & "/" & Mid(txtGenEnd.Text, 5, 2) & "/" & Mid(txtGenEnd.Text, 7, 2)

        lstDateGen.Items.Clear()
        For int1 As Integer = 0 To (strEnd - strStart).Days
            Dim dDateGen As Date = strStart.AddDays(int1) 'DateAdd(DateInterval.Day, int1, strStart)
            lstDateGen.Items.Add(dDateGen.Year + 543 & rightStr("0" & dDateGen.Month, 2) & rightStr("0" & dDateGen.Day, 2))
        Next
    End Sub

    Private Sub btnAnalyzeFile_Click(sender As Object, e As EventArgs) Handles btnAnalyzeFile.Click
        Dim oDir As New DirectoryInfo(txtPath.Text)
        lstvBranchChacker.Items.Clear()

        For int1 As Integer = 0 To lstDateGen.Items.Count - 1
            lblGenDisplay.Text = lstDateGen.Items(int1).ToString
            lblGenDisplay.Refresh()

            lstGenFile.Items.Clear()
            For Each ofile In oDir.GetFiles("ticket*_" & lblGenDisplay.Text & "_*.csv")
                If ofile.Extension.ToLower = ".csv" Then
                    lstGenFile.Items.Add(ofile.Name)
                    lstGenFile.Refresh()
                End If
            Next

            For int2 As Integer = 0 To lstGenFile.Items.Count - 1
                Dim oReader As StreamReader = New System.IO.StreamReader(txtPath.Text & "\" & lstGenFile.Items(int2).ToString, System.Text.Encoding.GetEncoding(874))
                Dim strFilename() As String = lstGenFile.Items(int2).ToString.Split("_")
                Dim strBranch As String = Replace(strFilename(0), "TICKET", "")
                While oReader.Peek <> -1
                    Dim strText() As String = oReader.ReadLine.Split(",")
                    With lstvBranchChacker
                        If IsNumeric(strText(1)) Then
                            Dim strRoute As String = strText(0)
                            Dim strBusID As String = strText(0) & "-" & strText(1)
                            Dim strDateLog As String = strText(3)
                            If .Items.Count < 1 Then
                                .Items.Add(strDateLog)
                                .Items(.Items.Count - 1).SubItems.Add(strBranch)
                                .Items(.Items.Count - 1).SubItems.Add(strRoute)
                                .Items(.Items.Count - 1).SubItems.Add(strBusID)
                            End If
                            If (strDateLog <> .Items(.Items.Count - 1).Text Or strRoute <> .Items(.Items.Count - 1).SubItems(2).Text Or strBusID <> .Items(.Items.Count - 1).SubItems(3).Text) Then
                                .Items.Add(strDateLog)
                                .Items(.Items.Count - 1).SubItems.Add(strBranch)
                                .Items(.Items.Count - 1).SubItems.Add(strRoute)
                                .Items(.Items.Count - 1).SubItems.Add(strBusID)
                            End If
                            .Refresh()
                        End If
                    End With
                End While
            Next



        Next
    End Sub
    Function sendtoLINE(message As String, token As String) As Boolean
        Try
            Dim oMaster As New mMaster
            Dim webClient As New System.Net.WebClient
            Dim result As String = webClient.DownloadString(oMaster.getINIValue("service", "lineservice") & "?t=" & token & "&m=" & message)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub btnCheckFile_Click(sender As Object, e As EventArgs) Handles btnCheckFile.Click
        Dim oMaster As New mMaster
        Dim DT As DataTable = oMaster.getData("select * from branch")
        If DT.Rows.Count > 0 Then
            lstvCheckFile.Items.Clear()
            For int1 As Integer = 0 To DT.Rows.Count - 1
                lblFileCHeckDisplay.Text = "==> " & txtCheckDate.Text
                With lstvCheckFile
                    .Items.Add(DT.Rows(int1).Item("branchName").ToString)
                    .Items(.Items.Count - 1).Tag = "0" & DT.Rows(int1).Item("branchID").ToString
                    .Items(.Items.Count - 1).SubItems.Add("")
                    .Items(.Items.Count - 1).SubItems.Add("")
                    .Items(.Items.Count - 1).SubItems.Add("")
                    Dim oDir As New DirectoryInfo(txtPath.Text & "\")
                    Dim oFile As FileInfo() = oDir.GetFiles("TICKET" & .Items(.Items.Count - 1).Tag & "_" & txtCheckDate.Text & "*.csv")
                    .Items(.Items.Count - 1).SubItems(1).Text = oFile.Length
                    oFile = oDir.GetFiles("TRIP" & .Items(.Items.Count - 1).Tag & "_" & txtCheckDate.Text & "*.csv")
                    .Items(.Items.Count - 1).SubItems(2).Text = oFile.Length
                    oFile = oDir.GetFiles("GASNGV" & .Items(.Items.Count - 1).Tag & "_" & txtCheckDate.Text & "*.csv")
                    .Items(.Items.Count - 1).SubItems(3).Text = oFile.Length
                End With
            Next

            If chkSendToLine.Checked Then
                Dim strMessage As String = "ข้อมูลวันที่ " & txtCheckDate.Text & vbCrLf
                With lstvCheckFile
                    If chkShortALert.Checked Then
                        For intA As Integer = 0 To .Items.Count - 1
                            If .Items(intA).SubItems(1).Text <> 1 And .Items(intA).SubItems(2).Text <> 1 And .Items(intA).SubItems(3).Text <> 1 Then
                                strMessage = strMessage & "File มีปัญหา สาขา ->" & .Items(intA).Text & "(" & .Items(intA).Tag & ")" & vbCrLf
                                If .Items(intA).SubItems(1).Text <> 1 Then strMessage = strMessage & "TICKET =" & .Items(intA).SubItems(1).Text & " files" & vbCrLf
                                If .Items(intA).SubItems(2).Text <> 1 Then strMessage = strMessage & "TRIP =" & .Items(intA).SubItems(2).Text & " files" & vbCrLf
                                If .Items(intA).SubItems(3).Text <> 1 Then strMessage = strMessage & "GASNGV =" & .Items(intA).SubItems(3).Text & " files" & vbCrLf
                                If chkSendToLine.Checked <> 0 Then sendtoLINE(strMessage, oMaster.getINIValue("service", "lineToken"))
                                strMessage = ""
                            End If
                        Next
                    Else
                        For intA As Integer = 0 To .Items.Count - 1
                            strMessage = strMessage & "ตรวจสอบ File สาขา ->" & .Items(intA).Text & "(" & .Items(intA).Tag & ")" & vbCrLf
                            strMessage = strMessage & "TICKET =" & .Items(intA).SubItems(1).Text & " files" & vbCrLf
                            strMessage = strMessage & "TRIP = " & .Items(intA).SubItems(2).Text & " files" & vbCrLf
                            strMessage = strMessage & "GASNGV = " & .Items(intA).SubItems(3).Text & " files" & vbCrLf
                            If chkSendToLine.Checked <> 0 Then sendtoLINE(strMessage, oMaster.getINIValue("service", "lineToken"))
                            strMessage = ""
                        Next
                    End If

                End With

            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oMaster As New mMaster

        txtPath.Text = oMaster.getINIValue("monitor", "monitorFolder")
        chkSendToLine.Checked = oMaster.getINIValue("auto", "send2line")
        chkAutoCheck.Checked = oMaster.getINIValue("auto", "monitorfile")
        chkUpdateBranch.Checked = oMaster.getINIValue("auto", "updatebranch")
        chkAlertNewRoute.Checked = oMaster.getINIValue("auto", "newRouteCheck")
        chkAutoAddRoute.Checked = oMaster.getINIValue("auto", "addnewroute")
        chkAutoMoveShuttleBus.Checked = oMaster.getINIValue("auto", "MoveGASdata")
        If oMaster.getINIValue("auto", "monitorfile") <> 0 Then
            Timer1.Enabled = True
            Me.Text = "File Analytic -> Auto Mode ON"
        Else
            Timer1.Enabled = False
            Me.Text = "File Analytic -> Auto Mode OFF"
        End If
    End Sub

    Private Sub chkSendToLine_CheckedChanged(sender As Object, e As EventArgs) Handles chkSendToLine.CheckedChanged
        Dim oMaster As New mMaster

        oMaster.setINIValue("auto", "send2line", CInt(chkSendToLine.Checked))
    End Sub

    Private Sub chkAutoCheck_CheckedChanged(sender As Object, e As EventArgs) Handles chkAutoCheck.CheckedChanged
        Dim oMaster As New mMaster

        oMaster.setINIValue("auto", "monitorfile", CInt(chkAutoCheck.Checked))
    End Sub

    Private Sub btnUpdateBranch_Click(sender As Object, e As EventArgs) Handles btnUpdateBranch.Click
        With lstvBranchChacker
            For int1 As Integer = 0 To .Items.Count - 1
                Dim sql As String = ""
                sql = "update busticketincome set branch='" & .Items(int1).SubItems(1).Text & "'  where (datelog='" & .Items(int1).Text & "' and route='" & .Items(int1).SubItems(2).Text & "' and busID='" & .Items(int1).SubItems(3).Text & "')"
                Dim oMaster As New mMaster
                If oMaster.executeSQL(sql) Then
                    .Items(int1).BackColor = Color.Green
                Else
                    .Items(int1).BackColor = Color.Red
                End If
                sql = "update gas set branch='" & .Items(int1).SubItems(1).Text & "'  where (datelog='" & .Items(int1).Text & "' and route='" & .Items(int1).SubItems(2).Text & "' and busID='" & .Items(int1).SubItems(3).Text & "')"
                oMaster.executeSQL(sql)
                lblGenDisplay.Text = "==>" & .Items(int1).Text
                lblGenDisplay.Refresh()
            Next
        End With

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Me.Text = "File Analytic -> Auto Mode Start"
        TabControl1.SelectedIndex = 2
        Dim dYesterday As Date = Now.AddDays(-1)
        txtCheckDate.Text = dYesterday.Year + 543 & rightStr("0" & dYesterday.Month, 2) & rightStr("0" & dYesterday.Day, 2)
        btnCheckFile_Click(btnCheckFile, e)
        If chkUpdateBranch.Checked <> 0 Then
            lstDateGen.Items.Clear()
            lstDateGen.Items.Add(txtCheckDate.Text)
            btnAnalyzeFile_Click(btnAnalyzeFile, e)
            TabControl1.SelectedIndex = 1
            If lstvBranchChacker.Items.Count > 0 Then btnUpdateBranch_Click(btnUpdateBranch, e)
            If chkAlertNewRoute.Checked Then btnCheckNewRoute_Click(btnCheckNewRoute, e)
        End If
        If chkAutoMoveShuttleBus.Checked Then btnMoveData_Click(btnMoveData, e)
        Me.Text = "File Analytic -> Auto Mode End"
    End Sub


    Private Sub btnBreakAuto_Click(sender As Object, e As EventArgs) Handles btnBreakAuto.Click
        Timer1.Enabled = False
        Me.Text = "File Analytic -> Break Auto Mode"
    End Sub

    Private Sub btnCheckNewRoute_Click(sender As Object, e As EventArgs) Handles btnCheckNewRoute.Click

        Dim oMaster As New mMaster
        Dim sql As String = "SELECT DISTINCT route FROM busticketincome where route not in(select route from branchroute) "
        Dim DT As DataTable = oMaster.getData(sql)

        With lstNewRoute
            .Items.Clear()
            Dim strRoute As String = ""
            If IsNothing(DT) Then
                'MessageBox.Show("No New Route")
                lblFileCHeckDisplay.Text = "No New Route"
                Exit Sub
            End If
            For int1 As Integer = 0 To DT.Rows.Count - 1
                .Items.Add(DT.Rows(int1).Item("route").ToString)
                strRoute = DT.Rows(int1).Item("route").ToString & " ," & strRoute
            Next
            If chkSendToLine.Checked Then sendtoLINE("พบสายรถใหม่ -> " & strRoute, oMaster.getINIValue("service", "lineToken"))
            If chkAutoAddRoute.Checked Then
                For int1 As Integer = 0 To .Items.Count - 1
                    sql = "insert into branchroute (branchID,route) values ('00','" & .Items(int1).ToString & "')"
                    oMaster.executeSQL(sql)
                Next
            End If

        End With
    End Sub

    Private Sub btnReorderRoute_Click(sender As Object, e As EventArgs) Handles btnReorderRoute.Click
        Dim oMaster As New mMaster
        Dim sql As String = "select DISTINCT route from branchroute order by branchID,route"
        Dim DT As DataTable = oMaster.getData(sql)

        With lstNewRoute
            .Items.Clear()
            Dim intRunning As Integer = 0
            oMaster.executeSQL("delete from routeorder")
            For int1 As Integer = 0 To DT.Rows.Count - 1
                intRunning = intRunning + 1
                .Items.Add(intRunning & ")" & DT.Rows(int1).Item("route").ToString)
                sql = "insert into routeorder (branchID,route) values (" & intRunning & ",'" & DT.Rows(int1).Item("route").ToString & "')"
                oMaster.executeSQL(sql)
            Next
        End With
    End Sub

    Private Sub chkAlertNewRoute_CheckedChanged(sender As Object, e As EventArgs) Handles chkAlertNewRoute.CheckedChanged
        Dim oMaster As New mMaster

        oMaster.setINIValue("auto", "newRouteCheck", CInt(chkAlertNewRoute.Checked))
    End Sub

    Private Sub chkAutoAddRoute_CheckedChanged(sender As Object, e As EventArgs) Handles chkAutoAddRoute.CheckedChanged
        Dim oMaster As New mMaster

        oMaster.setINIValue("auto", "addnewroute", CInt(chkAutoAddRoute.Checked))
    End Sub

    Private Sub btnMoveData_Click(sender As Object, e As EventArgs) Handles btnMoveData.Click
        Dim oMaster As New mMaster
        Dim sql As String = ""

        Try
            sql = "insert into gasshutterbus (route,busID,busNumber,dateLog,gasKG,gasAmount) select route,busID,busNumber,dateLog,gasKG,gasAmount from gas where (route like 'B%')"
            oMaster.executeSQL(sql)
        Catch ex As Exception
            lblFileCHeckDisplay.Text = "Trans SHBus" & ex.Message
        End Try
        Try
            sql = "delete from gas where (route like 'B%')"
            oMaster.executeSQL(sql)
            lblFileCHeckDisplay.Text = "Tranfer GAS OK"
        Catch ex As Exception
            lblFileCHeckDisplay.Text = "Clear GAS " & ex.Message
        End Try

        Try
            sql = "update busticketincome set  branch='08' where (branch='0P')"
            oMaster.executeSQL(sql)
            lblFileCHeckDisplay.Text = "Change Ticket Premium to 08 OK"
        Catch ex As Exception
            lblFileCHeckDisplay.Text = "Ticket " & ex.Message
        End Try

        Try
            sql = "update gas set branch='08' where (branch='0P')"
            oMaster.executeSQL(sql)
            lblFileCHeckDisplay.Text = "Change GAS Premium to 08 OK"
        Catch ex As Exception
            lblFileCHeckDisplay.Text = "GAS " & ex.Message
        End Try

    End Sub
End Class
