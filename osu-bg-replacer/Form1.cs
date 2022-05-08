using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.VisualBasic.FileIO;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;


namespace osu_bg_replacer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DirectorySelectButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowNewFolderButton = false;
            folder.RootFolder = Environment.SpecialFolder.MyComputer;
            folder.SelectedPath = DirectoryPath.Text;
            DialogResult path = folder.ShowDialog();
            if (path == DialogResult.OK)
            {
                if (!File.Exists(folder.SelectedPath + "\\osu!.exe"))
                {
                    MessageBox.Show("请选择osu!.exe所在的文件夹", "文件夹错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    DirectorySelectButton_Click(sender, e);
                    return;
                }
            }
            DirectoryPath.Text = folder.SelectedPath + "\\";
            GetFilesButton_Click(sender, e);
        }

        private void ReplaceDirectorySelectButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowNewFolderButton = false;
            folder.RootFolder = Environment.SpecialFolder.MyComputer;
            folder.SelectedPath = ReplaceDirectoryPath.Text;
            DialogResult path = folder.ShowDialog();
            ReplaceDirectoryPath.Text = folder.SelectedPath + "\\";
            GetReplaceFilesButton_Click(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (RegistryKey osureg = Registry.ClassesRoot.OpenSubKey("osu\\DefaultIcon"))
            {
                if (osureg != null)
                {
                    string osukey = osureg.GetValue(null).ToString();
                    string osupath = osukey.Remove(0, 1);
                    osupath = osupath.Remove(osupath.Length - 11);
                    DirectoryPath.Text = osupath;
                }
            }
        }

        private void GetFilesButton_Click(object sender, EventArgs e)
        {
            if (!DirectoryPath.Text.EndsWith("\\")) DirectoryPath.Text = DirectoryPath.Text + "\\";
            ElementListBox.Items.Clear();
            string[] pics = Directory.GetFiles(DirectoryPath.Text + "Data\\bg\\", "*.jpg", System.IO.SearchOption.TopDirectoryOnly);
            foreach (string p in pics)
            {
                // skip the tooooo looonngggg file path
                if (p.Length > 100) continue;
                // add files to list
                ElementListBox.Items.Add(p);
            }
            for (int i = 0; i < ElementListBox.Items.Count; i++)
                ElementListBox.SetItemChecked(i, true);
        }

        private void GetReplaceFilesButton_Click(object sender, EventArgs e)
        {
            if (!ReplaceDirectoryPath.Text.EndsWith("\\")) ReplaceDirectoryPath.Text = ReplaceDirectoryPath.Text + "\\";
            ReplaceElementListBox.Items.Clear();
            string[] pics = Directory.GetFiles(ReplaceDirectoryPath.Text, "*.jpg", System.IO.SearchOption.TopDirectoryOnly);
            foreach (string p in pics)
            {
                // skip the tooooo looonngggg file path
                if (p.Length > 100) continue;
                // add files to list
                ReplaceElementListBox.Items.Add(p);
            }
            for (int i = 0; i < ReplaceElementListBox.Items.Count; i++)
                ReplaceElementListBox.SetItemChecked(i, true);
        }

        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            ReplaceButton.Enabled = false;
            List<string> deletelist = new List<string>();
            List<string> replacelist = new List<string>();
            foreach (string file in ElementListBox.CheckedItems)
                deletelist.Add(file);
            foreach (string file in ReplaceElementListBox.CheckedItems)
                replacelist.Add(file);
            if (deletelist.Count != replacelist.Count)
            {
                DialogResult dr = MessageBox.Show("原始图片数量与替换图片数量不一致，是否继续替换？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr != DialogResult.Yes) return;
            }
            // step1: remove files
            foreach (string file in deletelist)
            {
                try
                {
                    // FileSystem.DeleteFile(file, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently);
                    FileSystem.DeleteFile(file, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                }
                catch (FileNotFoundException) { }
                catch (NotSupportedException) { }
            }

            System.Threading.Thread.Sleep(2000);

            // step2: replace files
            int i = 0;
            foreach (string file in replacelist)
            {
                if (i < replacelist.Count && i < deletelist.Count)
                {
                    File.Copy(replacelist[i], deletelist[i]);
                    ElementListBox.Items.Remove(deletelist[i]);
                    ReplaceElementListBox.Items.Remove(replacelist[i]);
                    i += 1;
                }
            }
            MessageBox.Show("替换完成！", "任务结束", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReplaceButton.Enabled = true;
        }

    }
}
