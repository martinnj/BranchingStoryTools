﻿/* Main form for the XML based BST reader. Something :)
 * 
 * Copyright (C) 2014  Martin Jørgensen, http://flanker.dk
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License along
 * with this program; if not, write to the Free Software Foundation, Inc.,
 * 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BSTParser;

namespace BranchingStoryReader
{
    public partial class ReaderMainForm : Form
    {
        #region "Variables/properties"
        /// <summary>
        /// Holds the currently loaded story.
        /// </summary>
        private Story _story;

        /// <summary>
        /// Currently loaded branch, used for redrawing a page on variable change.
        /// </summary>
        private Branch _branch;

        /// <summary>
        /// Open file dialog used for selecting XML files.
        /// </summary>
        private readonly OpenFileDialog _filedialog;

        /// <summary>
        /// Variable to hold the dialog that edits variables.
        /// </summary>
        private VariableDialog _variableDialog;

        /// <summary>
        /// Variable to hold the imageviewer.
        /// </summary>
        private PictureViewer _pictureViewer;

        #endregion
        public ReaderMainForm()
        {
            InitializeComponent();
            _filedialog = new OpenFileDialog
            {
                DefaultExt = ".xml",
                CheckFileExists = true,
                SupportMultiDottedExtensions = true,
                Title = @"Select XML file to open",
                InitialDirectory = Application.StartupPath
            };
        }

        #region "Helper methods"

        /// <summary>
        /// Draws the branch on the form, spawns images and choices etc.
        /// </summary>
        /// <param name="branch">The branch to draw on the form.</param>
        public void DrawBranch(Branch branch)
        {
            // First reset the controls.
            flowLayoutPanel1.Controls.Clear();
            richTextBox1.Clear();

            // Read text and place variables
            var ltext = branch.Text;
            foreach (var key in _story.Vars.Keys)
            {
                ltext = ltext.Replace(string.Format("%{0}", key), (string) _story.Vars[key]);
            }
            richTextBox1.Text = ltext;

            // Spawn Choices
            foreach (var c in branch.Choices)
            {
                var c2 = c;
                foreach (var key in _story.Vars.Keys)
                {
                    c2 = new Tuple<string, string>(c2.Item1.Replace(string.Format("%{0}", key), (string)_story.Vars[key]), c2.Item2);
                }
                var b = new Button {Text = c2.Item1, Name = c2.Item2, AutoSize = true};
                b.Click += MakeChoice;
                flowLayoutPanel1.Controls.Add(b);
            }

            // Spawn image viewer
            // Replace variables in descriptions.
            var imgs = new List<Tuple<string, string>>();
            foreach (var id in branch.Images)
            {
                var t = (Tuple<string, string>) _story.Images[id];
                foreach (var key in _story.Vars.Keys)
                {
                    t = new Tuple<string, string>(t.Item1, t.Item2.Replace(string.Format("%{0}", key), (string)_story.Vars[key]));
                }
                imgs.Add(t);
            }

            // Get the images to the form.
            var loca = new System.Drawing.Point();
            var size = new System.Drawing.Size(400,400);
            if (_pictureViewer != null)
            {
                loca = _pictureViewer.Location;
                size = _pictureViewer.Size;
                _pictureViewer.Close();
            }
            _pictureViewer = new PictureViewer(imgs, _story.StoryPath)
            {
                StartPosition = FormStartPosition.Manual,
                Location = loca,
                Size = size
            };
            _pictureViewer.Show();
        }

        #endregion

        #region "UI events and similar"
        /// <summary>
        /// Handles the event that a choice button was clicked.
        /// </summary>
        /// <param name="sender">The button that triggered the event.</param>
        /// <param name="e">Parameters??</param>
        void MakeChoice(Object sender, EventArgs e)
        {
            var b = (Button)sender;
            var id = b.Name;
            var branch = (Branch)_story.Branches[id];
            _branch = branch;
            DrawBranch(_branch);
        } 
        private void loadNewXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If the dialog didn't end with ok/open, just jump out and do nothing.
            if (_filedialog.ShowDialog() != DialogResult.OK) return;

            // If a file was chosen, parse the story and append the path.
            _story = Parser.LoadStory(_filedialog.FileName);
            _story.StoryPath = _filedialog.FileName;
            startOverToolStripMenuItem.Enabled = true;
            respawnImageWindowToolStripMenuItem.Enabled = true;
            changeVariablesToolStripMenuItem.Enabled = true;
            _branch = _story.Beginning;
            DrawBranch(_branch);
        }


        private void startOverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _branch = _story.Beginning;
            DrawBranch(_branch);
        }


        private void respawnImageWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Get the images to the form.
            var loca = new System.Drawing.Point();
            var size = new System.Drawing.Size(400, 400);
            if (_pictureViewer != null)
            {
                loca = _pictureViewer.Location;
                size = _pictureViewer.Size;
                _pictureViewer.Close();
            }
            // Replace variables in descriptions.
            // FIXME
            var imgs = new List<Tuple<string, string>>();
            foreach (var id in _branch.Images)
            {
                imgs.Add((Tuple<string, string>)_story.Images[id]);
            }
            _pictureViewer = new PictureViewer(imgs, _story.StoryPath)
            {
                StartPosition = FormStartPosition.Manual,
                Location = loca,
                Size = size
            };
            _pictureViewer.Show();
        }

        private void changeVariablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new dialog with our current variables.
            _variableDialog = new VariableDialog(_story.Vars);

            // If the dialog didn't end with ok/open, just jump out and do nothing.
            if (_variableDialog.ShowDialog() != DialogResult.OK) return;

            // Loop over all the variables an update the Story instance.
            _story.Vars = _variableDialog.Vars;

            // Refresh the current page
            DrawBranch(_branch);
        }
        #endregion


    }
}
