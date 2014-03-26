/* Main form for the XML based BST reader. Something :)
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
using System.Collections;
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

            // Read text
            var ltext = branch.Text;
            foreach (var key in _story.Vars.Keys)
            {
                ltext = ltext.Replace(string.Format("%{0}", key), (string) _story.Vars[key]);
            }
            richTextBox1.Text = ltext;

            // Spawn Choices
            foreach (var c in branch.Choices)
            {
                var b = new Button {Text = c.Item1, Name = c.Item2};
                b.Click += MakeChoice;
                flowLayoutPanel1.Controls.Add(b);
            }

            //TODO: Spawn images.
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
            DrawBranch(branch);
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

            DrawBranch(_story.Beginning);
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


        private void startOverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawBranch(_story.Beginning);
        }
        #endregion

    }
}
