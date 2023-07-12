namespace Przychodnia_formatki
{
    partial class Form_dataGridView_Gabinety
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
            this.button_usuń_gabinet = new System.Windows.Forms.Button();
            this.button_edytuj_gabinet = new System.Windows.Forms.Button();
            this.button_dodaj_gabinet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_usuń_gabinet
            // 
            this.button_usuń_gabinet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_usuń_gabinet.Location = new System.Drawing.Point(16, 143);
            this.button_usuń_gabinet.Name = "button_usuń_gabinet";
            this.button_usuń_gabinet.Size = new System.Drawing.Size(214, 38);
            this.button_usuń_gabinet.TabIndex = 23;
            this.button_usuń_gabinet.Text = "Usuń gabinet";
            this.button_usuń_gabinet.UseVisualStyleBackColor = true;
            this.button_usuń_gabinet.Click += new System.EventHandler(this.button_usuń_gabinet_Click);
            // 
            // button_edytuj_gabinet
            // 
            this.button_edytuj_gabinet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_edytuj_gabinet.Location = new System.Drawing.Point(16, 78);
            this.button_edytuj_gabinet.Name = "button_edytuj_gabinet";
            this.button_edytuj_gabinet.Size = new System.Drawing.Size(214, 38);
            this.button_edytuj_gabinet.TabIndex = 22;
            this.button_edytuj_gabinet.Text = "Edytuj gabinet";
            this.button_edytuj_gabinet.UseVisualStyleBackColor = true;
            this.button_edytuj_gabinet.Click += new System.EventHandler(this.button_edytuj_gabinet_Click);
            // 
            // button_dodaj_gabinet
            // 
            this.button_dodaj_gabinet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_dodaj_gabinet.Location = new System.Drawing.Point(16, 15);
            this.button_dodaj_gabinet.Name = "button_dodaj_gabinet";
            this.button_dodaj_gabinet.Size = new System.Drawing.Size(214, 38);
            this.button_dodaj_gabinet.TabIndex = 21;
            this.button_dodaj_gabinet.Text = "Dodaj gabinet";
            this.button_dodaj_gabinet.UseVisualStyleBackColor = true;
            this.button_dodaj_gabinet.Click += new System.EventHandler(this.button_dodaj_gabinet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(254, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(141, 172);
            this.dataGridView1.TabIndex = 20;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numer gabinetu";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Form_dataGridView_Gabinety
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 201);
            this.Controls.Add(this.button_usuń_gabinet);
            this.Controls.Add(this.button_edytuj_gabinet);
            this.Controls.Add(this.button_dodaj_gabinet);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_dataGridView_Gabinety";
            this.Text = "Dodaj_edytuj_Gabinety";
            this.Load += new System.EventHandler(this.Form_dataGridView_Gabinety_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_usuń_gabinet;
        private System.Windows.Forms.Button button_edytuj_gabinet;
        private System.Windows.Forms.Button button_dodaj_gabinet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}