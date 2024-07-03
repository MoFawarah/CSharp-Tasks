using System;
using System.Text;

namespace stuff
{
    public partial class FormPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblName.Text = name.Text;
            lblEmail.Text = email.Text;
            lblId.Text = id.Text;
            lblTextarea.Text = textarea.Text;

            string gender = radioFemale.Checked ? "Female" : radioMale.Checked ? "Male" : "Not selected";
            lblGender.Text = gender;

            StringBuilder courses = new StringBuilder();
            if (courseC.Checked) courses.Append("C ");
            if (courseCSharp.Checked) courses.Append("C# ");
            if (courseCPlusPlus.Checked) courses.Append("C++ ");
            lblCourses.Text = courses.ToString();
        }
    }
}
