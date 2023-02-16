using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Drawing.Drawing2D;

namespace SimonSays
{
    public partial class Form1 : Form
    {
        //TODO: create a List to store the pattern. Must be accessable on other screens
        public static int numberPlays = 0;

        public Form1()
        {
            InitializeComponent();

            //creates an instance of the MenuScreen
            MenuScreen ms = new MenuScreen();

            // Centre the screen on the Form  
            ms.Location = new Point((this.ClientSize.Width - ms.Width) / 2, (this.ClientSize.Height - ms.Height) / 2);

            //Add and give focus
            this.Controls.Add(ms);
            ms.Focus();
        }
    }
}
