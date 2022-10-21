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
            this.ImgManagerButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BlogView = new System.Windows.Forms.TabPage();
            this.DescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.LinksPanel = new System.Windows.Forms.FlowLayoutPanel();
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
            this.ImagesView = new System.Windows.Forms.TabPage();
            this.ImgUploadButton = new System.Windows.Forms.Button();
            this.ImgViewDeleteButton = new System.Windows.Forms.Button();
            this.ImgViewSelectedCount = new System.Windows.Forms.Label();
            this.ImgViewFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CategoryCreateButton = new System.Windows.Forms.Button();
            this.RemovePictureButton = new Blogz.CustomButton();
            this.AddPictureButton = new Blogz.CustomButton();
            this.BackButton = new Blogz.CustomButton();
            this.ImgViewBackButton = new Blogz.CustomButton();
            this.CategoryDeleteButton = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.MainView.SuspendLayout();
            this.BlogView.SuspendLayout();
            this.PicturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ImagesView.SuspendLayout();
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
            this.TabControl.Controls.Add(this.ImagesView);
            this.TabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(788, 460);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl.TabIndex = 1;
            // 
            // MainView
            // 
            this.MainView.Controls.Add(this.CategoryDeleteButton);
            this.MainView.Controls.Add(this.CategoryCreateButton);
            this.MainView.Controls.Add(this.ImgManagerButton);
            this.MainView.Controls.Add(this.ExitButton);
            this.MainView.Controls.Add(this.CategoryFlowPanel);
            this.MainView.Location = new System.Drawing.Point(4, 5);
            this.MainView.Name = "MainView";
            this.MainView.Padding = new System.Windows.Forms.Padding(3);
            this.MainView.Size = new System.Drawing.Size(780, 451);
            this.MainView.TabIndex = 0;
            this.MainView.Text = "tabPage1";
            this.MainView.UseVisualStyleBackColor = true;
            // 
            // ImgManagerButton
            // 
            this.ImgManagerButton.Location = new System.Drawing.Point(667, 7);
            this.ImgManagerButton.Name = "ImgManagerButton";
            this.ImgManagerButton.Size = new System.Drawing.Size(97, 23);
            this.ImgManagerButton.TabIndex = 3;
            this.ImgManagerButton.Text = "Manage Images";
            this.ImgManagerButton.UseVisualStyleBackColor = true;
            this.ImgManagerButton.Click += new System.EventHandler(this.ImgManagerButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(667, 422);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(97, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BlogView
            // 
            this.BlogView.BackColor = System.Drawing.Color.LightSlateGray;
            this.BlogView.Controls.Add(this.RemovePictureButton);
            this.BlogView.Controls.Add(this.AddPictureButton);
            this.BlogView.Controls.Add(this.DescriptionTxtBox);
            this.BlogView.Controls.Add(this.LinksPanel);
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
            this.BlogView.Size = new System.Drawing.Size(780, 451);
            this.BlogView.TabIndex = 1;
            this.BlogView.Text = "tabPage2";
            // 
            // DescriptionTxtBox
            // 
            this.DescriptionTxtBox.Location = new System.Drawing.Point(11, 72);
            this.DescriptionTxtBox.Name = "DescriptionTxtBox";
            this.DescriptionTxtBox.Size = new System.Drawing.Size(612, 20);
            this.DescriptionTxtBox.TabIndex = 17;
            this.DescriptionTxtBox.TabStop = false;
            // 
            // LinksPanel
            // 
            this.LinksPanel.AutoScroll = true;
            this.LinksPanel.BackColor = System.Drawing.Color.White;
            this.LinksPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LinksPanel.Location = new System.Drawing.Point(634, 30);
            this.LinksPanel.Name = "LinksPanel";
            this.LinksPanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LinksPanel.Size = new System.Drawing.Size(140, 145);
            this.LinksPanel.TabIndex = 15;
            // 
            // LinksPanelLabel
            // 
            this.LinksPanelLabel.AutoSize = true;
            this.LinksPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinksPanelLabel.Location = new System.Drawing.Point(629, 10);
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
            this.BlogContentTxtBox.Location = new System.Drawing.Point(8, 91);
            this.BlogContentTxtBox.Name = "BlogContentTxtBox";
            this.BlogContentTxtBox.Size = new System.Drawing.Size(615, 357);
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
            this.CreatorTxtBox.Size = new System.Drawing.Size(389, 21);
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
            this.TitleTxtBox.Size = new System.Drawing.Size(615, 35);
            this.TitleTxtBox.TabIndex = 2;
            this.TitleTxtBox.TabStop = false;
            // 
            // ImagesView
            // 
            this.ImagesView.BackColor = System.Drawing.SystemColors.Control;
            this.ImagesView.Controls.Add(this.ImgUploadButton);
            this.ImagesView.Controls.Add(this.ImgViewDeleteButton);
            this.ImagesView.Controls.Add(this.ImgViewSelectedCount);
            this.ImagesView.Controls.Add(this.ImgViewFlowPanel);
            this.ImagesView.Controls.Add(this.ImgViewBackButton);
            this.ImagesView.Location = new System.Drawing.Point(4, 5);
            this.ImagesView.Name = "ImagesView";
            this.ImagesView.Size = new System.Drawing.Size(780, 451);
            this.ImagesView.TabIndex = 2;
            this.ImagesView.Text = "tabPage1";
            // 
            // ImgUploadButton
            // 
            this.ImgUploadButton.Location = new System.Drawing.Point(696, 75);
            this.ImgUploadButton.Name = "ImgUploadButton";
            this.ImgUploadButton.Size = new System.Drawing.Size(75, 23);
            this.ImgUploadButton.TabIndex = 21;
            this.ImgUploadButton.Text = "Upload";
            this.ImgUploadButton.UseVisualStyleBackColor = true;
            this.ImgUploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // ImgViewDeleteButton
            // 
            this.ImgViewDeleteButton.Enabled = false;
            this.ImgViewDeleteButton.Location = new System.Drawing.Point(696, 29);
            this.ImgViewDeleteButton.Name = "ImgViewDeleteButton";
            this.ImgViewDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.ImgViewDeleteButton.TabIndex = 20;
            this.ImgViewDeleteButton.Text = "Delete";
            this.ImgViewDeleteButton.UseVisualStyleBackColor = true;
            this.ImgViewDeleteButton.Click += new System.EventHandler(this.ImgViewDeleteButton_Click);
            // 
            // ImgViewSelectedCount
            // 
            this.ImgViewSelectedCount.AutoSize = true;
            this.ImgViewSelectedCount.Location = new System.Drawing.Point(685, 4);
            this.ImgViewSelectedCount.Name = "ImgViewSelectedCount";
            this.ImgViewSelectedCount.Size = new System.Drawing.Size(95, 13);
            this.ImgViewSelectedCount.TabIndex = 19;
            this.ImgViewSelectedCount.Text = "0 Images Selected";
            // 
            // ImgViewFlowPanel
            // 
            this.ImgViewFlowPanel.AutoScroll = true;
            this.ImgViewFlowPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ImgViewFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.ImgViewFlowPanel.Name = "ImgViewFlowPanel";
            this.ImgViewFlowPanel.Size = new System.Drawing.Size(679, 451);
            this.ImgViewFlowPanel.TabIndex = 18;
            // 
            // CategoryCreateButton
            // 
            this.CategoryCreateButton.Location = new System.Drawing.Point(667, 36);
            this.CategoryCreateButton.Name = "CategoryCreateButton";
            this.CategoryCreateButton.Size = new System.Drawing.Size(97, 23);
            this.CategoryCreateButton.TabIndex = 4;
            this.CategoryCreateButton.Text = "Create Category";
            this.CategoryCreateButton.UseVisualStyleBackColor = true;
            this.CategoryCreateButton.Click += new System.EventHandler(this.CategoryCreateButton_Click);
            // 
            // RemovePictureButton
            // 
            this.RemovePictureButton.BlogID = null;
            this.RemovePictureButton.CategoryID = null;
            this.RemovePictureButton.ClickState = Blogz.ClickState.Delete;
            this.RemovePictureButton.Location = new System.Drawing.Point(707, 178);
            this.RemovePictureButton.Name = "RemovePictureButton";
            this.RemovePictureButton.Size = new System.Drawing.Size(67, 23);
            this.RemovePictureButton.TabIndex = 20;
            this.RemovePictureButton.Text = "Remove";
            this.RemovePictureButton.UseVisualStyleBackColor = true;
            this.RemovePictureButton.Click += new System.EventHandler(this.BlogViewPictureManager_Click);
            // 
            // AddPictureButton
            // 
            this.AddPictureButton.BlogID = null;
            this.AddPictureButton.CategoryID = null;
            this.AddPictureButton.ClickState = Blogz.ClickState.Open;
            this.AddPictureButton.Location = new System.Drawing.Point(634, 178);
            this.AddPictureButton.Name = "AddPictureButton";
            this.AddPictureButton.Size = new System.Drawing.Size(67, 23);
            this.AddPictureButton.TabIndex = 19;
            this.AddPictureButton.Text = "Add";
            this.AddPictureButton.UseVisualStyleBackColor = true;
            this.AddPictureButton.Click += new System.EventHandler(this.BlogViewPictureManager_Click);
            // 
            // BackButton
            // 
            this.BackButton.BlogID = "Blog0000";
            this.BackButton.CategoryID = "Category0000";
            this.BackButton.ClickState = Blogz.ClickState.Open;
            this.BackButton.Location = new System.Drawing.Point(699, 420);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 16;
            this.BackButton.TabStop = false;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ImgViewBackButton
            // 
            this.ImgViewBackButton.BlogID = "Blog0000";
            this.ImgViewBackButton.CategoryID = "Category0000";
            this.ImgViewBackButton.ClickState = Blogz.ClickState.Open;
            this.ImgViewBackButton.Location = new System.Drawing.Point(696, 420);
            this.ImgViewBackButton.Name = "ImgViewBackButton";
            this.ImgViewBackButton.Size = new System.Drawing.Size(75, 23);
            this.ImgViewBackButton.TabIndex = 17;
            this.ImgViewBackButton.TabStop = false;
            this.ImgViewBackButton.Text = "Back";
            this.ImgViewBackButton.UseVisualStyleBackColor = true;
            this.ImgViewBackButton.Click += new System.EventHandler(this.ImgViewBackButton_Click);
            // 
            // CategoryDeleteButton
            // 
            this.CategoryDeleteButton.Location = new System.Drawing.Point(667, 65);
            this.CategoryDeleteButton.Name = "CategoryDeleteButton";
            this.CategoryDeleteButton.Size = new System.Drawing.Size(97, 23);
            this.CategoryDeleteButton.TabIndex = 5;
            this.CategoryDeleteButton.Text = "Delete Category";
            this.CategoryDeleteButton.UseVisualStyleBackColor = true;
            this.CategoryDeleteButton.Click += new System.EventHandler(this.CategoryDeleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 460);
            this.Controls.Add(this.TabControl);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.TabControl.ResumeLayout(false);
            this.MainView.ResumeLayout(false);
            this.BlogView.ResumeLayout(false);
            this.BlogView.PerformLayout();
            this.PicturePanel.ResumeLayout(false);
            this.PicturePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ImagesView.ResumeLayout(false);
            this.ImagesView.PerformLayout();
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
        private System.Windows.Forms.FlowLayoutPanel LinksPanel;
        private CustomButton BackButton;
        private System.Windows.Forms.TextBox DescriptionTxtBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ImgManagerButton;
        private System.Windows.Forms.TabPage ImagesView;
        private CustomButton ImgViewBackButton;
        private System.Windows.Forms.FlowLayoutPanel ImgViewFlowPanel;
        private System.Windows.Forms.Label ImgViewSelectedCount;
        private System.Windows.Forms.Button ImgViewDeleteButton;
        private System.Windows.Forms.Button ImgUploadButton;
        private CustomButton AddPictureButton;
        private CustomButton RemovePictureButton;
        private System.Windows.Forms.Button CategoryCreateButton;
        private System.Windows.Forms.Button CategoryDeleteButton;
    }
}

