Imports MySql.Data.MySqlClient
Imports TAJet
Imports AMS.Profile
Imports System.IO
Imports System.Net
Imports System.Text

Public Class mMaster
    Function trimRight(source As String, wordLenght As Integer) As String
        Return Microsoft.VisualBasic.Right(source, wordLenght)
    End Function
    Function setINIValue(section As String, entry As String, Optional value As String = "") As Boolean
        Dim oINI As Ini = getINIConfig()

        Try
            oINI.SetValue(section, entry, value)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Function getINIConfig() As Ini
        Dim objINI As Ini = New Ini(My.Application.Info.DirectoryPath & "\setting.ini")
        Return objINI
    End Function
    Function getINIValue(Section As String, Entry As String) As String
        Try
            Dim oINI As Ini = getINIConfig()
            Return oINI.GetValue(Section, Entry)
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Function logName() As String
        Return "log_" & Now.Year & trimRight("0" & Now.Month, 2) & trimRight("0" & Now.Day, 2)
    End Function
    Sub writeLog(message As String)
        Dim oUtil As Utilities = New Utilities

        If File.Exists(My.Application.Info.DirectoryPath & "\" & logName() & ".txt") Then
            Dim oLog As StreamWriter = File.AppendText(My.Application.Info.DirectoryPath & "\" & logName() & ".txt")
            oLog.WriteLine(Now().ToString & " | " & message)
            oLog.Close()
        Else
            Dim oLog As StreamWriter = File.CreateText(My.Application.Info.DirectoryPath & "\" & logName() & ".txt")
            oLog.WriteLine(Now().ToString & " | " & message)
            oLog.Close()
        End If
    End Sub
    Function openConnect(Optional conString As String = "")
        Dim oCon As New MySqlConnection
        oCon.ConnectionString = getINIValue("DB", "Connection")
        oCon.Open()

        Return oCon
    End Function
    Function getData(sql As String) As DataTable
        Dim oConn As New MySqlConnection

        oConn = openConnect()
        Dim oCommand As New MySqlCommand(sql, oConn)
        Dim drReader As MySqlDataReader = oCommand.ExecuteReader

        If drReader.HasRows = False Then
            If oConn.State = ConnectionState.Open Then
                oConn.Close()
                oConn.Dispose()
            End If
            Return Nothing
        Else
            Dim dtTemp As New DataTable
            dtTemp.Load(drReader)
            If oConn.State = ConnectionState.Open Then
                oConn.Close()
                oConn.Dispose()
            End If
            Return dtTemp
        End If


    End Function
    Function executeSQL(sql As String) As Boolean
        Try
            Dim oConn As New MySqlConnection
            Dim oCommand As MySqlCommand = New MySqlCommand

            oConn = openConnect()
            With oCommand
                .Connection = oConn
                .CommandText = sql
                .ExecuteNonQuery()
            End With
            oConn.Close()
            oConn.Dispose()
            Return True
        Catch ex As Exception
            writeLog("error :" & ex.Message & " ->sql :" & sql)
            Return False
        End Try
    End Function
    Function leftString(source As String, length As Integer) As String
        Return Microsoft.VisualBasic.Left(source, length)
    End Function
End Class
