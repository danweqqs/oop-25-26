namespace labs3.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;

        private System.Windows.Forms.Button btnOpenJson;
        private System.Windows.Forms.Button btnAbout;

        private System.Windows.Forms.DataGridView dataGridView1;

        private void InitializeComponent()
        {
            this.topPanel = new System.Windows.Forms.Panel();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();

            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();

            this.btnOpenJson = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();

            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            this.topPanel.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Height = 70;
            this.topPanel.Padding = new System.Windows.Forms.Padding(10);

            this.btnAdd.Text = "Додати";
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Size = new System.Drawing.Size(110, 40);
            this.btnAdd.Location = new System.Drawing.Point(20, 15);
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Click += btnAdd_Click;

            this.btnEdit.Text = "Редагувати";
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Size = new System.Drawing.Size(140, 40);
            this.btnEdit.Location = new System.Drawing.Point(140, 15);
            this.btnEdit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Click += btnEdit_Click;

            this.btnDelete.Text = "Видалити";
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Size = new System.Drawing.Size(130, 40);
            this.btnDelete.Location = new System.Drawing.Point(290, 15);
            this.btnDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Click += btnDelete_Click;

            this.btnSave.Text = "Зберегти";
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.Size = new System.Drawing.Size(130, 40);
            this.btnSave.Location = new System.Drawing.Point(430, 15);
            this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Click += btnSave_Click;

            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.Size = new System.Drawing.Size(220, 30);
            this.txtSearch.Location = new System.Drawing.Point(580, 20);

            this.btnSearch.Text = "Пошук";
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Size = new System.Drawing.Size(90, 30);
            this.btnSearch.Location = new System.Drawing.Point(810, 20);
            this.btnSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Click += btnSearch_Click;

            this.btnOpenJson.Text = "Відкрити JSON";
            this.btnOpenJson.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnOpenJson.Size = new System.Drawing.Size(130, 35);
            this.btnOpenJson.Location = new System.Drawing.Point(920, 17);
            this.btnOpenJson.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOpenJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenJson.Click += btnOpenJson_Click;

            this.btnAbout.Text = "Про програму";
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnAbout.Size = new System.Drawing.Size(130, 35);
            this.btnAbout.Location = new System.Drawing.Point(1060, 17);
            this.btnAbout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Click += btnAbout_Click;

            this.topPanel.Controls.Add(this.btnAdd);
            this.topPanel.Controls.Add(this.btnEdit);
            this.topPanel.Controls.Add(this.btnDelete);
            this.topPanel.Controls.Add(this.btnSave);
            this.topPanel.Controls.Add(this.txtSearch);
            this.topPanel.Controls.Add(this.btnSearch);
            this.topPanel.Controls.Add(this.btnOpenJson);
            this.topPanel.Controls.Add(this.btnAbout);

            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.ClientSize = new System.Drawing.Size(1230, 600);
            this.Text = "JSON диспетчер студентів";
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.topPanel);

            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}