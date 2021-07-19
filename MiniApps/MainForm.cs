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
        Random rand;

        public MainForm()
        {
            InitializeComponent();
            rand = new Random();
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

        private void buttonRand_Click(object sender, EventArgs e)
        {
            int num = rand.Next(Convert.ToInt32(randMin.Value), Convert.ToInt32(randMax.Value) + 1);
            randNum.Text = num.ToString();
            if (cbNoRepeat.Checked)
            {
                if (tbRand.Text.IndexOf(num.ToString()) == -1)
                    tbRand.AppendText(num + Environment.NewLine);
            }
            else
                tbRand.AppendText(num + Environment.NewLine);
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            tbRand.Clear();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbRand.Text);
        }
    }
}
