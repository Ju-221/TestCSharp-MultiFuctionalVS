//Author: Juan Vargas (c)
//FINAL PROJECT PROGRAMMING
//Last edit: 15/05/2017
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

//todo: REad File();

namespace Project420JuanVargasP25
{
    public partial class FrmExchange : Form
    {
        int select = 0;
        string WriteOut;
        private const string dir = @"C:\FinalProject\";
        private const string path = dir + "Exchange.txt";
        DateTime now = DateTime.Now;

        public FrmExchange()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var exit = MessageBox.Show("Do you want to quit the form?", "Exit", MessageBoxButtons.YesNo);

            if (exit == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

         }



        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (rdbCAN1.Checked)
            {
                select = 1;
                convert();
                
            }
            else if (rdbUSD1.Checked)
            {
                select = 2;
                convert();
            }

            else if (rdbEUR1.Checked)
            {
                select = 3;
                convert();
            }
            else if (rdbGBP1.Checked)
            {
                select = 4;
                convert();
            }

            WriteLog(WriteOut);
            //MessageBox.Show("error, you have not selected correctly the buttons");
        }

        
        public void convert()
        {
            //________________________________0, CAN, USD, EUR, GBP 
            double[] rateCAN = new double[5] { 0, 1, 1.33, 1.41, 1.67};
            double[] rateUSD = new double[5] { 0, 0.75, 1, 1.06, 1.25};
            double[] rateEUR = new double[5] { 0, 0.71, 0.94, 1, 1.18 }; 
            double[] rateGBP = new double[5] { 0, 0.60, 0.80, 0.85, 1 };

            string[] selectedRate = new string[5] { "none", " CAN", " USD", " EUR", " GBP" };
            string date = now.ToString();

           double n1=0, total;

           try
           {
               n1 = Convert.ToDouble(textBox1.Text);
           }
           catch (Exception except1)
           {
               textBox1.Text = "0";
               MessageBox.Show(except1.Message);
           }


            if (rdbCAN2.Checked)
            {
               
                total = n1 * rateCAN[select];

                textBox2.Text = Convert.ToString(total);

                WriteOut = Convert.ToString(n1) + selectedRate[select] + " = " + Convert.ToString(total) + " CAN, " + date + " Rate: " + Convert.ToString(rateCAN[select]);


            }
            else if (rdbUSD2.Checked)
            {
                total = n1 * rateUSD[select];

                textBox2.Text = Convert.ToString(total);
                WriteOut = Convert.ToString(n1) + selectedRate[select] + " = " + Convert.ToString(total) + " USD, " + date + " Rate: " + Convert.ToString(rateUSD[select]);
            }

            else if (rdbEUR2.Checked)
            {
                total = n1 * rateEUR[select];

                textBox2.Text = Convert.ToString(total);
                WriteOut = Convert.ToString(n1) + selectedRate[select] + " = " + Convert.ToString(total) + " EUR, " + date + " Rate: " + Convert.ToString(rateEUR[select]);
            }
            else if (rdbGBP2.Checked)
            {
                total = n1 * rateGBP[select];

                textBox2.Text = Convert.ToString(total);
                WriteOut = Convert.ToString(n1) + selectedRate[select] + " = " + Convert.ToString(total) + " GBP, " + date + " Rate: " + Convert.ToString(rateGBP[select]);
            }

        }

        public void WriteLog(string WriteOut)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);




            // _____________Streamwriter starts here__________________

            StreamWriter textOut =
           new StreamWriter(
              new FileStream(path, FileMode.Append, FileAccess.Write));
            textOut.WriteLine();

            {
                
                textOut.WriteLine(WriteOut + ".");
            }
            textOut.Close();
            //___________________StreamWriter Ends______________________

        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path))
                MessageBox.Show("The file does not exist, please generate one");
            else
            {
                string lines = File.ReadAllText(path);
                MessageBox.Show(lines);
            }
        }

    }
}
