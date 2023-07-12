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
    public partial class Form_dodaj_edytuj_Gabinet : Form
    {
        Przychodnia.Gabinet gabinet;
        internal Form_dodaj_edytuj_Gabinet(Przychodnia.Gabinet gabinet)
        {
            this.gabinet = gabinet;
            InitializeComponent();
        }

        private void Form_dodaj_edytuj_Gabinet_Load(object sender, EventArgs e)
        {
            numericUpDown_numer_gabinetu.Value = gabinet.Numer_gabinetu;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numericUpDown_numer_gabinetu.Value == 0)
            {
                MessageBox.Show("Wprowadź numer gabinetu. ", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            gabinet.Numer_gabinetu = (int)numericUpDown_numer_gabinetu.Value;

            foreach (Przychodnia.Gabinet numer_gabinetu in Przychodnia.Gabinet.Lista_gabinetów)
            {
                if(gabinet.Numer_gabinetu == numer_gabinetu.Numer_gabinetu)
                {
                    MessageBox.Show("Już jest dodany ten numer gabinetu. ", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DialogResult = DialogResult.OK;
        }
    }
}
