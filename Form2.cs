using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeEzberlemeUygulamasi
{

    public partial class SoruFormu: Form
    {
        private List<Kelime> kelimeler;
        private int soruIndex = 0;
        private int puan = 0;
        private Random rnd = new Random();
        private Button[] secenekButonlari;
        private Kelime aktifKelime;
        private bool ilkCevap = true;


        private void SoruGoster()
        {
            if (soruIndex >= kelimeler.Count)
            {
                MessageBox.Show("Test tamamlandı. Toplam Puan: " + puan);
                this.Close();
                return;
            }

            aktifKelime = kelimeler[soruIndex];
            lbIngilizce.Text = aktifKelime.Ingilizce;

            ilkCevap = true;

            // doğru + 3 yanlış
            List<string> secenekler = new List<string> { aktifKelime.Turkce };
            while (secenekler.Count < 4)
            {
                var yanlis = kelimeler[rnd.Next(kelimeler.Count)].Turkce;
                if (!secenekler.Contains(yanlis))
                    secenekler.Add(yanlis);
            }

            // karıştır
            secenekler = secenekler.OrderBy(x => rnd.Next()).ToList();

            for (int i = 0; i < secenekButonlari.Length; i++)
            {
                secenekButonlari[i].Text = secenekler[i];
                secenekButonlari[i].BackColor = SystemColors.Control;
                secenekButonlari[i].Enabled = true;
                secenekButonlari[i].Click -= SecenekTiklandi;
                secenekButonlari[i].Click += SecenekTiklandi;
            }
            lblSoruDurum.Invalidate(); // Paint olayını tetikler

        }

        private void SecenekTiklandi(object sender, EventArgs e)
        {
            Button tiklanan = sender as Button;

            if (tiklanan.Text == aktifKelime.Turkce)
            {
                tiklanan.BackColor = Color.LightGreen;
                if (ilkCevap)
                {
                    puan += 10;
                }

                soruIndex++;
                Task.Delay(800).ContinueWith(_ =>
                {
                    Invoke(new Action(() =>
                    {
                        SoruGoster();
                    }));
                });
            }
            else
            {
                tiklanan.BackColor = Color.Red;
                ilkCevap = false;
            }
        }


        public SoruFormu(List<Kelime> kelimeler)
        {
            InitializeComponent();
            this.kelimeler = kelimeler.OrderBy(x => rnd.Next()).ToList();
            secenekButonlari = new Button[] { btnSecenek1, btnSecenek2, btnSecenek3, btnSecenek4 };
            lblSoruDurum.Paint += lblSoruDurum_Paint;

        }



        private void SoruFormu_Load(object sender, EventArgs e)
        {
            lbIngilizce.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lbIngilizce.ForeColor = Color.White;
            lbIngilizce.BackColor = Color.SteelBlue;
            lbIngilizce.TextAlign = ContentAlignment.MiddleCenter;
            lbIngilizce.AutoSize = false;
            lbIngilizce.Size = new Size(this.Width - 40, 50);
            lbIngilizce.Location = new Point(10, 60);

            SoruGoster();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, PaintEventArgs e)
        {

        }
        private void lblSoruDurum_Paint(object sender, PaintEventArgs e)
        {
            string soruText = $"{soruIndex + 1} / {kelimeler.Count}";
            string puanText = puan.ToString();

            using (Font font = new Font("Segoe UI", 12, FontStyle.Bold))
            using (Brush brush = new SolidBrush(Color.White))
            {
                // Sol tarafa soru sayısı
                e.Graphics.DrawString(soruText, font, brush, new PointF(10, 15));

                // Sağ tarafa puan
                SizeF puanSize = e.Graphics.MeasureString(puanText, font);
                float x = lblSoruDurum.Width - puanSize.Width - 10;
                e.Graphics.DrawString(puanText, font, brush, new PointF(x, 15));
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.AnaForm.Close(); // 👈 Form1’i de kapat

            MessageBox.Show($"Test bitti! Toplam puan: {puan}");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
