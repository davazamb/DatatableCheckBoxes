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
    
    public partial class Boleta_VTR_SWDEM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Boleta_VTR_SWDEM()
        {
            this.Boleta_VTR_Agenda_Job = new HashSet<Boleta_VTR_Agenda_Job>();
            this.Boleta_VTR_PPL_valida_archivos = new HashSet<Boleta_VTR_PPL_valida_archivos>();
            this.Boleta_VTR_VTR_valida_archivos = new HashSet<Boleta_VTR_VTR_valida_archivos>();
        }
    
        public int Codigo_Reg_SWDEM { get; set; }
        public string Ruta_Fichero { get; set; }
        public string Separador { get; set; }
        public Nullable<int> Cantidad_Separadores { get; set; }
        public string Extensiones { get; set; }
        public string Nombre_Servicio { get; set; }
        public string Nombre_Corto { get; set; }
        public Nullable<int> Disponible { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Boleta_VTR_Agenda_Job> Boleta_VTR_Agenda_Job { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Boleta_VTR_PPL_valida_archivos> Boleta_VTR_PPL_valida_archivos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Boleta_VTR_VTR_valida_archivos> Boleta_VTR_VTR_valida_archivos { get; set; }
    }
}
