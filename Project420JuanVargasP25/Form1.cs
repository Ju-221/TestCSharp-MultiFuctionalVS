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
    public partial class FrmLotto : Form
    {
        string WinningNumbers = "0";
        private const string dir = @"C:\FinalProject\";
        private const string path = dir + "LottoNumbers.txt";
        List<Numbers> prs;
        DateTime now = DateTime.Now;

        public FrmLotto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExitLotto_Click(object sender, EventArgs e)
        {
            var exit = MessageBox.Show("Do you want to quit the form?", "Exit", MessageBoxButtons.YesNo);

            if (exit == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            WinningNumbers = string.Empty;
            string date = now.ToString();

            Create(WinningNumbers);


            WinningNumbers = "Max: " + date + " - " + WinningNumbers; 

            txtLottoOut.Text += WinningNumbers + "\n\n";
            //Numbers n1 = new Numbers();
            //n1.WinNum = WinningNumbers;

          // prs.Add(n1);

            Write(WinningNumbers);
        }

        /*public List<Numbers> GetNumbers()
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            StreamReader textIn =
                        new StreamReader(
                        new FileStream(
                        path, FileMode.OpenOrCreate,
                        FileAccess.Read));

            List<name> names = new List<name>();
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] Line = row.Split('.');
                name Ps1Name = new name();
                Ps1Name.Fname = Line[0];
                names.Add(Ps1Name);

            }
            textIn.Close();
            return names;
        }
        */

        public void Create(string Win)
        {
            Random random = new Random();
            
            int lastValue=0;
            string date = now.ToString();
            int randomNumber;

            //List<int> listNumbers = new List<int>();

            for (int i = 0; i <= 6; i++)
            {
                randomNumber = random.Next(1, 50);
        
              if (lastValue != randomNumber)
                {
                    WinningNumbers = WinningNumbers + Convert.ToString(randomNumber) + ",";
                   lastValue = randomNumber;
                }
            }

            int randomNumberMAX = random.Next(1, 50);

            WinningNumbers = WinningNumbers + " Extra: " + Convert.ToString(randomNumberMAX);

                        
            
        }
           
        public void Write(string write)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

         
           

            // _____________Streamwriter starts here__________________

            StreamWriter textOut =
           new StreamWriter(
              new FileStream(path, FileMode.Append, FileAccess.Write));
                textOut.WriteLine();
      
                {
                   // textOut.Write("Max," + date + ":" );
                    textOut.WriteLine(write + ".");
                }
                textOut.Close();
            //___________________StreamWriter Ends______________________

        }

        public class Numbers
        {
            private string winNum;

            public string WinNum
            {
                get { return winNum; }
                set { winNum = value; }
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {

            txtLottoOut.Text = null;
            string lines = File.ReadAllText(path);
            txtLottoOut.Text = lines;

          /*  if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            StreamReader textIn =
                            new StreamReader(
                            new FileStream(
                            path, FileMode.OpenOrCreate,
                            FileAccess.Read));
            string[] numbers;

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] Line = row.Split('|');
                
                numbers = Line;
                txtLottoOut.Text = string.Join(row,Line); ;

            }

            textIn.Close();
          */
        }

      


    }
}
