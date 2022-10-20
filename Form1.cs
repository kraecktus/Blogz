using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Blogz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //AddTests();
            TabControl.Appearance = TabAppearance.FlatButtons;
            TabControl.ItemSize = new System.Drawing.Size(0, 1);
            TabControl.SizeMode = TabSizeMode.Fixed;
            Initialize();
        }
        public void Initialize()
        {
            Essentials.LoadData(ButtonClickHandler);
            PicturePanel.Visible = false;
            CategoryFlowPanel.Controls.Clear();
            
            if (Essentials.Categorys.Count == 0) CategoryFlowPanel.Controls.Add(new BlogControl(Essentials.ErrorBlog("No Blogs were Found"), false, (object sender, EventArgs e) => { }));
            else
            {
                foreach (CategoryControl x in Essentials.Categorys.Values)
                {
                    CategoryFlowPanel.Controls.Add(x);
                }
            }
        }
        
        public CustomLinkLabel AddHyperlink(Image _image)
        {
            if (_image.DisplayText == "") return null;
            else
            {
                CustomLinkLabel link = new CustomLinkLabel();
                link.Text = _image.DisplayText;

                if(!File.Exists(_image.Path)) return null;
                else
                {
                    link.Title = _image.Title;
                    link.Creator = _image.Creator;
                    link.cDate = _image.Creation;
                    link.MouseHover += BlogContentTxtBox_LinkHover;
                    link.LinkClicked += (object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("explorer.exe", e.Link.LinkData.ToString());
                    link.MouseLeave += (object sender, EventArgs e) => PicturePanel.Visible = false;
                    
                    LinkLabel.Link data = new LinkLabel.Link();
                    data.LinkData = _image.Path;
                    link.Links.Add(data);
                    return link;
                }
            }
        }
        public void AddTests()
        {
            Image _image = new Image("Test Image", "Test", "Dev", "00.00.0001", "file://C:\\Users\\kaktus\\Documents\\boy4.png", "Image0001");
            Image _image1 = new Image("Test Image2", "Test3", "Dev", "00.00.0001", "file://C:\\Blogz\\Data\\ErrorImage.png", "Image0002");
            
            for (int i = 1; i < 16; i++)
            {
                Dictionary<string, BlogControl> Blogs = new Dictionary<string, BlogControl>();
                Blogs.Add("Blog0001", new BlogControl(new Blog("Day 1", "Dev", "Test", "00.00.0001", new string[] { "a", "b", "c", "asjkdhjkashdjkahsdjkhasd", "asjkfhasjklhfajklsbdjklasbnchjl" }, "Blog0001", new List<string>() { "Image0000", "Image0003" }, $"Category00" + i), true, ButtonClickHandler));
                Blogs.Add("Blog0002", new BlogControl(new Blog("Day 2", "Dev", "Test", "00.00.0002", new string[] { "a", "b", "c" }, "Blog0002", new List<string>() { "Image0000" }, $"Category00" + i), true, ButtonClickHandler));
                Blogs.Add("Blog0003", new BlogControl(new Blog("Day 3", "Dev", "Test", "00.00.0003", new string[] { "a", "b", "c" }, "Blog0003", new List<string>() { "Image0000" }, $"Category00" + i), true, ButtonClickHandler));
                Blogs.Add("Blog0004", new BlogControl(new Blog("Day 4", "Dev", "Test", "00.00.0004", new string[] { "a", "b", "c" }, "Blog0004", new List<string>() { "Image0000" }, $"Category00" + i), true, ButtonClickHandler));
                Blogs.Add("Blog0005", new BlogControl(new Blog("Day 5", "Dev", "Test", "00.00.0005", new string[] { "a", "b", "c" }, "Blog0005", new List<string>() { "Image0000" }, $"Category00" + i), true, ButtonClickHandler));
                Blogs.Add("Blog0006", new BlogControl(new Blog("Day 6", "Dev", "Test", "00.00.0006", new string[] { "a", "b", "c" }, "Blog0006", new List<string>() { "Image0000" }, $"Category00" + i), true, ButtonClickHandler));
                Blogs.Add("Blog0007", new BlogControl(new Blog("Day 7", "Dev", "Test", "00.00.0007", new string[] { "a", "b", "c" }, "Blog0007", new List<string>() { "Image0000" }, $"Category00" + i), true, ButtonClickHandler));
                Blogs.Add("Blog0008", new BlogControl(new Blog("Day 8", "Dev", "Test", "00.00.0008", new string[] { "a", "b", "c" }, "Blog0008", new List<string>() { "Image0000" }, $"Category00" + i), true, ButtonClickHandler));
                Blogs.Add("Blog0009", new BlogControl(new Blog("Day 9", "Dev", "Test", "00.00.0009", new string[] { "a", "b", "c" }, "Blog0009", new List<string>() { "Image0000" }, $"Category00" + i), true, ButtonClickHandler));
                CategoryControl x = new CategoryControl(new Category($"Category Test {i}", Blogs, $"Category00" + i));
                Essentials.Categorys.Add($"Category00" + i, x);
            }
        }
        public void LoadHyperlinks(BlogControl _Blog)
        {
            foreach (string _imageID in Essentials.Categorys[_Blog.LocalBlog.CategoryID].LocalCategory.Blogs[_Blog.LocalBlog.ID].LocalBlog.ImageIDs)
            {
                CustomLinkLabel _link = AddHyperlink(Essentials.Images[_imageID]);
                if (_link != null)
                {
                    BlogContentTxtBox.Controls.Add(_link);
                    LinksPanel.Controls.Add(_link);
                }
            }
        }
        public void ButtonClickHandler(object sender, EventArgs e)
        {
            BlogControl Blog = (BlogControl)sender;
            if(Blog.LocalClickState != ClickState.Delete)
            {
                TabControl.SelectedTab = BlogView;
                LoadBlog(Blog);
                LoadHyperlinks(Blog);
                LoadBlogControls(Blog);
            }
            else
            {
                // TODO: Delete
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
        }
        public void LoadBlogControls(BlogControl _Blog)
        {
            List<TextBox> ViewControls = new List<TextBox>() { TitleTxtBox, CreationDateTxtBox, CreatorTxtBox, DescriptionTxtBox };
            if(_Blog.LocalClickState == ClickState.Open)
            {
                foreach(TextBox box in ViewControls)
                {
                    box.BorderStyle = BorderStyle.None;
                    box.BackColor = Color.LightSlateGray;
                    box.ReadOnly = true;
                }
                BlogContentTxtBox.BorderStyle = BorderStyle.None;
                BlogContentTxtBox.BackColor = Color.LightSlateGray;
                BlogContentTxtBox.ReadOnly = true;
                AddPictureButton.Visible = false;
                RemovePictureButton.Visible = false;
                BackButton.ClickState = ClickState.Open;
            }
            else if(_Blog.LocalClickState == ClickState.Edit)
            {
                foreach (TextBox box in ViewControls)
                {
                    box.BorderStyle = BorderStyle.Fixed3D;
                    box.BackColor = Color.White;
                    box.ReadOnly = false;
                }
                BlogContentTxtBox.BorderStyle = BorderStyle.Fixed3D;
                BlogContentTxtBox.BackColor = Color.White;
                BlogContentTxtBox.ReadOnly = false;
                AddPictureButton.Visible = true;
                RemovePictureButton.Visible = true;
                BackButton.ClickState = ClickState.Edit;
            }
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            CustomButton button = (CustomButton)sender;
            if(button.ClickState == ClickState.Edit) CheckForBlogUpdates(Essentials.Categorys[button.CategoryID].LocalCategory.Blogs[button.BlogID].LocalBlog);
            TabControl.SelectedTab = MainView;
            Initialize();
        }

        public void CheckForBlogUpdates(Blog _Blog)
        {
            Boolean isDifferent = false;
            if (TitleTxtBox.Text != _Blog.Title || CreationDateTxtBox.Text != _Blog.CreationDate || CreatorTxtBox.Text != _Blog.Creator)
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
            if(isDifferent)
            {
                Blog _NewBlog = new Blog(TitleTxtBox.Text, CreatorTxtBox.Text, DescriptionTxtBox.Text, CreationDateTxtBox.Text, BlogContentTxtBox.Lines, _Blog.ID, _Blog.ImageIDs, _Blog.CategoryID);
                Essentials.Categorys[_Blog.CategoryID].LocalCategory.Blogs[_Blog.ID].LocalBlog = _NewBlog;
                Essentials.UpdateData();
            }
        }

        private void BlogContentTxtBox_LinkHover(object sender, EventArgs e)
        {
            CustomLinkLabel link = (CustomLinkLabel)sender;
            PictureTitleLabel.Text = "Title: " + link.Title;
            PictureCdateLabel.Text = "Creation: " + link.cDate;
            PictureCreatorLabel.Text = "Creator: " + link.Creator;

            string Path = link.Links[0].LinkData.ToString();
            
            if(Path != "") pictureBox1.BackgroundImage = System.Drawing.Image.FromFile(Path);
            else pictureBox1.BackgroundImage = System.Drawing.Image.FromFile(Essentials.Path + "/Data/ErrorImage.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom; 

            Point pos = Essentials.GetMousePoint();
            pos.X -= 219;
            PicturePanel.Location = pos;
            PicturePanel.Visible = true;
            PicturePanel.BringToFront();
        }

        private void ExitButton_Click(object sender, EventArgs e) => Environment.Exit(0);

        private void UploadButton_Click(object sender, EventArgs e)
        {
            if (Essentials.Images.Count < 99999)
            {
                ImageUploader _imageUploader = new ImageUploader(ButtonClickHandler);
                _imageUploader.ShowDialog();
                Initialize();
            }
            else MessageBox.Show("Sorry,\nbut you can Only have 99999 Images\nPlease Delete some, To Add More", "Info");
        }
    }
}
