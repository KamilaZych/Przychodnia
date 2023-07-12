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
    public partial class Form_dataGridView_Gabinety : Form
    {
        public Form_dataGridView_Gabinety()
        {
            InitializeComponent();
        }

        private void button_dodaj_gabinet_Click(object sender, EventArgs e)
        {
            Przychodnia.Gabinet nowy_gabinet = new Przychodnia.Gabinet();
            Form_dodaj_edytuj_Gabinet form_Dodaj_Edytuj_Gabinet = new Form_dodaj_edytuj_Gabinet(nowy_gabinet);
            if (form_Dodaj_Edytuj_Gabinet.ShowDialog() == DialogResult.OK)
                Przychodnia.Gabinet.Lista_gabinetów.Add(nowy_gabinet);
            odśwież();
        }
        void odśwież()
        {
            dataGridView1.Rows.Clear();
            foreach (Przychodnia.Gabinet gabinet in Przychodnia.Gabinet.Lista_gabinetów)
            {
                int index = dataGridView1.Rows.Add(gabinet.Values);
                dataGridView1.Rows[index].Tag = gabinet;
            }
        }

        private void button_edytuj_gabinet_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Brak gabinetów.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Przychodnia.Gabinet gabinet = (Przychodnia.Gabinet)dataGridView1.SelectedRows[0].Tag;
            Form_dodaj_edytuj_Gabinet form_Dodaj_Edytuj_Gabinet = new Form_dodaj_edytuj_Gabinet(gabinet);
            form_Dodaj_Edytuj_Gabinet.ShowDialog();
            odśwież();
        }

        private void button_usuń_gabinet_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Brak gabinetów.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult msg = MessageBox.Show("Po wykonaniu tego polecenia nie będzie możliwe przywrócenie usuniętego gabinetu. " +
                        "Czy na pewno chcesz usunąć ten gabinet?", "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (msg == DialogResult.Yes)
            {
                Przychodnia.Gabinet gabinet = (Przychodnia.Gabinet)dataGridView1.SelectedRows[0].Tag;
                Przychodnia.Gabinet.Lista_gabinetów.Remove(gabinet);
                odśwież();
            }
        }

        private void Form_dataGridView_Gabinety_Load(object sender, EventArgs e)
        {
            odśwież();
        }
    }
}
