using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeEzberlemeUygulamasi
{
    

    public partial class Form1: Form
    {
        public static Form1 AnaForm;
        List<Kelime> kelimeListesi = new List<Kelime>();

        public Form1()
        {
            InitializeComponent();
            AnaForm = this; // 👈 static referansa kendini kaydet

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] dosyalar = Directory.GetFiles(Application.StartupPath, "*.txt");

            foreach (var dosya in dosyalar)
            {
                string dosyaAdi = Path.GetFileNameWithoutExtension(dosya);
                comboBox1.Items.Add(dosyaAdi);
            }

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0; // otomatik seçim
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string secilenDosya = comboBox1.SelectedItem.ToString() + ".txt";
                string tamYol = Path.Combine(Application.StartupPath, secilenDosya);

                try
                {
                    kelimeListesi = SozlukYukleyici.Yukle(tamYol);
                    button1.Enabled = true;
                    MessageBox.Show("Sözlük başarıyla yüklendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosya okunamadı: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir sözlük seçiniz.");
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoruFormu form = new SoruFormu(kelimeListesi);
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
