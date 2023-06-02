﻿using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace OtoparkOtomasyonuEnSon
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManualForm ManualForm = new ManualForm();
            this.Hide();
            ManualForm.ShowDialog();
            //Manuel Giriş Sayfasına Geçiş
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Start a new process
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "python",
                    // Replace with your python script path
                    Arguments = "D:\\projects\\realtime_park\\plaka_tanima\\cam_plaka.py",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            process.Start();

            // Read the python script output
            while (!process.StandardOutput.EndOfStream)
            {
                var line = process.StandardOutput.ReadLine();
                if (!string.IsNullOrEmpty(line))
                {
                    // Store the detected text
                    string detectedText = line;
                    MessageBox.Show(detectedText);
                    // Now you can use the 'detectedText' variable to insert into your SQL Server in Windows Forms.
                    // Here, you would typically call a method which executes the SQL insert operation using the SqlConnection, SqlCommand and SqlParameter classes.
                    // For example: InsertIntoSqlServer(detectedText);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormKayitlar formKayitlar = new FormKayitlar();
            this.Hide();
            formKayitlar.ShowDialog();
            //Kayıtlar Sayfasına Geçiş
        }


        private void button5_Click(object sender, EventArgs e)
        {
            FormGirisYap form1 = new FormGirisYap();
            this.Hide();
            form1.ShowDialog();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            string komut = "cd D:\\projects\\realtime_park\\plaka_tanima python cam_plaka.py";
            try
            {
                Process.Start("cmd.exe", "/c" + "cd D:\\projects\\realtime_park\\plaka_tanima &python cam_plaka.py");

            }
            catch (Exception)
            {
                MessageBox.Show("Tekrar Deneyiniz !");
            }

            // Plaka Okuma Programını CMD üzerinden çalıştırıyoruz
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FiyatTarifeForm fiyatTarifeForm = new FiyatTarifeForm();
            this.Hide();
            fiyatTarifeForm.ShowDialog();
        }
    }
}
