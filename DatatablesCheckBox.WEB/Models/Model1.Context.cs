﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Boleta_VTR_DSAEntities : DbContext
    {
        public Boleta_VTR_DSAEntities()
            : base("name=Boleta_VTR_DSAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Boleta_VTR_Agenda_Job> Boleta_VTR_Agenda_Job { get; set; }
        public virtual DbSet<Boleta_VTR_Alta_OT> Boleta_VTR_Alta_OT { get; set; }
        public virtual DbSet<Boleta_VTR_Auditoria_tipos> Boleta_VTR_Auditoria_tipos { get; set; }
        public virtual DbSet<Boleta_VTR_Ciclo> Boleta_VTR_Ciclo { get; set; }
        public virtual DbSet<Boleta_VTR_Disparo> Boleta_VTR_Disparo { get; set; }
        public virtual DbSet<Boleta_VTR_HTML> Boleta_VTR_HTML { get; set; }
        public virtual DbSet<Boleta_VTR_HTML_Parametros> Boleta_VTR_HTML_Parametros { get; set; }
        public virtual DbSet<Boleta_VTR_Llave> Boleta_VTR_Llave { get; set; }
        public virtual DbSet<Boleta_VTR_OT> Boleta_VTR_OT { get; set; }
        public virtual DbSet<Boleta_VTR_OT_estado> Boleta_VTR_OT_estado { get; set; }
        public virtual DbSet<Boleta_VTR_OT_MuestrasR3> Boleta_VTR_OT_MuestrasR3 { get; set; }
        public virtual DbSet<Boleta_VTR_OT_MuestrasVTR> Boleta_VTR_OT_MuestrasVTR { get; set; }
        public virtual DbSet<Boleta_VTR_PPL_Carga> Boleta_VTR_PPL_Carga { get; set; }
        public virtual DbSet<Boleta_VTR_PPL_clean> Boleta_VTR_PPL_clean { get; set; }
        public virtual DbSet<Boleta_VTR_PPL_exclude> Boleta_VTR_PPL_exclude { get; set; }
        public virtual DbSet<Boleta_VTR_PPL_paso> Boleta_VTR_PPL_paso { get; set; }
        public virtual DbSet<Boleta_VTR_PPL_repeat> Boleta_VTR_PPL_repeat { get; set; }
        public virtual DbSet<Boleta_VTR_PPL_valida> Boleta_VTR_PPL_valida { get; set; }
        public virtual DbSet<Boleta_VTR_PPL_valida_archivos> Boleta_VTR_PPL_valida_archivos { get; set; }
        public virtual DbSet<Boleta_VTR_Procesos> Boleta_VTR_Procesos { get; set; }
        public virtual DbSet<Boleta_VTR_Procesos_audit> Boleta_VTR_Procesos_audit { get; set; }
        public virtual DbSet<Boleta_VTR_Procesos_tipo> Boleta_VTR_Procesos_tipo { get; set; }
        public virtual DbSet<Boleta_VTR_SWDEM> Boleta_VTR_SWDEM { get; set; }
        public virtual DbSet<Boleta_VTR_TipoServicio> Boleta_VTR_TipoServicio { get; set; }
        public virtual DbSet<Boleta_VTR_VTR_clean> Boleta_VTR_VTR_clean { get; set; }
        public virtual DbSet<Boleta_VTR_VTR_exclude> Boleta_VTR_VTR_exclude { get; set; }
        public virtual DbSet<Boleta_VTR_VTR_paso> Boleta_VTR_VTR_paso { get; set; }
        public virtual DbSet<Boleta_VTR_VTR_repeat> Boleta_VTR_VTR_repeat { get; set; }
        public virtual DbSet<Boleta_VTR_VTR_valida> Boleta_VTR_VTR_valida { get; set; }
        public virtual DbSet<Boleta_VTR_VTR_valida_archivos> Boleta_VTR_VTR_valida_archivos { get; set; }
        public virtual DbSet<Boleta_VTR_VTR_PPL_clean> Boleta_VTR_VTR_PPL_clean { get; set; }
        public virtual DbSet<FiltrosQueryBuilder> FiltrosQueryBuilder { get; set; }
        public virtual DbSet<PowerBi_Disparos> PowerBi_Disparos { get; set; }
    }
}