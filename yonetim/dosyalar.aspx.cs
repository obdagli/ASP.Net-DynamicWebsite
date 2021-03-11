using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class yonetim_dosyalar : System.Web.UI.Page
{
    veritabani vt = new veritabani();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dtDosyalar = vt.getDataTable("select * from dosyalar order by [dosya_id] desc");
        DataListDosyalar.DataSource = dtDosyalar;
        DataListDosyalar.DataBind();
        if (Request.QueryString["dosya_id"] != null && Request.QueryString["islem"] == "sil")
        {
            string gelenDosyaId = Request.QueryString["dosya_id"];
            vt.komut("delete from dosyalar where dosya_id=" + gelenDosyaId);
            Response.Redirect("dosyalar.aspx");
        }
    }
}