using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yonetim_yonetim : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {        
        if (Session["uye_ad"] == null || Session["uye_yetki"].ToString() == "kullanici")
        {
            Response.Redirect("../Default.aspx");
        }
        lblkullanici.Text = Session["uye_ad"].ToString();
    }

    protected void lbtnCikis_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("../Default.aspx");
    }
}
