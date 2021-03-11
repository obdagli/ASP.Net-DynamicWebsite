<%@ Page Language="C#" AutoEventWireup="true" CodeFile="kayitol.aspx.cs" Inherits="kayitol" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>X Games - Kayıt Ol</title>
    <style type="text/css">
        body{font-family:'Trebuchet MS';}
        .giris{text-align:center; width:40%; margin:40px auto; background-color:#FFEDBC; border-radius:20px; padding-bottom:10px;}
        .giris h2{ padding:15px 0px; background-color:#a75265; border-top-left-radius :20px; border-top-right-radius :20px;}
        .giris img{ width:30%;}
        .giris p{ font-size:1.5em; margin-bottom:5px;}
        input{ font-size:1.5em; padding:10px;}
        .girisButonu{padding:10px 20px; text-decoration:none;color:black; background-color:#a75265; font-size:1.5em; border-radius:10px;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="giris">
            <h2>Kayıt Ol</h2>
            <img src="../resimler/icon/user.svg" />
            <p>Kullanıcı Adı</p>
            <asp:TextBox ID="txtKullanici" runat="server"></asp:TextBox>
            <br />
            <p>Şifre</p>
            <asp:TextBox ID="txtSifre" runat="server"></asp:TextBox><br /><br />
            <br />
            <asp:LinkButton ID="lbtnGiris" CssClass="girisButonu" runat="server" OnClick="lbtnGiris_Click">Kayıt Ol</asp:LinkButton><br /><br />
            <asp:Label ID="lblDurum" runat="server" Visible="false" ForeColor="Red" Text="Kullanıcı Adı veya Şifre Hatalı"></asp:Label>
           
        </div>
    </form>
</body>
</html>
