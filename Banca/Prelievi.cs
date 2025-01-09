using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banca;

namespace Banca
{
    public partial class Prelievi : Form
    {
      
        private decimal creditoDisponibile;

        public event EventHandler<decimal> CreditoAggiornato;

        public Prelievi(decimal creditoIniziale)
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

        public void prelievoBtn_Click(object sender, EventArgs e)
        {
            decimal importoDaPrelevare = numericUpDown1.Value;

            if (importoDaPrelevare <= creditoDisponibile)
            {
                creditoDisponibile -= importoDaPrelevare;
                AggiornaCredito();
                MessageBox.Show($"Prelievo effettuato: {importoDaPrelevare}\nCredito rimanente: {creditoDisponibile}", "Prelievo Effettuato");
                if (CreditoAggiornato != null) // Controlla se ci sono ascoltatori per l'evento
                {
                    CreditoAggiornato(this, creditoDisponibile); // Scatena l'evento e invia i dati
                }

            }
            else
            {
                MessageBox.Show("Credito insufficiente per il prelievo richiesto.", "Errore di Prelievo");
            }
        }

    }
        
}
