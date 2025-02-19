using Selling.Components;
using System.ComponentModel;
using static Selling.Components.Widget;

namespace Selling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)
        {

        }


        private void widget7_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            /* docker.WindowState = Docker.WindowState.Maximized; */
        }

        // AddItem method
        private void AddItem(string name, double cost, categories _category, Image icon)
        {
            var w = new Widget()
            {
                Title = name,
                Cost = cost,
                Category = _category,
                Icon = icon

            };
            pnl.Controls.Add(w);
            w.Onselect += (ss, ee) =>
            {
                var wdg = (Widget)ss;
                foreach (DataGridViewRow item in grid.Rows)
                {
                    if (item.Cells[0].Value.ToString() == wdg.Title)
                    {
                        item.Cells[1].Value = (int.Parse(item.Cells[1].Value.ToString()) + 1);
                        item.Cells[2].Value = (int.Parse(item.Cells[2].Value.ToString())
                        * double.Parse(wdg.label2.Text.Replace("₱", " "))).ToString("C2");
                        CalculateTotal();
                        return;
                    }
                }
                grid.Rows.Add(new object[] { wdg.label1.Text, 1, wdg.label2.Text });
                CalculateTotal();
            };

        }

        void CalculateTotal()
        {
            double tot = 0;
            foreach (DataGridViewRow item in grid.Rows)
            {
                tot += double.Parse(item.Cells[2].Value.ToString().Replace("₱", " "));
            }
            txtTotal.Text = tot.ToString("C2");
        }


        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void Form1_Shown(object sender, EventArgs e)
        {

            // connect to database


            //drinks
            AddItem("Coca Cola", 30, categories.Drinks, Properties.Resources.canned_food);
            AddItem("Sprite", 20, categories.Drinks, Properties.Resources.canned_food);

            //canned foods
            AddItem("Mega Corned ", 16, categories.CannedGoods, Properties.Resources.Mega_Corned_Sardines_TSC_155g);
            AddItem("century tuna", 16, categories.CannedGoods, Properties.Resources.Mega_Corned_Sardines_TSC_155g);

            //biscuits
            AddItem("Brave Biscuit", 10, categories.Biscuits, Properties.Resources.biscuit);
            AddItem("rebisco", 10, categories.Biscuits, Properties.Resources.biscuit);

        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            foreach (var item in pnl.Controls)
            {
                if (item is Components.Widget widget)
                {
                    widget.Visible = true;
                }
            }
        }

        private void txtSearchbar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchbar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || txtSearchbar.Text.Trim().Length == 0)
            {
                foreach (var item in pnl.Controls)
                {
                    var wdg = (Widget)item;
                    wdg.Visible = wdg.Title.ToLower().ToLower().Contains(txtSearchbar.Text.Trim().ToLower());
                }
            }
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            foreach (var item in pnl.Controls)
            {
                if (item is Components.Widget widget)
                {
                    if (widget.Category == categories.Drinks)
                    {
                        widget.Visible = true;
                    }
                    else
                    {
                        widget.Visible = false;
                    }
                }
            }
        }

        private void btnCanned_Click(object sender, EventArgs e)
        {
            foreach (var item in pnl.Controls)
            {
                if (item is Components.Widget widget)
                {
                    if (widget.Category == categories.CannedGoods)
                    {
                        widget.Visible = true;
                    }
                    else
                    {
                        widget.Visible = false;
                    }
                }
            }
        }

        private void BtnBiscuit_Click(object sender, EventArgs e)
        {
            foreach (var item in pnl.Controls)
            {
                if (item is Components.Widget widget)
                {
                    if (widget.Category == categories.Biscuits)
                    {
                        widget.Visible = true;
                    }
                    else
                    {
                        widget.Visible = false;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grid.GridColor = grid.BackgroundColor;
            grid.BorderStyle = BorderStyle.None;

        }
    }
}
