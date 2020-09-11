namespace SymbolHelper.Controls {
    partial class EditWordsControl {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditWordsControl));
            this.FLPlist = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBsearch = new System.Windows.Forms.TextBox();
            this.Bhide = new System.Windows.Forms.Button();
            this.BaddWord = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FLPlist
            // 
            this.FLPlist.AutoScroll = true;
            this.FLPlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPlist.Location = new System.Drawing.Point(0, 50);
            this.FLPlist.Name = "FLPlist";
            this.FLPlist.Size = new System.Drawing.Size(696, 462);
            this.FLPlist.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.TBsearch);
            this.panel1.Controls.Add(this.Bhide);
            this.panel1.Controls.Add(this.BaddWord);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 50);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // TBsearch
            // 
            this.TBsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TBsearch.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBsearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TBsearch.Location = new System.Drawing.Point(4, 6);
            this.TBsearch.Margin = new System.Windows.Forms.Padding(6);
            this.TBsearch.Name = "TBsearch";
            this.TBsearch.Size = new System.Drawing.Size(604, 40);
            this.TBsearch.TabIndex = 1;
            this.TBsearch.TextChanged += new System.EventHandler(this.TBsearch_TextChanged);
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
            this.Bhide.Location = new System.Drawing.Point(654, 9);
            this.Bhide.Name = "Bhide";
            this.Bhide.Size = new System.Drawing.Size(32, 32);
            this.Bhide.TabIndex = 9;
            this.Bhide.UseVisualStyleBackColor = true;
            this.Bhide.Click += new System.EventHandler(this.Bhide_Click);
            // 
            // BaddWord
            // 
            this.BaddWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BaddWord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BaddWord.BackgroundImage")));
            this.BaddWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BaddWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BaddWord.FlatAppearance.BorderSize = 0;
            this.BaddWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BaddWord.Location = new System.Drawing.Point(614, 8);
            this.BaddWord.Margin = new System.Windows.Forms.Padding(0);
            this.BaddWord.Name = "BaddWord";
            this.BaddWord.Size = new System.Drawing.Size(32, 32);
            this.BaddWord.TabIndex = 0;
            this.BaddWord.UseVisualStyleBackColor = true;
            this.BaddWord.Click += new System.EventHandler(this.BaddWord_Click);
            // 
            // EditWordsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FLPlist);
            this.Controls.Add(this.panel1);
            this.Name = "EditWordsControl";
            this.Size = new System.Drawing.Size(696, 512);
            this.Load += new System.EventHandler(this.WordsControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPlist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BaddWord;
        private System.Windows.Forms.Button Bhide;
        private System.Windows.Forms.TextBox TBsearch;
    }
}
