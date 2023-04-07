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
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox11_Click(object sender, EventArgs e) //финиш 
        {
            label4.Text = string.Empty;
            label6.Text = "Финиш"; 
            label5.Text = string.Empty;
            label8.Text = string.Empty;
            label9.Text = string.Empty;
        }

        private void pictureBox12_Click(object sender, EventArgs e) //пункт1 
        {
            label4.Text = "Checkpoint1";
            label6.Text = "МЦК Лужники";
            label9.Text = "Напитки \nЭнергетические батончики \n ";
            pictureBox23.Image = null;
            pictureBox24.Image = Properties.Resources.map_icon_drinks__1_;
            pictureBox25.Image = Properties.Resources.map_icon_energy_bars;
            pictureBox26.Image = null;
            pictureBox27.Image = null;


        }

        private void pictureBox13_Click(object sender, EventArgs e) //пункт2 
        {
            label4.Text = "Checkpoint2";
            label6.Text = "Новодевичей монастырь";
            label9.Text = " Напитки \nЭнергетические батончики \nТуалет \nИнформация \nМед.пункт ";
            pictureBox23.Image = Properties.Resources.map_icon_drinks__1_;
            pictureBox24.Image = Properties.Resources.map_icon_energy_bars;
            pictureBox25.Image = Properties.Resources.map_icon_toilets;
            pictureBox26.Image = Properties.Resources.map_icon_information;
            pictureBox27.Image = Properties.Resources.map_icon_medical;
        }

        private void pictureBox14_Click(object sender, EventArgs e) //пункт3 
        {
            label4.Text = "Checkpoint3";
            label6.Text = "Метро Киевская";
            label9.Text = " Напитки \nЭнергетические батончики \nТуалет \n ";
            pictureBox23.Image = null;
            pictureBox24.Image = Properties.Resources.map_icon_drinks__1_;
            pictureBox25.Image = Properties.Resources.map_icon_energy_bars;
            pictureBox26.Image = Properties.Resources.map_icon_toilets;
            pictureBox27.Image = null;


        }

        private void pictureBox15_Click(object sender, EventArgs e) //пункт4
        {
            label4.Text = "Checkpoint4";
            label6.Text = "МИД";
            label9.Text = " Напитки \nЭнергетические батончики \nТуалет \nМед.пункт";
            pictureBox23.Image = Properties.Resources.map_icon_drinks__1_;
            pictureBox24.Image = Properties.Resources.map_icon_energy_bars;
            pictureBox25.Image = Properties.Resources.map_icon_toilets;
            pictureBox26.Image = Properties.Resources.map_icon_medical;
            pictureBox27.Image = null;

        }

        private void pictureBox16_Click_1(object sender, EventArgs e) //пункт5
        {
            label4.Text = "Checkpoint5";
            label6.Text = "Парк Горького";
            label9.Text = " Напитки \nЭнергетические батончики \nТуалет \nИнформация \n";
            pictureBox23.Image = Properties.Resources.map_icon_drinks__1_;
            pictureBox24.Image = Properties.Resources.map_icon_energy_bars;
            pictureBox25.Image = Properties.Resources.map_icon_toilets;
            pictureBox26.Image = Properties.Resources.map_icon_information;
            pictureBox27.Image = null;

        }

        private void pictureBox17_Click_1(object sender, EventArgs e) //пункт6
        {

            label4.Text = "Checkpoint6";
            label6.Text = "Здание РАН";
            label9.Text = "Напитки \nЭнергетические батончики \nТуалет";
            pictureBox23.Image = null;
            pictureBox24.Image = Properties.Resources.map_icon_drinks__1_;
            pictureBox25.Image = Properties.Resources.map_icon_energy_bars;
            pictureBox26.Image = Properties.Resources.map_icon_toilets;
            pictureBox27.Image = null;
        }

        private void pictureBox18_Click_1(object sender, EventArgs e) //пункт7
        {
            label4.Text = "Checkpoint7";
            label6.Text = "Метро Воробьевы горы";
            label9.Text = " Напитки \nЭнергетические батончики \nТуалет \nИнформация \nМед.пункт ";
            pictureBox23.Image = Properties.Resources.map_icon_drinks__1_;
            pictureBox24.Image = Properties.Resources.map_icon_energy_bars;
            pictureBox25.Image = Properties.Resources.map_icon_toilets;
            pictureBox26.Image = Properties.Resources.map_icon_information;
            pictureBox27.Image = Properties.Resources.map_icon_medical;

        }

        private void pictureBox19_Click_1(object sender, EventArgs e) //пункт8
        {

            label4.Text = "Checkpoint8";
            label6.Text = "Стадион Лужники";
            label9.Text = " Напитки \nЭнергетические батончики \nТуалет \nИнформация \nМед.пункт ";
            pictureBox23.Image = Properties.Resources.map_icon_drinks__1_;
            pictureBox24.Image = Properties.Resources.map_icon_energy_bars;
            pictureBox25.Image = Properties.Resources.map_icon_toilets;
            pictureBox26.Image = Properties.Resources.map_icon_information;
            pictureBox27.Image = Properties.Resources.map_icon_medical;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            label4.Text = "Cтарт";
            label6.Text = "Samba Full Marathon";

        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {

        }
    }
}
