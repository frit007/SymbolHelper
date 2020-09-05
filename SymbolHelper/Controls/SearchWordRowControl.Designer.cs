namespace SymbolHelper.Controls {
    partial class SearchWordRowControl {
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
            this.PletterBackground = new System.Windows.Forms.Panel();
            this.Lletter = new System.Windows.Forms.Label();
            this.Lnames = new System.Windows.Forms.Label();
            this.PletterBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // PletterBackground
            // 
            this.PletterBackground.BackColor = System.Drawing.Color.Teal;
            this.PletterBackground.Controls.Add(this.Lletter);
            this.PletterBackground.Dock = System.Windows.Forms.DockStyle.Left;
            this.PletterBackground.Location = new System.Drawing.Point(0, 0);
            this.PletterBackground.Name = "PletterBackground";
            this.PletterBackground.Size = new System.Drawing.Size(72, 61);
            this.PletterBackground.TabIndex = 6;
            // 
            // Lletter
            // 
            this.Lletter.AutoSize = true;
            this.Lletter.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lletter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lletter.Location = new System.Drawing.Point(19, 13);
            this.Lletter.Name = "Lletter";
            this.Lletter.Size = new System.Drawing.Size(34, 33);
            this.Lletter.TabIndex = 0;
            this.Lletter.Text = "A";
            // 
            // Lnames
            // 
            this.Lnames.AutoSize = true;
            this.Lnames.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lnames.Location = new System.Drawing.Point(78, 19);
            this.Lnames.Name = "Lnames";
            this.Lnames.Size = new System.Drawing.Size(64, 21);
            this.Lnames.TabIndex = 7;
            this.Lnames.Text = "Names";
            // 
            // SearchWordRowControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lnames);
            this.Controls.Add(this.PletterBackground);
            this.Name = "SearchWordRowControl";
            this.Size = new System.Drawing.Size(591, 61);
            this.PletterBackground.ResumeLayout(false);
            this.PletterBackground.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PletterBackground;
        private System.Windows.Forms.Label Lletter;
        private System.Windows.Forms.Label Lnames;
    }
}
