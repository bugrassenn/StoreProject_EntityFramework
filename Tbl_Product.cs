//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityProjectApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Product()
        {
            this.Tbl_Sales = new HashSet<Tbl_Sales>();
        }
    
        public int PRODUCTID { get; set; }
        public string PRODUCTNAME { get; set; }
        public string BRAND { get; set; }
        public Nullable<short> STOCK { get; set; }
        public Nullable<decimal> PRICE { get; set; }
        public Nullable<bool> STATUS { get; set; }
        public Nullable<int> CATEGORY { get; set; }
    
        public virtual Tbl_Categories Tbl_Categories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Sales> Tbl_Sales { get; set; }
    }
}
