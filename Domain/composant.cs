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
    
    public partial class composant
    {
        public composant()
        {
            this.constituer = new HashSet<constituer>();
        }
    
        public int id_composant { get; set; }
        public string lib_composant { get; set; }
    
        public virtual ICollection<constituer> constituer { get; set; }
    }
}
