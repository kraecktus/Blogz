using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Blogz
{
    public class Essentials
    {
        // TODO: Backup Funktion
        public static Dictionary<string, CategoryControl> Categorys = new Dictionary<string, CategoryControl>();
        public static Dictionary<string, Image> Images = new Dictionary<string, Image>();
        public static Dictionary<string, Image> ImagesSelected = new Dictionary<string, Image>();
        public static EventHandler PlaceHolderEvent;
        public static string ErrorMessage
        {
            get
            {
                return "";
            }
            set
            {
                MessageBox.Show(value, "Error");
            }
        }

        public static System.Drawing.Image ReadImage(string Path)
        {
            using (var ms = new MemoryStream(File.ReadAllBytes(Path)))
            {
                System.Drawing.Image _image = System.Drawing.Image.FromStream(ms);
                ms.Flush();
                ms.Dispose();
                return _image;
            }
        }
        // TODO: Make a Path Selector
        public static string Path = "C:/Blogz";
        public static Blog ErrorBlog(string ErrorMessage)
        {
            Blog _Blog = new Blog("Info", "Dev", ErrorMessage, "00.00.0000", new string[] { "" }, "Blog00000", new List<string>(), "Category00000");

            return _Blog;
        }
        public static void LoadData(EventHandler ButtonClickHandler, EventHandler InitializeEvent)
        {
            Essentials.Categorys.Clear();
            Essentials.Images.Clear();
            Essentials.ImagesSelected.Clear();
            List<Blog> BlogsList = new List<Blog>();
            List<LoadingCategory> CategoryList = new List<LoadingCategory>();
            List<Image> ImageList = new List<Image>();

            string JsonFile = File.ReadAllText(Path + "/Data/Blogs.json");
            BlogsList = JsonConvert.DeserializeObject<List<Blog>>(JsonFile);

            JsonFile = File.ReadAllText(Path + "/Data/Categorys.json");
            CategoryList = JsonConvert.DeserializeObject<List<LoadingCategory>>(JsonFile);

            JsonFile = File.ReadAllText(Path + "/Data/ImagesManager.json");
            ImageList = JsonConvert.DeserializeObject<List<Image>>(JsonFile);
            
            foreach(Image _image in ImageList)
            {
                try
                {
                    if (_image.ID.Length != 10)
                    {
                        ErrorMessage = "Could not Load Image with the ID " + _image.ID + ",\nPlease delete This Image ID in the File \"ImagesManager.json\"\nAnd Re -add the Correct Image.";
                        continue;
                    }
                    else
                    {
                        try
                        {
                            int x = Convert.ToInt32(_image.ID.Split('e')[1]);
                        }
                        catch
                        {
                            ErrorMessage = "Could not Load Image with the ID " + _image.ID + ",\nPlease delete This Image ID in the File \"ImagesManager.json\"\nAnd Re -add the Correct Image.";
                            continue;
                        }
                    }
                }
                catch
                {
                    ErrorMessage = "Could not Load Image with the ID " + _image.ID + ",\nPlease delete This Image ID in the File \"ImagesManager.json\"\nAnd Re -add the Correct Image.";
                    continue;
                }
                Images.Add(_image.ID, new Image(_image.DisplayText, _image.Title, _image.Creator, _image.Creation, _image.Path, _image.ID));
            }

            foreach (LoadingCategory cat in CategoryList)
            {
                Dictionary<string, BlogControl> _Blogs = new Dictionary<string, BlogControl>();
                foreach (Blog _blog in BlogsList.Where(x => x.CategoryID == cat .ID))
                {
                    _Blogs.Add(_blog.ID, new BlogControl(_blog, true, ButtonClickHandler, InitializeEvent));
                }
                Essentials.Categorys.Add(cat.ID, new CategoryControl(new Category(cat.Title, _Blogs, cat.ID)));
            }
        }
        public static void UpdateData()
        {
            List<LoadingCategory> LoadCategorys = new List<LoadingCategory>();
            List<Blog> LoadBlogs = new List<Blog>();
            List<Image> LoadImages = new List<Image>();

            foreach (CategoryControl _Category in Essentials.Categorys.Values)
            {
                LoadCategorys.Add(new LoadingCategory(_Category.LocalCategory.Title, _Category.LocalCategory.ID));
                foreach(BlogControl _Blog in _Category.LocalCategory.Blogs.Values)
                {
                    LoadBlogs.Add(_Blog.LocalBlog);
                }
            }
            foreach(Image _image in Essentials.Images.Values)
            {
                LoadImages.Add(new Image(_image.DisplayText, _image.Title, _image.Creator, _image.Creation, _image.Path, _image.ID));
            }
            using(StreamWriter sw = File.CreateText(Path + "/Data/Categorys.json"))
            {
                string SerializedJson = JsonConvert.SerializeObject(LoadCategorys, Formatting.Indented);
                sw.WriteLine(SerializedJson);
                sw.Close();
            }
            using(StreamWriter sw = File.CreateText(Path + "/Data/Blogs.json"))
            {
                string SerializedJson = JsonConvert.SerializeObject(LoadBlogs, Formatting.Indented);
                sw.WriteLine(SerializedJson);
                sw.Close();
            }
            using (StreamWriter sw = File.CreateText(Path + "/Data/ImagesManager.json"))
            {
                string SerializedJson = JsonConvert.SerializeObject(LoadImages, Formatting.Indented);
                sw.WriteLine(SerializedJson);
                sw.Close();
            }
        }

        public static Point GetMousePoint()
        {
            Point point = Cursor.Position;
            IntPtr handle = IntPtr.Zero;
            IntPtr ptr = GetForegroundWindow();
            Rect rect = new Rect();
            GetWindowRect(GetForegroundWindow(), out rect);
            point.X = point.X - rect.Left;
            point.Y = point.Y - rect.Top - 15;
            return point;
        }

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(IntPtr hWnd, out Rect lpRect);

    }
    [StructLayout(LayoutKind.Sequential)]
    public struct Rect
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;

        public int Width => Right - Left;
        public int Height => Bottom - Top;
    }
    public class CustomButton : Button
    {
        public ClickState ClickState { get; set; }
        public string BlogID { get; set; }
        public string CategoryID { get; set; }
    }
    public class CustomLinkLabel : LinkLabel
    {
        public string Title { get; set; }
        public string Creator { get; set; }
        public string cDate { get; set; }
    }
    public class Blog
    {
        public string Title { get; set; }
        public string Creator { get; set; }
        public string Description { get; set; }
        public string CreationDate { get; set; }
        public string[] Content { get; set; }
        public List<string> ImageIDs { get; set; }
        public string ID { get; set; }
        public string CategoryID { get; set; }
        public Blog(string _Title, string _Creator, string _Description, string _CreationDate, string[] _Content, string _ID, List<string> _ImageIDs, string _CategoryID)
        {
            Title = _Title;
            Creator = _Creator;
            Description = _Description;
            CreationDate = _CreationDate;
            Content = _Content;
            ID = _ID;
            ImageIDs = _ImageIDs;
            CategoryID = _CategoryID;
        }
    }
    public class Category
    {
        public string Title { get; set; } = "Category00000";
        public Dictionary<string, BlogControl> Blogs { get; set; }
        public string ID { get; set; }
        public Category(string _Title, Dictionary<string, BlogControl> blogs, string _ID)
        {
            Title = _Title;
            Blogs = blogs;
            ID = _ID;
        }
    }
    public class LoadingCategory
    {
        public string Title { get; set; }
        public string ID { get; set; }
        public LoadingCategory(string _Title, string _ID)
        {
            Title = _Title;
            ID = _ID;
        }
    }
    public class Image
    {
        public string DisplayText = "HyperImage";
        public string Title = "Image00000";
        public string Creator = "Dev";
        public string Creation = "00.00.0000";
        public string Path = "";
        public string ID = "Image00000";
        public Image(string _DisplayText, string _Title, string _Creator, string _Creation, string _Path, string _ID)
        {
            DisplayText = _DisplayText;
            Title = _Title;
            Creator = _Creator;
            Creation = _Creation;
            Path = _Path;
            ID = _ID;
        }
    }
    public enum ClickState
    {
        Open,
        Edit,
        Delete
    }
    
}
