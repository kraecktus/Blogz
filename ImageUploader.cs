using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blogz
{
    public partial class ImageUploader : Form
    {
        public string Path
        {
            get
            {
                return _Path;
            }
            set
            {
                _Path = value;
                PathLabel.Text = "Path: " + _Path;
            }
        }
        public string _Path = "";
        public EventHandler FormsButtonClickHandler;
        public EventHandler FormsInitializeHandler;
        public ImageUploader(EventHandler ButtonClickHandler, EventHandler InitializeHandler)
        {
            FormsButtonClickHandler = ButtonClickHandler;
            FormsInitializeHandler = InitializeHandler;
            InitializeComponent();
        }

        private void ChooseFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images |*.png;*.jpg;*.jpeg";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Path = openFileDialog.FileName;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e) => Close();

        private void UploadButton_Click(object sender, EventArgs e)
        {
            if (Path == "") MessageBox.Show("Please Select a Image!", "Info");
            else if (DisplayTtxtBox.Text == "") MessageBox.Show("Please Enter a Valid Display Text!", "Info");
            else if (TitleTxtBox.Text == "") MessageBox.Show("Please Enter a Valid Title!", "Info");
            else if (CreatorTxtBox.Text == "") MessageBox.Show("Please Enter a Valid Creator!", "Info");
            else if (CreationTxtBox.Text == "") MessageBox.Show("Please Enter a Valid Creation Date!", "Info");
            else
            {
                string NewID = GetHighestID();
                try
                {
                    File.Copy(Path, Essentials.Path + "/Data/Images/" + NewID + ".png");
                    Essentials.Images.Add(NewID, new Image(DisplayTtxtBox.Text, TitleTxtBox.Text, CreatorTxtBox.Text, CreationTxtBox.Text, Path, NewID));
                    Essentials.UpdateData();
                    Essentials.LoadData(FormsButtonClickHandler, FormsInitializeHandler);
                }
                catch
                {
                    MessageBox.Show("Something went Wrong when Trying to Upload the File!", "Error");
                }
                Close();
            }
        }
        public string GetHighestID()
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
    }
}
