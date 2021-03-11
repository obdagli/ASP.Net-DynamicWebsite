<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/yonetim.master" AutoEventWireup="true" CodeFile="dosyaEkle.aspx.cs" Inherits="yonetim_dosyaEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 70%;
            margin:0 auto;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderYonetim" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td>Dosya Ad</td>
            <td>
                <asp:TextBox ID="txtAd" runat="server" Width="95%"></asp:TextBox>
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td>Dosya Hedef</td>
            <td>
                <asp:TextBox ID="txtHedef" runat="server" Width="95%"></asp:TextBox>
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td>Dosya Gizliliği</td>
            <td>
                <asp:DropDownList ID="ddlAnasayfa" runat="server" Width="95%">
                    <asp:ListItem Value="1">Göster</asp:ListItem>
                    <asp:ListItem Value="0">Gizle</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/resimler/icon/yonetim-kaydet.png" OnClick="ImageButton1_Click" />
                <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/resimler/icon/yonetim-iptal.png"/>
            </td>
        </tr>
    </table>
    
</asp:Content>

