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
    public partial class FormSaisirOffre : Form
    {
        public FormSaisirOffre()
        {
            InitializeComponent();
            foreach(Entreprise E1 in DonneesClass.GetListEntreprise())
            {
                cbNom.Items.Add(E1.GetNom());
            }
            foreach(OffreStage OF1 in DonneesClass.GetListOffreStage())
            {
                cbDomaine.Items.Add(OF1.GetDomaine());
            }
        }

        private void btEnvoyer_Click(object sender, EventArgs e)
        {
            //OffreStage OF1 = new OffreStage()
        }
    }
}
