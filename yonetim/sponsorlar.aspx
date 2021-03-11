<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/yonetim.master" AutoEventWireup="true" CodeFile="sponsorlar.aspx.cs" Inherits="yonetim_sponsorlar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        a img{width:32px;text-align:center;}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderYonetim" Runat="Server">
    <asp:DataList ID="DataListSponsorlar" runat="server" CssClass="ortala" Width="70%" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black">
        <AlternatingItemStyle BackColor="PaleGoldenrod" />
        <FooterStyle BackColor="Tan" />
        <HeaderStyle BackColor="Tan" Font-Bold="True" />
        <HeaderTemplate>
            <table class="kategorilerTablo">
                <tr>
                    <td style="width:45%;">Sponsor Adı </td>
                    <td style="width:35%;">Sponsor Foto</td>
                    <td style="width:10%;">Düzenle </td>
                    <td style="width:10%;">Sil</td>
                </tr>
            </table>
        </HeaderTemplate>
        <ItemTemplate>
            <table class="auto-style1">
                <tr>
                    <td  style="width:30%;"><%# Eval("sponsor_ad") %></td>
                    <td  style="width:50%; text-align:center;">
                        <img  style="height:100px;"src="../<%# Eval("sponsor_resim") %>" alt="Kategori Foto" /></td>
                    <td  style="width:10%; text-align:center;">
                        <a href="sponsorDuzenle.aspx?sponsor_id=<%#Eval("sponsor_id")%>">
                        <img src="../resimler/icon/duzenle.svg"  alt="Duzenle"/></a></td>
                    <td  style="width:10%; text-align:center; ">
                        <a href="sponsor.aspx?sponsor_id=<%#Eval("sponsor_id") %>&islem=sil" onclick="return confirm ('Silmek İstediğinizden Emin Misiniz?')">
                        <img src="../resimler/icon/sil.svg"  alt="Sil"/></a></td>
                </tr>
            </table>
        </ItemTemplate>
        <SelectedItemStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
    </asp:DataList>

</asp:Content>

