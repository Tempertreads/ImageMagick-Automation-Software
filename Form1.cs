
 /***************************************************
 * Name: IMGMagicks                                 *
 * Function: Integration between Imagemagick and C# *
 * Written By Michael Osborne                       *
 * Ver 1.0                                          *
 ***************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IMGMagicks
{
    public partial class Form1 : Form
    {
        int HeightV= 0;
        int WidthH= 0;
        int imgnumber = 0;
        int Cropped = 0;
        string Destination;
        string IMGPath;
        string imagnumber;
        string Filepath;
        

        public Form1()
        {
            InitializeComponent();
            // Enable drag-and-drop operations and 
            // add handlers for DragEnter and DragDrop.
            this.AllowDrop = true;
            this.DragDrop += new DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new DragEventHandler(this.Form1_DragEnter);
        }
//Drag Drop for Picturebox
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            // Handle FileDrop data.
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                pictureBox1.Image = Image.FromFile(files[0]);
            }

            // Handle Bitmap data.
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
            //Sets Dropped Image to picturebox image
                pictureBox1.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
                
            }

            //Displays Width and Height in pixels
            ImgWidthBox.Text = pictureBox1.Image.Width.ToString();
            ImgHeightBox.Text = pictureBox1.Image.Height.ToString();

            HeightV = pictureBox1.Image.Height;
            WidthH = pictureBox1.Image.Width;

            
        }

        // If the data is a file or a bitmap, display the copy cursor.
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) || e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

//Crop Image
        private void CropB_Click(object sender, EventArgs e)
        {
            //stops image from cropping twice
            if (Cropped == 0){
                Cropped = 1;

            //Prevent lockup when Cropping images with immediate non-white borders
            int INW = 0;

            //Sets Perameters required by CropB
            HeightV = pictureBox1.Image.Height;
            WidthH = pictureBox1.Image.Width;
            int Xaxis = (WidthH / 20)*2,Yaxis = 0, bot = 0, top = 0, left = 0, right = 0;
            Destination = " cd " + Filepath + Environment.NewLine;
            IMGPath = Filepath + "\\" + imagnumber + ".jpg";

            //Prevent Exception
            try { 
            Bitmap bitmap = (Bitmap)pictureBox1.Image;

            //Find top of image
            while (top == 0 && INW == 0)
            {                
                //Gets Pixel Color
                Color color = bitmap.GetPixel(Xaxis, Yaxis);

                //If it's not white
                if ((color.R != 255) || (color.G != 255) || (color.B != 255))
                {
                    top = Yaxis;
                    INW = 1;
                }
                else
                {
                    Yaxis++;
                }
            }

            //Find Bottom of image
            Yaxis = HeightV-1;
            Xaxis = (WidthH / 4) * 3;
            INW = 0;
            while (bot == 0 && INW == 0)
            {
                //Get Pixel Color
                Color color = bitmap.GetPixel(Xaxis, Yaxis);
                //If it's not white
                if ((color.R != 255) || (color.G != 255) || (color.B != 255))
                {
                    bot = Yaxis;
                    INW = 1;
                }
                
                else
                {
                    Yaxis--;
                }
            }

            //Find Left of image
            Yaxis = HeightV / 2;
            Xaxis = 0;
            INW = 0;
            while(left == 0 && INW == 0)
            {   //Get Pixel Color
                Color color = bitmap.GetPixel(Xaxis, Yaxis);
                //If it's not white
                if ((color.R != 255) || (color.G != 255) || (color.B != 255))
                {
                    left = Xaxis;
                    INW = 1;
                }
                else
                {
                    Xaxis++;
                }
            }

           // Find Right of image
            Xaxis = WidthH - 1;
            INW = 0;
            while (right == 0 && INW == 0)
            {   //Get Pixel Color
                Color color = bitmap.GetPixel(Xaxis, Yaxis);
                //If it's not white
                if ((color.R != 255) || (color.G != 255) || (color.B != 255))
                {
                    right = Xaxis;
                }
                else
                {
                    Xaxis--;
                }

            }
            //Outputs Dimentions for crop
            Colortxt.Text = "bot = " + bot.ToString() + ", top = " + top.ToString() + ", left = " + left.ToString() + ", right = " + right.ToString();

            
            //New variables for Imagemagicks
            String CropDistanceY= (bot-top) .ToString();
            String CropDistanceX= (right-left) .ToString();
            String OffsetX = left.ToString();
            String OffsetY = top.ToString();

            
            //Start Command Line
             Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            using (StreamWriter sw = cmd.StandardInput){


                if (sw.BaseStream.CanWrite)
                {
                    //Imagemagick function
                    sw.WriteLine(Destination + Environment.NewLine);
                    sw.WriteLine("magick convert " + imagnumber + ".jpg -crop " + CropDistanceX + "x" + CropDistanceY + "+" + OffsetX + "+" + OffsetY + " " + imagnumber + ".jpg" + Environment.NewLine);
                    
                    //For debugging
                    /* do{}while (true);*/
                }
             }
          }
            catch { Colortxt.Text = "Can't be cropped"; }
        }   
     }

//ImageNumber Manipulation
        private void ImgNumBox_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(ImgNumBox.Text, out imgnumber);
            imagnumber = imgnumber.ToString();

            //Change to image folder
            Destination = " cd "+ Filepath + Environment.NewLine;
            //Path directly to Image
            IMGPath = Filepath + "\\" + imagnumber + ".jpg";          
            //Resets Crop flag
            Cropped = 0;
        }

//Change Resolution
        private void ResizeB_Click(object sender, EventArgs e)
        {
            //Sets Perameters required by ResizeB
            Destination = " cd " + Filepath + Environment.NewLine;
            IMGPath = Filepath + "\\" + imagnumber + ".jpg";

            //Start Command Line
            Process cmd = new Process();         
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            using (StreamWriter sw = cmd.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    //Imagemagick function
                    sw.WriteLine(Destination + Environment.NewLine);
                    sw.WriteLine("magick convert " + imagnumber + ".jpg -resize " + RXAxisT.Text + "x" + RYAxisT.Text+ "! " + imagnumber + ".jpg");

                    //For debugging
                    /* do{}while (true);*/
                }
            }
        
                      
        }
//Save
        private void SaveB_Click(object sender, EventArgs e)
        {
            try {
                //Resets Crop flag
                Cropped = 0;
                //Sets Perameters required by Save
                IMGPath = Filepath + "\\" + imagnumber + ".jpg";
                //Saves
                pictureBox1.Image.Save(@IMGPath, ImageFormat.Jpeg);
                SaveTxt.Text = "Save Successful";
            }
            catch {
                //If Save didn't Work
                SaveTxt.Text = "Image Didn't Save";
            }
        }

 //Set Image Path
        private void SetImgPathB_Click(object sender, EventArgs e)
        {
            //allows filepath to be entered from the application instead of within the code
            Filepath = ImgPathBox.Text;

            //sets all perameters requiring filepath
            Destination = " cd " + Filepath + Environment.NewLine;
            IMGPath = Filepath + "\\" + imagnumber + ".jpg";           
        }


    }
}
