//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrabajoFinal.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CategoriaHorario
    {
        public int IDCategoriaHorario { get; set; }
        public Nullable<int> IDCategoria { get; set; }
        public string Dia { get; set; }
        public string HoraInicio { get; set; }
        public Nullable<int> IDEstablecimiento { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        public virtual Establecimiento Establecimiento { get; set; }
    }
}
