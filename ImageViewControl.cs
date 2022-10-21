using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Blogz
{
    public partial class ImgViewControl : UserControl
    {
        public Image LocalImage { get; set; }
        public Boolean IsOpen = false;

        EventHandler FormsSelectedUpdate;

        public ImgViewControl(Image _image, EventHandler _SelectedUpdate)
        {
            FormsSelectedUpdate = _SelectedUpdate;
            LocalImage = _image;
            InitializeComponent();
            Initialize();
        }
        public void Initialize()
        {
            this.Height = 155;
            if (LocalImage.Path != "") ImgViewPictureBox.BackgroundImage = Essentials.ReadImage(LocalImage.Path);
            else ImgViewPictureBox.BackgroundImage = System.Drawing.Image.FromFile(Essentials.Path + "/Data/ErrorImage.png");
            ImgViewPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            ImgViewCheckBox.Text = LocalImage.DisplayText;
            ImgViewTitleLabel.Text = LocalImage.Title;
            ImgViewCreationLabel.Text = LocalImage.Creation;
            ImgViewCreatorLabel.Text = LocalImage.Creator;
        }
        // TODO: Remove Images from Blogs
        // TODO: Put Images into Garbage Folder
        private void OCButton_Click(object sender, EventArgs e)
        {
            if (IsOpen)
            {
                this.Height = 155;
                this.OCButton.BackgroundImage = Properties.Resources.IconClosed;
                IsOpen = false;
            }
            else
            {
                this.Height = 207;
                this.OCButton.BackgroundImage = Properties.Resources.IconOpened;
                IsOpen = true;
            }
        }

        private void ImgViewPictureBox_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "file://" + LocalImage.Path);
        }

        private void ImgViewCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(ImgViewCheckBox.Checked)
            {
                Essentials.ImagesSelected.Add(LocalImage.ID, LocalImage);
                FormsSelectedUpdate.Invoke(sender, e);
            }
            else
            {
                Essentials.ImagesSelected.Remove(LocalImage.ID);
                FormsSelectedUpdate.Invoke(sender, e);
            }
        }
    }
}
