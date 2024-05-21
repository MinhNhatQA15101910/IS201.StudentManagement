using BLL;
using ComponentFactory.Krypton.Toolkit;
using DTO.Models;
using DTO.Responses;
using PL.IRequesters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PL
{
    public partial class StudentManagementForm : KryptonForm, IAddUpdateStudentRequester
    {
        private readonly IStudentBLL _studentBLL = new StudentBLL();

        private List<StudentDTO> _allStudents;
        private List<StudentDTO> _filteredStudents;

        private BindingList<StudentDTO> _students;
        private BindingSource _studentsSource;

        private readonly string _placeholderText = "🔎 Tìm kiếm";

        public StudentManagementForm()
        {
            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            _allStudents = _studentBLL.GetAllStudents();

            _students = new BindingList<StudentDTO>(_allStudents);
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

        private void OnStudentsGridViewSelectionChanged(object sender, EventArgs e)
        {
            if (studentListDgv.CurrentRow != null)
            {
                studentListDgv.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.Yellow;

                StudentDTO student = _students[studentListDgv.CurrentRow.Index];
                if (student != null)
                {
                    studentIdTxt.Text = student.StudentId;
                    fullNameTxt.Text = student.FullName;
                    majorTxt.Text = student.MajorName;
                    dateOfBirthTxt.Text = student.DateOfBirth.ToString("dd/MM/yyyy");
                    maleRBtn.Checked = student.Gender.Equals("Nam");
                    femaleRBtn.Checked = !student.Gender.Equals("Nam");
                }
            }
        }

        private void OnSearchTxtEntered(object sender, EventArgs e)
        {
            if (searchTxt.Text.Equals(_placeholderText))
            {
                searchTxt.Text = "";
                searchTxt.Font = new Font(searchTxt.Font, FontStyle.Regular);
                searchTxt.ForeColor = SystemColors.ControlText;
            }
        }

        private void OnSearchTxtLeft(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchTxt.Text.Trim()))
            {
                searchTxt.Text = _placeholderText;
                searchTxt.Font = new Font(searchTxt.Font, FontStyle.Italic);
                searchTxt.ForeColor = SystemColors.GrayText;
            }
        }

        private void OnFilterClicked(object sender, EventArgs e)
        {
            string searchQuery = searchTxt.Text.Trim().ToLower();

            _filteredStudents = _allStudents
                .Where(s => s.StudentId.ToLower().Contains(searchQuery) ||
                    s.FullName.ToLower().Contains(searchQuery) ||
                    s.MajorName.ToLower().Contains(searchQuery))
                .ToList();
            _students = new BindingList<StudentDTO>(_filteredStudents);
            _studentsSource.DataSource = _students;
        }

        private void OnCancelFilterClicked(object sender, EventArgs e)
        {
            _students = new BindingList<StudentDTO>(_allStudents);
            _studentsSource.DataSource = _students;
            searchTxt.Text = _placeholderText;
        }

        private void OnDeleteBtnClicked(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa sinh viên đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string studentId = studentListDgv.CurrentRow.Cells["StudentId"].Value as string;
                StudentDTO deletedStudent = _students[studentListDgv.CurrentRow.Index];

                MessageDTO message = _studentBLL.DeleteStudent(studentId);
                if (message.StatusCode != 200)
                {
                    MessageBox.Show(message.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _students.Remove(deletedStudent);
                    _allStudents.Remove(deletedStudent);
                    MessageBox.Show(message.Message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void OnAddBtnClicked(object sender, EventArgs e)
        {
            AddUpdateStudentForm form = new AddUpdateStudentForm(this);
            form.ShowDialog();
        }

        private void OnUpdateBtnClicked(object sender, EventArgs e)
        {
            StudentDTO student = _students[studentListDgv.CurrentRow.Index];

            AddUpdateStudentForm form = new AddUpdateStudentForm(this, student);
            form.Show();
        }

        public void OnReloadStudentList()
        {
            _allStudents = _studentBLL.GetAllStudents();

            _students = new BindingList<StudentDTO>(_allStudents);
            _studentsSource = new BindingSource(_students, null);
            studentListDgv.DataSource = _studentsSource;
        }
    }
}