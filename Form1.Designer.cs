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
            this.CategoryDeleteButton = new System.Windows.Forms.Button();
            this.CategoryCreateButton = new System.Windows.Forms.Button();
            this.ImgManagerButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BlogView = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BlogContentTxtBox = new System.Windows.Forms.RichTextBox();
            this.DescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.CreatorTxtBox = new System.Windows.Forms.TextBox();
            this.AuthorLBL = new System.Windows.Forms.Label();
            this.CreationDateTxtBox = new System.Windows.Forms.TextBox();
            this.MinusLabel = new System.Windows.Forms.Label();
            this.TitleTxtBox = new System.Windows.Forms.TextBox();
            this.CreationLBL = new System.Windows.Forms.Label();
            this.LinksPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LinksPanelLabel = new System.Windows.Forms.Label();
            this.PicturePanel = new System.Windows.Forms.Panel();
            this.PictureCreatorLabel = new System.Windows.Forms.Label();
            this.PictureCdateLabel = new System.Windows.Forms.Label();
            this.PictureTitleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ImagesView = new System.Windows.Forms.TabPage();
            this.ImgUploadButton = new System.Windows.Forms.Button();
            this.ImgViewDeleteButton = new System.Windows.Forms.Button();
            this.ImgViewSelectedCount = new System.Windows.Forms.Label();
            this.ImgViewFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PathChooseButton = new System.Windows.Forms.Button();
            this.BackupButton = new System.Windows.Forms.Button();
            this.LoadBackupButton = new System.Windows.Forms.Button();
            this.CreateBlogButton = new Blogz.CustomButton();
            this.RemovePictureButton = new Blogz.CustomButton();
            this.AddPictureButton = new Blogz.CustomButton();
            this.BackButton = new Blogz.CustomButton();
            this.ImgViewBackButton = new Blogz.CustomButton();
            this.RenameCatButton = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.MainView.SuspendLayout();
            this.BlogView.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PicturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ImagesView.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoryFlowPanel
            // 
            this.CategoryFlowPanel.AutoScroll = true;
            this.CategoryFlowPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.CategoryFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.CategoryFlowPanel.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.CategoryFlowPanel.MinimumSize = new System.Drawing.Size(645, 450);
            this.CategoryFlowPanel.Name = "CategoryFlowPanel";
            this.CategoryFlowPanel.Padding = new System.Windows.Forms.Padding(3, 5, 0, 5);
            this.CategoryFlowPanel.Size = new System.Drawing.Size(645, 450);
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
            this.MainView.BackColor = System.Drawing.Color.CornflowerBlue;
            this.MainView.Controls.Add(this.RenameCatButton);
            this.MainView.Controls.Add(this.LoadBackupButton);
            this.MainView.Controls.Add(this.BackupButton);
            this.MainView.Controls.Add(this.PathChooseButton);
            this.MainView.Controls.Add(this.CreateBlogButton);
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
            // 
            // CategoryDeleteButton
            // 
            this.CategoryDeleteButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CategoryDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryDeleteButton.Location = new System.Drawing.Point(661, 123);
            this.CategoryDeleteButton.Name = "CategoryDeleteButton";
            this.CategoryDeleteButton.Size = new System.Drawing.Size(103, 23);
            this.CategoryDeleteButton.TabIndex = 5;
            this.CategoryDeleteButton.Text = "Delete Category";
            this.CategoryDeleteButton.UseVisualStyleBackColor = false;
            this.CategoryDeleteButton.Click += new System.EventHandler(this.CategoryDeleteButton_Click);
            // 
            // CategoryCreateButton
            // 
            this.CategoryCreateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(237)))));
            this.CategoryCreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryCreateButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CategoryCreateButton.Location = new System.Drawing.Point(661, 36);
            this.CategoryCreateButton.Name = "CategoryCreateButton";
            this.CategoryCreateButton.Size = new System.Drawing.Size(103, 23);
            this.CategoryCreateButton.TabIndex = 4;
            this.CategoryCreateButton.Text = "Create Category";
            this.CategoryCreateButton.UseVisualStyleBackColor = false;
            this.CategoryCreateButton.Click += new System.EventHandler(this.CategoryCreateButton_Click);
            // 
            // ImgManagerButton
            // 
            this.ImgManagerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(237)))));
            this.ImgManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImgManagerButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ImgManagerButton.Location = new System.Drawing.Point(661, 65);
            this.ImgManagerButton.Name = "ImgManagerButton";
            this.ImgManagerButton.Size = new System.Drawing.Size(103, 23);
            this.ImgManagerButton.TabIndex = 3;
            this.ImgManagerButton.Text = "Manage Images";
            this.ImgManagerButton.UseVisualStyleBackColor = false;
            this.ImgManagerButton.Click += new System.EventHandler(this.ImgManagerButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.SystemColors.Window;
            this.ExitButton.Location = new System.Drawing.Point(661, 420);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(103, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BlogView
            // 
            this.BlogView.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BlogView.Controls.Add(this.panel1);
            this.BlogView.Controls.Add(this.LinksPanel);
            this.BlogView.Controls.Add(this.LinksPanelLabel);
            this.BlogView.Controls.Add(this.PicturePanel);
            this.BlogView.Controls.Add(this.RemovePictureButton);
            this.BlogView.Controls.Add(this.AddPictureButton);
            this.BlogView.Controls.Add(this.BackButton);
            this.BlogView.Location = new System.Drawing.Point(4, 5);
            this.BlogView.Name = "BlogView";
            this.BlogView.Padding = new System.Windows.Forms.Padding(3);
            this.BlogView.Size = new System.Drawing.Size(780, 451);
            this.BlogView.TabIndex = 1;
            this.BlogView.Text = "tabPage2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.BlogContentTxtBox);
            this.panel1.Controls.Add(this.DescriptionTxtBox);
            this.panel1.Controls.Add(this.CreatorTxtBox);
            this.panel1.Controls.Add(this.AuthorLBL);
            this.panel1.Controls.Add(this.CreationDateTxtBox);
            this.panel1.Controls.Add(this.MinusLabel);
            this.panel1.Controls.Add(this.TitleTxtBox);
            this.panel1.Controls.Add(this.CreationLBL);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 450);
            this.panel1.TabIndex = 21;
            // 
            // BlogContentTxtBox
            // 
            this.BlogContentTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BlogContentTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlogContentTxtBox.Location = new System.Drawing.Point(3, 86);
            this.BlogContentTxtBox.Name = "BlogContentTxtBox";
            this.BlogContentTxtBox.Size = new System.Drawing.Size(615, 364);
            this.BlogContentTxtBox.TabIndex = 9;
            this.BlogContentTxtBox.TabStop = false;
            this.BlogContentTxtBox.Text = "";
            // 
            // DescriptionTxtBox
            // 
            this.DescriptionTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTxtBox.Location = new System.Drawing.Point(3, 60);
            this.DescriptionTxtBox.Name = "DescriptionTxtBox";
            this.DescriptionTxtBox.Size = new System.Drawing.Size(615, 20);
            this.DescriptionTxtBox.TabIndex = 17;
            this.DescriptionTxtBox.TabStop = false;
            // 
            // CreatorTxtBox
            // 
            this.CreatorTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatorTxtBox.Location = new System.Drawing.Point(229, 39);
            this.CreatorTxtBox.Name = "CreatorTxtBox";
            this.CreatorTxtBox.Size = new System.Drawing.Size(389, 21);
            this.CreatorTxtBox.TabIndex = 4;
            this.CreatorTxtBox.TabStop = false;
            this.CreatorTxtBox.Text = "Dev";
            // 
            // AuthorLBL
            // 
            this.AuthorLBL.AutoSize = true;
            this.AuthorLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLBL.Location = new System.Drawing.Point(178, 39);
            this.AuthorLBL.Name = "AuthorLBL";
            this.AuthorLBL.Size = new System.Drawing.Size(45, 15);
            this.AuthorLBL.TabIndex = 6;
            this.AuthorLBL.Text = "Author:";
            // 
            // CreationDateTxtBox
            // 
            this.CreationDateTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreationDateTxtBox.Location = new System.Drawing.Point(84, 39);
            this.CreationDateTxtBox.Name = "CreationDateTxtBox";
            this.CreationDateTxtBox.Size = new System.Drawing.Size(73, 21);
            this.CreationDateTxtBox.TabIndex = 3;
            this.CreationDateTxtBox.TabStop = false;
            this.CreationDateTxtBox.Text = "00.00.0000";
            // 
            // MinusLabel
            // 
            this.MinusLabel.AutoSize = true;
            this.MinusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusLabel.Location = new System.Drawing.Point(161, 39);
            this.MinusLabel.Name = "MinusLabel";
            this.MinusLabel.Size = new System.Drawing.Size(11, 15);
            this.MinusLabel.TabIndex = 5;
            this.MinusLabel.Text = "-";
            // 
            // TitleTxtBox
            // 
            this.TitleTxtBox.BackColor = System.Drawing.Color.White;
            this.TitleTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTxtBox.Location = new System.Drawing.Point(3, 4);
            this.TitleTxtBox.Name = "TitleTxtBox";
            this.TitleTxtBox.Size = new System.Drawing.Size(615, 35);
            this.TitleTxtBox.TabIndex = 2;
            this.TitleTxtBox.TabStop = false;
            // 
            // CreationLBL
            // 
            this.CreationLBL.AutoSize = true;
            this.CreationLBL.Location = new System.Drawing.Point(3, 41);
            this.CreationLBL.Name = "CreationLBL";
            this.CreationLBL.Size = new System.Drawing.Size(75, 13);
            this.CreationLBL.TabIndex = 7;
            this.CreationLBL.Text = "Creation Date:";
            // 
            // LinksPanel
            // 
            this.LinksPanel.AutoScroll = true;
            this.LinksPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.LinksPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LinksPanel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LinksPanel.Location = new System.Drawing.Point(651, 30);
            this.LinksPanel.Name = "LinksPanel";
            this.LinksPanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LinksPanel.Size = new System.Drawing.Size(123, 145);
            this.LinksPanel.TabIndex = 15;
            // 
            // LinksPanelLabel
            // 
            this.LinksPanelLabel.AutoSize = true;
            this.LinksPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinksPanelLabel.Location = new System.Drawing.Point(648, 10);
            this.LinksPanelLabel.Name = "LinksPanelLabel";
            this.LinksPanelLabel.Size = new System.Drawing.Size(59, 17);
            this.LinksPanelLabel.TabIndex = 0;
            this.LinksPanelLabel.Text = "Pictures";
            // 
            // PicturePanel
            // 
            this.PicturePanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PicturePanel.Controls.Add(this.PictureCreatorLabel);
            this.PicturePanel.Controls.Add(this.PictureCdateLabel);
            this.PicturePanel.Controls.Add(this.PictureTitleLabel);
            this.PicturePanel.Controls.Add(this.pictureBox1);
            this.PicturePanel.Location = new System.Drawing.Point(651, 223);
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
            // ImagesView
            // 
            this.ImagesView.BackColor = System.Drawing.Color.CornflowerBlue;
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
            this.ImgUploadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(237)))));
            this.ImgUploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImgUploadButton.Location = new System.Drawing.Point(662, 7);
            this.ImgUploadButton.Name = "ImgUploadButton";
            this.ImgUploadButton.Size = new System.Drawing.Size(97, 23);
            this.ImgUploadButton.TabIndex = 21;
            this.ImgUploadButton.Text = "Upload";
            this.ImgUploadButton.UseVisualStyleBackColor = false;
            this.ImgUploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // ImgViewDeleteButton
            // 
            this.ImgViewDeleteButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ImgViewDeleteButton.Enabled = false;
            this.ImgViewDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImgViewDeleteButton.Location = new System.Drawing.Point(662, 391);
            this.ImgViewDeleteButton.Name = "ImgViewDeleteButton";
            this.ImgViewDeleteButton.Size = new System.Drawing.Size(97, 23);
            this.ImgViewDeleteButton.TabIndex = 20;
            this.ImgViewDeleteButton.Text = "Delete";
            this.ImgViewDeleteButton.UseVisualStyleBackColor = false;
            this.ImgViewDeleteButton.Click += new System.EventHandler(this.ImgViewDeleteButton_Click);
            // 
            // ImgViewSelectedCount
            // 
            this.ImgViewSelectedCount.AutoSize = true;
            this.ImgViewSelectedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImgViewSelectedCount.Location = new System.Drawing.Point(656, 368);
            this.ImgViewSelectedCount.Name = "ImgViewSelectedCount";
            this.ImgViewSelectedCount.Size = new System.Drawing.Size(109, 15);
            this.ImgViewSelectedCount.TabIndex = 19;
            this.ImgViewSelectedCount.Text = "0 Images Selected";
            // 
            // ImgViewFlowPanel
            // 
            this.ImgViewFlowPanel.AutoScroll = true;
            this.ImgViewFlowPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.ImgViewFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.ImgViewFlowPanel.Name = "ImgViewFlowPanel";
            this.ImgViewFlowPanel.Size = new System.Drawing.Size(645, 450);
            this.ImgViewFlowPanel.TabIndex = 18;
            // 
            // PathChooseButton
            // 
            this.PathChooseButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PathChooseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PathChooseButton.Location = new System.Drawing.Point(661, 391);
            this.PathChooseButton.Name = "PathChooseButton";
            this.PathChooseButton.Size = new System.Drawing.Size(103, 23);
            this.PathChooseButton.TabIndex = 7;
            this.PathChooseButton.Text = "Choose Path";
            this.PathChooseButton.UseVisualStyleBackColor = false;
            this.PathChooseButton.Click += new System.EventHandler(this.PathChooseButton_Click);
            // 
            // BackupButton
            // 
            this.BackupButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackupButton.Location = new System.Drawing.Point(661, 333);
            this.BackupButton.Name = "BackupButton";
            this.BackupButton.Size = new System.Drawing.Size(103, 23);
            this.BackupButton.TabIndex = 8;
            this.BackupButton.Text = "Backup Data";
            this.BackupButton.UseVisualStyleBackColor = false;
            this.BackupButton.Click += new System.EventHandler(this.BackupButton_Click);
            // 
            // LoadBackupButton
            // 
            this.LoadBackupButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LoadBackupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadBackupButton.Location = new System.Drawing.Point(661, 362);
            this.LoadBackupButton.Name = "LoadBackupButton";
            this.LoadBackupButton.Size = new System.Drawing.Size(103, 23);
            this.LoadBackupButton.TabIndex = 9;
            this.LoadBackupButton.Text = "Load Backup";
            this.LoadBackupButton.UseVisualStyleBackColor = false;
            this.LoadBackupButton.Click += new System.EventHandler(this.LoadBackupButton_Click);
            // 
            // CreateBlogButton
            // 
            this.CreateBlogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(237)))));
            this.CreateBlogButton.BlogID = null;
            this.CreateBlogButton.CategoryID = null;
            this.CreateBlogButton.ClickState = Blogz.ClickState.Open;
            this.CreateBlogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateBlogButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CreateBlogButton.Location = new System.Drawing.Point(661, 7);
            this.CreateBlogButton.Name = "CreateBlogButton";
            this.CreateBlogButton.Size = new System.Drawing.Size(103, 23);
            this.CreateBlogButton.TabIndex = 6;
            this.CreateBlogButton.Text = "Create Blog";
            this.CreateBlogButton.UseVisualStyleBackColor = false;
            this.CreateBlogButton.Click += new System.EventHandler(this.CreateBlogButton_Click);
            // 
            // RemovePictureButton
            // 
            this.RemovePictureButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.RemovePictureButton.BlogID = null;
            this.RemovePictureButton.CategoryID = null;
            this.RemovePictureButton.ClickState = Blogz.ClickState.Delete;
            this.RemovePictureButton.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.RemovePictureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemovePictureButton.ForeColor = System.Drawing.SystemColors.Window;
            this.RemovePictureButton.Location = new System.Drawing.Point(713, 178);
            this.RemovePictureButton.Name = "RemovePictureButton";
            this.RemovePictureButton.Size = new System.Drawing.Size(61, 23);
            this.RemovePictureButton.TabIndex = 20;
            this.RemovePictureButton.Text = "Remove";
            this.RemovePictureButton.UseVisualStyleBackColor = false;
            this.RemovePictureButton.Click += new System.EventHandler(this.BlogViewPictureManager_Click);
            // 
            // AddPictureButton
            // 
            this.AddPictureButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.AddPictureButton.BlogID = null;
            this.AddPictureButton.CategoryID = null;
            this.AddPictureButton.ClickState = Blogz.ClickState.Open;
            this.AddPictureButton.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.AddPictureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPictureButton.ForeColor = System.Drawing.SystemColors.Window;
            this.AddPictureButton.Location = new System.Drawing.Point(651, 178);
            this.AddPictureButton.Name = "AddPictureButton";
            this.AddPictureButton.Size = new System.Drawing.Size(61, 23);
            this.AddPictureButton.TabIndex = 19;
            this.AddPictureButton.Text = "Add";
            this.AddPictureButton.UseVisualStyleBackColor = false;
            this.AddPictureButton.Click += new System.EventHandler(this.BlogViewPictureManager_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackButton.BlogID = "Blog0000";
            this.BackButton.CategoryID = "Category0000";
            this.BackButton.ClickState = Blogz.ClickState.Open;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.ForeColor = System.Drawing.SystemColors.Window;
            this.BackButton.Location = new System.Drawing.Point(667, 420);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(97, 23);
            this.BackButton.TabIndex = 16;
            this.BackButton.TabStop = false;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ImgViewBackButton
            // 
            this.ImgViewBackButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ImgViewBackButton.BlogID = "Blog0000";
            this.ImgViewBackButton.CategoryID = "Category0000";
            this.ImgViewBackButton.ClickState = Blogz.ClickState.Open;
            this.ImgViewBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImgViewBackButton.Location = new System.Drawing.Point(662, 420);
            this.ImgViewBackButton.Name = "ImgViewBackButton";
            this.ImgViewBackButton.Size = new System.Drawing.Size(97, 23);
            this.ImgViewBackButton.TabIndex = 17;
            this.ImgViewBackButton.TabStop = false;
            this.ImgViewBackButton.Text = "Back";
            this.ImgViewBackButton.UseVisualStyleBackColor = false;
            this.ImgViewBackButton.Click += new System.EventHandler(this.ImgViewBackButton_Click);
            // 
            // RenameCatButton
            // 
            this.RenameCatButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RenameCatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RenameCatButton.Location = new System.Drawing.Point(661, 94);
            this.RenameCatButton.Name = "RenameCatButton";
            this.RenameCatButton.Size = new System.Drawing.Size(103, 23);
            this.RenameCatButton.TabIndex = 10;
            this.RenameCatButton.Text = "Rename Category";
            this.RenameCatButton.UseVisualStyleBackColor = false;
            this.RenameCatButton.Click += new System.EventHandler(this.RenameCatButton_Click);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private CustomButton CreateBlogButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PathChooseButton;
        private System.Windows.Forms.Button BackupButton;
        private System.Windows.Forms.Button LoadBackupButton;
        private System.Windows.Forms.Button RenameCatButton;
    }
}

