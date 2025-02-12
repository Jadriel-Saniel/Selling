using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selling.Components
{
    public partial class Widget : UserControl
    {
        public partial class EventHandler Onselect = null;
        public Widget()
        {
            InitializeComponent();
        }

        private void Widget_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCanPic_Click(object sender, EventArgs e)
        {
           Onselect?.Invoke(this, e);
        }
    }
}
