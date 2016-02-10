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
    public partial class FormCreerEntreprise : Form
    {
        public FormCreerEntreprise()
        {
            InitializeComponent();
        }

        private void btEnvoyer_Click(object sender, EventArgs e)
        {
            Entreprise E1 = new Entreprise(txtVille.Text,txtAdresse.Text,Convert.ToInt32(txtCP.Text),txtSecteur.Text, txtNom.Text, Convert.ToInt32(txtNumTel.Text), txtEmail.Text);
            BDD.AjouterEntreprise(E1);
            MessageBox.Show("Entreprise ajoutée");
            this.DialogResult = DialogResult.OK;
        }
    }
}
