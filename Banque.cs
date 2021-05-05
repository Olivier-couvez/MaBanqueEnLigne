using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMaBanqueEnLigne
{
    class Banque
    {
        List<Client> lesClients;
        List<Compte> lesComptes;
        static int numeroVirement = 0;
        private string nom;

        public Client clientAuthentifie;

        public Banque(string nom)
        {
            this.nom = nom;
            lesClients = new List<Client>();
            lesComptes = new List<Compte>();
        }

        public void ajouterClient(Client leClient)
        {
            lesClients.Add(leClient);
        }

        public void ajouterCompte(Compte leCompte)
        {
            lesComptes.Add(leCompte);
        }

        public double accederCompte(string numeroCompte)
        {

            double solde = 0;
            /* Rechercher un commercial particulier dans la liste */

            Compte monCompte = rechercherCompte(numeroCompte);

            if (monCompte != null)
            {
                solde = monCompte.retournerSolde();
            }
            return solde;
        }

        public Compte rechercherCompte(string numeroCompte)
        {
            /* Rechercher un compte par son numero dans la liste de compte */

            Compte monCompte = null;

            monCompte = lesComptes.Find(delegate (Compte c)
            {
                return (c.Numero == numeroCompte);
            });

            return monCompte;
        }

        public bool effectuerVirement(string numeroCompteEmetteur, string numeroCompteBeneficiaire, double montant, string motif)
        {

            bool retour = true;
            Compte C1, C2;

            C1 = this.clientAuthentifie.selectionnerCompte(numeroCompteEmetteur);
            C2 = this.clientAuthentifie.selectionnerCompte(numeroCompteBeneficiaire);

            numeroVirement++;

            Virement leVirement = new Virement(numeroVirement, C1, C2, montant, motif);

            this.clientAuthentifie.ajouterVirement(leVirement);

            retour = leVirement.effectuerVirement();

            return retour;
        }
    }
}
