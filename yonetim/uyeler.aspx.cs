using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class yonetim_uyeler : System.Web.UI.Page
{
    veritabani vt = new veritabani();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dtKategoriler = vt.getDataTable(@"select * from uyeler");
        DataListUyeler.DataSource = dtKategoriler;
        DataListUyeler.DataBind();
        if (Request.QueryString["uye_id"] != null && Request.QueryString["islem"] == "sil")
        {
            string uye_id = Request.QueryString["uye_id"];
            vt.komut("delete from uyeler where uye_id=" + uye_id);
            Response.Redirect("uyeler.aspx");
        }
    }
}