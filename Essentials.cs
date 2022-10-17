using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Blogz
{
    public static class Essentials
    {
        public static List<CategoryControl> Categorys = new List<CategoryControl>();
        // TODO: Make a Path Selector
        public static string Path = "C:/Blogz";

        [DllImport("kernel32")]
        public static extern IntPtr GetConsoleWindow();
        public static Point GetConsolePoint(Point ClickPosition)
        {
            IntPtr consoleHwnd = GetConsoleWindow();
            Rect dwnRect = GetExtendedFrameBounds(consoleHwnd);
            Point local = new Point();
            local.X = ClickPosition.X - dwnRect.Left;
            local.Y = ClickPosition.Y - dwnRect.Top;
            return local;
        }
        private const int DWMWA_EXTENDED_FRAME_BOUNDS = 9;

        [DllImport(@"dwmapi.dll")]
        private static extern int DwmGetWindowAttribute(IntPtr hwnd, int dwAttribute, out Rect pvAttribute, int cbAttribute);

        public static Rect GetExtendedFrameBounds(IntPtr hwnd)
        {
            int hresult = DwmGetWindowAttribute(hwnd, DWMWA_EXTENDED_FRAME_BOUNDS, out Rect rect, Marshal.SizeOf(typeof(Rect)));

            if (hresult >= 1)
            {
                throw Marshal.GetExceptionForHR(hresult);
            }

            return rect;
        }
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
    }
    public class Blog
    {
        public string Title { get; set; }
        public string Creator { get; set; }
        public string Description { get; set; }
        public string CreationDate { get; set; }
        public string[] Content { get; set; }
        public int ID { get; set; }
        public List<Image> Images { get; set; }
        public Blog(string _Title, string _Creator, string _Description, string _CreationDate, string[] _Content, int _ID, List<Image> _Images)
        {
            Title = _Title;
            Creator = _Creator;
            Description = _Description;
            CreationDate = _CreationDate;
            Content = _Content;
            ID = _ID;
            Images = _Images;
        }
    }
    public class Image
    {
        public string Name = "Image0000";
        public string Path = "";
        public int ID = 0;
        public Image(string _Name, string _Path, int _ID)
        {
            Name = _Name;
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
