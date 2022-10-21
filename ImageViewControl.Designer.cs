namespace Blogz
{
    partial class ImgViewControl
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
            this.ImgViewCheckBox = new System.Windows.Forms.CheckBox();
            this.ImgViewPictureBox = new System.Windows.Forms.PictureBox();
            this.OCButton = new System.Windows.Forms.Button();
            this.ImgViewTitleLabel = new System.Windows.Forms.Label();
            this.ImgViewCreatorLabel = new System.Windows.Forms.Label();
            this.ImgViewCreationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImgViewPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgViewCheckBox
            // 
            this.ImgViewCheckBox.AutoSize = true;
            this.ImgViewCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImgViewCheckBox.Location = new System.Drawing.Point(3, 131);
            this.ImgViewCheckBox.Name = "ImgViewCheckBox";
            this.ImgViewCheckBox.Size = new System.Drawing.Size(89, 19);
            this.ImgViewCheckBox.TabIndex = 2;
            this.ImgViewCheckBox.Text = "DisplayText";
            this.ImgViewCheckBox.UseVisualStyleBackColor = true;
            this.ImgViewCheckBox.CheckedChanged += new System.EventHandler(this.ImgViewCheckBox_CheckedChanged);
            // 
            // ImgViewPictureBox
            // 
            this.ImgViewPictureBox.Location = new System.Drawing.Point(3, 3);
            this.ImgViewPictureBox.Name = "ImgViewPictureBox";
            this.ImgViewPictureBox.Size = new System.Drawing.Size(212, 125);
            this.ImgViewPictureBox.TabIndex = 0;
            this.ImgViewPictureBox.TabStop = false;
            this.ImgViewPictureBox.Click += new System.EventHandler(this.ImgViewPictureBox_Click);
            // 
            // OCButton
            // 
            this.OCButton.BackgroundImage = global::Blogz.Properties.Resources.IconClosed;
            this.OCButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OCButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.OCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OCButton.Location = new System.Drawing.Point(191, 128);
            this.OCButton.Name = "OCButton";
            this.OCButton.Size = new System.Drawing.Size(25, 25);
            this.OCButton.TabIndex = 3;
            this.OCButton.UseVisualStyleBackColor = true;
            this.OCButton.Click += new System.EventHandler(this.OCButton_Click);
            // 
            // ImgViewTitleLabel
            // 
            this.ImgViewTitleLabel.AutoSize = true;
            this.ImgViewTitleLabel.Location = new System.Drawing.Point(5, 162);
            this.ImgViewTitleLabel.Name = "ImgViewTitleLabel";
            this.ImgViewTitleLabel.Size = new System.Drawing.Size(30, 13);
            this.ImgViewTitleLabel.TabIndex = 4;
            this.ImgViewTitleLabel.Text = "Title:";
            // 
            // ImgViewCreatorLabel
            // 
            this.ImgViewCreatorLabel.AutoSize = true;
            this.ImgViewCreatorLabel.Location = new System.Drawing.Point(5, 175);
            this.ImgViewCreatorLabel.Name = "ImgViewCreatorLabel";
            this.ImgViewCreatorLabel.Size = new System.Drawing.Size(44, 13);
            this.ImgViewCreatorLabel.TabIndex = 5;
            this.ImgViewCreatorLabel.Text = "Creator:";
            // 
            // ImgViewCreationLabel
            // 
            this.ImgViewCreationLabel.AutoSize = true;
            this.ImgViewCreationLabel.Location = new System.Drawing.Point(5, 188);
            this.ImgViewCreationLabel.Name = "ImgViewCreationLabel";
            this.ImgViewCreationLabel.Size = new System.Drawing.Size(49, 13);
            this.ImgViewCreationLabel.TabIndex = 6;
            this.ImgViewCreationLabel.Text = "Creation:";
            // 
            // ImgViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.Controls.Add(this.ImgViewCreationLabel);
            this.Controls.Add(this.ImgViewCreatorLabel);
            this.Controls.Add(this.ImgViewTitleLabel);
            this.Controls.Add(this.OCButton);
            this.Controls.Add(this.ImgViewCheckBox);
            this.Controls.Add(this.ImgViewPictureBox);
            this.Name = "ImgViewControl";
            this.Size = new System.Drawing.Size(219, 207);
            ((System.ComponentModel.ISupportInitialize)(this.ImgViewPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgViewPictureBox;
        private System.Windows.Forms.CheckBox ImgViewCheckBox;
        private System.Windows.Forms.Button OCButton;
        private System.Windows.Forms.Label ImgViewTitleLabel;
        private System.Windows.Forms.Label ImgViewCreatorLabel;
        private System.Windows.Forms.Label ImgViewCreationLabel;
    }
}
