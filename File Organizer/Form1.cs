using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Organizer
{
    public partial class Form1 : Form
    {
        string sSelectedFolder; // path to selected folder
        string[] files; // all filenames
        DirectoryInfo dir;

        public Form1()
        {
            InitializeComponent();
            string userName = Environment.UserName; // get user name
            sSelectedFolder = @"C:\Users\" + userName + @"\Downloads"; // use download folder as default
            
            files = Directory.GetFiles(sSelectedFolder); // load all files from download folder
            fileCount.Text = files.Length.ToString(); // how much files
            currentFolder.Text = sSelectedFolder; // print selected folder in window
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            //
            //
            // Button, that selects custom folder
            //
            //

            sSelectedFolder = getPath(); // get user selected folder
            currentFolder.Text = sSelectedFolder; // print selected folder in window
            files = Directory.GetFiles(sSelectedFolder); // get all files
            fileCount.Text = files.Length.ToString(); // number of files
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

            //
            //
            //Button that calls organize function
            //
            //

            organize(); // call organize function
        }

        private void organize()
        {
            foreach (string name in files) // for each file in folder
            {
                if (getFolderNameByExtension(name) != "") // Calls function that retuns folder name for given file extension, if no folder name is returned, it will leave it as is
                {
                    string pastaDestino = sSelectedFolder + @"\" + getFolderNameByExtension(name) + @"\" + Path.GetFileName(name); // New file path
                    new System.IO.FileInfo(pastaDestino).Directory.Create(); // Create folder retuned by getFolderNameByExtension
                    File.Move(name, pastaDestino); // move the file to new directory
                }
                
            }

            files = Directory.GetFiles(sSelectedFolder); // Get all files in selected folder
            fileCount.Text = files.Length.ToString(); // Number of files
            MessageBox.Show("Yaaaay, organized files! xD"); // Popup that everything is done
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName">Directory of a file</param>
        /// <returns>Folder Name by filetype</returns>
        private string getFolderNameByExtension(string fileName)
        {

            //
            //
            // Function to return folder name for given extension
            //
            //

            string ext = Path.GetExtension(fileName);
            string folderName = "";

            if (ext.Equals(".ext", StringComparison.OrdinalIgnoreCase) || ext.Equals(".pdf", StringComparison.OrdinalIgnoreCase) || ext.Equals(".docx", StringComparison.OrdinalIgnoreCase))
            {
                folderName = "Text Files";
            }
            else if (ext.Equals(".exe", StringComparison.OrdinalIgnoreCase) || ext.Equals(".msi", StringComparison.OrdinalIgnoreCase))
            {
                folderName = "Applications and Games";
            }
            else if (ext.Equals(".zip", StringComparison.OrdinalIgnoreCase) || ext.Equals(".rar", StringComparison.OrdinalIgnoreCase) || ext.Equals(".7zip", StringComparison.OrdinalIgnoreCase))
            {
                folderName = "Compressed Files";
            }
            else if (ext.Equals(".img", StringComparison.OrdinalIgnoreCase) || ext.Equals(".iso", StringComparison.OrdinalIgnoreCase) || ext.Equals(".dmg", StringComparison.OrdinalIgnoreCase))
            {
                folderName = "Install Media";
            }
            else if (ext.Equals(".png", StringComparison.OrdinalIgnoreCase) || ext.Equals(".jpg", StringComparison.OrdinalIgnoreCase) || ext.Equals(".jpeg", StringComparison.OrdinalIgnoreCase) || ext.Equals(".gif", StringComparison.OrdinalIgnoreCase))
            {
                folderName = "Images";
            }
            else if (ext.Equals(".mp3", StringComparison.OrdinalIgnoreCase) || ext.Equals(".aac", StringComparison.OrdinalIgnoreCase))
            {
                folderName = "Musics";
            }
            else if (ext.Equals(".mp4", StringComparison.OrdinalIgnoreCase) || ext.Equals(".flv", StringComparison.OrdinalIgnoreCase) || ext.Equals(".3gp", StringComparison.OrdinalIgnoreCase) || ext.Equals(".avi", StringComparison.OrdinalIgnoreCase))
            {
                folderName = "Videos";
            }
            else if (ext.Equals(".html", StringComparison.OrdinalIgnoreCase) || ext.Equals(".css", StringComparison.OrdinalIgnoreCase) || ext.Equals(".php", StringComparison.OrdinalIgnoreCase) || ext.Equals(".url", StringComparison.OrdinalIgnoreCase))
            {
                folderName = "Web Files";
            }
            else if (ext.Equals(".lnk", StringComparison.OrdinalIgnoreCase))
            {
                folderName = "Shortcuts";
            }
            else if(ext.Equals(".ini", StringComparison.OrdinalIgnoreCase))
            {
                folderName = "";
            }
            else
            {
                folderName = "Other Files";
            }


            return folderName;
        }

        public string getPath()
        {

            //
            //
            // Function for selecting folder
            //
            //

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            // fbd.Description = "Custom Description";

            if (fbd.ShowDialog() == DialogResult.OK) // If valid valid folder is returned, return it's path
            {
                dir = new DirectoryInfo(fbd.SelectedPath);
                return fbd.SelectedPath;
            }
            else // Else return downloads folder path
            {
                string downloads = "";
                string userName = Environment.UserName;
                downloads = @"C:\Users\"+ userName +@"\Downloads";
                return downloads;
            }
        }

        private void CurrentFolder_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void FileCount_Click(object sender, EventArgs e)
        {

        }
    }
}
