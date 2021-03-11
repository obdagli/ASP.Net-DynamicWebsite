using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class yonetim_altKategoriEkle : System.Web.UI.Page
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
        vt.komut("insert into altkategori (altkategori_ad, altkategori_durum, kategori_id) values ('" + txtAd.Text + "', '" + ddlAnasayfa.SelectedValue + "', '" + ddlKategori.SelectedValue + "')");
        Response.Redirect("kategoriler.aspx");
    }
    void kategoriDoldur()
    {
        DataTable dtKategoriler = vt.getDataTable("select * from kategori");
        ddlKategori.DataSource = dtKategoriler;
        ddlKategori.DataTextField = "kategori_adi";
        ddlKategori.DataValueField = "kategori_id";
        ddlKategori.DataBind();
    }
}