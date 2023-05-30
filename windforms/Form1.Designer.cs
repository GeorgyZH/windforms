namespace windforms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.GenPsw = new System.Windows.Forms.TabPage();
            this.tbRndPsw = new System.Windows.Forms.TextBox();
            this.chBxSymbols = new System.Windows.Forms.CheckBox();
            this.chBxNumber = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdBt24 = new System.Windows.Forms.RadioButton();
            this.rdbt16 = new System.Windows.Forms.RadioButton();
            this.rdBt8 = new System.Windows.Forms.RadioButton();
            this.btnCp = new System.Windows.Forms.Button();
            this.btnCrt = new System.Windows.Forms.Button();
            this.tcmiNtpd = new System.Windows.Forms.TabPage();
            this.rchTB = new System.Windows.Forms.RichTextBox();
            this.random = new System.Windows.Forms.TabPage();
            this.chRnd = new System.Windows.Forms.CheckBox();
            this.btRndCp = new System.Windows.Forms.Button();
            this.btnRndClr = new System.Windows.Forms.Button();
            this.tbRnd = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.NumericUpDown();
            this.num1 = new System.Windows.Forms.NumericUpDown();
            this.lblrandom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnrandom = new System.Windows.Forms.Button();
            this.Count = new System.Windows.Forms.TabPage();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnCount0 = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.GenPsw.SuspendLayout();
            this.tcmiNtpd.SuspendLayout();
            this.random.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            this.Count.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutProgramToolStripMenuItem,
            this.notepadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(353, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit,
            this.dateToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(93, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(90, 6);
            this.dateToolStripMenuItem.Click += new System.EventHandler(this.dateToolStripMenuItem_Click);
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.aboutProgramToolStripMenuItem.Text = "about program";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(127, 22);
            this.tsmiAbout.Text = "gay check";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateToolStripMenuItem1,
            this.timeToolStripMenuItem1,
            this.saveToolStripMenuItem});
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.notepadToolStripMenuItem.Text = "Notepad";
            // 
            // dateToolStripMenuItem1
            // 
            this.dateToolStripMenuItem1.Name = "dateToolStripMenuItem1";
            this.dateToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.dateToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.dateToolStripMenuItem1.Text = "Date";
            this.dateToolStripMenuItem1.Click += new System.EventHandler(this.dateToolStripMenuItem1_Click_1);
            // 
            // timeToolStripMenuItem1
            // 
            this.timeToolStripMenuItem1.Name = "timeToolStripMenuItem1";
            this.timeToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.timeToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.timeToolStripMenuItem1.Text = "Time";
            this.timeToolStripMenuItem1.Click += new System.EventHandler(this.timeToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.GenPsw);
            this.tabControl1.Controls.Add(this.tcmiNtpd);
            this.tabControl1.Controls.Add(this.random);
            this.tabControl1.Controls.Add(this.Count);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(353, 141);
            this.tabControl1.TabIndex = 1;
            // 
            // GenPsw
            // 
            this.GenPsw.Controls.Add(this.tbRndPsw);
            this.GenPsw.Controls.Add(this.chBxSymbols);
            this.GenPsw.Controls.Add(this.chBxNumber);
            this.GenPsw.Controls.Add(this.label4);
            this.GenPsw.Controls.Add(this.rdBt24);
            this.GenPsw.Controls.Add(this.rdbt16);
            this.GenPsw.Controls.Add(this.rdBt8);
            this.GenPsw.Controls.Add(this.btnCp);
            this.GenPsw.Controls.Add(this.btnCrt);
            this.GenPsw.Location = new System.Drawing.Point(4, 22);
            this.GenPsw.Name = "GenPsw";
            this.GenPsw.Size = new System.Drawing.Size(345, 115);
            this.GenPsw.TabIndex = 3;
            this.GenPsw.Text = "Пароль";
            this.GenPsw.UseVisualStyleBackColor = true;
            // 
            // tbRndPsw
            // 
            this.tbRndPsw.Location = new System.Drawing.Point(8, 87);
            this.tbRndPsw.Name = "tbRndPsw";
            this.tbRndPsw.ReadOnly = true;
            this.tbRndPsw.Size = new System.Drawing.Size(240, 20);
            this.tbRndPsw.TabIndex = 9;
            // 
            // chBxSymbols
            // 
            this.chBxSymbols.AutoSize = true;
            this.chBxSymbols.Location = new System.Drawing.Point(145, 65);
            this.chBxSymbols.Name = "chBxSymbols";
            this.chBxSymbols.Size = new System.Drawing.Size(103, 17);
            this.chBxSymbols.TabIndex = 8;
            this.chBxSymbols.Text = "Спец. символы";
            this.chBxSymbols.UseVisualStyleBackColor = true;
            // 
            // chBxNumber
            // 
            this.chBxNumber.AutoSize = true;
            this.chBxNumber.Location = new System.Drawing.Point(145, 41);
            this.chBxNumber.Name = "chBxNumber";
            this.chBxNumber.Size = new System.Drawing.Size(62, 17);
            this.chBxNumber.TabIndex = 7;
            this.chBxNumber.Text = "Цифры";
            this.chBxNumber.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(142, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Количество символов в пароле:";
            // 
            // rdBt24
            // 
            this.rdBt24.AutoSize = true;
            this.rdBt24.Location = new System.Drawing.Point(256, 71);
            this.rdBt24.Name = "rdBt24";
            this.rdBt24.Size = new System.Drawing.Size(37, 17);
            this.rdBt24.TabIndex = 5;
            this.rdBt24.TabStop = true;
            this.rdBt24.Text = "24";
            this.rdBt24.UseVisualStyleBackColor = true;
            // 
            // rdbt16
            // 
            this.rdbt16.AutoSize = true;
            this.rdbt16.Location = new System.Drawing.Point(256, 47);
            this.rdbt16.Name = "rdbt16";
            this.rdbt16.Size = new System.Drawing.Size(37, 17);
            this.rdbt16.TabIndex = 4;
            this.rdbt16.TabStop = true;
            this.rdbt16.Text = "16";
            this.rdbt16.UseVisualStyleBackColor = true;
            // 
            // rdBt8
            // 
            this.rdBt8.AutoSize = true;
            this.rdBt8.Location = new System.Drawing.Point(256, 21);
            this.rdBt8.Name = "rdBt8";
            this.rdBt8.Size = new System.Drawing.Size(31, 17);
            this.rdBt8.TabIndex = 3;
            this.rdBt8.TabStop = true;
            this.rdBt8.Text = "8";
            this.rdBt8.UseVisualStyleBackColor = true;
            // 
            // btnCp
            // 
            this.btnCp.Location = new System.Drawing.Point(8, 41);
            this.btnCp.Name = "btnCp";
            this.btnCp.Size = new System.Drawing.Size(75, 23);
            this.btnCp.TabIndex = 2;
            this.btnCp.Text = "Копировать";
            this.btnCp.UseVisualStyleBackColor = true;
            this.btnCp.Click += new System.EventHandler(this.btnCp_Click);
            // 
            // btnCrt
            // 
            this.btnCrt.Location = new System.Drawing.Point(8, 15);
            this.btnCrt.Name = "btnCrt";
            this.btnCrt.Size = new System.Drawing.Size(75, 23);
            this.btnCrt.TabIndex = 0;
            this.btnCrt.Text = "Создать";
            this.btnCrt.UseVisualStyleBackColor = true;
            this.btnCrt.Click += new System.EventHandler(this.btnCrt_Click);
            // 
            // tcmiNtpd
            // 
            this.tcmiNtpd.Controls.Add(this.rchTB);
            this.tcmiNtpd.Location = new System.Drawing.Point(4, 22);
            this.tcmiNtpd.Name = "tcmiNtpd";
            this.tcmiNtpd.Padding = new System.Windows.Forms.Padding(3);
            this.tcmiNtpd.Size = new System.Drawing.Size(345, 115);
            this.tcmiNtpd.TabIndex = 2;
            this.tcmiNtpd.Text = "Блокнот";
            this.tcmiNtpd.UseVisualStyleBackColor = true;
            // 
            // rchTB
            // 
            this.rchTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchTB.Location = new System.Drawing.Point(3, 3);
            this.rchTB.Name = "rchTB";
            this.rchTB.Size = new System.Drawing.Size(339, 109);
            this.rchTB.TabIndex = 0;
            this.rchTB.Text = "";
            // 
            // random
            // 
            this.random.Controls.Add(this.chRnd);
            this.random.Controls.Add(this.btRndCp);
            this.random.Controls.Add(this.btnRndClr);
            this.random.Controls.Add(this.tbRnd);
            this.random.Controls.Add(this.num2);
            this.random.Controls.Add(this.num1);
            this.random.Controls.Add(this.lblrandom);
            this.random.Controls.Add(this.label2);
            this.random.Controls.Add(this.label1);
            this.random.Controls.Add(this.btnrandom);
            this.random.Location = new System.Drawing.Point(4, 22);
            this.random.Name = "random";
            this.random.Padding = new System.Windows.Forms.Padding(3);
            this.random.Size = new System.Drawing.Size(345, 115);
            this.random.TabIndex = 1;
            this.random.Text = "Генератор";
            this.random.UseVisualStyleBackColor = true;
            this.random.Click += new System.EventHandler(this.random_Click);
            // 
            // chRnd
            // 
            this.chRnd.AutoSize = true;
            this.chRnd.Location = new System.Drawing.Point(114, 93);
            this.chRnd.Name = "chRnd";
            this.chRnd.Size = new System.Drawing.Size(107, 17);
            this.chRnd.TabIndex = 9;
            this.chRnd.Text = "Без повторений";
            this.chRnd.UseVisualStyleBackColor = true;
            // 
            // btRndCp
            // 
            this.btRndCp.Location = new System.Drawing.Point(114, 63);
            this.btRndCp.Name = "btRndCp";
            this.btRndCp.Size = new System.Drawing.Size(75, 23);
            this.btRndCp.TabIndex = 8;
            this.btRndCp.Text = "Копировать";
            this.btRndCp.UseVisualStyleBackColor = true;
            this.btRndCp.Click += new System.EventHandler(this.btRndCp_Click);
            // 
            // btnRndClr
            // 
            this.btnRndClr.Location = new System.Drawing.Point(114, 33);
            this.btnRndClr.Name = "btnRndClr";
            this.btnRndClr.Size = new System.Drawing.Size(75, 23);
            this.btnRndClr.TabIndex = 7;
            this.btnRndClr.Text = "Очистить";
            this.btnRndClr.UseVisualStyleBackColor = true;
            this.btnRndClr.Click += new System.EventHandler(this.btnRndClr_Click);
            // 
            // tbRnd
            // 
            this.tbRnd.Location = new System.Drawing.Point(238, 6);
            this.tbRnd.Multiline = true;
            this.tbRnd.Name = "tbRnd";
            this.tbRnd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRnd.Size = new System.Drawing.Size(105, 106);
            this.tbRnd.TabIndex = 6;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(33, 31);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(52, 20);
            this.num2.TabIndex = 5;
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(32, 3);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(53, 20);
            this.num1.TabIndex = 4;
            // 
            // lblrandom
            // 
            this.lblrandom.AutoSize = true;
            this.lblrandom.Location = new System.Drawing.Point(29, 63);
            this.lblrandom.Name = "lblrandom";
            this.lblrandom.Size = new System.Drawing.Size(13, 13);
            this.lblrandom.TabIndex = 3;
            this.lblrandom.Text = "0";
            this.lblrandom.Click += new System.EventHandler(this.lblrandom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "до";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "от";
            // 
            // btnrandom
            // 
            this.btnrandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnrandom.Location = new System.Drawing.Point(114, 3);
            this.btnrandom.Name = "btnrandom";
            this.btnrandom.Size = new System.Drawing.Size(98, 23);
            this.btnrandom.TabIndex = 0;
            this.btnrandom.Text = "Создать";
            this.btnrandom.UseVisualStyleBackColor = true;
            this.btnrandom.Click += new System.EventHandler(this.btnrandom_Click);
            // 
            // Count
            // 
            this.Count.Controls.Add(this.lblCount);
            this.Count.Controls.Add(this.btnCount0);
            this.Count.Controls.Add(this.btnMin);
            this.Count.Controls.Add(this.btnPlus);
            this.Count.Location = new System.Drawing.Point(4, 22);
            this.Count.Name = "Count";
            this.Count.Padding = new System.Windows.Forms.Padding(3);
            this.Count.Size = new System.Drawing.Size(345, 115);
            this.Count.TabIndex = 0;
            this.Count.Text = "Счетчик";
            this.Count.UseVisualStyleBackColor = true;
            this.Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(48, 45);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(13, 13);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "0";
            this.lblCount.Click += new System.EventHandler(this.lblCount_Click);
            // 
            // btnCount0
            // 
            this.btnCount0.Location = new System.Drawing.Point(108, 40);
            this.btnCount0.Name = "btnCount0";
            this.btnCount0.Size = new System.Drawing.Size(75, 23);
            this.btnCount0.TabIndex = 2;
            this.btnCount0.Text = "Сброс";
            this.btnCount0.UseVisualStyleBackColor = true;
            this.btnCount0.Click += new System.EventHandler(this.btnCount0_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(8, 85);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(75, 23);
            this.btnMin.TabIndex = 1;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(8, 6);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 165);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Whatever";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.GenPsw.ResumeLayout(false);
            this.GenPsw.PerformLayout();
            this.tcmiNtpd.ResumeLayout(false);
            this.random.ResumeLayout(false);
            this.random.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            this.Count.ResumeLayout(false);
            this.Count.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Count;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnCount0;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.TabPage random;
        private System.Windows.Forms.NumericUpDown num2;
        private System.Windows.Forms.NumericUpDown num1;
        private System.Windows.Forms.Label lblrandom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnrandom;
        private System.Windows.Forms.TextBox tbRnd;
        private System.Windows.Forms.Button btRndCp;
        private System.Windows.Forms.Button btnRndClr;
        private System.Windows.Forms.CheckBox chRnd;
        private System.Windows.Forms.TabPage tcmiNtpd;
        private System.Windows.Forms.RichTextBox rchTB;
        private System.Windows.Forms.ToolStripSeparator dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem timeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TabPage GenPsw;
        private System.Windows.Forms.RadioButton rdBt24;
        private System.Windows.Forms.RadioButton rdbt16;
        private System.Windows.Forms.RadioButton rdBt8;
        private System.Windows.Forms.Button btnCp;
        private System.Windows.Forms.Button btnCrt;
        private System.Windows.Forms.CheckBox chBxSymbols;
        private System.Windows.Forms.CheckBox chBxNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRndPsw;
    }
}

