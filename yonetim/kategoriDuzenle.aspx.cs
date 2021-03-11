using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class yonetim_kategoriDuzenle : System.Web.UI.Page
{
    veritabani vt = new veritabani();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["kategori_id"] == null)
        {
            Response.Redirect("kategoriler.aspx");
        }
        if (!Page.IsPostBack)
        {
            string kategori_id = Request.QueryString["kategori_id"];
            DataRow drKategori = vt.getDataRow("select * from kategori where kategori_id =" + kategori_id);
            txtAd.Text = drKategori["kategori_adi"].ToString();
        }
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string gelenkatid = Request.QueryString["kategori_id"];
        vt.komut("update kategori set kategori_adi ='" + txtAd.Text + "', kategoriAnasayfa ='" + ddlAnasayfa.SelectedValue + "' where kategori_id =" + gelenkatid);
        Response.Redirect("kategoriler.aspx");
    }
}