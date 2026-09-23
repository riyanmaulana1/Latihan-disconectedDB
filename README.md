**# Latihan Disconnected Environment Database (VB.NET Windows Forms)

![Visual Basic](https://img.shields.io/badge/Visual%20Basic-.NET-512BD4?style=for-the-badge&logo=visual-basic&logoColor=white)
![MySQL](https://img.shields.io/badge/MySQL-4479A1?style=for-the-badge&logo=mysql&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white)

Repositori ini berisi proyek latihan penerapan konsep **Disconnected Architecture** (Model Terputus) dalam pengolahan basis data menggunakan bahasa pemrograman **Visual Basic .NET (VB.NET)** dan GUI **Windows Forms**.

---

## 📌 Deskripsi Proyek

Proyek ini dibuat untuk mempelajari dan mempraktikkan konsep *Disconnected Data Access Architecture* pada .NET Framework / .NET Core, yaitu:
- Penggunaan komponen **DataSet** dan **DataTable** untuk menyimpan dan mengelola salinan data di memori lokal (RAM).
- Penggunaan **MySqlDataAdapter** / **SqlDataAdapter** untuk mengambil data dari basis data serta melakukan sinkronisasi perubahan (*Update*, *Insert*, *Delete*) kembali ke basis data.
- Efisiensi penggunaan koneksi basis data di mana koneksi hanya dibuka saat pengambilan/penyimpanan data dan langsung ditutup kembali, sehingga menghemat konsumsi daya server.

---

## 🛠️ Teknologi & Prasyarat

| Komponen | Badge / Ikon | Deskripsi |
| :--- | :--- | :--- |
| **Bahasa Pemrograman** | <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/dot-net/dot-net-original.svg" alt="VB.NET" width="24"/> **Visual Basic .NET** | Bahasa utama aplikasi Windows Forms |
| **Basis Data** | <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/mysql/mysql-original.svg" alt="MySQL" width="24"/> **MySQL Database** | Database relasional (RDBMS) |
| **Server Lokal** | <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/apache/apache-original.svg" alt="XAMPP" width="24"/> **XAMPP / MariaDB** | Server lokal Apache & MySQL |
| **IDE** | <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/visualstudio/visualstudio-plain.svg" alt="Visual Studio" width="24"/> **Visual Studio** | Lingkungan pengembangan terpadu (IDE) |

### Kebutuhan Sistem:
- **IDE / Editor:** [Visual Studio 2022](https://visualstudio.microsoft.com/) (Workload: *.NET Desktop Development*).
- **Driver / Library:** Paket `MySql.Data` (MySQL Connector/NET) terpasang melalui NuGet.
- **RDBMS:** MySQL Server / XAMPP Stack.

---

## 📂 Struktur Proyek

```text
Latihan-disconectedDB/
├── My Project/
│   ├── Application.Designer.vb   # Konfigurasi aplikasi VB.NET
│   └── Application.myapp          # Pengaturan runtime aplikasi
├── ApplicationEvents.vb           # Event handler tingkat aplikasi
├── Form1.Designer.vb              # Inisialisasi komponen UI form
├── Form1.resx                     # Resource file untuk Form1
├── Form1.vb                       # Logika form & penerapan Disconnected Architecture (DataSet/DataAdapter)
├── Latihan-disconectedDB.slnx     # File solusi Visual Studio (XML format)
└── Latihan-disconectedDB.vbproj   # Konfigurasi proyek .NET & dependensi paket**
