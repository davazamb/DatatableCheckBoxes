using DatatablesCheckBox.WEB.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatatablesCheckBox.WEB.Controllers
{
    public class HomeController : Controller
    {
        Boleta_VTR_DSAEntities context = new Boleta_VTR_DSAEntities();
        public ActionResult Index()
        {
            cargaDatosProcesoVTR();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult BuscarProcesoDisparo(int idProceso)
        {
            if (idProceso != 0)
            {
                cModelos lstDisparo = new cModelos();
                lstDisparo.lstDetalleDisparo = obtieneDetallesDisparos(idProceso);

                var datas = lstDisparo.lstDetalleDisparo.ToList();
                return Json(new { data = datas }, JsonRequestBehavior.AllowGet);

            }
            var datas0 = 0;
            return Json(new { data = datas0 }, JsonRequestBehavior.AllowGet);
        }

        public List<cBoleta_Vtr_Detalle_Disparo> obtieneDetallesDisparos(int codigoProceso)
        {
            List<cBoleta_Vtr_Detalle_Disparo> listadoDisparo = new List<cBoleta_Vtr_Detalle_Disparo>();
            try
            {
                System.Data.SqlClient.SqlParameter[] p = new System.Data.SqlClient.SqlParameter[1];
                p[0] = new System.Data.SqlClient.SqlParameter("codigoProceso", codigoProceso)
                {
                    DbType = DbType.Int64
                };
                listadoDisparo = context.Database.SqlQuery<cBoleta_Vtr_Detalle_Disparo>("sp_Boleta_VTR_Muestra_Informacion_Disparo  @codigoProceso", p).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
            return listadoDisparo;
        }

        public void cargaDatosProcesoVTR()
        {
            List<SelectListItem> listaProcesoDisponibles = new List<SelectListItem>();
            listaProcesoDisponibles.Add(new SelectListItem
            {
                Value = "0",
                Text = "[Seleccione numero de proceso...]",
            });

            var ProcesoDisponible = listadoProcesoDisponibles(1);
            foreach (var itemProcesoDisponible in ProcesoDisponible)

                listaProcesoDisponibles.Add(new SelectListItem { Text = itemProcesoDisponible.descripcion, Value = itemProcesoDisponible.codigo_proceso.ToString() });
            ViewBag.ListadoProcesoDisponibleVtr = listaProcesoDisponibles;

        }

        public List<cBoleta_Vtr_Procesos_Disponibles> listadoProcesoDisponibles(int sw)
        {
            List<cBoleta_Vtr_Procesos_Disponibles> PorcesosDisponibles = new List<cBoleta_Vtr_Procesos_Disponibles>();
            try
            {
                System.Data.SqlClient.SqlParameter[] p = new System.Data.SqlClient.SqlParameter[1];
                p[0] = new System.Data.SqlClient.SqlParameter("sw", sw)
                {
                    DbType = DbType.Int64
                };
                PorcesosDisponibles = context.Database.SqlQuery<cBoleta_Vtr_Procesos_Disponibles>("sp_Obtine_Procesos_Disponibles @sw", p).ToList();
                return PorcesosDisponibles;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

    }
}