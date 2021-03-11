using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class yonetim_urunEkle : System.Web.UI.Page
{
    veritabani vt = new veritabani();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            kategoriDoldur();
        }

    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        vt.komut("insert into urunler (urun_ad, urun_fiyat, urun_BilgiBaslik, urun_BilgiMetin, altkategori_id) values ('" + txtUrunAd.Text + "', '" + txtUrunFiyat.Text + "', '" + txtUrunBaslik.Text + "', '" + txtUrunBilgi.Text + "', '" + ddlKategori.SelectedValue + "')");
        Response.Redirect("urunler.aspx");
    }
    void kategoriDoldur()
    {
        DataTable dtKategoriler = vt.getDataTable("select * from altkategori");
        ddlKategori.DataSource = dtKategoriler;
        ddlKategori.DataTextField = "altkategori_ad";
        ddlKategori.DataValueField = "altkategori_id";
        ddlKategori.DataBind();
    }
}