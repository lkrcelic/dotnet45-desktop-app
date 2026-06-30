using System;
using System.Windows.Forms;

namespace Dotnet45DesktopApp
{
    /// <summary>
    /// The single window of this simple desktop application.
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            greetingLabel.Text = AppInfo.GetGreeting();
        }

        private void sayHelloButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                AppInfo.GetGreeting(),
                AppInfo.Name,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
