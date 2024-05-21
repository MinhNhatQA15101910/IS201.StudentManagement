using BLL;
using ComponentFactory.Krypton.Toolkit;
using DTO.Models;
using DTO.Responses;
using PL.IRequesters;
using System;
using System.Windows.Forms;

namespace PL
{
    public partial class AddUpdateStudentForm : KryptonForm
    {
        private readonly IStudentBLL _studentBLL = new StudentBLL();
        private readonly IAddUpdateStudentRequester _addUpdateStudentRequester;
        private readonly StudentDTO _student;

        public AddUpdateStudentForm(IAddUpdateStudentRequester requester)
        {
            InitializeComponent();

            _addUpdateStudentRequester = requester;

            SettingProperties();
        }

        public AddUpdateStudentForm(IAddUpdateStudentRequester requester, StudentDTO student)
        {
            InitializeComponent();

            _addUpdateStudentRequester = requester;
            _student = student;

            SettingProperties();
        }

        private void SettingProperties()
        {
            if (_student != null)
            {
                Text = "Cập nhật sinh viên";
                titleLabel.Text = "CẬP NHẬT SINH VIÊN";

                studentIdTxt.Text = _student.StudentId;
                fullNameTxt.Text = _student.FullName;
                maleRBtn.Checked = _student.Gender.Equals("Nam");
                femaleRBtn.Checked = !_student.Gender.Equals("Nam");
                dobDatePicker.Value = _student.DateOfBirth;
                majorTxt.Text = _student.MajorName;
            }
            else
            {
                Text = "Thêm sinh viên";
                titleLabel.Text = "THÊM SINH VIÊN";
                maleRBtn.Checked = true;
            }
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            _addUpdateStudentRequester?.OnReloadStudentList();
        }

        private void OnClearBtnClicked(object sender, EventArgs e)
        {
            studentIdTxt.Clear();
            fullNameTxt.Clear();
            majorTxt.Clear();
            maleRBtn.Checked = true;
            femaleRBtn.Checked = false;
            dobDatePicker.Value = DateTime.Now;
        }

        private void OnVerifyBtnClicked(object sender, EventArgs e)
        {
            if (_student == null)
            {
                AddStudent();
            } 
            else
            {
                UpdateStudent();
            }
        }

        private void AddStudent()
        {
            string studentId = studentIdTxt.Text.Trim();
            string fullName = fullNameTxt.Text.Trim();
            string majorName = majorTxt.Text.Trim();
            DateTime dateOfBirth = dobDatePicker.Value;
            string gender = maleRBtn.Checked ? "Nam" : "Nữ";

            StudentDTO newStudent = new StudentDTO 
            {
                StudentId = studentId,
                FullName = fullName,
                MajorName = majorName,
                DateOfBirth = dateOfBirth,
                Gender = gender,
            };

            MessageDTO message = _studentBLL.AddStudent(newStudent);
            if (message.StatusCode == 200)
            {
                MessageBox.Show(message.Message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(message.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStudent()
        {
            string studentId = studentIdTxt.Text.Trim();
            string fullName = fullNameTxt.Text.Trim();
            string majorName = majorTxt.Text.Trim();
            DateTime dateOfBirth = dobDatePicker.Value;
            string gender = maleRBtn.Checked ? "Nam" : "Nữ";

            StudentDTO newStudent = new StudentDTO
            {
                Id = _student.Id,
                StudentId = studentId,
                FullName = fullName,
                MajorName = majorName,
                DateOfBirth = dateOfBirth,
                Gender = gender,
            };

            MessageDTO message = _studentBLL.UpdateStudent(newStudent);
            if (message.StatusCode == 200)
            {
                MessageBox.Show(message.Message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(message.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}