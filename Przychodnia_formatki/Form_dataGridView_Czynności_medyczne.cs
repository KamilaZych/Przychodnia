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
    public partial class Form_dataGridView_Czynności_medyczne : Form
    {
        public Form_dataGridView_Czynności_medyczne()
        {
            InitializeComponent();
        }

        private void button_dodaj_czynność_medyczną_Click(object sender, EventArgs e)
        {
            Przychodnia.Czynność_medyczna nowa_czynność_medyczna = new Przychodnia.Czynność_medyczna();
            Form_dodaj_edytuj_Czynność_medyczna form_Dodaj_Edytuj_Czynność_Medyczna = new Form_dodaj_edytuj_Czynność_medyczna(nowa_czynność_medyczna);
            if (form_Dodaj_Edytuj_Czynność_Medyczna.ShowDialog() == DialogResult.OK)
                Przychodnia.Czynność_medyczna.Lista_wszystkich_czynności_medycznych.Add(nowa_czynność_medyczna);
            odśwież();
        }
        void odśwież()
        {
            dataGridView1.Rows.Clear();
            foreach (Przychodnia.Czynność_medyczna czynność_medyczna in Przychodnia.Czynność_medyczna.Lista_wszystkich_czynności_medycznych)
            {
                int index = dataGridView1.Rows.Add(czynność_medyczna.Values);
                dataGridView1.Rows[index].Tag = czynność_medyczna;
            }
        }

        private void button_edytuj_czynność_medyczną_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Brak czynności medycznych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Przychodnia.Czynność_medyczna czynność_medyczna = (Przychodnia.Czynność_medyczna)dataGridView1.SelectedRows[0].Tag;
            Form_dodaj_edytuj_Czynność_medyczna form = new Form_dodaj_edytuj_Czynność_medyczna(czynność_medyczna);
            form.ShowDialog();
            odśwież();
        }

        private void button_usuń_czynność_medyczną_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Brak czynności medycznych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult msg = MessageBox.Show("Po wykonaniu tego polecenia nie będzie możliwe przywrócenie usuniętej czynności medycznej. " +
                        "Czy na pewno chcesz usunąć tą czynność medyczną?", "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (msg == DialogResult.Yes)
            {
                Przychodnia.Czynność_medyczna czynność_medyczna = (Przychodnia.Czynność_medyczna)dataGridView1.SelectedRows[0].Tag;
                Przychodnia.Czynność_medyczna.Lista_wszystkich_czynności_medycznych.Remove(czynność_medyczna);
                odśwież();
            }
        }

        private void Form_dataGridView_Czynności_medyczne_Load(object sender, EventArgs e)
        {
            odśwież();
        }
    }
}
