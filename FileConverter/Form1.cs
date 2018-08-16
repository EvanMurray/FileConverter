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
        //initializes an empty image object for storing the users image 
        Image image;
        public Form1()
        {
            InitializeComponent();
            formatMenu.SelectedIndex = 0;
        }

        //button used to convert your selected image 
        private void convertButton_Click(object sender, EventArgs e)
        {
            //checks to ensure textboxes are not left blank
            if (!(String.IsNullOrEmpty(inputFileBox.Text)) && !(String.IsNullOrEmpty(outputTextBox.Text)))
            {
                //obtains the file name and uses DirectoryInfo to give access to just the file name and not the entire path
                string fileName = inputFileBox.Text;
                DirectoryInfo di = new DirectoryInfo(fileName);

                string fileType = comboBoxChoice().ToLower();

                //Saves the image based on the combo box choice using the Image class
                string outputFile = outputTextBox.Text + @"\" + di.Name.Substring(0, di.Name.Length - 3) + fileType;
                image.Save(outputFile, getImageFormat(fileType));

                //displays a success message and prompts the user if they wish to continue
                DialogResult result = MessageBox.Show("Success! Did you want to convert another image?", "Conversion Successful", MessageBoxButtons.YesNo);
                resultChoice(result);
                
            }
            else
            {
                MessageBox.Show("One or more fields have been left blank.");
            }
        }

        //button to choose the image the user wishes to convert
        private void browseButton_Click(object sender, EventArgs e)
        {
            //allows the user to choose their file using the File Dialog
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Please choose a file";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                inputFileBox.Text = fdlg.FileName;

                //tries to save in your file as an image, but catches if the file type is incompatible with the Image class
                try
                {
                    image = Image.FromFile(inputFileBox.Text);
                }
                catch
                {
                    
                    MessageBox.Show("Sorry, this converter does not support the file format you are trying to use.");
                    inputFileBox.Clear();
                    
                }
                //sets the image to the picture box
                displayBox.Image = image;
            }
        }

        //button to select the folder to where the newly converted file will be saved
        private void outputButton_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = true;
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                outputTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        //Stores the value of the users choice in the combo box used for file type selection
        private string comboBoxChoice()
        {
            string type = formatMenu.Text;
            return type;
        }

        //gets the image format that the user picked to correctly save the new file
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

        //function for the choice made in the success messagebox 
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
