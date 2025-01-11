using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Banca
{
    public partial class InformazioniAccount : Form
    {
        private Random random;
        public InformazioniAccount()
        {
            InitializeComponent();
            random = new Random();
            GenerateRandomNumberInTextBox();
        }

        private void GenerateRandomNumberInTextBox()
        {
            // Genera un numero randomico di 7 cifre
            int randomNumber = random.Next(1000000, 1999999);
            this.randomTxt.Text = randomNumber.ToString();

            this.randomTxt.SelectionStart = this.randomTxt.Text.Length;
            this.randomTxt.SelectionLength = 0;
        }

        private void dateLbl_Click(object sender, EventArgs e)
        {
            dateLbl.Text = DateTime.Now.ToString("dddd dd MMMM yyyy");
        }


        public class Dati
        {
            public string Nome { get; set; }
            public string Cognome { get; set; }
            public string Nato { get; set; }
            public string Telefono { get; set; }
            public string Indirizzo { get; set; }
            public string Nazionalita { get; set; }
            public string Mansione { get; set; }
            public DateTime DataNascita {  get; set; }
            public string NumeroRandom { get; set; }
        }

        private string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "dati.json");


        private void SalvaDati()
        {
            var dati = new Dati
            {
                Nome = nometxt.Text,
                Cognome = cognometxt.Text,
                Nato = natotxt.Text,
                Telefono = telefonotxt.Text,
                Indirizzo = indirizzotxt.Text,
                Nazionalita = nazionalitatxt.Text,
                Mansione = mansionetxt.Text,
                DataNascita = dateTimePicker1.Value,
                NumeroRandom = randomTxt.Text
            };

            var json = JsonSerializer.Serialize(dati);
            File.WriteAllText(filePath, json);
        }

        private void CaricaDati()
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                var dati = JsonSerializer.Deserialize<Dati>(json);

                nometxt.Text = dati.Nome;
                cognometxt.Text = dati.Cognome;
                natotxt.Text = dati.Nato;
                telefonotxt.Text = dati.Telefono;
                indirizzotxt.Text = dati.Indirizzo;
                nazionalitatxt.Text = dati.Nazionalita;
                mansionetxt.Text = dati.Mansione;
                dateTimePicker1.Value = dati.DataNascita;
                randomTxt.Text = dati.NumeroRandom;
            }
        }


        private void InformazioniAccount_Shown_1(object sender, EventArgs e)
        {
            CaricaDati();
        }

        private void SalvaDatiBtn_Click_1(object sender, EventArgs e)
        {
            // Salva i dati correnti
            SalvaDati();

            // Nascondi il form corrente
            this.Hide();
        }

        
    }
}
