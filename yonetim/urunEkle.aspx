<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/yonetim.master" AutoEventWireup="true" CodeFile="urunEkle.aspx.cs" Inherits="yonetim_urunEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            margin:0 auto;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderYonetim" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td>Ürün Ad</td>
            <td>
                <asp:TextBox ID="txtUrunAd" runat="server" Width="95%"></asp:TextBox><br /><br />
            </td>
        </tr>
        <tr>
            <td>Bağlı Olacağı Kategori</td>
            <td>
                <asp:DropDownList ID="ddlKategori" runat="server"></asp:DropDownList><br /><br />
            </td>
        </tr>
        <tr>
            <td>Ürün Fiyat</td>
            <td>
                <asp:TextBox ID="txtUrunFiyat" runat="server" Width="95%"></asp:TextBox><br /><br />
            </td>
        </tr>
        <tr>
            <td>Ürün Baslik</td>
            <td>
                <asp:TextBox ID="txtUrunBaslik" runat="server" Width="95%"></asp:TextBox><br /><br />
            </td>
        </tr>
        <tr>
            <td>Ürün Bilgi</td>
            <td>
                <asp:TextBox ID="txtUrunBilgi" runat="server" Width="95%" TextMode="MultiLine"></asp:TextBox><br /><br />
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/resimler/icon/yonetim-kaydet.png" OnClick="ImageButton1_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

