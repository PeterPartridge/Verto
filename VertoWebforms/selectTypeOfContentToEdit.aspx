<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="selectTypeOfContentToEdit.aspx.cs" Inherits="VertoWebforms.selectTypeOfContentToEdit" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="small-12 columns centerItem">
       <a class="button sucess" href="EditList.aspx?id=products">Products</a>
         <a class="button sucess" href="EditList.aspx?id=gallery">Gallery</a>
         <a class="button sucess" href="EditList.aspx?id=field">Feild Events</a>
         <a class="button sucess" href="EditList.aspx?id=news">News</a>
         <a class="button sucess" href="EditList.aspx?id=offers">Offers</a>
        <a class="button sucess" href="EditList.aspx?id=catagories">Catagories</a>
            </div>
    </div>
</asp:Content>
