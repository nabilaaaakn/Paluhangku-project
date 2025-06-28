﻿Imports MySql.Data.MySqlClient
Imports MySqlConnector
Imports System.Reflection.Emit

Public Class AlamiBullying
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query As String = "SELECT Isi_konten FROM tbedukasi WHERE Id_edukasi = 8"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    Label1.Text = reader("Isi_konten").ToString()
                End If
                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
        Dim query As String = "SELECT Judul FROM tbedukasi WHERE Id_edukasi = 8"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    Label2.Text = reader("Judul").ToString()
                End If
                reader.Close()
            End Using
        End Using
    End Sub
End Class