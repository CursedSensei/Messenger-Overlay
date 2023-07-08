
namespace Messenger_Overlay
{
    partial class MsgBackground
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgBackground));
            this.MsgNotifTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.MsgIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.IconMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MsgIconMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MsgNotifTray
            // 
            this.MsgNotifTray.ContextMenuStrip = this.MsgIconMenu;
            this.MsgNotifTray.Icon = ((System.Drawing.Icon)(resources.GetObject("MsgNotifTray.Icon")));
            this.MsgNotifTray.Text = "Messenger Overlay";
            this.MsgNotifTray.DoubleClick += new System.EventHandler(this.MsgNotifTray_DoubleClick);
            // 
            // MsgIconMenu
            // 
            this.MsgIconMenu.BackColor = System.Drawing.SystemColors.Control;
            this.MsgIconMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MsgIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IconMenuOpen,
            this.closeToolStripMenuItem});
            this.MsgIconMenu.Name = "MsgIconMenu";
            this.MsgIconMenu.Size = new System.Drawing.Size(181, 70);
            // 
            // IconMenuOpen
            // 
            this.IconMenuOpen.Name = "IconMenuOpen";
            this.IconMenuOpen.Size = new System.Drawing.Size(180, 22);
            this.IconMenuOpen.Text = "Open";
            this.IconMenuOpen.Click += new System.EventHandler(this.IconMenuOpen_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.IconMenuClose_Click);
            // 
            // MsgBackground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MsgBackground";
            this.Opacity = 0.75D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MsgBackground";
            this.TopMost = true;
            this.Click += new System.EventHandler(this.MsgBackground_Click);
            this.MsgIconMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.NotifyIcon MsgNotifTray;
        private System.Windows.Forms.ContextMenuStrip MsgIconMenu;
        private System.Windows.Forms.ToolStripMenuItem IconMenuOpen;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}