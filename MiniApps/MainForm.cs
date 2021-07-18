using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniApps
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа для нищих. Автор: подстольный рабочий Денис.", "О программе");
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
