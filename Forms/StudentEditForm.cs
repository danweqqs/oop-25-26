using labs3.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace labs3.Forms
{
    public partial class StudentEditForm : Form
    {
        public Student Student { get; private set; }

        public StudentEditForm(Student s = null)
        {
            Student = s ?? new Student
            {
                Grades = new List<SubjectGrade>()
            };

            InitializeComponent();

            txtId.Text = Student.Id.ToString();
            txtName.Text = Student.Name ?? "";
            txtFaculty.Text = Student.Faculty ?? "";
            txtDepartment.Text = Student.Department ?? "";

            numCourse.Value = Student.Course > 0 ? Student.Course : numCourse.Minimum;
            numSemester.Value = Student.Semester > 0 ? Student.Semester : numSemester.Minimum;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Student.Id = int.Parse(txtId.Text);
            Student.Name = txtName.Text;
            Student.Faculty = txtFaculty.Text;
            Student.Department = txtDepartment.Text;

            Student.Course = (int)numCourse.Value;
            Student.Semester = (int)numSemester.Value;

            DialogResult = DialogResult.OK;
        }
    }
}