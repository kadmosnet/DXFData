using DXFReaderNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXFData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "TXT";
            openFileDialog1.Filter = "TXT|*.txt";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                ImportData(openFileDialog1.FileName);

            }
        }
        private void ImportData(string dataFileName)
        {
            dxfReaderNETControl1.NewDrawing();
            System.IO.StreamReader objReader;


            objReader = new System.IO.StreamReader(dataFileName);


            string l;

            do
            {
                l = objReader.ReadLine();
                if (l != null)
                {
                    string[] sl = l.Trim().Replace("   ", " ").Replace("  ", " ").Split((char)32);
                    dxfReaderNETControl1.AddPoint(new Vector3(double.Parse(sl[0], System.Globalization.CultureInfo.InvariantCulture), double.Parse(sl[1], System.Globalization.CultureInfo.InvariantCulture), double.Parse(sl[2], System.Globalization.CultureInfo.InvariantCulture)));
                }
            }
            while (l != null);
            objReader.Close();

            double minZ = 100000000;
            double maxZ = -100000000;
            foreach (DXFReaderNET.Entities.Point p in dxfReaderNETControl1.DXF.Points)
            {
                if (p.Position.Z < minZ) minZ = p.Position.Z;
                if (p.Position.Z > maxZ) maxZ = p.Position.Z;
            }
            double step = (maxZ - minZ) / 10;
            foreach (DXFReaderNET.Entities.Point p in dxfReaderNETControl1.DXF.Points)
            {
                short color = (short)(p.Position.Z / step * 25 + 10);
                if (color < 1) color = 1;
                if (color > 254) color = 254;
                p.Color = AciColor.FromCadIndex(color);
                //dxfReaderNETControl1.AddText(p.Position.Z.ToString(), p.Position, p.Position, step / 100, 0, TextAlignment.BaselineCenter, "", color);


            }
            dxfReaderNETControl1.Refresh();
            dxfReaderNETControl1.ZoomExtents();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.DisplayPredefinedView(PredefinedViewType.SW_Isometric);
            dxfReaderNETControl1.Refresh();
            dxfReaderNETControl1.ZoomExtents();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.DisplayPredefinedView(PredefinedViewType.Top);
            dxfReaderNETControl1.Refresh();
            dxfReaderNETControl1.ZoomExtents();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "dxf";
            saveFileDialog1.Filter = "DXF|*.dxf";
            saveFileDialog1.FileName = "drawing.dxf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dxfReaderNETControl1.WriteDXF(saveFileDialog1.FileName);

            }
        }
    }
}
