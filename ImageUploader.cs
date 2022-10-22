using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
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
            if (Path == "") Essentials.ErrorMessage = "Please Select a Image!";
            else if (DisplayTtxtBox.Text == "") Essentials.ErrorMessage = "Please Enter a Valid Display Text!";
            else if (TitleTxtBox.Text == "") Essentials.ErrorMessage = "Please Enter a Valid Title!";
            else if (CreatorTxtBox.Text == "") Essentials.ErrorMessage = "Please Enter a Valid Creator!";
            else if (CreationTxtBox.Text == "") Essentials.ErrorMessage = "Please Enter a Valid Creation Date!";
            else
            {
                string NewID = IdGetter.GetHighestImageID();
                try
                {
                    File.Copy(Path, Essentials.Path + "/Data/Images/" + NewID + ".png");
                    Essentials.Images.Add(NewID, new Image(DisplayTtxtBox.Text, TitleTxtBox.Text, CreatorTxtBox.Text, CreationTxtBox.Text, "/Data/Images/" + NewID + ".png", NewID));
                    Essentials.UpdateData();
                    Essentials.LoadData(FormsButtonClickHandler, FormsInitializeHandler);
                }
                catch (Exception x)
                {
                    Essentials.ErrorMessage = "Something went Wrong when Trying to Upload the File!\n" + x.Message;
                }
                Close();
            }
        }
        
    }
}
