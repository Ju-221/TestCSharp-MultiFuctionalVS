namespace Project420JuanVargasP25
{
    partial class FrmExchange
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gpbFrom1 = new System.Windows.Forms.GroupBox();
            this.rdbGBP1 = new System.Windows.Forms.RadioButton();
            this.rdbEUR1 = new System.Windows.Forms.RadioButton();
            this.rdbUSD1 = new System.Windows.Forms.RadioButton();
            this.rdbCAN1 = new System.Windows.Forms.RadioButton();
            this.gpbTo = new System.Windows.Forms.GroupBox();
            this.rdbGBP2 = new System.Windows.Forms.RadioButton();
            this.rdbEUR2 = new System.Windows.Forms.RadioButton();
            this.rdbUSD2 = new System.Windows.Forms.RadioButton();
            this.rdbCAN2 = new System.Windows.Forms.RadioButton();
            this.gpbFrom1.SuspendLayout();
            this.gpbTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(24, 266);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(125, 34);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "&Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(155, 266);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(125, 34);
            this.btnReadFile.TabIndex = 9;
            this.btnReadFile.Text = "&Read File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(286, 266);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 34);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 220);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 26);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(226, 220);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(185, 26);
            this.textBox2.TabIndex = 12;
            // 
            // gpbFrom1
            // 
            this.gpbFrom1.Controls.Add(this.rdbGBP1);
            this.gpbFrom1.Controls.Add(this.rdbEUR1);
            this.gpbFrom1.Controls.Add(this.rdbUSD1);
            this.gpbFrom1.Controls.Add(this.rdbCAN1);
            this.gpbFrom1.Location = new System.Drawing.Point(24, 12);
            this.gpbFrom1.Name = "gpbFrom1";
            this.gpbFrom1.Size = new System.Drawing.Size(178, 185);
            this.gpbFrom1.TabIndex = 0;
            this.gpbFrom1.TabStop = false;
            this.gpbFrom1.Text = "From";
            // 
            // rdbGBP1
            // 
            this.rdbGBP1.AutoSize = true;
            this.rdbGBP1.Location = new System.Drawing.Point(32, 150);
            this.rdbGBP1.Name = "rdbGBP1";
            this.rdbGBP1.Size = new System.Drawing.Size(68, 24);
            this.rdbGBP1.TabIndex = 3;
            this.rdbGBP1.TabStop = true;
            this.rdbGBP1.Tag = "4";
            this.rdbGBP1.Text = "GBP";
            this.rdbGBP1.UseVisualStyleBackColor = true;
            // 
            // rdbEUR1
            // 
            this.rdbEUR1.AutoSize = true;
            this.rdbEUR1.Location = new System.Drawing.Point(32, 120);
            this.rdbEUR1.Name = "rdbEUR1";
            this.rdbEUR1.Size = new System.Drawing.Size(69, 24);
            this.rdbEUR1.TabIndex = 2;
            this.rdbEUR1.TabStop = true;
            this.rdbEUR1.Tag = "3";
            this.rdbEUR1.Text = "EUR";
            this.rdbEUR1.UseVisualStyleBackColor = true;
            // 
            // rdbUSD1
            // 
            this.rdbUSD1.AutoSize = true;
            this.rdbUSD1.Location = new System.Drawing.Point(32, 90);
            this.rdbUSD1.Name = "rdbUSD1";
            this.rdbUSD1.Size = new System.Drawing.Size(69, 24);
            this.rdbUSD1.TabIndex = 1;
            this.rdbUSD1.TabStop = true;
            this.rdbUSD1.Tag = "2";
            this.rdbUSD1.Text = "USD";
            this.rdbUSD1.UseVisualStyleBackColor = true;
            // 
            // rdbCAN1
            // 
            this.rdbCAN1.AutoSize = true;
            this.rdbCAN1.Location = new System.Drawing.Point(32, 60);
            this.rdbCAN1.Name = "rdbCAN1";
            this.rdbCAN1.Size = new System.Drawing.Size(67, 24);
            this.rdbCAN1.TabIndex = 0;
            this.rdbCAN1.TabStop = true;
            this.rdbCAN1.Tag = "1";
            this.rdbCAN1.Text = "CAN";
            this.rdbCAN1.UseVisualStyleBackColor = true;
            // 
            // gpbTo
            // 
            this.gpbTo.Controls.Add(this.rdbGBP2);
            this.gpbTo.Controls.Add(this.rdbEUR2);
            this.gpbTo.Controls.Add(this.rdbUSD2);
            this.gpbTo.Controls.Add(this.rdbCAN2);
            this.gpbTo.Location = new System.Drawing.Point(226, 12);
            this.gpbTo.Name = "gpbTo";
            this.gpbTo.Size = new System.Drawing.Size(178, 185);
            this.gpbTo.TabIndex = 4;
            this.gpbTo.TabStop = false;
            this.gpbTo.Text = "To";
            // 
            // rdbGBP2
            // 
            this.rdbGBP2.AutoSize = true;
            this.rdbGBP2.Location = new System.Drawing.Point(32, 150);
            this.rdbGBP2.Name = "rdbGBP2";
            this.rdbGBP2.Size = new System.Drawing.Size(68, 24);
            this.rdbGBP2.TabIndex = 3;
            this.rdbGBP2.TabStop = true;
            this.rdbGBP2.Tag = "8";
            this.rdbGBP2.Text = "GBP";
            this.rdbGBP2.UseVisualStyleBackColor = true;
            // 
            // rdbEUR2
            // 
            this.rdbEUR2.AutoSize = true;
            this.rdbEUR2.Location = new System.Drawing.Point(32, 120);
            this.rdbEUR2.Name = "rdbEUR2";
            this.rdbEUR2.Size = new System.Drawing.Size(69, 24);
            this.rdbEUR2.TabIndex = 2;
            this.rdbEUR2.TabStop = true;
            this.rdbEUR2.Tag = "7";
            this.rdbEUR2.Text = "EUR";
            this.rdbEUR2.UseVisualStyleBackColor = true;
            // 
            // rdbUSD2
            // 
            this.rdbUSD2.AutoSize = true;
            this.rdbUSD2.Location = new System.Drawing.Point(32, 90);
            this.rdbUSD2.Name = "rdbUSD2";
            this.rdbUSD2.Size = new System.Drawing.Size(69, 24);
            this.rdbUSD2.TabIndex = 1;
            this.rdbUSD2.TabStop = true;
            this.rdbUSD2.Tag = "6";
            this.rdbUSD2.Text = "USD";
            this.rdbUSD2.UseVisualStyleBackColor = true;
            // 
            // rdbCAN2
            // 
            this.rdbCAN2.AutoSize = true;
            this.rdbCAN2.Location = new System.Drawing.Point(32, 60);
            this.rdbCAN2.Name = "rdbCAN2";
            this.rdbCAN2.Size = new System.Drawing.Size(67, 24);
            this.rdbCAN2.TabIndex = 0;
            this.rdbCAN2.TabStop = true;
            this.rdbCAN2.Tag = "5";
            this.rdbCAN2.Text = "CAN";
            this.rdbCAN2.UseVisualStyleBackColor = true;
            // 
            // FrmExchange
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(464, 353);
            this.Controls.Add(this.gpbTo);
            this.Controls.Add(this.gpbFrom1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.btnConvert);
            this.Name = "FrmExchange";
            this.Text = "Money Exchange";
            this.gpbFrom1.ResumeLayout(false);
            this.gpbFrom1.PerformLayout();
            this.gpbTo.ResumeLayout(false);
            this.gpbTo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox gpbFrom1;
        private System.Windows.Forms.RadioButton rdbEUR1;
        private System.Windows.Forms.RadioButton rdbUSD1;
        private System.Windows.Forms.RadioButton rdbCAN1;
        private System.Windows.Forms.RadioButton rdbGBP1;
        private System.Windows.Forms.GroupBox gpbTo;
        private System.Windows.Forms.RadioButton rdbGBP2;
        private System.Windows.Forms.RadioButton rdbEUR2;
        private System.Windows.Forms.RadioButton rdbUSD2;
        private System.Windows.Forms.RadioButton rdbCAN2;
    }
}