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
        private categories _category;
        private double _cost;

        public event EventHandler Onselect = null;
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

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        public enum categories
        {
            Food,
            Drinks,
            CannedGoods,
            Biscuits
        }
        public categories Category { get => _category; set => _category = value; }

        public string Title
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public double Cost
        {
            get => _cost; set => _cost = value;
        }
        public Image Icon
        {
            get { return lblCanPic.Image; }
            set { lblCanPic.Image = value; }
        }
    }
}
