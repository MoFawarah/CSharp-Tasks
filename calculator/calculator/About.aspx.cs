using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace calculator
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string num1Input = TextBox1.Text;
            string num2Input = TextBox2.Text;

            if (string.IsNullOrEmpty(num1Input) || !int.TryParse(num1Input, out int num1Value) ||
                string.IsNullOrEmpty(num2Input) || !int.TryParse(num2Input, out int num2Value))
            {
                Label3.Text = "Please enter two valid numbers.";
            }
            else
            {
                Label3.Text = (num1Value + num2Value).ToString();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string num1Input = TextBox1.Text;
            string num2Input = TextBox2.Text;

            if (string.IsNullOrEmpty(num1Input) || !int.TryParse(num1Input, out int num1Value) ||
                string.IsNullOrEmpty(num2Input) || !int.TryParse(num2Input, out int num2Value))
            {
                Label3.Text = "Please enter two valid numbers.";
            }
            else
            {
                Label3.Text = (num1Value - num2Value).ToString();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string num1Input = TextBox1.Text;
            string num2Input = TextBox2.Text;

            if (string.IsNullOrEmpty(num1Input) || !int.TryParse(num1Input, out int num1Value) ||
                string.IsNullOrEmpty(num2Input) || !int.TryParse(num2Input, out int num2Value))
            {
                Label3.Text = "Please enter two valid numbers.";
            }
            else
            {
                Label3.Text = (num1Value * num2Value).ToString();
            }


        }
    }
}