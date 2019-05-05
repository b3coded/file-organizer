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
            Console.WriteLine(userName);

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

        private string getFolderNameByExtension(string fileName)
        {
            string ext = Path.GetExtension(fileName);
            string folderName = "";



            if (ext.Equals(".ext") || ext.Equals(".pdf") || ext.Equals(".docx"))
            {
                folderName = "Text Files";
            }
            else if (ext.Equals(".exe") || ext.Equals(".msi"))
            {
                folderName = "Applications and Games";
            }
            else if (ext.Equals(".zip") || ext.Equals(".rar") || ext.Equals(".7zip"))
            {
                folderName = "Compressed Files";
            }
            else if (ext.Equals(".img") || ext.Equals(".iso") || ext.Equals(".dmg"))
            {
                folderName = "Install Media";
            }
            else if (ext.Equals(".png") || ext.Equals(".jpg") || ext.Equals(".jpeg") || ext.Equals(".gif"))
            {
                folderName = "Images";
            }
            else if (ext.Equals(".mp3") || ext.Equals(".aac"))
            {
                folderName = "Musics";
            }
            else if (ext.Equals(".mp4" )|| ext.Equals(".flv") || ext.Equals(".3gp") || ext.Equals(".avi"))
            {
                folderName = "Videos";
            }
            else if (ext.Equals(".html") || ext.Equals(".css") || ext.Equals(".php") || ext.Equals(".url"))
            {
                folderName = "Web Files";
            }
            else if(ext.Equals(".ini"))
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
