<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frontPage.aspx.cs" Inherits="VertoWebforms._frontPage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row  whiteBackground media-object stack-for-small"">
        <div class="media-object-section">
        <div class="small-12 medium-6 large-3  columns">
            <h4>New Products</h4>
            <asp:Image runat="server" ID="productImage" />
            <asp:TextBox CssClass="textBelowImage" ID="newProductTextBox" ReadOnly="true" TextMode="MultiLine" runat="server"></asp:TextBox>
            <a class="button success">New Products</a>
        </div>

        <div class="small-12 medium-6 large-3  columns">
            <h4>Field Events</h4>
          <asp:Image runat="server" ID="eventImage" />
            <asp:TextBox CssClass="textBelowImage" ID="feildEventTextBox" ReadOnly="true" TextMode="MultiLine" runat="server"></asp:TextBox>
            <a class="button success">View Events</a>
        </div>
        <div class="small-12 medium-6 large-3 columns">
            <h4>Latest News</h4>
           <asp:Image runat="server" ID="newsImage" />
            <asp:TextBox CssClass="textBelowImage" ID="latestNewsTextBox" ReadOnly="true" TextMode="MultiLine" runat="server"></asp:TextBox>
            <a class="button success">Read Article</a>
        </div>
        <div class="small-12 medium-6 large-3 columns">
            <h4>Gallery</h4>
          <asp:Image runat="server" ID="galleryImage" />
            <asp:TextBox CssClass="textBelowImage" ID="birdImagesTextBox" ReadOnly="true" TextMode="MultiLine" runat="server"></asp:TextBox>
            <a class="button success">View Gallery</a>
        </div>
            </div>
    </div>
    
    <div class="row grayBackground">
        <div class="TopandBottomPadding">
        <h3>Special Offers</h3>
            </div>
        
        <asp:Repeater ID="OffersRepeater" runat="server" DataSourceID="SqlDataSource1">
            <ItemTemplate>
                <div class="small-12 large-4 columns TopandBottomPadding">
                    <asp:Image runat="server" ImageUrl='<%#Eval("image")%>' AlternateText='<%#Eval("title")%>' />
                    <div class=" whiteFrame">
                        <p><%#Eval("title")%></p>
                        <p><b><%#Eval("offer")%></b></p>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        
        <div class="centerItem">
            <a class="button success TopandBottomPadding">View All offers</a>
        </div>
    </div>
    <asp:SqlDataSource
        ConnectionString='<%$ ConnectionStrings:DefaultConnection %>'
        ID="SqlDataSource1" runat="server"
        SelectCommand="SELECT Top 3 offersModels.offerTitle AS title, offersModels.Offer AS offer, ImagesModels.imageLocation AS image FROM ImagesModels INNER JOIN offersModels ON ImagesModels.imageId = offersModels.imageModelId"></asp:SqlDataSource>


    <div class="row">
        <div class="TopandBottomPadding">
        <h3>Product Catagories</h3>
            </div>
        <div class="catagoriesSlider">
            <%--Slider is responsive and will only show arrows when sliding is needed this should also work on swipes--%>
          <button type="button" class="slick-prev">Previous</button>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <div class="slide">
                        <asp:Image runat="server" ImageUrl='<%#Eval("image")%>'/>
                        <asp:Label runat="server"><%#Eval("catagory") %></asp:Label>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            <button type="button" class="slick-next">Next</button>
                </div>      
    </div>
</asp:Content>
