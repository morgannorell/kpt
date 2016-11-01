using kpt.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace kpt
{
    public partial class courselogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnStartExam_Click(object sender, EventArgs e)
        {
            Coursetest ct = new Coursetest();
            ct.GetQuestions();

            //Response.Redirect("examination.aspx");
        }

        protected void btnLastExam_Click(object sender, EventArgs e)
        {

        }
    }
}