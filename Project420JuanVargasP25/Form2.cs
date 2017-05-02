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

namespace Project420JuanVargasP25
{
    public partial class FrmCalculator : Form
    {
        string Input,Input2;
        double Oper1, Oper2;
        private string OP;

        private const string dir = @"C:\FinalProject\";
        private const string path = dir + "Math.txt";

        public FrmCalculator()
        {
            InitializeComponent();
            txtShow.Text = "0";
            Input = null;

            mathJ calc = new mathJ();

            calc.Op = Convert.ToString(txtShow.Text);
        }

       

        private void btn1_Click(object sender, EventArgs e)
        {
            Input = Input + "1";
            txtShow.Text = Input;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Input = Input + "2";
            txtShow.Text = Input;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Input = Input + "3";
            txtShow.Text = Input;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Input = Input + "4";
            txtShow.Text = Input;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Input = Input + "5";
            txtShow.Text = Input;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Input = Input + "6";
            txtShow.Text = Input;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Input = Input + "7";
            txtShow.Text = Input;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Input = Input + "8";
            txtShow.Text = Input;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Input = Input + "9";
            txtShow.Text = Input;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Input = Input + "0";
            txtShow.Text = Input;
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            var str = Input;

            
           // if (str.IndexOf(".") == -1)
            {
            Input = Input + ".";
            txtShow.Text = Input;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var exit = MessageBox.Show("Do you want to quit the form?", "Exit", MessageBoxButtons.YesNo);

            if (exit == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtShow.Text = "0";
            Input = null;
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {

            Input = txtShow.Text;

            if (Input != "0")
            {
                mathJ calc = new mathJ();

                try
                {
                    Oper1 = Convert.ToDouble(Input);
                }
                catch (Exception except1)
                {
                    Input = "0";
                    MessageBox.Show(except1.Message);
                }

                OP = "-";

                calc.Substract(Input);
                //calc.Op = "+";

                Input = string.Empty;
                txtShow.Text = Input;
               
            }

            if (Input == "0")
            {
                Input = "-";
                txtShow.Text = Input;
            }
          
            
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

            mathJ calc = new mathJ();

            try
            {
                Oper1 = Convert.ToDouble(Input);
            }
            catch (Exception except1)
            {
                Input = "0";

              MessageBox.Show(except1.Message);
            }
            
            OP = "+";

            calc.Add(Input);
           // calc.Op = "+";
           
            Input = string.Empty;
            txtShow.Text = Input;
        }
        private void btnMul_Click(object sender, EventArgs e)
        {
            mathJ calc = new mathJ();

            try
            {
                Oper1 = Convert.ToDouble(Input);
            }
            catch (Exception except1)
            {
                Input = "0";
                MessageBox.Show(except1.Message);
            }
            OP = "*";

            calc.Add(Input);
            // calc.Op = "*";

            Input = string.Empty;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            mathJ calc = new mathJ();

            try
            {
                Oper1 = Convert.ToDouble(Input);
            }
            catch (Exception except1)
            {
                Input = "0";
                MessageBox.Show(except1.Message);
            }




            OP = "/";

            //calc.Add(Input);
            // calc.Op = "/";

           

            Input = string.Empty;
        }

         private void btnEql_Click(object sender, EventArgs e)
        {
            mathJ calc = new mathJ();

          

            try
            {
                Oper2 = Convert.ToDouble(Input);
            }
            catch (Exception except1)
            {
                Input = "0";
                MessageBox.Show(except1.Message);
            }


            calc.Equals(Oper1,Oper2,OP);

           

            Input = Convert.ToString(calc.CurrentValue);

            if (OP == "/" && Oper2 == 0)
            {
                Input = null;   
                txtShow.Text = "Error";
                MessageBox.Show("Invalid division by 0 found");
                
            }

            txtShow.Text = Input;

             WriteData(calc.CurrentValue);


        }

        public void WriteData(double Current)
        {
            if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                // _____________Streamwriter starts here__________________

                StreamWriter textOut =
               new StreamWriter(
                  new FileStream(path, FileMode.Append,FileAccess.Write));
                  textOut.WriteLine(Oper1 + OP + Oper2 + "=" + Current + "|");
                textOut.Close();
               //___________________StreamWriter Ends______________________


        }
         
         

         public class mathJ
         {
             private double currentValue = 0, operand1 = 0, operand2 = 0;
             private string op;

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
             public string Op
             {
                 set { op = value; }
                 get { return op; }
             }

             //add
             public void Add(string Input)
             {
                 try
                 {
                     Operand1 = Convert.ToDouble(Input);


                 }
                 catch (Exception except1)
                 {
                     Input = "0";
                     MessageBox.Show(except1.Message);
                 }
                 Op = "+";

             }

             public void Substract(string Input)
             {
                 try
                 {
                     Operand1 = Convert.ToDouble(Input);


                 }
                 catch (Exception except1)
                 {
                     Input = "0";
                     MessageBox.Show(except1.Message);
                 }
                 Op = "-";

             }

             /*public string Inputlay
             {
                 set { Inputlay = value; }
                 get { return Inputlay; }
             }
             */


             public void Equals(double Oper1, double Oper2,string OP)
             {
               
              /*   if (Op == "+")
                 {
                      
                     CurrentValue = Oper1 + Oper2;
                }
              */
                 switch (OP)
                 {
                     case ("+"):
                         {
                              CurrentValue = Oper1 + Oper2;

                             break;
                         }
                     case ("-"):
                         {
                              CurrentValue = Oper1 - Oper2;

                             break;
                         }
                     case ("*"):
                         {
                             CurrentValue = Oper1 * Oper2;

                             break;
                         }

                     case ("/"):
                         {
                             
                             CurrentValue = Oper1 / Oper2;
                            
                             break;
                         }

                  


                 }
             }


             /*   //run the math

                public void mathCalc()
                {


                    //first number trycatch
                    try
                    {
                        Operand1 = Convert.ToDouble(Call);
                    }
                    catch (Exception except1)
                    {
                        Op = "0";
                        MessageBox.Show(except1.Message);
                    }
        
            */
         }

        

         
    }
}
