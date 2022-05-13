using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MesExceptions;

namespace Domain
{
    public class ServiceConnexion
    {
        private static ServiceConnexion instance;
        private static RG_GSBE5CEntities unService;
        private visiteur unVisiteur;

        public visiteur UnVisiteur { get => unVisiteur; set => unVisiteur = value; }

        /// <summary>
        /// Obtenir le singleton et le créer s'il n'existe pas
        /// </summary>
        public static ServiceConnexion getInstance()
        {
            if (ServiceConnexion.instance == null)
            {
                ServiceConnexion.instance = new ServiceConnexion();
                // on définit un contexte commun à toutes les requêtes
                unService = new RG_GSBE5CEntities();
            }
            return ServiceConnexion.instance;
        }
        // Le constructeur devient privé
        private ServiceConnexion()
        { }

        public visiteur RechercheUnVisiteur(String login)
        {
            sErreurs er = new sErreurs("Erreur sur recherche d'un visiteur.", "RechercheUnVisiteur()");
            visiteur unVisiteur;    
            try
            {
                unVisiteur = (from v in unService.visiteur
                              where v.login_visiteur == login
                              select v).FirstOrDefault();
                return unVisiteur;
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }
    }
}
