//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Stocktronic.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PF_CATEGORIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PF_CATEGORIA()
        {
            this.PF_PRODUCTO = new HashSet<PF_PRODUCTO>();
        }
    
        public long ID_CATEGORIA { get; set; }
        public string CAT_TIPO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PF_PRODUCTO> PF_PRODUCTO { get; set; }
    }
}
