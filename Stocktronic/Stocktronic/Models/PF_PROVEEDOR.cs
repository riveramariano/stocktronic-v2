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
    
    public partial class PF_PROVEEDOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PF_PROVEEDOR()
        {
            this.PF_H_ENTREGAS = new HashSet<PF_H_ENTREGAS>();
            this.PF_PRODUCTO = new HashSet<PF_PRODUCTO>();
        }
    
        public long ID_PROVEEDOR { get; set; }
        public string PROV_NOMBRE { get; set; }
        public string PROV_CED_JURIDICA { get; set; }
        public System.DateTime PROV_FEC_AFILIACION { get; set; }
        public long FK_ID_SUCURSAL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PF_H_ENTREGAS> PF_H_ENTREGAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PF_PRODUCTO> PF_PRODUCTO { get; set; }
        public virtual PF_SUCURSAL PF_SUCURSAL { get; set; }
    }
}
