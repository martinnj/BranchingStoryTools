using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BranchingStoryReader
{
    //TODO: Use descriptions, find a way to draw them. :)
    public partial class PictureViewer : Form
    {
        /// <summary>
        /// List of image files and their desciption.
        /// </summary>
        public List<Tuple<string, string>> Images;

        public PictureViewer(List<Tuple<string, string>> imageList)
        {
            InitializeComponent();
            Images = imageList;
        }

        private void PictureBox_Load(object sender, EventArgs e)
        {
            /*foreach (var path in Images.Select(t => t.Item1))
            {
                _images.Add(new Bitmap(path));
            }*/
            PopulateFlow();
            if (Images.Count > 0) pictureBox1.Image = new Bitmap(Images[0].Item1);
        }

        private void ChangePicture(object sender, EventArgs e)
        {
            pictureBox1.Image = ((PictureBox) sender).Image;
        }

        private void PopulateFlow()
        {
            // Create little thumbnails that can be clicked.
            // The constants are there to create a slight "room" between images.
            foreach (var t in Images)
            {
                var img = new Bitmap(t.Item1);
                double factor = (flowLayoutPanel1.Height - 4.0) / img.Height;
                var pb = new PictureBox { Name = t.Item1,
                                          SizeMode = PictureBoxSizeMode.Zoom,
                                          Image = img,
                                          Size = img.Size};
                pb.Height = (int) (pb.Height * factor);
                pb.Width  = (int) (pb.Width * factor)+6;
                pb.Click += ChangePicture;
                flowLayoutPanel1.Controls.Add(pb);
            }
        }
    }
}
