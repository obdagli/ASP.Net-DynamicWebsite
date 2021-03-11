<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/yonetim.master" AutoEventWireup="true" CodeFile="uyeler.aspx.cs" Inherits="yonetim_uyeler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width:600px;
        }
        tr.icerik{
            height:60px;
            line-height:60px;
        }
        tr.baslik{
            height:30px;
            line-height:30px;
        }
        
        img{width:32px;text-align:center;}

        img.duzenle{
            position:absolute;
            margin-top:14px;
        }
         img.sil{
            position:absolute;
            margin-top:14px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderYonetim" Runat="Server">
    <asp:DataList ID="DataListUyeler" CssClass="deneme" runat="server" CellPadding="4" ForeColor="#333333">
        <AlternatingItemStyle BackColor="White" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderTemplate>
            <table class="auto-style1">
                <tr class="baslik">
                    <th style="text-align:center;width:100px">Kullanıcı Adı</th>
                    <th style="text-align:center;width:50px">Şifre</th>
                    <th style="text-align:center;width:200px">Kullanıcı Tipi</th>
                    <th style="text-align:center;width:50px">Bakiye</th>
                    <th style="text-align:center;width:50px;">Düzenle</th>
                    <th style="text-align:center;width:50px;">Sil</th>
                </tr>
            </table>
        </HeaderTemplate>
        <ItemStyle BackColor="#E3EAEB" />
        <ItemTemplate>
            <table class="auto-style1">
                <tr class="icerik">
                    <td style="width:100px;text-align:center;"><%#Eval("uye_ad") %></td>
                    <td style="width:50px;text-align:center;"><%#Eval("uye_sifre") %></td>
                    <td style="width:200px;text-align:center;"><%#Eval("uye_yetki") %></td>
                    <td style="width:50px;text-align:center;"><%#Eval("uye_bakiye") %></td>
                    
                    <td style="width:60px;padding-left:.5%;"><a href="uyeDuzenle.aspx?uye_id=<%#Eval("uye_id") %>"> <img src="../resimler/icon/duzenle.svg" class="duzenle"></img></a></td>
                    <td style="width:50px;padding-left: 2%;"> <a href="uyeler.aspx?uye_id=<%#Eval("uye_id") %>&islem=sil" onclick="return confirm('Silmek istediğinizden emin misiniz?')"><img src="../resimler/icon/sil.svg" class="sil"></img></a></td>
                </tr>
            </table>
        </ItemTemplate>
        <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
    </asp:DataList>
    
</asp:Content>

