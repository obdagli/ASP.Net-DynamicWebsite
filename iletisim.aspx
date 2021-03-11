<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="iletisim.aspx.cs" Inherits="iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        #iletisim{text-align:center;font-family:"Roboto Condensed", Arial, sans-serif;background-color:#a98c66;padding:2.5% 5%;color:#fff; border-radius:20px; font-size:1.2em;margin-bottom: 5%;
}

        h2, h3{font-size:2em; text-align:center; letter-spacing:2px;           
           text-shadow:-1px -1px 1px black, 1px 1px 1px #36163b;  
        }
        .iletisimUst{padding:2%;
                      border-radius:20px;}
        .iletisimFormuAlan, .iletisimFormuButon{padding:2% 4%; margin:5px 0 20px 0; 
                           border-radius:10px; border:none; 
        }        
        .iletisimFormuAlan:focus{width:60%; transition:ease 10s;}
        .iletisimFormuButon{cursor:pointer; border:2px solid #a98c66; }
        .iletisimFormuButon:hover{border-color:white; background-color:#52cfeb; color:white;}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceGovde" runat="Server">
    <div id="iletisim">
        <h2>İletişim</h2><br /><br />
        <h3>Bize Ulaşın</h3><br />
        <div class="iletisimUst">

            <div class="iletisimFormu">
                Ad Soyad<br />
                <asp:TextBox ID="txtAd" CssClass="iletisimFormuAlan" runat="server"></asp:TextBox><br />
                E-Posta Adresi<br />
                <asp:TextBox ID="txtEposta" CssClass="iletisimFormuAlan" runat="server"></asp:TextBox><br />
                Telefon Numarası<br />
                <asp:TextBox ID="txtTel" CssClass="iletisimFormuAlan" runat="server"></asp:TextBox><br />
                Mesaj<br />
                <asp:TextBox ID="txtMesaj" CssClass="iletisimFormuAlan" TextMode="MultiLine" Rows="5" Width="80%"
                    runat="server"></asp:TextBox><br />
                <asp:Button ID="btnGonder" CssClass="iletisimFormuButon" runat="server" Text="Gönder" OnClick="btnGonder_Click" /><br />
                <asp:Label ID="lblSonuc" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>

