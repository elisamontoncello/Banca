using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace Banca
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private decimal creditoIniziale = 0;

        private void aggiungiCreditoBtn_Click(object sender, EventArgs e)
        {
            decimal creditoDaAggiungere = numericUpDown1.Value;
            creditoIniziale += creditoDaAggiungere;
            MessageBox.Show($"Credito aggiunto: {creditoDaAggiungere}\nCredito totale: {creditoIniziale}", "Credito Aggiornato");
            AggiornaCredito();
        }
        private void AggiornaCredito()
        {
            this.creditoTxt.Text = $"Credito attuale: {creditoIniziale}";
            this.creditoTxt.SelectionStart = this.creditoTxt.Text.Length;
            this.creditoTxt.SelectionLength = 0;
        }

        private void impostaInformazioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformazioniAccount informazioniAccount = new InformazioniAccount();
            informazioniAccount.ShowDialog();
        }

        private void prelieviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prelievi prelievi = new Prelievi(creditoIniziale);
            prelievi.CreditoAggiornato += Prelievi_CreditoAggiornato;
            prelievi.ShowDialog();
        }

        private void Prelievi_CreditoAggiornato(object sender, decimal nuovoCredito)
        {
            creditoIniziale = nuovoCredito;
            AggiornaCredito();
        }

        private void inviaDenaroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InviaDenaro inviaDenaro = new InviaDenaro(creditoIniziale);
            inviaDenaro.CreditoAggiornato += InviaDenaro_CreditoAggiornato;
            inviaDenaro.ShowDialog();
        }
        private void InviaDenaro_CreditoAggiornato(object sender, decimal nuovoCredito)
        {
            creditoIniziale = nuovoCredito;
            AggiornaCredito();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Login_Form loginForm = new Login_Form(); 
            loginForm.Show();
        }
    }
}


  
       

  