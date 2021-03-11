using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yonetim_uyeEkle : System.Web.UI.Page
{
    veritabani vt = new veritabani();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        vt.komut("insert into uyeler (uye_ad, uye_yetki, uye_sifre) values ('" + txtKullaniciAdi.Text + "', '" + ddlAnasayfa.SelectedItem.Text + "', '" + txtSifre.Text + "')");
        Response.Redirect("uyeler.aspx");
    }
}