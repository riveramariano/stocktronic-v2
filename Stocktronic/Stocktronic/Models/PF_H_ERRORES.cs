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
    
    public partial class PF_H_ERRORES
    {
        public long ID_ERRORES { get; set; }
        public System.DateTime ERR_FEC { get; set; }
        public string ERR_DESCRIPCION { get; set; }
        public long FK_ID_USUARIO { get; set; }
    
        public virtual PF_USUARIO PF_USUARIO { get; set; }
    }
}