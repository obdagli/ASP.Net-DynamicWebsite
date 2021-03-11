using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yonetim_kategoriEkle : System.Web.UI.Page
{
    veritabani vt = new veritabani();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        vt.komut("insert into kategori (kategori_adi, kategori_durum) values ('"+txtAd.Text+ "', '" + ddlAnasayfa.SelectedValue + "')");
        Response.Redirect("kategoriler.aspx");
    }
}