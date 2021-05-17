using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Sam Miller
// IT111 Section 6211
// NOTES: Make sure you click the buttons at least a few times.

namespace Miller_MerryGoRound
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            label_top.Text = "TEXT MERRY-GO-ROUND";
            int form_xloc = this.Width / 2;
            int label_offset = label_top.Width / 2;
            label_top.Left = form_xloc - ( label_offset );
            this.Text = "ASSIGNMENT 1: Sam Miller";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_topleft_Click(object sender, EventArgs e)
        {
            if (box_mid.Text.Length > 0)
            {
                box_topleft.Text = box_mid.Text;
                box_mid.Text = "";
            } else if (box_topright.Text.Length > 0) {
                box_topleft.Text = box_topright.Text;
                box_topright.Text = "";
            } else if (box_bottomleft.Text.Length > 0)
            {
                box_topleft.Text = box_bottomleft.Text;
                box_bottomleft.Text = "";
            } else if (box_bottomright.Text.Length > 0)
            {
                box_topleft.Text = box_bottomright.Text;
                box_bottomright.Text = "";
            }
            bowser_box.Left += 10;
            mario_box.Left += 10;
        }

        private void btn_topright_Click(object sender, EventArgs e)
        {
            if (box_mid.Text.Length > 0)
            {
                box_topright.Text = box_mid.Text;
                box_mid.Text = "";
            }
            else if (box_topleft.Text.Length > 0)
            {
                box_topright.Text = box_topleft.Text;
                box_topleft.Text = "";
            }
            else if (box_bottomleft.Text.Length > 0)
            {
                box_topright.Text = box_bottomleft.Text;
                box_bottomleft.Text = "";
            }
            else if (box_bottomright.Text.Length > 0)
            {
                box_topright.Text = box_bottomright.Text;
                box_bottomright.Text = "";
            }
            bowser_box.Left += 10;
            mario_box.Left += 10;
        }

        private void btn_bottomleft_Click(object sender, EventArgs e)
        {
            if (box_mid.Text.Length > 0)
            {
                box_bottomleft.Text = box_mid.Text;
                box_mid.Text = "";
            }
            else if (box_topleft.Text.Length > 0)
            {
                box_bottomleft.Text = box_topleft.Text;
                box_topleft.Text = "";
            }
            else if (box_topright.Text.Length > 0)
            {
                box_bottomleft.Text = box_topright.Text;
                box_topright.Text = "";
            }
            else if (box_bottomright.Text.Length > 0)
            {
                box_bottomleft.Text = box_bottomright.Text;
                box_bottomright.Text = "";
            }
            bowser_box.Left += 10;
            mario_box.Left += 10;
        }

        private void btn_bottomright_Click(object sender, EventArgs e)
        {
            if (box_mid.Text.Length > 0)
            {
                box_bottomright.Text = box_mid.Text;
                box_mid.Text = "";
            }
            else if (box_topleft.Text.Length > 0)
            {
                box_bottomright.Text = box_topleft.Text;
                box_topleft.Text = "";
            }
            else if (box_topright.Text.Length > 0)
            {
                box_bottomright.Text = box_topright.Text;
                box_topright.Text = "";
            }
            else if (box_bottomleft.Text.Length > 0)
            {
                box_bottomright.Text = box_bottomleft.Text;
                box_bottomleft.Text = "";
            }
            bowser_box.Left += 10;
            mario_box.Left += 10;
        }
    }
}
