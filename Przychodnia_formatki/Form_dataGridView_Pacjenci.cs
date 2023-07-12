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
    public partial class Form_dataGridView_Pacjenci : Form
    {
        public Form_dataGridView_Pacjenci()
        {
            InitializeComponent();
        }

        private void button_dodaj_pacjenta_Click(object sender, EventArgs e)
        {
            Przychodnia.Pacjent nowy_pacjent = new Przychodnia.Pacjent();
            Form_dodaj_edytuj_Pacjenta form_Dodaj_Edytuj_Pacjenta = new Form_dodaj_edytuj_Pacjenta(nowy_pacjent);
            if (form_Dodaj_Edytuj_Pacjenta.ShowDialog() == DialogResult.OK)
                Przychodnia.Pacjent.Lista_pacjentów.Add(nowy_pacjent);
            odśwież();
        }
        void odśwież()
        {
            dataGridView1.Rows.Clear();
            foreach (Przychodnia.Pacjent pacjent in Przychodnia.Pacjent.Lista_pacjentów)
            {
                int index = dataGridView1.Rows.Add(pacjent.Values);
                dataGridView1.Rows[index].Tag = pacjent;
            }
        }

        private void button_edytuj_pacjenta_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Brak pacjentów.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Przychodnia.Pacjent pacjent = (Przychodnia.Pacjent)dataGridView1.SelectedRows[0].Tag;
            Form_dodaj_edytuj_Pacjenta form_Dodaj_Edytuj_Pacjenta = new Form_dodaj_edytuj_Pacjenta(pacjent);
            form_Dodaj_Edytuj_Pacjenta.ShowDialog();
            odśwież();
        }

        private void button_usuń_pacjenta_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Brak pacjentów.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult msg = MessageBox.Show("Po wykonaniu tego polecenia nie będzie możliwe przywrócenie usuniętego pacjenta. " +
                        "Czy na pewno chcesz usunąć tego pacjenta?", "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (msg == DialogResult.Yes)
            {
                Przychodnia.Pacjent pacjent = (Przychodnia.Pacjent)dataGridView1.SelectedRows[0].Tag;
                Przychodnia.Pacjent.Lista_pacjentów.Remove(pacjent);
                odśwież();
            }
        }

        private void Form_dataGridView_Pacjenci_Load(object sender, EventArgs e)
        {
            odśwież();
        }
    }
}
