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
    
    public partial class DetalleIngreso
    {
        public int IDIngreso { get; set; }
        public int IDProducto { get; set; }
        public Nullable<int> detCantidad { get; set; }
        public decimal detPrecio { get; set; }
    
        public virtual Ingreso Ingreso { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
