using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D; // to convert type
using System.Drawing.Imaging; // to convert type
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertToJPG
{
    public partial class Form1 : Form
    {
        bool convertFromPNG = false;
        bool convertFromBMP = false;
        int countFile = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvertToJPG_Click(object sender, EventArgs e)
        {
            convertFromPNG = checkBoxPNG.Checked;
            convertFromBMP = checkBoxBMP.Checked;
            countFile = 0;

            if (!convertFromPNG && !convertFromBMP)
            {
                setTextWarning("Please select image type ...");                
            }
            else
            {
                string CurrentFolder = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                convertToJPG_Func(CurrentFolder);
            }            
        }

        public void convertToJPG_Func(string folder)
        {            
            foreach (string file in System.IO.Directory.GetFiles(folder))
            {
                if(convertFromPNG) convertImageType(file, ".png", ".jpg");
                if(convertFromBMP) convertImageType(file, ".bmp", ".jpg");                
            }
            setTextWarning("Convert "+ countFile +" files Complete...");
        }

        public void convertImageType(string fileSrc, string originalType, string resultType)
        {
            string extension = System.IO.Path.GetExtension(fileSrc); // get file extention 
            if (extension.ToLower() == originalType)
            {
                string name = System.IO.Path.GetFileNameWithoutExtension(fileSrc);
                string path = System.IO.Path.GetDirectoryName(fileSrc);
                Image resultImage = Image.FromFile(fileSrc);
                resultImage.Save(path + @"/" + name + resultType, System.Drawing.Imaging.ImageFormat.Jpeg);
                resultImage.Dispose();
                countFile++;
            }
        }

        public void setTextWarning (string textWarning)
        {
            labelWarning.Visible = true;
            labelWarning.Text = textWarning;
        }

        private void checkBoxPNG_CheckedChanged(object sender, EventArgs e)
        {
            labelWarning.Visible = false;
        }

        private void checkBoxBMP_CheckedChanged(object sender, EventArgs e)
        {
            labelWarning.Visible = false;
        }
    }
}
