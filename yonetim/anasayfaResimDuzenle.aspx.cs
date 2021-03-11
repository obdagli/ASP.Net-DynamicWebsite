using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class yonetim_anasayfaResimDuzenle : System.Web.UI.Page
{
    veritabani vt = new veritabani();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["gerec_id"] == null)
        {
            Response.Redirect("anasayfaResimler.aspx");
        }
        if (!Page.IsPostBack)
        {
            string gerec_id = Request.QueryString["gerec_id"];
            DataRow drASResim = vt.getDataRow("select * from anasayfa_gerecler where gerec_id =" + gerec_id);
            ImageanasayfaResim.ImageUrl =  "../" + drASResim["gerec_foto"].ToString();
        }
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string yol = ImageanasayfaResim.ImageUrl;
        string gerec_id = Request.QueryString["gerec_id"];
        if (FileUpload1.HasFile)
        {
            yol = vt.resimKaydetAnaSayfa(FileUpload1, 550, "../resimler/default/");
        }
        vt.komut("update anasayfa_gerecler set gerec_durum ='" + ddlResimKonum.SelectedValue + "', [gerec_foto]='" + yol + "' where gerec_id =" + gerec_id);
        Response.Redirect("anasayfaResimler.aspx");
    }
}