﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dobre_misli
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void dodajMisel_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Insert(0, misel.Text);        
        }
    }
    
}