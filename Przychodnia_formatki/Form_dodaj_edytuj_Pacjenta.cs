using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia_formatki
{
    public partial class Form_dodaj_edytuj_Pacjenta : Form
    {
        Przychodnia.Pacjent pacjent;
        internal Form_dodaj_edytuj_Pacjenta(Przychodnia.Pacjent pacjent)
        {
            this.pacjent = pacjent;
            InitializeComponent();
        }

        private void Form_dodaj_edytuj_Pacjenta_Load(object sender, EventArgs e)
        {
            textBox_imię.Text = pacjent.Imię;
            textBox_nazwisko.Text = pacjent.Nazwisko;
            textBox_pesel.Text = pacjent.Pesel;
            textBox_rok_urodzenia.Text = pacjent.Rok_urodzenia;
            textBox_adres_zamieszkania.Text = pacjent.Adres_zamieszkania;
            textBox_telefon_komórkowy.Text = pacjent.Telefon_komórkowy;
            textBox_adres_email.Text = pacjent.Adres_email;
            listBox_osoby_upoważnione.Items.Clear();

            foreach (object obj in pacjent.Lista_osób_upoważnionych)
            {
                listBox_osoby_upoważnione.Items.Add(obj);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_imię.Text == "" || textBox_nazwisko.Text == "" || textBox_pesel.Text == "" || textBox_rok_urodzenia.Text == "" || textBox_adres_zamieszkania.Text == "" ||
                textBox_telefon_komórkowy.Text == "" || textBox_adres_email.Text == "" || listBox_osoby_upoważnione.Items.Count == 0)
            {
                MessageBox.Show("Wprowadź dane pacjenta. ", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pacjent.Imię = textBox_imię.Text;
            pacjent.Nazwisko = textBox_nazwisko.Text;
            pacjent.Pesel = textBox_pesel.Text;
            pacjent.Rok_urodzenia = textBox_rok_urodzenia.Text;
            pacjent.Adres_zamieszkania = textBox_adres_zamieszkania.Text;
            pacjent.Telefon_komórkowy = textBox_telefon_komórkowy.Text;
            pacjent.Adres_email = textBox_adres_email.Text;
            pacjent.Lista_osób_upoważnionych.Clear();
            foreach (object obj in listBox_osoby_upoważnione.Items)
            {
                pacjent.Lista_osób_upoważnionych.Add(obj.ToString());
            }
            pacjent.Osoby_upoważnione = "";
            foreach (string osoba_upoważniona in pacjent.Lista_osób_upoważnionych)
            {
                pacjent.Osoby_upoważnione += osoba_upoważniona + ". ";
            }

            DialogResult = DialogResult.OK;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox_osoby_upoważnione.Text == "")
            {
                MessageBox.Show("Wprowadź imię i nazwisko osoby upoważnionej. ", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            foreach (string osoba_upoważniona in listBox_osoby_upoważnione.Items)
            {
                if (osoba_upoważniona == textBox_osoby_upoważnione.Text)
                {
                    MessageBox.Show("Już ta osoba znajduje się na liście osób upoważnionych. ", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            listBox_osoby_upoważnione.Items.Add(textBox_osoby_upoważnione.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (string osoba_upoważniona in pacjent.Lista_osób_upoważnionych)
            {
                if (listBox_osoby_upoważnione.SelectedItem.ToString() == osoba_upoważniona)
                {
                    pacjent.Lista_osób_upoważnionych.Remove(osoba_upoważniona);
                }
            }
            
            listBox_osoby_upoważnione.Items.Remove(listBox_osoby_upoważnione.SelectedItem);
        }
    }
}
