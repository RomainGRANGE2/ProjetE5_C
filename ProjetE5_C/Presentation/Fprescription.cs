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
    public partial class Fprescription : Form
    {
        private int idMedocSelectionne;
        private String TextMedocSelectionne;
        private DataTable mesPrescriptions = null;
        private List<dosage> mesPresListe;
        public Fprescription(int idMedocS, String TextMedocS, DataTable mesP,List<dosage> mesPList  )
        {
            InitializeComponent();
            idMedocSelectionne = idMedocS;
            TextMedocSelectionne = TextMedocS;
            mesPrescriptions = mesP;
            mesPresListe = mesPList;
        }

        private void Fprescription_Load(object sender, EventArgs e)
        {
            lb_MedocP.Text = TextMedocSelectionne;
            dg_prescription.DataSource = mesPrescriptions;

            cb_Prescriptions.DisplayMember = "Text";
            cb_Prescriptions.ValueMember = "Value";
            foreach (dosage unD in mesPresListe)
            {
                cb_Prescriptions.Items.Add(new { Text = unD.id_dosage, Value = unD.id_dosage });
            }
        }
    }
}
