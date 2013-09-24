using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cargarCombo
{
    public partial class cargarmarcas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var callback = Request["callback"];

            var marcas = new List<dynamic>();
            marcas.Add(new { Id = "ford", nombre = "ford" });
            marcas.Add(new { Id = "renault", nombre = "renault" });
            marcas.Add(new {Id = "citroen", nombre = "citroen" });
            marcas.Add(new { Id = "peugeot", nombre = "peugeot" });

            Response.ContentType = "text/javascript";
            var datos = new JavaScriptSerializer().Serialize(marcas);

            Response.Write(string.Format("{0}({1})", callback, datos ));
        }
    }
}