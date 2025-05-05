--- CREATE DATABASE
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'db_QLThuocDongY')
BEGIN
    CREATE DATABASE db_QLThuocDongY;
END
GO

USE db_QLThuocDongY;
--- CREATE TABLES
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'tb_product')
BEGIN
    CREATE TABLE tb_product (
        id_product CHAR(20) PRIMARY KEY,
        Product_Name NVARCHAR(50),
        Prices INT,
        Quantity FLOAT,
        Type NVARCHAR(10),
        Status NVARCHAR(20)
    );
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'tb_useraccount')
BEGIN
    CREATE TABLE tb_useraccount (
        id_user CHAR(20) PRIMARY KEY,
        username NVARCHAR(50) UNIQUE,
        email CHAR(50),
        Pass CHAR(50),
        user_role NVARCHAR(50)
    );
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'tb_order')
BEGIN
    CREATE TABLE tb_order (
        id_order CHAR(20) PRIMARY KEY,
        id_user CHAR(20),
        Status NVARCHAR(50),
        order_date DATE,
        total_price INT,
        firstname NVARCHAR(50),
        lastname NVARCHAR(50),
        email CHAR(50),
        phone CHAR(10),
        detail_address NVARCHAR(50),
        payment_method VARCHAR(20)
    );
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'tb_orderdetail')
BEGIN
    CREATE TABLE tb_orderdetail (
        id_order CHAR(20),
        id_product CHAR(20),
        Quantity FLOAT,
        Price INT,
        PRIMARY KEY (id_order, id_product)
    );
END
GO

---
GO
INSERT INTO tb_product (id_product, Product_Name, Prices, Quantity, Type, Status) VALUES
('T005', N'Bạch chỉ', 30000, 25, N'gram', N'In Stock'),
('T006', N'Cam thảo', 20000, 40, N'gram', N'Out Stock'),
('T007', N'Hoàng kỳ', 35000, 30, N'gram', N'In Stock'),
('T008', N'Táo nhân', 28000, 15, N'gram', N'Out Stock'),
('T009', N'Nhân sâm', 150000, 10, N'gram', N'No Longer Available');

---

INSERT INTO tb_useraccount (id_user, username, email, Pass, user_role) VALUES
('U001', N'jane_doe', 'janedoe_admin@gmail.com', 'admin123',N'Admin'),
('U002', N'tran_thanh', 'tranthanh@gmail.com', '25102005',N'Customer')

---
INSERT INTO tb_order 
(id_order, id_user, order_date, total_price, firstname, lastname, email, phone, detail_address, Status, payment_method) 
VALUES
('D001', 'U001', '2024-03-01', 150000, N'Jane', N'Doe', 'janedoe_admin@gmail.com', '0123456789', N'123 Main St', N'Chờ xử lý', 0),
('D002', 'U002', '2024-03-05', 125000, N'Thành', N'Trấn', 'tranthanh@gmail.com', '0987654321', N'456 Binh Thanh', N'Đang giao', 1),
('D003', 'U003', '2024-03-10', 200000, N'Anh', N'Trần', 'anh@gmail.com', '0909090909', N'789 District 1', N'Đã giao', 0);

---
INSERT INTO tb_orderdetail(id_order, id_product, Quantity, Price) VALUES
('D001', 'T005', 10, 150000),
('D002', 'T006', 5, 125000),
('D003', 'T008', 20, 200000);
