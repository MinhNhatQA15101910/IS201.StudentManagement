﻿CREATE DATABASE student_management_db;
USE student_management_db;

CREATE TABLE students (
	id INT IDENTITY(1, 1) NOT NULL,
	student_id VARCHAR(8) NOT NULL UNIQUE,
	full_name NVARCHAR(100) NOT NULL, 
	date_of_birth DATE NOT NULL, 
	gender NVARCHAR(10) NOT NULL, 
	major_name NVARCHAR(200) NOT NULL,

	CONSTRAINT pk_students PRIMARY KEY (id)
);

SET DATEFORMAT DMY;

INSERT INTO students(student_id, full_name, date_of_birth, gender, major_name) VALUES
('21520007', N'Võ Thanh Bình', '15/05/2003', N'Nam', N'Khoa học máy tính'),
('21520013', N'Trương Bá Cường', '20/10/2003', N'Nam', N'Khoa học máy tính'),
('21520053', N'Nguyễn Hữu Hiếu', '17/09/2003', N'Nam', N'Khoa học máy tính'),
('21520167', N'Phan Huy Tiến', '04/08/2003', N'Nam', N'Khoa học máy tính'),
('21520179', N'Nguyễn Thành Trung', '05/08/2003', N'Nam', N'Khoa học máy tính'),
('21520210', N'Nguyễn Minh Đức', '06/05/2003', N'Nam', N'Khoa học máy tính'),
('21520302', N'Bế Hải Long', '03/08/2003', N'Nam', N'Khoa học máy tính'),
('21520438', N'Phan Quốc An', '13/04/2003', N'Nam', N'Khoa học máy tính'),
('21520608', N'Võ Minh Đôn', '05/02/2003', N'Nam', N'Khoa học máy tính'),
('21520626', N'Trương Hữu Minh Đức', '10/03/2003', N'Nam', N'Khoa học máy tính'),
('21521066', N'Nguyễn Xuân Luân', '17/07/2003', N'Nam', N'Trí tuệ nhân tạo'),
('21521079', N'Nguyễn Thị Khánh Ly', '07/12/2003', N'Nữ',  N'Trí tuệ nhân tạo'),
('21521117', N'Đào Duy Từ', '06/01/2003', N'Nam', N'Trí tuệ nhân tạo'),
('21521528', N'Nguyễn Hữu Trí', '16/03/2003', N'Nam', N'Trí tuệ nhân tạo'),
('21521585', N'Nguyễn Xuân Tú', '24/11/2003', N'Nam', N'Trí tuệ nhân tạo'),
('21521604', N'Nguyễn Thanh Tuấn', '16/08/2003', N'Nam', N'Trí tuệ nhân tạo'),
('21521616', N'Lê Xuân Tùng', '20/08/2003', N'Nam', N'Trí tuệ nhân tạo'),
('21520251', N'Nguyễn Đình Tuấn Anh', '15/05/2003', N'Nam', N'Trí tuệ nhân tạo'),
('21520266', N'Nguyễn Minh Đức', '22/04/2003', N'Nam', N'Trí tuệ nhân tạo'),
('21520032', N'Đôn Khánh Duy', '30/09/2003', N'Nam', N'Trí tuệ nhân tạo'),
('21520093', N'Trần Hoàng Long', '15/02/2003', N'Nam', N'Kỹ thuật phần mềm'),
('21521457', N'Lê Minh Thông', '30/05/2003', N'Nam', N'Kỹ thuật phần mềm'),
('21521477', N'Nguyễn Thị Thúy', '26/02/2003', N'Nữ', N'Kỹ thuật phần mềm'),
('21520378', N'Nguyễn Thị Thủy Tiên', '11/06/2003', N'Nữ', N'Kỹ thuật phần mềm'),
('21521495', N'Trương Thảo Tiên', '28/06/2003', N'Nữ', N'Kỹ thuật phần mềm'),
('21521572', N'Trần Nguyễn Quang Trường', '16/07/2003', N'Nam', N'Kỹ thuật phần mềm'),
('21521156', N'Đào Trung Nguyên', '30/04/2003', N'Nữ', N'Kỹ thuật phần mềm'),
('21521236', N'Dương Hoài Phong', '23/09/2003', N'Nam', N'Kỹ thuật phần mềm'),
('21521332', N'Đặng Xuân Sang', '06/03/2003', N'Nam', N'Kỹ thuật phần mềm'),
('21521415', N'Văn Duy Thanh', '04/09/2003', N'Nữ', N'Kỹ thuật phần mềm'),
('21520365', N'Trần Chí Thiện', '11/02/2003', N'Nam', N'Kỹ thuật máy tính'),
('21521544', N'Bùi Chí Trung', '07/11/2003', N'Nam', N'Kỹ thuật máy tính'),
('21520182', N'Nguyễn Quang Trường', '04/04/2003', N'Nam', N'Kỹ thuật máy tính'),
('21520423', N'Huỳnh Ngọc Thiên Ân', '26/12/2003', N'Nam', N'Kỹ thuật máy tính'),
('21520262', N'Phù Hữu Đạt', '10/04/2003', N'Nam', N'Kỹ thuật máy tính'),
('21520648', N'Nguyễn Thị Thùy Dương', '23/08/2003', N'Nữ', N'Kỹ thuật máy tính'),
('21520800', N'Nguyễn Hải Hưng', '12/10/2003', N'Nam', N'Kỹ thuật máy tính'),
('21520863', N'Nguyễn Thị Thu Huyền', '10/05/2003', N'Nữ', N'Kỹ thuật máy tính'),
('21520866', N'Hồ Công Huynh', '01/03/2003', N'Nam', N'Kỹ thuật máy tính'),
('21520879', N'Phan Tấn Nhất Khâm', '16/03/2003', N'Nam', N'Kỹ thuật máy tính'),
('21520099', N'Trần Xuân Mạnh', '07/12/2003', N'Nam', N'Hệ thống thông tin'),
('21521286', N'Phạm Hồ Anh Quân', '13/02/2003', N'Nam', N'Hệ thống thông tin'),
('21521520', N'Nguyễn Trần Thị Bích Trâm','27/11/2003', N'Nữ', N'Hệ thống thông tin'),
('21521525', N'Vòng Thủy Thùy Trang', '04/04/2003', N'Nữ', N'Hệ thống thông tin'),
('21520190', N'Bùi Thúy Vi', '12/11/2003', N'Nữ', N'Hệ thống thông tin'),
('21520136', N'Huỳnh Bá Anh Quân', '07/06/2003', N'Nam', N'Hệ thống thông tin'),
('21520381', N'Lê Nguyễn Công Toại', '12/04/2003', N'Nam', N'Hệ thống thông tin'),
('21520591', N'Trần Tiến Đạt', '15/03/2003', N'Nam', N'Hệ thống thông tin'),
('21520597', N'Nguyễn Thị Ngọc Diễm', '04/11/2003', N'Nữ', N'Hệ thống thông tin'),
('21520984', N'Đào Quang Linh', '07/07/2003', N'Nam', N'Hệ thống thông tin'),
('21521021', N'Đinh Phạm Thiên Long', '31/12/2003', N'Nam', N'Thương mại điện tử'),
('21521065', N'Nguyễn Tiến Luận', '24/11/2003', N'Nam', N'Thương mại điện tử'),
('21521178', N'Nguyễn Thành Nhân', '10/04/2003', N'Nam', N'Thương mại điện tử'),
('21521197', N'Phạm Tân Nhật', '08/04/2003', N'Nam', N'Thương mại điện tử'),
('21521250', N'Trần Hoàng Thiên Phú', '06/05/2003', N'Nam', N'Thương mại điện tử'),
('21521449', N'Phạm Công Thịnh', '01/01/2003', N'Nam', N'Thương mại điện tử'),
('21521608', N'Trần Minh Tuấn', '10/09/2003', N'Nam', N'Thương mại điện tử'),
('21520143', N'Vũ Quí San', '01/06/2003', N'Nam', N'Thương mại điện tử'),
('21520285', N'Nguyễn Lê Hoàng Hùng', '24/02/2003', N'Nam', N'Thương mại điện tử'),
('21520691', N'Nguyễn Thị Hà', '05/06/2003', N'Nữ', N'Thương mại điện tử'),
('21520882', N'Dương Lê Tường Khang', '25/09/2003', N'Nam', N'Thương mại điện tử'),
('21521247', N'Phan Lê Phú', '15/03/2003', N'Nam', N'Mạng Máy tính và Truyền thông'),
('21521394', N'Nguyễn Hoàng Thắng', '06/09/2003', N'Nam', N'Mạng Máy tính và Truyền thông'),
('21521596', N'Huỳnh Minh Tuấn', '19/10/2003', N'Nam', N'Mạng Máy tính và Truyền thông'),
('21520035', N'Nguyễn Hoàng Khánh Duy', '19/12/2003', N'Nam', N'Mạng Máy tính và Truyền thông'),
('21520102', N'Phạm Nhật Minh', '29/11/2003', N'Nam', N'Mạng Máy tính và Truyền thông'),
('21520135', N'Nguyễn Thị Phương', '07/01/2003', N'Nữ', N'Mạng Máy tính và Truyền thông'),
('21520270', N'Hoàng Thị Ánh Dương', '15/03/2003', N'Nữ', N'Mạng Máy tính và Truyền thông'),
('21520291', N'Liêu Gia Khánh', '24/04/2003', N'Nam', N'Mạng Máy tính và Truyền thông'),
('21520574', N'Nguyễn Quốc Đạt', '26/08/2003', N'Nam', N'Mạng Máy tính và Truyền thông'),
('21520596', N'Nguyễn Thị Bích Diễm', '20/10/2003', N'Nữ', N'Mạng Máy tính và Truyền thông'),
('21520723', N'Nguyễn Thị Thu Hiền', '21/05/2003', N'Nữ', N'Mạng Máy tính và Truyền thông'),
('21520747', N'Nguyễn Minh Hiếu', '29/09/2003', N'Nam', N'An toàn thông tin'),
('21520834', N'Lê Quốc Huy', '03/05/2003', N'Nam', N'An toàn thông tin'),
('21520894', N'Nguyễn Thịnh Khang', '14/12/2003', N'Nam', N'An toàn thông tin'),
('21521074', N'Ngân Văn Luyện', '14/09/2003', N'Nam', N'An toàn thông tin'),
('21521251', N'Đinh Ngọc Phúc', '22/01/2003', N'Nam', N'An toàn thông tin'),
('21521292', N'Đoàn Minh Quang', '11/06/2003', N'Nam', N'An toàn thông tin'),
('21521300', N'Nguyễn Nhật Quang', '07/11/2003', N'Nam', N'An toàn thông tin'),
('21521312', N'Tống Đình Quốc', '10/10/2003', N'Nam', N'An toàn thông tin'),
('21521399', N'Trần Quốc Thắng', '04/09/2003', N'Nam', N'An toàn thông tin'),
('21521487', N'Nguyễn Hữu Tiến', '13/11/2003', N'Nam', N'An toàn thông tin'),
('21521511', N'Phạm Đức Toàn', '07/01/2003', N'Nam', N'An toàn thông tin'),
('21521514', N'Vũ Đức Tới', '20/03/2003', N'Nam', N'Công nghệ thông tin'),
('21521581', N'Mai Xuân Tú', '10/01/2003', N'Nam', N'Công nghệ thông tin'),
('21521586', N'Phạm Anh Tú', '07/08/2003', N'Nam', N'Công nghệ thông tin'),
('21521645', N'Đỗ Quốc Vinh', '19/10/2003', N'Nam', N'Công nghệ thông tin'),
('21521695', N'Trần Huy Thắng', '31/07/2003', N'Nam', N'Công nghệ thông tin'),
('21520570', N'Lê Phan Thành Đạt', '20/07/2003', N'Nam', N'Công nghệ thông tin'),
('21520641', N'Võ Thành Trung Dũng', '25/05/2003', N'Nam', N'Công nghệ thông tin'),
('21520711', N'Dương Thị Hồng Hạnh', '19/10/2003', N'Nữ', N'Công nghệ thông tin'),
('21520714', N'Huỳnh Nhật Hào', '30/09/2003', N'Nam', N'Công nghệ thông tin'),
('21520754', N'Trần Trung Hiếu', '05/04/2003', N'Nam', N'Khoa học dữ liệu'),
('21520758', N'Võ Trung Hiếu', '12/11/2003', N'Nam', N'Khoa học dữ liệu'),
('21520767', N'Võ Kiều Hoa', '20/03/2003', N'Nữ', N'Khoa học dữ liệu'),
('21520938', N'Trần Nguyễn Anh Khoa', '24/02/2003', N'Nam', N'Khoa học dữ liệu'),
('21521046', N'Nguyễn Thiên Long', '26/11/2003', N'Nam', N'Khoa học dữ liệu'),
('21521176', N'Nguyễn Hoàng Nhân', '02/09/2003', N'Nam', N'Khoa học dữ liệu'),
('21521227', N'Trịnh Ngọc Pháp', '04/03/2003', N'Nam', N'Khoa học dữ liệu'),
('21521384', N'Nguyễn Thị Thắm', '24/11/2003', N'Nữ', N'Khoa học dữ liệu'),
('21521470', N'Nguyễn Quang Thuận', '21/04/2003', N'Nam', N'Khoa học dữ liệu'),
('21521636', N'Nguyễn Thanh Tường Vi', '15/11/2003', N'Nữ', N'Khoa học dữ liệu');
