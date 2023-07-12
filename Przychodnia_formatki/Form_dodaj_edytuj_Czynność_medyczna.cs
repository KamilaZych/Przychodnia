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
    public partial class Form_dodaj_edytuj_Czynność_medyczna : Form
    {
        Przychodnia.Czynność_medyczna czynność_medyczna;
        internal Form_dodaj_edytuj_Czynność_medyczna(Przychodnia.Czynność_medyczna czynność_medyczna)
        {
            this.czynność_medyczna = czynność_medyczna;
            InitializeComponent();
        }

        private void Form_Czynność_medyczna_Load(object sender, EventArgs e)
        {
            textBox_czynność_medyczna.Text = czynność_medyczna.Nazwa_czynności_medycznej;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_czynność_medyczna.Text == "")
            {
                MessageBox.Show("Wprowadź nazwę czynności medycznej. ", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            czynność_medyczna.Nazwa_czynności_medycznej = textBox_czynność_medyczna.Text;

            foreach (Przychodnia.Czynność_medyczna czynność in Przychodnia.Czynność_medyczna.Lista_wszystkich_czynności_medycznych)
            {
                if (czynność_medyczna.Nazwa_czynności_medycznej == czynność.Nazwa_czynności_medycznej)
                {
                    MessageBox.Show("Ta czynność już jest na liście.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DialogResult = DialogResult.OK;
        }
    }
}
