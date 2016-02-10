using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetGestionStage
{
    static class DonneesClass
    {
        private static Entreprise Entreprise;
        private static List<Entreprise> listeEntreprise = new List<Entreprise>();
        private static Utilisateur Utilisateur;
        private static List<Utilisateur> listeUtilisateur = new List<Utilisateur>();
        private static OffreStage OffreStage;
        private static List<OffreStage> listeOffreStage = new List<OffreStage>();

        public static void SetEntreprise(Entreprise UneEntreprise)
        {
            Entreprise = UneEntreprise;
        }

        public static void SetUtilisateur(Utilisateur UnUtilisateur)
        {
            Utilisateur = UnUtilisateur;
        }
        
        public static void SetOffreStage(OffreStage UneOffreStage)
        {
            OffreStage = UneOffreStage;
        }

        public static Entreprise GetEntreprise()
        {
            return Entreprise;
        }

        public static OffreStage GetOffreStage()
        {
            return OffreStage;
        }

        public static Utilisateur GetUtilisateur()
        {
            return Utilisateur;
        }

        public static List<Entreprise> GetListEntreprise()
        {
            return listeEntreprise;
        }

        public static List<OffreStage> GetListOffreStage()
        {
            return listeOffreStage;
        }

        public static List<Utilisateur> GetListUtilisateur()
        {
            return listeUtilisateur;
        }

        public static void SetListOffreStage(List<OffreStage> unelisteOffreStage)
        {
            listeOffreStage = unelisteOffreStage;
        }
        
        public static void SetListUtilisateur(List<Utilisateur> unelisteUtilisateur)
        {
            listeUtilisateur = unelisteUtilisateur;
        }

        public static void SetListEntreprise(List<Entreprise> unelisteEntreprise)
        {
            listeEntreprise = unelisteEntreprise;
        }
    }
}
