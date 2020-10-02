Imports MySql.Data
Imports AMS.Profile.Ini
Imports TAJet
Imports System.IO

Public Class Form1
    Dim intDelay As Integer = 120
    Structure planDesc
        Dim dateLog As String
        Dim route As String
        Dim terminal As String
        Dim hour As String
        Dim amount As String
    End Structure
    Function splitPlanData(data As String) As planDesc
        Dim sTmp() As String = data.Split(",")
        Dim oPlan As New planDesc

        With oPlan
            .dateLog = txtDatePlan.Text
            .route = sTmp(0)
            .hour = sTmp(1)
            .terminal = sTmp(2)
            .amount = sTmp(3)
        End With
        Return oPlan
    End Function
    Private Sub cmdLoadPlan_Click(sender As Object, e As EventArgs) Handles cmdLoadPlan.Click
        Dim strMaster As String
        strMaster = My.Application.Info.DirectoryPath & "\masterPlan.txt"
        Dim oReader As New StreamReader(strMaster)
        Dim strText As String = ""
        With lstvPlan
            .Items.Clear()
            Do
                strText = oReader.ReadLine
                If Not strText Is Nothing Then
                    Dim itemPlan As New planDesc
                    itemPlan = splitPlanData(strText)
                    .Items.Add(itemPlan.dateLog)
                    .Items(.Items.Count - 1).SubItems.Add(itemPlan.route)
                    .Items(.Items.Count - 1).SubItems.Add(itemPlan.terminal)
                    .Items(.Items.Count - 1).SubItems.Add(itemPlan.hour)
                    .Items(.Items.Count - 1).SubItems.Add(itemPlan.amount)
                    lblMessage.Text = lstvPlan.Items.Count & " rec."
                    ssStatus.Refresh()
                End If
            Loop Until strText Is Nothing
            .Refresh()

            For int1 As Integer = 0 To lstvPlan.Items.Count - 1
                Dim sql As String
                sql = "select * from masterplanhour where dateLog='" & .Items(int1).Text & "' and route='" & .Items(int1).SubItems(1).Text & "'"
                sql = sql & " and terminal=" & .Items(int1).SubItems(2).Text & " and hour=" & .Items(int1).SubItems(3).Text
                Dim oMaster As New mMaster
                Dim DT As DataTable = oMaster.getData(sql)
                If IsNothing(DT) Then
                    sql = "insert into masterplanhour (dateLog,route,terminal,hour,amountBus) values ('" & .Items(int1).Text & "','" & .Items(int1).SubItems(1).Text & "',"
                    sql = sql & .Items(int1).SubItems(2).Text & "," & .Items(int1).SubItems(3).Text & "," & .Items(int1).SubItems(4).Text & ")"
                Else
                    sql = "update masterplanhour Set amount= where  dateLog='" & .Items(int1).Text & "' and route='" & .Items(int1).SubItems(1).Text & "'"
                    sql = sql & " and terminal=" & .Items(int1).SubItems(2).Text & " and hour=" & .Items(int1).SubItems(3).Text
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
            Next
        End With
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strDate As String = Now.Year & "-" & Now.Month & "-" & Now.Day
        txtDatePlan.Text = strDate
        txtWD.Text = Now.ToString("ddd") & " (" & Now.DayOfWeek & ")"
        tmDelay.Enabled = True
    End Sub

    Private Sub tmDelay_Tick(sender As Object, e As EventArgs) Handles tmDelay.Tick
        intDelay = intDelay - 1
        lblMessage.Text = "Auto in " & intDelay & " sec."
        If intDelay <= 0 Then
            cmdLoadPlan_Click(cmdLoadPlan, e)
        End If
    End Sub

    Private Sub btnAuto_Click(sender As Object, e As EventArgs) Handles btnAuto.Click
        tmDelay.Enabled = False
    End Sub
    Private Sub txtdatePlan_keyDown(sender As Object, e As KeyEventArgs) Handles txtDatePlan.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim dDate As Date = Convert.ToDateTime(txtDatePlan.Text.Trim.Replace("-", "/"))
                txtWD.Text = dDate.ToString("ddd") & " (" & dDate.DayOfWeek & ")"
        End Select

    End Sub

End Class
