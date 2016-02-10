using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetGestionStage
{
    class Entreprise
    {
        private string Ville;
        private string Rue;
        private int CP;
        private string Secteur;
        private int NumTel;
        private string Nom;
        private string Mail;

        public Entreprise(string uneVille, string UneRue, int UnCP, string UnSecteur, string UnNom, int UnNumTel,string unMail)
        {
            Ville = uneVille;
            Rue = UneRue;
            CP = UnCP;
            Secteur = UnSecteur;
            NumTel = UnNumTel;
            Nom = UnNom;
            Mail = unMail;
        }

        public string GetMail()
        {
            return Mail;
        }

        public int GetNumTel()
        {
            return NumTel;
        }

        public int GetCP()
        {
            return CP;
        }

        public string GetVille()
        {
            return Ville;
        }

        public string GetRue()
        {
            return Rue;
        }

        public string GetSecteur()
        {
            return Secteur;
        }

        public string GetNom()
        {
            return Nom;
        }

        public void SetVille(string uneVille)
        {
            Ville = uneVille;
        }

        public void SetMail(string unMail)
        {
            Mail = unMail;
        }

        public void SetNom(string unNom)
        {   
            Nom = unNom;
        }

        public void SetSecteur(string unSecteur)
        {   
            Secteur = unSecteur;
        }

        public void SetCP(int unCP)
        {
            CP = unCP;
        }

        public void SetRue(string uneRue)
        {
            Rue = uneRue;
        }

        public void SetNumTel(int unNumTel)
        {
            NumTel = unNumTel;
        }
    }
}
