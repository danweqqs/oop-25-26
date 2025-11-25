namespace labs3.Forms
{
    partial class StudentEditForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtSemester;
        private System.Windows.Forms.DataGridView gradesGrid;
        private System.Windows.Forms.Button btnOK;

        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.Label l6;

        private void InitializeComponent()
        {
            txtId = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            txtFaculty = new System.Windows.Forms.TextBox();
            txtDepartment = new System.Windows.Forms.TextBox();
            txtCourse = new System.Windows.Forms.TextBox();
            txtSemester = new System.Windows.Forms.TextBox();

            l1 = new System.Windows.Forms.Label();
            l2 = new System.Windows.Forms.Label();
            l3 = new System.Windows.Forms.Label();
            l4 = new System.Windows.Forms.Label();
            l5 = new System.Windows.Forms.Label();
            l6 = new System.Windows.Forms.Label();

            gradesGrid = new System.Windows.Forms.DataGridView();
            btnOK = new System.Windows.Forms.Button();

            SuspendLayout();

            l1.Text = "ID";
            l1.Location = new System.Drawing.Point(10, 10);
            txtId.Location = new System.Drawing.Point(120, 10);

            l2.Text = "Name";
            l2.Location = new System.Drawing.Point(10, 40);
            txtName.Location = new System.Drawing.Point(120, 40);

            l3.Text = "Faculty";
            l3.Location = new System.Drawing.Point(10, 70);
            txtFaculty.Location = new System.Drawing.Point(120, 70);

            l4.Text = "Department";
            l4.Location = new System.Drawing.Point(10, 100);
            txtDepartment.Location = new System.Drawing.Point(120, 100);

            l5.Text = "Course";
            l5.Location = new System.Drawing.Point(10, 130);
            txtCourse.Location = new System.Drawing.Point(120, 130);

            l6.Text = "Semester";
            l6.Location = new System.Drawing.Point(10, 160);
            txtSemester.Location = new System.Drawing.Point(120, 160);

            gradesGrid.Location = new System.Drawing.Point(10, 200);
            gradesGrid.Size = new System.Drawing.Size(380, 150);

            btnOK.Text = "OK";
            btnOK.Location = new System.Drawing.Point(10, 360);
            btnOK.Click += btnOK_Click;

            Controls.AddRange(new System.Windows.Forms.Control[]
            {
                l1, txtId, l2, txtName, l3, txtFaculty, l4, txtDepartment,
                l5, txtCourse, l6, txtSemester, gradesGrid, btnOK
            });

            ClientSize = new System.Drawing.Size(420, 420);
            Text = "Редагування студента";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}