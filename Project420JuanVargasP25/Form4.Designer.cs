namespace Project420JuanVargasP25
{
    partial class FrmTemperature
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
            this.rdbC2F = new System.Windows.Forms.RadioButton();
            this.rdbF2C = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtC2F = new System.Windows.Forms.TextBox();
            this.txtF2C = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnCloseFrmCalc = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rdbC2F
            // 
            this.rdbC2F.AutoSize = true;
            this.rdbC2F.Location = new System.Drawing.Point(185, 60);
            this.rdbC2F.Name = "rdbC2F";
            this.rdbC2F.Size = new System.Drawing.Size(118, 24);
            this.rdbC2F.TabIndex = 0;
            this.rdbC2F.TabStop = true;
            this.rdbC2F.Tag = "1";
            this.rdbC2F.Text = "From C to F";
            this.rdbC2F.UseVisualStyleBackColor = true;
            this.rdbC2F.CheckedChanged += new System.EventHandler(this.rdbC2F_CheckedChanged);
            // 
            // rdbF2C
            // 
            this.rdbF2C.AutoSize = true;
            this.rdbF2C.Location = new System.Drawing.Point(185, 90);
            this.rdbF2C.Name = "rdbF2C";
            this.rdbF2C.Size = new System.Drawing.Size(118, 24);
            this.rdbF2C.TabIndex = 1;
            this.rdbF2C.TabStop = true;
            this.rdbF2C.Tag = "2";
            this.rdbF2C.Text = "From F to C";
            this.rdbF2C.UseVisualStyleBackColor = true;
            this.rdbF2C.CheckedChanged += new System.EventHandler(this.rdbF2C_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "to";
            // 
            // txtC2F
            // 
            this.txtC2F.Location = new System.Drawing.Point(32, 153);
            this.txtC2F.Name = "txtC2F";
            this.txtC2F.Size = new System.Drawing.Size(169, 26);
            this.txtC2F.TabIndex = 3;
            // 
            // txtF2C
            // 
            this.txtF2C.Location = new System.Drawing.Point(274, 153);
            this.txtF2C.Name = "txtF2C";
            this.txtF2C.Size = new System.Drawing.Size(179, 26);
            this.txtF2C.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "C ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "F";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Message: ";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(32, 408);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(115, 30);
            this.btnConvert.TabIndex = 9;
            this.btnConvert.Text = "&Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(188, 408);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(115, 30);
            this.btnReadFile.TabIndex = 10;
            this.btnReadFile.Text = "&Read File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnCloseFrmCalc
            // 
            this.btnCloseFrmCalc.Location = new System.Drawing.Point(338, 408);
            this.btnCloseFrmCalc.Name = "btnCloseFrmCalc";
            this.btnCloseFrmCalc.Size = new System.Drawing.Size(115, 30);
            this.btnCloseFrmCalc.TabIndex = 11;
            this.btnCloseFrmCalc.Text = "E&xit";
            this.btnCloseFrmCalc.UseVisualStyleBackColor = true;
            this.btnCloseFrmCalc.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(32, 239);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(421, 146);
            this.txtOutput.TabIndex = 12;
            // 
            // FrmTemperature
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(498, 479);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnCloseFrmCalc);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtF2C);
            this.Controls.Add(this.txtC2F);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbF2C);
            this.Controls.Add(this.rdbC2F);
            this.Name = "FrmTemperature";
            this.Text = "Temperature Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbC2F;
        private System.Windows.Forms.RadioButton rdbF2C;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtC2F;
        private System.Windows.Forms.TextBox txtF2C;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnCloseFrmCalc;
        private System.Windows.Forms.TextBox txtOutput;
    }
}