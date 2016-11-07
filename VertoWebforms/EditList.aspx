<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditList.aspx.cs" Inherits="VertoWebforms.EditList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView runat="server" ID="editGriedView"  OnRowCancelingEdit="editGriedView_RowCancelingEdit"
         OnRowEditing="editGriedView_RowEditing" OnRowUpdating="editGriedView_RowUpdating" AutoGenerateColumns="False" CssClass="centerItem">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="ListEditButton" runat="server" CommandName="Edit">Edit</asp:LinkButton>
                </ItemTemplate>
                <EditItemTemplate>
                      <asp:LinkButton ID="ListUpdateButton" runat="server" CommandName="Update">Update</asp:LinkButton>
                <asp:LinkButton ID="ListCancelBUtton" runat="server" CommandName="Cancel">Cancel</asp:LinkButton>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="ID">  
                    <ItemTemplate>  
                        <asp:Label ID="Edit_ID" runat="server" Text='<%#Eval("Id") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>  
            <asp:TemplateField HeaderText="Title">
                 <ItemTemplate>
             <asp:Label ID="ListTitle" runat="server" Text='<%# Eval("Title") %>' ></asp:Label>
                 </ItemTemplate>
                <EditItemTemplate>
             <asp:TextBox ID="ListTitleEdit" runat="server" Text='<%# Eval("Title") %>'></asp:TextBox>
               </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Body Content">
                 <ItemTemplate>
             <asp:Label ID="bodyContent" runat="server" Text='<%# Eval("bodyContent") %>'></asp:Label>
                 </ItemTemplate>
                <EditItemTemplate>
             <asp:TextBox ID="bodyContentEdit" runat="server" Text='<%# Eval("bodyContent") %>'></asp:TextBox>
               </EditItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>   

</asp:Content>
