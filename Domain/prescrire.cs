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
    
    public partial class prescrire
    {
        public int id_dosage { get; set; }
        public int id_medicament { get; set; }
        public int id_type_individu { get; set; }
        public string posologie { get; set; }
    
        public virtual dosage dosage { get; set; }
        public virtual medicament medicament { get; set; }
        public virtual type_individu type_individu { get; set; }
    }
}
