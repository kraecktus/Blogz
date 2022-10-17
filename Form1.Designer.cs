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
            this.BlogView = new System.Windows.Forms.TabPage();
            this.BlogContentTxtBox = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CreationLBL = new System.Windows.Forms.Label();
            this.AuthorLBL = new System.Windows.Forms.Label();
            this.MinusLabel = new System.Windows.Forms.Label();
            this.CreatorTxtBox = new System.Windows.Forms.TextBox();
            this.CreationDateTxtBox = new System.Windows.Forms.TextBox();
            this.TitleTxtBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TabControl.SuspendLayout();
            this.MainView.SuspendLayout();
            this.BlogView.SuspendLayout();
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
            this.MainView.Controls.Add(this.CategoryFlowPanel);
            this.MainView.Location = new System.Drawing.Point(4, 5);
            this.MainView.Name = "MainView";
            this.MainView.Padding = new System.Windows.Forms.Padding(3);
            this.MainView.Size = new System.Drawing.Size(806, 451);
            this.MainView.TabIndex = 0;
            this.MainView.Text = "tabPage1";
            this.MainView.UseVisualStyleBackColor = true;
            // 
            // BlogView
            // 
            this.BlogView.BackColor = System.Drawing.Color.LightSlateGray;
            this.BlogView.Controls.Add(this.pictureBox1);
            this.BlogView.Controls.Add(this.BlogContentTxtBox);
            this.BlogView.Controls.Add(this.textBox1);
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
            // BlogContentTxtBox
            // 
            this.BlogContentTxtBox.Location = new System.Drawing.Point(364, 100);
            this.BlogContentTxtBox.Name = "BlogContentTxtBox";
            this.BlogContentTxtBox.Size = new System.Drawing.Size(100, 96);
            this.BlogContentTxtBox.TabIndex = 9;
            this.BlogContentTxtBox.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(364, 225);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
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
            this.CreatorTxtBox.Text = "Dev";
            // 
            // CreationDateTxtBox
            // 
            this.CreationDateTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreationDateTxtBox.Location = new System.Drawing.Point(87, 50);
            this.CreationDateTxtBox.Name = "CreationDateTxtBox";
            this.CreationDateTxtBox.Size = new System.Drawing.Size(73, 21);
            this.CreationDateTxtBox.TabIndex = 3;
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
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(721, 420);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(87, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 125);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel CategoryFlowPanel;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage MainView;
        private System.Windows.Forms.TabPage BlogView;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox TitleTxtBox;
        private System.Windows.Forms.TextBox CreationDateTxtBox;
        private System.Windows.Forms.TextBox CreatorTxtBox;
        private System.Windows.Forms.Label MinusLabel;
        private System.Windows.Forms.Label AuthorLBL;
        private System.Windows.Forms.Label CreationLBL;
        private System.Windows.Forms.RichTextBox BlogContentTxtBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

