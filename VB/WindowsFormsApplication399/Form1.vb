Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsFormsApplication399
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			AddHandler gridControl1.VisibleChanged, AddressOf gridControl1_VisibleChanged
			AddHandler gridControl2.VisibleChanged, AddressOf gridControl1_VisibleChanged
		End Sub

		Private Sub gridControl1_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
			transitionManager1.EndTransition()
		End Sub

		Private Sub navBarControl1_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navBarControl1.LinkClicked
			Select Case e.Link.Caption
				Case "Grid1"
					transitionManager1.StartTransition(panelControl1)
					gridControl2.Visible = False
					gridControl1.Visible = True
				Case "Grid2"
					transitionManager1.StartTransition(panelControl1)
					gridControl2.Visible = True
					gridControl1.Visible = False
				Case Else
			End Select
		End Sub
	End Class
End Namespace
