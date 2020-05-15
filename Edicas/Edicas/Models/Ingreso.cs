//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Edicas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ingreso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ingreso()
        {
            this.DetalleIngreso = new HashSet<DetalleIngreso>();
        }
    
        public int IDIngreso { get; set; }
        public string DNI { get; set; }
        public int IDProveedor { get; set; }
        public Nullable<System.DateTime> ingFecha { get; set; }
        public Nullable<int> ingTotal { get; set; }
        public bool ingEstado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleIngreso> DetalleIngreso { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Proveedor Proveedor { get; set; }
    }
}
