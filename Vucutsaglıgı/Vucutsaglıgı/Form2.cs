using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vucutsaglıgı
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       
        
        private void kitleindeksi(Form1 frm)
        {
            
            bilgiler(out string cinsiyet, out double kilo, out double boy, out double boyuncevresi, out double belcevresi, out double kalcacevresi, out double yas, out double goguscevresi);
            double BMI = Math.Round((kilo) / Math.Pow((boy / 100), 2));
            frm.textBox7.Text = BMI.ToString();
            if (0 < BMI && BMI <= 18.5) { frm.textBox8.Text = "İdeal Kilonuzun Altındasınız"; }
            else if (18.5 < BMI && BMI <= 25) { frm.textBox8.Text = "İdeal Kilonuzdasınız"; }
            else if (25 < BMI && BMI <= 30) { frm.textBox8.Text = "İdeal Kilonuzun Üzerindesiniz"; }
            else if (30 < BMI && BMI <= 35) { frm.textBox8.Text = "I. Sınıf Obezite Tehlikesi"; }
            else if (35 < BMI && BMI <= 45) { frm.textBox8.Text = "II. Sınıf Obezite Tehlikesi"; }
            else if (45 < BMI) { frm.textBox8.Text = "III. Sınıf (Aşırı) Obezite Tehlikesi"; }
        }

        private void sivihesaplama(Form1 frm)
        {
            
            bilgiler(out string cinsiyet, out double kilo, out double boy, out double boyuncevresi, out double belcevresi, out double kalcacevresi, out double yas, out double goguscevresi);
            if (cinsiyet == "Kadın")
            {
                double siviagirligi = (-2.097 + 0.1069 * boy + 0.2466 * kilo);
                double siviorani = ((siviagirligi / kilo) * 100);
                frm.textBox6.Text = siviagirligi.ToString();
                frm.textBox5.Text = siviorani.ToString();
                if (1 <= yas && yas < 12) { frm.textBox5.Text = siviorani + " İdeal 49-75"; }
                else if (12 <= yas && yas <= 18) { frm.textBox5.Text = siviorani + " İdeal 49-63"; }
                else if (18 < yas && yas <= 50) { frm.textBox5.Text = siviorani + " İdeal 41-60"; }
                else if (50 < yas) { frm.textBox5.Text = siviorani + " İdeal 39-57"; }
            }
            else if (cinsiyet == "Erkek")
            {
                double siviagirligi = (2.447 - 0.09156 * yas + 0.1074 * boy + 0.3362 * kilo);
                double siviorani = ((siviagirligi / kilo) * 100);
                frm.textBox6.Text = siviagirligi.ToString();
                if (1 <= yas && yas < 12) { frm.textBox5.Text = siviorani + " İdeal 49-75"; }
                else if (12 <= yas && yas <= 18) { frm.textBox5.Text = siviorani + " İdeal 52-56"; }
                else if (18 < yas && yas <= 50) { frm.textBox5.Text = siviorani + " İdeal 43-73"; }
                else if (50 < yas) { frm.textBox5.Text = siviorani + " İdeal 47-67"; }
            }
        }

        private void Yagorani(Form1 frm)
        {
            
            bilgiler(out string cinsiyet, out double kilo, out double boy, out double boyuncevresi, out double belcevresi, out double kalcacevresi, out double yas, out double goguscevresi);
            double yagoranihesap;
            if (cinsiyet == "Erkek")
            {
                yagoranihesap = Math.Round((495 / (1.0324 - 0.19077 * Math.Log10(belcevresi - boyuncevresi) + 0.15456 * Math.Log10(boy)) - 450) * 10) / 10;
                double yagagirligi = Math.Round(kilo * yagoranihesap) / 100;
                frm.textBox3.Text = yagagirligi.ToString();
                double yagsizagirlik = Math.Round(kilo - yagagirligi);
                frm.textBox4.Text = yagsizagirlik.ToString();
                if (double.IsNaN(yagoranihesap)) { yagoranihesap = 0; }
                frm.textBox1.Text = "%" + yagoranihesap;
                if (0 < yagoranihesap && yagoranihesap <= 2) { frm.textBox2.Text = "Tehlikeli Yağ Oranı Aralık: 0 - 2 İdeal: 8 - 14 %"; }
                else if (2 < yagoranihesap && yagoranihesap <= 5) { frm.textBox2.Text = "Sınır Yağ Oranı Aralık: 2 - 5 % İdeal:8 - 14 % "; }
                else if (5 < yagoranihesap && yagoranihesap <= 13) { frm.textBox2.Text = "Atletik Yağ Oranı Aralık: 5 - 13 % İdeal:8 - 14 % "; }
                else if (13 < yagoranihesap && yagoranihesap <= 17) { frm.textBox2.Text = "Fitness Yağ Oranı Aralık: 13 - 17 % İdeal:8 - 14 % "; }
                else if (17 < yagoranihesap && yagoranihesap <= 25) { frm.textBox2.Text = "Ortalama Yağ Oranı Aralık: 17 - 25 % İdeal:8 - 14 % "; }
                else if (25 < yagoranihesap) { frm.textBox2.Text = "Obezite Yağ Oranı Aralık: 25 + % İdeal:8 - 14 % "; }
            }
            else if (cinsiyet == "Kadın")
            {
                yagoranihesap = Math.Round((495 / (1.29579 - 0.35004 * Math.Log10(belcevresi + kalcacevresi - boyuncevresi) + 0.22100 * Math.Log10(boy)) - 450) * 10) / 10;
                double yagagirligi = Math.Round(kilo * yagoranihesap) / 100;
                frm.textBox3.Text = yagagirligi.ToString();
                double yagsizagirlik = Math.Round(kilo - yagagirligi);
                frm.textBox4.Text = yagsizagirlik.ToString();
                if (double.IsNaN(yagoranihesap)) { yagoranihesap = 0; }
                frm.textBox1.Text = "%" + yagoranihesap;
                if (0 < yagoranihesap && yagoranihesap <= 10) { frm.textBox2.Text = "Tehlikeli Yağ Oranı Aralık: 0 - 10 İdeal: 20 - 25 %"; }
                else if (10 < yagoranihesap && yagoranihesap <= 13) { frm.textBox2.Text = "Sınır Yağ Oranı Aralık: 10 - 13 % İdeal:20 - 25 % "; }
                else if (13 < yagoranihesap && yagoranihesap <= 20) { frm.textBox2.Text = "Atletik Yağ Oranı Aralık: 13 - 20 % İdeal:20 - 25 % "; }
                else if (20 < yagoranihesap && yagoranihesap <= 24) { frm.textBox2.Text = "Fitness Yağ Oranı Aralık: 20 - 24 % İdeal:20 - 25 % "; }
                else if (24 < yagoranihesap && yagoranihesap <= 31) { frm.textBox2.Text = "Ortalama Yağ Oranı Aralık: 24 - 31 % İdeal:20 - 25 % "; }
                else if (31 < yagoranihesap) { frm.textBox2.Text = "Obezite Yağ Oranı Aralık: 31 + % İdeal:20 - 25 % "; }
                else
                {
                    frm.textBox2.Text = "Böyle Bir Katagori Yok";
                }
            }
        }

        private void bilgiler(out string cinsiyet, out double kilo, out double boy, out double boyuncevresi, out double belcevresi, out double kalcacevresi, out double yas, out double goguscevresi)
        {
            
            cinsiyet = cinsiyet_comboBox.Text;
            yas = Convert.ToDouble(yas_textbox.Text);
            kilo = Convert.ToDouble(kilo_textbox.Text);
            boy = Convert.ToDouble(boy_textbox.Text);
            goguscevresi = Convert.ToDouble(goguscevresi_textbox.Text);
            boyuncevresi = Convert.ToDouble(boyuncevresi_textbox.Text);
            belcevresi = Convert.ToDouble(belcevresi_textbox.Text);
            kalcacevresi = Convert.ToDouble(kalcacevresi_textbox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = gunlukkaloriilerihtiyaci();
            vucuttipi(frm);
            kitleindeksi(frm);
            sivihesaplama(frm);
            Yagorani(frm);
            frm.cinsiyet = cinsiyet_comboBox.Text;
            frm.ShowDialog(); 
        }

        private void vucuttipi(Form1 frm)
        {
            bilgiler(out string cinsiyet, out double kilo, out double boy, out double boyuncevresi, out double belcevresi, out double kalcacevresi, out double yas, out double goguscevresi);
            double belkalcaorani = Math.Round((belcevresi / kalcacevresi), 2);
            frm.textBox10.Text = belkalcaorani.ToString();
            if (cinsiyet == "Kadın")
            {
                if (belkalcaorani <= 0.8) { frm.textBox11.Text = "DÜŞÜK"; } else if (0.8 < belkalcaorani && belkalcaorani <= 0.86) { frm.textBox11.Text = "Sınırda"; } else if (0.86 < belkalcaorani) { frm.textBox11.Text = "Yüksek"; }
                frm.textBox10.Text = belkalcaorani + " İdeal:0.7 - 0.8";
            }
            if (cinsiyet == "Erkek")
            {
                if (belkalcaorani <= 0.95) { frm.textBox11.Text = "DÜŞÜK"; } else if (0.95 < belkalcaorani && belkalcaorani <= 1) { frm.textBox11.Text = "Sınırda"; } else if (1 < belkalcaorani) { frm.textBox11.Text = "Yüksek"; }
                frm.textBox10.Text = belkalcaorani + " İdeal:0.8 - 0.95";
            }
            if ((goguscevresi - kalcacevresi) <= 2.54 && (kalcacevresi - goguscevresi) < 9.144 && ((goguscevresi - belcevresi) >= 22.86 || (kalcacevresi - belcevresi) >= 25.4)) { frm.textBox9.Text = "Kum Saati";}
            else if ((kalcacevresi - goguscevresi) >= 9.144 && (kalcacevresi - goguscevresi) < 25.4 && (kalcacevresi - belcevresi) >= 22.86 && (kalcacevresi / belcevresi) < 1.193) { frm.textBox9.Text = "Alt Kum Saati"; }
            else if ((goguscevresi - kalcacevresi) > 2.54 && (goguscevresi - kalcacevresi) < 25.4 && (goguscevresi - belcevresi) >= 22.86) { frm.textBox9.Text = "En iyi Kum Saati"; }
            else if ((kalcacevresi - goguscevresi) > 5.08 && (kalcacevresi - belcevresi) >= 17.78 && (kalcacevresi / belcevresi) >= 1.193) { frm.textBox9.Text = "Kaşık"; }
            else if ((kalcacevresi - goguscevresi) >= 9.144 && (kalcacevresi - belcevresi) < 22.86) { frm.textBox9.Text = "Üçgen"; }
            else if ((goguscevresi - kalcacevresi) >= 9.144 && (goguscevresi - belcevresi) < 22.86) { frm.textBox9.Text = "Ters Üçgen"; }
            else if ((kalcacevresi - goguscevresi) < 9.144 && (goguscevresi - kalcacevresi) < 9.144 && (goguscevresi - belcevresi) < 22.86 && (kalcacevresi - belcevresi) < 25.4) { frm.textBox9.Text = "Diktörtgen"; }
            else { frm.textBox9.Text = "Vücut Tipi Belirlenemedi"; }
        }

        private Form1 gunlukkaloriilerihtiyaci()
        {
            Form1 frm = new Form1();
            bilgiler(out string cinsiyet, out double kilo, out double boy, out double boyuncevresi, out double belcevresi, out double kalcacevresi, out double yas, out double goguscevresi);
            double amac = 0;
            if (amac == 0)
            {
                if (comboBox1.Text == "Hızlı Kilo Vermek") { amac = -0.2; }
                else if (comboBox1.Text == "Yavaş Kilo Vermek") { amac = -0.1; }
                else if (comboBox1.Text == "Kilo Korumak") { amac = 0; }
                else if (comboBox1.Text == "Yavaş Kilo Almak") { amac = 0.1; }
                else if (comboBox1.Text == "Hızlı Kilo Almak") { amac = 0.2; }
            }
            double bmh = 1;
            if (bmh == 1)
            {
                if (cinsiyet == "Kadın") { bmh = Math.Round(655.1 + (9.56 * kilo) + (1.85 * boy) - (4.68 * yas)); }
                else if (cinsiyet == "Erkek") { bmh = Math.Round(66.5 + (13.75 * kilo) + (5.03 * boy) - (6.75 * yas)); }
            }
            frm.textBox12.Text = bmh + " kcal/gün";
            double gunlukkalori, karbonhidrat, yag, protein, gunlukkaloria;
            if (radioButton1.Checked == true)
            {

                gunlukkalori = Math.Round(bmh * 1.2);
                gunlukkaloria = Math.Round((gunlukkalori * amac) + gunlukkalori);
                karbonhidrat = Math.Round(gunlukkaloria / 100 * 55);
                yag = Math.Round(gunlukkaloria / 100 * 30);
                protein = Math.Round(gunlukkaloria / 100 * 15);
                frm.textBox13.Text = gunlukkaloria + " kcal/gün";
                frm.textBox14.Text = karbonhidrat + " kcal/gün";
                frm.textBox15.Text = yag + " kcal/gün";
                frm.textBox16.Text = protein + " kcal/gün";
            }
            else if (radioButton2.Checked == true)
            {
                gunlukkalori = Math.Round(bmh * 1.375);
                gunlukkaloria = Math.Round((gunlukkalori * amac) + gunlukkalori);
                karbonhidrat = Math.Round(gunlukkaloria / 100 * 55);
                yag = Math.Round(gunlukkaloria / 100 * 30);
                protein = Math.Round(gunlukkaloria / 100 * 15);
                frm.textBox13.Text = gunlukkaloria + " kcal/gün";
                frm.textBox14.Text = karbonhidrat + " kcal/gün";
                frm.textBox15.Text = yag + " kcal/gün";
                frm.textBox16.Text = protein + " kcal/gün";
            }
            else if (radioButton3.Checked == true)
            {
                gunlukkalori = Math.Round(bmh * 1.55);
                gunlukkaloria = Math.Round((gunlukkalori * amac) + gunlukkalori);
                karbonhidrat = Math.Round(gunlukkaloria / 100 * 55);
                yag = Math.Round(gunlukkaloria / 100 * 30);
                protein = Math.Round(gunlukkaloria / 100 * 15);
                frm.textBox13.Text = gunlukkaloria + " kcal/gün";
                frm.textBox14.Text = karbonhidrat + " kcal/gün";
                frm.textBox15.Text = yag + " kcal/gün";
                frm.textBox16.Text = protein + " kcal/gün";
            }
            else if (radioButton4.Checked == true)
            {
                gunlukkalori = Math.Round(bmh * 1.1725);
                gunlukkaloria = Math.Round((gunlukkalori * amac) + gunlukkalori);
                karbonhidrat = Math.Round(gunlukkaloria / 100 * 55);
                yag = Math.Round(gunlukkaloria / 100 * 30);
                protein = Math.Round(gunlukkaloria / 100 * 15);
                frm.textBox13.Text = gunlukkaloria + " kcal/gün";
                frm.textBox14.Text = karbonhidrat + " kcal/gün";
                frm.textBox15.Text = yag + " kcal/gün";
                frm.textBox16.Text = protein + " kcal/gün";
            }
            else if (radioButton5.Checked == true)
            {
                gunlukkalori = Math.Round(bmh * 1.9);
                gunlukkaloria = Math.Round((gunlukkalori * amac) + gunlukkalori);
                karbonhidrat = Math.Round(gunlukkaloria / 100 * 55);
                yag = Math.Round(gunlukkaloria / 100 * 30);
                protein = Math.Round(gunlukkaloria / 100 * 15);
                frm.textBox13.Text = gunlukkaloria + " kcal/gün";
                frm.textBox14.Text = karbonhidrat + " kcal/gün";
                frm.textBox15.Text = yag + " kcal/gün";
                frm.textBox16.Text = protein + " kcal/gün";
            }

            return frm;
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
