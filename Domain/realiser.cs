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
    
    public partial class realiser
    {
        public int id_activite_compl { get; set; }
        public int id_visiteur { get; set; }
        public Nullable<decimal> montant_ac { get; set; }
    
        public virtual activite_compl activite_compl { get; set; }
        public virtual visiteur visiteur { get; set; }
    }
}
