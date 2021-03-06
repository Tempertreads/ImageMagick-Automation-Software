# ImageMagick-Automation-Software

IMGMagicks Instructions

Summary:
IMGMagicks is designed to manipulate images to adhere to a specific format. 
It has 3 functions, Save, Crop and Resize, These Instructions will go over those functions.

**************************************************************************************************************************************

Setup:

1. Drag an Image from File Explorer into the blue box. The image should now appear in the box.

2. Paste the path for the Destination folder for the new image into the Set Image Path box. 
   Use the Format C:\Users\Mike\Images (this should be obtained by copying the image path in file explorer)
   Note:The destination path must be reachable using the cd function from the command line. (No changing drives yet :( )

3. Set the Image Number, Type a Number into the Image Number Box, That is the new name for the image

4. Click Set Path, Then Click SaveIMG, Your Image should now be Saved in the corresponding folder with the name "Image Number".jpg

!!!Repeat Steps every time you want to change an image

IMPORTANT!!!

Don't drag the saved image back into the box, this creates a handle between the application and the image, making it not editable.
Change the image number or move the image to another location to make it editable again.

**************************************************************************************************************************************

Save:

The Save function saves the image in the current state in the picturebox, to a file with the name 
"Image Number".jpg at the location specified by Set Image Path.

Steps

1. Ensure the path in Set File Path is the one you want to save to.

2. Change Image Number to the number you want to save the image as.

3. Click Set Path, then SaveIMG

Note: Clicking SaveIMG will overwrite the image in the current location with the one in the Picturebox

**************************************************************************************************************************************

Crop:

The Crop Function analyses the image in the picturebox to determine the parameters to send to the imagemagick crop function.
It then crops the image with the name specified by Image Number and Image Path.

Note: Currently Crop function is based on white space and only analyses one row of pixels per dimension, This will change in the next update

Note: Image must exist

Note: Crop only works once, save the image or change the Image Number to reset the flag

Steps

1. Click Crop, This will crop the Image specified by Image Number + Location by the 
   dimensions specified through analyzing the picturebox image

Note: Crop dimensions are shown below the Crop button

**************************************************************************************************************************************

Resize:

The Resize function changes the resolution of an image specified by Path + imagenumber

Note: Image must exist (Path + Image Number must reach an image)

Steps

1. Enter X dimension into Xaxis and Y dimension into Yaxis

2. Click Resize, The program takes the image specified by Path +"Image Number" and resizes it using the perameters Xaxis and Yaxis as guidelines.

