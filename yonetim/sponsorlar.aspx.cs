using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class yonetim_sponsorlar : System.Web.UI.Page
{
    veritabani vt = new veritabani();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dtSponsor = vt.getDataTable("Select * From sponsor Order By [sponsor_id] Desc");
        DataListSponsorlar.DataSource = dtSponsor;
        DataListSponsorlar.DataBind();

        if (Request.QueryString["sponsor_id"] != null && Request.QueryString["islem"] == "sil")
        {
            string gelenKategoriId = Request.QueryString["sponsor_id"];
            vt.komut("Delete From [sponsor] Where [sponsor_id]=" + gelenKategoriId);

            Response.Redirect("sponsorlar.aspx");
        }
    }
}