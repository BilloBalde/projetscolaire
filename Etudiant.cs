//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ges_scolaire
{
    using System;
    using System.Collections.Generic;
    
    public partial class Etudiant
    {
        public int id { get; set; }
        public string prenom { get; set; }
        public string nom { get; set; }
        public Nullable<int> credit { get; set; }
        public Nullable<int> versement { get; set; }
        public string annescolaire { get; set; }
        public int idClasse { get; set; }
    
        public virtual Classe Classe { get; set; }
    }
}
