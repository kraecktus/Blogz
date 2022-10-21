using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blogz
{
    public partial class CategoryCreateForm : Form
    {
        public ClickState LocalClickState { get; set; }
        public EventHandler FormsEventHandler { get; set; }
        public CategoryCreateForm(ClickState _ClickState, EventHandler _FormsEventHandler)
        {
            LocalClickState = _ClickState;
            FormsEventHandler = _FormsEventHandler;
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

                foreach(CategoryControl category in Essentials.Categorys.Values)
                {
                    CategoryComboBox.Items.Add(new CustomControl(category.LocalCategory));
                }
                if (CategoryComboBox.Items.Count >= 1) CategoryComboBox.SelectedIndex = 0;
            }
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
                        MessageBox.Show("Cannot Delete Category, there are Still Blogs inside of It.", "Info");
                    }
                }
            }
            else if(LocalClickState == ClickState.Open)
            {

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
    }
}
