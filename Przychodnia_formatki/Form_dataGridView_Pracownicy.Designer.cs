namespace Przychodnia_formatki
{
    partial class Form_dataGridView_Pracownicy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_usuń_pracownika = new System.Windows.Forms.Button();
            this.button_edytuj_pracownika = new System.Windows.Forms.Button();
            this.button_dodaj_pracownika = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_usuń_pracownika
            // 
            this.button_usuń_pracownika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_usuń_pracownika.Location = new System.Drawing.Point(476, 299);
            this.button_usuń_pracownika.Name = "button_usuń_pracownika";
            this.button_usuń_pracownika.Size = new System.Drawing.Size(205, 48);
            this.button_usuń_pracownika.TabIndex = 27;
            this.button_usuń_pracownika.Text = "Usuń pracownika";
            this.button_usuń_pracownika.UseVisualStyleBackColor = true;
            this.button_usuń_pracownika.Click += new System.EventHandler(this.button_usuń_pracownika_Click);
            // 
            // button_edytuj_pracownika
            // 
            this.button_edytuj_pracownika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_edytuj_pracownika.Location = new System.Drawing.Point(244, 299);
            this.button_edytuj_pracownika.Name = "button_edytuj_pracownika";
            this.button_edytuj_pracownika.Size = new System.Drawing.Size(205, 48);
            this.button_edytuj_pracownika.TabIndex = 26;
            this.button_edytuj_pracownika.Text = "Edytuj pracownika";
            this.button_edytuj_pracownika.UseVisualStyleBackColor = true;
            this.button_edytuj_pracownika.Click += new System.EventHandler(this.button_edytuj_pracownika_Click);
            // 
            // button_dodaj_pracownika
            // 
            this.button_dodaj_pracownika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_dodaj_pracownika.Location = new System.Drawing.Point(12, 299);
            this.button_dodaj_pracownika.Name = "button_dodaj_pracownika";
            this.button_dodaj_pracownika.Size = new System.Drawing.Size(205, 48);
            this.button_dodaj_pracownika.TabIndex = 25;
            this.button_dodaj_pracownika.Text = "Dodaj pracownika";
            this.button_dodaj_pracownika.UseVisualStyleBackColor = true;
            this.button_dodaj_pracownika.Click += new System.EventHandler(this.button_dodaj_pracownika_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(669, 274);
            this.dataGridView1.TabIndex = 24;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Imię";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Nazwisko";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column4
            // 
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "Rok rozpoczęcia pracy";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column3
            // 
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column3.HeaderText = "Czynności medyczne do których posiada uprawnienia";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 350;
            // 
            // Form_dataGridView_Pracownicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 360);
            this.Controls.Add(this.button_usuń_pracownika);
            this.Controls.Add(this.button_edytuj_pracownika);
            this.Controls.Add(this.button_dodaj_pracownika);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_dataGridView_Pracownicy";
            this.Text = "Dodaj_edytuj_Pracownicy";
            this.Load += new System.EventHandler(this.Form_dataGridView_Pracownicy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_usuń_pracownika;
        private System.Windows.Forms.Button button_edytuj_pracownika;
        private System.Windows.Forms.Button button_dodaj_pracownika;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}