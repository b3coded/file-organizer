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
        string sSelectedFolder;
        string[] files;
        DirectoryInfo dir;

        public Form1()
        {
            InitializeComponent();
            string userName = Environment.UserName;
            sSelectedFolder = @"C:\Users\" + userName + @"\Downloads";
            
            files = Directory.GetFiles(sSelectedFolder);
            fileCount.Text = files.Length.ToString();
            currentFolder.Text = sSelectedFolder;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            sSelectedFolder = getPath();
            currentFolder.Text = sSelectedFolder;
            files = Directory.GetFiles(sSelectedFolder);
            fileCount.Text = files.Length.ToString();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            organizar();
        }

        private void organizar()
        {
            foreach (string name in files)
            {
                if (getFolderNameByExtension(name) != "")
                {
                    string pastaDestino = sSelectedFolder + @"\" + getFolderNameByExtension(name) + @"\" + Path.GetFileName(name);
                    new System.IO.FileInfo(pastaDestino).Directory.Create();
                    File.Move(name, pastaDestino);
                }
                
            }

            files = Directory.GetFiles(sSelectedFolder);
            fileCount.Text = files.Length.ToString();
            MessageBox.Show("Yaaaay, organized files! xD");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName">Directory of a file</param>
        /// <returns>Folder Name by filetype</returns>
        private string getFolderNameByExtension(string fileName)
        {

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
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            // fbd.Description = "Custom Description";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                dir = new DirectoryInfo(fbd.SelectedPath);
                return fbd.SelectedPath;
            }
            else
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
