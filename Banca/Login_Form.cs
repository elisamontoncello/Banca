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
    public partial class Login_Form : Form
    {
        private List<Utente> utenti;

        public Login_Form()
        {
            InitializeComponent();
            utenti = new List<Utente>();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string nomeUtenteInserito = usrtxt.Text.Trim();
            string passwordInserita = passtxt.Text.Trim();

            Utente utenteLoggato = null;

            foreach (var x in utenti)
            {
                if (x.NomeUtente == nomeUtenteInserito && x.Password == passwordInserita)
                {
                    utenteLoggato = x;
                    break;
                }
            }

            if (utenteLoggato != null)
            {
                Json.EliminaFileJson();
                this.Hide();
                Menu m = new Menu();
                m.FormClosed += Menu_FormClosed; // Chiudi il form di login quando il form Menu viene chiuso
                m.Show();
                MessageBox.Show($"Benvenuto {utenteLoggato.NomeUtente}, il tuo saldo è: {utenteLoggato.Saldo}€");
            }
            else
            {
                MessageBox.Show("Nome utente o password errati");
            }
        }
        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        { this.Close(); }

        private void button2_Click(object sender, EventArgs e)
        {
            Registrazione_Form formRegistrazione = new Registrazione_Form(utenti);
            formRegistrazione.ShowDialog();
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked)
            {
                passtxt.PasswordChar = '\0'; // Mostra i caratteri effettivi
            }
            else
            {
                passtxt.PasswordChar = '*'; // Maschera i caratteri
            }
        }
    }
}

/*
 * Parametro sender:

Il parametro sender rappresenta l'oggetto che ha generato l'evento. In questo caso, sarà il CheckBox che è stato selezionato o deselezionato.

Casting del sender:

CheckBox checkBox = sender as CheckBox; converte il sender in un oggetto CheckBox. Questo ci permette di accedere alle proprietà e ai metodi specifici del CheckBox.

Condizione if:

if (checkBox.Checked) verifica se il CheckBox è selezionato (Checked è true).

Se il CheckBox è selezionato, passtxt.PasswordChar = '\0'; imposta la proprietà PasswordChar della TextBox a '\0' (carattere nullo), mostrando così i caratteri effettivi della password.

Se il CheckBox non è selezionato, passtxt.PasswordChar = '*'; imposta la proprietà PasswordChar della TextBox a '*', mascherando i caratteri della password con asterischi.
*/