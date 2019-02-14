using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Property_cls;
using System.Data;

namespace Property
{
    public partial class UpcomingProjects : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cls_Property clsobj = new cls_Property();
            DataTable dt = clsobj.GetSiteSettings();
            if (dt.Rows.Count > 0)
            {
                siteTitle.Text = Convert.ToString(dt.Rows[0]["Title"]);
                // lblemail.Text = Convert.ToString(dt.Rows[0]["Email"]);
            }
        }
    }
}