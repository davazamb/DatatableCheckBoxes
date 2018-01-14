using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatatablesCheckBox.WEB.Models
{
    public class cBoleta_Vtr_Detalle_Disparo
    {                                            
        public int Codigo_Proceso { get; set; }    
        public DateTime Mes_Operacion { get; set; }    
        public int Codigo_OT { get; set; }       
        public string Estado { get; set; }      
        public int Codigo_Estado { get; set; }    
        public string Tipo_Proceso { get; set; }   
        public string Tipo_Servicio { get; set; }    
        public string Ciclo { get; set; }     
        public int? Cantidad { get; set; }
    }
}