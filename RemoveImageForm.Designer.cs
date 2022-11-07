namespace Blogz
{
    partial class RemoveImageForm
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
            this.ImageComboBox = new System.Windows.Forms.ComboBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CreatorLabel = new System.Windows.Forms.Label();
            this.CreationLabel = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageComboBox
            // 
            this.ImageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ImageComboBox.FormattingEnabled = true;
            this.ImageComboBox.Location = new System.Drawing.Point(230, 12);
            this.ImageComboBox.Name = "ImageComboBox";
            this.ImageComboBox.Size = new System.Drawing.Size(188, 21);
            this.ImageComboBox.TabIndex = 1;
            this.ImageComboBox.SelectedIndexChanged += new System.EventHandler(this.ImageComboBox_SelectedIndexChanged);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(230, 41);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(33, 13);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Title: ";
            // 
            // CreatorLabel
            // 
            this.CreatorLabel.AutoSize = true;
            this.CreatorLabel.Location = new System.Drawing.Point(230, 59);
            this.CreatorLabel.Name = "CreatorLabel";
            this.CreatorLabel.Size = new System.Drawing.Size(44, 13);
            this.CreatorLabel.TabIndex = 3;
            this.CreatorLabel.Text = "Creator:";
            // 
            // CreationLabel
            // 
            this.CreationLabel.AutoSize = true;
            this.CreationLabel.Location = new System.Drawing.Point(230, 76);
            this.CreationLabel.Name = "CreationLabel";
            this.CreationLabel.Size = new System.Drawing.Size(49, 13);
            this.CreationLabel.TabIndex = 4;
            this.CreationLabel.Text = "Creation:";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(325, 114);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(93, 23);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(230, 114);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(93, 23);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 125);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(230, 93);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 13);
            this.IDLabel.TabIndex = 7;
            this.IDLabel.Text = "ID:";
            // 
            // RemoveImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 145);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.CreationLabel);
            this.Controls.Add(this.CreatorLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ImageComboBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(446, 184);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(446, 184);
            this.Name = "RemoveImageForm";
            this.Text = "Image Manager";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox ImageComboBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CreatorLabel;
        private System.Windows.Forms.Label CreationLabel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label IDLabel;
    }
}