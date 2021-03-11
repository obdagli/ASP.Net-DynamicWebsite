using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class kayitol : System.Web.UI.Page
{
    veritabani vt = new veritabani();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void lbtnGiris_Click(object sender, EventArgs e)
    {
        if (txtKullanici.Text != "" && txtSifre.Text != "")
        {
            DataTable dr = vt.getDataTable("select uye_ad from uyeler where uye_ad='" + txtKullanici.Text + "'");
            if (dr.Rows.Count == 0)
            {
                vt.komut("insert into uyeler (uye_ad, uye_sifre, uye_yetki, uye_bakiye) values ('" + txtKullanici.Text + "', '" + txtSifre.Text + "', 'kullanici', '0')");
                lblDurum.Text = "Kayıt başarıyla gerçekleştirildi!";
                lblDurum.ForeColor = System.Drawing.Color.Green;
                lblDurum.Visible = true;
            }
            else
            {
                lblDurum.Text = "Kullanıcı adı zaten kullanımda!";
                lblDurum.ForeColor = System.Drawing.Color.Red;
                lblDurum.Visible = true;
            }
        }
        else
        {
            lblDurum.Text = "Kullanıcı adı veya şifre boş geçilemez!";
            lblDurum.ForeColor = System.Drawing.Color.Red;
            lblDurum.Visible = true;
        }




    }
}