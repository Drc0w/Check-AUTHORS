﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CheckAuthors
{
    public partial class CheckAuthorsForm : Form
    {
        public CheckAuthorsForm()
        {
            InitializeComponent();
        }

        private void CheckAuthorsForm_Load(object sender, EventArgs e)
        {

        }

        private void loadListButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK && dialog.CheckFileExists)
            {
                listView1.Items.Clear();
                addToList(dialog.FileName);
            }
        }

        private void addToList(string filename)
        {
            try
            {
                FileStream file = new FileStream(filename, FileMode.Open);
                StreamReader sr = new StreamReader(file);
                string line = sr.ReadLine();
                while (line != null)
                {
                    ListViewItem item = new ListViewItem(new[]
                    {
                        line
                    });
                    line = sr.ReadLine();
                    listView1.Items.Add(item);
                }
                file.Close();
            }
            catch
            {

            }

        }

        private void loadDirectoriesButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string subfolder in Directory.EnumerateDirectories(dialog.SelectedPath))
                {
                    checkAuthorsFile(subfolder + "\\AUTHORS");
                }
            }
        }

        private void checkAuthorsFile(string filename)
        {
            FileStream file = null;
            StreamReader sr = null;
            try
            {
                file = new FileStream(filename, FileMode.Open);
                sr = new StreamReader(file);
                bool remove = true;

                string line = sr.ReadLine();
                int index = 0;
                string[] login = new string[5];
                while (line != null)
                {
                    if (line.Length > 0 && line != "\n" && line != ""
                        && line[line.Length - 1] != '\n' && line[0] != '*'
                        || ((line[line.Length - 1] < 'a'
                        || line[line.Length - 1] > 'z')
                        && (line[line.Length - 1] < '0'
                        || line[line.Length - 1] > '9'))
                        || line[1] != ' ')
                    {
                        remove = false;
                        break;
                    }
                    login[index++] = line;
                    line = sr.ReadLine();
                }
                if (remove)
                    for (int i = 0; i < listView1.Items.Count; i++)
                        for (int j = 0; j < login.Length && login[j] != null; j++)
                            if (listView1.Items[i].Text == login[j].Substring(2))
                            {
                                listView1.Items.Remove(listView1.Items[i]);
                                break;
                            }
                sr.Close();
                file.Close();
            }
            catch (Exception e)
            {
                if (sr != null)
                    sr.Close();
                if (file != null)
                    file.Close();
            }
        }


    }
}
