Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
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
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.advBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
			Me.Header = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.gridColumn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridColumn2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridColumn3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridColumn4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.bandedGridColumn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.bandedGridColumn2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.bandedGridColumn3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.gridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.advBandedGridView1
			Me.gridControl1.Margin = New System.Windows.Forms.Padding(4)
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(731, 559)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.advBandedGridView1, Me.gridView2})
			' 
			' advBandedGridView1
			' 
			Me.advBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.Header, Me.gridBand3, Me.gridBand4, Me.gridBand2})
			Me.advBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() { Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.bandedGridColumn1, Me.bandedGridColumn2, Me.bandedGridColumn3})
			Me.advBandedGridView1.GridControl = Me.gridControl1
			Me.advBandedGridView1.Name = "advBandedGridView1"
			Me.advBandedGridView1.OptionsView.ShowBands = False
			Me.advBandedGridView1.OptionsView.ShowColumnHeaders = False
			' 
			' Header
			' 
			Me.Header.Caption = "gridBand1"
			Me.Header.Columns.Add(Me.gridColumn1)
			Me.Header.Columns.Add(Me.gridColumn2)
			Me.Header.Columns.Add(Me.gridColumn3)
			Me.Header.Columns.Add(Me.gridColumn4)
			Me.Header.Columns.Add(Me.bandedGridColumn1)
			Me.Header.Columns.Add(Me.bandedGridColumn2)
			Me.Header.Columns.Add(Me.bandedGridColumn3)
			Me.Header.Name = "Header"
			Me.Header.Width = 691
			' 
			' gridColumn1
			' 
			Me.gridColumn1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.gridColumn1.AppearanceCell.Options.UseFont = True
			Me.gridColumn1.AppearanceCell.Options.UseTextOptions = True
			Me.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.gridColumn1.Caption = "Name"
			Me.gridColumn1.FieldName = "Name"
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.Visible = True
			Me.gridColumn1.Width = 691
			' 
			' gridColumn2
			' 
			Me.gridColumn2.Caption = "ID"
			Me.gridColumn2.FieldName = "ID"
			Me.gridColumn2.Name = "gridColumn2"
			Me.gridColumn2.RowIndex = 1
			Me.gridColumn2.Visible = True
			Me.gridColumn2.Width = 230
			' 
			' gridColumn3
			' 
			Me.gridColumn3.Caption = "Number"
			Me.gridColumn3.FieldName = "Number"
			Me.gridColumn3.Name = "gridColumn3"
			Me.gridColumn3.RowIndex = 1
			Me.gridColumn3.Visible = True
			Me.gridColumn3.Width = 230
			' 
			' gridColumn4
			' 
			Me.gridColumn4.Caption = "Date"
			Me.gridColumn4.FieldName = "Date"
			Me.gridColumn4.Name = "gridColumn4"
			Me.gridColumn4.RowIndex = 1
			Me.gridColumn4.Visible = True
			Me.gridColumn4.Width = 231
			' 
			' bandedGridColumn1
			' 
			Me.bandedGridColumn1.Caption = "bandedGridColumn1"
			Me.bandedGridColumn1.FieldName = "Name"
			Me.bandedGridColumn1.Name = "bandedGridColumn1"
			Me.bandedGridColumn1.RowIndex = 2
			Me.bandedGridColumn1.Visible = True
			' 
			' bandedGridColumn2
			' 
			Me.bandedGridColumn2.Caption = "bandedGridColumn2"
			Me.bandedGridColumn2.FieldName = "Name"
			Me.bandedGridColumn2.Name = "bandedGridColumn2"
			Me.bandedGridColumn2.RowIndex = 2
			Me.bandedGridColumn2.Visible = True
			' 
			' bandedGridColumn3
			' 
			Me.bandedGridColumn3.Caption = "bandedGridColumn3"
			Me.bandedGridColumn3.FieldName = "Name"
			Me.bandedGridColumn3.Name = "bandedGridColumn3"
			Me.bandedGridColumn3.RowIndex = 2
			Me.bandedGridColumn3.Visible = True
			' 
			' gridBand3
			' 
			Me.gridBand3.Caption = "gridBand3"
			Me.gridBand3.Name = "gridBand3"
			Me.gridBand3.Visible = False
			Me.gridBand3.Width = 75
			' 
			' gridBand4
			' 
			Me.gridBand4.Caption = "gridBand4"
			Me.gridBand4.Name = "gridBand4"
			Me.gridBand4.Visible = False
			Me.gridBand4.Width = 75
			' 
			' gridBand2
			' 
			Me.gridBand2.Caption = "gridBand2"
			Me.gridBand2.Name = "gridBand2"
			Me.gridBand2.Visible = False
			Me.gridBand2.Width = 75
			' 
			' gridView2
			' 
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(731, 559)
			Me.Controls.Add(Me.gridControl1)
			Me.Margin = New System.Windows.Forms.Padding(4)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private advBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
		Private gridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private gridColumn2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private gridColumn3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private gridColumn4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private bandedGridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private bandedGridColumn2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private bandedGridColumn3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private Header As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
	End Class
End Namespace

