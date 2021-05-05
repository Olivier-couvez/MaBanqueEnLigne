using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMaBanqueEnLigne
{
    class Client
    {
        /* liste des comptes du client */

        List<Compte> mesComptes;

        internal List<Compte> MesComptes
        {
            get { return mesComptes; }

        }
        List<Virement> mesVirements;

        string nom;

        public Client(string nom)
        {
            mesComptes = new List<Compte>();
            mesVirements = new List<Virement>();
            this.nom = nom;
        }


        public void ajouterVirement(Virement monvirement)
        {
            mesVirements.Add(monvirement);
        }

        public void ajouterCompte(Compte monCompte)
        {
            MesComptes.Add(monCompte);
        }

        public Compte selectionnerCompte(string numeroCompte)
        {
            Compte monCompte = null;

            monCompte = MesComptes.Find(delegate (Compte c)
            {
                return (c.Numero == numeroCompte);
            });

            return monCompte;
        }
    }
}
