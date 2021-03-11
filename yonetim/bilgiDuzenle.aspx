<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/yonetim.master" AutoEventWireup="true" CodeFile="bilgiDuzenle.aspx.cs" Inherits="yonetim_bilgiDuzenle" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 70%;
            margin: 0 auto;
            font-size: 1.4em;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderYonetim" runat="Server">
    <table class="auto-style1">
        <tr>
            <td style="width:20%">Bilgi Ad</td>
            <td style="width:80%">
                <asp:DropDownList ID="ddlBilgiAd" runat="server" Width="95%" AutoPostBack="True" OnSelectedIndexChanged="ddlBilgiAd_SelectedIndexChanged">
                </asp:DropDownList><br /><br />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <h4>Sayfa İçeriği</h4><br />
                <CKEditor:CKEditorControl ID="CKEbilgiMetin" BasePath="/ckeditor/" runat="server"></CKEditor:CKEditorControl>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
                <asp:ImageButton ID="ibtnGuncelle" runat="server" ImageUrl="~/resimler/icon/yonetim-kaydet.png" OnClick="ibtnGuncelle_Click"/>
            </td>
        </tr>
    </table>


</asp:Content>
