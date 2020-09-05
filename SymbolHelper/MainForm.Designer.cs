namespace SymbolHelper {
    partial class MainForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BIcon = new System.Windows.Forms.Button();
            this.BWords = new System.Windows.Forms.Button();
            this.PactiveWindow = new System.Windows.Forms.Panel();
            this.Bsearch = new System.Windows.Forms.Button();
            this.Bsettings = new System.Windows.Forms.Button();
            this.Babout = new System.Windows.Forms.Button();
            this.SCabout = new SymbolHelper.Controls.AboutControl();
            this.SCwords = new SymbolHelper.Controls.EditWordsControl();
            this.SCsettings = new SymbolHelper.SettingsControl();
            this.SCsearch = new SymbolHelper.SearchControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BIcon);
            this.panel1.Controls.Add(this.BWords);
            this.panel1.Controls.Add(this.PactiveWindow);
            this.panel1.Controls.Add(this.Bsearch);
            this.panel1.Controls.Add(this.Bsettings);
            this.panel1.Controls.Add(this.Babout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 450);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "SymbolHelper";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BIcon
            // 
            this.BIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BIcon.BackgroundImage")));
            this.BIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BIcon.Cursor = System.Windows.Forms.Cursors.Help;
            this.BIcon.FlatAppearance.BorderSize = 0;
            this.BIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BIcon.Location = new System.Drawing.Point(42, 29);
            this.BIcon.Name = "BIcon";
            this.BIcon.Size = new System.Drawing.Size(75, 75);
            this.BIcon.TabIndex = 5;
            this.BIcon.UseVisualStyleBackColor = true;
            this.BIcon.Click += new System.EventHandler(this.BIcon_Click);
            // 
            // BWords
            // 
            this.BWords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BWords.FlatAppearance.BorderSize = 0;
            this.BWords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BWords.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BWords.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BWords.Image = ((System.Drawing.Image)(resources.GetObject("BWords.Image")));
            this.BWords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BWords.Location = new System.Drawing.Point(12, 175);
            this.BWords.Name = "BWords";
            this.BWords.Size = new System.Drawing.Size(155, 67);
            this.BWords.TabIndex = 4;
            this.BWords.Text = "      Words";
            this.BWords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BWords.UseVisualStyleBackColor = true;
            this.BWords.Click += new System.EventHandler(this.BWords_Click);
            // 
            // PactiveWindow
            // 
            this.PactiveWindow.BackColor = System.Drawing.Color.DarkCyan;
            this.PactiveWindow.Location = new System.Drawing.Point(0, 108);
            this.PactiveWindow.Name = "PactiveWindow";
            this.PactiveWindow.Size = new System.Drawing.Size(12, 67);
            this.PactiveWindow.TabIndex = 3;
            // 
            // Bsearch
            // 
            this.Bsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bsearch.FlatAppearance.BorderSize = 0;
            this.Bsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bsearch.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bsearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Bsearch.Image = ((System.Drawing.Image)(resources.GetObject("Bsearch.Image")));
            this.Bsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bsearch.Location = new System.Drawing.Point(12, 108);
            this.Bsearch.Name = "Bsearch";
            this.Bsearch.Size = new System.Drawing.Size(155, 67);
            this.Bsearch.TabIndex = 3;
            this.Bsearch.Text = "      Search";
            this.Bsearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bsearch.UseVisualStyleBackColor = true;
            this.Bsearch.Click += new System.EventHandler(this.Bsearch_Click);
            // 
            // Bsettings
            // 
            this.Bsettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bsettings.FlatAppearance.BorderSize = 0;
            this.Bsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bsettings.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bsettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Bsettings.Image = ((System.Drawing.Image)(resources.GetObject("Bsettings.Image")));
            this.Bsettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bsettings.Location = new System.Drawing.Point(12, 242);
            this.Bsettings.Name = "Bsettings";
            this.Bsettings.Size = new System.Drawing.Size(155, 67);
            this.Bsettings.TabIndex = 2;
            this.Bsettings.Text = "      Settings";
            this.Bsettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bsettings.UseVisualStyleBackColor = true;
            this.Bsettings.Click += new System.EventHandler(this.Bsettings_Click);
            // 
            // Babout
            // 
            this.Babout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Babout.FlatAppearance.BorderSize = 0;
            this.Babout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Babout.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Babout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Babout.Image = ((System.Drawing.Image)(resources.GetObject("Babout.Image")));
            this.Babout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Babout.Location = new System.Drawing.Point(12, 383);
            this.Babout.Name = "Babout";
            this.Babout.Size = new System.Drawing.Size(155, 67);
            this.Babout.TabIndex = 1;
            this.Babout.Text = "      About";
            this.Babout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Babout.UseVisualStyleBackColor = true;
            this.Babout.Click += new System.EventHandler(this.Babout_Click);
            // 
            // SCabout
            // 
            this.SCabout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SCabout.Location = new System.Drawing.Point(167, 0);
            this.SCabout.Name = "SCabout";
            this.SCabout.Size = new System.Drawing.Size(633, 450);
            this.SCabout.TabIndex = 7;
            // 
            // SCwords
            // 
            this.SCwords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SCwords.Location = new System.Drawing.Point(167, 0);
            this.SCwords.Name = "SCwords";
            this.SCwords.Size = new System.Drawing.Size(633, 450);
            this.SCwords.TabIndex = 6;
            // 
            // SCsettings
            // 
            this.SCsettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SCsettings.Location = new System.Drawing.Point(167, 0);
            this.SCsettings.Name = "SCsettings";
            this.SCsettings.Size = new System.Drawing.Size(633, 450);
            this.SCsettings.TabIndex = 4;
            this.SCsettings.Visible = false;
            // 
            // SCsearch
            // 
            this.SCsearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SCsearch.Location = new System.Drawing.Point(167, 0);
            this.SCsearch.Name = "SCsearch";
            this.SCsearch.Size = new System.Drawing.Size(633, 450);
            this.SCsearch.TabIndex = 3;
            this.SCsearch.Load += new System.EventHandler(this.searchControl1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SCabout);
            this.Controls.Add(this.SCwords);
            this.Controls.Add(this.SCsettings);
            this.Controls.Add(this.SCsearch);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Helper";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Babout;
        private System.Windows.Forms.Button Bsearch;
        private System.Windows.Forms.Button Bsettings;
        private System.Windows.Forms.Panel PactiveWindow;
        private SearchControl SCsearch;
        private SettingsControl SCsettings;
        private Controls.EditWordsControl SCwords;
        private System.Windows.Forms.Button BWords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BIcon;
        private Controls.AboutControl SCabout;
    }
}

