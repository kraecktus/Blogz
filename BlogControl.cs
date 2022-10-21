using System;
using System.Windows.Forms;

namespace Blogz
{
    public partial class BlogControl : UserControl
    {
        public Blog LocalBlog { get; set; }
        public Boolean ShowButtons { get; set; } = false;
        public ClickState LocalClickState { get; set; }
        public EventHandler FormsClickHandler { get; set; }
        public EventHandler FormsInitializeHandler { get; set; }
        public BlogControl(Blog _Blog, Boolean _ShowButtons, EventHandler _FormsClickHandler, EventHandler _FormsInitializeHandler)
        {
            LocalBlog = _Blog;
            ShowButtons = _ShowButtons;
            InitializeComponent();

            OpenButton.Click += ClickHandler;
            OpenButton.BlogID = LocalBlog.ID;
            OpenButton.CategoryID = LocalBlog.CategoryID;
            EditButton.Click += ClickHandler;
            EditButton.BlogID = LocalBlog.ID;
            EditButton.CategoryID = LocalBlog.CategoryID;
            DeleteButton.Click += ClickHandler;
            DeleteButton.BlogID = LocalBlog.ID;
            DeleteButton.CategoryID = LocalBlog.CategoryID;

            FormsClickHandler = _FormsClickHandler;
            FormsInitializeHandler = _FormsInitializeHandler;
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Delete this Blog?", "Warning", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                Essentials.Categorys[LocalBlog.CategoryID].LocalCategory.Blogs.Remove(LocalBlog.ID);
                Essentials.UpdateData();
                FormsInitializeHandler.Invoke(sender, e);
            }

        }
    }
}
