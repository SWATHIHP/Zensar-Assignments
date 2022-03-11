using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DropDownList
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {


                string[] str = new string[] { "Select", "iPhone XS(64GB)", "iPhone 12(128GB)", "iPhone 12Pro(256GB)", "iPhone 13(512GB)", "iPhone 13Pro(1TB)" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/images/" + str + ".jfif";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "iPhone XS(64GB)")
            {
                TextBox1.Text = "79,900 INR";
            }
            else if (DropDownList1.SelectedValue == "iPhone 12(128GB)")
            {
                TextBox1.Text = "60,990 INR";
            }
            else if (DropDownList1.SelectedValue == "iPhone 12Pro(256GB)")
            {
                TextBox1.Text = "1,04,900 INR";
            }
            else if (DropDownList1.SelectedValue == "iPhone 13(512GB)")
            {
                TextBox1.Text = "1,39,900 INR";
            }
            else if (DropDownList1.SelectedValue == "iPhone 13Pro(1TB)")
            {
                TextBox1.Text = "1,69,900 INR";
            }
        }
    }
    
}