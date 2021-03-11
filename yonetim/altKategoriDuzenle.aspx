<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/yonetim.master" AutoEventWireup="true" ValidateRequest="false" CodeFile="altKategoriDuzenle.aspx.cs" Inherits="yonetim_altKategoriEkle" %>

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
            <td>Alt Kategori Ad</td>
            <td>
                <asp:TextBox ID="txtAltKategoriAd" runat="server" Width="95%"></asp:TextBox><br /><br />
            </td>
        </tr>
        <tr>
            <td>Bağlı olduğu Kategori</td>
            <td>
                <asp:DropDownList ID="ddlKategori" runat="server"></asp:DropDownList><br /><br />
            </td>
        </tr>
        <tr>
            <td>Alt Kategori Bilgi</td>
            <td>
                <asp:TextBox ID="txtAltKategoriMetin" runat="server" Width="95%" TextMode="MultiLine"></asp:TextBox><br /><br />
            </td>
        </tr>
        <tr>
            <td>Alt Kategori Durum</td>
            <td>
                <asp:DropDownList ID="ddlAnasayfa" runat="server" Width="95%">
                    <asp:ListItem Value="1">Evet</asp:ListItem>
                    <asp:ListItem Value="0">Hayır</asp:ListItem>
                </asp:DropDownList><br /><br />
            </td>
        </tr>
        <tr>
            <td>Alt Kategori Foto</td>
            <td>
                <asp:ImageButton ID="ImageKategoriler" runat="server" />
                <br />
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/resimler/icon/yonetim-kaydet.png" OnClick="ImageButton1_Click" />
            </td>
        </tr>
        <tr>

            <td colspan="2" style="text-align: center; ">
                <br />
                <asp:HyperLink ID="hlUrunBuyukFotograf" runat="server" CssClass="cikisButon">Alt Kategori Büyük Fotoğraflar</asp:HyperLink>
                 <br /><br />
            </td>
        </tr>
    </table>
</asp:Content>
