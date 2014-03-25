/* Class that should act as a library when parsing the BST XML files.
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


namespace BSTParser
{
    public class Parser
    {

        /// <summary>
        /// Loads a story from an XML file structured after the BST format.
        /// </summary>
        /// <param name="xmlFile">Path to the XML file.</param>
        /// <returns>A Story instance with the files content.</returns>
        public Story LoadStory(string xmlFile)
        {
            //FIXME: Actually load the XML. Please?
            return new Story();
        }
    }
}
