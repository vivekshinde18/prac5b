using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class Pract5b1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            if (ViewState["count"] != null)
            {
                int viewstateval = Convert.ToInt32(ViewState["count"]) + 1;
                Label1.Text = "ViewState:" + viewstateval.ToString();
                ViewState["count"] = viewstateval.ToString();
            }
        }
        else
        {
            ViewState["count"] = "1";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label2.Text = ViewState["count"].ToString();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Page.EnableViewState = true;
        HiddenField1.Value = "welcome to our website:http://www.google.com" +
        "<br/>";
        Label1.Text = HiddenField1.Value;
        HiddenField1.Value = "0";
        int i = 0;
        i = (int.Parse(HiddenField1.Value)) + 1;
        Label2.Text = i.ToString();
        HiddenField1.Value = i.ToString();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        HttpCookie c1 = new HttpCookie("name");
        c1.Value = TextBox1.Text;
        Response.Cookies.Add(c1);
        Response.Redirect("WebForm2.aspx");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        ViewState["name"] = TextBox2.Text;
        ViewState["password"] = TextBox3.Text;
        TextBox2.Text = TextBox3.Text = string.Empty;
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        if (ViewState["name"] != null)
        {
            TextBox2.Text = ViewState["name"].ToString();
        }
        if (ViewState["password"] != null)
        {
            TextBox3.Text = ViewState["password"].ToString();
        }
    }
}
