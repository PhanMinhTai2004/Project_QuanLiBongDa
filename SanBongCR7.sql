CREATE DATABASE SANBONGCR7
GO

-- Bảng khách hàng
CREATE TABLE KhachHang (
    MaTaiKhoan INT PRIMARY KEY, 
    MatKhau VARCHAR(255) NOT NULL,
    HoTen NVARCHAR(255) NOT NULL,
    NgaySinh DATE,
    SDT VARCHAR(15)
);
drop table KhachHang


-- Bảng chủ sân
CREATE TABLE ChuSan (
    MaCoSoSan INT PRIMARY KEY, 
    DiaChiSan NVARCHAR(255) NOT NULL
);

-- Bảng sân bóng
CREATE TABLE SanBong (
    MaSanBong INT PRIMARY KEY, 
    LoaiSan NVARCHAR(50) NOT NULL,
    SoNguoiToiDa INT,
    SoSlotConTrong INT,
    MaCoSoSan INT, 
    FOREIGN KEY (MaCoSoSan) REFERENCES ChuSan(MaCoSoSan)
);

-- Bảng phiếu đăng ký đá ghép
CREATE TABLE PhieuDangKy (
    MaPhieu INT IDENTITY(1,1) PRIMARY KEY, 
    MaTaiKhoan INT NOT NULL, 
    MaSanBong INT NOT NULL, 
    SoNguoiDangKy INT,
    PhiDatCoc DECIMAL(10, 2),
    FOREIGN KEY (MaTaiKhoan) REFERENCES KhachHang(MaTaiKhoan), 
    FOREIGN KEY (MaSanBong) REFERENCES SanBong(MaSanBong) djfhfhihf
);