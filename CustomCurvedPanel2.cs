﻿using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurvedShaped
{
    public class CustomCurvedPanel2 : GroupBox
    {
        public CustomCurvedPanel2()
        {
            this.DoubleBuffered = true;
            this.TitleBackColor = Color.SteelBlue;
            this.TitleForeColor = Color.White;
            this.TitleFont = new Font(this.Font.FontFamily, Font.Size + 8, FontStyle.Bold);
            this.BackColor = Color.Transparent;
            this.borderRadius = 1;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GroupBoxRenderer.DrawParentBackground(e.Graphics, this.ClientRectangle, this);
            var rect = ClientRectangle;

            using (var path = GetCustomShape(this.ClientRectangle))
            {
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

                if (this.BackColor != Color.Transparent)
                {
                    using (var brush = new SolidBrush(BackColor))
                    {
                        e.Graphics.FillPath(brush, path);
                    }
                }

                var clip = e.Graphics.ClipBounds;
                e.Graphics.SetClip(rect);

                e.Graphics.SetClip(clip);

                using (var pen = new Pen(TitleBackColor, borderRadius))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        public Color TitleBackColor { get; set; }
        public int borderRadius { get; set; }
        public Font TitleFont { get; set; }
        public Color TitleForeColor { get; set; }

        private GraphicsPath GetCustomShape(Rectangle rect)
        {
            GraphicsPath path = new GraphicsPath();

            // Top side - straight line (rectangular)
            path.StartFigure();
            path.AddLine(rect.X, rect.Y, rect.Right, rect.Y);  // Top side

            // Left side - straight line downwards (rectangular)
            path.AddLine(rect.X, rect.Y, rect.X, rect.Bottom);  // Left side

            // Bottom side - wavy line from left to right, narrowing
            int waveHeight = rect.Height / 3; // Height of the wave
            int narrowWidth = rect.Width / 4; // Width at the narrowest point on the right

            path.AddBezier(
                new Point(rect.X, rect.Bottom - waveHeight),                        // Start at bottom-left corner
                new Point(rect.X + (rect.Width / 3), rect.Bottom - waveHeight*5),  // Control point 1
                new Point(rect.Right - narrowWidth*1, rect.Bottom + waveHeight*3), // Control point 2
                new Point(rect.Right, rect.Bottom - waveHeight*2));              // End at bottom-right, narrow

            // Right side - straight line upwards (rectangular)
            path.AddLine(rect.Right, rect.Bottom - waveHeight, rect.Right, rect.Y);  // Right side

            path.CloseFigure();
            return path;
        }

    }
}