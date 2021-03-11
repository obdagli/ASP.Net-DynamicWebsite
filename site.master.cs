using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class site : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PanelGiris.Visible = true;
        PanelHosgeldiniz.Visible = false;
        if (Session["uye_ad"] != null)
        {   
            PanelGiris.Visible = false;
            PanelHosgeldiniz.Visible = true;
            lblAd.Text = Session["uye_ad"].ToString();
            lblBakiye.Text = Session["uye_bakiye"].ToString()+ "₺";
        }
        
    }

    protected void RepeaterKategoriler_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        Repeater RepeaterAltKategorilerCs = (Repeater)e.Item.FindControl("RepeaterAltKategoriler");
        SqlDataSource SqlDataSourceAltKategorilerCs = (SqlDataSource)e.Item.FindControl("SqlDataSourceAltKategori");
        SqlDataSourceAltKategorilerCs.SelectCommand = "SELECT * FROM [altkategori] where kategori_id=" + DataBinder.Eval(e.Item.DataItem, "kategori_id").ToString();
    }

    protected void ButtonAra_Click(object sender, EventArgs e)
    {
        string gelenaramametin = ara.Text;
        if (gelenaramametin != "")
        {
            Response.Redirect("urunler.aspx?ara=" + gelenaramametin);
        }
    }

    protected void btn_giris_Click(object sender, EventArgs e)
    {
        if (tb_kullaniciadi.Text != "" && tb_sifre.Text != "")
        {
            DataView tablo = (DataView)SqlDataSourceUyeler.Select(DataSourceSelectArguments.Empty);
            int satirsay = tablo.Count;
            if (satirsay > 0)
            {
                DataRowView satir = tablo[0];
                Session["uye_ad"] = satir["uye_ad"];
                Session["uye_bakiye"] = satir["uye_bakiye"];
                Session["uye_yetki"] = satir["uye_yetki"];
                if (Session["uye_yetki"].ToString() == "admin")
                {
                    Response.Redirect("yonetim/Default.aspx");
                }
                else if (Session["uye_yetki"].ToString() == "kullanici")
                {
                    Response.Redirect("Default.aspx");
                }
            }
            else
            {
                lblDurum.Visible = true;
            }
        }

    }

    protected void btnCikis_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }

    protected void btnSepet_Click(object sender, EventArgs e)
    {
        Response.Redirect("Sepetim.aspx");
    }
}
