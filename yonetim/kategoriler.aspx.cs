using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class yonetim_kategoriler : System.Web.UI.Page
{
    veritabani vt = new veritabani();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dtKategoriler = vt.getDataTable("select * from kategori order by [kategori_id] desc");
        DataListKategoriler.DataSource = dtKategoriler;
        DataListKategoriler.DataBind();
        if (Request.QueryString["kategori_id"] != null && Request.QueryString["islem"] == "sil")
        {
            string gelenKategoriId = Request.QueryString["kategori_id"];
            vt.komut("delete from kategori where kategori_id=" + gelenKategoriId);
            Response.Redirect("kategoriler.aspx");
        }
    }
}