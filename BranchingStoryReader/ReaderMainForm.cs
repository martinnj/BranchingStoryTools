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
using System.Windows.Forms;
using BSTParser;

namespace BranchingStoryReader
{
    public partial class ReaderMainForm : Form
    {
        /// <summary>
        /// Holds the currently loaded story.
        /// </summary>
        private Story story;

        public ReaderMainForm()
        {
            InitializeComponent();
        }

        private void loadNewXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                DefaultExt = ".xml",
                CheckFileExists = true,
                SupportMultiDottedExtensions = true,
                Title = @"Select XML file to open",
                InitialDirectory = Application.StartupPath
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                story = Parser.LoadStory(dialog.FileName);
            }
        }
    }
}
