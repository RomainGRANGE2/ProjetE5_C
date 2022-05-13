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
    public partial class Finterraction : Form
    {
        private int idMedocSelectionne;
        private String TextMedocSelectionne;
        private DataTable mesInterractions = null;
        private List<medicament> mesInterractionsListe; 
        public Finterraction(int idMedocS, String TextMedocS, DataTable mesI,List<medicament> mesIList)
        {
            InitializeComponent();
            idMedocSelectionne = idMedocS;
            TextMedocSelectionne = TextMedocS;
            mesInterractions = mesI;
            mesInterractionsListe = mesIList;
        }

        private void Finterraction_Load(object sender, EventArgs e)
        {
            lb_MedocI.Text = TextMedocSelectionne;
            dg_interraction.DataSource = mesInterractions;

            cb_Interraction.DisplayMember = "Text";
            cb_Interraction.ValueMember = "Value";
            foreach (medicament uneI in mesInterractionsListe)
            {
                cb_Interraction.Items.Add(new { Text = uneI.nom_commercial, Value = uneI.id_medicament });
            }
        }
    }
}
