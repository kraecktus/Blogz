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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddTests();
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
                CategoryFlowPanel.Controls.Add(new CategoryControl("Could not Find Any Categorys", new List<BlogControl> { new BlogControl("Info", "No Entrys", "00.00.0000", new string[] { "a", "b", "c" }, 0, false, ButtonClickHandler) }, false));
            }
        }
        public void AddTests()
        {
            for (int i = 0; i < 10; i++)
            {
                List<BlogControl> z = new List<BlogControl>();
                z.Add(new BlogControl("Day 0", "Test Day", "01.05.2022", new string[] { "a", "b", "c" }, 0, true, ButtonClickHandler));
                z.Add(new BlogControl("Day 1", "Test Day", "02.05.2022", new string[] { "a", "b", "c" }, 1, true, ButtonClickHandler));
                z.Add(new BlogControl("Day 2", "Test Day", "03.05.2022", new string[] { "a", "b", "c" }, 2, true, ButtonClickHandler));
                z.Add(new BlogControl("Day 3", "Test Day", "04.05.2022", new string[] { "a", "b", "c" }, 3, true, ButtonClickHandler));
                z.Add(new BlogControl("Day 4", "Test Day", "05.05.2022", new string[] { "a", "b", "c" }, 4, true, ButtonClickHandler));
                z.Add(new BlogControl("Day 5", "Test Day", "06.05.2022", new string[] { "a", "b", "c" }, 5, true, ButtonClickHandler));
                z.Add(new BlogControl("Day 6", "Test Day", "07.05.2022", new string[] { "a", "b", "c" }, 6, true, ButtonClickHandler));
                z.Add(new BlogControl("Day 7", "Test Day", "08.05.2022", new string[] { "a", "b", "c" }, 7, true, ButtonClickHandler));
                CategoryControl x = new CategoryControl("Ausbildung Test " + i, z);
                Essentials.Categorys.Add(x);
            }
        }
        public void ButtonClickHandler(object sender, EventArgs e)
        {
            BlogControl Blog = (BlogControl)sender;
            Console.WriteLine("Blog ID: " + Blog.ID);
            Console.WriteLine("Action To Do: " + Blog.LocalClickState);

        }
        public void OpenBTNEvent(object sender, EventArgs e)
        {
            CustomButton OpenButton = (CustomButton)sender;
            Console.WriteLine("Button ID: " + OpenButton.ID);
            // OPEN
        }
        public void EditBTNEvent(object sender, EventArgs e)
        {
            CustomButton EditButton = (CustomButton)sender;
            Console.WriteLine("Button ID: " + EditButton.ID);
            // EDIT
        }

        public void DeleteBTNEvent(object sender, EventArgs e)
        {
            CustomButton DeleteButton = (CustomButton)sender;
            Console.WriteLine("Button ID: " + DeleteButton.ID);
            // Delete
        }
    }
}
