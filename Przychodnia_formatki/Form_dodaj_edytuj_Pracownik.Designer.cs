namespace Przychodnia_formatki
{
    partial class Form_dodaj_edytuj_Pracownik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_czynności_medyczne = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox_czynności_medyczne = new System.Windows.Forms.ListBox();
            this.textBox_rok_rozpoczęcia_pracy = new System.Windows.Forms.TextBox();
            this.textBox_nazwisko = new System.Windows.Forms.TextBox();
            this.textBox_imię = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_czynności_medyczne);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.listBox_czynności_medyczne);
            this.groupBox1.Controls.Add(this.textBox_rok_rozpoczęcia_pracy);
            this.groupBox1.Controls.Add(this.textBox_nazwisko);
            this.groupBox1.Controls.Add(this.textBox_imię);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 555);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodawanie/edytowanie pracownika";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(162, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 41);
            this.button1.TabIndex = 38;
            this.button1.Text = "Anuluj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 496);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 41);
            this.button2.TabIndex = 37;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Wybierz czynność medyczną ";
            // 
            // comboBox_czynności_medyczne
            // 
            this.comboBox_czynności_medyczne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_czynności_medyczne.FormattingEnabled = true;
            this.comboBox_czynności_medyczne.Location = new System.Drawing.Point(15, 205);
            this.comboBox_czynności_medyczne.Name = "comboBox_czynności_medyczne";
            this.comboBox_czynności_medyczne.Size = new System.Drawing.Size(260, 21);
            this.comboBox_czynności_medyczne.TabIndex = 35;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 439);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(260, 30);
            this.button4.TabIndex = 34;
            this.button4.Text = "Usuń zaznaczoną czynność medyczną";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Rok rozpoczęcia pracy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Nazwisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Imię";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 30);
            this.button3.TabIndex = 24;
            this.button3.Text = "Dodaj zaznaczoną czynność medyczną";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox_czynności_medyczne
            // 
            this.listBox_czynności_medyczne.FormattingEnabled = true;
            this.listBox_czynności_medyczne.Location = new System.Drawing.Point(15, 289);
            this.listBox_czynności_medyczne.Name = "listBox_czynności_medyczne";
            this.listBox_czynności_medyczne.Size = new System.Drawing.Size(260, 134);
            this.listBox_czynności_medyczne.TabIndex = 22;
            // 
            // textBox_rok_rozpoczęcia_pracy
            // 
            this.textBox_rok_rozpoczęcia_pracy.Location = new System.Drawing.Point(15, 152);
            this.textBox_rok_rozpoczęcia_pracy.Name = "textBox_rok_rozpoczęcia_pracy";
            this.textBox_rok_rozpoczęcia_pracy.Size = new System.Drawing.Size(260, 20);
            this.textBox_rok_rozpoczęcia_pracy.TabIndex = 18;
            // 
            // textBox_nazwisko
            // 
            this.textBox_nazwisko.Location = new System.Drawing.Point(15, 100);
            this.textBox_nazwisko.Name = "textBox_nazwisko";
            this.textBox_nazwisko.Size = new System.Drawing.Size(260, 20);
            this.textBox_nazwisko.TabIndex = 16;
            // 
            // textBox_imię
            // 
            this.textBox_imię.Location = new System.Drawing.Point(15, 53);
            this.textBox_imię.Name = "textBox_imię";
            this.textBox_imię.Size = new System.Drawing.Size(260, 20);
            this.textBox_imię.TabIndex = 15;
            // 
            // Form_dodaj_edytuj_Pracownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 580);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_dodaj_edytuj_Pracownik";
            this.Text = "Form_dodaj_edytuj_Pracownik";
            this.Load += new System.EventHandler(this.Form_dodaj_edytuj_Pracownik_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_czynności_medyczne;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox_czynności_medyczne;
        private System.Windows.Forms.TextBox textBox_rok_rozpoczęcia_pracy;
        private System.Windows.Forms.TextBox textBox_nazwisko;
        private System.Windows.Forms.TextBox textBox_imię;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}