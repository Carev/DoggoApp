using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Media;

namespace DoggoApp
{
    public partial class Doggo : Form
    {
        public Doggo()
        {
            InitializeComponent();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            try
            {            
            SoundPlayer moonTheme = new SoundPlayer(Properties.Resources._09_the_moon);
            moonTheme.Play();
            }
            catch
            {
                //these hands;
            }
            
        }
    }
}
