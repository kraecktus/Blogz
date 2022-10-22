using System;
using System.IO;

namespace Blogz
{
    public static class IdGetter
    {
		public static string GetHighestCategoryID()
		{
			string CurrentHighestID = "Category00000";
			foreach (string _Category in Essentials.Categorys.Keys)
			{
				if (Convert.ToInt32(_Category.Split('y')[1]) > Convert.ToInt32(CurrentHighestID.Split('y')[1])) CurrentHighestID = _Category;
			}
			int NumStartIndex = 8;
			string NewNum = "";
			for (int i = 8; i < 13; i++)
			{
				int CurrNum = Convert.ToInt32(CurrentHighestID[i].ToString());
				if (CurrNum != 0)
				{
					NumStartIndex = i;
					break;
				}
			}
			for (int i = NumStartIndex; i < 13; i++)
			{
				NewNum += CurrentHighestID[i];
			}
			int Num = Convert.ToInt32(NewNum);
			Num++;
			NewNum = $"Category{Num,5:D5}";
			return NewNum;
		}
		public static string GetHighestBlogID()
		{
			string CurrentHighestID = "Blog00000";
			foreach (CategoryControl _Category in Essentials.Categorys.Values)
			{
				foreach (BlogControl _Blog in _Category.LocalCategory.Blogs.Values)
				{
					if (Convert.ToInt32(_Blog.LocalBlog.ID.Split('g')[1]) > Convert.ToInt32(CurrentHighestID.Split('g')[1])) CurrentHighestID = _Blog.LocalBlog.ID;
				}
			}
			int NumStartIndex = 4;
			string NewNum = "";
			for (int i = 4; i < 9; i++)
			{
				int CurrNum = Convert.ToInt32(CurrentHighestID[i].ToString());
				if (CurrNum != 0)
				{
					NumStartIndex = i;
					break;
				}
			}
			for (int i = NumStartIndex; i < 9; i++)
			{
				NewNum += CurrentHighestID[i];
			}
			int Num = Convert.ToInt32(NewNum);
			Num++;
			NewNum = $"Blog{Num,5:D5}";
			return NewNum;
		}
		public static string GetHighestImageID()
		{
			string CurrentHighestID = "Image00000";
			foreach (Image _image in Essentials.Images.Values)
			{
				if (Convert.ToInt32(_image.ID.Split('e')[1]) > Convert.ToInt32(CurrentHighestID.Split('e')[1])) CurrentHighestID = _image.ID;
			}
			int NumStartIndex = 5;
			string NewNum = "";
			for (int i = 5; i < 10; i++)
			{
				int CurrNum = Convert.ToInt32(CurrentHighestID[i].ToString());
				if (CurrNum != 0)
				{
					NumStartIndex = i;
					break;
				}
			}
			for (int i = NumStartIndex; i < 10; i++)
			{
				NewNum += CurrentHighestID[i];
			}
			int Num = Convert.ToInt32(NewNum);
			Num++;
			NewNum = $"Image{Num,5:D5}";
			return NewNum;
		}
		public static string GetHighestDeletedID()
		{
			string CurrentHighestID = "DeletedImage00000";
			DirectoryInfo dInfo = new DirectoryInfo(Essentials.Path + "/Data/DeletedImages/");

			foreach (FileInfo _image in dInfo.GetFiles("*.png"))
			{
				string CurrName = Path.GetFileNameWithoutExtension(_image.Name);
				if (Convert.ToInt32(CurrName.Split('e')[4]) > Convert.ToInt32(CurrentHighestID.Split('e')[4])) CurrentHighestID = CurrName;
			}
			int NumStartIndex = 13;
			string NewNum = "";
			for (int i = 13; i < 17; i++)
			{
				int CurrNum = Convert.ToInt32(CurrentHighestID[i].ToString());
				if (CurrNum != 0)
				{
					NumStartIndex = i;
					break;
				}
			}
			for (int i = NumStartIndex; i < 17; i++)
			{
				NewNum += CurrentHighestID[i];
			}
			int Num = Convert.ToInt32(NewNum);
			Num++;
			NewNum = $"DeletedImage{Num,5:D5}.png";
			return NewNum;
		}
	}
}
