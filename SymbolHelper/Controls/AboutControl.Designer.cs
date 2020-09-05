namespace SymbolHelper.Controls {
    partial class AboutControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutControl));
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Bhide = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PBflaticon = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBflaticon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label1.Location = new System.Drawing.Point(208, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Icons made by ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(196, 236);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(177, 22);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.flaticon.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Bhide
            // 
            this.Bhide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bhide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bhide.BackgroundImage")));
            this.Bhide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bhide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bhide.FlatAppearance.BorderSize = 0;
            this.Bhide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bhide.ForeColor = System.Drawing.Color.Coral;
            this.Bhide.Location = new System.Drawing.Point(545, 9);
            this.Bhide.Name = "Bhide";
            this.Bhide.Size = new System.Drawing.Size(32, 32);
            this.Bhide.TabIndex = 8;
            this.Bhide.UseVisualStyleBackColor = true;
            this.Bhide.Click += new System.EventHandler(this.Bhide_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.Bhide);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 50);
            this.panel2.TabIndex = 4;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // PBflaticon
            // 
            this.PBflaticon.Image = ((System.Drawing.Image)(resources.GetObject("PBflaticon.Image")));
            this.PBflaticon.Location = new System.Drawing.Point(209, 108);
            this.PBflaticon.Name = "PBflaticon";
            this.PBflaticon.Size = new System.Drawing.Size(150, 150);
            this.PBflaticon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBflaticon.TabIndex = 5;
            this.PBflaticon.TabStop = false;
            // 
            // AboutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PBflaticon);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AboutControl";
            this.Size = new System.Drawing.Size(587, 441);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBflaticon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button Bhide;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PBflaticon;
    }
}
