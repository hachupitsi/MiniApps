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
        char[] SpecSym = new char[] {'@', '$', '&', '^', '%', '*'};
        Dictionary<String, double> metrics;

        public MainForm()
        {
            InitializeComponent();
            rand = new Random();
            metrics = new Dictionary<string, double>();
            metrics.Add("мм", 1);
            metrics.Add("см", 10);
            metrics.Add("дм", 100);
            metrics.Add("м", 1000);
            metrics.Add("км", 1000000);
            metrics.Add("дюймы", 25.4);
            metrics.Add("футы", 304.8);
            metrics.Add("ярды", 914.4);
            metrics.Add("мили", 1609000);
            metrics.Add("г", 1);
            metrics.Add("кг", 1000);
            metrics.Add("т", 1000000);
            metrics.Add("фунты", 453.6);
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

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            rtbNotepad.SaveFile("note.rtf");
        }

        private void LoadNote()
        {
            try
            {
                rtbNotepad.LoadFile("note.rtf");
            }
            catch
            {
                MessageBox.Show("Файл ещё не создан");
            }
        }

        private void tsmiLoad_Click(object sender, EventArgs e)
        {
            LoadNote();
        }

        private void tsmiDate_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now.ToShortDateString());
        }

        private void tsmiTime_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now.ToShortTimeString());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadNote();
            clbParam.SetItemChecked(0, true);
            clbParam.SetItemChecked(2, true);
        }

        private void buttonGen_Click(object sender, EventArgs e)
        {
            if (clbParam.CheckedItems.Count == 0)
                return;
            String password = "";
            for (int i = 0; i < passwordLength.Value; i++)
            {
                int paramInd = rand.Next(clbParam.CheckedItems.Count);
                String param = clbParam.CheckedItems[paramInd].ToString();
                switch (param)
                {
                    case "Строчные буквы":
                        password += Convert.ToChar(rand.Next(97, 123));
                        break;
                    case "Прописные буквы":
                        password += Convert.ToChar(rand.Next(65, 91));
                        break;
                    case "Цифры":
                        password += rand.Next(10);
                        break;
                    default:
                        password += SpecSym[rand.Next(SpecSym.Length)];
                        break;
                }
                tbPassword.Text = password;
                Clipboard.SetText(tbPassword.Text);
            }
        }

        private void cbSwitch_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbSwitch.Text)
            {
                case "Вес":
                    cbFrom.Items.Clear();
                    cbFrom.Items.Add("г");
                    cbFrom.Items.Add("кг");
                    cbFrom.Items.Add("т");
                    cbFrom.Items.Add("фунты");
                    cbFrom.Text = "г";
                    cbTo.Items.Clear();
                    cbTo.Items.Add("г");
                    cbTo.Items.Add("кг");
                    cbTo.Items.Add("т");
                    cbTo.Items.Add("фунты");
                    cbTo.Text = "г";
                    break;
                default:
                    cbFrom.Items.Clear();
                    cbFrom.Items.Add("мм");
                    cbFrom.Items.Add("см");
                    cbFrom.Items.Add("дм");
                    cbFrom.Items.Add("м");
                    cbFrom.Items.Add("км");
                    cbFrom.Items.Add("дюймы");
                    cbFrom.Items.Add("футы");
                    cbFrom.Items.Add("ярды");
                    cbFrom.Items.Add("мили");
                    cbFrom.Text = "мм";
                    cbTo.Items.Clear();
                    cbTo.Items.Add("мм");
                    cbTo.Items.Add("см");
                    cbTo.Items.Add("дм");
                    cbTo.Items.Add("м");
                    cbTo.Items.Add("км");
                    cbTo.Items.Add("дюймы");
                    cbTo.Items.Add("футы");
                    cbTo.Items.Add("ярды");
                    cbTo.Items.Add("мили");
                    cbTo.Text = "мм";
                    break;
            }
        }

        private void buttonSwap_Click(object sender, EventArgs e)
        {
            String temp = cbFrom.Text;
            cbFrom.Text = cbTo.Text;
            cbTo.Text = temp;
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            tbTo.Text = Convert.ToString(Convert.ToDouble(tbFrom.Text) * metrics[cbFrom.Text] / metrics[cbTo.Text]);
        }
    }
}
