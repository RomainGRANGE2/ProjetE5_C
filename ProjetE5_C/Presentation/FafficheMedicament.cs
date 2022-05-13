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

namespace ProjetE5_C.Presentation
{
    public partial class FafficheMedicament : Form
    {
        private DataTable mesMedicaments = null;
        private List<medicament> mesMedicamentList = null;
        public FafficheMedicament(DataTable mesM, List<medicament> mesMList)
        {
            InitializeComponent();
            mesMedicaments = mesM;
            mesMedicamentList = mesMList;
        }

        private void FafficheMedicament_Load(object sender, EventArgs e)
        {
            dg_medicament.DataSource = mesMedicaments;

            cb_medicament.DisplayMember = "Text";
            cb_medicament.ValueMember = "Value";
            foreach (medicament unMedoc in mesMedicamentList)
            {
                cb_medicament.Items.Add(new { Text = unMedoc.nom_commercial, Value = unMedoc.id_medicament });
            }
        }

        private void bt_formulation_Click(object sender, EventArgs e)
        {
            int idMedocSelectionne = (cb_medicament.SelectedItem as dynamic).Value;
            String TextMedocSelectionne = (cb_medicament.SelectedItem as dynamic).Text;
            DataTable mesFormulations = ServiceVisiteur.getInstance().ListeDesFormulationsDATA(idMedocSelectionne);
            List<presentation> ListePres = ServiceVisiteur.getInstance().ListeDesPres(idMedocSelectionne);
            Presentation.Fformulation f = new Presentation.Fformulation(idMedocSelectionne,TextMedocSelectionne,mesFormulations,ListePres);
            f.ShowDialog();
        }

        private void bt_interactions_Click(object sender, EventArgs e)
        {
            int idMedocSelectionne = (cb_medicament.SelectedItem as dynamic).Value;
            String TextMedocSelectionne = (cb_medicament.SelectedItem as dynamic).Text;
            DataTable mesInterractions = ServiceVisiteur.getInstance().ListeDesInetrractionsDATA(idMedocSelectionne);
            List<medicament> Listeinterractions = ServiceVisiteur.getInstance().ListeDesInterractions(idMedocSelectionne);
            Presentation.Finterraction f = new Presentation.Finterraction(idMedocSelectionne, TextMedocSelectionne, mesInterractions,Listeinterractions);
            f.ShowDialog();
        }

        private void bt_prescriptions_Click(object sender, EventArgs e)
        {
            int idMedocSelectionne = (cb_medicament.SelectedItem as dynamic).Value;
            String TextMedocSelectionne = (cb_medicament.SelectedItem as dynamic).Text;
            DataTable mesPrescriptions = ServiceVisiteur.getInstance().ListeDesPrescriptionsDATA(idMedocSelectionne);
            List<dosage> ListePrescription = ServiceVisiteur.getInstance().ListeDesPrescriptions(idMedocSelectionne);
            Presentation.Fprescription f = new Presentation.Fprescription(idMedocSelectionne, TextMedocSelectionne, mesPrescriptions,ListePrescription);
            f.ShowDialog();
        }
    }
}
