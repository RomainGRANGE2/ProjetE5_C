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
    
    public partial class type_individu
    {
        public type_individu()
        {
            this.prescrire = new HashSet<prescrire>();
        }
    
        public int id_type_individu { get; set; }
        public string lib_type_individu { get; set; }
    
        public virtual ICollection<prescrire> prescrire { get; set; }
    }
}
