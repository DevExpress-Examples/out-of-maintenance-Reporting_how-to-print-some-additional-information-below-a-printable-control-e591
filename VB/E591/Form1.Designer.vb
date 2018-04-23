Imports Microsoft.VisualBasic
Imports System
Namespace E591
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.button1 = New System.Windows.Forms.Button()
			Me.printingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
			Me.printableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.printingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.printableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Location = New System.Drawing.Point(13, 13)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(730, 347)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(328, 404)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(75, 23)
			Me.button1.TabIndex = 1
			Me.button1.Text = "button1"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' printingSystem1
			' 
			Me.printingSystem1.Links.AddRange(New Object() { Me.printableComponentLink1})
			' 
			' printableComponentLink1
			' 
			Me.printableComponentLink1.Component = Me.gridControl1
			' 
			' 
			' 
			Me.printableComponentLink1.ImageCollection.ImageStream = (CType(resources.GetObject("printableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.printableComponentLink1.PrintingSystem = Me.printingSystem1
			Me.printableComponentLink1.PrintingSystemBase = Me.printingSystem1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(755, 439)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.printingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.printableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private WithEvents button1 As System.Windows.Forms.Button
		Private printingSystem1 As DevExpress.XtraPrinting.PrintingSystem
		Private printableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
	End Class
End Namespace

