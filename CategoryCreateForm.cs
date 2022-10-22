using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Blogz
{
    public partial class CategoryCreateForm : Form
    {
        public ClickState LocalClickState { get; set; }
        public EventHandler FormsEventHandler { get; set; }
        public EventHandler FormsButtonClickHandler { get; set; }
        public string ID;
        public Boolean IsSuccess = false;
        public BlogControl LocalBlog { get; set; }
        public string SelectedBackup = "";
        public CategoryCreateForm(ClickState _ClickState, EventHandler _ButtonClickHandler, EventHandler _FormsEventHandler, string _BlogID = "Blog00000")
        {
            LocalClickState = _ClickState;
            FormsEventHandler = _FormsEventHandler;
            FormsButtonClickHandler = _ButtonClickHandler;
            ID = _BlogID;
            InitializeComponent();
            Initialize();
        }
        public void Initialize()
        {
            CategoryComboBox.DisplayMember = "Text";
            if (LocalClickState == ClickState.Delete)
            {
                CategoryComboBox.Visible = true;
                TitleTextbox.Visible = false;
                TitleLabel.Visible = false;
                ActionButton.Text = "Delete";
                Text = "Delete Category";
                LoadAllCategorys();
            }
            else if(LocalClickState == ClickState.Edit)
            {
                CategoryComboBox.Visible = false;
                TitleTextbox.Visible = true;
                TitleLabel.Visible = true;
                ActionButton.Text = "Create";
                Text = "Create Category";
            }
            else if(LocalClickState == ClickState.Open)
            {
                CategoryComboBox.Visible = true;
                TitleTextbox.Visible = false;
                TitleLabel.Visible = false;
                ActionButton.Text = "Select";
                Text = "Select Category";
                LoadAllCategorys();
            }
            else if(LocalClickState == ClickState.Backup)
            {
                CategoryComboBox.Visible = true;
                TitleTextbox.Visible = false;
                TitleLabel.Visible = false;
                ActionButton.Text = "Select";
                Text = "Select Backup";
                LoadBackups();
            }
            else if(LocalClickState == ClickState.RenameSelect)
            {
                CategoryComboBox.Visible = true;
                TitleTextbox.Visible = false;
                TitleLabel.Visible = false;
                ActionButton.Text = "Select";
                Text = "Select Category";
                LoadAllCategorys();
            }
            else if(LocalClickState == ClickState.Rename)
            {
                CategoryComboBox.Visible = false;
                TitleTextbox.Visible = true;
                TitleLabel.Visible = true;
                ActionButton.Text = "Rename";
                Text = "Rename Category";
            }
        }
        public void LoadAllCategorys()
        {
            foreach (CategoryControl category in Essentials.Categorys.Values)
            {
                CategoryComboBox.Items.Add(new CustomControl(category.LocalCategory));
            }
            if (CategoryComboBox.Items.Count >= 1) CategoryComboBox.SelectedIndex = 0;
        }
        public void LoadBackups()
        {
            DirectoryInfo dInfo = new DirectoryInfo(Essentials.Path + "/Data/Backups/");

            foreach (FileInfo _image in dInfo.GetFiles("*.zip"))
            {
                CategoryComboBox.Items.Add(Path.GetFileNameWithoutExtension(_image.Name));
            }
            if (CategoryComboBox.Items.Count >= 1) CategoryComboBox.SelectedIndex = 0;
        }
        private void ActionButton_Click(object sender, EventArgs e)
        {
            if(LocalClickState == ClickState.Delete)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Delete this Category?", "Info", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    CustomControl Category = (CustomControl)CategoryComboBox.Items[CategoryComboBox.SelectedIndex];
                    if (Essentials.Categorys[Category.LocalCategory.ID].LocalCategory.Blogs.Count() == 0)
                    {
                        Essentials.Categorys.Remove(Category.LocalCategory.ID);
                        Essentials.UpdateData();
                        FormsEventHandler.Invoke(sender, e);
                    }
                    else
                    {
                        Essentials.ErrorMessage = "Cannot Delete Category, there are Still Blogs inside of It.";
                    }
                }
            }
            else if(LocalClickState == ClickState.Edit)
            {
                if (TitleTextbox.Text != "")
                {
                    string ID = IdGetter.GetHighestCategoryID();
                    Essentials.Categorys.Add(ID, new CategoryControl(new Category(TitleTextbox.Text, new Dictionary<string, BlogControl>(), ID)));
                    Essentials.UpdateData();
                    FormsEventHandler.Invoke(sender, e);
                }
                else Essentials.ErrorMessage = "Please Enter a Valid Title!";
            }
            else if(LocalClickState == ClickState.Open)
            {
                CustomControl Category = (CustomControl)CategoryComboBox.Items[CategoryComboBox.SelectedIndex];
                string CatID = Category.LocalCategory.ID;
                BlogControl _Blog = new BlogControl(new Blog("", "", "", "", new string[] {  }, ID, new List<string>(), CatID), false, FormsButtonClickHandler, FormsEventHandler);
                LocalBlog = _Blog;
                Essentials.Categorys[CatID].LocalCategory.Blogs.Add(ID, _Blog);

                IsSuccess = true;
            }
            else if(LocalClickState == ClickState.Backup)
            {
                SelectedBackup = CategoryComboBox.Text;
            }
            else if(LocalClickState == ClickState.RenameSelect)
            {
                CustomControl Category = (CustomControl)CategoryComboBox.Items[CategoryComboBox.SelectedIndex];
                ID = Category.LocalCategory.ID;
                IsSuccess = true;
            }
            else if(LocalClickState == ClickState.Rename)
            {
                if (TitleTextbox.Text != "")
                {
                    DialogResult dialog = MessageBox.Show("Do you really want to Rename the Category:\n" + Essentials.Categorys[ID].LocalCategory.Title + "\nTo:\n" + TitleTextbox.Text + " ?", "Info", MessageBoxButtons.YesNo);
                    if(dialog == DialogResult.Yes)
                    {
                        Essentials.Categorys[ID].LocalCategory.Title = TitleTextbox.Text;
                        Essentials.UpdateData();
                        FormsEventHandler.Invoke(sender, e);
                    }
                }
                else Essentials.ErrorMessage = "Please Enter a Valid Title!";
            }
            this.Close();
        }
        
        public class CustomControl : Control
        {
            public Category LocalCategory { get; set; }
            public CustomControl(Category _Category)
            {
                LocalCategory = _Category;
            }
            public override string Text { get => LocalCategory.Title; set => LocalCategory.Title = value; }
        }

        private void CancelButton_Click(object sender, EventArgs e) => this.Close();
    }
}
