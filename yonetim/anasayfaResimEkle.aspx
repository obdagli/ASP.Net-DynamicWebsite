<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/yonetim.master" AutoEventWireup="true" CodeFile="anasayfaResimEkle.aspx.cs" Inherits="yonetim_anasayfaResimEkle" %>

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
            <td>Resim</td>
            <td>
                <asp:ImageButton ID="ImageanasayfaResim" runat="server" />
                <br />
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td>Resim Yukarıda-Aşağıda</td>
            <td>
                <asp:DropDownList ID="ddlResimKonum" runat="server" Width="95%">
                    <asp:ListItem Value="1">Aşağıda</asp:ListItem>
                    <asp:ListItem Value="0">Yukarıda</asp:ListItem>
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

