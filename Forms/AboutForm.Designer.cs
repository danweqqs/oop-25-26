namespace labs3.Forms
{
    partial class AboutForm
    {
        private Label label1;

        private void InitializeComponent()
        {
            label1 = new Label();

            SuspendLayout();

            label1.Location = new Point(10, 10);
            label1.Size = new Size(300, 200);

            Controls.Add(label1);

            ClientSize = new Size(320, 220);
            Text = "Про програму";

            ResumeLayout(false);
        }
    }
}