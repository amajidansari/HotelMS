<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Usermaster.Master" AutoEventWireup="true" CodeBehind="Booking.aspx.cs" Inherits="HotelMS.Views.Booking"  EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        <div class="row">
            
        
                           <div class="col">
                <div class="row"> 
                    
                    <div class="col">
                        <div class="row">
                            <div class="col">
                     <div class="mb-3">
               <label for="Rnametb" class="form-label">Room </label>
             <input type="text" class="form-control" id="Roomtb" runat="server" required="required" />
              </div>

                            <div class="mb-3">
               <label for="datetb" class="form-label">Date In </label>
                                <input   class="form-control" id="datetb" runat="server" required="required" TextMode="Date"/>
                          
              </div>


                            </div>


                            <div class="col">
                            <div class="mb-3">
               <label for="dateouttb" class="form-label">Date Out </label>
                                <input class="form-control" id="dateoutb" runat="server" required="required" TextMode="Date"/>
              </div>

                            <div class="mb-3">
               <label for="amountb" class="form-label">Amount</label>                               
                 <input TextMode="number"  class="form-control" id="amountb" runat="server" required="required" />

              </div>

                            </div>


                        </div>


                               
                        <br />
                    <div class="row">
                        <div class="col">

                              <div class="d-grid">
                        <label id="errmsg" runat="server" class="text-danger"></label>
 
                        <asp:Button runat="server" ID ="bookbtn" Text="Book"  class="btn btn-warning" OnClick="bookbtn_Click" />     <br />             
                                        <asp:Button runat="server" ID ="btnreset" Text="Reset"  class="btn btn-danger" />

                       </div>
                        </div>

                    </div>
                       
                    </div>
                    

                    

                </div>

                



            <div class="text-primary"> Rooms</div>   
                   <asp:GridView ID="Roomsgv" class="table"  runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="Roomsgv_SelectedIndexChanged"   >
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










      <div class="col">
          <div class="row">

              <div class="col"></div>
              <div class="col"><h2 class="text-primary">Pending Books</h2></div>

          </div>
          <div class="row">
              <div class="col">


                          <asp:GridView ID="bookinggv" class="table"  runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
         
   </div>


        
        
        
        </div>
</asp:Content>
