Imports MySql.Data.MySqlClient
Imports MySqlConnector
Imports System.Security.Cryptography
Imports System.Text

Public Class FormLogIn
    ' Informasi koneksi ke MySQL
    Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Ambil username dan password yang dimasukkan oleh pengguna
        Dim username As String = txtUsername.Text
        Dim password As String = tbPassword.Text

        ' Hash password yang dimasukkan pengguna
        Dim hashedPassword As String = GetSHA256Hash(password)


        ' Buat koneksi ke database
        Using connection As New MySqlConnection(connectionString)
            ' Buat query SQL untuk memeriksa keberadaan pengguna di database
            Dim query As String = "SELECT COUNT(*) FROM tbanggota WHERE Username = @username AND Password = @password"
            Using command As New MySqlCommand(query, connection)
                ' Tambahkan parameter untuk username dan password
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", hashedPassword)



                ' Buka koneksi
                connection.Open()
                    ' Eksekusi query dan baca hasilnya
                    Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())
                    ' Periksa hasil
                    If result > 0 Then
                        ' Jika pengguna terdaftar, munculkan ForumForm
                        Dim forumForm As New ForumForm()
                        forumForm.ShowDialog()
                        ' Sembunyikan form login
                        Me.Hide()
                    Else
                        ' Jika pengguna tidak terdaftar, tampilkan pesan
                        MessageBox.Show("Pengguna belum terdaftar, silahkan daftar terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    ' Tangani kesalahan jika terjadi
                    MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Tutup form login
        Me.Close()
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Saat form dimuat, atur textbox password agar menggunakan karakter password sistem
        tbPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub cbLihat_CheckedChanged(sender As Object, e As EventArgs) Handles cbLihat.CheckedChanged
        ' Saat checkbox untuk melihat password dicentang atau tidak
        ' Atur karakter password sistem sesuai dengan status checkbox
        tbPassword.UseSystemPasswordChar = Not cbLihat.Checked
    End Sub

    Private Function GetSHA256Hash(input As String) As String
        Using sha256 As SHA256 = sha256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(input))
            Dim builder As New StringBuilder()
            For Each b As Byte In bytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function
End Class