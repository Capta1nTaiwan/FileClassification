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

namespace File_Classify_Date
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectPathBtn_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxPath.Text = folderBrowserDialog1.SelectedPath;                
            }
        }

        private void DoClassifyBtn_Click(object sender, EventArgs e)
        {
            string[] allfiles = new string[999999];
            try
            {
                allfiles = Directory.GetFiles(tbxPath.Text, "*.*", SearchOption.AllDirectories);
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show("路徑錯誤，請檢查");
                return;
            }
            
            foreach (var file in allfiles)
            {
                FileInfo info = new FileInfo(file);
                DateTime Date = info.LastWriteTime;
                string DateOfFile = Date.Year + "-" + Date.Month + "-" + Date.Day;

                if (!Directory.Exists(Path.Combine(tbxPath.Text, DateOfFile)))
                {
                    Directory.CreateDirectory(Path.Combine(tbxPath.Text, DateOfFile));
                }

                File.Move(file, Path.Combine(tbxPath.Text, DateOfFile, info.Name));
            }
            MessageBox.Show("分類完成");
        }
    }
}
