Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq

Imports DevExpress.Web.ASPxMenu

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Private correctItems As Boolean = False ' for the demo purpose only
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub

	Protected Sub ASPxMenu1_ItemDataBound(ByVal source As Object, ByVal e As MenuItemEventArgs)
		'Uncomment the following code to use it in a real application
		'if ((e.Item.Parent != null) && (!String.IsNullOrEmpty(e.Item.Parent.NavigateUrl))) {
		'    e.Item.Parent.NavigateUrl = null;
		'}


		'The following code is used for the demo purpose only. Do not use it in a real scenario
		If correctItems Then
			If (e.Item.Parent IsNot Nothing) AndAlso ((Not String.IsNullOrEmpty(e.Item.Parent.NavigateUrl))) Then
				e.Item.Parent.NavigateUrl = Nothing
			End If
		ElseIf e.Item.Text = "Corrected Menu" Then
			correctItems = True
		End If
	End Sub
End Class