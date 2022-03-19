using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.XemLich
{
    public partial class uctDays : UserControl
    {
        public uctDays()
        {
            InitializeComponent();
        }

        private void uctDays_Load(object sender, EventArgs e)
        {
            
        }
        public void Days( int numday )
        {
            lbDays.Text = numday+"";
        }
    }
}
