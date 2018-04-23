Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid.Drawing
Imports DevExpress.Utils.Drawing

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Private _Painter As DevExpress.Utils.Drawing.HeaderObjectPainter
				Private Function CreateTable(ByVal RowCount As Integer) As DataTable
			Dim tbl As New DataTable()
			tbl.Columns.Add("Name", GetType(String))
			tbl.Columns.Add("ID", GetType(Integer))
			tbl.Columns.Add("Number", GetType(Integer))
			tbl.Columns.Add("Date", GetType(DateTime))
			For i As Integer = 0 To RowCount - 1
				tbl.Rows.Add(New Object() { String.Format("Name{0}", i), i, 3 - i, DateTime.Now.AddDays(i) })
			Next i
			Return tbl
				End Function


		Public Sub New()
			InitializeComponent()
			gridControl1.DataSource = CreateTable(20)
			AddHandler advBandedGridView1.CustomDrawCell, AddressOf advBandedGridView1_CustomDrawCell
			_Painter = New GridPainter(advBandedGridView1).ElementsPainter.Column
		End Sub

		Private Sub advBandedGridView1_CustomDrawCell(ByVal sender As Object, ByVal e As RowCellCustomDrawEventArgs)
			If e.Column Is gridColumn1 Then
				e.Handled = True
				Dim args As New HeaderObjectInfoArgs()
				Dim bounds As Rectangle = e.Bounds
				bounds.Inflate(1, 1)
				args.Bounds = bounds
				args.Caption = e.DisplayText
				args.Cache = e.Cache
				bounds.Offset(-bounds.Location.X, -bounds.Location.Y)
				args.CaptionRect = bounds
				args.Appearance.Assign(e.Appearance)
				_Painter.DrawObject(args)
			End If
		End Sub
	End Class
End Namespace