namespace CSVLinqTestProjekt
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
            this.csv1BT = new System.Windows.Forms.Button();
            this.csv2BT = new System.Windows.Forms.Button();
            this.csv1TB = new System.Windows.Forms.TextBox();
            this.csv2TB = new System.Windows.Forms.TextBox();
            this.btWyswietlNaListe = new System.Windows.Forms.Button();
            this.csv1Dialog = new System.Windows.Forms.OpenFileDialog();
            this.csv2Dialog = new System.Windows.Forms.OpenFileDialog();
            this.lista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.SuspendLayout();
            // 
            // csv1BT
            // 
            this.csv1BT.Location = new System.Drawing.Point(13, 13);
            this.csv1BT.Name = "csv1BT";
            this.csv1BT.Size = new System.Drawing.Size(176, 29);
            this.csv1BT.TabIndex = 0;
            this.csv1BT.Text = "CSV1";
            this.csv1BT.UseVisualStyleBackColor = true;
            this.csv1BT.Click += new System.EventHandler(this.csv1BT_Click);
            // 
            // csv2BT
            // 
            this.csv2BT.Location = new System.Drawing.Point(13, 53);
            this.csv2BT.Name = "csv2BT";
            this.csv2BT.Size = new System.Drawing.Size(176, 29);
            this.csv2BT.TabIndex = 1;
            this.csv2BT.Text = "CSV2";
            this.csv2BT.UseVisualStyleBackColor = true;
            this.csv2BT.Click += new System.EventHandler(this.csv2BT_Click);
            // 
            // csv1TB
            // 
            this.csv1TB.Location = new System.Drawing.Point(205, 18);
            this.csv1TB.Name = "csv1TB";
            this.csv1TB.ReadOnly = true;
            this.csv1TB.Size = new System.Drawing.Size(237, 20);
            this.csv1TB.TabIndex = 2;
            // 
            // csv2TB
            // 
            this.csv2TB.Location = new System.Drawing.Point(205, 58);
            this.csv2TB.Name = "csv2TB";
            this.csv2TB.ReadOnly = true;
            this.csv2TB.Size = new System.Drawing.Size(237, 20);
            this.csv2TB.TabIndex = 3;
            // 
            // btWyswietlNaListe
            // 
            this.btWyswietlNaListe.Location = new System.Drawing.Point(13, 398);
            this.btWyswietlNaListe.Name = "btWyswietlNaListe";
            this.btWyswietlNaListe.Size = new System.Drawing.Size(139, 40);
            this.btWyswietlNaListe.TabIndex = 5;
            this.btWyswietlNaListe.Text = "Wczytaj na listę";
            this.btWyswietlNaListe.UseVisualStyleBackColor = true;
            this.btWyswietlNaListe.Click += new System.EventHandler(this.btWyswietlNaListe_Click);
            // 
            // csv1Dialog
            // 
            this.csv1Dialog.DefaultExt = "*.csv|Plik csv";
            this.csv1Dialog.FileName = "openFileDialog1";
            // 
            // csv2Dialog
            // 
            this.csv2Dialog.DefaultExt = "*.csv|Plik csv";
            this.csv2Dialog.FileName = "openFileDialog1";
            // 
            // lista
            // 
            this.lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista.Location = new System.Drawing.Point(13, 88);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(429, 304);
            this.lista.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.btWyswietlNaListe);
            this.Controls.Add(this.csv2TB);
            this.Controls.Add(this.csv1TB);
            this.Controls.Add(this.csv2BT);
            this.Controls.Add(this.csv1BT);
            this.Name = "Form1";
            this.Text = "CSV LINQ Test";
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button csv1BT;
        private System.Windows.Forms.Button csv2BT;
        private System.Windows.Forms.TextBox csv1TB;
        private System.Windows.Forms.TextBox csv2TB;
        private System.Windows.Forms.Button btWyswietlNaListe;
        private System.Windows.Forms.OpenFileDialog csv1Dialog;
        private System.Windows.Forms.OpenFileDialog csv2Dialog;
        private System.Windows.Forms.DataGridView lista;
    }
}

