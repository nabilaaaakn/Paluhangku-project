Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class ForumForm
    ' Informasi koneksi ke MySQL
    Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"

    Private Sub btnKirim_Click(sender As Object, e As EventArgs) Handles btnKirim.Click
        Dim pesan As String = TextBoxPesanBaru.Text

        ' Pastikan pesan tidak kosong sebelum mengirimkannya
        If pesan <> "" Then
            ' Tambahkan pesan ke dalam List Box
            ListBoxDiskusiUmum.Items.Add(pesan)

            ' Simpan pesan ke dalam database MySQL
            SimpanKeDatabase(pesan)

            ' Kosongkan TextBox setelah mengirim pesan
            TextBoxPesanBaru.Text = ""
        Else
            MessageBox.Show("Silakan tulis pesan terlebih dahulu.")
        End If
    End Sub

    ' Fungsi untuk menyimpan pesan ke database MySQL
    Private Sub SimpanKeDatabase(pesan As String)
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "INSERT INTO tbforum (Isi_cerita) VALUES (@pesan)"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@pesan", pesan)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Cerita anda sudah berhasil dikirim!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
End Class