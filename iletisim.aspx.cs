using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class iletisim : System.Web.UI.Page
{
    string sifre = "123456789q";
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGonder_Click(object sender, EventArgs e)
    {
        try
        {
            SmtpClient kaynak = new SmtpClient();
            kaynak.Credentials = new System.Net.NetworkCredential("gamexdestek@gmail.com", sifre);
            kaynak.Host = "smtp.gmail.com";
            kaynak.Port = 587;
            kaynak.EnableSsl = true;
            MailAddress gonderen = new MailAddress(txtEposta.Text, txtAd.Text);
            MailAddress giden = new MailAddress("gamexdestek@gmail.com", "Site Yöneticisi");
            MailMessage mesaj = new MailMessage(gonderen, giden);
            mesaj.Subject = txtAd.Text + "Sitenizden bir mesaj gönderdi";
            mesaj.IsBodyHtml = true;
            mesaj.Body = "Gönderen Bilgileri: " + "<br />Adı: " + txtAd.Text + "<br />Eposta: " + txtEposta.Text + "<br />Telefon: " + txtTel.Text + "<br />Mesaj: " + txtMesaj.Text;
            kaynak.Send(mesaj);
            lblSonuc.Text = "Mesajınız alındı, en kısa zamanda tarafınıza dönüş yapılacaktır.";
            lblSonuc.ForeColor = System.Drawing.Color.Green;
            temizle();
        }
        catch
        {
            lblSonuc.Text = "Bir hata oluştu! Daha sonra tekrar deneyiniz";
            lblSonuc.ForeColor = System.Drawing.Color.Red;
        }

    }
    void temizle()
    {
        txtAd.Text = "";
        txtEposta.Text = "";
        txtMesaj.Text = "";
        txtTel.Text = "";
    }
}