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
    
    public partial class laboratoire
    {
        public laboratoire()
        {
            this.visiteur = new HashSet<visiteur>();
        }
    
        public int id_laboratoire { get; set; }
        public string nom_laboratoire { get; set; }
        public string chef_vente { get; set; }
    
        public virtual ICollection<visiteur> visiteur { get; set; }
    }
}
