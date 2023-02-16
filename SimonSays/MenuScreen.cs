using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            //TODO: remove this screen and start the GameScreen

            // f is the form "this" control is on 
            Form f = this.FindForm();
            f.Controls.Remove(this);

            //create instance for GameScreen
            GameScreen gs = new GameScreen();

            //centre screen
            gs.Location = new Point((f.ClientSize.Width - gs.Width) / 2, (f.ClientSize.Height - gs.Height) / 2);

            //Add and give control
            f.Controls.Add(gs);
            gs.Focus();
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            //TODO: end the application

        }
    }
}
