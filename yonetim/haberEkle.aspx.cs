using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yonetim_haberEkle : System.Web.UI.Page
{
    veritabani vt = new veritabani();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        vt.komut("insert into haberler (haberadi, haberdurum, haberhedef) values ('" + txtBaslik.Text + "', '" + ddlAnasayfa.SelectedValue + "', '" + txtHaberHedef.Text + "')");
        Response.Redirect("haberler.aspx");
    }
}