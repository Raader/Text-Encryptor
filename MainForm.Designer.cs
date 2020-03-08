namespace Text_Encryptor
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.languageBox = new System.Windows.Forms.ComboBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.deCryptButton = new System.Windows.Forms.Button();
            this.enCryptButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.fixtermLabel = new System.Windows.Forms.Label();
            this.fixTermInput = new System.Windows.Forms.NumericUpDown();
            this.factorLabel = new System.Windows.Forms.Label();
            this.factorInput = new System.Windows.Forms.NumericUpDown();
            this.funcLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fixTermInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factorInput)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mainPanel.Controls.Add(this.button1);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.languageBox);
            this.mainPanel.Controls.Add(this.copyButton);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.resetButton);
            this.mainPanel.Controls.Add(this.deCryptButton);
            this.mainPanel.Controls.Add(this.enCryptButton);
            this.mainPanel.Controls.Add(this.outputLabel);
            this.mainPanel.Controls.Add(this.inputBox);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(597, 534);
            this.mainPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(427, 245);
            this.button1.Margin = new System.Windows.Forms.Padding(20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "Yapıştır";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dil";
            // 
            // languageBox
            // 
            this.languageBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageBox.FormattingEnabled = true;
            this.languageBox.Items.AddRange(new object[] {
            "Türkçe",
            "İngilizce"});
            this.languageBox.Location = new System.Drawing.Point(20, 493);
            this.languageBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.languageBox.Name = "languageBox";
            this.languageBox.Size = new System.Drawing.Size(150, 21);
            this.languageBox.TabIndex = 8;
            // 
            // copyButton
            // 
            this.copyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.copyButton.Location = new System.Drawing.Point(427, 178);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(150, 44);
            this.copyButton.TabIndex = 7;
            this.copyButton.Text = "Kopyala";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(329, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Çıktı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Girdi";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.DarkGray;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resetButton.Location = new System.Drawing.Point(20, 310);
            this.resetButton.Margin = new System.Windows.Forms.Padding(20);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(150, 44);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Temizle";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // deCryptButton
            // 
            this.deCryptButton.BackColor = System.Drawing.Color.Silver;
            this.deCryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deCryptButton.Location = new System.Drawing.Point(20, 245);
            this.deCryptButton.Margin = new System.Windows.Forms.Padding(20);
            this.deCryptButton.Name = "deCryptButton";
            this.deCryptButton.Size = new System.Drawing.Size(150, 44);
            this.deCryptButton.TabIndex = 3;
            this.deCryptButton.Text = "Çöz";
            this.deCryptButton.UseVisualStyleBackColor = false;
            this.deCryptButton.Click += new System.EventHandler(this.deCryptButton_Click);
            // 
            // enCryptButton
            // 
            this.enCryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.enCryptButton.Location = new System.Drawing.Point(20, 178);
            this.enCryptButton.Name = "enCryptButton";
            this.enCryptButton.Size = new System.Drawing.Size(150, 44);
            this.enCryptButton.TabIndex = 2;
            this.enCryptButton.Text = "Şifrele";
            this.enCryptButton.UseVisualStyleBackColor = true;
            this.enCryptButton.Click += new System.EventHandler(this.enCryptButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.SystemColors.Window;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.outputLabel.Location = new System.Drawing.Point(329, 71);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(20);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(248, 38);
            this.outputLabel.TabIndex = 1;
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.inputBox.Location = new System.Drawing.Point(20, 71);
            this.inputBox.Margin = new System.Windows.Forms.Padding(20);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(248, 38);
            this.inputBox.TabIndex = 0;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sidePanel.Controls.Add(this.label4);
            this.sidePanel.Controls.Add(this.clearButton);
            this.sidePanel.Controls.Add(this.applyButton);
            this.sidePanel.Controls.Add(this.fixtermLabel);
            this.sidePanel.Controls.Add(this.fixTermInput);
            this.sidePanel.Controls.Add(this.factorLabel);
            this.sidePanel.Controls.Add(this.factorInput);
            this.sidePanel.Controls.Add(this.funcLabel);
            this.sidePanel.Location = new System.Drawing.Point(615, 12);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(272, 534);
            this.sidePanel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(20, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fonksiyon";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clearButton.Location = new System.Drawing.Point(26, 290);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(126, 28);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Temizle";
            this.clearButton.UseVisualStyleBackColor = false;
            // 
            // applyButton
            // 
            this.applyButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.applyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.applyButton.Location = new System.Drawing.Point(26, 229);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(126, 28);
            this.applyButton.TabIndex = 5;
            this.applyButton.Text = "Uygula";
            this.applyButton.UseVisualStyleBackColor = false;
            // 
            // fixtermLabel
            // 
            this.fixtermLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.fixtermLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fixtermLabel.Location = new System.Drawing.Point(26, 178);
            this.fixtermLabel.Margin = new System.Windows.Forms.Padding(20, 50, 20, 50);
            this.fixtermLabel.Name = "fixtermLabel";
            this.fixtermLabel.Size = new System.Drawing.Size(126, 20);
            this.fixtermLabel.TabIndex = 4;
            this.fixtermLabel.Text = "Sabit Terim";
            this.fixtermLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fixTermInput
            // 
            this.fixTermInput.Location = new System.Drawing.Point(175, 178);
            this.fixTermInput.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.fixTermInput.Minimum = new decimal(new int[] {
            99,
            0,
            0,
            -2147483648});
            this.fixTermInput.Name = "fixTermInput";
            this.fixTermInput.Size = new System.Drawing.Size(77, 20);
            this.fixTermInput.TabIndex = 3;
            // 
            // factorLabel
            // 
            this.factorLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.factorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.factorLabel.Location = new System.Drawing.Point(26, 137);
            this.factorLabel.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.factorLabel.Name = "factorLabel";
            this.factorLabel.Size = new System.Drawing.Size(126, 20);
            this.factorLabel.TabIndex = 2;
            this.factorLabel.Text = "Katsayı";
            this.factorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // factorInput
            // 
            this.factorInput.Location = new System.Drawing.Point(175, 137);
            this.factorInput.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.factorInput.Minimum = new decimal(new int[] {
            99,
            0,
            0,
            -2147483648});
            this.factorInput.Name = "factorInput";
            this.factorInput.Size = new System.Drawing.Size(77, 20);
            this.factorInput.TabIndex = 1;
            // 
            // funcLabel
            // 
            this.funcLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.funcLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.funcLabel.Location = new System.Drawing.Point(20, 72);
            this.funcLabel.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.funcLabel.Name = "funcLabel";
            this.funcLabel.Size = new System.Drawing.Size(232, 37);
            this.funcLabel.TabIndex = 0;
            this.funcLabel.Text = "f(x) = ax + b";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(899, 558);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.mainPanel);
            this.Name = "MainForm";
            this.Text = "Şifreleyici";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fixTermInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factorInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label fixtermLabel;
        private System.Windows.Forms.NumericUpDown fixTermInput;
        private System.Windows.Forms.Label factorLabel;
        private System.Windows.Forms.NumericUpDown factorInput;
        private System.Windows.Forms.Label funcLabel;
        private System.Windows.Forms.Button deCryptButton;
        private System.Windows.Forms.Button enCryptButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.ComboBox languageBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}

