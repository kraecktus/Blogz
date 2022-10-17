using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Blogz
{
    
    public partial class CategoryControl : UserControl
    {
        public List<BlogControl> Blogs = new List<BlogControl>();
        public int ScrollLocation = 0;
        public string Title { get; set; } = "";
        public Boolean IsOpened {
            get { return _IsOpened; }
            set 
            {
                _IsOpened = value;
                if(_IsOpened)
                {
                    //OpenCloseButton.Text = "Close";
                    OpenCloseButton.BackgroundImage = Properties.Resources.IconOpened;
                    this.Height = 299;
                    this.BlogsPanel.Size = new System.Drawing.Size(610, 257);
                    BlogsPanel.Visible = true;
                }
                else if(!_IsOpened)
                {
                    //OpenCloseButton.Text = "Open";
                    OpenCloseButton.BackgroundImage = Properties.Resources.IconClosed;
                    this.Height = 42;
                    this.BlogsPanel.Size = new System.Drawing.Size(610, 0);
                    BlogsPanel.Visible = false;
                }
            }
        }
        public Boolean _IsOpened = true;
        public Boolean ShowBTN = true;
        public CategoryControl(string _Title, List<BlogControl> _Blogs, Boolean _ShowBTN = true, int _Height = 42, int _Width = 625)
        {
            Title = _Title;
            this.Height = _Height;
            this.Width = _Width;
            ShowBTN = _ShowBTN;
            Blogs = _Blogs;
            InitializeComponent();
            Initialize();
        }
        public void Initialize()
        {
            this.BlogsPanel.Controls.Clear();

            foreach (BlogControl b in Blogs)
            {
                if (Blogs != null)
                {
                    this.BlogsPanel.Controls.Add(b);
                }
                else
                {
                    this.BlogsPanel.Controls.Add(new BlogControl("Info", "No Blogs Found", "01.01.2022", new string[] { "" }, 0, false, PlaceHolderEvent));
                }
            }
            
            TitleLabel.Text = Title;
            //OpenCloseButton.Text = "Open";
            OpenCloseButton.BackgroundImage = Properties.Resources.IconClosed;
            OpenCloseButton.FlatStyle = FlatStyle.Flat;
            OpenCloseButton.FlatAppearance.BorderSize = 0;
            OpenCloseButton.FlatAppearance.MouseDownBackColor = Color.LightSlateGray;
            OpenCloseButton.FlatAppearance.MouseOverBackColor = Color.LightSlateGray;

            if (ShowBTN) OpenCloseButton.Visible = true;
            else if (!ShowBTN) OpenCloseButton.Visible = false;
            IsOpened = false;
        }
        public void PlaceHolderEvent(object sender, EventArgs e) { }
        private void OpenCloseButton_Click(object sender, System.EventArgs e)
        {
            if(IsOpened)
            {
                IsOpened = false;
            }
            else
            {
                IsOpened = true;
            }
        }
    }
}
