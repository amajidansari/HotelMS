<%@ Page Title="" Language="C#" MasterPageFile="~/Views/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="HotelMS.Views.Categories" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       <div class="container-fluid">
           <div class="row"><div class="col-md-5"></div><div class="col-md-5"></div><div class="col-md-2"><label id ="logeduser" runat="server" class="text-success"></label></div></div>
        <div class="row">
            <div class="col-4"></div>
            <div class="col-4"><h1 class="text-success text-center">Manage Categories</h1></div>
        
                <div class="col-4"></div>
        
        </div>
        <div class="row">

            <div class="col-md-3">
                 <form>
            <div class="mb-3">
               <label for="cattb" class="form-label">Category Name</label>
             <input type="text" class="form-control" id="cattb" runat="server" />
              </div>
              

                      <div class="mb-3">
               <label for="remarktb" class="form-label">Remarks</label>
             <input type="text" class="form-control" id="remarktb" runat="server"/>
              </div>

                     
                    <div class="row">
                        <div class="col d-grid">
                        <asp:Button runat="server" ID ="Button2" Text="Edit"  class="btn btn-warning  btn-block " OnClick="Button2_Click"  />
 </div>
                                         <div class="col d-grid">
       
                        <asp:Button runat="server" ID ="Button1" Text="Delete"  class="btn btn-danger  btn-block " OnClick="Button1_Click"/>
       
                                             </div>
                                                             </div><br />
  
                    <div class="d-grid">
                        <label id="errmsg" runat="server" class="text-danger"></label>
 
                        <asp:Button runat="server" ID ="savebutton" Text="save"  class="btn btn-success  btn-block " OnClick="savebutton_Click"/>
                       </div>
                      
                    <br /><br />
</form>


            </div>

            <div class="col-md-9">


                <asp:GridView ID="Catgv" class="table"  runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="Catgv_SelectedIndexChanged">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Select" Text="Select"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </div>


        </div>


    </div>
</asp:Content>
