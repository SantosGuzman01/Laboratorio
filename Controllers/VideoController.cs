using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using MVCPlantilla.Utilerias;


namespace MvcPlantilla.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {
            ViewData["video"] =  BaseHelper.ejecutarConsulta("Select * from video", CommandType.Text);
            return View();
        }

        [HttpPost]
        public ActionResult Creates(int idvideo, string titulo, int repro, string url)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("idVideo", idvideo));
            parametros.Add(new SqlParameter("titulo", titulo));
            parametros.Add(new SqlParameter("repro", repro));
            parametros.Add(new SqlParameter("url", url));

            BaseHelper.ejecutarSentencia("INSERT INTO empleados" + "VALUES(@idvideo,@titulo,@repro,@url)", CommandType.Text, parametros);
        }
    }
}
