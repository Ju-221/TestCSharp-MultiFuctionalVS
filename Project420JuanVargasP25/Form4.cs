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
using System.Text.RegularExpressions;
using System.IO;

namespace Project420JuanVargasP25
{
    public partial class FrmTemperature : Form
    {
        string Output, message2Show;
        string title = "Created by Juan Vargas(c), FINAL PROJECT 2017 PROGRAMMING\r\nLast time edited : 17/04/2017\r\nTeacher: Mihai Mahtei\r\nEdition 2.0\r\n\r\n\r\n";
        private const string dir = @"C:\FinalProject\";
        private const string path = dir + "TempConversions.txt";

        int choice = 0,i=0; // 0 = ilegal process, 1 = C2F, 2= F2C / check the streamWriter for the I function.

        DateTime now = DateTime.Now;

        public FrmTemperature()
        {
            InitializeComponent();
            txtOutput.Text = title;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var exit = MessageBox.Show("Do you want to quit the form?", "Exit", MessageBoxButtons.YesNo);

            if (exit == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            //flush the last values when run.
            choice = 0;
            message2Show = string.Empty;

            string date = now.ToString();

            convert(txtC2F.Text,txtF2C.Text);

            

            switch (choice)
            {
                case 1:
                    {
                        // output
                        Message(Convert.ToDouble(Output));
                        txtOutput.Text += Output + "F " + message2Show + date + "\r\n";
                        WriteOut(Output + "F " + message2Show + date);
                        break;
                    }

                case 2:
                    {
                        // output
                        Message(Convert.ToDouble(Output));
                        txtOutput.Text += Output + "C " + message2Show + " " + date + "\r\n";
                        WriteOut(Output + "C " + message2Show + " " + date);
                        break;
                    }
                
                default:
                    Console.WriteLine("ERROR, deleting win32"); //if someone reaches this level of data exception handling they are not human (or someone with a hex editor)
                    break;

            }

            

            
        }
        private void convert(string C2F,string F2C)
        {
            TempJ tempChange = new TempJ();
            

             if (rdbC2F.Checked == false && rdbF2C.Checked == false)
            {
                choice = 0;
                MessageBox.Show("", "Please select the type of convertion to be done.");
            }
            else if (rdbC2F.Checked == true)
            {
                choice = 1;
                 try
                {
                    //C2F = Regex.Replace(C2F, @"^\d+([\.\,]?\d+)?$","");
                    tempChange.Operand1 = Convert.ToDouble(C2F);
                }
                catch (Exception except1)
                {
                    txtC2F.Text= "0";
                    MessageBox.Show(except1.Message);
                }
                 //CALCULATION
                 tempChange.CurrentValue = (tempChange.Operand1 * 9 / 5) + 32;
                 Output = Convert.ToString(tempChange.CurrentValue);

            }
            else if (rdbF2C.Checked == true)
            {
                choice = 2;
                 try
                {
                   // F2C = Regex.Replace(C2F, @"^\d+([\.\,]?\d+)?$", "");
                    tempChange.Operand2 = Convert.ToDouble(F2C);
                }
                catch (Exception except1)
                {
                    txtF2C.Text= "0";
                    MessageBox.Show(except1.Message);
                }
                //CALCULATION
                 tempChange.CurrentValue = (tempChange.Operand2 - 32) * 5 / 9;
                 Output = Convert.ToString(tempChange.CurrentValue);
                 

            }

         

        
        }

        public void Message(double Value)
        {

            if (choice == 2)
            {
                if (Value == 100)
                    message2Show = " Water boils";
                else if (Value == 40)
                    message2Show = " Hot Bath";
                else if (Value == 37)
                    message2Show = " Body Temperature";
                else if (Value == 30)
                    message2Show = " Beach weather";
                else if (Value == 21)
                    message2Show = " Room Temperature";
                else if (Value == 10)
                    message2Show = " Cool day ";
                else if (Value == 0)
                    message2Show = " Freezing point of water";
                else if (Value == -18)
                    message2Show = " Very Cold Day";
                else if (Value == -40)
                    message2Show =" Extremly Cold Day\n(and the same number!)";

                //message2Show = string.Empty;

            
            }

            else if (choice == 1)
            {
                if (Value == 212)
                    message2Show = " Water boils";
                else if (Value == 104)
                    message2Show = " Hot Bath";
                else if (Value == 98.6)
                    message2Show = " Body Temperature";
                else if (Value == 86)
                    message2Show = " Beach weather";
                else if (Value == 70)
                    message2Show = " Room Temperature";
                else if (Value == 50)
                    message2Show = " Cool day ";
                else if (Value == 32)
                    message2Show = " Freezing point of water";
                else if (Value == 0)
                    message2Show = " Very Cold Day";
                else if (Value == -40)
                    message2Show = " Extremly Cold Day\n(and the same number!)";

                //message2Show = string.Empty;
            }
        }

        public void WriteOut(string WriteOut)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            // _____________Streamwriter starts here__________________

            StreamWriter textOut =
           new StreamWriter(
              new FileStream(path, FileMode.Append, FileAccess.Write));
            textOut.WriteLine();

            {
                if (i == 0) //write the titleVersion on the file only once per time the program is opened
                {
                    textOut.Write(title);
                    i++;
                }
                textOut.WriteLine(WriteOut + "|");
            }
            textOut.Close();
            //___________________StreamWriter Ends______________________

        }

        public class TempJ
        {
            private double currentValue = 0, operand1, operand2;

            public double CurrentValue
            {
                set { currentValue = value; }
                get { return currentValue; }
            }
            public double Operand1
            {
                set { operand1 = value; }
                get { return operand1; }
            }
            public double Operand2
            {
                set { operand2 = value; }
                get { return operand2; }
            }
        }

        private void rdbC2F_CheckedChanged(object sender, EventArgs e)
        {
            txtF2C.ReadOnly = true;
            txtC2F.ReadOnly = false;
            txtC2F.Text = string.Empty;
        }

        private void rdbF2C_CheckedChanged(object sender, EventArgs e)
        {
            txtC2F.ReadOnly = true;
            txtF2C.ReadOnly = false;
            txtF2C.Text = string.Empty;
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(dir) && File.Exists(path))
            {
                // ___________Stream reader___________
                txtOutput.Text = string.Empty;
                string lines = File.ReadAllText(path);

                //______________ReaderFinishes___________
                txtOutput.Text = lines;
            }
            else if (!File.Exists(path))
                MessageBox.Show("File not found");
        }

    }
}
