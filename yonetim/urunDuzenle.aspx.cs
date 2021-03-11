using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class yonetim_urunDuzenle : System.Web.UI.Page
{
    veritabani vt = new veritabani();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["urun_id"] == null)
        {
            Response.Redirect("urunler.aspx");
        }
        if (!Page.IsPostBack)
        {
            string urun_id = Request.QueryString["urun_id"];
            DataRow drUrun = vt.getDataRow("select * from urunler where urun_id =" + urun_id);
            txtUrunAd.Text = drUrun["urun_ad"].ToString();
            txtUrunFiyat.Text = drUrun["urun_fiyat"].ToString();
            txtUrunBaslik.Text = drUrun["urun_BilgiBaslik"].ToString();
            txtUrunBilgi.Text = drUrun["urun_BilgiMetin"].ToString();
            ImageUrunler.ImageUrl = "../" + drUrun["urun_foto"].ToString();
        }
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string yol = ImageUrunler.ImageUrl;
        string urun_id = Request.QueryString["urun_id"];
        if (FileUpload1.HasFile)
        {
            yol = vt.resimKaydet2(FileUpload1, 520, "../resimler/urundetay_resim/");
        }
        //vt.komut("update urunler set urun_ad ='" + txtUrunAd.Text + "', urun_fiyat ='" + txtUrunFiyat.Text + "', urun_BilgiBaslik ='" + txtUrunBaslik.Text + "', urun_BilgiMetin ='" + txtUrunBilgi.Text + "', urun_foto ='" + yol + "' where urun_id =" + urun_id);
        vt.komut("update urunler set urun_ad ='" + txtUrunAd.Text + "', urun_fiyat ='" + txtUrunFiyat.Text + "', urun_BilgiBaslik ='" + txtUrunBaslik.Text + "', urun_BilgiMetin ='" + txtUrunBilgi.Text + "', [urun_foto]='" + yol + "' where urun_id =" + urun_id);
        Response.Redirect("urunler.aspx");
    }
}