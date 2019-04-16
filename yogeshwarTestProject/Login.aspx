<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="yogeshwarTestProject.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Yogesh Test App</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.3.1.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="row">
             <div class="col-lg-offset-3 col-md-offset-3  col-lg-4 col-md-4">
                 
                 <div class="form-group">
                 <asp:Label ID="lblMsg" runat="server"></asp:Label>    
                 </div>
                    
                 
                  <div class="form-group">
                      
                           <input type ="text" class="form-control" id="txtUserName" placeholder="Please enter your user name" required runat="server" />
                       
                    </div>
                      
                 
                 <div class="form-group">
                  
                           <input type ="password"  class="form-control" id="txtPassword" placeholder="Please enter your password" required  runat="server"/>
                       
                    </div>
                     
            
             <div class="form-group">
             <asp:Button ID="btnLogin" Text="Login" runat="server"  Class="btn btn-primary" OnClick="btnLogin_Click" />
                 </div>
                  </div>
        </div>
    </form>
</body>
</html>
