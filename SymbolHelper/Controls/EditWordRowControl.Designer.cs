namespace SymbolHelper.Controls {
    partial class EditWordRowControl {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditWordRowControl));
            this.Lletter = new System.Windows.Forms.Label();
            this.TBcode = new System.Windows.Forms.TextBox();
            this.Lcode = new System.Windows.Forms.Label();
            this.TBname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PletterBackground = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pdelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PletterBackground.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lletter
            // 
            this.Lletter.AutoSize = true;
            this.Lletter.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lletter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lletter.Location = new System.Drawing.Point(20, 17);
            this.Lletter.Name = "Lletter";
            this.Lletter.Size = new System.Drawing.Size(34, 33);
            this.Lletter.TabIndex = 0;
            this.Lletter.Text = "A";
            // 
            // TBcode
            // 
            this.TBcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBcode.Location = new System.Drawing.Point(123, 5);
            this.TBcode.Name = "TBcode";
            this.TBcode.Size = new System.Drawing.Size(76, 31);
            this.TBcode.TabIndex = 1;
            this.TBcode.Text = "03B1";
            this.TBcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBcode.TextChanged += new System.EventHandler(this.TBcode_TextChanged);
            // 
            // Lcode
            // 
            this.Lcode.AutoSize = true;
            this.Lcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lcode.Location = new System.Drawing.Point(6, 4);
            this.Lcode.Name = "Lcode";
            this.Lcode.Size = new System.Drawing.Size(106, 25);
            this.Lcode.TabIndex = 2;
            this.Lcode.Text = "UTF code";
            this.Lcode.Click += new System.EventHandler(this.Lcode_Click);
            // 
            // TBname
            // 
            this.TBname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBname.Location = new System.Drawing.Point(123, 37);
            this.TBname.Name = "TBname";
            this.TBname.Size = new System.Drawing.Size(353, 24);
            this.TBname.TabIndex = 3;
            this.TBname.Text = "alpha";
            this.TBname.TextChanged += new System.EventHandler(this.TBname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Names";
            // 
            // PletterBackground
            // 
            this.PletterBackground.BackColor = System.Drawing.Color.Teal;
            this.PletterBackground.Controls.Add(this.Lletter);
            this.PletterBackground.Dock = System.Windows.Forms.DockStyle.Left;
            this.PletterBackground.Location = new System.Drawing.Point(0, 0);
            this.PletterBackground.Name = "PletterBackground";
            this.PletterBackground.Size = new System.Drawing.Size(72, 68);
            this.PletterBackground.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Pdelete);
            this.panel1.Controls.Add(this.TBname);
            this.panel1.Controls.Add(this.TBcode);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(72, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 68);
            this.panel1.TabIndex = 6;
            // 
            // Pdelete
            // 
            this.Pdelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pdelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pdelete.BackgroundImage")));
            this.Pdelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pdelete.FlatAppearance.BorderSize = 0;
            this.Pdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pdelete.Location = new System.Drawing.Point(479, 8);
            this.Pdelete.Name = "Pdelete";
            this.Pdelete.Size = new System.Drawing.Size(50, 50);
            this.Pdelete.TabIndex = 5;
            this.Pdelete.UseVisualStyleBackColor = true;
            this.Pdelete.Click += new System.EventHandler(this.Pdelete_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Lcode);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 68);
            this.panel2.TabIndex = 0;
            // 
            // EditWordRowControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PletterBackground);
            this.Name = "EditWordRowControl";
            this.Size = new System.Drawing.Size(606, 68);
            this.PletterBackground.ResumeLayout(false);
            this.PletterBackground.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lletter;
        private System.Windows.Forms.TextBox TBcode;
        private System.Windows.Forms.Label Lcode;
        private System.Windows.Forms.TextBox TBname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PletterBackground;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Pdelete;
    }
}
