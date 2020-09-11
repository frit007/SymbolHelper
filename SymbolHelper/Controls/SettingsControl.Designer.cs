namespace SymbolHelper {
    partial class SettingsControl {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsControl));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Bhide = new System.Windows.Forms.Button();
            this.CBselectTextOnOpen = new System.Windows.Forms.CheckBox();
            this.CBautoClose = new System.Windows.Forms.CheckBox();
            this.CBconfirmDelete = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "You awesome settings";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.Bhide);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 50);
            this.panel2.TabIndex = 5;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
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
            this.Bhide.Location = new System.Drawing.Point(661, 9);
            this.Bhide.Name = "Bhide";
            this.Bhide.Size = new System.Drawing.Size(32, 32);
            this.Bhide.TabIndex = 8;
            this.Bhide.UseVisualStyleBackColor = true;
            this.Bhide.Click += new System.EventHandler(this.Bhide_Click);
            // 
            // CBselectTextOnOpen
            // 
            this.CBselectTextOnOpen.AutoSize = true;
            this.CBselectTextOnOpen.Location = new System.Drawing.Point(24, 106);
            this.CBselectTextOnOpen.Name = "CBselectTextOnOpen";
            this.CBselectTextOnOpen.Size = new System.Drawing.Size(146, 17);
            this.CBselectTextOnOpen.TabIndex = 6;
            this.CBselectTextOnOpen.Text = "Select text when opening";
            this.CBselectTextOnOpen.UseVisualStyleBackColor = true;
            this.CBselectTextOnOpen.CheckedChanged += new System.EventHandler(this.CBselectTextOnOpen_CheckedChanged);
            // 
            // CBautoClose
            // 
            this.CBautoClose.AutoSize = true;
            this.CBautoClose.Location = new System.Drawing.Point(24, 129);
            this.CBautoClose.Name = "CBautoClose";
            this.CBautoClose.Size = new System.Drawing.Size(152, 17);
            this.CBautoClose.TabIndex = 7;
            this.CBautoClose.Text = "Automatically hide program";
            this.CBautoClose.UseVisualStyleBackColor = true;
            this.CBautoClose.CheckedChanged += new System.EventHandler(this.CBautoClose_CheckedChanged);
            // 
            // CBconfirmDelete
            // 
            this.CBconfirmDelete.AutoSize = true;
            this.CBconfirmDelete.Location = new System.Drawing.Point(24, 152);
            this.CBconfirmDelete.Name = "CBconfirmDelete";
            this.CBconfirmDelete.Size = new System.Drawing.Size(93, 17);
            this.CBconfirmDelete.TabIndex = 8;
            this.CBconfirmDelete.Text = "Confirm delete";
            this.CBconfirmDelete.UseVisualStyleBackColor = true;
            this.CBconfirmDelete.CheckedChanged += new System.EventHandler(this.CBconfirmDelete_CheckedChanged);
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CBconfirmDelete);
            this.Controls.Add(this.CBautoClose);
            this.Controls.Add(this.CBselectTextOnOpen);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(703, 490);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Bhide;
        private System.Windows.Forms.CheckBox CBselectTextOnOpen;
        private System.Windows.Forms.CheckBox CBautoClose;
        private System.Windows.Forms.CheckBox CBconfirmDelete;
    }
}
