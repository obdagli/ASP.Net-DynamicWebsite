<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/yonetim.master" AutoEventWireup="true" CodeFile="uyeDuzenle.aspx.cs" Inherits="yonetim_uyeDuzenle" %>

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
            <td>Uye Ad</td>
            <td>
                <asp:TextBox ID="txtUyeAd" runat="server" Width="95%"></asp:TextBox><br /><br />
            </td>
        </tr>
        <tr>
            <td>Uye Şifre</td>
            <td>
                <asp:TextBox ID="txtUyeSifre" runat="server" Width="95%" TextMode="MultiLine"></asp:TextBox><br /><br />
            </td>
        </tr>
        <tr>
            <td>Uye Yetki</td>
            <td>
                <asp:DropDownList ID="ddlAnasayfa" runat="server" Width="95%">
                    <asp:ListItem Value="1">admin</asp:ListItem>
                    <asp:ListItem Value="0">kullanici</asp:ListItem>
                </asp:DropDownList><br /><br />
            </td>
        </tr>
        <tr>
            <td>Uye Bakiye</td>
            <td>
                <asp:TextBox ID="txtUyeBakiye" runat="server" Width="95%" TextMode="MultiLine"></asp:TextBox><br /><br />
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/resimler/icon/yonetim-kaydet.png" OnClick="ImageButton1_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

