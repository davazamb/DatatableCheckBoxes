//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatatablesCheckBox.WEB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Boleta_VTR_PPL_exclude
    {
        public int Codigo_Reg_Exclude { get; set; }
        public Nullable<int> Codigo_Reg_ValArchivo { get; set; }
        public Nullable<int> Codigo_Reg_Valida { get; set; }
        public Nullable<int> Codigo_Reg_EtapaProceso { get; set; }
        public Nullable<int> Codigo_Reg_Proceso { get; set; }
        public string Data { get; set; }
        public Nullable<int> Cantidad_Separadores { get; set; }
        public Nullable<int> Codigo_OT { get; set; }
    
        public virtual Boleta_VTR_PPL_valida_archivos Boleta_VTR_PPL_valida_archivos { get; set; }
    }
}
