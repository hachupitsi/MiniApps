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
        int count = 0;

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

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            count++;
            labelNum.Text = count.ToString();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            count--;
            labelNum.Text = count.ToString();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            count = 0;
            labelNum.Text = count.ToString();
        }
    }
}
