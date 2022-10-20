namespace Blogz
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
            this.CategoryFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.MainView = new System.Windows.Forms.TabPage();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BlogView = new System.Windows.Forms.TabPage();
            this.DescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.LinksPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.RemovePictureButton = new System.Windows.Forms.Button();
            this.AddPictureButton = new System.Windows.Forms.Button();
            this.LinksPanelLabel = new System.Windows.Forms.Label();
            this.PicturePanel = new System.Windows.Forms.Panel();
            this.PictureCreatorLabel = new System.Windows.Forms.Label();
            this.PictureCdateLabel = new System.Windows.Forms.Label();
            this.PictureTitleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BlogContentTxtBox = new System.Windows.Forms.RichTextBox();
            this.CreationLBL = new System.Windows.Forms.Label();
            this.AuthorLBL = new System.Windows.Forms.Label();
            this.MinusLabel = new System.Windows.Forms.Label();
            this.CreatorTxtBox = new System.Windows.Forms.TextBox();
            this.CreationDateTxtBox = new System.Windows.Forms.TextBox();
            this.TitleTxtBox = new System.Windows.Forms.TextBox();
            this.UploadButton = new System.Windows.Forms.Button();
            this.BackButton = new Blogz.CustomButton();
            this.TabControl.SuspendLayout();
            this.MainView.SuspendLayout();
            this.BlogView.SuspendLayout();
            this.PicturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryFlowPanel
            // 
            this.CategoryFlowPanel.AutoScroll = true;
            this.CategoryFlowPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CategoryFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.CategoryFlowPanel.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.CategoryFlowPanel.MinimumSize = new System.Drawing.Size(655, 450);
            this.CategoryFlowPanel.Name = "CategoryFlowPanel";
            this.CategoryFlowPanel.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.CategoryFlowPanel.Size = new System.Drawing.Size(655, 451);
            this.CategoryFlowPanel.TabIndex = 0;
            // 
            // TabControl
            // 
            this.TabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabControl.Controls.Add(this.MainView);
            this.TabControl.Controls.Add(this.BlogView);
            this.TabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(814, 460);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl.TabIndex = 1;
            // 
            // MainView
            // 
            this.MainView.Controls.Add(this.UploadButton);
            this.MainView.Controls.Add(this.ExitButton);
            this.MainView.Controls.Add(this.CategoryFlowPanel);
            this.MainView.Location = new System.Drawing.Point(4, 5);
            this.MainView.Name = "MainView";
            this.MainView.Padding = new System.Windows.Forms.Padding(3);
            this.MainView.Size = new System.Drawing.Size(806, 451);
            this.MainView.TabIndex = 0;
            this.MainView.Text = "tabPage1";
            this.MainView.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(661, 422);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BlogView
            // 
            this.BlogView.BackColor = System.Drawing.Color.LightSlateGray;
            this.BlogView.Controls.Add(this.DescriptionTxtBox);
            this.BlogView.Controls.Add(this.LinksPanel);
            this.BlogView.Controls.Add(this.RemovePictureButton);
            this.BlogView.Controls.Add(this.AddPictureButton);
            this.BlogView.Controls.Add(this.LinksPanelLabel);
            this.BlogView.Controls.Add(this.PicturePanel);
            this.BlogView.Controls.Add(this.BlogContentTxtBox);
            this.BlogView.Controls.Add(this.CreationLBL);
            this.BlogView.Controls.Add(this.AuthorLBL);
            this.BlogView.Controls.Add(this.MinusLabel);
            this.BlogView.Controls.Add(this.CreatorTxtBox);
            this.BlogView.Controls.Add(this.CreationDateTxtBox);
            this.BlogView.Controls.Add(this.TitleTxtBox);
            this.BlogView.Controls.Add(this.BackButton);
            this.BlogView.Location = new System.Drawing.Point(4, 5);
            this.BlogView.Name = "BlogView";
            this.BlogView.Padding = new System.Windows.Forms.Padding(3);
            this.BlogView.Size = new System.Drawing.Size(806, 451);
            this.BlogView.TabIndex = 1;
            this.BlogView.Text = "tabPage2";
            // 
            // DescriptionTxtBox
            // 
            this.DescriptionTxtBox.Location = new System.Drawing.Point(11, 72);
            this.DescriptionTxtBox.Name = "DescriptionTxtBox";
            this.DescriptionTxtBox.Size = new System.Drawing.Size(632, 20);
            this.DescriptionTxtBox.TabIndex = 17;
            this.DescriptionTxtBox.TabStop = false;
            // 
            // LinksPanel
            // 
            this.LinksPanel.AutoScroll = true;
            this.LinksPanel.BackColor = System.Drawing.Color.White;
            this.LinksPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LinksPanel.Location = new System.Drawing.Point(650, 30);
            this.LinksPanel.Name = "LinksPanel";
            this.LinksPanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LinksPanel.Size = new System.Drawing.Size(146, 145);
            this.LinksPanel.TabIndex = 15;
            // 
            // RemovePictureButton
            // 
            this.RemovePictureButton.Location = new System.Drawing.Point(725, 181);
            this.RemovePictureButton.Name = "RemovePictureButton";
            this.RemovePictureButton.Size = new System.Drawing.Size(71, 23);
            this.RemovePictureButton.TabIndex = 14;
            this.RemovePictureButton.TabStop = false;
            this.RemovePictureButton.Text = "Remove";
            this.RemovePictureButton.UseVisualStyleBackColor = true;
            // 
            // AddPictureButton
            // 
            this.AddPictureButton.Location = new System.Drawing.Point(649, 181);
            this.AddPictureButton.Name = "AddPictureButton";
            this.AddPictureButton.Size = new System.Drawing.Size(71, 23);
            this.AddPictureButton.TabIndex = 13;
            this.AddPictureButton.TabStop = false;
            this.AddPictureButton.Text = "Add";
            this.AddPictureButton.UseVisualStyleBackColor = true;
            // 
            // LinksPanelLabel
            // 
            this.LinksPanelLabel.AutoSize = true;
            this.LinksPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinksPanelLabel.Location = new System.Drawing.Point(649, 9);
            this.LinksPanelLabel.Name = "LinksPanelLabel";
            this.LinksPanelLabel.Size = new System.Drawing.Size(59, 17);
            this.LinksPanelLabel.TabIndex = 0;
            this.LinksPanelLabel.Text = "Pictures";
            // 
            // PicturePanel
            // 
            this.PicturePanel.BackColor = System.Drawing.Color.White;
            this.PicturePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicturePanel.Controls.Add(this.PictureCreatorLabel);
            this.PicturePanel.Controls.Add(this.PictureCdateLabel);
            this.PicturePanel.Controls.Add(this.PictureTitleLabel);
            this.PicturePanel.Controls.Add(this.pictureBox1);
            this.PicturePanel.Location = new System.Drawing.Point(409, 48);
            this.PicturePanel.Name = "PicturePanel";
            this.PicturePanel.Size = new System.Drawing.Size(219, 163);
            this.PicturePanel.TabIndex = 11;
            // 
            // PictureCreatorLabel
            // 
            this.PictureCreatorLabel.AutoSize = true;
            this.PictureCreatorLabel.Location = new System.Drawing.Point(114, 148);
            this.PictureCreatorLabel.Name = "PictureCreatorLabel";
            this.PictureCreatorLabel.Size = new System.Drawing.Size(99, 13);
            this.PictureCreatorLabel.TabIndex = 13;
            this.PictureCreatorLabel.Text = "By: Devvvvvvvvvv";
            // 
            // PictureCdateLabel
            // 
            this.PictureCdateLabel.AutoSize = true;
            this.PictureCdateLabel.Location = new System.Drawing.Point(7, 148);
            this.PictureCdateLabel.Name = "PictureCdateLabel";
            this.PictureCdateLabel.Size = new System.Drawing.Size(100, 13);
            this.PictureCdateLabel.TabIndex = 12;
            this.PictureCdateLabel.Text = "Creation: 00.00.000";
            // 
            // PictureTitleLabel
            // 
            this.PictureTitleLabel.Location = new System.Drawing.Point(7, 133);
            this.PictureTitleLabel.Name = "PictureTitleLabel";
            this.PictureTitleLabel.Size = new System.Drawing.Size(208, 15);
            this.PictureTitleLabel.TabIndex = 11;
            this.PictureTitleLabel.Text = "Title";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 125);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // BlogContentTxtBox
            // 
            this.BlogContentTxtBox.Location = new System.Drawing.Point(8, 98);
            this.BlogContentTxtBox.Name = "BlogContentTxtBox";
            this.BlogContentTxtBox.Size = new System.Drawing.Size(635, 350);
            this.BlogContentTxtBox.TabIndex = 9;
            this.BlogContentTxtBox.TabStop = false;
            this.BlogContentTxtBox.Text = "";
            // 
            // CreationLBL
            // 
            this.CreationLBL.AutoSize = true;
            this.CreationLBL.Location = new System.Drawing.Point(8, 52);
            this.CreationLBL.Name = "CreationLBL";
            this.CreationLBL.Size = new System.Drawing.Size(75, 13);
            this.CreationLBL.TabIndex = 7;
            this.CreationLBL.Text = "Creation Date:";
            // 
            // AuthorLBL
            // 
            this.AuthorLBL.AutoSize = true;
            this.AuthorLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLBL.Location = new System.Drawing.Point(179, 50);
            this.AuthorLBL.Name = "AuthorLBL";
            this.AuthorLBL.Size = new System.Drawing.Size(45, 15);
            this.AuthorLBL.TabIndex = 6;
            this.AuthorLBL.Text = "Author:";
            // 
            // MinusLabel
            // 
            this.MinusLabel.AutoSize = true;
            this.MinusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusLabel.Location = new System.Drawing.Point(162, 50);
            this.MinusLabel.Name = "MinusLabel";
            this.MinusLabel.Size = new System.Drawing.Size(11, 15);
            this.MinusLabel.TabIndex = 5;
            this.MinusLabel.Text = "-";
            // 
            // CreatorTxtBox
            // 
            this.CreatorTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatorTxtBox.Location = new System.Drawing.Point(234, 50);
            this.CreatorTxtBox.Name = "CreatorTxtBox";
            this.CreatorTxtBox.Size = new System.Drawing.Size(409, 21);
            this.CreatorTxtBox.TabIndex = 4;
            this.CreatorTxtBox.TabStop = false;
            this.CreatorTxtBox.Text = "Dev";
            // 
            // CreationDateTxtBox
            // 
            this.CreationDateTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreationDateTxtBox.Location = new System.Drawing.Point(87, 50);
            this.CreationDateTxtBox.Name = "CreationDateTxtBox";
            this.CreationDateTxtBox.Size = new System.Drawing.Size(73, 21);
            this.CreationDateTxtBox.TabIndex = 3;
            this.CreationDateTxtBox.TabStop = false;
            this.CreationDateTxtBox.Text = "00.00.0000";
            // 
            // TitleTxtBox
            // 
            this.TitleTxtBox.BackColor = System.Drawing.Color.White;
            this.TitleTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTxtBox.Location = new System.Drawing.Point(8, 7);
            this.TitleTxtBox.Name = "TitleTxtBox";
            this.TitleTxtBox.Size = new System.Drawing.Size(635, 35);
            this.TitleTxtBox.TabIndex = 2;
            this.TitleTxtBox.TabStop = false;
            // 
            // UploadButton
            // 
            this.UploadButton.Location = new System.Drawing.Point(661, 7);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(97, 23);
            this.UploadButton.TabIndex = 2;
            this.UploadButton.Text = "Upload Images";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BlogID = "Blog0000";
            this.BackButton.CategoryID = "Category0000";
            this.BackButton.ClickState = Blogz.ClickState.Open;
            this.BackButton.Location = new System.Drawing.Point(721, 420);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 16;
            this.BackButton.TabStop = false;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 460);
            this.Controls.Add(this.TabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabControl.ResumeLayout(false);
            this.MainView.ResumeLayout(false);
            this.BlogView.ResumeLayout(false);
            this.BlogView.PerformLayout();
            this.PicturePanel.ResumeLayout(false);
            this.PicturePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel CategoryFlowPanel;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage MainView;
        private System.Windows.Forms.TabPage BlogView;
        private System.Windows.Forms.TextBox TitleTxtBox;
        private System.Windows.Forms.TextBox CreationDateTxtBox;
        private System.Windows.Forms.TextBox CreatorTxtBox;
        private System.Windows.Forms.Label MinusLabel;
        private System.Windows.Forms.Label AuthorLBL;
        private System.Windows.Forms.Label CreationLBL;
        private System.Windows.Forms.RichTextBox BlogContentTxtBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PicturePanel;
        private System.Windows.Forms.Label PictureTitleLabel;
        private System.Windows.Forms.Label PictureCdateLabel;
        private System.Windows.Forms.Label PictureCreatorLabel;
        private System.Windows.Forms.Label LinksPanelLabel;
        private System.Windows.Forms.Button AddPictureButton;
        private System.Windows.Forms.Button RemovePictureButton;
        private System.Windows.Forms.FlowLayoutPanel LinksPanel;
        private CustomButton BackButton;
        private System.Windows.Forms.TextBox DescriptionTxtBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button UploadButton;
    }
}

