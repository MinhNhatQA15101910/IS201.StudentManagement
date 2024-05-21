using BLL;
using ComponentFactory.Krypton.Toolkit;
using DTO.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PL
{
    public partial class StudentManagementForm : KryptonForm
    {
        private IStudentBLL _studentBLL = new StudentBLL();

        private BindingList<StudentDTO> _students;
        private BindingSource _studentsSource;

        private readonly string _placeholderText = "🔎 Tìm kiếm";

        public StudentManagementForm()
        {
            InitializeComponent();
        }

        private void dgvDanhSachSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            //if (dgvDanhSachSinhVien.CurrentRow != null)
            //{
            //    dgvDanhSachSinhVien.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.Yellow;

            //    CT_SinhVien sinhVien = mSinhVien[dgvDanhSachSinhVien.CurrentRow.Index];
            //    if (sinhVien != null)
            //    {
            //        txtMSSV.Text = sinhVien.MaSV;
            //        txtHoTen.Text = sinhVien.HoTen;
            //        txtNganh.Text = sinhVien.MaNganh + " - " + sinhVien.TenNganh;
            //        txtNgaySinh.Text = sinhVien.NgaySinh.ToString("dd/MM/yyyy");
            //        txtQueQuan.Text = sinhVien.TenHuyen + ", " + sinhVien.TenTTP;
            //        txtKhoa.Text = sinhVien.MaKhoa + " - " + sinhVien.TenKhoa;
            //        if (sinhVien.GioiTinh.Equals("Nam"))
            //        {
            //            rbtnNam.Checked = true;
            //            rbtnNu.Checked = false;
            //        }
            //        else
            //        {
            //            rbtnNam.Checked = false;
            //            rbtnNu.Checked = true;
            //        }
            //        mDoiTuong = new BindingList<DoiTuong>(_doiTuongBLLService.LayDSDoiTuongBangMaSV(sinhVien.MaSV));
            //        mDoiTuongSource = new BindingSource(mDoiTuong, null);
            //        lbDoiTuong.DataSource = mDoiTuongSource;
            //        lbDoiTuong.DisplayMember = "TenDT";
            //        lbDoiTuong.ValueMember = "MaDT";
            //    }
            //}
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            //if (txtTimKiem.Text.Equals(placeholderText))
            //{
            //    txtTimKiem.Text = "";
            //    txtTimKiem.Font = new Font(txtTimKiem.Font, FontStyle.Regular);
            //    txtTimKiem.ForeColor = SystemColors.ControlText;
            //}
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtTimKiem.Text.Trim()))
            //{
            //    txtTimKiem.Text = placeholderText;
            //    txtTimKiem.Font = new Font(txtTimKiem.Font, FontStyle.Italic);
            //    txtTimKiem.ForeColor = SystemColors.GrayText;
            //}
        }

        public void OnThemSuaSinhVienClosing()
        {
            //mSinhVien = new BindingList<CT_SinhVien>(_sinhVienBLLService.LayDSSV());
            //mSinhVienSource.DataSource = mSinhVien;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            //Close();
        }

        private void picLoc_Click(object sender, EventArgs e)
        {
            //string searchQuery = txtTimKiem.Text.Trim().ToLower();

            //BindingList<CT_SinhVien> filterList = new BindingList<CT_SinhVien>(mSinhVien.Where(d =>
            //        d.MaSV.ToLower().Contains(searchQuery) ||
            //        d.HoTen.ToLower().Contains(searchQuery)).ToList()
            //    );
            //mSinhVienSource.DataSource = filterList;
        }

        private void picBoLoc_Click(object sender, EventArgs e)
        {
            //mSinhVienSource.DataSource = mSinhVien;
            //txtTimKiem.Text = placeholderText;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //ThemSuaSinhVien themSuaSinhVien = new ThemSuaSinhVien(this);
            //themSuaSinhVien.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Bạn có muốn xóa sinh viên đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (result == DialogResult.Yes)
            //{
            //    string maSV = dgvDanhSachSinhVien.CurrentRow.Cells["MaSV"].Value as string;
            //    CT_SinhVien sinhVien = mSinhVien[dgvDanhSachSinhVien.CurrentRow.Index];

            //    XoaSinhVienMessage message = _sinhVienBLLService.XoaSinhVien(maSV);
            //    switch (message)
            //    {
            //        case XoaSinhVienMessage.Success:
            //            mSinhVien.Remove(sinhVien);
            //            MessageBox.Show("Xóa sinh viên thành công!");
            //            break;
            //    }
            //}
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //CT_SinhVien sinhVien = mSinhVien[dgvDanhSachSinhVien.CurrentRow.Index];

            //ThemSuaSinhVien themSuaSinhVien = new ThemSuaSinhVien(this, sinhVien);
            //themSuaSinhVien.Show();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            _students = new BindingList<StudentDTO>(_studentBLL.GetAllStudents());
            _studentsSource = new BindingSource(_students, null);
            studentListDgv.DataSource = _studentsSource;

            studentListDgv.Columns["StudentId"].HeaderText = "MSSV";
            studentListDgv.Columns["StudentId"].Width = 200;

            studentListDgv.Columns["FullName"].HeaderText = "Họ và tên";
            studentListDgv.Columns["FullName"].Width = 300;

            studentListDgv.Columns["MajorName"].HeaderText = "Tên ngành";
            studentListDgv.Columns["MajorName"].Width = 300;

            studentListDgv.Columns["Id"].Visible = false;
            studentListDgv.Columns["DateOfBirth"].Visible = false;
            studentListDgv.Columns["Gender"].Visible = false;
        }
    }
}