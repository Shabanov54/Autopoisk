
namespace PortalMazda
{
    partial class WindowForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowForm));
            this.BrowserPanel = new System.Windows.Forms.Panel();
            this.downloadGIF = new System.Windows.Forms.PictureBox();
            this.BrowserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.downloadGIF)).BeginInit();
            this.SuspendLayout();
            // 
            // BrowserPanel
            // 
            this.BrowserPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowserPanel.Controls.Add(this.downloadGIF);
            this.BrowserPanel.Location = new System.Drawing.Point(1, 0);
            this.BrowserPanel.Name = "BrowserPanel";
            this.BrowserPanel.Size = new System.Drawing.Size(796, 452);
            this.BrowserPanel.TabIndex = 0;
            // 
            // downloadGIF
            // 
            this.downloadGIF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadGIF.Image = ((System.Drawing.Image)(resources.GetObject("downloadGIF.Image")));
            this.downloadGIF.Location = new System.Drawing.Point(277, 114);
            this.downloadGIF.Name = "downloadGIF";
            this.downloadGIF.Size = new System.Drawing.Size(200, 200);
            this.downloadGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.downloadGIF.TabIndex = 0;
            this.downloadGIF.TabStop = false;
            // 
            // WindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BrowserPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WindowForm";
            this.Text = "Portal";
            this.BrowserPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.downloadGIF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BrowserPanel;
        private System.Windows.Forms.PictureBox downloadGIF;
    }
}

