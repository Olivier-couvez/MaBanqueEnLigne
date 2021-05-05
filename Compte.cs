using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMaBanqueEnLigne
{
    public class Compte
    {
        string numero;
        double solde;

        public string Numero
        {
            get { return numero; }

        }

        public Compte(string numero, double solde)
        {
            this.numero = numero;
            this.solde = solde;
        }

        public double retournerSolde()
        {
            return solde;
        }

        public Boolean deposer(double montant)
        {
            solde += montant;
            return true;
        }

        public Boolean retirer(double montant)
        {
            solde -= montant;
            return true;
        }
    }
}
