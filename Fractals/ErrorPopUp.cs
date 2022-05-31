using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fractals
{
    public partial class ErrorPopUp : Form
    {
        // When an ErrorPopUp item is created it is assigned a message
        // The messsage will be displayed on the PopUp menu
        public ErrorPopUp(string error)
        {
            InitializeComponent();
            ErrorType.Text = error;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
