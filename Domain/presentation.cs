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
    
    public partial class presentation
    {
        public presentation()
        {
            this.formuler = new HashSet<formuler>();
        }
    
        public int id_presentation { get; set; }
        public string lib_presentation { get; set; }
    
        public virtual ICollection<formuler> formuler { get; set; }
    }
}
