using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fractals
{
    public partial class Help : Form
    {
        bool drawFractal = false;
        public Help()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void testStartDrawButton_Click(object sender, EventArgs e)
        {
            drawFractal = !drawFractal;
            if (drawFractal)
            {
                testStartDrawButton.Text = "Stop drawing";
            }
            else
            {
                testStartDrawButton.Text = "Start drawing";
            }
        }
    }
}
