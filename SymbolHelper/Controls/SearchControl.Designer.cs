namespace SymbolHelper {
    partial class SearchControl {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchControl));
            this.panel2 = new System.Windows.Forms.Panel();
            this.Bhide = new System.Windows.Forms.Button();
            this.TBsearch = new System.Windows.Forms.TextBox();
            this.FLPwords = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.Bhide);
            this.panel2.Controls.Add(this.TBsearch);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(728, 50);
            this.panel2.TabIndex = 3;
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
            this.Bhide.Location = new System.Drawing.Point(686, 9);
            this.Bhide.Name = "Bhide";
            this.Bhide.Size = new System.Drawing.Size(32, 32);
            this.Bhide.TabIndex = 8;
            this.Bhide.UseVisualStyleBackColor = true;
            this.Bhide.Click += new System.EventHandler(this.Bhide_Click);
            // 
            // TBsearch
            // 
            this.TBsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TBsearch.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBsearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TBsearch.Location = new System.Drawing.Point(6, 6);
            this.TBsearch.Margin = new System.Windows.Forms.Padding(6);
            this.TBsearch.Name = "TBsearch";
            this.TBsearch.Size = new System.Drawing.Size(663, 40);
            this.TBsearch.TabIndex = 0;
            this.TBsearch.TextChanged += new System.EventHandler(this.TBsearch_TextChanged);
            this.TBsearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBsearch_KeyDown);
            // 
            // FLPwords
            // 
            this.FLPwords.AutoScroll = true;
            this.FLPwords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPwords.Location = new System.Drawing.Point(0, 50);
            this.FLPwords.Name = "FLPwords";
            this.FLPwords.Size = new System.Drawing.Size(728, 389);
            this.FLPwords.TabIndex = 9;
            // 
            // SearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FLPwords);
            this.Controls.Add(this.panel2);
            this.Name = "SearchControl";
            this.Size = new System.Drawing.Size(728, 439);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TBsearch;
        private System.Windows.Forms.Button Bhide;
        private System.Windows.Forms.FlowLayoutPanel FLPwords;
    }
}
