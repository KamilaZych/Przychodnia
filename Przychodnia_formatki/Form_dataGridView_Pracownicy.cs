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
    public partial class Form_dataGridView_Pracownicy : Form
    {
        public Form_dataGridView_Pracownicy()
        {
            InitializeComponent();
        }

        private void button_dodaj_pracownika_Click(object sender, EventArgs e)
        {
            Przychodnia.Pracownik nowy_pracownik = new Przychodnia.Pracownik();
            Form_dodaj_edytuj_Pracownik form_Dodaj_Edytuj_Pracownik = new Form_dodaj_edytuj_Pracownik(nowy_pracownik);
            if (form_Dodaj_Edytuj_Pracownik.ShowDialog() == DialogResult.OK)
                Przychodnia.Pracownik.Lista_pracowników.Add(nowy_pracownik);
            odśwież();
        }
        void odśwież()
        {
            dataGridView1.Rows.Clear();
            foreach (Przychodnia.Pracownik pracownik in Przychodnia.Pracownik.Lista_pracowników)
            {
                int index = dataGridView1.Rows.Add(pracownik.Values);
                dataGridView1.Rows[index].Tag = pracownik;
            }
        }

        private void button_edytuj_pracownika_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Brak pracowników.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Przychodnia.Pracownik pracownik = (Przychodnia.Pracownik)dataGridView1.SelectedRows[0].Tag;
            Form_dodaj_edytuj_Pracownik form_Dodaj_Edytuj_Pracownik = new Form_dodaj_edytuj_Pracownik(pracownik);
            form_Dodaj_Edytuj_Pracownik.ShowDialog();
            odśwież();
        }

        private void button_usuń_pracownika_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Brak pracowników.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult msg = MessageBox.Show("Po wykonaniu tego polecenia nie będzie możliwe przywrócenie usuniętego pracownika. " +
                        "Czy na pewno chcesz usunąć tego pracownika?", "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (msg == DialogResult.Yes)
            {
                Przychodnia.Pracownik pracownik = (Przychodnia.Pracownik)dataGridView1.SelectedRows[0].Tag;
                Przychodnia.Pracownik.Lista_pracowników.Remove(pracownik);
                odśwież();
            }
        }

        private void Form_dataGridView_Pracownicy_Load(object sender, EventArgs e)
        {
            odśwież();
        }
    }
}
