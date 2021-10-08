using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO__ISP_2_20__Gleb__PR___1_
{
    public partial class Глеб : Form
    {
        public Глеб()
        {
            InitializeComponent();
        }

        double X, Y, Z, U;

        private void button1_Click(object sender, EventArgs e) 
        {
            U = function();
       
            double X = double.Parse(textBox1.Text);
            double Y = double.Parse(textBox2.Text);
            double Z = double.Parse(textBox3.Text);

            double pi = Math.PI;
            double cosX = Math.Cos(X - pi / 6);
            double sin = Math.Sin(Y);
            double sinY = Math.Pow(sin, 2);
            double Z2 = Math.Pow(Z, 2);
            U = ((2 * cosX) / (0.5 + sinY)) * ((1 + Z2) / (3 - Z2 / 5));

            string name = "Практическая работа №1. Студент группы ИСП-2-20 Гичка Г.В.";
            string XYZ = String.Format("X = {0:F3};\nY = {1:F3};\nZ = {2:F3}", X, Y, Z);
            
            string Uform = string.Format("Результат U = {0:F3}", U);
            richTextBox1.Text = name + "\n" + XYZ + "\n" + Uform;
           
        }
       
        public double function()
        {
            double pi = Math.PI;
            double cosX = Math.Cos(X - pi / 6);
            double sin = Math.Sin(Y);
            double sinY = Math.Pow(sin, 2);
            double Z2 = Math.Pow(Z, 2);
            U = ((2 * cosX) / (0.5 + sinY)) * ((1 + Z2) / (3 - Z2 / 5));
            return U;
        }

        

        
    }
}