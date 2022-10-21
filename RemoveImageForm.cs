using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace Blogz
{
    public partial class RemoveImageForm : Form
    {
        List<string> ImageIDs = new List<string>();
        public CustomButton Button;
        public FlowLayoutPanel Panel;
        public EventHandler FormsInitializeHandler;
        public TabControl FormsTabControl;
        public RemoveImageForm(CustomButton _Button, FlowLayoutPanel _Panel, EventHandler _FormsInitializeHandler, TabControl _TabControl)
        {
            Button = _Button;
            Panel = _Panel;
            FormsInitializeHandler = _FormsInitializeHandler;
            FormsTabControl = _TabControl;
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
            else if(Button.ClickState == ClickState.Delete)
            {
                ImageIDs = Essentials.Categorys[Button.CategoryID].LocalCategory.Blogs[Button.BlogID].LocalBlog.ImageIDs;
                RemoveButton.Text = "Remove";
            }
            foreach (string _Image in ImageIDs)
            {
                ImageComboBox.Items.Add(new CustomControl(Essentials.Images[_Image]));
            }
            if (ImageComboBox.Items.Count >= 1) ImageComboBox.SelectedIndex = 0;
        }

        private void CancelButton_Click(object sender, EventArgs e) => this.Close();

        private void ImageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomControl _Image = (CustomControl)ImageComboBox.Items[ImageComboBox.SelectedIndex];
            pictureBox1.BackgroundImage = Essentials.ReadImage(_Image.LocalImage.Path);
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
                    FormsInitializeHandler.Invoke(sender, e);
                    Panel.Controls.RemoveAt(ImageComboBox.SelectedIndex);
                }
            }
            else if (Button.ClickState == ClickState.Open)
            {
                CustomControl _Image = (CustomControl)ImageComboBox.Items[ImageComboBox.SelectedIndex];
                Essentials.Categorys[Button.CategoryID].LocalCategory.Blogs[Button.BlogID].LocalBlog.ImageIDs.Add(_Image.LocalImage.ID);
                Essentials.UpdateData();
                FormsInitializeHandler.Invoke(sender, e);
                FormsTabControl.SelectedIndex = 0;
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
