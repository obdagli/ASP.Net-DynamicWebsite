using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class yonetim_dosyaDuzenle : System.Web.UI.Page
{
    veritabani vt = new veritabani();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["dosya_id"] == null)
        {
            Response.Redirect("dosyalar.aspx");
        }
        if (!Page.IsPostBack)
        {
            string dosya_id = Request.QueryString["dosya_id"];
            DataRow drDosya = vt.getDataRow("select * from dosyalar where dosya_id =" + dosya_id);
            txtAd.Text = drDosya["dosya_ad"].ToString();
            txtHedef.Text = drDosya["dosya_hedef"].ToString();
        }
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string dosya_id = Request.QueryString["dosya_id"];
        vt.komut("update dosyalar set dosya_ad ='" + txtAd.Text + "', dosya_durum ='" + ddlGizlilik.SelectedValue + "', dosya_guncellemetarihi='" + DateTime.Today + "' where dosya_id =" + dosya_id);
        Response.Redirect("dosyalar.aspx");
    }
}