using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yonetim_anasayfaResimEkle : System.Web.UI.Page
{
    veritabani vt = new veritabani();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string yol = ImageanasayfaResim.ImageUrl;
        if (FileUpload1.HasFile)
        {
            yol = vt.resimKaydetAnaSayfa(FileUpload1, 550, "../resimler/default/");
        }
        vt.komut("insert into anasayfa_gerecler (gerec_foto, gerec_durum) values ('" + yol + "', '" + ddlResimKonum.SelectedValue + "')");
        Response.Redirect("anasayfaResimler.aspx");
    }
}