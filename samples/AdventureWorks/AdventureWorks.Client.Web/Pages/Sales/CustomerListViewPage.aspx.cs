//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "ASP.NET Search Pages" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using System;
using System.Web;
using System.Web.UI;

namespace AdventureWorks.Client.Web
{
    public partial class CustomerListViewPage : Page
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!IsPostBack) uclCustomerListView.Activate(Request.QueryString);
        }
    }
}