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
    
    public partial class tbresultado
    {
        public int lca_id { get; set; }
        public int pla_id { get; set; }
        public int res_cantidad_votos { get; set; }
    
        public virtual tblistacargo tblistacargo { get; set; }
        public virtual tbplanilla tbplanilla { get; set; }
    }
}
