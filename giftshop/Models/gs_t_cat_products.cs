//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace giftshop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class gs_t_cat_products
    {
        public int idproduct { get; set; }
        public int idcategory { get; set; }
        public string product { get; set; }
        public string description { get; set; }
        public string sku { get; set; }
        public Nullable<double> price { get; set; }
    }
}
