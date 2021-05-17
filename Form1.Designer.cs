
namespace Miller_MerryGoRound
{
    partial class main_form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.box_mid = new System.Windows.Forms.TextBox();
            this.box_topleft = new System.Windows.Forms.TextBox();
            this.box_topright = new System.Windows.Forms.TextBox();
            this.box_bottomleft = new System.Windows.Forms.TextBox();
            this.box_bottomright = new System.Windows.Forms.TextBox();
            this.btn_topleft = new System.Windows.Forms.Button();
            this.btn_topright = new System.Windows.Forms.Button();
            this.btn_bottomleft = new System.Windows.Forms.Button();
            this.btn_bottomright = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label_top = new System.Windows.Forms.Label();
            this.bowser_box = new System.Windows.Forms.Panel();
            this.mario_box = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // box_mid
            // 
            this.box_mid.Location = new System.Drawing.Point(324, 201);
            this.box_mid.Name = "box_mid";
            this.box_mid.Size = new System.Drawing.Size(140, 20);
            this.box_mid.TabIndex = 0;
            // 
            // box_topleft
            // 
            this.box_topleft.Location = new System.Drawing.Point(191, 130);
            this.box_topleft.Name = "box_topleft";
            this.box_topleft.Size = new System.Drawing.Size(100, 20);
            this.box_topleft.TabIndex = 1;
            // 
            // box_topright
            // 
            this.box_topright.Location = new System.Drawing.Point(497, 130);
            this.box_topright.Name = "box_topright";
            this.box_topright.Size = new System.Drawing.Size(100, 20);
            this.box_topright.TabIndex = 2;
            // 
            // box_bottomleft
            // 
            this.box_bottomleft.Location = new System.Drawing.Point(191, 257);
            this.box_bottomleft.Name = "box_bottomleft";
            this.box_bottomleft.Size = new System.Drawing.Size(100, 20);
            this.box_bottomleft.TabIndex = 3;
            // 
            // box_bottomright
            // 
            this.box_bottomright.Location = new System.Drawing.Point(497, 257);
            this.box_bottomright.Name = "box_bottomright";
            this.box_bottomright.Size = new System.Drawing.Size(100, 20);
            this.box_bottomright.TabIndex = 4;
            // 
            // btn_topleft
            // 
            this.btn_topleft.Location = new System.Drawing.Point(203, 171);
            this.btn_topleft.Name = "btn_topleft";
            this.btn_topleft.Size = new System.Drawing.Size(75, 23);
            this.btn_topleft.TabIndex = 5;
            this.btn_topleft.Text = "1";
            this.btn_topleft.UseVisualStyleBackColor = true;
            this.btn_topleft.Click += new System.EventHandler(this.btn_topleft_Click);
            // 
            // btn_topright
            // 
            this.btn_topright.Location = new System.Drawing.Point(510, 171);
            this.btn_topright.Name = "btn_topright";
            this.btn_topright.Size = new System.Drawing.Size(75, 23);
            this.btn_topright.TabIndex = 6;
            this.btn_topright.Text = "2";
            this.btn_topright.UseVisualStyleBackColor = true;
            this.btn_topright.Click += new System.EventHandler(this.btn_topright_Click);
            // 
            // btn_bottomleft
            // 
            this.btn_bottomleft.Location = new System.Drawing.Point(203, 300);
            this.btn_bottomleft.Name = "btn_bottomleft";
            this.btn_bottomleft.Size = new System.Drawing.Size(75, 23);
            this.btn_bottomleft.TabIndex = 7;
            this.btn_bottomleft.Text = "3";
            this.btn_bottomleft.UseVisualStyleBackColor = true;
            this.btn_bottomleft.Click += new System.EventHandler(this.btn_bottomleft_Click);
            // 
            // btn_bottomright
            // 
            this.btn_bottomright.Location = new System.Drawing.Point(510, 300);
            this.btn_bottomright.Name = "btn_bottomright";
            this.btn_bottomright.Size = new System.Drawing.Size(75, 23);
            this.btn_bottomright.TabIndex = 8;
            this.btn_bottomright.Text = "4";
            this.btn_bottomright.UseVisualStyleBackColor = true;
            this.btn_bottomright.Click += new System.EventHandler(this.btn_bottomright_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(681, 409);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label_top
            // 
            this.label_top.AutoSize = true;
            this.label_top.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_top.Location = new System.Drawing.Point(291, 34);
            this.label_top.Name = "label_top";
            this.label_top.Size = new System.Drawing.Size(0, 24);
            this.label_top.TabIndex = 10;
            // 
            // bowser_box
            // 
            this.bowser_box.BackColor = System.Drawing.Color.Transparent;
            this.bowser_box.BackgroundImage = global::Miller_MerryGoRound.Properties.Resources.bowser_walk;
            this.bowser_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bowser_box.Location = new System.Drawing.Point(-99, 233);
            this.bowser_box.Name = "bowser_box";
            this.bowser_box.Size = new System.Drawing.Size(99, 100);
            this.bowser_box.TabIndex = 11;
            // 
            // mario_box
            // 
            this.mario_box.BackColor = System.Drawing.Color.Transparent;
            this.mario_box.BackgroundImage = global::Miller_MerryGoRound.Properties.Resources.mario_run;
            this.mario_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mario_box.Location = new System.Drawing.Point(23, 270);
            this.mario_box.Name = "mario_box";
            this.mario_box.Size = new System.Drawing.Size(49, 63);
            this.mario_box.TabIndex = 12;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Miller_MerryGoRound.Properties.Resources.mario_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mario_box);
            this.Controls.Add(this.bowser_box);
            this.Controls.Add(this.label_top);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_bottomright);
            this.Controls.Add(this.btn_bottomleft);
            this.Controls.Add(this.btn_topright);
            this.Controls.Add(this.btn_topleft);
            this.Controls.Add(this.box_bottomright);
            this.Controls.Add(this.box_bottomleft);
            this.Controls.Add(this.box_topright);
            this.Controls.Add(this.box_topleft);
            this.Controls.Add(this.box_mid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main_form";
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox box_mid;
        private System.Windows.Forms.TextBox box_topleft;
        private System.Windows.Forms.TextBox box_topright;
        private System.Windows.Forms.TextBox box_bottomleft;
        private System.Windows.Forms.TextBox box_bottomright;
        private System.Windows.Forms.Button btn_topleft;
        private System.Windows.Forms.Button btn_topright;
        private System.Windows.Forms.Button btn_bottomleft;
        private System.Windows.Forms.Button btn_bottomright;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label_top;
        private System.Windows.Forms.Panel bowser_box;
        private System.Windows.Forms.Panel mario_box;
    }
}

