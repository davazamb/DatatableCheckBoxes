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
    
    public partial class Boleta_VTR_PPL_valida
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Boleta_VTR_PPL_valida()
        {
            this.Boleta_VTR_PPL_paso = new HashSet<Boleta_VTR_PPL_paso>();
        }
    
        public int Codigo_Reg_Valida { get; set; }
        public int Codigo_Reg_ValArchivo { get; set; }
        public Nullable<int> Codigo_Reg_Proceso { get; set; }
        public string Data { get; set; }
        public Nullable<int> Cantidad_Separadores { get; set; }
        public int Codigo_OT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Boleta_VTR_PPL_paso> Boleta_VTR_PPL_paso { get; set; }
        public virtual Boleta_VTR_PPL_valida_archivos Boleta_VTR_PPL_valida_archivos { get; set; }
    }
}