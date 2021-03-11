<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="hakkimizda.aspx.cs" Inherits="hakkimizda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="stil/hakkimizda_stil.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceGovde" Runat="Server">
    <div id="hakkimizda">
        <asp:Repeater ID="RepeaterSayfa" runat="server" DataSourceID="SqlDataSourceBilgi">
            <ItemTemplate>
                <h4><%#Eval("bilgi_baslik") %></h4><br />
                <%#Eval("bilgi_metin") %>
            </ItemTemplate>
        </asp:Repeater>
        <asp:SqlDataSource runat="server" ID="SqlDataSourceBilgi" ConnectionString='<%$ ConnectionStrings:ConnectionString %>' ProviderName='<%$ ConnectionStrings:ConnectionString.ProviderName %>' SelectCommand="SELECT * FROM [bilgi]"></asp:SqlDataSource>
        
        
        
    </div>
    
</asp:Content>

