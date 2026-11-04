**-- 1. Membuat Database Baru (Jika belum ada)**

**CREATE DATABASE SekolahDB;**

**GO**



**-- 2. Menggunakan Database SekolahDB**

**USE SekolahDB;**

**GO**



**-- 3. Membuat Tabel Jurusan**

**CREATE TABLE Jurusan (**

&#x20;   **Id INT IDENTITY(1,1) PRIMARY KEY,**

&#x20;   **NamaJurusan NVARCHAR(100) NOT NULL**

**);**

**GO**



**-- 4. Membuat Tabel Siswa**

**CREATE TABLE Siswa (**

&#x20;   **Id INT IDENTITY(1,1) PRIMARY KEY,**

&#x20;   **Nama NVARCHAR(100) NOT NULL,**

&#x20;   **Umur INT NULL,**

&#x20;   **Alamat NVARCHAR(255) NULL,**

&#x20;   **JurusanID INT NULL, -- Boleh NULL karena di diagram tertulis 0..1**

&#x20;   

&#x20;   **-- Membuat Relasi Foreign Key ke Tabel Jurusan**

&#x20;   **CONSTRAINT FK\_Siswa\_Jurusan FOREIGN KEY (JurusanID)** 

&#x20;   **REFERENCES Jurusan(Id)** 

&#x20;   **ON DELETE SET NULL -- Jika jurusan dihapus, JurusanID di siswa jadi kosong**

**);**

**GO**



