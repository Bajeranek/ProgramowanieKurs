using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration;
using CSVLinqTestProjekt.DTO;

namespace CSVLinqTestProjekt
{
    public partial class Form1 : Form
    {
        string csv1file = string.Empty;
        string csv2File = string.Empty;



        public Form1()
        {
            InitializeComponent();
            //prepareListColumns();
        }

        private void prepareListColumns()
        {
            lista.Columns.Clear();

            lista.Columns.Add("ID", "ID");
            lista.Columns.Add("Imię", "Imię");
            lista.Columns.Add("Nazwisko", "Nazwisko");
            lista.Columns.Add("Ulica", "Ulica");
            lista.Columns.Add("Numer", "Numer");

        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Kliknięcie csv1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void csv1BT_Click(object sender, EventArgs e)
        {
            if (csv1Dialog.ShowDialog() == DialogResult.OK)
            {
                csv1file = csv1Dialog.FileName;
            }

            csv1TB.Text = csv1file;
        }

        private void csv2BT_Click(object sender, EventArgs e)
        {
            if (csv2Dialog.ShowDialog() == DialogResult.OK)
            {
                csv2File = csv2Dialog.FileName;
            }

            csv2TB.Text = csv2File;
        }

        private void btWyswietlNaListe_Click(object sender, EventArgs e)
        {
            if (csv1TB.Text == string.Empty || csv2TB.Text == string.Empty)
            {
                MessageBox.Show("Nie wybrano plików!", "Brak plików", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(csv1file))
            {
                MessageBox.Show("Plik nie istnieje!");
            }

            IEnumerable<ImieNazwiskoDto> listaImion = null;
            IEnumerable<AdresDto> listaAdres = null;

            var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
            csvConfig.HasHeaderRecord = true;

            using (StreamReader sr = new StreamReader(csv1file))
            using (var csv1 = new CsvReader(sr, csvConfig))
            {
                csv1.Context.RegisterClassMap<ImieNazwiskoDtoMap>();
                listaImion = csv1.GetRecords<ImieNazwiskoDto>().ToList();
            }

            using (StreamReader sr = new StreamReader(csv2File))
            using (var csv2 = new CsvReader(sr, csvConfig))
            {
                csv2.Context.RegisterClassMap<AdresDtoMap>();
                listaAdres = csv2.GetRecords<AdresDto>().ToList();
            }

            var joinedData = listaImion.Join(listaAdres, p => p.Id, a => a.IdOsoby, (imiona, adresy) => new
            {
                ID = imiona.Id,
                Imie = imiona.Imie,
                Nazwosko = imiona.Nazwisko,
                Ulica = adresy.Ulica,
                Numer = adresy.Numer
            });

            BindingSource bs = new BindingSource();
            bs.DataSource = joinedData;

            lista.DataSource = bs;

        }
    }
}
