<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/yonetim.master" AutoEventWireup="true" CodeFile="altKategoriFotoDuzenle.aspx.cs" Inherits="yonetim_altKategoriFotoDuzenle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .tablo {
            width: 100%;
        }

        .ortala {
            margin: 20px auto;
        }

        .auto-style1 {
            width: 70%;
            margin: 0 auto;
            font-size: 1.4em;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderYonetim" runat="Server">
    <asp:DataList ID="DataListAltKatFotograflar" runat="server" CssClass="ortala" Width="70%" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black">
        <AlternatingItemStyle BackColor="PaleGoldenrod" />
        <FooterStyle BackColor="Tan" />
        <HeaderStyle BackColor="Tan" Font-Bold="True" />
        <HeaderTemplate>
            <table class="tablo">
                <tr>

                    <td style="width: 90%;">Alt Kategori Fotoğrafı</td>
                    <td style="width: 10%;">Sil</td>
                </tr>
            </table>
        </HeaderTemplate>
        <ItemTemplate>
            <table class="tablo">
                <tr>
                    <td style="width: 90%; text-align: center;">
                        <img style="height: 100px;" src="<%# Eval("resimKucukAdres") %>" alt="Kategori Foto" /></td>

                    <td style="width: 10%; text-align: center;">
                        <a href="altKategoriFotoDuzenle.aspx?altkategori_id=<%#Eval("altkategori_id") %>&resim_id=<%#Eval("resim_id") %>&islem=sil" onclick="return confirm ('Silmek İstediğinizden Emin Misiniz?')">
                            <img src="../resimler/icon/sil.png" alt="Sil" /></a></td>
                </tr>
            </table>
        </ItemTemplate>
        <SelectedItemStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
    </asp:DataList>
    <table class="auto-style1">
        <tr>
            <td>Ürün Foto</td>
            <td>

                <asp:FileUpload ID="fuDosya" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center;">
                <asp:ImageButton ID="ibtnKaydet" runat="server" ImageUrl="~/resimler/icon/yonetim-kaydet.png" OnClick="ibtnKaydet_Click" />
                &nbsp;
            </td>
        </tr>
    </table>



</asp:Content>
