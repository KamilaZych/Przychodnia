namespace Przychodnia_formatki
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_pracownicy = new System.Windows.Forms.Button();
            this.button_pacjenci = new System.Windows.Forms.Button();
            this.button_gabinety = new System.Windows.Forms.Button();
            this.button_czynności_medyczne = new System.Windows.Forms.Button();
            this.button_grafik = new System.Windows.Forms.Button();
            this.button_zaplanowane_wizyty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_pracownicy
            // 
            this.button_pracownicy.Location = new System.Drawing.Point(20, 103);
            this.button_pracownicy.Name = "button_pracownicy";
            this.button_pracownicy.Size = new System.Drawing.Size(344, 27);
            this.button_pracownicy.TabIndex = 0;
            this.button_pracownicy.Text = "Pracownicy";
            this.button_pracownicy.UseVisualStyleBackColor = true;
            this.button_pracownicy.Click += new System.EventHandler(this.button_pracownicy_Click);
            // 
            // button_pacjenci
            // 
            this.button_pacjenci.Location = new System.Drawing.Point(20, 143);
            this.button_pacjenci.Name = "button_pacjenci";
            this.button_pacjenci.Size = new System.Drawing.Size(344, 27);
            this.button_pacjenci.TabIndex = 1;
            this.button_pacjenci.Text = "Pacjenci";
            this.button_pacjenci.UseVisualStyleBackColor = true;
            this.button_pacjenci.Click += new System.EventHandler(this.button_pacjenci_Click);
            // 
            // button_gabinety
            // 
            this.button_gabinety.Location = new System.Drawing.Point(20, 64);
            this.button_gabinety.Name = "button_gabinety";
            this.button_gabinety.Size = new System.Drawing.Size(344, 27);
            this.button_gabinety.TabIndex = 2;
            this.button_gabinety.Text = "Gabinety";
            this.button_gabinety.UseVisualStyleBackColor = true;
            this.button_gabinety.Click += new System.EventHandler(this.button_gabinety_Click);
            // 
            // button_czynności_medyczne
            // 
            this.button_czynności_medyczne.Location = new System.Drawing.Point(20, 22);
            this.button_czynności_medyczne.Name = "button_czynności_medyczne";
            this.button_czynności_medyczne.Size = new System.Drawing.Size(344, 27);
            this.button_czynności_medyczne.TabIndex = 3;
            this.button_czynności_medyczne.Text = "Czynności medyczne";
            this.button_czynności_medyczne.UseVisualStyleBackColor = true;
            this.button_czynności_medyczne.Click += new System.EventHandler(this.button_czynności_medyczne_Click);
            // 
            // button_grafik
            // 
            this.button_grafik.Location = new System.Drawing.Point(20, 183);
            this.button_grafik.Name = "button_grafik";
            this.button_grafik.Size = new System.Drawing.Size(344, 27);
            this.button_grafik.TabIndex = 4;
            this.button_grafik.Text = "Grafik";
            this.button_grafik.UseVisualStyleBackColor = true;
            this.button_grafik.Click += new System.EventHandler(this.button_grafik_Click);
            // 
            // button_zaplanowane_wizyty
            // 
            this.button_zaplanowane_wizyty.Location = new System.Drawing.Point(20, 226);
            this.button_zaplanowane_wizyty.Name = "button_zaplanowane_wizyty";
            this.button_zaplanowane_wizyty.Size = new System.Drawing.Size(344, 27);
            this.button_zaplanowane_wizyty.TabIndex = 5;
            this.button_zaplanowane_wizyty.Text = "Zaplanowane wizyty";
            this.button_zaplanowane_wizyty.UseVisualStyleBackColor = true;
            this.button_zaplanowane_wizyty.Click += new System.EventHandler(this.button_zaplanowane_wizyty_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 268);
            this.Controls.Add(this.button_zaplanowane_wizyty);
            this.Controls.Add(this.button_grafik);
            this.Controls.Add(this.button_czynności_medyczne);
            this.Controls.Add(this.button_gabinety);
            this.Controls.Add(this.button_pacjenci);
            this.Controls.Add(this.button_pracownicy);
            this.Name = "Form1";
            this.Text = "Główna formatka";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_pracownicy;
        private System.Windows.Forms.Button button_pacjenci;
        private System.Windows.Forms.Button button_gabinety;
        private System.Windows.Forms.Button button_czynności_medyczne;
        private System.Windows.Forms.Button button_grafik;
        private System.Windows.Forms.Button button_zaplanowane_wizyty;
    }
}

