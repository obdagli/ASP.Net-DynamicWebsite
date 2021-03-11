using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class Sepetim : System.Web.UI.Page
{
    sepetkomutlar sk = new sepetkomutlar();
    veritabani vt = new veritabani();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["uye_ad"] == null)
        {
            Response.Redirect("default.aspx");
        }
        else
        {            
            SepetGetir();
        }
        if (DataList1.Items.Count > 0)
        {
            Panel1.Visible = true;
        }
        else
        {
            Panel1.Visible = false;
        }
    }
    int fiyat;
    private void SepetGetir()
    {
        if (Session["sepet"] != null)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)Session["sepet"];
            DataList1.DataSource = dt.DefaultView;
            DataList1.DataBind();
            lblToplam.Text = "Toplam : " + sk.SepetToplam().ToString() + " TL.";
        }
    }
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName.ToString() == "sil")
        {
            sk.Sil(e.CommandArgument.ToString());//yazdığımız sil methoduna o anki ürünün id değerini gönderiyoruz
            SepetGetir();
        }
    }

    protected void btn_siparis_Click(object sender, EventArgs e)
    {
        if (Session["uye_ad"] != null)
        {
            vt.baglan();
            string uye_ad = Session["uye_ad"].ToString();
            Button basilanButon = (Button)sender;
            int ucret = Convert.ToInt32(sk.SepetToplam().ToString());
            DataRow drKategori = vt.getDataRow("select * from uyeler where uye_ad ='" + uye_ad + "'");
            string y = drKategori["uye_bakiye"].ToString();
            int bakiye = Convert.ToInt32(y);
            if (ucret <= bakiye)
            {
                int yenibakiye = bakiye - ucret;
                vt.komut("update uyeler set uye_bakiye=" + yenibakiye + " where uye_ad ='" + uye_ad + "'");
                double q = Convert.ToDouble(Session["uye_bakiye"].ToString());
                Session["uye_bakiye"] = Convert.ToDouble(q - ucret);
                Page.Response.Redirect(Page.Request.Url.ToString(), true);
                SepetGetir();
            }
            else
            {
                lblUyari.Visible = true;
                lblUyari.ForeColor = System.Drawing.Color.Red;
                lblUyari.Text = "Yetersiz Bakiye!";
            }
        }
    }
}