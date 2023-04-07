using BMIкалькулятор.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMIкалькулятор
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            frm2 = new Map();
        }
        Map frm2;

        private void Cancel_Click(object sender, EventArgs e)
        {
            txtLength.Clear();
            txtWeight.Clear();

        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Result_Click(object sender, EventArgs e)
        {
            double rost = Convert.ToDouble(txtLength.Text);
            rost = rost / 100;
            double ves = Convert.ToDouble(txtWeight.Text);
            int BMI = Convert.ToInt32(ves / (rost * rost));
            label10.Text = BMI.ToString();

            if (BMI < 10)
            {
                trackBar1.Value = 10; textBox1.Text = "Недостаточный";
                pictureBox3.Image = Properties.Resources.bmi_underweight_icon;
            }

            if (BMI < 18.5 && BMI >= 10)
            {
                trackBar1.Value = Convert.ToInt32(BMI); textBox1.Text = "Недостаточный";
                pictureBox3.Image = Properties.Resources.bmi_underweight_icon;
            }

            if (BMI >= 18.5 && BMI <= 24.9)
            {
                trackBar1.Value = Convert.ToInt32(BMI); textBox2.Text = "Здоровый";
                pictureBox3.Image = Properties.Resources.bmi_healthy_icon;
            }

            if (BMI <= 30 && BMI > 24.9)
            {
                trackBar1.Value = Convert.ToInt32(BMI); textBox3.Text = "Избыточный";
                pictureBox3.Image = Properties.Resources.bmi_overweight_icon;
            }

            if (BMI > 30 && BMI < 35)
            {
                trackBar1.Value = Convert.ToInt32(BMI); textBox4.Text = "Ожирение";
                pictureBox3.Image = Properties.Resources.bmi_obese_icon;
            }
            if (BMI > 35)
            {
                trackBar1.Value = Convert.ToInt32(BMI); textBox4.Text = "Ожирение";
                pictureBox3.Image = Properties.Resources.bmi_obese_icon;
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm2.Show();    
        }

        private void diagnozlabel3_Click(object sender, EventArgs e)
        {

        }

        private void man_Click_1(object sender, EventArgs e)
        {
            woman.BorderStyle = BorderStyle.None;
            man.BorderStyle = BorderStyle.FixedSingle;
            man.BackColor = Color.Gainsboro;
            woman.BackColor = Color.WhiteSmoke;
        }

        private void woman_Click(object sender, EventArgs e)
        {
            man.BorderStyle = BorderStyle.None;
            woman.BorderStyle = BorderStyle.FixedSingle;
            man.BackColor = Color.WhiteSmoke;
            woman.BackColor = Color.Gainsboro;
        }
    }
}