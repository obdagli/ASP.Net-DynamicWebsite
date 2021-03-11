<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="stil/reset.css" rel="stylesheet" />
    <link href="stil/default_stil.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceGovde" runat="Server">
    <div id="haberslider">
        <asp:Repeater ID="RepeaterUstAna" runat="server" DataSourceID="SqlDataSourceAnaSayfa">
            <ItemTemplate>
                <img src="<%#Eval("gerec_foto") %>"" />
            </ItemTemplate>
        </asp:Repeater>
        <asp:SqlDataSource runat="server" ID="SqlDataSourceAnaSayfa" ConnectionString='<%$ ConnectionStrings:ConnectionString %>' ProviderName='<%$ ConnectionStrings:ConnectionString.ProviderName %>' SelectCommand="SELECT * FROM [anasayfa_gerecler] WHERE ([gerec_durum] = ?)">
            <SelectParameters>
                <asp:Parameter DefaultValue="0" Name="gerec_durum" Type="String"></asp:Parameter>
            </SelectParameters>
        </asp:SqlDataSource>
        
    </div>
    <div id="haberler">
        <div class="sol-haber">
            <h3>Son Eklenen Oyunlar</h3>
            <br />
            <asp:Repeater ID="RepeaterSolHaber" runat="server" DataSourceID="SqlDataSourceSonEOyun">
                <ItemTemplate>
                    <a href="<%#Eval("soneklenenoyun_hedef") %>">
                        <p><%#Eval("soneklenenoyun_ad") %></p>
                    </a>
                    <br />
                </ItemTemplate>
            </asp:Repeater>
            <asp:SqlDataSource runat="server" ID="SqlDataSourceSonEOyun" ConnectionString='<%$ ConnectionStrings:ConnectionString %>' ProviderName='<%$ ConnectionStrings:ConnectionString.ProviderName %>' SelectCommand="SELECT * FROM [soneklenenoyunlar] WHERE ([sonekleyenoyun_durum] = ?)">
                <SelectParameters>
                    <asp:Parameter DefaultValue="1" Name="sonekleyenoyun_durum" Type="String"></asp:Parameter>
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
        <div class="sag-haber">
            <h3>Haberler</h3>
            <br />
            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSourceHaberler">
                <ItemTemplate>
                    <p><a href="<%#Eval("haberhedef") %>"><%#Eval("haberadi") %></a></p>
                    <br />
                </ItemTemplate>
            </asp:Repeater>
            <asp:SqlDataSource runat="server" ID="SqlDataSourceHaberler" ConnectionString='<%$ ConnectionStrings:ConnectionString %>' ProviderName='<%$ ConnectionStrings:ConnectionString.ProviderName %>' SelectCommand="SELECT * FROM [haberler] WHERE ([haberdurum] = ?)">
                <SelectParameters>
                    <asp:Parameter DefaultValue="1" Name="haberdurum" Type="String"></asp:Parameter>
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
        <div class="clear"></div>
        <asp:Repeater ID="Repeater2" runat="server" DataSourceID="SqlDataSourceAnaAltRes">
            <ItemTemplate>
               <div class="csgo">
                   <img src="<%#Eval("gerec_foto")%>" />
               </div>
            </ItemTemplate>
        </asp:Repeater>
        <asp:SqlDataSource runat="server" ID="SqlDataSourceAnaAltRes" ConnectionString='<%$ ConnectionStrings:ConnectionString %>' ProviderName='<%$ ConnectionStrings:ConnectionString.ProviderName %>' SelectCommand="SELECT * FROM [anasayfa_gerecler] WHERE ([gerec_durum] = ?)">
            <SelectParameters>
                <asp:Parameter DefaultValue="1" Name="gerec_durum" Type="String"></asp:Parameter>
            </SelectParameters>
        </asp:SqlDataSource>
        
        <div class="clear"></div>
    </div>
</asp:Content>

