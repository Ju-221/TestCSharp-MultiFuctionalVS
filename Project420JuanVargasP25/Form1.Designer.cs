namespace Project420JuanVargasP25
{
    partial class FrmLotto
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
            this.lblWinners = new System.Windows.Forms.Label();
            this.txtLottoOut = new System.Windows.Forms.RichTextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnExitLotto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWinners
            // 
            this.lblWinners.AutoSize = true;
            this.lblWinners.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinners.Location = new System.Drawing.Point(12, 4);
            this.lblWinners.Name = "lblWinners";
            this.lblWinners.Size = new System.Drawing.Size(243, 25);
            this.lblWinners.TabIndex = 0;
            this.lblWinners.Text = "The winning numbers are: ";
            // 
            // txtLottoOut
            // 
            this.txtLottoOut.Location = new System.Drawing.Point(16, 32);
            this.txtLottoOut.Name = "txtLottoOut";
            this.txtLottoOut.ReadOnly = true;
            this.txtLottoOut.Size = new System.Drawing.Size(608, 293);
            this.txtLottoOut.TabIndex = 1;
            this.txtLottoOut.Text = "";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(16, 331);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(183, 36);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(217, 331);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(227, 36);
            this.btnReadFile.TabIndex = 3;
            this.btnReadFile.Text = "&Read file";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnExitLotto
            // 
            this.btnExitLotto.Location = new System.Drawing.Point(461, 331);
            this.btnExitLotto.Name = "btnExitLotto";
            this.btnExitLotto.Size = new System.Drawing.Size(163, 36);
            this.btnExitLotto.TabIndex = 4;
            this.btnExitLotto.Text = "E&xit";
            this.btnExitLotto.UseVisualStyleBackColor = true;
            this.btnExitLotto.Click += new System.EventHandler(this.btnExitLotto_Click);
            // 
            // FrmLotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(655, 393);
            this.Controls.Add(this.btnExitLotto);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtLottoOut);
            this.Controls.Add(this.lblWinners);
            this.Name = "FrmLotto";
            this.Text = "Lotto ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWinners;
        private System.Windows.Forms.RichTextBox txtLottoOut;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnExitLotto;
    }
}