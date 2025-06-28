# Paluhangku-project
Aplikasi desktop edukatif untuk pencegahan dan penanganan bullying menggunakan Visual Basic

# Paluhangku

**Paluhangku** adalah aplikasi desktop berbasis Visual Basic untuk pencegahan dan penanganan bullying. Aplikasi ini bertujuan untuk mengedukasi pengguna mengenai bullying serta menyediakan fitur-fitur pendukung seperti login, registrasi, enkripsi data, dan koneksi ke database.

> 🎓 Project ini merupakan hasil tugas mata kuliah *Pemrograman Visual* semester 2. Mohon maklum jika masih terdapat kekurangan ya! 😊

---

## 🛠️ Teknologi yang Digunakan

- **Visual Basic** (via Visual Studio)
- **MySQL** sebagai database
- **SHA-256** untuk enkripsi password
- **Windows Forms** untuk UI

---

## 📂 Struktur Folder (setelah clone)
C:\Users<YourName>\source\repos\Paluhangku


Pastikan file berada di path di atas agar tidak error saat dibuka di Visual Studio.

---

## 🚀 Cara Menjalankan Project

Berikut langkah-langkah untuk menjalankan aplikasi ini:

1. **Install Visual Studio**
- Pastikan sudah terinstall Visual Studio yang mendukung Visual Basic .NET.

2. **Clone repository ini**
   ```bash
   git clone https://github.com/username/paluhangku.git
3. Buka Project di Visual Studio
- Masuk ke folder:C:\Users<YourName>\source\repos\Paluhangku
- Buka file `.sln` (solution file) menggunakan Visual Studio.

4. Unblock File .resx
- Klik kanan setiap file `.resx`
- Pilih **Properties**
- Jika ada opsi **"Unblock"**, centang ✅ opsi tersebut

5. Import Database
- Import file `dbpaluhangku.sql` ke MySQL kalian masing-masing
- Nama database harus: **`dbpaluhangku`**
- Bisa menggunakan **phpMyAdmin** atau **MySQL Workbench**

6. Setup Koneksi Database di Kode
- Buka bagian kode yang mengatur koneksi database
- Pastikan isi connection string seperti ini:
```vb
Dim connectionString As String = "server=localhost;user=forum_paluhangku;password=kelompok4;database=dbpaluhangku"
```
server, user, dan password bisa disesuaikan dengan MySQL di perangkat kalian,
tapi nama database (dbpaluhangku) harus sama.

7. Cek dan Sesuaikan Semua Form
Pastikan semua form yang melakukan query ke database sudah menyesuaikan dengan:
- Struktur database
  - Nama tabel
  - Nama kolom
  - Koneksi yang digunakan

8. Jalankan Project
- Klik tombol Start/Running di Visual Studio
- Gunakan akun yang sudah terdaftar untuk login, atau klik Sign Up untuk membuat akun baru
---

## 👥 Tim Pengembang
Kelompok 4 - Mahasiswa Sistem Informasi
Universitas Bakrie
- Nabila Khairun Nisa (Programmer)
- Hafizhah Dea Az Zahrah (System Analyst)
- Rara Kholillah (System Analyst)
- Kevin Septiani (Designer)
- Mira Nuryanti (System Analyst)

📌 Catatan Tambahan
Untuk menjalankan aplikasi ini, kamu mungkin perlu membuat user account MySQL baru yang punya akses ke dbpaluhangku.
Jangan lupa cek ulang semua pengaturan koneksi database di form login, sign up, dsb.
Aplikasi ini masih terus dikembangkan dan bisa dieksplor lebih lanjut 🚀
