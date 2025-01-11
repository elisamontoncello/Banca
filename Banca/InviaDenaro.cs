using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banca
{
    public partial class InviaDenaro : Form
    {
        private decimal creditoDisponibile;

        // Dichiarazione dell'evento
        public event EventHandler<decimal> CreditoAggiornato;
        public InviaDenaro(decimal creditoIniziale)
        {
            InitializeComponent();
            creditoDisponibile = creditoIniziale;
            AggiornaCredito();
        }
       
        private void AggiornaCredito()
        {
            this.creditoTxt.Text = $"Credito attuale: {creditoDisponibile}";
            this.creditoTxt.SelectionStart = this.creditoTxt.Text.Length;
            this.creditoTxt.SelectionLength = 0;
        }

        private void inviaBtn_Click_1(object sender, EventArgs e)
        {

            decimal importoDaInviare = numericUpDown1.Value;
            string usernameDestinatario = userNameTxt.Text;
            if (importoDaInviare <= creditoDisponibile)
            {
                creditoDisponibile -= importoDaInviare;
                AggiornaCredito();
                MessageBox.Show($"Invio effettuato: {importoDaInviare} € a {usernameDestinatario}\nCredito rimanente: {creditoDisponibile}", "Invio Effettuato");
                if (CreditoAggiornato != null) // Controlla se ci sono ascoltatori per l'evento
                {
                    CreditoAggiornato(this, creditoDisponibile); // Scatena l'evento e invia i dati
                }
            }
            else
            {
                MessageBox.Show("Credito insufficiente per l'invio richiesto.");
            }
        }
    }
}
