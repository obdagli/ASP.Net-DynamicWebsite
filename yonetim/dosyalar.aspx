<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/yonetim.master" AutoEventWireup="true" CodeFile="dosyalar.aspx.cs" Inherits="yonetim_dosyalar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        
        img{width:32px;text-align:center;}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderYonetim" Runat="Server">
    <asp:DataList ID="DataListDosyalar" CssClass="deneme" runat="server" CellPadding="4" ForeColor="#333333">
        <AlternatingItemStyle BackColor="White" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderTemplate>
            <table class="auto-style1">
                <tr>
                    <th style="text-align:center;width:80%">Dosya Adı</th>
                    <th style="text-align:center;width:10%;">Düzenle</th>
                    <th style="text-align:center;width:10%;">Sil</th>
                </tr>
            </table>
        </HeaderTemplate>
        <ItemStyle BackColor="#E3EAEB" />
        <ItemTemplate>
            <table class="auto-style1">
                <tr>
                    <td style="width:80%;text-align:center;padding-bottom:5%"><%#Eval("dosya_ad") %></td>
                    <td style="width:150px;padding-left:.5%;">
                        <a href="dosyaDuzenle.aspx?dosya_id=<%#Eval("dosya_id") %>">
                        <img src="../resimler/icon/duzenle.svg"></img></a></td>
                    <td style="width:150px;padding-left: 2%;"> <a href="dosyalar.aspx?dosya_id=<%#Eval("dosya_id") %>&islem=sil" onclick="return confirm('Silmek istediğinizden emin misiniz?')"><img src="../resimler/icon/sil.svg"></img></a></td>
                </tr>
            </table>
        </ItemTemplate>
        <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
    </asp:DataList>
    
</asp:Content>

