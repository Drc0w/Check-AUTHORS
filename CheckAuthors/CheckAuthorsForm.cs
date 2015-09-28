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
                    ListViewItem item = new ListViewItem(new []
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
            try
            {
                FileStream file = new FileStream(filename, FileMode.Open);
                StreamReader sr = new StreamReader(file);

                string line = sr.ReadLine();
                while (line != null)
                {
                    for (int i = 0; i < listView1.Items.Count; i++)
                        if (listView1.Items[i].Text == line.Substring(2))
                        {
                            listView1.Items.Remove(listView1.Items[i]);
                            break;
                        }
                    line = sr.ReadLine();
                }
                file.Close();
            }
            catch
            {

            }
        }


    }
}