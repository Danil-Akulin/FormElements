using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormElements
{
    public partial class Form1 : Form
    {
        TreeView tree;
        Button btn;
        Label lbl;
        PictureBox picb;

        public Form1()
        {
            BackColor = Color.AntiqueWhite;
            this.Height= 800;
            this.Width = 900;
            this.Text = "Vorm elementidega";
            tree = new TreeView();
            tree.Dock = DockStyle.Left;
            TreeNode tn = new TreeNode("Elemendid");
            tn.Nodes.Add(new TreeNode("Nupp"));
            tn.Nodes.Add(new TreeNode("Silt-Label"));
            tn.Nodes.Add(new TreeNode("PictureBox"));

            tn.Nodes.Add(new TreeNode("Märkeruut-CheckBox"));
            tn.Nodes.Add(new TreeNode("Radionupp-Radiobutton"));
            tn.Nodes.Add(new TreeNode("Tekstkast-TextBox"));

            tn.Nodes.Add(new TreeNode("Kaart-TabControl"));
            tn.Nodes.Add(new TreeNode("MessageBox"));

            //Nupp
            tree.AfterSelect += Tree_AfterSelect;
            tree.MouseLeave += Tree_MouseLeave;
            btn = new Button();
            btn.Text = "Vajuta siia";
            btn.Location = new Point(130,30);
            btn.Height = 20;
            btn.Width = 70;
            btn.Click += Btn_Click;


            // Silt Label
            lbl = new Label();
            lbl.Text = "Elementide loomine c# abil";
            lbl.Size = new Size(400, 30);
            lbl.Location = new Point(150,0);
            lbl.MouseHover += Lbl_MouseHover;
            lbl.MouseLeave += Lbl_MouseLeave;


            // PictureBox
            picb = new PictureBox();
            //picb.Text = "PictureBox on siin";
            picb.Size = new Size(50, 50);
            picb.Location = new Point(150, 0);
            picb.SizeMode = PictureBoxSizeMode.StretchImage;
            picb.Image = Image.FromFile(@"..\..\hoi.png");


            //Double_Click --> carusel 3 - 4 images 1-2-3-4
            picb.DoubleClick += Picb_DoubleClick;

            picb = new PictureBox();
            picb.Size = new Size(50, 50);
            picb.Location = new Point(150, 0);
            picb.SizeMode = PictureBoxSizeMode.StretchImage;
            picb.Image = Image.FromFile(@"..\..\Hoi.png");





            //footer
            tree.Nodes.Add(tn);
            this.Controls.Add(tree);

            
        }

        private void Picb_DoubleClick(object sender, EventArgs e)
        {
            int i = 0;
            while (i!=999)
            {
                i++;
                picb.Image = Image.FromFile(@"..\..\Hoi2.png");
                picb.Image = Image.FromFile(@"..\..\Hoi3.png");
            }
            //picb.Image = Image.FromFile(@"..\..\Hoi2.png");
            //picb.Image = Image.FromFile(@"..\..\Hoi3.png");
        }

        private void Tree_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void Lbl_MouseLeave(object sender, EventArgs e)
        {
            lbl.BackColor = Color.AntiqueWhite;
        }

        private void Lbl_MouseHover(object sender, EventArgs e)
        {
            lbl.BackColor = Color.FromArgb(88, 88, 74);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            BackColor = Color.Aquamarine;
        }

        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text=="Nupp")
            {
                this.Controls.Add(btn);
            }
            else if (e.Node.Text=="Silt")
            {
                this.Controls.Add(lbl);
            }
            else if (e.Node.Text== "Picture")
            {
                this.Controls.Add(picb);
            }

        }

    }
}
