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

namespace ProjetE5_C.Presentation
{
    public partial class Fformulation : Form
    {
        private int idMedocSelectionne;
        private String TextMedocSelectionne;
        private DataTable mesFormulations = null;
        private List<presentation> mesPresListe;


        public Fformulation(int idMedocS,String TextMedocS,DataTable mesF, List<presentation> ListeP)
        {
            InitializeComponent();
            idMedocSelectionne = idMedocS;
            TextMedocSelectionne = TextMedocS;
            mesFormulations = mesF;
            mesPresListe = ListeP;
        }

        private void Fformulation_Load(object sender, EventArgs e)
        {
            lb_MedocS.Text = TextMedocSelectionne;
            dg_formulation.DataSource = mesFormulations;

            cb_Presentation.DisplayMember = "Text";
            cb_Presentation.ValueMember = "Value";
            foreach (presentation uneP in mesPresListe)
            {
                cb_Presentation.Items.Add(new { Text = uneP.lib_presentation, Value = uneP.id_presentation });
            }
        }

        private void cb_Formulations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_supprimerF_Click(object sender, EventArgs e)
        {
            int idMedoc = idMedocSelectionne;
            int idPresSelectionne = (cb_Presentation.SelectedItem as dynamic).Value;
            String TextPresSelectionne = (cb_Presentation.SelectedItem as dynamic).Text;
            ServiceVisiteur.getInstance().SupprimerFormulation(idMedoc, idPresSelectionne);
            ServiceVisiteur.getInstance().MiseAjourDuModele();
            MessageBox.Show("La formulation a etait supprimer", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
