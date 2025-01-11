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
    public partial class Salvadanaio : Form
    {
        private decimal creditoDisponibile;

        public Salvadanaio(decimal credito)
        {
            InitializeComponent();
            creditoDisponibile = credito;
            VisualizzaCreditoAttuale();
        }

        private void VisualizzaCreditoAttuale()
        {
            creditoAttualeLbl.Text = " " + creditoDisponibile;
        }


        private void calcoloRisparmioBtn_Click(object sender, EventArgs e)
        {
            decimal percentuale = numericUpDownPercentuale.Value;
            decimal risparmioMensile = creditoDisponibile * (percentuale / 100);
            decimal risparmioAnnuale = risparmioMensile * 12;

            risparmioMensileTxt.Text = " " + risparmioMensile;
            risparmioAnnualeTxt.Text = " " + risparmioAnnuale;
        }
    }
}

