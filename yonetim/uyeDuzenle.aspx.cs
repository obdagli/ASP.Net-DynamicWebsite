using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class yonetim_uyeDuzenle : System.Web.UI.Page
{
    veritabani vt = new veritabani();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["uye_id"] == null)
        {
            Response.Redirect("uyeler.aspx");
        }
        if (!Page.IsPostBack)
        {
            string uye_id = Request.QueryString["uye_id"];
            DataRow drHaberler = vt.getDataRow("select * from uyeler where uye_id =" + uye_id);
            txtUyeAd.Text = drHaberler["uye_ad"].ToString();
            txtUyeSifre.Text = drHaberler["uye_sifre"].ToString();
            txtUyeBakiye.Text = drHaberler["uye_bakiye"].ToString();
            ddlAnasayfa.SelectedValue = drHaberler["uye_yetki"].ToString();
        }
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string uye_id = Request.QueryString["uye_id"];
        vt.komut("update uyeler set uye_ad ='" + txtUyeAd.Text + "', uye_sifre ='" + txtUyeSifre.Text + "', uye_yetki ='" + ddlAnasayfa.SelectedItem.Text + "', uye_bakiye ='" + txtUyeBakiye.Text + "' where uye_id =" + uye_id);
        Response.Redirect("uyeler.aspx");
    }
}