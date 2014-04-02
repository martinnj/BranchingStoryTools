using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace BranchingStoryReader
{
    public partial class PictureViewer : Form
    {
        /// <summary>
        /// List of image files and their desciption.
        /// </summary>
        public List<Tuple<string, string>> Images;

        public string PrefixPath;

        public PictureViewer(List<Tuple<string, string>> imageList, string storyPath)
        {
            InitializeComponent();
            Images = imageList;
            PrefixPath = Path.GetDirectoryName(storyPath);
        }

        private void PictureBox_Load(object sender, EventArgs e)
        {
            PopulateFlow();
            if (Images.Count <= 0) return;
            pictureBox1.Image = new Bitmap(PrefixPath + "\\" + Images[0].Item1);
            label1.Text = Images[0].Item2;
        }

        private void ChangePicture(object sender, EventArgs e)
        {
            var pb = (PictureBox) sender;
            pictureBox1.Image = pb.Image;
            var t = Images.Find(i => i.Item1 == pb.Name);
            label1.Text = t.Item2;
        }

        private void PopulateFlow()
        {
            // Create little thumbnails that can be clicked.
            // The constants are there to create a slight "room" between images.
            foreach (var t in Images)
            {
                var img = new Bitmap(PrefixPath + "\\" + t.Item1);
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
