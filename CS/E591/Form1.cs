using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Design;
using DevExpress.XtraPrinting;

namespace E591
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            printableComponentLink1.CreateReportFooterArea+=new CreateAreaEventHandler(printableComponentLink1_CreateReportFooterArea);
        }

        void printableComponentLink1_CreateReportFooterArea(object sender, CreateAreaEventArgs e)
        {
            TextBrick brick = e.Graph.DrawString("My Report Footer", Color.Navy, new RectangleF(0, 10, 400, 40), BorderSide.None);
            brick.BackColor = Color.White;
            brick.Font = new Font("Tahoma", 16);
            brick.StringFormat = new DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Center);            
        }

        private void button1_Click(object sender, EventArgs e)
        {
             printableComponentLink1.CreateDocument();
             printableComponentLink1.ShowPreview();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XViewsPrinting V = new XViewsPrinting(gridControl1);
        }
    }
}
