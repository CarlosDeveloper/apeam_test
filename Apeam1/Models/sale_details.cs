//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apeam1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class sale_details
    {
        public int Id { get; set; }
        public string article { get; set; }
        public double quantity { get; set; }
        public double unit_price { get; set; }
        public Nullable<int> sale_id { get; set; }
    
        public virtual sales sales { get; set; }
    }
}