using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Blogz
{
    public partial class ImgViewControl : UserControl
    {
        public Image LocalImage { get; set; }
        public Boolean IsOpen = false;
        public int ClosedHeight { get; set; }
        public int OpenedHeight { get; set; }
        EventHandler FormsSelectedUpdate;
        public ClickState LocalClickState { get; set; }
        public ImgViewControl(Image _image, EventHandler _SelectedUpdate, ClickState _ClickState)
        {
            FormsSelectedUpdate = _SelectedUpdate;
            LocalImage = _image;
            LocalClickState = _ClickState;
            InitializeComponent();
            Initialize();
        }
        public void Initialize()
        {
            this.Height = 155;
            ImgViewPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            if (LocalClickState == ClickState.Open)
            {
                if (LocalImage.Path != "") ImgViewPictureBox.BackgroundImage = Essentials.ReadImage(LocalImage.Path);
                else ImgViewPictureBox.BackgroundImage = Essentials.ReadImage(Essentials.Path + "/Data/ErrorImage.png");
                ImgViewCheckBox.Text = LocalImage.DisplayText;
                ImgViewTitleLabel.Text = "Title: " + LocalImage.Title;
                ImgViewCreationLabel.Text = "Creation: " + LocalImage.Creation;
                ImgViewCreatorLabel.Text = "Creator: " + LocalImage.Creator;
            }
            else if(LocalClickState == ClickState.Edit)
            {
                ImgViewPictureBox.BackgroundImage = Essentials.DrawImage(LocalImage);
                ImgViewCheckBox.Text = LocalImage.DisplayText;
                ImgViewTitleLabel.Text = "Title: " + LocalImage.Title;
                ImgViewCreationLabel.Text = "Creation: " + LocalImage.Creation;
                ImgViewCreatorLabel.Text = "Creator: " + LocalImage.Creator;
            }
            FormsSelectedUpdate.Invoke(LocalClickState, new EventArgs());
        }
        
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
            Process.Start("explorer.exe", "file://" + Essentials.Path + LocalImage.Path);
        }

        private void ImgViewCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ImgViewCheckBox.Checked)
            {
                Essentials.ImagesSelected.Add(LocalImage.ID, LocalImage);
                FormsSelectedUpdate.Invoke(LocalClickState, e);
            }
            else
            {
                Essentials.ImagesSelected.Remove(LocalImage.ID);
                FormsSelectedUpdate.Invoke(this, e);
            }
        }
    }
}
