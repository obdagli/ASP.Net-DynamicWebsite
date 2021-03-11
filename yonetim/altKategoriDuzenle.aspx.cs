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
        if (Request.QueryString["altkategori_id"] == null)
        {
            Response.Redirect("altKategoriler.aspx");
        }
        if (!Page.IsPostBack)
        {
            kategoriDoldur();
            string altkategori_id = Request.QueryString["altkategori_id"];
            DataRow drAltKategori = vt.getDataRow("select * from altkategori where altkategori_id =" + altkategori_id);
            txtAltKategoriAd.Text = drAltKategori["altkategori_ad"].ToString();
            ddlKategori.SelectedValue = drAltKategori["kategori_id"].ToString();
            txtAltKategoriMetin.Text = drAltKategori["altkategori_ustbilgi"].ToString();
            ddlAnasayfa.SelectedValue = drAltKategori["altkategori_durum"].ToString();
            ImageKategoriler.ImageUrl = "../"+drAltKategori["altkategori_foto"].ToString();
            hlUrunBuyukFotograf.NavigateUrl = "altKategoriFotoDuzenle.aspx?altkategori_id=" + drAltKategori["altkategori_id"];
        }
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string yol = ImageKategoriler.ImageUrl;
        string altkategori_id = Request.QueryString["altkategori_id"];
        if (FileUpload1.HasFile)
        {
            yol = vt.resimKaydet(FileUpload1, 520, "../resimler/urunler_resim/");
        }
        vt.komut("update altkategori set altkategori_ad ='" + txtAltKategoriAd.Text + "', altkategori_foto ='" + yol + "', altkategori_ustbilgi ='" + txtAltKategoriMetin.Text + "', altkategori_durum ='" + ddlAnasayfa.SelectedValue + "', [kategori_id]='" + ddlKategori.SelectedValue + "' where altkategori_id =" + altkategori_id);
        Response.Redirect("altKategoriler.aspx");
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