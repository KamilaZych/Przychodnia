namespace Przychodnia_formatki
{
    partial class Form_dataGridView_Grafik
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
            this.button_usuń_pozycję_w_grafiku = new System.Windows.Forms.Button();
            this.button_edytuj_pozycję_w_grafiku = new System.Windows.Forms.Button();
            this.button_dodaj_pozycję_w_grafiku = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_usuń_pozycję_w_grafiku
            // 
            this.button_usuń_pozycję_w_grafiku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_usuń_pozycję_w_grafiku.Location = new System.Drawing.Point(375, 275);
            this.button_usuń_pozycję_w_grafiku.Name = "button_usuń_pozycję_w_grafiku";
            this.button_usuń_pozycję_w_grafiku.Size = new System.Drawing.Size(162, 48);
            this.button_usuń_pozycję_w_grafiku.TabIndex = 31;
            this.button_usuń_pozycję_w_grafiku.Text = "Usuń pozycję w grafiku";
            this.button_usuń_pozycję_w_grafiku.UseVisualStyleBackColor = true;
            this.button_usuń_pozycję_w_grafiku.Click += new System.EventHandler(this.button_usuń_pozycję_w_grafiku_Click);
            // 
            // button_edytuj_pozycję_w_grafiku
            // 
            this.button_edytuj_pozycję_w_grafiku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_edytuj_pozycję_w_grafiku.Location = new System.Drawing.Point(194, 275);
            this.button_edytuj_pozycję_w_grafiku.Name = "button_edytuj_pozycję_w_grafiku";
            this.button_edytuj_pozycję_w_grafiku.Size = new System.Drawing.Size(162, 48);
            this.button_edytuj_pozycję_w_grafiku.TabIndex = 30;
            this.button_edytuj_pozycję_w_grafiku.Text = "Edytuj pozycję w grafiku";
            this.button_edytuj_pozycję_w_grafiku.UseVisualStyleBackColor = true;
            this.button_edytuj_pozycję_w_grafiku.Click += new System.EventHandler(this.button_edytuj_pozycję_w_grafiku_Click);
            // 
            // button_dodaj_pozycję_w_grafiku
            // 
            this.button_dodaj_pozycję_w_grafiku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_dodaj_pozycję_w_grafiku.Location = new System.Drawing.Point(12, 275);
            this.button_dodaj_pozycję_w_grafiku.Name = "button_dodaj_pozycję_w_grafiku";
            this.button_dodaj_pozycję_w_grafiku.Size = new System.Drawing.Size(162, 48);
            this.button_dodaj_pozycję_w_grafiku.TabIndex = 29;
            this.button_dodaj_pozycję_w_grafiku.Text = "Dodaj pozycję w grafiku";
            this.button_dodaj_pozycję_w_grafiku.UseVisualStyleBackColor = true;
            this.button_dodaj_pozycję_w_grafiku.Click += new System.EventHandler(this.button_dodaj_pozycję_w_grafiku_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(525, 252);
            this.dataGridView1.TabIndex = 28;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Pracownik";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Data rozpoczęcia pracy";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Data zakończenia pracy";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Numer gabinetu";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Form_dataGridView_Grafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 336);
            this.Controls.Add(this.button_usuń_pozycję_w_grafiku);
            this.Controls.Add(this.button_edytuj_pozycję_w_grafiku);
            this.Controls.Add(this.button_dodaj_pozycję_w_grafiku);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_dataGridView_Grafik";
            this.Text = "Grafik";
            this.Load += new System.EventHandler(this.Form_dataGridView_Grafik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_usuń_pozycję_w_grafiku;
        private System.Windows.Forms.Button button_edytuj_pozycję_w_grafiku;
        private System.Windows.Forms.Button button_dodaj_pozycję_w_grafiku;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}