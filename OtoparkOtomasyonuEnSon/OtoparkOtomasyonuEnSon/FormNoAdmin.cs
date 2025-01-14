﻿using System;
using System.Windows.Forms;

namespace OtoparkOtomasyonuEnSon
{
    public partial class FormNoAdmin : Form
    {
        public FormNoAdmin()
        {
            InitializeComponent();
        }

        private void FormNoAdmin_Load(object sender, EventArgs e)
        {
            // Bu kod satırı 'otoparkDataSet7.arabalar' tablosuna veri yükler.
            // Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.arabalarTableAdapter.Fill(this.otoparkDataSet4.arabalar);
            Timer_Tick(this, new EventArgs());
            timer.Start();
            
        }

        private void Timer_Tick(object sender, EventArgs e) => stripSaat.Text = $"{DateTime.Now:HH:mm}";

        private void logOutButton_Click(object sender, EventArgs e)
        {
            using (FormGirisYap form1 = new FormGirisYap())
            {
                this.Hide();
                form1.ShowDialog();
            }
        }

        #region Eyecandy
        private void PnlCikisYap_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlCikisYap);

        private void PnlCikisYap_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlCikisYap);

        private void LblCikisYap_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlCikisYap);

        private void LblCikisYap_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlCikisYap);

        private void PicCikisYap_MouseEnter(object sender, EventArgs e) => FormGiris.HoverOldu(pnlCikisYap);

        private void PicCikisYap_MouseLeave(object sender, EventArgs e) => FormGiris.HoverBitti(pnlCikisYap);
        #endregion

        private void __label1_Click(object sender, EventArgs e)
        {

        }

        private void __label2_Click(object sender, EventArgs e)
        {

        }

    }
}
