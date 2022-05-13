using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MesExceptions;


namespace Domain
{
    public class ServiceVisiteur
    {
        private static ServiceVisiteur instance;
        private static RG_GSBE5CEntities unService;
        /// <summary>
        /// Obtenir le singleton et le créer s'il n'existe pas
        /// </summary>
        public static ServiceVisiteur getInstance()
        {
            if (ServiceVisiteur.instance == null)
            {
                ServiceVisiteur.instance = new ServiceVisiteur();
                // on définit un contexte commun à toutes les requêtes
                unService = new RG_GSBE5CEntities();
            }
            return ServiceVisiteur.instance;
        }
        // Le constructeur devient privé
        private ServiceVisiteur()
        { }

        /// <summary>
        /// contrôle du login d'un visiteur
        /// </summary>
        /// <param name="numV"></param>
        /// <returns></returns>


        public visiteur RechercheUnVisiteur(Int32 numV)
        {

            sErreurs er = new sErreurs("Erreur sur recherche d'un visiteur.", "RechercheUnVisiteur()");
            visiteur unVisiteur;
            try
            {

                unVisiteur = (from v in unService.visiteur
                              where v.id_visiteur == numV
                              select v).FirstOrDefault();
                return unVisiteur;
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }
        public List<medicament> GetListeMedicament()
        {
            sErreurs er = new sErreurs("Erreur liste des Médicaments.", "GetListeMedicament()");
            try
            {
                var mesMedicaments = (from v in unService.medicament
                                    select v);
                return mesMedicaments.ToList<medicament>();
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message); 
            }
        }
        
        public List<presentation> ListeDesPres(int id)
        {
            sErreurs er = new sErreurs("Erreur liste des Médicaments.", "GetListeMedicament()");
            try
            {
                var mesFormulations = (from p in unService.presentation
                                       join f in unService.formuler on p.id_presentation equals f.id_presentation
                                      where f.id_medicament == id
                                      select p);
                return mesFormulations.ToList<presentation>();
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }

        public List<medicament> ListeDesInterractions(int id)
        {
            sErreurs er = new sErreurs("Erreur liste des Médicaments.", "GetListeMedicament()");
            try
            {
                var mesInterractions = (from m in unService.medicament
                                       join i in unService.interagir on m.id_medicament equals i.med_id_medicament
                                       where i.id_medicament == id
                                       select m);

                return mesInterractions.ToList<medicament>();
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }

        public List<dosage> ListeDesPrescriptions(int id)
        {
            sErreurs er = new sErreurs("Erreur liste des Médicaments.", "GetListeMedicament()");
            try
            {
                var mesPrescriptions = (from d in unService.dosage
                                        join p in unService.prescrire on d.id_dosage equals p.id_dosage
                                        where p.id_medicament == id
                                        select d);

                return mesPrescriptions.ToList<dosage>();
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }

        public DataTable ListeDesMedicamentsDATA()
        {
            DataTable dt = new DataTable();
            sErreurs er = new sErreurs("Erreur liste des Médicaments.", "GetListeMedicament()");
            try
            {
                dt.Columns.Add("id_medicament", typeof(int));
                dt.Columns.Add("famille", typeof(String));
                dt.Columns.Add("nom_commercial", typeof(String));
                dt.Columns.Add("effets", typeof(String));
                dt.Columns.Add("prix", typeof(Decimal));

                var mesMedicaments = from m in unService.medicament
                                     join f in unService.famille on m.id_famille equals f.id_famille
                                     select new
                                     {
                                         m.id_medicament,
                                         f.lib_famille,
                                         m.nom_commercial,
                                         m.effets,
                                         m.prix_echantillon
                                     };
                foreach (var res in mesMedicaments)
                {
                    dt.Rows.Add(res.id_medicament, res.lib_famille, res.nom_commercial, res.effets, res.prix_echantillon);
                }
                return dt;
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }

        public DataTable ListeDesFormulationsDATA(int id)
        {
            DataTable dt = new DataTable();
            sErreurs er = new sErreurs("Erreur liste des Médicaments.", "GetListeMedicament()");
            try
            {
                dt.Columns.Add("presentation", typeof(String));
                dt.Columns.Add("quantité", typeof(int));

                var mesFormulations = from f in unService.formuler
                                     join p in unService.presentation on f.id_presentation equals p.id_presentation
                                     where f.id_medicament == id
                                     select new
                                     {
                                         p.lib_presentation,
                                         f.qte_formuler
                                     };
                                    
                foreach (var res in mesFormulations)
                {
                    dt.Rows.Add(res.lib_presentation, res.qte_formuler);
                }
                return dt;
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }

        public DataTable ListeDesInetrractionsDATA(int id)
        {
            DataTable dt = new DataTable();
            sErreurs er = new sErreurs("Erreur liste des Médicaments.", "GetListeMedicament()");
            try
            {
                dt.Columns.Add("Médicament", typeof(String));

                var mesInetrractions = from i in unService.interagir
                                       join medoc in unService.medicament on i.med_id_medicament equals medoc.id_medicament
                                       where i.id_medicament == id
                                      select new
                                      {
                                          medoc.nom_commercial
                                      };

                foreach (var res in mesInetrractions)
                {
                    dt.Rows.Add(res.nom_commercial);
                }
                return dt;
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }

        public DataTable ListeDesPrescriptionsDATA(int id)
        {
            DataTable dt = new DataTable();
            sErreurs er = new sErreurs("Erreur liste des Médicaments.", "GetListeMedicament()");
            try
            {
                dt.Columns.Add("ID dosage", typeof(int));
                dt.Columns.Add("Quantité de dosage", typeof(String));
                dt.Columns.Add("Type d'individu", typeof(String));
                dt.Columns.Add("Posologie", typeof(String));

                var mesPrescriptions = from p in unService.prescrire
                                       join medoc in unService.medicament on p.id_medicament equals medoc.id_medicament
                                       join dosage in unService.dosage on p.id_dosage equals dosage.id_dosage
                                       join individu in unService.type_individu on p.id_type_individu equals individu.id_type_individu
                                       where p.id_medicament == id
                                       select new
                                       {
                                           dosage.id_dosage,
                                           dosage.qte_dosage,
                                           individu.lib_type_individu,
                                           p.posologie
                                       };

                foreach (var res in mesPrescriptions)
                {
                    dt.Rows.Add(res.id_dosage,res.qte_dosage, res.lib_type_individu, res.posologie);
                }
                return dt;
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }

        public void SupprimerFormulation(int idMedoc, int idPres)
        {
            sErreurs er = new sErreurs("Erreur liste des Médicaments.", "GetListeMedicament()");
            try
            {
                var supprF = (from f in unService.formuler
                                      where f.id_medicament == idMedoc
                                      where f.id_presentation == idPres
                                      select f);

                //unService.formuler.Remove(supprF);
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }
        public List<visiteur> GetListeVisiteur()
        {
            sErreurs er = new sErreurs("Erreur liste des Médicaments.", "GetListeMedicament()");
            try
            {
                var mesVisiteurs = (from v in unService.visiteur
                                      select v);
                return mesVisiteurs.ToList<visiteur>();
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }
        public void MiseAjourDuModele()
        {
            sErreurs er = new sErreurs("Erreur  sur la mise à jour du modèle", "MiseAjourDuModele()");

            try
            {
                unService.SaveChanges();
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }

        }
    }
}