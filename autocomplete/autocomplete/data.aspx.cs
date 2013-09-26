using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace autocomplete
{
    public partial class data : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var query = Request["query"];
            var data = new[] { "aaaa", "aaaaa", "abbbb", "aabb", "abc", "abcc", "bbb", "bbc", "c" };
            Response.ContentType = "application/json";
            Response.Write(new JavaScriptSerializer().Serialize(data.Where(s => s.Contains(query))));
        }
    }
}