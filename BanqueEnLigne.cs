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
        int numVirement = 0;
        bool virementOk;


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

            //lesClients.Add(clientAuthentifie);

            // Ajout des comptes du client

            //lesComptes.Add(clientAuthentifie.MesComptes[0]);
            //lesComptes.Add(clientAuthentifie.MesComptes[1]);
            //lesComptes.Add(clientAuthentifie.MesComptes[2]);

            //Mise à jour des combobox

            for (int i = 0 ; i < clientAuthentifie.MesComptes.Count; i++)
            {
                comboBoxEmetteur.Items.Add(clientAuthentifie.MesComptes[i].Numero);
                comboBoxbeneficiaire.Items.Add(clientAuthentifie.MesComptes[i].Numero);
            }       
        }

        private void comboBoxEmetteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEmetteur.SelectedIndex != -1)
            {
                textBoxSoldeEmetteur.Text = Convert.ToString(clientAuthentifie.MesComptes[comboBoxEmetteur.SelectedIndex].retournerSolde());
            }            
        }

        private void comboBoxbeneficiaire_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxbeneficiaire.SelectedIndex != -1)
            {
                textBoxSoldeBeneficiaire.Text = Convert.ToString(clientAuthentifie.MesComptes[comboBoxbeneficiaire.SelectedIndex].retournerSolde());
            }            
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            try { 
            if (textBoxMontant.Text != null)
            {
                if (Convert.ToDouble(textBoxSoldeEmetteur.Text) >= (Convert.ToDouble(textBoxMontant.Text)))
                {
                        numVirement++;
                        Virement nouveauVirement = new Virement(numVirement, clientAuthentifie.MesComptes[comboBoxEmetteur.SelectedIndex], clientAuthentifie.MesComptes[comboBoxbeneficiaire.SelectedIndex], Convert.ToDouble(textBoxMontant.Text), textBoxMotif.Text);
                        nouveauVirement.Ladate = DateTime.Now;
                        virementOk = nouveauVirement.effectuerVirement();

                        if (virementOk == true)
                        {
                            MessageBox.Show("Le virement à été exécuté");
                            clientAuthentifie.ajouterVirement(nouveauVirement);
                            textBoxMontant.Text = "";
                            textBoxMotif.Text = "";
                            comboBoxbeneficiaire.SelectedIndex = -1;
                            comboBoxEmetteur.SelectedIndex = -1;
                            textBoxSoldeBeneficiaire.Text = "";
                            textBoxSoldeEmetteur.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Veuillez vérifier, une erreur s'est produite");
                        }
                }
                else
                {
                    MessageBox.Show("Vous n'avez pas assez sur votre compte pour faire le virement !");
                }
            }
            else
            {
                MessageBox.Show("Vous n'avez pas saisi de montant !");
            }
            }catch
            {
                MessageBox.Show("Votre saisie n'est pas correcte !");
            }
        }
    }
}
