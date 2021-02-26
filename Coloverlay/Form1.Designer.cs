namespace Coloverlay
{
    partial class OverlayWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverlayWindow));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyCM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incOpacityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decOpacityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.minimiseEscToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.colorCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incOpacityToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.decOpacityXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimiseEscToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximiseDoubleClickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyCM.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.notifyCM;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Coloverlay";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseClick);
            // 
            // notifyCM
            // 
            this.notifyCM.BackColor = System.Drawing.Color.DimGray;
            this.notifyCM.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.notifyCM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colourToolStripMenuItem,
            this.incOpacityToolStripMenuItem,
            this.decOpacityToolStripMenuItem,
            this.toolStripSeparator2,
            this.helpToolStripMenuItem1,
            this.closeToolStripMenuItem});
            this.notifyCM.Name = "notifyCM";
            this.notifyCM.ShowImageMargin = false;
            this.notifyCM.Size = new System.Drawing.Size(132, 120);
            // 
            // colourToolStripMenuItem
            // 
            this.colourToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            this.colourToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.colourToolStripMenuItem.Text = "Colour (C)";
            this.colourToolStripMenuItem.Click += new System.EventHandler(this.colourToolStripMenuItem_Click);
            // 
            // incOpacityToolStripMenuItem
            // 
            this.incOpacityToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.incOpacityToolStripMenuItem.Name = "incOpacityToolStripMenuItem";
            this.incOpacityToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.incOpacityToolStripMenuItem.Text = "Inc Opacity (X)";
            this.incOpacityToolStripMenuItem.Click += new System.EventHandler(this.incOpacityToolStripMenuItem_Click);
            // 
            // decOpacityToolStripMenuItem
            // 
            this.decOpacityToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.decOpacityToolStripMenuItem.Name = "decOpacityToolStripMenuItem";
            this.decOpacityToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.decOpacityToolStripMenuItem.Text = "Dec Opacity (Z)";
            this.decOpacityToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(128, 6);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.helpToolStripMenuItem1.Text = "Help (H)";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.closeToolStripMenuItem.Text = "Close (K)";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maximiseDoubleClickToolStripMenuItem,
            this.minimiseEscToolStripMenuItem1,
            this.toolStripSeparator3,
            this.colorCToolStripMenuItem,
            this.incOpacityToolStripMenuItem1,
            this.decOpacityXToolStripMenuItem,
            this.toolStripSeparator1,
            this.helpToolStripMenuItem,
            this.closeKToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(179, 192);
            // 
            // minimiseEscToolStripMenuItem1
            // 
            this.minimiseEscToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.minimiseEscToolStripMenuItem1.Name = "minimiseEscToolStripMenuItem1";
            this.minimiseEscToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.minimiseEscToolStripMenuItem1.Text = "Minimise (Esc)";
            this.minimiseEscToolStripMenuItem1.Click += new System.EventHandler(this.minimiseEscToolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(175, 6);
            // 
            // colorCToolStripMenuItem
            // 
            this.colorCToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.colorCToolStripMenuItem.Name = "colorCToolStripMenuItem";
            this.colorCToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.colorCToolStripMenuItem.Text = "Colour (C)";
            this.colorCToolStripMenuItem.Click += new System.EventHandler(this.colorCToolStripMenuItem_Click);
            // 
            // incOpacityToolStripMenuItem1
            // 
            this.incOpacityToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.incOpacityToolStripMenuItem1.Name = "incOpacityToolStripMenuItem1";
            this.incOpacityToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.incOpacityToolStripMenuItem1.Text = "Inc Opacity (X)";
            this.incOpacityToolStripMenuItem1.Click += new System.EventHandler(this.incOpacityToolStripMenuItem1_Click);
            // 
            // decOpacityXToolStripMenuItem
            // 
            this.decOpacityXToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.decOpacityXToolStripMenuItem.Name = "decOpacityXToolStripMenuItem";
            this.decOpacityXToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.decOpacityXToolStripMenuItem.Text = "Dec Opacity (Z)";
            this.decOpacityXToolStripMenuItem.Click += new System.EventHandler(this.decOpacityXToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.helpToolStripMenuItem.Text = "Help (H)";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // closeKToolStripMenuItem
            // 
            this.closeKToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.closeKToolStripMenuItem.Name = "closeKToolStripMenuItem";
            this.closeKToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.closeKToolStripMenuItem.Text = "Close (K)";
            this.closeKToolStripMenuItem.Click += new System.EventHandler(this.closeKToolStripMenuItem_Click);
            // 
            // minimiseEscToolStripMenuItem
            // 
            this.minimiseEscToolStripMenuItem.Name = "minimiseEscToolStripMenuItem";
            this.minimiseEscToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // maximiseDoubleClickToolStripMenuItem
            // 
            this.maximiseDoubleClickToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.maximiseDoubleClickToolStripMenuItem.Name = "maximiseDoubleClickToolStripMenuItem";
            this.maximiseDoubleClickToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.maximiseDoubleClickToolStripMenuItem.Text = "Maximise (Double Click)";
            this.maximiseDoubleClickToolStripMenuItem.Click += new System.EventHandler(this.maximiseDoubleClickToolStripMenuItem_Click);
            // 
            // OverlayWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(40F, 76F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Coloverlay.Properties.Settings.Default.OverlayColor;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Coloverlay.Properties.Settings.Default, "OverlayColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Opacity", global::Coloverlay.Properties.Settings.Default, "OverlayOpacity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(50, 50);
            this.Name = "OverlayWindow";
            this.Opacity = global::Coloverlay.Properties.Settings.Default.OverlayOpacity;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coloverlay";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_DoubleClick);
            this.notifyCM.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyCM;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem incOpacityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decOpacityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incOpacityToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem decOpacityXToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimiseEscToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minimiseEscToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem maximiseDoubleClickToolStripMenuItem;
    }
}

