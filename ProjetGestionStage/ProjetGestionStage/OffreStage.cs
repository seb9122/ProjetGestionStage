using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetGestionStage
{
    class OffreStage
    {
       private int IDEntreprise;
       private DateTime Date;
       private string Libelle;
       private string Descriptif;
       private string Domaine;
       private int Duree;
        
       public OffreStage(int uneIDEntreprise, DateTime UneDate, string UnLibelle, string UnDescriptif, string UnDomaine, int UneDuree)
       {
            IDEntreprise = uneIDEntreprise;
            Date = UneDate;
            Libelle = UnLibelle;
            Descriptif = UnDescriptif;
            Domaine = UnDomaine;
            Duree = UneDuree;       
       }

       public int GetIDEntreprise()
       {
            return IDEntreprise;
       }

       public DateTime GetDate()
        {   
           return Date;
        }
        
        public string GetLibelle()
        {
            return Libelle;
        }

        public string GetDescriptif()
        {
            return Descriptif;
        }

        public int GetDuree()
        {
            return Duree;
        }

        public string GetDomaine()
        {
            return Domaine;
        }

        public void SetIDEntreprise(int uneIDEntreprise)
        {
            IDEntreprise = uneIDEntreprise;
        }
        
        public void SetDomaine(string UnDomaine)
        {
            Domaine = UnDomaine;
        }

        public void SetDuree(int UneDuree)
        {
            Duree = UneDuree;
        }

        public void SetLibelle(string UnLibelle)
        {
            Libelle = UnLibelle;
        }

        public void SetDescriptif(string UnDescriptif)
        {
            Descriptif = UnDescriptif;
        }

        public void SetDate(DateTime UneDate)
        {
            Date = UneDate;
        }
    }
}
