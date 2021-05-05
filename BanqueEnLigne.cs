using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsMaBanqueEnLigne
{
    public partial class BanqueEnLigne : Form
    {
        List<Compte> lesComptes;
        List<Client> lesClients;
        Banque maBanque;
        Client clientAuthentifie;
        Compte compte1;
        Compte compte2;
        Compte compte3;


        public BanqueEnLigne()
        {
            InitializeComponent();
            maBanque = new Banque("MaBanque");
            clientAuthentifie = new Client("Dupont");
            compte1 = new Compte("123456789", 500);
            compte2 = new Compte("987654321", 20);
            compte3 = new Compte("321654987", 150);
            maBanque.ajouterClient(clientAuthentifie);
            maBanque.ajouterCompte(compte1);
            maBanque.ajouterCompte(compte2);
            maBanque.ajouterCompte(compte3);
            clientAuthentifie.ajouterCompte(compte1);
            clientAuthentifie.ajouterCompte(compte2);
            clientAuthentifie.ajouterCompte(compte3);

        }

        private void BanqueEnLigne_Load(object sender, EventArgs e)
        {
            // Ajout dans la liste des clients

            lesClients.Add(clientAuthentifie);

            // Ajout des comptes du client

            lesComptes.Add(clientAuthentifie.MesComptes[0]);
            lesComptes.Add(clientAuthentifie.MesComptes[1]);
            lesComptes.Add(clientAuthentifie.MesComptes[2]);

            //Mise à jour des combobox

            for (int i = 0 ; i < clientAuthentifie.MesComptes.Count; i++)
            {
                comboBoxEmetteur.Items.Add(clientAuthentifie.MesComptes[i].Numero);
                comboBoxbeneficiaire.Items.Add(clientAuthentifie.MesComptes[i].Numero);
            }       
        }

        private void comboBoxEmetteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSoldeEmetteur.Text = Convert.ToString(lesComptes[comboBoxEmetteur.SelectedIndex].retournerSolde());
        }
    }
}
