using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class yonetim_anasayfaResimler : System.Web.UI.Page
{
    veritabani vt = new veritabani();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dtDosyalar = vt.getDataTable("select * from anasayfa_gerecler");
        DataListAnaSayfaResimler.DataSource = dtDosyalar;
        DataListAnaSayfaResimler.DataBind();
        if (Request.QueryString["gerec_id"] != null && Request.QueryString["islem"] == "sil")
        {
            string gelengerec_id = Request.QueryString["gerec_id"];
            vt.komut("delete from anasayfa_gerecler where gerec_id=" + gelengerec_id);
            Response.Redirect("anasayfaResimler.aspx");
        }
    }
}