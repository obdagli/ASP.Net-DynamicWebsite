<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="urunler.aspx.cs" Inherits="lol_rp_tr" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <link href="stil/urunler/urunstil.css" rel="stylesheet" />
    <link href="stil/urunler/tablo.css" rel="stylesheet" />

    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceGovde" runat="Server">
    <asp:Panel ID="PanelUrun" runat="server">
        <div class="ustbilgi">
                <div class="x">
                    <ul class="slides">
                        <asp:Repeater ID="RepeaterSlider1" runat="server" DataSourceID="SqlDataSourceSlider1">
                            <ItemTemplate>
                                <li data-thumb="<%#Eval("resimKucukAdres") %>"">
                                    <img src="<%#Eval("resimBuyukAdres") %>""/>
                                </li>
                            </ItemTemplate>
                        </asp:Repeater>
                        <asp:SqlDataSource runat="server" ID="SqlDataSourceSlider1" ConnectionString='<%$ ConnectionStrings:ConnectionString %>' ProviderName='<%$ ConnectionStrings:ConnectionString.ProviderName %>' SelectCommand="SELECT * FROM [resimler] WHERE ([altkategori_id] = ?)">
                            <SelectParameters>
                                <asp:QueryStringParameter QueryStringField="altKat" Name="altkategori_id" Type="Int32"></asp:QueryStringParameter>
                            </SelectParameters>
                        </asp:SqlDataSource>
                    </ul>
                </div>
            <asp:Repeater ID="RepeaterUrunlerUstBilgi" runat="server" DataSourceID="SqlDataSourceUrunler">
                <ItemTemplate>

                    <p><%#Eval("altkategori_ustbilgi") %></p>
                </ItemTemplate>
            </asp:Repeater>
            <asp:SqlDataSource runat="server" ID="SqlDataSourceUrunler" ConnectionString='<%$ ConnectionStrings:ConnectionString %>' ProviderName='<%$ ConnectionStrings:ConnectionString.ProviderName %>' SelectCommand="SELECT * FROM [altkategori]"></asp:SqlDataSource>


        </div>
        <div class="urun">
            <div class="tablo-bg">
                <table>
                    <asp:Panel ID="PanelBaslik" runat="server">
                        <thead>
                            <tr>
                                <th>Ürün Adı</th>
                                <th>Fiyat</th>
                                <th>Sipariş</th>
                            </tr>
                        </thead>
                    </asp:Panel>
                    <tbody>
                        <asp:Repeater ID="RepeaterUrunler" runat="server" DataSourceID="SqlDataSourceUrunler2">
                            <ItemTemplate>
                                <tr>
                                    <td class="urunadi"><a href="urunler.aspx?urun_id=<%#Eval("urun_id") %>"><%#Eval("urun_ad") %></td>
                                    </a>
                                <td class="urunfiyat"><%#Eval("urun_fiyat") %> ₺</td>
                                    <td class="siparisbuton">
                                        <asp:Button ID="btn_siparis" OnClick="btn_siparis_Click" CssClass="butonsiparis" runat="server" Text="Sipariş" ToolTip='<%#Eval("urun_id") %>' /></td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                        <asp:SqlDataSource runat="server" ID="SqlDataSourceUrunler2" ConnectionString='<%$ ConnectionStrings:ConnectionString %>' ProviderName='<%$ ConnectionStrings:ConnectionString.ProviderName %>' SelectCommand="SELECT * FROM [urunler]"></asp:SqlDataSource>

                    </tbody>
                </table>
            </div>

        </div>
    </asp:Panel>
    <asp:Panel ID="PanelUrunDetay" runat="server" Visible="false">
        <div class="urundetay">
            <asp:Repeater ID="RepeaterUrunDetay" runat="server" DataSourceID="SqlDataSourceUrunDetay">
                <ItemTemplate>
                    <img src="<%#Eval("urun_foto") %>" />
                    <h4><%#Eval("urun_BilgiBaslik") %></h4>
                    <br />
                    <p><%#Eval("urun_BilgiMetin") %></p>
                </ItemTemplate>
            </asp:Repeater>
            <asp:SqlDataSource runat="server" ID="SqlDataSourceUrunDetay" ConnectionString='<%$ ConnectionStrings:ConnectionString %>' ProviderName='<%$ ConnectionStrings:ConnectionString.ProviderName %>' SelectCommand="SELECT * FROM [urunler] WHERE ([urun_id] = ?)">
                <SelectParameters>
                    <asp:QueryStringParameter QueryStringField="urun_id" Name="urun_id" Type="Int32"></asp:QueryStringParameter>
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
    </asp:Panel>
    <script src="js/jquery-2.1.4.js"></script>
    <script  src="js/jquery.flexslider.js"></script>

  <script type="text/javascript">
      $(window).load(function () {
          $('.x').flexslider({
              animation: "slide",
              controlNav: "thumbnails",
          });
      });
  </script>
</asp:Content>

