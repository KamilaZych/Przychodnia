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
    public partial class Form_dataGridView_Grafik : Form
    {
        public Form_dataGridView_Grafik()
        {
            InitializeComponent();
        }

        private void Form_dataGridView_Grafik_Load(object sender, EventArgs e)
        {
            odśwież();
        }
        void odśwież()
        {
            dataGridView1.Rows.Clear();
            foreach (Przychodnia.Grafik grafik in Przychodnia.Grafik.Lista_grafik)
            {
                int index = dataGridView1.Rows.Add(grafik.Values);
                dataGridView1.Rows[index].Tag = grafik;
            }
        }

        private void button_dodaj_pozycję_w_grafiku_Click(object sender, EventArgs e)
        {
            Przychodnia.Grafik nowy_wpis_w_grafiku = new Przychodnia.Grafik();
            Form_dodaj_edytuj_Grafik form_Dodaj_Edytuj_Grafik = new Form_dodaj_edytuj_Grafik(nowy_wpis_w_grafiku);
            if (form_Dodaj_Edytuj_Grafik.ShowDialog() == DialogResult.OK)
                Przychodnia.Grafik.Lista_grafik.Add(nowy_wpis_w_grafiku);
            odśwież();
        }

        private void button_edytuj_pozycję_w_grafiku_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Brak pozycji w grafiku.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Przychodnia.Grafik grafik = (Przychodnia.Grafik)dataGridView1.SelectedRows[0].Tag;
            Form_dodaj_edytuj_Grafik form_Dodaj_Edytuj_Grafik = new Form_dodaj_edytuj_Grafik(grafik);
            form_Dodaj_Edytuj_Grafik.ShowDialog();
            odśwież();
        }

        private void button_usuń_pozycję_w_grafiku_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Brak pozycji w grafiku.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult msg = MessageBox.Show("Po wykonaniu tego polecenia nie będzie możliwe przywrócenie usuniętej pozycji w grafiku. " +
                        "Czy na pewno chcesz usunąć tą pozycję?", "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (msg == DialogResult.Yes)
            {
                Przychodnia.Grafik grafik = (Przychodnia.Grafik)dataGridView1.SelectedRows[0].Tag;
                Przychodnia.Grafik.Lista_grafik.Remove(grafik);
                odśwież();
            }
        }
    }
}
