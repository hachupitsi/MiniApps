namespace MiniApps
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabConrol1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelNum = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRand = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.randMin = new System.Windows.Forms.NumericUpDown();
            this.randMax = new System.Windows.Forms.NumericUpDown();
            this.randNum = new System.Windows.Forms.Label();
            this.tbRand = new System.Windows.Forms.TextBox();
            this.cbNoRepeat = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.tabConrol1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.randMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randMax)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(109, 22);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(149, 22);
            this.tsmiAbout.Text = "О программе";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tabConrol1
            // 
            this.tabConrol1.Controls.Add(this.tabPage1);
            this.tabConrol1.Controls.Add(this.tabPage2);
            this.tabConrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabConrol1.Location = new System.Drawing.Point(0, 24);
            this.tabConrol1.Name = "tabConrol1";
            this.tabConrol1.SelectedIndex = 0;
            this.tabConrol1.Size = new System.Drawing.Size(800, 426);
            this.tabConrol1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelNum);
            this.tabPage1.Controls.Add(this.buttonReset);
            this.tabPage1.Controls.Add(this.buttonMinus);
            this.tabPage1.Controls.Add(this.buttonPlus);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Счётчик";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNum.Location = new System.Drawing.Point(307, 156);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(21, 24);
            this.labelNum.TabIndex = 3;
            this.labelNum.Text = "0";
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReset.Location = new System.Drawing.Point(407, 146);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(105, 45);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinus.Location = new System.Drawing.Point(265, 213);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(105, 45);
            this.buttonMinus.TabIndex = 1;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.Location = new System.Drawing.Point(265, 85);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(105, 45);
            this.buttonPlus.TabIndex = 0;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbNoRepeat);
            this.tabPage2.Controls.Add(this.tbRand);
            this.tabPage2.Controls.Add(this.randNum);
            this.tabPage2.Controls.Add(this.randMax);
            this.tabPage2.Controls.Add(this.randMin);
            this.tabPage2.Controls.Add(this.buttonCopy);
            this.tabPage2.Controls.Add(this.buttonClear);
            this.tabPage2.Controls.Add(this.buttonRand);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Рандомайзер";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "От";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "До";
            // 
            // buttonRand
            // 
            this.buttonRand.Location = new System.Drawing.Point(295, 48);
            this.buttonRand.Name = "buttonRand";
            this.buttonRand.Size = new System.Drawing.Size(84, 23);
            this.buttonRand.TabIndex = 2;
            this.buttonRand.Text = "Зарандомить";
            this.buttonRand.UseVisualStyleBackColor = true;
            this.buttonRand.Click += new System.EventHandler(this.buttonRand_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(97, 173);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(97, 220);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy.TabIndex = 4;
            this.buttonCopy.Text = "Копировать";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // randMin
            // 
            this.randMin.Location = new System.Drawing.Point(97, 48);
            this.randMin.Name = "randMin";
            this.randMin.Size = new System.Drawing.Size(120, 20);
            this.randMin.TabIndex = 5;
            // 
            // randMax
            // 
            this.randMax.Location = new System.Drawing.Point(97, 97);
            this.randMax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.randMax.Name = "randMax";
            this.randMax.Size = new System.Drawing.Size(120, 20);
            this.randMax.TabIndex = 6;
            this.randMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // randNum
            // 
            this.randNum.AutoSize = true;
            this.randNum.Location = new System.Drawing.Point(292, 104);
            this.randNum.Name = "randNum";
            this.randNum.Size = new System.Drawing.Size(0, 13);
            this.randNum.TabIndex = 7;
            // 
            // tbRand
            // 
            this.tbRand.BackColor = System.Drawing.SystemColors.Window;
            this.tbRand.Location = new System.Drawing.Point(295, 168);
            this.tbRand.Multiline = true;
            this.tbRand.Name = "tbRand";
            this.tbRand.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRand.Size = new System.Drawing.Size(150, 160);
            this.tbRand.TabIndex = 8;
            // 
            // cbNoRepeat
            // 
            this.cbNoRepeat.AutoSize = true;
            this.cbNoRepeat.Location = new System.Drawing.Point(97, 260);
            this.cbNoRepeat.Name = "cbNoRepeat";
            this.cbNoRepeat.Size = new System.Drawing.Size(106, 17);
            this.cbNoRepeat.TabIndex = 9;
            this.cbNoRepeat.Text = "без повторений";
            this.cbNoRepeat.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabConrol1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Mini apps";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabConrol1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.randMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.TabControl tabConrol1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label randNum;
        private System.Windows.Forms.NumericUpDown randMax;
        private System.Windows.Forms.NumericUpDown randMin;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRand;
        private System.Windows.Forms.CheckBox cbNoRepeat;
    }
}