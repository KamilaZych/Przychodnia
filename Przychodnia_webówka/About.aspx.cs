using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Przychodnia_webówka
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*Przychodnia.Serializacja.SerializacjaForms();
            foreach (Przychodnia.Pracownik pracownik in Przychodnia.Pracownik.Lista_pracowników)
            {
                
                DropDownList1.Items.Add(pracownik.ToString());
                foreach (string czynność in pracownik.Lista_czynności_medycznych_danego_lekarza)
                {
                    DropDownList2.Items.Add(czynność);
                }

                int sprawdzenie = 0;
                int minuty = 0;
                int ilość_minut;
                foreach (Przychodnia.Grafik grafik in Przychodnia.Grafik.Lista_grafik)
                {
                    if (pracownik.ToString() == grafik.Pracownik.ToString())
                    {
                        DropDownList3.Items.Add(grafik.Data_rozpoczęcia_pracy.ToShortDateString());
                        ilość_minut = (grafik.Data_zakończenia_pracy.Hour - grafik.Data_rozpoczęcia_pracy.Hour) * 60;
                        int godziny = grafik.Data_rozpoczęcia_pracy.Hour;

                        for (sprawdzenie = 0; sprawdzenie <= ilość_minut; sprawdzenie = sprawdzenie + 10)
                        {

                            if (minuty == 0)
                            {
                                DropDownList4.Items.Add(godziny.ToString() + ":" + minuty.ToString() + "0");
                                minuty = minuty + 10;
                            }
                            else
                            {
                                DropDownList4.Items.Add(godziny.ToString() + ":" + minuty.ToString());
                                minuty = minuty + 10;
                            }

                            if (minuty == 60)
                            {
                                minuty = 0;
                                godziny = godziny + 1;
                            }                           
                        }
                        
                        foreach (Przychodnia.Zaplanowana_wizyta wizyta in Przychodnia.Zaplanowana_wizyta.Lista_zaplanowanych_wizyt)
                        {
                            if (wizyta.Godzina_wizyty != (godziny.ToString() + ":" + minuty.ToString() + "0") || wizyta.Godzina_wizyty != (godziny.ToString() + ":" + minuty.ToString()))
                            {
                                DropDownList4.Items.Remove(wizyta.Godzina_wizyty);
                            }
                        }
                    }
                }
            }*/
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*Przychodnia.Zaplanowana_wizyta nowa_wizyta = new Przychodnia.Zaplanowana_wizyta();
            
            nowa_wizyta.Pracownik = DropDownList1.SelectedItem.Value;
            nowa_wizyta.Czynność_medyczna = DropDownList2.SelectedItem.Value;
            nowa_wizyta.Data_wizyty = DropDownList3.SelectedItem.Value;
            nowa_wizyta.Godzina_wizyty = DropDownList4.SelectedItem.Value;
            foreach(Przychodnia.Grafik grafik in Przychodnia.Grafik.Lista_grafik)
            {
                if(grafik.Pracownik.ToString()==nowa_wizyta.Pracownik && grafik.Data_rozpoczęcia_pracy.ToShortDateString() == nowa_wizyta.Data_wizyty)
                {
                    nowa_wizyta.Numer_gabinetu = grafik.Numer_gabinetu;
                }
            }
            Przychodnia.Zaplanowana_wizyta.Lista_zaplanowanych_wizyt.Add(nowa_wizyta);*/
        }
    }
}