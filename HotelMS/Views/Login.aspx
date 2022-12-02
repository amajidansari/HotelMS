<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HotelMS.Views.Login" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Assets/css/bootstrap.min.css" rel="stylesheet"/>
    
 
<style>
    body {
    
    
        background-image:url(../Assets/Images/hotel2.jfif);
    background-size:cover;
    
    }
    .container-fluid{
    opacity:1.9;
    }
    

</style>
</head>
<body>

    <form id ="form1" runat="server">


    
    <div class="container-fluid">
       <div class="row" style="height:120px;"></div> 
       <div class="row">
            <div class="col-md-4">

            </div>
            <div class="col-md-4 bg-light rounded-3">
                <h1 class="text-success  text-center" >Venture Stay Hotel</h1>
                <form>
            <div class="mb-3">
               <label for="exampleInputEmail1" class="form-label" >Email address</label>
             <input type="text" class="form-control" runat="server" required="required" id="email" />
              </div>
             <div class="mb-3">
              <label for="exampleInputPassword1" class="form-label">Password</label>
             <input type="password" class="form-control" id="password"  required="required" runat="server"/>
                 </div>
                <div class="mb-3">
                    <label id="errormsg" class="text-danger" runat="server"></label>

    <input type="radio"  id="admincb" runat="server"  name="Admin"/>   <label class="text-success">Admin</label>
                 
    <input type="radio"  id="usercb" runat="server"    name="user" /><label class="text-success">User</label>
 
  </div>
                    <div class="d-grid">
  

   <asp:Button ID="Logi" class="btn btn-success  btn-block " runat="server" Text="Login" OnClick="Logi_Click" />



                        </div>
                    <br /><br />
</form>
            </div>


            <div class="col-md-4">

            </div>
        </div>

    </div>
   </form>

</body>
</html>
