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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            DonneesClass.SetListEntreprise(BDD.GetListEntreprise());
            DonneesClass.SetListOffreStage(BDD.GetListOffreStage());
        }

        private void btCreerEntreprise_Click(object sender, EventArgs e)
        {
            FormCreerEntreprise frmCreerEntreprise = new FormCreerEntreprise();

            if (frmCreerEntreprise.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void btSaisirOffre_Click(object sender, EventArgs e)
        {
            FormSaisirOffre frmSaisirOffre = new FormSaisirOffre();

            if (frmSaisirOffre.ShowDialog() == DialogResult.OK)
            {
            }
        }
    }
}
