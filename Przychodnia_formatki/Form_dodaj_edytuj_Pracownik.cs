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
    public partial class Form_dodaj_edytuj_Pracownik : Form
    {
        Przychodnia.Pracownik pracownik;
        public Form_dodaj_edytuj_Pracownik(Przychodnia.Pracownik pracownik)
        {
            this.pracownik = pracownik;
            InitializeComponent();
        }

        private void Form_dodaj_edytuj_Pracownik_Load(object sender, EventArgs e)
        {
            comboBox_czynności_medyczne.Items.Clear();
            foreach(Przychodnia.Czynność_medyczna czynność_Medyczna in Przychodnia.Czynność_medyczna.Lista_wszystkich_czynności_medycznych)
            {
                comboBox_czynności_medyczne.Items.Add(czynność_Medyczna.Nazwa_czynności_medycznej);
            }
            listBox_czynności_medyczne.Items.Clear();
            foreach (object obj in pracownik.Lista_czynności_medycznych_danego_lekarza)
            {
                listBox_czynności_medyczne.Items.Add(obj);
            }

            textBox_imię.Text = pracownik.Imię;
            textBox_nazwisko.Text = pracownik.Nazwisko;
            textBox_rok_rozpoczęcia_pracy.Text = pracownik.Rok_rozpoczęcia_pracy;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox_czynności_medyczne.SelectedItem == null)
            {
                MessageBox.Show("Wybierz czynność medyczną którą chcesz przydzielić temu lekarzowi. ", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (string czynność_medyczna in listBox_czynności_medyczne.Items)
            {
                if (czynność_medyczna == comboBox_czynności_medyczne.SelectedItem.ToString())
                {
                    MessageBox.Show("Już ta czynność medyczna znajduje się na liście czynności medycznych tego lekarza. ", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            listBox_czynności_medyczne.Items.Add(comboBox_czynności_medyczne.SelectedItem.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_imię.Text == "" || textBox_nazwisko.Text == "" || textBox_rok_rozpoczęcia_pracy.Text == "" || listBox_czynności_medyczne.Items.Count == 0)
            {
                MessageBox.Show("Wprowadź dane lekarza. ", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pracownik.Imię = textBox_imię.Text;
            pracownik.Nazwisko = textBox_nazwisko.Text;
            pracownik.Rok_rozpoczęcia_pracy = textBox_rok_rozpoczęcia_pracy.Text;
            pracownik.Lista_czynności_medycznych_danego_lekarza.Clear();
            foreach (string czynność_medyczna in listBox_czynności_medyczne.Items)
            {
                pracownik.Lista_czynności_medycznych_danego_lekarza.Add(czynność_medyczna.ToString());
            }
            pracownik.Czynności_medyczne = "";
            foreach (string czynność_medyczna in pracownik.Lista_czynności_medycznych_danego_lekarza)
            {
                pracownik.Czynności_medyczne +=  czynność_medyczna + ". ";
            }

            DialogResult = DialogResult.OK;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox_czynności_medyczne.Items.Remove(listBox_czynności_medyczne.SelectedItem.ToString());
            foreach (string czynność in pracownik.Lista_czynności_medycznych_danego_lekarza)
            {
                if (czynność == listBox_czynności_medyczne.SelectedItem.ToString())
                {
                    pracownik.Lista_czynności_medycznych_danego_lekarza.Remove(czynność);
                }
            }
        }
    }
}
