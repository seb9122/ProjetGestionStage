using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace ProjetGestionStage
{
    class BDD
    {
        private static MySqlConnection conn;

        public static void DbConnection()
        {
            conn = new MySqlConnection("Data Source=127.0.0.1;Initial Catalog=projet_stage;User ID=root;Password=");
            conn.Open();
        }

        public static void DbDeconnection()
        {
            conn.Close();
        }

        public static List<Utilisateur> GetListUtilisateur()
        {
            List<Utilisateur> listeUtilisateur = new List<Utilisateur>();
            DbCommand cmd = conn.CreateCommand();
            DbDataReader dr;
            cmd.CommandText = "Select * from Utilisateur";
            dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    listeUtilisateur.Add(new Utilisateur((string)dr["MDP"], (string)dr["PSEUDO"], (bool)dr["TYPE"]));
                }
            }
            dr.Close();
            return listeUtilisateur;
        }

        public static List<Entreprise> GetListEntreprise()
        {
            List<Entreprise> listeEntreprise = new List<Entreprise>();
            DbCommand cmd = conn.CreateCommand();
            DbDataReader dr;
            cmd.CommandText = "Select * from Entreprise";
            dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    listeEntreprise.Add(new Entreprise((string)dr["VILLE"], (string)dr["RUE"], (int)dr["CODE_POSTAL"], (string)dr["Secteur"], (string)dr["NOM"], (int)dr["NUM_TEL"], (string)dr["EMAIL"]));
                }
            }
            dr.Close();
            return listeEntreprise;
        }

        public static List<OffreStage> GetListOffreStage()
        {
            List<OffreStage> listeOffreStage = new List<OffreStage>();
            DbCommand cmd = conn.CreateCommand();
            DbDataReader dr;
            cmd.CommandText = "Select * from Offre_Stage";
            dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    listeOffreStage.Add(new OffreStage((int)dr["ID_ENTREPRISE"], (DateTime)dr["DATE"], (string)dr["LIBELLE"], (string)dr["DESCRIPTIF"], (string)dr["DOMAINE"], (int)dr["DUREE"]));
                }
            }
            dr.Close();
            return listeOffreStage;
        }

        public static void AjouterEntreprise(Entreprise uneEntreprise)
        {
            DbCommand cmd = conn.CreateCommand();
            DbDataReader dr;
            string req = "Insert into ENTREPRISE (VILLE,RUE,CODE_POSTAL,SECTEUR,NOM,EMAIL,NUM_TEL) values ('" + uneEntreprise.GetVille() + "','" + uneEntreprise.GetRue() + "'," + uneEntreprise.GetCP() + ",'" + uneEntreprise.GetSecteur() + "','" + uneEntreprise.GetNom() + "','" + uneEntreprise.GetMail() + "'," + uneEntreprise.GetNumTel() + ")";
            cmd.CommandText = req;
            dr = cmd.ExecuteReader();
            dr.Close();
        }
    }
}
