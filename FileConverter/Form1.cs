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
        Image image;
        public Form1()
        {
            InitializeComponent();
        }

       
        private void convertButton_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(inputFileBox.Text)) && !(String.IsNullOrEmpty(outputTextBox.Text)))
            {
                string fileName = inputFileBox.Text;

                DirectoryInfo di = new DirectoryInfo(fileName);
                string fileType = comboBoxChoice();

                string outputFile = outputTextBox.Text + "\\" + di.Name.Substring(0, di.Name.Length - 3) + fileType.ToLower();
                image.Save(outputFile, System.Drawing.Imaging.ImageFormat.Png);
                MessageBox.Show("Success!");
                Close();
            }
            else
            {
                MessageBox.Show("One or more fields have been left blank.");
            }
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

                try
                {
                    image = Image.FromFile(inputFileBox.Text);
                }
                catch
                {
                    
                    MessageBox.Show("Sorry, this converter does not support the file format you are trying to use.");
                    inputFileBox.Clear();
                    
                }
                
                displayBox.Image = image;
            }
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


        private string comboBoxChoice()
        {
            string type = formatMenu.Text;
            return type;
        }


    }
}
