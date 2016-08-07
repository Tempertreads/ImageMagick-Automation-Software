namespace IMGMagicks
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImgWidthBox = new System.Windows.Forms.TextBox();
            this.WidthTxt = new System.Windows.Forms.TextBox();
            this.HeightTxt = new System.Windows.Forms.TextBox();
            this.ImgHeightBox = new System.Windows.Forms.TextBox();
            this.CropB = new System.Windows.Forms.Button();
            this.Colortxt = new System.Windows.Forms.TextBox();
            this.ImgNumBox = new System.Windows.Forms.TextBox();
            this.ImgNumTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ImgInfoTxt = new System.Windows.Forms.TextBox();
            this.FunctionsTxt = new System.Windows.Forms.TextBox();
            this.CropDTxt = new System.Windows.Forms.TextBox();
            this.ResizeB = new System.Windows.Forms.Button();
            this.RXAxisT = new System.Windows.Forms.TextBox();
            this.RYAxisT = new System.Windows.Forms.TextBox();
            this.RXAxisTxt = new System.Windows.Forms.TextBox();
            this.RYAxisTxt = new System.Windows.Forms.TextBox();
            this.UnderscoreTxt = new System.Windows.Forms.TextBox();
            this.SaveB = new System.Windows.Forms.Button();
            this.SaveTxt = new System.Windows.Forms.TextBox();
            this.DragHereTxt = new System.Windows.Forms.TextBox();
            this.ImgPathBox = new System.Windows.Forms.TextBox();
            this.SetImgPathTxt = new System.Windows.Forms.TextBox();
            this.SetImgPathB = new System.Windows.Forms.Button();
            this.UnderscoreTxt2 = new System.Windows.Forms.TextBox();
            this.UnderscoreTxt3 = new System.Windows.Forms.TextBox();
            this.UnderscoreTxt4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgWidthBox
            // 
            this.ImgWidthBox.Location = new System.Drawing.Point(43, 55);
            this.ImgWidthBox.Name = "ImgWidthBox";
            this.ImgWidthBox.ReadOnly = true;
            this.ImgWidthBox.Size = new System.Drawing.Size(100, 20);
            this.ImgWidthBox.TabIndex = 1;
            // 
            // WidthTxt
            // 
            this.WidthTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WidthTxt.Location = new System.Drawing.Point(43, 36);
            this.WidthTxt.Name = "WidthTxt";
            this.WidthTxt.ReadOnly = true;
            this.WidthTxt.Size = new System.Drawing.Size(100, 13);
            this.WidthTxt.TabIndex = 2;
            this.WidthTxt.Text = "Width";
            // 
            // HeightTxt
            // 
            this.HeightTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HeightTxt.Location = new System.Drawing.Point(43, 81);
            this.HeightTxt.Name = "HeightTxt";
            this.HeightTxt.ReadOnly = true;
            this.HeightTxt.Size = new System.Drawing.Size(100, 13);
            this.HeightTxt.TabIndex = 4;
            this.HeightTxt.Text = "Height";
            // 
            // ImgHeightBox
            // 
            this.ImgHeightBox.Location = new System.Drawing.Point(43, 100);
            this.ImgHeightBox.Name = "ImgHeightBox";
            this.ImgHeightBox.ReadOnly = true;
            this.ImgHeightBox.Size = new System.Drawing.Size(100, 20);
            this.ImgHeightBox.TabIndex = 3;
            // 
            // CropB
            // 
            this.CropB.Location = new System.Drawing.Point(-4, 262);
            this.CropB.Name = "CropB";
            this.CropB.Size = new System.Drawing.Size(75, 23);
            this.CropB.TabIndex = 5;
            this.CropB.Text = "Crop";
            this.CropB.UseVisualStyleBackColor = true;
            this.CropB.Click += new System.EventHandler(this.CropB_Click);
            // 
            // Colortxt
            // 
            this.Colortxt.Location = new System.Drawing.Point(9, 310);
            this.Colortxt.Name = "Colortxt";
            this.Colortxt.ReadOnly = true;
            this.Colortxt.Size = new System.Drawing.Size(193, 20);
            this.Colortxt.TabIndex = 6;
            // 
            // ImgNumBox
            // 
            this.ImgNumBox.Location = new System.Drawing.Point(224, 29);
            this.ImgNumBox.Name = "ImgNumBox";
            this.ImgNumBox.Size = new System.Drawing.Size(100, 20);
            this.ImgNumBox.TabIndex = 7;
            this.ImgNumBox.Text = "Enter Number";
            this.ImgNumBox.TextChanged += new System.EventHandler(this.ImgNumBox_TextChanged);
            // 
            // ImgNumTxt
            // 
            this.ImgNumTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ImgNumTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImgNumTxt.Location = new System.Drawing.Point(224, 10);
            this.ImgNumTxt.Name = "ImgNumTxt";
            this.ImgNumTxt.ReadOnly = true;
            this.ImgNumTxt.Size = new System.Drawing.Size(100, 13);
            this.ImgNumTxt.TabIndex = 8;
            this.ImgNumTxt.Text = "Image Number";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(224, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(751, 383);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ImgInfoTxt
            // 
            this.ImgInfoTxt.BackColor = System.Drawing.SystemColors.Control;
            this.ImgInfoTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ImgInfoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImgInfoTxt.Location = new System.Drawing.Point(43, 12);
            this.ImgInfoTxt.Name = "ImgInfoTxt";
            this.ImgInfoTxt.Size = new System.Drawing.Size(100, 13);
            this.ImgInfoTxt.TabIndex = 9;
            this.ImgInfoTxt.Text = "Image Information";
            // 
            // FunctionsTxt
            // 
            this.FunctionsTxt.BackColor = System.Drawing.SystemColors.Control;
            this.FunctionsTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FunctionsTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FunctionsTxt.Location = new System.Drawing.Point(9, 172);
            this.FunctionsTxt.Name = "FunctionsTxt";
            this.FunctionsTxt.Size = new System.Drawing.Size(100, 13);
            this.FunctionsTxt.TabIndex = 10;
            this.FunctionsTxt.Text = "Functions";
            // 
            // CropDTxt
            // 
            this.CropDTxt.BackColor = System.Drawing.SystemColors.Control;
            this.CropDTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CropDTxt.Location = new System.Drawing.Point(9, 291);
            this.CropDTxt.Name = "CropDTxt";
            this.CropDTxt.Size = new System.Drawing.Size(100, 13);
            this.CropDTxt.TabIndex = 11;
            this.CropDTxt.Text = "Crop Dimensions FYI";
            // 
            // ResizeB
            // 
            this.ResizeB.Location = new System.Drawing.Point(-4, 345);
            this.ResizeB.Name = "ResizeB";
            this.ResizeB.Size = new System.Drawing.Size(75, 23);
            this.ResizeB.TabIndex = 12;
            this.ResizeB.Text = "Resize";
            this.ResizeB.UseVisualStyleBackColor = true;
            this.ResizeB.Click += new System.EventHandler(this.ResizeB_Click);
            // 
            // RXAxisT
            // 
            this.RXAxisT.Location = new System.Drawing.Point(50, 371);
            this.RXAxisT.Name = "RXAxisT";
            this.RXAxisT.Size = new System.Drawing.Size(93, 20);
            this.RXAxisT.TabIndex = 13;
            this.RXAxisT.Text = "Enter X Resolution";
            // 
            // RYAxisT
            // 
            this.RYAxisT.Location = new System.Drawing.Point(50, 397);
            this.RYAxisT.Name = "RYAxisT";
            this.RYAxisT.Size = new System.Drawing.Size(93, 20);
            this.RYAxisT.TabIndex = 14;
            this.RYAxisT.Text = "Enter Y Resolution";
            // 
            // RXAxisTxt
            // 
            this.RXAxisTxt.BackColor = System.Drawing.SystemColors.Control;
            this.RXAxisTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RXAxisTxt.Location = new System.Drawing.Point(9, 374);
            this.RXAxisTxt.Name = "RXAxisTxt";
            this.RXAxisTxt.Size = new System.Drawing.Size(35, 13);
            this.RXAxisTxt.TabIndex = 15;
            this.RXAxisTxt.Text = "XAxis";
            // 
            // RYAxisTxt
            // 
            this.RYAxisTxt.BackColor = System.Drawing.SystemColors.Control;
            this.RYAxisTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RYAxisTxt.Location = new System.Drawing.Point(9, 400);
            this.RYAxisTxt.Name = "RYAxisTxt";
            this.RYAxisTxt.Size = new System.Drawing.Size(37, 13);
            this.RYAxisTxt.TabIndex = 16;
            this.RYAxisTxt.Text = "YAxis";
            // 
            // UnderscoreTxt
            // 
            this.UnderscoreTxt.BackColor = System.Drawing.SystemColors.Control;
            this.UnderscoreTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UnderscoreTxt.Location = new System.Drawing.Point(-4, 326);
            this.UnderscoreTxt.Name = "UnderscoreTxt";
            this.UnderscoreTxt.Size = new System.Drawing.Size(222, 13);
            this.UnderscoreTxt.TabIndex = 17;
            this.UnderscoreTxt.Text = "_____________________________________";
            // 
            // SaveB
            // 
            this.SaveB.Location = new System.Drawing.Point(-4, 215);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(75, 23);
            this.SaveB.TabIndex = 18;
            this.SaveB.Text = "SaveIMG";
            this.SaveB.UseVisualStyleBackColor = true;
            this.SaveB.Click += new System.EventHandler(this.SaveB_Click);
            // 
            // SaveTxt
            // 
            this.SaveTxt.BackColor = System.Drawing.SystemColors.Control;
            this.SaveTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SaveTxt.Location = new System.Drawing.Point(77, 220);
            this.SaveTxt.Name = "SaveTxt";
            this.SaveTxt.ReadOnly = true;
            this.SaveTxt.Size = new System.Drawing.Size(141, 13);
            this.SaveTxt.TabIndex = 19;
            // 
            // DragHereTxt
            // 
            this.DragHereTxt.BackColor = System.Drawing.SystemColors.Control;
            this.DragHereTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DragHereTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DragHereTxt.Location = new System.Drawing.Point(439, 48);
            this.DragHereTxt.Name = "DragHereTxt";
            this.DragHereTxt.Size = new System.Drawing.Size(318, 28);
            this.DragHereTxt.TabIndex = 20;
            this.DragHereTxt.Text = "Drag Image To Space Below\r\n";
            // 
            // ImgPathBox
            // 
            this.ImgPathBox.Location = new System.Drawing.Point(393, 28);
            this.ImgPathBox.Name = "ImgPathBox";
            this.ImgPathBox.Size = new System.Drawing.Size(216, 20);
            this.ImgPathBox.TabIndex = 21;
            this.ImgPathBox.Text = "Enter Image Destination Path";
            // 
            // SetImgPathTxt
            // 
            this.SetImgPathTxt.BackColor = System.Drawing.SystemColors.Control;
            this.SetImgPathTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SetImgPathTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetImgPathTxt.Location = new System.Drawing.Point(393, 10);
            this.SetImgPathTxt.Name = "SetImgPathTxt";
            this.SetImgPathTxt.Size = new System.Drawing.Size(100, 13);
            this.SetImgPathTxt.TabIndex = 22;
            this.SetImgPathTxt.Text = "Set Image Path";
            // 
            // SetImgPathB
            // 
            this.SetImgPathB.Location = new System.Drawing.Point(615, 25);
            this.SetImgPathB.Name = "SetImgPathB";
            this.SetImgPathB.Size = new System.Drawing.Size(75, 23);
            this.SetImgPathB.TabIndex = 23;
            this.SetImgPathB.Text = "Set Path";
            this.SetImgPathB.UseVisualStyleBackColor = true;
            this.SetImgPathB.Click += new System.EventHandler(this.SetImgPathB_Click);
            // 
            // UnderscoreTxt2
            // 
            this.UnderscoreTxt2.BackColor = System.Drawing.SystemColors.Control;
            this.UnderscoreTxt2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UnderscoreTxt2.Location = new System.Drawing.Point(-4, 423);
            this.UnderscoreTxt2.Name = "UnderscoreTxt2";
            this.UnderscoreTxt2.Size = new System.Drawing.Size(222, 13);
            this.UnderscoreTxt2.TabIndex = 24;
            this.UnderscoreTxt2.Text = "_____________________________________";
            // 
            // UnderscoreTxt3
            // 
            this.UnderscoreTxt3.BackColor = System.Drawing.SystemColors.Control;
            this.UnderscoreTxt3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UnderscoreTxt3.Location = new System.Drawing.Point(-4, 239);
            this.UnderscoreTxt3.Name = "UnderscoreTxt3";
            this.UnderscoreTxt3.Size = new System.Drawing.Size(222, 13);
            this.UnderscoreTxt3.TabIndex = 25;
            this.UnderscoreTxt3.Text = "_____________________________________";
            // 
            // UnderscoreTxt4
            // 
            this.UnderscoreTxt4.BackColor = System.Drawing.SystemColors.Control;
            this.UnderscoreTxt4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UnderscoreTxt4.Location = new System.Drawing.Point(-4, 191);
            this.UnderscoreTxt4.Name = "UnderscoreTxt4";
            this.UnderscoreTxt4.Size = new System.Drawing.Size(222, 13);
            this.UnderscoreTxt4.TabIndex = 26;
            this.UnderscoreTxt4.Text = "_____________________________________";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 482);
            this.Controls.Add(this.UnderscoreTxt4);
            this.Controls.Add(this.UnderscoreTxt3);
            this.Controls.Add(this.UnderscoreTxt2);
            this.Controls.Add(this.SetImgPathB);
            this.Controls.Add(this.SetImgPathTxt);
            this.Controls.Add(this.ImgPathBox);
            this.Controls.Add(this.SaveTxt);
            this.Controls.Add(this.SaveB);
            this.Controls.Add(this.RYAxisTxt);
            this.Controls.Add(this.RXAxisTxt);
            this.Controls.Add(this.RYAxisT);
            this.Controls.Add(this.RXAxisT);
            this.Controls.Add(this.ResizeB);
            this.Controls.Add(this.CropDTxt);
            this.Controls.Add(this.FunctionsTxt);
            this.Controls.Add(this.ImgInfoTxt);
            this.Controls.Add(this.ImgNumTxt);
            this.Controls.Add(this.ImgNumBox);
            this.Controls.Add(this.Colortxt);
            this.Controls.Add(this.CropB);
            this.Controls.Add(this.HeightTxt);
            this.Controls.Add(this.ImgHeightBox);
            this.Controls.Add(this.WidthTxt);
            this.Controls.Add(this.ImgWidthBox);
            this.Controls.Add(this.UnderscoreTxt);
            this.Controls.Add(this.DragHereTxt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ImgWidthBox;
        private System.Windows.Forms.TextBox WidthTxt;
        private System.Windows.Forms.TextBox HeightTxt;
        private System.Windows.Forms.TextBox ImgHeightBox;
        private System.Windows.Forms.Button CropB;
        private System.Windows.Forms.TextBox Colortxt;
        private System.Windows.Forms.TextBox ImgNumBox;
        private System.Windows.Forms.TextBox ImgNumTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ImgInfoTxt;
        private System.Windows.Forms.TextBox FunctionsTxt;
        private System.Windows.Forms.TextBox CropDTxt;
        private System.Windows.Forms.Button ResizeB;
        private System.Windows.Forms.TextBox RXAxisT;
        private System.Windows.Forms.TextBox RYAxisT;
        private System.Windows.Forms.TextBox RXAxisTxt;
        private System.Windows.Forms.TextBox RYAxisTxt;
        private System.Windows.Forms.TextBox UnderscoreTxt;
        private System.Windows.Forms.Button SaveB;
        private System.Windows.Forms.TextBox SaveTxt;
        private System.Windows.Forms.TextBox DragHereTxt;
        private System.Windows.Forms.TextBox ImgPathBox;
        private System.Windows.Forms.TextBox SetImgPathTxt;
        private System.Windows.Forms.Button SetImgPathB;
        private System.Windows.Forms.TextBox UnderscoreTxt2;
        private System.Windows.Forms.TextBox UnderscoreTxt3;
        private System.Windows.Forms.TextBox UnderscoreTxt4;

    }
}

