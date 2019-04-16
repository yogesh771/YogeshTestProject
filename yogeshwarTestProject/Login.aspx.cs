using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace yogeshwarTestProject
{
    public partial class Login : System.Web.UI.Page
    {
       private readonly NotesEntities db = new NotesEntities();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Value;
            string Password = txtPassword.Value;
            if (userName != "" && Password != "")
            {
                var model = db.TblUsers.Where(e1 => e1.UserName == userName && e1.Password == Password).FirstOrDefault();
                if (model!=null)
                {
                    Session["userId"] = model.UserId;
                    Response.Redirect("Notes.aspx");
                }
                else
                {

                    lblMsg.Text = "User name and passowrd not found.";
                    return;
                }
            }
            else {
                lblMsg.Text = "User name and passowrd are required.";
                return;
            }
        }
    }
}