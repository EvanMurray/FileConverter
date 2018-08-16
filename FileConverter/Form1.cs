using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
            formatMenu.SelectedIndex = 0;
        }

       
        private void convertButton_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(inputFileBox.Text)) && !(String.IsNullOrEmpty(outputTextBox.Text)))
            {
                string fileName = inputFileBox.Text;

                DirectoryInfo di = new DirectoryInfo(fileName);
                string fileType = comboBoxChoice().ToLower();

                string outputFile = outputTextBox.Text + "\\" + di.Name.Substring(0, di.Name.Length - 3) + fileType;
                image.Save(outputFile, getImageFormat(fileType));
                DialogResult result = MessageBox.Show("Success! Did you want to convert another image?", "Conversion Successful", MessageBoxButtons.YesNo);
                resultChoice(result);
                
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

        private ImageFormat getImageFormat(string type)
        {
            switch (type)
            {
                case "png":
                    return ImageFormat.Png;
                case "jpg":
                    return ImageFormat.Jpeg;
                case "bmp":
                    return ImageFormat.Bmp;
                default:
                    MessageBox.Show("Im sorry, but that image type is not yet supported.");
                    break;
            }
            return null;
            
        }

        private void resultChoice(DialogResult result)
        {
            if (result == DialogResult.Yes)
            {
                inputFileBox.Text = "";
                outputTextBox.Text = "";
                displayBox.Image = null;

            }
            else if (result == DialogResult.No)
            {
                Close();
            }
        }


    }
}
