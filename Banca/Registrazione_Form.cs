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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Banca
{
    public partial class Registrazione_Form : Form
    {
        private List<Utente> utenti;

        public Registrazione_Form(List<Utente> utenti)
        {
            InitializeComponent();
            this.utenti = utenti;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeUtente = usrtxtR.Text;
            string password = passtxtR.Text;

            // Verifica che il nome utente non esista già nella lista utilizzando un ciclo foreach
            foreach (var i in utenti)
            {
                if (i.NomeUtente == nomeUtente)
                {
                    MessageBox.Show("Nome utente già esistente, scegliere un altro nome utente.");
                    return; // Esce dalla funzione se il nome utente esiste già
                }
            }

            utenti.Add(new Utente(nomeUtente, password));
           

            MessageBox.Show("Registrazione completata!");
            this.Close();
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked)
            {
                passtxtR.PasswordChar = '\0'; // Mostra i caratteri effettivi
            }
            else
            {
                passtxtR.PasswordChar = '*'; // Maschera i caratteri
            }
        }

        private void infobtn_Click(object sender, EventArgs e)
        {
            string terminiCondizioni = "Termini e Condizioni di Adesione alla Carta di Credito:\n" +
                                       "1. Procedura di Adesione: Richiesta online, valutazione del credito, emissione della carta.\n" +
                                       "2. Diritto di Ripensamento: Annullamento entro 14 giorni.\n" +
                                       "3. Uso della Carta: Pagamenti in negozi, online, prelievi ATM, limiti di credito.\n" +
                                       "4. Rimborso e Interessi: Saldo rimborsabile in rate mensili o un'unica soluzione, TAEG.\n" +
                                       "5. Commissioni: Utilizzo, gestione carta, prelievi e operazioni all'estero.\n" +
                                       "6. Risolvere le Controversie: Contattare il servizio clienti, arbitrato dei consumatori.\n" +
                                       "7. Modifiche ai Termini: La banca può modificare i termini, con preavviso.";

            MessageBox.Show(terminiCondizioni, "Termini e Condizioni", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void chisiamoBtn_Click(object sender, EventArgs e)
        {
            string messaggio = "Benvenuti nel futuro dei pagamenti con la nostra nuova Carta di Credito!\n\n" +
                              "Siamo entusiasti di presentarvi la Carta di Credito X, che offre sicurezza avanzata " +
                              "per proteggere i tuoi dati e transazioni. È accettata in milioni di punti vendita e " +
                              "servizi online in tutto il mondo. Con la nostra app mobile, potrai gestire le tue " +
                              "finanze in tempo reale e bloccare temporaneamente la carta in caso di smarrimento o furto.";

            MessageBox.Show(messaggio, "Informazioni sulla Carta di Credito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
