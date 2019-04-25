namespace PictureSorter
{
    partial class PicturePicker
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSourceFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureSlot = new System.Windows.Forms.PictureBox();
            this.ImageNameLabel = new System.Windows.Forms.Label();
            this.skipImageButton = new System.Windows.Forms.Button();
            this.destButtonLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.sourcePicker = new System.Windows.Forms.FolderBrowserDialog();
            this.sourcePathLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSlot)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFolderToolStripMenuItem,
            this.setSourceFolderToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // addFolderToolStripMenuItem
            // 
            this.addFolderToolStripMenuItem.Name = "addFolderToolStripMenuItem";
            this.addFolderToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.addFolderToolStripMenuItem.Text = "Add Destination Folder";
            this.addFolderToolStripMenuItem.Click += new System.EventHandler(this.addFolderToolStripMenuItem_Click);
            // 
            // setSourceFolderToolStripMenuItem
            // 
            this.setSourceFolderToolStripMenuItem.Name = "setSourceFolderToolStripMenuItem";
            this.setSourceFolderToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.setSourceFolderToolStripMenuItem.Text = "Set Source Folder";
            this.setSourceFolderToolStripMenuItem.Click += new System.EventHandler(this.setSourceFolderToolStripMenuItem_Click);
            // 
            // pictureSlot
            // 
            this.pictureSlot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureSlot.Location = new System.Drawing.Point(43, 139);
            this.pictureSlot.Name = "pictureSlot";
            this.pictureSlot.Size = new System.Drawing.Size(432, 258);
            this.pictureSlot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSlot.TabIndex = 1;
            this.pictureSlot.TabStop = false;
            // 
            // ImageNameLabel
            // 
            this.ImageNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageNameLabel.Location = new System.Drawing.Point(12, 115);
            this.ImageNameLabel.Name = "ImageNameLabel";
            this.ImageNameLabel.Size = new System.Drawing.Size(513, 21);
            this.ImageNameLabel.TabIndex = 5;
            this.ImageNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skipImageButton
            // 
            this.skipImageButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.skipImageButton.Location = new System.Drawing.Point(230, 424);
            this.skipImageButton.Name = "skipImageButton";
            this.skipImageButton.Size = new System.Drawing.Size(72, 23);
            this.skipImageButton.TabIndex = 3;
            this.skipImageButton.Text = "Skip";
            this.skipImageButton.UseVisualStyleBackColor = true;
            this.skipImageButton.Click += new System.EventHandler(this.skipImageButton_Click);
            // 
            // destButtonLayout
            // 
            this.destButtonLayout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.destButtonLayout.Location = new System.Drawing.Point(43, 45);
            this.destButtonLayout.Name = "destButtonLayout";
            this.destButtonLayout.Size = new System.Drawing.Size(434, 58);
            this.destButtonLayout.TabIndex = 4;
            // 
            // sourcePathLabel
            // 
            this.sourcePathLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sourcePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourcePathLabel.Location = new System.Drawing.Point(15, 400);
            this.sourcePathLabel.Name = "sourcePathLabel";
            this.sourcePathLabel.Size = new System.Drawing.Size(510, 20);
            this.sourcePathLabel.TabIndex = 5;
            this.sourcePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicturePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 467);
            this.Controls.Add(this.sourcePathLabel);
            this.Controls.Add(this.destButtonLayout);
            this.Controls.Add(this.skipImageButton);
            this.Controls.Add(this.ImageNameLabel);
            this.Controls.Add(this.pictureSlot);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PicturePicker";
            this.Text = "Pickture";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSlot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSourceFolderToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureSlot;
        private System.Windows.Forms.Label ImageNameLabel;
        private System.Windows.Forms.Button skipImageButton;
        private System.Windows.Forms.FlowLayoutPanel destButtonLayout;
        private System.Windows.Forms.FolderBrowserDialog sourcePicker;
        private System.Windows.Forms.Label sourcePathLabel;
    }
}

