namespace DXFData
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DXFReaderNET.DxfDocument dxfDocument2 = new DXFReaderNET.DxfDocument();
            DXFReaderNET.AciColor aciColor2 = new DXFReaderNET.AciColor();
            DXFReaderNET.Objects.RasterVariables rasterVariables2 = new DXFReaderNET.Objects.RasterVariables();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dxfReaderNETControl1 = new DXFReaderNET.DXFReaderNETControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // dxfReaderNETControl1
            // 
            this.dxfReaderNETControl1.AutoSize = true;
            this.dxfReaderNETControl1.ContinuousHighlight = false;
            this.dxfReaderNETControl1.CustomCursor = DXFReaderNET.CustomCursorType.None;
            dxfDocument2.ActiveLayout = "Model";
            dxfDocument2.Comments = null;
            aciColor2.Index = ((short)(256));
            aciColor2.IsByBlock = false;
            aciColor2.IsByLayer = true;
            aciColor2.UseTrueColor = false;
            dxfDocument2.CurrentColor = aciColor2;
            dxfDocument2.CurrentElevation = 0D;
            dxfDocument2.CurrentLayer = "0";
            dxfDocument2.CurrentLineTypeName = "ByLayer";
            dxfDocument2.CurrentLineTypeScale = 1D;
            dxfDocument2.CurrentTextSize = 2.5D;
            dxfDocument2.CurrentTextStyle = "STANDARD";
            dxfDocument2.CurrentThickness = 0D;
            dxfDocument2.DateCreated = new System.DateTime(2022, 10, 13, 8, 40, 26, 988);
            dxfDocument2.DateLastEdited = new System.DateTime(2022, 10, 13, 8, 40, 26, 988);
            dxfDocument2.Handle = "0";
            dxfDocument2.IsBinary = false;
            dxfDocument2.Modified = false;
            dxfDocument2.Name = null;
            dxfDocument2.Owner = null;
            rasterVariables2.DisplayFrame = true;
            rasterVariables2.DisplayQuality = DXFReaderNET.Objects.ImageDisplayQuality.High;
            rasterVariables2.Handle = "2A";
            rasterVariables2.Owner = null;
            rasterVariables2.Units = DXFReaderNET.ImageUnits.Unitless;
            dxfDocument2.RasterVariables = rasterVariables2;
            dxfDocument2.ThumbnailImage = null;
            dxfDocument2.TotalEditTime = new System.DateTime(2022, 10, 13, 0, 0, 0, 0);
            dxfDocument2.TotalEditTimeDays = 0;
            dxfDocument2.UserTimer = new System.DateTime(2022, 10, 13, 0, 0, 0, 0);
            dxfDocument2.UserTimerDays = 0;
            this.dxfReaderNETControl1.DXF = dxfDocument2;
            this.dxfReaderNETControl1.FileName = null;
            this.dxfReaderNETControl1.HighlightMarkerColor2 = System.Drawing.Color.Magenta;
            this.dxfReaderNETControl1.HighlightNotContinuous = false;
            this.dxfReaderNETControl1.Location = new System.Drawing.Point(12, 12);
            this.dxfReaderNETControl1.Name = "dxfReaderNETControl1";
            this.dxfReaderNETControl1.ShowAxes = false;
            this.dxfReaderNETControl1.ShowGridRuler = false;
            this.dxfReaderNETControl1.Size = new System.Drawing.Size(647, 647);
            this.dxfReaderNETControl1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(680, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Import data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(681, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "View 3D";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(793, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "View flat";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(680, 117);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(213, 39);
            this.button4.TabIndex = 4;
            this.button4.Text = "Save DXF file...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 671);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dxfReaderNETControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DXFReader.NET - Data Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DXFReaderNET.DXFReaderNETControl dxfReaderNETControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

