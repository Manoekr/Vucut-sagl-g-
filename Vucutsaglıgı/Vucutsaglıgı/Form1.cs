using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vucutsaglıgı.Properties;
namespace Vucutsaglıgı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 f2 = new Form2();
        public string cinsiyet;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (cinsiyet == "Kadın")
            {
                if (textBox9.Text == "Kum Saati")
                {
                    pictureBox1.Image = Resources.Kadın_Kumsaati;

                }
                else if (textBox9.Text == "Kaşık")
                {
                    pictureBox1.Image = Resources.Kadın_kaşık;
                }
                else if (textBox9.Text == "Üçgen")
                {
                    pictureBox1.Image = Resources.Kadın_Üçgen;
                }
                else if (textBox9.Text == "Ters Üçgen")
                {
                    pictureBox1.Image = Resources.Kadın_TersÜçgen;
                }
                else if (textBox9.Text == "Diktörtgen")
                {
                    pictureBox1.Image = Resources.Kadın_Diktörtgen;
                }
            }
            else if (cinsiyet == "Erkek")
            {
                if (textBox9.Text == "Kum Saati" || textBox9.Text == "Alt Kum Saati" || textBox9.Text == "En iyi Kum Saati")
                {
                    pictureBox1.Image = Resources.Erkek_Kumsaati;
                }
                else if (textBox9.Text == "Kaşık")
                {
                    pictureBox1.Image = Resources.Erkek_Kaşık;
                }
                else if (textBox9.Text == "Üçgen")
                {
                    pictureBox1.Image = Resources.Erkek_üçgen;
                }
                else if (textBox9.Text == "Ters Ügçen")
                {
                    pictureBox1.Image = Resources.Erkek_TersÜçgen;
                }
                else if (textBox9.Text == "Diktörtgen")
                {
                    pictureBox1.Image = Resources.Erkek_Diktörtgen;
                }
            }
        }

        
    }
}
