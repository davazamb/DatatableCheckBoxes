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
    
    public partial class Boleta_VTR_Procesos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Boleta_VTR_Procesos()
        {
            this.Boleta_VTR_Agenda_Job = new HashSet<Boleta_VTR_Agenda_Job>();
            this.Boleta_VTR_OT = new HashSet<Boleta_VTR_OT>();
            this.Boleta_VTR_PPL_Carga = new HashSet<Boleta_VTR_PPL_Carga>();
            this.Boleta_VTR_Procesos_audit = new HashSet<Boleta_VTR_Procesos_audit>();
        }
    
        public int Codigo_Reg_Proceso { get; set; }
        public int Codigo_Reg_TipoServicio { get; set; }
        public int Codigo_Reg_Ciclo { get; set; }
        public Nullable<int> Codigo_Reg_ProcesoTipo { get; set; }
        public string Desc_Proceso { get; set; }
        public Nullable<System.DateTime> Mes_Operacion { get; set; }
        public Nullable<int> Estado { get; set; }
        public Nullable<int> Codigo_Reg_Usuario { get; set; }
        public Nullable<int> Informe_Cuadratura { get; set; }
        public Nullable<int> Informe_Disparo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Boleta_VTR_Agenda_Job> Boleta_VTR_Agenda_Job { get; set; }
        public virtual Boleta_VTR_Ciclo Boleta_VTR_Ciclo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Boleta_VTR_OT> Boleta_VTR_OT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Boleta_VTR_PPL_Carga> Boleta_VTR_PPL_Carga { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Boleta_VTR_Procesos_audit> Boleta_VTR_Procesos_audit { get; set; }
        public virtual Boleta_VTR_Procesos_tipo Boleta_VTR_Procesos_tipo { get; set; }
        public virtual Boleta_VTR_TipoServicio Boleta_VTR_TipoServicio { get; set; }
    }
}
