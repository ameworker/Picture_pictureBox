using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using Picture_pictureBox.Properties;

namespace Picture_pictureBox
{
    public partial class Form1 : Form
    {
        public bool IsLastPicture
        {
            get 
            { 
                return Settings.Default.IsLastPicture;
            }
            set 
            { 
                Settings.Default.IsLastPicture = value;
            }
        }
        public string LastPictureLocation
        {
            get
            {
                return Settings.Default.LastPictureLocation;
            }
            set
            {
                Settings.Default.LastPictureLocation = value;
            }
        }
        private string _fileToDisplay;
        private Bitmap MyImage;
        private string _folderForPictures;
        public Form1()
        {

            _folderForPictures = CreateNewFolder("FolderForPictures");
            InitializeComponent();

            if (IsLastPicture)
            {
                ShowMyImage(Settings.Default.LastPictureLocation);
            }
            

        }

        private string CreateNewFolder(string folderName)
        {
            folderName = new DirectoryInfo(Program.FilePath)
                .CreateSubdirectory(folderName)
                .FullName;
            return Path.GetFullPath(folderName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            if (pictureBox1.Image == null) { OptionsVisibilityChange(false); }
            else { OptionsVisibilityChange(true); }
        }

        private void OptionsVisibilityChange(bool change)
        {
            btnRemovePicture.Visible = change;
            label2.Visible = change;
            label3.Visible = change;
            txbAnswerAnimal.Visible = change;
            txbAnswerNumber.Visible = change;
            btnSend.Visible = change;
            groupBox1.Visible = change;
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Wybierz zdjęcie";
            ofd.InitialDirectory = _folderForPictures;
            ofd.ShowDialog();

            if (ofd.FileName != "")
            {
                _fileToDisplay = ofd.FileName;
                lblLocation.Text = _fileToDisplay;
                ShowMyImage(_fileToDisplay);
            }
            else
            {
                _fileToDisplay = null;
            }
        }


        public void ShowMyImage(string fileToDisplay)
        {
            if (MyImage != null)
            {
                MyImage.Dispose();
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            MyImage = new Bitmap(fileToDisplay);
            pictureBox1.Image = (Image)MyImage;
            OptionsVisibilityChange(true);
            _fileToDisplay = fileToDisplay;
            lblLocation.Text = _fileToDisplay;
        }

        private void btnRemovePicture_Click(object sender, EventArgs e)
        {
            RemovePicture();
            OptionsVisibilityChange(false);
        }

        private void RemovePicture()
        {
            MyImage = null;
            pictureBox1.Image = (Image)MyImage;
            _fileToDisplay = null;
            lblLocation.Text = _fileToDisplay;

        }

        private string GetFileName(string fileToDisplay)
        {
            string fileName = Path.GetFileName(fileToDisplay);
            return fileName;
        }

        private string GetPictureName(string fileName)
        {
            string pictureName;
            var extension = Path.GetExtension(fileName);
            pictureName = fileName.Replace(extension, "");


            return pictureName;
        }
        private int GetNumberAboutPicture(string pictureName)
        {
            int number;
            string resultString = "";
            resultString = Regex.Match(pictureName, @"\d+").Value;
            if (resultString != "")
            {
                number = Int32.Parse(resultString);
                return number;
            }
            else
            {
                number = 1; return number;
            }


        }
        private string GetAnimalFromPicture(string pictureName)
        {
            string animalName = "";
            char[] strArray = pictureName.ToCharArray();
            foreach (var item in strArray)
            {
                if (!char.IsDigit(item))
                    animalName = animalName + item;
            }
            return animalName;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var fileName = GetFileName(_fileToDisplay);
            var pictureName = GetPictureName(fileName);
            var animalNumber = GetNumberAboutPicture(pictureName).ToString();
            var animalName = GetAnimalFromPicture(pictureName);

            string answer = String.Concat(txbAnswerNumber.Text, txbAnswerAnimal.Text);
            if (answer == String.Concat(animalNumber, animalName))
            {
                MyImage = new Bitmap(Resources.Congrats);
                pictureBox1.Image = (Image)MyImage;
            }
            else
            {
                MyImage = new Bitmap(Resources.Loser1);
                pictureBox1.Image = (Image)MyImage;
                MessageBox.Show($"Poprawna odpowiedź: {animalName} {animalNumber}");
            }
        }

        private void btnRandomPicture_Click(object sender, EventArgs e)
        {
            string pictureLocation = _folderForPictures;
            int howManyForRandom = CountPictures(pictureLocation);
            if (howManyForRandom <5)
            {
                MessageBox.Show($"Aby rozpocząć losowanie musisz mieć co najmniej 5 plików graficznych w folderze. Dodaj pliki do folderu: \n {pictureLocation}");
            }
            else
            {
                string[] allFiles = Directory.GetFiles(pictureLocation, "*.*", SearchOption.TopDirectoryOnly);
                foreach (string file in allFiles)
                {
                    FileInfo fileInfo = new FileInfo(file);
                }

                howManyForRandom = allFiles.Length;
                Random random = new Random();
                int randomElementNumber = random.Next(howManyForRandom);
                string randomPicture = allFiles[randomElementNumber];
                ShowMyImage(randomPicture);
            }
            

        }

        private string FindFolderForRandom()
        {
            string folderLocation;
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            folderLocation = dialog.SelectedPath;

            return folderLocation;
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            _folderForPictures = FindFolderForRandom();
        }

        private int CountPictures(string folderLocation)
        {
            int howMany = 0;
            string[] allFiles = Directory.GetFiles(folderLocation, "*.*", SearchOption.TopDirectoryOnly);
            foreach (string file in allFiles)
            {
                FileInfo fileInfo = new FileInfo(file);
            }

            howMany = allFiles.Length;
            return howMany;
        }

        private void txbAnswerAnimal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbAnswerNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (pictureBox1.Image !=null)
            {
                IsLastPicture = true;
                LastPictureLocation = _fileToDisplay;
            }
            else
            {
                IsLastPicture = false;
            }
            Settings.Default.Save();
        }
    }
}
