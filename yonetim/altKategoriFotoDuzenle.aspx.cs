using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class yonetim_altKategoriFotoDuzenle : System.Web.UI.Page
{
    veritabani vt = new veritabani();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["altkategori_id"] == null)
        {
            Response.Redirect("altKategoriler.aspx");
        }

        DataTable dtAltKatFotograflar = vt.getDataTable("Select * From resimler Where [altkategori_id]=" + Request.QueryString["altkategori_id"] + " Order By [resim_id] Desc");
        DataListAltKatFotograflar.DataSource = dtAltKatFotograflar;
        DataListAltKatFotograflar.DataBind();

        if (Request.QueryString["resim_id"] != null && Request.QueryString["islem"] == "sil")
        {
            string gelenResimId = Request.QueryString["resim_id"];
            vt.komut("Delete From [resimler] Where [resim_id]=" + gelenResimId);

            Response.Redirect("altKategoriFotoDuzenle.aspx?altkategori_id=" + Request.QueryString["altkategori_id"]);
        }
    }

    protected void ibtnKaydet_Click(object sender, ImageClickEventArgs e)
    {
        if (fuDosya.HasFile)
        {
            string yolBuyuk = vt.resimKaydet(fuDosya, 520, "/resimler/urunler_resim/buyuk/");
            string yolKucuk = vt.resimKaydetUrunKucukFotograf(fuDosya, 210, "/resimler/urunler_resim/kucuk/");
            vt.komut("Insert Into [resimler] ([resimKucukAdres], [resimBuyukAdres], [altkategori_id]) Values ('" + yolKucuk + "', '" + yolBuyuk + "', '" + Request.QueryString["altkategori_id"] + "')");
            Response.Redirect("altKategoriFotoDuzenle.aspx?altkategori_id=" + Request.QueryString["altkategori_id"]);
        }
    }
}