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
    public partial class Fconnexion : Form
    {
        private String[] credential;
        public Fconnexion()
        {
            InitializeComponent();
        }

        public Fconnexion(String[] tab)
        {
            InitializeComponent();

            credential = tab;
        }
       

        private void bt_connexion_Click(object sender, EventArgs e)
        {
            credential[0] = tb_login.Text;

            if (credential[0] == "")
                tb_login.Focus();
            else
            {
                credential[1] = tb_password.Text;
                if (credential[1] == "")
                {
                    tb_password.Focus();
                }
            }
        }
    }
}
