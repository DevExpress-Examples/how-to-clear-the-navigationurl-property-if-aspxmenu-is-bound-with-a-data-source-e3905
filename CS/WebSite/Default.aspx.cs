using System;
using System.Collections.Generic;
using System.Linq;

using DevExpress.Web.ASPxMenu;

public partial class _Default : System.Web.UI.Page {
	bool correctItems = false; // for the demo purpose only
	protected void Page_Load(object sender, EventArgs e) {

	}

	protected void ASPxMenu1_ItemDataBound(object source, MenuItemEventArgs e) {
		//Uncomment the following code to use it in a real application
		//if ((e.Item.Parent != null) && (!String.IsNullOrEmpty(e.Item.Parent.NavigateUrl))) {
		//    e.Item.Parent.NavigateUrl = null;
		//}


		//The following code is used for the demo purpose only. Do not use it in a real scenario
		if (correctItems) {
			if ((e.Item.Parent != null) && (!String.IsNullOrEmpty(e.Item.Parent.NavigateUrl))) {
				e.Item.Parent.NavigateUrl = null;
			}
		}
		else if (e.Item.Text == "Corrected Menu")
			correctItems = true;
	}
}