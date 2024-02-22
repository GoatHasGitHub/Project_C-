using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Project_C_
{
	public partial class Form1 : Form
	{
		private List<Rectangle> rectangles = new List<Rectangle>();

		public Form1()
		{
			InitializeComponent();
			this.MouseDown += Form1_MouseDown;
			this.MouseMove += Form1_MouseMove;
			this.MouseUp += Form1_MouseUp;
			this.Paint += Form1_Paint;
		}

		private Point startPoint;
		private Point endPoint;
		private bool drawing = false;

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				startPoint = e.Location;
				drawing = true;
			}
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if (drawing)
			{
				endPoint = e.Location;
				this.Invalidate();
			}
		}

		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				drawing = false;
				endPoint = e.Location;

				Rectangle rectangle = new Rectangle(
					Math.Min(startPoint.X, endPoint.X),
					Math.Min(startPoint.Y, endPoint.Y),
					Math.Abs(startPoint.X - endPoint.X),
					Math.Abs(startPoint.Y - endPoint.Y));

				rectangles.Add(rectangle);

				this.Invalidate();
			}
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			foreach (var rectangle in rectangles)
			{
				e.Graphics.DrawRectangle(Pens.Black, rectangle);
			}

			int totalArea = 0;
			foreach (var rect in rectangles)
			{
				totalArea += rect.Width * rect.Height;
			}

			statusLabel.Text = $"Ukupna površina: {totalArea} CM kvadratnih";
		}

		private void statusLabel_Click(object sender, EventArgs e)
		{

		}
	}
}