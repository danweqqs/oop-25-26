namespace labs3.Forms
{
    partial class StudentEditForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.TextBox txtDepartment;

        private System.Windows.Forms.NumericUpDown numCourse;
        private System.Windows.Forms.NumericUpDown numSemester;

        private System.Windows.Forms.Button btnOK;

        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.Label l6;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            txtId = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            txtFaculty = new System.Windows.Forms.TextBox();
            txtDepartment = new System.Windows.Forms.TextBox();

            numCourse = new System.Windows.Forms.NumericUpDown();
            numSemester = new System.Windows.Forms.NumericUpDown();

            btnOK = new System.Windows.Forms.Button();

            l1 = new System.Windows.Forms.Label();
            l2 = new System.Windows.Forms.Label();
            l3 = new System.Windows.Forms.Label();
            l4 = new System.Windows.Forms.Label();
            l5 = new System.Windows.Forms.Label();
            l6 = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(numCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(numSemester)).BeginInit();

            SuspendLayout();

            l1.Text = "ID";
            l1.Location = new System.Drawing.Point(10, 10);

            l2.Text = "Name";
            l2.Location = new System.Drawing.Point(10, 40);

            l3.Text = "Faculty";
            l3.Location = new System.Drawing.Point(10, 70);

            l4.Text = "Department";
            l4.Location = new System.Drawing.Point(10, 100);

            l5.Text = "Course";
            l5.Location = new System.Drawing.Point(10, 130);

            l6.Text = "Semester";
            l6.Location = new System.Drawing.Point(10, 160);

            txtId.Location = new System.Drawing.Point(120, 10);
            txtId.Width = 200;

            txtName.Location = new System.Drawing.Point(120, 40);
            txtName.Width = 200;

            txtFaculty.Location = new System.Drawing.Point(120, 70);
            txtFaculty.Width = 200;

            txtDepartment.Location = new System.Drawing.Point(120, 100);
            txtDepartment.Width = 200;

            numCourse.Location = new System.Drawing.Point(120, 130);
            numCourse.Minimum = 0;
            numCourse.Maximum = 10;
            numCourse.Width = 80;

            numSemester.Location = new System.Drawing.Point(120, 160);
            numSemester.Minimum = 0;
            numSemester.Maximum = 20;
            numSemester.Width = 80;

            btnOK.Text = "Зберегти";
            btnOK.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnOK.Size = new System.Drawing.Size(310, 40);
            btnOK.Location = new System.Drawing.Point(10, 210);
            btnOK.BackColor = System.Drawing.Color.SteelBlue;
            btnOK.ForeColor = System.Drawing.Color.White;
            btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOK.Click += btnOK_Click;

            Controls.AddRange(new System.Windows.Forms.Control[]
            {
                l1, txtId,
                l2, txtName,
                l3, txtFaculty,
                l4, txtDepartment,
                l5, numCourse,
                l6, numSemester,
                btnOK
            });

            ClientSize = new System.Drawing.Size(340, 270);
            Text = "Редагування студента";
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;

            ResumeLayout(false);
            PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(numCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(numSemester)).EndInit();
        }
    }
}