using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatatablesCheckBox.WEB.Models
{
    public class cBoleta_Vtr_Procesos
    {                                              
        public string Desc_Proceso { get; set; }  
        public int Codigo_Reg_TipoServicio { get; set; }  
        public int Codigo_Reg_Ciclo { get; set; }   
        public int Codigo_proceso_tipo { get; set; }  
        public DateTime Mes_Operacion { get; set; }   
        public int Estado { get; set; }           
        public DateTime Fec_creacion { get; set; }  
        public int? codigo_usuario { get; set; } 
        public int informe_cuadratura { get; set; } 
        public int informe_disparo { get; set; }  
        public int codigo_proceso { get; set; }
    }
}