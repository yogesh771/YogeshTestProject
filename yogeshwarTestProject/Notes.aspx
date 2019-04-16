<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Notes.aspx.cs" Inherits="yogeshwarTestProject.Notes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.3.1.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server"> 
      
        <div class="col-md-12">
            <div class="col-md-3">
                <div class="table-responsive" style="margin-top:20px">
                        <asp:Repeater ID="rptNotes" runat="server" OnItemCommand="rptNotes_ItemCommand">
                            
                            <ItemTemplate>
                                <div  class="col-md-12" style="border:1px solid black; padding:8px">
                                    <div  class="col-md-8">
                                        <div class="font-weight-medium"><b><%# Eval("Title") %></b>
                                        </div> 
                                 </div> 
                                     <div  class="col-md-4"><asp:LinkButton ID="NotesEdit" runat="server" CommandName="edit" CommandArgument='<%# Eval("NoteId") %>'><i class="glyphicon glyphicon-edit"></i></asp:LinkButton> |
                                   
                                        <asp:LinkButton ID="NotesDelete" runat="server" CommandName="delete" CommandArgument='<%# Eval("NoteId") %>'><i class="glyphicon glyphicon-trash"></i></asp:LinkButton>
                                    </div>
                                     <div  class="col-md-12">
                                    <div class="font-weight-medium">
                                        <%# Eval("NoteDescription") %>
                                    </div> 
                                     </Div>
                                    </div>
                               
                            </ItemTemplate>
                        </asp:Repeater>



                    </div>
            </div>
            <div class="col-md-9">
                <div class="form-group">
                 <asp:Label ID="lblMsg" runat="server"></asp:Label>    <asp:HiddenField ID="noteid" runat="server" />
                 </div>
                 
                  <div class="form-group">
                      
                           <input type ="text" class="form-control" id="txtTitle" placeholder="Please add tiltle" required runat="server" />
                       
                    </div>
                 

                 
                  <div class="form-group">
                      
                           <textarea rows="10" cols="30" class="form-control" id="txtComment" placeholder="Please add Description" required runat="server" ></textarea>
                        
                   
                 </div>
                  <div class="form-group">
                     <asp:Button ID="btnSave" Text="Save" runat="server"  Class="btn btn-primary" OnClick="btnSave_Click"  />
                 </div>
            
        </div>
            </div>
       
    </form>
</body>
</html>
