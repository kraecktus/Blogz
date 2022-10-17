using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;

namespace Blogz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddTests();
            TabControl.Appearance = TabAppearance.FlatButtons;
            TabControl.ItemSize = new System.Drawing.Size(0, 1);
            TabControl.SizeMode = TabSizeMode.Fixed;
            Initialize();
        }
        public void Initialize()
        {
            CategoryFlowPanel.Controls.Clear();
            // Load Up
            foreach(CategoryControl x in Essentials.Categorys)
            {
                CategoryFlowPanel.Controls.Add(x);
            }
            if (Essentials.Categorys.Count == 0)
            {
                // TODO: Make Error Image
                CategoryFlowPanel.Controls.Add(new BlogControl(new Blog("Info", "Dev", "No Blogs Found", "00.00.0000", new string[] { "" }, 0, new List<Image>() { new Image("Image0000", "C:/Blogz/Data/ErrorImage.png", 0) }), false, ButtonClickHandler));
            }
        }
        public void AddTests()
        {
            LinkLabel link = new LinkLabel();
            link.Text = "Microsoft";
            link.LinkClicked += BlogContentTxtBox_LinkClicked;
            link.MouseHover += BlogContentTxtBox_LinkHover;
            link.MouseLeave += BlogContentTxtBox_LinkHoverExit;
            LinkLabel.Link data = new LinkLabel.Link();
            data.LinkData = "file://C:\\Users\\kaktus\\Documents\\boy4.png";
            link.Links.Add(data);
            //link.Location = richTextBox1.GetPositionFromCharIndex(richTextBox1.TextLength);
            //richTextBox1.Controls.Add(link);
            //LinkLabel link = new LinkLabel();
            //link.Text = "Microsoft";
            //LinkLabel.Link data = new LinkLabel.Link();
            //data.LinkData = "file://C:\\Users\\kaktus\\Documents\\boy4.png";
            //link.Links.Add(data);
            
            link.Location = BlogContentTxtBox.GetPositionFromCharIndex(BlogContentTxtBox.TextLength);
            BlogContentTxtBox.Controls.Add(link);
            for (int i = 1; i < 16; i++)
            {
                List<BlogControl> z = new List<BlogControl>();
                z.Add(new BlogControl(new Blog("Day 1", "Dev", "Test", "00.00.0001", new string[] { "" }, 0, new List<Image>() { new Image("Image0000", "C:/Blogz/Data/ErrorImage.png", 0) }), true, ButtonClickHandler));
                z.Add(new BlogControl(new Blog("Day 2", "Dev", "Test", "00.00.0002", new string[] { "" }, 0, new List<Image>() { new Image("Image0000", "C:/Blogz/Data/ErrorImage.png", 0) }), true, ButtonClickHandler));
                z.Add(new BlogControl(new Blog("Day 3", "Dev", "Test", "00.00.0003", new string[] { "" }, 0, new List<Image>() { new Image("Image0000", "C:/Blogz/Data/ErrorImage.png", 0) }), true, ButtonClickHandler));
                z.Add(new BlogControl(new Blog("Day 4", "Dev", "Test", "00.00.0004", new string[] { "" }, 0, new List<Image>() { new Image("Image0000", "C:/Blogz/Data/ErrorImage.png", 0) }), true, ButtonClickHandler));
                z.Add(new BlogControl(new Blog("Day 5", "Dev", "Test", "00.00.0005", new string[] { "" }, 0, new List<Image>() { new Image("Image0000", "C:/Blogz/Data/ErrorImage.png", 0) }), true, ButtonClickHandler));
                z.Add(new BlogControl(new Blog("Day 6", "Dev", "Test", "00.00.0006", new string[] { "" }, 0, new List<Image>() { new Image("Image0000", "C:/Blogz/Data/ErrorImage.png", 0) }), true, ButtonClickHandler));
                z.Add(new BlogControl(new Blog("Day 7", "Dev", "Test", "00.00.0007", new string[] { "" }, 0, new List<Image>() { new Image("Image0000", "C:/Blogz/Data/ErrorImage.png", 0) }), true, ButtonClickHandler));
                CategoryControl x = new CategoryControl("Category Test " + i, z);
                Essentials.Categorys.Add(x);
            }
        }
        public void ButtonClickHandler(object sender, EventArgs e)
        {
            BlogControl Blog = (BlogControl)sender;
            TabControl.SelectedTab = BlogView;
            if(Blog.LocalClickState != ClickState.Delete)
            {
                LoadBlog(Blog);
                LoadBlogControls(Blog);
            }
            else
            {
                // TODO: Delete
            }
        }
        public void LoadBlog(BlogControl _Blog)
        {
            TitleTxtBox.Text = _Blog.LocalBlog.Title;
            CreationDateTxtBox.Text = _Blog.LocalBlog.CreationDate;
            CreatorTxtBox.Text = _Blog.LocalBlog.Creator;
        }
        public void LoadBlogControls(BlogControl _Blog)
        {
            List<TextBox> ViewControls = new List<TextBox>() { TitleTxtBox, CreationDateTxtBox, CreatorTxtBox };
            if(_Blog.LocalClickState == ClickState.Open)
            {
                foreach(TextBox box in ViewControls)
                {
                    box.BorderStyle = BorderStyle.None;
                    box.BackColor = Color.LightSlateGray;
                }
            }
            else if(_Blog.LocalClickState == ClickState.Edit)
            {
                foreach (TextBox box in ViewControls)
                {
                    box.BorderStyle = BorderStyle.Fixed3D;
                    box.BackColor = Color.White;
                }
            }
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = MainView;
            Initialize();
        }

        private void BlogContentTxtBox_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p = System.Diagnostics.Process.Start("explorer.exe", e.Link.LinkData.ToString()/*.Split(':')[1]*/);
        }
        private void BlogContentTxtBox_LinkHover(object sender, EventArgs e)
        {
            LinkLabel link = (LinkLabel)sender;
            pictureBox1.Visible = true;
            Point pos = Essentials.GetConsolePoint(Cursor.Position);

            pictureBox1.Location = pos;
            pictureBox1.ImageLocation = link.Links[0].LinkData.ToString();
            
            //pictureBox1.Visible = false;
        }
        private void BlogContentTxtBox_LinkHoverExit(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }
    }
}
