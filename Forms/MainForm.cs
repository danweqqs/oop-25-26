using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using labs3.Models;

namespace labs3.Forms
{
    public partial class MainForm : Form
    {
        private List<Student> students = new();

        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new StudentEditForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                students.Add(form.Student);
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            var st = (Student)dataGridView1.CurrentRow.DataBoundItem;
            var form = new StudentEditForm(st);

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            var st = (Student)dataGridView1.CurrentRow.DataBoundItem;
            students.Remove(st);

            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            JsonDataManager.SaveData(students);
            MessageBox.Show("JSON збережено!");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string key = txtSearch.Text.ToLower();

            var result = students.Where(s =>
                s.Id.ToString().Contains(key) ||
                s.Name.ToLower().Contains(key) ||
                s.Faculty.ToLower().Contains(key) ||
                s.Department.ToLower().Contains(key) ||
                s.Course.ToString().Contains(key) ||
                s.Semester.ToString().Contains(key) ||

                s.Grades.Any(g =>
                    g.Subject.ToLower().Contains(key) ||
                    g.Type.ToLower().Contains(key) ||
                    (g.Teacher != null && g.Teacher.ToLower().Contains(key)) ||
                    g.Score.ToString().Contains(key)
                )
            ).ToList();

            dataGridView1.DataSource = result;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }
        private void btnOpenJson_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSON files (*.json)|*.json";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                JsonDataManager.FilePath = dialog.FileName;

                students = JsonDataManager.LoadData();
                LoadData();

                MessageBox.Show("Файл успішно відкрито!");
            }
        }
    }
}