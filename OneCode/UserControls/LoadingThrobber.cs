using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace OneCode.UserControls
{
    public partial class LoadingThrobber : UserControl
    {
        private float _progress = 1f;

        private Color _color = Color.FromArgb(0, 110, 230);
        private Color _backColorCircle = Color.FromArgb(255, 255, 255);
        private Color _borderColor = Color.DarkGray;

        private int _borderThickness = 1;

        public LoadingThrobber()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
        }

        public void SetProgress(double value)
        {
            _progress = (float)Math.Max(0, Math.Min(1, value));
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int size = Math.Min(Width, Height);
            Rectangle rect = new Rectangle(0, 0, size - 1, size - 1);

            using (SolidBrush backBrush = new SolidBrush(_backColorCircle))
                g.FillEllipse(backBrush, rect);
            using (SolidBrush brush = new SolidBrush(_color))
            {
                float sweepAngle = 360f * _progress;
                g.FillPie(brush, rect, -90f, sweepAngle);
            }
            using (Pen pen = new Pen(_borderColor, _borderThickness))
            {
                pen.Alignment = PenAlignment.Inset;
                g.DrawEllipse(pen, rect);
            }
        }
    }
}