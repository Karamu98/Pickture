namespace PictureSorter
{
    partial class AddDestination
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
            this.label1 = new System.Windows.Forms.Label();
            this.destName = new System.Windows.Forms.TextBox();
            this.pickSource = new System.Windows.Forms.Button();
            this.findDestination = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Destination Name";
            // 
            // destName
            // 
            this.destName.Location = new System.Drawing.Point(12, 30);
            this.destName.Name = "destName";
            this.destName.Size = new System.Drawing.Size(225, 20);
            this.destName.TabIndex = 1;
            this.destName.TextChanged += new System.EventHandler(this.destName_TextChanged);
            // 
            // pickSource
            // 
            this.pickSource.Location = new System.Drawing.Point(12, 73);
            this.pickSource.Name = "pickSource";
            this.pickSource.Size = new System.Drawing.Size(75, 23);
            this.pickSource.TabIndex = 2;
            this.pickSource.Text = "Find Folder";
            this.pickSource.UseVisualStyleBackColor = true;
            this.pickSource.Click += new System.EventHandler(this.pickSource_Click);
            // 
            // AddDestination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 113);
            this.Controls.Add(this.pickSource);
            this.Controls.Add(this.destName);
            this.Controls.Add(this.label1);
            this.Name = "AddDestination";
            this.Text = "AddDestination";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox destName;
        private System.Windows.Forms.Button pickSource;
        private System.Windows.Forms.FolderBrowserDialog findDestination;
    }
}