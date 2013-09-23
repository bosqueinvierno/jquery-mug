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
            var marcas = new List<dynamic>();
            marcas.Add(new { Id = "ford", nombre = "ford" });
            marcas.Add(new { Id = "renault", nombre = "renault" });
            marcas.Add(new {Id = "citroen", nombre = "citroen" });
            marcas.Add(new { Id = "peugeot", nombre = "peugeot" });

            Response.ContentType = "application/json";
            Response.Write(new JavaScriptSerializer().Serialize(marcas));
        }
    }
}