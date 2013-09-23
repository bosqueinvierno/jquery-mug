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
            var marcas = new List<Marca>();
            marcas.Add(new Marca { Id = "ford", nombre = "ford" });
            marcas.Add(new Marca { Id = "renault", nombre = "renault" });
            marcas.Add(new Marca { Id = "citroen", nombre = "citroen" });
            marcas.Add(new Marca { Id = "peugeot", nombre = "peugeot" });

            Response.ContentType = "application/json";
            Response.Write(new JavaScriptSerializer().Serialize(marcas));
        }
    }

    public class Marca
    {
        public string Id { get; set; }
        public string nombre { get; set; }
    }
}