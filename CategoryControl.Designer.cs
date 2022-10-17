namespace Blogz
{
    partial class CategoryControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryControl));
            this.BlogsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.OpenCloseButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BlogsPanel
            // 
            this.BlogsPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BlogsPanel.AutoScroll = true;
            this.BlogsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BlogsPanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.BlogsPanel.Location = new System.Drawing.Point(3, 36);
            this.BlogsPanel.Name = "BlogsPanel";
            this.BlogsPanel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.BlogsPanel.Size = new System.Drawing.Size(610, 258);
            this.BlogsPanel.TabIndex = 0;
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.Transparent;
            this.TitlePanel.Controls.Add(this.OpenCloseButton);
            this.TitlePanel.Controls.Add(this.TitleLabel);
            this.TitlePanel.Location = new System.Drawing.Point(3, 3);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(612, 31);
            this.TitlePanel.TabIndex = 1;
            // 
            // OpenCloseButton
            // 
            this.OpenCloseButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.OpenCloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpenCloseButton.BackgroundImage")));
            this.OpenCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenCloseButton.FlatAppearance.BorderSize = 0;
            this.OpenCloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.OpenCloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.OpenCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenCloseButton.ForeColor = System.Drawing.Color.Transparent;
            this.OpenCloseButton.Location = new System.Drawing.Point(584, 5);
            this.OpenCloseButton.Name = "OpenCloseButton";
            this.OpenCloseButton.Size = new System.Drawing.Size(22, 22);
            this.OpenCloseButton.TabIndex = 1;
            this.OpenCloseButton.UseVisualStyleBackColor = false;
            this.OpenCloseButton.Click += new System.EventHandler(this.OpenCloseButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(6, 6);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(38, 20);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title";
            // 
            // CategoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.BlogsPanel);
            this.Name = "CategoryControl";
            this.Size = new System.Drawing.Size(620, 299);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button OpenCloseButton;
        public System.Windows.Forms.FlowLayoutPanel BlogsPanel;
    }
}
