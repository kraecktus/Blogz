using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Blogz
{
    
    public partial class CategoryControl : UserControl
    {
        public Category LocalCategory { get; set; } 
        public Boolean IsOpened {
            get { return _IsOpened; }
            set 
            {
                _IsOpened = value;
                if(_IsOpened)
                {
                    //OpenCloseButton.Text = "Close";
                    OpenCloseButton.BackgroundImage = Properties.Resources.IconOpened;
                    this.Height = CalcControlHeight;
                    this.BlogsPanel.Size = new System.Drawing.Size(635, CalcBlogPanelHeight);
                    BlogsPanel.Visible = true;
                }
                else if(!_IsOpened)
                {
                    //OpenCloseButton.Text = "Open";
                    OpenCloseButton.BackgroundImage = Properties.Resources.IconClosed;
                    this.Height = 42;
                    this.BlogsPanel.Size = new System.Drawing.Size(635, 0);
                    BlogsPanel.Visible = false;
                }
            }
        }
        public Boolean _IsOpened = true;
        public Boolean ShowBTN = true;
        //public int CalcControlHeight = 299;
        public int CalcControlHeight = 42;
        public int CalcBlogPanelHeight = 257;
        public int CalcBlogPanelPositionY = 0;
        public CategoryControl(Category _Category, Boolean _ShowBTN = true, int _Height = 42, int _Width = 635)
        {
            LocalCategory = _Category;
            this.Height = _Height;
            this.Width = _Width;
            ShowBTN = _ShowBTN;
            InitializeComponent();
            Initialize();
        }
        public void Initialize()
        {
            this.BlogsPanel.Controls.Clear();
            if (LocalCategory.Blogs != null)
            {
                foreach (BlogControl b in LocalCategory.Blogs.Values)
                {
                    this.BlogsPanel.Controls.Add(b);
                    CalcControlHeight += 45;
                }
            }
            else
            {
                this.BlogsPanel.Controls.Add(new BlogControl(Essentials.ErrorBlog("No Blogs were Found"), false, (object sender, EventArgs e) => { }, Essentials.PlaceHolderEvent));
            }
            TitleLabel.Text = LocalCategory.Title;
            //OpenCloseButton.Text = "Open";
            OpenCloseButton.BackgroundImage = Properties.Resources.IconClosed;
            OpenCloseButton.FlatStyle = FlatStyle.Flat;
            OpenCloseButton.FlatAppearance.BorderSize = 0;

            if (ShowBTN) OpenCloseButton.Visible = true;
            else if (!ShowBTN) OpenCloseButton.Visible = false;
            IsOpened = false;
            this.BlogsPanel.Location = new Point(BlogsPanel.Location.X, BlogsPanel.Location.Y + CalcBlogPanelPositionY);
            //BlogsPanel.BringToFront();
        }
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
        private int radius = 25;
        [DefaultValue(25)]
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                this.RecreateRegion();
            }
        }
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect,
    int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private GraphicsPath GetRoundRectagle(Rectangle bounds, int radius)
        {
            float r = radius;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(bounds.Left, bounds.Top, r, r, 180, 90);
            path.AddArc(bounds.Right - r, bounds.Top, r, r, 270, 90);
            path.AddArc(bounds.Right - r, bounds.Bottom - r, r, r, 0, 90);
            path.AddArc(bounds.Left, bounds.Bottom - r, r, r, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void RecreateRegion()
        {
            var bounds = ClientRectangle;

            //using (var path = GetRoundRectagle(bounds, this.Radius))
            //    this.Region = new Region(path);

            //Better round rectangle
            this.Region = Region.FromHrgn(CreateRoundRectRgn(bounds.Left, bounds.Top,
                bounds.Right, bounds.Bottom, Radius, radius));
            this.Invalidate();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.RecreateRegion();
        }
    }
}
