/* Class the represents a whole story with all branches
 * and all meta information/image paths (not the image data).
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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTParser
{
    class Story
    {
        /// <summary>
        /// Variable that holds the path where the story was loaded from.
        /// Important since image paths in the story is relative to this point.
        /// </summary>
        public string StoryPath;

        /// <summary>
        /// Hashtable that contains the different branches, keyed on their ID.
        /// </summary>
        public Hashtable Branches;
    }
}
