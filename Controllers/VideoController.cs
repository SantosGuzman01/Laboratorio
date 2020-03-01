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
        public ActionResult Borrar()
        {
            
            return View();
        }

        public ActionResult Creates()
        {

            return View();
        }

        public ActionResult Modificar()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Borrar(int idvideo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("idVideo", idvideo));

            BaseHelper.ejecutarSentencia("DELETE * FROM VIDEO WHERE idVideo = idVideo", CommandType.Text,parametros);
            return View("MensajeBorrar");
        }
        [HttpPost]
        public ActionResult Creates(int idvideo, string titulo, int repro, string url)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("idVideo", idvideo));
            parametros.Add(new SqlParameter("titulo", titulo));
            parametros.Add(new SqlParameter("repro", repro));
            parametros.Add(new SqlParameter("url", url));

            BaseHelper.ejecutarSentencia("INSERT INTO VIDEO" + "VALUES(@idvideo,@titulo,@repro,@url)", CommandType.Text, parametros);
            return View("MensajeCrear");
        }
        [HttpPost]
        public ActionResult Modificar(string titulo, int repro, string url,int video)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("titulo", titulo));
            parametros.Add(new SqlParameter("repro", repro));
            parametros.Add(new SqlParameter("url", url));
            parametros.Add(new SqlParameter("idVideo", idVideo));

            BaseHelper.ejecutarSentencia("UPDATE VIDEO SET titulo = titulo, repro = repro, url = url WHERE idVideo = idVideo", CommandType.Text, parametros);
            return View("MensajeModificar");
        }
    }
}
