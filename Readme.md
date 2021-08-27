<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128597612/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E591)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/E591/Form1.cs) (VB: [Form1.vb](./VB/E591/Form1.vb))
<!-- default file list end -->
# How to print some additional information below a printable control


<p><strong>Description</strong>:<br />
I'm printing the XtraGrid via the XtraPrinting Library.  I want to output some additional information below the grid on a printed page.  How can this be done?</p><p><strong>Solution</strong>:<br />
<strong>Applies to:</strong><br />
<i>XtraPrinting Library, XtraGrid, XtraTreeList, XtraPivotGrid, XtraScheduler, XtraCharts</i></p><p>You should handle the <strong>CreateReportFooterArea</strong> event of your <strong>PrintableComponentLink</strong> to render anything below the printed control.  Some sample code is listed below.  The whole test project is attached.  We also advise that you explore the demo projects shipped with the XtraPrinting Library to learn how to create printable bricks of different types.<br />
</p>

```vb
        void printableComponentLink1_CreateReportFooterArea(object sender, CreateAreaEventArgs e)
        {
            TextBrick brick = e.Graph.DrawString("My Report Footer", Color.Navy, new RectangleF(0, 10, 400, 40), BorderSide.None);
            brick.BackColor = Color.White;
            brick.Font = new Font("Tahoma", 16);
            brick.StringFormat = new DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Center);            
        }


<bold>
```

<p>See Also:</bold><br />
<a href="https://www.devexpress.com/Support/Center/p/A791">A791</a><br />
<a href="https://www.devexpress.com/Support/Center/p/A2648">A2648</a><br />
<a href="https://www.devexpress.com/Support/Center/p/A2730">A2730</a></p>

<br/>


