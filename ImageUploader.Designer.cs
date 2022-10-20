namespace Blogz
{
    partial class ImageUploader
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
            this.ChooseFileButton = new System.Windows.Forms.Button();
            this.PathLabel = new System.Windows.Forms.Label();
            this.DisplayTlabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CreatorLabel = new System.Windows.Forms.Label();
            this.CreationLabel = new System.Windows.Forms.Label();
            this.DisplayTtxtBox = new System.Windows.Forms.TextBox();
            this.TitleTxtBox = new System.Windows.Forms.TextBox();
            this.CreatorTxtBox = new System.Windows.Forms.TextBox();
            this.CreationTxtBox = new System.Windows.Forms.TextBox();
            this.UploadButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChooseFileButton
            // 
            this.ChooseFileButton.Location = new System.Drawing.Point(12, 12);
            this.ChooseFileButton.Name = "ChooseFileButton";
            this.ChooseFileButton.Size = new System.Drawing.Size(89, 23);
            this.ChooseFileButton.TabIndex = 0;
            this.ChooseFileButton.TabStop = false;
            this.ChooseFileButton.Text = "Choose a File";
            this.ChooseFileButton.UseVisualStyleBackColor = true;
            this.ChooseFileButton.Click += new System.EventHandler(this.ChooseFileButton_Click);
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(107, 17);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(32, 13);
            this.PathLabel.TabIndex = 1;
            this.PathLabel.Text = "Path:";
            // 
            // DisplayTlabel
            // 
            this.DisplayTlabel.AutoSize = true;
            this.DisplayTlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTlabel.Location = new System.Drawing.Point(12, 53);
            this.DisplayTlabel.Name = "DisplayTlabel";
            this.DisplayTlabel.Size = new System.Drawing.Size(76, 15);
            this.DisplayTlabel.TabIndex = 2;
            this.DisplayTlabel.Text = "DisplayText: ";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(52, 83);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(36, 15);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Title: ";
            // 
            // CreatorLabel
            // 
            this.CreatorLabel.AutoSize = true;
            this.CreatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatorLabel.Location = new System.Drawing.Point(35, 105);
            this.CreatorLabel.Name = "CreatorLabel";
            this.CreatorLabel.Size = new System.Drawing.Size(53, 15);
            this.CreatorLabel.TabIndex = 4;
            this.CreatorLabel.Text = "Creator: ";
            // 
            // CreationLabel
            // 
            this.CreationLabel.AutoSize = true;
            this.CreationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreationLabel.Location = new System.Drawing.Point(29, 131);
            this.CreationLabel.Name = "CreationLabel";
            this.CreationLabel.Size = new System.Drawing.Size(59, 15);
            this.CreationLabel.TabIndex = 5;
            this.CreationLabel.Text = "Creation: ";
            // 
            // DisplayTtxtBox
            // 
            this.DisplayTtxtBox.Location = new System.Drawing.Point(94, 52);
            this.DisplayTtxtBox.Name = "DisplayTtxtBox";
            this.DisplayTtxtBox.Size = new System.Drawing.Size(259, 20);
            this.DisplayTtxtBox.TabIndex = 6;
            this.DisplayTtxtBox.TabStop = false;
            // 
            // TitleTxtBox
            // 
            this.TitleTxtBox.Location = new System.Drawing.Point(95, 78);
            this.TitleTxtBox.Name = "TitleTxtBox";
            this.TitleTxtBox.Size = new System.Drawing.Size(259, 20);
            this.TitleTxtBox.TabIndex = 7;
            this.TitleTxtBox.TabStop = false;
            // 
            // CreatorTxtBox
            // 
            this.CreatorTxtBox.Location = new System.Drawing.Point(94, 104);
            this.CreatorTxtBox.Name = "CreatorTxtBox";
            this.CreatorTxtBox.Size = new System.Drawing.Size(259, 20);
            this.CreatorTxtBox.TabIndex = 8;
            this.CreatorTxtBox.TabStop = false;
            // 
            // CreationTxtBox
            // 
            this.CreationTxtBox.Location = new System.Drawing.Point(94, 130);
            this.CreationTxtBox.Name = "CreationTxtBox";
            this.CreationTxtBox.Size = new System.Drawing.Size(259, 20);
            this.CreationTxtBox.TabIndex = 9;
            this.CreationTxtBox.TabStop = false;
            // 
            // UploadButton
            // 
            this.UploadButton.Location = new System.Drawing.Point(278, 156);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(75, 23);
            this.UploadButton.TabIndex = 99;
            this.UploadButton.TabStop = false;
            this.UploadButton.Text = "Upload";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(197, 156);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.TabStop = false;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ImageUploader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 186);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.CreationTxtBox);
            this.Controls.Add(this.CreatorTxtBox);
            this.Controls.Add(this.TitleTxtBox);
            this.Controls.Add(this.DisplayTtxtBox);
            this.Controls.Add(this.CreationLabel);
            this.Controls.Add(this.CreatorLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.DisplayTlabel);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.ChooseFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImageUploader";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ImageUploader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseFileButton;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Label DisplayTlabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CreatorLabel;
        private System.Windows.Forms.Label CreationLabel;
        private System.Windows.Forms.TextBox DisplayTtxtBox;
        private System.Windows.Forms.TextBox TitleTxtBox;
        private System.Windows.Forms.TextBox CreatorTxtBox;
        private System.Windows.Forms.TextBox CreationTxtBox;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.Button CancelButton;
    }
}