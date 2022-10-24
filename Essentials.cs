using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Blogz
{
    public class Essentials
    {
        public static Dictionary<string, CategoryControl> Categorys = new Dictionary<string, CategoryControl>();
        public static Dictionary<string, Image> Images = new Dictionary<string, Image>();
        public static Dictionary<string, Image> Files = new Dictionary<string, Image>();
        public static Dictionary<string, Image> ImagesSelected = new Dictionary<string, Image>();
        public static Config Config = new Config();
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
        public static void RemoveImageFromBlog(Image _image, EventHandler FormsInit)
        {
            foreach (CategoryControl _category in Essentials.Categorys.Values)
            {
                foreach (BlogControl _Blog in _category.LocalCategory.Blogs.Values)
                {
                    if (_Blog.LocalBlog.ImageIDs.Contains(_image.ID))
                    {
                        _Blog.LocalBlog.ImageIDs.Remove(_image.ID);
                    }
                }
            }
            Essentials.UpdateData();
            FormsInit.Invoke(new object(), new EventArgs());
        }
        public static void RemoveFileFromBlog(Image _image, EventHandler FormsInit)
        {
            foreach (CategoryControl _category in Essentials.Categorys.Values)
            {
                foreach (BlogControl _Blog in _category.LocalCategory.Blogs.Values)
                {
                    if (_Blog.LocalBlog.FileIDs.Contains(_image.ID))
                    {
                        _Blog.LocalBlog.FileIDs.Remove(_image.ID);
                    }
                }
            }
            Essentials.UpdateData();
            FormsInit.Invoke(new object(), new EventArgs());
        }
        public static System.Drawing.Image DrawImage(Image LocalImage)
        {
            Point DisplayTextLocation = new Point(400, 150);
            Point TitleLocation = new Point(390, 250);
            Point CreatorLocation = new Point(390, 330);
            Point CreationLocation = new Point(390, 415);

            string Template = "/Data/FileTemplate.png";

            Bitmap bitmap = (Bitmap)System.Drawing.Image.FromFile(Essentials.Path + Template);
            Bitmap tempBitmap = new Bitmap(bitmap.Width, bitmap.Height);

            using (Graphics graphics = Graphics.FromImage(tempBitmap))
            {
                using (Font CalibriFont = new Font("Calibri", 60))
                {
                    graphics.DrawImage(bitmap, 0, 0);
                    graphics.DrawString(LocalImage.DisplayText, CalibriFont, Brushes.White, DisplayTextLocation);
                    graphics.DrawString(LocalImage.Title, CalibriFont, Brushes.White, TitleLocation);
                    graphics.DrawString(LocalImage.Creator, CalibriFont, Brushes.White, CreatorLocation);
                    graphics.DrawString(LocalImage.Creation, CalibriFont, Brushes.White, CreationLocation);
                }
            }
            bitmap.Dispose();
            return (System.Drawing.Image)tempBitmap;
        }
        public static System.Drawing.Image ReadImage(string Path)
        {
            using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(Essentials.Path + "/" + Path)))
            {
                System.Drawing.Image _image = System.Drawing.Image.FromStream(ms);
                ms.Flush();
                ms.Dispose();
                return _image;
            }
        }
        public static string Path = "C:/Blogz";
        public static Blog ErrorBlog(string ErrorMessage)
        {
            Blog _Blog = new Blog("Info", "Dev", ErrorMessage, "00.00.0000", new string[] { "" }, "Blog00000", new List<string>(), new List<string>(), "Category00000");

            return _Blog;
        }
        public static void CheckFiles()
        {
            if (!Directory.Exists(Essentials.Path + "/Data")) Directory.CreateDirectory(Essentials.Path + "/Data");
            if (!Directory.Exists("C:/Blogz")) Directory.CreateDirectory("C:/Blogz");
            if (!Directory.Exists(Essentials.Path + "/Data/DeletedImages")) Directory.CreateDirectory(Essentials.Path + "/Data/DeletedImages");
            if (!Directory.Exists(Essentials.Path + "/Data/Images")) Directory.CreateDirectory(Essentials.Path + "/Data/Images");
            if (!Directory.Exists(Essentials.Path + "/Data/Backups")) Directory.CreateDirectory(Essentials.Path + "/Data/Backups");
            if (!Directory.Exists(Essentials.Path + "/Data/Files")) Directory.CreateDirectory(Essentials.Path + "/Data/Files");
            if (!Directory.Exists(Essentials.Path + "/Data/DeletedFiles")) Directory.CreateDirectory(Essentials.Path + "/Data/DeletedFiles");
            if (!File.Exists(Essentials.Path + "/Data/Blogs.json")) File.Create(Essentials.Path + "/Data/Blogs.json").Dispose();
            if (!File.Exists(Essentials.Path + "/Data/Categorys.json")) File.Create(Essentials.Path + "/Data/Categorys.json").Dispose();
            if (!File.Exists(Essentials.Path + "/Data/ImagesManager.json")) File.Create(Essentials.Path + "/Data/ImagesManager.json").Dispose(); ;
            if (!File.Exists(Essentials.Path + "/Data/FilesManager.json")) File.Create(Essentials.Path + "/Data/FilesManager.json").Dispose(); ;
        }
        public static void BackUpData()
        {
            try
            {
                List<FileInfo> Files = new List<FileInfo>();
                DirectoryInfo dInfo = new DirectoryInfo(Essentials.Path + "/Data/Images/");
                foreach (FileInfo _image in dInfo.GetFiles("*.png"))
                {
                    Files.Add(_image);
                }
                string _Path = Essentials.Path + "/Data/Backups/" + DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") + "_DataBackup.zip";
                using (ZipArchive zipFile = System.IO.Compression.ZipFile.Open(_Path, ZipArchiveMode.Create))
                {
                    ZipArchiveEntry entry;
                    zipFile.CreateEntryFromFile(Essentials.Path + "/Data/Blogs.json", System.IO.Path.GetFileName(Essentials.Path + "/Data/Blogs.json"));
                    zipFile.CreateEntryFromFile(Essentials.Path + "/Data/Categorys.json", System.IO.Path.GetFileName(Essentials.Path + "/Data/Categorys.json"));
                    zipFile.CreateEntryFromFile(Essentials.Path + "/Data/ImagesManager.json", System.IO.Path.GetFileName(Essentials.Path + "/Data/ImagesManager.json"));
                    zipFile.CreateEntryFromFile(Essentials.Path + "/Data/FilesManager.json", System.IO.Path.GetFileName(Essentials.Path + "/Data/FilesManager.json"));

                    foreach (FileInfo file in Files)
                    {
                        entry = zipFile.CreateEntryFromFile(file.FullName, "Images/" + System.IO.Path.GetFileName(file.Name));
                    }
                }
                MessageBox.Show("Successfully Created Backup!", "Info");
            }
            catch (Exception e)
            {
                ErrorMessage = "Could not Create Backup!\n" + e.Message;
            }
        }
        public static void CheckConfig()
        {
            if (!Directory.Exists(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/Data/")) Directory.CreateDirectory(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/Data/");
            if (!File.Exists(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/Data/Config.json")) File.Create(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/Data/Config.json");
            UpdateConfig();
        }
        public static void LoadConfig() => Config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/Data/Config.json"));
        public static void UpdateConfig()
        {
            using (StreamWriter sw = File.CreateText(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/Data/Config.json"))
            {
                string SerializedJson = JsonConvert.SerializeObject(Config, Formatting.Indented);
                sw.WriteLine(SerializedJson);
                sw.Close();
            }
        }
        public static void LoadData(EventHandler ButtonClickHandler, EventHandler InitializeEvent)
        {
            Essentials.Categorys.Clear();
            Essentials.Images.Clear();
            Essentials.ImagesSelected.Clear();
            Essentials.Files.Clear();
            List<Blog> BlogsList = new List<Blog>();
            List<LoadingCategory> CategoryList = new List<LoadingCategory>();
            List<Image> ImageList = new List<Image>();
            List<Image> FileList = new List<Image>();

            string JsonFile = File.ReadAllText(Path + "/Data/Blogs.json");
            BlogsList = JsonConvert.DeserializeObject<List<Blog>>(JsonFile);

            JsonFile = File.ReadAllText(Path + "/Data/Categorys.json");
            CategoryList = JsonConvert.DeserializeObject<List<LoadingCategory>>(JsonFile);

            JsonFile = File.ReadAllText(Path + "/Data/ImagesManager.json");
            ImageList = JsonConvert.DeserializeObject<List<Image>>(JsonFile);

            JsonFile = File.ReadAllText(Path + "/Data/FilesManager.json");
            FileList = JsonConvert.DeserializeObject<List<Image>>(JsonFile);

            if (ImageList != null)
            {
                foreach (Image _image in ImageList)
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
            }
            if (FileList != null)
            {
                foreach (Image _image in FileList)
                {
                    try
                    {
                        if (_image.ID.Length != 9)
                        {
                            ErrorMessage = "Could not Load File with the ID " + _image.ID + ",\nPlease delete This File ID in the File \"FilesManager.json\"\nAnd Re -add the Correct File. Error 1";
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
                                ErrorMessage = "Could not Load File with the ID " + _image.ID + ",\nPlease delete This File ID in the File \"FilesManager.json\"\nAnd Re -add the Correct File. Error 2";
                                continue;
                            }
                        }
                    }
                    catch
                    {
                        ErrorMessage = "Could not Load File with the ID " + _image.ID + ",\nPlease delete This File ID in the File \"FilesManager.json\"\nAnd Re -add the Correct File. Error 3";
                        continue;
                    }
                    Files.Add(_image.ID, new Image(_image.DisplayText, _image.Title, _image.Creator, _image.Creation, _image.Path, _image.ID));
                }
            }
            if (CategoryList != null)
            {
                foreach (LoadingCategory cat in CategoryList)
                {
                    Dictionary<string, BlogControl> _Blogs = new Dictionary<string, BlogControl>();
                    foreach (Blog _blog in BlogsList.Where(x => x.CategoryID == cat.ID))
                    {
                        _Blogs.Add(_blog.ID, new BlogControl(_blog, true, ButtonClickHandler, InitializeEvent));
                    }
                    Essentials.Categorys.Add(cat.ID, new CategoryControl(new Category(cat.Title, _Blogs, cat.ID)));
                }
            }
        }
        public static void UpdateData()
        {
            List<LoadingCategory> LoadCategorys = new List<LoadingCategory>();
            List<Blog> LoadBlogs = new List<Blog>();
            List<Image> LoadImages = new List<Image>();
            List<Image> LoadFiles = new List<Image>();

            foreach (CategoryControl _Category in Essentials.Categorys.Values)
            {
                LoadCategorys.Add(new LoadingCategory(_Category.LocalCategory.Title, _Category.LocalCategory.ID));
                foreach (BlogControl _Blog in _Category.LocalCategory.Blogs.Values)
                {
                    LoadBlogs.Add(_Blog.LocalBlog);
                }
            }
            foreach (Image _image in Essentials.Images.Values)
            {
                LoadImages.Add(new Image(_image.DisplayText, _image.Title, _image.Creator, _image.Creation, _image.Path, _image.ID));
            }
            foreach (Image _image in Essentials.Files.Values)
            {
                LoadFiles.Add(new Image(_image.DisplayText, _image.Title, _image.Creator, _image.Creation, _image.Path, _image.ID));
            }
            using (StreamWriter sw = File.CreateText(Path + "/Data/Categorys.json"))
            {
                string SerializedJson = JsonConvert.SerializeObject(LoadCategorys, Formatting.Indented);
                sw.WriteLine(SerializedJson);
                sw.Close();
            }
            using (StreamWriter sw = File.CreateText(Path + "/Data/Blogs.json"))
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
            using (StreamWriter sw = File.CreateText(Path + "/Data/FilesManager.json"))
            {
                string SerializedJson = JsonConvert.SerializeObject(LoadFiles, Formatting.Indented);
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
    public class Config
    {
        public static string Path { get; set; }
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
        public new Image Image { get; set; }
        public ClickState ClickState { get; set; }
    }
    public class Blog
    {
        public string Title { get; set; }
        public string Creator { get; set; }
        public string Description { get; set; }
        public string CreationDate { get; set; }
        public string[] Content { get; set; }
        public List<string> ImageIDs { get; set; }
        public List<string> FileIDs { get; set; }
        public string ID { get; set; }
        public string CategoryID { get; set; }
        public Blog(string _Title, string _Creator, string _Description, string _CreationDate, string[] _Content, string _ID, List<string> _ImageIDs, List<string> _FileIDs, string _CategoryID)
        {
            Title = _Title;
            Creator = _Creator;
            Description = _Description;
            CreationDate = _CreationDate;
            Content = _Content;
            ID = _ID;
            ImageIDs = _ImageIDs;
            FileIDs = _FileIDs;
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
        Delete,
        Backup,
        RenameSelect,
        Rename
    }

}
