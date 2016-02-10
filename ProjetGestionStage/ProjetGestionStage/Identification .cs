using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetGestionStage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BDD.DbConnection();
            DonneesClass.SetListUtilisateur(BDD.GetListUtilisateur());
        }

        private void btConnexion_Click(object sender, EventArgs e)
        {
            string pseudo = Convert.ToString(txtPseudo.Text);
            string MDP = Convert.ToString(txtMDP.Text);
            foreach(Utilisateur U1 in DonneesClass.GetListUtilisateur())
            {
                if(U1.GetPseudo() == pseudo && U1.GetMDP() == MDP)
                   {
                        MessageBox.Show("Authentification réussite");
                        DonneesClass.SetUtilisateur(U1);
                        Menu frmMenu = new Menu();

                        if (frmMenu.ShowDialog() == DialogResult.OK)
                        {
                        }
                   }
            }
        }
    }
}
