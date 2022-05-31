using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractals
{
    public partial class Fractals : Form
    {
        /// <summary>
        /// Determines wether the fractal should be drawn or not
        /// </summary>
        bool drawFractal = false;
        /// <summary>
        /// Starting point of the fractal
        /// </summary>
        Point zero = new Point(0, 0);
        public Fractals()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Initiates whenever the user resizes the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_ResizeEnd(object sender, EventArgs e)
        {
            //Changing the size of the panel to fit the window
            if (WindowState != FormWindowState.Minimized)
            {
                DrawFractal();
            }
        }
        /// <summary>
        /// Initiates the moment the user opens the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //Setting some variables to their needed value
            //I found changing the values in the [Design] window to be uncomfortable, so instead I used code to change the values
            endColor.BackColor = Color.White;
            endColor.ForeColor = Color.Black;
            MinimumSize = new Size(500, 550);
        }
        /// <summary>
        /// Initiates when the user presses the start/stop drawing button
        /// The button turns the rendering of the fractal on or off
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartStop_Click(object sender, EventArgs e)
        {
            drawFractal = !drawFractal;
            DrawFractal();
            if (drawFractal)
            {
                drawButton.Text = "Stop drawing";
            }
            else
            {
                drawButton.Text = "Start drawing";
            }
        }
        /// <summary>
        /// Draws a step of the tree fractal
        /// </summary>
        /// <param name="start">Starting point</param>
        /// <param name="step">Current step of the fractal</param>
        /// <param name="maxstep">Total amount of steps</param>
        /// <param name="left">Determines wether the current step is leaning left or rigth</param>
        /// <param name="angle">The turning angle of each step (default 45°)</param>
        /// <param name="map">The bitmap that we are drawing in</param>
        private void DrawTreeStep(Point start, int step, int maxstep, bool left, double angle, Bitmap map)
        {
            int r = startColor.BackColor.R, g = startColor.BackColor.G, b = startColor.BackColor.B;
            if (maxstep != 0)
            {
                // These steps make the gradient effect happen
                r -= (r - endColor.BackColor.R) * step / maxstep;
                g -= (g - endColor.BackColor.G) * step / maxstep;
                b -= (b - endColor.BackColor.B) * step / maxstep;
            }
            if (left)
            {
                angle += Math.PI / 4 + Math.PI * ((double)LeftAngle.Value / 25);
            }
            else
            {
                angle -= Math.PI / 4 - Math.PI * ((double)RightAngle.Value / 25);
            }
            Point end = DrawLine(start, step, angle, map, r, g, b);
            if (step < maxstep)
            {
                DrawTreeStep(end, step + 1, maxstep, true, angle, map);
                DrawTreeStep(end, step + 1, maxstep, false, angle, map);
            }
        }
        /// <summary>
        /// Draws a single line needed for the tree fractal
        /// </summary>
        /// <param name="start">Starting point of the line</param>
        /// <param name="step">Current step of the fractal</param>
        /// <param name="angle">Angle at which the line should be drawn</param>
        /// <param name="map">The bitmap used</param>
        /// <param name="r">How red the line is</param>
        /// <param name="g">How green the line is</param>
        /// <param name="b">How blue the line is</param>
        /// <returns></returns>
        private Point DrawLine(Point start, int step, double angle, Bitmap map, int r, int g, int b)
        {
            // The length depends on the size of the window
            double len =  Math.Min((double)Width / 960, (double)Height / 540) * (double)zoom.Value / Math.Pow(2.65 - ((double)length.Value / 100), step);
            Point end = new Point((int)(start.X - Math.Cos(angle) * len), (int)(start.Y - Math.Sin(angle) * len));
            Graphics gr = Graphics.FromImage(map);
            Pen pen = new Pen(Color.FromArgb(255, r, g, b), PenWidth.Value);
            gr.DrawLine(pen, start, end);

            return end;
        }
        /// <summary>
        /// Draws the Koch's line fractal
        /// </summary>
        /// <param name="start">Staring point</param>
        /// <param name="len">Length between the starting point and the ending point of the whole fractal</param>
        /// <param name="step">Currect step of the fractal</param>
        /// <param name="maxstep">Total amount of steps</param>
        /// <param name="map">The bitmap used</param>
        /// <param name="angle">Angle at which the fractal should be drawn</param>
        /// <returns>The point ending point</returns>
        private Point DrawKoch(Point start, double len, int step, int maxstep, Bitmap map, double angle)
        {
            length.Value = 150;
            zero.Y = panel1.Height / 2 - vScrollBar1.Value;
            zero.X = panel1.Width / 2 - hScrollBar1.Value;
            hScrollBar1.Maximum = zoom.Value * length.Value / 100;
            vScrollBar1.Maximum = zoom.Value * length.Value / 100;
            hScrollBar1.Minimum = -zoom.Value * length.Value / 100;
            vScrollBar1.Minimum = -zoom.Value * length.Value / 100;
            zoom.Minimum = 250;
            zoom.Maximum = (int)(500 * Math.Pow(3, (maxstep)));
            return DrawKochStep(start, len, step, maxstep, map, angle);
        }
        /// <summary>
        /// Draws a single step of the Koch's line fractal
        /// </summary>
        /// <param name="start">Starting point</param>
        /// <param name="len">Length of step</param>
        /// <param name="step">Current step</param>
        /// <param name="maxstep">Total amount of steps</param>
        /// <param name="map">The used bitmap</param>
        /// <param name="angle">The angle at which the step should be drawn</param>
        /// <returns></returns>
        private Point DrawKochStep(Point start, double len, int step, int maxstep, Bitmap map, double angle)
        {
            int r = startColor.BackColor.R, g = startColor.BackColor.G, b = startColor.BackColor.B;
            Point end;
            if (maxstep == -1)
            {
                end = zero;
                end.X += (int)len;
                Graphics gr = Graphics.FromImage(map);
                Pen pen = new Pen(Color.FromArgb(255, r, g, b), PenWidth.Value);
                gr.DrawLine(pen, start, end);
                return end;
            }
            if (step == maxstep)
            {
                return DrawKochLines(ref start, len, map, angle, r, g, b, out end);
            }
            else
            {
                end = DrawKochStep(start, len, step + 1, maxstep, map, angle);
                end = DrawKochStep(end, len, step + 1, maxstep, map, angle - Math.PI / 3);
                end = DrawKochStep(end, len, step + 1, maxstep, map, angle + Math.PI / 3);
                return DrawKochStep(end, len, step + 1, maxstep, map, angle);
            }
        }

        /// <summary>
        /// Draws the smallest step of the Koch's line fractal
        /// </summary>
        /// <param name="start">Starting point</param>
        /// <param name="len">Length of each step</param>
        /// <param name="map">The bitmap used</param>
        /// <param name="angle">The angle at which it should be drawn</param>
        /// <param name="r">How red the step is</param>
        /// <param name="g">How green the step is</param>
        /// <param name="b">How blue the step is</param>
        /// <param name="end">Enging point</param>
        /// <returns>Ending point</returns>
        private Point DrawKochLines(ref Point start, double len, Bitmap map, double angle, int r, int g, int b, out Point end)
        {
            end = new Point((int)(start.X - Math.Cos(angle) * len), (int)(start.Y - Math.Sin(angle) * len));
            Graphics gr = Graphics.FromImage(map);
            Pen pen = new Pen(Color.FromArgb(255, r, g, b), PenWidth.Value);
            gr.DrawLine(pen, start, end);
            start = end;
            end.X -= (int)(Math.Cos(angle - Math.PI / 3) * len);
            end.Y -= (int)(Math.Sin(angle - Math.PI / 3) * len);
            gr.DrawLine(pen, start, end);
            start = end;
            end.X -= (int)(Math.Cos(angle + Math.PI / 3) * len);
            end.Y -= (int)(Math.Sin(angle + Math.PI / 3) * len);
            gr.DrawLine(pen, start, end);
            start = end;
            end.X -= (int)(Math.Cos(angle) * len);
            end.Y -= (int)(Math.Sin(angle) * len);
            gr.DrawLine(pen, start, end);
            return end;
        }
        /// <summary>
        /// Draws the carpet fractal
        /// </summary>
        /// <param name="start">Starting point</param>
        /// <param name="len">Size of the carpet</param>
        /// <param name="step">Currect step of the fractal</param>
        /// <param name="maxstep">Total amount of steps</param>
        /// <param name="map">The bitmap used</param>
        private void DrawCarpet(Point start, double len, int step, int maxstep, Bitmap map)
        {
            length.Value = 150;
            zero.Y = length.Value * 3 - vScrollBar1.Value;
            zero.X = length.Value * 3 - hScrollBar1.Value;
            hScrollBar1.Maximum = zoom.Value * length.Value / 50;
            vScrollBar1.Maximum = zoom.Value * length.Value / 50;
            hScrollBar1.Minimum = -zoom.Value * length.Value / 50;
            vScrollBar1.Minimum = -zoom.Value * length.Value / 50;
            zoom.Maximum = (int)(500 * Math.Pow(3, (maxstep)));
            DrawCarpetStep(start, len, step, maxstep, map);
        }
        /// <summary>
        /// Draws a single step of the carper fractal
        /// </summary>
        /// <param name="start">Starting point</param>
        /// <param name="len">Lenght of each step</param>
        /// <param name="step">Current step</param>
        /// <param name="maxstep">Total amount of steps</param>
        /// <param name="map">The used bitmap</param>
        private void DrawCarpetStep(Point start, double len, int step, int maxstep, Bitmap map)
        {
            if (step == 0)
            {
                Graphics gr = Graphics.FromImage(map);
                Pen pen = new Pen(startColor.BackColor, PenWidth.Value);
                Rectangle rect = new Rectangle(start, new Size((int)len, (int)len));
                gr.FillRectangle(pen.Brush, rect);
                if (step < maxstep)
                {
                    DrawCarpetStep(start, len / 3, step + 1, maxstep, map);
                }
            }
            else
            {
                start.X += (int)(len);
                start.Y += (int)(len);
                Graphics gr = Graphics.FromImage(map);
                Pen pen = new Pen(endColor.BackColor, PenWidth.Value);
                Rectangle rect = new Rectangle(start, new Size((int)len, (int)len));
                gr.FillRectangle(pen.Brush, rect);
                if (step < maxstep)
                {
                    DrawCarpetSquares(start, len, step, maxstep, map);
                }
            }
        }

        /// <summary>
        /// Draws a single the squares of the smallest step of the carpet fractal
        /// </summary>
        /// <param name="start">Starting point</param>
        /// <param name="len">Size of the step</param>
        /// <param name="step">Current step</param>
        /// <param name="maxstep">Total amount of steps</param>
        /// <param name="map">The bitmap used</param>
        private void DrawCarpetSquares(Point start, double len, int step, int maxstep, Bitmap map)
        {
            start.X -= (int)(len);
            start.Y -= (int)(len);
            DrawCarpet(start, len / 3, step + 1, maxstep, map);
            start.X += (int)(len);
            DrawCarpet(start, len / 3, step + 1, maxstep, map);
            start.X += (int)(len);
            DrawCarpet(start, len / 3, step + 1, maxstep, map);
            start.Y += (int)(len);
            DrawCarpet(start, len / 3, step + 1, maxstep, map);
            start.Y += (int)(len);
            DrawCarpet(start, len / 3, step + 1, maxstep, map);
            start.X -= (int)(len);
            DrawCarpet(start, len / 3, step + 1, maxstep, map);
            start.Y -= (int)(len);
            DrawCarpet(start, len / 3, step + 1, maxstep, map);
            start.X -= (int)(len);
            DrawCarpet(start, len / 3, step + 1, maxstep, map);
            start.Y += (int)(len);
            DrawCarpet(start, len / 3, step + 1, maxstep, map);
        }
        /// <summary>
        /// Draws the triangle fractal
        /// </summary>
        /// <param name="start">Starting point</param>
        /// <param name="len">Length of the side of the triangle</param>
        /// <param name="step">Current step of the fractal</param>
        /// <param name="maxstep">Total amount of steps</param>
        /// <param name="map">The used bitmap</param>
        private void DrawTriangleSerp(Point start, double len, int step, int maxstep, Bitmap map)
        {
            length.Value = 150;
            zero.Y = length.Value * 3 - vScrollBar1.Value;
            zero.X = length.Value * 3 - hScrollBar1.Value;
            hScrollBar1.Maximum = zoom.Value * length.Value / 150;
            vScrollBar1.Maximum = zoom.Value * length.Value / 150;
            hScrollBar1.Minimum = -zoom.Value * length.Value / 150;
            vScrollBar1.Minimum = -zoom.Value * length.Value / 150;
            zoom.Maximum = (int)(500 * Math.Pow(2, (maxstep)));
            Graphics gr = Graphics.FromImage(map);
            int r = startColor.BackColor.R, g = startColor.BackColor.G, b = startColor.BackColor.B;
            if (maxstep != 0)
            {
                r -= (r - endColor.BackColor.R) * step / maxstep;
                g -= (g - endColor.BackColor.G) * step / maxstep;
                b -= (b - endColor.BackColor.B) * step / maxstep;
            }
            Pen pen = new Pen(Color.FromArgb(255, r, g, b), PenWidth.Value);
            if (step == 0)
            {
                DrawUpsideTriangle(start, len, gr, pen);
                if (step < maxstep)
                {
                    len /= 2;
                    DrawTriangleSerp(start, len * 2, step + 1, maxstep, map);
                }
            }
            else
            {
                len /= 2;
                DrawTriangle(new Point(start.X + (int)(len / 2), start.Y - (int)(Math.Sqrt(3) * len / 2)), len, pen, gr);
                if (step < maxstep)
                {
                    DrawTriangleSerp(new Point(start.X + (int)(len / 2), start.Y - (int)(Math.Sqrt(3) * len / 2)), len, step + 1, maxstep, map);
                    DrawTriangleSerp(new Point(start.X, start.Y), len, step + 1, maxstep, map);
                    DrawTriangleSerp(new Point(start.X + (int)len, start.Y), len, step + 1, maxstep, map);
                }
            }
        }
        /// <summary>
        /// Draws an upside down triangle
        /// </summary>
        /// <param name="start">Starting point</param>
        /// <param name="len">Length of the side of the triangle</param>
        /// <param name="gr">The used graphics</param>
        /// <param name="pen">The used pen</param>
        /// <returns>Ending point</returns>
        private static void DrawUpsideTriangle(Point start, double len, Graphics gr, Pen pen)
        {
            gr.DrawLine(pen, start, new Point(start.X + (int)len, start.Y));
            gr.DrawLine(pen, start, new Point(start.X + (int)(len / 2), start.Y - (int)(Math.Sqrt(3) * len / 2)));
            gr.DrawLine(pen, new Point(start.X + (int)(len / 2), start.Y - (int)(Math.Sqrt(3) * len / 2)), new Point(start.X + (int)(len), start.Y));
        }
        /// <summary>
        /// Draws a triangle
        /// </summary>
        /// <param name="start">Starting point</param>
        /// <param name="len"></param>
        /// <param name="pen"></param>
        /// <param name="gr"></param>
        private void DrawTriangle(Point start, double len, Pen pen, Graphics gr)
        {
            gr.DrawLine(pen, start, new Point(start.X + (int)len, start.Y));
            gr.DrawLine(pen, start, new Point(start.X + (int)(len / 2), start.Y + (int)(Math.Sqrt(3) * len / 2)));
            gr.DrawLine(pen, new Point(start.X + (int)(len / 2), start.Y + (int)(Math.Sqrt(3) * len / 2)), new Point(start.X + (int)(len), start.Y));

        }
        private void DrawKantor(Point start, double len, int step, int maxstep, Bitmap map)
        {
            hScrollBar1.Maximum = zoom.Value * length.Value / 150;
            vScrollBar1.Maximum = zoom.Value * length.Value / 150;
            hScrollBar1.Minimum = -zoom.Value * length.Value / 150;
            vScrollBar1.Minimum = -zoom.Value * length.Value / 150;
            zoom.Maximum = 1000;
            Graphics gr = Graphics.FromImage(map);
            int stepLen = zoom.Value * (LeftAngle.Value + 26) / 25;
            int r = startColor.BackColor.R, g = startColor.BackColor.G, b = startColor.BackColor.B;
            r -= (r - endColor.BackColor.R) * step / (maxstep + 1);
            g -= (g - endColor.BackColor.G) * step / (maxstep + 1);
            b -= (b - endColor.BackColor.B) * step / (maxstep + 1);
            Pen pen = new Pen(Color.FromArgb(255, r, g, b), PenWidth.Value);
            if (step == 0)
            {
                gr.DrawLine(pen, start, new Point(start.X + (int)len, start.Y));
                if (step < maxstep)
                {
                    DrawKantor(new Point(start.X, start.Y + stepLen), len / 3, step + 1, maxstep, map);
                    DrawKantor(new Point(start.X + (int)(len * 2 / 3), start.Y + stepLen), len / 3, step + 1, maxstep, map);
                }
            }
            else
            {
                gr.DrawLine(pen, start, new Point(start.X + (int)len, start.Y));
                if (step < maxstep)
                {
                    DrawKantor(new Point(start.X, start.Y + stepLen), len / 3, step + 1, maxstep, map);
                    DrawKantor(new Point(start.X + (int)(len * 2 / 3), start.Y + stepLen), len / 3, step + 1, maxstep, map);
                }
            }
        }
        /// <summary>
        /// Initiates when user changes any of the values and redraws the fractal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountOfSteps_Change(object sender, EventArgs e)
        {
            DrawFractal();
        }
        /// <summary>
        /// Draws the chosen fractal
        /// </summary>
        private void DrawFractal()
        {
            if (drawFractal)
            {
                Bitmap map = new Bitmap(panel1.Size.Width, panel1.Size.Height);
                int len;
                switch (fractal.SelectedIndex)
                {
                    case (0):
                        DrawPythTree(map);
                        break;
                    case (1):
                        if (countOfSteps.Value > 13)
                        {
                            countOfSteps.Value = 13;
                        }
                        len = (int)(Math.Min((double)Width / 960, (double)Height / 540) * length.Value * zoom.Value / 100 / Math.Pow(3, (double)(countOfSteps.Value)));
                        DrawKoch(zero, len, 0, (int)(countOfSteps.Value) - 1, map, Math.PI);
                        break;
                    case (2):
                        if (countOfSteps.Value > 5)
                        {
                            countOfSteps.Value = 5;
                        }
                        zero.Y = panel1.Height / 2 - vScrollBar1.Value;
                        zero.X = panel1.Width / 2 - hScrollBar1.Value;
                        len = (int)(Math.Min((double)Width / 960, (double)Height / 540) * zoom.Value);
                        DrawCarpet(zero, len, 0, (int)(countOfSteps.Value), map);
                        break;
                    case (3):
                        if (countOfSteps.Value > 8)
                        {
                            countOfSteps.Value = 8;
                        }
                        zero.Y = panel1.Height / 2 - vScrollBar1.Value;
                        zero.X = panel1.Width / 2 - hScrollBar1.Value;
                        len = (int)(Math.Min((double)Width / 960, (double)Height / 540) * zoom.Value);
                        DrawTriangleSerp(zero, len, 0, (int)(countOfSteps.Value), map);
                        break;
                    case (4):
                        if (countOfSteps.Value > 6)
                        {
                            countOfSteps.Value = 6;
                        }
                        zero.Y = panel1.Height / 2 - vScrollBar1.Value;
                        zero.X = panel1.Width / 2 - hScrollBar1.Value;
                        len = (int)(Math.Min((double)Width / 960, (double)Height / 540) * zoom.Value * length.Value / 100);
                        DrawKantor(zero, len, 0, (int)(countOfSteps.Value), map);
                        break;
                }
                pictureBox1.Size = map.Size;
                pictureBox1.Image = map; 
            }
        }
        /// <summary>
        /// Draws the tree fractal
        /// </summary>
        /// <param name="map">The used bitmap</param>
        private void DrawPythTree(Bitmap map)
        {
            if (countOfSteps.Value > 13)
            {
                countOfSteps.Value = 13;
            }
            zero.Y = panel1.Height / 2 - vScrollBar1.Value;
            zero.X = panel1.Width / 2 - hScrollBar1.Value;
            hScrollBar1.Maximum = zoom.Value * length.Value / 25;
            vScrollBar1.Maximum = zoom.Value * length.Value / 25;
            hScrollBar1.Minimum = -zoom.Value * length.Value / 25;
            vScrollBar1.Minimum = -zoom.Value * length.Value / 25;
            zoom.Minimum = 100 / length.Value;
            zoom.Maximum = 1000;
            DrawTreeStep(zero, 0, (int)countOfSteps.Value, true, Math.PI / 4, map);
        }
        /// <summary>
        /// Initiates when the user changes the left angle of the fractal and redraws it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LeftAngle_Scroll(object sender, EventArgs e)
        {
            DrawFractal();
        }
        /// <summary>
        /// Initiates when the user zooms in on the fractal and redraws it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zoom_Scroll(object sender, EventArgs e)
        {
            DrawFractal();
        }
        /// <summary>
        /// Initiates when the user scrolls through the fractal and redraws it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            DrawFractal();
        }
        /// <summary>
        /// Initiates when the user scrolls through the fractal and redraws it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            DrawFractal();
        }
        /// <summary>
        /// Initiates when the user changes the length of the fractal and redraws it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void length_Scroll(object sender, EventArgs e)
        {
            DrawFractal();
        }
        /// <summary>
        /// Initiates when the user changes the right angle of the fractal and redraws it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RightAngle_Scroll(object sender, EventArgs e)
        {
            DrawFractal();
        }
        /// <summary>
        /// Initiates when the user clicks the start color button, lets him choose a color and redraws the fractal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            startColor.BackColor = colorDialog1.Color;
            int r = 255 - colorDialog1.Color.R;
            int g = 255 - colorDialog1.Color.G;
            int b = 255 - colorDialog1.Color.B;
            startColor.ForeColor = Color.FromArgb(255, r, g, b);
            DrawFractal();
        }
        /// <summary>
        /// Initiates when the user clicks the end color button, lets him choose a color and redraws the fractal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void endcolor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            endColor.BackColor = colorDialog1.Color;
            int r = 255 - colorDialog1.Color.R;
            int g = 255 - colorDialog1.Color.G;
            int b = 255 - colorDialog1.Color.B;
            endColor.ForeColor = Color.FromArgb(255, r, g, b);
            DrawFractal();
        }
        /// <summary>
        /// Initiates when the user changes the selected fractal makes the needed elements visible and redraws the fractal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fractal.SelectedIndex != -1)
            {
                currentFractal.Text = fractal.SelectedItem.ToString();
            }
            if (fractal.SelectedIndex == 0)
            {
                LeftAngle.Value = 0;
                RightAngle.Value = 0;
                label1.Visible = true;
                label4.Visible = true;
                LeftAngle.Visible = true;
                RightAngle.Visible = true;
                label3.Visible = true;
                length.Visible = true;
                spaceLable.Visible = false;
            }
            else if (fractal.SelectedIndex == 4)
            {
                LeftAngle.Value = -20;
                label1.Visible = false;
                label4.Visible = false;
                label3.Visible = true;
                length.Visible = true;
                LeftAngle.Visible = true;
                RightAngle.Visible = false;
                spaceLable.Visible = true;
            }
            else
            {
                label1.Visible = false;
                label4.Visible = false;
                label3.Visible = false;
                length.Visible = false;
                LeftAngle.Visible = false;
                RightAngle.Visible = false;
                spaceLable.Visible = false;
            }
            if (fractal.SelectedIndex == 3)
            {
                endColor.BackColor = startColor.BackColor;
                int r = 255 - endColor.BackColor.R;
                int g = 255 - endColor.BackColor.G;
                int b = 255 - endColor.BackColor.B;
                endColor.ForeColor = Color.FromArgb(255, r, g, b);
            }
            if (fractal.SelectedIndex == 2)
            {

                endColor.BackColor = panel1.BackColor;
                int r = 255 - endColor.BackColor.R;
                int g = 255 - endColor.BackColor.G;
                int b = 255 - endColor.BackColor.B;
                endColor.ForeColor = Color.FromArgb(255, r, g, b);
            }
            DrawFractal();
        }
        /// <summary>
        /// Initiates when the user clicks the background color button, lets him choose a color and redraws the fractal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundcolor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            backgroundcolor.BackColor = colorDialog1.Color;
            panel1.BackColor = colorDialog1.Color;
            int r = 255 - colorDialog1.Color.R;
            int g = 255 - colorDialog1.Color.G;
            int b = 255 - colorDialog1.Color.B;
            backgroundcolor.ForeColor = Color.FromArgb(255, r, g, b);
        }
        /// <summary>
        /// Initiates when the user clicks the save button and saves the fractal in the folder of the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void save_Click(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                ErrorPopUp errorPopUp = new ErrorPopUp("Please write a name of the file");
                errorPopUp.Show(this);
            }
            else
            {
                if (format.SelectedIndex == -1)
                {
                    ErrorPopUp errorPopUp = new ErrorPopUp("Please select a format first");
                    errorPopUp.Show(this);
                }
                else
                {
                    Bitmap map = new Bitmap(panel1.Size.Width, panel1.Size.Height);
                    int len;
                    if (fractal.SelectedIndex == -1)
                    {
                        ErrorPopUp errorPopUp = new ErrorPopUp("Please select a fractal type first");
                        errorPopUp.Show(this);
                    }
                    if (fractal.SelectedIndex == 0)
                    {
                        DrawPythTree(map);
                    }
                    if (fractal.SelectedIndex == 1)
                    {
                        len = (int)(Math.Max((double)Width / 960, (double)Height / 540) * length.Value * zoom.Value / 100 / Math.Pow(3, (double)(countOfSteps.Value)));
                        DrawKoch(zero, len, 0, (int)(countOfSteps.Value) - 1, map, Math.PI);
                    }
                    if (fractal.SelectedIndex == 2)
                    {
                        zero.Y = panel1.Height / 2 - vScrollBar1.Value;
                        zero.X = panel1.Width / 2 - hScrollBar1.Value;
                        len = (int)(Math.Min((double)Width / 960, (double)Height / 540) * zoom.Value);
                        DrawCarpet(zero, len, 0, (int)(countOfSteps.Value), map);
                    }
                    if (fractal.SelectedIndex == 3)
                    {
                        zero.Y = panel1.Height / 2 - vScrollBar1.Value;
                        zero.X = panel1.Width / 2 - hScrollBar1.Value;
                        len = (int)(Math.Min((double)Width / 960, (double)Height / 540) * zoom.Value);
                        DrawTriangleSerp(zero, len, 0, (int)(countOfSteps.Value), map);
                    }
                    if (fractal.SelectedIndex == 4)
                    {
                        zero.Y = panel1.Height / 2 - vScrollBar1.Value;
                        zero.X = panel1.Width / 2 - hScrollBar1.Value;
                        len = (int)(Math.Min((double)Width / 960, (double)Height / 540) * zoom.Value * length.Value / 100);
                        DrawKantor(zero, len, 0, (int)(countOfSteps.Value), map);
                    }
                    if (fractal.SelectedIndex != -1)
                    {
                        folderBrowserDialog1.ShowDialog();
                        if (folderBrowserDialog1.SelectedPath != "")
                        {
                            try
                            {
                                map.Save(folderBrowserDialog1.SelectedPath + Path.DirectorySeparatorChar + name.Text + format.SelectedItem);
                            }
                            catch (Exception)
                            {
                                ErrorPopUp SaveFail = new ErrorPopUp("Chosen path or name of file is not allowed");
                                SaveFail.Show();
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Initiates when the user changes the pen width and redraws the fractal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PenWidth_Sroll(object sender, EventArgs e)
        {
            DrawFractal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Help().Show();
        }
    }
}
