//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MilitappRest.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbfiscal
    {
        public tbfiscal()
        {
            this.tbplanilla = new HashSet<tbplanilla>();
        }
    
        public int fis_id { get; set; }
        public int fis_dni { get; set; }
        public string fis_nombre { get; set; }
        public string fis_apellido { get; set; }
    
        public virtual ICollection<tbplanilla> tbplanilla { get; set; }
    }
}
