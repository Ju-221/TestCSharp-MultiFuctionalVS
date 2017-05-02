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

namespace Project420JuanVargasP25 
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var exit = MessageBox.Show("Do you want to quit the application?", "Exit", MessageBoxButtons.YesNo);

            if (exit == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmTemperature Thermometer = new FrmTemperature();
            //load form for temperature exchange
            Thermometer.Show();
        }

        private void pcbCalculator_Click(object sender, EventArgs e)
        {
            FrmCalculator calc = new FrmCalculator(); 
            //load form for calculator
            calc.Show();
        }

        private void pcbLotto_Click(object sender, EventArgs e)
        {
            FrmLotto lottery = new FrmLotto();
            //load form for lotery
            lottery.Show();
        }

        private void pcbRateExchange_Click(object sender, EventArgs e)
        {
            FrmExchange exchange = new FrmExchange();
            //load form for Exchange rate application
            exchange.Show();
        }

     }
}
