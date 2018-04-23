using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.Utils.Drawing;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        private DevExpress.Utils.Drawing.HeaderObjectPainter _Painter;
                private DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Number", typeof(int));
            tbl.Columns.Add("Date", typeof(DateTime));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { String.Format("Name{0}", i), i, 3 - i, DateTime.Now.AddDays(i) });
            return tbl;
        }


        public Form1()
        {
            InitializeComponent();
            gridControl1.DataSource = CreateTable(20);
            advBandedGridView1.CustomDrawCell += advBandedGridView1_CustomDrawCell;
            _Painter = new GridPainter(advBandedGridView1).ElementsPainter.Column;
        }

        void advBandedGridView1_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column == gridColumn1)
            {
                e.Handled = true;
                HeaderObjectInfoArgs args = new HeaderObjectInfoArgs();
                Rectangle bounds = e.Bounds;
                bounds.Inflate(1, 1);
                args.Bounds = bounds;
                args.Caption = e.DisplayText;
                args.Cache = e.Cache;
                bounds.Offset(-bounds.Location.X, -bounds.Location.Y);
                args.CaptionRect = bounds;
                args.Appearance.Assign(e.Appearance);
                _Painter.DrawObject(args);
            }
        }
    }
}