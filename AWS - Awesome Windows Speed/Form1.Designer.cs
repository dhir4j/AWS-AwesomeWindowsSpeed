namespace AWS___Awesome_Windows_Speed
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialSwitch5 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialSwitch4 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialSwitch3 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialSwitch2 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialSwitch6 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialTabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(794, 383);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.ImageKey = "icons8-home-page-50.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.materialSwitch6);
            this.tabPage2.Controls.Add(this.materialSwitch5);
            this.tabPage2.Controls.Add(this.materialSwitch4);
            this.tabPage2.Controls.Add(this.materialSwitch3);
            this.tabPage2.Controls.Add(this.materialSwitch2);
            this.tabPage2.Controls.Add(this.materialSwitch1);
            this.tabPage2.ImageKey = "icons8-rocket-50.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Boost Tools";
            // 
            // materialSwitch5
            // 
            this.materialSwitch5.AutoSize = true;
            this.materialSwitch5.Depth = 0;
            this.materialSwitch5.Location = new System.Drawing.Point(29, 207);
            this.materialSwitch5.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch5.Name = "materialSwitch5";
            this.materialSwitch5.Ripple = true;
            this.materialSwitch5.Size = new System.Drawing.Size(424, 37);
            this.materialSwitch5.TabIndex = 4;
            this.materialSwitch5.Text = "Improve System responsiveness and Network speed";
            this.materialSwitch5.UseVisualStyleBackColor = true;
            this.materialSwitch5.CheckedChanged += new System.EventHandler(this.materialSwitch5_CheckedChanged);
            // 
            // materialSwitch4
            // 
            this.materialSwitch4.AutoSize = true;
            this.materialSwitch4.Depth = 0;
            this.materialSwitch4.Location = new System.Drawing.Point(29, 170);
            this.materialSwitch4.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch4.Name = "materialSwitch4";
            this.materialSwitch4.Ripple = true;
            this.materialSwitch4.Size = new System.Drawing.Size(242, 37);
            this.materialSwitch4.TabIndex = 3;
            this.materialSwitch4.Text = "Speedup Shut Down Time";
            this.materialSwitch4.UseVisualStyleBackColor = true;
            this.materialSwitch4.CheckedChanged += new System.EventHandler(this.materialSwitch4_CheckedChanged);
            // 
            // materialSwitch3
            // 
            this.materialSwitch3.AutoSize = true;
            this.materialSwitch3.Depth = 0;
            this.materialSwitch3.Location = new System.Drawing.Point(29, 133);
            this.materialSwitch3.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch3.Name = "materialSwitch3";
            this.materialSwitch3.Ripple = true;
            this.materialSwitch3.Size = new System.Drawing.Size(505, 37);
            this.materialSwitch3.TabIndex = 2;
            this.materialSwitch3.Text = "Slightly Improves RAM management and Overall system speed.";
            this.materialSwitch3.UseVisualStyleBackColor = true;
            this.materialSwitch3.CheckedChanged += new System.EventHandler(this.materialSwitch3_CheckedChanged);
            // 
            // materialSwitch2
            // 
            this.materialSwitch2.AutoSize = true;
            this.materialSwitch2.Depth = 0;
            this.materialSwitch2.Location = new System.Drawing.Point(29, 96);
            this.materialSwitch2.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch2.Name = "materialSwitch2";
            this.materialSwitch2.Ripple = true;
            this.materialSwitch2.Size = new System.Drawing.Size(289, 37);
            this.materialSwitch2.TabIndex = 1;
            this.materialSwitch2.Text = "Disable GameDVR and GameBar";
            this.materialSwitch2.UseVisualStyleBackColor = true;
            this.materialSwitch2.CheckedChanged += new System.EventHandler(this.materialSwitch2_CheckedChanged);
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.AutoSize = true;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Location = new System.Drawing.Point(29, 59);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(135, 37);
            this.materialSwitch1.TabIndex = 0;
            this.materialSwitch1.Text = "Dark Mode";
            this.materialSwitch1.UseVisualStyleBackColor = true;
            this.materialSwitch1.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.ImageKey = "icons8-remove-50.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(786, 340);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Debloat Tools";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.ImageKey = "icons8-developer-50.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(786, 340);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "About";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-developer-50.png");
            this.imageList1.Images.SetKeyName(1, "icons8-home-page-50.png");
            this.imageList1.Images.SetKeyName(2, "icons8-remove-50.png");
            this.imageList1.Images.SetKeyName(3, "icons8-rocket-50.png");
            // 
            // materialSwitch6
            // 
            this.materialSwitch6.AutoSize = true;
            this.materialSwitch6.Depth = 0;
            this.materialSwitch6.Location = new System.Drawing.Point(29, 22);
            this.materialSwitch6.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch6.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch6.Name = "materialSwitch6";
            this.materialSwitch6.Ripple = true;
            this.materialSwitch6.Size = new System.Drawing.Size(271, 37);
            this.materialSwitch6.TabIndex = 5;
            this.materialSwitch6.Text = "Ultimate Performance Tweaks";
            this.materialSwitch6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AWS - Awesome Windows Speed";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ImageList imageList1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch5;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch4;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch3;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch2;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch6;
    }
}