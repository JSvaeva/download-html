namespace DownloadProject
{
    partial class Form1
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
            this.uriTextBox = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.downloadButton = new System.Windows.Forms.Button();
            this.linkLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uriTextBox
            // 
            this.uriTextBox.Location = new System.Drawing.Point(70, 21);
            this.uriTextBox.Name = "uriTextBox";
            this.uriTextBox.Size = new System.Drawing.Size(267, 20);
            this.uriTextBox.TabIndex = 0;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.infoLabel.Location = new System.Drawing.Point(3, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(149, 13);
            this.infoLabel.TabIndex = 1;
            this.infoLabel.Text = "Insert link to download page...";
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(26, 57);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(311, 23);
            this.downloadButton.TabIndex = 2;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(23, 24);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(30, 13);
            this.linkLabel.TabIndex = 3;
            this.linkLabel.Text = "Link:";
            this.linkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.infoLabel);
            this.panel1.Location = new System.Drawing.Point(26, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 239);
            this.panel1.TabIndex = 4;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(25, 363);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(311, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 412);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.uriTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uriTextBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Label linkLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clearButton;
    }
}

