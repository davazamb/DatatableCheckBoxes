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
    
    public partial class Boleta_VTR_Procesos_audit
    {
        public int Codigo_Reg_Audit { get; set; }
        public int Codigo_Reg_Proceso { get; set; }
        public int Codigo_Reg_AuditTipos { get; set; }
        public Nullable<System.DateTime> Fecha_Audit { get; set; }
        public Nullable<int> Codigo_Reg_Usuario { get; set; }
    
        public virtual Boleta_VTR_Auditoria_tipos Boleta_VTR_Auditoria_tipos { get; set; }
        public virtual Boleta_VTR_Procesos Boleta_VTR_Procesos { get; set; }
    }
}
