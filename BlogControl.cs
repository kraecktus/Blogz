using System;
using System.Windows.Forms;

namespace Blogz
{
    public partial class BlogControl : UserControl
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string CreationDate { get; set; }
        public string[] Content { get; set; }
        public Boolean ShowButtons { get; set; } = false;
        public int ID { get; set; }
        public ClickState LocalClickState { get; set; }
        public EventHandler FormsClickHandler { get; set; }
        public BlogControl(string _Title, string _Description, string _CreationDate, string[] _Content, int _ID, Boolean _ShowButtons, EventHandler _FormsClickHandler)
        {
            Title = _Title;
            Description = _Description;
            CreationDate = _CreationDate;
            Content = _Content;
            ShowButtons = _ShowButtons;
            ID = _ID;
            InitializeComponent();
            OpenButton.Click += ClickHandler;
            EditButton.Click += ClickHandler;
            DeleteButton.Click += ClickHandler;
            FormsClickHandler = _FormsClickHandler;
            EditButton.ID = ID;
            OpenButton.ID = ID;
            DeleteButton.ID = ID;
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
            TitleLBL.Text = Title + " - " + Description;
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
