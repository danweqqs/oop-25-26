using System.Windows.Forms;

namespace labs3.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            label1.Text =
                "Автор: Сорокін Даніїл\n" +
                "Група: К-26\n" +
                "Курс: 2\n" +
                "Рік: 2025\n" +
                "JSON диспетчер студентів.";
        }
    }
}