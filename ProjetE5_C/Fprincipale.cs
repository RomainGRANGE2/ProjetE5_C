using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using MesExceptions;
using Utilitaires;

namespace ProjetE5_C
{
    public partial class Fprincipale : Form
    {
        /// <summary>
        /// variable partagé entre les services
        /// 
        /// </summary>
        private visiteur unVisiteur;


        public Fprincipale()
        {
            InitializeComponent();
            Init_Etat();
        }

        private void Init_Etat()
        {
            deconnexionToolStripMenuItem.Enabled = false;
            listerMédicamentsToolStripMenuItem.Enabled = false;
            connexionToolStripMenuItem.Enabled = true;
            miseÀJourMotDePasseToolStripMenuItem.Enabled = true;
        }
        /// <summary>
        /// Connexion d'un visiteur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void connexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String[] Credential = new String[] { " ", " " };
            String login;
            String mdp;

            Presentation.Fconnexion f = new Presentation.Fconnexion(Credential);

            DialogResult res = f.ShowDialog();
            if (res == DialogResult.OK)
            {
                //
                login = Credential[0];
                mdp = Credential[1];
                unVisiteur = ServiceConnexion.getInstance().RechercheUnVisiteur(login);
                // on controle le mot de passe
                try
                {
                    if (unVisiteur != null)
                    {
                        try
                        {
                            String sel = unVisiteur.sel_visiteur;
                            // on récupère le sel 
                            Byte[] salt = MonMotPassHash.transformeEnBytes(sel);
                            // on génère le mot de passe 
                            Byte[] tempo = MonMotPassHash.transformeEnBytes(unVisiteur.pwd_visiteur);
                            if (MonMotPassHash.VerifyPassword(salt, mdp, tempo) == true)

                            {
                                lb_etat.Text = "Etat connecté";
                                deconnexionToolStripMenuItem.Enabled = true;
                                listerMédicamentsToolStripMenuItem.Enabled = true;
                                connexionToolStripMenuItem.Enabled = false;
                                miseÀJourMotDePasseToolStripMenuItem.Enabled = false;
                            }
                            else
                                MessageBox.Show("Erreur", "Erreur lors du contrôle  du mot de passe pour : " + Credential[0]);
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show("Erreur", "Erreur lors du contrôle : " + err.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erreur", "Erreur  login erroné : " + Credential[0]);

                    }
                }
                catch (MonException er)
                {
                    MessageBox.Show("Erreur", "Erreur lors de l'authentification : " + er.Message);

                }
            }
        }

        /// <summary>
        /// On quitte l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void deconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unVisiteur = null;
            Init_Etat();
            lb_etat.Text = "Non connecté";
        }

        private void quitterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void miseÀJourMotDePasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<visiteur> mesVisiteurs;
            try
            {

                mesVisiteurs = ServiceVisiteur.getInstance().GetListeVisiteur();
                Byte[] selByte;
                Byte[] mdpByte;
                String sel;
                String mdp;
                foreach (visiteur unV in mesVisiteurs)
                {
                     selByte = MonMotPassHash.GenerateSalt();
                     mdpByte = MonMotPassHash.PasswordHashe("secret", selByte);
                     sel = MonMotPassHash.BytesToString(selByte);
                     mdp = MonMotPassHash.BytesToString(mdpByte);
                    unV.sel_visiteur = sel;
                    unV.pwd_visiteur = mdp;
                }
                
                ServiceVisiteur.getInstance().MiseAjourDuModele();
                MessageBox.Show("Mise à jour", "Mise à jour effectuée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (MonException er)
            {
                MessageBox.Show(er.Message, "Mise à jour", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Fprincipale_Load(object sender, EventArgs e)
        {

        }

        private void listerMédicamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable mesMedicaments = ServiceVisiteur.getInstance().ListeDesMedicamentsDATA();
            List<medicament> mesMedicamentList = ServiceVisiteur.getInstance().GetListeMedicament();
            Presentation.FafficheMedicament f = new Presentation.FafficheMedicament(mesMedicaments,mesMedicamentList);
            f.ShowDialog();
        }
    }
}


