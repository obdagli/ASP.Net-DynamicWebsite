<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="dosyalar.aspx.cs" Inherits="dosyalar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">    
    <link href="stil/urunler/urunstil.css" rel="stylesheet" />
    <link href="stil/urunler/tablo.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceGovde" Runat="Server">
    <div class="urun">
        <div class="tablo-bg">
            <table>
                <thead>
                    <tr>
                        <th>Dosya Adı</th>
                        <th>Güncelleme Tarihi</th>
                        <th>İndir</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="RepeaterDosyalar" runat="server" DataSourceID="SqlDataSourceDosyalar">

                        <ItemTemplate>
                            <tr>
                                <td class="dosyaadi"><%#Eval("dosya_ad") %></td>
                                <td class="guncellemetarihi"><%#Eval("dosya_guncellemetarihi") %></td>
                                <td class="siparisbuton">
                                    <a href="<%#Eval("dosya_hedef") %>">
                                        <asp:Button ID="Button1" CssClass="butonsiparis" runat="server" Text="İndir" /></a></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>

                    <asp:SqlDataSource runat="server" ID="SqlDataSourceDosyalar" ConnectionString='<%$ ConnectionStrings:ConnectionString %>' ProviderName='<%$ ConnectionStrings:ConnectionString.ProviderName %>' SelectCommand="SELECT * FROM [dosyalar] WHERE ([dosya_durum] = ?)">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="1" Name="dosya_durum" Type="String"></asp:Parameter>
                        </SelectParameters>
                    </asp:SqlDataSource>                    
                </tbody>
            </table>
        </div>
    </div>
</asp:Content>

