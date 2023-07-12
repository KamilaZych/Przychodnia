namespace Przychodnia_formatki
{
    partial class Form_dodaj_edytuj_Grafik
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
            this.comboBox_gabinety = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_zakończenie = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_rozpoczęcie = new System.Windows.Forms.DateTimePicker();
            this.comboBox_pracownicy = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_gabinety);
            this.groupBox1.Controls.Add(this.dateTimePicker_zakończenie);
            this.groupBox1.Controls.Add(this.dateTimePicker_rozpoczęcie);
            this.groupBox1.Controls.Add(this.comboBox_pracownicy);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 318);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodawanie/edytowanie pozycji w grafiku";
            // 
            // comboBox_gabinety
            // 
            this.comboBox_gabinety.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gabinety.FormattingEnabled = true;
            this.comboBox_gabinety.Location = new System.Drawing.Point(15, 211);
            this.comboBox_gabinety.Name = "comboBox_gabinety";
            this.comboBox_gabinety.Size = new System.Drawing.Size(290, 21);
            this.comboBox_gabinety.TabIndex = 42;
            // 
            // dateTimePicker_zakończenie
            // 
            this.dateTimePicker_zakończenie.CustomFormat = "dddd, dd MMMM yyyy              H:00";
            this.dateTimePicker_zakończenie.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_zakończenie.Location = new System.Drawing.Point(15, 157);
            this.dateTimePicker_zakończenie.Name = "dateTimePicker_zakończenie";
            this.dateTimePicker_zakończenie.Size = new System.Drawing.Size(290, 20);
            this.dateTimePicker_zakończenie.TabIndex = 41;
            // 
            // dateTimePicker_rozpoczęcie
            // 
            this.dateTimePicker_rozpoczęcie.Checked = false;
            this.dateTimePicker_rozpoczęcie.CustomFormat = "dddd, dd MMMM yyyy              H:00";
            this.dateTimePicker_rozpoczęcie.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_rozpoczęcie.Location = new System.Drawing.Point(15, 103);
            this.dateTimePicker_rozpoczęcie.Name = "dateTimePicker_rozpoczęcie";
            this.dateTimePicker_rozpoczęcie.Size = new System.Drawing.Size(290, 20);
            this.dateTimePicker_rozpoczęcie.TabIndex = 40;
            // 
            // comboBox_pracownicy
            // 
            this.comboBox_pracownicy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_pracownicy.FormattingEnabled = true;
            this.comboBox_pracownicy.Location = new System.Drawing.Point(15, 53);
            this.comboBox_pracownicy.Name = "comboBox_pracownicy";
            this.comboBox_pracownicy.Size = new System.Drawing.Size(290, 21);
            this.comboBox_pracownicy.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(185, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 41);
            this.button1.TabIndex = 38;
            this.button1.Text = "Anuluj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 41);
            this.button2.TabIndex = 37;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Wybierz numer gabinetu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Data i godzina zakończenia pracy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Data i godzina rozpoczęcia pracy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Wybierz pracownika";
            // 
            // Form_dodaj_edytuj_Grafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 341);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_dodaj_edytuj_Grafik";
            this.Text = "Dodaj/edytuj grafik";
            this.Load += new System.EventHandler(this.Form_dodaj_edytuj_Grafik_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_gabinety;
        private System.Windows.Forms.DateTimePicker dateTimePicker_zakończenie;
        private System.Windows.Forms.DateTimePicker dateTimePicker_rozpoczęcie;
        private System.Windows.Forms.ComboBox comboBox_pracownicy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}