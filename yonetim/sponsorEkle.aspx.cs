using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yonetim_sponsorEkle : System.Web.UI.Page
{
    veritabani vt = new veritabani();
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        vt.komut("insert into sponsor (sponsor_ad, sponsor_metin, sponsor_hedef, sponsor_durum) values ('" + txtSponsorAd.Text + "', '" + txtSponsorMetin.Text + "', '" + txtSponsorHedef.Text + "', '" + ddlGizlilik.SelectedValue + "')");
        Response.Redirect("sponsorlar.aspx");
    }
}