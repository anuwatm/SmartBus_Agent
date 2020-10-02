Imports MySql.Data
Imports AMS.Profile.Ini
Imports TAJet
Imports System.IO
Public Class Form1
    Structure PromotionData
        Dim route As String
        Dim card As String
        Dim transDate As String
        Dim dateFormat As String
        Dim transTime As String
        Dim upSTation As String
        Dim downStation As String
        Dim transAmount As Integer
        Dim fareAmount As Integer
        Dim BSSPay As Integer
    End Structure
    Sub extractCSV(filename As String)
        Dim oReader As StreamReader = New System.IO.StreamReader(filename)
        'lstvPromotion.Items.Clear()
        While oReader.Peek <> -1
            Dim strData() As String = oReader.ReadLine.Split(",")
            With lstvPromotion
                .Items.Add(strData(0))
                .Items(.Items.Count - 1).SubItems.Add(strData(1))
                .Items(.Items.Count - 1).SubItems.Add(strData(2))
                .Items(.Items.Count - 1).SubItems.Add(strData(3))
                .Items(.Items.Count - 1).SubItems.Add(strData(4))
                .Items(.Items.Count - 1).SubItems.Add(strData(5))
                .Items(.Items.Count - 1).SubItems.Add(strData(6))
                .Items(.Items.Count - 1).SubItems.Add(strData(7))
                .Items(.Items.Count - 1).SubItems.Add(strData(8))
                .Items(.Items.Count - 1).SubItems.Add("")
                slblMessage.Text = "total Rec " & lstvPromotion.Items.Count & " rec."
                ssStatus.Refresh()
            End With
        End While
        oReader.Close()
        oReader = Nothing
        Dim oFile As New System.IO.FileInfo(filename)
        Dim strFile As String = oFile.Name
        oFile = Nothing
        My.Computer.FileSystem.MoveFile(filename, My.Application.Info.DirectoryPath & "\backup\" & strFile)
    End Sub
    Function setFormatDate(val As String) As String
        Return Mid(val, 5, 4) & "-" & Mid(val, 3, 2) & "-" & Mid(val, 1, 2)
    End Function
    Function getPromotion(idx As Integer) As PromotionData
        Dim tmp As New PromotionData
        With lstvPromotion
            tmp.route = .Items(idx).Text
            tmp.card = .Items(idx).SubItems(1).Text
            tmp.transDate = .Items(idx).SubItems(2).Text
            tmp.dateFormat = setFormatDate(tmp.transDate)
            tmp.transTime = .Items(idx).SubItems(3).Text
            tmp.upSTation = .Items(idx).SubItems(4).Text
            tmp.downStation = .Items(idx).SubItems(5).Text
            tmp.transAmount = .Items(idx).SubItems(6).Text
            tmp.fareAmount = .Items(idx).SubItems(7).Text
            tmp.BSSPay = .Items(idx).SubItems(8).Text
        End With
        Return tmp
    End Function
    Private Sub cmdLoadCSV_Click(sender As Object, e As EventArgs) Handles cmdLoadCSV.Click
        dlgFile.ShowDialog()
        If dlgFile.FileName <> "" Then
            extractCSV(dlgFile.FileName)
        End If
    End Sub

    Private Sub cmdMatchData_Click(sender As Object, e As EventArgs) Handles cmdMatchData.Click
        Dim oMaster As New mMaster
        Dim sql As String = ""
        For int1 As Integer = 0 To lstvPromotion.Items.Count - 1
            Dim Promo As PromotionData = getPromotion(int1)
            sql = "select * from passengerlog where (amount=1 and route=" & Promo.route & " and transDate='" & Promo.dateFormat & "' and cardID='" & Promo.card & "' and upStation=" & Promo.upSTation & "  and downStation=" & Promo.downStation & ")"
            Dim DT As DataTable = oMaster.getData(sql)
            If IsNothing(DT) Then
                lstvPromotion.Items(int1).SubItems(9).Text = "unMatch"
            Else
                If DT.Rows.Count > 1 Then
                    lstvPromotion.Items(int1).SubItems(9).Text = "Match " & DT.Rows.Count & " rec."
                Else
                    lstvPromotion.Items(int1).SubItems(9).Text = "Matched"
                End If

            End If
        Next
    End Sub

    Private Sub cmdUpdateDB_Click(sender As Object, e As EventArgs) Handles cmdUpdateDB.Click
        Dim oMaster As New mMaster
        Dim sql As String = ""
        For int1 As Integer = 0 To lstvPromotion.Items.Count - 1
            Dim Promo As PromotionData = getPromotion(int1)
            sql = "insert into promoTrans (route,card,transDate,transTime,upStation,downStation,transAmount,fareAmount,BSSPay) values ('" & Promo.route & "','" & Promo.card & "','" & Promo.dateFormat & "','" & Promo.transTime & "',"
            sql = sql & Promo.upSTation & "," & Promo.downStation & "," & Promo.transAmount & "," & Promo.fareAmount & "," & Promo.BSSPay & ")"
            oMaster.executeSQL(sql)
            sql = "update passengerlog set amount=" & Promo.fareAmount & "where (amount=1 and route=" & Promo.route & " and transDate='" & Promo.dateFormat & "' and cardID='" & Promo.card & "' and upStation=" & Promo.upSTation
            sql = sql & "  and downStation=" & Promo.downStation & ")"
            'oMaster.executeSQL(sql)
            slblMessage.Text = "update " & int1 & "/" & lstvPromotion.Items.Count & " rec."
        Next
        MessageBox.Show("Update OK.")
        lstvPromotion.Items.Clear()
    End Sub

    Private Sub cmdClearList_Click(sender As Object, e As EventArgs) Handles cmdClearList.Click
        lstvPromotion.Items.Clear()
    End Sub
End Class
