using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Blogz
{
    public partial class RemoveImageForm : Form
    {
        List<string> ImageIDs = new List<string>();
        public CustomButton Button;
        public FlowLayoutPanel LinksPanel;
        public FlowLayoutPanel FilesPanel;
        public EventHandler FormsInitializeHandler;
        public EventHandler FormsLoadHyperlinks;
        public EventHandler LoadHyperLinkFiles;
        public RemoveImageForm(CustomButton _Button, FlowLayoutPanel _Panel, FlowLayoutPanel _FilesPanel, EventHandler _FormsInitializeHandler, EventHandler _LoadHyperlinks, EventHandler _LoadHyperLinkFiles)
        {
            Button = _Button;
            LinksPanel = _Panel;
            FilesPanel = _FilesPanel;
            FormsInitializeHandler = _FormsInitializeHandler;
            FormsLoadHyperlinks = _LoadHyperlinks;
            LoadHyperLinkFiles = _LoadHyperLinkFiles;
            InitializeComponent();
            Initialize();
        }

        public void Initialize()
        {
            ImageComboBox.DisplayMember = "Text";
            if (Button.ClickState == ClickState.Open)
            {
                foreach (string _ImageID in Essentials.Images.Keys)
                {
                    ImageIDs.Add(_ImageID);
                }
                RemoveButton.Text = "Add";
            }
            else if (Button.ClickState == ClickState.Delete)
            {
                ImageIDs = Essentials.Categorys[Button.CategoryID].LocalCategory.Blogs[Button.BlogID].LocalBlog.ImageIDs;
                RemoveButton.Text = "Remove";
            }
            else if(Button.ClickState == ClickState.Edit)
            {
                foreach(string _FileID in Essentials.Files.Keys)
                {
                    ImageIDs.Add(_FileID);
                }
                RemoveButton.Text = "Add";
            }
            else if(Button.ClickState == ClickState.Rename)
            {
                ImageIDs = Essentials.Categorys[Button.CategoryID].LocalCategory.Blogs[Button.BlogID].LocalBlog.FileIDs;
                RemoveButton.Text = "Remove";
            }
            if(Button.ClickState == ClickState.Open || Button.ClickState == ClickState.Delete)
            {
                foreach (string _Image in ImageIDs)
                {
                    ImageComboBox.Items.Add(new CustomControl(Essentials.Images[_Image]));
                }
            }
            else if(Button.ClickState == ClickState.Edit || Button.ClickState == ClickState.Rename)
            {
                foreach (string _Image in ImageIDs)
                {
                    ImageComboBox.Items.Add(new CustomControl(Essentials.Files[_Image]));
                }
            }
            if (ImageComboBox.Items.Count >= 1) ImageComboBox.SelectedIndex = 0;
        }

        private void CancelButton_Click(object sender, EventArgs e) => this.Close();

        private void ImageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomControl _Image = (CustomControl)ImageComboBox.Items[ImageComboBox.SelectedIndex];
            if (Button.ClickState == ClickState.Open || Button.ClickState == ClickState.Delete)
            {
                pictureBox1.BackgroundImage = Essentials.ReadImage(_Image.LocalImage.Path);
            }
            else if (Button.ClickState == ClickState.Edit || Button.ClickState == ClickState.Rename)
            {
                pictureBox1.BackgroundImage = Essentials.DrawImage(_Image.LocalImage);
            }
            TitleLabel.Text = "Title: " + _Image.LocalImage.Title;
            CreationLabel.Text = "Creation: " + _Image.LocalImage.Creation;
            CreatorLabel.Text = "Creator: " + _Image.LocalImage.Creator;
            IDLabel.Text = "ID: " + _Image.LocalImage.ID;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (Button.ClickState == ClickState.Delete)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Remove this Picture?", "Info", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    CustomControl _Image = (CustomControl)ImageComboBox.Items[ImageComboBox.SelectedIndex];
                    Essentials.Categorys[Button.CategoryID].LocalCategory.Blogs[Button.BlogID].LocalBlog.ImageIDs.Remove(_Image.LocalImage.ID);
                    Essentials.UpdateData();
                    FormsInitializeHandler.Invoke(Button.ClickState, e);
                    FormsLoadHyperlinks.Invoke(Essentials.Categorys[Button.CategoryID].LocalCategory.Blogs[Button.BlogID], e);
                }
            }
            else if (Button.ClickState == ClickState.Open)
            {
                CustomControl _Image = (CustomControl)ImageComboBox.Items[ImageComboBox.SelectedIndex];
                Essentials.Categorys[Button.CategoryID].LocalCategory.Blogs[Button.BlogID].LocalBlog.ImageIDs.Add(_Image.LocalImage.ID);
                Essentials.UpdateData();
                FormsInitializeHandler.Invoke(Button.ClickState, e);
                FormsLoadHyperlinks.Invoke(Essentials.Categorys[Button.CategoryID].LocalCategory.Blogs[Button.BlogID], e);
            }
            else if (Button.ClickState == ClickState.Rename)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Remove this File?", "Info", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    CustomControl _Image = (CustomControl)ImageComboBox.Items[ImageComboBox.SelectedIndex];
                    Essentials.Categorys[Button.CategoryID].LocalCategory.Blogs[Button.BlogID].LocalBlog.FileIDs.Remove(_Image.LocalImage.ID);
                    Essentials.UpdateData();
                    FormsInitializeHandler.Invoke(Button.ClickState, e);
                    LoadHyperLinkFiles.Invoke(Essentials.Categorys[Button.CategoryID].LocalCategory.Blogs[Button.BlogID], e);

                }
            }
            else if (Button.ClickState == ClickState.Edit)
            {
                CustomControl _Image = (CustomControl)ImageComboBox.Items[ImageComboBox.SelectedIndex];
                Essentials.Categorys[Button.CategoryID].LocalCategory.Blogs[Button.BlogID].LocalBlog.FileIDs.Add(_Image.LocalImage.ID);
                Essentials.UpdateData();
                FormsInitializeHandler.Invoke(Button.ClickState, e);
                LoadHyperLinkFiles.Invoke(Essentials.Categorys[Button.CategoryID].LocalCategory.Blogs[Button.BlogID], e);
            }
            this.Close();
        }
    }
    public class CustomControl : System.Windows.Forms.Control
    {
        public Image LocalImage { get; set; }
        public CustomControl(Image _Image)
        {
            LocalImage = _Image;
        }
        public override string ToString()
        {
            return LocalImage.DisplayText;
        }
        public override string Text { get => LocalImage.DisplayText; set => LocalImage.DisplayText = value; }
    }
}
