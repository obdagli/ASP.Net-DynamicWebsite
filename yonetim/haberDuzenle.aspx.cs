using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class yonetim_haberDuzenle : System.Web.UI.Page
{
    veritabani vt = new veritabani();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["haber_id"] == null)
        {
            Response.Redirect("haberler.aspx");
        }
        if (!Page.IsPostBack)
        {
            string haber_id = Request.QueryString["haber_id"];
            DataRow drHaberler = vt.getDataRow("select * from haberler where haber_id =" + haber_id);
            txtHaberAd.Text = drHaberler["haberadi"].ToString();
            txtHaberHedef.Text = drHaberler["haberhedef"].ToString();
            ddlAnasayfa.SelectedValue = drHaberler["haberdurum"].ToString();
        }
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string haber_id = Request.QueryString["haber_id"];
        vt.komut("update haberler set haberadi ='" + txtHaberAd.Text + "', haberhedef ='" + txtHaberHedef.Text + "', haberdurum ='" + ddlAnasayfa.SelectedValue + "' where haber_id =" + haber_id);
        Response.Redirect("haberler.aspx");
    }
}