namespace frmBegin
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ex38ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex39ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex40ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex41ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex42ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbBoxMenu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ex38ToolStripMenuItem,
            this.ex39ToolStripMenuItem,
            this.ex40ToolStripMenuItem,
            this.ex41ToolStripMenuItem,
            this.ex42ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(920, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ex38ToolStripMenuItem
            // 
            this.ex38ToolStripMenuItem.Name = "ex38ToolStripMenuItem";
            this.ex38ToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.ex38ToolStripMenuItem.Text = "Ex38";
            this.ex38ToolStripMenuItem.Click += new System.EventHandler(this.ex38ToolStripMenuItem_Click);
            // 
            // ex39ToolStripMenuItem
            // 
            this.ex39ToolStripMenuItem.Name = "ex39ToolStripMenuItem";
            this.ex39ToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.ex39ToolStripMenuItem.Text = "Ex39";
            this.ex39ToolStripMenuItem.Click += new System.EventHandler(this.ex39ToolStripMenuItem_Click);
            // 
            // ex40ToolStripMenuItem
            // 
            this.ex40ToolStripMenuItem.Name = "ex40ToolStripMenuItem";
            this.ex40ToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.ex40ToolStripMenuItem.Text = "Ex40";
            this.ex40ToolStripMenuItem.Click += new System.EventHandler(this.ex40ToolStripMenuItem_Click);
            // 
            // ex41ToolStripMenuItem
            // 
            this.ex41ToolStripMenuItem.Name = "ex41ToolStripMenuItem";
            this.ex41ToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.ex41ToolStripMenuItem.Text = "Ex41";
            this.ex41ToolStripMenuItem.Click += new System.EventHandler(this.ex41ToolStripMenuItem_Click);
            // 
            // ex42ToolStripMenuItem
            // 
            this.ex42ToolStripMenuItem.Name = "ex42ToolStripMenuItem";
            this.ex42ToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.ex42ToolStripMenuItem.Text = "Ex42";
            this.ex42ToolStripMenuItem.Click += new System.EventHandler(this.ex42ToolStripMenuItem_Click);
            // 
            // cmbBoxMenu
            // 
            this.cmbBoxMenu.FormattingEnabled = true;
            this.cmbBoxMenu.Items.AddRange(new object[] {
            "38",
            "39",
            "40",
            "41",
            "42"});
            this.cmbBoxMenu.Location = new System.Drawing.Point(402, 3);
            this.cmbBoxMenu.Name = "cmbBoxMenu";
            this.cmbBoxMenu.Size = new System.Drawing.Size(50, 21);
            this.cmbBoxMenu.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Escolha o exercício: ";
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(458, 1);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(31, 23);
            this.btnGo.TabIndex = 6;
            this.btnGo.Text = "Ir";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(920, 631);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxMenu);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMenu_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ex38ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ex39ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ex40ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ex41ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ex42ToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbBoxMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGo;
    }
}

