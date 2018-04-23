<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v11.2, Version=11.2.10.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxMenu" TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<dx:ASPxMenu ID="ASPxMenu1" runat="server" NavigateUrl="~/Default2.aspx" 
			DataSourceID="XmlDataSource1" NavigateUrlField="url" 
			onitemdatabound="ASPxMenu1_ItemDataBound" TextField="caption">
		</dx:ASPxMenu>
	</div>
	<asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/Menu.xml" 
		XPath="//root/*"></asp:XmlDataSource>
	</form>
</body>
</html>