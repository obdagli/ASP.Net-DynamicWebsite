<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/yonetim.master" AutoEventWireup="true" CodeFile="urunler.aspx.cs" Inherits="yonetim_urunler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../stil/urunler/deneme.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 750px;
        }
        
        img{width:32px; height:32px; text-align:center;}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderYonetim" Runat="Server">
    <asp:DataList ID="DataListUrunler" CssClass="deneme" runat="server" CellPadding="4" ForeColor="#333333">
        <AlternatingItemStyle BackColor="White" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderTemplate>
            <table class="auto-style1">
                <tr>
                    <th style="text-align:center;width:300px">Ürün Ad</th>
                    <th style="text-align:center;width:100px;">Ürün Fiyat</th>
                    <th style="text-align:center;width:300px;">Bağlı AltKategori</th>
                    <th style="text-align:center;width:30px;">Düzenle</th>
                    <th style="text-align:center;width:25px;">Sil</th>
                </tr>
            </table>
        </HeaderTemplate>
        <ItemStyle BackColor="#E3EAEB" />
        <ItemTemplate>
            <table class="auto-style1">
                <tr>
                    <td style="width:300px;text-align:center;padding-bottom:5%"><%#Eval("urun_ad") %></td>
                    <td style="width:140px"><%#Eval("urun_fiyat") %></td>
                    <td style="width:200px"><%#Eval("altkategori_ad") %></td>
                    <td style="width:30px;padding-left:.5%;">
                        <a href="urunDuzenle.aspx?urun_id=<%#Eval("urun_id") %>">
                        <img src="../resimler/icon/duzenle.svg"></img></a></td>
                    <td style="width:50px;padding-left: 2%;"> <a href="urunler.aspx?urun_id=<%#Eval("urun_id") %>&islem=sil" onclick="return confirm('Silmek istediğinizden emin misiniz?')"><img src="../resimler/icon/sil.svg"></img></a></td>
                </tr>
            </table>
        </ItemTemplate>
        <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
    </asp:DataList>
    
</asp:Content>


