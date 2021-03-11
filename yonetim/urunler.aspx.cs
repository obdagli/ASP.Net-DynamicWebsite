using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class yonetim_urunler : System.Web.UI.Page
{
    veritabani vt = new veritabani();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dtKategoriler = vt.getDataTable(@"SELECT        urunler.*, altkategori.altkategori_ad
FROM            (urunler INNER JOIN
                         altkategori ON urunler.altkategori_id = altkategori.altkategori_id) order by [altkategori_ad] desc");
        DataListUrunler.DataSource = dtKategoriler;
        DataListUrunler.DataBind();
        if (Request.QueryString["urun_id"] != null && Request.QueryString["islem"] == "sil")
        {
            string urun_id = Request.QueryString["urun_id"];
            vt.komut("delete from urunler where urun_id=" + urun_id);
            Response.Redirect("urunler.aspx");
        }
    }
}