using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMaBanqueEnLigne
{
    public class Virement
    {
        private Compte compteEmetteur;
        private Compte compteBeneficiaire;
        private string motif;
        private double montant;
        private int id;
        private DateTime ladate;

        public Virement(int _id, Compte _compteEmetteur, Compte _compteBeneficiaire, double _montant, string _motif)
        {
            id = _id;
            compteEmetteur = _compteEmetteur;
            compteBeneficiaire = _compteBeneficiaire;
            motif = _motif;
            montant = _montant;
        }

        public Compte CompteEmetteur { get => compteEmetteur; set => compteEmetteur = value; }
        public Compte CompteBeneficiaire { get => compteBeneficiaire; set => compteBeneficiaire = value; }
        public string Motif { get => motif; set => motif = value; }
        public double Montant { get => montant; set => montant = value; }
        public int Id { get => id; set => id = value; }
        public DateTime Ladate { get => ladate; set => ladate = value; }

        public Boolean effectuerVirement()
        {
            CompteEmetteur.retirer(montant);
            compteBeneficiaire.deposer(Montant);
            return true;
        }
    }
}
