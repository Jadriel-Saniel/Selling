namespace Selling.Components
{
    partial class Widget
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblCanPic = new Guna.UI2.WinForms.Guna2PictureBox();
            label2 = new Label();
            label1 = new Label();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lblCanPic).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.Controls.Add(lblCanPic);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Location = new Point(3, 3);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(301, 165);
            guna2Panel1.TabIndex = 0;
            // 
            // lblCanPic
            // 
            lblCanPic.CustomizableEdges = customizableEdges1;
            lblCanPic.Image = Properties.Resources.Mega_Corned_Sardines_TSC_155g;
            lblCanPic.ImageRotate = 0F;
            lblCanPic.Location = new Point(174, 3);
            lblCanPic.Name = "lblCanPic";
            lblCanPic.ShadowDecoration.CustomizableEdges = customizableEdges2;
            lblCanPic.Size = new Size(112, 143);
            lblCanPic.SizeMode = PictureBoxSizeMode.Zoom;
            lblCanPic.TabIndex = 2;
            lblCanPic.TabStop = false;
            lblCanPic.Click += lblCanPic_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 125);
            label2.Name = "label2";
            label2.Size = new Size(55, 31);
            label2.TabIndex = 1;
            label2.Text = "₱16";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(165, 57);
            label1.TabIndex = 0;
            label1.Text = "Mega Corned Sardines \r\nin Tomato Sauce Chili \r\nAdded";
            label1.Click += label1_Click;
            // 
            // Widget
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(guna2Panel1);
            Name = "Widget";
            Size = new Size(307, 171);
            Load += Widget_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lblCanPic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox lblCanPic;
        private Label label2;
        private Label label1;
    }
}
