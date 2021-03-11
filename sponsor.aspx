<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="sponsor.aspx.cs" Inherits="sponsor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="stil/sponsor_stil.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceGovde" Runat="Server">
    <div id="sponsorlar">
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSourceSponsor">
            <ItemTemplate>
                <div class="sponsor">            
            <a href="<%# Eval("sponsor_hedef")%>"><img src="<%#Eval("sponsor_resim") %>"" />
            <h4><%#Eval("sponsor_ad") %></h4><br />
            <p><%#Eval("sponsor_metin") %></p></a>
        </div>  
            </ItemTemplate>
        </asp:Repeater>
        <asp:SqlDataSource runat="server" ID="SqlDataSourceSponsor" ConnectionString='<%$ ConnectionStrings:ConnectionString %>' ProviderName='<%$ ConnectionStrings:ConnectionString.ProviderName %>' SelectCommand="SELECT * FROM [sponsor] WHERE ([sponsor_durum] = ?)">
            <SelectParameters>
                <asp:Parameter DefaultValue="1" Name="sponsor_durum" Type="String"></asp:Parameter>
            </SelectParameters>
        </asp:SqlDataSource>
        
    </div>
</asp:Content>

