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
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTime = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabConrol1 = new System.Windows.Forms.TabControl();
            this.tpCounter = new System.Windows.Forms.TabPage();
            this.labelNum = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.tpRandomizer = new System.Windows.Forms.TabPage();
            this.cbNoRepeat = new System.Windows.Forms.CheckBox();
            this.tbRand = new System.Windows.Forms.TextBox();
            this.randNum = new System.Windows.Forms.Label();
            this.randMax = new System.Windows.Forms.NumericUpDown();
            this.randMin = new System.Windows.Forms.NumericUpDown();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonRand = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpNotepad = new System.Windows.Forms.TabPage();
            this.rtbNotepad = new System.Windows.Forms.RichTextBox();
            this.passwordGen = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordLength = new System.Windows.Forms.NumericUpDown();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.buttonGen = new System.Windows.Forms.Button();
            this.clbParam = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1.SuspendLayout();
            this.tabConrol1.SuspendLayout();
            this.tpCounter.SuspendLayout();
            this.tpRandomizer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.randMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randMin)).BeginInit();
            this.tpNotepad.SuspendLayout();
            this.passwordGen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.вставитьToolStripMenuItem,
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
            this.tsmiSave,
            this.tsmiLoad,
            this.toolStripMenuItem1,
            this.tsmiExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSave.Size = new System.Drawing.Size(173, 22);
            this.tsmiSave.Text = "Сохранить";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiLoad
            // 
            this.tsmiLoad.Name = "tsmiLoad";
            this.tsmiLoad.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.tsmiLoad.Size = new System.Drawing.Size(173, 22);
            this.tsmiLoad.Text = "Загрузить";
            this.tsmiLoad.Click += new System.EventHandler(this.tsmiLoad_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(170, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(173, 22);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDate,
            this.tsmiTime});
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            // 
            // tsmiDate
            // 
            this.tsmiDate.Name = "tsmiDate";
            this.tsmiDate.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.tsmiDate.Size = new System.Drawing.Size(181, 22);
            this.tsmiDate.Text = "Дата";
            this.tsmiDate.Click += new System.EventHandler(this.tsmiDate_Click);
            // 
            // tsmiTime
            // 
            this.tsmiTime.Name = "tsmiTime";
            this.tsmiTime.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.tsmiTime.Size = new System.Drawing.Size(181, 22);
            this.tsmiTime.Text = "Время";
            this.tsmiTime.Click += new System.EventHandler(this.tsmiTime_Click);
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
            this.tabConrol1.Controls.Add(this.tpCounter);
            this.tabConrol1.Controls.Add(this.tpRandomizer);
            this.tabConrol1.Controls.Add(this.tpNotepad);
            this.tabConrol1.Controls.Add(this.passwordGen);
            this.tabConrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabConrol1.Location = new System.Drawing.Point(0, 24);
            this.tabConrol1.Name = "tabConrol1";
            this.tabConrol1.SelectedIndex = 0;
            this.tabConrol1.Size = new System.Drawing.Size(800, 426);
            this.tabConrol1.TabIndex = 1;
            // 
            // tpCounter
            // 
            this.tpCounter.Controls.Add(this.labelNum);
            this.tpCounter.Controls.Add(this.buttonReset);
            this.tpCounter.Controls.Add(this.buttonMinus);
            this.tpCounter.Controls.Add(this.buttonPlus);
            this.tpCounter.Location = new System.Drawing.Point(4, 22);
            this.tpCounter.Name = "tpCounter";
            this.tpCounter.Padding = new System.Windows.Forms.Padding(3);
            this.tpCounter.Size = new System.Drawing.Size(792, 400);
            this.tpCounter.TabIndex = 0;
            this.tpCounter.Text = "Счётчик";
            this.tpCounter.UseVisualStyleBackColor = true;
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
            // tpRandomizer
            // 
            this.tpRandomizer.Controls.Add(this.cbNoRepeat);
            this.tpRandomizer.Controls.Add(this.tbRand);
            this.tpRandomizer.Controls.Add(this.randNum);
            this.tpRandomizer.Controls.Add(this.randMax);
            this.tpRandomizer.Controls.Add(this.randMin);
            this.tpRandomizer.Controls.Add(this.buttonCopy);
            this.tpRandomizer.Controls.Add(this.buttonClear);
            this.tpRandomizer.Controls.Add(this.buttonRand);
            this.tpRandomizer.Controls.Add(this.label2);
            this.tpRandomizer.Controls.Add(this.label1);
            this.tpRandomizer.Location = new System.Drawing.Point(4, 22);
            this.tpRandomizer.Name = "tpRandomizer";
            this.tpRandomizer.Padding = new System.Windows.Forms.Padding(3);
            this.tpRandomizer.Size = new System.Drawing.Size(792, 400);
            this.tpRandomizer.TabIndex = 1;
            this.tpRandomizer.Text = "Рандомайзер";
            this.tpRandomizer.UseVisualStyleBackColor = true;
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
            // randNum
            // 
            this.randNum.AutoSize = true;
            this.randNum.Location = new System.Drawing.Point(292, 104);
            this.randNum.Name = "randNum";
            this.randNum.Size = new System.Drawing.Size(0, 13);
            this.randNum.TabIndex = 7;
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
            // randMin
            // 
            this.randMin.Location = new System.Drawing.Point(97, 48);
            this.randMin.Name = "randMin";
            this.randMin.Size = new System.Drawing.Size(120, 20);
            this.randMin.TabIndex = 5;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "До";
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
            // tpNotepad
            // 
            this.tpNotepad.Controls.Add(this.rtbNotepad);
            this.tpNotepad.Location = new System.Drawing.Point(4, 22);
            this.tpNotepad.Name = "tpNotepad";
            this.tpNotepad.Size = new System.Drawing.Size(792, 400);
            this.tpNotepad.TabIndex = 2;
            this.tpNotepad.Text = "Блокнот";
            this.tpNotepad.UseVisualStyleBackColor = true;
            // 
            // rtbNotepad
            // 
            this.rtbNotepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNotepad.Location = new System.Drawing.Point(0, 0);
            this.rtbNotepad.Name = "rtbNotepad";
            this.rtbNotepad.Size = new System.Drawing.Size(792, 400);
            this.rtbNotepad.TabIndex = 0;
            this.rtbNotepad.Text = "";
            // 
            // passwordGen
            // 
            this.passwordGen.Controls.Add(this.label3);
            this.passwordGen.Controls.Add(this.passwordLength);
            this.passwordGen.Controls.Add(this.tbPassword);
            this.passwordGen.Controls.Add(this.buttonGen);
            this.passwordGen.Controls.Add(this.clbParam);
            this.passwordGen.Location = new System.Drawing.Point(4, 22);
            this.passwordGen.Name = "passwordGen";
            this.passwordGen.Size = new System.Drawing.Size(792, 400);
            this.passwordGen.TabIndex = 3;
            this.passwordGen.Text = "Генератор паролей";
            this.passwordGen.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Длина пароля";
            // 
            // passwordLength
            // 
            this.passwordLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLength.Location = new System.Drawing.Point(128, 130);
            this.passwordLength.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.passwordLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.passwordLength.Name = "passwordLength";
            this.passwordLength.Size = new System.Drawing.Size(60, 20);
            this.passwordLength.TabIndex = 3;
            this.passwordLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(26, 210);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(219, 20);
            this.tbPassword.TabIndex = 2;
            // 
            // buttonGen
            // 
            this.buttonGen.Location = new System.Drawing.Point(26, 165);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(219, 23);
            this.buttonGen.TabIndex = 1;
            this.buttonGen.Text = "Генерировать пароль";
            this.buttonGen.UseVisualStyleBackColor = true;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // clbParam
            // 
            this.clbParam.CheckOnClick = true;
            this.clbParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clbParam.FormattingEnabled = true;
            this.clbParam.Items.AddRange(new object[] {
            "Строчные буквы",
            "Прописные буквы",
            "Цифры",
            "Спец. символы (@, $, &, ^, %, *)"});
            this.clbParam.Location = new System.Drawing.Point(26, 24);
            this.clbParam.Name = "clbParam";
            this.clbParam.Size = new System.Drawing.Size(219, 89);
            this.clbParam.TabIndex = 0;
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
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabConrol1.ResumeLayout(false);
            this.tpCounter.ResumeLayout(false);
            this.tpCounter.PerformLayout();
            this.tpRandomizer.ResumeLayout(false);
            this.tpRandomizer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.randMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randMin)).EndInit();
            this.tpNotepad.ResumeLayout(false);
            this.passwordGen.ResumeLayout(false);
            this.passwordGen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLength)).EndInit();
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
        private System.Windows.Forms.TabPage tpCounter;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.TabPage tpRandomizer;
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
        private System.Windows.Forms.TabPage tpNotepad;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoad;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDate;
        private System.Windows.Forms.ToolStripMenuItem tsmiTime;
        private System.Windows.Forms.RichTextBox rtbNotepad;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.TabPage passwordGen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown passwordLength;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.CheckedListBox clbParam;
    }
}