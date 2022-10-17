using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Blogz
{
    public static class Essentials
    {
        public static List<CategoryControl> Categorys = new List<CategoryControl>();
    }
    public class CustomButton : Button
    {
        public int ID { get; set; }
        public ClickState ClickState { get; set; }
    }
    public enum ClickState
    {
        Open,
        Edit,
        Delete
    }
}
