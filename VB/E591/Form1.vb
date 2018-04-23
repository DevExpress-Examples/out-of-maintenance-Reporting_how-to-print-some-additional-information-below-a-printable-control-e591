Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Design
Imports DevExpress.XtraPrinting

Namespace E591
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			AddHandler printableComponentLink1.CreateReportFooterArea, AddressOf printableComponentLink1_CreateReportFooterArea
		End Sub

		Private Sub printableComponentLink1_CreateReportFooterArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)
			Dim brick As TextBrick = e.Graph.DrawString("My Report Footer", Color.Navy, New RectangleF(0, 10, 400, 40), BorderSide.None)
			brick.BackColor = Color.White
			brick.Font = New Font("Tahoma", 16)
			brick.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Center)
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			 printableComponentLink1.CreateDocument()
			 printableComponentLink1.ShowPreview()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim V As New XViewsPrinting(gridControl1)
		End Sub
	End Class
End Namespace
