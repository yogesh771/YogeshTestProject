using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yogeshwarTestProject
{
    public partial class Notes : System.Web.UI.Page
    {
        private readonly NotesEntities db = new NotesEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userId"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            ReadNotes();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string Title = txtTitle.Value;
            string desc = txtComment.Value;
            try
            {
                if (Title != "" && desc != "")
                {
                    if (noteid.Value == "")
                    {
                        var obj = new TblNote();
                        obj.Title = Title;
                        obj.NoteDescription = desc;
                        obj.UserId = Convert.ToInt32(Session["userId"]);
                        obj.isDeleted = false;
                        db.TblNotes.Add(obj);
                    }
                    else {
                        Int32 noteId = Convert.ToInt32(noteid.Value);
                        var obj = db.TblNotes.Find(noteId);
                        obj.Title = Title;
                        obj.NoteDescription = desc;
                        db.Entry(obj).State = EntityState.Modified;
                        db.SaveChanges();

                    }
                    db.SaveChanges();
                    ReadNotes();
                    txtComment.Value = "";
                    txtTitle.Value = "";
                    noteid.Value = "";

                }
                else
                {
                    lblMsg.Text = "Title and descriptions are required.";
            }
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Record not saved.";
            }
            return;
        }


        private void ReadNotes()
        {
            Int32 userId= Convert.ToInt32(Session["userId"]);
            var Notes = db.TblNotes.Where(e => e.UserId == userId && e.isDeleted==false).ToList();
            rptNotes.DataSource = Notes;
            rptNotes.DataBind();
        }
        protected void rptNotes_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int NoteId = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName.ToLower().ToString() == "edit")
            {
                var obj = db.TblNotes.Find(NoteId);
                txtTitle.Value = obj.Title;
                txtComment.Value = obj.NoteDescription;
                noteid.Value = obj.NoteId.ToString();
                
            }
            if (e.CommandName.ToLower().ToString() == "delete")
            {
                var obj = db.TblNotes.Find(NoteId);
                obj.isDeleted = true;                
                db.Entry(obj).State = EntityState.Modified;
                db.SaveChanges();
            }
            ReadNotes();
        }

      
    }
}