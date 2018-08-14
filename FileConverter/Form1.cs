﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = inputFileBox.Text;
            Image image = Image.FromFile(fileName);
            DirectoryInfo di = new DirectoryInfo(fileName);
            
            string outputFile = outputTextBox.Text + "\\" + di.Name.Substring(0, di.Name.Length - 3)+"png";
            image.Save(outputFile, System.Drawing.Imaging.ImageFormat.Png);
            
            
            
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Please choose a file";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                inputFileBox.Text = fdlg.FileName;
            }
        }

        private void inputFileBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = true;
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                outputTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
