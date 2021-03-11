using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yonetim_dosyaEkle : System.Web.UI.Page
{
    veritabani vt = new veritabani();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        vt.komut("insert into dosyalar (dosya_ad, dosya_hedef, dosya_guncellemetarihi, dosya_durum) values ('" + txtAd.Text + "', '" + txtHedef.Text + "', '" + DateTime.Today + "', '" + ddlAnasayfa.SelectedValue + "')");
        Response.Redirect("dosyalar.aspx");
    }
}