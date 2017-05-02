namespace Project420JuanVargasP25
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.btnExit = new System.Windows.Forms.Button();
            this.pcbRateExchange = new System.Windows.Forms.PictureBox();
            this.pcbTemperature = new System.Windows.Forms.PictureBox();
            this.pcbLotto = new System.Windows.Forms.PictureBox();
            this.pcbCalculator = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRateExchange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLotto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCalculator)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(529, 485);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 42);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // pcbRateExchange
            // 
            this.pcbRateExchange.Image = ((System.Drawing.Image)(resources.GetObject("pcbRateExchange.Image")));
            this.pcbRateExchange.Location = new System.Drawing.Point(87, 83);
            this.pcbRateExchange.Name = "pcbRateExchange";
            this.pcbRateExchange.Size = new System.Drawing.Size(170, 134);
            this.pcbRateExchange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRateExchange.TabIndex = 1;
            this.pcbRateExchange.TabStop = false;
            this.pcbRateExchange.Click += new System.EventHandler(this.pcbRateExchange_Click);
            // 
            // pcbTemperature
            // 
            this.pcbTemperature.Image = ((System.Drawing.Image)(resources.GetObject("pcbTemperature.Image")));
            this.pcbTemperature.Location = new System.Drawing.Point(332, 83);
            this.pcbTemperature.Name = "pcbTemperature";
            this.pcbTemperature.Size = new System.Drawing.Size(170, 142);
            this.pcbTemperature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbTemperature.TabIndex = 2;
            this.pcbTemperature.TabStop = false;
            this.pcbTemperature.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pcbLotto
            // 
            this.pcbLotto.Image = ((System.Drawing.Image)(resources.GetObject("pcbLotto.Image")));
            this.pcbLotto.Location = new System.Drawing.Point(87, 292);
            this.pcbLotto.Name = "pcbLotto";
            this.pcbLotto.Size = new System.Drawing.Size(170, 142);
            this.pcbLotto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLotto.TabIndex = 3;
            this.pcbLotto.TabStop = false;
            this.pcbLotto.Click += new System.EventHandler(this.pcbLotto_Click);
            // 
            // pcbCalculator
            // 
            this.pcbCalculator.Image = ((System.Drawing.Image)(resources.GetObject("pcbCalculator.Image")));
            this.pcbCalculator.Location = new System.Drawing.Point(332, 292);
            this.pcbCalculator.Name = "pcbCalculator";
            this.pcbCalculator.Size = new System.Drawing.Size(170, 142);
            this.pcbCalculator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCalculator.TabIndex = 4;
            this.pcbCalculator.TabStop = false;
            this.pcbCalculator.Click += new System.EventHandler(this.pcbCalculator_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(627, 539);
            this.Controls.Add(this.pcbCalculator);
            this.Controls.Add(this.pcbLotto);
            this.Controls.Add(this.pcbTemperature);
            this.Controls.Add(this.pcbRateExchange);
            this.Controls.Add(this.btnExit);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FrmMenu";
            this.ShowIcon = false;
            this.Text = "Dash Board - Juan Vargas (2017)";
            ((System.ComponentModel.ISupportInitialize)(this.pcbRateExchange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLotto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCalculator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pcbRateExchange;
        private System.Windows.Forms.PictureBox pcbTemperature;
        private System.Windows.Forms.PictureBox pcbLotto;
        private System.Windows.Forms.PictureBox pcbCalculator;
    }
}

