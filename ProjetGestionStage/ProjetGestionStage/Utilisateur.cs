using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetGestionStage
{
    class Utilisateur
    {
        private string MDP;
        private string Pseudo;
        private bool Type;
        
        public Utilisateur(string UnMDP, string UnPseudo, bool UnType)
        {
            MDP = UnMDP;
            Pseudo = UnPseudo;
            Type = UnType;
        }

        public string GetMDP()
        {
            return MDP;
        }

        public string GetPseudo()
        {
            return Pseudo;
        }

        public bool UnType()
        {
            return Type;
        }

        public void SetMDP(string UnMDP)
        {
            MDP = UnMDP;
        }

        public void SetPseudo(string UnPseudo)
        {
            Pseudo = UnPseudo;
        }
        
        public void SetType(bool UnType)
        {
            Type = UnType;
        }
    }
}
