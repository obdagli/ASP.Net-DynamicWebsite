using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class yonetim_bilgiDuzenle : System.Web.UI.Page
{
    veritabani vt = new veritabani();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            bilgiDoldur();
            DataRow drBilgi = vt.getDataRow("select * from bilgi where bilgi_id=" + ddlBilgiAd.SelectedValue);
            CKEbilgiMetin.Text = drBilgi["bilgi_metin"].ToString();
        }
    }

    protected void ibtnGuncelle_Click(object sender, ImageClickEventArgs e)
    {
        vt.komut("update bilgi set bilgi_metin='"+CKEbilgiMetin.Text+"' where bilgi_id="+ddlBilgiAd.SelectedValue);
    }
    void bilgiDoldur()
    {
        DataTable dtBilgiler = vt.getDataTable("select * from bilgi");
        ddlBilgiAd.DataSource = dtBilgiler;
        ddlBilgiAd.DataTextField = "bilgi_baslik";
        ddlBilgiAd.DataValueField = "bilgi_id";
        ddlBilgiAd.DataBind();
    }

    protected void ddlBilgiAd_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataRow drBilgi = vt.getDataRow("select * from bilgi where bilgi_id=" + ddlBilgiAd.SelectedValue);
        CKEbilgiMetin.Text = drBilgi["bilgi_metin"].ToString();
    }
}