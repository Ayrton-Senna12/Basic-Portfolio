﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLHAKKIMDATableAdapter dt = new DataSet1TableAdapters.TBLHAKKIMDATableAdapter();
            Repeater1.DataSource = dt.HakkımdaListele();
            Repeater1.DataBind();

            DataSet1TableAdapters.TBLDENEYIMTableAdapter dt2 = new DataSet1TableAdapters.TBLDENEYIMTableAdapter();
            Repeater2.DataSource = dt2.DeneyimListesi();
            Repeater2.DataBind();

            DataSet1TableAdapters.TBLEGITIMTableAdapter dt3 = new DataSet1TableAdapters.TBLEGITIMTableAdapter();
            Repeater3.DataSource = dt3.EgitimListesi();
            Repeater3.DataBind();

            DataSet1TableAdapters.TBLHOBILERTableAdapter dt4 = new DataSet1TableAdapters.TBLHOBILERTableAdapter();
            Repeater4.DataSource = dt4.HobilerListesi();
            Repeater4.DataBind();

            DataSet1TableAdapters.TBLYETENEKTableAdapter dt5 = new DataSet1TableAdapters.TBLYETENEKTableAdapter();
            Repeater5.DataSource = dt5.YetenekListesi();
            Repeater5.DataBind();

        }
    }
}