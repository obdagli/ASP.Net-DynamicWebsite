using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.IO;
using System.Data;
public partial class lol_rp_tr : System.Web.UI.Page
{

    bool degisken = true;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["altKat"] != null)
        {
            string gelenAltKategori = Request.QueryString["altKat"];
            SqlDataSourceUrunler.SelectCommand = "SELECT * FROM [altkategori] WHERE([altkategori_id] = " + gelenAltKategori + ")";
            SqlDataSourceUrunler2.SelectCommand = "select * from urunler where altkategori_id = " + gelenAltKategori + "";
        }
        if (Request.QueryString["kat"] != null)
        {
            string gelenKategori = Request.QueryString["kat"];
            SqlDataSourceUrunler.SelectCommand = "SELECT urunler.*, altkategori.*, kategori.*" +
"FROM((urunler INNER JOIN altkategori ON urunler.altkategori_id = altkategori.altkategori_id)" +
"INNER JOIN kategori ON altkategori.kategori_id = kategori.kategori_id)" +
"where ([altkategori.kategori_id]=" + gelenKategori + ")";
        }
        if (Request.QueryString["ara"] != null)
        {
            string gelenAramaMetin = Request.QueryString["ara"];
            SqlDataSourceUrunler2.SelectCommand = "SELECT * from urunler WHERE ([urun_ad] Like '%" + gelenAramaMetin + "%')";

            string appdatafolder = Path.Combine(HttpContext.Current.Request.PhysicalApplicationPath, "App_Data");

            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + appdatafolder + "\\vt.mdb;Persist Security Info=True");
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * from urunler WHERE ([urun_ad] Like '%" + gelenAramaMetin + "%')", conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                degisken = true;
                SqlDataSourceUrunler.SelectCommand = "SELECT * FROM [altkategori] WHERE([altkategori_id] = 23 )";
            }
            else
            {
                degisken = false;
                SqlDataSourceUrunler.SelectCommand = "SELECT * FROM [altkategori] WHERE([altkategori_id] = 24 )";
            }


        }
        // derste yapılan
        if (Request.QueryString["urun_id"] != null)
        {
            PanelUrun.Visible = false;
            PanelUrunDetay.Visible = true;
        }
    }


    protected void Page_LoadComplete(object sender, EventArgs e)
    {
        if (degisken == false)
        {
            PanelBaslik.Visible = false;
        }
        else
        {
            PanelBaslik.Visible = true;
        }
    }
    veritabani vt = new veritabani();
    sepetkomutlar sk = new sepetkomutlar();
    protected void btn_siparis_Click(object sender, EventArgs e)
    {
        if (Session["uye_ad"] != null)
        {
            Button basilanButon = (Button)sender;
            string urunid = basilanButon.ToolTip;
            DataRow dr = vt.getDataRow("select * from urunler where urun_id=" + urunid);
            sk.Ekle(urunid, dr["urun_ad"].ToString(), 1, Convert.ToDouble(dr["urun_fiyat"].ToString()));
        }


        /*if (Session["uye_ad"] != null)
        {
            vt.baglan();
            string uye_ad = Session["uye_ad"].ToString();
            Button basilanButon = (Button)sender;
            string x = basilanButon.ToolTip;
            int para = Convert.ToInt32(x);
            DataRow drKategori = vt.getDataRow("select * from uyeler where uye_ad ='" + uye_ad+"'");
            string y = drKategori["uye_bakiye"].ToString();
            int bakiye = Convert.ToInt32(y);
            if (para < bakiye)
            {
                int yenibakiye = bakiye - para;
                vt.komut("update uyeler set uye_bakiye="+yenibakiye+" where uye_ad ='" + uye_ad+"'");
                double q = Convert.ToDouble(Session["uye_bakiye"].ToString());
                Session["uye_bakiye"] = Convert.ToDouble(q - para);
            }
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }*/


    }

}