using System;
using System.Windows.Forms;

namespace Blogz
{
    public partial class BlogControl : UserControl
    {
        public Blog LocalBlog { get; set; }
        public Boolean ShowButtons { get; set; } = false;
        public int ID { get; set; }
        public ClickState LocalClickState { get; set; }
        public EventHandler FormsClickHandler { get; set; }
        public BlogControl(Blog _Blog, Boolean _ShowButtons, EventHandler _FormsClickHandler)
        {
            LocalBlog = _Blog;
            ShowButtons = _ShowButtons;
            InitializeComponent();
            OpenButton.Click += ClickHandler;
            EditButton.Click += ClickHandler;
            DeleteButton.Click += ClickHandler;
            FormsClickHandler = _FormsClickHandler;
            Initialize();
        }
        public void ClickHandler(object sender, EventArgs e)
        {
            CustomButton Buttonsender = (CustomButton)sender;
            LocalClickState = Buttonsender.ClickState;
            FormsClickHandler.Invoke(this, e);
        }
        public void Initialize()
        {
            TitleLBL.Text = LocalBlog.Title + " - " + LocalBlog.Description;
            if(ShowButtons)
            {
                OpenButton.Visible = true;
                EditButton.Visible = true;
                DeleteButton.Visible = true;
            }
            else if (!ShowButtons)
            {
                OpenButton.Visible = false;
                EditButton.Visible = false;
                DeleteButton.Visible = false;
            }
        }
    }
}
