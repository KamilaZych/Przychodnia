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
    public partial class Form_dodaj_edytuj_Grafik : Form
    {
        Przychodnia.Grafik grafik;
        internal Form_dodaj_edytuj_Grafik(Przychodnia.Grafik grafik)
        {
            this.grafik = grafik;
            InitializeComponent();
        }

        private void Form_dodaj_edytuj_Grafik_Load(object sender, EventArgs e)
        {
            comboBox_gabinety.Items.Clear();
            foreach (Przychodnia.Gabinet gabinet in Przychodnia.Gabinet.Lista_gabinetów)
            {
                comboBox_gabinety.Items.Add(gabinet.Numer_gabinetu);
            }

            comboBox_pracownicy.Items.Clear();
            foreach (Przychodnia.Pracownik pracownik in Przychodnia.Pracownik.Lista_pracowników)
            {
                comboBox_pracownicy.Items[comboBox_pracownicy.Items.Add(pracownik)] = pracownik;
            }

            comboBox_pracownicy.SelectedItem = grafik.Pracownik;
            dateTimePicker_rozpoczęcie.Value = grafik.Data_rozpoczęcia_pracy;
            dateTimePicker_zakończenie.Value = grafik.Data_zakończenia_pracy;
            comboBox_gabinety.SelectedItem = grafik.Numer_gabinetu;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox_pracownicy.SelectedItem == null || comboBox_gabinety.SelectedItem == null)
            {
                MessageBox.Show("Wprowadź dane do grafiku. ", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            foreach (Przychodnia.Grafik sprawdzenie in Przychodnia.Grafik.Lista_grafik)
            {
                if (sprawdzenie.Pracownik != grafik.Pracownik)
                {
                    if (sprawdzenie.Data_rozpoczęcia_pracy.Date == dateTimePicker_rozpoczęcie.Value.Date
                     && sprawdzenie.Numer_gabinetu == (int)comboBox_gabinety.SelectedItem
                     && sprawdzenie.Data_rozpoczęcia_pracy.Hour <= dateTimePicker_zakończenie.Value.Hour
                     && sprawdzenie.Data_zakończenia_pracy.Hour >= dateTimePicker_rozpoczęcie.Value.Hour)
                    {
                        MessageBox.Show("Już ktoś w ten dzień ma przydzielony ten numer gabinetu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

            }
            grafik.Pracownik = (Przychodnia.Pracownik)comboBox_pracownicy.SelectedItem;
            grafik.Data_rozpoczęcia_pracy = dateTimePicker_rozpoczęcie.Value;
            grafik.Data_zakończenia_pracy = dateTimePicker_zakończenie.Value;
            grafik.Numer_gabinetu = (int)comboBox_gabinety.SelectedItem;

            DialogResult = DialogResult.OK;
        }
    }
}
