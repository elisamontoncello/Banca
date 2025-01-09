using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca
{
    public class Utente
    {
        public string NomeUtente { get; set; }
        public string Password { get; set; }
        public decimal Saldo { get; set; }

        public Utente(string nomeUtente, string password)
        {
            NomeUtente = nomeUtente;
            Password = password;
        }
 
         decimal saldonuovo;
         public void AggiornaSaldo(decimal importo) 
         {
            saldonuovo = importo; 
         }

    }
}
