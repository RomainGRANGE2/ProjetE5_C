using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Configuration;
using System.Web;
using System.IO;

namespace MesExceptions
{
    public class MonException : Exception
    {
        private string utilisateur, application, systeme;
        private string support = "Si l'erreur persiste, relevez les messages ci-dessus et prenez contact avec le support technique.";

        public MonException()
        {
            utilisateur = application = systeme = "";

        }
        public string MsgUtilisateur
        {
            get { return utilisateur; }
            set { utilisateur = value + "\r\n"; }
        }
        public string MsgApplication
        {
            get { return application; }
            set { application = "Origine de l'erreur : " + value + "\r\n"; }
        }

        public string MsgSysteme
        {
            get { return systeme; }
            set { systeme = "Erreur système : " + value + "\r\n"; }
        }


        public MonException(string u, string a, string s)
        {
            utilisateur = application = systeme = "";
            if (u != "")
                utilisateur = u + "\r\n";

            if (a != "")
                application = "Origine de l'erreur : " + a + "\r\n";
            if (s != "")
                systeme = "Erreur système : " + s + "\r\n";
        }



    }

}
