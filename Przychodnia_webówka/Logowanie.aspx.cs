using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Przychodnia_webówka
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Przychodnia.Serializacja.SerializacjaForms(); 
            Label1.ForeColor = System.Drawing.Color.Red;
            Label1.Text = "Błąd logowania. Sprawdź poprawność danych logowania.";
            int sprawdzenie = 0;
            foreach (Przychodnia.Pacjent logowanie in Przychodnia.Pacjent.Lista_pacjentów)
            {
                if (logowanie.Adres_email.ToString() == TextBox_email_login.Text.ToString() && logowanie.Pesel.ToString() == TextBox_hasło.Text.ToString())
                {
                    Label1.ForeColor = System.Drawing.Color.Green;
                    Label1.Text = "Pomyślnie zalogowano.";
                        
                    
                }
                sprawdzenie++;
                if (Przychodnia.Pacjent.Lista_pacjentów.Count == sprawdzenie && Label1.Text != "Pomyślnie zalogowano.")
                {
                    Label1.ForeColor = System.Drawing.Color.Red;
                    Label1.Text = "Błąd logowania. Sprawdź poprawność danych logowania.";
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {

        }
    }
}