using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class yonetim_haberler : System.Web.UI.Page
{
    veritabani vt = new veritabani();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dtKategoriler = vt.getDataTable(@"select * from haberler");
        DataListHaberler.DataSource = dtKategoriler;
        DataListHaberler.DataBind();
        if (Request.QueryString["haber_id"] != null && Request.QueryString["islem"] == "sil")
        {
            string haber_id = Request.QueryString["haber_id"];
            vt.komut("delete from haberler where haber_id=" + haber_id);
            Response.Redirect("haberler.aspx");
        }
    }
}