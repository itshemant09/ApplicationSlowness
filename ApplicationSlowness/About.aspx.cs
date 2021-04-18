using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

public partial class About : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Random random = new Random();
        int x = random.Next(60000);
        Thread.Sleep(x);
        Label1.Text = x.ToString();
    }
}