using System;
using System.IO;
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
        public ClickState LocalClickState;
        public ImageUploader(EventHandler ButtonClickHandler, EventHandler InitializeHandler, ClickState _ClickState)
        {
            FormsButtonClickHandler = ButtonClickHandler;
            FormsInitializeHandler = InitializeHandler;
            LocalClickState = _ClickState;
            InitializeComponent();
            Initialize();
        }
        public void Initialize()
        {
            if(LocalClickState == ClickState.Open) Text = "Upload a Image"; 
            else if(LocalClickState == ClickState.Edit) Text = "Upload a File"; 
        }
        private void ChooseFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(LocalClickState == ClickState.Open) openFileDialog.Filter = "Images |*.png;*.jpg;*.jpeg";
            else if(LocalClickState == ClickState.Edit) openFileDialog.Filter = "File |*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Path = openFileDialog.FileName;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e) => Close();

        private void UploadButton_Click(object sender, EventArgs e)
        {
            if (Path == "") Essentials.ErrorMessage = "Please Select a File!";
            else if (DisplayTtxtBox.Text == "") Essentials.ErrorMessage = "Please Enter a Valid Display Text!";
            else if (TitleTxtBox.Text == "") Essentials.ErrorMessage = "Please Enter a Valid Title!";
            else if (CreatorTxtBox.Text == "") Essentials.ErrorMessage = "Please Enter a Valid Creator!";
            else if (CreationTxtBox.Text == "") Essentials.ErrorMessage = "Please Enter a Valid Creation Date!";
            else
            {
                if(LocalClickState == ClickState.Open)
                {
                    string NewID = IdGetter.GetHighestImageID();
                    try
                    {
                        File.Copy(Path, Essentials.Path + "/Data/Images/" + NewID + ".png");
                        Essentials.Images.Add(NewID, new Image(DisplayTtxtBox.Text, TitleTxtBox.Text, CreatorTxtBox.Text, CreationTxtBox.Text, "/Data/Images/" + NewID + ".png", NewID));    
                    }
                    catch (Exception x)
                    {
                        Essentials.ErrorMessage = "Something went Wrong when Trying to Upload the Image!\n" + x.Message;
                    }
                }
                else if (LocalClickState == ClickState.Edit)
                {
                    string NewID = IdGetter.GetHighestFileID();
                    try
                    {
                        string Extension = System.IO.Path.GetExtension(Path);
                        File.Copy(Path, Essentials.Path + "/Data/Files/" + NewID + Extension);
                        Essentials.Files.Add(NewID, new Image(DisplayTtxtBox.Text, TitleTxtBox.Text, CreatorTxtBox.Text, CreationTxtBox.Text, "/Data/Files/" + NewID + Extension, NewID));
                    }
                    catch (Exception x)
                    {
                        Essentials.ErrorMessage = "Something went Wrong when Trying to Upload the File!\n" + x.Message;
                    }
                }
                Essentials.UpdateData();
                Essentials.LoadData(FormsButtonClickHandler, FormsInitializeHandler);
                Close();
            }
        }

    }
}
