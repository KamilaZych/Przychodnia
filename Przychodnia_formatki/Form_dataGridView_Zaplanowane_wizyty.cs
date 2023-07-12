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
    public partial class Form_dataGridView_Zaplanowane_wizyty : Form
    {
        public Form_dataGridView_Zaplanowane_wizyty()
        {
            InitializeComponent();
        }

        private void Form_dataGridView_Zaplanowane_wizyty_Load(object sender, EventArgs e)
        {
            odśwież();
        }
        void odśwież()
        {
            dataGridView1.Rows.Clear();
            foreach (Przychodnia.Zaplanowana_wizyta zaplanowana_Wizyta in Przychodnia.Zaplanowana_wizyta.Lista_zaplanowanych_wizyt)
            {
                int index = dataGridView1.Rows.Add(zaplanowana_Wizyta.Values);
                dataGridView1.Rows[index].Tag = zaplanowana_Wizyta;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Przychodnia.Zaplanowana_wizyta zaplanowana_Wizyta = (Przychodnia.Zaplanowana_wizyta)dataGridView1.SelectedRows[0].Tag;
            Przychodnia.Zaplanowana_wizyta.Lista_zaplanowanych_wizyt.Remove(zaplanowana_Wizyta);
            odśwież();
        }
    }
}
