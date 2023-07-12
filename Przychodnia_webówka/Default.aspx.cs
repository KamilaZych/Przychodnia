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
            Przychodnia.Serializacja.SerializacjaWeb();
            Label3.Text = "Zaloguj się, aby zobaczyć zaplanowane wizyty.";
            TextBox_hasło.TextMode = TextBoxMode.Password;
        }

        protected void Button1_Click(object sender, EventArgs e) // Zaloguj
        {
            if (Label1.Text == "Pomyślnie zalogowano.")
            {
                Label4.ForeColor = System.Drawing.Color.Orange;
                Label4.Text = "Już jesteś zalogowany!";
                odśwież();
                return;
            }

            int sprawdzenie = 0;
            foreach (Przychodnia.Pacjent logowanie in Przychodnia.Pacjent.Lista_pacjentów)
            {
                if ((logowanie.Adres_email.ToString() == TextBox_email_login.Text || logowanie.Adres_email.ToString() == TextBox_email_login.Text.ToLower()) && logowanie.Pesel == TextBox_hasło.Text)
                {
                    Label1.ForeColor = System.Drawing.Color.Green;
                    Label1.Text = "Pomyślnie zalogowano.";
                    Label7.Text = logowanie.ToString();
                    TextBox_email_login.Text = string.Empty;
                    TextBox_hasło.Text = string.Empty;
                    Label6.Visible = true;
                    Label4.Text = string.Empty;
                    Label_Umów_się.Visible = true;
                    Label_Czynność.Visible = true;
                    DropDownList2.Visible = true;
                    Button3.Visible = true;

                    DropDownList2.Items.Clear();
                    if (DropDownList2.Items.Count == 0)
                    {
                        foreach (Przychodnia.Czynność_medyczna czynność_medyczna in Przychodnia.Czynność_medyczna.Lista_wszystkich_czynności_medycznych)
                        {
                            DropDownList2.Items.Add(czynność_medyczna.Nazwa_czynności_medycznej);
                        }
                    }

                    odśwież();
                }
                sprawdzenie++;
                if (Przychodnia.Pacjent.Lista_pacjentów.Count == sprawdzenie && Label1.Text != "Pomyślnie zalogowano.")
                {
                    Label1.ForeColor = System.Drawing.Color.Red;
                    Label1.Text = "Błąd logowania. Sprawdź poprawność danych logowania.";
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click1(object sender, EventArgs e) //Umów się na wizytę
        {
            if (Label1.Text != "Pomyślnie zalogowano.")
            {
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Text = "Należy najpierw się zalogować.";
                return;
            }

            Przychodnia.Zaplanowana_wizyta nowa_wizyta = new Przychodnia.Zaplanowana_wizyta();
            foreach (Przychodnia.Pacjent pacjent in Przychodnia.Pacjent.Lista_pacjentów)
            {
                if (pacjent.ToString() == Label7.Text)
                {
                    nowa_wizyta.Pacjent = pacjent;
                }
            }
            nowa_wizyta.Pracownik = DropDownList1.SelectedItem.Value;
            nowa_wizyta.Czynność_medyczna = DropDownList2.SelectedItem.Value;
            nowa_wizyta.Data_wizyty = Convert.ToDateTime(DropDownList3.SelectedItem.Value);
            nowa_wizyta.Godzina_wizyty = Convert.ToDateTime(DropDownList4.SelectedItem.Value);
            foreach (Przychodnia.Grafik grafik in Przychodnia.Grafik.Lista_grafik)
            {
                if (grafik.Pracownik.ToString() == nowa_wizyta.Pracownik && grafik.Data_rozpoczęcia_pracy.ToShortDateString() == nowa_wizyta.Data_wizyty.ToShortDateString())
                {
                    nowa_wizyta.Numer_gabinetu = grafik.Numer_gabinetu;
                }
            }
            Label2.ForeColor = System.Drawing.Color.Green;
            Label2.Text = "Zapisałeś się na wizytę do gabinetu nr. " + nowa_wizyta.Numer_gabinetu.ToString() + ", " + nowa_wizyta.Data_wizyty.ToShortDateString()
                        + " na godzinę " + nowa_wizyta.Godzina_wizyty.ToString() + " do lekarza " + nowa_wizyta.Pracownik.ToString() + " na czynność medyczną: " + nowa_wizyta.Czynność_medyczna.ToString(); ;
            Przychodnia.Zaplanowana_wizyta.Lista_zaplanowanych_wizyt.Add(nowa_wizyta);
            Przychodnia.Serializacja.DeserializacjaWeb();

            DropDownList1.Visible = false;
            Button4.Visible = false;
            Label_Lekarz.Visible = false;
            DropDownList3.Visible = false;
            Button5.Visible = false;
            DropDownList4.Visible = false;
            Label_godzina.Visible = false;
            Button2.Visible = false;
            Label_Dzień.Visible = false;
            Label2.Visible=false;

            odśwież();
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox_hasło_TextChanged(object sender, EventArgs e)
        {

        }
        void odśwież()
        {
            Label3.Text = string.Empty;

            foreach (Przychodnia.Zaplanowana_wizyta zaplanowana_Wizyta in Przychodnia.Zaplanowana_wizyta.Lista_zaplanowanych_wizyt)
            {
                foreach (Przychodnia.Pacjent pacjent in Przychodnia.Pacjent.Lista_pacjentów)
                {
                    if (pacjent.ToString() == Label7.Text && pacjent.ToString() == zaplanowana_Wizyta.Pacjent.ToString())
                    {
                        Label3.Text += "Masz wizytę w gabinecie nr. " + zaplanowana_Wizyta.Numer_gabinetu.ToString() + ", " + zaplanowana_Wizyta.Data_wizyty.ToShortDateString()
                                    + " na godzinę " + zaplanowana_Wizyta.Godzina_wizyty.ToString() + " do lekarza " + zaplanowana_Wizyta.Pracownik.ToString() + " na czynność medyczną: " + zaplanowana_Wizyta.Czynność_medyczna.ToString()+".<p>";
                    }
                }
            }

            if (Label3.Text == string.Empty)
            {
                Label3.Text = "Nie masz jeszcze zaplanowanych wizyt.";
            }
        }

        protected void DropDownList1_TextChanged(object sender, EventArgs e)
        {


        }

        protected void DropDownList2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click1(object sender, EventArgs e) //Wybierz dla czynności
        {
            Label2.Text = string.Empty;
            if (Label1.Text != "Pomyślnie zalogowano.")
            {
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Text = "Należy najpierw się zalogować.";
                return;
            }

            DropDownList1.Items.Clear();
            if (DropDownList2.SelectedItem != null)
            {
                foreach (Przychodnia.Pracownik pracownik in Przychodnia.Pracownik.Lista_pracowników)
                {
                    foreach (string czynność in pracownik.Lista_czynności_medycznych_danego_lekarza)
                    {
                        if (DropDownList2.SelectedItem.Value == czynność)
                        {
                            DropDownList1.Items.Add(pracownik.ToString());
                        }
                    }
                }
            }
            odśwież();
            DropDownList1.Visible = true;
            Button4.Visible = true;
            Label_Lekarz.Visible = true;
        }

        protected void Button4_Click(object sender, EventArgs e) //Wybierz dla pracownika
        {
            if (Label1.Text != "Pomyślnie zalogowano.")
            {
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Text = "Należy najpierw się zalogować.";
                return;
            }

            DropDownList3.Items.Clear();
            if (DropDownList1.SelectedItem != null)
            {
                foreach (Przychodnia.Pracownik pracownik in Przychodnia.Pracownik.Lista_pracowników)
                {
                    if (DropDownList1.SelectedItem.Value == pracownik.ToString())
                    {
                        foreach (Przychodnia.Grafik grafik in Przychodnia.Grafik.Lista_grafik)
                        {
                            if (pracownik.ToString() == grafik.Pracownik.ToString() && DropDownList1.SelectedItem.Value == pracownik.ToString())
                            {
                                DropDownList3.Items.Add(grafik.Data_rozpoczęcia_pracy.ToShortDateString());
                            }
                        }
                    }
                }
            }
            odśwież();
            DropDownList3.Visible = true;
            Button5.Visible = true;
            Label_Dzień.Visible = true;
        }

        protected void Button5_Click(object sender, EventArgs e) //Wybierz dla daty
        {
            if (Label1.Text != "Pomyślnie zalogowano.")
            {
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Text = "Należy najpierw się zalogować.";
                return;
            }

            DropDownList4.Items.Clear();
            if (DropDownList3.SelectedItem != null)
            {
                foreach (Przychodnia.Pracownik pracownik in Przychodnia.Pracownik.Lista_pracowników)
                {
                    int sprawdzenie = 0;
                    int minuty = 0;
                    int ilość_minut;
                    foreach (Przychodnia.Grafik grafik in Przychodnia.Grafik.Lista_grafik)
                    {
                        if (pracownik.ToString() == grafik.Pracownik.ToString() && DropDownList1.SelectedItem.Value == pracownik.ToString()
                           && grafik.Data_rozpoczęcia_pracy.ToShortDateString() == DropDownList3.SelectedItem.Value)
                        {
                            ilość_minut = (grafik.Data_zakończenia_pracy.Hour - grafik.Data_rozpoczęcia_pracy.Hour) * 60;
                            int godziny = grafik.Data_rozpoczęcia_pracy.Hour;

                            for (sprawdzenie = 0; sprawdzenie <= ilość_minut; sprawdzenie += 10)
                            {
                                if (minuty == 0)
                                {
                                    DropDownList4.Items.Add(godziny.ToString() + ":" + minuty.ToString() + "0");
                                    minuty += 10;
                                }
                                else
                                {
                                    DropDownList4.Items.Add(godziny.ToString() + ":" + minuty.ToString());
                                    minuty += 10;
                                }
                                if (minuty == 60)
                                {
                                    minuty = 0;
                                    godziny += 1;
                                }
                            }

                            foreach (Przychodnia.Zaplanowana_wizyta wizyta in Przychodnia.Zaplanowana_wizyta.Lista_zaplanowanych_wizyt)
                            {
                                if (grafik.Pracownik.ToString() == wizyta.Pracownik)
                                {
                                    if (wizyta.Godzina_wizyty.ToShortTimeString() != (godziny.ToString() + ":" + minuty.ToString() + "0") || wizyta.Godzina_wizyty.ToShortTimeString() != (godziny.ToString() + ":" + minuty.ToString()))
                                    {
                                        DropDownList4.Items.Remove(wizyta.Godzina_wizyty.ToShortTimeString());
                                    }
                                }
                            }
                        }
                    }
                }
            }
            odśwież();
            DropDownList4.Visible = true;
            Button6.Visible = true;
            Label_godzina.Visible = true;
            Button2.Visible = true;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if (Label1.Text == "Pomyślnie zalogowano.")
            {
                DropDownList1.Items.Clear();
                DropDownList2.Items.Clear();
                DropDownList3.Items.Clear();
                DropDownList4.Items.Clear();
                TextBox_email_login.Text = string.Empty;
                TextBox_hasło.Text = string.Empty;

                Label1.Text = string.Empty;
                Label7.Text = string.Empty;
                Label6.Visible = false;
                Label_Czynność.Visible = false;
                Label_Umów_się.Visible=false;
                Label_Lekarz.Visible = false;
                Label_godzina.Visible = false;
                Label_Dzień.Visible = false;
                DropDownList1.Visible = false;
                DropDownList2.Visible = false;
                DropDownList3.Visible = false;
                DropDownList4.Visible = false;
                Button2.Visible = false;
                Button3.Visible = false;
                Button4.Visible = false;
                Button5.Visible = false;         
                
                Label1.ForeColor = System.Drawing.Color.Green;
                Label1.Text = "Zostałeś pomyślnie wylogowany.";
            }
            else
            {
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Text = "Nie jesteś zalogowany!";
            }
        } //Wyloguj
    }
}

    
