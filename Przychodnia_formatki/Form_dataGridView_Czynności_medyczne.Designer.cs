namespace Przychodnia_formatki
{
    partial class Form_dataGridView_Czynności_medyczne
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_usuń_czynność_medyczną = new System.Windows.Forms.Button();
            this.button_edytuj_czynność_medyczną = new System.Windows.Forms.Button();
            this.button_dodaj_czynność_medyczną = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(395, 172);
            this.dataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Czynności medyczne";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 300;
            // 
            // button_usuń_czynność_medyczną
            // 
            this.button_usuń_czynność_medyczną.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_usuń_czynność_medyczną.Location = new System.Drawing.Point(282, 201);
            this.button_usuń_czynność_medyczną.Name = "button_usuń_czynność_medyczną";
            this.button_usuń_czynność_medyczną.Size = new System.Drawing.Size(125, 48);
            this.button_usuń_czynność_medyczną.TabIndex = 19;
            this.button_usuń_czynność_medyczną.Text = "Usuń czynność medyczną";
            this.button_usuń_czynność_medyczną.UseVisualStyleBackColor = true;
            this.button_usuń_czynność_medyczną.Click += new System.EventHandler(this.button_usuń_czynność_medyczną_Click);
            // 
            // button_edytuj_czynność_medyczną
            // 
            this.button_edytuj_czynność_medyczną.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_edytuj_czynność_medyczną.Location = new System.Drawing.Point(151, 201);
            this.button_edytuj_czynność_medyczną.Name = "button_edytuj_czynność_medyczną";
            this.button_edytuj_czynność_medyczną.Size = new System.Drawing.Size(125, 48);
            this.button_edytuj_czynność_medyczną.TabIndex = 18;
            this.button_edytuj_czynność_medyczną.Text = "Edytuj czynność medyczną";
            this.button_edytuj_czynność_medyczną.UseVisualStyleBackColor = true;
            this.button_edytuj_czynność_medyczną.Click += new System.EventHandler(this.button_edytuj_czynność_medyczną_Click);
            // 
            // button_dodaj_czynność_medyczną
            // 
            this.button_dodaj_czynność_medyczną.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_dodaj_czynność_medyczną.Location = new System.Drawing.Point(12, 201);
            this.button_dodaj_czynność_medyczną.Name = "button_dodaj_czynność_medyczną";
            this.button_dodaj_czynność_medyczną.Size = new System.Drawing.Size(125, 48);
            this.button_dodaj_czynność_medyczną.TabIndex = 17;
            this.button_dodaj_czynność_medyczną.Text = "Dodaj czynność medyczną";
            this.button_dodaj_czynność_medyczną.UseVisualStyleBackColor = true;
            this.button_dodaj_czynność_medyczną.Click += new System.EventHandler(this.button_dodaj_czynność_medyczną_Click);
            // 
            // Form_dataGridView_Czynności_medyczne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 261);
            this.Controls.Add(this.button_usuń_czynność_medyczną);
            this.Controls.Add(this.button_edytuj_czynność_medyczną);
            this.Controls.Add(this.button_dodaj_czynność_medyczną);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_dataGridView_Czynności_medyczne";
            this.Text = "Dodaj_edytuj_Czynności_medyczne";
            this.Load += new System.EventHandler(this.Form_dataGridView_Czynności_medyczne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button_usuń_czynność_medyczną;
        private System.Windows.Forms.Button button_edytuj_czynność_medyczną;
        private System.Windows.Forms.Button button_dodaj_czynność_medyczną;
    }
}