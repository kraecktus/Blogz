using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;

namespace Blogz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TabControl.Appearance = TabAppearance.FlatButtons;
            TabControl.ItemSize = new System.Drawing.Size(0, 1);
            TabControl.SizeMode = TabSizeMode.Fixed;
            Initialize();
        }
        public void Initialize()
        {
            this.Text = "Blogz";
            Essentials.CheckConfig();
            Essentials.LoadConfig();
            Essentials.CheckFiles();
            Essentials.LoadData(ButtonClickHandler, InitializeEvent);

            PicturePanel.Visible = false;
            CategoryFlowPanel.Controls.Clear();
            CategoryFlowPanel.SizeChanged += (object sender, EventArgs e) => CategoryFlowPanel.HorizontalScroll.Visible = false;

            if (Essentials.Categorys.Count == 0) CategoryFlowPanel.Controls.Add(new BlogControl(Essentials.ErrorBlog("No Blogs were Found"), false, (object sender, EventArgs e) => { }, InitializeEvent));
            else
            {
                foreach (CategoryControl x in Essentials.Categorys.Values)
                {
                    CategoryFlowPanel.Controls.Add(x);
                }
            }
        }

        public CustomLinkLabel AddHyperlink(Image _image, ClickState _ClickState)
        {
            if (_image.DisplayText == "") return null;
            else
            {
                CustomLinkLabel link = new CustomLinkLabel();
                link.Text = _image.DisplayText;

                if (!File.Exists(Essentials.Path + _image.Path)) return null;
                else
                {
                    link.Image = _image;
                    link.ClickState = _ClickState;
                    link.MouseHover += BlogContentTxtBox_LinkHover;
                    link.LinkClicked += (object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("explorer.exe", e.Link.LinkData.ToString());
                    link.MouseLeave += (object sender, EventArgs e) => PicturePanel.Visible = false;
                    link.LinkColor = Color.Black;
                    LinkLabel.Link data = new LinkLabel.Link();
                    data.LinkData = _image.Path;
                    link.Links.Add(data);
                    return link;
                }
            }
        }
        public void LoadHyperlinks(object Blog, EventArgs e)
        {
            BlogControl _Blog = (BlogControl)Blog;
            LinksPanel.Controls.Clear();
            foreach (string _imageID in Essentials.Categorys[_Blog.LocalBlog.CategoryID].LocalCategory.Blogs[_Blog.LocalBlog.ID].LocalBlog.ImageIDs)
            {
                CustomLinkLabel _link = AddHyperlink(Essentials.Images[_imageID], ClickState.Open);
                if (_link != null)
                {
                    LinksPanel.Controls.Add(_link);
                }
            }
            
        }
        public void LoadFileHyperLinks(object Blog, EventArgs e)
        {
            BlogControl _Blog = (BlogControl)Blog;
            FilesPanel.Controls.Clear();
            foreach (string _imageID in Essentials.Categorys[_Blog.LocalBlog.CategoryID].LocalCategory.Blogs[_Blog.LocalBlog.ID].LocalBlog.FileIDs)
            {
                CustomLinkLabel _link = AddHyperlink(Essentials.Files[_imageID], ClickState.Edit);
                if (_link != null)
                {
                    FilesPanel.Controls.Add(_link);
                }
            }
        }
        public void ButtonClickHandler(object sender, EventArgs e)
        {
            BlogControl Blog = (BlogControl)sender;
            if (Blog.LocalClickState != ClickState.Delete)
            {
                TabControl.SelectedTab = BlogView;
                LoadBlog(Blog);
                LoadHyperlinks(Blog, e);
                LoadFileHyperLinks(Blog, e);
                LoadBlogControls(Blog);
            }
        }


        public void LoadBlog(BlogControl _Blog)
        {
            LinksPanel.Controls.Clear();
            TitleTxtBox.Text = _Blog.LocalBlog.Title;
            CreationDateTxtBox.Text = _Blog.LocalBlog.CreationDate;
            CreatorTxtBox.Text = _Blog.LocalBlog.Creator;
            BlogContentTxtBox.Lines = _Blog.LocalBlog.Content;
            DescriptionTxtBox.Text = _Blog.LocalBlog.Description;
            BackButton.BlogID = _Blog.LocalBlog.ID;
            BackButton.CategoryID = _Blog.LocalBlog.CategoryID;
            AddPictureButton.BlogID = _Blog.LocalBlog.ID;
            AddPictureButton.CategoryID = _Blog.LocalBlog.CategoryID;
            RemovePictureButton.BlogID = _Blog.LocalBlog.ID;
            RemovePictureButton.CategoryID = _Blog.LocalBlog.CategoryID;
            AddFileButton.BlogID = _Blog.LocalBlog.ID;
            AddFileButton.CategoryID = _Blog.LocalBlog.CategoryID;
            RemoveFileButton.BlogID = _Blog.LocalBlog.ID;
            RemoveFileButton.CategoryID = _Blog.LocalBlog.CategoryID;
        }
        public void LoadBlogControls(BlogControl _Blog)
        {
            List<TextBox> ViewControls = new List<TextBox>() { TitleTxtBox, CreationDateTxtBox, CreatorTxtBox, DescriptionTxtBox };
            if (_Blog.LocalClickState == ClickState.Open)
            {
                foreach (TextBox box in ViewControls)
                {
                    box.BorderStyle = BorderStyle.None;
                    box.BackColor = Color.RoyalBlue;
                    box.ReadOnly = true;
                }
                BlogContentTxtBox.BorderStyle = BorderStyle.None;
                BlogContentTxtBox.BackColor = Color.RoyalBlue;
                BlogContentTxtBox.ReadOnly = true;
                AddPictureButton.Visible = false;
                RemovePictureButton.Visible = false;
                AddFileButton.Visible = false;
                RemoveFileButton.Visible = false;
                BackButton.ClickState = ClickState.Open;
            }
            else if (_Blog.LocalClickState == ClickState.Edit)
            {
                foreach (TextBox box in ViewControls)
                {
                    box.BorderStyle = BorderStyle.Fixed3D;
                    box.BackColor = Color.CornflowerBlue;
                    box.ReadOnly = false;
                }
                BlogContentTxtBox.BorderStyle = BorderStyle.Fixed3D;
                BlogContentTxtBox.BackColor = Color.CornflowerBlue;
                BlogContentTxtBox.ReadOnly = false;
                AddPictureButton.Visible = true;
                RemovePictureButton.Visible = true;
                AddFileButton.Visible = true;
                RemoveFileButton.Visible = true;
                BackButton.ClickState = ClickState.Edit;
            }
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            CustomButton button = (CustomButton)sender;
            if (button.ClickState == ClickState.Edit) CheckForBlogUpdates(Essentials.Categorys[button.CategoryID].LocalCategory.Blogs[button.BlogID].LocalBlog);
            TabControl.SelectedTab = MainView;
            Initialize();
        }

        public void CheckForBlogUpdates(Blog _Blog)
        {
            Boolean isDifferent = false;
            if (TitleTxtBox.Text != _Blog.Title || CreationDateTxtBox.Text != _Blog.CreationDate || CreatorTxtBox.Text != _Blog.Creator || DescriptionTxtBox.Text != _Blog.Description)
            {
                isDifferent = true;
            }
            if (_Blog.Content.Count() > BlogContentTxtBox.Lines.Count() || _Blog.Content.Count() < BlogContentTxtBox.Lines.Count())
            {
                isDifferent = true;
            }
            else
            {
                for (int i = 0; i < _Blog.Content.Count(); i++)
                {
                    if (BlogContentTxtBox.Lines[i] != _Blog.Content[i])
                    {
                        isDifferent = true;
                        break;
                    }
                }
            }
            if (isDifferent)
            {
                Blog _NewBlog = new Blog(TitleTxtBox.Text, CreatorTxtBox.Text, DescriptionTxtBox.Text, CreationDateTxtBox.Text, BlogContentTxtBox.Lines, _Blog.ID, _Blog.ImageIDs, _Blog.FileIDs, _Blog.CategoryID);
                Essentials.Categorys[_Blog.CategoryID].LocalCategory.Blogs[_Blog.ID].LocalBlog = _NewBlog;
                Essentials.UpdateData();
            }
        }

        private void BlogContentTxtBox_LinkHover(object sender, EventArgs e)
        {
            CustomLinkLabel link = (CustomLinkLabel)sender;
            PictureTitleLabel.Text = "Title: " + link.Image.Title;
            PictureCdateLabel.Text = "Creation: " + link.Image.Creation;
            PictureCreatorLabel.Text = "Creator: " + link.Image.Creator;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            if (link.ClickState == ClickState.Open)
            {
                string Path = link.Links[0].LinkData.ToString();
                if (Path != "") pictureBox1.BackgroundImage = Essentials.ReadImage(Path);
                else pictureBox1.BackgroundImage = Essentials.ReadImage("/Data/ErrorImage.png");
            }
            else if(link.ClickState == ClickState.Edit)
            {
                pictureBox1.BackgroundImage = Essentials.DrawImage(link.Image);
            }
            Point pos = Essentials.GetMousePoint();
            pos.X -= 219;
            PicturePanel.Location = pos;
            PicturePanel.Visible = true;
            PicturePanel.BringToFront();
        }

        private void ExitButton_Click(object sender, EventArgs e) => Environment.Exit(0);

        private void UploadButton_Click(object sender, EventArgs e)
        {
            CustomButton _Button = (CustomButton)sender;
            if (Essentials.Images.Count < 99999 || Essentials.Files.Count < 99999)
            {
                ImageUploader _imageUploader = new ImageUploader(ButtonClickHandler, InitializeEvent, _Button.ClickState);
                _imageUploader.ShowDialog();
                LoadImgView(sender);
                Initialize();
            }
            else Essentials.ErrorMessage = "Sorry,\nbut you can Only have 99999 Files or Images\nPlease Delete some, To Add More";
        }

        private void ImgManagerButton_Click(object sender, EventArgs e) => LoadImgView(sender);
        public void LoadImgView(object sender)
        {
            CustomButton _Button = (CustomButton)sender;
            Essentials.ImagesSelected.Clear();
            ImgViewFlowPanel.Controls.Clear();
            if (_Button.ClickState == ClickState.Open)
            {
                foreach (Image _image in Essentials.Images.Values)
                {
                    ImgViewFlowPanel.Controls.Add(new ImgViewControl(_image, SelectionUpdateHandler, ClickState.Open));
                }
                UploadImgButton.Text = "Upload Image";
            }
            else if(_Button.ClickState == ClickState.Edit)
            {
                foreach (Image _image in Essentials.Files.Values)
                {
                    ImgViewFlowPanel.Controls.Add(new ImgViewControl(_image, SelectionUpdateHandler, ClickState.Edit));
                }
                UploadImgButton.Text = "Upload File";
            }
            UploadImgButton.ClickState = _Button.ClickState;
            ImgDeleteButton.ClickState = _Button.ClickState;
            TabControl.SelectedTab = ImagesView;
            SelectionUpdateHandler(_Button.ClickState, new EventArgs());
        }
        public void SelectionUpdateHandler(object sender, EventArgs e)
        {
            ClickState view = (ClickState)sender;
            int Count = Essentials.ImagesSelected.Count();
            if (Count >= 1) ImgDeleteButton.Enabled = true;
            else ImgDeleteButton.Enabled = false;
            string Type1 = "";
            string Type2 = "";
            if (view == ClickState.Open || view == ClickState.Delete)
            {
                Type1 = "Image";
                Type2 = "Images";
            }
            else if (view == ClickState.Edit || view == ClickState.Rename)
            {
                Type1 = "File";
                Type2 = "Files";
            }
            if (Count == 1) ImgViewSelectedCount.Text = Essentials.ImagesSelected.Count().ToString() + $" {Type1} Selected";
            else ImgViewSelectedCount.Text = Essentials.ImagesSelected.Count().ToString() + $" {Type2} Selected";
        }
        private void ImgViewBackButton_Click(object sender, EventArgs e) => TabControl.SelectedTab = MainView;

        private void ImgViewDeleteButton_Click(object sender, EventArgs e)
        {
            CustomButton _Button = (CustomButton)sender;
            foreach (Image _image in Essentials.ImagesSelected.Values.ToList())
            {
                if (_Button.ClickState == ClickState.Open)
                {
                    Essentials.Images.Remove(_image.ID);
                    Essentials.RemoveImageFromBlog(_image, InitializeEvent);
                    Essentials.UpdateData();
                    if (Essentials.Path + "/" + _image.Path != Essentials.Path + "/Data/ErrorImage.png")
                    {
                        File.Copy(Essentials.Path + "/" + _image.Path, Essentials.Path + "/Data/DeletedImages/" + IdGetter.GetHighestDeletedImageID());
                        File.Delete(Essentials.Path + "/" + _image.Path);
                    }
                }
                else if(_Button.ClickState == ClickState.Edit)
                {
                    Essentials.Files.Remove(_image.ID);
                    Essentials.RemoveFileFromBlog(_image, InitializeEvent);
                    Essentials.UpdateData();
                    if (Essentials.Path + "/" + _image.Path != Essentials.Path + "/Data/FileTemplate.png")
                    {
                        File.Copy(Essentials.Path + "/" + _image.Path, Essentials.Path + "/Data/DeletedFiles/" + IdGetter.GetHighestDeletedFileID());
                        File.Delete(Essentials.Path + "/" + _image.Path);
                    }
                }
                LoadImgView(sender);
                SelectionUpdateHandler(_Button.ClickState, e);
            }
        }
        
        public void InitializeEvent(object sender, EventArgs e) => Initialize();


        private void BlogViewPictureManager_Click(object sender, EventArgs e)
        {
            RemoveImageForm RIForm = new RemoveImageForm((CustomButton)sender, LinksPanel, FilesPanel, InitializeEvent, LoadHyperlinks, LoadFileHyperLinks);
            RIForm.ShowDialog();
        }

        private void CategoryCreateButton_Click(object sender, EventArgs e)
        {
            CategoryCreateForm Form = new CategoryCreateForm(ClickState.Edit, ButtonClickHandler, InitializeEvent);
            Form.ShowDialog();
        }

        private void CategoryDeleteButton_Click(object sender, EventArgs e)
        {
            CategoryCreateForm Form = new CategoryCreateForm(ClickState.Delete, ButtonClickHandler, InitializeEvent);
            Form.ShowDialog();
        }

        private void CreateBlogButton_Click(object sender, EventArgs e)
        {
            string BlogID = IdGetter.GetHighestBlogID();
            CategoryCreateForm Form = new CategoryCreateForm(ClickState.Open, ButtonClickHandler, InitializeEvent, BlogID);
            Form.ShowDialog();
            if (Form.IsSuccess == true)
            {
                BlogControl _Blog = Essentials.Categorys[Form.LocalBlog.LocalBlog.CategoryID].LocalCategory.Blogs[Form.LocalBlog.LocalBlog.ID];
                Console.WriteLine("Created");
                _Blog.LocalClickState = ClickState.Edit;
                LoadBlog(_Blog);
                LoadHyperlinks(_Blog, e);
                LoadBlogControls(_Blog);
                TabControl.SelectedTab = BlogView;
            }
            else Console.WriteLine("Stopped");
        }

        private void PathChooseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Dialog = new FolderBrowserDialog();
            Dialog.SelectedPath = Essentials.Path;
            Dialog.Description = "Please Choose a Folder Container the Data Folder for Blogz";
            Dialog.ShowDialog();
            if (Dialog.SelectedPath != "")
            {
                Essentials.Path = Dialog.SelectedPath;
                Essentials.Config.Path = Essentials.Path;
                Essentials.UpdateConfig();
                Initialize();
            }
        }

        private void BackupButton_Click(object sender, EventArgs e) => Essentials.BackUpData();

        private void LoadBackupButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to a Backup?\nThis will Delete all Your Current Data!", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                CategoryCreateForm cCreate = new CategoryCreateForm(ClickState.Backup, Essentials.PlaceHolderEvent, Essentials.PlaceHolderEvent);
                cCreate.ShowDialog();
                if (cCreate.SelectedBackup != "")
                {
                    DialogResult _result = MessageBox.Show("Are you sure you want to Load the Backup " + cCreate.SelectedBackup + "?", "Info", MessageBoxButtons.YesNo);
                    if (_result == DialogResult.Yes)
                    {
                        File.Delete(Essentials.Path + "/Data/Blogs.json");
                        File.Delete(Essentials.Path + "/Data/Categorys.json");
                        File.Delete(Essentials.Path + "/Data/ImagesManager.json");
                        Directory.Delete(Essentials.Path + "/Data/Images", true);
                        ZipFile.ExtractToDirectory(Essentials.Path + "/Data/Backups/" + cCreate.SelectedBackup + ".zip", Essentials.Path + "/Data/");
                        Initialize();
                        MessageBox.Show("Successfully Loaded Backup!", "Info");
                    }
                }
            }
        }

        private void RenameCatButton_Click(object sender, EventArgs e)
        {
            string CatID = "";
            CategoryCreateForm _CatSelector = new CategoryCreateForm(ClickState.RenameSelect, ButtonClickHandler, InitializeEvent);
            _CatSelector.ShowDialog();
            if (_CatSelector.IsSuccess)
            {
                CatID = _CatSelector.ID;
                CategoryCreateForm _CatRename = new CategoryCreateForm(ClickState.Rename, ButtonClickHandler, InitializeEvent, CatID);
                _CatRename.ShowDialog();
            }
        }

        private void FileManageButton_Click(object sender, EventArgs e) => LoadImgView(sender);
    }
}
