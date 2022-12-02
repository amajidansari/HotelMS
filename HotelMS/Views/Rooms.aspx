<%@ Page Title="" Language="C#" MasterPageFile="~/Views/AdminMaster.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="Rooms.aspx.cs" Inherits="HotelMS.Views.Rooms" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  

    <div class="container-fluid">
        <div class="row">
            <div class="col-4"></div>
            <div class="col-4"><h1 class="text-success text-center">Manage Rooms</h1></div>
        
                <div class="col-4"></div>
        
        
        </div>
        <div class="row">

            <div class="col-md-3">
                 <form >
            <div class="mb-3">
               <label for="Rnametb" class="form-label">Room Name</label>
             <input type="text" class="form-control" id="Rnametb" runat="server" required="required" />
              </div>
             <div class="mb-3">
              <label for="catcb" class="form-label">Categories</label><br />
                 <asp:DropDownList ID="catcb" class="btn btn-primary dropdown-toggle btn-sm" runat="server"></asp:DropDownList>
                 </div>

                      <div class="mb-3">
               <label for="locationtb" class="form-label">Location</label>
             <input type="text" class="form-control" id="locationtb" runat="server" required="required" />
              </div>

                      <div class="mb-3">
               <label for="roomcosttb" class="form-label">Room cost</label>
             <input type="text" class="form-control" id="roomcosttb" runat="server" required="required" />
              </div>
                               <div class="mb-3">
               <label for="remarks" class="form-label">Remrks</label>
             <input type="text" class="form-control" id="remarks" runat="server" required="required" />
              </div>

                      <div class="mb-3">
               <label for="status" class="form-label" >status</label>
                    <br />
                 <asp:DropDownList ID="status"   class="btn btn-primary dropdown-toggle btn-sm" runat="server">
                     <asp:ListItem>Available</asp:ListItem>
                     <asp:ListItem>Booked</asp:ListItem>

                 </asp:DropDownList>
             
            
              </div>
          
                    <div class="row">
                        <div class="col d-grid">
                        <asp:Button runat="server" ID ="Button2" Text="Edit"  class="btn btn-warning  btn-block " OnClick="Button2_Click"  />
 </div>
                                         <div class="col d-grid">
       
                        <asp:Button runat="server" ID ="Button1" Text="Delete"  class="btn btn-danger  btn-block " OnClick="Button1_Click" />
       
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


                   <asp:GridView ID="Roomsgv" class="table"  runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="Roomsgv_SelectedIndexChanged"  >
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
