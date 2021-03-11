using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class yonetim_altKategoriler : System.Web.UI.Page
{
    veritabani vt = new veritabani();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dtKategoriler = vt.getDataTable(@"SELECT        altkategori.*, kategori.kategori_adi
FROM            (altkategori INNER JOIN
                         kategori ON altkategori.kategori_id = kategori.kategori_id)");
        DataListAltKategoriler.DataSource = dtKategoriler;
        DataListAltKategoriler.DataBind();
        if (Request.QueryString["altkategori_id"] != null && Request.QueryString["islem"] == "sil")
        {
            string gelenaltKategoriId = Request.QueryString["altkategori_id"];
            vt.komut("delete from altkategori where altkategori_id=" + gelenaltKategoriId);
            Response.Redirect("altKategoriler.aspx");
        }
    }
}