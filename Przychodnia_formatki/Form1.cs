using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;


namespace Przychodnia_formatki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_czynności_medyczne_Click(object sender, EventArgs e)
        {
            Hide();
            Form_dataGridView_Czynności_medyczne form_Dodaj_Edytuj_Czynności_Medyczne = new Form_dataGridView_Czynności_medyczne();
            form_Dodaj_Edytuj_Czynności_Medyczne.ShowDialog();
            Show();
        }

        private void button_gabinety_Click(object sender, EventArgs e)
        {
            Hide();
            Form_dataGridView_Gabinety form_Dodaj_Edytuj_Gabinety = new Form_dataGridView_Gabinety();
            form_Dodaj_Edytuj_Gabinety.ShowDialog();
            Show();
        }

        private void button_pracownicy_Click(object sender, EventArgs e)
        {
            Hide();
            Form_dataGridView_Pracownicy form_Dodaj_Edytuj_Pracownicy = new Form_dataGridView_Pracownicy();
            form_Dodaj_Edytuj_Pracownicy.ShowDialog();
            Show();
        }

        private void button_pacjenci_Click(object sender, EventArgs e)
        {
            Hide();
            Form_dataGridView_Pacjenci form_Dodaj_Edytuj_Pacjenci = new Form_dataGridView_Pacjenci();
            form_Dodaj_Edytuj_Pacjenci.ShowDialog();
            Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Przychodnia.Serializacja.SerializacjaForms();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Przychodnia.Serializacja.DeserializacjaForms();
        }

        private void button_grafik_Click(object sender, EventArgs e)
        {
            Hide();
            Form_dataGridView_Grafik form_DataGridView_Grafik = new Form_dataGridView_Grafik();
            form_DataGridView_Grafik.ShowDialog();
            Show();
        }

        private void button_zaplanowane_wizyty_Click(object sender, EventArgs e)
        {
            Hide();
            Form_dataGridView_Zaplanowane_wizyty form_DataGridView_Zaplanowane_Wizyty = new Form_dataGridView_Zaplanowane_wizyty();
            form_DataGridView_Zaplanowane_Wizyty.ShowDialog();
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
