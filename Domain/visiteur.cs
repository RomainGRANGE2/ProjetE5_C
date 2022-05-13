//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class visiteur
    {
        public visiteur()
        {
            this.frais = new HashSet<frais>();
            this.offrir = new HashSet<offrir>();
            this.rapport_visite = new HashSet<rapport_visite>();
            this.realiser = new HashSet<realiser>();
            this.travailler = new HashSet<travailler>();
        }
    
        public int id_visiteur { get; set; }
        public Nullable<int> id_laboratoire { get; set; }
        public Nullable<int> id_secteur { get; set; }
        public string nom_visiteur { get; set; }
        public string prenom_visiteur { get; set; }
        public string adresse_visiteur { get; set; }
        public string cp_visiteur { get; set; }
        public string ville_visiteur { get; set; }
        public Nullable<System.DateTime> date_embauche { get; set; }
        public string login_visiteur { get; set; }
        public string pwd_visiteur { get; set; }
        public string type_visiteur { get; set; }
        public string sel_visiteur { get; set; }
    
        public virtual ICollection<frais> frais { get; set; }
        public virtual laboratoire laboratoire { get; set; }
        public virtual ICollection<offrir> offrir { get; set; }
        public virtual ICollection<rapport_visite> rapport_visite { get; set; }
        public virtual ICollection<realiser> realiser { get; set; }
        public virtual secteur secteur { get; set; }
        public virtual ICollection<travailler> travailler { get; set; }
    }
}
