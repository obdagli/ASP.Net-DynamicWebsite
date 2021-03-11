<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="Sepetim.aspx.cs" Inherits="Sepetim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 550px;
            margin:0 auto;
        }
        .butonsiparis {
    cursor: pointer;
    text-decoration: none;
    color: #fff;
    width: 60px;
    height: 25px;
    display: block;
    line-height: 20px;
    font-size: 13px;
    font-weight: bold;
    background: #080;
    border: 1px solid #060;
    padding: 0 5px;
    overflow: hidden;
    text-align: center;
    -moz-border-radius: 3px;
    -webkit-border-radius: 3px;
    border-radius: 3px;
}

    .butonsiparis:hover {
        color: #fff;
        background: #191b1d;
        border: 1px solid #a98c66;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceGovde" Runat="Server">
        <asp:DataList ID="DataList1" CssClass="deneme" runat="server" CellPadding="4" ForeColor="#333333" OnItemCommand="DataList1_ItemCommand">
        <AlternatingItemStyle BackColor="White" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderTemplate>
            <table class="auto-style1">
                <tr>
                    <th style="text-align:center;width:10%">Ürün Id</th>
                    <th style="text-align:center;width:40%">Ürün Ad</th>
                    <th style="text-align:center;width:10%;">Ürün Fiyat</th>
                    <th style="text-align:center;width:10%;">Ürün Adet</th>
                    <th style="text-align:center;width:20%;">Ürün Tutar</th>
                    <th style="text-align:center;width:10%;">Sil</th>
                </tr>
            </table>
        </HeaderTemplate>
        <ItemStyle BackColor="#E3EAEB" />
        <ItemTemplate>
            <table class="auto-style1">
                <tr>
                    <td style="text-align:center;width:10%"><%# Eval("id") %></td>
                    <td style="text-align:center;width:40%"><%# Eval("isim") %></td>
                    <td style="text-align:center;width:10%"><%# Eval("fiyat") %></td>
                    <td style="text-align:center;width:10%"><%# Eval("adet") %></td>
                    <td style="text-align:center;width:20%"><%# Eval("tutar") %></td>
                    <td style="text-align:center;width:10%"><asp:LinkButton ID="btnSil" runat="server" CommandArgument='<%# Eval("id") %>' CommandName="sil">Sil</asp:LinkButton></td>
                </tr>
            </table>
        </ItemTemplate>
        <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
    </asp:DataList>
    <asp:Panel ID="Panel1" runat="server">
    <div class="satinal" style="margin-left:43%"><asp:Label ID="lblToplam" runat="server" Text="Label"></asp:Label><br />
    <asp:Button ID="btn_siparis" runat="server" CssClass="butonsiparis" Text="Sipariş" OnClick="btn_siparis_Click"/>
        <asp:Label ID="lblUyari" runat="server" Text="Label" Visible="false"></asp:Label>
    </div></asp:Panel>
    
</asp:Content>


