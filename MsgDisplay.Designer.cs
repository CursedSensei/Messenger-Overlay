namespace Messenger_Overlay
{
    partial class MsgDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgDisplay));
            this.MoveBox = new System.Windows.Forms.PictureBox();
            this.sKeyWorker = new System.ComponentModel.BackgroundWorker();
            this.delayedInit = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.MoveBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveBox
            // 
            this.MoveBox.Image = global::Messenger_Overlay.Properties.Resources.MoveBox;
            this.MoveBox.Location = new System.Drawing.Point(371, 1);
            this.MoveBox.Name = "MoveBox";
            this.MoveBox.Size = new System.Drawing.Size(14, 14);
            this.MoveBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MoveBox.TabIndex = 0;
            this.MoveBox.TabStop = false;
            // 
            // sKeyWorker
            // 
            this.sKeyWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.sKeyWorker_DoWork);
            // 
            // delayedInit
            // 
            this.delayedInit.DoWork += new System.ComponentModel.DoWorkEventHandler(this.delayedInit_DoWork);
            // 
            // MsgDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(386, 465);
            this.Controls.Add(this.MoveBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MsgDisplay";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Messenger Display";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Lime;
            ((System.ComponentModel.ISupportInitialize)(this.MoveBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MoveBox;
        private System.ComponentModel.BackgroundWorker sKeyWorker;
        private System.ComponentModel.BackgroundWorker delayedInit;
    }
}