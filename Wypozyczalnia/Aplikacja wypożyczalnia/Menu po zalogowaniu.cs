﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Aplikacja_wypożyczalnia
{
 


    public partial class Menu_po_zalogowaniu : Form
    {

        public Menu_po_zalogowaniu()
        {
            InitializeComponent();
        }

        private void Menu_po_zalogowaniu_Load(object sender, EventArgs e)
        {
            timer1.Start();
            data.Text = DateTime.Now.ToLongDateString();
            czas.Text = DateTime.Now.ToLongTimeString();


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void data_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            czas.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();

        }

        private void czas_Click(object sender, EventArgs e)
        {

        }

       

        private void wylogowanie_Click(object sender, EventArgs e)
        {
          

                MessageBox.Show("Wylogowano");
                this.Hide();
                Panel_administratora pan = new Panel_administratora();
                pan.Show();
            

         
        }

        private void samochody_Click(object sender, EventArgs e)
        {
            this.Hide();
            Samochody sa = new Samochody();
            sa.Show();
        }

        private void rezerwacje_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rezerwacja rez = new Rezerwacja();
            rez.Show();
        }

        private void klienci_Click(object sender, EventArgs e)
        {
            this.Hide();
            Klienci kl = new Klienci();
            kl.Show();
        }

        private void wypozyczenia_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wypozyczenia w = new Wypozyczenia();
            w.Show();
        }
    }
}
