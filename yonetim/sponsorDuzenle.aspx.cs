using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class yonetim_sponsorDuzenle : System.Web.UI.Page
{
    veritabani vt = new veritabani();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["sponsor_id"] == null)
        {
            Response.Redirect("sponsorlar.aspx");
        }
        if (!Page.IsPostBack)
        {
            string sponsor_id = Request.QueryString["sponsor_id"];
            DataRow drSponsor = vt.getDataRow("select * from sponsor where sponsor_id =" + sponsor_id);
            txtAd.Text = drSponsor["sponsor_ad"].ToString();
            ImageSponsor.ImageUrl = "../" + drSponsor["sponsor_resim"].ToString();
            txtHedef.Text = drSponsor["sponsor_hedef"].ToString();
            txtMetin.Text = drSponsor["sponsor_metin"].ToString();

        }
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string yol = ImageSponsor.ImageUrl;
        string sponsor_id = Request.QueryString["sponsor_id"];
        if (FileUpload1.HasFile)
        {
            yol = vt.resimKaydetSponsor_Slider(FileUpload1, 360, "../resimler/sponsor_resimler/");
        }
        //vt.komut("update urunler set urun_ad ='" + txtUrunAd.Text + "', urun_fiyat ='" + txtUrunFiyat.Text + "', urun_BilgiBaslik ='" + txtUrunBaslik.Text + "', urun_BilgiMetin ='" + txtUrunBilgi.Text + "', urun_foto ='" + yol + "' where urun_id =" + urun_id);
        vt.komut("update sponsor set sponsor_ad ='" + txtAd.Text + "', sponsor_metin ='" + txtMetin.Text + "', sponsor_hedef ='" + txtHedef.Text + "', sponsor_durum ='" + ddlGizlilik.SelectedValue + "', [sponsor_resim]='" + yol + "' where sponsor_id =" + sponsor_id);
        Response.Redirect("sponsorlar.aspx");
    }
}