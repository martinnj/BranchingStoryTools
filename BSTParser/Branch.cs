/* Class the represents a branch in the story, including text, imagepaths
 * and choices.
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

namespace BSTParser
{
    public class Branch
    {
        /// <summary>
        /// List of tuples that with the format: ("ImagePath","ImageLabel")
        /// containing all the images associated with this branch/section.
        /// </summary>
        public List<Tuple<string, string>> Images;

        /// <summary>
        /// List of tuples that with the format: ("ChoiceLabel","targetbranchID")
        /// with all the choices for this branch.
        /// </summary>
        public List<Tuple<string, string>> Choices;

        /// <summary>
        /// Text shown in this section.
        /// </summary>
        public string Text;

        /// <summary>
        /// Default constructor. Initializes lists as empty and Text as "".
        /// </summary>
        public Branch()
        {
            Images = new List<Tuple<string, string>>();
            Choices = new List<Tuple<string, string>>();
            Text = "";
        }

        /// <summary>
        /// Convinience method to add an image.
        /// </summary>
        /// <param name="imagePath">Path to the image file.</param>
        /// <param name="imageLabel">Label/description of the image.</param>
        public void AddImage(string imagePath, string imageLabel)
        {
            Images.Add(new Tuple<string, string>(imagePath,imageLabel));
            return;
        }

        /// <summary>
        /// Convenience method to add a choice.
        /// </summary>
        /// <param name="choiceLabel">Label for the choice.</param>
        /// <param name="targetBranchId">The ID of the branch this choice leeds to.</param>
        public void AddChoice(string choiceLabel, string targetBranchId)
        {
            Choices.Add(new Tuple<string, string>(choiceLabel, targetBranchId));
            return;
        }
    }
}
