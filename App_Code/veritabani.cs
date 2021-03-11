using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;

/// <summary>
/// Summary description for veritabani
/// </summary>
public class veritabani
{
    public veritabani()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public OleDbConnection baglan()
    {
        OleDbConnection baglanti = new OleDbConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        baglanti.Open();
        return (baglanti);
    }
    public int komut(string sqlcumle)
    {
        int sonuc = 0;
        OleDbConnection baglanti = this.baglan();
        OleDbCommand komut = new OleDbCommand(sqlcumle, baglanti);
        try
        {
            sonuc = komut.ExecuteNonQuery();
        }
        catch (OleDbException hata)
        {

            throw new Exception(hata.Message + sqlcumle + "Cümlesinde hata var!");
        }
        komut.Dispose();
        baglanti.Close();
        baglanti.Dispose();
        return sonuc;
    }
    public DataTable getDataTable(string sql)
    {
        OleDbConnection baglanti = this.baglan();
        OleDbDataAdapter da = new OleDbDataAdapter(sql, baglanti);
        DataTable dt = new DataTable();
        try
        {
            da.Fill(dt);
        }
        catch (OleDbException hata)
        {
            throw new Exception(hata.Message + sql + "Cümlesinde hata var!");
        }
        da.Dispose();
        baglanti.Close();
        baglanti.Dispose();
        return dt;
    }
    public DataRow getDataRow(string sql)
    {
        DataTable tablo = getDataTable(sql);
        if (tablo.Rows.Count == 0)
        {
            return null;
        }
        else
        {
            return tablo.Rows[0];
        }
    }
    public string getDataCell(string sql)
    {
        DataRow dr = getDataRow(sql);
        if (dr != null)
        {
            return dr[0].ToString();
        }
        else
        {
            return null;
        }
    }
    public string resimKaydet(FileUpload fuYukle, int sonGenislik, string gercekYol)
    {
        string yoluKaydet;
        string geciciYol = "../resimler/gecici/";
        string resimAd = DateTime.Now.Ticks.ToString();
        string resimUzanti = Path.GetExtension(fuYukle.PostedFile.FileName);
        fuYukle.SaveAs(HttpContext.Current.Server.MapPath(geciciYol + resimAd + resimUzanti));
        Bitmap bmp = new Bitmap(HttpContext.Current.Server.MapPath(geciciYol + resimAd + resimUzanti));
        using (Bitmap orjinalResim = bmp)
        {
            double resimGenislik = orjinalResim.Width;
            double resimYukseklik = orjinalResim.Height;
            double oran = resimGenislik / resimYukseklik;
            resimGenislik = sonGenislik;
            resimYukseklik = 75;
            Size yeniDegerler = new Size(Convert.ToInt32(resimGenislik), Convert.ToInt32(resimYukseklik));
            Bitmap yeniResim = new Bitmap(orjinalResim, yeniDegerler);
            yeniResim.Save(HttpContext.Current.Server.MapPath(gercekYol + resimAd + resimUzanti));
            yoluKaydet = gercekYol + resimAd + resimUzanti;
            orjinalResim.Dispose();
            bmp.Dispose();
            yeniResim.Dispose();
        }
        FileInfo silinecek = new FileInfo(HttpContext.Current.Server.MapPath(geciciYol + resimAd + resimUzanti));
        silinecek.Delete();
        return yoluKaydet;
    }
    public string resimKaydet2(FileUpload fuYukle, int sonGenislik, string gercekYol)
    {
        string yoluKaydet;
        string geciciYol = "../resimler/gecici/";
        string resimAd = DateTime.Now.Ticks.ToString();
        string resimUzanti = Path.GetExtension(fuYukle.PostedFile.FileName);
        fuYukle.SaveAs(HttpContext.Current.Server.MapPath(geciciYol + resimAd + resimUzanti));
        Bitmap bmp = new Bitmap(HttpContext.Current.Server.MapPath(geciciYol + resimAd + resimUzanti));
        using (Bitmap orjinalResim = bmp)
        {
            double resimGenislik = orjinalResim.Width;
            double resimYukseklik = orjinalResim.Height;
            double oran = resimGenislik / resimYukseklik;
            resimGenislik = sonGenislik;
            resimYukseklik = resimGenislik / oran;
            Size yeniDegerler = new Size(Convert.ToInt32(resimGenislik), Convert.ToInt32(resimYukseklik));
            Bitmap yeniResim = new Bitmap(orjinalResim, yeniDegerler);
            yeniResim.Save(HttpContext.Current.Server.MapPath(gercekYol + resimAd + resimUzanti));
            yoluKaydet = gercekYol + resimAd + resimUzanti;
            orjinalResim.Dispose();
            bmp.Dispose();
            yeniResim.Dispose();
        }
        FileInfo silinecek = new FileInfo(HttpContext.Current.Server.MapPath(geciciYol + resimAd + resimUzanti));
        silinecek.Delete();
        return yoluKaydet;
    }
    public string resimKaydetUrunKucukFotograf(FileUpload fuYukle, int sonGenislik, string gercekYol)
    {
        string yoluKaydet;
        string geciciYol = "../resimler/gecici/";
        string resimAd = DateTime.Now.Ticks.ToString();
        string resimUzanti = Path.GetExtension(fuYukle.PostedFile.FileName);
        fuYukle.SaveAs(HttpContext.Current.Server.MapPath(geciciYol + resimAd + resimUzanti));
        Bitmap bmp = new Bitmap(HttpContext.Current.Server.MapPath(geciciYol + resimAd + resimUzanti));
        using (Bitmap orjinalResim = bmp)
        {
            double resimGenislik = orjinalResim.Width;
            double resimYukseklik = orjinalResim.Height;
            double oran = resimGenislik / resimYukseklik;
            resimGenislik = sonGenislik;
            resimYukseklik = 132.3;
            Size yeniDegerler = new Size(Convert.ToInt32(resimGenislik), Convert.ToInt32(resimYukseklik));
            Bitmap yeniResim = new Bitmap(orjinalResim, yeniDegerler);
            yeniResim.Save(HttpContext.Current.Server.MapPath(gercekYol + resimAd + resimUzanti));
            yoluKaydet = gercekYol + resimAd + resimUzanti;
            orjinalResim.Dispose();
            bmp.Dispose();
            yeniResim.Dispose();
        }
        FileInfo silinecek = new FileInfo(HttpContext.Current.Server.MapPath(geciciYol + resimAd + resimUzanti));
        silinecek.Delete();
        return yoluKaydet;
    }
    public string resimKaydetSponsor_Slider(FileUpload fuYukle, int sonGenislik, string gercekYol)
    {
        string yoluKaydet;
        string geciciYol = "../resimler/gecici/";
        string resimAd = DateTime.Now.Ticks.ToString();
        string resimUzanti = Path.GetExtension(fuYukle.PostedFile.FileName);
        fuYukle.SaveAs(HttpContext.Current.Server.MapPath(geciciYol + resimAd + resimUzanti));
        Bitmap bmp = new Bitmap(HttpContext.Current.Server.MapPath(geciciYol + resimAd + resimUzanti));
        using (Bitmap orjinalResim = bmp)
        {
            double resimGenislik = orjinalResim.Width;
            double resimYukseklik = orjinalResim.Height;
            double oran = resimGenislik / resimYukseklik;
            resimGenislik = sonGenislik;
            resimYukseklik = 140;
            Size yeniDegerler = new Size(Convert.ToInt32(resimGenislik), Convert.ToInt32(resimYukseklik));
            Bitmap yeniResim = new Bitmap(orjinalResim, yeniDegerler);
            yeniResim.Save(HttpContext.Current.Server.MapPath(gercekYol + resimAd + resimUzanti));
            yoluKaydet = gercekYol + resimAd + resimUzanti;
            orjinalResim.Dispose();
            bmp.Dispose();
            yeniResim.Dispose();
        }
        FileInfo silinecek = new FileInfo(HttpContext.Current.Server.MapPath(geciciYol + resimAd + resimUzanti));
        silinecek.Delete();
        return yoluKaydet;
    }
    public string resimKaydetAnaSayfa(FileUpload fuYukle, int sonGenislik, string gercekYol)
    {
        string yoluKaydet;
        string geciciYol = "../resimler/gecici/";
        string resimAd = DateTime.Now.Ticks.ToString();
        string resimUzanti = Path.GetExtension(fuYukle.PostedFile.FileName);
        fuYukle.SaveAs(HttpContext.Current.Server.MapPath(geciciYol + resimAd + resimUzanti));
        Bitmap bmp = new Bitmap(HttpContext.Current.Server.MapPath(geciciYol + resimAd + resimUzanti));
        using (Bitmap orjinalResim = bmp)
        {
            double resimGenislik = orjinalResim.Width;
            double resimYukseklik = orjinalResim.Height;
            double oran = resimGenislik / resimYukseklik;
            resimGenislik = sonGenislik;
            resimYukseklik = 218;
            Size yeniDegerler = new Size(Convert.ToInt32(resimGenislik), Convert.ToInt32(resimYukseklik));
            Bitmap yeniResim = new Bitmap(orjinalResim, yeniDegerler);
            yeniResim.Save(HttpContext.Current.Server.MapPath(gercekYol + resimAd + resimUzanti));
            yoluKaydet = gercekYol + resimAd + resimUzanti;
            orjinalResim.Dispose();
            bmp.Dispose();
            yeniResim.Dispose();
        }
        FileInfo silinecek = new FileInfo(HttpContext.Current.Server.MapPath(geciciYol + resimAd + resimUzanti));
        silinecek.Delete();
        return yoluKaydet;
    }
}