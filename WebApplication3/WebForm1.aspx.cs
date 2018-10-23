using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int a;
        double sum = 1.0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(int.TryParse(TextBox1.Text, out a))
            {
                a = Convert.ToInt32(TextBox1.Text);
                for(int i=1;i<=a;i++)
                {
                    sum = 1.0 / Factorial(i);
                }
                Label1.Text = sum.ToString();
            }
            else
            {

            }
        }
    }
}